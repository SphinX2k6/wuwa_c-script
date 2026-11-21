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
	// Token: 0x02004ABE RID: 19134
	[NullableContext(2)]
	[Nullable(0)]
	public class DangoAbyssSelectDangoView : UiViewBase
	{
		// Token: 0x0602FDEB RID: 196075 RVA: 0x00D5C23F File Offset: 0x00D5A43F
		[NullableContext(1)]
		public DangoAbyssSelectDangoView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602FDEC RID: 196076 RVA: 0x00D5C248 File Offset: 0x00D5A448
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

		// Token: 0x0602FDED RID: 196077 RVA: 0x00D5C378 File Offset: 0x00D5A578
		protected override UniTask OnBeforeStartAsync()
		{
			DangoAbyssSelectDangoView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoAbyssSelectDangoView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602FDEE RID: 196078 RVA: 0x00D5C3BC File Offset: 0x00D5A5BC
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

		// Token: 0x0602FDEF RID: 196079 RVA: 0x00D5C41D File Offset: 0x00D5A61D
		[NullableContext(1)]
		private AbyssDangoItem InitItem()
		{
			return new AbyssDangoItem();
		}

		// Token: 0x0602FDF0 RID: 196080 RVA: 0x00D5C424 File Offset: 0x00D5A624
		private void OnCloseBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x0602FDF1 RID: 196081 RVA: 0x00D5C42D File Offset: 0x00D5A62D
		protected override void OnBeforeShow()
		{
			this.RefreshDangoList();
			this.RefreshInfo();
		}

		// Token: 0x0602FDF2 RID: 196082 RVA: 0x00D5C43C File Offset: 0x00D5A63C
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

		// Token: 0x0602FDF3 RID: 196083 RVA: 0x00D5C47C File Offset: 0x00D5A67C
		private void RefreshConfirmBtn(AbyssDangoRoleData data)
		{
			ButtonItem confirmBtnItem = this.ConfirmBtnItem;
			if (confirmBtnItem == null)
			{
				return;
			}
			confirmBtnItem.SetActive(data != null);
		}

		// Token: 0x0602FDF4 RID: 196084 RVA: 0x00D5C494 File Offset: 0x00D5A694
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

		// Token: 0x0602FDF5 RID: 196085 RVA: 0x00D5C4D0 File Offset: 0x00D5A6D0
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

		// Token: 0x0602FDF6 RID: 196086 RVA: 0x00D5C5A0 File Offset: 0x00D5A7A0
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

		// Token: 0x0602FDF7 RID: 196087 RVA: 0x00D5C5F8 File Offset: 0x00D5A7F8
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

		// Token: 0x0602FDF8 RID: 196088 RVA: 0x00D5C647 File Offset: 0x00D5A847
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

		// Token: 0x0602FDF9 RID: 196089 RVA: 0x00D5C684 File Offset: 0x00D5A884
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

		// Token: 0x0602FDFA RID: 196090 RVA: 0x00D5C6E1 File Offset: 0x00D5A8E1
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

		// Token: 0x0602FDFB RID: 196091 RVA: 0x00D5C71B File Offset: 0x00D5A91B
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

		// Token: 0x0602FDFC RID: 196092 RVA: 0x00D5C744 File Offset: 0x00D5A944
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

		// Token: 0x040196A2 RID: 104098
		private int CurrentRoleConfigId;

		// Token: 0x040196A3 RID: 104099
		private int CurrentSelectDangoId;

		// Token: 0x040196A4 RID: 104100
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<AbyssDangoItem, AbyssDangoItemData> LoopScrollView;

		// Token: 0x040196A5 RID: 104101
		private RoleInfoPanel RolePanel;

		// Token: 0x040196A6 RID: 104102
		private BuffPanel BuffPanel;

		// Token: 0x040196A7 RID: 104103
		private SkillPanel SkillPanel;

		// Token: 0x040196A8 RID: 104104
		private SkillPanel PassiveSkillPanel;

		// Token: 0x040196A9 RID: 104105
		private ButtonItem LevelUpBtnItem;

		// Token: 0x040196AA RID: 104106
		private ButtonItem ConfirmBtnItem;

		// Token: 0x0200A740 RID: 42816
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x04033ADC RID: 211676
			CloseBtn,
			// Token: 0x04033ADD RID: 211677
			LoopScrollView,
			// Token: 0x04033ADE RID: 211678
			ScrollItem,
			// Token: 0x04033ADF RID: 211679
			LeftDownText,
			// Token: 0x04033AE0 RID: 211680
			RolePanel,
			// Token: 0x04033AE1 RID: 211681
			BuffPanel,
			// Token: 0x04033AE2 RID: 211682
			SkillPanel,
			// Token: 0x04033AE3 RID: 211683
			PassiveSkillPanel,
			// Token: 0x04033AE4 RID: 211684
			RightDownRedTips,
			// Token: 0x04033AE5 RID: 211685
			LevelUpBtn,
			// Token: 0x04033AE6 RID: 211686
			ConfirmBtn
		}
	}
}
