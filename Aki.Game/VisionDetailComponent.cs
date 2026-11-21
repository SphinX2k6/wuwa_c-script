using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Phantom.Vision.View;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001982 RID: 6530
[NullableContext(2)]
[Nullable(0)]
public class VisionDetailComponent : UiPanelBase
{
	// Token: 0x060101C9 RID: 65993 RVA: 0x004B2860 File Offset: 0x004B0A60
	[NullableContext(1)]
	public VisionDetailComponent(UUIItem actor)
	{
		this.SourceItem = actor;
	}

	// Token: 0x060101CA RID: 65994 RVA: 0x004B2870 File Offset: 0x004B0A70
	public UniTask Init()
	{
		VisionDetailComponent.<Init>d__7 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<VisionDetailComponent.<Init>d__7>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x060101CB RID: 65995 RVA: 0x004B28B3 File Offset: 0x004B0AB3
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x060101CC RID: 65996 RVA: 0x004B28EC File Offset: 0x004B0AEC
	protected override UniTask OnBeforeStartAsync()
	{
		VisionDetailComponent.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<VisionDetailComponent.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060101CD RID: 65997 RVA: 0x004B292F File Offset: 0x004B0B2F
	protected override void OnStart()
	{
		this.UnderComponent = new VisionDetailUnderComponent(base.GetItem(0));
		this.VisionDetailInfoComponent.SetClickCallBack(new Action(this.OnClickMainItem));
	}

	// Token: 0x060101CE RID: 65998 RVA: 0x004B295A File Offset: 0x004B0B5A
	public UUIItem GetTxtItemByIndex(int index)
	{
		VisionDetailInfoComponent visionDetailInfoComponent = this.VisionDetailInfoComponent;
		if (visionDetailInfoComponent == null)
		{
			return null;
		}
		return visionDetailInfoComponent.GetTxtItemByIndex(index);
	}

	// Token: 0x060101CF RID: 65999 RVA: 0x004B296E File Offset: 0x004B0B6E
	protected void OnClickMainItem()
	{
	}

	// Token: 0x060101D0 RID: 66000 RVA: 0x004B2970 File Offset: 0x004B0B70
	[NullableContext(1)]
	public void SetUnderLeftButtonText(string textId)
	{
		this.UnderComponent.RefreshLeftButtonText(textId);
	}

	// Token: 0x060101D1 RID: 66001 RVA: 0x004B297E File Offset: 0x004B0B7E
	[NullableContext(1)]
	public void Update(PhantomBattleData data, int roleId, int cost, bool ifCompare = false)
	{
		this.CurrentPhantomData = data;
		this.RoleId = roleId;
		this.Cost = cost;
		this.CurrentCompareState = ifCompare;
		this.RefreshDetailView();
		this.UnderComponent.Update(data);
	}

	// Token: 0x060101D2 RID: 66002 RVA: 0x004B29B0 File Offset: 0x004B0BB0
	private void RefreshDetailView()
	{
		int key = (this.CurrentCompareState > false) ? 1 : 0;
		bool ifSimpleState = PhantomBattleModel.Instance.GetIfSimpleState(key);
		VisionDetailInfoComponentData visionDetailInfoComponentData = new VisionDetailInfoComponentData();
		visionDetailInfoComponentData.DataBase = this.CurrentPhantomData;
		visionDetailInfoComponentData.RoleId = this.RoleId;
		visionDetailInfoComponentData.Cost = this.Cost;
		int num = -1;
		if (!this.CurrentCompareState)
		{
			num = PhantomBattleModel.Instance.CurrentEquipmentSelectIndex;
		}
		List<VisionFetterData> previewShowFetterList = this.CurrentPhantomData.GetPreviewShowFetterList(num, this.RoleId);
		bool flag = this.CurrentPhantomData.IfEquipSameNameMonsterOnRole(num, this.RoleId);
		bool flag2 = this.CurrentPhantomData.IfEquipOverNeedOnRole(previewShowFetterList);
		bool ifPreview = false;
		PhantomDataBase dataByIndex = RoleModel.Instance.GetRoleInstanceById(this.RoleId).GetPhantomData().GetDataByIndex(0);
		if (dataByIndex == null || dataByIndex.GetIncrId() != this.CurrentPhantomData.GetUniqueId())
		{
			ifPreview = true;
		}
		foreach (VisionDetailDesc data in VisionDetailDesc.ConvertVisionSkillDescToDescData(this.CurrentPhantomData.GetNormalSkillConfig().Value, this.CurrentPhantomData.GetPhantomLevel(), num == 0 || num == -1, ifPreview, this.CurrentPhantomData.GetQuality()))
		{
			visionDetailInfoComponentData.AddDescData(data);
		}
		foreach (VisionDetailDesc data2 in VisionDetailDesc.ConvertVisionFetterDataToDetailDescData(previewShowFetterList, flag, new bool?(flag2), delegate
		{
			PhantomBattleController.Instance.OpenPhantomBattleFetterView(this.CurrentPhantomData.GetFetterGroupId(), this.RoleId, true, null);
		}))
		{
			visionDetailInfoComponentData.AddDescData(data2);
		}
		if (this.CurrentCompareState && visionDetailInfoComponentData.DescData != null)
		{
			foreach (VisionDetailDesc visionDetailDesc in visionDetailInfoComponentData.DescData)
			{
				visionDetailDesc.AnimationState = false;
				visionDetailDesc.CompareState = this.CurrentCompareState;
			}
		}
		if (flag)
		{
			foreach (VisionDetailDesc data3 in VisionDetailDesc.CreateSameMonsterTips())
			{
				visionDetailInfoComponentData.AddDescData(data3);
			}
		}
		if (flag2)
		{
			foreach (VisionDetailDesc data4 in VisionDetailDesc.CreateOverNeedTips())
			{
				visionDetailInfoComponentData.AddDescData(data4);
			}
		}
		this.VisionDetailInfoComponent.Refresh(visionDetailInfoComponentData, this.CurrentCompareState, ifSimpleState);
		this.VisionDetailInfoComponent.SetActive(true);
	}

	// Token: 0x060101D3 RID: 66003 RVA: 0x004B2C6C File Offset: 0x004B0E6C
	public void SetButtonPanelShowState(bool state)
	{
		this.UnderComponent.SetActive(state);
	}

	// Token: 0x060101D4 RID: 66004 RVA: 0x004B2C7A File Offset: 0x004B0E7A
	public void RefreshViewByCompareState(bool state)
	{
		this.UnderComponent.RefreshViewByCompareState(state);
	}

	// Token: 0x060101D5 RID: 66005 RVA: 0x004B2C88 File Offset: 0x004B0E88
	public VisionDetailUnderComponent GetDetailUnderComponent()
	{
		return this.UnderComponent;
	}

	// Token: 0x04008EF6 RID: 36598
	private bool CurrentCompareState;

	// Token: 0x04008EF7 RID: 36599
	private int RoleId;

	// Token: 0x04008EF8 RID: 36600
	private int Cost;

	// Token: 0x04008EF9 RID: 36601
	private PhantomBattleData CurrentPhantomData;

	// Token: 0x04008EFA RID: 36602
	private readonly UUIItem SourceItem;

	// Token: 0x04008EFB RID: 36603
	private VisionDetailUnderComponent UnderComponent;

	// Token: 0x04008EFC RID: 36604
	private VisionDetailInfoComponent VisionDetailInfoComponent;

	// Token: 0x02007BA4 RID: 31652
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x040280AF RID: 164015
		UnderPanel,
		// Token: 0x040280B0 RID: 164016
		InfoPanel
	}
}
