using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SlidingBlocks
{
	// Token: 0x02003B21 RID: 15137
	[NullableContext(1)]
	[Nullable(0)]
	public class Mino : IStaticVariableResetter
	{
		// Token: 0x06026E72 RID: 159346 RVA: 0x00AE32B5 File Offset: 0x00AE14B5
		static Mino()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(Mino.CreateStaticDefaultValue), new Action(Mino.ResetStaticDefaultValue));
		}

		// Token: 0x17004FD8 RID: 20440
		// (get) Token: 0x06026E73 RID: 159347 RVA: 0x00AE32D4 File Offset: 0x00AE14D4
		public string StyleName { get; }

		// Token: 0x17004FD9 RID: 20441
		// (get) Token: 0x06026E74 RID: 159348 RVA: 0x00AE32DC File Offset: 0x00AE14DC
		// (set) Token: 0x06026E75 RID: 159349 RVA: 0x00AE32E4 File Offset: 0x00AE14E4
		public Vector2D Coord { get; set; }

		// Token: 0x17004FDA RID: 20442
		// (get) Token: 0x06026E76 RID: 159350 RVA: 0x00AE32ED File Offset: 0x00AE14ED
		// (set) Token: 0x06026E77 RID: 159351 RVA: 0x00AE32F5 File Offset: 0x00AE14F5
		public AActor CubeActor { get; set; }

		// Token: 0x06026E78 RID: 159352 RVA: 0x00AE3300 File Offset: 0x00AE1500
		public Mino(string styleName, Vector2D coord, AActor cubeActor, SlidingBlocksDefine.EMinoParent parent)
		{
			this.StyleName = styleName;
			this.Coord = coord;
			this.CubeActor = cubeActor;
			this.Id = Mino._minoIndex;
			Mino._minoIndex++;
		}

		// Token: 0x06026E79 RID: 159353 RVA: 0x00AE3358 File Offset: 0x00AE1558
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

		// Token: 0x06026E7A RID: 159354 RVA: 0x00AE33A4 File Offset: 0x00AE15A4
		private void ResetMoveData()
		{
			this.StartFallingAnchorCoord.Set(this.Coord.X, this.Coord.Y);
			float num = SlidingBlocksModel.Instance.GameData.SingleCellMoveTime();
			this.CurFallingTime = MathCommon.Clamp(this.CurFallingTime - num, 0f, num);
		}

		// Token: 0x06026E7B RID: 159355 RVA: 0x00AE33FB File Offset: 0x00AE15FB
		private void RegisterTick()
		{
			SlidingBlocksModel.Instance.RegisterMinoTick(this);
		}

		// Token: 0x06026E7C RID: 159356 RVA: 0x00AE3408 File Offset: 0x00AE1608
		private void UnRegisterTick()
		{
			SlidingBlocksModel.Instance.UnRegisterMinoTick(this);
		}

		// Token: 0x06026E7D RID: 159357 RVA: 0x00AE3418 File Offset: 0x00AE1618
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

		// Token: 0x06026E7E RID: 159358 RVA: 0x00AE34EC File Offset: 0x00AE16EC
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

		// Token: 0x06026E7F RID: 159359 RVA: 0x00AE354A File Offset: 0x00AE174A
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

		// Token: 0x06026E80 RID: 159360 RVA: 0x00AE3578 File Offset: 0x00AE1778
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

		// Token: 0x06026E81 RID: 159361 RVA: 0x00AE35C0 File Offset: 0x00AE17C0
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

		// Token: 0x06026E82 RID: 159362 RVA: 0x00AE36A0 File Offset: 0x00AE18A0
		public static void CreateStaticDefaultValue()
		{
			Mino._minoIndex = 0;
		}

		// Token: 0x06026E83 RID: 159363 RVA: 0x00AE36A8 File Offset: 0x00AE18A8
		public static void ResetStaticDefaultValue()
		{
			Mino._minoIndex = 0;
		}

		// Token: 0x04015417 RID: 87063
		private static int _minoIndex;

		// Token: 0x04015418 RID: 87064
		public readonly int Id;

		// Token: 0x04015419 RID: 87065
		public Mino.EMinoState State;

		// Token: 0x0401541A RID: 87066
		private readonly Vector2D StartFallingAnchorCoord = Vector2D.Create();

		// Token: 0x0401541B RID: 87067
		private float CurFallingTime;

		// Token: 0x0401541C RID: 87068
		private double MoveTargetY;

		// Token: 0x0401541D RID: 87069
		[Nullable(2)]
		private CustomPromise<bool> FallPromise;

		// Token: 0x0401541E RID: 87070
		private readonly Vector CacheVector = Vector.Create();

		// Token: 0x02009772 RID: 38770
		[NullableContext(0)]
		public enum EMinoState
		{
			// Token: 0x0402F40D RID: 193549
			Static,
			// Token: 0x0402F40E RID: 193550
			Moving
		}
	}
}
