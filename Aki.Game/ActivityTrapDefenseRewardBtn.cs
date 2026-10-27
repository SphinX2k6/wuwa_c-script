using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001531 RID: 5425
[NullableContext(1)]
[Nullable(0)]
public class ActivityTrapDefenseRewardBtn : UiPanelBase
{
	// Token: 0x06009ACE RID: 39630 RVA: 0x00217C10 File Offset: 0x00215E10
	public UniTask Init(UUIItem item)
	{
		ActivityTrapDefenseRewardBtn.<Init>d__3 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.item = item;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<ActivityTrapDefenseRewardBtn.<Init>d__3>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x06009ACF RID: 39631 RVA: 0x00217C5B File Offset: 0x00215E5B
	protected override void OnBeforeCreate()
	{
	}

	// Token: 0x06009AD0 RID: 39632 RVA: 0x00217C60 File Offset: 0x00215E60
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnClickBtnSelf))
		};
	}

	// Token: 0x06009AD1 RID: 39633 RVA: 0x00217CF3 File Offset: 0x00215EF3
	protected override void OnStart()
	{
		this.SetRedDotVisible(false);
	}

	// Token: 0x06009AD2 RID: 39634 RVA: 0x00217CFC File Offset: 0x00215EFC
	protected override void OnBeforeShow()
	{
	}

	// Token: 0x06009AD3 RID: 39635 RVA: 0x00217CFE File Offset: 0x00215EFE
	protected override void OnBeforeDestroy()
	{
		this.UnBindRedDot();
	}

	// Token: 0x06009AD4 RID: 39636 RVA: 0x00217D06 File Offset: 0x00215F06
	public void SetEnableClick(bool state)
	{
		this.GetBtn().SetSelfInteractive(state);
	}

	// Token: 0x06009AD5 RID: 39637 RVA: 0x00217D14 File Offset: 0x00215F14
	public void SetRedDotVisible(bool visible)
	{
		this.GetRedDotItem().SetUIActive(visible);
	}

	// Token: 0x06009AD6 RID: 39638 RVA: 0x00217D22 File Offset: 0x00215F22
	public void BindRedDot(ERedDotName redDotName, int uId = 0)
	{
		this.UnBindRedDot();
		this.RedDotName = new ERedDotName?(redDotName);
		if (this.RedDotName != null)
		{
			RedDotController.Instance.BindRedDot(redDotName, this.GetRedDotItem(), null, uId);
		}
	}

	// Token: 0x06009AD7 RID: 39639 RVA: 0x00217D56 File Offset: 0x00215F56
	public void BindGivenUid(ERedDotName redDotName, int uId)
	{
		this.RedDotName = new ERedDotName?(redDotName);
		if (this.RedDotName != null)
		{
			RedDotController.Instance.BindRedDot(redDotName, this.GetRedDotItem(), null, uId);
		}
	}

	// Token: 0x06009AD8 RID: 39640 RVA: 0x00217D84 File Offset: 0x00215F84
	public void UnBindGivenUid(int uId)
	{
		if (this.RedDotName != null)
		{
			RedDotController.Instance.UnBindGivenUi(this.RedDotName.Value, this.GetRedDotItem(), uId);
		}
	}

	// Token: 0x06009AD9 RID: 39641 RVA: 0x00217DAF File Offset: 0x00215FAF
	public void UnBindRedDot()
	{
		if (this.RedDotName != null)
		{
			RedDotController.Instance.UnBindRedDot(this.RedDotName.Value);
			this.RedDotName = null;
		}
	}

	// Token: 0x06009ADA RID: 39642 RVA: 0x00217DDF File Offset: 0x00215FDF
	public UUIButtonComponent GetBtn()
	{
		return base.GetButton(0);
	}

	// Token: 0x06009ADB RID: 39643 RVA: 0x00217DE8 File Offset: 0x00215FE8
	public UUIItem GetRedDotItem()
	{
		return base.GetItem(3);
	}

	// Token: 0x06009ADC RID: 39644 RVA: 0x00217DF1 File Offset: 0x00215FF1
	public UUIText GetTitleText()
	{
		return base.GetText(1);
	}

	// Token: 0x06009ADD RID: 39645 RVA: 0x00217DFA File Offset: 0x00215FFA
	public UUIText GetProgressText()
	{
		return base.GetText(2);
	}

	// Token: 0x06009ADE RID: 39646 RVA: 0x00217E03 File Offset: 0x00216003
	private void OnClickBtnSelf()
	{
		Action onClickBtnCallback = this.OnClickBtnCallback;
		if (onClickBtnCallback == null)
		{
			return;
		}
		onClickBtnCallback();
	}

	// Token: 0x04004411 RID: 17425
	public ERedDotName? RedDotName;

	// Token: 0x04004412 RID: 17426
	[Nullable(2)]
	public Action OnClickBtnCallback;

	// Token: 0x02007B5A RID: 31578
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x04028900 RID: 166144
		public const int BtnSelf = 0;

		// Token: 0x04028901 RID: 166145
		public const int TextTitle = 1;

		// Token: 0x04028902 RID: 166146
		public const int TextProgress = 2;

		// Token: 0x04028903 RID: 166147
		public const int ItemRedDot = 3;
	}
}
