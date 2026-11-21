using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.AdventureGuide;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.RoleDev;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001D88 RID: 7560
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RoleDevPhantomVisionSuitItem : GridProxyAbstract<RoleDevPhantomVisionSuitItemData>
{
	// Token: 0x06012AA7 RID: 76455 RVA: 0x0057EA98 File Offset: 0x0057CC98
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUISprite)),
			new ValueTuple<int, Type>(5, typeof(UUITexture))
		};
	}

	// Token: 0x06012AA8 RID: 76456 RVA: 0x0057EB34 File Offset: 0x0057CD34
	protected override UniTask OnBeforeStartAsync()
	{
		RoleDevPhantomVisionSuitItem.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RoleDevPhantomVisionSuitItem.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06012AA9 RID: 76457 RVA: 0x0057EB77 File Offset: 0x0057CD77
	private void InitDetailVerticalLayout()
	{
		this.DetailVerticalLayout = new GenericLayout<RoleDevPhantomVisionSuitDisplayItem, IRoleDevPhantomSuitDisplayItemData>(base.GetHorizontalLayout(1), () => new RoleDevPhantomVisionSuitDisplayItem(), null, false, true);
	}

	// Token: 0x06012AAA RID: 76458 RVA: 0x0057EBB0 File Offset: 0x0057CDB0
	private UniTask InitButtonConfirm()
	{
		RoleDevPhantomVisionSuitItem.<InitButtonConfirm>d__7 <InitButtonConfirm>d__;
		<InitButtonConfirm>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitButtonConfirm>d__.<>4__this = this;
		<InitButtonConfirm>d__.<>1__state = -1;
		<InitButtonConfirm>d__.<>t__builder.Start<RoleDevPhantomVisionSuitItem.<InitButtonConfirm>d__7>(ref <InitButtonConfirm>d__);
		return <InitButtonConfirm>d__.<>t__builder.Task;
	}

	// Token: 0x06012AAB RID: 76459 RVA: 0x0057EBF4 File Offset: 0x0057CDF4
	public override void Refresh(RoleDevPhantomVisionSuitItemData data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		this.ButtonConfirm.SetFunction(new Action<int>(this.OnClickConfirm));
		this.ButtonConfirm.SetLocalTextNew(this.Data.ButtonName, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.Name, Array.Empty<object>());
		if (data.ItemType == EVisionSuitItemType.Dungeon)
		{
			base.GetSprite(4).SetUIActive(false);
			base.GetTexture(5).SetUIActive(true);
			base.SetTextureByPath(data.TypeIcon, base.GetTexture(5), null, null);
		}
		else if (data.ItemType == EVisionSuitItemType.Phantom)
		{
			base.GetSprite(4).SetUIActive(true);
			base.GetTexture(5).SetUIActive(false);
		}
		this.RefreshDisplayContent(data);
	}

	// Token: 0x06012AAC RID: 76460 RVA: 0x0057ECC4 File Offset: 0x0057CEC4
	private void RefreshDisplayContent(RoleDevPhantomVisionSuitItemData data)
	{
		List<IRoleDevPhantomSuitDisplayItemData> list = new List<IRoleDevPhantomSuitDisplayItemData>();
		if (data.MonsterDataList != null && data.MonsterDataList.Count > 0)
		{
			foreach (global::IPhantomMonsterItemData monsterData in data.MonsterDataList)
			{
				list.Add(new RoleDevPhantomSuitDisplayItemData
				{
					MonsterData = monsterData
				});
			}
		}
		if (data.RewardDataList != null && data.RewardDataList.Count > 0)
		{
			foreach (global::IDropRewardItemData rewardData in data.RewardDataList)
			{
				list.Add(new RoleDevPhantomSuitDisplayItemData
				{
					RewardData = rewardData
				});
			}
		}
		GenericLayout<RoleDevPhantomVisionSuitDisplayItem, IRoleDevPhantomSuitDisplayItemData> detailVerticalLayout = this.DetailVerticalLayout;
		if (detailVerticalLayout == null)
		{
			return;
		}
		detailVerticalLayout.RefreshByData(list, null, false);
	}

	// Token: 0x06012AAD RID: 76461 RVA: 0x0057EDB8 File Offset: 0x0057CFB8
	private void OnClickConfirm(int _)
	{
		if (this.Data == null)
		{
			return;
		}
		if (this.Data.DungeonId > 0)
		{
			this.HandleDungeonJump(this.Data.DungeonId);
			RoleDevController.Instance.LogRoleDevSubPageClick(this.Data.RoleId, ERoleDevMainPage.Phantom, ERoleDevSubPageButton.NoSoundZoneGo);
			return;
		}
		if (this.Data.FetterGroupId > 0)
		{
			RoleDevController.Instance.LogRoleDevSubPageClick(this.Data.RoleId, ERoleDevMainPage.Phantom, ERoleDevSubPageButton.Cost4Go);
			this.HandleOpenFettersView(this.Data.FetterGroupId, this.Data.RoleId, this.Data.RecommendGroupIds);
		}
	}

	// Token: 0x06012AAE RID: 76462 RVA: 0x0057EE54 File Offset: 0x0057D054
	private void HandleDungeonJump(int dungeonId)
	{
		if (GameModeController.Instance.IsInInstance())
		{
			GenericPromptController.Instance.ShowPromptByCode("DungeonDetection", Array.Empty<object>());
			return;
		}
		SilentAreaDetectionRecord silentAreaDetectData = AdventureGuideModel.Instance.GetSilentAreaDetectData(dungeonId);
		if (silentAreaDetectData == null)
		{
			return;
		}
		if (!AdventureGuideController.Instance.IsMarkUnlock(silentAreaDetectData.Conf.MarkId))
		{
			return;
		}
		AdventureGuideModel.Instance.SetFromManualDetect(true);
		AdventureGuideController.Instance.RequestForDetection(DetectionType.SilentArea, silentAreaDetectData.Conf.LevelPlayList(), dungeonId);
	}

	// Token: 0x06012AAF RID: 76463 RVA: 0x0057EED4 File Offset: 0x0057D0D4
	private void HandleOpenFettersView(int fetterGroupId, int roleId, List<int> recommendGroupIds)
	{
		bool flag = RoleModel.Instance.IsRoleOwned(roleId);
		UiManager.Instance.OpenView(EUiViewName.PhantomBattleFettersView, new object[]
		{
			fetterGroupId,
			roleId,
			flag,
			recommendGroupIds
		}, null);
	}

	// Token: 0x0400A211 RID: 41489
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<RoleDevPhantomVisionSuitDisplayItem, IRoleDevPhantomSuitDisplayItemData> DetailVerticalLayout;

	// Token: 0x0400A212 RID: 41490
	[Nullable(2)]
	private RoleDevPhantomVisionSuitItemData Data;

	// Token: 0x0400A213 RID: 41491
	[Nullable(2)]
	private ButtonItem ButtonConfirm;

	// Token: 0x0200809C RID: 32924
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x040299B1 RID: 170417
		TxtName,
		// Token: 0x040299B2 RID: 170418
		PanelDetailLayout,
		// Token: 0x040299B3 RID: 170419
		ItemBase,
		// Token: 0x040299B4 RID: 170420
		BtnConfirm,
		// Token: 0x040299B5 RID: 170421
		IconSprite,
		// Token: 0x040299B6 RID: 170422
		IconTexture
	}
}
