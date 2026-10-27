using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020046BE RID: 18110
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneUiView : UiPanelBase
	{
		// Token: 0x17007668 RID: 30312
		// (get) Token: 0x0602EB5A RID: 191322 RVA: 0x00ACF623 File Offset: 0x00ACD823
		public bool FaceCamera
		{
			get
			{
				return this.FaceCameraInternal;
			}
		}

		// Token: 0x0602EB5B RID: 191323 RVA: 0x00ACF62C File Offset: 0x00ACD82C
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

		// Token: 0x0602EB5C RID: 191324 RVA: 0x00ACF688 File Offset: 0x00ACD888
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

		// Token: 0x0602EB5D RID: 191325 RVA: 0x00ACF720 File Offset: 0x00ACD920
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

		// Token: 0x0602EB5E RID: 191326 RVA: 0x00ACF7DE File Offset: 0x00ACD9DE
		protected override void OnBeforeCreateImplement()
		{
			this.UiViewSequence = new UiBehaviorLevelSequence(this);
			base.AddUiBehavior(this.UiViewSequence);
		}

		// Token: 0x0602EB5F RID: 191327 RVA: 0x00ACF7F8 File Offset: 0x00ACD9F8
		protected override UniTask OnBeforeShowAsyncImplement()
		{
			SceneUiView.<OnBeforeShowAsyncImplement>d__12 <OnBeforeShowAsyncImplement>d__;
			<OnBeforeShowAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeShowAsyncImplement>d__.<>4__this = this;
			<OnBeforeShowAsyncImplement>d__.<>1__state = -1;
			<OnBeforeShowAsyncImplement>d__.<>t__builder.Start<SceneUiView.<OnBeforeShowAsyncImplement>d__12>(ref <OnBeforeShowAsyncImplement>d__);
			return <OnBeforeShowAsyncImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0602EB60 RID: 191328 RVA: 0x00ACF83B File Offset: 0x00ACDA3B
		protected virtual UniTask OnBeforeShowAsyncImplementImplement()
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x0602EB61 RID: 191329 RVA: 0x00ACF844 File Offset: 0x00ACDA44
		protected override UniTask OnShowAsyncImplementImplement()
		{
			SceneUiView.<OnShowAsyncImplementImplement>d__14 <OnShowAsyncImplementImplement>d__;
			<OnShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnShowAsyncImplementImplement>d__.<>4__this = this;
			<OnShowAsyncImplementImplement>d__.<>1__state = -1;
			<OnShowAsyncImplementImplement>d__.<>t__builder.Start<SceneUiView.<OnShowAsyncImplementImplement>d__14>(ref <OnShowAsyncImplementImplement>d__);
			return <OnShowAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0602EB62 RID: 191330 RVA: 0x00ACF888 File Offset: 0x00ACDA88
		protected override UniTask OnHideAsyncImplementImplement()
		{
			SceneUiView.<OnHideAsyncImplementImplement>d__15 <OnHideAsyncImplementImplement>d__;
			<OnHideAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnHideAsyncImplementImplement>d__.<>4__this = this;
			<OnHideAsyncImplementImplement>d__.<>1__state = -1;
			<OnHideAsyncImplementImplement>d__.<>t__builder.Start<SceneUiView.<OnHideAsyncImplementImplement>d__15>(ref <OnHideAsyncImplementImplement>d__);
			return <OnHideAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0602EB63 RID: 191331 RVA: 0x00ACF8CC File Offset: 0x00ACDACC
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

		// Token: 0x0602EB64 RID: 191332 RVA: 0x00ACF927 File Offset: 0x00ACDB27
		public void SkipPlayingSequence()
		{
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence == null)
			{
				return;
			}
			uiViewSequence.StopPrevSequence(true, true);
		}

		// Token: 0x0602EB65 RID: 191333 RVA: 0x00ACF93B File Offset: 0x00ACDB3B
		protected virtual UniTask OnPlayingStartSequenceAsync()
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x0602EB66 RID: 191334 RVA: 0x00ACF942 File Offset: 0x00ACDB42
		protected virtual void OnAfterPlayStartSequence()
		{
		}

		// Token: 0x0602EB67 RID: 191335 RVA: 0x00ACF944 File Offset: 0x00ACDB44
		protected virtual void OnBeforePlayCloseSequence()
		{
		}

		// Token: 0x0602EB68 RID: 191336 RVA: 0x00ACF946 File Offset: 0x00ACDB46
		protected virtual UniTask OnPlayingCloseSequenceAsync()
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x0602EB69 RID: 191337 RVA: 0x00ACF94D File Offset: 0x00ACDB4D
		protected virtual UniTask OnPlayingHideSequenceAsync()
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x0602EB6A RID: 191338 RVA: 0x00ACF954 File Offset: 0x00ACDB54
		[NullableContext(2)]
		protected string GetOpenParamString()
		{
			return this.OpenParam as string;
		}

		// Token: 0x0602EB6B RID: 191339 RVA: 0x00ACF961 File Offset: 0x00ACDB61
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

		// Token: 0x040196D7 RID: 104151
		[Nullable(2)]
		protected UiBehaviorLevelSequence UiViewSequence;

		// Token: 0x040196D8 RID: 104152
		public bool LastHide;

		// Token: 0x040196D9 RID: 104153
		private bool FirstShow = true;

		// Token: 0x040196DA RID: 104154
		private bool FaceCameraInternal;

		// Token: 0x040196DB RID: 104155
		private FRotator? FacingRotation;

		// Token: 0x040196DC RID: 104156
		private FRotator? InitialWorldRotation;
	}
}
