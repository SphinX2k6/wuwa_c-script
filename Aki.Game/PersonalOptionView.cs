using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Personal;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020023D9 RID: 9177
[NullableContext(1)]
[Nullable(0)]
public class PersonalOptionView : UiViewBase
{
	// Token: 0x06012577 RID: 75127 RVA: 0x00484B47 File Offset: 0x00482D47
	public PersonalOptionView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06012578 RID: 75128 RVA: 0x00484B50 File Offset: 0x00482D50
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUISprite)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(7, typeof(UUIText)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIGridLayout)),
			new ValueTuple<int, Type>(10, typeof(UUIText)),
			new ValueTuple<int, Type>(11, typeof(UUIText)),
			new ValueTuple<int, Type>(12, typeof(UUIItem)),
			new ValueTuple<int, Type>(13, typeof(UUIText)),
			new ValueTuple<int, Type>(14, typeof(UUIItem)),
			new ValueTuple<int, Type>(15, typeof(UUITexture)),
			new ValueTuple<int, Type>(16, typeof(UUIItem)),
			new ValueTuple<int, Type>(17, typeof(UUITexture)),
			new ValueTuple<int, Type>(18, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(19, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(18, new Action(this.OnClickXboxButton))
		};
	}

	// Token: 0x06012579 RID: 75129 RVA: 0x00484D50 File Offset: 0x00482F50
	private void OnClickXboxButton()
	{
		string thirdPartyUserId = PlayerInfoModel.Instance.GetThirdPartyUserId();
		if (!string.IsNullOrEmpty(thirdPartyUserId))
		{
			KuroSdkController.Instance.OpenProfileCard(thirdPartyUserId);
		}
	}

	// Token: 0x0601257A RID: 75130 RVA: 0x00484D7C File Offset: 0x00482F7C
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnBirthChange, new Action(this.OnBirthChange));
		EventSystem.Instance.Add<int>(EEventName.OnHeadIconChange, new Action<int>(this.OnHeadIconChange));
		EventSystem.Instance.Add(EEventName.OnNameChange, new Action(this.OnNameChange));
		EventSystem.Instance.Add(EEventName.OnSignChange, new Action(this.OnSignChange));
		EventSystem.Instance.Add(EEventName.OnPlayerTitleChange, new Action(this.RefreshPlayerTitle));
		EventSystem.Instance.Add(EEventName.OnCardChange, new Action(this.OnCardChange));
	}

	// Token: 0x0601257B RID: 75131 RVA: 0x00484E34 File Offset: 0x00483034
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnBirthChange, new Action(this.OnBirthChange));
		EventSystem.Instance.Remove(EEventName.OnHeadIconChange, new Action<int>(this.OnHeadIconChange));
		EventSystem.Instance.Remove(EEventName.OnNameChange, new Action(this.OnNameChange));
		EventSystem.Instance.Remove(EEventName.OnSignChange, new Action(this.OnSignChange));
		EventSystem.Instance.Remove(EEventName.OnPlayerTitleChange, new Action(this.RefreshPlayerTitle));
		EventSystem.Instance.Remove(EEventName.OnCardChange, new Action(this.OnCardChange));
	}

	// Token: 0x0601257C RID: 75132 RVA: 0x00484EEC File Offset: 0x004830EC
	protected override UniTask OnBeforeStartAsync()
	{
		PersonalOptionView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PersonalOptionView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601257D RID: 75133 RVA: 0x00484F30 File Offset: 0x00483130
	protected override void OnStart()
	{
		this.HeadPhotoItem = new PlayerHeadItem(base.GetItem(0).GetOwner());
		this.RefreshOptions();
		this.RefreshPlayerName();
		this.RefreshSign();
		int? playerLevel = FunctionModel.Instance.GetPlayerLevel();
		if (playerLevel != null)
		{
			base.GetText(5).SetText(playerLevel.ToString(), true);
		}
		this.RefreshIcon();
		this.RefreshPlayStationItem();
		base.GetText(4).SetText("", true);
		LguiUtil.Instance.SetLocalText(base.GetText(10), "SetPersonalData", Array.Empty<object>());
		this.RefreshCard();
	}

	// Token: 0x0601257E RID: 75134 RVA: 0x00484FD4 File Offset: 0x004831D4
	private ILayoutItem<PersonalOptionItem> InitPersonalOptionItem(object optionId, UUIItem uiItem, int index)
	{
		PersonalOptionItem personalOptionItem = new PersonalOptionItem(uiItem);
		personalOptionItem.Refresh((int)optionId, false, index);
		return new LayoutItem<PersonalOptionItem>
		{
			Key = index,
			Value = personalOptionItem
		};
	}

	// Token: 0x0601257F RID: 75135 RVA: 0x0048500E File Offset: 0x0048320E
	protected override void OnAfterShow()
	{
	}

	// Token: 0x06012580 RID: 75136 RVA: 0x00485010 File Offset: 0x00483210
	private void RefreshIcon()
	{
		int headIconId = PlayerInfoModel.Instance.GetHeadIconId();
		this.HeadPhotoItem.RefreshByRoleId(headIconId);
	}

	// Token: 0x06012581 RID: 75137 RVA: 0x00485034 File Offset: 0x00483234
	private void RefreshPlayStationItem()
	{
		if (KuroSdkController.Instance.NeedShowThirdPartyId())
		{
			string thirdPartyUserId = PlayerInfoModel.Instance.GetThirdPartyUserId();
			string thirdPartyOnlineId = PlayerInfoModel.Instance.GetThirdPartyOnlineId();
			bool flag = thirdPartyUserId != "";
			UUIItem item = base.GetItem(12);
			if (item != null)
			{
				item.SetUIActive(flag && Info.Instance.IsPs5Platform());
			}
			UUITexture texture = base.GetTexture(15);
			if (texture != null)
			{
				texture.SetUIActive(flag && Info.Instance.IsPs5Platform());
			}
			if (flag && Info.Instance.IsPs5Platform())
			{
				UUIText text = base.GetText(13);
				if (text != null)
				{
					text.SetText(thirdPartyOnlineId, true);
				}
			}
			UUIButtonComponent button = base.GetButton(18);
			if (button != null)
			{
				UUIItem uuiitem = button.RootUIComp.Get();
				if (uuiitem != null)
				{
					uuiitem.SetUIActive(flag && Info.Instance.IsXboxPlatform());
				}
			}
			if (flag && Info.Instance.IsXboxPlatform())
			{
				UUIText text2 = base.GetText(19);
				if (text2 != null)
				{
					text2.SetText(thirdPartyOnlineId, true);
				}
			}
			UUIItem item2 = base.GetItem(16);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(!flag);
			return;
		}
		else
		{
			UUIItem item3 = base.GetItem(12);
			if (item3 != null)
			{
				item3.SetUIActive(false);
			}
			UUITexture texture2 = base.GetTexture(15);
			if (texture2 != null)
			{
				texture2.SetUIActive(false);
			}
			UUIItem item4 = base.GetItem(16);
			if (item4 == null)
			{
				return;
			}
			item4.SetUIActive(false);
			return;
		}
	}

	// Token: 0x06012582 RID: 75138 RVA: 0x00485188 File Offset: 0x00483388
	private void RefreshPlayerName()
	{
		string playerName = FunctionModel.Instance.GetPlayerName();
		if (playerName != null)
		{
			base.GetText(2).SetText(playerName, true);
		}
	}

	// Token: 0x06012583 RID: 75139 RVA: 0x004851B4 File Offset: 0x004833B4
	private void RefreshSign()
	{
		string signature = PersonalModel.Instance.GetSignature();
		UUIText text = base.GetText(11);
		if (signature != null && signature != "")
		{
			text.SetText(signature, true);
			return;
		}
		LguiUtil.Instance.SetLocalText(text, "EmptySign", Array.Empty<object>());
	}

	// Token: 0x06012584 RID: 75140 RVA: 0x00485204 File Offset: 0x00483404
	private void RefreshCard()
	{
		int curCardId = PersonalModel.Instance.GetCurCardId();
		BackgroundCard? config = ConfigBackgroundCardById.GetConfig(curCardId, true);
		if (config != null)
		{
			base.SetTextureByPath(config.Value.FunctionViewCardPath, base.GetTexture(17), null, null);
		}
	}

	// Token: 0x06012585 RID: 75141 RVA: 0x00485254 File Offset: 0x00483454
	private void OnBirthChange()
	{
		this.RefreshOptions();
	}

	// Token: 0x06012586 RID: 75142 RVA: 0x0048525C File Offset: 0x0048345C
	private void OnHeadIconChange(int roleId)
	{
		this.RefreshIcon();
	}

	// Token: 0x06012587 RID: 75143 RVA: 0x00485264 File Offset: 0x00483464
	private void OnNameChange()
	{
		this.RefreshPlayerName();
	}

	// Token: 0x06012588 RID: 75144 RVA: 0x0048526C File Offset: 0x0048346C
	private void OnSignChange()
	{
		this.RefreshSign();
	}

	// Token: 0x06012589 RID: 75145 RVA: 0x00485274 File Offset: 0x00483474
	private void RefreshPlayerTitle()
	{
		PlayerTitleItem titleItem = this.TitleItem;
		if (titleItem == null)
		{
			return;
		}
		titleItem.Refresh(new int?(PersonalModel.Instance.GetDressedPlayerTitleId()), new int?(PersonalModel.Instance.GetDressedPlayerTitleLevel()), new int?(PersonalModel.Instance.GetSex()));
	}

	// Token: 0x0601258A RID: 75146 RVA: 0x004852B3 File Offset: 0x004834B3
	private void OnCardChange()
	{
		this.RefreshCard();
	}

	// Token: 0x0601258B RID: 75147 RVA: 0x004852BC File Offset: 0x004834BC
	protected void RefreshOptions()
	{
		List<int> list = new List<int>();
		list.Add(6);
		if (FunctionModel.Instance.IsOpen(10061))
		{
			list.Add(7);
		}
		if (FunctionModel.Instance.IsOpen(10082))
		{
			list.Add(14);
		}
		list.Add(8);
		list.Add(9);
		list.Add(10);
		if (!Info.Instance.IsHomeConsolePlatform())
		{
			list.Add(11);
		}
		if (FunctionModel.Instance.IsOpen(10060))
		{
			list.Add(15);
		}
		if (this.PersonalOptionItemLayout == null)
		{
			this.PersonalOptionItemLayout = new GenericLayoutNew<PersonalOptionItem>(base.GetGridLayout(9), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<PersonalOptionItem>(this.InitPersonalOptionItem), null);
		}
		this.PersonalOptionItemLayout.ClearChildren();
		list.Sort(delegate(int a, int b)
		{
			PersonalTips value = ConfigPersonalTipsById.GetConfig(a, true).Value;
			PersonalTips value2 = ConfigPersonalTipsById.GetConfig(b, true).Value;
			return value.Sort - value2.Sort;
		});
		this.PersonalOptionItemLayout.RebuildLayoutByDataNew<int>(list, null);
	}

	// Token: 0x0601258C RID: 75148 RVA: 0x004853B8 File Offset: 0x004835B8
	protected override void OnBeforeDestroy()
	{
		if (this.PersonalOptionItemLayout != null)
		{
			this.PersonalOptionItemLayout.ClearChildren();
			this.PersonalOptionItemLayout = null;
		}
		if (this.TitleItem != null)
		{
			this.TitleItem.Destroy(null);
			this.TitleItem = null;
		}
	}

	// Token: 0x0601258D RID: 75149 RVA: 0x004853F0 File Offset: 0x004835F0
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		if (configParams.Length == 0)
		{
			return null;
		}
		int num = 3;
		if (FunctionModel.Instance.IsOpen(10061))
		{
			num++;
		}
		if (FunctionModel.Instance.IsOpen(10082))
		{
			num++;
		}
		UUIItem grid = this.PersonalOptionItemLayout.GetGrid(num);
		if (grid != null)
		{
			return new UUIItem[]
			{
				grid,
				grid
			};
		}
		return null;
	}

	// Token: 0x04008AC6 RID: 35526
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayoutNew<PersonalOptionItem> PersonalOptionItemLayout;

	// Token: 0x04008AC7 RID: 35527
	[Nullable(2)]
	private PlayerHeadItem HeadPhotoItem;

	// Token: 0x04008AC8 RID: 35528
	[Nullable(2)]
	private PlayerTitleItem TitleItem;
}
