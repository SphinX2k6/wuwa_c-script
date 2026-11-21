using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020014E2 RID: 5346
[NullableContext(1)]
[Nullable(0)]
public class ListSliderControl<[Nullable(0)] T> where T : SliderItem
{
	// Token: 0x0600D5EA RID: 54762 RVA: 0x003F7968 File Offset: 0x003F5B68
	public ListSliderControl(IListSliderControlData<T> data)
	{
		this.Data = data;
		if (data == null)
		{
			return;
		}
		this.ParentUiItem = data.ParentUi;
		if (!string.IsNullOrEmpty(data.ChildResourceId))
		{
			this.ResourceId = data.ChildResourceId;
		}
		else if (data.ChildTemplate != null)
		{
			this.ChildTemplate = data.ChildTemplate;
		}
		else
		{
			this.ChildTemplate = data.ParentUi.GetAttachUIChild(0);
		}
		if (this.ChildTemplate != null)
		{
			UUIItem childTemplate = this.ChildTemplate;
			if (childTemplate != null)
			{
				childTemplate.SetUIActive(false);
			}
			this.ChildHeight = this.ChildTemplate.GetHeight();
		}
		this.LastActiveStatus = data.ParentUi.IsUIActiveInHierarchy();
		this.Layout = (data.ParentUi.GetOwner().GetComponentByClass(UUIVerticalLayout.StaticClass()) as UUIVerticalLayout);
		this.SliderMode = data.SliderMode.GetValueOrDefault(ESliderMode.SliderWhenPlayEndFinish);
		this.TickItemMode = data.TickMode.GetValueOrDefault();
		this.LastMaxCount = data.MaxShowCount.GetValueOrDefault(8);
		this.OffsetIndex = 0;
	}

	// Token: 0x0600D5EB RID: 54763 RVA: 0x003F7A9C File Offset: 0x003F5C9C
	public void SetDynamicLoadResourceId(string resourceId)
	{
		this.ResourceId = resourceId;
	}

