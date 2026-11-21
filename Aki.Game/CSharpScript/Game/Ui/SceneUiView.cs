using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020035EF RID: 13807
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneUiView : UiPanelBase
	{
		// Token: 0x17004924 RID: 18724
		// (get) Token: 0x060232A6 RID: 144038 RVA: 0x009FDF4B File Offset: 0x009FC14B
		public bool FaceCamera
		{
			get
			{
				return this.FaceCameraInternal;
			}
		}

		// Token: 0x060232A7 RID: 144039 RVA: 0x009FDF54 File Offset: 0x009FC154
		public void SetFaceCamera(bool enable)
		{
			if (this.FaceCameraInternal == enable)
			{
				return;
			}
			this.FaceCameraInternal = enable;
			if (!enable && this.InitialWorldRotation != null && this.RootItem != null && this.RootItem.IsValid())
			{
				UUIItem rootItem = this.RootItem;
				FRotator value = this.InitialWorldRotation.Value;
				rootItem.SetUIWorldRotation(value);
			}
		}

		// Token: 0x060232A8 RID: 144040 RVA: 0x009FDFB0 File Offset: 0x009FC1B0
		public void AttachToAnchor(AActor anchor)
		{
			AActor originalActor = base.GetOriginalActor();
			if (originalActor == null || !originalActor.IsValid() || anchor == null || !anchor.IsValid())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Scene3dUi;
				ELogAuthor author = ELogAuthor.HYF;
				string message = "[SceneUiView.AttachToAnchor]actor无效";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("view", base.GetType().Name);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			originalActor.K2_AttachToActor(anchor, FName.NAME_None, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, false, true);
			AActor rootActor = base.GetRootActor();
			this.InitialWorldRotation = ((rootActor != null) ? new FRotator?(rootActor.K2_GetActorRotation()) : null);
		}

		// Token: 0x060232A9 RID: 144041 RVA: 0x009FE048 File Offset: 0x009FC248
		public void UpdateFacing(float cameraYaw, float cameraPitch)
		{
			AActor rootActor = base.GetRootActor();
			if (rootActor == null || !rootActor.IsValid() || this.RootItem == null || !this.RootItem.IsValid())
			{
				return;
			}
			if (this.InitialWorldRotation == null)
			{
				this.InitialWorldRotation = new FRotator?(rootActor.K2_GetActorRotation());
			}
			if (this.FacingRotation == null)
			{
				this.FacingRotation = new FRotator?(rootActor.K2_GetActorRotation());
			}
			FRotator value = this.FacingRotation.Value;
			value.Roll = cameraPitch - 90f;
			value.Pitch = 0f;
			value.Yaw = cameraYaw + 90f;
			this.FacingRotation = new FRotator?(value);
			this.RootItem.SetUIWorldRotation(value);
		}

		// Token: 0x060232AA RID: 144042 RVA: 0x009FE106 File Offset: 0x009FC306
		protected override void OnBeforeCreateImplement()
		{
			this.UiViewSequence = new UiBehaviorLevelSequence(this);
			base.AddUiBehavior(this.UiViewSequence);
		}

		// Token: 0x060232AB RID: 144043 RVA: 0x009FE120 File Offset: 0x009FC320
		protected override UniTask OnBeforeShowAsyncImplement()
		{
			SceneUiView.<OnBeforeShowAsyncImplement>d__12 <OnBeforeShowAsyncImplement>d__;
			<OnBeforeShowAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeShowAsyncImplement>d__.<>4__this = this;
			<OnBeforeShowAsyncImplement>d__.<>1__state = -1;
			<OnBeforeShowAsyncImplement>d__.<>t__builder.Start<SceneUiView.<OnBeforeShowAsyncImplement>d__12>(ref <OnBeforeShowAsyncImplement>d__);
			return <OnBeforeShowAsyncImplement>d__.<>t__builder.Task;
		}

		// Token: 0x060232AC RID: 144044 RVA: 0x009FE163 File Offset: 0x009FC363
		protected virtual UniTask OnBeforeShowAsyncImplementImplement()
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x060232AD RID: 144045 RVA: 0x009FE16C File Offset: 0x009FC36C
		protected override UniTask OnShowAsyncImplementImplement()
		{
			SceneUiView.<OnShowAsyncImplementImplement>d__14 <OnShowAsyncImplementImplement>d__;
			<OnShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnShowAsyncImplementImplement>d__.<>4__this = this;
			<OnShowAsyncImplementImplement>d__.<>1__state = -1;
			<OnShowAsyncImplementImplement>d__.<>t__builder.Start<SceneUiView.<OnShowAsyncImplementImplement>d__14>(ref <OnShowAsyncImplementImplement>d__);
			return <OnShowAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x060232AE RID: 144046 RVA: 0x009FE1B0 File Offset: 0x009FC3B0
		protected override UniTask OnHideAsyncImplementImplement()
		{
			SceneUiView.<OnHideAsyncImplementImplement>d__15 <OnHideAsyncImplementImplement>d__;
			<OnHideAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnHideAsyncImplementImplement>d__.<>4__this = this;
			<OnHideAsyncImplementImplement>d__.<>1__state = -1;
			<OnHideAsyncImplementImplement>d__.<>t__builder.Start<SceneUiView.<OnHideAsyncImplementImplement>d__15>(ref <OnHideAsyncImplementImplement>d__);
			return <OnHideAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x060232AF RID: 144047 RVA: 0x009FE1F4 File Offset: 0x009FC3F4
		protected UniTask PlaySequenceAsync(string sequenceName, bool playReverse = false, float? playRate = null)
		{
			SceneUiView.<PlaySequenceAsync>d__16 <PlaySequenceAsync>d__;
			<PlaySequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlaySequenceAsync>d__.<>4__this = this;
			<PlaySequenceAsync>d__.sequenceName = sequenceName;
			<PlaySequenceAsync>d__.playReverse = playReverse;
			<PlaySequenceAsync>d__.playRate = playRate;
			<PlaySequenceAsync>d__.<>1__state = -1;
			<PlaySequenceAsync>d__.<>t__builder.Start<SceneUiView.<PlaySequenceAsync>d__16>(ref <PlaySequenceAsync>d__);
			return <PlaySequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060232B0 RID: 144048 RVA: 0x009FE24F File Offset: 0x009FC44F
		public void SkipPlayingSequence()
		{
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence == null)
			{
				return;
			}
			uiViewSequence.StopPrevSequence(true, true);
		}

		// Token: 0x060232B1 RID: 144049 RVA: 0x009FE263 File Offset: 0x009FC463
		protected virtual UniTask OnPlayingStartSequenceAsync()
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x060232B2 RID: 144050 RVA: 0x009FE26A File Offset: 0x009FC46A
		protected virtual void OnAfterPlayStartSequence()
		{
		}

		// Token: 0x060232B3 RID: 144051 RVA: 0x009FE26C File Offset: 0x009FC46C
		protected virtual void OnBeforePlayCloseSequence()
		{
		}

		// Token: 0x060232B4 RID: 144052 RVA: 0x009FE26E File Offset: 0x009FC46E
		protected virtual UniTask OnPlayingCloseSequenceAsync()
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x060232B5 RID: 144053 RVA: 0x009FE275 File Offset: 0x009FC475
		protected virtual UniTask OnPlayingHideSequenceAsync()
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x060232B6 RID: 144054 RVA: 0x009FE27C File Offset: 0x009FC47C
		[NullableContext(2)]
		protected string GetOpenParamString()
		{
			return this.OpenParam as string;
		}

		// Token: 0x060232B7 RID: 144055 RVA: 0x009FE289 File Offset: 0x009FC489
		[return: Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		protected Dictionary<string, string> GetOpenParamMap()
		{
			return this.OpenParam as Dictionary<string, string>;
		}

		// Token: 0x04013D7E RID: 81278
		[Nullable(2)]
		protected UiBehaviorLevelSequence UiViewSequence;

		// Token: 0x04013D7F RID: 81279
		public bool LastHide;

		// Token: 0x04013D80 RID: 81280
		private bool FirstShow = true;

		// Token: 0x04013D81 RID: 81281
		private bool FaceCameraInternal;

		// Token: 0x04013D82 RID: 81282
		private FRotator? FacingRotation;

		// Token: 0x04013D83 RID: 81283
		private FRotator? InitialWorldRotation;
	}
}
