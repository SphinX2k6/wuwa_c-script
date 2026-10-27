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
	// Token: 0x02006180 RID: 24960
	[NullableContext(2)]
	[Nullable(0)]
	public class RoverlikeRoleSelectView : UiViewBase
	{
		// Token: 0x170091BD RID: 37309
		// (get) Token: 0x0603F145 RID: 258373 RVA: 0x00F3E4DD File Offset: 0x00F3C6DD
		private RoverlikeActivityData ActivityData
		{
			get
			{
				return RoverlikeActivityController.Instance.GetCurrentActivityData();
			}
		}

		// Token: 0x0603F146 RID: 258374 RVA: 0x00F3E4E9 File Offset: 0x00F3C6E9
		[NullableContext(1)]
		public RoverlikeRoleSelectView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603F147 RID: 258375 RVA: 0x00F3E508 File Offset: 0x00F3C708
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

		// Token: 0x0603F148 RID: 258376 RVA: 0x00F3E7A8 File Offset: 0x00F3C9A8
		protected override UniTask OnBeforeStartAsync()
		{
			RoverlikeRoleSelectView.<OnBeforeStartAsync>d__20 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoverlikeRoleSelectView.<OnBeforeStartAsync>d__20>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603F149 RID: 258377 RVA: 0x00F3E7EC File Offset: 0x00F3C9EC
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

		// Token: 0x0603F14A RID: 258378 RVA: 0x00F3E93C File Offset: 0x00F3CB3C
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

		// Token: 0x0603F14B RID: 258379 RVA: 0x00F3E988 File Offset: 0x00F3CB88
		private void BuildInfoLayout()
		{
			UUILayoutBase layout = base.GetScrollViewWithScrollbar(8).GetContent().GetComponentByClass(UUILayoutBase.StaticClass()) as UUILayoutBase;
			this.InfoLayout = new GenericLayout<RoverlikeRoleSelectInfoItem, RoverlikeRoleSelectInfoItemData>(layout, () => new RoverlikeRoleSelectInfoItem(), base.GetItem(9).GetOwner() as AUIBaseActor, false, true);
		}

		// Token: 0x0603F14C RID: 258380 RVA: 0x00F3E9F8 File Offset: 0x00F3CBF8
		private void BuildAssistRoleLayouts()
		{
			this.AssistLayoutL = new GenericLayout<RoverlikeRoleSelectAssistRoleItem, RoverlikeRoleSelectAssistRoleItemData>(base.GetGridLayout(10), () => new RoverlikeRoleSelectAssistRoleItem(), base.GetItem(11).GetOwner() as AUIBaseActor, false, true);
			this.AssistLayoutR = new GenericLayout<RoverlikeRoleSelectAssistRoleItem, RoverlikeRoleSelectAssistRoleItemData>(base.GetGridLayout(12), () => new RoverlikeRoleSelectAssistRoleItem(), base.GetItem(13).GetOwner() as AUIBaseActor, false, true);
		}

		// Token: 0x0603F14D RID: 258381 RVA: 0x00F3EA94 File Offset: 0x00F3CC94
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

		// Token: 0x0603F14E RID: 258382 RVA: 0x00F3EAF3 File Offset: 0x00F3CCF3
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

		// Token: 0x0603F14F RID: 258383 RVA: 0x00F3EB1C File Offset: 0x00F3CD1C
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

		// Token: 0x0603F150 RID: 258384 RVA: 0x00F3EBAC File Offset: 0x00F3CDAC
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

		// Token: 0x0603F151 RID: 258385 RVA: 0x00F3EC10 File Offset: 0x00F3CE10
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

		// Token: 0x0603F152 RID: 258386 RVA: 0x00F3EC57 File Offset: 0x00F3CE57
		private void RefreshInfoList(RoverRogueRoleType? cfg)
		{
			GenericLayout<RoverlikeRoleSelectInfoItem, RoverlikeRoleSelectInfoItemData> infoLayout = this.InfoLayout;
			if (infoLayout == null)
			{
				return;
			}
			infoLayout.RefreshByData(this.BuildInfoDataList(cfg), null, false);
		}

		// Token: 0x0603F153 RID: 258387 RVA: 0x00F3EC74 File Offset: 0x00F3CE74
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

		// Token: 0x0603F154 RID: 258388 RVA: 0x00F3ED0C File Offset: 0x00F3CF0C
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

		// Token: 0x0603F155 RID: 258389 RVA: 0x00F3EE28 File Offset: 0x00F3D028
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

		// Token: 0x0603F156 RID: 258390 RVA: 0x00F3EEFB File Offset: 0x00F3D0FB
		private RoverRogueRoleType? GetRoleTypeConfig(int roleTypeId)
		{
			return RoverlikeConfig.Instance.GetRoleTypeConfig(roleTypeId);
		}

		// Token: 0x0603F157 RID: 258391 RVA: 0x00F3EF08 File Offset: 0x00F3D108
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

		// Token: 0x0603F158 RID: 258392 RVA: 0x00F3EF78 File Offset: 0x00F3D178
		private bool IsRoleTypeSelectable(int roleTypeId)
		{
			return this.SelectableRoleTypeIdSet.Contains(roleTypeId);
		}

		// Token: 0x0603F159 RID: 258393 RVA: 0x00F3EF88 File Offset: 0x00F3D188
		private void OnLightToggleStateChange(EToggleState state)
		{
			if (state != EToggleState.ETT_Checked)
			{
				return;
			}
			this.SelectElement(this.GetRoleTypeIdByIndex(0));
			base.PlayOrReplaySequence("Switch", false, null);
		}

		// Token: 0x0603F15A RID: 258394 RVA: 0x00F3EFBC File Offset: 0x00F3D1BC
		private void OnDarkToggleStateChange(EToggleState state)
		{
			if (state != EToggleState.ETT_Checked)
			{
				return;
			}
			this.SelectElement(this.GetRoleTypeIdByIndex(1));
			base.PlayOrReplaySequence("Switch", false, null);
		}

		// Token: 0x0603F15B RID: 258395 RVA: 0x00F3EFF0 File Offset: 0x00F3D1F0
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

		// Token: 0x0603F15C RID: 258396 RVA: 0x00F3F04E File Offset: 0x00F3D24E
		private void OnClickClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x04020E4C RID: 134732
		private const int ROLE_TYPE_INDEX_LIGHT = 0;

		// Token: 0x04020E4D RID: 134733
		private const int ROLE_TYPE_INDEX_DARK = 1;

		// Token: 0x04020E4E RID: 134734
		private PopupCaptionItem CaptionItem;

		// Token: 0x04020E4F RID: 134735
		private ButtonItem ConfirmButton;

		// Token: 0x04020E50 RID: 134736
		private RoverlikeRoleSelectTitlePanel TitlePanel;

		// Token: 0x04020E51 RID: 134737
		private RoverlikeRoleSelectUnlockPanel UnlockPanel;

		// Token: 0x04020E52 RID: 134738
		private RoverlikeRoleSelectElementTogglePanel LightTogglePanel;

		// Token: 0x04020E53 RID: 134739
		private RoverlikeRoleSelectElementTogglePanel DarkTogglePanel;

		// Token: 0x04020E54 RID: 134740
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RoverlikeRoleSelectInfoItem, RoverlikeRoleSelectInfoItemData> InfoLayout;

		// Token: 0x04020E55 RID: 134741
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RoverlikeRoleSelectAssistRoleItem, RoverlikeRoleSelectAssistRoleItemData> AssistLayoutL;

		// Token: 0x04020E56 RID: 134742
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RoverlikeRoleSelectAssistRoleItem, RoverlikeRoleSelectAssistRoleItemData> AssistLayoutR;

		// Token: 0x04020E57 RID: 134743
		private int CurRoleTypeId;

		// Token: 0x04020E58 RID: 134744
		[Nullable(1)]
		private List<int> RoleTypeIdList = new List<int>();

		// Token: 0x04020E59 RID: 134745
		private int CurInstId;

		// Token: 0x04020E5A RID: 134746
		[Nullable(1)]
		private readonly HashSet<int> SelectableRoleTypeIdSet = new HashSet<int>();

		// Token: 0x0200C3E9 RID: 50153
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403B1D8 RID: 242136
			public const int UiItemCaption = 0;

			// Token: 0x0403B1D9 RID: 242137
			public const int TogSelectElementLight = 1;

			// Token: 0x0403B1DA RID: 242138
			public const int TogSelectElementDark = 2;

			// Token: 0x0403B1DB RID: 242139
			public const int PnlRoleMale = 3;

			// Token: 0x0403B1DC RID: 242140
			public const int PnlRoleFemale = 4;

			// Token: 0x0403B1DD RID: 242141
			public const int PnlEffectLight = 5;

			// Token: 0x0403B1DE RID: 242142
			public const int PnlEffectDark = 6;

			// Token: 0x0403B1DF RID: 242143
			public const int PnlTitle = 7;

			// Token: 0x0403B1E0 RID: 242144
			public const int SvInfo = 8;

			// Token: 0x0403B1E1 RID: 242145
			public const int PnlInfoItem = 9;

			// Token: 0x0403B1E2 RID: 242146
			public const int PnlRoleLayoutL = 10;

			// Token: 0x0403B1E3 RID: 242147
			public const int UiItemRoleL = 11;

			// Token: 0x0403B1E4 RID: 242148
			public const int PnlRoleLayoutR = 12;

			// Token: 0x0403B1E5 RID: 242149
			public const int UiItemRoleR = 13;

			// Token: 0x0403B1E6 RID: 242150
			public const int PnlAactivedB = 14;

			// Token: 0x0403B1E7 RID: 242151
			public const int BtnConfirm = 15;
		}
	}
}
