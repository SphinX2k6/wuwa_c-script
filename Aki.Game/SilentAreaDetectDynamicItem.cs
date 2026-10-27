using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.AdventureGuide;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020016B8 RID: 5816
[NullableContext(1)]
[Nullable(0)]
public class SilentAreaDetectDynamicItem : UiPanelBase, IDynamicScrollItem<ISilentAreaDetectionDynamicData>
{
	// Token: 0x0600A5F1 RID: 42481 RVA: 0x00251848 File Offset: 0x0024FA48
	public UniTask Init(UUIItem actor)
	{
		SilentAreaDetectDynamicItem.<Init>d__6 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.actor = actor;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<SilentAreaDetectDynamicItem.<Init>d__6>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x0600A5F2 RID: 42482 RVA: 0x00251894 File Offset: 0x0024FA94
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600A5F3 RID: 42483 RVA: 0x002518FD File Offset: 0x0024FAFD
	protected override void OnStart()
	{
		if (this.SilentCategoryItem == null)
		{
			this.SilentCategoryItem = new SilentCategoryItem(base.GetItem(0));
		}
		if (this.SilentResultItem == null)
		{
			this.SilentResultItem = new SilentResultItem(base.GetItem(1));
		}
	}

	// Token: 0x0600A5F4 RID: 42484 RVA: 0x00251933 File Offset: 0x0024FB33
	public AUIBaseActor GetUsingItem(ISilentAreaDetectionDynamicData data)
	{
		if (data.SilentAreaDetectionData != null)
		{
			return base.GetItem(1).GetOwner() as AUIBaseActor;
		}
		return base.GetItem(0).GetOwner() as AUIBaseActor;
	}

	// Token: 0x0600A5F5 RID: 42485 RVA: 0x00251960 File Offset: 0x0024FB60
	public void Update(ISilentAreaDetectionDynamicData data, int index)
	{
		this.Data = data;
		this.SilentResultItem.SetActive(false);
		this.SilentCategoryItem.SetActive(false);
		if (data.SilentAreaDetectionData != null)
		{
			this.SilentResultItem.SetActive(true);
			this.SilentResultItem.Update(data.SilentAreaDetectionData);
			this.SilentResultItem.BindResultCallback(this.OnResultCallback);
			return;
		}
		this.SilentCategoryItem.SetActive(true);
		this.SilentCategoryItem.Update(data.SilentAreaTitleData, data.IsShow);
		this.SilentCategoryItem.BindCategoryCallback(this.OnCategoryCallback);
	}

	// Token: 0x0600A5F6 RID: 42486 RVA: 0x002519F7 File Offset: 0x0024FBF7
	public void BindClickCategoryCallback(Action<int, UUIExtendToggle, bool> onCategoryCallback)
	{
		this.OnCategoryCallback = onCategoryCallback;
	}

	// Token: 0x0600A5F7 RID: 42487 RVA: 0x00251A00 File Offset: 0x0024FC00
	public void BindClickResultCallback(Action<int, UUIExtendToggle> onResultCallback)
	{
		this.OnResultCallback = onResultCallback;
	}

	// Token: 0x0600A5F8 RID: 42488 RVA: 0x00251A09 File Offset: 0x0024FC09
	public void ClearItem()
	{
		base.Destroy(null);
	}

	// Token: 0x0600A5F9 RID: 42489 RVA: 0x00251A12 File Offset: 0x0024FC12
	protected override void OnBeforeDestroy()
	{
		if (this.SilentCategoryItem != null)
		{
			this.SilentCategoryItem.Destroy(null);
			this.SilentCategoryItem = null;
		}
		if (this.SilentResultItem != null)
		{
			this.SilentResultItem.Destroy(null);
			this.SilentResultItem = null;
		}
	}

	// Token: 0x04004AF1 RID: 19185
	[Nullable(2)]
	protected ISilentAreaDetectionDynamicData Data;

	// Token: 0x04004AF2 RID: 19186
	[Nullable(2)]
	private SilentCategoryItem SilentCategoryItem;

	// Token: 0x04004AF3 RID: 19187
	[Nullable(2)]
	private SilentResultItem SilentResultItem;

	// Token: 0x04004AF4 RID: 19188
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<int, UUIExtendToggle, bool> OnCategoryCallback;

	// Token: 0x04004AF5 RID: 19189
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<int, UUIExtendToggle> OnResultCallback;

	// Token: 0x02007C8B RID: 31883
	[NullableContext(0)]
	public enum ESilentAreaDefine
	{
		// Token: 0x04028DCB RID: 167371
		SilentCategoryItem,
		// Token: 0x04028DCC RID: 167372
		SilentResultItem
	}
}
