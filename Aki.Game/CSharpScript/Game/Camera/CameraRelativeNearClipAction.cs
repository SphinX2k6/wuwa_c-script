using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Camera
{
	// Token: 0x020072C0 RID: 29376
	[NullableContext(1)]
	[Nullable(0)]
	public class CameraRelativeNearClipAction : ICameraNearClipAction<CameraRelativeNearClipConfig>
	{
		// Token: 0x06048113 RID: 295187 RVA: 0x0127A6F8 File Offset: 0x012788F8
		public CameraRelativeNearClipAction(int id, CameraRelativeNearClipConfig nearClipConfig)
		{
		}

		// Token: 0x17009F2D RID: 40749
		// (get) Token: 0x06048114 RID: 295188 RVA: 0x0127A715 File Offset: 0x01278915
		public CameraRelativeNearClipConfig NearClipConfig
		{
			get
			{
				return this.<nearClipConfig>P;
			}
		} = nearClipConfig;

		// Token: 0x06048115 RID: 295189 RVA: 0x0127A720 File Offset: 0x01278920
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

		// Token: 0x06048116 RID: 295190 RVA: 0x0127A7F4 File Offset: 0x012789F4
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

		// Token: 0x06048117 RID: 295191 RVA: 0x0127A866 File Offset: 0x01278A66
		private void UpdateNearClip(float targetNearClipDistance)
		{
			if (MathUtils.Instance.IsNearlyEqual((double)this.CurrentClipDistance, (double)targetNearClipDistance, new double?((double)1)))
			{
				return;
			}
			this.CurrentClipDistance = targetNearClipDistance;
			UKuroCameraFunctionLibrary.DelaySetNearClipPlane(this.CurrentClipDistance);
		}

		// Token: 0x06048118 RID: 295192 RVA: 0x0127A897 File Offset: 0x01278A97
		public bool IsPause()
		{
			return this.IsPauseState;
		}

		// Token: 0x06048119 RID: 295193 RVA: 0x0127A8A0 File Offset: 0x01278AA0
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

		// Token: 0x0604811A RID: 295194 RVA: 0x0127A98C File Offset: 0x01278B8C
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

		// Token: 0x0604811B RID: 295195 RVA: 0x0127AA78 File Offset: 0x01278C78
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

		// Token: 0x0402605C RID: 155740
		[CompilerGenerated]
		private CameraRelativeNearClipConfig <nearClipConfig>P;

		// Token: 0x0402605D RID: 155741
		public readonly int Id = id;

		// Token: 0x0402605E RID: 155742
		private bool IsPauseState;

		// Token: 0x0402605F RID: 155743
		private float CurrentClipDistance;

		// Token: 0x04026060 RID: 155744
		private int DefaultPlayAfterTickId = -1;
	}
}
