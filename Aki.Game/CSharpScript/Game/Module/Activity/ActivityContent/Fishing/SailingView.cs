using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x0200660F RID: 26127
	public class SailingView : UiViewBase
	{
		// Token: 0x06041798 RID: 268184 RVA: 0x00FDB5B9 File Offset: 0x00FD97B9
		[NullableContext(1)]
		public SailingView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06041799 RID: 268185 RVA: 0x00FDB5C4 File Offset: 0x00FD97C4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 20;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 8;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickBackBtn));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(7, new Action(this.OnClickSkinBtn));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClickTimeHelpBtn));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action<EToggleState>(this.OnClickTimeNowToggle));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(5, new Action<EToggleState>(this.OnClickTimeDayToggle));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(6, new Action<EToggleState>(this.OnClickTimeNightToggle));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(11, new Action(this.OnClickDurabilityHelpBtn));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(15, new Action(this.OnClickConfirmBtn));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0604179A RID: 268186 RVA: 0x00FDB9BF File Offset: 0x00FD9BBF
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.FishingShipSkinChangeSuccess, new Action(this.FishingShipSkinChangeSuccess));
			EventSystem.Instance.Add(EEventName.FishingShipSkinClick, new Action(this.FishingShipSkinChangeSuccess));
		}

		// Token: 0x0604179B RID: 268187 RVA: 0x00FDB9F9 File Offset: 0x00FD9BF9
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.FishingShipSkinChangeSuccess, new Action(this.FishingShipSkinChangeSuccess));
			EventSystem.Instance.Remove(EEventName.FishingShipSkinClick, new Action(this.FishingShipSkinChangeSuccess));
		}

		// Token: 0x0604179C RID: 268188 RVA: 0x00FDBA34 File Offset: 0x00FD9C34
		protected override UniTask OnBeforeStartAsync()
		{
			SailingView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SailingView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0604179D RID: 268189 RVA: 0x00FDBA78 File Offset: 0x00FD9C78
		protected override void OnStart()
		{
			FishingModel.Instance.LocalSailingTime = ESailTime.Now;
			this.CurrentToggle = base.GetExtendToggle(4);
			UUIExtendToggle currentToggle = this.CurrentToggle;
			if (currentToggle != null)
			{
				currentToggle.SetToggleStateForce(EToggleState.ETT_Checked, false, true, false);
			}
			if (LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.SailingIsFix, false))
			{
				base.GetExtendToggle(14).SetToggleState(EToggleState.ETT_Checked, false, false, false);
			}
		}

		// Token: 0x0604179E RID: 268190 RVA: 0x00FDBACE File Offset: 0x00FD9CCE
		protected override void OnBeforeShow()
		{
			this.RefreshTimeItem();
			this.RefreshSkinItem();
			this.RefreshDurability();
		}

		// Token: 0x0604179F RID: 268191 RVA: 0x00FDBAE4 File Offset: 0x00FD9CE4
		private void RefreshTimeItem()
		{
			string hourMinuteString = TimeOfDayModel.Instance.GameTime.HourMinuteString;
			base.GetText(3).SetText(hourMinuteString, true);
			int currentTraceEntrust = FishingQuestModel.Instance.CurrentTraceEntrust;
			if (currentTraceEntrust <= 0)
			{
				base.GetItem(19).SetUIActive(false);
				return;
			}
			FishingEntrust? fishingEntrust = FishingConfig.Instance.GetFishingEntrust(currentTraceEntrust);
			bool uiactive = fishingEntrust != null && fishingEntrust.Value.IsNight;
			base.GetItem(19).SetUIActive(uiactive);
		}

		// Token: 0x060417A0 RID: 268192 RVA: 0x00FDBB64 File Offset: 0x00FD9D64
		private void RefreshSkinItem()
		{
			int currentSkinId = FishingModel.Instance.GetShipData().GetCurrentSkinId();
			FishingShipSkin fishingShipSkinConfig = FishingConfig.Instance.GetFishingShipSkinConfig(currentSkinId);
			base.SetTextureByPath(fishingShipSkinConfig.IconTexture, base.GetTexture(8), null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(9), fishingShipSkinConfig.Name, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(10), fishingShipSkinConfig.DesText, Array.Empty<object>());
			foreach (int value in FishingModel.Instance.UnlockShipSkin)
			{
				if (!NewFlagModel.Instance.HasNewFlag(ELocalStoragePlayerKey.FishingShipSkinRecord, value))
				{
					base.GetItem(18).SetUIActive(true);
					return;
				}
			}
			base.GetItem(18).SetUIActive(false);
		}

		// Token: 0x060417A1 RID: 268193 RVA: 0x00FDBC5C File Offset: 0x00FD9E5C
		private void RefreshDurability()
		{
			FishingShipData shipData = FishingModel.Instance.GetShipData();
			float currentHp = shipData.GetCurrentHp();
			float maxHp = shipData.GetMaxHp();
			base.GetText(12).SetText(currentHp.ToString() + "/" + maxHp.ToString(), true);
			base.SetTextureByPath(ItemConfig.Instance.GetConfig(FishingModel.Instance.FishingShipFixItem).Value.IconSmall, base.GetTexture(16), null, null);
			int fishingShipFixCost = FishingModel.Instance.FishingShipFixCost;
			float num = (maxHp - currentHp) * (float)fishingShipFixCost;
			base.GetText(13).SetText(num.ToString() ?? "", true);
		}

		// Token: 0x060417A2 RID: 268194 RVA: 0x00FDBD15 File Offset: 0x00FD9F15
		private void OnClickBackBtn()
		{
			base.CloseMe(null);
		}

		// Token: 0x060417A3 RID: 268195 RVA: 0x00FDBD1E File Offset: 0x00FD9F1E
		private void OnClickSkinBtn()
		{
			UiManager.Instance.OpenView(EUiViewName.ShipSkinView, null, null);
		}

		// Token: 0x060417A4 RID: 268196 RVA: 0x00FDBD31 File Offset: 0x00FD9F31
		private void OnClickTimeHelpBtn()
		{
			HelpController.Instance.OpenHelpById(185);
		}

		// Token: 0x060417A5 RID: 268197 RVA: 0x00FDBD42 File Offset: 0x00FD9F42
		private void OnClickDurabilityHelpBtn()
		{
			HelpController.Instance.OpenHelpById(186);
		}

		// Token: 0x060417A6 RID: 268198 RVA: 0x00FDBD53 File Offset: 0x00FD9F53
		private void OnClickTimeNowToggle(EToggleState toggleState)
		{
			UUIExtendToggle currentToggle = this.CurrentToggle;
			if (currentToggle != null)
			{
				currentToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			}
			this.CurrentToggle = base.GetExtendToggle(4);
			FishingModel.Instance.LocalSailingTime = ESailTime.Now;
		}

		// Token: 0x060417A7 RID: 268199 RVA: 0x00FDBD83 File Offset: 0x00FD9F83
		private void OnClickTimeDayToggle(EToggleState toggleState)
		{
			UUIExtendToggle currentToggle = this.CurrentToggle;
			if (currentToggle != null)
			{
				currentToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			}
			this.CurrentToggle = base.GetExtendToggle(5);
			FishingModel.Instance.LocalSailingTime = ESailTime.Day;
		}

		// Token: 0x060417A8 RID: 268200 RVA: 0x00FDBDB3 File Offset: 0x00FD9FB3
		private void OnClickTimeNightToggle(EToggleState toggleState)
		{
			UUIExtendToggle currentToggle = this.CurrentToggle;
			if (currentToggle != null)
			{
				currentToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			}
			this.CurrentToggle = base.GetExtendToggle(6);
			FishingModel.Instance.LocalSailingTime = ESailTime.Night;
		}

		// Token: 0x060417A9 RID: 268201 RVA: 0x00FDBDE4 File Offset: 0x00FD9FE4
		private void OnClickConfirmBtn()
		{
			bool isAutoFix = base.GetExtendToggle(14).ToggleState == EToggleState.ETT_Checked;
			int currentTraceEntrust = FishingQuestModel.Instance.CurrentTraceEntrust;
			FishingEntrust? fishingEntrust = FishingConfig.Instance.GetFishingEntrust(currentTraceEntrust);
			if (fishingEntrust != null && fishingEntrust.Value.IsNight && (FishingModel.Instance.LocalSailingTime == ESailTime.Day || (FishingModel.Instance.LocalSailingTime == ESailTime.Now && !FishingQuestModel.Instance.IsInNight())))
			{
				ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.FishingNightTraceSailingInDay);
				confirmBoxDataNew.FunctionMap.Add(1, delegate
				{
					FishingController.Instance.RequestFishingSailingRequest(isAutoFix, FishingModel.Instance.DockId, (int)FishingModel.Instance.LocalSailingTime);
				});
				confirmBoxDataNew.FunctionMap.Add(2, delegate
				{
					FishingController.Instance.RequestFishingSailingRequest(isAutoFix, FishingModel.Instance.DockId, 2);
				});
				confirmBoxDataNew.IsEscViewTriggerCallBack = false;
				ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
				return;
			}
			FishingController.Instance.RequestFishingSailingRequest(isAutoFix, FishingModel.Instance.DockId, (int)FishingModel.Instance.LocalSailingTime);
		}

		// Token: 0x060417AA RID: 268202 RVA: 0x00FDBEDE File Offset: 0x00FDA0DE
		private void FishingShipSkinChangeSuccess()
		{
			this.RefreshSkinItem();
		}

		// Token: 0x04022137 RID: 139575
		[Nullable(2)]
		private UUIExtendToggle CurrentToggle;

		// Token: 0x0200C81C RID: 51228
		private class EComponentDefine
		{
			// Token: 0x0403C6E9 RID: 247529
			public const int TitleText = 0;

			// Token: 0x0403C6EA RID: 247530
			public const int BackBtn = 1;

			// Token: 0x0403C6EB RID: 247531
			public const int TimeHelpBtn = 2;

			// Token: 0x0403C6EC RID: 247532
			public const int TimeText = 3;

			// Token: 0x0403C6ED RID: 247533
			public const int TimeNowToggle = 4;

			// Token: 0x0403C6EE RID: 247534
			public const int TimeDayToggle = 5;

			// Token: 0x0403C6EF RID: 247535
			public const int TimeNightToggle = 6;

			// Token: 0x0403C6F0 RID: 247536
			public const int SkinBtn = 7;

			// Token: 0x0403C6F1 RID: 247537
			public const int SkinTexture = 8;

			// Token: 0x0403C6F2 RID: 247538
			public const int SkinNameText = 9;

			// Token: 0x0403C6F3 RID: 247539
			public const int SkinEffectText = 10;

			// Token: 0x0403C6F4 RID: 247540
			public const int DurabilityHelpBtn = 11;

			// Token: 0x0403C6F5 RID: 247541
			public const int DurabilityText = 12;

			// Token: 0x0403C6F6 RID: 247542
			public const int DurabilityFixText = 13;

			// Token: 0x0403C6F7 RID: 247543
			public const int AutoFixToggle = 14;

			// Token: 0x0403C6F8 RID: 247544
			public const int ConfirmBtn = 15;

			// Token: 0x0403C6F9 RID: 247545
			public const int FixItemTexture = 16;

			// Token: 0x0403C6FA RID: 247546
			public const int FishingCurrencyItem = 17;

			// Token: 0x0403C6FB RID: 247547
			public const int SkinRedDotItem = 18;

			// Token: 0x0403C6FC RID: 247548
			public const int NightItem = 19;
		}
	}
}
