using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Extension;
using CSharpScript.Game.Ui.Base;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02004632 RID: 17970
	[NullableContext(2)]
	[Nullable(0)]
	public class UiPanelBase : ComponentAction
	{
		// Token: 0x170075E4 RID: 30180
		// (get) Token: 0x0602E48B RID: 189579 RVA: 0x00AB3075 File Offset: 0x00AB1275
		// (set) Token: 0x0602E48C RID: 189580 RVA: 0x00AB307D File Offset: 0x00AB127D
		public bool SkipDestroyActor { get; set; }

		// Token: 0x0602E48D RID: 189581 RVA: 0x00AB3088 File Offset: 0x00AB1288
		public UiPanelBase()
		{
			this.MemoryTag = base.GetType().Name;
		}

		// Token: 0x0602E48E RID: 189582 RVA: 0x00AB3125 File Offset: 0x00AB1325
		protected virtual void OnRegisterComponent()
		{
		}

		// Token: 0x0602E48F RID: 189583 RVA: 0x00AB3127 File Offset: 0x00AB1327
		protected virtual void OnBeforeCreate()
		{
		}

		// Token: 0x0602E490 RID: 189584 RVA: 0x00AB3129 File Offset: 0x00AB1329
		protected virtual UniTask OnCreateAsync()
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x0602E491 RID: 189585 RVA: 0x00AB3130 File Offset: 0x00AB1330
		protected virtual UniTask OnBeforeStartAsync()
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x0602E492 RID: 189586 RVA: 0x00AB3137 File Offset: 0x00AB1337
		protected virtual void OnStart()
		{
		}

		// Token: 0x0602E493 RID: 189587 RVA: 0x00AB3139 File Offset: 0x00AB1339
		protected virtual void OnBeforeShow()
		{
		}

		// Token: 0x0602E494 RID: 189588 RVA: 0x00AB313B File Offset: 0x00AB133B
		protected virtual void OnAfterShow()
		{
		}

		// Token: 0x0602E495 RID: 189589 RVA: 0x00AB313D File Offset: 0x00AB133D
		protected virtual UniTask OnBeforeHideAsync()
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x0602E496 RID: 189590 RVA: 0x00AB3144 File Offset: 0x00AB1344
		protected virtual void OnBeforeHide()
		{
		}

		// Token: 0x0602E497 RID: 189591 RVA: 0x00AB3146 File Offset: 0x00AB1346
		protected virtual void OnAfterHide()
		{
		}

		// Token: 0x0602E498 RID: 189592 RVA: 0x00AB3148 File Offset: 0x00AB1348
		protected virtual void OnBeforeDestroy()
		{
		}

		// Token: 0x0602E499 RID: 189593 RVA: 0x00AB314A File Offset: 0x00AB134A
		protected virtual void OnAfterDestroy()
		{
		}

		// Token: 0x0602E49A RID: 189594 RVA: 0x00AB314C File Offset: 0x00AB134C
		protected virtual void OnAutoDestroy()
		{
		}

		// Token: 0x0602E49B RID: 189595 RVA: 0x00AB314E File Offset: 0x00AB134E
		protected virtual void OnBeforeCreateImplement()
		{
		}

		// Token: 0x0602E49C RID: 189596 RVA: 0x00AB3150 File Offset: 0x00AB1350
		protected virtual UniTask OnCreateAsyncImplementImplement()
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x0602E49D RID: 189597 RVA: 0x00AB3157 File Offset: 0x00AB1357
		protected virtual void OnAfterCreateImplement()
		{
		}

		// Token: 0x0602E49E RID: 189598 RVA: 0x00AB3159 File Offset: 0x00AB1359
		protected virtual void OnStartImplement()
		{
		}

		// Token: 0x0602E49F RID: 189599 RVA: 0x00AB315B File Offset: 0x00AB135B
		protected virtual UniTask OnBeforeShowAsyncImplement()
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x0602E4A0 RID: 189600 RVA: 0x00AB3162 File Offset: 0x00AB1362
		protected virtual void OnBeforeShowImplement()
		{
		}

		// Token: 0x0602E4A1 RID: 189601 RVA: 0x00AB3164 File Offset: 0x00AB1364
		protected virtual void OnAfterShowImplement()
		{
		}

		// Token: 0x0602E4A2 RID: 189602 RVA: 0x00AB3166 File Offset: 0x00AB1366
		protected virtual UniTask OnShowAsyncImplementImplement()
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x0602E4A3 RID: 189603 RVA: 0x00AB316D File Offset: 0x00AB136D
		protected virtual UniTask OnHideAsyncImplementImplement()
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x0602E4A4 RID: 189604 RVA: 0x00AB3174 File Offset: 0x00AB1374
		protected virtual UniTask OnDestroyAsyncImplementImplement()
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x0602E4A5 RID: 189605 RVA: 0x00AB317B File Offset: 0x00AB137B
		protected virtual void OnBeforeHideImplement()
		{
		}

		// Token: 0x0602E4A6 RID: 189606 RVA: 0x00AB317D File Offset: 0x00AB137D
		protected virtual void OnAfterHideImplement()
		{
		}

		// Token: 0x0602E4A7 RID: 189607 RVA: 0x00AB317F File Offset: 0x00AB137F
		protected virtual void OnBeforeDestroyImplement()
		{
		}

		// Token: 0x0602E4A8 RID: 189608 RVA: 0x00AB3181 File Offset: 0x00AB1381
		protected virtual void OnAfterDestroyImplement()
		{
		}

		// Token: 0x0602E4A9 RID: 189609 RVA: 0x00AB3184 File Offset: 0x00AB1384
		[NullableContext(0)]
		protected override UniTask<bool> OnCreateAsyncImplement()
		{
			UiPanelBase.<OnCreateAsyncImplement>d__51 <OnCreateAsyncImplement>d__;
			<OnCreateAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OnCreateAsyncImplement>d__.<>4__this = this;
			<OnCreateAsyncImplement>d__.<>1__state = -1;
			<OnCreateAsyncImplement>d__.<>t__builder.Start<UiPanelBase.<OnCreateAsyncImplement>d__51>(ref <OnCreateAsyncImplement>d__);
			return <OnCreateAsyncImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0602E4AA RID: 189610 RVA: 0x00AB31C8 File Offset: 0x00AB13C8
		protected override UniTask OnStartAsyncImplement()
		{
			UiPanelBase.<OnStartAsyncImplement>d__52 <OnStartAsyncImplement>d__;
			<OnStartAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnStartAsyncImplement>d__.<>4__this = this;
			<OnStartAsyncImplement>d__.<>1__state = -1;
			<OnStartAsyncImplement>d__.<>t__builder.Start<UiPanelBase.<OnStartAsyncImplement>d__52>(ref <OnStartAsyncImplement>d__);
			return <OnStartAsyncImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0602E4AB RID: 189611 RVA: 0x00AB320C File Offset: 0x00AB140C
		protected override void OnStartImplementCompatible()
		{
			this.OnStartImplement();
			this.OnStart();
			foreach (UiBehaviorBaseProxy uiBehaviorBaseProxy in this.UiBehaviorProxies)
			{
				uiBehaviorBaseProxy.StartCompatible();
			}
			foreach (UiPanelBase uiPanelBase in this.Children)
			{
				uiPanelBase.StartCompatible();
			}
		}

		// Token: 0x0602E4AC RID: 189612 RVA: 0x00AB32A8 File Offset: 0x00AB14A8
		protected override UniTask OnShowAsyncImplement()
		{
			UiPanelBase.<OnShowAsyncImplement>d__54 <OnShowAsyncImplement>d__;
			<OnShowAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnShowAsyncImplement>d__.<>4__this = this;
			<OnShowAsyncImplement>d__.<>1__state = -1;
			<OnShowAsyncImplement>d__.<>t__builder.Start<UiPanelBase.<OnShowAsyncImplement>d__54>(ref <OnShowAsyncImplement>d__);
			return <OnShowAsyncImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0602E4AD RID: 189613 RVA: 0x00AB32EB File Offset: 0x00AB14EB
		protected virtual void OnShowAsyncImplementImplementCompatible()
		{
		}

		// Token: 0x0602E4AE RID: 189614 RVA: 0x00AB32F0 File Offset: 0x00AB14F0
		protected override void OnShowImplementCompatible()
		{
			this.OnBeforeShowImplement();
			this.OnBeforeShow();
			this.SetUiActive(true);
			this.OnShowAsyncImplementImplementCompatible();
			foreach (UiBehaviorBaseProxy uiBehaviorBaseProxy in this.UiBehaviorProxies)
			{
				uiBehaviorBaseProxy.ShowCompatible();
			}
			foreach (UiPanelBase uiPanelBase in this.Children)
			{
				uiPanelBase.ShowCompatible();
			}
			this.OnAfterShowImplement();
			this.OnAfterShow();
		}

		// Token: 0x0602E4AF RID: 189615 RVA: 0x00AB33A4 File Offset: 0x00AB15A4
		protected override UniTask OnHideAsyncImplement()
		{
			UiPanelBase.<OnHideAsyncImplement>d__57 <OnHideAsyncImplement>d__;
			<OnHideAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnHideAsyncImplement>d__.<>4__this = this;
			<OnHideAsyncImplement>d__.<>1__state = -1;
			<OnHideAsyncImplement>d__.<>t__builder.Start<UiPanelBase.<OnHideAsyncImplement>d__57>(ref <OnHideAsyncImplement>d__);
			return <OnHideAsyncImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0602E4B0 RID: 189616 RVA: 0x00AB33E7 File Offset: 0x00AB15E7
		protected virtual void OnHideAsyncImplementImplementCompatible()
		{
		}

		// Token: 0x0602E4B1 RID: 189617 RVA: 0x00AB33EC File Offset: 0x00AB15EC
		protected override void OnHideImplementCompatible()
		{
			this.OnBeforeHide();
			this.OnBeforeHideImplement();
			foreach (UiBehaviorBaseProxy uiBehaviorBaseProxy in this.UiBehaviorProxies)
			{
				uiBehaviorBaseProxy.HideCompatible();
			}
			foreach (UiPanelBase uiPanelBase in this.Children)
			{
				uiPanelBase.HideCompatible();
			}
			this.OnHideAsyncImplementImplementCompatible();
			this.SetUiActive(false);
			this.OnAfterHide();
			this.OnAfterHideImplement();
		}

		// Token: 0x0602E4B2 RID: 189618 RVA: 0x00AB34A0 File Offset: 0x00AB16A0
		protected override UniTask OnDestroyAsyncImplement()
		{
			UiPanelBase.<OnDestroyAsyncImplement>d__60 <OnDestroyAsyncImplement>d__;
			<OnDestroyAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnDestroyAsyncImplement>d__.<>4__this = this;
			<OnDestroyAsyncImplement>d__.<>1__state = -1;
			<OnDestroyAsyncImplement>d__.<>t__builder.Start<UiPanelBase.<OnDestroyAsyncImplement>d__60>(ref <OnDestroyAsyncImplement>d__);
			return <OnDestroyAsyncImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0602E4B3 RID: 189619 RVA: 0x00AB34E3 File Offset: 0x00AB16E3
		protected virtual void OnDestroyAsyncImplementImplementCompatible()
		{
		}

		// Token: 0x0602E4B4 RID: 189620 RVA: 0x00AB34E8 File Offset: 0x00AB16E8
		protected override void OnDestroyImplementCompatible()
		{
			this.CancelAllAsyncTask();
			this.OnBeforeDestroy();
			this.OnBeforeDestroyImplement();
			foreach (UiBehaviorBaseProxy uiBehaviorBaseProxy in this.UiBehaviorProxies)
			{
				uiBehaviorBaseProxy.DestroyCompatible();
			}
			foreach (UiPanelBase uiPanelBase in new List<UiPanelBase>(this.Children))
			{
				uiPanelBase.DestroyCompatible();
			}
			this.OnDestroyAsyncImplementImplementCompatible();
			this.DestroyPrivate();
			this.OnAfterDestroy();
			this.OnAfterDestroyImplement();
		}

		// Token: 0x0602E4B5 RID: 189621 RVA: 0x00AB35A8 File Offset: 0x00AB17A8
		[NullableContext(1)]
		public void SetRootActorLoadInfoByPath(string actorPath, [Nullable(2)] UUIItem parentItem = null, bool usePool = false, bool isPermanent = false)
		{
			this._actorPath = actorPath;
			this.ParentUiItem = parentItem;
			this.UsePool = usePool;
			this._isPermanent = isPermanent;
		}

		// Token: 0x0602E4B6 RID: 189622 RVA: 0x00AB35C7 File Offset: 0x00AB17C7
		[NullableContext(1)]
		public void SetRootActorLoadInfo(string resourceId, [Nullable(2)] UUIItem parentItem = null, bool usePool = false, bool isPermanent = false)
		{
			this._actorPath = UiResourceConfig.Instance.GetResourcePath(resourceId);
			this.ParentUiItem = parentItem;
			this.UsePool = usePool;
			this._isPermanent = isPermanent;
		}

		// Token: 0x0602E4B7 RID: 189623 RVA: 0x00AB35F0 File Offset: 0x00AB17F0
		[NullableContext(1)]
		public UniTask CreateThenShowByResourceIdAsync(string resourceId, [Nullable(2)] UUIItem parentItem = null, bool usePool = false)
		{
			UiPanelBase.<CreateThenShowByResourceIdAsync>d__65 <CreateThenShowByResourceIdAsync>d__;
			<CreateThenShowByResourceIdAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateThenShowByResourceIdAsync>d__.<>4__this = this;
			<CreateThenShowByResourceIdAsync>d__.resourceId = resourceId;
			<CreateThenShowByResourceIdAsync>d__.parentItem = parentItem;
			<CreateThenShowByResourceIdAsync>d__.usePool = usePool;
			<CreateThenShowByResourceIdAsync>d__.<>1__state = -1;
			<CreateThenShowByResourceIdAsync>d__.<>t__builder.Start<UiPanelBase.<CreateThenShowByResourceIdAsync>d__65>(ref <CreateThenShowByResourceIdAsync>d__);
			return <CreateThenShowByResourceIdAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602E4B8 RID: 189624 RVA: 0x00AB364C File Offset: 0x00AB184C
		[NullableContext(1)]
		public UniTask CreateByResourceIdAsync(string resourceId, [Nullable(2)] UUIItem parentItem = null, bool usePool = false)
		{
			UiPanelBase.<CreateByResourceIdAsync>d__66 <CreateByResourceIdAsync>d__;
			<CreateByResourceIdAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateByResourceIdAsync>d__.<>4__this = this;
			<CreateByResourceIdAsync>d__.resourceId = resourceId;
			<CreateByResourceIdAsync>d__.parentItem = parentItem;
			<CreateByResourceIdAsync>d__.usePool = usePool;
			<CreateByResourceIdAsync>d__.<>1__state = -1;
			<CreateByResourceIdAsync>d__.<>t__builder.Start<UiPanelBase.<CreateByResourceIdAsync>d__66>(ref <CreateByResourceIdAsync>d__);
			return <CreateByResourceIdAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602E4B9 RID: 189625 RVA: 0x00AB36A8 File Offset: 0x00AB18A8
		[NullableContext(1)]
		public UniTask CreateByPathAsync(string path, [Nullable(2)] UUIItem parentItem = null, bool usePool = false)
		{
			UiPanelBase.<CreateByPathAsync>d__67 <CreateByPathAsync>d__;
			<CreateByPathAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateByPathAsync>d__.<>4__this = this;
			<CreateByPathAsync>d__.path = path;
			<CreateByPathAsync>d__.parentItem = parentItem;
			<CreateByPathAsync>d__.usePool = usePool;
			<CreateByPathAsync>d__.<>1__state = -1;
			<CreateByPathAsync>d__.<>t__builder.Start<UiPanelBase.<CreateByPathAsync>d__67>(ref <CreateByPathAsync>d__);
			return <CreateByPathAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602E4BA RID: 189626 RVA: 0x00AB3704 File Offset: 0x00AB1904
		[NullableContext(1)]
		public UniTask OnlyCreateByPathAsync(string path, [Nullable(2)] UUIItem parentItem = null, bool usePool = false)
		{
			UiPanelBase.<OnlyCreateByPathAsync>d__68 <OnlyCreateByPathAsync>d__;
			<OnlyCreateByPathAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnlyCreateByPathAsync>d__.<>4__this = this;
			<OnlyCreateByPathAsync>d__.path = path;
			<OnlyCreateByPathAsync>d__.parentItem = parentItem;
			<OnlyCreateByPathAsync>d__.usePool = usePool;
			<OnlyCreateByPathAsync>d__.<>1__state = -1;
			<OnlyCreateByPathAsync>d__.<>t__builder.Start<UiPanelBase.<OnlyCreateByPathAsync>d__68>(ref <OnlyCreateByPathAsync>d__);
			return <OnlyCreateByPathAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602E4BB RID: 189627 RVA: 0x00AB3760 File Offset: 0x00AB1960
		[NullableContext(1)]
		public UniTask CreateThenShowByPathAsync(string path, [Nullable(2)] UUIItem parentItem = null, bool usePool = false)
		{
			UiPanelBase.<CreateThenShowByPathAsync>d__69 <CreateThenShowByPathAsync>d__;
			<CreateThenShowByPathAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateThenShowByPathAsync>d__.<>4__this = this;
			<CreateThenShowByPathAsync>d__.path = path;
			<CreateThenShowByPathAsync>d__.parentItem = parentItem;
			<CreateThenShowByPathAsync>d__.usePool = usePool;
			<CreateThenShowByPathAsync>d__.<>1__state = -1;
			<CreateThenShowByPathAsync>d__.<>t__builder.Start<UiPanelBase.<CreateThenShowByPathAsync>d__69>(ref <CreateThenShowByPathAsync>d__);
			return <CreateThenShowByPathAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602E4BC RID: 189628 RVA: 0x00AB37BC File Offset: 0x00AB19BC
		[NullableContext(1)]
		public UniTask CreateThenShowByActorAsync(AActor actor, [Nullable(2)] object parameters = null, bool usePool = false)
		{
			UiPanelBase.<CreateThenShowByActorAsync>d__70 <CreateThenShowByActorAsync>d__;
			<CreateThenShowByActorAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateThenShowByActorAsync>d__.<>4__this = this;
			<CreateThenShowByActorAsync>d__.actor = actor;
			<CreateThenShowByActorAsync>d__.parameters = parameters;
			<CreateThenShowByActorAsync>d__.usePool = usePool;
			<CreateThenShowByActorAsync>d__.<>1__state = -1;
			<CreateThenShowByActorAsync>d__.<>t__builder.Start<UiPanelBase.<CreateThenShowByActorAsync>d__70>(ref <CreateThenShowByActorAsync>d__);
			return <CreateThenShowByActorAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602E4BD RID: 189629 RVA: 0x00AB3818 File Offset: 0x00AB1A18
		[NullableContext(1)]
		public UniTask CreateByActorAsync(AActor actor, [Nullable(2)] object parameters = null, bool usePool = false)
		{
			UiPanelBase.<CreateByActorAsync>d__71 <CreateByActorAsync>d__;
			<CreateByActorAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateByActorAsync>d__.<>4__this = this;
			<CreateByActorAsync>d__.actor = actor;
			<CreateByActorAsync>d__.parameters = parameters;
			<CreateByActorAsync>d__.usePool = usePool;
			<CreateByActorAsync>d__.<>1__state = -1;
			<CreateByActorAsync>d__.<>t__builder.Start<UiPanelBase.<CreateByActorAsync>d__71>(ref <CreateByActorAsync>d__);
			return <CreateByActorAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602E4BE RID: 189630 RVA: 0x00AB3874 File Offset: 0x00AB1A74
		[NullableContext(1)]
		public UniTask OnlyCreateByActorAsync(AActor actor, [Nullable(2)] object parameters = null, bool usePool = false)
		{
			UiPanelBase.<OnlyCreateByActorAsync>d__72 <OnlyCreateByActorAsync>d__;
			<OnlyCreateByActorAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnlyCreateByActorAsync>d__.<>4__this = this;
			<OnlyCreateByActorAsync>d__.actor = actor;
			<OnlyCreateByActorAsync>d__.parameters = parameters;
			<OnlyCreateByActorAsync>d__.usePool = usePool;
			<OnlyCreateByActorAsync>d__.<>1__state = -1;
			<OnlyCreateByActorAsync>d__.<>t__builder.Start<UiPanelBase.<OnlyCreateByActorAsync>d__72>(ref <OnlyCreateByActorAsync>d__);
			return <OnlyCreateByActorAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602E4BF RID: 189631 RVA: 0x00AB38CF File Offset: 0x00AB1ACF
		public virtual void SetActive(bool visibility)
		{
			if (visibility)
			{
				base.Show(null);
				return;
			}
			base.Hide(null);
		}

		// Token: 0x0602E4C0 RID: 189632 RVA: 0x00AB38E3 File Offset: 0x00AB1AE3
		public bool GetActive()
		{
			return this.RootItem != null && this.RootItem.IsValid() && this.RootItem.IsUIActiveSelf();
		}

		// Token: 0x0602E4C1 RID: 189633 RVA: 0x00AB3907 File Offset: 0x00AB1B07
		public bool IsUiActiveInHierarchy()
		{
			return this.RootItem != null && this.RootItem.IsValid() && this.RootItem.IsUIActiveInHierarchy();
		}

		// Token: 0x0602E4C2 RID: 189634 RVA: 0x00AB392B File Offset: 0x00AB1B2B
		public void SetUiActive(bool visibility)
		{
			if (this.RootItem == null || !this.RootItem.IsValid())
			{
				return;
			}
			this.RootItem.SetUIActive(visibility);
		}

		// Token: 0x0602E4C3 RID: 189635 RVA: 0x00AB394F File Offset: 0x00AB1B4F
		public bool InAsyncLoading()
		{
			return base.IsCreating;
		}

		// Token: 0x0602E4C4 RID: 189636 RVA: 0x00AB3958 File Offset: 0x00AB1B58
		private UniTask LoadRootActorAsync()
		{
			UiPanelBase.<LoadRootActorAsync>d__78 <LoadRootActorAsync>d__;
			<LoadRootActorAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadRootActorAsync>d__.<>4__this = this;
			<LoadRootActorAsync>d__.<>1__state = -1;
			<LoadRootActorAsync>d__.<>t__builder.Start<UiPanelBase.<LoadRootActorAsync>d__78>(ref <LoadRootActorAsync>d__);
			return <LoadRootActorAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602E4C5 RID: 189637 RVA: 0x00AB399C File Offset: 0x00AB1B9C
		[NullableContext(1)]
		private unsafe bool SetActor(AActor actor)
		{
			AUIBaseActor auibaseActor = actor as AUIBaseActor;
			if (auibaseActor == null || !auibaseActor.IsValid())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiCore;
				ELogAuthor author = ELogAuthor.TL;
				string message = "[SetActor] actor is not UIBaseActor";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("uiActor", (auibaseActor != null) ? auibaseActor.GetName() : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("path", LguiUtil.Instance.GetActorFullPath(auibaseActor));
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return false;
			}
			this._originalActor = auibaseActor;
			this._originalItem = (this._originalActor.GetComponentByClass(UUIItem.StaticClass()) as UUIItem);
			this.InitRootActorAndComponentRegistry();
			this.InitGuideRegistry();
			this.BindOnClickEvents();
			this.SetUiActive(false);
			this._originalActor.OnPreDestroyed.Add(new Action<AActor>(this.AutoDestroy));
			if (this.RootActor != this._originalActor)
			{
				AUIBaseActor rootActor = this.RootActor;
				if (rootActor != null)
				{
					rootActor.OnPreDestroyed.Add(new Action<AActor>(this.DestroyCheck));
				}
			}
			return true;
		}

		// Token: 0x0602E4C6 RID: 189638 RVA: 0x00AB3AB2 File Offset: 0x00AB1CB2
		private void RefreshMemoryTag()
		{
			if (this._originalItem != null && this._originalItem.IsValid())
			{
				this.MemoryTag = LguiUtil.Instance.GetRootActorMemoryTag(this._originalItem, null);
			}
		}

		// Token: 0x0602E4C7 RID: 189639 RVA: 0x00AB3AE0 File Offset: 0x00AB1CE0
		private void InitRootActorAndComponentRegistry()
		{
			this.OnRegisterComponent();
			this.RootActor = (this.FindInitedComponentRegistryActor() ?? this._originalActor);
			AUIBaseActor rootActor = this.RootActor;
			this.RootItem = (((rootActor != null) ? rootActor.GetComponentByClass(UUIItem.StaticClass()) : null) as UUIItem);
		}

		// Token: 0x0602E4C8 RID: 189640 RVA: 0x00AB3B30 File Offset: 0x00AB1D30
		private unsafe AUIBaseActor FindInitedComponentRegistryActor()
		{
			AUIBaseActor originalActor = this._originalActor;
			ULGUIComponentsRegistry componentsRegistry = LguiUtil.Instance.GetComponentsRegistry(originalActor);
			AUIBaseActor auibaseActor = originalActor;
			if (componentsRegistry == null)
			{
				if (originalActor != null)
				{
					auibaseActor = LguiUtil.Instance.GetChildActorByHierarchyIndex(originalActor, 0);
				}
				if (auibaseActor != null)
				{
					componentsRegistry = LguiUtil.Instance.GetComponentsRegistry(auibaseActor);
					if (componentsRegistry == null)
					{
						auibaseActor = LguiUtil.Instance.GetChildActorByHierarchyIndex(auibaseActor, 0);
						if (auibaseActor != null)
						{
							componentsRegistry = LguiUtil.Instance.GetComponentsRegistry(auibaseActor);
						}
					}
				}
			}
			if (componentsRegistry == null)
			{
				return null;
			}
			int num = componentsRegistry.Components.Num();
			foreach (ValueTuple<int, Type> valueTuple in this.ComponentRegisterInfos)
			{
				int item = valueTuple.Item1;
				if (item < num)
				{
					AActor aactor = componentsRegistry.Components.Get(item);
					Func<UClassStackOnlyPtr> func;
					if (UiPanelBase.StaticClassGetters.TryGetValue(valueTuple.Item2, out func))
					{
						UActorComponent uactorComponent = (aactor != null) ? aactor.GetComponentByClass(func()) : null;
						if (uactorComponent == null)
						{
							Log instance = Log.Instance;
							ELogModule module = ELogModule.UiCore;
							ELogAuthor author = ELogAuthor.TL;
							string message = "[FindInitedComponentRegistryActor]请该UI负责人和程序检查以下路径的LGUIComponentsRegistry组件, 检查是否缺失以下类型的组件";
							<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("节点全路径为", LguiUtil.Instance.GetActorFullPath(auibaseActor));
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("缺失组件的索引为", valueTuple.Item1);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("缺失的组件类型为", valueTuple.Item2.Name);
							instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
						}
						else
						{
							this.BaseComponentMap[valueTuple.Item1] = new Tuple<Type, UActorComponent>(uactorComponent.GetType(), uactorComponent);
							this.BindAudioEvents(uactorComponent.GetType(), uactorComponent);
						}
					}
					else
					{
						Log instance2 = Log.Instance;
						ELogModule module2 = ELogModule.UiCore;
						ELogAuthor author2 = ELogAuthor.TL;
						string message2 = "[FindInitedComponentRegistryActor] C#环境下, 组件类型未在StaticClassGetters中注册, 请在UiPanelBase.StaticClassGetters中补充该类型";
						<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray4<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("节点全路径为", LguiUtil.Instance.GetActorFullPath(auibaseActor));
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("组件的索引为", valueTuple.Item1);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("未注册的组件类型为", valueTuple.Item2.Name);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("TsClassName", base.GetType().Name);
						instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 4));
					}
				}
			}
			return auibaseActor;
		}

		// Token: 0x0602E4C9 RID: 189641 RVA: 0x00AB3DC8 File Offset: 0x00AB1FC8
		protected virtual bool DestroyOverride()
		{
			return false;
		}

		// Token: 0x0602E4CA RID: 189642 RVA: 0x00AB3DCC File Offset: 0x00AB1FCC
		private void DestroyPrivate()
		{
			this.UnBindOnClickEvents();
			this.UnBindAllAudioEvents();
			this.ClearUiResourceLoadModule();
			this.ClearUiPrefabLoadModule();
			this.BaseComponentMap.Clear();
			this.BtnBindInfo.Clear();
			this.Children.Clear();
			this.RemoveFromParent();
			this.UiBehaviorProxies.Clear();
			this.OpenParam = null;
			this.DestroyActor();
		}

		// Token: 0x0602E4CB RID: 189643 RVA: 0x00AB3E30 File Offset: 0x00AB2030
		private void DestroyActor()
		{
			if (this.SkipDestroyActor)
			{
				return;
			}
			AUIBaseActor originalActor = this._originalActor;
			if (originalActor != null && originalActor.IsValid())
			{
				this._originalActor.OnPreDestroyed.Remove(new Action<AActor>(this.AutoDestroy));
			}
			AUIBaseActor rootActor = this.RootActor;
			if (rootActor != null && rootActor.IsValid())
			{
				this.RootActor.OnPreDestroyed.Remove(new Action<AActor>(this.DestroyCheck));
			}
			if (!this.DestroyOverride())
			{
				if (this.UsePool)
				{
					this.RecycleAsyncLoad();
				}
				else if (this._originalActor != null && this._originalActor.IsValid())
				{
					ULGUIBPLibrary.DestroyActorWithHierarchy(this._originalActor, true);
				}
			}
			this._originalActor = null;
			this.RootActor = null;
			this.RootItem = null;
		}

		// Token: 0x0602E4CC RID: 189644 RVA: 0x00AB3EF4 File Offset: 0x00AB20F4
		private void AutoDestroy(AActor aActor)
		{
			if (base.IsDestroyOrDestroying)
			{
				return;
			}
			this.OnAutoDestroy();
			base.Destroy(null);
		}

		// Token: 0x0602E4CD RID: 189645 RVA: 0x00AB3F0C File Offset: 0x00AB210C
		private void DestroyCheck(AActor aActor)
		{
			if (base.IsDestroyOrDestroying || this.WaitToDestroy)
			{
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.UiComponent;
			ELogAuthor author = ELogAuthor.YYZ;
			string message = "对象已销毁,生命周期不同步请检查";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Ts类名", base.GetType().Name);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x0602E4CE RID: 189646 RVA: 0x00AB3F5B File Offset: 0x00AB215B
		public UUIItem GetRootItem()
		{
			return this.RootItem;
		}

		// Token: 0x0602E4CF RID: 189647 RVA: 0x00AB3F63 File Offset: 0x00AB2163
		public AActor GetRootActor()
		{
			return this.RootActor;
		}

		// Token: 0x0602E4D0 RID: 189648 RVA: 0x00AB3F6B File Offset: 0x00AB216B
		public AActor GetOriginalActor()
		{
			return this._originalActor;
		}

		// Token: 0x0602E4D1 RID: 189649 RVA: 0x00AB3F73 File Offset: 0x00AB2173
		public virtual UUIItem GetOriginalItem()
		{
			return this._originalItem;
		}

		// Token: 0x0602E4D2 RID: 189650 RVA: 0x00AB3F7B File Offset: 0x00AB217B
		public virtual CustomPromise GetClosePromiseImplement()
		{
			return null;
		}

		// Token: 0x0602E4D3 RID: 189651 RVA: 0x00AB3F7E File Offset: 0x00AB217E
		private void RecycleAsyncLoad()
		{
			UiActorPool.Instance.RecycleAsync(this.UiPoolActorNew, this._actorPath);
			this.UiPoolActorNew = null;
		}

		// Token: 0x0602E4D4 RID: 189652 RVA: 0x00AB3FA0 File Offset: 0x00AB21A0
		[NullableContext(1)]
		private void BindAudioEvents(Type type, UActorComponent component)
		{
			if (!(type == typeof(UUIButtonComponent)))
			{
				if (type == typeof(UUIExtendToggle))
				{
					UUIExtendToggle uuiextendToggle = component as UUIExtendToggle;
					if (uuiextendToggle != null)
					{
						uuiextendToggle.OnPostAudioEvent.Bind(new Action<string>(this.PostClickAudioEvent));
					}
					if (uuiextendToggle == null)
					{
						return;
					}
					uuiextendToggle.OnPostAudioStateEvent.Bind(delegate(EToggleAudioTransitionState state, string eventPath)
					{
						this.PostClickAudioEvent(eventPath);
					});
				}
				return;
			}
			UUIButtonComponent uuibuttonComponent = component as UUIButtonComponent;
			if (uuibuttonComponent != null)
			{
				uuibuttonComponent.OnPostAudioEvent.Bind(new Action<string>(this.PostClickAudioEvent));
			}
			if (uuibuttonComponent == null)
			{
				return;
			}
			uuibuttonComponent.OnPostAudioStateEvent.Bind(delegate(EButtonAudioStateTransferType state, string eventPath)
			{
				this.PostClickAudioEvent(eventPath);
			});
		}

		// Token: 0x0602E4D5 RID: 189653 RVA: 0x00AB4050 File Offset: 0x00AB2250
		private void UnBindAllAudioEvents()
		{
			foreach (KeyValuePair<int, Tuple<Type, UActorComponent>> keyValuePair in this.BaseComponentMap)
			{
				Type item = keyValuePair.Value.Item1;
				UActorComponent item2 = keyValuePair.Value.Item2;
				if (item == typeof(UUIButtonComponent))
				{
					UUIButtonComponent uuibuttonComponent = item2 as UUIButtonComponent;
					if (uuibuttonComponent != null)
					{
						uuibuttonComponent.OnPostAudioEvent.Unbind();
					}
					if (uuibuttonComponent != null)
					{
						uuibuttonComponent.OnPostAudioStateEvent.Unbind();
					}
				}
				else if (item == typeof(UUIExtendToggle))
				{
					UUIExtendToggle uuiextendToggle = item2 as UUIExtendToggle;
					if (uuiextendToggle != null)
					{
						uuiextendToggle.OnPostAudioEvent.Unbind();
					}
					if (uuiextendToggle != null)
					{
						uuiextendToggle.OnPostAudioStateEvent.Unbind();
					}
				}
			}
		}

		// Token: 0x0602E4D6 RID: 189654 RVA: 0x00AB4130 File Offset: 0x00AB2330
		protected unsafe void BindOnClickEvents()
		{
			foreach (ValueTuple<int, Delegate> valueTuple in this.BtnBindInfo)
			{
				if (this.BaseComponentMap.ContainsKey(valueTuple.Item1))
				{
					this.BindOnClickEvent(valueTuple.Item1, valueTuple.Item2);
				}
				else
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.UiComponent;
					ELogAuthor author = ELogAuthor.HCW;
					string message = "检查BtnBindInfo中的项是否没有在ComponentsRegisterInfo中注册";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Name", base.GetType().Name);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ComponentId", valueTuple.Item1);
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				}
			}
		}

		// Token: 0x0602E4D7 RID: 189655 RVA: 0x00AB4210 File Offset: 0x00AB2410
		[NullableContext(1)]
		protected void BindOnClickEvent(int name, Delegate fn)
		{
			Tuple<Type, UActorComponent> tuple;
			if (!this.BaseComponentMap.TryGetValue(name, out tuple))
			{
				return;
			}
			UActorComponent item = tuple.Item2;
			UUIButtonComponent uuibuttonComponent = item as UUIButtonComponent;
			if (uuibuttonComponent != null)
			{
				UiComponentActionBinder.BindClickEvent(name, uuibuttonComponent, fn);
				return;
			}
			UUIToggleComponent uuitoggleComponent = item as UUIToggleComponent;
			if (uuitoggleComponent != null)
			{
				UiComponentActionBinder.BindClickEvent(name, uuitoggleComponent, fn);
				return;
			}
			UUIExtendToggle uuiextendToggle = item as UUIExtendToggle;
			if (uuiextendToggle != null)
			{
				UiComponentActionBinder.BindClickEvent(name, uuiextendToggle, fn);
				return;
			}
			UUISliderComponent uuisliderComponent = item as UUISliderComponent;
			if (uuisliderComponent != null)
			{
				UiComponentActionBinder.BindClickEvent(name, uuisliderComponent, fn);
				return;
			}
			UUITextInputComponent uuitextInputComponent = item as UUITextInputComponent;
			if (uuitextInputComponent == null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 2);
				defaultInterpolatedStringHandler.AppendLiteral("未支持的事件绑定组件类型: ");
				defaultInterpolatedStringHandler.AppendFormatted(tuple.Item1.Name);
				defaultInterpolatedStringHandler.AppendLiteral(" (组件ID: ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(name);
				defaultInterpolatedStringHandler.AppendLiteral(")");
				throw new NotImplementedException(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			UiComponentActionBinder.BindClickEvent(name, uuitextInputComponent, fn);
		}

		// Token: 0x0602E4D8 RID: 189656 RVA: 0x00AB42F8 File Offset: 0x00AB24F8
		protected void UnBindOnClickEvents()
		{
			foreach (ValueTuple<int, Delegate> valueTuple in this.BtnBindInfo)
			{
				this.UnBindOnClickEvent(valueTuple.Item1);
			}
		}

		// Token: 0x0602E4D9 RID: 189657 RVA: 0x00AB4350 File Offset: 0x00AB2550
		protected void UnBindOnClickEvent(int name)
		{
			Tuple<Type, UActorComponent> tuple;
			if (!this.BaseComponentMap.TryGetValue(name, out tuple))
			{
				return;
			}
			UActorComponent item = tuple.Item2;
			UUIButtonComponent uuibuttonComponent = item as UUIButtonComponent;
			if (uuibuttonComponent != null)
			{
				uuibuttonComponent.OnClickCallBack.Unbind();
				return;
			}
			UUIToggleComponent uuitoggleComponent = item as UUIToggleComponent;
			if (uuitoggleComponent != null)
			{
				uuitoggleComponent.OnToggleEvent.Unbind();
				return;
			}
			UUIExtendToggle uuiextendToggle = item as UUIExtendToggle;
			if (uuiextendToggle != null)
			{
				uuiextendToggle.OnStateChange.Clear();
				uuiextendToggle.CanExecuteChange.Unbind();
				return;
			}
			UUISliderComponent uuisliderComponent = item as UUISliderComponent;
			if (uuisliderComponent != null)
			{
				uuisliderComponent.OnValueChangeCb.Unbind();
				return;
			}
			UUITextInputComponent uuitextInputComponent = item as UUITextInputComponent;
			if (uuitextInputComponent == null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 2);
				defaultInterpolatedStringHandler.AppendLiteral("未支持的取消事件绑定组件类型: ");
				defaultInterpolatedStringHandler.AppendFormatted(tuple.Item1.Name);
				defaultInterpolatedStringHandler.AppendLiteral(" (组件ID: ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(name);
				defaultInterpolatedStringHandler.AppendLiteral(")");
				throw new NotImplementedException(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			uuitextInputComponent.OnInputActivateDelegate.Unbind();
		}

		// Token: 0x0602E4DA RID: 189658 RVA: 0x00AB4450 File Offset: 0x00AB2650
		[NullableContext(1)]
		protected void PostClickAudioEvent(string eventPath)
		{
			string text = AudioSystem.Instance.parseAudioEventPath(eventPath);
			if (text != null)
			{
				AudioSystem.Instance.PostEvent(text);
			}
		}

		// Token: 0x0602E4DB RID: 189659 RVA: 0x00AB4478 File Offset: 0x00AB2678
		protected UUIButtonComponent GetButton(int name)
		{
			Tuple<Type, UActorComponent> tuple;
			if (!this.BaseComponentMap.TryGetValue(name, out tuple))
			{
				return null;
			}
			return tuple.Item2 as UUIButtonComponent;
		}

		// Token: 0x0602E4DC RID: 189660 RVA: 0x00AB44A4 File Offset: 0x00AB26A4
		protected UUIItem GetItem(int name)
		{
			Tuple<Type, UActorComponent> tuple;
			if (!this.BaseComponentMap.TryGetValue(name, out tuple))
			{
				return null;
			}
			return tuple.Item2 as UUIItem;
		}

		// Token: 0x0602E4DD RID: 189661 RVA: 0x00AB44D0 File Offset: 0x00AB26D0
		protected USpineSkeletonAnimationComponent GetSpine(int name)
		{
			Tuple<Type, UActorComponent> tuple;
			if (!this.BaseComponentMap.TryGetValue(name, out tuple))
			{
				return null;
			}
			return tuple.Item2 as USpineSkeletonAnimationComponent;
		}

		// Token: 0x0602E4DE RID: 189662 RVA: 0x00AB44FC File Offset: 0x00AB26FC
		protected UUIInteractionGroup GetInteractionGroup(int name)
		{
			Tuple<Type, UActorComponent> tuple;
			if (!this.BaseComponentMap.TryGetValue(name, out tuple))
			{
				return null;
			}
			return tuple.Item2 as UUIInteractionGroup;
		}

		// Token: 0x0602E4DF RID: 189663 RVA: 0x00AB4528 File Offset: 0x00AB2728
		protected UUIText GetText(int name)
		{
			Tuple<Type, UActorComponent> tuple;
			if (!this.BaseComponentMap.TryGetValue(name, out tuple))
			{
				return null;
			}
			return tuple.Item2 as UUIText;
		}

		// Token: 0x0602E4E0 RID: 189664 RVA: 0x00AB4554 File Offset: 0x00AB2754
		protected UUIArtText GetArtText(int name)
		{
			Tuple<Type, UActorComponent> tuple;
			if (!this.BaseComponentMap.TryGetValue(name, out tuple))
			{
				return null;
			}
			return tuple.Item2 as UUIArtText;
		}

		// Token: 0x0602E4E1 RID: 189665 RVA: 0x00AB4580 File Offset: 0x00AB2780
		protected UUISprite GetSprite(int name)
		{
			Tuple<Type, UActorComponent> tuple;
			if (!this.BaseComponentMap.TryGetValue(name, out tuple))
			{
				return null;
			}
			return tuple.Item2 as UUISprite;
		}

		// Token: 0x0602E4E2 RID: 189666 RVA: 0x00AB45AC File Offset: 0x00AB27AC
		protected UUITexture GetTexture(int name)
		{
			Tuple<Type, UActorComponent> tuple;
			if (!this.BaseComponentMap.TryGetValue(name, out tuple))
			{
				return null;
			}
			return tuple.Item2 as UUITexture;
		}

		// Token: 0x0602E4E3 RID: 189667 RVA: 0x00AB45D8 File Offset: 0x00AB27D8
		protected UUILangTexture GetLangTexture(int name)
		{
			Tuple<Type, UActorComponent> tuple;
			if (!this.BaseComponentMap.TryGetValue(name, out tuple))
			{
				return null;
			}
			return tuple.Item2 as UUILangTexture;
		}

		// Token: 0x0602E4E4 RID: 189668 RVA: 0x00AB4604 File Offset: 0x00AB2804
		protected UUISliderComponent GetSlider(int name)
		{
			Tuple<Type, UActorComponent> tuple;
			if (!this.BaseComponentMap.TryGetValue(name, out tuple))
			{
				return null;
			}
			return tuple.Item2 as UUISliderComponent;
		}

		// Token: 0x0602E4E5 RID: 189669 RVA: 0x00AB4630 File Offset: 0x00AB2830
		protected UUIToggleComponent GetToggle(int name)
		{
			Tuple<Type, UActorComponent> tuple;
			if (!this.BaseComponentMap.TryGetValue(name, out tuple))
			{
				return null;
			}
			return tuple.Item2 as UUIToggleComponent;
		}

		// Token: 0x0602E4E6 RID: 189670 RVA: 0x00AB465C File Offset: 0x00AB285C
		protected UUIExtendToggle GetExtendToggle(int name)
		{
			Tuple<Type, UActorComponent> tuple;
			if (!this.BaseComponentMap.TryGetValue(name, out tuple))
			{
				return null;
			}
			return tuple.Item2 as UUIExtendToggle;
		}

		// Token: 0x0602E4E7 RID: 189671 RVA: 0x00AB4688 File Offset: 0x00AB2888
		protected UUIExtendToggleGroup GetExtendToggleGroup(int name)
		{
			Tuple<Type, UActorComponent> tuple;
			if (!this.BaseComponentMap.TryGetValue(name, out tuple))
			{
				return null;
			}
			return tuple.Item2 as UUIExtendToggleGroup;
		}

		// Token: 0x0602E4E8 RID: 189672 RVA: 0x00AB46B4 File Offset: 0x00AB28B4
		protected UUIScrollViewWithScrollbarComponent GetScrollViewWithScrollbar(int name)
		{
			Tuple<Type, UActorComponent> tuple;
			if (!this.BaseComponentMap.TryGetValue(name, out tuple))
			{
				return null;
			}
			return tuple.Item2 as UUIScrollViewWithScrollbarComponent;
		}

		// Token: 0x0602E4E9 RID: 189673 RVA: 0x00AB46E0 File Offset: 0x00AB28E0
		protected UUIDynScrollViewComponent GetUIDynScrollViewComponent(int name)
		{
			Tuple<Type, UActorComponent> tuple;
			if (!this.BaseComponentMap.TryGetValue(name, out tuple))
			{
				return null;
			}
			return tuple.Item2 as UUIDynScrollViewComponent;
		}

		// Token: 0x0602E4EA RID: 189674 RVA: 0x00AB470C File Offset: 0x00AB290C
		protected UUIScrollbarComponent GetScrollScrollbar(int name)
		{
			Tuple<Type, UActorComponent> tuple;
			if (!this.BaseComponentMap.TryGetValue(name, out tuple))
			{
				return null;
			}
			return tuple.Item2 as UUIScrollbarComponent;
		}

		// Token: 0x0602E4EB RID: 189675 RVA: 0x00AB4738 File Offset: 0x00AB2938
		protected UUIScrollViewComponent GetScrollView(int name)
		{
			Tuple<Type, UActorComponent> tuple;
			if (!this.BaseComponentMap.TryGetValue(name, out tuple))
			{
				return null;
			}
			return tuple.Item2 as UUIScrollViewComponent;
		}

		// Token: 0x0602E4EC RID: 189676 RVA: 0x00AB4764 File Offset: 0x00AB2964
		protected UUILoopScrollViewComponent GetLoopScrollViewComponent(int name)
		{
			Tuple<Type, UActorComponent> tuple;
			if (!this.BaseComponentMap.TryGetValue(name, out tuple))
			{
				return null;
			}
			return tuple.Item2 as UUILoopScrollViewComponent;
		}

		// Token: 0x0602E4ED RID: 189677 RVA: 0x00AB4790 File Offset: 0x00AB2990
		protected UUIMultiTemplateScrollViewComponent GetMultiTemplateScrollViewComponent(int name)
		{
			Tuple<Type, UActorComponent> tuple;
			if (!this.BaseComponentMap.TryGetValue(name, out tuple))
			{
				return null;
			}
			return tuple.Item2 as UUIMultiTemplateScrollViewComponent;
		}

		// Token: 0x0602E4EE RID: 189678 RVA: 0x00AB47BC File Offset: 0x00AB29BC
		protected UUIDropdownComponent GetDropdown(int name)
		{
			Tuple<Type, UActorComponent> tuple;
			if (!this.BaseComponentMap.TryGetValue(name, out tuple))
			{
				return null;
			}
			return tuple.Item2 as UUIDropdownComponent;
		}

		// Token: 0x0602E4EF RID: 189679 RVA: 0x00AB47E8 File Offset: 0x00AB29E8
		protected UUITextInputComponent GetInputText(int name)
		{
			Tuple<Type, UActorComponent> tuple;
			if (!this.BaseComponentMap.TryGetValue(name, out tuple))
			{
				return null;
			}
			return tuple.Item2 as UUITextInputComponent;
		}

		// Token: 0x0602E4F0 RID: 189680 RVA: 0x00AB4814 File Offset: 0x00AB2A14
		protected UUIDraggableComponent GetDraggable(int name)
		{
			Tuple<Type, UActorComponent> tuple;
			if (!this.BaseComponentMap.TryGetValue(name, out tuple))
			{
				return null;
			}
			return tuple.Item2 as UUIDraggableComponent;
		}

		// Token: 0x0602E4F1 RID: 189681 RVA: 0x00AB4840 File Offset: 0x00AB2A40
		protected UUINiagara GetUiNiagara(int name)
		{
			Tuple<Type, UActorComponent> tuple;
			if (!this.BaseComponentMap.TryGetValue(name, out tuple))
			{
				return null;
			}
			return tuple.Item2 as UUINiagara;
		}

		// Token: 0x0602E4F2 RID: 189682 RVA: 0x00AB486C File Offset: 0x00AB2A6C
		protected UUIVerticalLayout GetVerticalLayout(int name)
		{
			Tuple<Type, UActorComponent> tuple;
			if (!this.BaseComponentMap.TryGetValue(name, out tuple))
			{
				return null;
			}
			return tuple.Item2 as UUIVerticalLayout;
		}

		// Token: 0x0602E4F3 RID: 189683 RVA: 0x00AB4898 File Offset: 0x00AB2A98
		protected UUIHorizontalLayout GetHorizontalLayout(int name)
		{
			Tuple<Type, UActorComponent> tuple;
			if (!this.BaseComponentMap.TryGetValue(name, out tuple))
			{
				return null;
			}
			return tuple.Item2 as UUIHorizontalLayout;
		}

		// Token: 0x0602E4F4 RID: 189684 RVA: 0x00AB48C4 File Offset: 0x00AB2AC4
		protected UUIMultiTemplateLayout GetMultiTemplateLayout(int name)
		{
			Tuple<Type, UActorComponent> tuple;
			if (!this.BaseComponentMap.TryGetValue(name, out tuple))
			{
				return null;
			}
			return tuple.Item2 as UUIMultiTemplateLayout;
		}

		// Token: 0x0602E4F5 RID: 189685 RVA: 0x00AB48F0 File Offset: 0x00AB2AF0
		protected UUIGridLayout GetGridLayout(int name)
		{
			Tuple<Type, UActorComponent> tuple;
			if (!this.BaseComponentMap.TryGetValue(name, out tuple))
			{
				return null;
			}
			return tuple.Item2 as UUIGridLayout;
		}

		// Token: 0x0602E4F6 RID: 189686 RVA: 0x00AB491C File Offset: 0x00AB2B1C
		protected UUILayoutBase GetLayoutBase(int name)
		{
			Tuple<Type, UActorComponent> tuple;
			if (!this.BaseComponentMap.TryGetValue(name, out tuple))
			{
				return null;
			}
			return tuple.Item2 as UUILayoutBase;
		}

		// Token: 0x0602E4F7 RID: 189687 RVA: 0x00AB4948 File Offset: 0x00AB2B48
		protected UUITextTransition GetUITextTransition(int name)
		{
			Tuple<Type, UActorComponent> tuple;
			if (!this.BaseComponentMap.TryGetValue(name, out tuple))
			{
				return null;
			}
			return tuple.Item2 as UUITextTransition;
		}

		// Token: 0x0602E4F8 RID: 189688 RVA: 0x00AB4974 File Offset: 0x00AB2B74
		protected UUITextureTransitionComponent GetUiTextureTransitionComponent(int name)
		{
			Tuple<Type, UActorComponent> tuple;
			if (!this.BaseComponentMap.TryGetValue(name, out tuple))
			{
				return null;
			}
			return tuple.Item2 as UUITextureTransitionComponent;
		}

		// Token: 0x0602E4F9 RID: 189689 RVA: 0x00AB49A0 File Offset: 0x00AB2BA0
		protected UUISpriteTransition GetUiSpriteTransition(int name)
		{
			Tuple<Type, UActorComponent> tuple;
			if (!this.BaseComponentMap.TryGetValue(name, out tuple))
			{
				return null;
			}
			return tuple.Item2 as UUISpriteTransition;
		}

		// Token: 0x0602E4FA RID: 189690 RVA: 0x00AB49CC File Offset: 0x00AB2BCC
		protected UUIExtendToggleSpriteTransition GetUiExtendToggleSpriteTransition(int name)
		{
			Tuple<Type, UActorComponent> tuple;
			if (!this.BaseComponentMap.TryGetValue(name, out tuple))
			{
				return null;
			}
			return tuple.Item2 as UUIExtendToggleSpriteTransition;
		}

		// Token: 0x0602E4FB RID: 189691 RVA: 0x00AB49F8 File Offset: 0x00AB2BF8
		protected UUIExtendToggleTextureTransition GetUiExtendToggleTextureTransition(int name)
		{
			Tuple<Type, UActorComponent> tuple;
			if (!this.BaseComponentMap.TryGetValue(name, out tuple))
			{
				return null;
			}
			return tuple.Item2 as UUIExtendToggleTextureTransition;
		}

		// Token: 0x0602E4FC RID: 189692 RVA: 0x00AB4A24 File Offset: 0x00AB2C24
		protected UUIExtendToggleTextTransition GetUiExtendToggleTextTransition(int name)
		{
			Tuple<Type, UActorComponent> tuple;
			if (!this.BaseComponentMap.TryGetValue(name, out tuple))
			{
				return null;
			}
			return tuple.Item2 as UUIExtendToggleTextTransition;
		}

		// Token: 0x0602E4FD RID: 189693 RVA: 0x00AB4A50 File Offset: 0x00AB2C50
		protected UUISizeControlByOther GetUiSizeControlByOther(int name)
		{
			Tuple<Type, UActorComponent> tuple;
			if (!this.BaseComponentMap.TryGetValue(name, out tuple))
			{
				return null;
			}
			return tuple.Item2 as UUISizeControlByOther;
		}

		// Token: 0x0602E4FE RID: 189694 RVA: 0x00AB4A7C File Offset: 0x00AB2C7C
		protected UUIDynamicBatchMesh GetDynamicBatchMesh(int name)
		{
			Tuple<Type, UActorComponent> tuple;
			if (!this.BaseComponentMap.TryGetValue(name, out tuple))
			{
				return null;
			}
			return tuple.Item2 as UUIDynamicBatchMesh;
		}

		// Token: 0x0602E4FF RID: 189695 RVA: 0x00AB4AA8 File Offset: 0x00AB2CA8
		protected UUIInturnAnimController GetUiInturnAnimController(int name)
		{
			Tuple<Type, UActorComponent> tuple;
			if (!this.BaseComponentMap.TryGetValue(name, out tuple))
			{
				return null;
			}
			return tuple.Item2 as UUIInturnAnimController;
		}

		// Token: 0x0602E500 RID: 189696 RVA: 0x00AB4AD4 File Offset: 0x00AB2CD4
		protected UUI2DLineRaw GetUiLineRaw(int name)
		{
			Tuple<Type, UActorComponent> tuple;
			if (!this.BaseComponentMap.TryGetValue(name, out tuple))
			{
				return null;
			}
			return tuple.Item2 as UUI2DLineRaw;
		}

		// Token: 0x0602E501 RID: 189697 RVA: 0x00AB4AFE File Offset: 0x00AB2CFE
		private void InitGuideRegistry()
		{
			AActor rootActor = this.GetRootActor();
			this._guideRegistry = (((rootActor != null) ? rootActor.GetComponentByClass(UGuideHookRegistry.StaticClass()) : null) as UGuideHookRegistry);
		}

		// Token: 0x0602E502 RID: 189698 RVA: 0x00AB4B28 File Offset: 0x00AB2D28
		[NullableContext(1)]
		[return: Nullable(2)]
		public UUIItem GetGuideUiItem(string name)
		{
			if (this._guideRegistry == null)
			{
				return null;
			}
			TWeakObjectPtr<AActor>? valueOrNull = this._guideRegistry.GuideHookComponents.GetValueOrNull(name);
			if (valueOrNull == null)
			{
				return null;
			}
			AUIBaseActor auibaseActor = valueOrNull.Value.Get() as AUIBaseActor;
			if (auibaseActor == null)
			{
				return null;
			}
			return auibaseActor.GetUIItem();
		}

		// Token: 0x0602E503 RID: 189699 RVA: 0x00AB4B7C File Offset: 0x00AB2D7C
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			Log.Instance.Error(ELogModule.Guide, ELogAuthor.TL, "引导步骤已配置的聚焦界面未实现GetGuideUiItemEx函数", default(ReadOnlySpan<ValueTuple<string, object>>));
			return null;
		}

		// Token: 0x0602E504 RID: 189700 RVA: 0x00AB4BA6 File Offset: 0x00AB2DA6
		public virtual UUIScrollViewComponent GetGuideScrollViewToLock()
		{
			return null;
		}

		// Token: 0x0602E505 RID: 189701 RVA: 0x00AB4BAC File Offset: 0x00AB2DAC
		protected void SetButtonUiActive(int name, bool value)
		{
			UUIButtonComponent button = this.GetButton(name);
			if (button == null)
			{
				Log.Instance.Error(ELogModule.UiCommon, ELogAuthor.TL, "设置Button可见性错误，Button组件为空！", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			UUIItem rootComponent = button.GetRootComponent();
			if (rootComponent == null)
			{
				return;
			}
			rootComponent.SetUIActive(value);
		}

		// Token: 0x0602E506 RID: 189702 RVA: 0x00AB4BF4 File Offset: 0x00AB2DF4
		[NullableContext(1)]
		protected virtual void SetSpriteByPath(string path, UUISprite uiSprite, bool setSize, EUiViewName? syncLoadViewName = null, [Nullable(2)] Action<bool> callback = null)
		{
			EUiViewName? euiViewName = syncLoadViewName;
			if (!string.IsNullOrEmpty((euiViewName != null) ? euiViewName.GetValueOrDefault() : null))
			{
				this._uiImageSettingModule.SetSpriteByPathSync(path, uiSprite, setSize, syncLoadViewName.Value, callback);
				return;
			}
			this._uiImageSettingModule.SetSpriteByPathAsync(path, uiSprite, setSize, callback);
		}

		// Token: 0x0602E507 RID: 189703 RVA: 0x00AB4C4B File Offset: 0x00AB2E4B
		protected void TrySetSpriteByPath(string path, UUISprite uiSprite, bool setSize, EUiViewName? syncLoadViewName = null, Action<bool> callback = null)
		{
			if (path == null || uiSprite == null)
			{
				if (uiSprite != null)
				{
					uiSprite.SetUIActive(false);
					return;
				}
			}
			else
			{
				uiSprite.SetUIActive(true);
				this.SetSpriteByPath(path, uiSprite, setSize, syncLoadViewName, callback);
			}
		}

		// Token: 0x0602E508 RID: 189704 RVA: 0x00AB4C74 File Offset: 0x00AB2E74
		[NullableContext(1)]
		protected UniTask SetSpriteTransitionByPath(string path, UUISpriteTransition uiSpriteTransition, EUISelectableSelectionState state = EUISelectableSelectionState.EUISelectableSelectionState_MAX)
		{
			UiPanelBase.<SetSpriteTransitionByPath>d__149 <SetSpriteTransitionByPath>d__;
			<SetSpriteTransitionByPath>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetSpriteTransitionByPath>d__.<>4__this = this;
			<SetSpriteTransitionByPath>d__.path = path;
			<SetSpriteTransitionByPath>d__.uiSpriteTransition = uiSpriteTransition;
			<SetSpriteTransitionByPath>d__.state = state;
			<SetSpriteTransitionByPath>d__.<>1__state = -1;
			<SetSpriteTransitionByPath>d__.<>t__builder.Start<UiPanelBase.<SetSpriteTransitionByPath>d__149>(ref <SetSpriteTransitionByPath>d__);
			return <SetSpriteTransitionByPath>d__.<>t__builder.Task;
		}

		// Token: 0x0602E509 RID: 189705 RVA: 0x00AB4CCF File Offset: 0x00AB2ECF
		protected void SetTextureByPath([Nullable(1)] string path, UUITexture uiTexture, EUiViewName? syncLoadViewName = null, Action<bool> callback = null)
		{
			if (syncLoadViewName != null)
			{
				this._uiImageSettingModule.SetTextureByPathSync(path, uiTexture, syncLoadViewName.Value, callback);
				return;
			}
			this._uiImageSettingModule.SetTextureByPathAsync(path, uiTexture, callback);
		}

		// Token: 0x0602E50A RID: 189706 RVA: 0x00AB4D00 File Offset: 0x00AB2F00
		protected void TrySetTextureByPath(string path, UUITexture uiTexture, EUiViewName? syncLoadViewName = null, Action<bool> callback = null)
		{
			if (path == null)
			{
				if (uiTexture != null)
				{
					uiTexture.SetUIActive(false);
					return;
				}
			}
			else
			{
				if (uiTexture != null)
				{
					uiTexture.SetUIActive(true);
				}
				this.SetTextureByPath(path, uiTexture, syncLoadViewName, callback);
			}
		}

		// Token: 0x0602E50B RID: 189707 RVA: 0x00AB4D28 File Offset: 0x00AB2F28
		[NullableContext(1)]
		protected UniTask SetTextureTransitionByPath(string path, UUITextureTransitionComponent uiTextureTransition, EUISelectableSelectionState state = EUISelectableSelectionState.EUISelectableSelectionState_MAX)
		{
			UiPanelBase.<SetTextureTransitionByPath>d__152 <SetTextureTransitionByPath>d__;
			<SetTextureTransitionByPath>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetTextureTransitionByPath>d__.<>4__this = this;
			<SetTextureTransitionByPath>d__.path = path;
			<SetTextureTransitionByPath>d__.uiTextureTransition = uiTextureTransition;
			<SetTextureTransitionByPath>d__.state = state;
			<SetTextureTransitionByPath>d__.<>1__state = -1;
			<SetTextureTransitionByPath>d__.<>t__builder.Start<UiPanelBase.<SetTextureTransitionByPath>d__152>(ref <SetTextureTransitionByPath>d__);
			return <SetTextureTransitionByPath>d__.<>t__builder.Task;
		}

		// Token: 0x0602E50C RID: 189708 RVA: 0x00AB4D84 File Offset: 0x00AB2F84
		[NullableContext(1)]
		protected UniTask SetExtendToggleTextureTransitionByPath(string path, UUIExtendToggleTextureTransition uiExtendToggleTextureTransition, EToggleTransitionState state = EToggleTransitionState.ETT_MAX)
		{
			UiPanelBase.<SetExtendToggleTextureTransitionByPath>d__153 <SetExtendToggleTextureTransitionByPath>d__;
			<SetExtendToggleTextureTransitionByPath>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetExtendToggleTextureTransitionByPath>d__.<>4__this = this;
			<SetExtendToggleTextureTransitionByPath>d__.path = path;
			<SetExtendToggleTextureTransitionByPath>d__.uiExtendToggleTextureTransition = uiExtendToggleTextureTransition;
			<SetExtendToggleTextureTransitionByPath>d__.state = state;
			<SetExtendToggleTextureTransitionByPath>d__.<>1__state = -1;
			<SetExtendToggleTextureTransitionByPath>d__.<>t__builder.Start<UiPanelBase.<SetExtendToggleTextureTransitionByPath>d__153>(ref <SetExtendToggleTextureTransitionByPath>d__);
			return <SetExtendToggleTextureTransitionByPath>d__.<>t__builder.Task;
		}

		// Token: 0x0602E50D RID: 189709 RVA: 0x00AB4DE0 File Offset: 0x00AB2FE0
		[NullableContext(1)]
		protected UniTask SetExtendToggleTextureTransitionGroupByPath(string path, UUIExtendToggleTextureTransition uiExtendToggleTextureTransition, EToggleTransitionState[] states)
		{
			UiPanelBase.<SetExtendToggleTextureTransitionGroupByPath>d__154 <SetExtendToggleTextureTransitionGroupByPath>d__;
			<SetExtendToggleTextureTransitionGroupByPath>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetExtendToggleTextureTransitionGroupByPath>d__.<>4__this = this;
			<SetExtendToggleTextureTransitionGroupByPath>d__.path = path;
			<SetExtendToggleTextureTransitionGroupByPath>d__.uiExtendToggleTextureTransition = uiExtendToggleTextureTransition;
			<SetExtendToggleTextureTransitionGroupByPath>d__.states = states;
			<SetExtendToggleTextureTransitionGroupByPath>d__.<>1__state = -1;
			<SetExtendToggleTextureTransitionGroupByPath>d__.<>t__builder.Start<UiPanelBase.<SetExtendToggleTextureTransitionGroupByPath>d__154>(ref <SetExtendToggleTextureTransitionGroupByPath>d__);
			return <SetExtendToggleTextureTransitionGroupByPath>d__.<>t__builder.Task;
		}

		// Token: 0x0602E50E RID: 189710 RVA: 0x00AB4E3C File Offset: 0x00AB303C
		[NullableContext(1)]
		protected UniTask SetTextureCustomMaterialAsync(string materialPath, [Nullable(2)] UUITexture uiTexture)
		{
			UiPanelBase.<SetTextureCustomMaterialAsync>d__155 <SetTextureCustomMaterialAsync>d__;
			<SetTextureCustomMaterialAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetTextureCustomMaterialAsync>d__.<>4__this = this;
			<SetTextureCustomMaterialAsync>d__.materialPath = materialPath;
			<SetTextureCustomMaterialAsync>d__.uiTexture = uiTexture;
			<SetTextureCustomMaterialAsync>d__.<>1__state = -1;
			<SetTextureCustomMaterialAsync>d__.<>t__builder.Start<UiPanelBase.<SetTextureCustomMaterialAsync>d__155>(ref <SetTextureCustomMaterialAsync>d__);
			return <SetTextureCustomMaterialAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602E50F RID: 189711 RVA: 0x00AB4E90 File Offset: 0x00AB3090
		[NullableContext(1)]
		protected UniTask SetExtendToggleSpriteTransitionByPath(string path, UUIExtendToggleSpriteTransition uiExtendToggleSpriteTransition, EToggleTransitionState? state = null)
		{
			UiPanelBase.<SetExtendToggleSpriteTransitionByPath>d__156 <SetExtendToggleSpriteTransitionByPath>d__;
			<SetExtendToggleSpriteTransitionByPath>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetExtendToggleSpriteTransitionByPath>d__.<>4__this = this;
			<SetExtendToggleSpriteTransitionByPath>d__.path = path;
			<SetExtendToggleSpriteTransitionByPath>d__.uiExtendToggleSpriteTransition = uiExtendToggleSpriteTransition;
			<SetExtendToggleSpriteTransitionByPath>d__.state = state;
			<SetExtendToggleSpriteTransitionByPath>d__.<>1__state = -1;
			<SetExtendToggleSpriteTransitionByPath>d__.<>t__builder.Start<UiPanelBase.<SetExtendToggleSpriteTransitionByPath>d__156>(ref <SetExtendToggleSpriteTransitionByPath>d__);
			return <SetExtendToggleSpriteTransitionByPath>d__.<>t__builder.Task;
		}

		// Token: 0x0602E510 RID: 189712 RVA: 0x00AB4EEC File Offset: 0x00AB30EC
		[NullableContext(1)]
		protected UniTask SetExtendToggleSpriteTransitionByStateList(string path, UUIExtendToggleSpriteTransition uiExtendToggleSpriteTransition, EToggleTransitionState[] states)
		{
			UiPanelBase.<SetExtendToggleSpriteTransitionByStateList>d__157 <SetExtendToggleSpriteTransitionByStateList>d__;
			<SetExtendToggleSpriteTransitionByStateList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetExtendToggleSpriteTransitionByStateList>d__.<>4__this = this;
			<SetExtendToggleSpriteTransitionByStateList>d__.path = path;
			<SetExtendToggleSpriteTransitionByStateList>d__.uiExtendToggleSpriteTransition = uiExtendToggleSpriteTransition;
			<SetExtendToggleSpriteTransitionByStateList>d__.states = states;
			<SetExtendToggleSpriteTransitionByStateList>d__.<>1__state = -1;
			<SetExtendToggleSpriteTransitionByStateList>d__.<>t__builder.Start<UiPanelBase.<SetExtendToggleSpriteTransitionByStateList>d__157>(ref <SetExtendToggleSpriteTransitionByStateList>d__);
			return <SetExtendToggleSpriteTransitionByStateList>d__.<>t__builder.Task;
		}

		// Token: 0x0602E511 RID: 189713 RVA: 0x00AB4F48 File Offset: 0x00AB3148
		[NullableContext(1)]
		protected UniTask SetTextureAsync(string path, UUITexture uiTexture)
		{
			UiPanelBase.<SetTextureAsync>d__158 <SetTextureAsync>d__;
			<SetTextureAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetTextureAsync>d__.<>4__this = this;
			<SetTextureAsync>d__.path = path;
			<SetTextureAsync>d__.uiTexture = uiTexture;
			<SetTextureAsync>d__.<>1__state = -1;
			<SetTextureAsync>d__.<>t__builder.Start<UiPanelBase.<SetTextureAsync>d__158>(ref <SetTextureAsync>d__);
			return <SetTextureAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602E512 RID: 189714 RVA: 0x00AB4F9C File Offset: 0x00AB319C
		[NullableContext(1)]
		protected UniTask SetSpriteAsync(string path, UUISprite uiSprite, bool setSize)
		{
			UiPanelBase.<SetSpriteAsync>d__159 <SetSpriteAsync>d__;
			<SetSpriteAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetSpriteAsync>d__.<>4__this = this;
			<SetSpriteAsync>d__.path = path;
			<SetSpriteAsync>d__.uiSprite = uiSprite;
			<SetSpriteAsync>d__.setSize = setSize;
			<SetSpriteAsync>d__.<>1__state = -1;
			<SetSpriteAsync>d__.<>t__builder.Start<UiPanelBase.<SetSpriteAsync>d__159>(ref <SetSpriteAsync>d__);
			return <SetSpriteAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602E513 RID: 189715 RVA: 0x00AB4FF8 File Offset: 0x00AB31F8
		protected void SetTextureShowUntilLoaded([Nullable(1)] string path, UUITexture uiTexture, Action<bool> callback = null)
		{
			if (uiTexture == null)
			{
				return;
			}
			uiTexture.SetUIActive(false);
			this._uiImageSettingModule.SetTextureByPathAsync(path, uiTexture, delegate(bool result)
			{
				uiTexture.SetUIActive(true);
				if (callback != null)
				{
					callback(result);
				}
			});
		}

		// Token: 0x0602E514 RID: 189716 RVA: 0x00AB504C File Offset: 0x00AB324C
		[NullableContext(1)]
		protected void SetItemIcon(UUITexture texture, int itemId, EUiViewName? syncLoadViewName = null, [Nullable(2)] Action<bool> action = null)
		{
			if (syncLoadViewName != null)
			{
				this._uiImageSettingModule.SetItemIconSync(texture, itemId, syncLoadViewName.Value, action);
				return;
			}
			this._uiImageSettingModule.SetItemIconAsync(texture, itemId, action);
		}

		// Token: 0x0602E515 RID: 189717 RVA: 0x00AB5080 File Offset: 0x00AB3280
		[NullableContext(1)]
		protected UniTask SetItemIconAsync(UUITexture texture, int itemId)
		{
			UiPanelBase.<SetItemIconAsync>d__162 <SetItemIconAsync>d__;
			<SetItemIconAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetItemIconAsync>d__.<>4__this = this;
			<SetItemIconAsync>d__.texture = texture;
			<SetItemIconAsync>d__.itemId = itemId;
			<SetItemIconAsync>d__.<>1__state = -1;
			<SetItemIconAsync>d__.<>t__builder.Start<UiPanelBase.<SetItemIconAsync>d__162>(ref <SetItemIconAsync>d__);
			return <SetItemIconAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602E516 RID: 189718 RVA: 0x00AB50D4 File Offset: 0x00AB32D4
		[NullableContext(1)]
		protected void SetQualityIconById(UUISprite sprite, int qualityId, EUiViewName? syncLoadViewName = null, CommonDefine.EQualityIconType? type = null, [Nullable(2)] Action<bool> action = null)
		{
			CommonDefine.EQualityIconType valueOrDefault = type.GetValueOrDefault();
			if (syncLoadViewName != null)
			{
				this._uiImageSettingModule.SetQualityIconByIdSync(sprite, qualityId, syncLoadViewName.Value, valueOrDefault, action);
				return;
			}
			this._uiImageSettingModule.SetQualityIconByIdAsync(sprite, qualityId, valueOrDefault, action);
		}

		// Token: 0x0602E517 RID: 189719 RVA: 0x00AB511A File Offset: 0x00AB331A
		[NullableContext(1)]
		protected void SetItemQualityIcon(UUISprite sprite, int itemId, EUiViewName? syncLoadViewName = null, CommonDefine.EQualityIconType type = CommonDefine.EQualityIconType.BackgroundSprite, [Nullable(2)] Action<bool> action = null)
		{
			if (syncLoadViewName != null)
			{
				this._uiImageSettingModule.SetItemQualityIconSync(sprite, itemId, syncLoadViewName.Value, type, action);
				return;
			}
			this._uiImageSettingModule.SetItemQualityIconAsync(sprite, itemId, type, action);
		}

		// Token: 0x0602E518 RID: 189720 RVA: 0x00AB514F File Offset: 0x00AB334F
		[NullableContext(1)]
		protected void SetRoleIcon(string path, UUITexture texture, int roleId, EUiViewName? syncLoadViewName = null, [Nullable(2)] Action<bool> callback = null)
		{
			if (syncLoadViewName != null)
			{
				this._uiImageSettingModule.SetRoleIconSync(path, texture, roleId, syncLoadViewName.Value, callback);
				return;
			}
			this._uiImageSettingModule.SetRoleIconAsync(path, texture, roleId, callback);
		}

		// Token: 0x0602E519 RID: 189721 RVA: 0x00AB5182 File Offset: 0x00AB3382
		[NullableContext(1)]
		protected void SetRoleSkinIcon(string path, UUITexture texture, int skinId, EUiViewName? syncLoadViewName = null, [Nullable(2)] Action<bool> callback = null)
		{
			if (syncLoadViewName != null)
			{
				this._uiImageSettingModule.SetRoleSkinIconSync(path, texture, skinId, syncLoadViewName.Value, callback);
				return;
			}
			this._uiImageSettingModule.SetRoleSkinIconAsync(path, texture, skinId, callback);
		}

		// Token: 0x0602E51A RID: 189722 RVA: 0x00AB51B8 File Offset: 0x00AB33B8
		[NullableContext(1)]
		protected void SetRoleIconByRoleIdOrSkinId(string path, UUITexture texture, int roleId, int? skinId = null, [Nullable(2)] Action<bool> callback = null, EUiViewName? syncLoadViewName = null)
		{
			if (skinId != null)
			{
				int? num = skinId;
				int num2 = 0;
				if (!(num.GetValueOrDefault() <= num2 & num != null))
				{
					this.SetRoleSkinIcon(path, texture, skinId.Value, syncLoadViewName, callback);
					return;
				}
			}
			this.SetRoleIcon(path, texture, roleId, syncLoadViewName, callback);
		}

		// Token: 0x0602E51B RID: 189723 RVA: 0x00AB520B File Offset: 0x00AB340B
		[NullableContext(1)]
		protected void SetElementIcon(string path, UUITexture texture, int elementId, EUiViewName? syncLoadViewName = null)
		{
			if (syncLoadViewName != null)
			{
				this._uiImageSettingModule.SetElementIconSync(path, texture, elementId, syncLoadViewName.Value);
				return;
			}
			this._uiImageSettingModule.SetElementIcon(path, texture, elementId);
		}

		// Token: 0x0602E51C RID: 189724 RVA: 0x00AB523A File Offset: 0x00AB343A
		[NullableContext(1)]
		protected void SetMonsterIcon(string path, UUITexture texture, int monsterInfoId, EUiViewName? syncLoadViewName = null)
		{
			if (syncLoadViewName != null)
			{
				this._uiImageSettingModule.SetMonsterIconSync(path, texture, monsterInfoId, syncLoadViewName.Value);
				return;
			}
			this._uiImageSettingModule.SetMonsterIconAsync(path, texture, monsterInfoId);
		}

		// Token: 0x0602E51D RID: 189725 RVA: 0x00AB5269 File Offset: 0x00AB3469
		[NullableContext(1)]
		protected void SetDungeonEntranceIconSync(string path, UUITexture texture, int entranceId, EUiViewName? syncLoadViewName = null)
		{
			if (syncLoadViewName != null)
			{
				this._uiImageSettingModule.SetDungeonEntranceIconSync(path, texture, entranceId, syncLoadViewName.Value);
				return;
			}
			this._uiImageSettingModule.SetDungeonEntranceIconAsync(path, texture, entranceId);
		}

		// Token: 0x0602E51E RID: 189726 RVA: 0x00AB5298 File Offset: 0x00AB3498
		[NullableContext(1)]
		protected void SetNiagaraTextureByPath(string iconPath, UUINiagara niagara, string emitterName, string variableName, EUiViewName? syncLoadViewName = null, [Nullable(2)] Action<bool> callback = null)
		{
			if (syncLoadViewName != null)
			{
				this._uiImageSettingModule.SetNiagaraTextureSync(iconPath, niagara, emitterName, variableName, syncLoadViewName.Value, callback);
				return;
			}
			this._uiImageSettingModule.SetNiagaraTextureAsync(iconPath, niagara, emitterName, variableName, callback);
		}

		// Token: 0x0602E51F RID: 189727 RVA: 0x00AB52CF File Offset: 0x00AB34CF
		[NullableContext(1)]
		protected void SetNiagaraSystemByPath(string niagaraPath, UUINiagara niagara, [Nullable(2)] Action<bool> callback = null)
		{
			this._uiNiagaraSettingModule.SetNiagaraByPath(niagaraPath, niagara, callback);
		}

		// Token: 0x0602E520 RID: 189728 RVA: 0x00AB52E0 File Offset: 0x00AB34E0
		[NullableContext(1)]
		protected UniTask SetNiagaraSystemByPathAsync(string niagaraPath, UUINiagara niagara)
		{
			UiPanelBase.<SetNiagaraSystemByPathAsync>d__173 <SetNiagaraSystemByPathAsync>d__;
			<SetNiagaraSystemByPathAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetNiagaraSystemByPathAsync>d__.<>4__this = this;
			<SetNiagaraSystemByPathAsync>d__.niagaraPath = niagaraPath;
			<SetNiagaraSystemByPathAsync>d__.niagara = niagara;
			<SetNiagaraSystemByPathAsync>d__.<>1__state = -1;
			<SetNiagaraSystemByPathAsync>d__.<>t__builder.Start<UiPanelBase.<SetNiagaraSystemByPathAsync>d__173>(ref <SetNiagaraSystemByPathAsync>d__);
			return <SetNiagaraSystemByPathAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602E521 RID: 189729 RVA: 0x00AB5334 File Offset: 0x00AB3534
		[NullableContext(1)]
		protected UniTask SetSpineAssetByPath(string atlasPath, string skeletonPath, USpineSkeletonAnimationComponent spine)
		{
			UiPanelBase.<SetSpineAssetByPath>d__174 <SetSpineAssetByPath>d__;
			<SetSpineAssetByPath>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetSpineAssetByPath>d__.<>4__this = this;
			<SetSpineAssetByPath>d__.atlasPath = atlasPath;
			<SetSpineAssetByPath>d__.skeletonPath = skeletonPath;
			<SetSpineAssetByPath>d__.spine = spine;
			<SetSpineAssetByPath>d__.<>1__state = -1;
			<SetSpineAssetByPath>d__.<>t__builder.Start<UiPanelBase.<SetSpineAssetByPath>d__174>(ref <SetSpineAssetByPath>d__);
			return <SetSpineAssetByPath>d__.<>t__builder.Task;
		}

		// Token: 0x0602E522 RID: 189730 RVA: 0x00AB538F File Offset: 0x00AB358F
		private void ClearUiResourceLoadModule()
		{
			this._uiImageSettingModule.Clear();
			this._uiNiagaraSettingModule.Clear();
			this._uiSpineLoadModule.Clear();
		}

		// Token: 0x0602E523 RID: 189731 RVA: 0x00AB53B4 File Offset: 0x00AB35B4
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		public UniTask<AActor> LoadPrefabAsync(string path, [Nullable(2)] UUIItem parent = null)
		{
			UiPanelBase.<LoadPrefabAsync>d__177 <LoadPrefabAsync>d__;
			<LoadPrefabAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<AActor>.Create();
			<LoadPrefabAsync>d__.<>4__this = this;
			<LoadPrefabAsync>d__.path = path;
			<LoadPrefabAsync>d__.parent = parent;
			<LoadPrefabAsync>d__.<>1__state = -1;
			<LoadPrefabAsync>d__.<>t__builder.Start<UiPanelBase.<LoadPrefabAsync>d__177>(ref <LoadPrefabAsync>d__);
			return <LoadPrefabAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602E524 RID: 189732 RVA: 0x00AB5407 File Offset: 0x00AB3607
		protected void ClearUiPrefabLoadModule()
		{
			this._uiPrefabLoadModule.Clear();
		}

		// Token: 0x0602E525 RID: 189733 RVA: 0x00AB5414 File Offset: 0x00AB3614
		[NullableContext(1)]
		protected UniTask RunAsyncTask(UiAsyncTask task)
		{
			UiPanelBase.<RunAsyncTask>d__180 <RunAsyncTask>d__;
			<RunAsyncTask>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RunAsyncTask>d__.<>4__this = this;
			<RunAsyncTask>d__.task = task;
			<RunAsyncTask>d__.<>1__state = -1;
			<RunAsyncTask>d__.<>t__builder.Start<UiPanelBase.<RunAsyncTask>d__180>(ref <RunAsyncTask>d__);
			return <RunAsyncTask>d__.<>t__builder.Task;
		}

		// Token: 0x0602E526 RID: 189734 RVA: 0x00AB545F File Offset: 0x00AB365F
		protected void CancelAllAsyncTask()
		{
			UiAsyncTaskManager taskManager = this.TaskManager;
			if (taskManager == null)
			{
				return;
			}
			taskManager.CancelAllTask();
		}

		// Token: 0x0602E527 RID: 189735 RVA: 0x00AB5471 File Offset: 0x00AB3671
		[NullableContext(1)]
		public void AddUiBehavior(IUiBehavior behavior)
		{
			this.AddUiBehaviorProxy(new UiBehaviorBaseProxy(behavior));
		}

		// Token: 0x0602E528 RID: 189736 RVA: 0x00AB547F File Offset: 0x00AB367F
		[NullableContext(1)]
		public void AddUiBehaviorProxy(UiBehaviorBaseProxy proxy)
		{
			this.UiBehaviorProxies.Add(proxy);
		}

		// Token: 0x0602E529 RID: 189737 RVA: 0x00AB548D File Offset: 0x00AB368D
		[NullableContext(1)]
		public void AddChild(UiPanelBase child)
		{
			this.Children.Add(child);
			child.Parent = this;
		}

		// Token: 0x0602E52A RID: 189738 RVA: 0x00AB54A4 File Offset: 0x00AB36A4
		private void RemoveFromParent()
		{
			if (this.Parent == null)
			{
				return;
			}
			int num = this.Parent.Children.IndexOf(this);
			if (num < 0)
			{
				return;
			}
			this.Parent.Children.RemoveAt(num);
			this.Parent = null;
		}

		// Token: 0x0602E52B RID: 189739 RVA: 0x00AB54EC File Offset: 0x00AB36EC
		public UiPanelBase GetLastChild()
		{
			int count = this.Children.Count;
			if (count == 0)
			{
				return null;
			}
			return this.Children[count - 1];
		}

		// Token: 0x0602E52C RID: 189740 RVA: 0x00AB5518 File Offset: 0x00AB3718
		public void Register()
		{
		}

		// Token: 0x0602E52D RID: 189741 RVA: 0x00AB551A File Offset: 0x00AB371A
		protected void Begin()
		{
		}

		// Token: 0x0602E52E RID: 189742 RVA: 0x00AB551C File Offset: 0x00AB371C
		protected virtual void OnBegin(object parameters = null)
		{
		}

		// Token: 0x0602E52F RID: 189743 RVA: 0x00AB551E File Offset: 0x00AB371E
		protected virtual void OnChangeComponentActiveState(bool visibility)
		{
		}

		// Token: 0x0602E530 RID: 189744 RVA: 0x00AB5520 File Offset: 0x00AB3720
		protected virtual void OnRegister()
		{
		}

		// Token: 0x0602E531 RID: 189745 RVA: 0x00AB5522 File Offset: 0x00AB3722
		protected virtual void OnCreate()
		{
		}

		// Token: 0x0602E532 RID: 189746 RVA: 0x00AB5524 File Offset: 0x00AB3724
		protected virtual void OnShow()
		{
		}

		// Token: 0x0602E533 RID: 189747 RVA: 0x00AB5526 File Offset: 0x00AB3726
		protected virtual void OnHide()
		{
		}

		// Token: 0x0602E534 RID: 189748 RVA: 0x00AB5528 File Offset: 0x00AB3728
		protected virtual void OnPrepareHide(bool inClose = false)
		{
		}

		// Token: 0x0602E535 RID: 189749 RVA: 0x00AB552A File Offset: 0x00AB372A
		protected virtual void OnEnd()
		{
		}

		// Token: 0x0602E536 RID: 189750 RVA: 0x00AB552C File Offset: 0x00AB372C
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x0602E537 RID: 189751 RVA: 0x00AB552E File Offset: 0x00AB372E
		protected virtual void OnStartSequenceFinish()
		{
		}

		// Token: 0x0602E538 RID: 189752 RVA: 0x00AB5530 File Offset: 0x00AB3730
		[NullableContext(1)]
		protected virtual void OnSequenceEvent(string sequenceName, string eventName)
		{
		}

		// Token: 0x0602E539 RID: 189753 RVA: 0x00AB5532 File Offset: 0x00AB3732
		protected virtual bool OnPlayCloseSequence()
		{
			return false;
		}

		// Token: 0x0602E53A RID: 189754 RVA: 0x00AB5535 File Offset: 0x00AB3735
		protected virtual void OnStackShow()
		{
		}

		// Token: 0x0602E53B RID: 189755 RVA: 0x00AB5537 File Offset: 0x00AB3737
		protected virtual void OnShowSequenceFinish()
		{
		}

		// Token: 0x0602E53C RID: 189756 RVA: 0x00AB5539 File Offset: 0x00AB3739
		protected virtual void OnActiveSequenceFinish()
		{
		}

		// Token: 0x0602E53D RID: 189757 RVA: 0x00AB553B File Offset: 0x00AB373B
		protected virtual bool OnCheckLoadSceneCondition()
		{
			return true;
		}

		// Token: 0x0602E53E RID: 189758 RVA: 0x00AB553E File Offset: 0x00AB373E
		protected virtual bool OnCheckReleaseSceneCondition()
		{
			return true;
		}

		// Token: 0x0602E53F RID: 189759 RVA: 0x00AB5541 File Offset: 0x00AB3741
		public void Start()
		{
		}

		// Token: 0x0602E540 RID: 189760 RVA: 0x00AB5543 File Offset: 0x00AB3743
		public void End()
		{
		}

		// Token: 0x0602E541 RID: 189761 RVA: 0x00AB5545 File Offset: 0x00AB3745
		protected void InitParam()
		{
		}

		// Token: 0x0602E542 RID: 189762 RVA: 0x00AB5547 File Offset: 0x00AB3747
		protected void InitComponentsData()
		{
		}

		// Token: 0x0602E543 RID: 189763 RVA: 0x00AB5549 File Offset: 0x00AB3749
		protected void OnClearComponentsData()
		{
		}

		// Token: 0x0602E544 RID: 189764 RVA: 0x00AB554B File Offset: 0x00AB374B
		public void Create()
		{
		}

		// Token: 0x0602E545 RID: 189765 RVA: 0x00AB554D File Offset: 0x00AB374D
		public bool ClearComponentsData()
		{
			base.Destroy(null);
			return true;
		}

		// Token: 0x0602E546 RID: 189766 RVA: 0x00AB5558 File Offset: 0x00AB3758
		[NullableContext(1)]
		public UniTask ConstructorAsync(string resourceId, UUIItem parentItem, bool usePool = false)
		{
			UiPanelBase.<ConstructorAsync>d__213 <ConstructorAsync>d__;
			<ConstructorAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ConstructorAsync>d__.<>4__this = this;
			<ConstructorAsync>d__.resourceId = resourceId;
			<ConstructorAsync>d__.parentItem = parentItem;
			<ConstructorAsync>d__.usePool = usePool;
			<ConstructorAsync>d__.<>1__state = -1;
			<ConstructorAsync>d__.<>t__builder.Start<UiPanelBase.<ConstructorAsync>d__213>(ref <ConstructorAsync>d__);
			return <ConstructorAsync>d__.<>t__builder.Task;
		}

		// Token: 0x170075E5 RID: 30181
		// (get) Token: 0x0602E547 RID: 189767 RVA: 0x00AB55B3 File Offset: 0x00AB37B3
		// (set) Token: 0x0602E548 RID: 189768 RVA: 0x00AB55BB File Offset: 0x00AB37BB
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		protected List<ValueTuple<int, Type>> ComponentsRegisterInfo
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				return this.ComponentRegisterInfos;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.ComponentRegisterInfos = value;
			}
		}

		// Token: 0x0602E549 RID: 189769 RVA: 0x00AB55C4 File Offset: 0x00AB37C4
		[NullableContext(1)]
		public void SetRootActor(AActor actor, bool isBegin = true)
		{
			if (isBegin)
			{
				this.CreateThenShowByActor(actor, null);
				return;
			}
			this.CreateByActor(actor, null);
		}

		// Token: 0x0602E54A RID: 189770 RVA: 0x00AB55DA File Offset: 0x00AB37DA
		[NullableContext(1)]
		public void CreateThenShowByActor(AActor actor, [Nullable(2)] object parameters = null)
		{
			if (parameters != null)
			{
				this.OpenParam = parameters;
			}
			this.SetActor(actor);
			base.StartCompatible();
			base.ShowCompatible();
		}

		// Token: 0x0602E54B RID: 189771 RVA: 0x00AB55FA File Offset: 0x00AB37FA
		[NullableContext(1)]
		public void CreateByActor(AActor actor, [Nullable(2)] object parameters = null)
		{
			if (parameters != null)
			{
				this.OpenParam = parameters;
			}
			this.SetActor(actor);
			base.StartCompatible();
		}

		// Token: 0x04018D6E RID: 101742
		protected UUIItem RootItem;

		// Token: 0x04018D6F RID: 101743
		protected AUIBaseActor RootActor;

		// Token: 0x04018D70 RID: 101744
		private AUIBaseActor _originalActor;

		// Token: 0x04018D71 RID: 101745
		private UUIItem _originalItem;

		// Token: 0x04018D72 RID: 101746
		protected UUIItem ParentUiItem;

		// Token: 0x04018D73 RID: 101747
		protected bool UsePool;

		// Token: 0x04018D74 RID: 101748
		[Nullable(1)]
		protected string MemoryTag = "js_undefined";

		// Token: 0x04018D76 RID: 101750
		private bool _isPermanent;

		// Token: 0x04018D77 RID: 101751
		public object OpenParam;

		// Token: 0x04018D78 RID: 101752
		[Nullable(1)]
		private string _actorPath = "";

		// Token: 0x04018D79 RID: 101753
		[Nullable(1)]
		private readonly List<UiBehaviorBaseProxy> UiBehaviorProxies = new List<UiBehaviorBaseProxy>();

		// Token: 0x04018D7A RID: 101754
		[Nullable(1)]
		private readonly List<UiPanelBase> Children = new List<UiPanelBase>();

		// Token: 0x04018D7B RID: 101755
		public UiPanelBase Parent;

		// Token: 0x04018D7C RID: 101756
		[Nullable(1)]
		private readonly Dictionary<int, Tuple<Type, UActorComponent>> BaseComponentMap = new Dictionary<int, Tuple<Type, UActorComponent>>();

		// Token: 0x04018D7D RID: 101757
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly Dictionary<Type, Func<UClassStackOnlyPtr>> StaticClassGetters = new Dictionary<Type, Func<UClassStackOnlyPtr>>
		{
			{
				typeof(UUIItem),
				new Func<UClassStackOnlyPtr>(UUIItem.StaticClass)
			},
			{
				typeof(UUIText),
				new Func<UClassStackOnlyPtr>(UUIText.StaticClass)
			},
			{
				typeof(UUIArtText),
				new Func<UClassStackOnlyPtr>(UUIArtText.StaticClass)
			},
			{
				typeof(UUIButtonComponent),
				new Func<UClassStackOnlyPtr>(UUIButtonComponent.StaticClass)
			},
			{
				typeof(UUIToggleComponent),
				new Func<UClassStackOnlyPtr>(UUIToggleComponent.StaticClass)
			},
			{
				typeof(UUIExtendToggle),
				new Func<UClassStackOnlyPtr>(UUIExtendToggle.StaticClass)
			},
			{
				typeof(UUIExtendToggleGroup),
				new Func<UClassStackOnlyPtr>(UUIExtendToggleGroup.StaticClass)
			},
			{
				typeof(UUISliderComponent),
				new Func<UClassStackOnlyPtr>(UUISliderComponent.StaticClass)
			},
			{
				typeof(UUITextInputComponent),
				new Func<UClassStackOnlyPtr>(UUITextInputComponent.StaticClass)
			},
			{
				typeof(UUIDropdownComponent),
				new Func<UClassStackOnlyPtr>(UUIDropdownComponent.StaticClass)
			},
			{
				typeof(UUIDraggableComponent),
				new Func<UClassStackOnlyPtr>(UUIDraggableComponent.StaticClass)
			},
			{
				typeof(UUIScrollViewComponent),
				new Func<UClassStackOnlyPtr>(UUIScrollViewComponent.StaticClass)
			},
			{
				typeof(UUIScrollbarComponent),
				new Func<UClassStackOnlyPtr>(UUIScrollbarComponent.StaticClass)
			},
			{
				typeof(UUILoopScrollViewComponent),
				new Func<UClassStackOnlyPtr>(UUILoopScrollViewComponent.StaticClass)
			},
			{
				typeof(UUIMultiTemplateScrollViewComponent),
				new Func<UClassStackOnlyPtr>(UUIMultiTemplateScrollViewComponent.StaticClass)
			},
			{
				typeof(UUIDynScrollViewComponent),
				new Func<UClassStackOnlyPtr>(UUIDynScrollViewComponent.StaticClass)
			},
			{
				typeof(UUIScrollViewWithScrollbarComponent),
				new Func<UClassStackOnlyPtr>(UUIScrollViewWithScrollbarComponent.StaticClass)
			},
			{
				typeof(UUILayoutBase),
				new Func<UClassStackOnlyPtr>(UUILayoutBase.StaticClass)
			},
			{
				typeof(UUIVerticalLayout),
				new Func<UClassStackOnlyPtr>(UUIVerticalLayout.StaticClass)
			},
			{
				typeof(UUIHorizontalLayout),
				new Func<UClassStackOnlyPtr>(UUIHorizontalLayout.StaticClass)
			},
			{
				typeof(UUIGridLayout),
				new Func<UClassStackOnlyPtr>(UUIGridLayout.StaticClass)
			},
			{
				typeof(UUIMultiTemplateLayout),
				new Func<UClassStackOnlyPtr>(UUIMultiTemplateLayout.StaticClass)
			},
			{
				typeof(UUISizeControlByOther),
				new Func<UClassStackOnlyPtr>(UUISizeControlByOther.StaticClass)
			},
			{
				typeof(UUISprite),
				new Func<UClassStackOnlyPtr>(UUISprite.StaticClass)
			},
			{
				typeof(UUITexture),
				new Func<UClassStackOnlyPtr>(UUITexture.StaticClass)
			},
			{
				typeof(UUIExtendToggleSpriteTransition),
				new Func<UClassStackOnlyPtr>(UUIExtendToggleSpriteTransition.StaticClass)
			},
			{
				typeof(UUIExtendToggleTextureTransition),
				new Func<UClassStackOnlyPtr>(UUIExtendToggleTextureTransition.StaticClass)
			},
			{
				typeof(UUIExtendToggleTextTransition),
				new Func<UClassStackOnlyPtr>(UUIExtendToggleTextTransition.StaticClass)
			},
			{
				typeof(UUISpriteTransition),
				new Func<UClassStackOnlyPtr>(UUISpriteTransition.StaticClass)
			},
			{
				typeof(UUITextTransition),
				new Func<UClassStackOnlyPtr>(UUITextTransition.StaticClass)
			},
			{
				typeof(UUITextureTransitionComponent),
				new Func<UClassStackOnlyPtr>(UUITextureTransitionComponent.StaticClass)
			},
			{
				typeof(UUINiagara),
				new Func<UClassStackOnlyPtr>(UUINiagara.StaticClass)
			},
			{
				typeof(USpineSkeletonAnimationComponent),
				new Func<UClassStackOnlyPtr>(USpineSkeletonAnimationComponent.StaticClass)
			},
			{
				typeof(UUISelectableStateHolder),
				new Func<UClassStackOnlyPtr>(UUISelectableStateHolder.StaticClass)
			},
			{
				typeof(UUIInteractionGroup),
				new Func<UClassStackOnlyPtr>(UUIInteractionGroup.StaticClass)
			},
			{
				typeof(UUIDynamicBatchMesh),
				new Func<UClassStackOnlyPtr>(UUIDynamicBatchMesh.StaticClass)
			},
			{
				typeof(UUIInturnAnimController),
				new Func<UClassStackOnlyPtr>(UUIInturnAnimController.StaticClass)
			},
			{
				typeof(UUI2DLineRaw),
				new Func<UClassStackOnlyPtr>(UUI2DLineRaw.StaticClass)
			},
			{
				typeof(UUILangTexture),
				new Func<UClassStackOnlyPtr>(UUILangTexture.StaticClass)
			}
		};

		// Token: 0x04018D7E RID: 101758
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		protected List<ValueTuple<int, Type>> ComponentRegisterInfos = new List<ValueTuple<int, Type>>();

		// Token: 0x04018D7F RID: 101759
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		protected List<ValueTuple<int, Delegate>> BtnBindInfo = new List<ValueTuple<int, Delegate>>();

		// Token: 0x04018D80 RID: 101760
		private UGuideHookRegistry _guideRegistry;

		// Token: 0x04018D81 RID: 101761
		protected UiPoolActor UiPoolActorNew;

		// Token: 0x04018D82 RID: 101762
		[Nullable(1)]
		private readonly UiImageSettingModule _uiImageSettingModule = new UiImageSettingModule();

		// Token: 0x04018D83 RID: 101763
		[Nullable(1)]
		private readonly UiNiagaraSettingModule _uiNiagaraSettingModule = new UiNiagaraSettingModule();

		// Token: 0x04018D84 RID: 101764
		[Nullable(1)]
		private readonly UiSpineLoadModule _uiSpineLoadModule = new UiSpineLoadModule();

		// Token: 0x04018D85 RID: 101765
		[Nullable(1)]
		private readonly UiPrefabLoadModule _uiPrefabLoadModule = new UiPrefabLoadModule();

		// Token: 0x04018D86 RID: 101766
		protected UiAsyncTaskManager TaskManager;
	}
}
