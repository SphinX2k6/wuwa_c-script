using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020009E9 RID: 2537
[NullableContext(1)]
[Nullable(0)]
public class ActivityTrapDefenseRewardBtn : UiPanelBase
{
	// Token: 0x06006EAC RID: 28332 RVA: 0x002219B0 File Offset: 0x0021FBB0
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

	// Token: 0x06006EAD RID: 28333 RVA: 0x002219FB File Offset: 0x0021FBFB
	protected override void OnBeforeCreate()
	{
	}

	// Token: 0x06006EAE RID: 28334 RVA: 0x00221A00 File Offset: 0x0021FC00
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

	// Token: 0x06006EAF RID: 28335 RVA: 0x00221A93 File Offset: 0x0021FC93
	protected override void OnStart()
	{
		this.SetRedDotVisible(false);
	}

	// Token: 0x06006EB0 RID: 28336 RVA: 0x00221A9C File Offset: 0x0021FC9C
	protected override void OnBeforeShow()
	{
	}

	// Token: 0x06006EB1 RID: 28337 RVA: 0x00221A9E File Offset: 0x0021FC9E
	protected override void OnBeforeDestroy()
	{
		this.UnBindRedDot();
	}

	// Token: 0x06006EB2 RID: 28338 RVA: 0x00221AA6 File Offset: 0x0021FCA6
	public void SetEnableClick(bool state)
	{
		this.GetBtn().SetSelfInteractive(state);
	}

	// Token: 0x06006EB3 RID: 28339 RVA: 0x00221AB4 File Offset: 0x0021FCB4
	public void SetRedDotVisible(bool visible)
	{
		this.GetRedDotItem().SetUIActive(visible);
	}

	// Token: 0x06006EB4 RID: 28340 RVA: 0x00221AC2 File Offset: 0x0021FCC2
	public void BindRedDot(ERedDotName redDotName, int uId = 0)
	{
		this.UnBindRedDot();
		this.RedDotName = new ERedDotName?(redDotName);
		if (this.RedDotName != null)
		{
			RedDotController.Instance.BindRedDot(redDotName, this.GetRedDotItem(), null, uId);
		}
	}

	// Token: 0x06006EB5 RID: 28341 RVA: 0x00221AF6 File Offset: 0x0021FCF6
	public void BindGivenUid(ERedDotName redDotName, int uId)
	{
		this.RedDotName = new ERedDotName?(redDotName);
		if (this.RedDotName != null)
		{
			RedDotController.Instance.BindRedDot(redDotName, this.GetRedDotItem(), null, uId);
		}
	}

	// Token: 0x06006EB6 RID: 28342 RVA: 0x00221B24 File Offset: 0x0021FD24
	public void UnBindGivenUid(int uId)
	{
		if (this.RedDotName != null)
		{
			RedDotController.Instance.UnBindGivenUi(this.RedDotName.Value, this.GetRedDotItem(), uId);
		}
	}

	// Token: 0x06006EB7 RID: 28343 RVA: 0x00221B4F File Offset: 0x0021FD4F
	public void UnBindRedDot()
	{
		if (this.RedDotName != null)
		{
			RedDotController.Instance.UnBindRedDot(this.RedDotName.Value);
			this.RedDotName = null;
		}
	}

	// Token: 0x06006EB8 RID: 28344 RVA: 0x00221B7F File Offset: 0x0021FD7F
	public UUIButtonComponent GetBtn()
	{
		return base.GetButton(0);
	}

	// Token: 0x06006EB9 RID: 28345 RVA: 0x00221B88 File Offset: 0x0021FD88
	public UUIItem GetRedDotItem()
	{
		return base.GetItem(3);
	}

	// Token: 0x06006EBA RID: 28346 RVA: 0x00221B91 File Offset: 0x0021FD91
	public UUIText GetTitleText()
	{
		return base.GetText(1);
	}

	// Token: 0x06006EBB RID: 28347 RVA: 0x00221B9A File Offset: 0x0021FD9A
	public UUIText GetProgressText()
	{
		return base.GetText(2);
	}

	// Token: 0x06006EBC RID: 28348 RVA: 0x00221BA3 File Offset: 0x0021FDA3
	private void OnClickBtnSelf()
	{
		Action onClickBtnCallback = this.OnClickBtnCallback;
		if (onClickBtnCallback == null)
		{
			return;
		}
		onClickBtnCallback();
	}

	// Token: 0x040044B7 RID: 17591
	public ERedDotName? RedDotName;

	// Token: 0x040044B8 RID: 17592
	[Nullable(2)]
	public Action OnClickBtnCallback;

	// Token: 0x02006CE5 RID: 27877
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x04023C3B RID: 146491
		public const int BtnSelf = 0;

		// Token: 0x04023C3C RID: 146492
		public const int TextTitle = 1;

		// Token: 0x04023C3D RID: 146493
		public const int TextProgress = 2;

		// Token: 0x04023C3E RID: 146494
		public const int ItemRedDot = 3;
	}
}
