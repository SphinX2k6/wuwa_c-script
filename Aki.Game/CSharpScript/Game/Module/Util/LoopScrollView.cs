using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Util
{
	// Token: 0x020048DE RID: 18654
	[NullableContext(1)]
	[Nullable(0)]
	public class LoopScrollView<TProxy, [Nullable(2)] TData> : IGridPreserver where TProxy : class, IGridProxy<TData>
	{
		// Token: 0x17007993 RID: 31123
		// (get) Token: 0x06030C21 RID: 199713 RVA: 0x00B524F7 File Offset: 0x00B506F7
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

		// Token: 0x17007994 RID: 31124
		// (get) Token: 0x06030C22 RID: 199714 RVA: 0x00B52512 File Offset: 0x00B50712
		// (set) Token: 0x06030C23 RID: 199715 RVA: 0x00B5251A File Offset: 0x00B5071A
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

		// Token: 0x17007995 RID: 31125
		// (get) Token: 0x06030C24 RID: 199716 RVA: 0x00B52523 File Offset: 0x00B50723
		// (set) Token: 0x06030C25 RID: 199717 RVA: 0x00B5252B File Offset: 0x00B5072B
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

		// Token: 0x17007996 RID: 31126
		// (get) Token: 0x06030C26 RID: 199718 RVA: 0x00B52534 File Offset: 0x00B50734
		private bool IsEmpty
		{
			get
			{
				return this.EndGridIndex == -1 && this.StartGridIndex == -1;
			}
		}

		// Token: 0x17007997 RID: 31127
		// (get) Token: 0x06030C27 RID: 199719 RVA: 0x00B5254A File Offset: 0x00B5074A
		public bool DataInited
		{
			get
			{
				return this.DataInitedInternal;
			}
		}

		// Token: 0x17007998 RID: 31128
		// (get) Token: 0x06030C28 RID: 199720 RVA: 0x00B52552 File Offset: 0x00B50752
		private bool IsLock
		{
			get
			{
				return this.Operating;
			}
		}

		// Token: 0x06030C29 RID: 199721 RVA: 0x00B5255A File Offset: 0x00B5075A
		private void Lock()
		{
			this.Operating = true;
		}

		// Token: 0x06030C2A RID: 199722 RVA: 0x00B52564 File Offset: 0x00B50764
		private void Unlock()
		{
			this.Operating = false;
			if (this.OperationQueue.Size > 0)
			{
				OperationParam<TData> operationParam = this.OperationQueue.Pop();
				this.RefreshByData(operationParam.Data, operationParam.KeepContentPosition, operationParam.CallBack, operationParam.PlayGridAnim);
			}
		}

		// Token: 0x06030C2B RID: 199723 RVA: 0x00B525B0 File Offset: 0x00B507B0
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

		// Token: 0x06030C2C RID: 199724 RVA: 0x00B526C5 File Offset: 0x00B508C5
		public int GetDisplayGridNum()
		{
			return this.DisplayGridNum;
		}

		// Token: 0x06030C2D RID: 199725 RVA: 0x00B526CD File Offset: 0x00B508CD
		public int GetPreservedGridNum()
		{
			UUILoopScrollViewComponent targetScroll = this.TargetScroll;
			if (targetScroll == null)
			{
				return 0;
			}
			return targetScroll.GridArray.Num();
		}

		// Token: 0x06030C2E RID: 199726 RVA: 0x00B526E5 File Offset: 0x00B508E5
		public int GetDisplayGridStartIndex()
		{
			return this.StartGridIndex;
		}

		// Token: 0x06030C2F RID: 199727 RVA: 0x00B526ED File Offset: 0x00B508ED
		public int GetDisplayGridEndIndex()
		{
			return this.EndGridIndex;
		}

		// Token: 0x06030C30 RID: 199728 RVA: 0x00B526F5 File Offset: 0x00B508F5
		public float GetGridAnimationInterval()
		{
			return this.TargetScroll.GetGridAnimationInterval();
		}

		// Token: 0x06030C31 RID: 199729 RVA: 0x00B52702 File Offset: 0x00B50902
		public float GetGridAnimationStartTime()
		{
			return this.TargetScroll.GetGridAnimationStartTime();
		}

		// Token: 0x06030C32 RID: 199730 RVA: 0x00B5270F File Offset: 0x00B5090F
		public void NotifyAnimationStart()
		{
			this.TargetScroll.SetInAnimation(true);
		}

		// Token: 0x06030C33 RID: 199731 RVA: 0x00B5271D File Offset: 0x00B5091D
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

		// Token: 0x06030C34 RID: 199732 RVA: 0x00B5273B File Offset: 0x00B5093B
		public void SetAnimFinishDelegate(Action @delegate)
		{
			this.AnimFinishDelegate = @delegate;
		}

		// Token: 0x06030C35 RID: 199733 RVA: 0x00B52744 File Offset: 0x00B50944
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

		// Token: 0x06030C36 RID: 199734 RVA: 0x00B52760 File Offset: 0x00B50960
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

		// Token: 0x06030C37 RID: 199735 RVA: 0x00B527D8 File Offset: 0x00B509D8
		[NullableContext(2)]
		public TProxy UnsafeGetGridProxy(int gridIndex, bool logError = false)
		{
			int gridDisplayIndex = this.GetGridDisplayIndex(gridIndex, true);
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

		// Token: 0x06030C38 RID: 199736 RVA: 0x00B52866 File Offset: 0x00B50A66
		public void ReloadGrids(int length)
		{
			if (length == this.Delegate.GetDataLength())
			{
				return;
			}
			this.UpdateDataInternal(length, false);
		}

		// Token: 0x06030C39 RID: 199737 RVA: 0x00B5287F File Offset: 0x00B50A7F
		[Obsolete("请使用RefreshByData或 RefreshByDataAsync")]
		public void ReloadProxyData(Func<int, TData> dataProxyFunction, int dataLength, bool cacheData = true, bool keepContentPosition = false)
		{
			this.Delegate.ClearSelectInfo();
			this.Delegate.SetDataProxy(dataProxyFunction, dataLength, cacheData);
			this.UpdateDataInternal(dataLength, keepContentPosition);
		}

		// Token: 0x06030C3A RID: 199738 RVA: 0x00B528A4 File Offset: 0x00B50AA4
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

		// Token: 0x06030C3B RID: 199739 RVA: 0x00B52908 File Offset: 0x00B50B08
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

		// Token: 0x06030C3C RID: 199740 RVA: 0x00B5299C File Offset: 0x00B50B9C
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

		// Token: 0x06030C3D RID: 199741 RVA: 0x00B529D0 File Offset: 0x00B50BD0
		public void RefreshGridProxy(int gridIndex)
		{
			if (gridIndex >= this.StartGridIndex && gridIndex <= this.EndGridIndex)
			{
				int gridDisplayIndex = this.GetGridDisplayIndex(gridIndex, false);
				this.Delegate.RefreshGridProxy(gridIndex, gridDisplayIndex);
			}
		}

		// Token: 0x06030C3E RID: 199742 RVA: 0x00B52A08 File Offset: 0x00B50C08
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

		// Token: 0x06030C3F RID: 199743 RVA: 0x00B52A54 File Offset: 0x00B50C54
		public void ClearSelectInfo()
		{
			this.Delegate.ClearSelectInfo();
		}

		// Token: 0x06030C40 RID: 199744 RVA: 0x00B52A61 File Offset: 0x00B50C61
		public TData TryGetCachedData(int gridIndex)
		{
			return this.Delegate.TryGetCachedData(gridIndex);
		}

		// Token: 0x06030C41 RID: 199745 RVA: 0x00B52A6F File Offset: 0x00B50C6F
		public void SelectGridProxy(int gridIndex, bool fireEvent = false)
		{
			this.Delegate.SelectGridProxy(gridIndex, this.GetGridDisplayIndex(gridIndex, false), fireEvent);
		}

		// Token: 0x06030C42 RID: 199746 RVA: 0x00B52A86 File Offset: 0x00B50C86
		public void DeselectCurrentGridProxy(bool fireEvent = false)
		{
			this.Delegate.DeselectCurrentGridProxy(fireEvent);
		}

		// Token: 0x06030C43 RID: 199747 RVA: 0x00B52A94 File Offset: 0x00B50C94
		public int GetSelectedGridIndex()
		{
			return this.Delegate.GetSelectedGridIndex();
		}

		// Token: 0x06030C44 RID: 199748 RVA: 0x00B52AA1 File Offset: 0x00B50CA1
		public void BindLateUpdate(Action<float> callBack)
		{
			this.TargetScroll.OnLateUpdate.Bind(callBack);
		}

		// Token: 0x06030C45 RID: 199749 RVA: 0x00B52AB4 File Offset: 0x00B50CB4
		public void UnBindLateUpdate()
		{
			this.TargetScroll.OnLateUpdate.Unbind();
		}

		// Token: 0x06030C46 RID: 199750 RVA: 0x00B52AC8 File Offset: 0x00B50CC8
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

		// Token: 0x06030C47 RID: 199751 RVA: 0x00B52B68 File Offset: 0x00B50D68
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

		// Token: 0x06030C48 RID: 199752 RVA: 0x00B52BD0 File Offset: 0x00B50DD0
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

		// Token: 0x06030C49 RID: 199753 RVA: 0x00B52C2C File Offset: 0x00B50E2C
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

		// Token: 0x06030C4A RID: 199754 RVA: 0x00B52C80 File Offset: 0x00B50E80
		public bool IsGridDisplaying(int gridIndex)
		{
			int gridDisplayIndex = this.GetGridDisplayIndex(gridIndex, false);
			return gridDisplayIndex >= 0 && gridDisplayIndex < this.DisplayGridNum;
		}

		// Token: 0x06030C4B RID: 199755 RVA: 0x00B52CA5 File Offset: 0x00B50EA5
		public void ScrollToGridIndex(int gridIndex, bool playGridAnim = true)
		{
			this.TargetScroll.ScrollToGridIndex(gridIndex, false);
			if (playGridAnim)
			{
				this.ResetGridController();
			}
		}

		// Token: 0x06030C4C RID: 199756 RVA: 0x00B52CBD File Offset: 0x00B50EBD
		public void ScrollToGridIndexLate(int gridIndex, bool playGridAnim = true)
		{
			this.TargetScroll.ScrollToGridIndexLater(gridIndex, false);
			if (playGridAnim)
			{
				this.ResetGridController();
			}
		}

		// Token: 0x06030C4D RID: 199757 RVA: 0x00B52CD5 File Offset: 0x00B50ED5
		public void ScrollToGridIndexWithTween(int gridIndex, bool playGridAnim = true)
		{
			this.TargetScroll.ScrollToGridIndex(gridIndex, true);
			if (playGridAnim)
			{
				this.ResetGridController();
			}
		}

		// Token: 0x06030C4E RID: 199758 RVA: 0x00B52CED File Offset: 0x00B50EED
		[NullableContext(2)]
		private void OnGridCreate(int displayIndex, AUIBaseActor actor)
		{
			this.Delegate.CreateGridProxy(displayIndex, actor);
		}

		// Token: 0x06030C4F RID: 199759 RVA: 0x00B52D00 File Offset: 0x00B50F00
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

		// Token: 0x06030C50 RID: 199760 RVA: 0x00B52D78 File Offset: 0x00B50F78
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

		// Token: 0x06030C51 RID: 199761 RVA: 0x00B52E8C File Offset: 0x00B5108C
		private void OnGridUpdate(int gridIndex)
		{
			int gridDisplayIndex = this.GetGridDisplayIndex(gridIndex, false);
			this.Delegate.OnGridsUpdate(gridIndex, gridDisplayIndex, this.StartGridIndex, this.EndGridIndex);
		}

		// Token: 0x06030C52 RID: 199762 RVA: 0x00B52EBC File Offset: 0x00B510BC
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

		// Token: 0x06030C53 RID: 199763 RVA: 0x00B53000 File Offset: 0x00B51200
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

		// Token: 0x06030C54 RID: 199764 RVA: 0x00B5307F File Offset: 0x00B5127F
		public void BindOnScrollValueChanged(Action<FVector2D> callback)
		{
			this.TargetScroll.OnScrollValueChange.Bind(callback);
		}

		// Token: 0x06030C55 RID: 199765 RVA: 0x00B53094 File Offset: 0x00B51294
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

		// Token: 0x06030C56 RID: 199766 RVA: 0x00B53114 File Offset: 0x00B51314
		public void ScrollToNextLine(bool bReversed = true)
		{
			this.TargetScroll.ScrollToNextLine(bReversed);
		}

		// Token: 0x06030C57 RID: 199767 RVA: 0x00B53122 File Offset: 0x00B51322
		public void SetTargetRootComponentActive(bool value)
		{
			this.TargetScroll.GetRootComponent().SetUIActive(value);
		}

		// Token: 0x06030C58 RID: 199768 RVA: 0x00B53135 File Offset: 0x00B51335
		public void ResetGridController()
		{
			if (this.GridsController != null)
			{
				this.GridsController.PlayGridAnim(this.DisplayGridNum, true);
			}
		}

		// Token: 0x06030C59 RID: 199769 RVA: 0x00B53154 File Offset: 0x00B51354
		public void ScrollToDisplayingIndex(int displayIndex)
		{
			UUIItem gridByDisplayIndex = this.GetGridByDisplayIndex(displayIndex);
			if (gridByDisplayIndex != null)
			{
				this.TargetScroll.ScrollTo(gridByDisplayIndex, false);
			}
		}

		// Token: 0x06030C5A RID: 199770 RVA: 0x00B53179 File Offset: 0x00B51379
		public UUIInturnAnimController GetUiAnimController()
		{
			UUILoopScrollViewComponent targetScroll = this.TargetScroll;
			AUIBaseActor auibaseActor = (targetScroll != null) ? targetScroll.GetContent() : null;
			return ((auibaseActor != null) ? auibaseActor.GetComponentByClass(UUIInturnAnimController.StaticClass()) : null) as UUIInturnAnimController;
		}

		// Token: 0x06030C5B RID: 199771 RVA: 0x00B531A8 File Offset: 0x00B513A8
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

		// Token: 0x0401A2F4 RID: 107252
		public const bool IS_DEBUG = false;

		// Token: 0x0401A2F5 RID: 107253
		[Nullable(2)]
		private readonly UUILoopScrollViewComponent TargetScroll;

		// Token: 0x0401A2F6 RID: 107254
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private readonly ScrollViewDelegate<TProxy, TData> Delegate;

		// Token: 0x0401A2F7 RID: 107255
		[Nullable(2)]
		private readonly GridAppearAnimationBase GridsController;

		// Token: 0x0401A2F8 RID: 107256
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		private readonly List<UniTask<TProxy>> TempGridCreatePromiseList = new List<UniTask<TProxy>>();

		// Token: 0x0401A2F9 RID: 107257
		private int GridNum;

		// Token: 0x0401A2FA RID: 107258
		private int PrivateStartGridIndex = -1;

		// Token: 0x0401A2FB RID: 107259
		private int PrivateEndGridIndex = -1;

		// Token: 0x0401A2FC RID: 107260
		[Nullable(2)]
		private readonly AUIBaseActor TemplateGridActor;

		// Token: 0x0401A2FD RID: 107261
		private bool DataInitedInternal;

		// Token: 0x0401A2FE RID: 107262
		private bool Operating;

		// Token: 0x0401A2FF RID: 107263
		private readonly Queue<OperationParam<TData>> OperationQueue = new Queue<OperationParam<TData>>(4);

		// Token: 0x0401A300 RID: 107264
		private Action AnimFinishDelegate;

		// Token: 0x0401A301 RID: 107265
		private bool IsInRefreshAsync;

		// Token: 0x0401A302 RID: 107266
		private int LineCount = -1;
	}
}
