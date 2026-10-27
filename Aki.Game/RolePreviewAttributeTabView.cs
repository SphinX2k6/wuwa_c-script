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

// Token: 0x020028DF RID: 10463
public class RolePreviewAttributeTabView : UiTabViewBase
{
	// Token: 0x06015984 RID: 88452 RVA: 0x00573294 File Offset: 0x00571494
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

	// Token: 0x06015985 RID: 88453 RVA: 0x00573398 File Offset: 0x00571598
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

	// Token: 0x06015986 RID: 88454 RVA: 0x0057342A File Offset: 0x0057162A
	protected override void AddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.RoleSystemChangeRole, new Action<int>(this.OnRoleChange));
	}

	// Token: 0x06015987 RID: 88455 RVA: 0x00573448 File Offset: 0x00571648
	protected override void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RoleSystemChangeRole, new Action<int>(this.OnRoleChange));
	}

	// Token: 0x06015988 RID: 88456 RVA: 0x00573468 File Offset: 0x00571668
	protected override void OnBeforeShow()
	{
		this.PlayMontageStart();
		int curSelectRoleId = this.RoleViewAgent.GetCurSelectRoleId();
		this.OnRefresh(curSelectRoleId);
	}

	// Token: 0x06015989 RID: 88457 RVA: 0x0057348E File Offset: 0x0057168E
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

	// Token: 0x0601598A RID: 88458 RVA: 0x005734AF File Offset: 0x005716AF
	private void OnRoleChange(int roleId)
	{
		this.PlayMontageStartWithReLoop();
		this.OnRefresh(roleId);
	}

	// Token: 0x0601598B RID: 88459 RVA: 0x005734BE File Offset: 0x005716BE
	protected void PlayMontageStart()
	{
		RoleController.Instance.PlayRoleMontage(EPerformanceRoleState.Attribute_Perform, false, false, false);
	}

	// Token: 0x0601598C RID: 88460 RVA: 0x005734CE File Offset: 0x005716CE
	protected void PlayMontageStartWithReLoop()
	{
		RoleController.Instance.PlayRoleMontage(EPerformanceRoleState.Attribute_Perform, false, true, false);
	}

	// Token: 0x0601598D RID: 88461 RVA: 0x005734DE File Offset: 0x005716DE
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

	// Token: 0x0601598E RID: 88462 RVA: 0x0057351C File Offset: 0x0057171C
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

	// Token: 0x0601598F RID: 88463 RVA: 0x005735CC File Offset: 0x005717CC
	private void UpdateName()
	{
		base.GetText(0).SetText(this.RoleInstance.GetName(null), true);
	}

	// Token: 0x06015990 RID: 88464 RVA: 0x005735FC File Offset: 0x005717FC
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

	// Token: 0x06015991 RID: 88465 RVA: 0x005737D0 File Offset: 0x005719D0
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

	// Token: 0x06015992 RID: 88466 RVA: 0x00573814 File Offset: 0x00571A14
	private void UpdateRoleTag()
	{
		int[] roleTagByRoleInfo = RoleModel.Instance.GetRoleTagByRoleInfo(this.RoleInstance.GetRoleConfig());
		this.RoleTagLayout.RefreshByData(new List<int>(roleTagByRoleInfo), null, false);
	}

	// Token: 0x06015993 RID: 88467 RVA: 0x0057384C File Offset: 0x00571A4C
	private void UpdateDescription()
	{
		RoleInfo roleConfig = this.RoleInstance.GetRoleConfig();
		base.GetText(4).ShowTextNew(roleConfig.Introduction);
	}

	// Token: 0x06015994 RID: 88468 RVA: 0x00573878 File Offset: 0x00571A78
	[NullableContext(1)]
	private RoleTagSmallIconItem InitRoleTagItem()
	{
		return new RoleTagSmallIconItem();
	}

	// Token: 0x06015995 RID: 88469 RVA: 0x00573880 File Offset: 0x00571A80
	protected void RoleTagClick()
	{
		RoleInfo roleConfig = this.RoleInstance.GetRoleConfig();
		int[] roleTagByRoleInfo = RoleModel.Instance.GetRoleTagByRoleInfo(roleConfig);
		UiManager.Instance.OpenView(EUiViewName.RoleTagDetailView, roleTagByRoleInfo, null);
	}

	// Token: 0x0400A0B9 RID: 41145
	[Nullable(2)]
	protected RoleViewAgent RoleViewAgent;

	// Token: 0x0400A0BA RID: 41146
	[Nullable(2)]
	protected RoleDataBase RoleInstance;

	// Token: 0x0400A0BB RID: 41147
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayoutNew<CSharpScript.Game.Module.RoleUi.RoleAttributeItem> AttributeLayout;

	// Token: 0x0400A0BC RID: 41148
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<RoleTagSmallIconItem, int> RoleTagLayout;

	// Token: 0x02008EED RID: 36589
	private enum EPreviewAttributeViewNode
	{
		// Token: 0x0402E588 RID: 189832
		TextName,
		// Token: 0x0402E589 RID: 189833
		IconAttribute,
		// Token: 0x0402E58A RID: 189834
		TextAttribute,
		// Token: 0x0402E58B RID: 189835
		AttributeLayout,
		// Token: 0x0402E58C RID: 189836
		TextDescription,
		// Token: 0x0402E58D RID: 189837
		LayoutRoleTag,
		// Token: 0x0402E58E RID: 189838
		ItemRoleTag,
		// Token: 0x0402E58F RID: 189839
		ButtonRoleTag,
		// Token: 0x0402E590 RID: 189840
		IconAttributeBg
	}
}
