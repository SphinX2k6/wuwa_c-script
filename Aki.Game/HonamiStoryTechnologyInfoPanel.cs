using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020013C6 RID: 5062
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryTechnologyInfoPanel : UiPanelBase
{
	// Token: 0x0600C89B RID: 51355 RVA: 0x003BB5DC File Offset: 0x003B97DC
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

	// Token: 0x0600C89C RID: 51356 RVA: 0x003BB6D4 File Offset: 0x003B98D4
	protected override UniTask OnBeforeStartAsync()
	{
		HonamiStoryTechnologyInfoPanel.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<HonamiStoryTechnologyInfoPanel.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C89D RID: 51357 RVA: 0x003BB718 File Offset: 0x003B9918
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

	// Token: 0x0600C89E RID: 51358 RVA: 0x003BB98C File Offset: 0x003B9B8C
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

	// Token: 0x04007202 RID: 29186
	private HonamiStoryTechNodeData CurSelectNode;

	// Token: 0x04007203 RID: 29187
	[Nullable(2)]
	private ButtonItem ConfirmBtnItem;

	// Token: 0x04007204 RID: 29188
	[Nullable(2)]
	private CommonCostItem CostItem;

	// Token: 0x04007205 RID: 29189
	[Nullable(2)]
	private FunctionalPanelConditionLock LockTipsItem;

	// Token: 0x04007206 RID: 29190
	private readonly string LockBgPath = "/Game/Aki/UI/UIResources/UiActivity/Atlas/Activity28/HonamiStory/HonamiStorySkillTree/SP_SkillFrmLockNor.SP_SkillFrmLockNor";

	// Token: 0x04007207 RID: 29191
	private readonly string UnLockBgPath = "/Game/Aki/UI/UIResources/UiActivity/Atlas/Activity28/HonamiStory/HonamiStorySkillTree/SP_SkillFrmANor.SP_SkillFrmANor";

	// Token: 0x0200768D RID: 30349
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x040267D8 RID: 157656
		SprTechIconBg,
		// Token: 0x040267D9 RID: 157657
		TexTechIcon,
		// Token: 0x040267DA RID: 157658
		TxtTechTitle,
		// Token: 0x040267DB RID: 157659
		TxtMidSkillInfo,
		// Token: 0x040267DC RID: 157660
		PnlCost,
		// Token: 0x040267DD RID: 157661
		BtnConfirm,
		// Token: 0x040267DE RID: 157662
		PnlLockTips,
		// Token: 0x040267DF RID: 157663
		TxtTechDesc,
		// Token: 0x040267E0 RID: 157664
		PnlUnLockTips,
		// Token: 0x040267E1 RID: 157665
		TxtMidSkillTitle
	}
}
