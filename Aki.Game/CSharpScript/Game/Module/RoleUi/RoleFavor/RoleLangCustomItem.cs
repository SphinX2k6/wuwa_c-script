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
	// Token: 0x02004CFE RID: 19710
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleLangCustomItem : UiPanelBase
	{
		// Token: 0x06032F4A RID: 208714 RVA: 0x00BE1088 File Offset: 0x00BDF288
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

		// Token: 0x06032F4B RID: 208715 RVA: 0x00BE11F8 File Offset: 0x00BDF3F8
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

		// Token: 0x06032F4C RID: 208716 RVA: 0x00BE12D0 File Offset: 0x00BDF4D0
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

		// Token: 0x06032F4D RID: 208717 RVA: 0x00BE1364 File Offset: 0x00BDF564
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

		// Token: 0x06032F4E RID: 208718 RVA: 0x00BE1434 File Offset: 0x00BDF634
		public void OnTabViewHide()
		{
			if (base.GetExtendToggle(0).GetToggleState() != EToggleState.ETT_Checked)
			{
				return;
			}
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, true, false, false);
		}

		// Token: 0x06032F4F RID: 208719 RVA: 0x00BE1458 File Offset: 0x00BDF658
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

		// Token: 0x06032F50 RID: 208720 RVA: 0x00BE1510 File Offset: 0x00BDF710
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

		// Token: 0x06032F51 RID: 208721 RVA: 0x00BE1588 File Offset: 0x00BDF788
		private UniTask ShowMaskButton()
		{
			RoleLangCustomItem.<ShowMaskButton>d__14 <ShowMaskButton>d__;
			<ShowMaskButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowMaskButton>d__.<>4__this = this;
			<ShowMaskButton>d__.<>1__state = -1;
			<ShowMaskButton>d__.<>t__builder.Start<RoleLangCustomItem.<ShowMaskButton>d__14>(ref <ShowMaskButton>d__);
			return <ShowMaskButton>d__.<>t__builder.Task;
		}

		// Token: 0x06032F52 RID: 208722 RVA: 0x00BE15CB File Offset: 0x00BDF7CB
		private void HideMaskButton()
		{
			if (this.MaskButton == null)
			{
				return;
			}
			this.MaskButton.ResetItemParent();
			this.MaskButton.SetActive(false);
		}

		// Token: 0x06032F53 RID: 208723 RVA: 0x00BE15ED File Offset: 0x00BDF7ED
		private void OnClickedBtnInfo()
		{
			HelpController.Instance.OpenHelpById(584);
		}

		// Token: 0x06032F54 RID: 208724 RVA: 0x00BE15FE File Offset: 0x00BDF7FE
		private void OnClickedBtnSetting()
		{
			this.OnClickedMask();
			RoleLangCustomModel.Instance.RoleViewRoleId = this.RoleId;
			UiManager.Instance.OpenView(EUiViewName.RoleLangCustomView, this.RoleId, null);
		}

		// Token: 0x06032F55 RID: 208725 RVA: 0x00BE1631 File Offset: 0x00BDF831
		private RoleLangCustomTabItem CreateItem()
		{
			return new RoleLangCustomTabItem
			{
				OnClickedCallback = new Action<IRoleLangCustomInfo>(this.OnClickedToggleItem),
				CheckScrollActiveCallback = new Func<bool>(this.CheckScrollActiveCallback)
			};
		}

		// Token: 0x06032F56 RID: 208726 RVA: 0x00BE165C File Offset: 0x00BDF85C
		private bool CheckScrollActiveCallback()
		{
			return base.GetScrollViewWithScrollbar(4).RootUIComp.Get().IsUIActiveSelf();
		}

		// Token: 0x06032F57 RID: 208727 RVA: 0x00BE1684 File Offset: 0x00BDF884
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

		// Token: 0x06032F58 RID: 208728 RVA: 0x00BE16F9 File Offset: 0x00BDF8F9
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

		// Token: 0x06032F59 RID: 208729 RVA: 0x00BE171C File Offset: 0x00BDF91C
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

		// Token: 0x06032F5A RID: 208730 RVA: 0x00BE17CE File Offset: 0x00BDF9CE
		private void OnClickedMask()
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, true, false, false);
		}

		// Token: 0x06032F5B RID: 208731 RVA: 0x00BE17E1 File Offset: 0x00BDF9E1
		private void OnRefreshByNet(int roleId)
		{
			this.Refresh(this.RoleId);
		}

		// Token: 0x06032F5C RID: 208732 RVA: 0x00BE17F0 File Offset: 0x00BDF9F0
		private void OnTick(float delta)
		{
			foreach (RoleLangCustomTabItem roleLangCustomTabItem in this.ScrollView.GetScrollItemList())
			{
				roleLangCustomTabItem.OnTick();
			}
		}

		// Token: 0x0401B1A6 RID: 111014
		private const int HELP_ID = 584;

		// Token: 0x0401B1A7 RID: 111015
		protected GenericScrollViewNew<RoleLangCustomTabItem, IRoleLangCustomInfo> ScrollView;

		// Token: 0x0401B1A8 RID: 111016
		protected int RoleId;

		// Token: 0x0401B1A9 RID: 111017
		private DynamicMaskButton MaskButton;

		// Token: 0x0401B1AA RID: 111018
		[Nullable(2)]
		private TimerHandle TickTimer;

		// Token: 0x0401B1AB RID: 111019
		[Nullable(2)]
		public Action OnSetPlayerVoice;

		// Token: 0x0200AE8F RID: 44687
		[NullableContext(0)]
		private enum EDefine
		{
			// Token: 0x0403501D RID: 217117
			TogSort,
			// Token: 0x0403501E RID: 217118
			TxtSort,
			// Token: 0x0403501F RID: 217119
			BtnInfo,
			// Token: 0x04035020 RID: 217120
			BtnSetting,
			// Token: 0x04035021 RID: 217121
			ScrollView,
			// Token: 0x04035022 RID: 217122
			ToggleItem,
			// Token: 0x04035023 RID: 217123
			RedDot
		}
	}
}
