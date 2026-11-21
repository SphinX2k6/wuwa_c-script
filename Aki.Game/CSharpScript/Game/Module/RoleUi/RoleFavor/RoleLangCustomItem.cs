using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.ResManager;
using CSharpScript.Game.Module.RoleLangCustomModel;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.ServerStorage.Container;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher.Update;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleUi.RoleFavor
{
	// Token: 0x02003CB0 RID: 15536
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleLangCustomItem : UiPanelBase
	{
		// Token: 0x06027D25 RID: 163109 RVA: 0x00B26990 File Offset: 0x00B24B90
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClickedBtnInfo));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickedBtnSetting));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06027D26 RID: 163110 RVA: 0x00B26B00 File Offset: 0x00B24D00
		protected override void OnStart()
		{
			ResourceManagerController.Instance.ChangeHttpTickFrequency();
			this.ScrollView = new GenericScrollViewNew<RoleLangCustomTabItem, IRoleLangCustomInfo>(base.GetScrollViewWithScrollbar(4), new Func<RoleLangCustomTabItem>(this.CreateItem), null, false, null);
			UUIButtonComponent button = base.GetButton(2);
			if (button != null)
			{
				button.RootUIComp.Get().SetUIActive(false);
			}
			base.GetExtendToggle(0).CanExecuteChange.Bind(new Func<bool>(this.ToggleCanChangeState));
			base.GetExtendToggle(0).OnStateChange.Add(new Action<EToggleState>(this.OnToggleStateChanged));
			this.TickTimer = TimerSystem.Instance.Forever(new TTimerAction(this.OnTick), 500f, 1f, null, null, true);
			EventSystem.Instance.Add<int>(EEventName.RoleLangCustomRefresh, new Action<int>(this.OnRefreshByNet));
		}

		// Token: 0x06027D27 RID: 163111 RVA: 0x00B26BD8 File Offset: 0x00B24DD8
		protected override void OnBeforeDestroy()
		{
			ResourceManagerController.Instance.RestoreHttpTickFrequency();
			DynamicMaskButton maskButton = this.MaskButton;
			if (maskButton != null)
			{
				maskButton.Destroy(null);
			}
			base.GetExtendToggle(0).CanExecuteChange.Unbind();
			base.GetExtendToggle(0).OnStateChange.Remove(new Action<EToggleState>(this.OnToggleStateChanged));
			if (this.TickTimer != null)
			{
				TimerSystem.Instance.Remove(this.TickTimer);
				this.TickTimer = null;
			}
			EventSystem.Instance.Remove(EEventName.RoleLangCustomRefresh, new Action<int>(this.OnRefreshByNet));
		}

		// Token: 0x06027D28 RID: 163112 RVA: 0x00B26C6C File Offset: 0x00B24E6C
		public void Refresh(int roleId)
		{
			this.RoleId = roleId;
			bool flag = StringUtils.IsBlank(RoleConfig.Instance.GetRoleLangStateGroup(roleId));
			base.SetUiActive(!flag);
			if (flag)
			{
				return;
			}
			List<IRoleLangCustomInfo> roleLangCustomInfo = this.GetRoleLangCustomInfo();
			this.ScrollView.RefreshByData(roleLangCustomInfo, null, false);
			int roleLangType = RoleLangCustomModel.Instance.GetRoleLangType(roleId);
			RoleVoiceLanguage? roleLangCustomConfigById = MenuBaseConfig.Instance.GetRoleLangCustomConfigById(roleLangType);
			string configTextByKey = PublicUtil.Instance.GetConfigTextByKey(roleLangCustomConfigById.Value.Text);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "VoiceDIY_Dubbing", new <>z__ReadOnlySingleElementList<object>(configTextByKey));
			bool valueOrDefault = ((ServerStorageBoolean)ServerStorageModel.Instance.Get(EClientStorageSystemIdType.RoleLangCustomFuncClicked)).Get().GetValueOrDefault();
			UUIItem item = base.GetItem(6);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(!valueOrDefault);
		}

		// Token: 0x06027D29 RID: 163113 RVA: 0x00B26D3C File Offset: 0x00B24F3C
		public void OnTabViewHide()
		{
			if (base.GetExtendToggle(0).GetToggleState() != EToggleState.ETT_Checked)
			{
				return;
			}
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, true, false, false);
		}

		// Token: 0x06027D2A RID: 163114 RVA: 0x00B26D60 File Offset: 0x00B24F60
		protected List<IRoleLangCustomInfo> GetRoleLangCustomInfo()
		{
			List<IRoleLangCustomInfo> list = new List<IRoleLangCustomInfo>();
			List<int> allLanguageTypeForAudio = LanguageUpdateManager.Instance.GetAllLanguageTypeForAudio();
			allLanguageTypeForAudio.Sort((int a, int b) => a - b);
			foreach (int num in allLanguageTypeForAudio)
			{
				global::LanguageDefine languageDefineByType = LanguageSystem.Instance.GetLanguageDefineByType(num);
				RoleLangCustomInfo item = new RoleLangCustomInfo
				{
					RoleId = this.RoleId,
					LangIndex = num,
					LangCode = languageDefineByType.AudioCode
				};
				list.Add(item);
			}
			return list;
		}

		// Token: 0x06027D2B RID: 163115 RVA: 0x00B26E18 File Offset: 0x00B25018
		protected bool IsInBattle()
		{
			SceneTeamModel instance = SceneTeamModel.Instance;
			if (instance.IsPhantomTeam)
			{
				return false;
			}
			EntityHandle getCurrentEntity = instance.GetCurrentEntity;
			if (getCurrentEntity == null || !getCurrentEntity.Valid)
			{
				return false;
			}
			WorldEntity entity = getCurrentEntity.Entity;
			BaseTagComponent baseTagComponent = (entity != null) ? entity.GetComponent<BaseTagComponent>() : null;
			return baseTagComponent != null && baseTagComponent.Valid && baseTagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.进入战斗"]);
		}

		// Token: 0x06027D2C RID: 163116 RVA: 0x00B26E90 File Offset: 0x00B25090
		private UniTask ShowMaskButton()
		{
			RoleLangCustomItem.<ShowMaskButton>d__14 <ShowMaskButton>d__;
			<ShowMaskButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowMaskButton>d__.<>4__this = this;
			<ShowMaskButton>d__.<>1__state = -1;
			<ShowMaskButton>d__.<>t__builder.Start<RoleLangCustomItem.<ShowMaskButton>d__14>(ref <ShowMaskButton>d__);
			return <ShowMaskButton>d__.<>t__builder.Task;
		}

		// Token: 0x06027D2D RID: 163117 RVA: 0x00B26ED3 File Offset: 0x00B250D3
		private void HideMaskButton()
		{
			if (this.MaskButton == null)
			{
				return;
			}
			this.MaskButton.ResetItemParent();
			this.MaskButton.SetActive(false);
		}

		// Token: 0x06027D2E RID: 163118 RVA: 0x00B26EF5 File Offset: 0x00B250F5
		private void OnClickedBtnInfo()
		{
			HelpController.Instance.OpenHelpById(584);
		}

		// Token: 0x06027D2F RID: 163119 RVA: 0x00B26F06 File Offset: 0x00B25106
		private void OnClickedBtnSetting()
		{
			this.OnClickedMask();
			RoleLangCustomModel.Instance.RoleViewRoleId = this.RoleId;
			UiManager.Instance.OpenView(EUiViewName.RoleLangCustomView, this.RoleId, null);
		}

		// Token: 0x06027D30 RID: 163120 RVA: 0x00B26F39 File Offset: 0x00B25139
		private RoleLangCustomTabItem CreateItem()
		{
			return new RoleLangCustomTabItem
			{
				OnClickedCallback = new Action<IRoleLangCustomInfo>(this.OnClickedToggleItem),
				CheckScrollActiveCallback = new Func<bool>(this.CheckScrollActiveCallback)
			};
		}

		// Token: 0x06027D31 RID: 163121 RVA: 0x00B26F64 File Offset: 0x00B25164
		private bool CheckScrollActiveCallback()
		{
			return base.GetScrollViewWithScrollbar(4).RootUIComp.Get().IsUIActiveSelf();
		}

		// Token: 0x06027D32 RID: 163122 RVA: 0x00B26F8C File Offset: 0x00B2518C
		private bool ToggleCanChangeState()
		{
			ServerStorageBoolean serverStorageBoolean = (ServerStorageBoolean)ServerStorageModel.Instance.Get(EClientStorageSystemIdType.RoleLangCustomFuncClicked);
			if (!serverStorageBoolean.Get().GetValueOrDefault())
			{
				serverStorageBoolean.Set(new bool?(true));
				UUIItem item = base.GetItem(6);
				if (item != null)
				{
					item.SetUIActive(false);
				}
				EventSystem.Instance.Emit<int>(EEventName.RoleLangCustomFuncClicked, this.RoleId);
			}
			return RoleLangCustomModel.Instance.CheckServerVoiceDataSame(false);
		}

		// Token: 0x06027D33 RID: 163123 RVA: 0x00B27001 File Offset: 0x00B25201
		private void OnToggleStateChanged(EToggleState state)
		{
			this.ScrollView.SetActive(state == EToggleState.ETT_Checked);
			if (state == EToggleState.ETT_Checked)
			{
				this.ShowMaskButton();
				return;
			}
			this.HideMaskButton();
		}

		// Token: 0x06027D34 RID: 163124 RVA: 0x00B27024 File Offset: 0x00B25224
		private void OnClickedToggleItem(IRoleLangCustomInfo data)
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, true, false, false);
			if (RoleLangCustomModel.Instance.GetRoleLangType(this.RoleId) == data.LangIndex)
			{
				this.Refresh(this.RoleId);
				return;
			}
			RoleLangSetVoiceParam playerVoice = new RoleLangSetVoiceParam
			{
				RoleId = this.RoleId,
				Lang = data.LangIndex,
				NeedRequest = true,
				IsCustom = true,
				IsCover = false
			};
			RoleLangCustomModel.Instance.SetPlayerVoice(playerVoice);
			this.Refresh(this.RoleId);
			Action onSetPlayerVoice = this.OnSetPlayerVoice;
			if (onSetPlayerVoice != null)
			{
				onSetPlayerVoice();
			}
			ScrollingTipsController.Instance.ShowTipsByTextId("Notice_VoiceDIY_Setting_Success", Array.Empty<object>());
		}

		// Token: 0x06027D35 RID: 163125 RVA: 0x00B270D6 File Offset: 0x00B252D6
		private void OnClickedMask()
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, true, false, false);
		}

		// Token: 0x06027D36 RID: 163126 RVA: 0x00B270E9 File Offset: 0x00B252E9
		private void OnRefreshByNet(int roleId)
		{
			this.Refresh(this.RoleId);
		}

		// Token: 0x06027D37 RID: 163127 RVA: 0x00B270F8 File Offset: 0x00B252F8
		private void OnTick(float delta)
		{
			foreach (RoleLangCustomTabItem roleLangCustomTabItem in this.ScrollView.GetScrollItemList())
			{
				roleLangCustomTabItem.OnTick();
			}
		}

		// Token: 0x04015B2B RID: 88875
		private const int HELP_ID = 584;

		// Token: 0x04015B2C RID: 88876
		protected GenericScrollViewNew<RoleLangCustomTabItem, IRoleLangCustomInfo> ScrollView;

		// Token: 0x04015B2D RID: 88877
		protected int RoleId;

		// Token: 0x04015B2E RID: 88878
		private DynamicMaskButton MaskButton;

		// Token: 0x04015B2F RID: 88879
		[Nullable(2)]
		private TimerHandle TickTimer;

		// Token: 0x04015B30 RID: 88880
		[Nullable(2)]
		public Action OnSetPlayerVoice;

		// Token: 0x020098AD RID: 39085
		[NullableContext(0)]
		private enum EDefine
		{
			// Token: 0x0402F9C5 RID: 195013
			TogSort,
			// Token: 0x0402F9C6 RID: 195014
			TxtSort,
			// Token: 0x0402F9C7 RID: 195015
			BtnInfo,
			// Token: 0x0402F9C8 RID: 195016
			BtnSetting,
			// Token: 0x0402F9C9 RID: 195017
			ScrollView,
			// Token: 0x0402F9CA RID: 195018
			ToggleItem,
			// Token: 0x0402F9CB RID: 195019
			RedDot
		}
	}
}
