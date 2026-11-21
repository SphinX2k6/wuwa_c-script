using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Effect;
using CSharpScript.Game.LevelGamePlay;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SlidingBlocks
{
	// Token: 0x02003B2C RID: 15148
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class SlidingBlocksModel : ModelBase
	{
		// Token: 0x17004FED RID: 20461
		// (get) Token: 0x06026F0B RID: 159499 RVA: 0x00AE6130 File Offset: 0x00AE4330
		public bool IsInGame
		{
			get
			{
				SlidingBlocksDefine.EGameStage gameStage = this.GameStage;
				return gameStage > SlidingBlocksDefine.EGameStage.None && gameStage <= SlidingBlocksDefine.EGameStage.Settlement;
			}
		}

		// Token: 0x17004FEE RID: 20462
		// (get) Token: 0x06026F0C RID: 159500 RVA: 0x00AE6151 File Offset: 0x00AE4351
		public bool IsGameRunning
		{
			get
			{
				return this.GameStage == SlidingBlocksDefine.EGameStage.GameRunning;
			}
		}

		// Token: 0x06026F0D RID: 159501 RVA: 0x00AE615C File Offset: 0x00AE435C
		protected override bool OnLeaveLevel()
		{
			EffectSystem.Instance.StopEffectById(this.GameData.AreaLoopEffectHandle, "SlidingBlocksModel.OnLeaveLevel", true, null);
			this.GameData.AreaLoopEffectHandle = 0;
			return true;
		}

		// Token: 0x06026F0E RID: 159502 RVA: 0x00AE619B File Offset: 0x00AE439B
		protected override bool OnClear()
		{
			this.BoxMeshCache = null;
			return true;
		}

		// Token: 0x06026F0F RID: 159503 RVA: 0x00AE61A8 File Offset: 0x00AE43A8
		[return: Nullable(0)]
		public UniTask<bool> InitGameData(IFinishTetris config, Transform originTransform, GeneralLogicTreeContext context)
		{
			SlidingBlocksModel.<InitGameData>d__10 <InitGameData>d__;
			<InitGameData>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<InitGameData>d__.<>4__this = this;
			<InitGameData>d__.config = config;
			<InitGameData>d__.originTransform = originTransform;
			<InitGameData>d__.context = context;
			<InitGameData>d__.<>1__state = -1;
			<InitGameData>d__.<>t__builder.Start<SlidingBlocksModel.<InitGameData>d__10>(ref <InitGameData>d__);
			return <InitGameData>d__.<>t__builder.Task;
		}

		// Token: 0x06026F10 RID: 159504 RVA: 0x00AE6203 File Offset: 0x00AE4403
		public void OnGameOver()
		{
			this.SwitchStage(SlidingBlocksDefine.EGameStage.None, false);
			this.GameData.Reset();
			SlidingBlocksGlobal.ClearSettingData();
		}

		// Token: 0x06026F11 RID: 159505 RVA: 0x00AE6220 File Offset: 0x00AE4420
		public unsafe bool AddMino(string styleName, double x, double y, SlidingBlocksDefine.EAddMinoReason reason)
		{
			AActor aactor = SlidingBlocksUtil.CreateDynamicCube(styleName, x, y, this.GameData.OriginTransform, this.BoxMeshCache);
			if (aactor == null || !aactor.IsValid())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SlidingBlocks;
				ELogAuthor author = ELogAuthor.YSQ;
				string message = "SlidingBlocksModel.AddMino：创建cubeActor失败";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("styleName", styleName);
				ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
				string item = "coord";
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 2);
				defaultInterpolatedStringHandler.AppendLiteral("(");
				defaultInterpolatedStringHandler.AppendFormatted<double>(x);
				defaultInterpolatedStringHandler.AppendLiteral(",");
				defaultInterpolatedStringHandler.AppendFormatted<double>(y);
				defaultInterpolatedStringHandler.AppendLiteral(")");
				ptr = new ValueTuple<string, object>(item, defaultInterpolatedStringHandler.ToStringAndClear());
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return false;
			}
			Mino minoData = new Mino(styleName, Vector2D.Create(x, y), aactor, SlidingBlocksDefine.EMinoParent.Board);
			this.GameData.AddMinoData(x, y, minoData, reason);
			return true;
		}

		// Token: 0x06026F12 RID: 159506 RVA: 0x00AE6318 File Offset: 0x00AE4518
		public void EnterNextStage()
		{
			this.GameStage++;
			EventSystem.Instance.Emit(EEventName.SlidingBlockGameStageChanged);
		}

		// Token: 0x06026F13 RID: 159507 RVA: 0x00AE6338 File Offset: 0x00AE4538
		public void SwitchStage(SlidingBlocksDefine.EGameStage stage, bool bFireEvent = true)
		{
			this.GameStage = stage;
			if (bFireEvent)
			{
				EventSystem.Instance.Emit(EEventName.SlidingBlockGameStageChanged);
			}
		}

		// Token: 0x06026F14 RID: 159508 RVA: 0x00AE6354 File Offset: 0x00AE4554
		[NullableContext(2)]
		public void SetCurTetromino(Tetromino tetromino)
		{
			if (tetromino != null)
			{
				this.GameData.CurTetromino = tetromino;
				this.GameData.AllTetrominoList.Add(tetromino);
				return;
			}
			this.GameData.CurTetromino = null;
		}

		// Token: 0x06026F15 RID: 159509 RVA: 0x00AE6384 File Offset: 0x00AE4584
		public bool CheckGridOccupied(double x, double y)
		{
			TetrisGridColumn tetrisGridColumn;
			return this.GameData.GridColumns.TryGetValue(x, out tetrisGridColumn) && tetrisGridColumn.CheckOccupied(y);
		}

		// Token: 0x06026F16 RID: 159510 RVA: 0x00AE63B0 File Offset: 0x00AE45B0
		public double FindUnoccupiedGrid(double x, double y)
		{
			TetrisGridColumn tetrisGridColumn;
			if (!this.GameData.GridColumns.TryGetValue(x, out tetrisGridColumn))
			{
				return this.GameData.GridMaxY;
			}
			return tetrisGridColumn.FindUnoccupiedGrid(y);
		}

		// Token: 0x06026F17 RID: 159511 RVA: 0x00AE63E8 File Offset: 0x00AE45E8
		public bool CheckGridOccupiedUnderPlayer()
		{
			Vector2D playerCoord = this.GameData.PlayerCoord;
			return this.CheckGridOccupiedUnderCoord(playerCoord.X, playerCoord.Y);
		}

		// Token: 0x06026F18 RID: 159512 RVA: 0x00AE6413 File Offset: 0x00AE4613
		public bool CheckGridOccupiedUnderCoord(double x, double y)
		{
			return y.Equals(this.GameData.GridMaxY) || this.CheckGridOccupied(x, y + 1.0);
		}

		// Token: 0x06026F19 RID: 159513 RVA: 0x00AE6440 File Offset: 0x00AE4640
		public bool CheckBeyondGrid(double x, double y)
		{
			double gridMinX = this.GameData.GridMinX;
			double gridMaxX = this.GameData.GridMaxX;
			double gridMinY = this.GameData.GridMinY;
			double gridMaxY = this.GameData.GridMaxY;
			return x < gridMinX || x > gridMaxX || y < gridMinY || y > gridMaxY;
		}

		// Token: 0x06026F1A RID: 159514 RVA: 0x00AE648F File Offset: 0x00AE468F
		public void RegisterMinoTick(Mino mino)
		{
			if (!this.GameData.TickMinos.Contains(mino))
			{
				this.GameData.TickMinos.Add(mino);
			}
		}

		// Token: 0x06026F1B RID: 159515 RVA: 0x00AE64B5 File Offset: 0x00AE46B5
		public void UnRegisterMinoTick(Mino mino)
		{
			this.GameData.TickMinos.Remove(mino);
		}

		// Token: 0x17004FEF RID: 20463
		// (get) Token: 0x06026F1C RID: 159516 RVA: 0x00AE64C9 File Offset: 0x00AE46C9
		public static SlidingBlocksModel Instance
		{
			get
			{
				return SlidingBlocksModel._Instance;
			}
		}

		// Token: 0x06026F1D RID: 159517 RVA: 0x00AE64D0 File Offset: 0x00AE46D0
		public static SlidingBlocksModel GetOrCreateInstance()
		{
			if (SlidingBlocksModel._Instance == null)
			{
				SlidingBlocksModel.CreateInstance();
			}
			return SlidingBlocksModel._Instance;
		}

		// Token: 0x06026F1E RID: 159518 RVA: 0x00AE64E4 File Offset: 0x00AE46E4
		public static bool CreateInstance()
		{
			if (SlidingBlocksModel._Instance != null)
			{
				return true;
			}
			SlidingBlocksModel._Instance = new SlidingBlocksModel();
			return true;
		}

		// Token: 0x06026F1F RID: 159519 RVA: 0x00AE64FA File Offset: 0x00AE46FA
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06026F20 RID: 159520 RVA: 0x00AE64FC File Offset: 0x00AE46FC
		public static void ResetStaticDefaultValue()
		{
			SlidingBlocksModel._Instance = null;
		}

		// Token: 0x06026F21 RID: 159521 RVA: 0x00AE6504 File Offset: 0x00AE4704
		static SlidingBlocksModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SlidingBlocksModel.CreateStaticDefaultValue), new Action(SlidingBlocksModel.ResetStaticDefaultValue));
		}

		// Token: 0x04015469 RID: 87145
		public readonly bool EnableDebug;

		// Token: 0x0401546A RID: 87146
		[Nullable(2)]
		public UStaticMesh BoxMeshCache;

		// Token: 0x0401546B RID: 87147
		public readonly SlidingBlocksGameData GameData = new SlidingBlocksGameData();

		// Token: 0x0401546C RID: 87148
		public SlidingBlocksDefine.EGameStage GameStage;

		// Token: 0x0401546D RID: 87149
		[Nullable(2)]
		private static SlidingBlocksModel _Instance;
	}
}
