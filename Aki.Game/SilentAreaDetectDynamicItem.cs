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

// Token: 0x02000B70 RID: 2928
[NullableContext(1)]
[Nullable(0)]
public class SilentAreaDetectDynamicItem : UiPanelBase, IDynamicScrollItem<ISilentAreaDetectionDynamicData>
{
	// Token: 0x060079D1 RID: 31185 RVA: 0x0025BC58 File Offset: 0x00259E58
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

	// Token: 0x060079D2 RID: 31186 RVA: 0x0025BCA4 File Offset: 0x00259EA4
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

	// Token: 0x060079D3 RID: 31187 RVA: 0x0025BD0D File Offset: 0x00259F0D
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

	// Token: 0x060079D4 RID: 31188 RVA: 0x0025BD43 File Offset: 0x00259F43
	public AUIBaseActor GetUsingItem(ISilentAreaDetectionDynamicData data)
	{
		if (data.SilentAreaDetectionData != null)
		{
			return base.GetItem(1).GetOwner() as AUIBaseActor;
		}
		return base.GetItem(0).GetOwner() as AUIBaseActor;
	}

	// Token: 0x060079D5 RID: 31189 RVA: 0x0025BD70 File Offset: 0x00259F70
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

	// Token: 0x060079D6 RID: 31190 RVA: 0x0025BE07 File Offset: 0x0025A007
	public void BindClickCategoryCallback(Action<int, UUIExtendToggle, bool> onCategoryCallback)
	{
		this.OnCategoryCallback = onCategoryCallback;
	}

	// Token: 0x060079D7 RID: 31191 RVA: 0x0025BE10 File Offset: 0x0025A010
	public void BindClickResultCallback(Action<int, UUIExtendToggle> onResultCallback)
	{
		this.OnResultCallback = onResultCallback;
	}

	// Token: 0x060079D8 RID: 31192 RVA: 0x0025BE19 File Offset: 0x0025A019
	public void ClearItem()
	{
		base.Destroy(null);
	}

	// Token: 0x060079D9 RID: 31193 RVA: 0x0025BE22 File Offset: 0x0025A022
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

	// Token: 0x04004B98 RID: 19352
	[Nullable(2)]
	protected ISilentAreaDetectionDynamicData Data;

	// Token: 0x04004B99 RID: 19353
	[Nullable(2)]
	private SilentCategoryItem SilentCategoryItem;

	// Token: 0x04004B9A RID: 19354
	[Nullable(2)]
	private SilentResultItem SilentResultItem;

	// Token: 0x04004B9B RID: 19355
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<int, UUIExtendToggle, bool> OnCategoryCallback;

	// Token: 0x04004B9C RID: 19356
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<int, UUIExtendToggle> OnResultCallback;

	// Token: 0x02006E10 RID: 28176
	[NullableContext(0)]
	public enum ESilentAreaDefine
	{
		// Token: 0x040240F4 RID: 147700
		SilentCategoryItem,
		// Token: 0x040240F5 RID: 147701
		SilentResultItem
	}
}
