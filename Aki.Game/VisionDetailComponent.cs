using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Phantom.Vision.View;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200249B RID: 9371
[NullableContext(2)]
[Nullable(0)]
public class VisionDetailComponent : UiPanelBase
{
	// Token: 0x06012D08 RID: 77064 RVA: 0x004A4D58 File Offset: 0x004A2F58
	[NullableContext(1)]
	public VisionDetailComponent(UUIItem actor)
	{
		this.SourceItem = actor;
	}

	// Token: 0x06012D09 RID: 77065 RVA: 0x004A4D68 File Offset: 0x004A2F68
	public UniTask Init()
	{
		VisionDetailComponent.<Init>d__7 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<VisionDetailComponent.<Init>d__7>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x06012D0A RID: 77066 RVA: 0x004A4DAB File Offset: 0x004A2FAB
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x06012D0B RID: 77067 RVA: 0x004A4DE4 File Offset: 0x004A2FE4
	protected override UniTask OnBeforeStartAsync()
	{
		VisionDetailComponent.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<VisionDetailComponent.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06012D0C RID: 77068 RVA: 0x004A4E27 File Offset: 0x004A3027
	protected override void OnStart()
	{
		this.UnderComponent = new VisionDetailUnderComponent(base.GetItem(0));
		this.VisionDetailInfoComponent.SetClickCallBack(new Action(this.OnClickMainItem));
	}

	// Token: 0x06012D0D RID: 77069 RVA: 0x004A4E52 File Offset: 0x004A3052
	public UUIItem GetTxtItemByIndex(int index)
	{
		VisionDetailInfoComponent visionDetailInfoComponent = this.VisionDetailInfoComponent;
		if (visionDetailInfoComponent == null)
		{
			return null;
		}
		return visionDetailInfoComponent.GetTxtItemByIndex(index);
	}

	// Token: 0x06012D0E RID: 77070 RVA: 0x004A4E66 File Offset: 0x004A3066
	protected void OnClickMainItem()
	{
	}

	// Token: 0x06012D0F RID: 77071 RVA: 0x004A4E68 File Offset: 0x004A3068
	[NullableContext(1)]
	public void SetUnderLeftButtonText(string textId)
	{
		this.UnderComponent.RefreshLeftButtonText(textId);
	}

	// Token: 0x06012D10 RID: 77072 RVA: 0x004A4E76 File Offset: 0x004A3076
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

	// Token: 0x06012D11 RID: 77073 RVA: 0x004A4EA8 File Offset: 0x004A30A8
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

	// Token: 0x06012D12 RID: 77074 RVA: 0x004A5164 File Offset: 0x004A3364
	public void SetButtonPanelShowState(bool state)
	{
		this.UnderComponent.SetActive(state);
	}

	// Token: 0x06012D13 RID: 77075 RVA: 0x004A5172 File Offset: 0x004A3372
	public void RefreshViewByCompareState(bool state)
	{
		this.UnderComponent.RefreshViewByCompareState(state);
	}

	// Token: 0x06012D14 RID: 77076 RVA: 0x004A5180 File Offset: 0x004A3380
	public VisionDetailUnderComponent GetDetailUnderComponent()
	{
		return this.UnderComponent;
	}

	// Token: 0x04008DAC RID: 36268
	private bool CurrentCompareState;

	// Token: 0x04008DAD RID: 36269
	private int RoleId;

	// Token: 0x04008DAE RID: 36270
	private int Cost;

	// Token: 0x04008DAF RID: 36271
	private PhantomBattleData CurrentPhantomData;

	// Token: 0x04008DB0 RID: 36272
	private readonly UUIItem SourceItem;

	// Token: 0x04008DB1 RID: 36273
	private VisionDetailUnderComponent UnderComponent;

	// Token: 0x04008DB2 RID: 36274
	private VisionDetailInfoComponent VisionDetailInfoComponent;

	// Token: 0x02008A1A RID: 35354
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402CD8F RID: 183695
		UnderPanel,
		// Token: 0x0402CD90 RID: 183696
		InfoPanel
	}
}
