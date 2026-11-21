using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000866 RID: 2150
[NullableContext(1)]
[Nullable(0)]
public class ActivitySubViewNewPlayerSupportActivityV2 : ActivitySubViewBase
{
	// Token: 0x0600617C RID: 24956 RVA: 0x001F2387 File Offset: 0x001F0587
	protected override void OnSetData()
	{
		this.ActivityData = (this.ActivityBaseData as ActivityNewPlayerSupportActivityV2Data);
	}

	// Token: 0x0600617D RID: 24957 RVA: 0x001F239C File Offset: 0x001F059C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 14;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 5;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClickRole));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickAdventureView));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnClickShopEntrance));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.OnClickGachaEntrance));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnClickTrial));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600617E RID: 24958 RVA: 0x001F2660 File Offset: 0x001F0860
	protected override void OnStart()
	{
		this.RemainTimeText = (ConfigMultiTextLang.GetLocalTextNew("ActivityRemainingTime", null) ?? string.Empty);
		UUIText text = base.GetText(0);
		if (text != null)
		{
			ActivityNewPlayerSupportActivityV2Data activityData = this.ActivityData;
			text.SetText(((activityData != null) ? activityData.GetTitle() : null) ?? string.Empty, true);
		}
		UUIItem item = base.GetItem(13);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		this.RefreshViewState();
	}

