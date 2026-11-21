using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Phantom.Vision.View;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001984 RID: 6532
[NullableContext(2)]
[Nullable(0)]
public class VisionDetailInfoComponent : UiPanelBase
{
	// Token: 0x060101DB RID: 66011 RVA: 0x004B2CF5 File Offset: 0x004B0EF5
	[NullableContext(1)]
	public VisionDetailInfoComponent(UUIItem actor)
	{
		this.SourceItem = actor;
	}

	// Token: 0x060101DC RID: 66012 RVA: 0x004B2D04 File Offset: 0x004B0F04
	public UniTask Init()
	{
		VisionDetailInfoComponent.<Init>d__9 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<VisionDetailInfoComponent.<Init>d__9>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x060101DD RID: 66013 RVA: 0x004B2D48 File Offset: 0x004B0F48
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

	// Token: 0x060101DE RID: 66014 RVA: 0x004B2DF4 File Offset: 0x004B0FF4
	protected override UniTask OnBeforeStartAsync()
	{
		VisionDetailInfoComponent.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<VisionDetailInfoComponent.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060101DF RID: 66015 RVA: 0x004B2E37 File Offset: 0x004B1037
	protected override void OnStart()
	{
		this.RoleVisionAttribute = new RoleVisionAttribute(base.GetItem(1));
		this.RoleVisionAttribute.Init();
	}

	// Token: 0x060101E0 RID: 66016 RVA: 0x004B2E56 File Offset: 0x004B1056
	[NullableContext(1)]
	public void SetClickCallBack(Action call)
	{
		this.OnClickMainItemCall = call;
	}

	// Token: 0x060101E1 RID: 66017 RVA: 0x004B2E5F File Offset: 0x004B105F
	protected void OnClickArrow()
	{
		Action onClickMainItemCall = this.OnClickMainItemCall;
		if (onClickMainItemCall == null)
		{
			return;
		}
		onClickMainItemCall();
	}

	// Token: 0x060101E2 RID: 66018 RVA: 0x004B2E71 File Offset: 0x004B1071
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

	// Token: 0x060101E3 RID: 66019 RVA: 0x004B2EAE File Offset: 0x004B10AE
	public UUIItem GetTxtItemByIndex(int index)
	{
		VisionDetailDescComponent visionDetailDescComponent = this.VisionDetailDescComponent;
		if (visionDetailDescComponent == null)
		{
			return null;
		}
		return visionDetailDescComponent.GetTxtItemByIndex(index);
	}

	// Token: 0x060101E4 RID: 66020 RVA: 0x004B2EC2 File Offset: 0x004B10C2
	private void RefreshDescComponent()
	{
		this.VisionDetailDescComponent.Refresh(this.CurrentData.DescData, false);
		this.VisionDetailDescComponent.SetActive(true);
	}

	// Token: 0x060101E5 RID: 66021 RVA: 0x004B2EE8 File Offset: 0x004B10E8
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

	// Token: 0x060101E6 RID: 66022 RVA: 0x004B2FC8 File Offset: 0x004B11C8
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

	// Token: 0x04008F01 RID: 36609
	private VisionDetailTop VisionDetailTop;

	// Token: 0x04008F02 RID: 36610
	private VisionDetailInfoComponentData CurrentData;

	// Token: 0x04008F03 RID: 36611
	private RoleVisionAttribute RoleVisionAttribute;

	// Token: 0x04008F04 RID: 36612
	private RoleVisionIdentifyAttribute RoleVisionSubAttribute;

	// Token: 0x04008F05 RID: 36613
	private VisionDetailDescComponent VisionDetailDescComponent;

	// Token: 0x04008F06 RID: 36614
	private Action OnClickMainItemCall;

	// Token: 0x04008F07 RID: 36615
	private readonly UUIItem SourceItem;

	// Token: 0x02007BA7 RID: 31655
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x040280BA RID: 164026
		TopPanel,
		// Token: 0x040280BB RID: 164027
		AttributeItem,
		// Token: 0x040280BC RID: 164028
		AttributeItemSub,
		// Token: 0x040280BD RID: 164029
		ItemParent
	}
}
