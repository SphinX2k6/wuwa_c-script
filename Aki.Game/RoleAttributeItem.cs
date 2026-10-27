using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020028E3 RID: 10467
[NullableContext(1)]
[Nullable(0)]
public class RoleAttributeItem : UiPanelBase, IGridProxy<RoleAttributeSt>
{
	// Token: 0x17001CFE RID: 7422
	// (get) Token: 0x060159BB RID: 88507 RVA: 0x005742E4 File Offset: 0x005724E4
	// (set) Token: 0x060159BC RID: 88508 RVA: 0x005742EC File Offset: 0x005724EC
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	public IScrollViewDelegate<IGridProxy<RoleAttributeSt>, RoleAttributeSt> ScrollViewDelegate { [return: Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})] set; }

	// Token: 0x17001CFF RID: 7423
	// (get) Token: 0x060159BD RID: 88509 RVA: 0x005742F5 File Offset: 0x005724F5
	// (set) Token: 0x060159BE RID: 88510 RVA: 0x005742FD File Offset: 0x005724FD
	public int GridIndex { get; set; }

	// Token: 0x17001D00 RID: 7424
	// (get) Token: 0x060159BF RID: 88511 RVA: 0x00574306 File Offset: 0x00572506
	// (set) Token: 0x060159C0 RID: 88512 RVA: 0x0057430E File Offset: 0x0057250E
	public int DisplayIndex { get; set; }

	// Token: 0x060159C1 RID: 88513 RVA: 0x00574317 File Offset: 0x00572517
	public void CreateThenShowByActor(AActor actor)
	{
	}

	// Token: 0x060159C2 RID: 88514 RVA: 0x0057431C File Offset: 0x0057251C
	public UniTask CreateThenShowByActorAsync(AActor actor)
	{
		RoleAttributeItem.<CreateThenShowByActorAsync>d__14 <CreateThenShowByActorAsync>d__;
		<CreateThenShowByActorAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateThenShowByActorAsync>d__.<>1__state = -1;
		<CreateThenShowByActorAsync>d__.<>t__builder.Start<RoleAttributeItem.<CreateThenShowByActorAsync>d__14>(ref <CreateThenShowByActorAsync>d__);
		return <CreateThenShowByActorAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060159C3 RID: 88515 RVA: 0x00574358 File Offset: 0x00572558
	public UniTask CreateByActorAsync(AActor actor)
	{
		RoleAttributeItem.<CreateByActorAsync>d__15 <CreateByActorAsync>d__;
		<CreateByActorAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateByActorAsync>d__.<>1__state = -1;
		<CreateByActorAsync>d__.<>t__builder.Start<RoleAttributeItem.<CreateByActorAsync>d__15>(ref <CreateByActorAsync>d__);
		return <CreateByActorAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060159C4 RID: 88516 RVA: 0x00574393 File Offset: 0x00572593
	public void Refresh(RoleAttributeSt data, bool isSelected, int gridIndex)
	{
		this.Update(data);
	}

	// Token: 0x060159C5 RID: 88517 RVA: 0x0057439C File Offset: 0x0057259C
	public void Clear()
	{
	}

	// Token: 0x060159C6 RID: 88518 RVA: 0x0057439E File Offset: 0x0057259E
	public void OnSelected(bool fireEvent)
	{
	}

	// Token: 0x060159C7 RID: 88519 RVA: 0x005743A0 File Offset: 0x005725A0
	public void OnDeselected(bool fireEvent)
	{
	}

	// Token: 0x060159C8 RID: 88520 RVA: 0x005743A2 File Offset: 0x005725A2
	public object GetKey(RoleAttributeSt data, int gridIndex)
	{
		return this.GridIndex;
	}

	// Token: 0x060159C9 RID: 88521 RVA: 0x005743B0 File Offset: 0x005725B0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 7;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x060159CA RID: 88522 RVA: 0x005744BE File Offset: 0x005726BE
	protected override void OnStart()
	{
	}

	// Token: 0x060159CB RID: 88523 RVA: 0x005744C0 File Offset: 0x005726C0
	public void Update(RoleAttributeSt attrData)
	{
		if (attrData.NeedCheckBg)
		{
			base.GetSprite(5).SetUIActive(this.GridIndex % 2 == 0);
		}
		else
		{
			base.GetSprite(5).SetUIActive(!attrData.Data.NeedHighLight);
		}
		if (attrData.Data.IsUnknown)
		{
			base.GetText(0).SetText("???", true);
			base.GetText(1).SetText("???", true);
			base.GetTexture(4).SetUIActive(false);
			return;
		}
		PropertyIndex value = PropertyIndexConfig.Instance.GetPropertyIndexInfo(attrData.Data.Id).Value;
		base.SetTextureByPath(value.Icon, base.GetTexture(4), null, null);
		base.GetText(0).ShowTextNew(value.Name);
		base.GetItem(2).SetUIActive(attrData.Data.AttributeType == CommonComponentDefine.EAttributeType.VisionLevelUp);
		base.GetText(3).SetUIActive(attrData.Data.AttributeType == CommonComponentDefine.EAttributeType.VisionLevelUp);
		this.RefreshAttribute(attrData.Data);
		this.RefreshHighLight(attrData.Data.NeedHighLight);
	}

	// Token: 0x060159CC RID: 88524 RVA: 0x005745E8 File Offset: 0x005727E8
	private void RefreshAttribute(AttrListScrollData attrData)
	{
		if (attrData.AttributeType == CommonComponentDefine.EAttributeType.VisionSlot || attrData.AttributeType == CommonComponentDefine.EAttributeType.PhantomType || attrData.AttributeType == CommonComponentDefine.EAttributeType.VisionSlotLevelUp)
		{
			base.GetText(1).SetText(AttributeModel.Instance.GetFormatAttributeValueString(attrData.Id, attrData.BaseValue + attrData.AddValue, attrData.IsRatio), true);
			return;
		}
		base.GetText(3).SetText(AttributeModel.Instance.GetFormatAttributeValueString(attrData.Id, attrData.AddValue, attrData.IsRatio), true);
		base.GetText(1).SetText(AttributeModel.Instance.GetFormatAttributeValueString(attrData.Id, attrData.BaseValue, attrData.IsRatio), true);
	}

	// Token: 0x060159CD RID: 88525 RVA: 0x00574693 File Offset: 0x00572893
	private void RefreshHighLight(bool bEnable)
	{
		base.GetItem(6).SetUIActive(bEnable);
	}

	// Token: 0x02008EF4 RID: 36596
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x0402E5AB RID: 189867
		AttributeText,
		// Token: 0x0402E5AC RID: 189868
		AttributeNumText,
		// Token: 0x0402E5AD RID: 189869
		ArrowItem,
		// Token: 0x0402E5AE RID: 189870
		AttributeAddText,
		// Token: 0x0402E5AF RID: 189871
		AttributeIcon,
		// Token: 0x0402E5B0 RID: 189872
		Bg,
		// Token: 0x0402E5B1 RID: 189873
		HighLightItem
	}
}
