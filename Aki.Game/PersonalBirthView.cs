using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.AutoAttach;
using CSharpScript.Game.Module.Personal;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020018AC RID: 6316
[NullableContext(1)]
[Nullable(0)]
public class PersonalBirthView : UiTickViewBase
{
	// Token: 0x0600F9A6 RID: 63910 RVA: 0x0048FB07 File Offset: 0x0048DD07
	public PersonalBirthView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600F9A7 RID: 63911 RVA: 0x0048FB40 File Offset: 0x0048DD40
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

	// Token: 0x0600F9A8 RID: 63912 RVA: 0x0048FCE3 File Offset: 0x0048DEE3
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnBirthChange, new Action(this.OnBirthChange));
	}

	// Token: 0x0600F9A9 RID: 63913 RVA: 0x0048FD01 File Offset: 0x0048DF01
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnBirthChange, new Action(this.OnBirthChange));
	}

	// Token: 0x0600F9AA RID: 63914 RVA: 0x0048FD20 File Offset: 0x0048DF20
	private void OnBirthChange()
	{
		string textById = TextConfig.Instance.GetTextById("SetBirthSuccess");
		ScrollingTipsController.Instance.ShowTipsByText(textById);
		base.CloseMe(null);
	}

	// Token: 0x0600F9AB RID: 63915 RVA: 0x0048FD4F File Offset: 0x0048DF4F
	protected void OnLeftButtonClicked()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600F9AC RID: 63916 RVA: 0x0048FD58 File Offset: 0x0048DF58
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

	// Token: 0x0600F9AD RID: 63917 RVA: 0x0048FDA1 File Offset: 0x0048DFA1
	protected void OnMonthButtonClick()
	{
		if (this.IsSetBirth())
		{
			return;
		}
		this.RefreshLeftCircleExhibitionView();
		this.IsSelectMonthToggle = true;
	}

	// Token: 0x0600F9AE RID: 63918 RVA: 0x0048FDB9 File Offset: 0x0048DFB9
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

	// Token: 0x0600F9AF RID: 63919 RVA: 0x0048FDDC File Offset: 0x0048DFDC
	protected bool IsSetBirth()
	{
		int birthday = PersonalModel.Instance.GetBirthday();
		return BirthdayModel.Instance.GetBirthdayIsReset() && birthday != 0;
	}

	// Token: 0x0600F9B0 RID: 63920 RVA: 0x0048FE06 File Offset: 0x0048E006
	protected void CloseClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600F9B1 RID: 63921 RVA: 0x0048FE10 File Offset: 0x0048E010
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

	// Token: 0x0600F9B2 RID: 63922 RVA: 0x0048FFA4 File Offset: 0x0048E1A4
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

	// Token: 0x0600F9B3 RID: 63923 RVA: 0x0049002F File Offset: 0x0048E22F
	private PersonalBirthAttachItem OnCreateLeftCircleItem(AActor actor, int index, int showNum)
	{
		PersonalBirthAttachItem personalBirthAttachItem = new PersonalBirthAttachItem(actor);
		personalBirthAttachItem.SetDateType(EBirthDateType.MONTH);
		personalBirthAttachItem.BindOnSelected(new Action<int>(this.OnSelectedLeftNum));
		return personalBirthAttachItem;
	}

	// Token: 0x0600F9B4 RID: 63924 RVA: 0x00490050 File Offset: 0x0048E250
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

	// Token: 0x0600F9B5 RID: 63925 RVA: 0x004900E0 File Offset: 0x0048E2E0
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

	// Token: 0x0600F9B6 RID: 63926 RVA: 0x00490189 File Offset: 0x0048E389
	private PersonalBirthAttachItem OnCreateRightCircleItem(AActor actor, int index, int showNum)
	{
		PersonalBirthAttachItem personalBirthAttachItem = new PersonalBirthAttachItem(actor);
		personalBirthAttachItem.SetDateType(EBirthDateType.DAY);
		personalBirthAttachItem.BindOnSelected(new Action<int>(this.OnSelectedRightNum));
		return personalBirthAttachItem;
	}

	// Token: 0x0600F9B7 RID: 63927 RVA: 0x004901AC File Offset: 0x0048E3AC
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

	// Token: 0x0600F9B8 RID: 63928 RVA: 0x00490204 File Offset: 0x0048E404
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

	// Token: 0x0600F9B9 RID: 63929 RVA: 0x00490249 File Offset: 0x0048E449
	protected override void OnAfterShow()
	{
	}

	// Token: 0x0600F9BA RID: 63930 RVA: 0x0049024C File Offset: 0x0048E44C
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

	// Token: 0x0600F9BB RID: 63931 RVA: 0x004902AD File Offset: 0x0048E4AD
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

	// Token: 0x04008BA8 RID: 35752
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private CircleAttachView<int, PersonalBirthAttachItem> LeftCircleExhibitionView;

	// Token: 0x04008BA9 RID: 35753
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private CircleAttachView<int, PersonalBirthAttachItem> RightCircleExhibitionView;

	// Token: 0x04008BAA RID: 35754
	private int? MonthNumber;

	// Token: 0x04008BAB RID: 35755
	private int? DayNumber;

	// Token: 0x04008BAC RID: 35756
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

	// Token: 0x04008BAD RID: 35757
	private readonly int BigMonthDays = 31;

	// Token: 0x04008BAE RID: 35758
	private readonly int SmallMonthDays = 30;

	// Token: 0x04008BAF RID: 35759
	private readonly int FebruaryDays = 29;

	// Token: 0x04008BB0 RID: 35760
	private bool IsSelectMonthToggle;

	// Token: 0x04008BB1 RID: 35761
	private bool IsSelectDayToggle;

	// Token: 0x04008BB2 RID: 35762
	private const int SHOW_GAP = 2;

	// Token: 0x04008BB3 RID: 35763
	private const int MONTH_COUNT = 12;
}
