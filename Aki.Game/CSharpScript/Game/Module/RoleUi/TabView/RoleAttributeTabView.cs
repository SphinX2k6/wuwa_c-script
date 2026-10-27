using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.Role.Common.Data.Enum;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleUi.TabView
{
	// Token: 0x02004CEA RID: 19690
	[NullableContext(2)]
	[Nullable(0)]
	public class RoleAttributeTabView : UiTabViewBase
	{
		// Token: 0x06032D9F RID: 208287 RVA: 0x00BD98E0 File Offset: 0x00BD7AE0
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUISprite)),
				new ValueTuple<int, Type>(4, typeof(UUIText)),
				new ValueTuple<int, Type>(6, typeof(UUIText)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIText)),
				new ValueTuple<int, Type>(8, typeof(UUIText)),
				new ValueTuple<int, Type>(9, typeof(UUITexture)),
				new ValueTuple<int, Type>(10, typeof(UUIHorizontalLayout)),
				new ValueTuple<int, Type>(11, typeof(UUIText)),
				new ValueTuple<int, Type>(12, typeof(UUIItem)),
				new ValueTuple<int, Type>(13, typeof(UUIItem)),
				new ValueTuple<int, Type>(14, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(15, typeof(UUIItem)),
				new ValueTuple<int, Type>(16, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(17, typeof(UUIHorizontalLayout)),
				new ValueTuple<int, Type>(18, typeof(UUIItem)),
				new ValueTuple<int, Type>(19, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(20, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(21, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(22, typeof(UUIItem)),
				new ValueTuple<int, Type>(23, typeof(UUIItem)),
				new ValueTuple<int, Type>(24, typeof(UUISprite)),
				new ValueTuple<int, Type>(25, typeof(UUIText)),
				new ValueTuple<int, Type>(26, typeof(UUITexture)),
				new ValueTuple<int, Type>(27, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action(this.DetailClick)),
				new ValueTuple<int, Delegate>(14, new Action(this.TeachClick)),
				new ValueTuple<int, Delegate>(16, new Action(this.RoleChangeClick)),
				new ValueTuple<int, Delegate>(19, new Action(this.RoleTagClick)),
				new ValueTuple<int, Delegate>(21, new Action(this.OnRoleSkinClick))
			};
		}

		// Token: 0x06032DA0 RID: 208288 RVA: 0x00BD9BFA File Offset: 0x00BD7DFA
		protected void DetailClick()
		{
			this.UpdateAttrList();
		}

		// Token: 0x06032DA1 RID: 208289 RVA: 0x00BD9C04 File Offset: 0x00BD7E04
		protected void LevelUpClick(int _)
		{
			RoleViewViewModel viewModel = new RoleViewViewModel(this.RoleInstance.GetRoleId(), false, ERoleViewSource.Normal);
			RoleController.Instance.OpenRoleViewByViewModel(EUiViewName.RoleLevelUpView, viewModel);
		}

		// Token: 0x06032DA2 RID: 208290 RVA: 0x00BD9C34 File Offset: 0x00BD7E34
		protected void BreakthroughClick(int _)
		{
			RoleViewViewModel viewModel = new RoleViewViewModel(this.RoleInstance.GetRoleId(), false, ERoleViewSource.Normal);
			RoleController.Instance.OpenRoleViewByViewModel(EUiViewName.RoleBreachView, viewModel);
		}

		// Token: 0x06032DA3 RID: 208291 RVA: 0x00BD9C64 File Offset: 0x00BD7E64
		protected void RoleChangeClick()
		{
			if (GameModeModel.Instance.IsMulti)
			{
				ScrollingTipsController.Instance.ShowTipsById("InstanceDungeonShieldViewCantOpen", Array.Empty<object>());
				return;
			}
			LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.DirectTrainMakeRoleChange, true);
			UUIItem item = base.GetItem(23);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UiManager.Instance.OpenView(EUiViewName.RoleElementView, this.RoleViewAgent, null);
		}

		// Token: 0x06032DA4 RID: 208292 RVA: 0x00BD9CC8 File Offset: 0x00BD7EC8
		protected void RoleTagClick()
		{
			RoleInfo roleConfig = this.RoleInstance.GetRoleConfig();
			int[] roleTagByRoleInfo = RoleModel.Instance.GetRoleTagByRoleInfo(roleConfig);
			UiManager.Instance.OpenView(EUiViewName.RoleTagDetailView, roleTagByRoleInfo, null);
		}

		// Token: 0x06032DA5 RID: 208293 RVA: 0x00BD9D00 File Offset: 0x00BD7F00
		protected void OnRoleSkinClick()
		{
			int curSelectRoleId = this.RoleViewAgent.GetCurSelectRoleId();
			SkinController.Instance.SkipToSkinView(curSelectRoleId, EUiTabViewName.RoleSkinTabView, false, -1, null, null, null);
		}

		// Token: 0x06032DA6 RID: 208294 RVA: 0x00BD9D40 File Offset: 0x00BD7F40
		protected void TeachClick()
		{
			if (GameModeController.Instance.IsInInstance())
			{
				GenericPromptController.Instance.ShowPromptByCode("RoleGuideNotice01", Array.Empty<object>());
				return;
			}
			if (FormationDataController.Instance.GlobalIsInFight)
			{
				GenericPromptController.Instance.ShowPromptByCode("RoleGuideNotice06", Array.Empty<object>());
				return;
			}
			if (GameModeModel.Instance.IsMulti)
			{
				GenericPromptController.Instance.ShowPromptByCode("RoleGuideNotice05", Array.Empty<object>());
				return;
			}
			int roleId = this.RoleViewAgent.GetCurSelectRoleId();
			RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(roleId);
			string roleName = RoleConfig.Instance.GetRoleName(roleConfig.Value.Name);
			int dungeonId = roleConfig.Value.RoleGuide;
			if (dungeonId == 0)
			{
				GenericPromptController.Instance.ShowPromptByCode("RoleGuideNotice02", new object[]
				{
					roleName
				});
				return;
			}
			if (InstanceDungeonController.Instance.IsForbidDungeon(dungeonId))
			{
				ScrollingTipsController.Instance.ShowTipsById("PhantomFormationEnterInstanceTip", Array.Empty<object>());
				return;
			}
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.RoleTeachTip);
			confirmBoxDataNew.SetTextArgs(new string[]
			{
				roleName
			});
			confirmBoxDataNew.FunctionMap.Add(2, delegate
			{
				int fightFormationId = InstanceDungeonConfig.Instance.GetConfig(dungeonId).Value.FightFormationId;
				Aki.Config.FightFormation? fightFormation;
				int[] array = (FormationConfig.Instance.GetFightFormationConfig(fightFormationId) != null) ? fightFormation.GetValueOrDefault().AutoRole() : null;
				if (((array != null) ? array.Length : 0) > 0)
				{
					List<int> list = new List<int>();
					foreach (int id in array)
					{
						list.Add(RoleConfig.Instance.GetTrialRoleIdConfigByGroupId(id));
					}
					RoleTeachEnterCtx roleTeachEnterCtx = RoleTeachEnterCtx.Create();
					roleTeachEnterCtx.RoleId = roleId;
					InstanceDungeonModel.Instance.InstanceEnterContentText.RoleTeachCtx = roleTeachEnterCtx;
					InstanceDungeonController.Instance.PrewarTeamFightRequest(dungeonId, list, 0, 0, null, null).Forget<bool>();
					return;
				}
				Log.Instance.Error(ELogModule.Role, ELogAuthor.LZK, "未配置出战人物", default(ReadOnlySpan<ValueTuple<string, object>>));
			});
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x06032DA7 RID: 208295 RVA: 0x00BD9E90 File Offset: 0x00BD8090
		protected override void OnStart()
		{
			this.RoleViewAgent = (this.ExtraParams as RoleViewAgent);
			if (this.RoleViewAgent == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Role;
				ELogAuthor author = ELogAuthor.BB;
				string message = "RoleViewAgent为空";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("界面名称", "RoleAttributeTabView");
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.RoleSystemUiParams = this.RoleViewAgent.GetRoleSystemUiParams();
			this.SceneRoleActor = UiSceneManager.Instance.GetRoleSystemRoleActor();
			this.RoleState = ERoleState.NoRole;
			this.LevelUpButtonItem = new ButtonItem(base.GetItem(1));
			this.BreakthroughButtonItem = new ButtonItem(base.GetItem(15));
			this.LevelUpButtonItem.SetFunction(new Action<int>(this.LevelUpClick));
			this.BreakthroughButtonItem.SetFunction(new Action<int>(this.BreakthroughClick));
			base.SetButtonUiActive(20, false);
			this.InitAttributeItemList();
			this.StarLayout = new GenericLayout<StarItem, IStarItemData>(base.GetHorizontalLayout(10), new Func<StarItem>(this.InitStarItem), null, false, true);
			this.RoleTagLayout = new GenericLayout<RoleTagSmallIconItem, int>(base.GetHorizontalLayout(17), new Func<RoleTagSmallIconItem>(this.InitRoleTagItem), null, false, true);
		}

		// Token: 0x06032DA8 RID: 208296 RVA: 0x00BD9FB0 File Offset: 0x00BD81B0
		[NullableContext(1)]
		private StarItem InitStarItem()
		{
			return new StarItem();
		}

		// Token: 0x06032DA9 RID: 208297 RVA: 0x00BD9FB7 File Offset: 0x00BD81B7
		[NullableContext(1)]
		private RoleTagSmallIconItem InitRoleTagItem()
		{
			return new RoleTagSmallIconItem();
		}

		// Token: 0x06032DAA RID: 208298 RVA: 0x00BD9FC0 File Offset: 0x00BD81C0
		private void InitAttributeItemList()
		{
			IReadOnlyList<int> intArrayConfig = ConfigCommonParamById.GetIntArrayConfig("RoleAttributeDisplay6");
			UUIItem item = base.GetItem(12);
			UUIItem item2 = base.GetItem(5);
			int count = intArrayConfig.Count;
			for (int i = 0; i < count; i++)
			{
				UUIItem uuiitem;
				if (i == 0)
				{
					uuiitem = item2;
				}
				else
				{
					uuiitem = LguiUtil.Instance.CopyItem(item2, item);
				}
				int id = intArrayConfig[i];
				AttributeItem attributeItem = new AttributeItem();
				attributeItem.CreateThenShowByActor(uuiitem.GetOwner());
				attributeItem.UpdateParam(id, false);
				if (count > 2 && i % 2 == 0)
				{
					attributeItem.SetBgActive(true);
				}
				else
				{
					attributeItem.SetBgActive(false);
				}
				this.AttributeItemList.Add(attributeItem);
			}
		}

		// Token: 0x06032DAB RID: 208299 RVA: 0x00BDA06C File Offset: 0x00BD826C
		protected override void AddEventListener()
		{
			EventSystem.Instance.Add(EEventName.RoleInfoUpdate, new Action(this.OnRoleInfoUpdate));
			EventSystem.Instance.Add<int>(EEventName.RoleSystemChangeRole, new Action<int>(this.ChangeRoleEvent));
			EventSystem.Instance.Add<int, int, int>(EEventName.RoleLevelUp, new Action<int, int, int>(this.OnRoleLevelUp));
			EventSystem.Instance.Add<int>(EEventName.ActiveRole, new Action<int>(this.ActiveRoleEvent));
			EventSystem.Instance.Add(EEventName.RoleRefreshName, new Action(this.RefreshNameEvent));
		}

		// Token: 0x06032DAC RID: 208300 RVA: 0x00BDA108 File Offset: 0x00BD8308
		protected override void RemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RoleInfoUpdate, new Action(this.OnRoleInfoUpdate));
			EventSystem.Instance.Remove(EEventName.RoleSystemChangeRole, new Action<int>(this.ChangeRoleEvent));
			EventSystem.Instance.Remove(EEventName.RoleLevelUp, new Action<int, int, int>(this.OnRoleLevelUp));
			EventSystem.Instance.Remove(EEventName.ActiveRole, new Action<int>(this.ActiveRoleEvent));
			EventSystem.Instance.Remove(EEventName.RoleRefreshName, new Action(this.RefreshNameEvent));
		}

		// Token: 0x06032DAD RID: 208301 RVA: 0x00BDA1A1 File Offset: 0x00BD83A1
		private void ChangeRoleEvent(int roleId)
		{
			this.RoleInstance = RoleModel.Instance.GetRoleDataById(roleId, true);
			EventSystem.Instance.Emit<int>(EEventName.RoleSkinRedDotRefresh, roleId);
			this.PlayMontageStartWithReLoop();
			this.UpdateRoleInfo();
			this.UpdateTeachBtn();
		}

		// Token: 0x06032DAE RID: 208302 RVA: 0x00BDA1D8 File Offset: 0x00BD83D8
		private void UpdateTeachBtn()
		{
			this.LevelUpButtonItem.BindRedDot(ERedDotName.RoleAttributeTabLevelUp, this.RoleInstance.GetDataId());
			this.BreakthroughButtonItem.BindRedDot(ERedDotName.RoleAttributeTabBreakUp, this.RoleInstance.GetDataId());
			RedDotController.Instance.BindRedDot(ERedDotName.RoleSkin, base.GetItem(22), null, this.RoleInstance.GetDataId());
			if (!this.RoleSystemUiParams.TeachBtn)
			{
				base.GetButton(14).GetRootComponent().SetUIActive(false);
				return;
			}
			bool flag = this.RoleInstance.IsTrialRole();
			bool flag2 = FunctionModel.Instance.IsShow(10043);
			bool flag3 = FunctionModel.Instance.IsOpen(10043);
			if (flag2 && flag3)
			{
				base.GetButton(14).GetRootComponent().SetUIActive(!flag);
				return;
			}
			base.GetButton(14).GetRootComponent().SetUIActive(false);
		}

		// Token: 0x06032DAF RID: 208303 RVA: 0x00BDA2AF File Offset: 0x00BD84AF
		private void OnRoleInfoUpdate()
		{
			this.UpdateRoleInfo();
		}

		// Token: 0x06032DB0 RID: 208304 RVA: 0x00BDA2B7 File Offset: 0x00BD84B7
		private void OnRoleLevelUp(int i, int i1, int arg3)
		{
			this.UpdateRoleInfo();
		}

		// Token: 0x06032DB1 RID: 208305 RVA: 0x00BDA2BF File Offset: 0x00BD84BF
		private void ActiveRoleEvent(int i)
		{
			this.PlayModelEffect();
		}

		// Token: 0x06032DB2 RID: 208306 RVA: 0x00BDA2C7 File Offset: 0x00BD84C7
		private void RefreshNameEvent()
		{
			this.UpdateRename();
		}

		// Token: 0x06032DB3 RID: 208307 RVA: 0x00BDA2CF File Offset: 0x00BD84CF
		protected void PlayModelEffect()
		{
			UiRoleUtils.PlayRoleLevelUpEffect(this.SceneRoleActor);
		}

		// Token: 0x06032DB4 RID: 208308 RVA: 0x00BDA2DC File Offset: 0x00BD84DC
		private void UpdateAttrList()
		{
			UiManager.Instance.OpenView(EUiViewName.RoleAttributeDetailView, this.RoleInstance.GetShowAttrList(), null);
		}

		// Token: 0x06032DB5 RID: 208309 RVA: 0x00BDA2FC File Offset: 0x00BD84FC
		private void UpdateRoleLevel()
		{
			this.SetRoleLevelUpState();
			RoleLevelData levelData = this.RoleInstance.GetLevelData();
			if (this.RoleState == ERoleState.MaxLevel || this.RoleState == ERoleState.NoRole)
			{
				base.GetText(2).SetText("", true);
				base.GetItem(27).SetUIActive(true);
			}
			else
			{
				LguiUtil.Instance.SetLocalText(base.GetText(2), "RoleExp", new <>z__ReadOnlyArray<object>(new object[]
				{
					levelData.GetExp(),
					levelData.GetCurrentMaxExp()
				}));
				base.GetItem(27).SetUIActive(false);
			}
			double num = (this.RoleState == ERoleState.MaxLevel || this.RoleState == ERoleState.NoRole) ? 1.0 : levelData.GetExpPercentage();
			base.GetSprite(3).SetFillAmount((float)num);
			UUIText text = base.GetText(6);
			LguiUtil.Instance.SetLocalTextNew(text, "Level_Text_New_Suffix", new <>z__ReadOnlySingleElementList<object>(levelData.GetCurrentMaxLevel()));
		}

		// Token: 0x06032DB6 RID: 208310 RVA: 0x00BDA3F4 File Offset: 0x00BD85F4
		private void UpdateRoleBreakLevel()
		{
			RoleLevelData levelData = this.RoleInstance.GetLevelData();
			int breachLevel = levelData.GetBreachLevel();
			string text = TextConfig.Instance.GetTextById("RoleBreakLevel");
			text = ((text != null) ? text.Replace("%s", "[" + breachLevel.ToString() + "]") : null);
			if (text != null)
			{
				base.GetText(4).SetText(text, true);
			}
			int maxBreachLevel = levelData.GetMaxBreachLevel();
			IStarItemData[] array = new IStarItemData[maxBreachLevel];
			for (int i = 0; i < maxBreachLevel; i++)
			{
				StarItemData starItemData = new StarItemData
				{
					StarOnActive = (i < breachLevel),
					StarOffActive = (i >= breachLevel),
					StarNextActive = false,
					StarLoopActive = false,
					PlayLoopSequence = false,
					PlayActivateSequence = false
				};
				array[i] = starItemData;
			}
			this.StarLayout.RefreshByData(new List<IStarItemData>(array), null, false);
			int num = (this.RoleState == ERoleState.NoRole) ? levelData.GetRoleMaxLevel() : levelData.GetLevel();
			LguiUtil.Instance.SetLocalTextNew(base.GetText(7), "Level_Text_New", new <>z__ReadOnlySingleElementList<object>(num));
			ElementInfo? elementInfo = this.RoleInstance.GetElementInfo();
			base.SetElementIcon(elementInfo.Value.Icon, base.GetTexture(9), this.RoleInstance.GetRoleConfig().ElementId, new EUiViewName?(EUiViewName.RoleRootView));
			base.SetElementIcon(elementInfo.Value.Icon, base.GetTexture(26), this.RoleInstance.GetRoleConfig().ElementId, new EUiViewName?(EUiViewName.RoleRootView));
			string elementInfoLocalName = ElementInfoConfig.Instance.GetElementInfoLocalName(elementInfo.Value.Name);
			base.GetText(8).SetText(elementInfoLocalName, true);
		}

		// Token: 0x06032DB7 RID: 208311 RVA: 0x00BDA5C0 File Offset: 0x00BD87C0
		private void UpdateRoleTag()
		{
			int[] roleTagByRoleInfo = RoleModel.Instance.GetRoleTagByRoleInfo(this.RoleInstance.GetRoleConfig());
			this.RoleTagLayout.RefreshByData(new List<int>(roleTagByRoleInfo), null, false);
		}

		// Token: 0x06032DB8 RID: 208312 RVA: 0x00BDA5F6 File Offset: 0x00BD87F6
		private void UpdateRoleInfo()
		{
			this.UpdateRoleLevel();
			this.UpdateButtonState();
			this.UpdateRoleBreakLevel();
			this.UpdateRename();
			this.UpdateAttribute();
			this.UpdateTrial();
			this.UpdateRoleChangeButton();
			this.UpdateRoleTag();
			this.UpdateRoleSkinButton();
		}

		// Token: 0x06032DB9 RID: 208313 RVA: 0x00BDA630 File Offset: 0x00BD8830
		private void UpdateRoleChangeButton()
		{
			int curSelectRoleId = this.RoleViewAgent.GetCurSelectRoleId();
			RoleDataBase curSelectRoleData = this.RoleViewAgent.GetCurSelectRoleData();
			bool flag = MainRoleController.Instance.IsMainRole(curSelectRoleId);
			bool flag2 = curSelectRoleData.IsTrialRole();
			int? roleElementTransferFunctionId = RoleConfig.Instance.GetRoleElementTransferFunctionId();
			bool flag3 = FunctionModel.Instance.IsOpen(roleElementTransferFunctionId.Value);
			bool flag4 = GameModeController.Instance.IsInInstance();
			bool flag5 = RoleDefine.RoleViewSourceHideRoleChange[this.RoleViewAgent.Source];
			bool flag6 = flag && flag3 && !flag4 && !flag2 && !flag5;
			base.GetButton(16).RootUIComp.Get().SetUIActive(flag6);
			UUIItem item = base.GetItem(23);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(flag6 && !LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.DirectTrainMakeRoleChange, false));
		}

		// Token: 0x06032DBA RID: 208314 RVA: 0x00BDA700 File Offset: 0x00BD8900
		private void UpdateRoleSkinButton()
		{
			bool flag = this.RoleViewAgent.GetCurSelectRoleData().IsTrialRole();
			base.GetButton(21).RootUIComp.Get().SetUIActive(!flag);
		}

		// Token: 0x06032DBB RID: 208315 RVA: 0x00BDA73C File Offset: 0x00BD893C
		private void UpdateRename()
		{
			base.GetText(11).SetText(this.RoleInstance.GetName(null), true);
		}

		// Token: 0x06032DBC RID: 208316 RVA: 0x00BDA76C File Offset: 0x00BD896C
		private void UpdateTrial()
		{
			bool flag = this.RoleInstance.IsTrialRole();
			base.GetItem(13).SetUIActive(flag);
			if (flag)
			{
				int trialRoleId = (this.RoleInstance as RoleRobotData).GetTrialRoleId();
				string trailRoleLabelIconById = RoleUtils.GetTrailRoleLabelIconById(trialRoleId);
				string resourcePath = UiResourceConfig.Instance.GetResourcePath(trailRoleLabelIconById);
				this.SetSpriteByPath(resourcePath, base.GetSprite(24), false, null, null);
				ETrialRoleType trialRoleType = RoleUtils.GetTrialRoleType(trialRoleId);
				string text;
				FColor color = FColor.FromHex(RoleDefine.trialRoleHexColor.TryGetValue(trialRoleType, out text) ? text : RoleDefine.trialRoleHexColor[ETrialRoleType.NormalTrial]);
				UUIText text2 = base.GetText(25);
				if (text2 != null)
				{
					text2.SetColor(color);
				}
				if (this.RoleViewAgent.Source == ERoleViewSource.WheelTower)
				{
					LguiUtil.Instance.SetLocalTextNew(base.GetText(25), "WheelTower_Template_Role", Array.Empty<object>());
				}
			}
		}

		// Token: 0x06032DBD RID: 208317 RVA: 0x00BDA844 File Offset: 0x00BD8A44
		protected void UpdateButtonState()
		{
			if (this.RoleInstance.IsTrialRole())
			{
				this.LevelUpButtonItem.SetActive(false);
				this.BreakthroughButtonItem.SetActive(false);
				return;
			}
			string id = "RoleMaxLevelPreview";
			this.LevelUpButtonItem.SetActive(this.RoleState != ERoleState.NoRole && this.RoleState != ERoleState.CanBreakthrough);
			if (this.RoleState != ERoleState.NoRole)
			{
				if (this.RoleState == ERoleState.MaxLevel)
				{
					id = "RoleReachMaxLevel";
				}
				else if (this.RoleState == ERoleState.CanBreakthrough)
				{
					id = "RoleBreakup";
				}
				else if (this.RoleState == ERoleState.CanLevelUp)
				{
					id = "RoleLevelUp";
				}
				string textById = TextConfig.Instance.GetTextById(id);
				this.LevelUpButtonItem.SetText(textById);
				this.LevelUpButtonItem.SetEnableClick(this.RoleState != ERoleState.MaxLevel);
			}
			this.BreakthroughButtonItem.SetActive(this.RoleState != ERoleState.NoRole && this.RoleState == ERoleState.CanBreakthrough);
			string textById2 = TextConfig.Instance.GetTextById("RoleBreakup");
			this.BreakthroughButtonItem.SetText(textById2);
		}

		// Token: 0x06032DBE RID: 208318 RVA: 0x00BDA944 File Offset: 0x00BD8B44
		protected void SetRoleLevelUpState()
		{
			RoleLevelData levelData = this.RoleInstance.GetLevelData();
			if (levelData.GetRoleIsMaxLevel())
			{
				this.RoleState = ERoleState.MaxLevel;
				return;
			}
			if (levelData.GetRoleNeedBreakUp())
			{
				this.RoleState = ERoleState.CanBreakthrough;
				return;
			}
			this.RoleState = ERoleState.CanLevelUp;
		}

		// Token: 0x06032DBF RID: 208319 RVA: 0x00BDA984 File Offset: 0x00BD8B84
		protected void PlayMontageStart()
		{
			bool instantAttributeBlend = RoleUtils.NeedInstantAttributeBlend(this.RoleInstance.GetRoleId());
			RoleController.Instance.SetInstantAttributeBlend(instantAttributeBlend);
			RoleController.Instance.PlayRoleMontage(EPerformanceRoleState.Attribute_Perform, false, false, false);
		}

		// Token: 0x06032DC0 RID: 208320 RVA: 0x00BDA9BC File Offset: 0x00BD8BBC
		protected void PlayMontageStartWithReLoop()
		{
			bool instantAttributeBlend = RoleUtils.NeedInstantAttributeBlend(this.RoleInstance.GetRoleId());
			RoleController.Instance.SetInstantAttributeBlend(instantAttributeBlend);
			RoleController.Instance.PlayRoleMontage(EPerformanceRoleState.Attribute_Perform, false, true, false);
		}

		// Token: 0x06032DC1 RID: 208321 RVA: 0x00BDA9F4 File Offset: 0x00BD8BF4
		protected void UpdateAttribute()
		{
			IReadOnlyList<int> intArrayConfig = ConfigCommonParamById.GetIntArrayConfig("RoleAttributeDisplay6");
			for (int i = 0; i < this.AttributeItemList.Count; i++)
			{
				AttributeItem attributeItem = this.AttributeItemList[i];
				int id = intArrayConfig[i];
				float showAttributeValueById = this.RoleInstance.GetShowAttributeValueById(id);
				attributeItem.SetCurrentValue(showAttributeValueById);
				attributeItem.SetActive(true);
			}
		}

		// Token: 0x06032DC2 RID: 208322 RVA: 0x00BDAA50 File Offset: 0x00BD8C50
		protected override void OnBeforeShow()
		{
			this.RoleInstance = this.RoleViewAgent.GetCurSelectRoleData();
			this.UpdateRoleInfo();
			this.UpdateTeachBtn();
			this.LevelUpButtonItem.BindRedDot(ERedDotName.RoleAttributeTabLevelUp, this.RoleInstance.GetDataId());
		}

		// Token: 0x06032DC3 RID: 208323 RVA: 0x00BDAA87 File Offset: 0x00BD8C87
		protected override void OnAfterShow()
		{
			this.PlayMontageStart();
		}

		// Token: 0x06032DC4 RID: 208324 RVA: 0x00BDAA8F File Offset: 0x00BD8C8F
		protected override void OnBeforeHide()
		{
			this.LevelUpButtonItem.UnBindRedDot();
			RedDotController.Instance.UnBindGivenUi(ERedDotName.RoleSkin, null, 0);
		}

		// Token: 0x06032DC5 RID: 208325 RVA: 0x00BDAAAC File Offset: 0x00BD8CAC
		protected override void OnBeforeDestroy()
		{
			foreach (AttributeItem attributeItem in this.AttributeItemList)
			{
				attributeItem.Destroy(null);
			}
			this.AttributeItemList.Clear();
			this.LevelUpButtonItem = null;
		}

		// Token: 0x0401B0E3 RID: 110819
		private ERoleState RoleState;

		// Token: 0x0401B0E4 RID: 110820
		private ButtonItem LevelUpButtonItem;

		// Token: 0x0401B0E5 RID: 110821
		private ButtonItem BreakthroughButtonItem;

		// Token: 0x0401B0E6 RID: 110822
		protected RoleViewAgent RoleViewAgent;

		// Token: 0x0401B0E7 RID: 110823
		protected RoleDataBase RoleInstance;

		// Token: 0x0401B0E8 RID: 110824
		[Nullable(1)]
		protected List<AttributeItem> AttributeItemList = new List<AttributeItem>();

		// Token: 0x0401B0E9 RID: 110825
		protected IRoleSystemUiParams RoleSystemUiParams;

		// Token: 0x0401B0EA RID: 110826
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<StarItem, IStarItemData> StarLayout;

		// Token: 0x0401B0EB RID: 110827
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<RoleTagSmallIconItem, int> RoleTagLayout;

		// Token: 0x0401B0EC RID: 110828
		private TsUiSceneRoleActor SceneRoleActor;

		// Token: 0x0200AE71 RID: 44657
		[NullableContext(0)]
		private enum ERoleAttributeTabViewDefine
		{
			// Token: 0x04034F5C RID: 216924
			DetailButton,
			// Token: 0x04034F5D RID: 216925
			LevelUpButton,
			// Token: 0x04034F5E RID: 216926
			ExpText,
			// Token: 0x04034F5F RID: 216927
			ExpImage,
			// Token: 0x04034F60 RID: 216928
			BreakLevelText,
			// Token: 0x04034F61 RID: 216929
			AttributeItem,
			// Token: 0x04034F62 RID: 216930
			MaxLevelText,
			// Token: 0x04034F63 RID: 216931
			LevelText,
			// Token: 0x04034F64 RID: 216932
			ElementText,
			// Token: 0x04034F65 RID: 216933
			ElementTexture,
			// Token: 0x04034F66 RID: 216934
			StarRoot,
			// Token: 0x04034F67 RID: 216935
			RoleNameText,
			// Token: 0x04034F68 RID: 216936
			AttributeRootItem,
			// Token: 0x04034F69 RID: 216937
			TrialRootItem,
			// Token: 0x04034F6A RID: 216938
			BtnTeaching,
			// Token: 0x04034F6B RID: 216939
			BreakthroughButton,
			// Token: 0x04034F6C RID: 216940
			RoleChangeButton,
			// Token: 0x04034F6D RID: 216941
			RoleTagRoot,
			// Token: 0x04034F6E RID: 216942
			RoleTagItem,
			// Token: 0x04034F6F RID: 216943
			RoleTagButton,
			// Token: 0x04034F70 RID: 216944
			RoleBreakPreviewButton,
			// Token: 0x04034F71 RID: 216945
			RoleSkinButton,
			// Token: 0x04034F72 RID: 216946
			RoleSkinRedDot,
			// Token: 0x04034F73 RID: 216947
			RoleChangeRedDot,
			// Token: 0x04034F74 RID: 216948
			TrialRoleIcon,
			// Token: 0x04034F75 RID: 216949
			TrialRoleTxt,
			// Token: 0x04034F76 RID: 216950
			BgElementTexture,
			// Token: 0x04034F77 RID: 216951
			MaxSpriteItem
		}
	}
}
