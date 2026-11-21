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

// Token: 0x02001E5E RID: 7774
[NullableContext(1)]
[Nullable(0)]
public class RoleAttributeItem : UiPanelBase, IGridProxy<RoleAttributeSt>
{
	// Token: 0x17001D58 RID: 7512
	// (get) Token: 0x060133BF RID: 78783 RVA: 0x0059F1AC File Offset: 0x0059D3AC
	// (set) Token: 0x060133C0 RID: 78784 RVA: 0x0059F1B4 File Offset: 0x0059D3B4
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

	// Token: 0x17001D59 RID: 7513
	// (get) Token: 0x060133C1 RID: 78785 RVA: 0x0059F1BD File Offset: 0x0059D3BD
	// (set) Token: 0x060133C2 RID: 78786 RVA: 0x0059F1C5 File Offset: 0x0059D3C5
	public int GridIndex { get; set; }

	// Token: 0x17001D5A RID: 7514
	// (get) Token: 0x060133C3 RID: 78787 RVA: 0x0059F1CE File Offset: 0x0059D3CE
	// (set) Token: 0x060133C4 RID: 78788 RVA: 0x0059F1D6 File Offset: 0x0059D3D6
	public int DisplayIndex { get; set; }

	// Token: 0x060133C5 RID: 78789 RVA: 0x0059F1DF File Offset: 0x0059D3DF
	public void CreateThenShowByActor(AActor actor)
	{
	}

	// Token: 0x060133C6 RID: 78790 RVA: 0x0059F1E4 File Offset: 0x0059D3E4
	public UniTask CreateThenShowByActorAsync(AActor actor)
	{
		RoleAttributeItem.<CreateThenShowByActorAsync>d__14 <CreateThenShowByActorAsync>d__;
		<CreateThenShowByActorAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateThenShowByActorAsync>d__.<>1__state = -1;
		<CreateThenShowByActorAsync>d__.<>t__builder.Start<RoleAttributeItem.<CreateThenShowByActorAsync>d__14>(ref <CreateThenShowByActorAsync>d__);
		return <CreateThenShowByActorAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060133C7 RID: 78791 RVA: 0x0059F220 File Offset: 0x0059D420
	public UniTask CreateByActorAsync(AActor actor)
	{
		RoleAttributeItem.<CreateByActorAsync>d__15 <CreateByActorAsync>d__;
		<CreateByActorAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateByActorAsync>d__.<>1__state = -1;
		<CreateByActorAsync>d__.<>t__builder.Start<RoleAttributeItem.<CreateByActorAsync>d__15>(ref <CreateByActorAsync>d__);
		return <CreateByActorAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060133C8 RID: 78792 RVA: 0x0059F25B File Offset: 0x0059D45B
	public void Refresh(RoleAttributeSt data, bool isSelected, int gridIndex)
	{
		this.Update(data);
	}

	// Token: 0x060133C9 RID: 78793 RVA: 0x0059F264 File Offset: 0x0059D464
	public void Clear()
	{
	}

	// Token: 0x060133CA RID: 78794 RVA: 0x0059F266 File Offset: 0x0059D466
	public void OnSelected(bool fireEvent)
	{
	}

	// Token: 0x060133CB RID: 78795 RVA: 0x0059F268 File Offset: 0x0059D468
	public void OnDeselected(bool fireEvent)
	{
	}

	// Token: 0x060133CC RID: 78796 RVA: 0x0059F26A File Offset: 0x0059D46A
	public object GetKey(RoleAttributeSt data, int gridIndex)
	{
		return this.GridIndex;
	}

	// Token: 0x060133CD RID: 78797 RVA: 0x0059F278 File Offset: 0x0059D478
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

	// Token: 0x060133CE RID: 78798 RVA: 0x0059F386 File Offset: 0x0059D586
	protected override void OnStart()
	{
	}

	// Token: 0x060133CF RID: 78799 RVA: 0x0059F388 File Offset: 0x0059D588
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

	// Token: 0x060133D0 RID: 78800 RVA: 0x0059F4B0 File Offset: 0x0059D6B0
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

	// Token: 0x060133D1 RID: 78801 RVA: 0x0059F55B File Offset: 0x0059D75B
	private void RefreshHighLight(bool bEnable)
	{
		base.GetItem(6).SetUIActive(bEnable);
	}

	// Token: 0x0200813C RID: 33084
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04029CA6 RID: 171174
		AttributeText,
		// Token: 0x04029CA7 RID: 171175
		AttributeNumText,
		// Token: 0x04029CA8 RID: 171176
		ArrowItem,
		// Token: 0x04029CA9 RID: 171177
		AttributeAddText,
		// Token: 0x04029CAA RID: 171178
		AttributeIcon,
		// Token: 0x04029CAB RID: 171179
		Bg,
		// Token: 0x04029CAC RID: 171180
		HighLightItem
	}
}
