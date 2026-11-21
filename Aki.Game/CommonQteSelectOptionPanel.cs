using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001B06 RID: 6918
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class CommonQteSelectOptionPanel : CommonQteItemBase<CommonQteSelectOptionContext>
{
	// Token: 0x060113D7 RID: 70615 RVA: 0x00511D24 File Offset: 0x0050FF24
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

	// Token: 0x060113D8 RID: 70616 RVA: 0x00511F75 File Offset: 0x00510175
	public override void SetPreloadQte(int qteId)
	{
		this.PreloadQteId = qteId;
	}

	// Token: 0x060113D9 RID: 70617 RVA: 0x00511F80 File Offset: 0x00510180
	protected override UniTask OnBeforeStartAsync()
	{
		CommonQteSelectOptionPanel.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CommonQteSelectOptionPanel.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060113DA RID: 70618 RVA: 0x00511FC4 File Offset: 0x005101C4
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

	// Token: 0x060113DB RID: 70619 RVA: 0x00512088 File Offset: 0x00510288
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

	// Token: 0x060113DC RID: 70620 RVA: 0x00512154 File Offset: 0x00510354
	private void OnInputControllerChange(EInputControllerType _1, EInputControllerType _2)
	{
		this.RefreshOnInputControllerChange();
	}

	// Token: 0x060113DD RID: 70621 RVA: 0x0051215C File Offset: 0x0051035C
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

	// Token: 0x060113DE RID: 70622 RVA: 0x0051223C File Offset: 0x0051043C
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

	// Token: 0x060113DF RID: 70623 RVA: 0x005122C4 File Offset: 0x005104C4
	protected override bool IsContextMatched(CommonQteContextBase context)
	{
		return context is CommonQteSelectOptionContext;
	}

	// Token: 0x060113E0 RID: 70624 RVA: 0x005122D0 File Offset: 0x005104D0
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

	// Token: 0x060113E1 RID: 70625 RVA: 0x0051243C File Offset: 0x0051063C
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

	// Token: 0x060113E2 RID: 70626 RVA: 0x005124E0 File Offset: 0x005106E0
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

	// Token: 0x060113E3 RID: 70627 RVA: 0x0051257C File Offset: 0x0051077C
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

	// Token: 0x060113E4 RID: 70628 RVA: 0x005125F4 File Offset: 0x005107F4
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

	// Token: 0x060113E5 RID: 70629 RVA: 0x0051264A File Offset: 0x0051084A
	protected override bool IsUseBaseAction()
	{
		return false;
	}

	// Token: 0x04009793 RID: 38803
	private const int MAX_OPTION_NUM = 4;

	// Token: 0x04009794 RID: 38804
	private const int OPTION_ITEM_OFFSET = 112;

	// Token: 0x04009795 RID: 38805
	private int PreloadQteId;

	// Token: 0x04009796 RID: 38806
	private readonly List<CommonQteSelectOptionItem> OptionItemList = new List<CommonQteSelectOptionItem>();

	// Token: 0x04009797 RID: 38807
	private readonly List<CommonQteSelectOptionItem> GamepadOptionItemList = new List<CommonQteSelectOptionItem>();

	// Token: 0x04009798 RID: 38808
	[Nullable(2)]
	private UUISliderComponent ProgressBar;

	// Token: 0x04009799 RID: 38809
	[Nullable(2)]
	private UUISliderComponent GamepadProgressBar;

	// Token: 0x02007DEE RID: 32238
	[NullableContext(0)]
	private enum EDesktopChildType
	{
		// Token: 0x04028C3D RID: 166973
		DesktopOptionItem1,
		// Token: 0x04028C3E RID: 166974
		DesktopOptionItem2,
		// Token: 0x04028C3F RID: 166975
		DesktopOptionItem3,
		// Token: 0x04028C40 RID: 166976
		DesktopOptionItem4,
		// Token: 0x04028C41 RID: 166977
		DesktopOptionPanel,
		// Token: 0x04028C42 RID: 166978
		GamepadOptionPanel,
		// Token: 0x04028C43 RID: 166979
		GamepadOptionItem1,
		// Token: 0x04028C44 RID: 166980
		GamepadOptionItem2,
		// Token: 0x04028C45 RID: 166981
		GamepadOptionItem3,
		// Token: 0x04028C46 RID: 166982
		GamepadOptionItem4,
		// Token: 0x04028C47 RID: 166983
		DesktopProgressPanel,
		// Token: 0x04028C48 RID: 166984
		DesktopProgressBar,
		// Token: 0x04028C49 RID: 166985
		GamepadProgressPanel,
		// Token: 0x04028C4A RID: 166986
		GamepadProgressBar,
		// Token: 0x04028C4B RID: 166987
		DesktopOffsetPanel,
		// Token: 0x04028C4C RID: 166988
		GamepadOffsetPanel,
		// Token: 0x04028C4D RID: 166989
		AttachRootItem
	}

	// Token: 0x02007DEF RID: 32239
	[NullableContext(0)]
	private enum EMobileChildType
	{
		// Token: 0x04028C4F RID: 166991
		OptionItem1,
		// Token: 0x04028C50 RID: 166992
		OptionItem2,
		// Token: 0x04028C51 RID: 166993
		OptionItem3,
		// Token: 0x04028C52 RID: 166994
		OptionItem4,
		// Token: 0x04028C53 RID: 166995
		ProgressPanel,
		// Token: 0x04028C54 RID: 166996
		ProgressBar,
		// Token: 0x04028C55 RID: 166997
		OffsetPanel
	}
}
