using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02005084 RID: 20612
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class RoverlikeActionSubViewBase : UiPanelBase
	{
		// Token: 0x170064D3 RID: 25811
		// (get) Token: 0x0603396B RID: 211307
		public abstract ERoverActionSubViewType SubViewType { get; }

		// Token: 0x170064D4 RID: 25812
		// (get) Token: 0x0603396C RID: 211308
		public abstract string ResourceId { get; }

		// Token: 0x170064D5 RID: 25813
		// (get) Token: 0x0603396D RID: 211309 RVA: 0x00E70CAA File Offset: 0x00E6EEAA
		public ERoverlikeActionSubViewState State
		{
			get
			{
				return this.ViewState;
			}
		}

		// Token: 0x0603396E RID: 211310 RVA: 0x00E70CB2 File Offset: 0x00E6EEB2
		public void SetState(ERoverlikeActionSubViewState state)
		{
			this.ViewState = state;
		}

		// Token: 0x170064D6 RID: 25814
		// (get) Token: 0x0603396F RID: 211311 RVA: 0x00E70CBB File Offset: 0x00E6EEBB
		public bool Finished
		{
			get
			{
				return this.ViewState == ERoverlikeActionSubViewState.Finished;
			}
		}

		// Token: 0x06033970 RID: 211312 RVA: 0x00E70CC6 File Offset: 0x00E6EEC6
		protected override void OnBeforeCreateImplement()
		{
			this.UiViewSequence = new UiBehaviorLevelSequence(this);
			base.AddUiBehavior(this.UiViewSequence);
		}

		// Token: 0x06033971 RID: 211313 RVA: 0x00E70CE0 File Offset: 0x00E6EEE0
		protected override UniTask OnShowAsyncImplementImplement()
		{
			RoverlikeActionSubViewBase.<OnShowAsyncImplementImplement>d__14 <OnShowAsyncImplementImplement>d__;
			<OnShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnShowAsyncImplementImplement>d__.<>4__this = this;
			<OnShowAsyncImplementImplement>d__.<>1__state = -1;
			<OnShowAsyncImplementImplement>d__.<>t__builder.Start<RoverlikeActionSubViewBase.<OnShowAsyncImplementImplement>d__14>(ref <OnShowAsyncImplementImplement>d__);
			return <OnShowAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x06033972 RID: 211314 RVA: 0x00E70D24 File Offset: 0x00E6EF24
		protected override UniTask OnHideAsyncImplementImplement()
		{
			RoverlikeActionSubViewBase.<OnHideAsyncImplementImplement>d__15 <OnHideAsyncImplementImplement>d__;
			<OnHideAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnHideAsyncImplementImplement>d__.<>4__this = this;
			<OnHideAsyncImplementImplement>d__.<>1__state = -1;
			<OnHideAsyncImplementImplement>d__.<>t__builder.Start<RoverlikeActionSubViewBase.<OnHideAsyncImplementImplement>d__15>(ref <OnHideAsyncImplementImplement>d__);
			return <OnHideAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x06033973 RID: 211315 RVA: 0x00E70D68 File Offset: 0x00E6EF68
		protected UniTask PlaySequenceAsync(string sequenceName, bool blockClick = false, bool playReverse = false, float? playRate = null)
		{
			RoverlikeActionSubViewBase.<PlaySequenceAsync>d__16 <PlaySequenceAsync>d__;
			<PlaySequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlaySequenceAsync>d__.<>4__this = this;
			<PlaySequenceAsync>d__.sequenceName = sequenceName;
			<PlaySequenceAsync>d__.blockClick = blockClick;
			<PlaySequenceAsync>d__.playReverse = playReverse;
			<PlaySequenceAsync>d__.playRate = playRate;
			<PlaySequenceAsync>d__.<>1__state = -1;
			<PlaySequenceAsync>d__.<>t__builder.Start<RoverlikeActionSubViewBase.<PlaySequenceAsync>d__16>(ref <PlaySequenceAsync>d__);
			return <PlaySequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033974 RID: 211316 RVA: 0x00E70DCC File Offset: 0x00E6EFCC
		public virtual void OnRefreshSubView()
		{
		}

		// Token: 0x06033975 RID: 211317 RVA: 0x00E70DCE File Offset: 0x00E6EFCE
		public virtual void OnCoveredBySubView()
		{
		}

		// Token: 0x06033976 RID: 211318 RVA: 0x00E70DD0 File Offset: 0x00E6EFD0
		public virtual void OnUncoveredSubView()
		{
		}

		// Token: 0x06033977 RID: 211319 RVA: 0x00E70DD4 File Offset: 0x00E6EFD4
		protected bool TryInteractAction(Action action)
		{
			RoverlikeActionStack actionStack = this.GetActionStack();
			return actionStack != null && actionStack.TryAction(this, action);
		}

		// Token: 0x06033978 RID: 211320 RVA: 0x00E70DF5 File Offset: 0x00E6EFF5
		[NullableContext(2)]
		private RoverlikeActionStack GetActionStack()
		{
			RoverlikeModel instance = RoverlikeModel.Instance;
			if (instance == null)
			{
				return null;
			}
			return instance.ActionStack;
		}

		// Token: 0x0401B618 RID: 112152
		public int IncId;

		// Token: 0x0401B619 RID: 112153
		private ERoverlikeActionSubViewState ViewState;

		// Token: 0x0401B61A RID: 112154
		[Nullable(2)]
		protected UiBehaviorLevelSequence UiViewSequence;

		// Token: 0x0401B61B RID: 112155
		private bool IsFirstShow = true;
	}
}
