using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.Sequence.Assistant
{
	// Token: 0x02003FFD RID: 16381
	[NullableContext(2)]
	[Nullable(0)]
	public class PredictMotionSuppressor
	{
		// Token: 0x06029769 RID: 169833 RVA: 0x00BB0F04 File Offset: 0x00BAF104
		public unsafe void Begin(TsBaseCharacter character)
		{
			UCharacterMovementComponent ucharacterMovementComponent = (character != null) ? character.CharacterMovement : null;
			CharacterMoveComponent characterMoveComponent;
			if (character == null)
			{
				characterMoveComponent = null;
			}
			else
			{
				CharacterActorComponent characterActorComponent = character.CharacterActorComponent;
				if (characterActorComponent == null)
				{
					characterMoveComponent = null;
				}
				else
				{
					Entity entity = characterActorComponent.Entity;
					characterMoveComponent = ((entity != null) ? entity.GetComponent<CharacterMoveComponent>() : null);
				}
			}
			CharacterMoveComponent characterMoveComponent2 = characterMoveComponent;
			if (ucharacterMovementComponent == null || !ucharacterMovementComponent.IsValid() || characterMoveComponent2 == null)
			{
				return;
			}
			if (this.MoveComp != null && this.MoveComp != ucharacterMovementComponent)
			{
				this.Release();
			}
			this.MoveComp = ucharacterMovementComponent;
			this.EntityMoveComp = characterMoveComponent2;
			this.Actor = character;
			byte kuroPredictMotionMask = ucharacterMovementComponent.KuroPredictMotionMask;
			if ((kuroPredictMotionMask & 1) != 0)
			{
				ucharacterMovementComponent.KuroPredictMotionMask = (byte)((int)kuroPredictMotionMask & -2);
				this.EnableBitCleared = true;
			}
			this.EnterStage(PredictMotionSuppressor.EStage.Disable);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Plot;
			ELogAuthor author = ELogAuthor.HYF;
			string message = "[PredictMotion] 混出关闭预判移动";
			<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray5<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Actor", this.Actor);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("OriginMask", kuroPredictMotionMask);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Mask", ucharacterMovementComponent.KuroPredictMotionMask);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("EnableBitCleared", this.EnableBitCleared);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("EngineFrame", this.StageFrame);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 5));
			this.ScheduleTick();
		}

		// Token: 0x0602976A RID: 169834 RVA: 0x00BB106C File Offset: 0x00BAF26C
		public unsafe void Release()
		{
			if (this.Timer != null)
			{
				this.Timer.Remove();
				this.Timer = null;
			}
			this.Stage = PredictMotionSuppressor.EStage.None;
			if (this.MoveComp == null)
			{
				return;
			}
			this.RestoreEnableBit();
			if (this.NeverCompensateAdded)
			{
				CharacterMoveComponent entityMoveComp = this.EntityMoveComp;
				if (entityMoveComp != null)
				{
					entityMoveComp.RemovePredictMotionNeverCompensate();
				}
				this.NeverCompensateAdded = false;
			}
			if (this.MoveComp.IsValid())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Plot;
				ELogAuthor author = ELogAuthor.HYF;
				string message = "[PredictMotion] 恢复预判补差";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Actor", this.Actor);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Mask", this.MoveComp.KuroPredictMotionMask);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("EngineFrame", UKismetSystemLibrary.GetFrameCount());
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			}
			this.MoveComp = null;
			this.EntityMoveComp = null;
			this.Actor = null;
		}

		// Token: 0x0602976B RID: 169835 RVA: 0x00BB1177 File Offset: 0x00BAF377
		private void RestoreEnableBit()
		{
			if (!this.EnableBitCleared)
			{
				return;
			}
			this.EnableBitCleared = false;
			if (this.MoveComp != null && this.MoveComp.IsValid())
			{
				this.MoveComp.KuroPredictMotionMask = (this.MoveComp.KuroPredictMotionMask | 1);
			}
		}

		// Token: 0x0602976C RID: 169836 RVA: 0x00BB11B7 File Offset: 0x00BAF3B7
		private void EnterStage(PredictMotionSuppressor.EStage stage)
		{
			this.Stage = stage;
			this.StageFrame = UKismetSystemLibrary.GetFrameCount();
			this.TickCount = 0;
		}

		// Token: 0x0602976D RID: 169837 RVA: 0x00BB11D2 File Offset: 0x00BAF3D2
		private void ScheduleTick()
		{
			TimerHandle timer = this.Timer;
			if (timer != null)
			{
				timer.Remove();
			}
			this.Timer = TimerSystem.Instance.Next(delegate(float _)
			{
				this.OnTick();
			}, null, null);
			if (this.Timer == null)
			{
				this.Release();
			}
		}

		// Token: 0x0602976E RID: 169838 RVA: 0x00BB1214 File Offset: 0x00BAF414
		private void OnTick()
		{
			this.Timer = null;
			if (this.MoveComp == null || !this.MoveComp.IsValid())
			{
				this.Release();
				return;
			}
			long num = UKismetSystemLibrary.GetFrameCount() - this.StageFrame;
			this.TickCount++;
			bool flag = this.TickCount >= 300;
			PredictMotionSuppressor.EStage stage = this.Stage;
			if (stage == PredictMotionSuppressor.EStage.Disable)
			{
				bool flag2 = this.Actor == null || !this.Actor.IsValid() || !this.Actor.bHidden;
				if (flag || num >= 15L || (num >= 3L && flag2))
				{
					this.EnterNoCompensateStage();
				}
				this.ScheduleTick();
				return;
			}
			if (stage != PredictMotionSuppressor.EStage.NoCompensate)
			{
				this.Release();
				return;
			}
			if (flag || num >= 2L)
			{
				this.Release();
				return;
			}
			this.ScheduleTick();
		}

		// Token: 0x0602976F RID: 169839 RVA: 0x00BB12E8 File Offset: 0x00BAF4E8
		private unsafe void EnterNoCompensateStage()
		{
			if (!this.NeverCompensateAdded && this.EntityMoveComp != null)
			{
				this.EntityMoveComp.AddPredictMotionNeverCompensate();
				this.NeverCompensateAdded = true;
			}
			this.RestoreEnableBit();
			this.EnterStage(PredictMotionSuppressor.EStage.NoCompensate);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Plot;
			ELogAuthor author = ELogAuthor.HYF;
			string message = "[PredictMotion] 混出开启预判移动、屏蔽补差";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Actor", this.Actor);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Mask", this.MoveComp.KuroPredictMotionMask);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("EngineFrame", this.StageFrame);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		}

		// Token: 0x040169F5 RID: 92661
		private const byte ENABLE_BIT = 1;

		// Token: 0x040169F6 RID: 92662
		private const int DISABLE_MIN_FRAME = 3;

		// Token: 0x040169F7 RID: 92663
		private const int DISABLE_MAX_FRAME = 15;

		// Token: 0x040169F8 RID: 92664
		private const int NO_COMPENSATE_FRAME = 2;

		// Token: 0x040169F9 RID: 92665
		private const int MAX_TICK = 300;

		// Token: 0x040169FA RID: 92666
		private UCharacterMovementComponent MoveComp;

		// Token: 0x040169FB RID: 92667
		private CharacterMoveComponent EntityMoveComp;

		// Token: 0x040169FC RID: 92668
		private AActor Actor;

		// Token: 0x040169FD RID: 92669
		private bool EnableBitCleared;

		// Token: 0x040169FE RID: 92670
		private bool NeverCompensateAdded;

		// Token: 0x040169FF RID: 92671
		private TimerHandle Timer;

		// Token: 0x04016A00 RID: 92672
		private PredictMotionSuppressor.EStage Stage;

		// Token: 0x04016A01 RID: 92673
		private long StageFrame;

		// Token: 0x04016A02 RID: 92674
		private int TickCount;

		// Token: 0x02009BB3 RID: 39859
		[NullableContext(0)]
		private enum EStage
		{
			// Token: 0x040307AB RID: 198571
			None,
			// Token: 0x040307AC RID: 198572
			Disable,
			// Token: 0x040307AD RID: 198573
			NoCompensate
		}
	}
}
