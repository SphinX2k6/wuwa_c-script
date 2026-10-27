using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001F04 RID: 7940
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryTechnologyInfoPanel : UiPanelBase
{
	// Token: 0x0600F47C RID: 62588 RVA: 0x003AFAE8 File Offset: 0x003ADCE8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIText)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIText))
		};
	}

	// Token: 0x0600F47D RID: 62589 RVA: 0x003AFBE0 File Offset: 0x003ADDE0
	protected override UniTask OnBeforeStartAsync()
	{
		HonamiStoryTechnologyInfoPanel.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<HonamiStoryTechnologyInfoPanel.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600F47E RID: 62590 RVA: 0x003AFC24 File Offset: 0x003ADE24
	public void Refresh(HonamiStoryTechNodeData data)
	{
		if (data == null)
		{
			return;
		}
		this.CurSelectNode = data;
		HonamiStoryTalent getConfig = this.CurSelectNode.GetConfig;
		bool flag = HonamiStoryModel.Instance.CheckNodeCanActiveAndIsEnough(data);
		string path = (this.CurSelectNode.GetNodeStatus == ENodeStatus.IsActive) ? this.UnLockBgPath : this.LockBgPath;
		this.SetSpriteByPath(path, base.GetSprite(0), false, null, null);
		base.SetTextureByPath(getConfig.Icon, base.GetTexture(1), null, null);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), getConfig.Name, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(7), getConfig.Desc, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(9), getConfig.MidTitle, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), getConfig.MidDexc, Array.Empty<object>());
		Dictionary<int, int> dictionary = getConfig.ConsumeItems();
		if (dictionary == null || dictionary.Count == 0)
		{
			this.CostItem.SetUiActive(false);
		}
		else
		{
			this.CostItem.SetUiActive(true);
			foreach (KeyValuePair<int, int> keyValuePair in dictionary)
			{
				int key = keyValuePair.Key;
				int value = keyValuePair.Value;
				this.CostItem.UpdateItem(key, value);
				this.CostItem.RefreshCountEnableState();
			}
		}
		base.GetItem(5).SetUIActive(false);
		base.GetItem(6).SetUIActive(false);
		base.GetItem(8).SetUIActive(false);
		switch (this.CurSelectNode.GetNodeStatus)
		{
		case ENodeStatus.Lock:
		{
			base.GetItem(6).SetUIActive(true);
			if (!data.PreNodeIsActive)
			{
				this.LockTipsItem.SetTextByTextId("HonamiStory_Tech_PreNodeLock", Array.Empty<string>());
				return;
			}
			string lockPanelTip = data.GetConfig.LockPanelTip;
			this.LockTipsItem.SetTextByTextId(lockPanelTip, Array.Empty<string>());
			return;
		}
		case ENodeStatus.CanActive:
			if (flag)
			{
				base.GetItem(5).SetUIActive(true);
				return;
			}
			base.GetItem(6).SetUIActive(true);
			this.LockTipsItem.SetTextByTextId("HonamiStory_Tech_NotEnough", Array.Empty<string>());
			return;
		case ENodeStatus.IsActive:
			this.CostItem.SetUiActive(false);
			base.GetItem(8).SetUIActive(true);
			return;
		default:
			return;
		}
	}

	// Token: 0x0600F47F RID: 62591 RVA: 0x003AFE98 File Offset: 0x003AE098
	private void OnClickConfirmBtn(int _)
	{
		HonamiStoryController.Instance.SendHonamiStoryActivateTalentRequest(this.CurSelectNode.Id, delegate
		{
			HonamiStoryModel instance = HonamiStoryModel.Instance;
			HonamiStoryTechnologyNodeItem currentSelectNodeItem = instance.CurrentSelectNodeItem;
			if (currentSelectNodeItem != null)
			{
				currentSelectNodeItem.PlayActivateAnim();
			}
			if (instance.CurrentSelectNode != null)
			{
				UiManager.Instance.OpenView(EUiViewName.HonamiStoryTechSuccessEffectView, instance.CurrentSelectNode.GetConfig, null);
			}
		});
	}

	// Token: 0x04007121 RID: 28961
	private HonamiStoryTechNodeData CurSelectNode;

	// Token: 0x04007122 RID: 28962
	[Nullable(2)]
	private ButtonItem ConfirmBtnItem;

	// Token: 0x04007123 RID: 28963
	[Nullable(2)]
	private CommonCostItem CostItem;

	// Token: 0x04007124 RID: 28964
	[Nullable(2)]
	private FunctionalPanelConditionLock LockTipsItem;

	// Token: 0x04007125 RID: 28965
	private readonly string LockBgPath = "/Game/Aki/UI/UIResources/UiActivity/Atlas/Activity28/HonamiStory/HonamiStorySkillTree/SP_SkillFrmLockNor.SP_SkillFrmLockNor";

	// Token: 0x04007126 RID: 28966
	private readonly string UnLockBgPath = "/Game/Aki/UI/UIResources/UiActivity/Atlas/Activity28/HonamiStory/HonamiStorySkillTree/SP_SkillFrmANor.SP_SkillFrmANor";

	// Token: 0x02008508 RID: 34056
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402B4B4 RID: 177332
		SprTechIconBg,
		// Token: 0x0402B4B5 RID: 177333
		TexTechIcon,
		// Token: 0x0402B4B6 RID: 177334
		TxtTechTitle,
		// Token: 0x0402B4B7 RID: 177335
		TxtMidSkillInfo,
		// Token: 0x0402B4B8 RID: 177336
		PnlCost,
		// Token: 0x0402B4B9 RID: 177337
		BtnConfirm,
		// Token: 0x0402B4BA RID: 177338
		PnlLockTips,
		// Token: 0x0402B4BB RID: 177339
		TxtTechDesc,
		// Token: 0x0402B4BC RID: 177340
		PnlUnLockTips,
		// Token: 0x0402B4BD RID: 177341
		TxtMidSkillTitle
	}
}
