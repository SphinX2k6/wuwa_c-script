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
	// Token: 0x020053AC RID: 21420
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorFightRoleSelectView : UiViewBase
	{
		// Token: 0x0603547B RID: 218235 RVA: 0x00EE1ECB File Offset: 0x00EE00CB
		public MotorFightRoleSelectView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603547C RID: 218236 RVA: 0x00EE1ED4 File Offset: 0x00EE00D4
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

		// Token: 0x0603547D RID: 218237 RVA: 0x00EE2084 File Offset: 0x00EE0284
		protected override UniTask OnBeforeStartAsync()
		{
			MotorFightRoleSelectView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MotorFightRoleSelectView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603547E RID: 218238 RVA: 0x00EE20C8 File Offset: 0x00EE02C8
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

		// Token: 0x0603547F RID: 218239 RVA: 0x00EE2148 File Offset: 0x00EE0348
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

		// Token: 0x06035480 RID: 218240 RVA: 0x00EE225F File Offset: 0x00EE045F
		private bool IsSelected(int roleId)
		{
			return this.ViewModel.SelectedRoleId == roleId;
		}

		// Token: 0x06035481 RID: 218241 RVA: 0x00EE2270 File Offset: 0x00EE0470
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

		// Token: 0x06035482 RID: 218242 RVA: 0x00EE22EC File Offset: 0x00EE04EC
		private MotorFightRoleItem CreateRoleItem()
		{
			return new MotorFightRoleItem
			{
				RecommendRoleIds = this.ViewModel.LevelData.RecommendRoleIds,
				OnToggleClickCallback = new Action<MotorFightRoleData>(this.OnToggleClickCallback),
				IsSelected = new Func<int, bool>(this.IsSelected)
			};
		}

		// Token: 0x06035483 RID: 218243 RVA: 0x00EE2338 File Offset: 0x00EE0538
		private void OnConfirmBtnClick()
		{
			this.ViewModel.SelectedRoleId = this.RoleData.Id;
			base.CloseMe(null);
		}

		// Token: 0x06035484 RID: 218244 RVA: 0x00EE2357 File Offset: 0x00EE0557
		private void OnCloseBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x06035485 RID: 218245 RVA: 0x00EE2360 File Offset: 0x00EE0560
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

		// Token: 0x0401C18A RID: 115082
		private MotorFightLevelDetailViewModel ViewModel;

		// Token: 0x0401C18B RID: 115083
		private MotorFightRoleData RoleData;

		// Token: 0x0401C18C RID: 115084
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401C18D RID: 115085
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<MotorFightRoleItem, MotorFightRoleData> RoleLayout;

		// Token: 0x0401C18E RID: 115086
		[Nullable(2)]
		private FunctionalPanelConditionLock LockPanel;

		// Token: 0x0200B053 RID: 45139
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x040367D4 RID: 223188
			public const int TextureBg = 0;

			// Token: 0x040367D5 RID: 223189
			public const int ItemCaption = 1;

			// Token: 0x040367D6 RID: 223190
			public const int LayoutRole = 2;

			// Token: 0x040367D7 RID: 223191
			public const int ItemRole = 3;

			// Token: 0x040367D8 RID: 223192
			public const int TextRoleName = 4;

			// Token: 0x040367D9 RID: 223193
			public const int TextBuffDesc = 5;

			// Token: 0x040367DA RID: 223194
			public const int BtnConfirm = 6;

			// Token: 0x040367DB RID: 223195
			public const int ItemLockPanel = 7;

			// Token: 0x040367DC RID: 223196
			public const int TextBuffName = 8;

			// Token: 0x040367DD RID: 223197
			public const int TextConfirmBtn = 9;
		}
	}
}
