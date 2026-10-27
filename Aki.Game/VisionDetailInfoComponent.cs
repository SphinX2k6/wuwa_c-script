using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Phantom.Vision.View;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200249D RID: 9373
[NullableContext(2)]
[Nullable(0)]
public class VisionDetailInfoComponent : UiPanelBase
{
	// Token: 0x06012D1A RID: 77082 RVA: 0x004A51ED File Offset: 0x004A33ED
	[NullableContext(1)]
	public VisionDetailInfoComponent(UUIItem actor)
	{
		this.SourceItem = actor;
	}

	// Token: 0x06012D1B RID: 77083 RVA: 0x004A51FC File Offset: 0x004A33FC
	public UniTask Init()
	{
		VisionDetailInfoComponent.<Init>d__9 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<VisionDetailInfoComponent.<Init>d__9>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x06012D1C RID: 77084 RVA: 0x004A5240 File Offset: 0x004A3440
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06012D1D RID: 77085 RVA: 0x004A52EC File Offset: 0x004A34EC
	protected override UniTask OnBeforeStartAsync()
	{
		VisionDetailInfoComponent.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<VisionDetailInfoComponent.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06012D1E RID: 77086 RVA: 0x004A532F File Offset: 0x004A352F
	protected override void OnStart()
	{
		this.RoleVisionAttribute = new RoleVisionAttribute(base.GetItem(1));
		this.RoleVisionAttribute.Init();
	}

	// Token: 0x06012D1F RID: 77087 RVA: 0x004A534E File Offset: 0x004A354E
	[NullableContext(1)]
	public void SetClickCallBack(Action call)
	{
		this.OnClickMainItemCall = call;
	}

	// Token: 0x06012D20 RID: 77088 RVA: 0x004A5357 File Offset: 0x004A3557
	protected void OnClickArrow()
	{
		Action onClickMainItemCall = this.OnClickMainItemCall;
		if (onClickMainItemCall == null)
		{
			return;
		}
		onClickMainItemCall();
	}

	// Token: 0x06012D21 RID: 77089 RVA: 0x004A5369 File Offset: 0x004A3569
	[NullableContext(1)]
	public void Refresh(VisionDetailInfoComponentData data, bool ifCompare, bool ifSimple)
	{
		this.CurrentData = data;
		this.VisionDetailTop.Update(this.CurrentData.DataBase);
		this.VisionDetailTop.SetActive(true);
		this.RefreshMain();
		this.RefreshSub();
		this.RefreshDescComponent();
	}

	// Token: 0x06012D22 RID: 77090 RVA: 0x004A53A6 File Offset: 0x004A35A6
	public UUIItem GetTxtItemByIndex(int index)
	{
		VisionDetailDescComponent visionDetailDescComponent = this.VisionDetailDescComponent;
		if (visionDetailDescComponent == null)
		{
			return null;
		}
		return visionDetailDescComponent.GetTxtItemByIndex(index);
	}

	// Token: 0x06012D23 RID: 77091 RVA: 0x004A53BA File Offset: 0x004A35BA
	private void RefreshDescComponent()
	{
		this.VisionDetailDescComponent.Refresh(this.CurrentData.DescData, false);
		this.VisionDetailDescComponent.SetActive(true);
	}

	// Token: 0x06012D24 RID: 77092 RVA: 0x004A53E0 File Offset: 0x004A35E0
	private void RefreshMain()
	{
		VisionAttrRecommendInfo roleCostAttrRecommendInfo = VisionRecommendModel.Instance.GetRoleCostAttrRecommendInfo(this.CurrentData.RoleId, this.CurrentData.Cost);
		List<AttrListScrollData> mainPropData = this.CurrentData.GetMainPropData(false);
		List<AttrListScrollData> mainPropData2 = this.CurrentData.GetMainPropData(true);
		int count = mainPropData2.Count;
		List<AttrRecommendInfo> list = (roleCostAttrRecommendInfo != null) ? roleCostAttrRecommendInfo.GetMainAttrRecommendInfo() : null;
		for (int i = 0; i < count; i++)
		{
			if (roleCostAttrRecommendInfo != null)
			{
				int count2 = list.Count;
				for (int j = 0; j < count2; j++)
				{
					if (mainPropData2[i].AddValue == (double)list[j].GetAddType() && mainPropData2[i].Id == list[j].GetAttrId())
					{
						mainPropData[i].NeedHighLight = true;
					}
				}
			}
		}
		this.RoleVisionAttribute.Refresh(mainPropData, false);
	}

	// Token: 0x06012D25 RID: 77093 RVA: 0x004A54C0 File Offset: 0x004A36C0
	private void RefreshSub()
	{
		List<VisionSubPropData> subPropData = this.CurrentData.GetSubPropData();
		if (subPropData.Count > 0)
		{
			RoleVisionIdentifyAttribute roleVisionSubAttribute = this.RoleVisionSubAttribute;
			List<VisionSubPropData> data = subPropData;
			VisionDetailInfoComponentData currentData = this.CurrentData;
			roleVisionSubAttribute.Refresh(data, (currentData != null) ? currentData.DataBase : null, this.CurrentData);
			this.RoleVisionSubAttribute.SetActive(true);
			return;
		}
		this.RoleVisionSubAttribute.SetActive(false);
	}

	// Token: 0x04008DB7 RID: 36279
	private VisionDetailTop VisionDetailTop;

	// Token: 0x04008DB8 RID: 36280
	private VisionDetailInfoComponentData CurrentData;

	// Token: 0x04008DB9 RID: 36281
	private RoleVisionAttribute RoleVisionAttribute;

	// Token: 0x04008DBA RID: 36282
	private RoleVisionIdentifyAttribute RoleVisionSubAttribute;

	// Token: 0x04008DBB RID: 36283
	private VisionDetailDescComponent VisionDetailDescComponent;

	// Token: 0x04008DBC RID: 36284
	private Action OnClickMainItemCall;

	// Token: 0x04008DBD RID: 36285
	private readonly UUIItem SourceItem;

	// Token: 0x02008A1D RID: 35357
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402CD9A RID: 183706
		TopPanel,
		// Token: 0x0402CD9B RID: 183707
		AttributeItem,
		// Token: 0x0402CD9C RID: 183708
		AttributeItemSub,
		// Token: 0x0402CD9D RID: 183709
		ItemParent
	}
}
