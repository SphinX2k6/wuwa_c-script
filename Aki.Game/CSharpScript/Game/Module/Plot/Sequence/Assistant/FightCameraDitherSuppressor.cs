using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Camera;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.Sequence.Assistant
{
	// Token: 0x02003FFA RID: 16378
	[NullableContext(2)]
	[Nullable(0)]
	public class FightCameraDitherSuppressor
	{
		// Token: 0x0602974A RID: 169802 RVA: 0x00BAFF84 File Offset: 0x00BAE184
		public unsafe void Begin(float blendTime)
		{
			if (blendTime <= 0f)
			{
				return;
			}
			FightCamera fightCamera = CameraController.Instance.MainModel.FightCamera;
			FightCameraLogicComponent fightCameraLogicComponent = (fightCamera != null) ? fightCamera.LogicComponent : null;
			if (fightCameraLogicComponent == null)
			{
				return;
			}
			if (this.LogicComp != null && this.LogicComp != fightCameraLogicComponent)
			{
				this.Release();
			}
			TimerHandle timer = this.Timer;
			if (timer != null)
			{
				timer.Remove();
			}
			this.Timer = null;
			this.LogicComp = fightCameraLogicComponent;
			fightCameraLogicComponent.AddDitherDisableReason("PlotSequenceBlendOut");
			float num = Math.Max((blendTime + 0.1f) * 1000f, 20f);
			this.Timer = TimerSystem.Instance.Delay(delegate(float _)
			{
				this.Timer = null;
				this.Release();
			}, num, null, "FightCameraDitherSuppressor.Recover", true, 1f);
			if (this.Timer == null)
			{
				this.Release();
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Plot;
			ELogAuthor author = ELogAuthor.HYF;
			string message = "[DitherSuppress] 混出屏蔽战斗相机角色Dither";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("DelayMs", num);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("EngineFrame", UKismetSystemLibrary.GetFrameCount());
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}

		// Token: 0x0602974B RID: 169803 RVA: 0x00BB00B0 File Offset: 0x00BAE2B0
		public void Release()
		{
			if (this.Timer != null)
			{
				this.Timer.Remove();
				this.Timer = null;
			}
			if (this.LogicComp == null)
			{
				return;
			}
			this.LogicComp.RemoveDitherDisableReason("PlotSequenceBlendOut");
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Plot;
			ELogAuthor author = ELogAuthor.HYF;
			string message = "[DitherSuppress] 恢复战斗相机角色Dither";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("EngineFrame", UKismetSystemLibrary.GetFrameCount());
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.LogicComp = null;
		}

		// Token: 0x040169EF RID: 92655
		private const float RECOVER_EXTRA_TIME = 0.1f;

		// Token: 0x040169F0 RID: 92656
		[Nullable(1)]
		private const string DISABLE_REASON = "PlotSequenceBlendOut";

		// Token: 0x040169F1 RID: 92657
		private FightCameraLogicComponent LogicComp;

		// Token: 0x040169F2 RID: 92658
		private TimerHandle Timer;
	}
}
