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

// Token: 0x0200280D RID: 10253
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RoleDevPhantomVisionSuitItem : GridProxyAbstract<RoleDevPhantomVisionSuitItemData>
{
	// Token: 0x060150A7 RID: 86183 RVA: 0x00553CC4 File Offset: 0x00551EC4
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

	// Token: 0x060150A8 RID: 86184 RVA: 0x00553D60 File Offset: 0x00551F60
	protected override UniTask OnBeforeStartAsync()
	{
		RoleDevPhantomVisionSuitItem.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RoleDevPhantomVisionSuitItem.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060150A9 RID: 86185 RVA: 0x00553DA3 File Offset: 0x00551FA3
	private void InitDetailVerticalLayout()
	{
		this.DetailVerticalLayout = new GenericLayout<RoleDevPhantomVisionSuitDisplayItem, IRoleDevPhantomSuitDisplayItemData>(base.GetHorizontalLayout(1), () => new RoleDevPhantomVisionSuitDisplayItem(), null, false, true);
	}

	// Token: 0x060150AA RID: 86186 RVA: 0x00553DDC File Offset: 0x00551FDC
	private UniTask InitButtonConfirm()
	{
		RoleDevPhantomVisionSuitItem.<InitButtonConfirm>d__7 <InitButtonConfirm>d__;
		<InitButtonConfirm>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitButtonConfirm>d__.<>4__this = this;
		<InitButtonConfirm>d__.<>1__state = -1;
		<InitButtonConfirm>d__.<>t__builder.Start<RoleDevPhantomVisionSuitItem.<InitButtonConfirm>d__7>(ref <InitButtonConfirm>d__);
		return <InitButtonConfirm>d__.<>t__builder.Task;
	}

	// Token: 0x060150AB RID: 86187 RVA: 0x00553E20 File Offset: 0x00552020
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

	// Token: 0x060150AC RID: 86188 RVA: 0x00553EF0 File Offset: 0x005520F0
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

	// Token: 0x060150AD RID: 86189 RVA: 0x00553FE4 File Offset: 0x005521E4
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

	// Token: 0x060150AE RID: 86190 RVA: 0x00554080 File Offset: 0x00552280
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

	// Token: 0x060150AF RID: 86191 RVA: 0x00554100 File Offset: 0x00552300
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

	// Token: 0x04009E28 RID: 40488
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<RoleDevPhantomVisionSuitDisplayItem, IRoleDevPhantomSuitDisplayItemData> DetailVerticalLayout;

	// Token: 0x04009E29 RID: 40489
	[Nullable(2)]
	private RoleDevPhantomVisionSuitItemData Data;

	// Token: 0x04009E2A RID: 40490
	[Nullable(2)]
	private ButtonItem ButtonConfirm;

	// Token: 0x02008E54 RID: 36436
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402E2B5 RID: 189109
		TxtName,
		// Token: 0x0402E2B6 RID: 189110
		PanelDetailLayout,
		// Token: 0x0402E2B7 RID: 189111
		ItemBase,
		// Token: 0x0402E2B8 RID: 189112
		BtnConfirm,
		// Token: 0x0402E2B9 RID: 189113
		IconSprite,
		// Token: 0x0402E2BA RID: 189114
		IconTexture
	}
}
