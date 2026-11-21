using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Anniversary
{
	// Token: 0x02005865 RID: 22629
	[NullableContext(1)]
	[Nullable(0)]
	public class AnniversaryActivitySubView : ActivitySubViewBase
	{
		// Token: 0x06037CB3 RID: 228531 RVA: 0x00F99D1C File Offset: 0x00F97F1C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUITexture)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUITexture)),
				new ValueTuple<int, Type>(4, typeof(UUITexture)),
				new ValueTuple<int, Type>(5, typeof(UUITexture)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUIItem)),
				new ValueTuple<int, Type>(9, typeof(UUIItem)),
				new ValueTuple<int, Type>(10, typeof(UUIItem)),
				new ValueTuple<int, Type>(11, typeof(UUIItem)),
				new ValueTuple<int, Type>(12, typeof(UUIItem)),
				new ValueTuple<int, Type>(13, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(14, typeof(UUIText)),
				new ValueTuple<int, Type>(15, typeof(UUIHorizontalLayout)),
				new ValueTuple<int, Type>(16, typeof(UUIItem)),
				new ValueTuple<int, Type>(17, typeof(UUIItem)),
				new ValueTuple<int, Type>(18, typeof(UUITexture)),
				new ValueTuple<int, Type>(19, typeof(UUITexture)),
				new ValueTuple<int, Type>(20, typeof(UUITexture)),
				new ValueTuple<int, Type>(21, typeof(UUIItem)),
				new ValueTuple<int, Type>(22, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(23, typeof(UUIItem)),
				new ValueTuple<int, Type>(24, typeof(UUIVerticalLayout)),
				new ValueTuple<int, Type>(25, typeof(UUIItem)),
				new ValueTuple<int, Type>(26, typeof(UUIItem)),
				new ValueTuple<int, Type>(27, typeof(UUIButtonComponent))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(13, new Action(this.OnClickTimeMachine)),
				new ValueTuple<int, Delegate>(22, new Action(this.OnClickPersonalRewardDisplay)),
				new ValueTuple<int, Delegate>(27, new Action(this.OnClickPersonalRewardDisplay))
			};
		}

		// Token: 0x06037CB4 RID: 228532 RVA: 0x00F9A008 File Offset: 0x00F98208
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnAnniversaryActivityRewardUpdate, new Action(this.RefreshAnniversaryActivityReward));
			EventSystem.Instance.Add<int, int>(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
			EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshActivityRedDot));
			EventSystem.Instance.Add(EEventName.CrossDay, new Action(this.RefreshCrossDay));
		}

		// Token: 0x06037CB5 RID: 228533 RVA: 0x00F9A088 File Offset: 0x00F98288
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnAnniversaryActivityRewardUpdate, new Action(this.RefreshAnniversaryActivityReward));
			EventSystem.Instance.Remove(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
			EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshActivityRedDot));
			EventSystem.Instance.Remove(EEventName.CrossDay, new Action(this.RefreshCrossDay));
		}

		// Token: 0x06037CB6 RID: 228534 RVA: 0x00F9A105 File Offset: 0x00F98305
		protected override void OnSetData()
		{
			this.AnniversaryData = (this.ActivityBaseData as AnniversaryActivityData);
			AnniversaryActivityController.Instance.SetCheckedOpenActivity(false);
		}

		// Token: 0x06037CB7 RID: 228535 RVA: 0x00F9A123 File Offset: 0x00F98323
		protected override void OnStart()
		{
			this.RefreshTitleDeco();
		}

		// Token: 0x06037CB8 RID: 228536 RVA: 0x00F9A12C File Offset: 0x00F9832C
		protected override UniTask OnBeforeShowSelfAsync()
		{
			AnniversaryActivitySubView.<OnBeforeShowSelfAsync>d__23 <OnBeforeShowSelfAsync>d__;
			<OnBeforeShowSelfAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeShowSelfAsync>d__.<>4__this = this;
			<OnBeforeShowSelfAsync>d__.<>1__state = -1;
			<OnBeforeShowSelfAsync>d__.<>t__builder.Start<AnniversaryActivitySubView.<OnBeforeShowSelfAsync>d__23>(ref <OnBeforeShowSelfAsync>d__);
			return <OnBeforeShowSelfAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06037CB9 RID: 228537 RVA: 0x00F9A170 File Offset: 0x00F98370
		protected override UniTask OnBeforeHideSelfAsync()
		{
			AnniversaryActivitySubView.<OnBeforeHideSelfAsync>d__24 <OnBeforeHideSelfAsync>d__;
			<OnBeforeHideSelfAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeHideSelfAsync>d__.<>4__this = this;
			<OnBeforeHideSelfAsync>d__.<>1__state = -1;
			<OnBeforeHideSelfAsync>d__.<>t__builder.Start<AnniversaryActivitySubView.<OnBeforeHideSelfAsync>d__24>(ref <OnBeforeHideSelfAsync>d__);
			return <OnBeforeHideSelfAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06037CBA RID: 228538 RVA: 0x00F9A1B3 File Offset: 0x00F983B3
		protected override void OnBeforeDestroy()
		{
			this.WorldProgressTextTween.Destroy();
		}

		// Token: 0x06037CBB RID: 228539 RVA: 0x00F9A1C0 File Offset: 0x00F983C0
		protected override UniTask OnBeforeStartAsync()
		{
			AnniversaryActivitySubView.<OnBeforeStartAsync>d__26 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<AnniversaryActivitySubView.<OnBeforeStartAsync>d__26>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06037CBC RID: 228540 RVA: 0x00F9A204 File Offset: 0x00F98404
		protected override void OnSequenceStart(string sequenceName)
		{
			if (sequenceName != "Start")
			{
				return;
			}
			IReadOnlyList<AnniversaryEntrance> anniversaryEntranceAll = AnniversaryActivityConfig.Instance.GetAnniversaryEntranceAll();
			if (anniversaryEntranceAll != null)
			{
				foreach (AnniversaryEntrance anniversaryEntrance in anniversaryEntranceAll)
				{
					AnniversaryActivityData anniversaryData = this.AnniversaryData;
					AnniversarySubActivityDataBase anniversarySubActivityDataBase = (anniversaryData != null) ? anniversaryData.GetTargetSubActivityData((EAnniversarySubId)anniversaryEntrance.Id) : null;
					AnniversaryActivityEnterItem anniversaryActivityEnterItem;
					if (anniversarySubActivityDataBase != null && anniversarySubActivityDataBase.NeedPlayUnlockSequence() && this.ActivityEnterItemMap.TryGetValue((EAnniversarySubId)anniversaryEntrance.Id, out anniversaryActivityEnterItem))
					{
						anniversaryActivityEnterItem.PlayUnlockSequence().Forget();
					}
				}
			}
		}

		// Token: 0x06037CBD RID: 228541 RVA: 0x00F9A2A8 File Offset: 0x00F984A8
		protected override void OnSequenceClose(string sequenceName)
		{
			if (sequenceName != "Start")
			{
				return;
			}
			this.WorldProgressStartSequenceClosed = true;
			this.TryPlayPendingWorldProgressTextTween();
		}

		// Token: 0x06037CBE RID: 228542 RVA: 0x00F9A2C5 File Offset: 0x00F984C5
		private AnniversaryPersonalRewardItem CreateRewardItem()
		{
			AnniversaryPersonalRewardItem anniversaryPersonalRewardItem = new AnniversaryPersonalRewardItem();
			anniversaryPersonalRewardItem.SetClickCallback(new Action<int>(this.OnClickRewardItem));
			return anniversaryPersonalRewardItem;
		}

		// Token: 0x06037CBF RID: 228543 RVA: 0x00F9A2DE File Offset: 0x00F984DE
		private AnniversaryEnterRewardProgressItem CreateTaskItem()
		{
			return new AnniversaryEnterRewardProgressItem();
		}

		// Token: 0x06037CC0 RID: 228544 RVA: 0x00F9A2E8 File Offset: 0x00F984E8
		private UniTask InitActivityEnterItemsAsync(int subId, int compId)
		{
			AnniversaryActivitySubView.<InitActivityEnterItemsAsync>d__31 <InitActivityEnterItemsAsync>d__;
			<InitActivityEnterItemsAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitActivityEnterItemsAsync>d__.<>4__this = this;
			<InitActivityEnterItemsAsync>d__.subId = subId;
			<InitActivityEnterItemsAsync>d__.compId = compId;
			<InitActivityEnterItemsAsync>d__.<>1__state = -1;
			<InitActivityEnterItemsAsync>d__.<>t__builder.Start<AnniversaryActivitySubView.<InitActivityEnterItemsAsync>d__31>(ref <InitActivityEnterItemsAsync>d__);
			return <InitActivityEnterItemsAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06037CC1 RID: 228545 RVA: 0x00F9A33C File Offset: 0x00F9853C
		private AnniversaryActivityEnterItem GetAnniversaryActivityEnterItem(int subId)
		{
			switch (subId)
			{
			case 1:
				return new AnniversarySubActivityAnniversaryGiftUiItem();
			case 2:
				return new AnniversarySubActivityPinballUiItem();
			case 3:
				return new AnniversarySubActivityWuWuPackUiItem();
			case 4:
				return new AnniversarySubActivityDangoRunUiItem();
			default:
				return new AnniversaryActivityEnterItem();
			}
		}

		// Token: 0x06037CC2 RID: 228546 RVA: 0x00F9A384 File Offset: 0x00F98584
		private UniTask InitAnniversaryWorldRewardItemsAsync(int cfgId, int compId)
		{
			AnniversaryActivitySubView.<InitAnniversaryWorldRewardItemsAsync>d__33 <InitAnniversaryWorldRewardItemsAsync>d__;
			<InitAnniversaryWorldRewardItemsAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitAnniversaryWorldRewardItemsAsync>d__.<>4__this = this;
			<InitAnniversaryWorldRewardItemsAsync>d__.cfgId = cfgId;
			<InitAnniversaryWorldRewardItemsAsync>d__.compId = compId;
			<InitAnniversaryWorldRewardItemsAsync>d__.<>1__state = -1;
			<InitAnniversaryWorldRewardItemsAsync>d__.<>t__builder.Start<AnniversaryActivitySubView.<InitAnniversaryWorldRewardItemsAsync>d__33>(ref <InitAnniversaryWorldRewardItemsAsync>d__);
			return <InitAnniversaryWorldRewardItemsAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06037CC3 RID: 228547 RVA: 0x00F9A3D8 File Offset: 0x00F985D8
		private UniTask InitPersonRewardItemAsync()
		{
			AnniversaryActivitySubView.<InitPersonRewardItemAsync>d__34 <InitPersonRewardItemAsync>d__;
			<InitPersonRewardItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitPersonRewardItemAsync>d__.<>4__this = this;
			<InitPersonRewardItemAsync>d__.<>1__state = -1;
			<InitPersonRewardItemAsync>d__.<>t__builder.Start<AnniversaryActivitySubView.<InitPersonRewardItemAsync>d__34>(ref <InitPersonRewardItemAsync>d__);
			return <InitPersonRewardItemAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06037CC4 RID: 228548 RVA: 0x00F9A41B File Offset: 0x00F9861B
		protected override void OnRefreshView()
		{
			if (this.AnniversaryData == null)
			{
				return;
			}
			this.RefreshActivityTime();
			this.RefreshWorldProgress();
			this.RefreshPersonalProgress();
			this.RefreshWorldProgressRewards();
			this.RefreshPersonalRewards();
			this.RefreshSubActivityButtons();
		}

		// Token: 0x06037CC5 RID: 228549 RVA: 0x00F9A44C File Offset: 0x00F9864C
		private void RefreshTitleDeco()
		{
			string packageLanguage = LanguageSystem.Instance.PackageLanguage;
			string resourceId = "T_AnniversaryCelebrationLogo_EN";
			if (!(packageLanguage == "zh-Hans"))
			{
				if (packageLanguage == "en")
				{
					resourceId = "T_AnniversaryCelebrationLogo_EN";
				}
			}
			else
			{
				resourceId = "T_AnniversaryCelebrationLogo_CN";
			}
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
			base.TrySetTextureByPath(resourcePath, base.GetTexture(0), null, null);
		}

		// Token: 0x06037CC6 RID: 228550 RVA: 0x00F9A4B8 File Offset: 0x00F986B8
		protected override void OnTimer(float gap)
		{
			this.RefreshActivityTime();
			this.RefreshSubActivityTips();
		}

		// Token: 0x06037CC7 RID: 228551 RVA: 0x00F9A4C8 File Offset: 0x00F986C8
		private void OnClickRewardItem(int cfgId)
		{
			if (this.AnniversaryData == null)
			{
				return;
			}
			if (this.AnniversaryData.TargetPersonalCanReceive(cfgId))
			{
				AnniversaryActivityController.Instance.RequestThemePersonalScore(this.AnniversaryData);
				return;
			}
			PersonProgressCurve? personProgressCurveById = AnniversaryActivityConfig.Instance.GetPersonProgressCurveById(cfgId);
			if (personProgressCurveById == null)
			{
				return;
			}
			this.OpenRewardPreviewView(personProgressCurveById.Value.MotorPreviewId, personProgressCurveById.Value.DropId);
		}

		// Token: 0x06037CC8 RID: 228552 RVA: 0x00F9A538 File Offset: 0x00F98738
		private void OpenDropRewardItemTips(int dropId)
		{
			Dictionary<int, int> dropPackagePreview = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreview(dropId);
			if (dropPackagePreview == null || dropPackagePreview.Count == 0)
			{
				return;
			}
			using (Dictionary<int, int>.Enumerator enumerator = dropPackagePreview.GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					KeyValuePair<int, int> keyValuePair = enumerator.Current;
					int key = keyValuePair.Key;
					CSharpScript.Game.Module.Inventory.ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(key);
					if (itemConfigData != null && itemConfigData.ItemType.GetValueOrDefault() == InventoryDefine.EItemType.Ornament)
					{
						RoleController.Instance.OpenOrnamentPreviewView(key, null);
					}
					else
					{
						ItemController.Instance.OpenItemTipsByItemId(key, true, null, false);
					}
				}
			}
		}

		// Token: 0x06037CC9 RID: 228553 RVA: 0x00F9A5E8 File Offset: 0x00F987E8
		private void RefreshActivityTime()
		{
			if (this.ActivityBaseData == null)
			{
				return;
			}
			ValueTuple<bool, string, long> timeVisibleAndRemainTime = ActivityModel.Instance.GetTimeVisibleAndRemainTime(this.ActivityBaseData, null);
			bool item = timeVisibleAndRemainTime.Item1;
			string item2 = timeVisibleAndRemainTime.Item2;
			UUIText text = base.GetText(1);
			if (text == null)
			{
				return;
			}
			text.SetUIActive(item);
			text.SetText(item2, true);
		}

		// Token: 0x06037CCA RID: 228554 RVA: 0x00F9A637 File Offset: 0x00F98837
		private void BindWorldProgressTextTween()
		{
			this.WorldProgressTextTween.BindUpdateTween(new Action<float>(this.OnWorldProgressTextTweenUpdate));
			this.WorldProgressTextTween.BindCompleteTween(new Action(this.OnWorldProgressTextTweenComplete));
		}

		// Token: 0x06037CCB RID: 228555 RVA: 0x00F9A667 File Offset: 0x00F98867
		private void OnWorldProgressTextTweenUpdate(float value)
		{
			this.SetWorldProgressTextPercentRaw(value);
		}

		// Token: 0x06037CCC RID: 228556 RVA: 0x00F9A670 File Offset: 0x00F98870
		private void OnWorldProgressTextTweenComplete()
		{
			AnniversaryActivityData anniversaryData = this.AnniversaryData;
			if (anniversaryData == null)
			{
				return;
			}
			anniversaryData.MarkWorldProgressNumberTweenPlayedToday();
		}

		// Token: 0x06037CCD RID: 228557 RVA: 0x00F9A684 File Offset: 0x00F98884
		private void SetWorldProgressTextPercentRaw(float percentRaw)
		{
			UUIText text = base.GetText(2);
			if (text == null)
			{
				return;
			}
			string str = (percentRaw / 100f).ToString("F1");
			text.SetText(str + "%", true);
		}

		// Token: 0x06037CCE RID: 228558 RVA: 0x00F9A6C4 File Offset: 0x00F988C4
		private float GetPreviousWorldProgressPercent(int worldProgressId)
		{
			if (worldProgressId <= 0)
			{
				return 0f;
			}
			IReadOnlyList<WorldProgressCurve> worldProgressCurveAll = AnniversaryActivityConfig.Instance.GetWorldProgressCurveAll();
			if (worldProgressCurveAll == null)
			{
				return 0f;
			}
			int num = -1;
			int num2 = 0;
			foreach (WorldProgressCurve worldProgressCurve in worldProgressCurveAll)
			{
				if (worldProgressCurve.Id < worldProgressId && worldProgressCurve.Id > num)
				{
					num = worldProgressCurve.Id;
					num2 = worldProgressCurve.Percent;
				}
			}
			return (float)num2;
		}

		// Token: 0x06037CCF RID: 228559 RVA: 0x00F9A750 File Offset: 0x00F98950
		private void TryPlayPendingWorldProgressTextTween()
		{
			if (this.PendingWorldProgressTextTween == null || !this.WorldProgressStartSequenceClosed)
			{
				return;
			}
			if (this.AnniversaryData == null || !this.AnniversaryData.NeedPlayWorldProgressNumberTweenToday())
			{
				float item = this.PendingWorldProgressTextTween.Value.Item2;
				this.PendingWorldProgressTextTween = null;
				this.SetWorldProgressTextPercentRaw(item);
				return;
			}
			float item2 = this.PendingWorldProgressTextTween.Value.Item1;
			float item3 = this.PendingWorldProgressTextTween.Value.Item2;
			this.PendingWorldProgressTextTween = null;
			if (item2 == item3)
			{
				return;
			}
			this.WorldProgressTextTween.PlayTween(item2, item3, 1.25f, null);
		}

		// Token: 0x06037CD0 RID: 228560 RVA: 0x00F9A7F4 File Offset: 0x00F989F4
		private void RefreshWorldProgress()
		{
			if (this.AnniversaryData == null)
			{
				return;
			}
			if (base.GetText(2) == null)
			{
				return;
			}
			int worldCurProgressId = this.AnniversaryData.GetWorldCurProgressId();
			WorldProgressCurve? worldProgressCurveById = AnniversaryActivityConfig.Instance.GetWorldProgressCurveById(worldCurProgressId);
			int num = (worldProgressCurveById != null) ? worldProgressCurveById.Value.Percent : 0;
			float previousWorldProgressPercent = this.GetPreviousWorldProgressPercent(worldCurProgressId);
			this.WorldProgressTextTween.KillTween();
			bool flag = this.AnniversaryData.NeedPlayWorldProgressNumberTweenToday();
			bool flag2 = this.AnniversaryData.IsPreviousProgressFull();
			if (!flag || previousWorldProgressPercent == (float)num || flag2)
			{
				this.PendingWorldProgressTextTween = null;
				this.SetWorldProgressTextPercentRaw((float)num);
				if (flag2 && flag)
				{
					this.AnniversaryData.MarkWorldProgressNumberTweenPlayedToday();
				}
			}
			else
			{
				this.SetWorldProgressTextPercentRaw(previousWorldProgressPercent);
				this.PendingWorldProgressTextTween = new ValueTuple<float, float>?(new ValueTuple<float, float>(previousWorldProgressPercent, (float)num));
				this.TryPlayPendingWorldProgressTextTween();
			}
			IReadOnlyList<WorldProgressCurve> worldProgressCurveHadReward = AnniversaryActivityConfig.Instance.GetWorldProgressCurveHadReward();
			if (worldProgressCurveHadReward == null || worldProgressCurveHadReward.Count == 0)
			{
				return;
			}
			int num2 = num;
			int num3 = 0;
			for (int i = 0; i < 3; i++)
			{
				int num4 = 10000;
				if (i < worldProgressCurveHadReward.Count)
				{
					num4 = worldProgressCurveHadReward[i].Percent;
				}
				float val = 0f;
				if (num2 >= num4)
				{
					val = 1f;
				}
				else if (num4 > num3)
				{
					val = (float)(num2 - num3) / (float)(num4 - num3);
				}
				float num5 = Math.Max(0f, Math.Min(val, 1f));
				UUITexture texture = base.GetTexture(3 + i);
				if (texture != null)
				{
					texture.SetFillAmount(num5);
				}
				UUITexture texture2 = base.GetTexture(18 + i);
				if (texture2 != null)
				{
					texture2.SetCustomMaterialScalarParameter(this.ParameterName, num5);
				}
				num3 = num4;
			}
		}

		// Token: 0x06037CD1 RID: 228561 RVA: 0x00F9A9A8 File Offset: 0x00F98BA8
		private void RefreshPersonalProgress()
		{
			AnniversaryActivityData anniversaryData = this.AnniversaryData;
			int num = (anniversaryData != null) ? anniversaryData.GetPersonalCurProgress() : 0;
			UUIText text = base.GetText(14);
			if (text == null)
			{
				return;
			}
			text.SetText(num.ToString(), true);
		}

		// Token: 0x06037CD2 RID: 228562 RVA: 0x00F9A9E4 File Offset: 0x00F98BE4
		private void RefreshWorldProgressRewards()
		{
			if (this.AnniversaryData == null)
			{
				return;
			}
			IReadOnlyList<WorldProgressCurve> readOnlyList = AnniversaryActivityConfig.Instance.GetWorldProgressCurveHadReward() ?? new List<WorldProgressCurve>();
			int worldCurProgressId = this.AnniversaryData.GetWorldCurProgressId();
			List<int> worldRewardIds = this.AnniversaryData.GetWorldRewardIds();
			for (int i = 0; i < this.WorldRewardItems.Count; i++)
			{
				GridProxyAbstract<AnniversaryWorldRewardItemData> gridProxyAbstract = this.WorldRewardItems[i];
				WorldProgressCurve worldProgressCurve = readOnlyList[i];
				bool flag = worldCurProgressId >= worldProgressCurve.Id;
				bool flag2 = worldRewardIds.Contains(worldProgressCurve.Id);
				EAnniversaryProgressRewardState value = (!flag) ? EAnniversaryProgressRewardState.Lock : (flag2 ? EAnniversaryProgressRewardState.Rewarded : EAnniversaryProgressRewardState.CanReceive);
				AnniversaryWorldRewardItemData data = new AnniversaryWorldRewardItemData
				{
					CfgId = worldProgressCurve.Id,
					State = new EAnniversaryProgressRewardState?(value)
				};
				gridProxyAbstract.Refresh(data, false, i);
			}
		}

		// Token: 0x06037CD3 RID: 228563 RVA: 0x00F9AAA8 File Offset: 0x00F98CA8
		private void RefreshPersonalRewards()
		{
			if (this.AnniversaryData == null)
			{
				return;
			}
			IReadOnlyList<PersonProgressCurve> personProgressCurveAll = AnniversaryActivityConfig.Instance.GetPersonProgressCurveAll();
			if (personProgressCurveAll == null || personProgressCurveAll.Count == 0)
			{
				return;
			}
			List<int> personalRewardIds = this.AnniversaryData.GetPersonalRewardIds();
			int personalCurProgress = this.AnniversaryData.GetPersonalCurProgress();
			int num = 0;
			List<AnniversaryPersonalRewardItemData> list = new List<AnniversaryPersonalRewardItemData>();
			for (int i = 0; i < personProgressCurveAll.Count; i++)
			{
				PersonProgressCurve personProgressCurve = personProgressCurveAll[i];
				PersonProgressCurve? personProgressCurveById = AnniversaryActivityConfig.Instance.GetPersonProgressCurveById(personProgressCurve.Id);
				if (personProgressCurveById != null)
				{
					bool flag = personalRewardIds.Contains(personProgressCurve.Id);
					EAnniversaryProgressRewardState value = EAnniversaryProgressRewardState.Lock;
					if (flag)
					{
						value = EAnniversaryProgressRewardState.Rewarded;
					}
					else if (personalCurProgress >= personProgressCurveById.Value.Progress)
					{
						value = EAnniversaryProgressRewardState.CanReceive;
					}
					float curProgress;
					if (personalCurProgress >= personProgressCurveById.Value.Progress)
					{
						curProgress = 1f;
					}
					else
					{
						curProgress = (float)(personalCurProgress - num) / (float)(personProgressCurveById.Value.Progress - num);
					}
					AnniversaryPersonalRewardItemData anniversaryPersonalRewardItemData = new AnniversaryPersonalRewardItemData
					{
						CfgId = personProgressCurve.Id,
						State = new EAnniversaryProgressRewardState?(value),
						CurProgress = curProgress
					};
					if (i == personProgressCurveAll.Count - 1)
					{
						AnniversaryPersonalRewardItem lastPersonalRewardDisplay = this.LastPersonalRewardDisplay;
						if (lastPersonalRewardDisplay == null)
						{
							break;
						}
						lastPersonalRewardDisplay.Refresh(anniversaryPersonalRewardItemData, false, i);
						break;
					}
					else
					{
						list.Add(anniversaryPersonalRewardItemData);
						num = personProgressCurveById.Value.Progress;
					}
				}
			}
			GenericLayout<AnniversaryPersonalRewardItem, AnniversaryPersonalRewardItemData> personalRewardLayout = this.PersonalRewardLayout;
			if (personalRewardLayout == null)
			{
				return;
			}
			personalRewardLayout.RefreshByData(list, null, false);
		}

		// Token: 0x06037CD4 RID: 228564 RVA: 0x00F9AC18 File Offset: 0x00F98E18
		private void RefreshSubActivityButtons()
		{
			if (this.AnniversaryData == null)
			{
				return;
			}
			foreach (KeyValuePair<EAnniversarySubId, AnniversaryActivityEnterItem> keyValuePair in this.ActivityEnterItemMap)
			{
				AnniversarySubActivityDataBase targetSubActivityData = this.AnniversaryData.GetTargetSubActivityData(keyValuePair.Key);
				if (targetSubActivityData != null)
				{
					keyValuePair.Value.Refresh(targetSubActivityData);
				}
			}
		}

		// Token: 0x06037CD5 RID: 228565 RVA: 0x00F9AC90 File Offset: 0x00F98E90
		private void RefreshSubActivityTips()
		{
			if (this.AnniversaryData == null)
			{
				return;
			}
			foreach (KeyValuePair<EAnniversarySubId, AnniversaryActivityEnterItem> keyValuePair in this.ActivityEnterItemMap)
			{
				AnniversaryActivityEnterItem value = keyValuePair.Value;
				if (value != null)
				{
					value.OnTipsTimerTick();
				}
			}
		}

		// Token: 0x06037CD6 RID: 228566 RVA: 0x00F9ACF8 File Offset: 0x00F98EF8
		private void OnClickTimeMachine()
		{
			ActivityBaseData activityById = ActivityModel.Instance.GetActivityById(108400002);
			if (activityById == null || !activityById.IsUnLock())
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("Activity_Anniversary2_Lock", Array.Empty<object>());
				return;
			}
			ActivityController.Instance.OpenActivityById(108400002, EActivityViewOpenType.Other, null, null);
		}

		// Token: 0x06037CD7 RID: 228567 RVA: 0x00F9AD48 File Offset: 0x00F98F48
		private void OnClickPersonalRewardDisplay()
		{
			this.ShowRewardProgressDisplay = !this.ShowRewardProgressDisplay;
			this.SetVisibleRewardProgressDisplay(this.ShowRewardProgressDisplay);
		}

		// Token: 0x06037CD8 RID: 228568 RVA: 0x00F9AD68 File Offset: 0x00F98F68
		private void SetVisibleRewardProgressDisplay(bool visible)
		{
			UUIItem item = base.GetItem(23);
			if (item != null)
			{
				item.SetUIActive(visible);
			}
			FRotator frotator = visible ? this.OpenRotation : this.CloseRotation;
			UUIButtonComponent button = base.GetButton(22);
			if (button != null)
			{
				UUIItem uuiitem = button.RootUIComp.Get();
				if (uuiitem != null)
				{
					uuiitem.SetUIRelativeRotation(frotator);
				}
			}
			if (visible)
			{
				this.RefreshTaskItemLayout();
			}
		}

		// Token: 0x06037CD9 RID: 228569 RVA: 0x00F9ADCC File Offset: 0x00F98FCC
		private void RefreshCrossDay()
		{
			if (this.AnniversaryData != null && !this.AnniversaryData.IsPreviousProgressFull() && !this.AnniversaryData.IsCurrentProgressFull())
			{
				ActivityController.Instance.ShowActivityRefreshAndBackToBattleView();
				return;
			}
			this.RefreshWorldProgress();
			this.RefreshWorldProgressRewards();
			this.RefreshPersonalRewards();
			this.RefreshPersonalProgress();
		}

		// Token: 0x06037CDA RID: 228570 RVA: 0x00F9AE1E File Offset: 0x00F9901E
		private void RefreshAnniversaryActivityReward()
		{
			this.RefreshWorldProgressRewards();
			this.RefreshPersonalRewards();
			this.RefreshPersonalProgress();
		}

		// Token: 0x06037CDB RID: 228571 RVA: 0x00F9AE32 File Offset: 0x00F99032
		private void OnCommonItemCountAnyChange(int configId, int count)
		{
			this.RefreshAnniversaryActivityReward();
		}

		// Token: 0x06037CDC RID: 228572 RVA: 0x00F9AE3C File Offset: 0x00F9903C
		private void OnRefreshActivityRedDot(int id)
		{
			if (id == 108400002)
			{
				this.RefreshTimeMachineRedDot();
				return;
			}
			foreach (KeyValuePair<EAnniversarySubId, AnniversaryActivityEnterItem> keyValuePair in this.ActivityEnterItemMap)
			{
				AnniversaryEntrance? anniversaryEntranceById = AnniversaryActivityConfig.Instance.GetAnniversaryEntranceById((int)keyValuePair.Key);
				if (anniversaryEntranceById != null && anniversaryEntranceById.Value.ActivityId == id)
				{
					AnniversaryActivityEnterItem value = keyValuePair.Value;
					if (value != null)
					{
						value.RefreshRedDotItem();
					}
					AnniversaryActivityEnterItem value2 = keyValuePair.Value;
					if (value2 != null)
					{
						value2.RefreshFinished();
					}
				}
			}
		}

		// Token: 0x06037CDD RID: 228573 RVA: 0x00F9AEE8 File Offset: 0x00F990E8
		private void ClickWorldRewardItem(int id)
		{
			AnniversaryActivityData anniversaryData = this.AnniversaryData;
			List<int> list = (anniversaryData != null) ? anniversaryData.GetWorldCanReceiveRewardIds() : null;
			if (list != null && list.Contains(id))
			{
				if (this.AnniversaryData != null)
				{
					AnniversaryActivityController.Instance.RequestThemeWorldScore(this.AnniversaryData);
					return;
				}
			}
			else
			{
				WorldProgressCurve? worldProgressCurveById = AnniversaryActivityConfig.Instance.GetWorldProgressCurveById(id);
				if (worldProgressCurveById != null)
				{
					this.OpenRewardPreviewView(worldProgressCurveById.Value.MotorPreviewId, worldProgressCurveById.Value.DropId);
				}
			}
		}

		// Token: 0x06037CDE RID: 228574 RVA: 0x00F9AF66 File Offset: 0x00F99166
		private void OpenRewardPreviewView(int motorPreviewId, int dropId)
		{
			if (motorPreviewId <= 0)
			{
				if (dropId > 0)
				{
					this.OpenDropRewardItemTips(dropId);
				}
				return;
			}
			MotorcycleDiyController instance = MotorcycleDiyController.Instance;
			if (instance == null)
			{
				return;
			}
			instance.OpenMotorGeneralPreviewView(motorPreviewId);
		}

		// Token: 0x06037CDF RID: 228575 RVA: 0x00F9AF88 File Offset: 0x00F99188
		private void ClickSubEnter(EAnniversarySubId id)
		{
			if (this.AnniversaryData == null)
			{
				return;
			}
			AnniversarySubActivityDataBase targetSubActivityData = this.AnniversaryData.GetTargetSubActivityData(id);
			if (targetSubActivityData == null)
			{
				return;
			}
			EAnniversaryActivityState currentState = targetSubActivityData.GetCurrentState();
			if (currentState == EAnniversaryActivityState.Lock)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("Activity_Anniversary2_Lock", Array.Empty<object>());
				return;
			}
			if (currentState == EAnniversaryActivityState.Close)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("Activity_Anniversary2_Finish", Array.Empty<object>());
				return;
			}
			targetSubActivityData.FirstClickOpenView();
		}

		// Token: 0x06037CE0 RID: 228576 RVA: 0x00F9AFF0 File Offset: 0x00F991F0
		private void RefreshTaskItemLayout()
		{
			if (this.AnniversaryData == null)
			{
				return;
			}
			List<AnniversarySubActivityDataBase> list = new List<AnniversarySubActivityDataBase>();
			for (int i = 1; i <= 4; i++)
			{
				AnniversarySubActivityDataBase targetSubActivityData = this.AnniversaryData.GetTargetSubActivityData((EAnniversarySubId)i);
				if (targetSubActivityData != null)
				{
					list.Add(targetSubActivityData);
				}
			}
			GenericLayout<AnniversaryEnterRewardProgressItem, AnniversarySubActivityDataBase> rewardProgressItemLayout = this.RewardProgressItemLayout;
			if (rewardProgressItemLayout == null)
			{
				return;
			}
			rewardProgressItemLayout.RefreshByData(list, null, false);
		}

		// Token: 0x06037CE1 RID: 228577 RVA: 0x00F9B044 File Offset: 0x00F99244
		private void RefreshTimeMachineRedDot()
		{
			ActivityBaseData activityById = ActivityModel.Instance.GetActivityById(108400002);
			UUIItem item = base.GetItem(26);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(activityById != null && activityById.RedPointShowState);
		}

		// Token: 0x0401D715 RID: 120597
		private const int MAX_WORLD_REWARD_COUNT = 3;

		// Token: 0x0401D716 RID: 120598
		private const int MAX_SUB_ACTIVITY_ENTER_COUNT = 4;

		// Token: 0x0401D717 RID: 120599
		private const string LOOP_ANNIVERSARY_ACTIVITY_BGM = "map_huodong_2ndanni_main";

		// Token: 0x0401D718 RID: 120600
		private const float WORLD_PROGRESS_TEXT_TWEEN_DURATION = 1.25f;

		// Token: 0x0401D719 RID: 120601
		[Nullable(2)]
		protected AnniversaryActivityData AnniversaryData;

		// Token: 0x0401D71A RID: 120602
		private readonly List<AnniversaryWorldRewardItem> WorldRewardItems = new List<AnniversaryWorldRewardItem>();

		// Token: 0x0401D71B RID: 120603
		private readonly Dictionary<EAnniversarySubId, AnniversaryActivityEnterItem> ActivityEnterItemMap = new Dictionary<EAnniversarySubId, AnniversaryActivityEnterItem>();

		// Token: 0x0401D71C RID: 120604
		private readonly FName ParameterName = new FName("percent");

		// Token: 0x0401D71D RID: 120605
		private readonly FRotator OpenRotation = new FRotator(0f, 180f, 0f);

		// Token: 0x0401D71E RID: 120606
		private readonly FRotator CloseRotation = new FRotator(0f, 0f, 0f);

		// Token: 0x0401D71F RID: 120607
		private bool ShowRewardProgressDisplay;

		// Token: 0x0401D720 RID: 120608
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<AnniversaryPersonalRewardItem, AnniversaryPersonalRewardItemData> PersonalRewardLayout;

		// Token: 0x0401D721 RID: 120609
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<AnniversaryEnterRewardProgressItem, AnniversarySubActivityDataBase> RewardProgressItemLayout;

		// Token: 0x0401D722 RID: 120610
		[Nullable(2)]
		private AnniversaryPersonalRewardItem LastPersonalRewardDisplay;

		// Token: 0x0401D723 RID: 120611
		private readonly LguiFloatTween WorldProgressTextTween = new LguiFloatTween();

		// Token: 0x0401D724 RID: 120612
		private bool WorldProgressStartSequenceClosed;

		// Token: 0x0401D725 RID: 120613
		[TupleElementNames(new string[]
		{
			"StartPercent",
			"EndPercent"
		})]
		[Nullable(0)]
		private ValueTuple<float, float>? PendingWorldProgressTextTween;

		// Token: 0x0401D726 RID: 120614
		private int LoopBgmHandle;
	}
}
