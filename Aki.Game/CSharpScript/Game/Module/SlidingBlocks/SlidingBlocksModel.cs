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
	// Token: 0x02004B82 RID: 19330
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class SlidingBlocksModel : ModelBase
	{
		// Token: 0x17007C43 RID: 31811
		// (get) Token: 0x0603217A RID: 205178 RVA: 0x00BA1F88 File Offset: 0x00BA0188
		public bool IsInGame
		{
			get
			{
				SlidingBlocksDefine.EGameStage gameStage = this.GameStage;
				return gameStage > SlidingBlocksDefine.EGameStage.None && gameStage <= SlidingBlocksDefine.EGameStage.Settlement;
			}
		}

		// Token: 0x17007C44 RID: 31812
		// (get) Token: 0x0603217B RID: 205179 RVA: 0x00BA1FA9 File Offset: 0x00BA01A9
		public bool IsGameRunning
		{
			get
			{
				return this.GameStage == SlidingBlocksDefine.EGameStage.GameRunning;
			}
		}

		// Token: 0x0603217C RID: 205180 RVA: 0x00BA1FB4 File Offset: 0x00BA01B4
		protected override bool OnLeaveLevel()
		{
			EffectSystem.Instance.StopEffectById(this.GameData.AreaLoopEffectHandle, "SlidingBlocksModel.OnLeaveLevel", true, null);
			this.GameData.AreaLoopEffectHandle = 0;
			return true;
		}

		// Token: 0x0603217D RID: 205181 RVA: 0x00BA1FF3 File Offset: 0x00BA01F3
		protected override bool OnClear()
		{
			this.BoxMeshCache = null;
			return true;
		}

		// Token: 0x0603217E RID: 205182 RVA: 0x00BA2000 File Offset: 0x00BA0200
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

		// Token: 0x0603217F RID: 205183 RVA: 0x00BA205B File Offset: 0x00BA025B
		public void OnGameOver()
		{
			this.SwitchStage(SlidingBlocksDefine.EGameStage.None, false);
			this.GameData.Reset();
			SlidingBlocksGlobal.ClearSettingData();
		}

		// Token: 0x06032180 RID: 205184 RVA: 0x00BA2078 File Offset: 0x00BA0278
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

		// Token: 0x06032181 RID: 205185 RVA: 0x00BA2170 File Offset: 0x00BA0370
		public void EnterNextStage()
		{
			this.GameStage++;
			EventSystem.Instance.Emit(EEventName.SlidingBlockGameStageChanged);
		}

		// Token: 0x06032182 RID: 205186 RVA: 0x00BA2190 File Offset: 0x00BA0390
		public void SwitchStage(SlidingBlocksDefine.EGameStage stage, bool bFireEvent = true)
		{
			this.GameStage = stage;
			if (bFireEvent)
			{
				EventSystem.Instance.Emit(EEventName.SlidingBlockGameStageChanged);
			}
		}

		// Token: 0x06032183 RID: 205187 RVA: 0x00BA21AC File Offset: 0x00BA03AC
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

		// Token: 0x06032184 RID: 205188 RVA: 0x00BA21DC File Offset: 0x00BA03DC
		public bool CheckGridOccupied(double x, double y)
		{
			TetrisGridColumn tetrisGridColumn;
			return this.GameData.GridColumns.TryGetValue(x, out tetrisGridColumn) && tetrisGridColumn.CheckOccupied(y);
		}

		// Token: 0x06032185 RID: 205189 RVA: 0x00BA2208 File Offset: 0x00BA0408
		public double FindUnoccupiedGrid(double x, double y)
		{
			TetrisGridColumn tetrisGridColumn;
			if (!this.GameData.GridColumns.TryGetValue(x, out tetrisGridColumn))
			{
				return this.GameData.GridMaxY;
			}
			return tetrisGridColumn.FindUnoccupiedGrid(y);
		}

		// Token: 0x06032186 RID: 205190 RVA: 0x00BA2240 File Offset: 0x00BA0440
		public bool CheckGridOccupiedUnderPlayer()
		{
			Vector2D playerCoord = this.GameData.PlayerCoord;
			return this.CheckGridOccupiedUnderCoord(playerCoord.X, playerCoord.Y);
		}

		// Token: 0x06032187 RID: 205191 RVA: 0x00BA226B File Offset: 0x00BA046B
		public bool CheckGridOccupiedUnderCoord(double x, double y)
		{
			return y.Equals(this.GameData.GridMaxY) || this.CheckGridOccupied(x, y + 1.0);
		}

		// Token: 0x06032188 RID: 205192 RVA: 0x00BA2298 File Offset: 0x00BA0498
		public bool CheckBeyondGrid(double x, double y)
		{
			double gridMinX = this.GameData.GridMinX;
			double gridMaxX = this.GameData.GridMaxX;
			double gridMinY = this.GameData.GridMinY;
			double gridMaxY = this.GameData.GridMaxY;
			return x < gridMinX || x > gridMaxX || y < gridMinY || y > gridMaxY;
		}

		// Token: 0x06032189 RID: 205193 RVA: 0x00BA22E7 File Offset: 0x00BA04E7
		public void RegisterMinoTick(Mino mino)
		{
			if (!this.GameData.TickMinos.Contains(mino))
			{
				this.GameData.TickMinos.Add(mino);
			}
		}

		// Token: 0x0603218A RID: 205194 RVA: 0x00BA230D File Offset: 0x00BA050D
		public void UnRegisterMinoTick(Mino mino)
		{
			this.GameData.TickMinos.Remove(mino);
		}

		// Token: 0x17007C45 RID: 31813
		// (get) Token: 0x0603218B RID: 205195 RVA: 0x00BA2321 File Offset: 0x00BA0521
		public static SlidingBlocksModel Instance
		{
			get
			{
				return SlidingBlocksModel._Instance;
			}
		}

		// Token: 0x0603218C RID: 205196 RVA: 0x00BA2328 File Offset: 0x00BA0528
		public static SlidingBlocksModel GetOrCreateInstance()
		{
			if (SlidingBlocksModel._Instance == null)
			{
				SlidingBlocksModel.CreateInstance();
			}
			return SlidingBlocksModel._Instance;
		}

		// Token: 0x0603218D RID: 205197 RVA: 0x00BA233C File Offset: 0x00BA053C
		public static bool CreateInstance()
		{
			if (SlidingBlocksModel._Instance != null)
			{
				return true;
			}
			SlidingBlocksModel._Instance = new SlidingBlocksModel();
			return true;
		}

		// Token: 0x0603218E RID: 205198 RVA: 0x00BA2352 File Offset: 0x00BA0552
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603218F RID: 205199 RVA: 0x00BA2354 File Offset: 0x00BA0554
		public static void ResetStaticDefaultValue()
		{
			SlidingBlocksModel._Instance = null;
		}

		// Token: 0x06032190 RID: 205200 RVA: 0x00BA235C File Offset: 0x00BA055C
		static SlidingBlocksModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SlidingBlocksModel.CreateStaticDefaultValue), new Action(SlidingBlocksModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401AB15 RID: 109333
		public readonly bool EnableDebug;

		// Token: 0x0401AB16 RID: 109334
		[Nullable(2)]
		public UStaticMesh BoxMeshCache;

		// Token: 0x0401AB17 RID: 109335
		public readonly SlidingBlocksGameData GameData = new SlidingBlocksGameData();

		// Token: 0x0401AB18 RID: 109336
		public SlidingBlocksDefine.EGameStage GameStage;

		// Token: 0x0401AB19 RID: 109337
		[Nullable(2)]
		private static SlidingBlocksModel _Instance;
	}
}
