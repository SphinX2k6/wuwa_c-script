using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Character.Role.Common.Data.Enum;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001E5A RID: 7770
public class RolePreviewAttributeTabView : UiTabViewBase
{
	// Token: 0x06013388 RID: 78728 RVA: 0x0059E15C File Offset: 0x0059C35C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(8, typeof(UUITexture))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(7, new Action(this.RoleTagClick))
		};
	}

	// Token: 0x06013389 RID: 78729 RVA: 0x0059E260 File Offset: 0x0059C460
	protected override void OnStart()
	{
		this.RoleViewAgent = (this.ExtraParams as RoleViewAgent);
		if (this.RoleViewAgent == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Role;
			ELogAuthor author = ELogAuthor.BB;
			string message = "RoleViewAgent为空";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("界面名称", "RolePreviewAttributeTabView");
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.AttributeLayout = new GenericLayoutNew<CSharpScript.Game.Module.RoleUi.RoleAttributeItem>(base.GetVerticalLayout(3), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<CSharpScript.Game.Module.RoleUi.RoleAttributeItem>(this.InitRoleAttributeItem), null);
		this.RoleTagLayout = new GenericLayout<RoleTagSmallIconItem, int>(base.GetHorizontalLayout(5), new Func<RoleTagSmallIconItem>(this.InitRoleTagItem), null, false, true);
	}

	// Token: 0x0601338A RID: 78730 RVA: 0x0059E2F2 File Offset: 0x0059C4F2
	protected override void AddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.RoleSystemChangeRole, new Action<int>(this.OnRoleChange));
	}

	// Token: 0x0601338B RID: 78731 RVA: 0x0059E310 File Offset: 0x0059C510
	protected override void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RoleSystemChangeRole, new Action<int>(this.OnRoleChange));
	}

	// Token: 0x0601338C RID: 78732 RVA: 0x0059E330 File Offset: 0x0059C530
	protected override void OnBeforeShow()
	{
		this.PlayMontageStart();
		int curSelectRoleId = this.RoleViewAgent.GetCurSelectRoleId();
		this.OnRefresh(curSelectRoleId);
	}

	// Token: 0x0601338D RID: 78733 RVA: 0x0059E356 File Offset: 0x0059C556
	protected override void OnBeforeDestroy()
	{
		this.RoleInstance = null;
		GenericLayoutNew<CSharpScript.Game.Module.RoleUi.RoleAttributeItem> attributeLayout = this.AttributeLayout;
		if (attributeLayout != null)
		{
			attributeLayout.ClearChildren();
		}
		this.AttributeLayout = null;
	}

	// Token: 0x0601338E RID: 78734 RVA: 0x0059E377 File Offset: 0x0059C577
	private void OnRoleChange(int roleId)
	{
		this.PlayMontageStartWithReLoop();
		this.OnRefresh(roleId);
	}

	// Token: 0x0601338F RID: 78735 RVA: 0x0059E386 File Offset: 0x0059C586
	protected void PlayMontageStart()
	{
		RoleController.Instance.PlayRoleMontage(EPerformanceRoleState.Attribute_Perform, false, false, false);
	}

	// Token: 0x06013390 RID: 78736 RVA: 0x0059E396 File Offset: 0x0059C596
	protected void PlayMontageStartWithReLoop()
	{
		RoleController.Instance.PlayRoleMontage(EPerformanceRoleState.Attribute_Perform, false, true, false);
	}

	// Token: 0x06013391 RID: 78737 RVA: 0x0059E3A6 File Offset: 0x0059C5A6
	private void OnRefresh(int roleId)
	{
		this.RoleInstance = RoleModel.Instance.GetRoleDataById(roleId, true);
		if (this.RoleInstance == null)
		{
			return;
		}
		this.UpdateName();
		this.UpdateAttributeInfo();
		this.UpdateAttributeLayout();
		this.UpdateDescription();
		this.UpdateRoleTag();
	}

	// Token: 0x06013392 RID: 78738 RVA: 0x0059E3E4 File Offset: 0x0059C5E4
	private void UpdateAttributeInfo()
	{
		ElementInfo? elementInfo = this.RoleInstance.GetElementInfo();
		if (elementInfo == null)
		{
			return;
		}
		base.SetElementIcon(elementInfo.Value.Icon, base.GetTexture(1), this.RoleInstance.GetRoleConfig().ElementId, null);
		string icon = elementInfo.Value.Icon;
		this.SetSpriteByPath(icon, base.GetSprite(8), false, null, null);
		string elementInfoLocalName = ElementInfoConfig.Instance.GetElementInfoLocalName(elementInfo.Value.Name);
		base.GetText(2).SetText(elementInfoLocalName, true);
	}

	// Token: 0x06013393 RID: 78739 RVA: 0x0059E494 File Offset: 0x0059C694
	private void UpdateName()
	{
		base.GetText(0).SetText(this.RoleInstance.GetName(null), true);
	}

	// Token: 0x06013394 RID: 78740 RVA: 0x0059E4C4 File Offset: 0x0059C6C4
	private void UpdateAttributeLayout()
	{
		FavorRoleInfo? favorRoleInfoConfig = RoleFavorConfig.Instance.GetFavorRoleInfoConfig(this.RoleInstance.GetRoleId());
		RoleInfo roleConfig = this.RoleInstance.GetRoleConfig();
		List<IAttributeInfo> list = new List<IAttributeInfo>();
		string weaponTypeName = WeaponConfig.Instance.GetWeaponTypeName(roleConfig.WeaponType);
		AttributeInfo item = new AttributeInfo
		{
			Name = "Text_Weapon_Text",
			CurText = weaponTypeName
		};
		list.Add(item);
		if (favorRoleInfoConfig != null)
		{
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew(favorRoleInfoConfig.Value.Sex, null);
			AttributeInfo item2 = new AttributeInfo
			{
				Name = "PrefabTextItem_3159729083_Text",
				CurText = localTextNew
			};
			list.Add(item2);
			string localTextNew2 = ConfigMultiTextLang.GetLocalTextNew(favorRoleInfoConfig.Value.Country, null);
			AttributeInfo item3 = new AttributeInfo
			{
				Name = "PrefabTextItem_3969856612_Text",
				CurText = localTextNew2
			};
			list.Add(item3);
			string localTextNew3 = ConfigMultiTextLang.GetLocalTextNew(favorRoleInfoConfig.Value.Influence, null);
			AttributeInfo item4 = new AttributeInfo
			{
				Name = "PrefabTextItem_152395022_Text",
				CurText = localTextNew3
			};
			list.Add(item4);
		}
		string localTextNew4 = ConfigMultiTextLang.GetLocalTextNew(RoleFavorUtil.GetCurLanguageCvName(this.RoleInstance.GetRoleId()), null);
		AttributeInfo item5 = new AttributeInfo
		{
			Name = "Text_CharacterVoice_Text",
			CurText = localTextNew4
		};
		list.Add(item5);
		bool flag = true;
		foreach (IAttributeInfo attributeInfo in list)
		{
			attributeInfo.ShowArrow = new bool?(false);
			attributeInfo.InnerShowBg = new bool?(flag);
			flag = !flag;
		}
		GenericLayoutNew<CSharpScript.Game.Module.RoleUi.RoleAttributeItem> attributeLayout = this.AttributeLayout;
		if (attributeLayout == null)
		{
			return;
		}
		attributeLayout.RebuildLayoutByDataNew<IAttributeInfo>(list, null);
	}

	// Token: 0x06013395 RID: 78741 RVA: 0x0059E698 File Offset: 0x0059C898
	[NullableContext(1)]
	private ILayoutItem<CSharpScript.Game.Module.RoleUi.RoleAttributeItem> InitRoleAttributeItem(object data, UUIItem uiItem, int index)
	{
		CSharpScript.Game.Module.RoleUi.RoleAttributeItem roleAttributeItem = new CSharpScript.Game.Module.RoleUi.RoleAttributeItem();
		roleAttributeItem.SetRootActor(uiItem.GetOwner(), true);
		roleAttributeItem.Refresh((IAttributeInfo)data);
		return new LayoutItem<CSharpScript.Game.Module.RoleUi.RoleAttributeItem>
		{
			Key = index,
			Value = roleAttributeItem
		};
	}

	// Token: 0x06013396 RID: 78742 RVA: 0x0059E6DC File Offset: 0x0059C8DC
	private void UpdateRoleTag()
	{
		int[] roleTagByRoleInfo = RoleModel.Instance.GetRoleTagByRoleInfo(this.RoleInstance.GetRoleConfig());
		this.RoleTagLayout.RefreshByData(new List<int>(roleTagByRoleInfo), null, false);
	}

	// Token: 0x06013397 RID: 78743 RVA: 0x0059E714 File Offset: 0x0059C914
	private void UpdateDescription()
	{
		RoleInfo roleConfig = this.RoleInstance.GetRoleConfig();
		base.GetText(4).ShowTextNew(roleConfig.Introduction);
	}

	// Token: 0x06013398 RID: 78744 RVA: 0x0059E740 File Offset: 0x0059C940
	[NullableContext(1)]
	private RoleTagSmallIconItem InitRoleTagItem()
	{
		return new RoleTagSmallIconItem();
	}

	// Token: 0x06013399 RID: 78745 RVA: 0x0059E748 File Offset: 0x0059C948
	protected void RoleTagClick()
	{
		RoleInfo roleConfig = this.RoleInstance.GetRoleConfig();
		int[] roleTagByRoleInfo = RoleModel.Instance.GetRoleTagByRoleInfo(roleConfig);
		UiManager.Instance.OpenView(EUiViewName.RoleTagDetailView, roleTagByRoleInfo, null);
	}

	// Token: 0x0400A4A3 RID: 42147
	[Nullable(2)]
	protected RoleViewAgent RoleViewAgent;

	// Token: 0x0400A4A4 RID: 42148
	[Nullable(2)]
	protected RoleDataBase RoleInstance;

	// Token: 0x0400A4A5 RID: 42149
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayoutNew<CSharpScript.Game.Module.RoleUi.RoleAttributeItem> AttributeLayout;

	// Token: 0x0400A4A6 RID: 42150
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<RoleTagSmallIconItem, int> RoleTagLayout;

	// Token: 0x02008135 RID: 33077
	private enum EPreviewAttributeViewNode
	{
		// Token: 0x04029C83 RID: 171139
		TextName,
		// Token: 0x04029C84 RID: 171140
		IconAttribute,
		// Token: 0x04029C85 RID: 171141
		TextAttribute,
		// Token: 0x04029C86 RID: 171142
		AttributeLayout,
		// Token: 0x04029C87 RID: 171143
		TextDescription,
		// Token: 0x04029C88 RID: 171144
		LayoutRoleTag,
		// Token: 0x04029C89 RID: 171145
		ItemRoleTag,
		// Token: 0x04029C8A RID: 171146
		ButtonRoleTag,
		// Token: 0x04029C8B RID: 171147
		IconAttributeBg
	}
}
