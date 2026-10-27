using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Util
{
	// Token: 0x020048C9 RID: 18633
	[NullableContext(1)]
	[Nullable(0)]
	public class GenericLayout<TProxy, [Nullable(2)] TData> : IGridPreserver where TProxy : class, IGridProxy<TData>
	{
		// Token: 0x06030B40 RID: 199488 RVA: 0x00B4F218 File Offset: 0x00B4D418
		public GenericLayout(UUILayoutBase layout, Func<TProxy> gridProxyCreateFunction, [Nullable(2)] AUIBaseActor gridActor = null, bool isRefreshAsync = false, bool isGridShowWhenCreate = true)
		{
			this.IsRefreshAsync = isRefreshAsync;
			this.IsGridShowWhenCreate = isGridShowWhenCreate;
			this.Layout = layout;
			AUIBaseActor auibaseActor = this.Layout.GetOwner() as AUIBaseActor;
			if (auibaseActor != null)
			{
				auibaseActor.OnPreDestroyed.Add(new Action<AActor>(this.OnDestroy));
			}
			if (gridActor == null)
			{
				UUIItem attachUIChild = layout.RootUIComp.Get().GetAttachUIChild(0);
				this.TemplateGridActor = (((attachUIChild != null) ? attachUIChild.GetOwner() : null) as AUIBaseActor);
			}
			else
			{
				this.TemplateGridActor = gridActor;
			}
			if (this.TemplateGridActor == null)
			{
				return;
			}
			this.TemplateGridActor.GetUIItem().SetUIActive(false);
			this.Delegate = new ScrollViewDelegate<TProxy, TData>(gridProxyCreateFunction);
			this.GridsController = new InTurnGridAppearAnimation(this);
			this.GridsController.RegisterAnimController();
		}

		// Token: 0x17007985 RID: 31109
		// (get) Token: 0x06030B41 RID: 199489 RVA: 0x00B4F321 File Offset: 0x00B4D521
		public bool IsLock
		{
			get
			{
				return this.Operating;
			}
		}

		// Token: 0x06030B42 RID: 199490 RVA: 0x00B4F329 File Offset: 0x00B4D529
		private void Lock()
		{
			this.Operating = true;
		}

		// Token: 0x06030B43 RID: 199491 RVA: 0x00B4F334 File Offset: 0x00B4D534
		private void Unlock()
		{
			this.Operating = false;
			if (this.OperationQueue.Size > 0)
			{
				GenericLayout<TProxy, TData>.OperationParam operationParam = this.OperationQueue.Pop();
				this.RefreshByData(operationParam.Data, operationParam.CallBack, operationParam.PlayGridAnim);
			}
		}

		// Token: 0x06030B44 RID: 199492 RVA: 0x00B4F37C File Offset: 0x00B4D57C
		[NullableContext(2)]
		public UUIItem GetRootUiItem()
		{
			UUILayoutBase layout = this.Layout;
			TWeakObjectPtr<UUIItem>? tweakObjectPtr = (layout != null) ? new TWeakObjectPtr<UUIItem>?(layout.RootUIComp) : null;
			if (tweakObjectPtr == null)
			{
				return null;
			}
			return tweakObjectPtr.GetValueOrDefault();
		}

		// Token: 0x06030B45 RID: 199493 RVA: 0x00B4F3C0 File Offset: 0x00B4D5C0
		[NullableContext(2)]
		private UUIItem CreateGrid()
		{
			return LguiUtil.Instance.CopyItem(this.TemplateGridActor.GetUIItem(), this.GetRootUiItem());
		}

		// Token: 0x06030B46 RID: 199494 RVA: 0x00B4F3E0 File Offset: 0x00B4D5E0
		[NullableContext(2)]
		public object GetKey(int gridIndex)
		{
			if (gridIndex < 0 || gridIndex >= this.ProxyDisplayList.Count)
			{
				return null;
			}
			TProxy tproxy = this.ProxyDisplayList[gridIndex];
			IReadOnlyList<TData> datas = this.Delegate.GetDatas();
			if (gridIndex >= datas.Count)
			{
				return null;
			}
			return tproxy.GetKey(datas[gridIndex], gridIndex);
		}

		// Token: 0x06030B47 RID: 199495 RVA: 0x00B4F438 File Offset: 0x00B4D638
		public int? GetGridIndexByKey<[Nullable(2)] T>(T key)
		{
			TProxy tproxy;
			if (this.ProxyMap.TryGetValue(key, out tproxy))
			{
				return new int?(tproxy.GridIndex);
			}
			return null;
		}

		// Token: 0x06030B48 RID: 199496 RVA: 0x00B4F474 File Offset: 0x00B4D674
		public void ClearChildren()
		{
			foreach (UUIItem uuiitem in this.GridItemList)
			{
				AActor owner = uuiitem.GetOwner();
				if (owner != null && owner.IsValid())
				{
					ULGUIBPLibrary.DestroyActorWithHierarchy(owner, true);
				}
			}
			this.GridItemList.Clear();
			this.GridDisplayItemList.Clear();
			this.ProxyDisplayList.Clear();
			this.ProxyMap.Clear();
		}

		// Token: 0x06030B49 RID: 199497 RVA: 0x00B4F504 File Offset: 0x00B4D704
		public UniTask LoadGrid(int length, bool bShow = true)
		{
			GenericLayout<TProxy, TData>.<LoadGrid>d__24 <LoadGrid>d__;
			<LoadGrid>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadGrid>d__.<>4__this = this;
			<LoadGrid>d__.length = length;
			<LoadGrid>d__.bShow = bShow;
			<LoadGrid>d__.<>1__state = -1;
			<LoadGrid>d__.<>t__builder.Start<GenericLayout<TProxy, TData>.<LoadGrid>d__24>(ref <LoadGrid>d__);
			return <LoadGrid>d__.<>t__builder.Task;
		}

		// Token: 0x06030B4A RID: 199498 RVA: 0x00B4F558 File Offset: 0x00B4D758
		[NullableContext(0)]
		public UniTask<bool> RefreshByDataDirectly([Nullable(1)] IReadOnlyList<TData> data)
		{
			GenericLayout<TProxy, TData>.<RefreshByDataDirectly>d__25 <RefreshByDataDirectly>d__;
			<RefreshByDataDirectly>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RefreshByDataDirectly>d__.<>4__this = this;
			<RefreshByDataDirectly>d__.data = data;
			<RefreshByDataDirectly>d__.<>1__state = -1;
			<RefreshByDataDirectly>d__.<>t__builder.Start<GenericLayout<TProxy, TData>.<RefreshByDataDirectly>d__25>(ref <RefreshByDataDirectly>d__);
			return <RefreshByDataDirectly>d__.<>t__builder.Task;
		}

		// Token: 0x06030B4B RID: 199499 RVA: 0x00B4F5A4 File Offset: 0x00B4D7A4
		public bool RefreshByDataDirectlySync(IReadOnlyList<TData> data)
		{
			int count = data.Count;
			if (count > this.GridItemList.Count)
			{
				return false;
			}
			this.Delegate.SetData(data);
			this.Delegate.ClearSelectInfo();
			this.ProxyMap.Clear();
			int count2 = this.GridDisplayItemList.Count;
			if (count > count2)
			{
				for (int i = count2; i < count; i++)
				{
					UUIItem uuiitem = this.GridItemList[i];
					uuiitem.SetUIActive(true);
					this.GridDisplayItemList.Add(uuiitem);
					this.ProxyDisplayList.Add(this.Delegate.GetGridProxy(i));
				}
			}
			for (int j = count; j < this.GridItemList.Count; j++)
			{
				this.GridItemList[j].SetUIActive(false);
			}
			if (this.GridDisplayItemList.Count > count)
			{
				this.GridDisplayItemList.RemoveRange(count, this.GridDisplayItemList.Count - count);
			}
			if (this.ProxyDisplayList.Count > count)
			{
				this.ProxyDisplayList.RemoveRange(count, this.ProxyDisplayList.Count - count);
			}
			this.RefreshDisplayProxyListSync();
			return true;
		}

		// Token: 0x06030B4C RID: 199500 RVA: 0x00B4F6C0 File Offset: 0x00B4D8C0
		public void RefreshByData(IReadOnlyList<TData> data, [Nullable(2)] Action callBack = null, bool playGridAnim = false)
		{
			if (this.IsLock)
			{
				GenericLayout<TProxy, TData>.OperationParam element = new GenericLayout<TProxy, TData>.OperationParam(data, callBack, playGridAnim);
				this.OperationQueue.Push(element);
				return;
			}
			this.Lock();
			this.RefreshByDataAsync(data, playGridAnim, null).ContinueWith(delegate()
			{
				Action callBack2 = callBack;
				if (callBack2 != null)
				{
					callBack2();
				}
				this.Unlock();
			}).Forget();
		}

		// Token: 0x06030B4D RID: 199501 RVA: 0x00B4F734 File Offset: 0x00B4D934
		public UniTask RefreshByDataAsync(IReadOnlyList<TData> data, bool playGridAnim = false, int? length = null)
		{
			GenericLayout<TProxy, TData>.<RefreshByDataAsync>d__28 <RefreshByDataAsync>d__;
			<RefreshByDataAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshByDataAsync>d__.<>4__this = this;
			<RefreshByDataAsync>d__.data = data;
			<RefreshByDataAsync>d__.playGridAnim = playGridAnim;
			<RefreshByDataAsync>d__.length = length;
			<RefreshByDataAsync>d__.<>1__state = -1;
			<RefreshByDataAsync>d__.<>t__builder.Start<GenericLayout<TProxy, TData>.<RefreshByDataAsync>d__28>(ref <RefreshByDataAsync>d__);
			return <RefreshByDataAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06030B4E RID: 199502 RVA: 0x00B4F78F File Offset: 0x00B4D98F
		public void RefreshWithoutDataSync()
		{
			this.RefreshDisplayProxyListSync();
		}

		// Token: 0x06030B4F RID: 199503 RVA: 0x00B4F798 File Offset: 0x00B4D998
		private void RefreshDisplayProxyListSync()
		{
			if (this.GridDisplayItemList.Count == 0)
			{
				return;
			}
			for (int i = 0; i < this.GridDisplayItemList.Count; i++)
			{
				this.RefreshDisplayProxyInternalSync(i);
			}
		}

		// Token: 0x06030B50 RID: 199504 RVA: 0x00B4F7D0 File Offset: 0x00B4D9D0
		private UniTask RefreshDisplayProxyListAsync()
		{
			GenericLayout<TProxy, TData>.<RefreshDisplayProxyListAsync>d__31 <RefreshDisplayProxyListAsync>d__;
			<RefreshDisplayProxyListAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshDisplayProxyListAsync>d__.<>4__this = this;
			<RefreshDisplayProxyListAsync>d__.<>1__state = -1;
			<RefreshDisplayProxyListAsync>d__.<>t__builder.Start<GenericLayout<TProxy, TData>.<RefreshDisplayProxyListAsync>d__31>(ref <RefreshDisplayProxyListAsync>d__);
			return <RefreshDisplayProxyListAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06030B51 RID: 199505 RVA: 0x00B4F814 File Offset: 0x00B4DA14
		private void RefreshDisplayProxyInternalSync(int index)
		{
			this.Delegate.RefreshGridProxy(index, index);
			TProxy value = this.ProxyDisplayList[index];
			object key = this.GetKey(index);
			if (key != null)
			{
				this.ProxyMap[key] = value;
			}
		}

		// Token: 0x06030B52 RID: 199506 RVA: 0x00B4F854 File Offset: 0x00B4DA54
		private UniTask RefreshDisplayProxyInternalAsync(int index)
		{
			GenericLayout<TProxy, TData>.<RefreshDisplayProxyInternalAsync>d__33 <RefreshDisplayProxyInternalAsync>d__;
			<RefreshDisplayProxyInternalAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshDisplayProxyInternalAsync>d__.<>4__this = this;
			<RefreshDisplayProxyInternalAsync>d__.index = index;
			<RefreshDisplayProxyInternalAsync>d__.<>1__state = -1;
			<RefreshDisplayProxyInternalAsync>d__.<>t__builder.Start<GenericLayout<TProxy, TData>.<RefreshDisplayProxyInternalAsync>d__33>(ref <RefreshDisplayProxyInternalAsync>d__);
			return <RefreshDisplayProxyInternalAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06030B53 RID: 199507 RVA: 0x00B4F8A0 File Offset: 0x00B4DAA0
		private UniTask UpdateDataInternal(IReadOnlyList<TData> data, int length)
		{
			GenericLayout<TProxy, TData>.<UpdateDataInternal>d__34 <UpdateDataInternal>d__;
			<UpdateDataInternal>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<UpdateDataInternal>d__.<>4__this = this;
			<UpdateDataInternal>d__.data = data;
			<UpdateDataInternal>d__.length = length;
			<UpdateDataInternal>d__.<>1__state = -1;
			<UpdateDataInternal>d__.<>t__builder.Start<GenericLayout<TProxy, TData>.<UpdateDataInternal>d__34>(ref <UpdateDataInternal>d__);
			return <UpdateDataInternal>d__.<>t__builder.Task;
		}

		// Token: 0x06030B54 RID: 199508 RVA: 0x00B4F8F3 File Offset: 0x00B4DAF3
		[NullableContext(2)]
		public UUIItem GetItemByIndex(int index)
		{
			if (index < 0 || index >= this.GridDisplayItemList.Count)
			{
				return null;
			}
			return this.GridDisplayItemList[index];
		}

		// Token: 0x06030B55 RID: 199509 RVA: 0x00B4F918 File Offset: 0x00B4DB18
		[return: Nullable(2)]
		public UUIItem GetItemByKey(object key)
		{
			TProxy layoutItemByKey = this.GetLayoutItemByKey(key);
			return this.GridDisplayItemList[layoutItemByKey.GridIndex];
		}

		// Token: 0x06030B56 RID: 199510 RVA: 0x00B4F944 File Offset: 0x00B4DB44
		[return: Nullable(2)]
		public TProxy GetLayoutItemByKey(object key)
		{
			TProxy result;
			if (this.ProxyMap.TryGetValue(key, out result))
			{
				return result;
			}
			return default(TProxy);
		}

		// Token: 0x06030B57 RID: 199511 RVA: 0x00B4F96C File Offset: 0x00B4DB6C
		public Dictionary<object, TProxy> GetLayoutItemMap()
		{
			return this.ProxyMap;
		}

		// Token: 0x06030B58 RID: 199512 RVA: 0x00B4F974 File Offset: 0x00B4DB74
		public List<TProxy> GetLayoutItemList()
		{
			return this.ProxyDisplayList;
		}

		// Token: 0x06030B59 RID: 199513 RVA: 0x00B4F97C File Offset: 0x00B4DB7C
		[NullableContext(2)]
		public TProxy GetLayoutItemByIndex(int index)
		{
			if (index < 0 || index >= this.ProxyDisplayList.Count)
			{
				return default(TProxy);
			}
			return this.ProxyDisplayList[index];
		}

		// Token: 0x06030B5A RID: 199514 RVA: 0x00B4F9B1 File Offset: 0x00B4DBB1
		public IReadOnlyList<TData> GetDatas()
		{
			return this.Delegate.GetDatas();
		}

		// Token: 0x06030B5B RID: 199515 RVA: 0x00B4F9BE File Offset: 0x00B4DBBE
		public void SelectGridProxy(int gridIndex, bool fireEvent = false)
		{
			this.Delegate.SelectGridProxy(gridIndex, gridIndex, fireEvent);
		}

		// Token: 0x06030B5C RID: 199516 RVA: 0x00B4F9D0 File Offset: 0x00B4DBD0
		public void SelectGridProxyByKey(object key, bool fireEvent = false)
		{
			int? gridIndexByKey = this.GetGridIndexByKey<object>(key);
			if (gridIndexByKey != null)
			{
				this.SelectGridProxy(gridIndexByKey.Value, fireEvent);
			}
		}

		// Token: 0x06030B5D RID: 199517 RVA: 0x00B4F9FC File Offset: 0x00B4DBFC
		public void DeselectCurrentGridProxy()
		{
			this.Delegate.DeselectCurrentGridProxy(false);
		}

		// Token: 0x06030B5E RID: 199518 RVA: 0x00B4FA0A File Offset: 0x00B4DC0A
		public int GetSelectedGridIndex()
		{
			return this.Delegate.GetSelectedGridIndex();
		}

		// Token: 0x06030B5F RID: 199519 RVA: 0x00B4FA17 File Offset: 0x00B4DC17
		[NullableContext(2)]
		public TProxy GetSelectedProxy()
		{
			return this.Delegate.GetSelectedProxy();
		}

		// Token: 0x06030B60 RID: 199520 RVA: 0x00B4FA24 File Offset: 0x00B4DC24
		public void BindLateUpdate(Action<float> callBack)
		{
			this.Layout.OnLateUpdate.Bind(callBack);
		}

		// Token: 0x06030B61 RID: 199521 RVA: 0x00B4FA37 File Offset: 0x00B4DC37
		public void UnBindLateUpdate()
		{
			this.Layout.OnLateUpdate.Unbind();
		}

		// Token: 0x06030B62 RID: 199522 RVA: 0x00B4FA4C File Offset: 0x00B4DC4C
		public void SetActive(bool bActive)
		{
			UUILayoutBase layout = this.Layout;
			if (layout == null)
			{
				return;
			}
			layout.RootUIComp.Get().SetUIActive(bActive);
		}

		// Token: 0x06030B63 RID: 199523 RVA: 0x00B4FA77 File Offset: 0x00B4DC77
		[NullableContext(2)]
		private void OnDestroy(AActor actor)
		{
			this.UnBindLateUpdate();
		}

		// Token: 0x06030B64 RID: 199524 RVA: 0x00B4FA7F File Offset: 0x00B4DC7F
		public int GetDisplayGridNum()
		{
			return this.ProxyDisplayList.Count;
		}

		// Token: 0x06030B65 RID: 199525 RVA: 0x00B4FA8C File Offset: 0x00B4DC8C
		public int GetPreservedGridNum()
		{
			return this.GridItemList.Count;
		}

		// Token: 0x06030B66 RID: 199526 RVA: 0x00B4FA99 File Offset: 0x00B4DC99
		public int GetDisplayGridStartIndex()
		{
			return 0;
		}

		// Token: 0x06030B67 RID: 199527 RVA: 0x00B4FA9C File Offset: 0x00B4DC9C
		public int GetDisplayGridEndIndex()
		{
			return this.GetDisplayGridNum() - 1;
		}

		// Token: 0x06030B68 RID: 199528 RVA: 0x00B4FAA6 File Offset: 0x00B4DCA6
		public UUIItem GetGrid(int gridIndex)
		{
			if (gridIndex < 0 || gridIndex >= this.GridDisplayItemList.Count)
			{
				return null;
			}
			return this.GridDisplayItemList[gridIndex];
		}

		// Token: 0x06030B69 RID: 199529 RVA: 0x00B4FAC8 File Offset: 0x00B4DCC8
		public UUIItem GetGridByDisplayIndex(int displayIndex)
		{
			return this.GetGrid(displayIndex);
		}

		// Token: 0x06030B6A RID: 199530 RVA: 0x00B4FAD1 File Offset: 0x00B4DCD1
		public float GetGridAnimationInterval()
		{
			return this.Layout.GetGridAnimationInterval();
		}

		// Token: 0x06030B6B RID: 199531 RVA: 0x00B4FADE File Offset: 0x00B4DCDE
		public float GetGridAnimationStartTime()
		{
			return this.Layout.GetGridAnimationStartTime();
		}

		// Token: 0x06030B6C RID: 199532 RVA: 0x00B4FAEB File Offset: 0x00B4DCEB
		public void NotifyAnimationStart()
		{
			this.Layout.SetInAnimation(true);
		}

		// Token: 0x06030B6D RID: 199533 RVA: 0x00B4FAF9 File Offset: 0x00B4DCF9
		public void NotifyAnimationEnd()
		{
			this.Layout.SetInAnimation(false);
		}

		// Token: 0x06030B6E RID: 199534 RVA: 0x00B4FB07 File Offset: 0x00B4DD07
		[NullableContext(2)]
		public UUIInturnAnimController GetUiAnimController()
		{
			if (this.AnimControllerComponent == null)
			{
				UUILayoutBase layout = this.Layout;
				this.AnimControllerComponent = (((layout != null) ? layout.GetOwner().GetComponentByClass(UUIInturnAnimController.StaticClass()) : null) as UUIInturnAnimController);
			}
			return this.AnimControllerComponent;
		}

		// Token: 0x06030B6F RID: 199535 RVA: 0x00B4FB43 File Offset: 0x00B4DD43
		public void PlayGridAnim()
		{
			if (this.GridsController != null)
			{
				this.GridsController.PlayGridAnim(this.GetDisplayGridNum(), false);
			}
		}

		// Token: 0x06030B70 RID: 199536 RVA: 0x00B4FB60 File Offset: 0x00B4DD60
		public void RefreshGridProxyByKey<[Nullable(2)] T>(T key)
		{
			int? gridIndexByKey = this.GetGridIndexByKey<T>(key);
			if (gridIndexByKey != null)
			{
				this.Delegate.RefreshGridProxy(gridIndexByKey.Value, gridIndexByKey.Value);
			}
		}

		// Token: 0x0401A2AA RID: 107178
		[Nullable(2)]
		private readonly UUILayoutBase Layout;

		// Token: 0x0401A2AB RID: 107179
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private readonly ScrollViewDelegate<TProxy, TData> Delegate;

		// Token: 0x0401A2AC RID: 107180
		[Nullable(2)]
		private GridAppearAnimationBase GridsController;

		// Token: 0x0401A2AD RID: 107181
		[Nullable(2)]
		public UUIInturnAnimController AnimControllerComponent;

		// Token: 0x0401A2AE RID: 107182
		private readonly List<UUIItem> GridItemList = new List<UUIItem>();

		// Token: 0x0401A2AF RID: 107183
		private readonly List<UUIItem> GridDisplayItemList = new List<UUIItem>();

		// Token: 0x0401A2B0 RID: 107184
		private readonly List<TProxy> ProxyDisplayList = new List<TProxy>();

		// Token: 0x0401A2B1 RID: 107185
		private readonly Dictionary<object, TProxy> ProxyMap = new Dictionary<object, TProxy>();

		// Token: 0x0401A2B2 RID: 107186
		[Nullable(2)]
		private readonly AUIBaseActor TemplateGridActor;

		// Token: 0x0401A2B3 RID: 107187
		[Nullable(new byte[]
		{
			1,
			1,
			0,
			0
		})]
		private readonly Queue<GenericLayout<TProxy, TData>.OperationParam> OperationQueue = new Queue<GenericLayout<TProxy, TData>.OperationParam>(4);

		// Token: 0x0401A2B4 RID: 107188
		private bool Operating;

		// Token: 0x0401A2B5 RID: 107189
		public readonly bool IsRefreshAsync;

		// Token: 0x0401A2B6 RID: 107190
		public readonly bool IsGridShowWhenCreate = true;

		// Token: 0x0200AB7C RID: 43900
		[NullableContext(2)]
		[Nullable(0)]
		private class OperationParam
		{
			// Token: 0x0604DAC4 RID: 318148 RVA: 0x0147CF4A File Offset: 0x0147B14A
			public OperationParam([Nullable(new byte[]
			{
				2,
				1
			})] IReadOnlyList<TData> data = null, Action callBack = null, bool playGridAnim = false)
			{
				this.Data = data;
				this.CallBack = callBack;
				this.PlayGridAnim = playGridAnim;
			}

			// Token: 0x04034185 RID: 213381
			[Nullable(new byte[]
			{
				2,
				1
			})]
			public IReadOnlyList<TData> Data;

			// Token: 0x04034186 RID: 213382
			public Action CallBack;

			// Token: 0x04034187 RID: 213383
			public bool PlayGridAnim;
		}
	}
}
