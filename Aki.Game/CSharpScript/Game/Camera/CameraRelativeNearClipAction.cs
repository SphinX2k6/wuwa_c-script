using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Camera
{
	// Token: 0x02006442 RID: 25666
	[NullableContext(1)]
	[Nullable(0)]
	public class CameraRelativeNearClipAction : ICameraNearClipAction<CameraRelativeNearClipConfig>
	{
		// Token: 0x0603E507 RID: 255239 RVA: 0x0121CA90 File Offset: 0x0121AC90
		public CameraRelativeNearClipAction(int id, CameraRelativeNearClipConfig nearClipConfig)
		{
		}

		// Token: 0x17007694 RID: 30356
		// (get) Token: 0x0603E508 RID: 255240 RVA: 0x0121CAAD File Offset: 0x0121ACAD
		public CameraRelativeNearClipConfig NearClipConfig
		{
			get
			{
				return this.<nearClipConfig>P;
			}
		} = nearClipConfig;

		// Token: 0x0603E509 RID: 255241 RVA: 0x0121CAB8 File Offset: 0x0121ACB8
		public unsafe void Start()
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Camera;
			ELogAuthor author = ELogAuthor.LJM;
			string message = "[CameraNearClip][CameraRelativeNearClipAction]Start";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Id", this.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Type", this.<nearClipConfig>P.NearClipType);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Distance", this.<nearClipConfig>P.Distance.ToString("F2"));
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			Ticker ticker = TickSystem.Instance.Add(new Action<float>(this.AfterTick), "CameraRelativeNearClipAction", ETickingGroup.TG_PostUpdateWork, false, 0, false);
			this.DefaultPlayAfterTickId = ticker.Id;
		}

		// Token: 0x0603E50A RID: 255242 RVA: 0x0121CB8C File Offset: 0x0121AD8C
		private void AfterTick(float delta)
		{
			FightCamera fightCamera = CameraController.Instance.MainModel.FightCamera;
			FightCameraLogicComponent fightCameraLogicComponent = (fightCamera != null) ? fightCamera.LogicComponent : null;
			if (fightCameraLogicComponent == null || !fightCameraLogicComponent.Valid)
			{
				return;
			}
			if (fightCameraLogicComponent.FinalCameraDistance < this.<nearClipConfig>P.Distance)
			{
				this.UpdateNearClip(10f);
				return;
			}
			this.UpdateNearClip(fightCameraLogicComponent.FinalCameraDistance - this.<nearClipConfig>P.Distance);
		}

		// Token: 0x0603E50B RID: 255243 RVA: 0x0121CBFE File Offset: 0x0121ADFE
		private void UpdateNearClip(float targetNearClipDistance)
		{
			if (MathUtils.Instance.IsNearlyEqual((double)this.CurrentClipDistance, (double)targetNearClipDistance, new double?((double)1)))
			{
				return;
			}
			this.CurrentClipDistance = targetNearClipDistance;
			UKuroCameraFunctionLibrary.DelaySetNearClipPlane(this.CurrentClipDistance);
		}

		// Token: 0x0603E50C RID: 255244 RVA: 0x0121CC2F File Offset: 0x0121AE2F
		public bool IsPause()
		{
			return this.IsPauseState;
		}

		// Token: 0x0603E50D RID: 255245 RVA: 0x0121CC38 File Offset: 0x0121AE38
		public unsafe void Pause()
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Camera;
			ELogAuthor author = ELogAuthor.LJM;
			string message = "[CameraNearClip][CameraRelativeNearClipAction]Pause";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Id", this.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Type", this.<nearClipConfig>P.NearClipType);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Distance", this.<nearClipConfig>P.Distance.ToString("F2"));
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("this.CurrentClipDistance", this.CurrentClipDistance);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
			this.IsPauseState = true;
			if (this.DefaultPlayAfterTickId == -1)
			{
				return;
			}
			TickSystem.Instance.Pause(this.DefaultPlayAfterTickId);
		}

		// Token: 0x0603E50E RID: 255246 RVA: 0x0121CD24 File Offset: 0x0121AF24
		public unsafe void Resume()
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Camera;
			ELogAuthor author = ELogAuthor.LJM;
			string message = "[CameraNearClip][CameraRelativeNearClipAction]Resume";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Id", this.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Type", this.<nearClipConfig>P.NearClipType);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Distance", this.<nearClipConfig>P.Distance.ToString("F2"));
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("this.CurrentClipDistance", this.CurrentClipDistance);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
			this.IsPauseState = false;
			if (this.DefaultPlayAfterTickId == -1)
			{
				return;
			}
			TickSystem.Instance.Resume(this.DefaultPlayAfterTickId);
		}

		// Token: 0x0603E50F RID: 255247 RVA: 0x0121CE10 File Offset: 0x0121B010
		public unsafe void End()
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Camera;
			ELogAuthor author = ELogAuthor.LJM;
			string message = "[CameraNearClip][CameraRelativeNearClipAction]End";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Id", this.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Type", this.<nearClipConfig>P.NearClipType);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Distance", this.<nearClipConfig>P.Distance.ToString("F2"));
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			if (this.DefaultPlayAfterTickId != -1)
			{
				TickSystem.Instance.Remove(this.DefaultPlayAfterTickId);
				this.DefaultPlayAfterTickId = -1;
			}
		}

		// Token: 0x0402133C RID: 135996
		[CompilerGenerated]
		private CameraRelativeNearClipConfig <nearClipConfig>P;

		// Token: 0x0402133D RID: 135997
		public readonly int Id = id;

		// Token: 0x0402133E RID: 135998
		private bool IsPauseState;

		// Token: 0x0402133F RID: 135999
		private float CurrentClipDistance;

		// Token: 0x04021340 RID: 136000
		private int DefaultPlayAfterTickId = -1;
	}
}
