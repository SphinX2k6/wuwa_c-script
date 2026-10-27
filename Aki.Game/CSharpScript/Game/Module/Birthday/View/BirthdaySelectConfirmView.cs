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
	// Token: 0x02005C30 RID: 23600
	public class BirthdaySelectConfirmView : UiViewBase, IUiViewResource
	{
		// Token: 0x0603B9D3 RID: 244179 RVA: 0x00E39615 File Offset: 0x00E37815
		[NullableContext(1)]
		public BirthdaySelectConfirmView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603B9D4 RID: 244180 RVA: 0x00E39620 File Offset: 0x00E37820
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

		// Token: 0x0603B9D5 RID: 244181 RVA: 0x00E39650 File Offset: 0x00E37850
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

		// Token: 0x0603B9D6 RID: 244182 RVA: 0x00E3977C File Offset: 0x00E3797C
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

		// Token: 0x0603B9D7 RID: 244183 RVA: 0x00E398F0 File Offset: 0x00E37AF0
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

		// Token: 0x0603B9D8 RID: 244184 RVA: 0x00E3997D File Offset: 0x00E37B7D
		private void OnReturnBtnClick()
		{
			if (!this.IsClickBtn)
			{
				base.CloseMe(null);
				this.IsClickBtn = true;
			}
		}

		// Token: 0x0603B9D9 RID: 244185 RVA: 0x00E39998 File Offset: 0x00E37B98
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

		// Token: 0x0401F092 RID: 127122
		[Nullable(2)]
		private BirthdayInfo BirthdayInfo;

		// Token: 0x0401F093 RID: 127123
		private bool IsClickBtn;

		// Token: 0x0200BE20 RID: 48672
		private class EComponents
		{
			// Token: 0x04039554 RID: 234836
			public const int TextureRole = 0;

			// Token: 0x04039555 RID: 234837
			public const int ButtonReturn = 1;

			// Token: 0x04039556 RID: 234838
			public const int ButtonGoto = 2;

			// Token: 0x04039557 RID: 234839
			public const int TextConfirm = 3;

			// Token: 0x04039558 RID: 234840
			public const int TextGo = 4;
		}
	}
}
