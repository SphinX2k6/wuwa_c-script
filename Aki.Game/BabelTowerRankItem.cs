using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Personal;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000633 RID: 1587
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class BabelTowerRankItem : GridProxyAbstract<BabelTowerRankItemData>
{
	// Token: 0x06004A01 RID: 18945 RVA: 0x001926B0 File Offset: 0x001908B0
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

	// Token: 0x06004A02 RID: 18946 RVA: 0x001928C8 File Offset: 0x00190AC8
	protected override void OnStart()
	{
		UUILayoutBase horizontalLayout = base.GetHorizontalLayout(8);
		Func<RoleGridProxy> gridProxyCreateFunction = () => new RoleGridProxy();
		UUIItem item = base.GetItem(9);
		this.RoleLayout = new GenericLayout<RoleGridProxy, RoleData>(horizontalLayout, gridProxyCreateFunction, ((item != null) ? item.GetOwner() : null) as AUIBaseActor, false, true);
		this.TitleItem = new PlayerTitleItem();
		this.TitleItem.CreateThenShowByActor(base.GetItem(7).GetOwner(), null);
	}

	// Token: 0x06004A03 RID: 18947 RVA: 0x00192944 File Offset: 0x00190B44
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

	// Token: 0x06004A04 RID: 18948 RVA: 0x001929A7 File Offset: 0x00190BA7
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

	// Token: 0x06004A05 RID: 18949 RVA: 0x001929D0 File Offset: 0x00190BD0
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

	// Token: 0x06004A06 RID: 18950 RVA: 0x00192ABC File Offset: 0x00190CBC
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

	// Token: 0x06004A07 RID: 18951 RVA: 0x00192B10 File Offset: 0x00190D10
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

	// Token: 0x06004A08 RID: 18952 RVA: 0x00192B80 File Offset: 0x00190D80
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

	// Token: 0x06004A09 RID: 18953 RVA: 0x00192C38 File Offset: 0x00190E38
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

	// Token: 0x06004A0A RID: 18954 RVA: 0x00192CB0 File Offset: 0x00190EB0
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

	// Token: 0x06004A0B RID: 18955 RVA: 0x00192D50 File Offset: 0x00190F50
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

	// Token: 0x06004A0C RID: 18956 RVA: 0x00192E28 File Offset: 0x00191028
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

	// Token: 0x040036E4 RID: 14052
	private const int MAX_ROLE_COUNT = 3;

	// Token: 0x040036E5 RID: 14053
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<RoleGridProxy, RoleData> RoleLayout;

	// Token: 0x040036E6 RID: 14054
	[Nullable(2)]
	private PlayerTitleItem TitleItem;

	// Token: 0x040036E7 RID: 14055
	[Nullable(2)]
	private BabelTowerRankItemData CurrentData;

	// Token: 0x020068E3 RID: 26851
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x04022915 RID: 141589
		UnlockItem,
		// Token: 0x04022916 RID: 141590
		LockItem,
		// Token: 0x04022917 RID: 141591
		RankNumTexture,
		// Token: 0x04022918 RID: 141592
		RankNorTexture,
		// Token: 0x04022919 RID: 141593
		RankNumText,
		// Token: 0x0402291A RID: 141594
		AvatarTexture,
		// Token: 0x0402291B RID: 141595
		PlayerNameText,
		// Token: 0x0402291C RID: 141596
		TitlesComItem,
		// Token: 0x0402291D RID: 141597
		RoleListHLayout,
		// Token: 0x0402291E RID: 141598
		ItemBase,
		// Token: 0x0402291F RID: 141599
		TxtNumText,
		// Token: 0x04022920 RID: 141600
		TxtTimeText,
		// Token: 0x04022921 RID: 141601
		AvatarBtn
	}
}
