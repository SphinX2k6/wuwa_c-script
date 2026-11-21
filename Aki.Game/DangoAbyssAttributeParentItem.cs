using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000EEA RID: 3818
[NullableContext(2)]
[Nullable(0)]
public class DangoAbyssAttributeParentItem : UiPanelBase, IDynamicScrollItem<DangoAbyssDefine.EquipViewAttributeData>
{
	// Token: 0x06009917 RID: 39191 RVA: 0x002D6204 File Offset: 0x002D4404
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

	// Token: 0x06009918 RID: 39192 RVA: 0x002D6250 File Offset: 0x002D4450
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x06009919 RID: 39193 RVA: 0x002D62AC File Offset: 0x002D44AC
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

	// Token: 0x0600991A RID: 39194 RVA: 0x002D6300 File Offset: 0x002D4500
	protected override void OnStart()
	{
		this.ItemTitle = new DangoAbyssAttributeTitleItem();
		this.ItemTitle.Initialize(base.GetItem(0));
		this.ItemAttribute = new DangoAbyssAttributeItem();
		this.ItemAttribute.Initialize(base.GetItem(1));
		this.ItemTag = new DangoAbyssAttributeTagItem();
		this.ItemTag.Initialize(base.GetItem(2));
	}

	// Token: 0x0600991B RID: 39195 RVA: 0x002D6364 File Offset: 0x002D4564
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

	// Token: 0x0600991C RID: 39196 RVA: 0x002D63D4 File Offset: 0x002D45D4
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

	// Token: 0x04005BA1 RID: 23457
	public DangoAbyssDefine.EquipViewAttributeData Data;

	// Token: 0x04005BA2 RID: 23458
	public DangoAbyssAttributeTitleItem ItemTitle;

	// Token: 0x04005BA3 RID: 23459
	public DangoAbyssAttributeItem ItemAttribute;

	// Token: 0x04005BA4 RID: 23460
	public DangoAbyssAttributeTagItem ItemTag;
}
