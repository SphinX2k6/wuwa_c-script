using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001A2B RID: 6699
[NullableContext(2)]
[Nullable(0)]
public class DangoAbyssAttributeParentItem : UiPanelBase, IDynamicScrollItem<DangoAbyssDefine.EquipViewAttributeData>
{
	// Token: 0x0600C507 RID: 50439 RVA: 0x002CB0E4 File Offset: 0x002C92E4
	[NullableContext(1)]
	public UniTask Init(UUIItem actor)
	{
		DangoAbyssAttributeParentItem.<Init>d__4 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.actor = actor;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<DangoAbyssAttributeParentItem.<Init>d__4>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x0600C508 RID: 50440 RVA: 0x002CB130 File Offset: 0x002C9330
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x0600C509 RID: 50441 RVA: 0x002CB18C File Offset: 0x002C938C
	[NullableContext(1)]
	public AUIBaseActor GetUsingItem(DangoAbyssDefine.EquipViewAttributeData data)
	{
		if (data.Attribute != null)
		{
			return base.GetItem(1).GetOwner() as AUIBaseActor;
		}
		if (data.Tag != null)
		{
			return base.GetItem(2).GetOwner() as AUIBaseActor;
		}
		return base.GetItem(0).GetOwner() as AUIBaseActor;
	}

	// Token: 0x0600C50A RID: 50442 RVA: 0x002CB1E0 File Offset: 0x002C93E0
	protected override void OnStart()
	{
		this.ItemTitle = new DangoAbyssAttributeTitleItem();
		this.ItemTitle.Initialize(base.GetItem(0));
		this.ItemAttribute = new DangoAbyssAttributeItem();
		this.ItemAttribute.Initialize(base.GetItem(1));
		this.ItemTag = new DangoAbyssAttributeTagItem();
		this.ItemTag.Initialize(base.GetItem(2));
	}

	// Token: 0x0600C50B RID: 50443 RVA: 0x002CB244 File Offset: 0x002C9444
	[NullableContext(1)]
	public void Update(DangoAbyssDefine.EquipViewAttributeData data, int index)
	{
		this.Data = data;
		this.ItemAttribute.SetUiActive(false);
		this.ItemTag.SetUiActive(false);
		this.ItemTitle.SetUiActive(false);
		if (data.Attribute != null)
		{
			this.ItemAttribute.Refresh(data);
			return;
		}
		if (data.Tag != null)
		{
			this.ItemTag.Refresh(data);
			return;
		}
		this.ItemTitle.Refresh(data);
	}

	// Token: 0x0600C50C RID: 50444 RVA: 0x002CB2B4 File Offset: 0x002C94B4
	public void ClearItem()
	{
		this.Data = null;
		DangoAbyssAttributeTitleItem itemTitle = this.ItemTitle;
		if (itemTitle != null)
		{
			itemTitle.Destroy(null);
		}
		this.ItemTitle = null;
		DangoAbyssAttributeItem itemAttribute = this.ItemAttribute;
		if (itemAttribute != null)
		{
			itemAttribute.Destroy(null);
		}
		this.ItemAttribute = null;
		DangoAbyssAttributeTagItem itemTag = this.ItemTag;
		if (itemTag != null)
		{
			itemTag.Destroy(null);
		}
		this.ItemTag = null;
	}

	// Token: 0x04005AD2 RID: 23250
	public DangoAbyssDefine.EquipViewAttributeData Data;

	// Token: 0x04005AD3 RID: 23251
	public DangoAbyssAttributeTitleItem ItemTitle;

	// Token: 0x04005AD4 RID: 23252
	public DangoAbyssAttributeItem ItemAttribute;

	// Token: 0x04005AD5 RID: 23253
	public DangoAbyssAttributeTagItem ItemTag;
}