	// Token: 0x0600617F RID: 24959 RVA: 0x001F26CF File Offset: 0x001F08CF
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshRedDot));
		EventSystem.Instance.Add<EFunctionType, bool>(EEventName.OnFunctionOpenUpdate, new Action<EFunctionType, bool>(this.OnFunctionOpenChanged));
	}

	// Token: 0x06006180 RID: 24960 RVA: 0x001F2709 File Offset: 0x001F0909
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshRedDot));
		EventSystem.Instance.Remove<EFunctionType, bool>(EEventName.OnFunctionOpenUpdate, new Action<EFunctionType, bool>(this.OnFunctionOpenChanged));
	}

	// Token: 0x06006181 RID: 24961 RVA: 0x001F2743 File Offset: 0x001F0943
	protected override void OnTimer(float gap)
	{
		this.RefreshRemainTime();
	}

	// Token: 0x06006182 RID: 24962 RVA: 0x001F274B File Offset: 0x001F094B
	protected override void OnRefreshView()
	{
		this.RefreshViewState();
	}

	// Token: 0x06006183 RID: 24963 RVA: 0x001F2753 File Offset: 0x001F0953
	private void RefreshViewState()
	{
		this.RefreshRemainTime();
		this.RefreshTrialRoleDisplay();
		this.RefreshGachaEntrance2Visual();
		this.RefreshRoleEntranceCompositeVisual();
		this.RefreshEntranceRedDot();
	}

	// Token: 0x06006184 RID: 24964 RVA: 0x001F2774 File Offset: 0x001F0974
	private void RefreshRemainTime()
	{
		if (this.ActivityData == null)
		{
			return;
		}
		UUIText text = base.GetText(1);
		if (text == null)
		{
			return;
		}
		long displayRemainEndTime = this.ActivityData.GetDisplayRemainEndTime();
		if (displayRemainEndTime <= 0L || !this.ActivityData.CheckIfInShowTime())
		{
			text.SetUIActive(false);
			return;
		}
		string remainTimeText = ActivityModel.Instance.GetRemainTimeText(displayRemainEndTime, this.RemainTimeText);
		text.SetUIActive(true);
		text.SetText(remainTimeText ?? string.Empty, true);
	}

	// Token: 0x06006185 RID: 24965 RVA: 0x001F27E8 File Offset: 0x001F09E8
	private void OnRefreshRedDot(int activityId)
	{
		ActivityNewPlayerSupportActivityV2Data activityData = this.ActivityData;
		int? num = (activityData != null) ? new int?(activityData.Id) : null;
		if (!(activityId == num.GetValueOrDefault() & num != null))
		{
			return;
		}
		this.RefreshViewState();
	}

	// Token: 0x06006186 RID: 24966 RVA: 0x001F2830 File Offset: 0x001F0A30
	private void OnFunctionOpenChanged(EFunctionType functionType, bool isOpen)
	{
		if (functionType == EFunctionType.DailyActivity)
		{
			this.RefreshViewState();
		}
	}

	// Token: 0x06006187 RID: 24967 RVA: 0x001F2840 File Offset: 0x001F0A40
	private void OnClickRole()
	{
		ActivityNewPlayerSupportActivityV2Controller.ReportEntranceClick(ENewPlayerSupportEntrance.Liveness);
		if (!ActivitySubViewNewPlayerSupportActivityV2.IsExperienceBonusLivenessEntranceUnlocked())
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("NewPlayer_Experience_002", Array.Empty<object>());
			return;
		}
		ActivityNewPlayerSupportActivityV2Data activityData = this.ActivityData;
		if (activityData != null)
		{
			activityData.MarkLivenessEntranceClicked();
		}
		AdventureGuideViewOpenData param = new AdventureGuideViewOpenData
		{
			OpenTabViewName = new EUiTabViewName?(EUiTabViewName.DailyActivityTabView),
			SkipAdventureManualRequest = true
		};
		UiManager.Instance.OpenView(EUiViewName.AdventureGuideView, param, null);
	}

	// Token: 0x06006188 RID: 24968 RVA: 0x001F28AE File Offset: 0x001F0AAE
	private void OnClickAdventureView()
	{
		ActivityNewPlayerSupportActivityV2Controller.ReportEntranceClick(ENewPlayerSupportEntrance.GiftPack);
		ActivityNewPlayerSupportActivityV2Data activityData = this.ActivityData;
		if (activityData != null)
		{
			activityData.MarkGiftPackEntranceClicked();
		}
		ActivityNewPlayerSupportActivityV2Controller controller = this.GetController();
		if (controller == null)
		{
			return;
		}
		controller.OpenAdventureV2View();
	}

	// Token: 0x06006189 RID: 24969 RVA: 0x001F28D7 File Offset: 0x001F0AD7
	private void OnClickShopEntrance()
	{
		ActivityNewPlayerSupportActivityV2Controller.ReportEntranceClick(ENewPlayerSupportEntrance.WeekCard);
		ActivityNewPlayerSupportActivityV2Data activityData = this.ActivityData;
		if (activityData != null)
		{
			activityData.MarkWeekCardEntranceClicked();
		}
		PayShopController instance = PayShopController.Instance;
		Func<PayShopJumpParam> tabResolver;
		if ((tabResolver = ActivitySubViewNewPlayerSupportActivityV2.<>O.<0>__ResolveWeekCardShopJumpParam) == null)
		{
			tabResolver = (ActivitySubViewNewPlayerSupportActivityV2.<>O.<0>__ResolveWeekCardShopJumpParam = new Func<PayShopJumpParam>(ActivityNewPlayerSupportActivityV2Controller.ResolveWeekCardShopJumpParam));
		}
		instance.OpenPayShopViewWithTabResolver(tabResolver);
	}

	// Token: 0x0600618A RID: 24970 RVA: 0x001F2918 File Offset: 0x001F0B18
	private void OnClickGachaEntrance()
	{
		ActivityNewPlayerSupportActivityV2Controller.ReportEntranceClick(ENewPlayerSupportEntrance.Gacha);
		ActivityNewPlayerSupportActivityV2Data activityData = this.ActivityData;
		if (activityData != null)
		{
			activityData.MarkGachaEntranceClicked();
		}
		ActivityNewPlayerSupportActivityV2Data activityData2 = this.ActivityData;
		int? num = (activityData2 != null) ? activityData2.GetGachaOpenTabIdOrDefault() : null;
		GachaController.Instance.OpenGachaView(num.GetValueOrDefault());
	}

	// Token: 0x0600618B RID: 24971 RVA: 0x001F2968 File Offset: 0x001F0B68
	private void OnClickTrial()
	{
		ActivityNewPlayerSupportActivityV2Controller controller = this.GetController();
		if (controller == null)
		{
			return;
		}
		controller.OpenTrialRoleView(null);
	}

	// Token: 0x0600618C RID: 24972 RVA: 0x001F298E File Offset: 0x001F0B8E
	[NullableContext(2)]
	private ActivityNewPlayerSupportActivityV2Controller GetController()
	{
		if (this.ActivityData == null || this.ActivityData.Type == ActivityType.Parkour)
		{
			return null;
		}
		return ActivityManager.GetActivityController(this.ActivityData.Type) as ActivityNewPlayerSupportActivityV2Controller;
	}

	// Token: 0x0600618D RID: 24973 RVA: 0x001F29BC File Offset: 0x001F0BBC
	private void RefreshTrialRoleDisplay()
	{
		ActivityNewPlayerSupportActivityV2Data activityData = this.ActivityData;
		int? num;
		if (activityData == null)
		{
			num = null;
		}
		else
		{
			TrialRoleGroupData curUseTrialRoleData = activityData.CurUseTrialRoleData;
			num = ((curUseTrialRoleData != null) ? new int?(curUseTrialRoleData.RealRoleId) : null);
		}
		int? num2 = num;
		int valueOrDefault = num2.GetValueOrDefault();
		bool flag = valueOrDefault > 0;
		bool isRover = flag && RoleModel.Instance.IsMainRole(valueOrDefault);
		RoleInfo? roleConfig = flag ? RoleConfig.Instance.GetRoleConfig(valueOrDefault) : null;
		ActivityNewPlayerSupportActivityV2Data activityData2 = this.ActivityData;
		ValueTuple<string, string>? valueTuple = (activityData2 != null) ? activityData2.GetCurrentTrialRoleDisplayResourceIds() : null;
		this.RefreshRoleRelatedPanels(flag);
		string text;
		if ((text = this.ResolveTexturePath((valueTuple != null) ? valueTuple.GetValueOrDefault().Item2 : null)) == null)
		{
			text = (((roleConfig != null) ? roleConfig.GetValueOrDefault().Card : null) ?? string.Empty);
		}
		string bgPath = text;
		string text2;
		if (!flag)
		{
			text2 = this.GetSilhouetteTexturePathByGender();
		}
		else if ((text2 = this.ResolveTexturePath((valueTuple != null) ? valueTuple.GetValueOrDefault().Item1 : null)) == null)
		{
			text2 = (((roleConfig != null) ? roleConfig.GetValueOrDefault().FormationRoleCard : null) ?? string.Empty);
		}
		string rolePath = text2;
		this.RefreshBgTexture(flag, isRover, bgPath);
		this.RefreshRoleTexture(flag, rolePath);
		this.RefreshTrialButtonText(flag, roleConfig);
	}

	// Token: 0x0600618E RID: 24974 RVA: 0x001F2B18 File Offset: 0x001F0D18
	private void RefreshTrialButtonText(bool hasRole, RoleInfo? roleConfig)
	{
		UUIText text = base.GetText(12);
		if (text == null)
		{
			return;
		}
		text.SetGameRichText(true);
		text.SetRichText(true);
		if (hasRole && roleConfig != null)
		{
			string text2 = ConfigMultiTextLang.GetLocalTextNew(roleConfig.Value.Name, null) ?? string.Empty;
			LguiUtil.Instance.SetLocalTextNew(text, "NewPlayer_Trial_002", new string[]
			{
				text2
			});
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(text, "NewPlayer_Trial_001", Array.Empty<object>());
	}

	// Token: 0x0600618F RID: 24975 RVA: 0x001F2B9B File Offset: 0x001F0D9B
	private void RefreshRoleRelatedPanels(bool hasRole)
	{
		UUIItem item = base.GetItem(7);
		if (item != null)
		{
			item.SetUIActive(hasRole);
		}
		UUIItem item2 = base.GetItem(8);
		if (item2 != null)
		{
			item2.SetUIActive(hasRole);
		}
		UUIItem item3 = base.GetItem(11);
		if (item3 == null)
		{
			return;
		}
		item3.SetUIActive(!hasRole);
	}

	// Token: 0x06006190 RID: 24976 RVA: 0x001F2BDC File Offset: 0x001F0DDC
	private void RefreshBgTexture(bool hasRole, bool isRover, string bgPath)
	{
		UUITexture texture = base.GetTexture(9);
		if (texture == null)
		{
			return;
		}
		bool flag = hasRole && !isRover && !string.IsNullOrEmpty(bgPath);
		texture.SetUIActive(flag);
		if (flag)
		{
			base.SetTextureByPath(bgPath, texture, null, null);
		}
	}

	// Token: 0x06006191 RID: 24977 RVA: 0x001F2C28 File Offset: 0x001F0E28
	private void RefreshRoleTexture(bool hasRole, string rolePath)
	{
		UUITexture texture = base.GetTexture(10);
		if (texture == null)
		{
			return;
		}
		bool flag = !string.IsNullOrEmpty(rolePath);
		texture.SetUIActive(flag);
		if (flag)
		{
			base.SetTextureByPath(rolePath, texture, null, null);
		}
	}

	// Token: 0x06006192 RID: 24978 RVA: 0x001F2C68 File Offset: 0x001F0E68
	private string GetSilhouetteTexturePathByGender()
	{
		string resourceIdOrPath = (PlayerInfoModel.Instance.GetPlayerGender() == EPlayerGender.Male) ? "T_PrivilegeRoleRoverMale" : "T_PrivilegeRoleRoverFemale";
		return this.ResolveTexturePath(resourceIdOrPath) ?? string.Empty;
	}

	// Token: 0x06006193 RID: 24979 RVA: 0x001F2CA0 File Offset: 0x001F0EA0
	[NullableContext(2)]
	private string ResolveTexturePath(string resourceIdOrPath)
	{
		if (string.IsNullOrWhiteSpace(resourceIdOrPath))
		{
			return null;
		}
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceIdOrPath.Trim());
		if (!string.IsNullOrWhiteSpace(resourcePath))
		{
			return resourcePath;
		}
		return null;
	}

	// Token: 0x06006194 RID: 24980 RVA: 0x001F2CD4 File Offset: 0x001F0ED4
	private void RefreshEntranceRedDot()
	{
		UUIItem item = base.GetItem(13);
		if (item != null)
		{
			ActivityNewPlayerSupportActivityV2Data activityData = this.ActivityData;
			item.SetUIActive(activityData != null && activityData.GetTrialRoleEntranceRedDotState());
		}
		int componentType = 2;
		ActivityNewPlayerSupportActivityV2Data activityData2 = this.ActivityData;
		this.SetEntranceButtonRedDotVisible(componentType, activityData2 != null && activityData2.GetLivenessEntranceRedDotState());
		int componentType2 = 3;
		ActivityNewPlayerSupportActivityV2Data activityData3 = this.ActivityData;
		this.SetEntranceButtonRedDotVisible(componentType2, activityData3 != null && activityData3.GetGiftPackEntranceRedDotState());
		int componentType3 = 4;
		ActivityNewPlayerSupportActivityV2Data activityData4 = this.ActivityData;
		this.SetEntranceButtonRedDotVisible(componentType3, activityData4 != null && activityData4.GetWeekCardEntranceRedDotState());
		int componentType4 = 5;
		ActivityNewPlayerSupportActivityV2Data activityData5 = this.ActivityData;
		this.SetEntranceButtonRedDotVisible(componentType4, activityData5 != null && activityData5.GetGachaEntranceRedDotState());
	}

	// Token: 0x06006195 RID: 24981 RVA: 0x001F2D6C File Offset: 0x001F0F6C
	private void RefreshGachaEntrance2Visual()
	{
		UUIItem uuiitem = this.TryGetNestedUiItem(5, 1);
		UUIItem uuiitem2 = this.TryGetNestedUiItem(5, 2);
		if (uuiitem != null)
		{
			uuiitem.SetUIActive(true);
		}
		if (uuiitem2 != null)
		{
			uuiitem2.SetUIActive(false);
		}
	}

	// Token: 0x06006196 RID: 24982 RVA: 0x001F2DA0 File Offset: 0x001F0FA0
	private void RefreshRoleEntranceCompositeVisual()
	{
		bool flag = ActivitySubViewNewPlayerSupportActivityV2.IsExperienceBonusLivenessEntranceUnlocked();
		UUIItem uuiitem = this.TryGetNestedUiItem(2, 1);
		UUIItem uuiitem2 = this.TryGetNestedUiItem(2, 2);
		UUIText uuitext = this.TryGetNestedText(2, 3);
		if (uuiitem != null || uuiitem2 != null)
		{
			if (uuiitem != null)
			{
				uuiitem.SetUIActive(flag);
			}
			if (uuiitem2 != null)
			{
				uuiitem2.SetUIActive(!flag);
			}
		}
		if (uuitext != null)
		{
			if (flag)
			{
				LguiUtil.Instance.SetLocalTextNew(uuitext, "NewPlayer_Experience_004", Array.Empty<object>());
			}
			else
			{
				LguiUtil.Instance.SetLocalTextNew(uuitext, "NewPlayer_Experience_003", Array.Empty<object>());
			}
		}
		this.ApplyExperienceBonusRoleButtonLockExtension(!flag);
	}

	// Token: 0x06006197 RID: 24983 RVA: 0x001F2E27 File Offset: 0x001F1027
	private static bool IsExperienceBonusLivenessEntranceUnlocked()
	{
		return FunctionModel.Instance.IsOpen(10023005);
	}

	// Token: 0x06006198 RID: 24984 RVA: 0x001F2E38 File Offset: 0x001F1038
	private void ApplyExperienceBonusRoleButtonLockExtension(bool showLockVisual)
	{
		UUIButtonComponent button = base.GetButton(2);
		if (button == null)
		{
			return;
		}
		button.SetSelfInteractive(true);
		button.SetEnable(true);
	}

	// Token: 0x06006199 RID: 24985 RVA: 0x001F2E60 File Offset: 0x001F1060
	[NullableContext(2)]
	private ULGUIComponentsRegistry GetNestedRegistryForButton(int buttonType)
	{
		UUIButtonComponent button = base.GetButton(buttonType);
		AUIBaseActor auibaseActor = ((button != null) ? button.GetOwner() : null) as AUIBaseActor;
		if (auibaseActor == null || !auibaseActor.IsValid())
		{
			return null;
		}
		ULGUIComponentsRegistry ulguicomponentsRegistry = LguiUtil.Instance.GetComponentsRegistry(auibaseActor);
		if (ulguicomponentsRegistry == null || !ulguicomponentsRegistry.IsValid())
		{
			AUIBaseActor auibaseActor2 = LguiUtil.Instance.GetChildActorByHierarchyIndex(auibaseActor, 0);
			ulguicomponentsRegistry = ((auibaseActor2 != null) ? LguiUtil.Instance.GetComponentsRegistry(auibaseActor2) : null);
			if (ulguicomponentsRegistry == null || !ulguicomponentsRegistry.IsValid())
			{
				auibaseActor2 = ((auibaseActor2 != null) ? LguiUtil.Instance.GetChildActorByHierarchyIndex(auibaseActor2, 0) : null);
				ulguicomponentsRegistry = ((auibaseActor2 != null) ? LguiUtil.Instance.GetComponentsRegistry(auibaseActor2) : null);
			}
		}
		if (ulguicomponentsRegistry == null || !ulguicomponentsRegistry.IsValid())
		{
			return null;
		}
		return ulguicomponentsRegistry;
	}

	// Token: 0x0600619A RID: 24986 RVA: 0x001F2F0C File Offset: 0x001F110C
	[NullableContext(2)]
	private UUIItem TryGetNestedUiItem(int buttonType, int index)
	{
		ULGUIComponentsRegistry nestedRegistryForButton = this.GetNestedRegistryForButton(buttonType);
		if (nestedRegistryForButton == null || index >= nestedRegistryForButton.Components.Num())
		{
			return null;
		}
		AActor aactor = nestedRegistryForButton.Components.Get(index);
		return ((aactor != null) ? aactor.GetComponentByClass(UUIItem.StaticClass()) : null) as UUIItem;
	}

	// Token: 0x0600619B RID: 24987 RVA: 0x001F2F5C File Offset: 0x001F115C
	[NullableContext(2)]
	private UUIText TryGetNestedText(int buttonType, int index)
	{
		ULGUIComponentsRegistry nestedRegistryForButton = this.GetNestedRegistryForButton(buttonType);
		if (nestedRegistryForButton == null || index >= nestedRegistryForButton.Components.Num())
		{
			return null;
		}
		AActor aactor = nestedRegistryForButton.Components.Get(index);
		return ((aactor != null) ? aactor.GetComponentByClass(UUIText.StaticClass()) : null) as UUIText;
	}

	// Token: 0x0600619C RID: 24988 RVA: 0x001F2FAB File Offset: 0x001F11AB
	private void SetEntranceButtonRedDotVisible(int componentType, bool visible)
	{
		UUIItem uuiitem = this.TryGetNestedUiItem(componentType, 4);
		if (uuiitem == null)
		{
			return;
		}
		uuiitem.SetUIActive(visible);
	}

	// Token: 0x0600619D RID: 24989 RVA: 0x001F2FC0 File Offset: 0x001F11C0
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		if (!(configParams[0] == "TrialRoleBtn"))
		{
			return null;
		}
		UUIButtonComponent button = base.GetButton(6);
		UUIItem uuiitem = (button != null) ? button.RootUIComp.Get() : null;
		if (uuiitem == null)
		{
			return null;
		}
		return new UUIItem[]
		{
			uuiitem,
			uuiitem
		};
	}

	// Token: 0x04003F87 RID: 16263
	private const string NewPlayerSupportV2MaleSilhouetteResourceId = "T_PrivilegeRoleRoverMale";

	// Token: 0x04003F88 RID: 16264
	private const string NewPlayerSupportV2FemaleSilhouetteResourceId = "T_PrivilegeRoleRoverFemale";

	// Token: 0x04003F89 RID: 16265
	[Nullable(2)]
	private ActivityNewPlayerSupportActivityV2Data ActivityData;

	// Token: 0x04003F8A RID: 16266
	private string RemainTimeText = string.Empty;

	// Token: 0x02006BAC RID: 27564
	[NullableContext(0)]
	private class EComponentType
	{
		// Token: 0x04023670 RID: 145008
		public const int TxtTitle = 0;

		// Token: 0x04023671 RID: 145009
		public const int TxtRestTime = 1;

		// Token: 0x04023672 RID: 145010
		public const int BtnRole = 2;

		// Token: 0x04023673 RID: 145011
		public const int BtnGift = 3;

		// Token: 0x04023674 RID: 145012
		public const int BtnLuckDraw = 4;

		// Token: 0x04023675 RID: 145013
		public const int BtnEntrance2 = 5;

		// Token: 0x04023676 RID: 145014
		public const int BtnTrial = 6;

		// Token: 0x04023677 RID: 145015
		public const int TrialRoleStarLayout = 7;

		// Token: 0x04023678 RID: 145016
		public const int Star = 8;

		// Token: 0x04023679 RID: 145017
		public const int TexBg = 9;

		// Token: 0x0402367A RID: 145018
		public const int TexRole = 10;

		// Token: 0x0402367B RID: 145019
		public const int RoverDecoration = 11;

		// Token: 0x0402367C RID: 145020
		public const int TxtBtnTrialName = 12;

		// Token: 0x0402367D RID: 145021
		public const int TrialBtnRedDot = 13;
	}

	// Token: 0x02006BAD RID: 27565
	[NullableContext(0)]
	private static class ECompositeEntranceNested
	{
		// Token: 0x0402367E RID: 145022
		public const int PnlIconNor = 1;

		// Token: 0x0402367F RID: 145023
		public const int IconLock = 2;

		// Token: 0x04023680 RID: 145024
		public const int TxtDescription = 3;

		// Token: 0x04023681 RID: 145025
		public const int RedDot = 4;
	}

	// Token: 0x02006BAE RID: 27566
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x04023682 RID: 145026
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Func<PayShopJumpParam> <0>__ResolveWeekCardShopJumpParam;
	}
}
