using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02006106 RID: 24838
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class RoverlikeActionSubViewBase : UiPanelBase
	{
		// Token: 0x17009171 RID: 37233
		// (get) Token: 0x0603ECA9 RID: 257193
		public abstract ERoverActionSubViewType SubViewType { get; }

		// Token: 0x17009172 RID: 37234
		// (get) Token: 0x0603ECAA RID: 257194
		public abstract string ResourceId { get; }

		// Token: 0x17009173 RID: 37235
		// (get) Token: 0x0603ECAB RID: 257195 RVA: 0x00F29E96 File Offset: 0x00F28096
		public ERoverlikeActionSubViewState State
		{
			get
			{
				return this.ViewState;
			}
		}

		// Token: 0x0603ECAC RID: 257196 RVA: 0x00F29E9E File Offset: 0x00F2809E
		public void SetState(ERoverlikeActionSubViewState state)
		{
			this.ViewState = state;
		}

		// Token: 0x17009174 RID: 37236
		// (get) Token: 0x0603ECAD RID: 257197 RVA: 0x00F29EA7 File Offset: 0x00F280A7
		public bool Finished
		{
			get
			{
				return this.ViewState == ERoverlikeActionSubViewState.Finished;
			}
		}

		// Token: 0x0603ECAE RID: 257198 RVA: 0x00F29EB2 File Offset: 0x00F280B2
		protected override void OnBeforeCreateImplement()
		{
			this.UiViewSequence = new UiBehaviorLevelSequence(this);
			base.AddUiBehavior(this.UiViewSequence);
		}

		// Token: 0x0603ECAF RID: 257199 RVA: 0x00F29ECC File Offset: 0x00F280CC
		protected override UniTask OnShowAsyncImplementImplement()
		{
			RoverlikeActionSubViewBase.<OnShowAsyncImplementImplement>d__14 <OnShowAsyncImplementImplement>d__;
			<OnShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnShowAsyncImplementImplement>d__.<>4__this = this;
			<OnShowAsyncImplementImplement>d__.<>1__state = -1;
			<OnShowAsyncImplementImplement>d__.<>t__builder.Start<RoverlikeActionSubViewBase.<OnShowAsyncImplementImplement>d__14>(ref <OnShowAsyncImplementImplement>d__);
			return <OnShowAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0603ECB0 RID: 257200 RVA: 0x00F29F10 File Offset: 0x00F28110
		protected override UniTask OnHideAsyncImplementImplement()
		{
			RoverlikeActionSubViewBase.<OnHideAsyncImplementImplement>d__15 <OnHideAsyncImplementImplement>d__;
			<OnHideAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnHideAsyncImplementImplement>d__.<>4__this = this;
			<OnHideAsyncImplementImplement>d__.<>1__state = -1;
			<OnHideAsyncImplementImplement>d__.<>t__builder.Start<RoverlikeActionSubViewBase.<OnHideAsyncImplementImplement>d__15>(ref <OnHideAsyncImplementImplement>d__);
			return <OnHideAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0603ECB1 RID: 257201 RVA: 0x00F29F54 File Offset: 0x00F28154
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

		// Token: 0x0603ECB2 RID: 257202 RVA: 0x00F29FB8 File Offset: 0x00F281B8
		public virtual void OnRefreshSubView()
		{
		}

		// Token: 0x0603ECB3 RID: 257203 RVA: 0x00F29FBA File Offset: 0x00F281BA
		public virtual void OnCoveredBySubView()
		{
		}

		// Token: 0x0603ECB4 RID: 257204 RVA: 0x00F29FBC File Offset: 0x00F281BC
		public virtual void OnUncoveredSubView()
		{
		}

		// Token: 0x0603ECB5 RID: 257205 RVA: 0x00F29FC0 File Offset: 0x00F281C0
		protected bool TryInteractAction(Action action)
		{
			RoverlikeActionStack actionStack = this.GetActionStack();
			return actionStack != null && actionStack.TryAction(this, action);
		}

		// Token: 0x0603ECB6 RID: 257206 RVA: 0x00F29FE1 File Offset: 0x00F281E1
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

		// Token: 0x04020CEB RID: 134379
		public int IncId;

		// Token: 0x04020CEC RID: 134380
		private ERoverlikeActionSubViewState ViewState;

		// Token: 0x04020CED RID: 134381
		[Nullable(2)]
		protected UiBehaviorLevelSequence UiViewSequence;

		// Token: 0x04020CEE RID: 134382
		private bool IsFirstShow = true;
	}
}
