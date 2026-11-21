using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Util
{
	// Token: 0x02003855 RID: 14421
	[NullableContext(1)]
	[Nullable(0)]
	public class LoopScrollView<TProxy, [Nullable(2)] TData> : IGridPreserver where TProxy : class, IGridProxy<TData>
	{
		// Token: 0x17004CFB RID: 19707
		// (get) Token: 0x0602574E RID: 153422 RVA: 0x00A8D367 File Offset: 0x00A8B567
		private int DisplayGridNum
		{
			get
			{
				if (this.IsEmpty)
				{
					return 0;
				}
				return this.EndGridIndex - this.StartGridIndex + 1;
			}
		}

		// Token: 0x17004CFC RID: 19708
		// (get) Token: 0x0602574F RID: 153423 RVA: 0x00A8D382 File Offset: 0x00A8B582
		// (set) Token: 0x06025750 RID: 153424 RVA: 0x00A8D38A File Offset: 0x00A8B58A
		public int StartGridIndex
		{
			get
			{
				return this.PrivateStartGridIndex;
			}
			set
			{
				this.PrivateStartGridIndex = value;
			}
		}

		// Token: 0x17004CFD RID: 19709
		// (get) Token: 0x06025751 RID: 153425 RVA: 0x00A8D393 File Offset: 0x00A8B593
		// (set) Token: 0x06025752 RID: 153426 RVA: 0x00A8D39B File Offset: 0x00A8B59B
		public int EndGridIndex
		{
			get
			{
				return this.PrivateEndGridIndex;
			}
			set
			{
				this.PrivateEndGridIndex = value;
			}
		}

		// Token: 0x17004CFE RID: 19710
		// (get) Token: 0x06025753 RID: 153427 RVA: 0x00A8D3A4 File Offset: 0x00A8B5A4
		private bool IsEmpty
		{
			get
			{
				return this.EndGridIndex == -1 && this.StartGridIndex == -1;
			}
		}

		// Token: 0x17004CFF RID: 19711
		// (get) Token: 0x06025754 RID: 153428 RVA: 0x00A8D3BA File Offset: 0x00A8B5BA
		public bool DataInited
		{
			get
			{
				return this.DataInitedInternal;
			}
		}

		// Token: 0x17004D00 RID: 19712
		// (get) Token: 0x06025755 RID: 153429 RVA: 0x00A8D3C2 File Offset: 0x00A8B5C2
		private bool IsLock
		{
			get
			{
				return this.Operating;
			}
		}

		// Token: 0x06025756 RID: 153430 RVA: 0x00A8D3CA File Offset: 0x00A8B5CA
		private void Lock()
		{
			this.Operating = true;
		}

		// Token: 0x06025757 RID: 153431 RVA: 0x00A8D3D4 File Offset: 0x00A8B5D4
		private void Unlock()
		{
			this.Operating = false;
			if (this.OperationQueue.Size > 0)
			{
				OperationParam<TData> operationParam = this.OperationQueue.Pop();
				this.RefreshByData(operationParam.Data, operationParam.KeepContentPosition, operationParam.CallBack, operationParam.PlayGridAnim);
			}
		}

		// Token: 0x06025758 RID: 153432 RVA: 0x00A8D420 File Offset: 0x00A8B620
		public LoopScrollView(UUILoopScrollViewComponent scrollView, [Nullable(2)] AUIBaseActor gridActor, Func<TProxy> gridProxyCreateFunction, bool isAsync = false)
		{
			if (gridActor == null)
			{
				Log.Instance.Error(ELogModule.LoopScrollView, ELogAuthor.TL, "设置格子模板错误，grid为空!", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			gridActor.GetUIItem().SetUIActive(false);
			scrollView.SetTickableWhenPaused(true);
			AUIBaseActor auibaseActor = scrollView.GetOwner() as AUIBaseActor;
			if (auibaseActor != null)
			{
				auibaseActor.OnPreDestroyed.Add(new Action<AActor>(this.OnDestroy));
			}
			if (isAsync)
			{
				scrollView.OnGridCreate.Bind(new Action<int, AUIBaseActor>(this.OnGridCreateAsync));
			}
			else
			{
				scrollView.OnGridCreate.Bind(new Action<int, AUIBaseActor>(this.OnGridCreate));
			}
			scrollView.OnGridsUpdate.Bind(new Action<int, int>(this.OnGridsUpdate));
			this.TargetScroll = scrollView;
			this.TemplateGridActor = gridActor;
			this.Delegate = new ScrollViewDelegate<TProxy, TData>(gridProxyCreateFunction);
			this.GridsController = new InTurnGridAppearAnimation(this);
			this.GridsController.RegisterAnimController();
		}

		// Token: 0x06025759 RID: 153433 RVA: 0x00A8D535 File Offset: 0x00A8B735
		public int GetDisplayGridNum()
		{
			return this.DisplayGridNum;
		}

		// Token: 0x0602575A RID: 153434 RVA: 0x00A8D53D File Offset: 0x00A8B73D
		public int GetPreservedGridNum()
		{
			UUILoopScrollViewComponent targetScroll = this.TargetScroll;
			if (targetScroll == null)
			{
				return 0;
			}
			return targetScroll.GridArray.Num();
		}

		// Token: 0x0602575B RID: 153435 RVA: 0x00A8D555 File Offset: 0x00A8B755
		public int GetDisplayGridStartIndex()
		{
			return this.StartGridIndex;
		}

		// Token: 0x0602575C RID: 153436 RVA: 0x00A8D55D File Offset: 0x00A8B75D
		public int GetDisplayGridEndIndex()
		{
			return this.EndGridIndex;
		}

		// Token: 0x0602575D RID: 153437 RVA: 0x00A8D565 File Offset: 0x00A8B765
		public float GetGridAnimationInterval()
		{
			return this.TargetScroll.GetGridAnimationInterval();
		}

		// Token: 0x0602575E RID: 153438 RVA: 0x00A8D572 File Offset: 0x00A8B772
		public float GetGridAnimationStartTime()
		{
			return this.TargetScroll.GetGridAnimationStartTime();
		}

		// Token: 0x0602575F RID: 153439 RVA: 0x00A8D57F File Offset: 0x00A8B77F
		public void NotifyAnimationStart()
		{
			this.TargetScroll.SetInAnimation(true);
		}

		// Token: 0x06025760 RID: 153440 RVA: 0x00A8D58D File Offset: 0x00A8B78D
		public void NotifyAnimationEnd()
		{
			this.TargetScroll.SetInAnimation(false);
			Action animFinishDelegate = this.AnimFinishDelegate;
			if (animFinishDelegate == null)
			{
				return;
			}
			animFinishDelegate();
		}

		// Token: 0x06025761 RID: 153441 RVA: 0x00A8D5AB File Offset: 0x00A8B7AB
		public void SetAnimFinishDelegate(Action @delegate)
		{
			this.AnimFinishDelegate = @delegate;
		}

		// Token: 0x06025762 RID: 153442 RVA: 0x00A8D5B4 File Offset: 0x00A8B7B4
		[NullableContext(2)]
		public UUIItem GetGrid(int gridIndex)
		{
			AUIBaseActor grid = this.TargetScroll.GetGrid(gridIndex);
			if (grid == null)
			{
				return null;
			}
			return grid.GetUIItem();
		}

		// Token: 0x06025763 RID: 153443 RVA: 0x00A8D5D0 File Offset: 0x00A8B7D0
		[NullableContext(2)]
		public UUIItem GetGridByDisplayIndex(int displayIndex)
		{
			if (this.TargetScroll.GridArray.Num() <= 0)
			{
				return null;
			}
			TWeakObjectPtr<AUIBaseActor> tweakObjectPtr = this.TargetScroll.GridArray[displayIndex];
			if (tweakObjectPtr.Get() == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.ScrollViewGrid;
				ELogAuthor author = ELogAuthor.WY;
				string message = "Grid is NULL!";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("DisplayIndex", displayIndex);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			return tweakObjectPtr.Get().GetUIItem();
		}

		// Token: 0x06025764 RID: 153444 RVA: 0x00A8D648 File Offset: 0x00A8B848
		[NullableContext(2)]
		public TProxy UnsafeGetGridProxy(int gridIndex, bool logError = false)
		{
			int gridDisplayIndex = this.GetGridDisplayIndex(gridIndex, logError);
			if (gridDisplayIndex == -1)
			{
				return default(TProxy);
			}
			if (this.GridsController != null && !this.GridsController.IsGridControlValid())
			{
				if (logError)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.ScrollViewGrid;
					ELogAuthor author = ELogAuthor.WY;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 1);
					defaultInterpolatedStringHandler.AppendLiteral("动画还在播放时非法获取格子, gridIndex: ");
					defaultInterpolatedStringHandler.AppendFormatted<int>(gridIndex);
					instance.Error(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				}
				return default(TProxy);
			}
			return this.Delegate.GetGridProxy(gridDisplayIndex);
		}

		// Token: 0x06025765 RID: 153445 RVA: 0x00A8D6D6 File Offset: 0x00A8B8D6
		public void ReloadGrids(int length)
		{
			if (length == this.Delegate.GetDataLength())
			{
				return;
			}
			this.UpdateDataInternal(length, false);
		}

		// Token: 0x06025766 RID: 153446 RVA: 0x00A8D6EF File Offset: 0x00A8B8EF
		[Obsolete("请使用RefreshByData或 RefreshByDataAsync")]
		public void ReloadProxyData(Func<int, TData> dataProxyFunction, int dataLength, bool cacheData = true, bool keepContentPosition = false)
		{
			this.Delegate.ClearSelectInfo();
			this.Delegate.SetDataProxy(dataProxyFunction, dataLength, cacheData);
			this.UpdateDataInternal(dataLength, keepContentPosition);
		}

		// Token: 0x06025767 RID: 153447 RVA: 0x00A8D714 File Offset: 0x00A8B914
		[Obsolete("请使用RefreshByData或 RefreshByDataAsync")]
		public void ReloadData(IReadOnlyList<TData> data, bool keepContentPosition = false)
		{
			if (data.Count != this.Delegate.GetDataLength())
			{
				this.Delegate.ClearSelectInfo();
				this.Delegate.SetData(data);
				this.UpdateDataInternal(data.Count, keepContentPosition);
				return;
			}
			this.UpdateData(data);
			GridAppearAnimationBase gridsController = this.GridsController;
			if (gridsController == null)
			{
				return;
			}
			gridsController.PlayGridAnim(this.DisplayGridNum, true);
		}

		// Token: 0x06025768 RID: 153448 RVA: 0x00A8D778 File Offset: 0x00A8B978
		public void UpdateData(IReadOnlyList<TData> data)
		{
			if (data.Count != this.Delegate.GetDataLength())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.ScrollViewGrid;
				ELogAuthor author = ELogAuthor.WY;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(42, 2);
				defaultInterpolatedStringHandler.AppendLiteral("UpdateData要求新的数据长度必须跟旧的数据长度相等. 新长度: ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(data.Count);
				defaultInterpolatedStringHandler.AppendLiteral(", 旧长度：");
				defaultInterpolatedStringHandler.AppendFormatted<int>(this.Delegate.GetDataLength());
				instance.Error(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.Delegate.SetData(data);
			this.RefreshAllGridProxies();
		}

		// Token: 0x06025769 RID: 153449 RVA: 0x00A8D80C File Offset: 0x00A8BA0C
		public void RefreshAllGridProxies()
		{
			if (this.IsEmpty)
			{
				return;
			}
			for (int i = this.StartGridIndex; i <= this.EndGridIndex; i++)
			{
				this.RefreshGridProxy(i);
			}
		}

		// Token: 0x0602576A RID: 153450 RVA: 0x00A8D840 File Offset: 0x00A8BA40
		public void RefreshGridProxy(int gridIndex)
		{
			if (gridIndex >= this.StartGridIndex && gridIndex <= this.EndGridIndex)
			{
				int gridDisplayIndex = this.GetGridDisplayIndex(gridIndex, false);
				this.Delegate.RefreshGridProxy(gridIndex, gridDisplayIndex);
			}
		}

		// Token: 0x0602576B RID: 153451 RVA: 0x00A8D878 File Offset: 0x00A8BA78
		public void ClearGridProxies()
		{
			this.Delegate.ClearData();
			if (this.EndGridIndex < 0)
			{
				return;
			}
			for (int i = this.StartGridIndex; i <= this.EndGridIndex; i++)
			{
				this.Delegate.ClearGridProxy(i, this.GetGridDisplayIndex(i, false));
			}
		}

		// Token: 0x0602576C RID: 153452 RVA: 0x00A8D8C4 File Offset: 0x00A8BAC4
		public void ClearSelectInfo()
		{
			this.Delegate.ClearSelectInfo();
		}

		// Token: 0x0602576D RID: 153453 RVA: 0x00A8D8D1 File Offset: 0x00A8BAD1
		public TData TryGetCachedData(int gridIndex)
		{
			return this.Delegate.TryGetCachedData(gridIndex);
		}

		// Token: 0x0602576E RID: 153454 RVA: 0x00A8D8DF File Offset: 0x00A8BADF
		public void SelectGridProxy(int gridIndex, bool fireEvent = false)
		{
			this.Delegate.SelectGridProxy(gridIndex, this.GetGridDisplayIndex(gridIndex, false), fireEvent);
		}

		// Token: 0x0602576F RID: 153455 RVA: 0x00A8D8F6 File Offset: 0x00A8BAF6
		public void DeselectCurrentGridProxy(bool fireEvent = false)
		{
			this.Delegate.DeselectCurrentGridProxy(fireEvent);
		}

		// Token: 0x06025770 RID: 153456 RVA: 0x00A8D904 File Offset: 0x00A8BB04
		public int GetSelectedGridIndex()
		{
			return this.Delegate.GetSelectedGridIndex();
		}

		// Token: 0x06025771 RID: 153457 RVA: 0x00A8D911 File Offset: 0x00A8BB11
		public void BindLateUpdate(Action<float> callBack)
		{
			this.TargetScroll.OnLateUpdate.Bind(callBack);
		}

		// Token: 0x06025772 RID: 153458 RVA: 0x00A8D924 File Offset: 0x00A8BB24
		public void UnBindLateUpdate()
		{
			this.TargetScroll.OnLateUpdate.Unbind();
		}

		// Token: 0x06025773 RID: 153459 RVA: 0x00A8D938 File Offset: 0x00A8BB38
		private void UpdateDataInternal(int gridNum, bool keepContentPosition)
		{
			if (this.TargetScroll == null)
			{
				Log.Instance.Error(ELogModule.LoopScrollView, ELogAuthor.TL, "更新数据错误，UUILoopScrollViewComponent组件为空!", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			AUIBaseActor templateGridActor = this.TemplateGridActor;
			if (templateGridActor == null)
			{
				Log.Instance.Error(ELogModule.LoopScrollView, ELogAuthor.TL, "更新数据错误，TemplateGrid为空!", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.StartGridIndex = -1;
			this.EndGridIndex = -1;
			this.GridNum = gridNum;
			this.TargetScroll.RefreshByData(templateGridActor, gridNum, keepContentPosition);
			this.DataInitedInternal = true;
			if (this.GridsController != null)
			{
				this.GridsController.PlayGridAnim(this.DisplayGridNum, true);
			}
		}

		// Token: 0x06025774 RID: 153460 RVA: 0x00A8D9D8 File Offset: 0x00A8BBD8
		public void RefreshByData(IReadOnlyList<TData> data, bool keepContentPosition = false, [Nullable(2)] Action callBack = null, bool playGridAnim = false)
		{
			if (this.IsLock)
			{
				OperationParam<TData> element = new OperationParam<TData>(data, keepContentPosition, callBack, playGridAnim);
				this.OperationQueue.Push(element);
				return;
			}
			this.Lock();
			this.RefreshByDataAsync(data, keepContentPosition, playGridAnim).ContinueWith(delegate()
			{
				Action callBack2 = callBack;
				if (callBack2 != null)
				{
					callBack2();
				}
				this.Unlock();
			});
		}

		// Token: 0x06025775 RID: 153461 RVA: 0x00A8DA40 File Offset: 0x00A8BC40
		public UniTask RefreshByDataAsync(IReadOnlyList<TData> data, bool keepContentPosition = false, bool playGridAnim = false)
		{
			LoopScrollView<TProxy, TData>.<RefreshByDataAsync>d__58 <RefreshByDataAsync>d__;
			<RefreshByDataAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshByDataAsync>d__.<>4__this = this;
			<RefreshByDataAsync>d__.data = data;
			<RefreshByDataAsync>d__.keepContentPosition = keepContentPosition;
			<RefreshByDataAsync>d__.playGridAnim = playGridAnim;
			<RefreshByDataAsync>d__.<>1__state = -1;
			<RefreshByDataAsync>d__.<>t__builder.Start<LoopScrollView<TProxy, TData>.<RefreshByDataAsync>d__58>(ref <RefreshByDataAsync>d__);
			return <RefreshByDataAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06025776 RID: 153462 RVA: 0x00A8DA9C File Offset: 0x00A8BC9C
		private UniTask UpdateDataInternalAsync(int gridNum, bool keepContentPosition)
		{
			LoopScrollView<TProxy, TData>.<UpdateDataInternalAsync>d__60 <UpdateDataInternalAsync>d__;
			<UpdateDataInternalAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<UpdateDataInternalAsync>d__.<>4__this = this;
			<UpdateDataInternalAsync>d__.gridNum = gridNum;
			<UpdateDataInternalAsync>d__.keepContentPosition = keepContentPosition;
			<UpdateDataInternalAsync>d__.<>1__state = -1;
			<UpdateDataInternalAsync>d__.<>t__builder.Start<LoopScrollView<TProxy, TData>.<UpdateDataInternalAsync>d__60>(ref <UpdateDataInternalAsync>d__);
			return <UpdateDataInternalAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06025777 RID: 153463 RVA: 0x00A8DAF0 File Offset: 0x00A8BCF0
		public bool IsGridDisplaying(int gridIndex)
		{
			int gridDisplayIndex = this.GetGridDisplayIndex(gridIndex, false);
			return gridDisplayIndex >= 0 && gridDisplayIndex < this.DisplayGridNum;
		}

		// Token: 0x06025778 RID: 153464 RVA: 0x00A8DB15 File Offset: 0x00A8BD15
		public void ScrollToGridIndex(int gridIndex, bool playGridAnim = true)
		{
			this.TargetScroll.ScrollToGridIndex(gridIndex, false);
			if (playGridAnim)
			{
				this.ResetGridController();
			}
		}

		// Token: 0x06025779 RID: 153465 RVA: 0x00A8DB2D File Offset: 0x00A8BD2D
		public void ScrollToGridIndexLate(int gridIndex, bool playGridAnim = true)
		{
			this.TargetScroll.ScrollToGridIndexLater(gridIndex, false);
			if (playGridAnim)
			{
				this.ResetGridController();
			}
		}

		// Token: 0x0602577A RID: 153466 RVA: 0x00A8DB45 File Offset: 0x00A8BD45
		public void ScrollToGridIndexWithTween(int gridIndex, bool playGridAnim = true)
		{
			this.TargetScroll.ScrollToGridIndex(gridIndex, true);
			if (playGridAnim)
			{
				this.ResetGridController();
			}
		}

		// Token: 0x0602577B RID: 153467 RVA: 0x00A8DB5D File Offset: 0x00A8BD5D
		[NullableContext(2)]
		private void OnGridCreate(int displayIndex, AUIBaseActor actor)
		{
			this.Delegate.CreateGridProxy(displayIndex, actor);
		}

		// Token: 0x0602577C RID: 153468 RVA: 0x00A8DB70 File Offset: 0x00A8BD70
		[NullableContext(2)]
		private void OnGridCreateAsync(int displayIndex, AUIBaseActor actor)
		{
			UniTask<TProxy> promise = this.Delegate.CreateGridProxyAsync(displayIndex, actor, true);
			if (this.IsInRefreshAsync)
			{
				this.TempGridCreatePromiseList.Add(promise);
				return;
			}
			this.TempGridCreatePromiseList.Add(promise);
			promise.ContinueWith(delegate(TProxy _)
			{
				this.TempGridCreatePromiseList.Remove(promise);
				return UniTask.CompletedTask;
			}).Forget();
		}

		// Token: 0x0602577D RID: 153469 RVA: 0x00A8DBE8 File Offset: 0x00A8BDE8
		private void OnGridsUpdate(int startGridIndex, int endGridIndex)
		{
			if (this.TempGridCreatePromiseList.Count > 0)
			{
				return;
			}
			if (this.StartGridIndex == startGridIndex && this.EndGridIndex == endGridIndex)
			{
				return;
			}
			int startGridIndex2 = this.StartGridIndex;
			int endGridIndex2 = this.EndGridIndex;
			int displayGridNum = this.DisplayGridNum;
			int num = endGridIndex - startGridIndex + 1;
			for (int i = startGridIndex2; i <= endGridIndex2; i++)
			{
				if (i >= 0 && i < this.GridNum && displayGridNum != 0 && num != 0)
				{
					int num2 = i % displayGridNum;
					int num3 = i % num;
					if (i < startGridIndex || i > endGridIndex || i > endGridIndex2 || num2 != num3)
					{
						this.Delegate.ClearGridProxy(i, this.GetGridDisplayIndex(i, false));
					}
				}
			}
			this.StartGridIndex = startGridIndex;
			this.EndGridIndex = endGridIndex;
			for (int j = startGridIndex; j <= endGridIndex; j++)
			{
				if (j >= 0 && j < this.GridNum)
				{
					if (displayGridNum == 0 || num == 0)
					{
						this.OnGridUpdate(j);
					}
					else
					{
						int num4 = j % displayGridNum;
						int num5 = j % num;
						if (startGridIndex2 < 0 || j < startGridIndex2 || j > endGridIndex2 || num4 != num5)
						{
							this.OnGridUpdate(j);
						}
					}
				}
			}
		}

		// Token: 0x0602577E RID: 153470 RVA: 0x00A8DCFC File Offset: 0x00A8BEFC
		private void OnGridUpdate(int gridIndex)
		{
			int gridDisplayIndex = this.GetGridDisplayIndex(gridIndex, false);
			this.Delegate.OnGridsUpdate(gridIndex, gridDisplayIndex, this.StartGridIndex, this.EndGridIndex);
		}

		// Token: 0x0602577F RID: 153471 RVA: 0x00A8DD2C File Offset: 0x00A8BF2C
		private unsafe int GetGridDisplayIndex(int gridIndex, bool logError = false)
		{
			if (this.StartGridIndex < 0 || this.DisplayGridNum <= 0)
			{
				if (logError)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.LoopScrollView;
					ELogAuthor author = ELogAuthor.TL;
					string message = "GetGridDisplayIndex: 未初始化";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("this.StartGridIndex", this.StartGridIndex);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("this.DisplayGridNum", this.DisplayGridNum);
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				}
				return -1;
			}
			if (gridIndex < this.StartGridIndex || gridIndex >= this.StartGridIndex + this.DisplayGridNum)
			{
				if (logError)
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.LoopScrollView;
					ELogAuthor author2 = ELogAuthor.TL;
					string message2 = "GetGridDisplayIndex: 未处于展示中";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("gridIndex", gridIndex);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("this.StartGridIndex", this.StartGridIndex);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("this.StartGridIndex + this.DisplayGridNum", this.StartGridIndex + this.DisplayGridNum);
					instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
				}
				return -1;
			}
			return gridIndex % this.DisplayGridNum;
		}

		// Token: 0x06025780 RID: 153472 RVA: 0x00A8DE70 File Offset: 0x00A8C070
		private void OnDestroy(AActor actor)
		{
			(this.TargetScroll.GetOwner() as AUIBaseActor).OnPreDestroyed.Remove(new Action<AActor>(this.OnDestroy));
			this.TargetScroll.OnDestroyCallBack.Unbind();
			this.TargetScroll.OnGridsUpdate.Unbind();
			this.TargetScroll.OnGridCreate.Unbind();
			GridAppearAnimationBase gridsController = this.GridsController;
			if (gridsController != null)
			{
				gridsController.Clear();
			}
			this.Delegate.Destroy();
		}

		// Token: 0x06025781 RID: 153473 RVA: 0x00A8DEEF File Offset: 0x00A8C0EF
		public void BindOnScrollValueChanged(Action<FVector2D> callback)
		{
			this.TargetScroll.OnScrollValueChange.Bind(callback);
		}

		// Token: 0x06025782 RID: 153474 RVA: 0x00A8DF04 File Offset: 0x00A8C104
		[return: Nullable(2)]
		public UUIItem GetGridAndScrollToByJudge(object targetData, Func<object, TData, bool> judge, bool playGridAnim = true)
		{
			if (!this.DataInited)
			{
				return null;
			}
			int num = 0;
			bool flag = false;
			foreach (TData arg in this.Delegate.GetDatas())
			{
				if (judge(targetData, arg))
				{
					flag = true;
					break;
				}
				num++;
			}
			if (!flag)
			{
				num = 0;
			}
			this.ScrollToGridIndex(num, playGridAnim);
			return this.GetGrid(num);
		}

		// Token: 0x06025783 RID: 153475 RVA: 0x00A8DF84 File Offset: 0x00A8C184
		public void ScrollToNextLine(bool bReversed = true)
		{
			this.TargetScroll.ScrollToNextLine(bReversed);
		}

		// Token: 0x06025784 RID: 153476 RVA: 0x00A8DF92 File Offset: 0x00A8C192
		public void SetTargetRootComponentActive(bool value)
		{
			this.TargetScroll.GetRootComponent().SetUIActive(value);
		}

		// Token: 0x06025785 RID: 153477 RVA: 0x00A8DFA5 File Offset: 0x00A8C1A5
		public void ResetGridController()
		{
			if (this.GridsController != null)
			{
				this.GridsController.PlayGridAnim(this.DisplayGridNum, true);
			}
		}

		// Token: 0x06025786 RID: 153478 RVA: 0x00A8DFC4 File Offset: 0x00A8C1C4
		public void ScrollToDisplayingIndex(int displayIndex)
		{
			UUIItem gridByDisplayIndex = this.GetGridByDisplayIndex(displayIndex);
			if (gridByDisplayIndex != null)
			{
				this.TargetScroll.ScrollTo(gridByDisplayIndex, false);
			}
		}

		// Token: 0x06025787 RID: 153479 RVA: 0x00A8DFE9 File Offset: 0x00A8C1E9
		public UUIInturnAnimController GetUiAnimController()
		{
			UUILoopScrollViewComponent targetScroll = this.TargetScroll;
			AUIBaseActor auibaseActor = (targetScroll != null) ? targetScroll.GetContent() : null;
			return ((auibaseActor != null) ? auibaseActor.GetComponentByClass(UUIInturnAnimController.StaticClass()) : null) as UUIInturnAnimController;
		}

		// Token: 0x06025788 RID: 153480 RVA: 0x00A8E018 File Offset: 0x00A8C218
		public int GetDisplayGridEndIndexPurely()
		{
			if (this.LineCount == -1)
			{
				UUILoopScrollViewComponent targetScroll = this.TargetScroll;
				float? num;
				if (targetScroll == null)
				{
					num = null;
				}
				else
				{
					AUIBaseActor viewport = targetScroll.GetViewport();
					if (viewport == null)
					{
						num = null;
					}
					else
					{
						UUIItem uiitem = viewport.GetUIItem();
						num = ((uiitem != null) ? new float?(uiitem.GetHeight()) : null);
					}
				}
				float? num2 = num;
				float valueOrDefault = num2.GetValueOrDefault();
				UUILoopScrollViewComponent targetScroll2 = this.TargetScroll;
				float num3 = (targetScroll2 != null) ? targetScroll2.PaddingVertical : 0f;
				UUILoopScrollViewComponent targetScroll3 = this.TargetScroll;
				float num4 = (targetScroll3 != null) ? targetScroll3.SpacingVertical : 0f;
				float num5 = 0f;
				UUILoopScrollViewComponent targetScroll4 = this.TargetScroll;
				bool flag;
				if (targetScroll4 == null)
				{
					flag = false;
				}
				else
				{
					TWeakObjectPtr<AUIBaseActor> templateGrid = targetScroll4.TemplateGrid;
					flag = true;
				}
				if (flag)
				{
					UUIItem uiitem2 = this.TargetScroll.TemplateGrid.Get().GetUIItem();
					num5 = ((uiitem2 != null) ? uiitem2.GetHeight() : 0f);
				}
				if (num5 + num4 != 0f)
				{
					this.LineCount = (int)Math.Ceiling((double)((valueOrDefault - 2f * num3 + num4) / (num5 + num4)));
				}
			}
			return this.StartGridIndex + this.LineCount - 1;
		}

		// Token: 0x04014B67 RID: 84839
		public const bool IS_DEBUG = false;

		// Token: 0x04014B68 RID: 84840
		[Nullable(2)]
		private readonly UUILoopScrollViewComponent TargetScroll;

		// Token: 0x04014B69 RID: 84841
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private readonly ScrollViewDelegate<TProxy, TData> Delegate;

		// Token: 0x04014B6A RID: 84842
		[Nullable(2)]
		private readonly GridAppearAnimationBase GridsController;

		// Token: 0x04014B6B RID: 84843
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		private readonly List<UniTask<TProxy>> TempGridCreatePromiseList = new List<UniTask<TProxy>>();

		// Token: 0x04014B6C RID: 84844
		private int GridNum;

		// Token: 0x04014B6D RID: 84845
		private int PrivateStartGridIndex = -1;

		// Token: 0x04014B6E RID: 84846
		private int PrivateEndGridIndex = -1;

		// Token: 0x04014B6F RID: 84847
		[Nullable(2)]
		private readonly AUIBaseActor TemplateGridActor;

		// Token: 0x04014B70 RID: 84848
		private bool DataInitedInternal;

		// Token: 0x04014B71 RID: 84849
		private bool Operating;

		// Token: 0x04014B72 RID: 84850
		private readonly Queue<OperationParam<TData>> OperationQueue = new Queue<OperationParam<TData>>(4);

		// Token: 0x04014B73 RID: 84851
		private Action AnimFinishDelegate;

		// Token: 0x04014B74 RID: 84852
		private bool IsInRefreshAsync;

		// Token: 0x04014B75 RID: 84853
		private int LineCount = -1;
	}
}
