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
	// Token: 0x0200558D RID: 21901
	public class SailingView : UiViewBase
	{
		// Token: 0x0603645D RID: 222301 RVA: 0x00F22639 File Offset: 0x00F20839
		[NullableContext(1)]
		public SailingView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603645E RID: 222302 RVA: 0x00F22644 File Offset: 0x00F20844
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

		// Token: 0x0603645F RID: 222303 RVA: 0x00F22A3F File Offset: 0x00F20C3F
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.FishingShipSkinChangeSuccess, new Action(this.FishingShipSkinChangeSuccess));
			EventSystem.Instance.Add(EEventName.FishingShipSkinClick, new Action(this.FishingShipSkinChangeSuccess));
		}

		// Token: 0x06036460 RID: 222304 RVA: 0x00F22A79 File Offset: 0x00F20C79
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.FishingShipSkinChangeSuccess, new Action(this.FishingShipSkinChangeSuccess));
			EventSystem.Instance.Remove(EEventName.FishingShipSkinClick, new Action(this.FishingShipSkinChangeSuccess));
		}

		// Token: 0x06036461 RID: 222305 RVA: 0x00F22AB4 File Offset: 0x00F20CB4
		protected override UniTask OnBeforeStartAsync()
		{
			SailingView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SailingView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06036462 RID: 222306 RVA: 0x00F22AF8 File Offset: 0x00F20CF8
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

		// Token: 0x06036463 RID: 222307 RVA: 0x00F22B4E File Offset: 0x00F20D4E
		protected override void OnBeforeShow()
		{
			this.RefreshTimeItem();
			this.RefreshSkinItem();
			this.RefreshDurability();
		}

		// Token: 0x06036464 RID: 222308 RVA: 0x00F22B64 File Offset: 0x00F20D64
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

		// Token: 0x06036465 RID: 222309 RVA: 0x00F22BE4 File Offset: 0x00F20DE4
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

		// Token: 0x06036466 RID: 222310 RVA: 0x00F22CDC File Offset: 0x00F20EDC
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

		// Token: 0x06036467 RID: 222311 RVA: 0x00F22D95 File Offset: 0x00F20F95
		private void OnClickBackBtn()
		{
			base.CloseMe(null);
		}

		// Token: 0x06036468 RID: 222312 RVA: 0x00F22D9E File Offset: 0x00F20F9E
		private void OnClickSkinBtn()
		{
			UiManager.Instance.OpenView(EUiViewName.ShipSkinView, null, null);
		}

		// Token: 0x06036469 RID: 222313 RVA: 0x00F22DB1 File Offset: 0x00F20FB1
		private void OnClickTimeHelpBtn()
		{
			HelpController.Instance.OpenHelpById(185);
		}

		// Token: 0x0603646A RID: 222314 RVA: 0x00F22DC2 File Offset: 0x00F20FC2
		private void OnClickDurabilityHelpBtn()
		{
			HelpController.Instance.OpenHelpById(186);
		}

		// Token: 0x0603646B RID: 222315 RVA: 0x00F22DD3 File Offset: 0x00F20FD3
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

		// Token: 0x0603646C RID: 222316 RVA: 0x00F22E03 File Offset: 0x00F21003
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

		// Token: 0x0603646D RID: 222317 RVA: 0x00F22E33 File Offset: 0x00F21033
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

		// Token: 0x0603646E RID: 222318 RVA: 0x00F22E64 File Offset: 0x00F21064
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

		// Token: 0x0603646F RID: 222319 RVA: 0x00F22F5E File Offset: 0x00F2115E
		private void FishingShipSkinChangeSuccess()
		{
			this.RefreshSkinItem();
		}

		// Token: 0x0401CA68 RID: 117352
		[Nullable(2)]
		private UUIExtendToggle CurrentToggle;

		// Token: 0x0200B1FF RID: 45567
		private class EComponentDefine
		{
			// Token: 0x04037031 RID: 225329
			public const int TitleText = 0;

			// Token: 0x04037032 RID: 225330
			public const int BackBtn = 1;

			// Token: 0x04037033 RID: 225331
			public const int TimeHelpBtn = 2;

			// Token: 0x04037034 RID: 225332
			public const int TimeText = 3;

			// Token: 0x04037035 RID: 225333
			public const int TimeNowToggle = 4;

			// Token: 0x04037036 RID: 225334
			public const int TimeDayToggle = 5;

			// Token: 0x04037037 RID: 225335
			public const int TimeNightToggle = 6;

			// Token: 0x04037038 RID: 225336
			public const int SkinBtn = 7;

			// Token: 0x04037039 RID: 225337
			public const int SkinTexture = 8;

			// Token: 0x0403703A RID: 225338
			public const int SkinNameText = 9;

			// Token: 0x0403703B RID: 225339
			public const int SkinEffectText = 10;

			// Token: 0x0403703C RID: 225340
			public const int DurabilityHelpBtn = 11;

			// Token: 0x0403703D RID: 225341
			public const int DurabilityText = 12;

			// Token: 0x0403703E RID: 225342
			public const int DurabilityFixText = 13;

			// Token: 0x0403703F RID: 225343
			public const int AutoFixToggle = 14;

			// Token: 0x04037040 RID: 225344
			public const int ConfirmBtn = 15;

			// Token: 0x04037041 RID: 225345
			public const int FixItemTexture = 16;

			// Token: 0x04037042 RID: 225346
			public const int FishingCurrencyItem = 17;

			// Token: 0x04037043 RID: 225347
			public const int SkinRedDotItem = 18;

			// Token: 0x04037044 RID: 225348
			public const int NightItem = 19;
		}
	}
}
