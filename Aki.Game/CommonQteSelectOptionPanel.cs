using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200261B RID: 9755
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class CommonQteSelectOptionPanel : CommonQteItemBase<CommonQteSelectOptionContext>
{
	// Token: 0x06013EF5 RID: 81653 RVA: 0x00502E60 File Offset: 0x00501060
	protected override void OnRegisterComponent()
	{
		base.OnRegisterComponent();
		if (Info.Instance.IsInTouch())
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUISliderComponent)),
				new ValueTuple<int, Type>(6, typeof(UUIItem))
			};
			return;
		}
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUISliderComponent)),
			new ValueTuple<int, Type>(12, typeof(UUIItem)),
			new ValueTuple<int, Type>(13, typeof(UUISliderComponent)),
			new ValueTuple<int, Type>(14, typeof(UUIItem)),
			new ValueTuple<int, Type>(15, typeof(UUIItem)),
			new ValueTuple<int, Type>(16, typeof(UUIItem))
		};
	}

	// Token: 0x06013EF6 RID: 81654 RVA: 0x005030B1 File Offset: 0x005012B1
	public override void SetPreloadQte(int qteId)
	{
		this.PreloadQteId = qteId;
	}

	// Token: 0x06013EF7 RID: 81655 RVA: 0x005030BC File Offset: 0x005012BC
	protected override UniTask OnBeforeStartAsync()
	{
		CommonQteSelectOptionPanel.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CommonQteSelectOptionPanel.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013EF8 RID: 81656 RVA: 0x00503100 File Offset: 0x00501300
	protected override void OnStart()
	{
		base.OnStart();
		if (Info.Instance.IsInTouch())
		{
			this.ProgressBar = base.GetSlider(5);
			UUIItem item = base.GetItem(4);
			if (item != null)
			{
				item.SetUIActive(false);
			}
		}
		else
		{
			this.ProgressBar = base.GetSlider(11);
			this.GamepadProgressBar = base.GetSlider(13);
			UUIItem item2 = base.GetItem(10);
			if (item2 != null)
			{
				item2.SetUIActive(false);
			}
			UUIItem item3 = base.GetItem(12);
			if (item3 != null)
			{
				item3.SetUIActive(false);
			}
			base.SetAttachRootItem(base.GetItem(16));
		}
		this.InitOptionItemOffset();
		this.RefreshOnInputControllerChange();
		base.SetUiActive(false);
		EventSystem.Instance.Add<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
	}

	// Token: 0x06013EF9 RID: 81657 RVA: 0x005031C4 File Offset: 0x005013C4
	protected override void OnBeforeDestroy()
	{
		base.OnBeforeDestroy();
		EventSystem.Instance.Remove<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
		foreach (CommonQteSelectOptionItem commonQteSelectOptionItem in this.OptionItemList)
		{
			commonQteSelectOptionItem.Destroy(null);
		}
		this.OptionItemList.Clear();
		foreach (CommonQteSelectOptionItem commonQteSelectOptionItem2 in this.GamepadOptionItemList)
		{
			commonQteSelectOptionItem2.Destroy(null);
		}
		this.GamepadOptionItemList.Clear();
	}

	// Token: 0x06013EFA RID: 81658 RVA: 0x00503290 File Offset: 0x00501490
	private void OnInputControllerChange(EInputControllerType _1, EInputControllerType _2)
	{
		this.RefreshOnInputControllerChange();
	}

	// Token: 0x06013EFB RID: 81659 RVA: 0x00503298 File Offset: 0x00501498
	protected void RefreshOnInputControllerChange()
	{
		if (this.GamepadOptionItemList.Count == 0)
		{
			return;
		}
		bool flag = Info.Instance.IsInGamepad();
		UUIItem item = base.GetItem(4);
		if (item != null)
		{
			item.SetUIActive(!flag);
		}
		UUIItem item2 = base.GetItem(14);
		if (item2 != null)
		{
			item2.SetUIActive(!flag);
		}
		UUIItem item3 = base.GetItem(5);
		if (item3 != null)
		{
			item3.SetUIActive(flag);
		}
		UUIItem item4 = base.GetItem(15);
		if (item4 != null)
		{
			item4.SetUIActive(flag);
		}
		CommonQteSelectOptionContext commonQteContext = this.CommonQteContext;
		if (commonQteContext != null && !commonQteContext.IsPermanent)
		{
			UUIItem item5 = base.GetItem(10);
			if (item5 != null)
			{
				item5.SetUIActive(!flag);
			}
			UUIItem item6 = base.GetItem(12);
			if (item6 == null)
			{
				return;
			}
			item6.SetUIActive(flag);
			return;
		}
		else
		{
			UUIItem item7 = base.GetItem(10);
			if (item7 != null)
			{
				item7.SetUIActive(false);
			}
			UUIItem item8 = base.GetItem(12);
			if (item8 == null)
			{
				return;
			}
			item8.SetUIActive(false);
			return;
		}
	}

	// Token: 0x06013EFC RID: 81660 RVA: 0x00503378 File Offset: 0x00501578
	private void InitOptionItemOffset()
	{
		switch (this.OptionItemList.Count)
		{
		case 2:
			this.OptionItemList[0].SetAnchorOffsetX(112f);
			return;
		case 3:
			this.OptionItemList[1].SetAnchorOffsetX(112f);
			return;
		case 4:
			this.OptionItemList[1].SetAnchorOffsetX(112f);
			this.OptionItemList[2].SetAnchorOffsetX(112f);
			return;
		default:
			return;
		}
	}

	// Token: 0x06013EFD RID: 81661 RVA: 0x00503400 File Offset: 0x00501600
	protected override bool IsContextMatched(CommonQteContextBase context)
	{
		return context is CommonQteSelectOptionContext;
	}

	// Token: 0x06013EFE RID: 81662 RVA: 0x0050340C File Offset: 0x0050160C
	public override void SetQteContext(CommonQteContextBase context)
	{
		CommonQteSelectOptionContext commonQteSelectOptionContext = context as CommonQteSelectOptionContext;
		if (commonQteSelectOptionContext == null)
		{
			return;
		}
		this.QteHandle = context.HandleId;
		this.CommonQteContext = commonQteSelectOptionContext;
		if (!commonQteSelectOptionContext.IsPermanent)
		{
			if (Info.Instance.IsInTouch())
			{
				UUIItem item = base.GetItem(4);
				if (item != null)
				{
					item.SetUIActive(true);
				}
			}
			else
			{
				UUIItem item2 = base.GetItem(10);
				if (item2 != null)
				{
					item2.SetUIActive(true);
				}
				UUIItem item3 = base.GetItem(12);
				if (item3 != null)
				{
					item3.SetUIActive(true);
				}
			}
		}
		if (commonQteSelectOptionContext.IsAttachToActor())
		{
			if (Info.Instance.IsInTouch())
			{
				UUIItem item4 = base.GetItem(6);
				if (item4 != null)
				{
					item4.SetAnchorOffset(Vector2D.ZeroVector);
				}
			}
			else
			{
				UUIItem item5 = base.GetItem(14);
				if (item5 != null)
				{
					item5.SetAnchorOffset(Vector2D.ZeroVector);
				}
				UUIItem item6 = base.GetItem(15);
				if (item6 != null)
				{
					item6.SetAnchorOffset(Vector2D.ZeroVector);
				}
			}
		}
		foreach (CommonQteSelectOptionItem commonQteSelectOptionItem in this.OptionItemList)
		{
			commonQteSelectOptionItem.SetQteContext(context);
		}
		foreach (CommonQteSelectOptionItem commonQteSelectOptionItem2 in this.GamepadOptionItemList)
		{
			commonQteSelectOptionItem2.SetQteContext(context);
		}
		base.SetQteActive(context);
		this.PlayQteStart();
	}

	// Token: 0x06013EFF RID: 81663 RVA: 0x00503578 File Offset: 0x00501778
	protected override void OnPlayQteStart()
	{
		this.IsQteStart = true;
		this.IsQteInteractive = true;
		base.SetUiActive(true);
		foreach (CommonQteSelectOptionItem commonQteSelectOptionItem in this.OptionItemList)
		{
			commonQteSelectOptionItem.PlayQteStart();
		}
		foreach (CommonQteSelectOptionItem commonQteSelectOptionItem2 in this.GamepadOptionItemList)
		{
			commonQteSelectOptionItem2.PlayQteStart();
		}
	}

	// Token: 0x06013F00 RID: 81664 RVA: 0x0050361C File Offset: 0x0050181C
	protected override void OnHandleQteEnd()
	{
		foreach (CommonQteSelectOptionItem commonQteSelectOptionItem in new List<CommonQteSelectOptionItem>(this.OptionItemList))
		{
			commonQteSelectOptionItem.PlayQteEnd();
		}
		foreach (CommonQteSelectOptionItem commonQteSelectOptionItem2 in new List<CommonQteSelectOptionItem>(this.GamepadOptionItemList))
		{
			commonQteSelectOptionItem2.PlayQteEnd();
		}
	}

	// Token: 0x06013F01 RID: 81665 RVA: 0x005036B8 File Offset: 0x005018B8
	public void OnOptionItemPlayEnded(CommonQteSelectOptionItem optionItem)
	{
		int num = this.OptionItemList.IndexOf(optionItem);
		if (num != -1)
		{
			this.OptionItemList.RemoveAt(num);
		}
		else if (this.GamepadOptionItemList.Count > 0)
		{
			int num2 = this.GamepadOptionItemList.IndexOf(optionItem);
			if (num2 != -1)
			{
				this.GamepadOptionItemList.RemoveAt(num2);
			}
		}
		if (this.OptionItemList.Count == 0 && this.GamepadOptionItemList.Count == 0)
		{
			base.Destroy(null);
		}
	}

	// Token: 0x06013F02 RID: 81666 RVA: 0x00503730 File Offset: 0x00501930
	protected override void OnTickQteItem(float delta)
	{
		if (!this.CommonQteContext.IsPermanent)
		{
			CommonQteSelectOptionContext commonQteContext = this.CommonQteContext;
			float inValue = (commonQteContext != null) ? commonQteContext.GetRemainingTimeProgress() : 1f;
			UUISliderComponent progressBar = this.ProgressBar;
			if (progressBar != null)
			{
				progressBar.SetValue(inValue, true);
			}
			UUISliderComponent gamepadProgressBar = this.GamepadProgressBar;
			if (gamepadProgressBar == null)
			{
				return;
			}
			gamepadProgressBar.SetValue(inValue, true);
		}
	}

	// Token: 0x06013F03 RID: 81667 RVA: 0x00503786 File Offset: 0x00501986
	protected override bool IsUseBaseAction()
	{
		return false;
	}

	// Token: 0x0400963C RID: 38460
	private const int MAX_OPTION_NUM = 4;

	// Token: 0x0400963D RID: 38461
	private const int OPTION_ITEM_OFFSET = 112;

	// Token: 0x0400963E RID: 38462
	private int PreloadQteId;

	// Token: 0x0400963F RID: 38463
	private readonly List<CommonQteSelectOptionItem> OptionItemList = new List<CommonQteSelectOptionItem>();

	// Token: 0x04009640 RID: 38464
	private readonly List<CommonQteSelectOptionItem> GamepadOptionItemList = new List<CommonQteSelectOptionItem>();

	// Token: 0x04009641 RID: 38465
	[Nullable(2)]
	private UUISliderComponent ProgressBar;

	// Token: 0x04009642 RID: 38466
	[Nullable(2)]
	private UUISliderComponent GamepadProgressBar;

	// Token: 0x02008C65 RID: 35941
	[NullableContext(0)]
	private enum EDesktopChildType
	{
		// Token: 0x0402D926 RID: 186662
		DesktopOptionItem1,
		// Token: 0x0402D927 RID: 186663
		DesktopOptionItem2,
		// Token: 0x0402D928 RID: 186664
		DesktopOptionItem3,
		// Token: 0x0402D929 RID: 186665
		DesktopOptionItem4,
		// Token: 0x0402D92A RID: 186666
		DesktopOptionPanel,
		// Token: 0x0402D92B RID: 186667
		GamepadOptionPanel,
		// Token: 0x0402D92C RID: 186668
		GamepadOptionItem1,
		// Token: 0x0402D92D RID: 186669
		GamepadOptionItem2,
		// Token: 0x0402D92E RID: 186670
		GamepadOptionItem3,
		// Token: 0x0402D92F RID: 186671
		GamepadOptionItem4,
		// Token: 0x0402D930 RID: 186672
		DesktopProgressPanel,
		// Token: 0x0402D931 RID: 186673
		DesktopProgressBar,
		// Token: 0x0402D932 RID: 186674
		GamepadProgressPanel,
		// Token: 0x0402D933 RID: 186675
		GamepadProgressBar,
		// Token: 0x0402D934 RID: 186676
		DesktopOffsetPanel,
		// Token: 0x0402D935 RID: 186677
		GamepadOffsetPanel,
		// Token: 0x0402D936 RID: 186678
		AttachRootItem
	}

	// Token: 0x02008C66 RID: 35942
	[NullableContext(0)]
	private enum EMobileChildType
	{
		// Token: 0x0402D938 RID: 186680
		OptionItem1,
		// Token: 0x0402D939 RID: 186681
		OptionItem2,
		// Token: 0x0402D93A RID: 186682
		OptionItem3,
		// Token: 0x0402D93B RID: 186683
		OptionItem4,
		// Token: 0x0402D93C RID: 186684
		ProgressPanel,
		// Token: 0x0402D93D RID: 186685
		ProgressBar,
		// Token: 0x0402D93E RID: 186686
		OffsetPanel
	}
}
