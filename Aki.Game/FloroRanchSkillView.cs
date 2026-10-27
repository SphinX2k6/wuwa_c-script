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

// Token: 0x02001B79 RID: 7033
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchSkillView : UiViewBase
{
	// Token: 0x0600D142 RID: 53570 RVA: 0x002FED88 File Offset: 0x002FCF88
	public FloroRanchSkillView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0600D143 RID: 53571 RVA: 0x002FED94 File Offset: 0x002FCF94
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

	// Token: 0x0600D144 RID: 53572 RVA: 0x002FEEE4 File Offset: 0x002FD0E4
	protected override UniTask OnBeforeStartAsync()
	{
		FloroRanchSkillView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FloroRanchSkillView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600D145 RID: 53573 RVA: 0x002FEF28 File Offset: 0x002FD128
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

	// Token: 0x0600D146 RID: 53574 RVA: 0x002FEF97 File Offset: 0x002FD197
	private bool OnCanExecuteChange(int skillId)
	{
		return this.SelectedSkillId != skillId;
	}

	// Token: 0x0600D147 RID: 53575 RVA: 0x002FEFA5 File Offset: 0x002FD1A5
	private void OnToggleCallback(int skillId)
	{
		this.SelectedSkillId = skillId;
		this.SkillLayout.SelectGridProxyByKey(skillId, false);
	}

	// Token: 0x0600D148 RID: 53576 RVA: 0x002FEFC0 File Offset: 0x002FD1C0
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

	// Token: 0x0600D149 RID: 53577 RVA: 0x002FF010 File Offset: 0x002FD210
	private void OnConfirmBtnClick()
	{
		LocalStorage.SetPlayer<int>(FloroRanchModel.Instance.GetSkillStorageKeyByActivityType(this.ActivityDataType), this.SelectedSkillId);
		FloroRanchModel.Instance.GetActivityData(this.ActivityDataType, true).SaveSkillRedDot();
		EventSystem.Instance.Emit<EFloroRanchActivityDataType, int>(EEventName.FloroRanchSkillChange, this.ActivityDataType, this.SelectedSkillId);
		base.CloseMe(null);
	}

	// Token: 0x0600D14A RID: 53578 RVA: 0x002FF072 File Offset: 0x002FD272
	private void OnCloseBtnClick()
	{
		FloroRanchModel.Instance.GetActivityData(this.ActivityDataType, true).SaveSkillRedDot();
		EventSystem.Instance.Emit<EFloroRanchActivityDataType>(EEventName.FloroRanchSkillRedDotRefresh, this.ActivityDataType);
		base.CloseMe(null);
	}

	// Token: 0x0600D14B RID: 53579 RVA: 0x002FF0A8 File Offset: 0x002FD2A8
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

	// Token: 0x04006008 RID: 24584
	private int SelectedSkillId;

	// Token: 0x04006009 RID: 24585
	private EFloroRanchActivityDataType ActivityDataType;

	// Token: 0x0400600A RID: 24586
	private bool CanSelect;

	// Token: 0x0400600B RID: 24587
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<FloroRanchSkillCardItem, FloroRanchSkillData> SkillLayout;

	// Token: 0x020080F9 RID: 33017
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x0402A160 RID: 172384
		public const int SpineRole = 2;

		// Token: 0x0402A161 RID: 172385
		public const int LayoutSkillCard = 4;

		// Token: 0x0402A162 RID: 172386
		public const int ItemSkillCard = 5;

		// Token: 0x0402A163 RID: 172387
		public const int ButtonConfirm = 6;

		// Token: 0x0402A164 RID: 172388
		public const int ButtonClose = 7;

		// Token: 0x0402A165 RID: 172389
		public const int ItemTip = 8;
	}
}
