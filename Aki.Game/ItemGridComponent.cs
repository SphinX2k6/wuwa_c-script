using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020018B7 RID: 6327
[NullableContext(2)]
[Nullable(0)]
public class ItemGridComponent : UiPanelBase
{
	// Token: 0x0600B95A RID: 47450 RVA: 0x002A0C0F File Offset: 0x0029EE0F
	[NullableContext(1)]
	public void Initialize(UUIItem parentItem, bool useFixedAsync)
	{
		if (this.IsInitialized)
		{
			return;
		}
		this.ParentItem = parentItem;
		this.ResourceId = this.GetResourceId();
		this.UseFixedAsync = useFixedAsync;
		this.OnInitialize();
		this.IsInitialized = true;
	}

	// Token: 0x0600B95B RID: 47451 RVA: 0x002A0C44 File Offset: 0x0029EE44
	[return: Nullable(new byte[]
	{
		0,
		2
	})]
	public UniTask<ItemGridComponent> Load()
	{
		ItemGridComponent.<Load>d__9 <Load>d__;
		<Load>d__.<>t__builder = AsyncUniTaskMethodBuilder<ItemGridComponent>.Create();
		<Load>d__.<>4__this = this;
		<Load>d__.<>1__state = -1;
		<Load>d__.<>t__builder.Start<ItemGridComponent.<Load>d__9>(ref <Load>d__);
		return <Load>d__.<>t__builder.Task;
	}

	// Token: 0x0600B95C RID: 47452 RVA: 0x002A0C88 File Offset: 0x0029EE88
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	public UniTask<ItemGridComponent> GetAsync()
	{
		ItemGridComponent.<GetAsync>d__10 <GetAsync>d__;
		<GetAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<ItemGridComponent>.Create();
		<GetAsync>d__.<>4__this = this;
		<GetAsync>d__.<>1__state = -1;
		<GetAsync>d__.<>t__builder.Start<ItemGridComponent.<GetAsync>d__10>(ref <GetAsync>d__);
		return <GetAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600B95D RID: 47453 RVA: 0x002A0CCB File Offset: 0x0029EECB
	protected override void OnStartImplement()
	{
		this.IsBegin = true;
		this.OnActivate();
		if (this.Params != null)
		{
			this.OnRefresh(this.Params);
		}
	}

	// Token: 0x0600B95E RID: 47454 RVA: 0x002A0CEE File Offset: 0x0029EEEE
	public void Refresh(object @params = null)
	{
		this.Params = @params;
		if (base.IsCreateOrCreating)
		{
			return;
		}
		if (this.UseFixedAsync)
		{
			if (this.Params != null)
			{
				this.OnRefresh(this.Params);
			}
			return;
		}
		this.OnRefresh(@params);
	}

	// Token: 0x0600B95F RID: 47455 RVA: 0x002A0D24 File Offset: 0x0029EF24
	protected override void OnBeforeDestroyImplement()
	{
		if (this.IsBegin)
		{
			this.OnDeactivate();
		}
		this.IsBegin = false;
		this.IsInitialized = false;
		this.Params = null;
	}

	// Token: 0x0600B960 RID: 47456 RVA: 0x002A0D49 File Offset: 0x0029EF49
	protected virtual void OnInitialize()
	{
	}

	// Token: 0x0600B961 RID: 47457 RVA: 0x002A0D4B File Offset: 0x0029EF4B
	protected virtual void OnActivate()
	{
	}

	// Token: 0x0600B962 RID: 47458 RVA: 0x002A0D4D File Offset: 0x0029EF4D
	protected virtual void OnDeactivate()
	{
	}

	// Token: 0x0600B963 RID: 47459 RVA: 0x002A0D50 File Offset: 0x0029EF50
	protected virtual void OnRefresh(object @params = null)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Inventory;
		ELogAuthor author = ELogAuthor.YYZ;
		string message = "没有实现 OnRefresh";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ComponentName", base.GetType().Name);
		instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x0600B964 RID: 47460 RVA: 0x002A0D90 File Offset: 0x0029EF90
	protected virtual string GetResourceId()
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Inventory;
		ELogAuthor author = ELogAuthor.YYZ;
		string message = "没有实现 GetResourceId";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ComponentName", base.GetType().Name);
		instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		return null;
	}

	// Token: 0x0600B965 RID: 47461 RVA: 0x002A0DCF File Offset: 0x0029EFCF
	public virtual EItemGridComponentLayoutLevel GetLayoutLevel()
	{
		return EItemGridComponentLayoutLevel.Top;
	}

	// Token: 0x0600B966 RID: 47462 RVA: 0x002A0DD2 File Offset: 0x0029EFD2
	public override void SetActive(bool visibility)
	{
		if (this.UseFixedAsync)
		{
			base.SetActive(visibility);
			Action<ItemGridComponent, bool> onComponentVisibleChanged = this.OnComponentVisibleChanged;
			if (onComponentVisibleChanged == null)
			{
				return;
			}
			onComponentVisibleChanged(this, visibility);
			return;
		}
		else
		{
			if (visibility && base.IsShowOrShowing)
			{
				return;
			}
			base.SetActive(visibility);
			return;
		}
	}

	// Token: 0x0600B967 RID: 47463 RVA: 0x002A0E09 File Offset: 0x0029F009
	public void SetHierarchyIndex(int hierarchyIndex)
	{
		if (this.RootItem.GetHierarchyIndex() == hierarchyIndex)
		{
			return;
		}
		this.RootItem.SetHierarchyIndex(hierarchyIndex);
	}

	// Token: 0x0400541B RID: 21531
	private UUIItem ParentItem;

	// Token: 0x0400541C RID: 21532
	private string ResourceId;

	// Token: 0x0400541D RID: 21533
	private object Params;

	// Token: 0x0400541E RID: 21534
	private bool IsInitialized;

	// Token: 0x0400541F RID: 21535
	private bool IsBegin;

	// Token: 0x04005420 RID: 21536
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private CustomPromise<ItemGridComponent> WaitLoadPromise;

	// Token: 0x04005421 RID: 21537
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<ItemGridComponent, bool> OnComponentVisibleChanged;

	// Token: 0x04005422 RID: 21538
	private bool UseFixedAsync;
}
