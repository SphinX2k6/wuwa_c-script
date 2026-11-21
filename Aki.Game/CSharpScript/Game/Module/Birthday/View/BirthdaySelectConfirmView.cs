using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Skin;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Birthday.View
{
	// Token: 0x02004C10 RID: 19472
	public class BirthdaySelectConfirmView : UiViewBase, IUiViewResource
	{
		// Token: 0x0603091E RID: 198942 RVA: 0x00D89985 File Offset: 0x00D87B85
		[NullableContext(1)]
		public BirthdaySelectConfirmView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603091F RID: 198943 RVA: 0x00D89990 File Offset: 0x00D87B90
		[NullableContext(1)]
		public string GetExtraResourceId([Nullable(2)] object param = null)
		{
			BirthdayInfo birthdayInfo = param as BirthdayInfo;
			if (birthdayInfo == null)
			{
				return "";
			}
			return BirthdayModel.Instance.GetSelectConfirmViewResource(birthdayInfo.Year);
		}

		// Token: 0x06030920 RID: 198944 RVA: 0x00D899C0 File Offset: 0x00D87BC0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnReturnBtnClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClickGotoButton));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06030921 RID: 198945 RVA: 0x00D89AEC File Offset: 0x00D87CEC
		protected override void OnBeforeShow()
		{
			this.BirthdayInfo = (this.OpenParam as BirthdayInfo);
			int value = this.BirthdayInfo.RoleId.Value;
			RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(value, true);
			int? num = (roleDataById != null) ? new int?(roleDataById.GetRoleSkinId()) : null;
			if (num == null)
			{
				num = new int?(ConfigRoleInfoById.GetConfig(value, true).Value.SkinId);
			}
			RoleSkin? roleSkin;
			string text = (SkinConfig.Instance.GetRoleSkinConfig(num.Value) != null) ? roleSkin.GetValueOrDefault().FormationRoleCard : null;
			if (text != null)
			{
				base.SetTextureByPath(text, base.GetTexture(0), null, null);
			}
			DateTime birthdayDate = BirthdayModel.Instance.GetBirthdayDate(this.BirthdayInfo.Year);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), "BirthdayConfirmText", new <>z__ReadOnlyArray<object>(new object[]
			{
				this.BirthdayInfo.Year,
				birthdayDate.Month,
				birthdayDate.Day
			}));
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew(ConfigRoleInfoById.GetConfig(value, true).Value.Name, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), "BirthdaySelected_GO", new <>z__ReadOnlySingleElementList<object>(localTextNew));
		}

		// Token: 0x06030922 RID: 198946 RVA: 0x00D89C60 File Offset: 0x00D87E60
		private void RecordBirthdaySelectRole()
		{
			int value = this.BirthdayInfo.RoleId.Value;
			BirthdaySelectRoleEvent birthdaySelectRoleEvent = new BirthdaySelectRoleEvent();
			birthdaySelectRoleEvent.i_role_id = value;
			bool b_if_selected_role = BirthdayModel.Instance.IsRoleSelected(value);
			birthdaySelectRoleEvent.b_if_selected_role = b_if_selected_role;
			int birthdayCount = BirthdayModel.Instance.GetBirthdayCount();
			birthdaySelectRoleEvent.i_birthday_count = birthdayCount + 1;
			birthdaySelectRoleEvent.i_trigger_type = 1;
			birthdaySelectRoleEvent.bird_round_id = ConfigBirthDayByYear.GetConfig(this.BirthdayInfo.Year, true).Value.Id;
			LogReportController.Instance.LogReport(birthdaySelectRoleEvent);
		}

		// Token: 0x06030923 RID: 198947 RVA: 0x00D89CED File Offset: 0x00D87EED
		private void OnReturnBtnClick()
		{
			if (!this.IsClickBtn)
			{
				base.CloseMe(null);
				this.IsClickBtn = true;
			}
		}

		// Token: 0x06030924 RID: 198948 RVA: 0x00D89D08 File Offset: 0x00D87F08
		private void OnClickGotoButton()
		{
			if (!this.IsClickBtn)
			{
				this.RecordBirthdaySelectRole();
				UiManager.Instance.CloseAndOpenView(this.ViewInfo.Name, EUiViewName.BirthdayLetterView, this.BirthdayInfo, delegate(bool _)
				{
					UiManager.Instance.CloseView(EUiViewName.BirthdayRoleSelectView, null);
				}, true);
				this.IsClickBtn = true;
			}
		}

		// Token: 0x04019B43 RID: 105283
		[Nullable(2)]
		private BirthdayInfo BirthdayInfo;

		// Token: 0x04019B44 RID: 105284
		private bool IsClickBtn;

		// Token: 0x0200A828 RID: 43048
		private class EComponents
		{
			// Token: 0x04033F17 RID: 212759
			public const int TextureRole = 0;

			// Token: 0x04033F18 RID: 212760
			public const int ButtonReturn = 1;

			// Token: 0x04033F19 RID: 212761
			public const int ButtonGoto = 2;

			// Token: 0x04033F1A RID: 212762
			public const int TextConfirm = 3;

			// Token: 0x04033F1B RID: 212763
			public const int TextGo = 4;
		}
	}
}
