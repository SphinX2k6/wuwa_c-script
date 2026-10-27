using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Birthday.View
{
	// Token: 0x02005C2F RID: 23599
	public class BirthdayRoleSelectView : UiViewBase, IUiViewResource
	{
		// Token: 0x0603B9C9 RID: 244169 RVA: 0x00E3928C File Offset: 0x00E3748C
		[NullableContext(1)]
		public BirthdayRoleSelectView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603B9CA RID: 244170 RVA: 0x00E39298 File Offset: 0x00E37498
		[NullableContext(1)]
		public string GetExtraResourceId([Nullable(2)] object param = null)
		{
			BirthdayInfo birthdayInfo = param as BirthdayInfo;
			if (birthdayInfo == null)
			{
				return "";
			}
			return BirthdayModel.Instance.GetRoleSelectViewResource(birthdayInfo.Year);
		}

		// Token: 0x0603B9CB RID: 244171 RVA: 0x00E392C8 File Offset: 0x00E374C8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUILoopScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickGotoButton));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnClickCloseButton));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603B9CC RID: 244172 RVA: 0x00E39438 File Offset: 0x00E37638
		protected override UniTask OnBeforeStartAsync()
		{
			BirthdayRoleSelectView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<BirthdayRoleSelectView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603B9CD RID: 244173 RVA: 0x00E3947B File Offset: 0x00E3767B
		protected override void OnStart()
		{
			if (this.TriggerType == BirthdayDefine.ETriggerType.ReSelect)
			{
				this.UiViewSequence.StartSequenceName = "ShowView";
			}
		}

		// Token: 0x0603B9CE RID: 244174 RVA: 0x00E39498 File Offset: 0x00E37698
		private void SetButtonText()
		{
			string item = "";
			if (this.SelectedRoleId != null)
			{
				item = ConfigMultiTextLang.GetLocalTextNew(ConfigRoleInfoById.GetConfig(this.SelectedRoleId.Value, true).Value.Name, null);
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), "BirthdaySelected_Invite", new <>z__ReadOnlySingleElementList<object>(item));
		}

		// Token: 0x0603B9CF RID: 244175 RVA: 0x00E394FC File Offset: 0x00E376FC
		[NullableContext(1)]
		private BirthdayRoleHeadItem CreateItem()
		{
			return new BirthdayRoleHeadItem
			{
				OnToggleClickCallBack = new Action<int, int>(this.OnToggleClickCallBack)
			};
		}

		// Token: 0x0603B9D0 RID: 244176 RVA: 0x00E39518 File Offset: 0x00E37718
		private void OnToggleClickCallBack(int index, int roleId)
		{
			int? selectedRoleId = this.SelectedRoleId;
			if (selectedRoleId.GetValueOrDefault() == roleId & selectedRoleId != null)
			{
				this.SelectedRoleId = null;
				this.SetButtonText();
				this.RoleHeadScrollView.DeselectCurrentGridProxy(false);
				return;
			}
			this.SelectedRoleId = new int?(roleId);
			this.SetButtonText();
			this.RoleHeadScrollView.SelectGridProxy(index, false);
		}

		// Token: 0x0603B9D1 RID: 244177 RVA: 0x00E39580 File Offset: 0x00E37780
		private void OnClickGotoButton()
		{
			if (this.SelectedRoleId == null)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("BirthdayUnSelectedRole", Array.Empty<object>());
				return;
			}
			if (this.TriggerType == BirthdayDefine.ETriggerType.ReSelect)
			{
				EventSystem.Instance.Emit<int>(EEventName.OnBirthRoleChange, this.SelectedRoleId.Value);
				base.CloseMe(null);
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.BirthdaySelectConfirmView, new BirthdayInfo(this.TriggerType, this.Year, new int?(this.SelectedRoleId.Value)), null);
		}

		// Token: 0x0603B9D2 RID: 244178 RVA: 0x00E3960C File Offset: 0x00E3780C
		private void OnClickCloseButton()
		{
			base.CloseMe(null);
		}

		// Token: 0x0401F08E RID: 127118
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private LoopScrollView<BirthdayRoleHeadItem, int> RoleHeadScrollView;

		// Token: 0x0401F08F RID: 127119
		private int? SelectedRoleId;

		// Token: 0x0401F090 RID: 127120
		private int Year;

		// Token: 0x0401F091 RID: 127121
		private BirthdayDefine.ETriggerType TriggerType;

		// Token: 0x0200BE1E RID: 48670
		private class EComponents
		{
			// Token: 0x04039548 RID: 234824
			public const int TextTip = 0;

			// Token: 0x04039549 RID: 234825
			public const int LoopScrollViewRoleHead = 1;

			// Token: 0x0403954A RID: 234826
			public const int ItemRoleHead = 2;

			// Token: 0x0403954B RID: 234827
			public const int ButtonGoto = 3;

			// Token: 0x0403954C RID: 234828
			public const int TextInvite = 4;

			// Token: 0x0403954D RID: 234829
			public const int TxtTitle = 5;

			// Token: 0x0403954E RID: 234830
			public const int BtnClose = 6;
		}
	}
}
