using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Personal;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020017CD RID: 6093
public class OnlineApplyView : UiTickViewBase
{
	// Token: 0x0600EE4E RID: 61006 RVA: 0x0045D5F9 File Offset: 0x0045B7F9
	[NullableContext(1)]
	public OnlineApplyView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600EE4F RID: 61007 RVA: 0x0045D604 File Offset: 0x0045B804
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

	// Token: 0x0600EE50 RID: 61008 RVA: 0x0045D83D File Offset: 0x0045BA3D
	protected override void OnStart()
	{
		this.CountDown = base.GetText(5);
		this.CountDownBar = base.GetSprite(6);
		this.RefreshView();
		this.RefreshPcItem();
		this.RefreshThirdPartyItem();
	}

	// Token: 0x0600EE51 RID: 61009 RVA: 0x0045D86C File Offset: 0x0045BA6C
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

	// Token: 0x0600EE52 RID: 61010 RVA: 0x0045D8E9 File Offset: 0x0045BAE9
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnRefreshApply, new Action(this.CallServerNotifyOnlineApply));
	}

	// Token: 0x0600EE53 RID: 61011 RVA: 0x0045D907 File Offset: 0x0045BB07
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnRefreshApply, new Action(this.CallServerNotifyOnlineApply));
	}

	// Token: 0x0600EE54 RID: 61012 RVA: 0x0045D928 File Offset: 0x0045BB28
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

	// Token: 0x0600EE55 RID: 61013 RVA: 0x0045DA6C File Offset: 0x0045BC6C
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

	// Token: 0x0600EE56 RID: 61014 RVA: 0x0045DAF4 File Offset: 0x0045BCF4
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

	// Token: 0x0600EE57 RID: 61015 RVA: 0x0045DB54 File Offset: 0x0045BD54
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

	// Token: 0x0600EE58 RID: 61016 RVA: 0x0045DBB4 File Offset: 0x0045BDB4
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

	// Token: 0x0600EE59 RID: 61017 RVA: 0x0045DC84 File Offset: 0x0045BE84
	private void CallServerNotifyOnlineApply()
	{
		this.RefreshView();
	}

	// Token: 0x040086EA RID: 34538
	[Nullable(2)]
	private UUIText CountDown;

	// Token: 0x040086EB RID: 34539
	[Nullable(2)]
	private UUISprite CountDownBar;

	// Token: 0x040086EC RID: 34540
	private bool HaveClosed;

	// Token: 0x020079E3 RID: 31203
	private enum EOnlineApplyView
	{
		// Token: 0x040277ED RID: 161773
		RoleTexture,
		// Token: 0x040277EE RID: 161774
		PlayerName,
		// Token: 0x040277EF RID: 161775
		HandleBtn,
		// Token: 0x040277F0 RID: 161776
		ApplySprite,
		// Token: 0x040277F1 RID: 161777
		MoreSprite,
		// Token: 0x040277F2 RID: 161778
		CountDown,
		// Token: 0x040277F3 RID: 161779
		CountDownProgressBar,
		// Token: 0x040277F4 RID: 161780
		MultipleApplyText,
		// Token: 0x040277F5 RID: 161781
		CancelBtn,
		// Token: 0x040277F6 RID: 161782
		TexturePc = 15,
		// Token: 0x040277F7 RID: 161783
		ThirdPartyItem,
		// Token: 0x040277F8 RID: 161784
		ThirdPartyText,
		// Token: 0x040277F9 RID: 161785
		ThirdPartyTexture
	}
}
