using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Main
{
	// Token: 0x02006336 RID: 25398
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class PinballMainRootViewBase : UiViewBase
	{
		// Token: 0x0603FE63 RID: 261731 RVA: 0x00F754F7 File Offset: 0x00F736F7
		public PinballMainRootViewBase(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603FE64 RID: 261732 RVA: 0x00F75516 File Offset: 0x00F73716
		protected override void OnBeforeCreate()
		{
			this.OnRegisterViewData();
			this.OnRegisterDefaultChildView();
		}

		// Token: 0x0603FE65 RID: 261733
		protected abstract void OnRegisterDefaultChildView();

		// Token: 0x0603FE66 RID: 261734
		protected abstract void OnRegisterContentItem();

		// Token: 0x0603FE67 RID: 261735
		protected abstract void OnRegisterViewData();

		// Token: 0x0603FE68 RID: 261736 RVA: 0x00F75524 File Offset: 0x00F73724
		protected override UniTask OnBeforeStartAsync()
		{
			PinballMainRootViewBase.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PinballMainRootViewBase.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603FE69 RID: 261737 RVA: 0x00F75568 File Offset: 0x00F73768
		protected override UniTask OnShowAsyncImplementImplement()
		{
			PinballMainRootViewBase.<OnShowAsyncImplementImplement>d__12 <OnShowAsyncImplementImplement>d__;
			<OnShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnShowAsyncImplementImplement>d__.<>4__this = this;
			<OnShowAsyncImplementImplement>d__.<>1__state = -1;
			<OnShowAsyncImplementImplement>d__.<>t__builder.Start<PinballMainRootViewBase.<OnShowAsyncImplementImplement>d__12>(ref <OnShowAsyncImplementImplement>d__);
			return <OnShowAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0603FE6A RID: 261738 RVA: 0x00F755AC File Offset: 0x00F737AC
		protected override UniTask OnHideAsyncImplementImplement()
		{
			PinballMainRootViewBase.<OnHideAsyncImplementImplement>d__13 <OnHideAsyncImplementImplement>d__;
			<OnHideAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnHideAsyncImplementImplement>d__.<>4__this = this;
			<OnHideAsyncImplementImplement>d__.<>1__state = -1;
			<OnHideAsyncImplementImplement>d__.<>t__builder.Start<PinballMainRootViewBase.<OnHideAsyncImplementImplement>d__13>(ref <OnHideAsyncImplementImplement>d__);
			return <OnHideAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0603FE6B RID: 261739 RVA: 0x00F755F0 File Offset: 0x00F737F0
		protected override UniTask OnDestroyAsyncImplementImplement()
		{
			PinballMainRootViewBase.<OnDestroyAsyncImplementImplement>d__14 <OnDestroyAsyncImplementImplement>d__;
			<OnDestroyAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnDestroyAsyncImplementImplement>d__.<>4__this = this;
			<OnDestroyAsyncImplementImplement>d__.<>1__state = -1;
			<OnDestroyAsyncImplementImplement>d__.<>t__builder.Start<PinballMainRootViewBase.<OnDestroyAsyncImplementImplement>d__14>(ref <OnDestroyAsyncImplementImplement>d__);
			return <OnDestroyAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0603FE6C RID: 261740 RVA: 0x00F75634 File Offset: 0x00F73834
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		private UniTask<PinballMainChildViewBase> CreateChildViewAsync(string viewName)
		{
			PinballMainRootViewBase.<CreateChildViewAsync>d__15 <CreateChildViewAsync>d__;
			<CreateChildViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<PinballMainChildViewBase>.Create();
			<CreateChildViewAsync>d__.<>4__this = this;
			<CreateChildViewAsync>d__.viewName = viewName;
			<CreateChildViewAsync>d__.<>1__state = -1;
			<CreateChildViewAsync>d__.<>t__builder.Start<PinballMainRootViewBase.<CreateChildViewAsync>d__15>(ref <CreateChildViewAsync>d__);
			return <CreateChildViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603FE6D RID: 261741 RVA: 0x00F75680 File Offset: 0x00F73880
		public void OpenChildView(string viewName)
		{
			PinballMainRootViewBase.<>c__DisplayClass16_0 CS$<>8__locals1 = new PinballMainRootViewBase.<>c__DisplayClass16_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.viewName = viewName;
			UiAsyncTask task = new UiAsyncTask("PinballMainRootViewOpenChild", delegate()
			{
				PinballMainRootViewBase.<>c__DisplayClass16_0.<<OpenChildView>b__0>d <<OpenChildView>b__0>d;
				<<OpenChildView>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<OpenChildView>b__0>d.<>4__this = CS$<>8__locals1;
				<<OpenChildView>b__0>d.<>1__state = -1;
				<<OpenChildView>b__0>d.<>t__builder.Start<PinballMainRootViewBase.<>c__DisplayClass16_0.<<OpenChildView>b__0>d>(ref <<OpenChildView>b__0>d);
				return <<OpenChildView>b__0>d.<>t__builder.Task;
			}, null);
			base.RunAsyncTask(task).Forget();
		}

		// Token: 0x0603FE6E RID: 261742 RVA: 0x00F756C8 File Offset: 0x00F738C8
		public UniTask OpenChildViewAsync(string viewName)
		{
			PinballMainRootViewBase.<OpenChildViewAsync>d__17 <OpenChildViewAsync>d__;
			<OpenChildViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OpenChildViewAsync>d__.<>4__this = this;
			<OpenChildViewAsync>d__.viewName = viewName;
			<OpenChildViewAsync>d__.<>1__state = -1;
			<OpenChildViewAsync>d__.<>t__builder.Start<PinballMainRootViewBase.<OpenChildViewAsync>d__17>(ref <OpenChildViewAsync>d__);
			return <OpenChildViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603FE6F RID: 261743 RVA: 0x00F75714 File Offset: 0x00F73914
		public void CloseCurChildView()
		{
			UiAsyncTask task = new UiAsyncTask("PinballMainRootViewCloseCurChild", delegate()
			{
				PinballMainRootViewBase.<<CloseCurChildView>b__18_0>d <<CloseCurChildView>b__18_0>d;
				<<CloseCurChildView>b__18_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<CloseCurChildView>b__18_0>d.<>4__this = this;
				<<CloseCurChildView>b__18_0>d.<>1__state = -1;
				<<CloseCurChildView>b__18_0>d.<>t__builder.Start<PinballMainRootViewBase.<<CloseCurChildView>b__18_0>d>(ref <<CloseCurChildView>b__18_0>d);
				return <<CloseCurChildView>b__18_0>d.<>t__builder.Task;
			}, null);
			base.RunAsyncTask(task).Forget();
		}

		// Token: 0x0603FE70 RID: 261744 RVA: 0x00F75748 File Offset: 0x00F73948
		[NullableContext(0)]
		public UniTask<bool> CloseCurChildViewAsync()
		{
			PinballMainRootViewBase.<CloseCurChildViewAsync>d__19 <CloseCurChildViewAsync>d__;
			<CloseCurChildViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<CloseCurChildViewAsync>d__.<>4__this = this;
			<CloseCurChildViewAsync>d__.<>1__state = -1;
			<CloseCurChildViewAsync>d__.<>t__builder.Start<PinballMainRootViewBase.<CloseCurChildViewAsync>d__19>(ref <CloseCurChildViewAsync>d__);
			return <CloseCurChildViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603FE71 RID: 261745 RVA: 0x00F7578C File Offset: 0x00F7398C
		public void CloseChildView(PinballMainChildViewBase childView)
		{
			PinballMainRootViewBase.<>c__DisplayClass20_0 CS$<>8__locals1 = new PinballMainRootViewBase.<>c__DisplayClass20_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.childView = childView;
			UiAsyncTask task = new UiAsyncTask("PinballMainRootViewCloseChild", delegate()
			{
				PinballMainRootViewBase.<>c__DisplayClass20_0.<<CloseChildView>b__0>d <<CloseChildView>b__0>d;
				<<CloseChildView>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<CloseChildView>b__0>d.<>4__this = CS$<>8__locals1;
				<<CloseChildView>b__0>d.<>1__state = -1;
				<<CloseChildView>b__0>d.<>t__builder.Start<PinballMainRootViewBase.<>c__DisplayClass20_0.<<CloseChildView>b__0>d>(ref <<CloseChildView>b__0>d);
				return <<CloseChildView>b__0>d.<>t__builder.Task;
			}, null);
			base.RunAsyncTask(task).Forget();
		}

		// Token: 0x0603FE72 RID: 261746 RVA: 0x00F757D4 File Offset: 0x00F739D4
		[NullableContext(0)]
		public UniTask<bool> CloseChildViewAsync([Nullable(1)] PinballMainChildViewBase childView)
		{
			PinballMainRootViewBase.<CloseChildViewAsync>d__21 <CloseChildViewAsync>d__;
			<CloseChildViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<CloseChildViewAsync>d__.<>4__this = this;
			<CloseChildViewAsync>d__.childView = childView;
			<CloseChildViewAsync>d__.<>1__state = -1;
			<CloseChildViewAsync>d__.<>t__builder.Start<PinballMainRootViewBase.<CloseChildViewAsync>d__21>(ref <CloseChildViewAsync>d__);
			return <CloseChildViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603FE73 RID: 261747 RVA: 0x00F7581F File Offset: 0x00F73A1F
		public int GetChildViewStackNum()
		{
			return this.ChildViewStack.Size;
		}

		// Token: 0x0603FE74 RID: 261748 RVA: 0x00F7582C File Offset: 0x00F73A2C
		protected PinballMainChildViewBase GetCurChildView()
		{
			return this.ChildViewStack.Peek();
		}

		// Token: 0x0603FE75 RID: 261749 RVA: 0x00F7583C File Offset: 0x00F73A3C
		public void Back()
		{
			if (this.ChildViewStack.Size > 1)
			{
				this.CloseCurChildView();
				return;
			}
			IPinballMainRootViewOpenParam pinballMainRootViewOpenParam = this.OpenParam as IPinballMainRootViewOpenParam;
			if (pinballMainRootViewOpenParam == null || !pinballMainRootViewOpenParam.IsFromInstanceDungeon.GetValueOrDefault())
			{
				base.CloseMe(null);
				return;
			}
			PinballController instance = PinballController.Instance;
			if (instance == null)
			{
				return;
			}
			instance.OpenConfirmBackWorld();
		}

		// Token: 0x0603FE76 RID: 261750 RVA: 0x00F75898 File Offset: 0x00F73A98
		public void PlaySequenceByName(string sequenceName)
		{
			this.UiViewSequence.StopSequenceByKey(sequenceName, false, false);
			this.UiViewSequence.PlaySequence(sequenceName, false, null);
		}

		// Token: 0x0603FE77 RID: 261751 RVA: 0x00F758CC File Offset: 0x00F73ACC
		public UniTask PlaySequenceByNameAsync(string sequenceName)
		{
			PinballMainRootViewBase.<PlaySequenceByNameAsync>d__26 <PlaySequenceByNameAsync>d__;
			<PlaySequenceByNameAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlaySequenceByNameAsync>d__.<>4__this = this;
			<PlaySequenceByNameAsync>d__.sequenceName = sequenceName;
			<PlaySequenceByNameAsync>d__.<>1__state = -1;
			<PlaySequenceByNameAsync>d__.<>t__builder.Start<PinballMainRootViewBase.<PlaySequenceByNameAsync>d__26>(ref <PlaySequenceByNameAsync>d__);
			return <PlaySequenceByNameAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603FE78 RID: 261752 RVA: 0x00F75917 File Offset: 0x00F73B17
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (this.ChildViewStack.Size == 0)
			{
				return null;
			}
			return this.GetCurChildView().GetGuideUiItemAndUiItemForShowEx(configParams);
		}

		// Token: 0x04021547 RID: 136519
		[Nullable(2)]
		public object ViewModel;

		// Token: 0x04021548 RID: 136520
		public int ActivityId;

		// Token: 0x04021549 RID: 136521
		[Nullable(2)]
		protected UUIItem ContentItem;

		// Token: 0x0402154A RID: 136522
		[Nullable(2)]
		protected string DefaultChildViewName;

		// Token: 0x0402154B RID: 136523
		private readonly Stack<PinballMainChildViewBase> ChildViewStack = new Stack<PinballMainChildViewBase>();

		// Token: 0x0402154C RID: 136524
		protected UiMask ViewMask = new UiMask();
	}
}
