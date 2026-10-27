using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Personal;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200117F RID: 4479
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class BabelTowerRankItem : GridProxyAbstract<BabelTowerRankItemData>
{
	// Token: 0x0600766A RID: 30314 RVA: 0x00189B00 File Offset: 0x00187D00
	protected unsafe override void OnRegisterComponent()
	{
		int num = 13;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(12, new Action(this.OnClickAvatarBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600766B RID: 30315 RVA: 0x00189D18 File Offset: 0x00187F18
	protected override void OnStart()
	{
		UUILayoutBase horizontalLayout = base.GetHorizontalLayout(8);
		Func<RoleGridProxy> gridProxyCreateFunction = () => new RoleGridProxy();
		UUIItem item = base.GetItem(9);
		this.RoleLayout = new GenericLayout<RoleGridProxy, RoleData>(horizontalLayout, gridProxyCreateFunction, ((item != null) ? item.GetOwner() : null) as AUIBaseActor, false, true);
		this.TitleItem = new PlayerTitleItem();
		this.TitleItem.CreateThenShowByActor(base.GetItem(7).GetOwner(), null);
	}

	// Token: 0x0600766C RID: 30316 RVA: 0x00189D94 File Offset: 0x00187F94
	public override void Refresh(BabelTowerRankItemData data, bool isSelected, int gridIndex)
	{
		this.CurrentData = data;
		int rank = gridIndex + 1;
		if (!data.HasData)
		{
			this.ShowLockState();
			return;
		}
		this.RefreshRankDisplay(rank);
		this.RefreshPlayerInfo(data);
		this.RefreshRoleList(data);
		bool selfInteractive = !data.IsMyRank && data.ShowName;
		UUIButtonComponent button = base.GetButton(12);
		if (button == null)
		{
			return;
		}
		button.SetSelfInteractive(selfInteractive);
	}

	// Token: 0x0600766D RID: 30317 RVA: 0x00189DF7 File Offset: 0x00187FF7
	public void ShowLockState()
	{
		UUIItem item = base.GetItem(0);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		UUIItem item2 = base.GetItem(1);
		if (item2 == null)
		{
			return;
		}
		item2.SetUIActive(true);
	}

	// Token: 0x0600766E RID: 30318 RVA: 0x00189E20 File Offset: 0x00188020
	private void RefreshRankDisplay(int rank)
	{
		UUITexture texture = base.GetTexture(2);
		UUITexture texture2 = base.GetTexture(3);
		UUIText text = base.GetText(4);
		if (rank <= 3)
		{
			if (texture != null)
			{
				texture.SetUIActive(true);
			}
			if (texture2 != null)
			{
				texture2.SetUIActive(false);
			}
			if (text != null)
			{
				text.SetUIActive(true);
			}
			if (text != null)
			{
				text.SetText(rank.ToString(), true);
			}
			this.SetRankTextOutline(text, rank);
			UUIItem item = base.GetItem(0);
			if (item != null)
			{
				item.SetUIActive(true);
			}
			UUIItem item2 = base.GetItem(1);
			if (item2 != null)
			{
				item2.SetUIActive(false);
			}
			this.LoadTopRankDecoration(rank, texture);
			return;
		}
		if (texture != null)
		{
			texture.SetUIActive(false);
		}
		if (texture2 != null)
		{
			texture2.SetUIActive(false);
		}
		if (text != null)
		{
			text.SetUIActive(true);
		}
		if (text != null)
		{
			text.SetText(rank.ToString(), true);
		}
		UUIItem item3 = base.GetItem(0);
		if (item3 != null)
		{
			item3.SetUIActive(true);
		}
		UUIItem item4 = base.GetItem(1);
		if (item4 != null)
		{
			item4.SetUIActive(false);
		}
		this.SetRankTextOutline(text, rank);
	}

	// Token: 0x0600766F RID: 30319 RVA: 0x00189F0C File Offset: 0x0018810C
	[NullableContext(2)]
	private void SetRankTextOutline(UUIText text, int rank)
	{
		if (text == null)
		{
			return;
		}
		string text2;
		switch (rank)
		{
		case 1:
			text2 = "#cb9c38";
			break;
		case 2:
			text2 = "#727794";
			break;
		case 3:
			text2 = "#8b7368";
			break;
		default:
			text2 = "#696969";
			break;
		}
		string hexStr = text2;
		text.SetFontOutlineColor(FColor.FromHex(hexStr));
	}

	// Token: 0x06007670 RID: 30320 RVA: 0x00189F60 File Offset: 0x00188160
	[NullableContext(2)]
	private void LoadTopRankDecoration(int rank, UUITexture texture)
	{
		if (texture == null)
		{
			return;
		}
		string text = (rank >= 0 && rank < BabelTowerDefine.babelTowerRankDecoPath.Count) ? BabelTowerDefine.babelTowerRankDecoPath[rank] : null;
		if (!string.IsNullOrEmpty(text))
		{
			UiResourceConfig instance = UiResourceConfig.Instance;
			string text2 = (instance != null) ? instance.GetResourcePath(text) : null;
			if (!string.IsNullOrEmpty(text2))
			{
				base.SetTextureByPath(text2, texture, null, null);
				return;
			}
		}
		texture.SetUIActive(false);
	}

	// Token: 0x06007671 RID: 30321 RVA: 0x00189FD0 File Offset: 0x001881D0
	private void RefreshPlayerInfo(BabelTowerRankItemData data)
	{
		if (!data.HasData)
		{
			return;
		}
		UUIText text = base.GetText(6);
		if (text != null)
		{
			text.SetUIActive(true);
		}
		if (!data.ShowName)
		{
			LguiUtil.Instance.SetLocalTextNew(text, "BabelRanking_Anonymous", Array.Empty<object>());
		}
		else if (text != null)
		{
			text.SetText(data.Name, true);
		}
		this.RefreshHeadIcon(data.HeadId, data.ShowName);
		this.RefreshTitle(data);
		UUIText text2 = base.GetText(10);
		if (text2 != null)
		{
			text2.SetText(data.PassStar.ToString(), true);
		}
		string timeDataFormatWithHour = TimeUtil.Instance.GetTimeDataFormatWithHour((double)data.PassTime);
		UUIText text3 = base.GetText(11);
		if (text3 == null)
		{
			return;
		}
		text3.SetText(timeDataFormatWithHour, true);
	}

	// Token: 0x06007672 RID: 30322 RVA: 0x0018A088 File Offset: 0x00188288
	private void RefreshTitle(BabelTowerRankItemData data)
	{
		if (this.TitleItem == null)
		{
			return;
		}
		if (data.ShowName && data.TitleId > 0)
		{
			PersonalModel instance = PersonalModel.Instance;
			int? sex = (instance != null) ? new int?(instance.GetSex()) : null;
			this.TitleItem.Refresh(new int?(data.TitleId), new int?(data.TitleStarLevel), sex);
			return;
		}
		this.TitleItem.SetUiActive(false);
	}

	// Token: 0x06007673 RID: 30323 RVA: 0x0018A100 File Offset: 0x00188300
	private void RefreshHeadIcon(int headId, bool bShowName = true)
	{
		UUITexture headTexture = base.GetTexture(5);
		if (headTexture == null)
		{
			return;
		}
		if (!bShowName)
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath("T_IconRoleHeadCircle256_2031_UI");
			base.SetTextureShowUntilLoaded(resourcePath, headTexture, null);
			return;
		}
		if (headId > 0)
		{
			PlayerHeadData playerHeadData = PersonalModel.Instance.GetPlayerHeadData(headId, false);
			if (playerHeadData != null)
			{
				headTexture.SetUIActive(false);
				base.SetTextureByPath(playerHeadData.GetRoleHeadIconCircle(), headTexture, null, delegate(bool _)
				{
					headTexture.SetUIActive(true);
				});
				return;
			}
		}
		else
		{
			headTexture.SetUIActive(false);
		}
	}

	// Token: 0x06007674 RID: 30324 RVA: 0x0018A1A0 File Offset: 0x001883A0
	private void RefreshRoleList(BabelTowerRankItemData data)
	{
		if (data.ShowRoleList)
		{
			GenericLayout<RoleGridProxy, RoleData> roleLayout = this.RoleLayout;
			if (roleLayout != null)
			{
				roleLayout.SetActive(true);
			}
			List<int> list = data.RoleIdList ?? new List<int>();
			List<int> list2 = data.RoleLevelList ?? new List<int>();
			List<RoleData> list3 = new List<RoleData>();
			for (int i = 0; i < 3; i++)
			{
				if (i < list.Count)
				{
					list3.Add(new RoleData
					{
						RoleId = list[i],
						RoleLevel = ((i < list2.Count) ? list2[i] : 0)
					});
				}
				else
				{
					list3.Add(new RoleData
					{
						RoleId = 0,
						RoleLevel = 0
					});
				}
			}
			if (this.RoleLayout != null)
			{
				this.RoleLayout.RefreshByData(list3, null, false);
			}
			return;
		}
		GenericLayout<RoleGridProxy, RoleData> roleLayout2 = this.RoleLayout;
		if (roleLayout2 == null)
		{
			return;
		}
		roleLayout2.SetActive(false);
	}

	// Token: 0x06007675 RID: 30325 RVA: 0x0018A278 File Offset: 0x00188478
	private void OnClickAvatarBtn()
	{
		if (this.CurrentData == null || !this.CurrentData.ShowName)
		{
			return;
		}
		if (this.CurrentData.PlayerId <= 0)
		{
			return;
		}
		FriendModel instance = FriendModel.Instance;
		if (instance.IsMyFriend(this.CurrentData.PlayerId))
		{
			instance.SelectedPlayerId = new int?(this.CurrentData.PlayerId);
			instance.ShowingView = new EUiViewName?(EUiViewName.FriendView);
			instance.FilterState = new EFriendFilter?(EFriendFilter.FriendList);
			UiManager.Instance.OpenView(EUiViewName.FriendProcessView, null, null);
		}
	}

	// Token: 0x0400364B RID: 13899
	private const int MAX_ROLE_COUNT = 3;

	// Token: 0x0400364C RID: 13900
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<RoleGridProxy, RoleData> RoleLayout;

	// Token: 0x0400364D RID: 13901
	[Nullable(2)]
	private PlayerTitleItem TitleItem;

	// Token: 0x0400364E RID: 13902
	[Nullable(2)]
	private BabelTowerRankItemData CurrentData;

	// Token: 0x02007756 RID: 30550
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x040275DC RID: 161244
		UnlockItem,
		// Token: 0x040275DD RID: 161245
		LockItem,
		// Token: 0x040275DE RID: 161246
		RankNumTexture,
		// Token: 0x040275DF RID: 161247
		RankNorTexture,
		// Token: 0x040275E0 RID: 161248
		RankNumText,
		// Token: 0x040275E1 RID: 161249
		AvatarTexture,
		// Token: 0x040275E2 RID: 161250
		PlayerNameText,
		// Token: 0x040275E3 RID: 161251
		TitlesComItem,
		// Token: 0x040275E4 RID: 161252
		RoleListHLayout,
		// Token: 0x040275E5 RID: 161253
		ItemBase,
		// Token: 0x040275E6 RID: 161254
		TxtNumText,
		// Token: 0x040275E7 RID: 161255
		TxtTimeText,
		// Token: 0x040275E8 RID: 161256
		AvatarBtn
	}
}