	// Token: 0x0600D5EC RID: 54764 RVA: 0x003F7AA8 File Offset: 0x003F5CA8
	public void DisEnableParentLayout()
	{
		if (this.ParentUiItem == null)
		{
			Log.Instance.Error(ELogModule.ItemHint, ELogAuthor.ZJC, "ListSliderControl错误, ParentUiItem为null", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (this.Layout == null)
		{
			Log.Instance.Error(ELogModule.ItemHint, ELogAuthor.ZJC, "ListSliderControl错误, 父节点不包含UIVerticalLayout组件", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.Layout.SetEnable(false);
	}

	// Token: 0x0600D5ED RID: 54765 RVA: 0x003F7B0C File Offset: 0x003F5D0C
	public void Tick(float delta)
	{
		this.UpdateLastActiveStatus();
		this.UpdateLastMaxCount();
		if (!this.LastActiveStatus)
		{
			return;
		}
		if (this.ChildrenList.Count <= 0 && !this.CheckNext())
		{
			if (this.IsFinish)
			{
				return;
			}
			this.IsFinish = true;
			IListSliderControlData<T> data = this.Data;
			if (data == null)
			{
				return;
			}
			Action finishCallback = data.FinishCallback;
			if (finishCallback == null)
			{
				return;
			}
			finishCallback();
			return;
		}
		else
		{
			if (this.IsFinish)
			{
				this.IsFinish = false;
			}
			float num = delta;
			if (num > 20f)
			{
				num = 20f;
			}
			int num2 = 0;
			for (int i = 0; i < this.ChildrenList.Count; i++)
			{
				T t = this.ChildrenList[i];
				this.UpdateItemPosition(t, i);
				this.SliderItemTick(t, num, i);
				if (this.SliderMode != ESliderMode.SliderWhenPlayEnd || t.Status < EStatus.Over)
				{
					num2++;
				}
			}
			this.UpdateSliderProcess(num);
			this.RecycleItem();
			if (num2 > this.LastMaxCount)
			{
				return;
			}
			if (this.ShowItemCount != num2)
			{
				this.ShowItemCount = num2;
				this.SetParentHeight();
			}
			if (this.LoadState == EItemLoadState.Loading && this.NextItemAddTime > 2000f)
			{
				this.CacheItem.Status = EStatus.Destroy;
				this.CacheItem = default(T);
				this.LoadState = EItemLoadState.None;
				this.NextItemAddTime = 0f;
			}
			if (this.CheckNext())
			{
				float addItemTime = this.GetAddItemTime();
				if (this.NextItemAddTime >= addItemTime && this.LoadState == EItemLoadState.Loaded)
				{
					if (this.CacheItem != null)
					{
						this.CacheItem.SetActive(true);
						this.CacheItem.Play();
						this.CacheItem = default(T);
					}
					this.NextItemAddTime = 0f;
					this.LoadState = EItemLoadState.None;
				}
				if (this.LoadState == EItemLoadState.None)
				{
					this.LoadState = EItemLoadState.Loading;
					this.GetNewItem().ContinueWith(delegate(T item)
					{
						this.CacheItem = item;
						try
						{
							this.CacheItem.AsyncLoadUiResource().ContinueWith(delegate()
							{
								if (this.CacheItem == null)
								{
									return;
								}
								this.CacheItem.InitData();
								this.CacheItem.SetActive(false);
								this.LoadState = EItemLoadState.Loaded;
							});
						}
						catch (Exception item2)
						{
							this.CacheItem.Status = EStatus.Destroy;
							this.CacheItem = default(T);
							this.LoadState = EItemLoadState.None;
							this.NextItemAddTime = 0f;
							Log instance = Log.Instance;
							ELogModule module = ELogModule.ItemHint;
							ELogAuthor author = ELogAuthor.XXJ;
							string message = "[ListSliderControl::Tick]异步加载格子失败,到None";
							ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Exception", item2);
							instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
						}
					});
				}
				this.NextItemAddTime += num;
				return;
			}
			if (this.LoadState == EItemLoadState.Loading)
			{
				this.NextItemAddTime += num;
				return;
			}
			if (this.LoadState == EItemLoadState.Loaded)
			{
				Log.Instance.Info(ELogModule.ItemHint, ELogAuthor.XXJ, "[ListSliderControl::Tick]检查不到下个对象,执行缓存对象逻辑,到None", default(ReadOnlySpan<ValueTuple<string, object>>));
				this.CacheItem.SetActive(true);
				this.CacheItem.Play();
				this.CacheItem = default(T);
				this.LoadState = EItemLoadState.None;
				this.NextItemAddTime = 0f;
			}
			return;
		}
	}

	// Token: 0x0600D5EE RID: 54766 RVA: 0x003F7D74 File Offset: 0x003F5F74
	private void UpdateLastActiveStatus()
	{
		bool flag = this.ParentUiItem.IsUIActiveInHierarchy();
		if (flag != this.LastActiveStatus)
		{
			this.LastActiveStatus = flag;
			foreach (T t in this.ChildrenList)
			{
				t.ActiveStatusChange(flag);
			}
		}
	}

	// Token: 0x0600D5EF RID: 54767 RVA: 0x003F7DE8 File Offset: 0x003F5FE8
	private void UpdateLastMaxCount()
	{
		int maxShowCount = this.GetMaxShowCount();
		if (maxShowCount != this.LastMaxCount)
		{
			Log.Instance.Info(ELogModule.ItemHint, ELogAuthor.XXJ, "[ListSliderControl::Tick]最大数量发生变化", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.LastMaxCount = maxShowCount;
			if (this.GetAddItemTime() == 0f)
			{
				foreach (T t in this.ChildrenList)
				{
					t.AddShowTime = 0f;
				}
			}
		}
	}

	// Token: 0x0600D5F0 RID: 54768 RVA: 0x003F7E84 File Offset: 0x003F6084
	private void UpdateItemPosition(T sliderItem, int index)
	{
		UUIItem rootItem = sliderItem.GetRootItem();
		float anchorOffsetY = -this.NeedSliderHeight - this.Layout.Padding.Top - this.ChildHeight * 0.5f - (float)(index + this.OffsetIndex) * (this.ChildHeight + this.Layout.Spacing);
		rootItem.SetAnchorOffsetY(anchorOffsetY);
	}

	// Token: 0x0600D5F1 RID: 54769 RVA: 0x003F7EE8 File Offset: 0x003F60E8
	public void SliderItemTick(T sliderItem, float delta, int index)
	{
		sliderItem.Tick(delta);
		if (this.TickItemMode == ETickItemMode.TickOnlyTop && index != 0)
		{
			return;
		}
		if (sliderItem.Status == EStatus.Halfway)
		{
			ref T ptr = ref sliderItem;
			ptr.AddShowTime += delta;
		}
		if (this.SliderMode != ESliderMode.SliderWhenPlayEnd && index != 0)
		{
			return;
		}
		if (sliderItem.Status == EStatus.Finish)
		{
			sliderItem.Status = EStatus.Destroy;
			return;
		}
		if (sliderItem.Status == EStatus.Halfway && sliderItem.AddShowTime >= this.GetItemShowTime())
		{
			sliderItem.Status = EStatus.Over;
			sliderItem.PlayEnd();
			if (this.SliderMode == ESliderMode.SliderWhenPlayEnd)
			{
				this.OffsetIndex--;
				this.AddNeedSliderHeight();
			}
		}
	}

	// Token: 0x0600D5F2 RID: 54770 RVA: 0x003F7FB8 File Offset: 0x003F61B8
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	private UniTask<T> GetNewItem()
	{
		ListSliderControl<T>.<GetNewItem>d__28 <GetNewItem>d__;
		<GetNewItem>d__.<>t__builder = AsyncUniTaskMethodBuilder<T>.Create();
		<GetNewItem>d__.<>4__this = this;
		<GetNewItem>d__.<>1__state = -1;
		<GetNewItem>d__.<>t__builder.Start<ListSliderControl<T>.<GetNewItem>d__28>(ref <GetNewItem>d__);
		return <GetNewItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600D5F3 RID: 54771 RVA: 0x003F7FFC File Offset: 0x003F61FC
	private void UpdateSliderProcess(float delta)
	{
		if (this.NeedSliderHeight <= 0f)
		{
			return;
		}
		this.NeedSliderHeight -= this.ChildHeight / this.GetItemSliderTime() * delta;
		if (this.NeedSliderHeight > 0f)
		{
			return;
		}
		this.NeedSliderHeight = 0f;
	}

	// Token: 0x0600D5F4 RID: 54772 RVA: 0x003F804C File Offset: 0x003F624C
	private void RecycleItem()
	{
		List<T> childrenList = this.ChildrenList;
		while (childrenList.Count > 0)
		{
			T t = childrenList[0];
			if (t.Status != EStatus.Destroy)
			{
				return;
			}
			t.Status = EStatus.None;
			childrenList.RemoveAt(0);
			t.SetActive(false);
			this.ChildrenPool.Add(t);
			if (this.SliderMode == ESliderMode.SliderWhenPlayEndFinish)
			{
				this.AddNeedSliderHeight();
			}
			else if (this.SliderMode == ESliderMode.SliderWhenPlayEnd)
			{
				this.OffsetIndex++;
			}
		}
	}

	// Token: 0x0600D5F5 RID: 54773 RVA: 0x003F80D4 File Offset: 0x003F62D4
	private void AddNeedSliderHeight()
	{
		this.NeedSliderHeight += this.ChildHeight + this.Layout.Spacing;
	}

	// Token: 0x0600D5F6 RID: 54774 RVA: 0x003F80F8 File Offset: 0x003F62F8
	public void DestroyMe()
	{
		if (this.Layout != null)
		{
			this.Layout.SetEnable(true);
		}
		foreach (UiPoolActor uiPoolActor in this.PoolActorList)
		{
			UiActorPool.Instance.RecycleAsync(uiPoolActor, uiPoolActor.Path);
		}
		this.ChildrenPool = null;
	}

	// Token: 0x0600D5F7 RID: 54775 RVA: 0x003F8170 File Offset: 0x003F6370
	private void SetParentHeight()
	{
		this.ParentUiItem.SetHeight((float)this.ShowItemCount * this.ChildHeight);
	}

	// Token: 0x0600D5F8 RID: 54776 RVA: 0x003F818B File Offset: 0x003F638B
	private T CreateProxyFunction()
	{
		return this.Data.CreateProxyFunction();
	}

	// Token: 0x0600D5F9 RID: 54777 RVA: 0x003F819D File Offset: 0x003F639D
	private bool CheckNext()
	{
		return this.Data.CheckNext();
	}

	// Token: 0x0600D5FA RID: 54778 RVA: 0x003F81B0 File Offset: 0x003F63B0
	private int GetMaxShowCount()
	{
		IListSliderControlData<T> data = this.Data;
		return ((data != null) ? data.MaxShowCount : null).GetValueOrDefault(8);
	}

	// Token: 0x0600D5FB RID: 54779 RVA: 0x003F81E0 File Offset: 0x003F63E0
	private float GetAddItemTime()
	{
		IListSliderControlData<T> data = this.Data;
		return ((data != null) ? data.AddItemTime : null).GetValueOrDefault(100f);
	}

	// Token: 0x0600D5FC RID: 54780 RVA: 0x003F8214 File Offset: 0x003F6414
	private float GetItemSliderTime()
	{
		IListSliderControlData<T> data = this.Data;
		return ((data != null) ? data.ItemSliderTime : null).GetValueOrDefault(100f);
	}

	// Token: 0x0600D5FD RID: 54781 RVA: 0x003F8248 File Offset: 0x003F6448
	private float GetItemShowTime()
	{
		IListSliderControlData<T> data = this.Data;
		return ((data != null) ? data.ItemShowTime : null).GetValueOrDefault(2000f);
	}

	// Token: 0x040077FC RID: 30716
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private readonly IListSliderControlData<T> Data;

	// Token: 0x040077FD RID: 30717
	[Nullable(2)]
	private readonly UUIItem ParentUiItem;

	// Token: 0x040077FE RID: 30718
	[Nullable(2)]
	private readonly UUIVerticalLayout Layout;

	// Token: 0x040077FF RID: 30719
	[Nullable(2)]
	private readonly UUIItem ChildTemplate;

	// Token: 0x04007800 RID: 30720
	private float ChildHeight;

	// Token: 0x04007801 RID: 30721
	private float NeedSliderHeight;

	// Token: 0x04007802 RID: 30722
	private int OffsetIndex;

	// Token: 0x04007803 RID: 30723
	private bool LastActiveStatus;

	// Token: 0x04007804 RID: 30724
	public bool IsFinish;

	// Token: 0x04007805 RID: 30725
	private EItemLoadState LoadState;

	// Token: 0x04007806 RID: 30726
	private int ShowItemCount;

	// Token: 0x04007807 RID: 30727
	private int LastMaxCount;

	// Token: 0x04007808 RID: 30728
	private float NextItemAddTime;

	// Token: 0x04007809 RID: 30729
	private readonly ESliderMode SliderMode;

	// Token: 0x0400780A RID: 30730
	private readonly ETickItemMode TickItemMode;

	// Token: 0x0400780B RID: 30731
	[Nullable(2)]
	private T CacheItem;

	// Token: 0x0400780C RID: 30732
	[Nullable(2)]
	private string ResourceId;

	// Token: 0x0400780D RID: 30733
	private readonly List<T> ChildrenList = new List<T>();

	// Token: 0x0400780E RID: 30734
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<T> ChildrenPool = new List<T>();

	// Token: 0x0400780F RID: 30735
	private readonly List<UiPoolActor> PoolActorList = new List<UiPoolActor>();
}
