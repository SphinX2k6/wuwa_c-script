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
	// Token: 0x02004C0F RID: 19471
	public class BirthdayRoleSelectView : UiViewBase, IUiViewResource
	{
		// Token: 0x06030914 RID: 198932 RVA: 0x00D895FC File Offset: 0x00D877FC
		[NullableContext(1)]
		public BirthdayRoleSelectView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06030915 RID: 198933 RVA: 0x00D89608 File Offset: 0x00D87808
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

		// Token: 0x06030916 RID: 198934 RVA: 0x00D89638 File Offset: 0x00D87838
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

		// Token: 0x06030917 RID: 198935 RVA: 0x00D897A8 File Offset: 0x00D879A8
		protected override UniTask OnBeforeStartAsync()
		{
			BirthdayRoleSelectView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<BirthdayRoleSelectView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06030918 RID: 198936 RVA: 0x00D897EB File Offset: 0x00D879EB
		protected override void OnStart()
		{
			if (this.TriggerType == BirthdayDefine.ETriggerType.ReSelect)
			{
				this.UiViewSequence.StartSequenceName = "ShowView";
			}
		}

		// Token: 0x06030919 RID: 198937 RVA: 0x00D89808 File Offset: 0x00D87A08
		private void SetButtonText()
		{
			string item = "";
			if (this.SelectedRoleId != null)
			{
				item = ConfigMultiTextLang.GetLocalTextNew(ConfigRoleInfoById.GetConfig(this.SelectedRoleId.Value, true).Value.Name, null);
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), "BirthdaySelected_Invite", new <>z__ReadOnlySingleElementList<object>(item));
		}

		// Token: 0x0603091A RID: 198938 RVA: 0x00D8986C File Offset: 0x00D87A6C
		[NullableContext(1)]
		private BirthdayRoleHeadItem CreateItem()
		{
			return new BirthdayRoleHeadItem
			{
				OnToggleClickCallBack = new Action<int, int>(this.OnToggleClickCallBack)
			};
		}

		// Token: 0x0603091B RID: 198939 RVA: 0x00D89888 File Offset: 0x00D87A88
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

		// Token: 0x0603091C RID: 198940 RVA: 0x00D898F0 File Offset: 0x00D87AF0
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

		// Token: 0x0603091D RID: 198941 RVA: 0x00D8997C File Offset: 0x00D87B7C
		private void OnClickCloseButton()
		{
			base.CloseMe(null);
		}

		// Token: 0x04019B3F RID: 105279
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private LoopScrollView<BirthdayRoleHeadItem, int> RoleHeadScrollView;

		// Token: 0x04019B40 RID: 105280
		private int? SelectedRoleId;

		// Token: 0x04019B41 RID: 105281
		private int Year;

		// Token: 0x04019B42 RID: 105282
		private BirthdayDefine.ETriggerType TriggerType;

		// Token: 0x0200A826 RID: 43046
		private class EComponents
		{
			// Token: 0x04033F0B RID: 212747
			public const int TextTip = 0;

			// Token: 0x04033F0C RID: 212748
			public const int LoopScrollViewRoleHead = 1;

			// Token: 0x04033F0D RID: 212749
			public const int ItemRoleHead = 2;

			// Token: 0x04033F0E RID: 212750
			public const int ButtonGoto = 3;

			// Token: 0x04033F0F RID: 212751
			public const int TextInvite = 4;

			// Token: 0x04033F10 RID: 212752
			public const int TxtTitle = 5;

			// Token: 0x04033F11 RID: 212753
			public const int BtnClose = 6;
		}
	}
}
