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
	// Token: 0x0200355C RID: 13660
	[NullableContext(1)]
	[Nullable(0)]
	public class UiPanelBase : ComponentAction
	{
		// Token: 0x1700489E RID: 18590
		// (get) Token: 0x06022B9E RID: 142238 RVA: 0x009DFE05 File Offset: 0x009DE005
		// (set) Token: 0x06022B9F RID: 142239 RVA: 0x009DFE0D File Offset: 0x009DE00D
		public bool SkipDestroyActor { get; set; }

		// Token: 0x06022BA0 RID: 142240 RVA: 0x009DFE18 File Offset: 0x009DE018
		public UiPanelBase()
		{
			this.MemoryTag = base.GetType().Name;
		}

		// Token: 0x06022BA1 RID: 142241 RVA: 0x009DFEB5 File Offset: 0x009DE0B5
		protected virtual void OnRegisterComponent()
		{
		}

		// Token: 0x06022BA2 RID: 142242 RVA: 0x009DFEB7 File Offset: 0x009DE0B7
		protected virtual void OnBeforeCreate()
		{
		}

		// Token: 0x06022BA3 RID: 142243 RVA: 0x009DFEB9 File Offset: 0x009DE0B9
		protected virtual UniTask OnCreateAsync()
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x06022BA4 RID: 142244 RVA: 0x009DFEC0 File Offset: 0x009DE0C0
		protected virtual UniTask OnBeforeStartAsync()
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x06022BA5 RID: 142245 RVA: 0x009DFEC7 File Offset: 0x009DE0C7
		protected virtual void OnStart()
		{
		}

		// Token: 0x06022BA6 RID: 142246 RVA: 0x009DFEC9 File Offset: 0x009DE0C9
		protected virtual void OnBeforeShow()
		{
		}

		// Token: 0x06022BA7 RID: 142247 RVA: 0x009DFECB File Offset: 0x009DE0CB
		protected virtual void OnAfterShow()
		{
		}

		// Token: 0x06022BA8 RID: 142248 RVA: 0x009DFECD File Offset: 0x009DE0CD
		protected virtual UniTask OnBeforeHideAsync()
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x06022BA9 RID: 142249 RVA: 0x009DFED4 File Offset: 0x009DE0D4
		protected virtual void OnBeforeHide()
		{
		}

		// Token: 0x06022BAA RID: 142250 RVA: 0x009DFED6 File Offset: 0x009DE0D6
		protected virtual void OnAfterHide()
		{
		}

		// Token: 0x06022BAB RID: 142251 RVA: 0x009DFED8 File Offset: 0x009DE0D8
		protected virtual void OnBeforeDestroy()
		{
		}

		// Token: 0x06022BAC RID: 142252 RVA: 0x009DFEDA File Offset: 0x009DE0DA
		protected virtual void OnAfterDestroy()
		{
		}

		// Token: 0x06022BAD RID: 142253 RVA: 0x009DFEDC File Offset: 0x009DE0DC
		protected virtual void OnAutoDestroy()
		{
		}

		// Token: 0x06022BAE RID: 142254 RVA: 0x009DFEDE File Offset: 0x009DE0DE
		protected virtual void OnBeforeCreateImplement()
		{
		}

		// Token: 0x06022BAF RID: 142255 RVA: 0x009DFEE0 File Offset: 0x009DE0E0
		protected virtual UniTask OnCreateAsyncImplementImplement()
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x06022BB0 RID: 142256 RVA: 0x009DFEE7 File Offset: 0x009DE0E7
		protected virtual void OnAfterCreateImplement()
		{
		}

		// Token: 0x06022BB1 RID: 142257 RVA: 0x009DFEE9 File Offset: 0x009DE0E9
		protected virtual void OnStartImplement()
		{
		}

		// Token: 0x06022BB2 RID: 142258 RVA: 0x009DFEEB File Offset: 0x009DE0EB
		protected virtual UniTask OnBeforeShowAsyncImplement()
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x06022BB3 RID: 142259 RVA: 0x009DFEF2 File Offset: 0x009DE0F2
		protected virtual void OnBeforeShowImplement()
		{
		}

		// Token: 0x06022BB4 RID: 142260 RVA: 0x009DFEF4 File Offset: 0x009DE0F4
		protected virtual void OnAfterShowImplement()
		{
		}

		// Token: 0x06022BB5 RID: 142261 RVA: 0x009DFEF6 File Offset: 0x009DE0F6
		protected virtual UniTask OnShowAsyncImplementImplement()
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x06022BB6 RID: 142262 RVA: 0x009DFEFD File Offset: 0x009DE0FD
		protected virtual UniTask OnHideAsyncImplementImplement()
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x06022BB7 RID: 142263 RVA: 0x009DFF04 File Offset: 0x009DE104
		protected virtual UniTask OnDestroyAsyncImplementImplement()
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x06022BB8 RID: 142264 RVA: 0x009DFF0B File Offset: 0x009DE10B
		protected virtual void OnBeforeHideImplement()
		{
		}

		// Token: 0x06022BB9 RID: 142265 RVA: 0x009DFF0D File Offset: 0x009DE10D
		protected virtual void OnAfterHideImplement()
		{
		}

		// Token: 0x06022BBA RID: 142266 RVA: 0x009DFF0F File Offset: 0x009DE10F
		protected virtual void OnBeforeDestroyImplement()
		{
		}

		// Token: 0x06022BBB RID: 142267 RVA: 0x009DFF11 File Offset: 0x009DE111
		protected virtual void OnAfterDestroyImplement()
		{
		}

		// Token: 0x06022BBC RID: 142268 RVA: 0x009DFF14 File Offset: 0x009DE114
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

		// Token: 0x06022BBD RID: 142269 RVA: 0x009DFF58 File Offset: 0x009DE158
		protected override UniTask OnStartAsyncImplement()
		{
			UiPanelBase.<OnStartAsyncImplement>d__52 <OnStartAsyncImplement>d__;
			<OnStartAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnStartAsyncImplement>d__.<>4__this = this;
			<OnStartAsyncImplement>d__.<>1__state = -1;
			<OnStartAsyncImplement>d__.<>t__builder.Start<UiPanelBase.<OnStartAsyncImplement>d__52>(ref <OnStartAsyncImplement>d__);
			return <OnStartAsyncImplement>d__.<>t__builder.Task;
		}

		// Token: 0x06022BBE RID: 142270 RVA: 0x009DFF9C File Offset: 0x009DE19C
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

		// Token: 0x06022BBF RID: 142271 RVA: 0x009E0038 File Offset: 0x009DE238
		protected override UniTask OnShowAsyncImplement()
		{
			UiPanelBase.<OnShowAsyncImplement>d__54 <OnShowAsyncImplement>d__;
			<OnShowAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnShowAsyncImplement>d__.<>4__this = this;
			<OnShowAsyncImplement>d__.<>1__state = -1;
			<OnShowAsyncImplement>d__.<>t__builder.Start<UiPanelBase.<OnShowAsyncImplement>d__54>(ref <OnShowAsyncImplement>d__);
			return <OnShowAsyncImplement>d__.<>t__builder.Task;
		}

		// Token: 0x06022BC0 RID: 142272 RVA: 0x009E007B File Offset: 0x009DE27B
		protected virtual void OnShowAsyncImplementImplementCompatible()
		{
		}

		// Token: 0x06022BC1 RID: 142273 RVA: 0x009E0080 File Offset: 0x009DE280
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

		// Token: 0x06022BC2 RID: 142274 RVA: 0x009E0134 File Offset: 0x009DE334
		protected override UniTask OnHideAsyncImplement()
		{
			UiPanelBase.<OnHideAsyncImplement>d__57 <OnHideAsyncImplement>d__;
			<OnHideAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnHideAsyncImplement>d__.<>4__this = this;
			<OnHideAsyncImplement>d__.<>1__state = -1;
			<OnHideAsyncImplement>d__.<>t__builder.Start<UiPanelBase.<OnHideAsyncImplement>d__57>(ref <OnHideAsyncImplement>d__);
			return <OnHideAsyncImplement>d__.<>t__builder.Task;
		}

		// Token: 0x06022BC3 RID: 142275 RVA: 0x009E0177 File Offset: 0x009DE377
		protected virtual void OnHideAsyncImplementImplementCompatible()
		{
		}

		// Token: 0x06022BC4 RID: 142276 RVA: 0x009E017C File Offset: 0x009DE37C
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

		// Token: 0x06022BC5 RID: 142277 RVA: 0x009E0230 File Offset: 0x009DE430
		protected override UniTask OnDestroyAsyncImplement()
		{
			UiPanelBase.<OnDestroyAsyncImplement>d__60 <OnDestroyAsyncImplement>d__;
			<OnDestroyAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnDestroyAsyncImplement>d__.<>4__this = this;
			<OnDestroyAsyncImplement>d__.<>1__state = -1;
			<OnDestroyAsyncImplement>d__.<>t__builder.Start<UiPanelBase.<OnDestroyAsyncImplement>d__60>(ref <OnDestroyAsyncImplement>d__);
			return <OnDestroyAsyncImplement>d__.<>t__builder.Task;
		}

		// Token: 0x06022BC6 RID: 142278 RVA: 0x009E0273 File Offset: 0x009DE473
		protected virtual void OnDestroyAsyncImplementImplementCompatible()
		{
		}

		// Token: 0x06022BC7 RID: 142279 RVA: 0x009E0278 File Offset: 0x009DE478
		protected override void OnDestroyImplementCompatible()
		{
			this.RestoreAllSwitchers();
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

		// Token: 0x06022BC8 RID: 142280 RVA: 0x009E033C File Offset: 0x009DE53C
		public void SetRootActorLoadInfoByPath(string actorPath, [Nullable(2)] UUIItem parentItem = null, bool usePool = false, bool isPermanent = false)
		{
			this._actorPath = actorPath;
			this.ParentUiItem = parentItem;
			this.UsePool = usePool;
			this._isPermanent = isPermanent;
		}

		// Token: 0x06022BC9 RID: 142281 RVA: 0x009E035B File Offset: 0x009DE55B
		public void SetRootActorLoadInfo(string resourceId, [Nullable(2)] UUIItem parentItem = null, bool usePool = false, bool isPermanent = false)
		{
			this._actorPath = UiResourceConfig.Instance.GetResourcePath(resourceId);
			this.ParentUiItem = parentItem;
			this.UsePool = usePool;
			this._isPermanent = isPermanent;
		}

		// Token: 0x06022BCA RID: 142282 RVA: 0x009E0384 File Offset: 0x009DE584
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

		// Token: 0x06022BCB RID: 142283 RVA: 0x009E03E0 File Offset: 0x009DE5E0
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

		// Token: 0x06022BCC RID: 142284 RVA: 0x009E043C File Offset: 0x009DE63C
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

		// Token: 0x06022BCD RID: 142285 RVA: 0x009E0498 File Offset: 0x009DE698
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

		// Token: 0x06022BCE RID: 142286 RVA: 0x009E04F4 File Offset: 0x009DE6F4
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

		// Token: 0x06022BCF RID: 142287 RVA: 0x009E0550 File Offset: 0x009DE750
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

		// Token: 0x06022BD0 RID: 142288 RVA: 0x009E05AC File Offset: 0x009DE7AC
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

		// Token: 0x06022BD1 RID: 142289 RVA: 0x009E0608 File Offset: 0x009DE808
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

		// Token: 0x06022BD2 RID: 142290 RVA: 0x009E0663 File Offset: 0x009DE863
		public virtual void SetActive(bool visibility)
		{
			if (visibility)
			{
				base.Show(null);
				return;
			}
			base.Hide(null);
		}

		// Token: 0x06022BD3 RID: 142291 RVA: 0x009E0677 File Offset: 0x009DE877
		public bool GetActive()
		{
			return this.RootItem != null && this.RootItem.IsValid() && this.RootItem.IsUIActiveSelf();
		}

		// Token: 0x06022BD4 RID: 142292 RVA: 0x009E069B File Offset: 0x009DE89B
		public bool IsUiActiveInHierarchy()
		{
			return this.RootItem != null && this.RootItem.IsValid() && this.RootItem.IsUIActiveInHierarchy();
		}

		// Token: 0x06022BD5 RID: 142293 RVA: 0x009E06BF File Offset: 0x009DE8BF
		public void SetUiActive(bool visibility)
		{
			if (this.RootItem == null || !this.RootItem.IsValid())
			{
				return;
			}
			this.RootItem.SetUIActive(visibility);
		}

		// Token: 0x06022BD6 RID: 142294 RVA: 0x009E06E3 File Offset: 0x009DE8E3
		public bool InAsyncLoading()
		{
			return base.IsCreating;
		}

		// Token: 0x06022BD7 RID: 142295 RVA: 0x009E06EC File Offset: 0x009DE8EC
		private UniTask LoadRootActorAsync()
		{
			UiPanelBase.<LoadRootActorAsync>d__78 <LoadRootActorAsync>d__;
			<LoadRootActorAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadRootActorAsync>d__.<>4__this = this;
			<LoadRootActorAsync>d__.<>1__state = -1;
			<LoadRootActorAsync>d__.<>t__builder.Start<UiPanelBase.<LoadRootActorAsync>d__78>(ref <LoadRootActorAsync>d__);
			return <LoadRootActorAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06022BD8 RID: 142296 RVA: 0x009E0730 File Offset: 0x009DE930
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

		// Token: 0x06022BD9 RID: 142297 RVA: 0x009E0846 File Offset: 0x009DEA46
		private void RefreshMemoryTag()
		{
			if (this._originalItem != null && this._originalItem.IsValid())
			{
				this.MemoryTag = LguiUtil.Instance.GetRootActorMemoryTag(this._originalItem, null);
			}
		}

		// Token: 0x06022BDA RID: 142298 RVA: 0x009E0874 File Offset: 0x009DEA74
		private void InitRootActorAndComponentRegistry()
		{
			this.OnRegisterComponent();
			this.RootActor = (this.FindInitedComponentRegistryActor() ?? this._originalActor);
			AUIBaseActor rootActor = this.RootActor;
			this.RootItem = (((rootActor != null) ? rootActor.GetComponentByClass(UUIItem.StaticClass()) : null) as UUIItem);
		}

		// Token: 0x06022BDB RID: 142299 RVA: 0x009E08C4 File Offset: 0x009DEAC4
		[NullableContext(2)]
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

		// Token: 0x06022BDC RID: 142300 RVA: 0x009E0B5C File Offset: 0x009DED5C
		protected virtual bool DestroyOverride()
		{
			return false;
		}

		// Token: 0x06022BDD RID: 142301 RVA: 0x009E0B60 File Offset: 0x009DED60
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

		// Token: 0x06022BDE RID: 142302 RVA: 0x009E0BC4 File Offset: 0x009DEDC4
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

		// Token: 0x06022BDF RID: 142303 RVA: 0x009E0C88 File Offset: 0x009DEE88
		[NullableContext(2)]
		private void AutoDestroy(AActor aActor)
		{
			if (base.IsDestroyOrDestroying)
			{
				return;
			}
			this.OnAutoDestroy();
			base.Destroy(null);
		}

		// Token: 0x06022BE0 RID: 142304 RVA: 0x009E0CA0 File Offset: 0x009DEEA0
		[NullableContext(2)]
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

		// Token: 0x06022BE1 RID: 142305 RVA: 0x009E0CEF File Offset: 0x009DEEEF
		[NullableContext(2)]
		public UUIItem GetRootItem()
		{
			return this.RootItem;
		}

		// Token: 0x06022BE2 RID: 142306 RVA: 0x009E0CF7 File Offset: 0x009DEEF7
		[NullableContext(2)]
		public AActor GetRootActor()
		{
			return this.RootActor;
		}

		// Token: 0x06022BE3 RID: 142307 RVA: 0x009E0CFF File Offset: 0x009DEEFF
		[NullableContext(2)]
		public AActor GetOriginalActor()
		{
			return this._originalActor;
		}

		// Token: 0x06022BE4 RID: 142308 RVA: 0x009E0D07 File Offset: 0x009DEF07
		[NullableContext(2)]
		public virtual UUIItem GetOriginalItem()
		{
			return this._originalItem;
		}

		// Token: 0x06022BE5 RID: 142309 RVA: 0x009E0D0F File Offset: 0x009DEF0F
		[NullableContext(2)]
		public virtual CustomPromise GetClosePromiseImplement()
		{
			return null;
		}

		// Token: 0x06022BE6 RID: 142310 RVA: 0x009E0D12 File Offset: 0x009DEF12
		private void RecycleAsyncLoad()
		{
			UiActorPool.Instance.RecycleAsync(this.UiPoolActorNew, this._actorPath);
			this.UiPoolActorNew = null;
		}

		// Token: 0x06022BE7 RID: 142311 RVA: 0x009E0D34 File Offset: 0x009DEF34
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

		// Token: 0x06022BE8 RID: 142312 RVA: 0x009E0DE4 File Offset: 0x009DEFE4
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

		// Token: 0x06022BE9 RID: 142313 RVA: 0x009E0EC4 File Offset: 0x009DF0C4
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

		// Token: 0x06022BEA RID: 142314 RVA: 0x009E0FA4 File Offset: 0x009DF1A4
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

		// Token: 0x06022BEB RID: 142315 RVA: 0x009E108C File Offset: 0x009DF28C
		protected void UnBindOnClickEvents()
		{
			foreach (ValueTuple<int, Delegate> valueTuple in this.BtnBindInfo)
			{
				this.UnBindOnClickEvent(valueTuple.Item1);
			}
		}

		// Token: 0x06022BEC RID: 142316 RVA: 0x009E10E4 File Offset: 0x009DF2E4
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

		// Token: 0x06022BED RID: 142317 RVA: 0x009E11E4 File Offset: 0x009DF3E4
		protected void PostClickAudioEvent(string eventPath)
		{
			string text = AudioSystem.Instance.parseAudioEventPath(eventPath);
			if (text != null)
			{
				AudioSystem.Instance.PostEvent(text);
			}
		}

		// Token: 0x06022BEE RID: 142318 RVA: 0x009E120C File Offset: 0x009DF40C
		[NullableContext(2)]
		protected UUIButtonComponent GetButton(int name)
		{
			Tuple<Type, UActorComponent> tuple;
			if (!this.BaseComponentMap.TryGetValue(name, out tuple))
			{
				return null;
			}
			return tuple.Item2 as UUIButtonComponent;
		}

		// Token: 0x06022BEF RID: 142319 RVA: 0x009E1238 File Offset: 0x009DF438
		[NullableContext(2)]
		protected UUIItem GetItem(int name)
		{
			Tuple<Type, UActorComponent> tuple;
			if (!this.BaseComponentMap.TryGetValue(name, out tuple))
			{
				return null;
			}
			return tuple.Item2 as UUIItem;
		}

		// Token: 0x06022BF0 RID: 142320 RVA: 0x009E1264 File Offset: 0x009DF464
		[NullableContext(2)]
		protected USpineSkeletonAnimationComponent GetSpine(int name)
		{
			Tuple<Type, UActorComponent> tuple;
			if (!this.BaseComponentMap.TryGetValue(name, out tuple))
			{
				return null;
			}
			return tuple.Item2 as USpineSkeletonAnimationComponent;
		}

		// Token: 0x06022BF1 RID: 142321 RVA: 0x009E1290 File Offset: 0x009DF490
		[NullableContext(2)]
		protected UUIInteractionGroup GetInteractionGroup(int name)
		{
			Tuple<Type, UActorComponent> tuple;
			if (!this.BaseComponentMap.TryGetValue(name, out tuple))
			{
				return null;
			}
			return tuple.Item2 as UUIInteractionGroup;
		}

		// Token: 0x06022BF2 RID: 142322 RVA: 0x009E12BC File Offset: 0x009DF4BC
		[NullableContext(2)]
		protected UUIText GetText(int name)
		{
			Tuple<Type, UActorComponent> tuple;
			if (!this.BaseComponentMap.TryGetValue(name, out tuple))
			{
				return null;
			}
			return tuple.Item2 as UUIText;
		}

		// Token: 0x06022BF3 RID: 142323 RVA: 0x009E12E8 File Offset: 0x009DF4E8
		[NullableContext(2)]
		protected UUIArtText GetArtText(int name)
		{
			Tuple<Type, UActorComponent> tuple;
			if (!this.BaseComponentMap.TryGetValue(name, out tuple))
			{
				return null;
			}
			return tuple.Item2 as UUIArtText;
		}

		// Token: 0x06022BF4 RID: 142324 RVA: 0x009E1314 File Offset: 0x009DF514
		[NullableContext(2)]
		protected UUISprite GetSprite(int name)
		{
			Tuple<Type, UActorComponent> tuple;
			if (!this.BaseComponentMap.TryGetValue(name, out tuple))
			{
				return null;
			}
			return tuple.Item2 as UUISprite;
		}

		// Token: 0x06022BF5 RID: 142325 RVA: 0x009E1340 File Offset: 0x009DF540
		[NullableContext(2)]
		protected UUITexture GetTexture(int name)
		{
			Tuple<Type, UActorComponent> tuple;
			if (!this.BaseComponentMap.TryGetValue(name, out tuple))
			{
				return null;
			}
			return tuple.Item2 as UUITexture;
		}

		// Token: 0x06022BF6 RID: 142326 RVA: 0x009E136C File Offset: 0x009DF56C
		[NullableContext(2)]
		protected UUIRenderableMask GetRenderableMask(int name)
		{
			Tuple<Type, UActorComponent> tuple;
			if (!this.BaseComponentMap.TryGetValue(name, out tuple))
			{
				return null;
			}
			return tuple.Item2 as UUIRenderableMask;
		}

		// Token: 0x06022BF7 RID: 142327 RVA: 0x009E1398 File Offset: 0x009DF598
		[NullableContext(2)]
		protected UUILangTexture GetLangTexture(int name)
		{
			Tuple<Type, UActorComponent> tuple;
			if (!this.BaseComponentMap.TryGetValue(name, out tuple))
			{
				return null;
			}
			return tuple.Item2 as UUILangTexture;
		}

		// Token: 0x06022BF8 RID: 142328 RVA: 0x009E13C4 File Offset: 0x009DF5C4
		[NullableContext(2)]
		protected UUISliderComponent GetSlider(int name)
		{
			Tuple<Type, UActorComponent> tuple;
			if (!this.BaseComponentMap.TryGetValue(name, out tuple))
			{
				return null;
			}
			return tuple.Item2 as UUISliderComponent;
		}

		// Token: 0x06022BF9 RID: 142329 RVA: 0x009E13F0 File Offset: 0x009DF5F0
		[NullableContext(2)]
		protected UUIToggleComponent GetToggle(int name)
		{
			Tuple<Type, UActorComponent> tuple;
			if (!this.BaseComponentMap.TryGetValue(name, out tuple))
			{
				return null;
			}
			return tuple.Item2 as UUIToggleComponent;
		}

		// Token: 0x06022BFA RID: 142330 RVA: 0x009E141C File Offset: 0x009DF61C
		[NullableContext(2)]
		protected UUIExtendToggle GetExtendToggle(int name)
		{
			Tuple<Type, UActorComponent> tuple;
			if (!this.BaseComponentMap.TryGetValue(name, out tuple))
			{
				return null;
			}
			return tuple.Item2 as UUIExtendToggle;
		}

		// Token: 0x06022BFB RID: 142331 RVA: 0x009E1448 File Offset: 0x009DF648
		[NullableContext(2)]
		protected UUIExtendToggleGroup GetExtendToggleGroup(int name)
		{
			Tuple<Type, UActorComponent> tuple;
			if (!this.BaseComponentMap.TryGetValue(name, out tuple))
			{
				return null;
			}
			return tuple.Item2 as UUIExtendToggleGroup;
		}

		// Token: 0x06022BFC RID: 142332 RVA: 0x009E1474 File Offset: 0x009DF674
		[NullableContext(2)]
		protected UUIScrollViewWithScrollbarComponent GetScrollViewWithScrollbar(int name)
		{
			Tuple<Type, UActorComponent> tuple;
			if (!this.BaseComponentMap.TryGetValue(name, out tuple))
			{
				return null;
			}
			return tuple.Item2 as UUIScrollViewWithScrollbarComponent;
		}

		// Token: 0x06022BFD RID: 142333 RVA: 0x009E14A0 File Offset: 0x009DF6A0
		[NullableContext(2)]
		protected UUIDynScrollViewComponent GetUIDynScrollViewComponent(int name)
		{
			Tuple<Type, UActorComponent> tuple;
			if (!this.BaseComponentMap.TryGetValue(name, out tuple))
			{
				return null;
			}
			return tuple.Item2 as UUIDynScrollViewComponent;
		}

		// Token: 0x06022BFE RID: 142334 RVA: 0x009E14CC File Offset: 0x009DF6CC
		[NullableContext(2)]
		protected UUIScrollbarComponent GetScrollScrollbar(int name)
		{
			Tuple<Type, UActorComponent> tuple;
			if (!this.BaseComponentMap.TryGetValue(name, out tuple))
			{
				return null;
			}
			return tuple.Item2 as UUIScrollbarComponent;
		}

		// Token: 0x06022BFF RID: 142335 RVA: 0x009E14F8 File Offset: 0x009DF6F8
		[NullableContext(2)]
		protected UUIScrollViewComponent GetScrollView(int name)
		{
			Tuple<Type, UActorComponent> tuple;
			if (!this.BaseComponentMap.TryGetValue(name, out tuple))
			{
				return null;
			}
			return tuple.Item2 as UUIScrollViewComponent;
		}

		// Token: 0x06022C00 RID: 142336 RVA: 0x009E1524 File Offset: 0x009DF724
		[NullableContext(2)]
		protected UUILoopScrollViewComponent GetLoopScrollViewComponent(int name)
		{
			Tuple<Type, UActorComponent> tuple;
			if (!this.BaseComponentMap.TryGetValue(name, out tuple))
			{
				return null;
			}
			return tuple.Item2 as UUILoopScrollViewComponent;
		}

		// Token: 0x06022C01 RID: 142337 RVA: 0x009E1550 File Offset: 0x009DF750
		[NullableContext(2)]
		protected UUIMultiTemplateScrollViewComponent GetMultiTemplateScrollViewComponent(int name)
		{
			Tuple<Type, UActorComponent> tuple;
			if (!this.BaseComponentMap.TryGetValue(name, out tuple))
			{
				return null;
			}
			return tuple.Item2 as UUIMultiTemplateScrollViewComponent;
		}

		// Token: 0x06022C02 RID: 142338 RVA: 0x009E157C File Offset: 0x009DF77C
		[NullableContext(2)]
		protected UUIDropdownComponent GetDropdown(int name)
		{
			Tuple<Type, UActorComponent> tuple;
			if (!this.BaseComponentMap.TryGetValue(name, out tuple))
			{
				return null;
			}
			return tuple.Item2 as UUIDropdownComponent;
		}

		// Token: 0x06022C03 RID: 142339 RVA: 0x009E15A8 File Offset: 0x009DF7A8
		[NullableContext(2)]
		protected UUITextInputComponent GetInputText(int name)
		{
			Tuple<Type, UActorComponent> tuple;
			if (!this.BaseComponentMap.TryGetValue(name, out tuple))
			{
				return null;
			}
			return tuple.Item2 as UUITextInputComponent;
		}

		// Token: 0x06022C04 RID: 142340 RVA: 0x009E15D4 File Offset: 0x009DF7D4
		[NullableContext(2)]
		protected UUIDraggableComponent GetDraggable(int name)
		{
			Tuple<Type, UActorComponent> tuple;
			if (!this.BaseComponentMap.TryGetValue(name, out tuple))
			{
				return null;
			}
			return tuple.Item2 as UUIDraggableComponent;
		}

		// Token: 0x06022C05 RID: 142341 RVA: 0x009E1600 File Offset: 0x009DF800
		[NullableContext(2)]
		protected UUINiagara GetUiNiagara(int name)
		{
			Tuple<Type, UActorComponent> tuple;
			if (!this.BaseComponentMap.TryGetValue(name, out tuple))
			{
				return null;
			}
			return tuple.Item2 as UUINiagara;
		}

		// Token: 0x06022C06 RID: 142342 RVA: 0x009E162C File Offset: 0x009DF82C
		[NullableContext(2)]
		protected UUIVerticalLayout GetVerticalLayout(int name)
		{
			Tuple<Type, UActorComponent> tuple;
			if (!this.BaseComponentMap.TryGetValue(name, out tuple))
			{
				return null;
			}
			return tuple.Item2 as UUIVerticalLayout;
		}

		// Token: 0x06022C07 RID: 142343 RVA: 0x009E1658 File Offset: 0x009DF858
		[NullableContext(2)]
		protected UUIHorizontalLayout GetHorizontalLayout(int name)
		{
			Tuple<Type, UActorComponent> tuple;
			if (!this.BaseComponentMap.TryGetValue(name, out tuple))
			{
				return null;
			}
			return tuple.Item2 as UUIHorizontalLayout;
		}

		// Token: 0x06022C08 RID: 142344 RVA: 0x009E1684 File Offset: 0x009DF884
		[NullableContext(2)]
		protected UUIMultiTemplateLayout GetMultiTemplateLayout(int name)
		{
			Tuple<Type, UActorComponent> tuple;
			if (!this.BaseComponentMap.TryGetValue(name, out tuple))
			{
				return null;
			}
			return tuple.Item2 as UUIMultiTemplateLayout;
		}

		// Token: 0x06022C09 RID: 142345 RVA: 0x009E16B0 File Offset: 0x009DF8B0
		[NullableContext(2)]
		protected UUIGridLayout GetGridLayout(int name)
		{
			Tuple<Type, UActorComponent> tuple;
			if (!this.BaseComponentMap.TryGetValue(name, out tuple))
			{
				return null;
			}
			return tuple.Item2 as UUIGridLayout;
		}

		// Token: 0x06022C0A RID: 142346 RVA: 0x009E16DC File Offset: 0x009DF8DC
		[NullableContext(2)]
		protected UUILayoutBase GetLayoutBase(int name)
		{
			Tuple<Type, UActorComponent> tuple;
			if (!this.BaseComponentMap.TryGetValue(name, out tuple))
			{
				return null;
			}
			return tuple.Item2 as UUILayoutBase;
		}

		// Token: 0x06022C0B RID: 142347 RVA: 0x009E1708 File Offset: 0x009DF908
		[NullableContext(2)]
		protected UUITextTransition GetUITextTransition(int name)
		{
			Tuple<Type, UActorComponent> tuple;
			if (!this.BaseComponentMap.TryGetValue(name, out tuple))
			{
				return null;
			}
			return tuple.Item2 as UUITextTransition;
		}

		// Token: 0x06022C0C RID: 142348 RVA: 0x009E1734 File Offset: 0x009DF934
		[NullableContext(2)]
		protected UUITextureTransitionComponent GetUiTextureTransitionComponent(int name)
		{
			Tuple<Type, UActorComponent> tuple;
			if (!this.BaseComponentMap.TryGetValue(name, out tuple))
			{
				return null;
			}
			return tuple.Item2 as UUITextureTransitionComponent;
		}

		// Token: 0x06022C0D RID: 142349 RVA: 0x009E1760 File Offset: 0x009DF960
		[NullableContext(2)]
		protected UUISpriteTransition GetUiSpriteTransition(int name)
		{
			Tuple<Type, UActorComponent> tuple;
			if (!this.BaseComponentMap.TryGetValue(name, out tuple))
			{
				return null;
			}
			return tuple.Item2 as UUISpriteTransition;
		}

		// Token: 0x06022C0E RID: 142350 RVA: 0x009E178C File Offset: 0x009DF98C
		[NullableContext(2)]
		protected UUIExtendToggleSpriteTransition GetUiExtendToggleSpriteTransition(int name)
		{
			Tuple<Type, UActorComponent> tuple;
			if (!this.BaseComponentMap.TryGetValue(name, out tuple))
			{
				return null;
			}
			return tuple.Item2 as UUIExtendToggleSpriteTransition;
		}

		// Token: 0x06022C0F RID: 142351 RVA: 0x009E17B8 File Offset: 0x009DF9B8
		[NullableContext(2)]
		protected UUIExtendToggleTextureTransition GetUiExtendToggleTextureTransition(int name)
		{
			Tuple<Type, UActorComponent> tuple;
			if (!this.BaseComponentMap.TryGetValue(name, out tuple))
			{
				return null;
			}
			return tuple.Item2 as UUIExtendToggleTextureTransition;
		}

		// Token: 0x06022C10 RID: 142352 RVA: 0x009E17E4 File Offset: 0x009DF9E4
		[NullableContext(2)]
		protected UUIExtendToggleTextTransition GetUiExtendToggleTextTransition(int name)
		{
			Tuple<Type, UActorComponent> tuple;
			if (!this.BaseComponentMap.TryGetValue(name, out tuple))
			{
				return null;
			}
			return tuple.Item2 as UUIExtendToggleTextTransition;
		}

		// Token: 0x06022C11 RID: 142353 RVA: 0x009E1810 File Offset: 0x009DFA10
		[NullableContext(2)]
		protected UUISizeControlByOther GetUiSizeControlByOther(int name)
		{
			Tuple<Type, UActorComponent> tuple;
			if (!this.BaseComponentMap.TryGetValue(name, out tuple))
			{
				return null;
			}
			return tuple.Item2 as UUISizeControlByOther;
		}

		// Token: 0x06022C12 RID: 142354 RVA: 0x009E183C File Offset: 0x009DFA3C
		[NullableContext(2)]
		protected UUIDynamicBatchMesh GetDynamicBatchMesh(int name)
		{
			Tuple<Type, UActorComponent> tuple;
			if (!this.BaseComponentMap.TryGetValue(name, out tuple))
			{
				return null;
			}
			return tuple.Item2 as UUIDynamicBatchMesh;
		}

		// Token: 0x06022C13 RID: 142355 RVA: 0x009E1868 File Offset: 0x009DFA68
		[NullableContext(2)]
		protected UUIInturnAnimController GetUiInturnAnimController(int name)
		{
			Tuple<Type, UActorComponent> tuple;
			if (!this.BaseComponentMap.TryGetValue(name, out tuple))
			{
				return null;
			}
			return tuple.Item2 as UUIInturnAnimController;
		}

		// Token: 0x06022C14 RID: 142356 RVA: 0x009E1894 File Offset: 0x009DFA94
		[NullableContext(2)]
		protected UUI2DLineRaw GetUiLineRaw(int name)
		{
			Tuple<Type, UActorComponent> tuple;
			if (!this.BaseComponentMap.TryGetValue(name, out tuple))
			{
				return null;
			}
			return tuple.Item2 as UUI2DLineRaw;
		}

		// Token: 0x06022C15 RID: 142357 RVA: 0x009E18C0 File Offset: 0x009DFAC0
		[NullableContext(2)]
		protected UUIEffectTextAnimation GetUIEffectTextAnimation(int name)
		{
			Tuple<Type, UActorComponent> tuple;
			if (!this.BaseComponentMap.TryGetValue(name, out tuple))
			{
				return null;
			}
			return tuple.Item2 as UUIEffectTextAnimation;
		}

		// Token: 0x06022C16 RID: 142358 RVA: 0x009E18EC File Offset: 0x009DFAEC
		[NullableContext(2)]
		protected ULGUIPlayTweenComponent GetTween(int name)
		{
			Tuple<Type, UActorComponent> tuple;
			if (!this.BaseComponentMap.TryGetValue(name, out tuple))
			{
				return null;
			}
			return tuple.Item2 as ULGUIPlayTweenComponent;
		}

		// Token: 0x06022C17 RID: 142359 RVA: 0x009E1916 File Offset: 0x009DFB16
		private void InitGuideRegistry()
		{
			AActor rootActor = this.GetRootActor();
			this._guideRegistry = (((rootActor != null) ? rootActor.GetComponentByClass(UGuideHookRegistry.StaticClass()) : null) as UGuideHookRegistry);
		}

		// Token: 0x06022C18 RID: 142360 RVA: 0x009E1940 File Offset: 0x009DFB40
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

		// Token: 0x06022C19 RID: 142361 RVA: 0x009E1994 File Offset: 0x009DFB94
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

		// Token: 0x06022C1A RID: 142362 RVA: 0x009E19BE File Offset: 0x009DFBBE
		[NullableContext(2)]
		public virtual UUIScrollViewComponent GetGuideScrollViewToLock()
		{
			return null;
		}

		// Token: 0x06022C1B RID: 142363 RVA: 0x009E19C4 File Offset: 0x009DFBC4
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

		// Token: 0x06022C1C RID: 142364 RVA: 0x009E1A0C File Offset: 0x009DFC0C
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

		// Token: 0x06022C1D RID: 142365 RVA: 0x009E1A63 File Offset: 0x009DFC63
		protected bool CancelSpriteLoad(UUISprite uiSprite)
		{
			return this._uiImageSettingModule.CancelSpriteLoad(uiSprite);
		}

		// Token: 0x06022C1E RID: 142366 RVA: 0x009E1A71 File Offset: 0x009DFC71
		[NullableContext(2)]
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

		// Token: 0x06022C1F RID: 142367 RVA: 0x009E1A98 File Offset: 0x009DFC98
		protected UniTask SetSpriteTransitionByPath(string path, UUISpriteTransition uiSpriteTransition, EUISelectableSelectionState state = EUISelectableSelectionState.EUISelectableSelectionState_MAX)
		{
			UiPanelBase.<SetSpriteTransitionByPath>d__153 <SetSpriteTransitionByPath>d__;
			<SetSpriteTransitionByPath>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetSpriteTransitionByPath>d__.<>4__this = this;
			<SetSpriteTransitionByPath>d__.path = path;
			<SetSpriteTransitionByPath>d__.uiSpriteTransition = uiSpriteTransition;
			<SetSpriteTransitionByPath>d__.state = state;
			<SetSpriteTransitionByPath>d__.<>1__state = -1;
			<SetSpriteTransitionByPath>d__.<>t__builder.Start<UiPanelBase.<SetSpriteTransitionByPath>d__153>(ref <SetSpriteTransitionByPath>d__);
			return <SetSpriteTransitionByPath>d__.<>t__builder.Task;
		}

		// Token: 0x06022C20 RID: 142368 RVA: 0x009E1AF3 File Offset: 0x009DFCF3
		[NullableContext(2)]
		protected void SetTextureByPath([Nullable(1)] string path, UUITexture uiTexture, EUiViewName? syncLoadViewName = null, Action<bool> callback = null)
		{
			if (syncLoadViewName != null)
			{
				this._uiImageSettingModule.SetTextureByPathSync(path, uiTexture, syncLoadViewName.Value, callback);
				return;
			}
			this._uiImageSettingModule.SetTextureByPathAsync(path, uiTexture, callback);
		}

		// Token: 0x06022C21 RID: 142369 RVA: 0x009E1B24 File Offset: 0x009DFD24
		[NullableContext(2)]
		protected void SetRenderableMaskTextureByPath([Nullable(1)] string path, UUIRenderableMask renderableMask, Action<bool> callback = null)
		{
			this._uiImageSettingModule.SetRenderableMaskTextureByPathAsync(path, renderableMask, callback);
		}

		// Token: 0x06022C22 RID: 142370 RVA: 0x009E1B34 File Offset: 0x009DFD34
		[NullableContext(2)]
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

		// Token: 0x06022C23 RID: 142371 RVA: 0x009E1B5C File Offset: 0x009DFD5C
		protected UniTask SetTextureTransitionByPath(string path, UUITextureTransitionComponent uiTextureTransition, EUISelectableSelectionState state = EUISelectableSelectionState.EUISelectableSelectionState_MAX)
		{
			UiPanelBase.<SetTextureTransitionByPath>d__157 <SetTextureTransitionByPath>d__;
			<SetTextureTransitionByPath>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetTextureTransitionByPath>d__.<>4__this = this;
			<SetTextureTransitionByPath>d__.path = path;
			<SetTextureTransitionByPath>d__.uiTextureTransition = uiTextureTransition;
			<SetTextureTransitionByPath>d__.state = state;
			<SetTextureTransitionByPath>d__.<>1__state = -1;
			<SetTextureTransitionByPath>d__.<>t__builder.Start<UiPanelBase.<SetTextureTransitionByPath>d__157>(ref <SetTextureTransitionByPath>d__);
			return <SetTextureTransitionByPath>d__.<>t__builder.Task;
		}

		// Token: 0x06022C24 RID: 142372 RVA: 0x009E1BB8 File Offset: 0x009DFDB8
		protected UniTask SetExtendToggleTextureTransitionByPath(string path, UUIExtendToggleTextureTransition uiExtendToggleTextureTransition, EToggleTransitionState state = EToggleTransitionState.ETT_MAX)
		{
			UiPanelBase.<SetExtendToggleTextureTransitionByPath>d__158 <SetExtendToggleTextureTransitionByPath>d__;
			<SetExtendToggleTextureTransitionByPath>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetExtendToggleTextureTransitionByPath>d__.<>4__this = this;
			<SetExtendToggleTextureTransitionByPath>d__.path = path;
			<SetExtendToggleTextureTransitionByPath>d__.uiExtendToggleTextureTransition = uiExtendToggleTextureTransition;
			<SetExtendToggleTextureTransitionByPath>d__.state = state;
			<SetExtendToggleTextureTransitionByPath>d__.<>1__state = -1;
			<SetExtendToggleTextureTransitionByPath>d__.<>t__builder.Start<UiPanelBase.<SetExtendToggleTextureTransitionByPath>d__158>(ref <SetExtendToggleTextureTransitionByPath>d__);
			return <SetExtendToggleTextureTransitionByPath>d__.<>t__builder.Task;
		}

		// Token: 0x06022C25 RID: 142373 RVA: 0x009E1C14 File Offset: 0x009DFE14
		protected UniTask SetExtendToggleTextureTransitionGroupByPath(string path, UUIExtendToggleTextureTransition uiExtendToggleTextureTransition, EToggleTransitionState[] states)
		{
			UiPanelBase.<SetExtendToggleTextureTransitionGroupByPath>d__159 <SetExtendToggleTextureTransitionGroupByPath>d__;
			<SetExtendToggleTextureTransitionGroupByPath>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetExtendToggleTextureTransitionGroupByPath>d__.<>4__this = this;
			<SetExtendToggleTextureTransitionGroupByPath>d__.path = path;
			<SetExtendToggleTextureTransitionGroupByPath>d__.uiExtendToggleTextureTransition = uiExtendToggleTextureTransition;
			<SetExtendToggleTextureTransitionGroupByPath>d__.states = states;
			<SetExtendToggleTextureTransitionGroupByPath>d__.<>1__state = -1;
			<SetExtendToggleTextureTransitionGroupByPath>d__.<>t__builder.Start<UiPanelBase.<SetExtendToggleTextureTransitionGroupByPath>d__159>(ref <SetExtendToggleTextureTransitionGroupByPath>d__);
			return <SetExtendToggleTextureTransitionGroupByPath>d__.<>t__builder.Task;
		}

		// Token: 0x06022C26 RID: 142374 RVA: 0x009E1C70 File Offset: 0x009DFE70
		protected UniTask SetTextureCustomMaterialAsync(string materialPath, [Nullable(2)] UUITexture uiTexture)
		{
			UiPanelBase.<SetTextureCustomMaterialAsync>d__160 <SetTextureCustomMaterialAsync>d__;
			<SetTextureCustomMaterialAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetTextureCustomMaterialAsync>d__.<>4__this = this;
			<SetTextureCustomMaterialAsync>d__.materialPath = materialPath;
			<SetTextureCustomMaterialAsync>d__.uiTexture = uiTexture;
			<SetTextureCustomMaterialAsync>d__.<>1__state = -1;
			<SetTextureCustomMaterialAsync>d__.<>t__builder.Start<UiPanelBase.<SetTextureCustomMaterialAsync>d__160>(ref <SetTextureCustomMaterialAsync>d__);
			return <SetTextureCustomMaterialAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06022C27 RID: 142375 RVA: 0x009E1CC4 File Offset: 0x009DFEC4
		protected UniTask SetExtendToggleSpriteTransitionByPath(string path, UUIExtendToggleSpriteTransition uiExtendToggleSpriteTransition, EToggleTransitionState? state = null)
		{
			UiPanelBase.<SetExtendToggleSpriteTransitionByPath>d__161 <SetExtendToggleSpriteTransitionByPath>d__;
			<SetExtendToggleSpriteTransitionByPath>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetExtendToggleSpriteTransitionByPath>d__.<>4__this = this;
			<SetExtendToggleSpriteTransitionByPath>d__.path = path;
			<SetExtendToggleSpriteTransitionByPath>d__.uiExtendToggleSpriteTransition = uiExtendToggleSpriteTransition;
			<SetExtendToggleSpriteTransitionByPath>d__.state = state;
			<SetExtendToggleSpriteTransitionByPath>d__.<>1__state = -1;
			<SetExtendToggleSpriteTransitionByPath>d__.<>t__builder.Start<UiPanelBase.<SetExtendToggleSpriteTransitionByPath>d__161>(ref <SetExtendToggleSpriteTransitionByPath>d__);
			return <SetExtendToggleSpriteTransitionByPath>d__.<>t__builder.Task;
		}

		// Token: 0x06022C28 RID: 142376 RVA: 0x009E1D20 File Offset: 0x009DFF20
		protected UniTask SetExtendToggleSpriteTransitionByStateList(string path, UUIExtendToggleSpriteTransition uiExtendToggleSpriteTransition, EToggleTransitionState[] states)
		{
			UiPanelBase.<SetExtendToggleSpriteTransitionByStateList>d__162 <SetExtendToggleSpriteTransitionByStateList>d__;
			<SetExtendToggleSpriteTransitionByStateList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetExtendToggleSpriteTransitionByStateList>d__.<>4__this = this;
			<SetExtendToggleSpriteTransitionByStateList>d__.path = path;
			<SetExtendToggleSpriteTransitionByStateList>d__.uiExtendToggleSpriteTransition = uiExtendToggleSpriteTransition;
			<SetExtendToggleSpriteTransitionByStateList>d__.states = states;
			<SetExtendToggleSpriteTransitionByStateList>d__.<>1__state = -1;
			<SetExtendToggleSpriteTransitionByStateList>d__.<>t__builder.Start<UiPanelBase.<SetExtendToggleSpriteTransitionByStateList>d__162>(ref <SetExtendToggleSpriteTransitionByStateList>d__);
			return <SetExtendToggleSpriteTransitionByStateList>d__.<>t__builder.Task;
		}

		// Token: 0x06022C29 RID: 142377 RVA: 0x009E1D7C File Offset: 0x009DFF7C
		protected UniTask SetTextureAsync(string path, UUITexture uiTexture)
		{
			UiPanelBase.<SetTextureAsync>d__163 <SetTextureAsync>d__;
			<SetTextureAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetTextureAsync>d__.<>4__this = this;
			<SetTextureAsync>d__.path = path;
			<SetTextureAsync>d__.uiTexture = uiTexture;
			<SetTextureAsync>d__.<>1__state = -1;
			<SetTextureAsync>d__.<>t__builder.Start<UiPanelBase.<SetTextureAsync>d__163>(ref <SetTextureAsync>d__);
			return <SetTextureAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06022C2A RID: 142378 RVA: 0x009E1DD0 File Offset: 0x009DFFD0
		protected UniTask SetSpriteAsync(string path, UUISprite uiSprite, bool setSize)
		{
			UiPanelBase.<SetSpriteAsync>d__164 <SetSpriteAsync>d__;
			<SetSpriteAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetSpriteAsync>d__.<>4__this = this;
			<SetSpriteAsync>d__.path = path;
			<SetSpriteAsync>d__.uiSprite = uiSprite;
			<SetSpriteAsync>d__.setSize = setSize;
			<SetSpriteAsync>d__.<>1__state = -1;
			<SetSpriteAsync>d__.<>t__builder.Start<UiPanelBase.<SetSpriteAsync>d__164>(ref <SetSpriteAsync>d__);
			return <SetSpriteAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06022C2B RID: 142379 RVA: 0x009E1E2C File Offset: 0x009E002C
		[NullableContext(2)]
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

		// Token: 0x06022C2C RID: 142380 RVA: 0x009E1E80 File Offset: 0x009E0080
		protected void SetItemIcon(UUITexture texture, int itemId, EUiViewName? syncLoadViewName = null, [Nullable(2)] Action<bool> action = null)
		{
			if (syncLoadViewName != null)
			{
				this._uiImageSettingModule.SetItemIconSync(texture, itemId, syncLoadViewName.Value, action);
				return;
			}
			this._uiImageSettingModule.SetItemIconAsync(texture, itemId, action);
		}

		// Token: 0x06022C2D RID: 142381 RVA: 0x009E1EB4 File Offset: 0x009E00B4
		protected UniTask SetItemIconAsync(UUITexture texture, int itemId)
		{
			UiPanelBase.<SetItemIconAsync>d__167 <SetItemIconAsync>d__;
			<SetItemIconAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetItemIconAsync>d__.<>4__this = this;
			<SetItemIconAsync>d__.texture = texture;
			<SetItemIconAsync>d__.itemId = itemId;
			<SetItemIconAsync>d__.<>1__state = -1;
			<SetItemIconAsync>d__.<>t__builder.Start<UiPanelBase.<SetItemIconAsync>d__167>(ref <SetItemIconAsync>d__);
			return <SetItemIconAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06022C2E RID: 142382 RVA: 0x009E1F08 File Offset: 0x009E0108
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

		// Token: 0x06022C2F RID: 142383 RVA: 0x009E1F4E File Offset: 0x009E014E
		protected void SetItemQualityIcon(UUISprite sprite, int itemId, EUiViewName? syncLoadViewName = null, CommonDefine.EQualityIconType type = CommonDefine.EQualityIconType.BackgroundSprite, [Nullable(2)] Action<bool> action = null)
		{
			if (syncLoadViewName != null)
			{
				this._uiImageSettingModule.SetItemQualityIconSync(sprite, itemId, syncLoadViewName.Value, type, action);
				return;
			}
			this._uiImageSettingModule.SetItemQualityIconAsync(sprite, itemId, type, action);
		}

		// Token: 0x06022C30 RID: 142384 RVA: 0x009E1F83 File Offset: 0x009E0183
		protected void SetRoleIcon(string path, UUITexture texture, int roleId, EUiViewName? syncLoadViewName = null, [Nullable(2)] Action<bool> callback = null)
		{
			if (syncLoadViewName != null)
			{
				this._uiImageSettingModule.SetRoleIconSync(path, texture, roleId, syncLoadViewName.Value, callback);
				return;
			}
			this._uiImageSettingModule.SetRoleIconAsync(path, texture, roleId, callback);
		}

		// Token: 0x06022C31 RID: 142385 RVA: 0x009E1FB6 File Offset: 0x009E01B6
		protected void SetRoleSkinIcon(string path, UUITexture texture, int skinId, EUiViewName? syncLoadViewName = null, [Nullable(2)] Action<bool> callback = null)
		{
			if (syncLoadViewName != null)
			{
				this._uiImageSettingModule.SetRoleSkinIconSync(path, texture, skinId, syncLoadViewName.Value, callback);
				return;
			}
			this._uiImageSettingModule.SetRoleSkinIconAsync(path, texture, skinId, callback);
		}

		// Token: 0x06022C32 RID: 142386 RVA: 0x009E1FEC File Offset: 0x009E01EC
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

		// Token: 0x06022C33 RID: 142387 RVA: 0x009E203F File Offset: 0x009E023F
		protected void SetElementIcon(string path, UUITexture texture, int elementId, EUiViewName? syncLoadViewName = null)
		{
			if (syncLoadViewName != null)
			{
				this._uiImageSettingModule.SetElementIconSync(path, texture, elementId, syncLoadViewName.Value);
				return;
			}
			this._uiImageSettingModule.SetElementIcon(path, texture, elementId);
		}

		// Token: 0x06022C34 RID: 142388 RVA: 0x009E206E File Offset: 0x009E026E
		protected void SetMonsterIcon(string path, UUITexture texture, int monsterInfoId, EUiViewName? syncLoadViewName = null)
		{
			if (syncLoadViewName != null)
			{
				this._uiImageSettingModule.SetMonsterIconSync(path, texture, monsterInfoId, syncLoadViewName.Value);
				return;
			}
			this._uiImageSettingModule.SetMonsterIconAsync(path, texture, monsterInfoId);
		}

		// Token: 0x06022C35 RID: 142389 RVA: 0x009E209D File Offset: 0x009E029D
		protected void SetDungeonEntranceIconSync(string path, UUITexture texture, int entranceId, EUiViewName? syncLoadViewName = null)
		{
			if (syncLoadViewName != null)
			{
				this._uiImageSettingModule.SetDungeonEntranceIconSync(path, texture, entranceId, syncLoadViewName.Value);
				return;
			}
			this._uiImageSettingModule.SetDungeonEntranceIconAsync(path, texture, entranceId);
		}

		// Token: 0x06022C36 RID: 142390 RVA: 0x009E20CC File Offset: 0x009E02CC
		protected void SetNiagaraTextureByPath(string iconPath, UUINiagara niagara, string emitterName, string variableName, EUiViewName? syncLoadViewName = null, [Nullable(2)] Action<bool> callback = null)
		{
			if (syncLoadViewName != null)
			{
				this._uiImageSettingModule.SetNiagaraTextureSync(iconPath, niagara, emitterName, variableName, syncLoadViewName.Value, callback);
				return;
			}
			this._uiImageSettingModule.SetNiagaraTextureAsync(iconPath, niagara, emitterName, variableName, callback);
		}

		// Token: 0x06022C37 RID: 142391 RVA: 0x009E2103 File Offset: 0x009E0303
		protected void SetNiagaraSystemByPath(string niagaraPath, UUINiagara niagara, [Nullable(2)] Action<bool> callback = null)
		{
			this._uiNiagaraSettingModule.SetNiagaraByPath(niagaraPath, niagara, callback);
		}

		// Token: 0x06022C38 RID: 142392 RVA: 0x009E2114 File Offset: 0x009E0314
		protected UniTask SetNiagaraSystemByPathAsync(string niagaraPath, UUINiagara niagara)
		{
			UiPanelBase.<SetNiagaraSystemByPathAsync>d__178 <SetNiagaraSystemByPathAsync>d__;
			<SetNiagaraSystemByPathAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetNiagaraSystemByPathAsync>d__.<>4__this = this;
			<SetNiagaraSystemByPathAsync>d__.niagaraPath = niagaraPath;
			<SetNiagaraSystemByPathAsync>d__.niagara = niagara;
			<SetNiagaraSystemByPathAsync>d__.<>1__state = -1;
			<SetNiagaraSystemByPathAsync>d__.<>t__builder.Start<UiPanelBase.<SetNiagaraSystemByPathAsync>d__178>(ref <SetNiagaraSystemByPathAsync>d__);
			return <SetNiagaraSystemByPathAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06022C39 RID: 142393 RVA: 0x009E2168 File Offset: 0x009E0368
		protected UniTask SetSpineAssetByPath(string atlasPath, string skeletonPath, USpineSkeletonAnimationComponent spine)
		{
			UiPanelBase.<SetSpineAssetByPath>d__179 <SetSpineAssetByPath>d__;
			<SetSpineAssetByPath>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetSpineAssetByPath>d__.<>4__this = this;
			<SetSpineAssetByPath>d__.atlasPath = atlasPath;
			<SetSpineAssetByPath>d__.skeletonPath = skeletonPath;
			<SetSpineAssetByPath>d__.spine = spine;
			<SetSpineAssetByPath>d__.<>1__state = -1;
			<SetSpineAssetByPath>d__.<>t__builder.Start<UiPanelBase.<SetSpineAssetByPath>d__179>(ref <SetSpineAssetByPath>d__);
			return <SetSpineAssetByPath>d__.<>t__builder.Task;
		}

		// Token: 0x06022C3A RID: 142394 RVA: 0x009E21C3 File Offset: 0x009E03C3
		private void ClearUiResourceLoadModule()
		{
			this._uiImageSettingModule.Clear();
			this._uiNiagaraSettingModule.Clear();
			this._uiSpineLoadModule.Clear();
		}

		// Token: 0x06022C3B RID: 142395 RVA: 0x009E21E8 File Offset: 0x009E03E8
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		public UniTask<AActor> LoadPrefabAsync(string path, [Nullable(2)] UUIItem parent = null)
		{
			UiPanelBase.<LoadPrefabAsync>d__182 <LoadPrefabAsync>d__;
			<LoadPrefabAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<AActor>.Create();
			<LoadPrefabAsync>d__.<>4__this = this;
			<LoadPrefabAsync>d__.path = path;
			<LoadPrefabAsync>d__.parent = parent;
			<LoadPrefabAsync>d__.<>1__state = -1;
			<LoadPrefabAsync>d__.<>t__builder.Start<UiPanelBase.<LoadPrefabAsync>d__182>(ref <LoadPrefabAsync>d__);
			return <LoadPrefabAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06022C3C RID: 142396 RVA: 0x009E223B File Offset: 0x009E043B
		protected void ClearUiPrefabLoadModule()
		{
			this._uiPrefabLoadModule.Clear();
		}

		// Token: 0x06022C3D RID: 142397 RVA: 0x009E2248 File Offset: 0x009E0448
		protected UniTask RunAsyncTask(UiAsyncTask task)
		{
			UiPanelBase.<RunAsyncTask>d__185 <RunAsyncTask>d__;
			<RunAsyncTask>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RunAsyncTask>d__.<>4__this = this;
			<RunAsyncTask>d__.task = task;
			<RunAsyncTask>d__.<>1__state = -1;
			<RunAsyncTask>d__.<>t__builder.Start<UiPanelBase.<RunAsyncTask>d__185>(ref <RunAsyncTask>d__);
			return <RunAsyncTask>d__.<>t__builder.Task;
		}

		// Token: 0x06022C3E RID: 142398 RVA: 0x009E2293 File Offset: 0x009E0493
		protected void CancelAllAsyncTask()
		{
			UiAsyncTaskManager taskManager = this.TaskManager;
			if (taskManager == null)
			{
				return;
			}
			taskManager.CancelAllTask();
		}

		// Token: 0x06022C3F RID: 142399 RVA: 0x009E22A5 File Offset: 0x009E04A5
		protected bool ApplyCommandSwitcher(string commandName, int value, int? restoreValue = null, [Nullable(new byte[]
		{
			2,
			1
		})] Action<string> executeCommand = null)
		{
			return this.ApplyCommandSwitcher(new UiIntCommandSwitcher(commandName, value, restoreValue, executeCommand));
		}

		// Token: 0x06022C40 RID: 142400 RVA: 0x009E22B7 File Offset: 0x009E04B7
		protected bool ApplyCommandSwitcher(string commandName, float value, float? restoreValue = null, [Nullable(new byte[]
		{
			2,
			1
		})] Action<string> executeCommand = null)
		{
			return this.ApplyCommandSwitcher(new UiFloatCommandSwitcher(commandName, value, restoreValue, executeCommand));
		}

		// Token: 0x06022C41 RID: 142401 RVA: 0x009E22C9 File Offset: 0x009E04C9
		protected bool ApplyCommandSwitcher(string commandName, bool value, bool? restoreValue = null, [Nullable(new byte[]
		{
			2,
			1
		})] Action<string> executeCommand = null)
		{
			return this.ApplyCommandSwitcher(new UiBoolCommandSwitcher(commandName, value, restoreValue, executeCommand));
		}

		// Token: 0x06022C42 RID: 142402 RVA: 0x009E22DB File Offset: 0x009E04DB
		protected bool ApplySeqCommandSwitcher(string commandName, int value, int? restoreValue = null)
		{
			Action<string> executeCommand;
			if ((executeCommand = UiPanelBase.<>O.<0>__SimpleExecuteCommand) == null)
			{
				executeCommand = (UiPanelBase.<>O.<0>__SimpleExecuteCommand = new Action<string>(UKuroSequencePerformanceManager.SimpleExecuteCommand));
			}
			return this.ApplySeqCommandSwitcher(new UiIntCommandSwitcher(commandName, value, restoreValue, executeCommand));
		}

		// Token: 0x06022C43 RID: 142403 RVA: 0x009E2306 File Offset: 0x009E0506
		protected bool ApplySeqCommandSwitcher(string commandName, float value, float? restoreValue = null)
		{
			Action<string> executeCommand;
			if ((executeCommand = UiPanelBase.<>O.<0>__SimpleExecuteCommand) == null)
			{
				executeCommand = (UiPanelBase.<>O.<0>__SimpleExecuteCommand = new Action<string>(UKuroSequencePerformanceManager.SimpleExecuteCommand));
			}
			return this.ApplySeqCommandSwitcher(new UiFloatCommandSwitcher(commandName, value, restoreValue, executeCommand));
		}

		// Token: 0x06022C44 RID: 142404 RVA: 0x009E2331 File Offset: 0x009E0531
		protected bool ApplySeqCommandSwitcher(string commandName, bool value, bool? restoreValue = null)
		{
			Action<string> executeCommand;
			if ((executeCommand = UiPanelBase.<>O.<0>__SimpleExecuteCommand) == null)
			{
				executeCommand = (UiPanelBase.<>O.<0>__SimpleExecuteCommand = new Action<string>(UKuroSequencePerformanceManager.SimpleExecuteCommand));
			}
			return this.ApplySeqCommandSwitcher(new UiBoolCommandSwitcher(commandName, value, restoreValue, executeCommand));
		}

		// Token: 0x06022C45 RID: 142405 RVA: 0x009E235C File Offset: 0x009E055C
		private bool ApplySeqCommandSwitcher(UiCommandSwitcher switcher)
		{
			return UKismetSystemLibrary.GetConsoleVariableIntValue("r.Kuro.AllowSequencePerformance") == 1 && this.ApplyCommandSwitcher(switcher);
		}

		// Token: 0x06022C46 RID: 142406 RVA: 0x009E2374 File Offset: 0x009E0574
		private bool ApplyCommandSwitcher(UiCommandSwitcher switcher)
		{
			if (this.WaitToDestroy || base.IsDestroyOrDestroying)
			{
				return false;
			}
			UiCommandSwitcher uiCommandSwitcher;
			if (this.CommandSwitchers == null || !this.CommandSwitchers.TryGetValue(switcher.CommandName, out uiCommandSwitcher))
			{
				if (this.CommandSwitchers == null)
				{
					this.CommandSwitchers = new Dictionary<string, UiCommandSwitcher>(StringComparer.OrdinalIgnoreCase);
				}
				this.CommandSwitchers.Add(switcher.CommandName, switcher);
				return this.ApplySwitcher(switcher);
			}
			if (!uiCommandSwitcher.IsSameRequest(switcher))
			{
				throw new InvalidOperationException("Command " + switcher.CommandName + " is already applied with a different configuration. Restore it before applying a new configuration.");
			}
			uiCommandSwitcher.Reapply();
			return true;
		}

		// Token: 0x06022C47 RID: 142407 RVA: 0x009E2410 File Offset: 0x009E0610
		protected bool RestoreCommandSwitcher(string commandName)
		{
			UiCommandSwitcher switcher;
			return this.CommandSwitchers != null && this.CommandSwitchers.TryGetValue(commandName, out switcher) && this.RestoreSwitcher(switcher);
		}

		// Token: 0x06022C48 RID: 142408 RVA: 0x009E2440 File Offset: 0x009E0640
		protected bool ApplySwitcher(UiSwitcherBase switcher)
		{
			if (this.WaitToDestroy || base.IsDestroyOrDestroying || switcher.IsApplied)
			{
				return false;
			}
			if (this.Switchers == null)
			{
				this.Switchers = new List<UiSwitcherBase>();
			}
			this.Switchers.Add(switcher);
			return switcher.Apply(this);
		}

		// Token: 0x06022C49 RID: 142409 RVA: 0x009E2490 File Offset: 0x009E0690
		protected bool RestoreSwitcher(UiSwitcherBase switcher)
		{
			if (this.Switchers == null || !this.Switchers.Contains(switcher))
			{
				return false;
			}
			if (!switcher.Restore(this))
			{
				return false;
			}
			this.Switchers.Remove(switcher);
			UiCommandSwitcher uiCommandSwitcher = switcher as UiCommandSwitcher;
			UiCommandSwitcher uiCommandSwitcher2;
			if (uiCommandSwitcher != null && this.CommandSwitchers != null && this.CommandSwitchers.TryGetValue(uiCommandSwitcher.CommandName, out uiCommandSwitcher2) && uiCommandSwitcher2 == switcher)
			{
				this.CommandSwitchers.Remove(uiCommandSwitcher.CommandName);
			}
			return true;
		}

		// Token: 0x06022C4A RID: 142410 RVA: 0x009E250C File Offset: 0x009E070C
		protected unsafe void RestoreAllSwitchers()
		{
			if (this.Switchers == null || this.Switchers.Count == 0)
			{
				return;
			}
			UiSwitcherBase[] array = this.Switchers.ToArray();
			for (int i = array.Length - 1; i >= 0; i--)
			{
				UiSwitcherBase uiSwitcherBase = array[i];
				try
				{
					this.RestoreSwitcher(uiSwitcherBase);
				}
				catch (Exception ex)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.UiCore;
					ELogAuthor author = ELogAuthor.LZK;
					string message = "[UiSwitcher] 恢复失败";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("PanelName", base.GetType().Name);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("SwitcherName", uiSwitcherBase.Name);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("error", ex.ToString());
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				}
			}
		}

		// Token: 0x06022C4B RID: 142411 RVA: 0x009E25F8 File Offset: 0x009E07F8
		public void AddUiBehavior(IUiBehavior behavior)
		{
			this.AddUiBehaviorProxy(new UiBehaviorBaseProxy(behavior));
		}

		// Token: 0x06022C4C RID: 142412 RVA: 0x009E2606 File Offset: 0x009E0806
		public void AddUiBehaviorProxy(UiBehaviorBaseProxy proxy)
		{
			this.UiBehaviorProxies.Add(proxy);
		}

		// Token: 0x06022C4D RID: 142413 RVA: 0x009E2614 File Offset: 0x009E0814
		public void AddChild(UiPanelBase child)
		{
			this.Children.Add(child);
			child.Parent = this;
		}

		// Token: 0x06022C4E RID: 142414 RVA: 0x009E262C File Offset: 0x009E082C
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

		// Token: 0x06022C4F RID: 142415 RVA: 0x009E2674 File Offset: 0x009E0874
		[NullableContext(2)]
		public UiPanelBase GetLastChild()
		{
			int count = this.Children.Count;
			if (count == 0)
			{
				return null;
			}
			return this.Children[count - 1];
		}

		// Token: 0x06022C50 RID: 142416 RVA: 0x009E26A0 File Offset: 0x009E08A0
		public void Register()
		{
		}

		// Token: 0x06022C51 RID: 142417 RVA: 0x009E26A2 File Offset: 0x009E08A2
		protected void Begin()
		{
		}

		// Token: 0x06022C52 RID: 142418 RVA: 0x009E26A4 File Offset: 0x009E08A4
		[NullableContext(2)]
		protected virtual void OnBegin(object parameters = null)
		{
		}

		// Token: 0x06022C53 RID: 142419 RVA: 0x009E26A6 File Offset: 0x009E08A6
		protected virtual void OnChangeComponentActiveState(bool visibility)
		{
		}

		// Token: 0x06022C54 RID: 142420 RVA: 0x009E26A8 File Offset: 0x009E08A8
		protected virtual void OnRegister()
		{
		}

		// Token: 0x06022C55 RID: 142421 RVA: 0x009E26AA File Offset: 0x009E08AA
		protected virtual void OnCreate()
		{
		}

		// Token: 0x06022C56 RID: 142422 RVA: 0x009E26AC File Offset: 0x009E08AC
		protected virtual void OnShow()
		{
		}

		// Token: 0x06022C57 RID: 142423 RVA: 0x009E26AE File Offset: 0x009E08AE
		protected virtual void OnHide()
		{
		}

		// Token: 0x06022C58 RID: 142424 RVA: 0x009E26B0 File Offset: 0x009E08B0
		protected virtual void OnPrepareHide(bool inClose = false)
		{
		}

		// Token: 0x06022C59 RID: 142425 RVA: 0x009E26B2 File Offset: 0x009E08B2
		protected virtual void OnEnd()
		{
		}

		// Token: 0x06022C5A RID: 142426 RVA: 0x009E26B4 File Offset: 0x009E08B4
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x06022C5B RID: 142427 RVA: 0x009E26B6 File Offset: 0x009E08B6
		protected virtual void OnStartSequenceFinish()
		{
		}

		// Token: 0x06022C5C RID: 142428 RVA: 0x009E26B8 File Offset: 0x009E08B8
		protected virtual void OnSequenceEvent(string sequenceName, string eventName)
		{
		}

		// Token: 0x06022C5D RID: 142429 RVA: 0x009E26BA File Offset: 0x009E08BA
		protected virtual bool OnPlayCloseSequence()
		{
			return false;
		}

		// Token: 0x06022C5E RID: 142430 RVA: 0x009E26BD File Offset: 0x009E08BD
		protected virtual void OnStackShow()
		{
		}

		// Token: 0x06022C5F RID: 142431 RVA: 0x009E26BF File Offset: 0x009E08BF
		protected virtual void OnShowSequenceFinish()
		{
		}

		// Token: 0x06022C60 RID: 142432 RVA: 0x009E26C1 File Offset: 0x009E08C1
		protected virtual void OnActiveSequenceFinish()
		{
		}

		// Token: 0x06022C61 RID: 142433 RVA: 0x009E26C3 File Offset: 0x009E08C3
		protected virtual bool OnCheckLoadSceneCondition()
		{
			return true;
		}

		// Token: 0x06022C62 RID: 142434 RVA: 0x009E26C6 File Offset: 0x009E08C6
		protected virtual bool OnCheckReleaseSceneCondition()
		{
			return true;
		}

		// Token: 0x06022C63 RID: 142435 RVA: 0x009E26C9 File Offset: 0x009E08C9
		public void Start()
		{
		}

		// Token: 0x06022C64 RID: 142436 RVA: 0x009E26CB File Offset: 0x009E08CB
		public void End()
		{
		}

		// Token: 0x06022C65 RID: 142437 RVA: 0x009E26CD File Offset: 0x009E08CD
		protected void InitParam()
		{
		}

		// Token: 0x06022C66 RID: 142438 RVA: 0x009E26CF File Offset: 0x009E08CF
		protected void InitComponentsData()
		{
		}

		// Token: 0x06022C67 RID: 142439 RVA: 0x009E26D1 File Offset: 0x009E08D1
		protected void OnClearComponentsData()
		{
		}

		// Token: 0x06022C68 RID: 142440 RVA: 0x009E26D3 File Offset: 0x009E08D3
		public void Create()
		{
		}

		// Token: 0x06022C69 RID: 142441 RVA: 0x009E26D5 File Offset: 0x009E08D5
		public bool ClearComponentsData()
		{
			base.Destroy(null);
			return true;
		}

		// Token: 0x06022C6A RID: 142442 RVA: 0x009E26E0 File Offset: 0x009E08E0
		public UniTask ConstructorAsync(string resourceId, UUIItem parentItem, bool usePool = false)
		{
			UiPanelBase.<ConstructorAsync>d__232 <ConstructorAsync>d__;
			<ConstructorAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ConstructorAsync>d__.<>4__this = this;
			<ConstructorAsync>d__.resourceId = resourceId;
			<ConstructorAsync>d__.parentItem = parentItem;
			<ConstructorAsync>d__.usePool = usePool;
			<ConstructorAsync>d__.<>1__state = -1;
			<ConstructorAsync>d__.<>t__builder.Start<UiPanelBase.<ConstructorAsync>d__232>(ref <ConstructorAsync>d__);
			return <ConstructorAsync>d__.<>t__builder.Task;
		}

		// Token: 0x1700489F RID: 18591
		// (get) Token: 0x06022C6B RID: 142443 RVA: 0x009E273B File Offset: 0x009E093B
		// (set) Token: 0x06022C6C RID: 142444 RVA: 0x009E2743 File Offset: 0x009E0943
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

		// Token: 0x06022C6D RID: 142445 RVA: 0x009E274C File Offset: 0x009E094C
		public void SetRootActor(AActor actor, bool isBegin = true)
		{
			if (isBegin)
			{
				this.CreateThenShowByActor(actor, null);
				return;
			}
			this.CreateByActor(actor, null);
		}

		// Token: 0x06022C6E RID: 142446 RVA: 0x009E2762 File Offset: 0x009E0962
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

		// Token: 0x06022C6F RID: 142447 RVA: 0x009E2782 File Offset: 0x009E0982
		public void CreateByActor(AActor actor, [Nullable(2)] object parameters = null)
		{
			if (parameters != null)
			{
				this.OpenParam = parameters;
			}
			this.SetActor(actor);
			base.StartCompatible();
		}

		// Token: 0x040133BB RID: 78779
		[Nullable(2)]
		protected UUIItem RootItem;

		// Token: 0x040133BC RID: 78780
		[Nullable(2)]
		protected AUIBaseActor RootActor;

		// Token: 0x040133BD RID: 78781
		[Nullable(2)]
		private AUIBaseActor _originalActor;

		// Token: 0x040133BE RID: 78782
		[Nullable(2)]
		private UUIItem _originalItem;

		// Token: 0x040133BF RID: 78783
		[Nullable(2)]
		protected UUIItem ParentUiItem;

		// Token: 0x040133C0 RID: 78784
		protected bool UsePool;

		// Token: 0x040133C1 RID: 78785
		protected string MemoryTag = "js_undefined";

		// Token: 0x040133C3 RID: 78787
		private bool _isPermanent;

		// Token: 0x040133C4 RID: 78788
		[Nullable(2)]
		public object OpenParam;

		// Token: 0x040133C5 RID: 78789
		private string _actorPath = "";

		// Token: 0x040133C6 RID: 78790
		private readonly List<UiBehaviorBaseProxy> UiBehaviorProxies = new List<UiBehaviorBaseProxy>();

		// Token: 0x040133C7 RID: 78791
		private readonly List<UiPanelBase> Children = new List<UiPanelBase>();

		// Token: 0x040133C8 RID: 78792
		[Nullable(2)]
		public UiPanelBase Parent;

		// Token: 0x040133C9 RID: 78793
		private readonly Dictionary<int, Tuple<Type, UActorComponent>> BaseComponentMap = new Dictionary<int, Tuple<Type, UActorComponent>>();

		// Token: 0x040133CA RID: 78794
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
				typeof(UUIRenderableMask),
				new Func<UClassStackOnlyPtr>(UUIRenderableMask.StaticClass)
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
			},
			{
				typeof(UUIEffectTextAnimation),
				new Func<UClassStackOnlyPtr>(UUIEffectTextAnimation.StaticClass)
			},
			{
				typeof(ULGUIPlayTweenComponent),
				new Func<UClassStackOnlyPtr>(ULGUIPlayTweenComponent.StaticClass)
			}
		};

		// Token: 0x040133CB RID: 78795
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		protected List<ValueTuple<int, Type>> ComponentRegisterInfos = new List<ValueTuple<int, Type>>();

		// Token: 0x040133CC RID: 78796
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		protected List<ValueTuple<int, Delegate>> BtnBindInfo = new List<ValueTuple<int, Delegate>>();

		// Token: 0x040133CD RID: 78797
		[Nullable(2)]
		private UGuideHookRegistry _guideRegistry;

		// Token: 0x040133CE RID: 78798
		[Nullable(2)]
		protected UiPoolActor UiPoolActorNew;

		// Token: 0x040133CF RID: 78799
		private readonly UiImageSettingModule _uiImageSettingModule = new UiImageSettingModule();

		// Token: 0x040133D0 RID: 78800
		private readonly UiNiagaraSettingModule _uiNiagaraSettingModule = new UiNiagaraSettingModule();

		// Token: 0x040133D1 RID: 78801
		private readonly UiSpineLoadModule _uiSpineLoadModule = new UiSpineLoadModule();

		// Token: 0x040133D2 RID: 78802
		private readonly UiPrefabLoadModule _uiPrefabLoadModule = new UiPrefabLoadModule();

		// Token: 0x040133D3 RID: 78803
		[Nullable(2)]
		protected UiAsyncTaskManager TaskManager;

		// Token: 0x040133D4 RID: 78804
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<UiSwitcherBase> Switchers;

		// Token: 0x040133D5 RID: 78805
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private Dictionary<string, UiCommandSwitcher> CommandSwitchers;

		// Token: 0x0200921F RID: 37407
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402DBAF RID: 187311
			[Nullable(new byte[]
			{
				0,
				1
			})]
			public static Action<string> <0>__SimpleExecuteCommand;
		}
	}
}
