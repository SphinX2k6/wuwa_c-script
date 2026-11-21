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
	// Token: 0x02003C9C RID: 15516
	[NullableContext(2)]
	[Nullable(0)]
	public class RoleAttributeTabView : UiTabViewBase
	{
		// Token: 0x06027B7A RID: 162682 RVA: 0x00B1F1E8 File Offset: 0x00B1D3E8
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

		// Token: 0x06027B7B RID: 162683 RVA: 0x00B1F502 File Offset: 0x00B1D702
		protected void DetailClick()
		{
			this.UpdateAttrList();
		}

		// Token: 0x06027B7C RID: 162684 RVA: 0x00B1F50C File Offset: 0x00B1D70C
		protected void LevelUpClick(int _)
		{
			RoleViewViewModel viewModel = new RoleViewViewModel(this.RoleInstance.GetRoleId(), false, ERoleViewSource.Normal);
			RoleController.Instance.OpenRoleViewByViewModel(EUiViewName.RoleLevelUpView, viewModel);
		}

		// Token: 0x06027B7D RID: 162685 RVA: 0x00B1F53C File Offset: 0x00B1D73C
		protected void BreakthroughClick(int _)
		{
			RoleViewViewModel viewModel = new RoleViewViewModel(this.RoleInstance.GetRoleId(), false, ERoleViewSource.Normal);
			RoleController.Instance.OpenRoleViewByViewModel(EUiViewName.RoleBreachView, viewModel);
		}

		// Token: 0x06027B7E RID: 162686 RVA: 0x00B1F56C File Offset: 0x00B1D76C
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

		// Token: 0x06027B7F RID: 162687 RVA: 0x00B1F5D0 File Offset: 0x00B1D7D0
		protected void RoleTagClick()
		{
			RoleInfo roleConfig = this.RoleInstance.GetRoleConfig();
			int[] roleTagByRoleInfo = RoleModel.Instance.GetRoleTagByRoleInfo(roleConfig);
			UiManager.Instance.OpenView(EUiViewName.RoleTagDetailView, roleTagByRoleInfo, null);
		}

		// Token: 0x06027B80 RID: 162688 RVA: 0x00B1F608 File Offset: 0x00B1D808
		protected void OnRoleSkinClick()
		{
			int curSelectRoleId = this.RoleViewAgent.GetCurSelectRoleId();
			SkinController.Instance.SkipToSkinView(curSelectRoleId, EUiTabViewName.RoleSkinTabView, false, -1, null, null, null);
		}

		// Token: 0x06027B81 RID: 162689 RVA: 0x00B1F648 File Offset: 0x00B1D848
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

		// Token: 0x06027B82 RID: 162690 RVA: 0x00B1F798 File Offset: 0x00B1D998
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

		// Token: 0x06027B83 RID: 162691 RVA: 0x00B1F8B8 File Offset: 0x00B1DAB8
		[NullableContext(1)]
		private StarItem InitStarItem()
		{
			return new StarItem();
		}

		// Token: 0x06027B84 RID: 162692 RVA: 0x00B1F8BF File Offset: 0x00B1DABF
		[NullableContext(1)]
		private RoleTagSmallIconItem InitRoleTagItem()
		{
			return new RoleTagSmallIconItem();
		}

		// Token: 0x06027B85 RID: 162693 RVA: 0x00B1F8C8 File Offset: 0x00B1DAC8
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

		// Token: 0x06027B86 RID: 162694 RVA: 0x00B1F974 File Offset: 0x00B1DB74
		protected override void AddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.RoleInfoUpdate, new Action<int>(this.OnRoleInfoUpdate));
			EventSystem.Instance.Add<int>(EEventName.RoleSystemChangeRole, new Action<int>(this.ChangeRoleEvent));
			EventSystem.Instance.Add<int, int, int>(EEventName.RoleLevelUp, new Action<int, int, int>(this.OnRoleLevelUp));
			EventSystem.Instance.Add<int>(EEventName.ActiveRole, new Action<int>(this.ActiveRoleEvent));
			EventSystem.Instance.Add(EEventName.RoleRefreshName, new Action(this.RefreshNameEvent));
		}

		// Token: 0x06027B87 RID: 162695 RVA: 0x00B1FA10 File Offset: 0x00B1DC10
		protected override void RemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RoleInfoUpdate, new Action<int>(this.OnRoleInfoUpdate));
			EventSystem.Instance.Remove(EEventName.RoleSystemChangeRole, new Action<int>(this.ChangeRoleEvent));
			EventSystem.Instance.Remove(EEventName.RoleLevelUp, new Action<int, int, int>(this.OnRoleLevelUp));
			EventSystem.Instance.Remove(EEventName.ActiveRole, new Action<int>(this.ActiveRoleEvent));
			EventSystem.Instance.Remove(EEventName.RoleRefreshName, new Action(this.RefreshNameEvent));
		}

		// Token: 0x06027B88 RID: 162696 RVA: 0x00B1FAA9 File Offset: 0x00B1DCA9
		private void ChangeRoleEvent(int roleId)
		{
			this.RoleInstance = RoleModel.Instance.GetRoleDataById(roleId, true);
			EventSystem.Instance.Emit<int>(EEventName.RoleSkinRedDotRefresh, roleId);
			this.PlayMontageStartWithReLoop();
			this.UpdateRoleInfo();
			this.UpdateTeachBtn();
		}

		// Token: 0x06027B89 RID: 162697 RVA: 0x00B1FAE0 File Offset: 0x00B1DCE0
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

		// Token: 0x06027B8A RID: 162698 RVA: 0x00B1FBB7 File Offset: 0x00B1DDB7
		private void OnRoleInfoUpdate(int roleId)
		{
			this.UpdateRoleInfo();
		}

		// Token: 0x06027B8B RID: 162699 RVA: 0x00B1FBBF File Offset: 0x00B1DDBF
		private void OnRoleLevelUp(int i, int i1, int arg3)
		{
			this.UpdateRoleInfo();
		}

		// Token: 0x06027B8C RID: 162700 RVA: 0x00B1FBC7 File Offset: 0x00B1DDC7
		private void ActiveRoleEvent(int i)
		{
			this.PlayModelEffect();
		}

		// Token: 0x06027B8D RID: 162701 RVA: 0x00B1FBCF File Offset: 0x00B1DDCF
		private void RefreshNameEvent()
		{
			this.UpdateRename();
		}

		// Token: 0x06027B8E RID: 162702 RVA: 0x00B1FBD7 File Offset: 0x00B1DDD7
		protected void PlayModelEffect()
		{
			UiRoleUtils.PlayRoleLevelUpEffect(this.SceneRoleActor);
		}

		// Token: 0x06027B8F RID: 162703 RVA: 0x00B1FBE4 File Offset: 0x00B1DDE4
		private void UpdateAttrList()
		{
			UiManager.Instance.OpenView(EUiViewName.RoleAttributeDetailView, this.RoleInstance.GetShowAttrList(), null);
		}

		// Token: 0x06027B90 RID: 162704 RVA: 0x00B1FC04 File Offset: 0x00B1DE04
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

		// Token: 0x06027B91 RID: 162705 RVA: 0x00B1FCFC File Offset: 0x00B1DEFC
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

		// Token: 0x06027B92 RID: 162706 RVA: 0x00B1FEC8 File Offset: 0x00B1E0C8
		private void UpdateRoleTag()
		{
			int[] roleTagByRoleInfo = RoleModel.Instance.GetRoleTagByRoleInfo(this.RoleInstance.GetRoleConfig());
			this.RoleTagLayout.RefreshByData(new List<int>(roleTagByRoleInfo), null, false);
		}

		// Token: 0x06027B93 RID: 162707 RVA: 0x00B1FEFE File Offset: 0x00B1E0FE
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

		// Token: 0x06027B94 RID: 162708 RVA: 0x00B1FF38 File Offset: 0x00B1E138
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

		// Token: 0x06027B95 RID: 162709 RVA: 0x00B20008 File Offset: 0x00B1E208
		private void UpdateRoleSkinButton()
		{
			bool flag = this.RoleViewAgent.GetCurSelectRoleData().IsTrialRole();
			base.GetButton(21).RootUIComp.Get().SetUIActive(!flag);
		}

		// Token: 0x06027B96 RID: 162710 RVA: 0x00B20044 File Offset: 0x00B1E244
		private void UpdateRename()
		{
			base.GetText(11).SetText(this.RoleInstance.GetName(null), true);
		}

		// Token: 0x06027B97 RID: 162711 RVA: 0x00B20074 File Offset: 0x00B1E274
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

		// Token: 0x06027B98 RID: 162712 RVA: 0x00B2014C File Offset: 0x00B1E34C
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

		// Token: 0x06027B99 RID: 162713 RVA: 0x00B2024C File Offset: 0x00B1E44C
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

		// Token: 0x06027B9A RID: 162714 RVA: 0x00B2028C File Offset: 0x00B1E48C
		protected void PlayMontageStart()
		{
			bool instantAttributeBlend = RoleUtils.NeedInstantAttributeBlend(this.RoleInstance.GetRoleId());
			RoleController.Instance.SetInstantAttributeBlend(instantAttributeBlend);
			RoleController.Instance.PlayRoleMontage(EPerformanceRoleState.Attribute_Perform, false, false, false);
		}

		// Token: 0x06027B9B RID: 162715 RVA: 0x00B202C4 File Offset: 0x00B1E4C4
		protected void PlayMontageStartWithReLoop()
		{
			bool instantAttributeBlend = RoleUtils.NeedInstantAttributeBlend(this.RoleInstance.GetRoleId());
			RoleController.Instance.SetInstantAttributeBlend(instantAttributeBlend);
			RoleController.Instance.PlayRoleMontage(EPerformanceRoleState.Attribute_Perform, false, true, false);
		}

		// Token: 0x06027B9C RID: 162716 RVA: 0x00B202FC File Offset: 0x00B1E4FC
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

		// Token: 0x06027B9D RID: 162717 RVA: 0x00B20358 File Offset: 0x00B1E558
		protected override void OnBeforeShow()
		{
			this.RoleInstance = this.RoleViewAgent.GetCurSelectRoleData();
			this.UpdateRoleInfo();
			this.UpdateTeachBtn();
			this.LevelUpButtonItem.BindRedDot(ERedDotName.RoleAttributeTabLevelUp, this.RoleInstance.GetDataId());
		}

		// Token: 0x06027B9E RID: 162718 RVA: 0x00B2038F File Offset: 0x00B1E58F
		protected override void OnAfterShow()
		{
			this.PlayMontageStart();
		}

		// Token: 0x06027B9F RID: 162719 RVA: 0x00B20397 File Offset: 0x00B1E597
		protected override void OnBeforeHide()
		{
			this.LevelUpButtonItem.UnBindRedDot();
			RedDotController.Instance.UnBindGivenUi(ERedDotName.RoleSkin, null, 0);
		}

		// Token: 0x06027BA0 RID: 162720 RVA: 0x00B203B4 File Offset: 0x00B1E5B4
		protected override void OnBeforeDestroy()
		{
			foreach (AttributeItem attributeItem in this.AttributeItemList)
			{
				attributeItem.Destroy(null);
			}
			this.AttributeItemList.Clear();
			this.LevelUpButtonItem = null;
		}

		// Token: 0x04015A68 RID: 88680
		private ERoleState RoleState;

		// Token: 0x04015A69 RID: 88681
		private ButtonItem LevelUpButtonItem;

		// Token: 0x04015A6A RID: 88682
		private ButtonItem BreakthroughButtonItem;

		// Token: 0x04015A6B RID: 88683
		protected RoleViewAgent RoleViewAgent;

		// Token: 0x04015A6C RID: 88684
		protected RoleDataBase RoleInstance;

		// Token: 0x04015A6D RID: 88685
		[Nullable(1)]
		protected List<AttributeItem> AttributeItemList = new List<AttributeItem>();

		// Token: 0x04015A6E RID: 88686
		protected IRoleSystemUiParams RoleSystemUiParams;

		// Token: 0x04015A6F RID: 88687
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<StarItem, IStarItemData> StarLayout;

		// Token: 0x04015A70 RID: 88688
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<RoleTagSmallIconItem, int> RoleTagLayout;

		// Token: 0x04015A71 RID: 88689
		private TsUiSceneRoleActor SceneRoleActor;

		// Token: 0x0200988F RID: 39055
		[NullableContext(0)]
		private enum ERoleAttributeTabViewDefine
		{
			// Token: 0x0402F904 RID: 194820
			DetailButton,
			// Token: 0x0402F905 RID: 194821
			LevelUpButton,
			// Token: 0x0402F906 RID: 194822
			ExpText,
			// Token: 0x0402F907 RID: 194823
			ExpImage,
			// Token: 0x0402F908 RID: 194824
			BreakLevelText,
			// Token: 0x0402F909 RID: 194825
			AttributeItem,
			// Token: 0x0402F90A RID: 194826
			MaxLevelText,
			// Token: 0x0402F90B RID: 194827
			LevelText,
			// Token: 0x0402F90C RID: 194828
			ElementText,
			// Token: 0x0402F90D RID: 194829
			ElementTexture,
			// Token: 0x0402F90E RID: 194830
			StarRoot,
			// Token: 0x0402F90F RID: 194831
			RoleNameText,
			// Token: 0x0402F910 RID: 194832
			AttributeRootItem,
			// Token: 0x0402F911 RID: 194833
			TrialRootItem,
			// Token: 0x0402F912 RID: 194834
			BtnTeaching,
			// Token: 0x0402F913 RID: 194835
			BreakthroughButton,
			// Token: 0x0402F914 RID: 194836
			RoleChangeButton,
			// Token: 0x0402F915 RID: 194837
			RoleTagRoot,
			// Token: 0x0402F916 RID: 194838
			RoleTagItem,
			// Token: 0x0402F917 RID: 194839
			RoleTagButton,
			// Token: 0x0402F918 RID: 194840
			RoleBreakPreviewButton,
			// Token: 0x0402F919 RID: 194841
			RoleSkinButton,
			// Token: 0x0402F91A RID: 194842
			RoleSkinRedDot,
			// Token: 0x0402F91B RID: 194843
			RoleChangeRedDot,
			// Token: 0x0402F91C RID: 194844
			TrialRoleIcon,
			// Token: 0x0402F91D RID: 194845
			TrialRoleTxt,
			// Token: 0x0402F91E RID: 194846
			BgElementTexture,
			// Token: 0x0402F91F RID: 194847
			MaxSpriteItem
		}
	}
}
