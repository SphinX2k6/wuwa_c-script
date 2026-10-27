using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.AutoAttach;
using CSharpScript.Game.Module.Personal;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020023C7 RID: 9159
[NullableContext(1)]
[Nullable(0)]
public class PersonalBirthView : UiTickViewBase
{
	// Token: 0x060124F4 RID: 74996 RVA: 0x00482607 File Offset: 0x00480807
	public PersonalBirthView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060124F5 RID: 74997 RVA: 0x00482640 File Offset: 0x00480840
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(6, typeof(UUIText)),
			new ValueTuple<int, Type>(7, typeof(UUIText)),
			new ValueTuple<int, Type>(8, typeof(UUIText)),
			new ValueTuple<int, Type>(9, typeof(UUIText)),
			new ValueTuple<int, Type>(10, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(11, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(12, typeof(UUIText)),
			new ValueTuple<int, Type>(13, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(14, typeof(UUIInteractionGroup))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(4, new Action(this.OnLeftButtonClicked)),
			new ValueTuple<int, Delegate>(5, new Action(this.OnRightButtonClicked))
		};
	}

	// Token: 0x060124F6 RID: 74998 RVA: 0x004827E3 File Offset: 0x004809E3
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnBirthChange, new Action(this.OnBirthChange));
	}

	// Token: 0x060124F7 RID: 74999 RVA: 0x00482801 File Offset: 0x00480A01
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnBirthChange, new Action(this.OnBirthChange));
	}

	// Token: 0x060124F8 RID: 75000 RVA: 0x00482820 File Offset: 0x00480A20
	private void OnBirthChange()
	{
		string textById = TextConfig.Instance.GetTextById("SetBirthSuccess");
		ScrollingTipsController.Instance.ShowTipsByText(textById);
		base.CloseMe(null);
	}

	// Token: 0x060124F9 RID: 75001 RVA: 0x0048284F File Offset: 0x00480A4F
	protected void OnLeftButtonClicked()
	{
		base.CloseMe(null);
	}

	// Token: 0x060124FA RID: 75002 RVA: 0x00482858 File Offset: 0x00480A58
	protected void OnRightButtonClicked()
	{
		if (this.IsSetBirth())
		{
			base.CloseMe(null);
			return;
		}
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.SetBirthDay);
		confirmBoxDataNew.FunctionMap.Add(2, delegate
		{
			double timeStampSecond = TimeUtil.Instance.GetServerTimeStamp() / (double)TimeUtil.Instance.InverseMillisecond;
			DateTime dataFromTimeStamp = TimeUtil.Instance.GetDataFromTimeStamp(timeStampSecond);
			PersonalController.Instance.SendBirthdayInitRequest(dataFromTimeStamp.Year * 10000 + this.MonthNumber.Value * 100 + this.DayNumber.Value);
		});
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x060124FB RID: 75003 RVA: 0x004828A1 File Offset: 0x00480AA1
	protected void OnMonthButtonClick()
	{
		if (this.IsSetBirth())
		{
			return;
		}
		this.RefreshLeftCircleExhibitionView();
		this.IsSelectMonthToggle = true;
	}

	// Token: 0x060124FC RID: 75004 RVA: 0x004828B9 File Offset: 0x00480AB9
	protected void OnDayButtonClick()
	{
		if (this.IsSetBirth())
		{
			return;
		}
		if (!this.IsSelectMonthToggle)
		{
			return;
		}
		this.RefreshRightCircleExhibitionView();
		this.IsSelectDayToggle = true;
	}

	// Token: 0x060124FD RID: 75005 RVA: 0x004828DC File Offset: 0x00480ADC
	protected bool IsSetBirth()
	{
		int birthday = PersonalModel.Instance.GetBirthday();
		return BirthdayModel.Instance.GetBirthdayIsReset() && birthday != 0;
	}

	// Token: 0x060124FE RID: 75006 RVA: 0x00482906 File Offset: 0x00480B06
	protected void CloseClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x060124FF RID: 75007 RVA: 0x00482910 File Offset: 0x00480B10
	protected override void OnStart()
	{
		LguiUtil.Instance.SetLocalText(base.GetText(8), "AcquireCancel", Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(9), "PrefabTextItem_1541715829_Text", Array.Empty<object>());
		UUIText text = base.GetText(6);
		text.SetUIActive(true);
		UUIText text2 = base.GetText(7);
		text2.SetUIActive(true);
		if (this.IsSetBirth())
		{
			int birthday = PersonalModel.Instance.GetBirthday();
			int date = birthday / 100;
			int date2 = birthday % 100;
			text.SetText(PersonalConfig.Instance.GetBirthLocalText(date, EBirthDateType.MONTH), true);
			text2.SetText(PersonalConfig.Instance.GetBirthLocalText(date2, EBirthDateType.DAY), true);
			base.GetButton(5).SetSelfInteractive(true);
			base.GetInteractionGroup(14).SetInteractable(true);
			LguiUtil.Instance.SetLocalText(base.GetText(12), "BirthIsSetCanNotChange", Array.Empty<object>());
		}
		else
		{
			this.MonthNumber = new int?(1);
			this.DayNumber = new int?(1);
			text.SetText(this.MonthNumber.ToString(), true);
			text2.SetText(this.DayNumber.ToString(), true);
			base.GetButton(5).SetSelfInteractive(false);
			base.GetInteractionGroup(14).SetInteractable(false);
			LguiUtil.Instance.SetLocalText(base.GetText(12), "SetBirthCanNotChange", Array.Empty<object>());
			this.OnMonthButtonClick();
			this.OnDayButtonClick();
		}
		EToggleState state = PersonalModel.Instance.GetBirthdayDisplay() ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		UUIExtendToggle extendToggle = base.GetExtendToggle(13);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleState(state, false, false, false);
	}

	// Token: 0x06012500 RID: 75008 RVA: 0x00482AA4 File Offset: 0x00480CA4
	private void RefreshLeftCircleExhibitionView()
	{
		UUIItem item = base.GetItem(0);
		UUIItem item2 = base.GetItem(1);
		this.LeftCircleExhibitionView = new CircleAttachView<int, PersonalBirthAttachItem>(item.GetOwner(), true);
		this.LeftCircleExhibitionView.CreateItems(item2.GetOwner(), 2f, new Func<AActor, int, int, PersonalBirthAttachItem>(this.OnCreateLeftCircleItem), EAttachDirection.Vertical);
		List<int> list = new List<int>();
		for (int i = 1; i <= 12; i++)
		{
			list.Add(i);
		}
		this.LeftCircleExhibitionView.ReloadView(list.Count, list.ToArray(), 0);
		item2.SetUIActive(false);
	}

	// Token: 0x06012501 RID: 75009 RVA: 0x00482B2F File Offset: 0x00480D2F
	private PersonalBirthAttachItem OnCreateLeftCircleItem(AActor actor, int index, int showNum)
	{
		PersonalBirthAttachItem personalBirthAttachItem = new PersonalBirthAttachItem(actor);
		personalBirthAttachItem.SetDateType(EBirthDateType.MONTH);
		personalBirthAttachItem.BindOnSelected(new Action<int>(this.OnSelectedLeftNum));
		return personalBirthAttachItem;
	}

	// Token: 0x06012502 RID: 75010 RVA: 0x00482B50 File Offset: 0x00480D50
	private void OnSelectedLeftNum(int num)
	{
		this.MonthNumber = new int?(num);
		base.GetText(6).SetText(num.ToString(), true);
		if (this.IsSelectDayToggle)
		{
			if (this.DayNumber != null)
			{
				base.GetButton(5).SetSelfInteractive(true);
				base.GetInteractionGroup(14).SetInteractable(true);
				this.DayNumber = new int?(1);
				base.GetText(7).SetText(this.DayNumber.ToString(), true);
			}
			this.RefreshRightCircleExhibitionView();
		}
	}

	// Token: 0x06012503 RID: 75011 RVA: 0x00482BE0 File Offset: 0x00480DE0
	private void RefreshRightCircleExhibitionView()
	{
		UUIItem item = base.GetItem(2);
		UUIItem item2 = base.GetItem(3);
		if (this.RightCircleExhibitionView == null)
		{
			this.RightCircleExhibitionView = new CircleAttachView<int, PersonalBirthAttachItem>(item.GetOwner(), true);
			this.RightCircleExhibitionView.CreateItems(item2.GetOwner(), 2f, new Func<AActor, int, int, PersonalBirthAttachItem>(this.OnCreateRightCircleItem), EAttachDirection.Vertical);
		}
		int days = this.GetDays(this.MonthNumber.Value);
		List<int> list = new List<int>();
		for (int i = 1; i <= days; i++)
		{
			list.Add(i);
		}
		this.RightCircleExhibitionView.ReloadView(list.Count, list.ToArray(), 0);
		item2.SetUIActive(false);
	}

	// Token: 0x06012504 RID: 75012 RVA: 0x00482C89 File Offset: 0x00480E89
	private PersonalBirthAttachItem OnCreateRightCircleItem(AActor actor, int index, int showNum)
	{
		PersonalBirthAttachItem personalBirthAttachItem = new PersonalBirthAttachItem(actor);
		personalBirthAttachItem.SetDateType(EBirthDateType.DAY);
		personalBirthAttachItem.BindOnSelected(new Action<int>(this.OnSelectedRightNum));
		return personalBirthAttachItem;
	}

	// Token: 0x06012505 RID: 75013 RVA: 0x00482CAC File Offset: 0x00480EAC
	private void OnSelectedRightNum(int num)
	{
		this.DayNumber = new int?(num);
		if (this.MonthNumber != null)
		{
			base.GetButton(5).SetSelfInteractive(true);
			base.GetInteractionGroup(14).SetInteractable(true);
		}
		base.GetText(7).SetText(num.ToString(), true);
	}

	// Token: 0x06012506 RID: 75014 RVA: 0x00482D04 File Offset: 0x00480F04
	private int GetDays(int month)
	{
		if (month == 2)
		{
			return this.FebruaryDays;
		}
		int num = this.BigMonth.Length;
		for (int i = 0; i < num; i++)
		{
			if (this.BigMonth[i] == month)
			{
				return this.BigMonthDays;
			}
		}
		return this.SmallMonthDays;
	}

	// Token: 0x06012507 RID: 75015 RVA: 0x00482D49 File Offset: 0x00480F49
	protected override void OnAfterShow()
	{
	}

	// Token: 0x06012508 RID: 75016 RVA: 0x00482D4C File Offset: 0x00480F4C
	protected override void OnBeforeHide()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(13);
		EToggleState? etoggleState = (extendToggle != null) ? new EToggleState?(extendToggle.GetToggleState()) : null;
		EToggleState etoggleState2 = EToggleState.ETT_Checked;
		bool flag = (etoggleState.GetValueOrDefault() == etoggleState2 & etoggleState != null) > false;
		bool birthdayDisplay = PersonalModel.Instance.GetBirthdayDisplay();
		if (flag != birthdayDisplay)
		{
			PersonalController.Instance.SendBirthdayShowSetRequest(flag);
		}
	}

	// Token: 0x06012509 RID: 75017 RVA: 0x00482DAD File Offset: 0x00480FAD
	protected override void OnBeforeDestroy()
	{
		CircleAttachView<int, PersonalBirthAttachItem> leftCircleExhibitionView = this.LeftCircleExhibitionView;
		if (leftCircleExhibitionView != null)
		{
			leftCircleExhibitionView.Clear();
		}
		CircleAttachView<int, PersonalBirthAttachItem> rightCircleExhibitionView = this.RightCircleExhibitionView;
		if (rightCircleExhibitionView == null)
		{
			return;
		}
		rightCircleExhibitionView.Clear();
	}

	// Token: 0x04008A61 RID: 35425
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private CircleAttachView<int, PersonalBirthAttachItem> LeftCircleExhibitionView;

	// Token: 0x04008A62 RID: 35426
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private CircleAttachView<int, PersonalBirthAttachItem> RightCircleExhibitionView;

	// Token: 0x04008A63 RID: 35427
	private int? MonthNumber;

	// Token: 0x04008A64 RID: 35428
	private int? DayNumber;

	// Token: 0x04008A65 RID: 35429
	private readonly int[] BigMonth = new int[]
	{
		1,
		3,
		5,
		7,
		8,
		10,
		12
	};

	// Token: 0x04008A66 RID: 35430
	private readonly int BigMonthDays = 31;

	// Token: 0x04008A67 RID: 35431
	private readonly int SmallMonthDays = 30;

	// Token: 0x04008A68 RID: 35432
	private readonly int FebruaryDays = 29;

	// Token: 0x04008A69 RID: 35433
	private bool IsSelectMonthToggle;

	// Token: 0x04008A6A RID: 35434
	private bool IsSelectDayToggle;

	// Token: 0x04008A6B RID: 35435
	private const int SHOW_GAP = 2;

	// Token: 0x04008A6C RID: 35436
	private const int MONTH_COUNT = 12;
}
