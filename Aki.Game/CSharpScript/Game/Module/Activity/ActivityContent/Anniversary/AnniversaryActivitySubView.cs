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
	// Token: 0x02006915 RID: 26901
	[NullableContext(1)]
	[Nullable(0)]
	public class AnniversaryActivitySubView : ActivitySubViewBase
	{
		// Token: 0x0604315B RID: 274779 RVA: 0x010586F0 File Offset: 0x010568F0
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

		// Token: 0x0604315C RID: 274780 RVA: 0x010589DC File Offset: 0x01056BDC
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnAnniversaryActivityRewardUpdate, new Action(this.RefreshAnniversaryActivityReward));
			EventSystem.Instance.Add<int, int>(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
			EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshActivityRedDot));
			EventSystem.Instance.Add(EEventName.CrossDay, new Action(this.RefreshCrossDay));
		}

		// Token: 0x0604315D RID: 274781 RVA: 0x01058A5C File Offset: 0x01056C5C
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnAnniversaryActivityRewardUpdate, new Action(this.RefreshAnniversaryActivityReward));
			EventSystem.Instance.Remove(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
			EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshActivityRedDot));
			EventSystem.Instance.Remove(EEventName.CrossDay, new Action(this.RefreshCrossDay));
		}

		// Token: 0x0604315E RID: 274782 RVA: 0x01058AD9 File Offset: 0x01056CD9
		protected override void OnSetData()
		{
			this.AnniversaryData = (this.ActivityBaseData as AnniversaryActivityData);
			AnniversaryActivityController.Instance.SetCheckedOpenActivity(false);
		}

		// Token: 0x0604315F RID: 274783 RVA: 0x01058AF7 File Offset: 0x01056CF7
		protected override void OnStart()
		{
			this.RefreshTitleDeco();
		}

		// Token: 0x06043160 RID: 274784 RVA: 0x01058B00 File Offset: 0x01056D00
		protected override UniTask OnBeforeShowSelfAsync()
		{
			AnniversaryActivitySubView.<OnBeforeShowSelfAsync>d__23 <OnBeforeShowSelfAsync>d__;
			<OnBeforeShowSelfAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeShowSelfAsync>d__.<>4__this = this;
			<OnBeforeShowSelfAsync>d__.<>1__state = -1;
			<OnBeforeShowSelfAsync>d__.<>t__builder.Start<AnniversaryActivitySubView.<OnBeforeShowSelfAsync>d__23>(ref <OnBeforeShowSelfAsync>d__);
			return <OnBeforeShowSelfAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06043161 RID: 274785 RVA: 0x01058B44 File Offset: 0x01056D44
		protected override UniTask OnBeforeHideSelfAsync()
		{
			AnniversaryActivitySubView.<OnBeforeHideSelfAsync>d__24 <OnBeforeHideSelfAsync>d__;
			<OnBeforeHideSelfAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeHideSelfAsync>d__.<>4__this = this;
			<OnBeforeHideSelfAsync>d__.<>1__state = -1;
			<OnBeforeHideSelfAsync>d__.<>t__builder.Start<AnniversaryActivitySubView.<OnBeforeHideSelfAsync>d__24>(ref <OnBeforeHideSelfAsync>d__);
			return <OnBeforeHideSelfAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06043162 RID: 274786 RVA: 0x01058B87 File Offset: 0x01056D87
		protected override void OnBeforeDestroy()
		{
			this.WorldProgressTextTween.Destroy();
		}

		// Token: 0x06043163 RID: 274787 RVA: 0x01058B94 File Offset: 0x01056D94
		protected override UniTask OnBeforeStartAsync()
		{
			AnniversaryActivitySubView.<OnBeforeStartAsync>d__26 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<AnniversaryActivitySubView.<OnBeforeStartAsync>d__26>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06043164 RID: 274788 RVA: 0x01058BD8 File Offset: 0x01056DD8
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

		// Token: 0x06043165 RID: 274789 RVA: 0x01058C7C File Offset: 0x01056E7C
		protected override void OnSequenceClose(string sequenceName)
		{
			if (sequenceName != "Start")
			{
				return;
			}
			this.WorldProgressStartSequenceClosed = true;
			this.TryPlayPendingWorldProgressTextTween();
		}

		// Token: 0x06043166 RID: 274790 RVA: 0x01058C99 File Offset: 0x01056E99
		private AnniversaryPersonalRewardItem CreateRewardItem()
		{
			AnniversaryPersonalRewardItem anniversaryPersonalRewardItem = new AnniversaryPersonalRewardItem();
			anniversaryPersonalRewardItem.SetClickCallback(new Action<int>(this.OnClickRewardItem));
			return anniversaryPersonalRewardItem;
		}

		// Token: 0x06043167 RID: 274791 RVA: 0x01058CB2 File Offset: 0x01056EB2
		private AnniversaryEnterRewardProgressItem CreateTaskItem()
		{
			return new AnniversaryEnterRewardProgressItem();
		}

		// Token: 0x06043168 RID: 274792 RVA: 0x01058CBC File Offset: 0x01056EBC
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

		// Token: 0x06043169 RID: 274793 RVA: 0x01058D10 File Offset: 0x01056F10
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

		// Token: 0x0604316A RID: 274794 RVA: 0x01058D58 File Offset: 0x01056F58
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

		// Token: 0x0604316B RID: 274795 RVA: 0x01058DAC File Offset: 0x01056FAC
		private UniTask InitPersonRewardItemAsync()
		{
			AnniversaryActivitySubView.<InitPersonRewardItemAsync>d__34 <InitPersonRewardItemAsync>d__;
			<InitPersonRewardItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitPersonRewardItemAsync>d__.<>4__this = this;
			<InitPersonRewardItemAsync>d__.<>1__state = -1;
			<InitPersonRewardItemAsync>d__.<>t__builder.Start<AnniversaryActivitySubView.<InitPersonRewardItemAsync>d__34>(ref <InitPersonRewardItemAsync>d__);
			return <InitPersonRewardItemAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0604316C RID: 274796 RVA: 0x01058DEF File Offset: 0x01056FEF
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

		// Token: 0x0604316D RID: 274797 RVA: 0x01058E20 File Offset: 0x01057020
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

		// Token: 0x0604316E RID: 274798 RVA: 0x01058E8C File Offset: 0x0105708C
		protected override void OnTimer(float gap)
		{
			this.RefreshActivityTime();
			this.RefreshSubActivityTips();
		}

		// Token: 0x0604316F RID: 274799 RVA: 0x01058E9C File Offset: 0x0105709C
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

		// Token: 0x06043170 RID: 274800 RVA: 0x01058F0C File Offset: 0x0105710C
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
						ItemController.Instance.OpenItemTipsByItemId(key, true, null);
					}
				}
			}
		}

		// Token: 0x06043171 RID: 274801 RVA: 0x01058FBC File Offset: 0x010571BC
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

		// Token: 0x06043172 RID: 274802 RVA: 0x0105900B File Offset: 0x0105720B
		private void BindWorldProgressTextTween()
		{
			this.WorldProgressTextTween.BindUpdateTween(new Action<float>(this.OnWorldProgressTextTweenUpdate));
			this.WorldProgressTextTween.BindCompleteTween(new Action(this.OnWorldProgressTextTweenComplete));
		}

		// Token: 0x06043173 RID: 274803 RVA: 0x0105903B File Offset: 0x0105723B
		private void OnWorldProgressTextTweenUpdate(float value)
		{
			this.SetWorldProgressTextPercentRaw(value);
		}

		// Token: 0x06043174 RID: 274804 RVA: 0x01059044 File Offset: 0x01057244
		private void OnWorldProgressTextTweenComplete()
		{
			AnniversaryActivityData anniversaryData = this.AnniversaryData;
			if (anniversaryData == null)
			{
				return;
			}
			anniversaryData.MarkWorldProgressNumberTweenPlayedToday();
		}

		// Token: 0x06043175 RID: 274805 RVA: 0x01059058 File Offset: 0x01057258
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

		// Token: 0x06043176 RID: 274806 RVA: 0x01059098 File Offset: 0x01057298
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

		// Token: 0x06043177 RID: 274807 RVA: 0x01059124 File Offset: 0x01057324
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

		// Token: 0x06043178 RID: 274808 RVA: 0x010591C8 File Offset: 0x010573C8
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

		// Token: 0x06043179 RID: 274809 RVA: 0x0105937C File Offset: 0x0105757C
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

		// Token: 0x0604317A RID: 274810 RVA: 0x010593B8 File Offset: 0x010575B8
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

		// Token: 0x0604317B RID: 274811 RVA: 0x0105947C File Offset: 0x0105767C
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

		// Token: 0x0604317C RID: 274812 RVA: 0x010595EC File Offset: 0x010577EC
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

		// Token: 0x0604317D RID: 274813 RVA: 0x01059664 File Offset: 0x01057864
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

		// Token: 0x0604317E RID: 274814 RVA: 0x010596CC File Offset: 0x010578CC
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

		// Token: 0x0604317F RID: 274815 RVA: 0x0105971C File Offset: 0x0105791C
		private void OnClickPersonalRewardDisplay()
		{
			this.ShowRewardProgressDisplay = !this.ShowRewardProgressDisplay;
			this.SetVisibleRewardProgressDisplay(this.ShowRewardProgressDisplay);
		}

		// Token: 0x06043180 RID: 274816 RVA: 0x0105973C File Offset: 0x0105793C
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

		// Token: 0x06043181 RID: 274817 RVA: 0x010597A0 File Offset: 0x010579A0
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

		// Token: 0x06043182 RID: 274818 RVA: 0x010597F2 File Offset: 0x010579F2
		private void RefreshAnniversaryActivityReward()
		{
			this.RefreshWorldProgressRewards();
			this.RefreshPersonalRewards();
			this.RefreshPersonalProgress();
		}

		// Token: 0x06043183 RID: 274819 RVA: 0x01059806 File Offset: 0x01057A06
		private void OnCommonItemCountAnyChange(int configId, int count)
		{
			this.RefreshAnniversaryActivityReward();
		}

		// Token: 0x06043184 RID: 274820 RVA: 0x01059810 File Offset: 0x01057A10
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

		// Token: 0x06043185 RID: 274821 RVA: 0x010598BC File Offset: 0x01057ABC
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

		// Token: 0x06043186 RID: 274822 RVA: 0x0105993A File Offset: 0x01057B3A
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

		// Token: 0x06043187 RID: 274823 RVA: 0x0105995C File Offset: 0x01057B5C
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

		// Token: 0x06043188 RID: 274824 RVA: 0x010599C4 File Offset: 0x01057BC4
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

		// Token: 0x06043189 RID: 274825 RVA: 0x01059A18 File Offset: 0x01057C18
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

		// Token: 0x04022EB9 RID: 143033
		private const int MAX_WORLD_REWARD_COUNT = 3;

		// Token: 0x04022EBA RID: 143034
		private const int MAX_SUB_ACTIVITY_ENTER_COUNT = 4;

		// Token: 0x04022EBB RID: 143035
		private const string LOOP_ANNIVERSARY_ACTIVITY_BGM = "map_huodong_2ndanni_main";

		// Token: 0x04022EBC RID: 143036
		private const float WORLD_PROGRESS_TEXT_TWEEN_DURATION = 1.25f;

		// Token: 0x04022EBD RID: 143037
		[Nullable(2)]
		protected AnniversaryActivityData AnniversaryData;

		// Token: 0x04022EBE RID: 143038
		private readonly List<AnniversaryWorldRewardItem> WorldRewardItems = new List<AnniversaryWorldRewardItem>();

		// Token: 0x04022EBF RID: 143039
		private readonly Dictionary<EAnniversarySubId, AnniversaryActivityEnterItem> ActivityEnterItemMap = new Dictionary<EAnniversarySubId, AnniversaryActivityEnterItem>();

		// Token: 0x04022EC0 RID: 143040
		private readonly FName ParameterName = new FName("percent");

		// Token: 0x04022EC1 RID: 143041
		private readonly FRotator OpenRotation = new FRotator(0f, 180f, 0f);

		// Token: 0x04022EC2 RID: 143042
		private readonly FRotator CloseRotation = new FRotator(0f, 0f, 0f);

		// Token: 0x04022EC3 RID: 143043
		private bool ShowRewardProgressDisplay;

		// Token: 0x04022EC4 RID: 143044
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<AnniversaryPersonalRewardItem, AnniversaryPersonalRewardItemData> PersonalRewardLayout;

		// Token: 0x04022EC5 RID: 143045
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<AnniversaryEnterRewardProgressItem, AnniversarySubActivityDataBase> RewardProgressItemLayout;

		// Token: 0x04022EC6 RID: 143046
		[Nullable(2)]
		private AnniversaryPersonalRewardItem LastPersonalRewardDisplay;

		// Token: 0x04022EC7 RID: 143047
		private readonly LguiFloatTween WorldProgressTextTween = new LguiFloatTween();

		// Token: 0x04022EC8 RID: 143048
		private bool WorldProgressStartSequenceClosed;

		// Token: 0x04022EC9 RID: 143049
		[TupleElementNames(new string[]
		{
			"StartPercent",
			"EndPercent"
		})]
		[Nullable(0)]
		private ValueTuple<float, float>? PendingWorldProgressTextTween;

		// Token: 0x04022ECA RID: 143050
		private int LoopBgmHandle;
	}
}
