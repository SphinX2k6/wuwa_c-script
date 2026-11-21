using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000D70 RID: 3440
[NullableContext(2)]
[Nullable(0)]
public class ItemGridComponent : UiPanelBase
{
	// Token: 0x06008D43 RID: 36163 RVA: 0x002AB363 File Offset: 0x002A9563
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

	// Token: 0x06008D44 RID: 36164 RVA: 0x002AB398 File Offset: 0x002A9598
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

	// Token: 0x06008D45 RID: 36165 RVA: 0x002AB3DC File Offset: 0x002A95DC
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

	// Token: 0x06008D46 RID: 36166 RVA: 0x002AB41F File Offset: 0x002A961F
	protected override void OnStartImplement()
	{
		this.IsBegin = true;
		this.OnActivate();
		if (this.Params != null)
		{
			this.OnRefresh(this.Params);
		}
	}

	// Token: 0x06008D47 RID: 36167 RVA: 0x002AB442 File Offset: 0x002A9642
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

	// Token: 0x06008D48 RID: 36168 RVA: 0x002AB478 File Offset: 0x002A9678
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

	// Token: 0x06008D49 RID: 36169 RVA: 0x002AB49D File Offset: 0x002A969D
	protected virtual void OnInitialize()
	{
	}

	// Token: 0x06008D4A RID: 36170 RVA: 0x002AB49F File Offset: 0x002A969F
	protected virtual void OnActivate()
	{
	}

	// Token: 0x06008D4B RID: 36171 RVA: 0x002AB4A1 File Offset: 0x002A96A1
	protected virtual void OnDeactivate()
	{
	}

	// Token: 0x06008D4C RID: 36172 RVA: 0x002AB4A4 File Offset: 0x002A96A4
	protected virtual void OnRefresh(object @params = null)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Inventory;
		ELogAuthor author = ELogAuthor.YYZ;
		string message = "没有实现 OnRefresh";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ComponentName", base.GetType().Name);
		instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x06008D4D RID: 36173 RVA: 0x002AB4E4 File Offset: 0x002A96E4
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

	// Token: 0x06008D4E RID: 36174 RVA: 0x002AB523 File Offset: 0x002A9723
	public virtual EItemGridComponentLayoutLevel GetLayoutLevel()
	{
		return EItemGridComponentLayoutLevel.Top;
	}

	// Token: 0x06008D4F RID: 36175 RVA: 0x002AB526 File Offset: 0x002A9726
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

	// Token: 0x06008D50 RID: 36176 RVA: 0x002AB55D File Offset: 0x002A975D
	public void SetHierarchyIndex(int hierarchyIndex)
	{
		if (this.RootItem.GetHierarchyIndex() == hierarchyIndex)
		{
			return;
		}
		this.RootItem.SetHierarchyIndex(hierarchyIndex);
	}

	// Token: 0x040054C6 RID: 21702
	private UUIItem ParentItem;

	// Token: 0x040054C7 RID: 21703
	private string ResourceId;

	// Token: 0x040054C8 RID: 21704
	private object Params;

	// Token: 0x040054C9 RID: 21705
	private bool IsInitialized;

	// Token: 0x040054CA RID: 21706
	private bool IsBegin;

	// Token: 0x040054CB RID: 21707
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private CustomPromise<ItemGridComponent> WaitLoadPromise;

	// Token: 0x040054CC RID: 21708
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<ItemGridComponent, bool> OnComponentVisibleChanged;

	// Token: 0x040054CD RID: 21709
	private bool UseFixedAsync;
}
