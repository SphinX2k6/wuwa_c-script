using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Main
{
	// Token: 0x020052B4 RID: 21172
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class PinballMainRootViewBase : UiViewBase
	{
		// Token: 0x06034B24 RID: 215844 RVA: 0x00EBC453 File Offset: 0x00EBA653
		public PinballMainRootViewBase(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06034B25 RID: 215845 RVA: 0x00EBC472 File Offset: 0x00EBA672
		protected override void OnBeforeCreate()
		{
			this.OnRegisterViewData();
			this.OnRegisterDefaultChildView();
		}

		// Token: 0x06034B26 RID: 215846
		protected abstract void OnRegisterDefaultChildView();

		// Token: 0x06034B27 RID: 215847
		protected abstract void OnRegisterContentItem();

		// Token: 0x06034B28 RID: 215848
		protected abstract void OnRegisterViewData();

		// Token: 0x06034B29 RID: 215849 RVA: 0x00EBC480 File Offset: 0x00EBA680
		protected override UniTask OnBeforeStartAsync()
		{
			PinballMainRootViewBase.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PinballMainRootViewBase.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034B2A RID: 215850 RVA: 0x00EBC4C4 File Offset: 0x00EBA6C4
		protected override UniTask OnShowAsyncImplementImplement()
		{
			PinballMainRootViewBase.<OnShowAsyncImplementImplement>d__12 <OnShowAsyncImplementImplement>d__;
			<OnShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnShowAsyncImplementImplement>d__.<>4__this = this;
			<OnShowAsyncImplementImplement>d__.<>1__state = -1;
			<OnShowAsyncImplementImplement>d__.<>t__builder.Start<PinballMainRootViewBase.<OnShowAsyncImplementImplement>d__12>(ref <OnShowAsyncImplementImplement>d__);
			return <OnShowAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x06034B2B RID: 215851 RVA: 0x00EBC508 File Offset: 0x00EBA708
		protected override UniTask OnHideAsyncImplementImplement()
		{
			PinballMainRootViewBase.<OnHideAsyncImplementImplement>d__13 <OnHideAsyncImplementImplement>d__;
			<OnHideAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnHideAsyncImplementImplement>d__.<>4__this = this;
			<OnHideAsyncImplementImplement>d__.<>1__state = -1;
			<OnHideAsyncImplementImplement>d__.<>t__builder.Start<PinballMainRootViewBase.<OnHideAsyncImplementImplement>d__13>(ref <OnHideAsyncImplementImplement>d__);
			return <OnHideAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x06034B2C RID: 215852 RVA: 0x00EBC54C File Offset: 0x00EBA74C
		protected override UniTask OnDestroyAsyncImplementImplement()
		{
			PinballMainRootViewBase.<OnDestroyAsyncImplementImplement>d__14 <OnDestroyAsyncImplementImplement>d__;
			<OnDestroyAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnDestroyAsyncImplementImplement>d__.<>4__this = this;
			<OnDestroyAsyncImplementImplement>d__.<>1__state = -1;
			<OnDestroyAsyncImplementImplement>d__.<>t__builder.Start<PinballMainRootViewBase.<OnDestroyAsyncImplementImplement>d__14>(ref <OnDestroyAsyncImplementImplement>d__);
			return <OnDestroyAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x06034B2D RID: 215853 RVA: 0x00EBC590 File Offset: 0x00EBA790
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

		// Token: 0x06034B2E RID: 215854 RVA: 0x00EBC5DC File Offset: 0x00EBA7DC
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

		// Token: 0x06034B2F RID: 215855 RVA: 0x00EBC624 File Offset: 0x00EBA824
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

		// Token: 0x06034B30 RID: 215856 RVA: 0x00EBC670 File Offset: 0x00EBA870
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

		// Token: 0x06034B31 RID: 215857 RVA: 0x00EBC6A4 File Offset: 0x00EBA8A4
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

		// Token: 0x06034B32 RID: 215858 RVA: 0x00EBC6E8 File Offset: 0x00EBA8E8
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

		// Token: 0x06034B33 RID: 215859 RVA: 0x00EBC730 File Offset: 0x00EBA930
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

		// Token: 0x06034B34 RID: 215860 RVA: 0x00EBC77B File Offset: 0x00EBA97B
		public int GetChildViewStackNum()
		{
			return this.ChildViewStack.Size;
		}

		// Token: 0x06034B35 RID: 215861 RVA: 0x00EBC788 File Offset: 0x00EBA988
		protected PinballMainChildViewBase GetCurChildView()
		{
			return this.ChildViewStack.Peek();
		}

		// Token: 0x06034B36 RID: 215862 RVA: 0x00EBC798 File Offset: 0x00EBA998
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

		// Token: 0x06034B37 RID: 215863 RVA: 0x00EBC7F4 File Offset: 0x00EBA9F4
		public void PlaySequenceByName(string sequenceName)
		{
			this.UiViewSequence.StopSequenceByKey(sequenceName, false, false);
			this.UiViewSequence.PlaySequence(sequenceName, false, null);
		}

		// Token: 0x06034B38 RID: 215864 RVA: 0x00EBC828 File Offset: 0x00EBAA28
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

		// Token: 0x06034B39 RID: 215865 RVA: 0x00EBC873 File Offset: 0x00EBAA73
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

		// Token: 0x0401BE76 RID: 114294
		[Nullable(2)]
		public object ViewModel;

		// Token: 0x0401BE77 RID: 114295
		public int ActivityId;

		// Token: 0x0401BE78 RID: 114296
		[Nullable(2)]
		protected UUIItem ContentItem;

		// Token: 0x0401BE79 RID: 114297
		[Nullable(2)]
		protected string DefaultChildViewName;

		// Token: 0x0401BE7A RID: 114298
		private readonly Stack<PinballMainChildViewBase> ChildViewStack = new Stack<PinballMainChildViewBase>();

		// Token: 0x0401BE7B RID: 114299
		protected UiMask ViewMask = new UiMask();
	}
}
