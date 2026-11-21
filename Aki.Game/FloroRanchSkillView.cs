using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001038 RID: 4152
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchSkillView : UiViewBase
{
	// Token: 0x0600A553 RID: 42323 RVA: 0x00309E60 File Offset: 0x00308060
	public FloroRanchSkillView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0600A554 RID: 42324 RVA: 0x00309E6C File Offset: 0x0030806C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 6;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(USpineSkeletonAnimationComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnConfirmBtnClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(7, new Action(this.OnCloseBtnClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600A555 RID: 42325 RVA: 0x00309FBC File Offset: 0x003081BC
	protected override UniTask OnBeforeStartAsync()
	{
		FloroRanchSkillView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FloroRanchSkillView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600A556 RID: 42326 RVA: 0x0030A000 File Offset: 0x00308200
	private void ResolveOpenParam()
	{
		object openParam = this.OpenParam;
		if (openParam is bool)
		{
			bool canSelect = (bool)openParam;
			this.CanSelect = canSelect;
			this.ActivityDataType = EFloroRanchActivityDataType.Normal;
			return;
		}
		openParam = this.OpenParam;
		if (openParam is FloroRanchSkillViewParam)
		{
			FloroRanchSkillViewParam floroRanchSkillViewParam = (FloroRanchSkillViewParam)openParam;
			this.CanSelect = floroRanchSkillViewParam.CanSelect;
			this.ActivityDataType = floroRanchSkillViewParam.ActivityDataType;
			return;
		}
		this.CanSelect = false;
		this.ActivityDataType = EFloroRanchActivityDataType.Normal;
	}

	// Token: 0x0600A557 RID: 42327 RVA: 0x0030A06F File Offset: 0x0030826F
	private bool OnCanExecuteChange(int skillId)
	{
		return this.SelectedSkillId != skillId;
	}

	// Token: 0x0600A558 RID: 42328 RVA: 0x0030A07D File Offset: 0x0030827D
	private void OnToggleCallback(int skillId)
	{
		this.SelectedSkillId = skillId;
		this.SkillLayout.SelectGridProxyByKey(skillId, false);
	}

	// Token: 0x0600A559 RID: 42329 RVA: 0x0030A098 File Offset: 0x00308298
	private FloroRanchSkillCardItem CreateSkillCard()
	{
		return new FloroRanchSkillCardItem
		{
			OnCanExecuteChangeFunc = new Func<int, bool>(this.OnCanExecuteChange),
			OnToggleCallBack = new Action<int>(this.OnToggleCallback),
			CanSelect = this.CanSelect,
			ActivityDataType = this.ActivityDataType
		};
	}

	// Token: 0x0600A55A RID: 42330 RVA: 0x0030A0E8 File Offset: 0x003082E8
	private void OnConfirmBtnClick()
	{
		LocalStorage.SetPlayer<int>(FloroRanchModel.Instance.GetSkillStorageKeyByActivityType(this.ActivityDataType), this.SelectedSkillId);
		FloroRanchModel.Instance.GetActivityData(this.ActivityDataType, true).SaveSkillRedDot();
		EventSystem.Instance.Emit<EFloroRanchActivityDataType, int>(EEventName.FloroRanchSkillChange, this.ActivityDataType, this.SelectedSkillId);
		base.CloseMe(null);
	}

	// Token: 0x0600A55B RID: 42331 RVA: 0x0030A14A File Offset: 0x0030834A
	private void OnCloseBtnClick()
	{
		FloroRanchModel.Instance.GetActivityData(this.ActivityDataType, true).SaveSkillRedDot();
		EventSystem.Instance.Emit<EFloroRanchActivityDataType>(EEventName.FloroRanchSkillRedDotRefresh, this.ActivityDataType);
		base.CloseMe(null);
	}

	// Token: 0x0600A55C RID: 42332 RVA: 0x0030A180 File Offset: 0x00308380
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		if (configParams.Length == 0)
		{
			return null;
		}
		if (!(configParams[0] == "SkillCard"))
		{
			return null;
		}
		if (configParams.Length < 2)
		{
			return null;
		}
		int index = int.Parse(configParams[1]);
		GenericLayout<FloroRanchSkillCardItem, FloroRanchSkillData> skillLayout = this.SkillLayout;
		UUIItem uuiitem = (skillLayout != null) ? skillLayout.GetItemByIndex(index) : null;
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

	// Token: 0x040060D7 RID: 24791
	private int SelectedSkillId;

	// Token: 0x040060D8 RID: 24792
	private EFloroRanchActivityDataType ActivityDataType;

	// Token: 0x040060D9 RID: 24793
	private bool CanSelect;

	// Token: 0x040060DA RID: 24794
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<FloroRanchSkillCardItem, FloroRanchSkillData> SkillLayout;

	// Token: 0x02007287 RID: 29319
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04025494 RID: 152724
		public const int SpineRole = 2;

		// Token: 0x04025495 RID: 152725
		public const int LayoutSkillCard = 4;

		// Token: 0x04025496 RID: 152726
		public const int ItemSkillCard = 5;

		// Token: 0x04025497 RID: 152727
		public const int ButtonConfirm = 6;

		// Token: 0x04025498 RID: 152728
		public const int ButtonClose = 7;

		// Token: 0x04025499 RID: 152729
		public const int ItemTip = 8;
	}
}
