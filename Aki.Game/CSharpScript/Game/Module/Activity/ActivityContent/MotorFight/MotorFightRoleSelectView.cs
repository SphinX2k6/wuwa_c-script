using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Motorcycle.Model;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorFight
{
	// Token: 0x0200642E RID: 25646
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorFightRoleSelectView : UiViewBase
	{
		// Token: 0x060407BA RID: 264122 RVA: 0x00F9AF2B File Offset: 0x00F9912B
		public MotorFightRoleSelectView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x060407BB RID: 264123 RVA: 0x00F9AF34 File Offset: 0x00F99134
		protected unsafe override void OnRegisterComponent()
		{
			int num = 10;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnConfirmBtnClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060407BC RID: 264124 RVA: 0x00F9B0E4 File Offset: 0x00F992E4
		protected override UniTask OnBeforeStartAsync()
		{
			MotorFightRoleSelectView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MotorFightRoleSelectView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060407BD RID: 264125 RVA: 0x00F9B128 File Offset: 0x00F99328
		protected override void OnBeforeShow()
		{
			MotorFightLevelData levelData = this.ViewModel.LevelData;
			base.SetTextureByPath(MotorFightConfig.Instance.GetMotorFightLevelType((int)levelData.Type).Value.SelectLevelStateBg, base.GetTexture(0), null, null);
			GenericLayout<MotorFightRoleItem, MotorFightRoleData> roleLayout = this.RoleLayout;
			if (roleLayout != null)
			{
				roleLayout.SelectGridProxyByKey(this.RoleData.Id, false);
			}
			this.RefreshView(this.RoleData);
		}

		// Token: 0x060407BE RID: 264126 RVA: 0x00F9B1A8 File Offset: 0x00F993A8
		private void RefreshView(MotorFightRoleData roleData)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), roleData.RoleName, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(8), roleData.BuffName, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(5), roleData.BuffDesc, roleData.BuffDescParams);
			FunctionalPanelConditionLock lockPanel = this.LockPanel;
			if (lockPanel != null)
			{
				lockPanel.SetUiActive(!roleData.IsUnLock);
			}
			if (!roleData.IsUnLock)
			{
				string conditionGroupHintText = LevelGeneralCommons.GetConditionGroupHintText(roleData.ConditionId);
				FunctionalPanelConditionLock lockPanel2 = this.LockPanel;
				if (lockPanel2 != null)
				{
					lockPanel2.SetTextByTextId(conditionGroupHintText, Array.Empty<string>());
				}
			}
			UUIButtonComponent button = base.GetButton(6);
			if (button != null)
			{
				button.RootUIComp.Get().SetUIActive(roleData.IsUnLock);
			}
			bool flag = this.IsSelected(roleData.Id);
			UUIButtonComponent button2 = base.GetButton(6);
			if (button2 != null)
			{
				button2.SetSelfInteractive(!flag);
			}
			string textStringId = flag ? "MotorFightGame_CharacterCondition_04" : "MotorFightGame_CharacterCondition_03";
			LguiUtil.Instance.SetLocalTextNew(base.GetText(9), textStringId, Array.Empty<object>());
		}

		// Token: 0x060407BF RID: 264127 RVA: 0x00F9B2BF File Offset: 0x00F994BF
		private bool IsSelected(int roleId)
		{
			return this.ViewModel.SelectedRoleId == roleId;
		}

		// Token: 0x060407C0 RID: 264128 RVA: 0x00F9B2D0 File Offset: 0x00F994D0
		private void OnToggleClickCallback(MotorFightRoleData data)
		{
			this.RoleData = data;
			this.RefreshView(data);
			base.PlayOrReplaySequence("Switch", false, null);
			GenericLayout<MotorFightRoleItem, MotorFightRoleData> roleLayout = this.RoleLayout;
			if (roleLayout != null)
			{
				roleLayout.SelectGridProxyByKey(data.Id, false);
			}
			RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(data.TrialRoleId, true);
			MotorcycleUiModelUtil.Instance.RefreshRoleInMotor(roleDataById.GetRoleId(), roleDataById.GetRoleSkinId(), data.AnimPath);
		}

		// Token: 0x060407C1 RID: 264129 RVA: 0x00F9B34C File Offset: 0x00F9954C
		private MotorFightRoleItem CreateRoleItem()
		{
			return new MotorFightRoleItem
			{
				RecommendRoleIds = this.ViewModel.LevelData.RecommendRoleIds,
				OnToggleClickCallback = new Action<MotorFightRoleData>(this.OnToggleClickCallback),
				IsSelected = new Func<int, bool>(this.IsSelected)
			};
		}

		// Token: 0x060407C2 RID: 264130 RVA: 0x00F9B398 File Offset: 0x00F99598
		private void OnConfirmBtnClick()
		{
			this.ViewModel.SelectedRoleId = this.RoleData.Id;
			base.CloseMe(null);
		}

		// Token: 0x060407C3 RID: 264131 RVA: 0x00F9B3B7 File Offset: 0x00F995B7
		private void OnCloseBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x060407C4 RID: 264132 RVA: 0x00F9B3C0 File Offset: 0x00F995C0
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (!(configParams[0] == "sword_role"))
			{
				return null;
			}
			int index = int.Parse(configParams[1]);
			GenericLayout<MotorFightRoleItem, MotorFightRoleData> roleLayout = this.RoleLayout;
			MotorFightRoleItem motorFightRoleItem = (roleLayout != null) ? roleLayout.GetLayoutItemByIndex(index) : null;
			UUIItem uuiitem = (motorFightRoleItem != null) ? motorFightRoleItem.GetRootItem() : null;
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

		// Token: 0x0402185B RID: 137307
		private MotorFightLevelDetailViewModel ViewModel;

		// Token: 0x0402185C RID: 137308
		private MotorFightRoleData RoleData;

		// Token: 0x0402185D RID: 137309
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0402185E RID: 137310
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<MotorFightRoleItem, MotorFightRoleData> RoleLayout;

		// Token: 0x0402185F RID: 137311
		[Nullable(2)]
		private FunctionalPanelConditionLock LockPanel;

		// Token: 0x0200C66C RID: 50796
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403BE77 RID: 245367
			public const int TextureBg = 0;

			// Token: 0x0403BE78 RID: 245368
			public const int ItemCaption = 1;

			// Token: 0x0403BE79 RID: 245369
			public const int LayoutRole = 2;

			// Token: 0x0403BE7A RID: 245370
			public const int ItemRole = 3;

			// Token: 0x0403BE7B RID: 245371
			public const int TextRoleName = 4;

			// Token: 0x0403BE7C RID: 245372
			public const int TextBuffDesc = 5;

			// Token: 0x0403BE7D RID: 245373
			public const int BtnConfirm = 6;

			// Token: 0x0403BE7E RID: 245374
			public const int ItemLockPanel = 7;

			// Token: 0x0403BE7F RID: 245375
			public const int TextBuffName = 8;

			// Token: 0x0403BE80 RID: 245376
			public const int TextConfirmBtn = 9;
		}
	}
}
