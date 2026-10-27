using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200200F RID: 8207
[NullableContext(1)]
[Nullable(0)]
public class ListSliderControl<[Nullable(0)] T> where T : SliderItem
{
	// Token: 0x06010182 RID: 65922 RVA: 0x003EB370 File Offset: 0x003E9570
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

	// Token: 0x06010183 RID: 65923 RVA: 0x003EB4A4 File Offset: 0x003E96A4
	public void SetDynamicLoadResourceId(string resourceId)
	{
		this.ResourceId = resourceId;
	}

	// Token: 0x06010184 RID: 65924 RVA: 0x003EB4B0 File Offset: 0x003E96B0
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

	// Token: 0x06010185 RID: 65925 RVA: 0x003EB514 File Offset: 0x003E9714
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

	// Token: 0x06010186 RID: 65926 RVA: 0x003EB77C File Offset: 0x003E997C
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

	// Token: 0x06010187 RID: 65927 RVA: 0x003EB7F0 File Offset: 0x003E99F0
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

	// Token: 0x06010188 RID: 65928 RVA: 0x003EB88C File Offset: 0x003E9A8C
	private void UpdateItemPosition(T sliderItem, int index)
	{
		UUIItem rootItem = sliderItem.GetRootItem();
		float anchorOffsetY = -this.NeedSliderHeight - this.Layout.Padding.Top - this.ChildHeight * 0.5f - (float)(index + this.OffsetIndex) * (this.ChildHeight + this.Layout.Spacing);
		rootItem.SetAnchorOffsetY(anchorOffsetY);
	}

	// Token: 0x06010189 RID: 65929 RVA: 0x003EB8F0 File Offset: 0x003E9AF0
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

	// Token: 0x0601018A RID: 65930 RVA: 0x003EB9C0 File Offset: 0x003E9BC0
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

	// Token: 0x0601018B RID: 65931 RVA: 0x003EBA04 File Offset: 0x003E9C04
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

	// Token: 0x0601018C RID: 65932 RVA: 0x003EBA54 File Offset: 0x003E9C54
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

	// Token: 0x0601018D RID: 65933 RVA: 0x003EBADC File Offset: 0x003E9CDC
	private void AddNeedSliderHeight()
	{
		this.NeedSliderHeight += this.ChildHeight + this.Layout.Spacing;
	}

	// Token: 0x0601018E RID: 65934 RVA: 0x003EBB00 File Offset: 0x003E9D00
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

	// Token: 0x0601018F RID: 65935 RVA: 0x003EBB78 File Offset: 0x003E9D78
	private void SetParentHeight()
	{
		this.ParentUiItem.SetHeight((float)this.ShowItemCount * this.ChildHeight);
	}

	// Token: 0x06010190 RID: 65936 RVA: 0x003EBB93 File Offset: 0x003E9D93
	private T CreateProxyFunction()
	{
		return this.Data.CreateProxyFunction();
	}

	// Token: 0x06010191 RID: 65937 RVA: 0x003EBBA5 File Offset: 0x003E9DA5
	private bool CheckNext()
	{
		return this.Data.CheckNext();
	}

	// Token: 0x06010192 RID: 65938 RVA: 0x003EBBB8 File Offset: 0x003E9DB8
	private int GetMaxShowCount()
	{
		IListSliderControlData<T> data = this.Data;
		return ((data != null) ? data.MaxShowCount : null).GetValueOrDefault(8);
	}

	// Token: 0x06010193 RID: 65939 RVA: 0x003EBBE8 File Offset: 0x003E9DE8
	private float GetAddItemTime()
	{
		IListSliderControlData<T> data = this.Data;
		return ((data != null) ? data.AddItemTime : null).GetValueOrDefault(100f);
	}

	// Token: 0x06010194 RID: 65940 RVA: 0x003EBC1C File Offset: 0x003E9E1C
	private float GetItemSliderTime()
	{
		IListSliderControlData<T> data = this.Data;
		return ((data != null) ? data.ItemSliderTime : null).GetValueOrDefault(100f);
	}

	// Token: 0x06010195 RID: 65941 RVA: 0x003EBC50 File Offset: 0x003E9E50
	private float GetItemShowTime()
	{
		IListSliderControlData<T> data = this.Data;
		return ((data != null) ? data.ItemShowTime : null).GetValueOrDefault(2000f);
	}

	// Token: 0x04007713 RID: 30483
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private readonly IListSliderControlData<T> Data;

	// Token: 0x04007714 RID: 30484
	[Nullable(2)]
	private readonly UUIItem ParentUiItem;

	// Token: 0x04007715 RID: 30485
	[Nullable(2)]
	private readonly UUIVerticalLayout Layout;

	// Token: 0x04007716 RID: 30486
	[Nullable(2)]
	private readonly UUIItem ChildTemplate;

	// Token: 0x04007717 RID: 30487
	private float ChildHeight;

	// Token: 0x04007718 RID: 30488
	private float NeedSliderHeight;

	// Token: 0x04007719 RID: 30489
	private int OffsetIndex;

	// Token: 0x0400771A RID: 30490
	private bool LastActiveStatus;

	// Token: 0x0400771B RID: 30491
	public bool IsFinish;

	// Token: 0x0400771C RID: 30492
	private EItemLoadState LoadState;

	// Token: 0x0400771D RID: 30493
	private int ShowItemCount;

	// Token: 0x0400771E RID: 30494
	private int LastMaxCount;

	// Token: 0x0400771F RID: 30495
	private float NextItemAddTime;

	// Token: 0x04007720 RID: 30496
	private readonly ESliderMode SliderMode;

	// Token: 0x04007721 RID: 30497
	private readonly ETickItemMode TickItemMode;

	// Token: 0x04007722 RID: 30498
	[Nullable(2)]
	private T CacheItem;

	// Token: 0x04007723 RID: 30499
	[Nullable(2)]
	private string ResourceId;

	// Token: 0x04007724 RID: 30500
	private readonly List<T> ChildrenList = new List<T>();

	// Token: 0x04007725 RID: 30501
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<T> ChildrenPool = new List<T>();

	// Token: 0x04007726 RID: 30502
	private readonly List<UiPoolActor> PoolActorList = new List<UiPoolActor>();
}
