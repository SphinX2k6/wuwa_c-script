using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Personal;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020022E9 RID: 8937
public class OnlineApplyView : UiTickViewBase
{
	// Token: 0x060119B6 RID: 72118 RVA: 0x0045092D File Offset: 0x0044EB2D
	[NullableContext(1)]
	public OnlineApplyView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060119B7 RID: 72119 RVA: 0x00450938 File Offset: 0x0044EB38
	protected unsafe override void OnRegisterComponent()
	{
		int num = 13;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(18, typeof(UUITexture));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClickHandleBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(8, new Action(this.OnClickCancelBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060119B8 RID: 72120 RVA: 0x00450B71 File Offset: 0x0044ED71
	protected override void OnStart()
	{
		this.CountDown = base.GetText(5);
		this.CountDownBar = base.GetSprite(6);
		this.RefreshView();
		this.RefreshPcItem();
		this.RefreshThirdPartyItem();
	}

	// Token: 0x060119B9 RID: 72121 RVA: 0x00450BA0 File Offset: 0x0044EDA0
	protected override void OnTick(float delta)
	{
		OnlineApplyData currentApply = OnlineModel.Instance.CurrentApply;
		if (currentApply == null || currentApply.ApplyTimeLeftTime < 0.0)
		{
			if (!this.HaveClosed)
			{
				base.CloseMe(null);
				this.HaveClosed = true;
			}
			return;
		}
		this.CountDown.SetText(TimeUtil.Instance.GetCoolDown(currentApply.ApplyTimeLeftTime), true);
		this.CountDownBar.SetFillAmount((float)currentApply.ApplyTimeLeftTime / (float)OnlineModel.Instance.ApplyCd);
	}

	// Token: 0x060119BA RID: 72122 RVA: 0x00450C1D File Offset: 0x0044EE1D
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnRefreshApply, new Action(this.CallServerNotifyOnlineApply));
	}

	// Token: 0x060119BB RID: 72123 RVA: 0x00450C3B File Offset: 0x0044EE3B
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnRefreshApply, new Action(this.CallServerNotifyOnlineApply));
	}

	// Token: 0x060119BC RID: 72124 RVA: 0x00450C5C File Offset: 0x0044EE5C
	public void RefreshView()
	{
		int currentApplySize = OnlineModel.Instance.GetCurrentApplySize();
		UUIItem item = base.GetItem(3);
		UUIItem item2 = base.GetItem(4);
		UUIText text = base.GetText(7);
		if (currentApplySize <= 1)
		{
			item.SetUIActive(true);
			item2.SetUIActive(false);
			LguiUtil.Instance.SetLocalText(text, "OnlineSingleApply", Array.Empty<object>());
		}
		else
		{
			item.SetUIActive(false);
			item2.SetUIActive(true);
			LguiUtil.Instance.SetLocalText(text, "OnlineMultipleApply", new <>z__ReadOnlySingleElementList<object>(currentApplySize));
		}
		OnlineApplyData currentApply = OnlineModel.Instance.CurrentApply;
		if (currentApply == null)
		{
			return;
		}
		base.GetText(1).SetText(currentApply.Name, true);
		this.CountDown.SetText(TimeUtil.Instance.GetCoolDown(OnlineModel.Instance.CurrentApply.ApplyTimeLeftTime), true);
		this.CountDownBar.SetFillAmount((float)currentApply.ApplyTimeLeftTime / (float)OnlineModel.Instance.ApplyCd);
		PlayerHeadData playerHeadData = PersonalModel.Instance.GetPlayerHeadData(currentApply.HeadId, false);
		if (playerHeadData != null)
		{
			base.SetTextureByPath(playerHeadData.GetRoleHeadIconCircle(), base.GetTexture(0), null, null);
		}
		UUIButtonComponent button = base.GetButton(8);
		if (button == null)
		{
			return;
		}
		button.RootUIComp.Get().SetUIActive(true);
	}

	// Token: 0x060119BD RID: 72125 RVA: 0x00450DA0 File Offset: 0x0044EFA0
	private void OnClickHandleBtn()
	{
		if (OnlineModel.Instance.GetCurrentApplySize() > 1)
		{
			UiManager.Instance.OpenView(EUiViewName.OnlineMultipleApplyView, null, null);
			base.CloseMe(null);
			return;
		}
		if (OnlineModel.Instance.CurrentApply == null)
		{
			Log.Instance.Error(ELogModule.MultiPlayerTeam, ELogAuthor.LJQ, "当前申请不存在", default(ReadOnlySpan<ValueTuple<string, object>>));
			UiManager.Instance.CloseView(EUiViewName.OnlineMultipleApplyView, null);
			return;
		}
		OnlineController.Instance.AgreeJoinResultRequest(OnlineModel.Instance.CurrentApply.PlayerId, true);
	}

	// Token: 0x060119BE RID: 72126 RVA: 0x00450E28 File Offset: 0x0044F028
	private void OnClickCancelBtn()
	{
		if (OnlineModel.Instance.CurrentApply == null)
		{
			Log.Instance.Error(ELogModule.MultiPlayerTeam, ELogAuthor.LJQ, "当前申请不存在", default(ReadOnlySpan<ValueTuple<string, object>>));
			UiManager.Instance.CloseView(EUiViewName.OnlineMultipleApplyView, null);
			return;
		}
		OnlineController.Instance.AgreeJoinResultRequest(OnlineModel.Instance.CurrentApply.PlayerId, false);
	}

	// Token: 0x060119BF RID: 72127 RVA: 0x00450E88 File Offset: 0x0044F088
	private void RefreshPcItem()
	{
		if (KuroSdkController.Instance.NeedShowThirdPartyId())
		{
			bool flag = OnlineModel.Instance.CurrentApply.ThirdOnlineId != "";
			UUIItem item = base.GetItem(15);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(!flag);
			return;
		}
		else
		{
			UUIItem item2 = base.GetItem(15);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(false);
			return;
		}
	}

	// Token: 0x060119C0 RID: 72128 RVA: 0x00450EE8 File Offset: 0x0044F0E8
	private void RefreshThirdPartyItem()
	{
		if (KuroSdkController.Instance.NeedShowThirdPartyId())
		{
			bool flag = OnlineModel.Instance.CurrentApply.ThirdOnlineId != "";
			UUIItem item = base.GetItem(16);
			if (item != null)
			{
				item.SetUIActive(flag);
			}
			if (flag)
			{
				string thirdOnlineId = OnlineModel.Instance.CurrentApply.ThirdOnlineId;
				UUIText text = base.GetText(17);
				if (text != null)
				{
					text.SetText(thirdOnlineId, true);
				}
			}
			string thirdPartyLogoTexturePath = UiResourceConfig.Instance.GetThirdPartyLogoTexturePath(ELogoSize.Medium);
			base.SetTextureByPath(thirdPartyLogoTexturePath, base.GetTexture(18), null, null);
			string thirdPartyTextColor = UiResourceConfig.Instance.GetThirdPartyTextColor(EConsoleColorSet.Set1);
			UUIText text2 = base.GetText(17);
			if (text2 == null)
			{
				return;
			}
			text2.SetColor(FColor.FromHex(thirdPartyTextColor));
			return;
		}
		else
		{
			UUIItem item2 = base.GetItem(16);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(false);
			return;
		}
	}

	// Token: 0x060119C1 RID: 72129 RVA: 0x00450FB8 File Offset: 0x0044F1B8
	private void CallServerNotifyOnlineApply()
	{
		this.RefreshView();
	}

	// Token: 0x040085AC RID: 34220
	[Nullable(2)]
	private UUIText CountDown;

	// Token: 0x040085AD RID: 34221
	[Nullable(2)]
	private UUISprite CountDownBar;

	// Token: 0x040085AE RID: 34222
	private bool HaveClosed;

	// Token: 0x0200885F RID: 34911
	private enum EOnlineApplyView
	{
		// Token: 0x0402C4EB RID: 181483
		RoleTexture,
		// Token: 0x0402C4EC RID: 181484
		PlayerName,
		// Token: 0x0402C4ED RID: 181485
		HandleBtn,
		// Token: 0x0402C4EE RID: 181486
		ApplySprite,
		// Token: 0x0402C4EF RID: 181487
		MoreSprite,
		// Token: 0x0402C4F0 RID: 181488
		CountDown,
		// Token: 0x0402C4F1 RID: 181489
		CountDownProgressBar,
		// Token: 0x0402C4F2 RID: 181490
		MultipleApplyText,
		// Token: 0x0402C4F3 RID: 181491
		CancelBtn,
		// Token: 0x0402C4F4 RID: 181492
		TexturePc = 15,
		// Token: 0x0402C4F5 RID: 181493
		ThirdPartyItem,
		// Token: 0x0402C4F6 RID: 181494
		ThirdPartyText,
		// Token: 0x0402C4F7 RID: 181495
		ThirdPartyTexture
	}
}
