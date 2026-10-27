using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Dango
{
	// Token: 0x02005ADD RID: 23261
	[NullableContext(2)]
	[Nullable(0)]
	public class DangoAbyssSelectDangoView : UiViewBase
	{
		// Token: 0x0603AE79 RID: 241273 RVA: 0x00E0B557 File Offset: 0x00E09757
		[NullableContext(1)]
		public DangoAbyssSelectDangoView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603AE7A RID: 241274 RVA: 0x00E0B560 File Offset: 0x00E09760
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUILoopScrollViewComponent)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIText)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUIItem)),
				new ValueTuple<int, Type>(9, typeof(UUIItem)),
				new ValueTuple<int, Type>(10, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action(this.OnCloseBtnClick))
			};
		}

		// Token: 0x0603AE7B RID: 241275 RVA: 0x00E0B690 File Offset: 0x00E09890
		protected override UniTask OnBeforeStartAsync()
		{
			DangoAbyssSelectDangoView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoAbyssSelectDangoView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603AE7C RID: 241276 RVA: 0x00E0B6D4 File Offset: 0x00E098D4
		protected override void OnStart()
		{
			DangoSelectViewData dangoSelectViewData = this.OpenParam as DangoSelectViewData;
			this.CurrentRoleConfigId = dangoSelectViewData.RoleConfigId;
			this.CurrentSelectDangoId = dangoSelectViewData.CurrentSelectDangoId;
			if (this.CurrentSelectDangoId > 0)
			{
				DangoAbyssModel.Instance.SetDangoFormationIfNew(this.CurrentSelectDangoId, false);
				EventSystem.Instance.Emit<int>(EEventName.RefreshAbyssDangoRedDot, this.CurrentSelectDangoId);
			}
		}

		// Token: 0x0603AE7D RID: 241277 RVA: 0x00E0B735 File Offset: 0x00E09935
		[NullableContext(1)]
		private AbyssDangoItem InitItem()
		{
			return new AbyssDangoItem();
		}

		// Token: 0x0603AE7E RID: 241278 RVA: 0x00E0B73C File Offset: 0x00E0993C
		private void OnCloseBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x0603AE7F RID: 241279 RVA: 0x00E0B745 File Offset: 0x00E09945
		protected override void OnBeforeShow()
		{
			this.RefreshDangoList();
			this.RefreshInfo();
		}

		// Token: 0x0603AE80 RID: 241280 RVA: 0x00E0B754 File Offset: 0x00E09954
		private void RefreshLevelUpBtn(AbyssDangoRoleData data)
		{
			bool dangoUpAvailable = DangoAbyssModel.Instance.GetDangoUpAvailable();
			ButtonItem levelUpBtnItem = this.LevelUpBtnItem;
			if (levelUpBtnItem == null)
			{
				return;
			}
			levelUpBtnItem.SetActive(data != null && dangoUpAvailable && !GameModeModel.Instance.IsMulti);
		}

		// Token: 0x0603AE81 RID: 241281 RVA: 0x00E0B794 File Offset: 0x00E09994
		private void RefreshConfirmBtn(AbyssDangoRoleData data)
		{
			ButtonItem confirmBtnItem = this.ConfirmBtnItem;
			if (confirmBtnItem == null)
			{
				return;
			}
			confirmBtnItem.SetActive(data != null);
		}

		// Token: 0x0603AE82 RID: 241282 RVA: 0x00E0B7AC File Offset: 0x00E099AC
		private void RefreshRightDownText(AbyssDangoRoleData data)
		{
			if (data == null)
			{
				UUIItem item = base.GetItem(8);
				if (item == null)
				{
					return;
				}
				item.SetUIActive(false);
				return;
			}
			else
			{
				bool ifLock = data.GetIfLock();
				UUIItem item2 = base.GetItem(8);
				if (item2 == null)
				{
					return;
				}
				item2.SetUIActive(ifLock);
				return;
			}
		}

		// Token: 0x0603AE83 RID: 241283 RVA: 0x00E0B7E8 File Offset: 0x00E099E8
		private void RefreshDangoList()
		{
			AbyssDangoRoleData[] allDangoList = DangoAbyssModel.Instance.GetAllDangoList();
			List<AbyssDangoItemData> list = new List<AbyssDangoItemData>();
			foreach (AbyssDangoRoleData abyssDangoRoleData in allDangoList)
			{
				list.Add(new AbyssDangoItemData
				{
					DangoId = abyssDangoRoleData.GetId(),
					PlayerId = PlayerInfoModel.Instance.GetId().Value,
					RoleId = DangoAbyssModel.Instance.GetDangoBelongRoleId(PlayerInfoModel.Instance.GetId().Value, abyssDangoRoleData.GetId()),
					SelectState = (abyssDangoRoleData.GetId() == this.CurrentSelectDangoId),
					OnSelectCallBack = new Action<AbyssDangoItemData>(this.OnSelectDango)
				});
			}
			this.LoopScrollView.RefreshByData(list, false, null, false);
		}

		// Token: 0x0603AE84 RID: 241284 RVA: 0x00E0B8B8 File Offset: 0x00E09AB8
		[NullableContext(1)]
		private void OnSelectDango(AbyssDangoItemData data)
		{
			this.CurrentSelectDangoId = data.DangoId;
			if (this.CurrentSelectDangoId > 0)
			{
				DangoAbyssModel.Instance.SetDangoFormationIfNew(this.CurrentSelectDangoId, false);
				EventSystem.Instance.Emit<int>(EEventName.RefreshAbyssDangoRedDot, this.CurrentSelectDangoId);
			}
			this.RefreshDangoList();
			this.RefreshInfo();
		}

		// Token: 0x0603AE85 RID: 241285 RVA: 0x00E0B910 File Offset: 0x00E09B10
		private void RefreshInfo()
		{
			AbyssDangoRoleData dangoAbyssRoleData = DangoAbyssModel.Instance.GetDangoAbyssRoleData(this.CurrentSelectDangoId);
			this.RefreshRoleInfo(dangoAbyssRoleData);
			this.RefreshBuff(dangoAbyssRoleData);
			this.RefreshSkill(dangoAbyssRoleData);
			this.RefreshPassiveSkill(dangoAbyssRoleData);
			this.RefreshRightDownText(dangoAbyssRoleData);
			this.RefreshLevelUpBtn(dangoAbyssRoleData);
			this.RefreshConfirmBtn(dangoAbyssRoleData);
		}

		// Token: 0x0603AE86 RID: 241286 RVA: 0x00E0B95F File Offset: 0x00E09B5F
		private void RefreshRoleInfo(AbyssDangoRoleData data)
		{
			if (data == null)
			{
				RoleInfoPanel rolePanel = this.RolePanel;
				if (rolePanel == null)
				{
					return;
				}
				rolePanel.SetActive(false);
				return;
			}
			else
			{
				RoleInfoPanel rolePanel2 = this.RolePanel;
				if (rolePanel2 != null)
				{
					rolePanel2.SetActive(true);
				}
				RoleInfoPanel rolePanel3 = this.RolePanel;
				if (rolePanel3 == null)
				{
					return;
				}
				rolePanel3.Refresh(data);
				return;
			}
		}

		// Token: 0x0603AE87 RID: 241287 RVA: 0x00E0B99C File Offset: 0x00E09B9C
		private void RefreshBuff(AbyssDangoRoleData data)
		{
			if (data == null)
			{
				BuffPanel buffPanel = this.BuffPanel;
				if (buffPanel == null)
				{
					return;
				}
				buffPanel.SetActive(false);
				return;
			}
			else
			{
				int id = data.GetId();
				DangoAbyssDefine.DangoAbyssTagData[] dangoTagData = DangoAbyssModel.Instance.GetDangoTagData(id, DangoAbyssDefine.ETagDataGetType.Valid);
				BuffPanel buffPanel2 = this.BuffPanel;
				if (buffPanel2 != null)
				{
					buffPanel2.SetActive(dangoTagData.Length != 0);
				}
				BuffPanel buffPanel3 = this.BuffPanel;
				if (buffPanel3 == null)
				{
					return;
				}
				buffPanel3.Refresh(data);
				return;
			}
		}

		// Token: 0x0603AE88 RID: 241288 RVA: 0x00E0B9F9 File Offset: 0x00E09BF9
		private void RefreshSkill(AbyssDangoRoleData data)
		{
			if (data == null)
			{
				SkillPanel skillPanel = this.SkillPanel;
				if (skillPanel == null)
				{
					return;
				}
				skillPanel.SetActive(false);
				return;
			}
			else
			{
				SkillPanel skillPanel2 = this.SkillPanel;
				if (skillPanel2 != null)
				{
					skillPanel2.SetActive(true);
				}
				SkillPanel skillPanel3 = this.SkillPanel;
				if (skillPanel3 == null)
				{
					return;
				}
				skillPanel3.Refresh(data);
				return;
			}
		}

		// Token: 0x0603AE89 RID: 241289 RVA: 0x00E0BA33 File Offset: 0x00E09C33
		private void RefreshPassiveSkill(AbyssDangoRoleData data)
		{
			if (data == null)
			{
				SkillPanel passiveSkillPanel = this.PassiveSkillPanel;
				if (passiveSkillPanel == null)
				{
					return;
				}
				passiveSkillPanel.SetActive(false);
				return;
			}
			else
			{
				SkillPanel passiveSkillPanel2 = this.PassiveSkillPanel;
				if (passiveSkillPanel2 == null)
				{
					return;
				}
				passiveSkillPanel2.Refresh(data);
				return;
			}
		}

		// Token: 0x0603AE8A RID: 241290 RVA: 0x00E0BA5C File Offset: 0x00E09C5C
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (configParams.Length != 2)
			{
				return null;
			}
			int displayIndex;
			if (!int.TryParse(configParams[1], out displayIndex))
			{
				return null;
			}
			LoopScrollView<AbyssDangoItem, AbyssDangoItemData> loopScrollView = this.LoopScrollView;
			UUIItem uuiitem = (loopScrollView != null) ? loopScrollView.GetGridByDisplayIndex(displayIndex) : null;
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

		// Token: 0x0401EBE6 RID: 125926
		private int CurrentRoleConfigId;

		// Token: 0x0401EBE7 RID: 125927
		private int CurrentSelectDangoId;

		// Token: 0x0401EBE8 RID: 125928
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<AbyssDangoItem, AbyssDangoItemData> LoopScrollView;

		// Token: 0x0401EBE9 RID: 125929
		private RoleInfoPanel RolePanel;

		// Token: 0x0401EBEA RID: 125930
		private BuffPanel BuffPanel;

		// Token: 0x0401EBEB RID: 125931
		private SkillPanel SkillPanel;

		// Token: 0x0401EBEC RID: 125932
		private SkillPanel PassiveSkillPanel;

		// Token: 0x0401EBED RID: 125933
		private ButtonItem LevelUpBtnItem;

		// Token: 0x0401EBEE RID: 125934
		private ButtonItem ConfirmBtnItem;

		// Token: 0x0200BD38 RID: 48440
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x04039112 RID: 233746
			CloseBtn,
			// Token: 0x04039113 RID: 233747
			LoopScrollView,
			// Token: 0x04039114 RID: 233748
			ScrollItem,
			// Token: 0x04039115 RID: 233749
			LeftDownText,
			// Token: 0x04039116 RID: 233750
			RolePanel,
			// Token: 0x04039117 RID: 233751
			BuffPanel,
			// Token: 0x04039118 RID: 233752
			SkillPanel,
			// Token: 0x04039119 RID: 233753
			PassiveSkillPanel,
			// Token: 0x0403911A RID: 233754
			RightDownRedTips,
			// Token: 0x0403911B RID: 233755
			LevelUpBtn,
			// Token: 0x0403911C RID: 233756
			ConfirmBtn
		}
	}
}
