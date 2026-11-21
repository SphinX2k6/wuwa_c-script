using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Util
{
	// Token: 0x02003840 RID: 14400
	[NullableContext(1)]
	[Nullable(0)]
	public class GenericLayout<TProxy, [Nullable(2)] TData> : IGridPreserver where TProxy : class, IGridProxy<TData>
	{
		// Token: 0x0602566C RID: 153196 RVA: 0x00A8A020 File Offset: 0x00A88220
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

		// Token: 0x17004CED RID: 19693
		// (get) Token: 0x0602566D RID: 153197 RVA: 0x00A8A129 File Offset: 0x00A88329
		public bool IsLock
		{
			get
			{
				return this.Operating;
			}
		}

		// Token: 0x0602566E RID: 153198 RVA: 0x00A8A131 File Offset: 0x00A88331
		private void Lock()
		{
			this.Operating = true;
		}

		// Token: 0x0602566F RID: 153199 RVA: 0x00A8A13C File Offset: 0x00A8833C
		private void Unlock()
		{
			this.Operating = false;
			if (this.OperationQueue.Size > 0)
			{
				GenericLayout<TProxy, TData>.OperationParam operationParam = this.OperationQueue.Pop();
				this.RefreshByData(operationParam.Data, operationParam.CallBack, operationParam.PlayGridAnim);
			}
		}

		// Token: 0x06025670 RID: 153200 RVA: 0x00A8A184 File Offset: 0x00A88384
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

		// Token: 0x06025671 RID: 153201 RVA: 0x00A8A1C8 File Offset: 0x00A883C8
		[NullableContext(2)]
		private UUIItem CreateGrid()
		{
			return LguiUtil.Instance.CopyItem(this.TemplateGridActor.GetUIItem(), this.GetRootUiItem());
		}

		// Token: 0x06025672 RID: 153202 RVA: 0x00A8A1E8 File Offset: 0x00A883E8
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

		// Token: 0x06025673 RID: 153203 RVA: 0x00A8A240 File Offset: 0x00A88440
		public int? GetGridIndexByKey<[Nullable(2)] T>(T key)
		{
			TProxy tproxy;
			if (this.ProxyMap.TryGetValue(key, out tproxy))
			{
				return new int?(tproxy.GridIndex);
			}
			return null;
		}

		// Token: 0x06025674 RID: 153204 RVA: 0x00A8A27C File Offset: 0x00A8847C
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

		// Token: 0x06025675 RID: 153205 RVA: 0x00A8A30C File Offset: 0x00A8850C
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

		// Token: 0x06025676 RID: 153206 RVA: 0x00A8A360 File Offset: 0x00A88560
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

		// Token: 0x06025677 RID: 153207 RVA: 0x00A8A3AC File Offset: 0x00A885AC
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

		// Token: 0x06025678 RID: 153208 RVA: 0x00A8A4C8 File Offset: 0x00A886C8
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

		// Token: 0x06025679 RID: 153209 RVA: 0x00A8A53C File Offset: 0x00A8873C
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

		// Token: 0x0602567A RID: 153210 RVA: 0x00A8A597 File Offset: 0x00A88797
		public void RefreshWithoutDataSync()
		{
			this.RefreshDisplayProxyListSync();
		}

		// Token: 0x0602567B RID: 153211 RVA: 0x00A8A5A0 File Offset: 0x00A887A0
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

		// Token: 0x0602567C RID: 153212 RVA: 0x00A8A5D8 File Offset: 0x00A887D8
		private UniTask RefreshDisplayProxyListAsync()
		{
			GenericLayout<TProxy, TData>.<RefreshDisplayProxyListAsync>d__31 <RefreshDisplayProxyListAsync>d__;
			<RefreshDisplayProxyListAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshDisplayProxyListAsync>d__.<>4__this = this;
			<RefreshDisplayProxyListAsync>d__.<>1__state = -1;
			<RefreshDisplayProxyListAsync>d__.<>t__builder.Start<GenericLayout<TProxy, TData>.<RefreshDisplayProxyListAsync>d__31>(ref <RefreshDisplayProxyListAsync>d__);
			return <RefreshDisplayProxyListAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602567D RID: 153213 RVA: 0x00A8A61C File Offset: 0x00A8881C
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

		// Token: 0x0602567E RID: 153214 RVA: 0x00A8A65C File Offset: 0x00A8885C
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

		// Token: 0x0602567F RID: 153215 RVA: 0x00A8A6A8 File Offset: 0x00A888A8
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

		// Token: 0x06025680 RID: 153216 RVA: 0x00A8A6FB File Offset: 0x00A888FB
		[NullableContext(2)]
		public UUIItem GetItemByIndex(int index)
		{
			if (index < 0 || index >= this.GridDisplayItemList.Count)
			{
				return null;
			}
			return this.GridDisplayItemList[index];
		}

		// Token: 0x06025681 RID: 153217 RVA: 0x00A8A720 File Offset: 0x00A88920
		[return: Nullable(2)]
		public UUIItem GetItemByKey(object key)
		{
			TProxy layoutItemByKey = this.GetLayoutItemByKey(key);
			return this.GridDisplayItemList[layoutItemByKey.GridIndex];
		}

		// Token: 0x06025682 RID: 153218 RVA: 0x00A8A74C File Offset: 0x00A8894C
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

		// Token: 0x06025683 RID: 153219 RVA: 0x00A8A774 File Offset: 0x00A88974
		public Dictionary<object, TProxy> GetLayoutItemMap()
		{
			return this.ProxyMap;
		}

		// Token: 0x06025684 RID: 153220 RVA: 0x00A8A77C File Offset: 0x00A8897C
		public List<TProxy> GetLayoutItemList()
		{
			return this.ProxyDisplayList;
		}

		// Token: 0x06025685 RID: 153221 RVA: 0x00A8A784 File Offset: 0x00A88984
		[NullableContext(2)]
		public TProxy GetLayoutItemByIndex(int index)
		{
			if (index < 0 || index >= this.ProxyDisplayList.Count)
			{
				return default(TProxy);
			}
			return this.ProxyDisplayList[index];
		}

		// Token: 0x06025686 RID: 153222 RVA: 0x00A8A7B9 File Offset: 0x00A889B9
		public IReadOnlyList<TData> GetDatas()
		{
			return this.Delegate.GetDatas();
		}

		// Token: 0x06025687 RID: 153223 RVA: 0x00A8A7C6 File Offset: 0x00A889C6
		public void SelectGridProxy(int gridIndex, bool fireEvent = false)
		{
			this.Delegate.SelectGridProxy(gridIndex, gridIndex, fireEvent);
		}

		// Token: 0x06025688 RID: 153224 RVA: 0x00A8A7D8 File Offset: 0x00A889D8
		public void SelectGridProxyByKey(object key, bool fireEvent = false)
		{
			int? gridIndexByKey = this.GetGridIndexByKey<object>(key);
			if (gridIndexByKey != null)
			{
				this.SelectGridProxy(gridIndexByKey.Value, fireEvent);
			}
		}

		// Token: 0x06025689 RID: 153225 RVA: 0x00A8A804 File Offset: 0x00A88A04
		public void DeselectCurrentGridProxy()
		{
			this.Delegate.DeselectCurrentGridProxy(false);
		}

		// Token: 0x0602568A RID: 153226 RVA: 0x00A8A812 File Offset: 0x00A88A12
		public int GetSelectedGridIndex()
		{
			return this.Delegate.GetSelectedGridIndex();
		}

		// Token: 0x0602568B RID: 153227 RVA: 0x00A8A81F File Offset: 0x00A88A1F
		[NullableContext(2)]
		public TProxy GetSelectedProxy()
		{
			return this.Delegate.GetSelectedProxy();
		}

		// Token: 0x0602568C RID: 153228 RVA: 0x00A8A82C File Offset: 0x00A88A2C
		public void BindLateUpdate(Action<float> callBack)
		{
			this.Layout.OnLateUpdate.Bind(callBack);
		}

		// Token: 0x0602568D RID: 153229 RVA: 0x00A8A83F File Offset: 0x00A88A3F
		public void UnBindLateUpdate()
		{
			this.Layout.OnLateUpdate.Unbind();
		}

		// Token: 0x0602568E RID: 153230 RVA: 0x00A8A854 File Offset: 0x00A88A54
		public void SetActive(bool bActive)
		{
			UUILayoutBase layout = this.Layout;
			if (layout == null)
			{
				return;
			}
			layout.RootUIComp.Get().SetUIActive(bActive);
		}

		// Token: 0x0602568F RID: 153231 RVA: 0x00A8A87F File Offset: 0x00A88A7F
		[NullableContext(2)]
		private void OnDestroy(AActor actor)
		{
			this.UnBindLateUpdate();
		}

		// Token: 0x06025690 RID: 153232 RVA: 0x00A8A887 File Offset: 0x00A88A87
		public int GetDisplayGridNum()
		{
			return this.ProxyDisplayList.Count;
		}

		// Token: 0x06025691 RID: 153233 RVA: 0x00A8A894 File Offset: 0x00A88A94
		public int GetPreservedGridNum()
		{
			return this.GridItemList.Count;
		}

		// Token: 0x06025692 RID: 153234 RVA: 0x00A8A8A1 File Offset: 0x00A88AA1
		public int GetDisplayGridStartIndex()
		{
			return 0;
		}

		// Token: 0x06025693 RID: 153235 RVA: 0x00A8A8A4 File Offset: 0x00A88AA4
		public int GetDisplayGridEndIndex()
		{
			return this.GetDisplayGridNum() - 1;
		}

		// Token: 0x06025694 RID: 153236 RVA: 0x00A8A8AE File Offset: 0x00A88AAE
		public UUIItem GetGrid(int gridIndex)
		{
			if (gridIndex < 0 || gridIndex >= this.GridDisplayItemList.Count)
			{
				return null;
			}
			return this.GridDisplayItemList[gridIndex];
		}

		// Token: 0x06025695 RID: 153237 RVA: 0x00A8A8D0 File Offset: 0x00A88AD0
		public UUIItem GetGridByDisplayIndex(int displayIndex)
		{
			return this.GetGrid(displayIndex);
		}

		// Token: 0x06025696 RID: 153238 RVA: 0x00A8A8D9 File Offset: 0x00A88AD9
		public float GetGridAnimationInterval()
		{
			return this.Layout.GetGridAnimationInterval();
		}

		// Token: 0x06025697 RID: 153239 RVA: 0x00A8A8E6 File Offset: 0x00A88AE6
		public float GetGridAnimationStartTime()
		{
			return this.Layout.GetGridAnimationStartTime();
		}

		// Token: 0x06025698 RID: 153240 RVA: 0x00A8A8F3 File Offset: 0x00A88AF3
		public void NotifyAnimationStart()
		{
			this.Layout.SetInAnimation(true);
		}

		// Token: 0x06025699 RID: 153241 RVA: 0x00A8A901 File Offset: 0x00A88B01
		public void NotifyAnimationEnd()
		{
			this.Layout.SetInAnimation(false);
		}

		// Token: 0x0602569A RID: 153242 RVA: 0x00A8A90F File Offset: 0x00A88B0F
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

		// Token: 0x0602569B RID: 153243 RVA: 0x00A8A94B File Offset: 0x00A88B4B
		public void PlayGridAnim()
		{
			if (this.GridsController != null)
			{
				this.GridsController.PlayGridAnim(this.GetDisplayGridNum(), false);
			}
		}

		// Token: 0x0602569C RID: 153244 RVA: 0x00A8A968 File Offset: 0x00A88B68
		public void RefreshGridProxyByKey<[Nullable(2)] T>(T key)
		{
			int? gridIndexByKey = this.GetGridIndexByKey<T>(key);
			if (gridIndexByKey != null)
			{
				this.Delegate.RefreshGridProxy(gridIndexByKey.Value, gridIndexByKey.Value);
			}
		}

		// Token: 0x04014B1D RID: 84765
		[Nullable(2)]
		private readonly UUILayoutBase Layout;

		// Token: 0x04014B1E RID: 84766
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private readonly ScrollViewDelegate<TProxy, TData> Delegate;

		// Token: 0x04014B1F RID: 84767
		[Nullable(2)]
		private GridAppearAnimationBase GridsController;

		// Token: 0x04014B20 RID: 84768
		[Nullable(2)]
		public UUIInturnAnimController AnimControllerComponent;

		// Token: 0x04014B21 RID: 84769
		private readonly List<UUIItem> GridItemList = new List<UUIItem>();

		// Token: 0x04014B22 RID: 84770
		private readonly List<UUIItem> GridDisplayItemList = new List<UUIItem>();

		// Token: 0x04014B23 RID: 84771
		private readonly List<TProxy> ProxyDisplayList = new List<TProxy>();

		// Token: 0x04014B24 RID: 84772
		private readonly Dictionary<object, TProxy> ProxyMap = new Dictionary<object, TProxy>();

		// Token: 0x04014B25 RID: 84773
		[Nullable(2)]
		private readonly AUIBaseActor TemplateGridActor;

		// Token: 0x04014B26 RID: 84774
		[Nullable(new byte[]
		{
			1,
			1,
			0,
			0
		})]
		private readonly Queue<GenericLayout<TProxy, TData>.OperationParam> OperationQueue = new Queue<GenericLayout<TProxy, TData>.OperationParam>(4);

		// Token: 0x04014B27 RID: 84775
		private bool Operating;

		// Token: 0x04014B28 RID: 84776
		public readonly bool IsRefreshAsync;

		// Token: 0x04014B29 RID: 84777
		public readonly bool IsGridShowWhenCreate = true;

		// Token: 0x02009589 RID: 38281
		[NullableContext(2)]
		[Nullable(0)]
		private class OperationParam
		{
			// Token: 0x06044084 RID: 278660 RVA: 0x01434BF2 File Offset: 0x01432DF2
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

			// Token: 0x0402EAFC RID: 191228
			[Nullable(new byte[]
			{
				2,
				1
			})]
			public IReadOnlyList<TData> Data;

			// Token: 0x0402EAFD RID: 191229
			public Action CallBack;

			// Token: 0x0402EAFE RID: 191230
			public bool PlayGridAnim;
		}
	}
}
