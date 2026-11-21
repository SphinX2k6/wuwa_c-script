using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020050FE RID: 20734
	[NullableContext(2)]
	[Nullable(0)]
	public class RoverlikeRoleSelectView : UiViewBase
	{
		// Token: 0x1700651F RID: 25887
		// (get) Token: 0x06033E05 RID: 212485 RVA: 0x00E853A5 File Offset: 0x00E835A5
		private RoverlikeActivityData ActivityData
		{
			get
			{
				return RoverlikeActivityController.Instance.GetCurrentActivityData();
			}
		}

		// Token: 0x06033E06 RID: 212486 RVA: 0x00E853B1 File Offset: 0x00E835B1
		[NullableContext(1)]
		public RoverlikeRoleSelectView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06033E07 RID: 212487 RVA: 0x00E853D0 File Offset: 0x00E835D0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 16;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIGridLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIGridLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.OnLightToggleStateChange));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action<EToggleState>(this.OnDarkToggleStateChange));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06033E08 RID: 212488 RVA: 0x00E85670 File Offset: 0x00E83870
		protected override UniTask OnBeforeStartAsync()
		{
			RoverlikeRoleSelectView.<OnBeforeStartAsync>d__20 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoverlikeRoleSelectView.<OnBeforeStartAsync>d__20>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033E09 RID: 212489 RVA: 0x00E856B4 File Offset: 0x00E838B4
		protected override void OnStart()
		{
			this.RoleTypeIdList.Clear();
			foreach (RoverRogueRoleType roverRogueRoleType in RoverlikeConfig.Instance.GetRoleTypeConfigList())
			{
				this.RoleTypeIdList.Add(roverRogueRoleType.Id);
			}
			RoverlikeRoleSelectViewOpenParam roverlikeRoleSelectViewOpenParam = this.OpenParam as RoverlikeRoleSelectViewOpenParam;
			this.CurInstId = ((roverlikeRoleSelectViewOpenParam != null) ? roverlikeRoleSelectViewOpenParam.InstId : 0);
			this.BuildSelectableRoleTypeSet();
			this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
			this.CaptionItem.SetCloseCallBack(new Action(this.OnClickClose));
			this.ConfirmButton = new ButtonItem(base.GetButton(15).RootUIComp.Get());
			this.ConfirmButton.SetFunction(new Action<int>(this.OnClickConfirm));
			UUIExtendToggle extendToggle = base.GetExtendToggle(1);
			if (extendToggle != null)
			{
				extendToggle.CanExecuteChange.Bind(() => this.CurRoleTypeId != this.GetRoleTypeIdByIndex(0));
			}
			UUIExtendToggle extendToggle2 = base.GetExtendToggle(2);
			if (extendToggle2 != null)
			{
				extendToggle2.CanExecuteChange.Bind(() => this.CurRoleTypeId != this.GetRoleTypeIdByIndex(1));
			}
			this.BuildInfoLayout();
			this.BuildAssistRoleLayouts();
			this.RefreshRoleStand();
			this.SelectElement(this.GetDefaultRoleTypeId());
		}

		// Token: 0x06033E0A RID: 212490 RVA: 0x00E85804 File Offset: 0x00E83A04
		protected override void OnBeforeDestroy()
		{
			this.CaptionItem = null;
			this.ConfirmButton = null;
			this.TitlePanel = null;
			this.UnlockPanel = null;
			this.LightTogglePanel = null;
			this.DarkTogglePanel = null;
			this.InfoLayout = null;
			this.AssistLayoutL = null;
			this.AssistLayoutR = null;
		}

		// Token: 0x06033E0B RID: 212491 RVA: 0x00E85850 File Offset: 0x00E83A50
		private void BuildInfoLayout()
		{
			UUILayoutBase layout = base.GetScrollViewWithScrollbar(8).GetContent().GetComponentByClass(UUILayoutBase.StaticClass()) as UUILayoutBase;
			this.InfoLayout = new GenericLayout<RoverlikeRoleSelectInfoItem, RoverlikeRoleSelectInfoItemData>(layout, () => new RoverlikeRoleSelectInfoItem(), base.GetItem(9).GetOwner() as AUIBaseActor, false, true);
		}

		// Token: 0x06033E0C RID: 212492 RVA: 0x00E858C0 File Offset: 0x00E83AC0
		private void BuildAssistRoleLayouts()
		{
			this.AssistLayoutL = new GenericLayout<RoverlikeRoleSelectAssistRoleItem, RoverlikeRoleSelectAssistRoleItemData>(base.GetGridLayout(10), () => new RoverlikeRoleSelectAssistRoleItem(), base.GetItem(11).GetOwner() as AUIBaseActor, false, true);
			this.AssistLayoutR = new GenericLayout<RoverlikeRoleSelectAssistRoleItem, RoverlikeRoleSelectAssistRoleItemData>(base.GetGridLayout(12), () => new RoverlikeRoleSelectAssistRoleItem(), base.GetItem(13).GetOwner() as AUIBaseActor, false, true);
		}

		// Token: 0x06033E0D RID: 212493 RVA: 0x00E8595C File Offset: 0x00E83B5C
		private int GetDefaultRoleTypeId()
		{
			RoverlikeRoleSelectViewOpenParam roverlikeRoleSelectViewOpenParam = this.OpenParam as RoverlikeRoleSelectViewOpenParam;
			int num = (roverlikeRoleSelectViewOpenParam != null) ? roverlikeRoleSelectViewOpenParam.DefaultRoleTypeId : 0;
			if (num > 0 && this.RoleTypeIdList.Contains(num))
			{
				return num;
			}
			int lastPassRoleTypeId = RoverlikeModel.Instance.GetLastPassRoleTypeId();
			if (lastPassRoleTypeId > 0 && this.RoleTypeIdList.Contains(lastPassRoleTypeId))
			{
				return lastPassRoleTypeId;
			}
			return this.GetRoleTypeIdByIndex(0);
		}

		// Token: 0x06033E0E RID: 212494 RVA: 0x00E859BB File Offset: 0x00E83BBB
		private int GetRoleTypeIdByIndex(int index)
		{
			if (index >= 0 && index < this.RoleTypeIdList.Count)
			{
				return this.RoleTypeIdList[index];
			}
			if (index != 0)
			{
				return 2;
			}
			return 1;
		}

		// Token: 0x06033E0F RID: 212495 RVA: 0x00E859E4 File Offset: 0x00E83BE4
		private void SelectElement(int roleTypeId)
		{
			this.CurRoleTypeId = roleTypeId;
			bool flag = roleTypeId == this.GetRoleTypeIdByIndex(0);
			UUIExtendToggle extendToggle = base.GetExtendToggle(1);
			if (extendToggle != null)
			{
				extendToggle.SetToggleStateForce(flag ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
			}
			UUIExtendToggle extendToggle2 = base.GetExtendToggle(2);
			if (extendToggle2 != null)
			{
				extendToggle2.SetToggleStateForce(flag ? EToggleState.ETT_UnChecked : EToggleState.ETT_Checked, false, false, false);
			}
			RoverRogueRoleType? roleTypeConfig = this.GetRoleTypeConfig(roleTypeId);
			this.RefreshEffect();
			RoverlikeRoleSelectTitlePanel titlePanel = this.TitlePanel;
			if (titlePanel != null)
			{
				titlePanel.RefreshElement(flag, roleTypeConfig);
			}
			this.RefreshInfoList(roleTypeConfig);
			this.RefreshAssistRoles(roleTypeId);
			this.RefreshUnlockState(roleTypeId, roleTypeConfig);
		}

		// Token: 0x06033E10 RID: 212496 RVA: 0x00E85A74 File Offset: 0x00E83C74
		private void RefreshEffect()
		{
			int roleTypeIdByIndex = this.GetRoleTypeIdByIndex(0);
			int roleTypeIdByIndex2 = this.GetRoleTypeIdByIndex(1);
			bool flag = this.CurRoleTypeId == roleTypeIdByIndex;
			UUIItem item = base.GetItem(5);
			if (item != null)
			{
				item.SetUIActive(flag && this.IsRoleTypeSelectable(roleTypeIdByIndex));
			}
			UUIItem item2 = base.GetItem(6);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(!flag && this.IsRoleTypeSelectable(roleTypeIdByIndex2));
		}

		// Token: 0x06033E11 RID: 212497 RVA: 0x00E85AD8 File Offset: 0x00E83CD8
		private void RefreshRoleStand()
		{
			bool flag = RoverlikeModel.Instance.GetMainRoleId() == 5053002;
			UUIItem item = base.GetItem(3);
			if (item != null)
			{
				item.SetUIActive(flag);
			}
			UUIItem item2 = base.GetItem(4);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(!flag);
		}

		// Token: 0x06033E12 RID: 212498 RVA: 0x00E85B1F File Offset: 0x00E83D1F
		private void RefreshInfoList(RoverRogueRoleType? cfg)
		{
			GenericLayout<RoverlikeRoleSelectInfoItem, RoverlikeRoleSelectInfoItemData> infoLayout = this.InfoLayout;
			if (infoLayout == null)
			{
				return;
			}
			infoLayout.RefreshByData(this.BuildInfoDataList(cfg), null, false);
		}

		// Token: 0x06033E13 RID: 212499 RVA: 0x00E85B3C File Offset: 0x00E83D3C
		[NullableContext(1)]
		private List<RoverlikeRoleSelectInfoItemData> BuildInfoDataList(RoverRogueRoleType? cfg)
		{
			List<RoverlikeRoleSelectInfoItemData> list = new List<RoverlikeRoleSelectInfoItemData>();
			if (cfg == null)
			{
				return list;
			}
			int num = Math.Min(cfg.Value.SkillTitleListLength, cfg.Value.SkillDescListLength);
			for (int i = 0; i < num; i++)
			{
				list.Add(new RoverlikeRoleSelectInfoItemData
				{
					TitleTextId = (cfg.Value.SkillTitleList(i) ?? ""),
					DescTextId = (cfg.Value.SkillDescList(i) ?? "")
				});
			}
			return list;
		}

		// Token: 0x06033E14 RID: 212500 RVA: 0x00E85BD4 File Offset: 0x00E83DD4
		private void RefreshAssistRoles(int roleTypeId)
		{
			RoverlikeActivityData activityData = this.ActivityData;
			int num = (activityData != null) ? activityData.Id : 0;
			IEnumerable<RoverRogueBlessRole> blessRoleConfigList = RoverlikeConfig.Instance.GetBlessRoleConfigList();
			List<RoverlikeRoleSelectAssistRoleItemData> list = new List<RoverlikeRoleSelectAssistRoleItemData>();
			List<RoverlikeRoleSelectAssistRoleItemData> list2 = new List<RoverlikeRoleSelectAssistRoleItemData>();
			foreach (RoverRogueBlessRole roverRogueBlessRole in blessRoleConfigList)
			{
				if (roverRogueBlessRole.Id != 13 && (num <= 0 || roverRogueBlessRole.ActivityId == num))
				{
					int enableRoleTypeLength = roverRogueBlessRole.EnableRoleTypeLength;
					bool flag = false;
					for (int i = 0; i < enableRoleTypeLength; i++)
					{
						if (roverRogueBlessRole.EnableRoleType(i) == roleTypeId)
						{
							flag = true;
							break;
						}
					}
					if (flag)
					{
						if (enableRoleTypeLength > 1)
						{
							list.Add(new RoverlikeRoleSelectAssistRoleItemData
							{
								BlessRoleId = roverRogueBlessRole.Id
							});
						}
						else
						{
							list2.Add(new RoverlikeRoleSelectAssistRoleItemData
							{
								BlessRoleId = roverRogueBlessRole.Id
							});
						}
					}
				}
			}
			GenericLayout<RoverlikeRoleSelectAssistRoleItem, RoverlikeRoleSelectAssistRoleItemData> assistLayoutL = this.AssistLayoutL;
			if (assistLayoutL != null)
			{
				assistLayoutL.RefreshByData(list, null, false);
			}
			GenericLayout<RoverlikeRoleSelectAssistRoleItem, RoverlikeRoleSelectAssistRoleItemData> assistLayoutR = this.AssistLayoutR;
			if (assistLayoutR == null)
			{
				return;
			}
			assistLayoutR.RefreshByData(list2, null, false);
		}

		// Token: 0x06033E15 RID: 212501 RVA: 0x00E85CF0 File Offset: 0x00E83EF0
		private void RefreshUnlockState(int roleTypeId, RoverRogueRoleType? cfg)
		{
			bool flag = this.IsRoleTypeSelectable(roleTypeId);
			RoverlikeRoleSelectUnlockPanel unlockPanel = this.UnlockPanel;
			if (unlockPanel != null)
			{
				unlockPanel.SetActive(!flag);
			}
			if (!flag)
			{
				RoverlikeActivityData activityData = this.ActivityData;
				bool flag2 = activityData != null && activityData.IsRoleTypeUnlocked(roleTypeId);
				RoverlikeRoleSelectUnlockPanel unlockPanel2 = this.UnlockPanel;
				if (unlockPanel2 != null)
				{
					unlockPanel2.RefreshUnlockDesc(flag2 ? "RoverRogue_ElementLocked" : (((cfg != null) ? cfg.GetValueOrDefault().UnlockDesc : null) ?? ""));
				}
			}
			RoverlikeRoleSelectElementTogglePanel lightTogglePanel = this.LightTogglePanel;
			if (lightTogglePanel != null)
			{
				lightTogglePanel.SetLocked(!this.IsRoleTypeSelectable(this.GetRoleTypeIdByIndex(0)));
			}
			RoverlikeRoleSelectElementTogglePanel darkTogglePanel = this.DarkTogglePanel;
			if (darkTogglePanel != null)
			{
				darkTogglePanel.SetLocked(!this.IsRoleTypeSelectable(this.GetRoleTypeIdByIndex(1)));
			}
			ButtonItem confirmButton = this.ConfirmButton;
			if (confirmButton == null)
			{
				return;
			}
			confirmButton.SetActive(flag);
		}

		// Token: 0x06033E16 RID: 212502 RVA: 0x00E85DC3 File Offset: 0x00E83FC3
		private RoverRogueRoleType? GetRoleTypeConfig(int roleTypeId)
		{
			return RoverlikeConfig.Instance.GetRoleTypeConfig(roleTypeId);
		}

		// Token: 0x06033E17 RID: 212503 RVA: 0x00E85DD0 File Offset: 0x00E83FD0
		private void BuildSelectableRoleTypeSet()
		{
			this.SelectableRoleTypeIdSet.Clear();
			RoverRogueIns? insConfig = RoverlikeConfig.Instance.GetInsConfig(this.CurInstId);
			if (insConfig == null)
			{
				return;
			}
			int roverListLength = insConfig.Value.RoverListLength;
			if (roverListLength <= 0)
			{
				return;
			}
			for (int i = 0; i < roverListLength; i++)
			{
				this.SelectableRoleTypeIdSet.Add(insConfig.Value.RoverList(i));
			}
		}

		// Token: 0x06033E18 RID: 212504 RVA: 0x00E85E40 File Offset: 0x00E84040
		private bool IsRoleTypeSelectable(int roleTypeId)
		{
			return this.SelectableRoleTypeIdSet.Contains(roleTypeId);
		}

		// Token: 0x06033E19 RID: 212505 RVA: 0x00E85E50 File Offset: 0x00E84050
		private void OnLightToggleStateChange(EToggleState state)
		{
			if (state != EToggleState.ETT_Checked)
			{
				return;
			}
			this.SelectElement(this.GetRoleTypeIdByIndex(0));
			base.PlayOrReplaySequence("Switch", false, null);
		}

		// Token: 0x06033E1A RID: 212506 RVA: 0x00E85E84 File Offset: 0x00E84084
		private void OnDarkToggleStateChange(EToggleState state)
		{
			if (state != EToggleState.ETT_Checked)
			{
				return;
			}
			this.SelectElement(this.GetRoleTypeIdByIndex(1));
			base.PlayOrReplaySequence("Switch", false, null);
		}

		// Token: 0x06033E1B RID: 212507 RVA: 0x00E85EB8 File Offset: 0x00E840B8
		private void OnClickConfirm(int data)
		{
			if (!this.IsRoleTypeSelectable(this.CurRoleTypeId))
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("RoverRogue_RoleSelect_LockedTip", Array.Empty<object>());
				return;
			}
			RoverlikeRoleSelectViewOpenParam roverlikeRoleSelectViewOpenParam = this.OpenParam as RoverlikeRoleSelectViewOpenParam;
			if (roverlikeRoleSelectViewOpenParam != null)
			{
				Action<int> onConfirm = roverlikeRoleSelectViewOpenParam.OnConfirm;
				if (onConfirm != null)
				{
					onConfirm(this.CurRoleTypeId);
				}
			}
			base.CloseMe(null);
		}

		// Token: 0x06033E1C RID: 212508 RVA: 0x00E85F16 File Offset: 0x00E84116
		private void OnClickClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x0401B779 RID: 112505
		private const int ROLE_TYPE_INDEX_LIGHT = 0;

		// Token: 0x0401B77A RID: 112506
		private const int ROLE_TYPE_INDEX_DARK = 1;

		// Token: 0x0401B77B RID: 112507
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401B77C RID: 112508
		private ButtonItem ConfirmButton;

		// Token: 0x0401B77D RID: 112509
		private RoverlikeRoleSelectTitlePanel TitlePanel;

		// Token: 0x0401B77E RID: 112510
		private RoverlikeRoleSelectUnlockPanel UnlockPanel;

		// Token: 0x0401B77F RID: 112511
		private RoverlikeRoleSelectElementTogglePanel LightTogglePanel;

		// Token: 0x0401B780 RID: 112512
		private RoverlikeRoleSelectElementTogglePanel DarkTogglePanel;

		// Token: 0x0401B781 RID: 112513
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RoverlikeRoleSelectInfoItem, RoverlikeRoleSelectInfoItemData> InfoLayout;

		// Token: 0x0401B782 RID: 112514
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RoverlikeRoleSelectAssistRoleItem, RoverlikeRoleSelectAssistRoleItemData> AssistLayoutL;

		// Token: 0x0401B783 RID: 112515
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RoverlikeRoleSelectAssistRoleItem, RoverlikeRoleSelectAssistRoleItemData> AssistLayoutR;

		// Token: 0x0401B784 RID: 112516
		private int CurRoleTypeId;

		// Token: 0x0401B785 RID: 112517
		[Nullable(1)]
		private List<int> RoleTypeIdList = new List<int>();

		// Token: 0x0401B786 RID: 112518
		private int CurInstId;

		// Token: 0x0401B787 RID: 112519
		[Nullable(1)]
		private readonly HashSet<int> SelectableRoleTypeIdSet = new HashSet<int>();

		// Token: 0x0200ADD0 RID: 44496
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04035B39 RID: 219961
			public const int UiItemCaption = 0;

			// Token: 0x04035B3A RID: 219962
			public const int TogSelectElementLight = 1;

			// Token: 0x04035B3B RID: 219963
			public const int TogSelectElementDark = 2;

			// Token: 0x04035B3C RID: 219964
			public const int PnlRoleMale = 3;

			// Token: 0x04035B3D RID: 219965
			public const int PnlRoleFemale = 4;

			// Token: 0x04035B3E RID: 219966
			public const int PnlEffectLight = 5;

			// Token: 0x04035B3F RID: 219967
			public const int PnlEffectDark = 6;

			// Token: 0x04035B40 RID: 219968
			public const int PnlTitle = 7;

			// Token: 0x04035B41 RID: 219969
			public const int SvInfo = 8;

			// Token: 0x04035B42 RID: 219970
			public const int PnlInfoItem = 9;

			// Token: 0x04035B43 RID: 219971
			public const int PnlRoleLayoutL = 10;

			// Token: 0x04035B44 RID: 219972
			public const int UiItemRoleL = 11;

			// Token: 0x04035B45 RID: 219973
			public const int PnlRoleLayoutR = 12;

			// Token: 0x04035B46 RID: 219974
			public const int UiItemRoleR = 13;

			// Token: 0x04035B47 RID: 219975
			public const int PnlAactivedB = 14;

			// Token: 0x04035B48 RID: 219976
			public const int BtnConfirm = 15;
		}
	}
}
