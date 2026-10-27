using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SlidingBlocks
{
	// Token: 0x02004B77 RID: 19319
	[NullableContext(1)]
	[Nullable(0)]
	public class Mino : IStaticVariableResetter
	{
		// Token: 0x060320E1 RID: 205025 RVA: 0x00B9F105 File Offset: 0x00B9D305
		static Mino()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(Mino.CreateStaticDefaultValue), new Action(Mino.ResetStaticDefaultValue));
		}

		// Token: 0x17007C2E RID: 31790
		// (get) Token: 0x060320E2 RID: 205026 RVA: 0x00B9F124 File Offset: 0x00B9D324
		public string StyleName { get; }

		// Token: 0x17007C2F RID: 31791
		// (get) Token: 0x060320E3 RID: 205027 RVA: 0x00B9F12C File Offset: 0x00B9D32C
		// (set) Token: 0x060320E4 RID: 205028 RVA: 0x00B9F134 File Offset: 0x00B9D334
		public Vector2D Coord { get; set; }

		// Token: 0x17007C30 RID: 31792
		// (get) Token: 0x060320E5 RID: 205029 RVA: 0x00B9F13D File Offset: 0x00B9D33D
		// (set) Token: 0x060320E6 RID: 205030 RVA: 0x00B9F145 File Offset: 0x00B9D345
		public AActor CubeActor { get; set; }

		// Token: 0x060320E7 RID: 205031 RVA: 0x00B9F150 File Offset: 0x00B9D350
		public Mino(string styleName, Vector2D coord, AActor cubeActor, SlidingBlocksDefine.EMinoParent parent)
		{
			this.StyleName = styleName;
			this.Coord = coord;
			this.CubeActor = cubeActor;
			this.Id = Mino._minoIndex;
			Mino._minoIndex++;
		}

		// Token: 0x060320E8 RID: 205032 RVA: 0x00B9F1A8 File Offset: 0x00B9D3A8
		[NullableContext(0)]
		public UniTask<bool> TryFall(double targetY)
		{
			Mino.<TryFall>d__22 <TryFall>d__;
			<TryFall>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<TryFall>d__.<>4__this = this;
			<TryFall>d__.targetY = targetY;
			<TryFall>d__.<>1__state = -1;
			<TryFall>d__.<>t__builder.Start<Mino.<TryFall>d__22>(ref <TryFall>d__);
			return <TryFall>d__.<>t__builder.Task;
		}

		// Token: 0x060320E9 RID: 205033 RVA: 0x00B9F1F4 File Offset: 0x00B9D3F4
		private void ResetMoveData()
		{
			this.StartFallingAnchorCoord.Set(this.Coord.X, this.Coord.Y);
			float num = SlidingBlocksModel.Instance.GameData.SingleCellMoveTime();
			this.CurFallingTime = MathCommon.Clamp(this.CurFallingTime - num, 0f, num);
		}

		// Token: 0x060320EA RID: 205034 RVA: 0x00B9F24B File Offset: 0x00B9D44B
		private void RegisterTick()
		{
			SlidingBlocksModel.Instance.RegisterMinoTick(this);
		}

		// Token: 0x060320EB RID: 205035 RVA: 0x00B9F258 File Offset: 0x00B9D458
		private void UnRegisterTick()
		{
			SlidingBlocksModel.Instance.UnRegisterMinoTick(this);
		}

		// Token: 0x060320EC RID: 205036 RVA: 0x00B9F268 File Offset: 0x00B9D468
		public void OnTick(float delta)
		{
			if (this.State != Mino.EMinoState.Moving)
			{
				return;
			}
			if (this.CheckSqueezePlayer(this.StartFallingAnchorCoord.X, this.StartFallingAnchorCoord.Y + 1.0))
			{
				EventSystem.Instance.Emit(EEventName.SlidingBlockSqueezePlayer);
				return;
			}
			this.CurFallingTime += delta;
			float num = MathCommon.Clamp(this.CurFallingTime / SlidingBlocksModel.Instance.GameData.SingleCellMoveTime(), 0f, 1f);
			float num2 = MathCommon.Lerp(0f, 1f, num);
			this.Coord.Y = this.StartFallingAnchorCoord.Y + (double)num2;
			this.UpdateMinoWorldLocation();
			if (num >= 1f)
			{
				this.ResetMoveData();
				if (!this.CheckCanMove(0, 1))
				{
					this.OnMoveFinished();
				}
			}
		}

		// Token: 0x060320ED RID: 205037 RVA: 0x00B9F33C File Offset: 0x00B9D53C
		private bool CheckCanMove(int x, int y)
		{
			if (x == 0 && y == 0)
			{
				return false;
			}
			if (this.Coord.Y.Equals(this.MoveTargetY))
			{
				return false;
			}
			double x2 = this.Coord.X + (double)x;
			double y2 = this.Coord.Y + (double)y;
			return !SlidingBlocksModel.Instance.CheckBeyondGrid(x2, y2);
		}

		// Token: 0x060320EE RID: 205038 RVA: 0x00B9F39A File Offset: 0x00B9D59A
		private void OnMoveFinished()
		{
			this.State = Mino.EMinoState.Static;
			this.CurFallingTime = 0f;
			this.UnRegisterTick();
			CustomPromise<bool> fallPromise = this.FallPromise;
			if (fallPromise == null)
			{
				return;
			}
			fallPromise.SetResult(true);
		}

		// Token: 0x060320EF RID: 205039 RVA: 0x00B9F3C8 File Offset: 0x00B9D5C8
		private bool CheckSqueezePlayer(double minoNextCoordX, double minoNextCoordY)
		{
			SlidingBlocksModel instance = SlidingBlocksModel.Instance;
			if (!instance.CheckGridOccupiedUnderPlayer())
			{
				return false;
			}
			Vector2D playerCoord = instance.GameData.PlayerCoord;
			return playerCoord.X.Equals(minoNextCoordX) && playerCoord.Y.Equals(minoNextCoordY);
		}

		// Token: 0x060320F0 RID: 205040 RVA: 0x00B9F410 File Offset: 0x00B9D610
		private void UpdateMinoWorldLocation()
		{
			AActor cubeActor = this.CubeActor;
			if (cubeActor == null || !cubeActor.IsValid())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SlidingBlocks;
				ELogAuthor author = ELogAuthor.YSQ;
				string message = "更新Cube坐标失败：CubeActor不存在";
				string item = "coordinate";
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted<double>(this.Coord.X);
				defaultInterpolatedStringHandler.AppendLiteral(",");
				defaultInterpolatedStringHandler.AppendFormatted<double>(this.Coord.Y);
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, defaultInterpolatedStringHandler.ToStringAndClear());
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			Transform originTransform = SlidingBlocksModel.Instance.GameData.OriginTransform;
			SlidingBlocksUtil.GetWorldLocationByCoord(this.Coord.X, this.Coord.Y, originTransform, this.CacheVector);
			this.CubeActor.D_K2_SetActorLocation(this.CacheVector.ToUeVector(false), true, ref WorldGlobal.SweepHitResult, false);
		}

		// Token: 0x060320F1 RID: 205041 RVA: 0x00B9F4F0 File Offset: 0x00B9D6F0
		public static void CreateStaticDefaultValue()
		{
			Mino._minoIndex = 0;
		}

		// Token: 0x060320F2 RID: 205042 RVA: 0x00B9F4F8 File Offset: 0x00B9D6F8
		public static void ResetStaticDefaultValue()
		{
			Mino._minoIndex = 0;
		}

		// Token: 0x0401AAC3 RID: 109251
		private static int _minoIndex;

		// Token: 0x0401AAC4 RID: 109252
		public readonly int Id;

		// Token: 0x0401AAC5 RID: 109253
		public Mino.EMinoState State;

		// Token: 0x0401AAC6 RID: 109254
		private readonly Vector2D StartFallingAnchorCoord = Vector2D.Create();

		// Token: 0x0401AAC7 RID: 109255
		private float CurFallingTime;

		// Token: 0x0401AAC8 RID: 109256
		private double MoveTargetY;

		// Token: 0x0401AAC9 RID: 109257
		[Nullable(2)]
		private CustomPromise<bool> FallPromise;

		// Token: 0x0401AACA RID: 109258
		private readonly Vector CacheVector = Vector.Create();

		// Token: 0x0200AD51 RID: 44369
		[NullableContext(0)]
		public enum EMinoState
		{
			// Token: 0x04034A61 RID: 215649
			Static,
			// Token: 0x04034A62 RID: 215650
			Moving
		}
	}
}
