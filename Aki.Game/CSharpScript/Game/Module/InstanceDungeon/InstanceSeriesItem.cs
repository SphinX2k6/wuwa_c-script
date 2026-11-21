using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.Mowing;
using CSharpScript.Game.Module.InstanceDungeon.Define;
using CSharpScript.Game.Module.InstanceDungeon.ExchangeReward;
using CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonViewModel;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.InstanceDungeon
{
	// Token: 0x0200483E RID: 18494
	[NullableContext(2)]
	[Nullable(0)]
	public class InstanceSeriesItem : UiPanelBase
	{
		// Token: 0x0602E79A RID: 190362 RVA: 0x00CF7A88 File Offset: 0x00CF5C88
		protected unsafe override void OnRegisterComponent()
		{
			this.ParentModel = (this.OpenParam as InstanceDungeonViewModelBase);
			int num = 11;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickExtendToggle));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602E79B RID: 190363 RVA: 0x00CF7C6C File Offset: 0x00CF5E6C
		protected override void OnStart()
		{
			EventSystem.Instance.Add<int>(EEventName.OnChallengeInstanceRedDot, new Action<int>(this.OnChallengeInstanceRedDot));
			this.ExtendToggle = base.GetExtendToggle(0);
			this.ExtendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			this.ExtendToggle.OnStateChange.Add(new Action<EToggleState>(this.OnToggleStateChange));
			this.TimerHandle = TimerSystem.GameplayTimeInstance.Forever(delegate(float _)
			{
				this.OnTimer();
			}, (float)TimeUtil.Instance.InverseMillisecond, 1f, null, null, true);
		}

		// Token: 0x0602E79C RID: 190364 RVA: 0x00CF7CFD File Offset: 0x00CF5EFD
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove<int>(EEventName.OnChallengeInstanceRedDot, new Action<int>(this.OnChallengeInstanceRedDot));
			if (this.TimerHandle != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
				this.TimerHandle = null;
			}
		}

		// Token: 0x0602E79D RID: 190365 RVA: 0x00CF7D3B File Offset: 0x00CF5F3B
		private void OnTimer()
		{
			if (!this.NeedOnTimer)
			{
				return;
			}
			Action timerRefreshFunction = this.TimerRefreshFunction;
			if (timerRefreshFunction == null)
			{
				return;
			}
			timerRefreshFunction();
		}

		// Token: 0x0602E79E RID: 190366 RVA: 0x00CF7D56 File Offset: 0x00CF5F56
		[NullableContext(1)]
		public UUIText GetTitleText()
		{
			return base.GetText(3);
		}

		// Token: 0x0602E79F RID: 190367 RVA: 0x00CF7D60 File Offset: 0x00CF5F60
		[NullableContext(1)]
		private void RefreshSubTitle(Dictionary<int, string> subTitle)
		{
			int? num = null;
			string textStringId = null;
			foreach (KeyValuePair<int, string> keyValuePair in subTitle)
			{
				int num2;
				string text;
				keyValuePair.Deconstruct(out num2, out text);
				int value = num2;
				string text2 = text;
				num = new int?(value);
				textStringId = text2;
			}
			if (num.GetValueOrDefault() == 1)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(8), textStringId, Array.Empty<object>());
				return;
			}
			if (num.GetValueOrDefault() == 2)
			{
				int recommendLevel = InstanceDungeonConfig.Instance.GetRecommendLevel(this.TitleOrInstanceId, WorldLevelModel.Instance.CurWorldLevel);
				LguiUtil.Instance.SetLocalTextNew(base.GetText(8), "RecommendLevel", new <>z__ReadOnlySingleElementList<object>(recommendLevel));
				return;
			}
			if (num.GetValueOrDefault() == 3 && !string.IsNullOrEmpty(this.SubtitleTextId))
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(8), this.SubtitleTextId, this.SubtitleTextArgs ?? Array.Empty<string>());
			}
		}

		// Token: 0x0602E7A0 RID: 190368 RVA: 0x00CF7E74 File Offset: 0x00CF6074
		private void RefreshByTowerDefense()
		{
			if (TowerDefenseController.Instance.CheckIsInstanceUnlock(this.TitleOrInstanceId))
			{
				bool flag = TowerDefenseController.Instance.CheckInstancePassedByInstanceId(this.TitleOrInstanceId);
				if (TowerDefenseController.Instance.CheckIsChallengeInstanceByInstanceId(this.TitleOrInstanceId))
				{
					string passTimeContentByInstanceId = TowerDefenseController.Instance.GetPassTimeContentByInstanceId(this.TitleOrInstanceId);
					if (flag)
					{
						LguiUtil.Instance.SetLocalTextNew(base.GetText(8), "TowerDefenceBestTime", new <>z__ReadOnlySingleElementList<object>(passTimeContentByInstanceId));
					}
					else
					{
						LguiUtil.Instance.SetLocalTextNew(base.GetText(8), "Text_NotFinished_Text", Array.Empty<object>());
					}
				}
				else
				{
					int recordByInstanceId = TowerDefenseController.Instance.GetRecordByInstanceId(this.TitleOrInstanceId);
					LguiUtil.Instance.SetLocalTextNew(base.GetText(8), "TowerDefence_GPint", new <>z__ReadOnlySingleElementList<object>(recordByInstanceId));
				}
				base.GetItem(6).SetUIActive(flag);
				base.GetItem(7).SetUIActive(false);
				return;
			}
			string text = TowerDefenseController.Instance.BuildInstanceCountDownText(this.TitleOrInstanceId);
			if (!string.IsNullOrEmpty(text))
			{
				UUIText text2 = base.GetText(8);
				if (text2 != null)
				{
					text2.SetText(text, true);
				}
			}
			base.GetItem(7).SetUIActive(true);
			base.GetItem(6).SetUIActive(false);
		}

		// Token: 0x0602E7A1 RID: 190369 RVA: 0x00CF7F9C File Offset: 0x00CF619C
		private bool RefreshInOnlyOneGrid(bool isSelect)
		{
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(this.TitleOrInstanceId);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), config.Value.MapName, Array.Empty<object>());
			if (isSelect && this.OnClickCallbackOnlyOneGrid != null)
			{
				this.OnClickCallbackOnlyOneGrid(this.TitleOrInstanceId, this.ExtendToggle, this.CurrentData);
			}
			string difficultyIcon = config.Value.DifficultyIcon;
			UUISprite sprite = base.GetSprite(2);
			if (sprite != null)
			{
				sprite.SetUIActive(true);
			}
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				item.SetUIActive(true);
			}
			base.SetTextureByPath(difficultyIcon, base.GetTexture(2), null, null);
			UUIText text = base.GetText(8);
			if (text != null)
			{
				text.SetUIActive(true);
			}
			Dictionary<int, string> dictionary = config.Value.SubTitle();
			if (dictionary != null && dictionary.Count > 0)
			{
				this.RefreshSubTitle(dictionary);
			}
			else
			{
				if (TowerDefenseController.Instance.CheckInUiFlow())
				{
					this.RefreshByTowerDefense();
					return false;
				}
				LguiUtil.Instance.TrySetLocalTextNew(base.GetText(8), (config != null) ? config.GetValueOrDefault().SubInstanceTitle : null, Array.Empty<object>());
			}
			return true;
		}

		// Token: 0x0602E7A2 RID: 190370 RVA: 0x00CF80D4 File Offset: 0x00CF62D4
		private void RefreshNotOnlyOneGrid()
		{
			InstanceDungeonTitle? titleConfig = InstanceDungeonConfig.Instance.GetTitleConfig(this.TitleOrInstanceId);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), titleConfig.Value.CommonText, Array.Empty<object>());
			UUIText text = base.GetText(8);
			if (text != null)
			{
				text.SetUIActive(false);
			}
			string iconTexture = titleConfig.Value.IconTexture;
			if (!string.IsNullOrEmpty(iconTexture))
			{
				UUISprite sprite = base.GetSprite(2);
				if (sprite != null)
				{
					sprite.SetUIActive(true);
				}
				UUIItem item = base.GetItem(1);
				if (item != null)
				{
					item.SetUIActive(true);
				}
				base.SetTextureByPath(iconTexture, base.GetTexture(2), null, null);
			}
		}

		// Token: 0x0602E7A3 RID: 190371 RVA: 0x00CF8180 File Offset: 0x00CF6380
		public void Update(int data, bool isSelect, bool isOnlyOneGrid = false)
		{
			this.TitleOrInstanceId = data;
			this.IsSelect = isSelect;
			this.IsOnlyOneGrid = isOnlyOneGrid;
			this.ExtendToggle.SetToggleStateForce(isSelect ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
			UUIItem item = base.GetItem(5);
			if (item != null)
			{
				item.SetUIActive(isSelect);
			}
			UUISprite sprite = base.GetSprite(2);
			if (sprite != null)
			{
				sprite.SetUIActive(false);
			}
			base.TrySetTextureByPath(this.IconRightPath, base.GetTexture(10), null, null);
			UUIItem item2 = base.GetItem(1);
			if (item2 != null)
			{
				item2.SetUIActive(false);
			}
			this.RefreshRedDot();
			if (!isOnlyOneGrid)
			{
				this.RefreshNotOnlyOneGrid();
			}
			else if (!this.RefreshInOnlyOneGrid(isSelect))
			{
				return;
			}
			this.NeedOnTimer = this.CheckNeedOnTimer(this.TitleOrInstanceId);
			if (this.NeedOnTimer)
			{
				Action timerRefreshFunction = this.TimerRefreshFunction;
				if (timerRefreshFunction != null)
				{
					timerRefreshFunction();
				}
			}
			this.UpdateLockOrFirstReward(isOnlyOneGrid);
			this.UpdateFinishState();
		}

		// Token: 0x0602E7A4 RID: 190372 RVA: 0x00CF8261 File Offset: 0x00CF6461
		[NullableContext(1)]
		public void UpdateSubtitleByText(string text)
		{
			UUIText text2 = base.GetText(8);
			if (text2 == null)
			{
				return;
			}
			text2.SetText(text, true);
		}

		// Token: 0x0602E7A5 RID: 190373 RVA: 0x00CF8276 File Offset: 0x00CF6476
		public void RefreshSubtitleByIdAndArgs()
		{
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(8), this.SubtitleTextId, this.SubtitleTextArgs ?? Array.Empty<string>());
		}

		// Token: 0x0602E7A6 RID: 190374 RVA: 0x00CF82A0 File Offset: 0x00CF64A0
		private bool CheckNeedOnTimer(int id)
		{
			if (!ActivityMowingController.Instance.IsMowingInstanceDungeon(id))
			{
				return false;
			}
			ActivityMowingData mowingActivityData = ActivityMowingController.Instance.GetMowingActivityData();
			if (mowingActivityData == null)
			{
				return false;
			}
			this.TimerRefreshFunction = new Action(this.RefreshMowingInstance);
			bool activityLevelUnlockState = mowingActivityData.GetActivityLevelUnlockState(id);
			if (activityLevelUnlockState)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(8), "ActivityMowing_Point", new <>z__ReadOnlySingleElementList<object>(mowingActivityData.GetLevelMaxPoint(id)));
			}
			return !activityLevelUnlockState;
		}

		// Token: 0x0602E7A7 RID: 190375 RVA: 0x00CF8314 File Offset: 0x00CF6514
		private void RefreshMowingInstance()
		{
			ActivityMowingData mowingActivityData = ActivityMowingController.Instance.GetMowingActivityData();
			if (mowingActivityData == null)
			{
				return;
			}
			string activityLevelCountdownText = mowingActivityData.GetActivityLevelCountdownText(this.TitleOrInstanceId);
			base.GetText(8).SetText(activityLevelCountdownText, true);
			if (string.IsNullOrEmpty(activityLevelCountdownText))
			{
				this.NeedOnTimer = false;
				this.Update(this.TitleOrInstanceId, this.IsSelect, this.IsOnlyOneGrid);
			}
		}

		// Token: 0x0602E7A8 RID: 190376 RVA: 0x00CF8372 File Offset: 0x00CF6572
		private void UpdateFinishState()
		{
			if (this.HasOverrideFinishState)
			{
				base.GetItem(6).SetUIActive(this.OverrideFinishState);
			}
		}

		// Token: 0x0602E7A9 RID: 190377 RVA: 0x00CF8390 File Offset: 0x00CF6590
		private void OnChallengeInstanceRedDot(int instanceId)
		{
			List<int> list;
			if (!this.ParentModel.InstanceByTitleMap.TryGetValue(this.TitleOrInstanceId, out list))
			{
				return;
			}
			if (!list.Contains(instanceId))
			{
				return;
			}
			this.RefreshRedDot();
		}

		// Token: 0x0602E7AA RID: 190378 RVA: 0x00CF83C8 File Offset: 0x00CF65C8
		[NullableContext(1)]
		public void BindClickCallback(Action<int, UUIExtendToggle, bool> onClickCallback)
		{
			this.OnClickCallback = onClickCallback;
		}

		// Token: 0x0602E7AB RID: 190379 RVA: 0x00CF83D1 File Offset: 0x00CF65D1
		public void BindClickCallbackOnlyOneGrid([Nullable(new byte[]
		{
			1,
			1,
			2
		})] Action<int, UUIExtendToggle, InstanceDetectionDynamicData> onClickCallback)
		{
			this.OnClickCallbackOnlyOneGrid = onClickCallback;
		}

		// Token: 0x0602E7AC RID: 190380 RVA: 0x00CF83DA File Offset: 0x00CF65DA
		[NullableContext(1)]
		public void BindCanShowRedDot(Func<int, bool> canShowRedDot)
		{
			this.CanShowRedDot = canShowRedDot;
		}

		// Token: 0x0602E7AD RID: 190381 RVA: 0x00CF83E4 File Offset: 0x00CF65E4
		private void OnClickExtendToggle(EToggleState state)
		{
			if (state != EToggleState.ETT_Checked)
			{
				return;
			}
			this.IsSelect = true;
			if (this.OnClickCallback != null)
			{
				this.OnClickCallback(this.TitleOrInstanceId, this.ExtendToggle, this.IsSelect);
			}
			if (this.OnClickCallbackOnlyOneGrid != null)
			{
				this.OnClickCallbackOnlyOneGrid(this.TitleOrInstanceId, this.ExtendToggle, this.CurrentData);
			}
		}

		// Token: 0x0602E7AE RID: 190382 RVA: 0x00CF8448 File Offset: 0x00CF6648
		private void UpdateLockOrFirstReward(bool isOnlyOneGrid)
		{
			bool instanceItemLockStateGetter = InstanceDungeonEntranceController.Instance.GetInstanceItemLockStateGetter(this.TitleOrInstanceId);
			base.GetItem(4).SetUIActive(!isOnlyOneGrid);
			if (!isOnlyOneGrid)
			{
				return;
			}
			if (instanceItemLockStateGetter)
			{
				base.GetItem(7).SetUIActive(true);
				base.GetItem(6).SetUIActive(false);
				return;
			}
			if (ExchangeRewardModel.Instance.IsFinishInstance(this.TitleOrInstanceId))
			{
				base.GetItem(7).SetUIActive(false);
				base.GetItem(6).SetUIActive(true);
				return;
			}
			base.GetItem(7).SetUIActive(false);
			base.GetItem(6).SetUIActive(false);
		}

		// Token: 0x0602E7AF RID: 190383 RVA: 0x00CF84E0 File Offset: 0x00CF66E0
		private void OnToggleStateChange(EToggleState state)
		{
			bool flag = state == EToggleState.ETT_Checked;
			this.IsSelect = flag;
			UUIItem item = base.GetItem(5);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(flag);
		}

		// Token: 0x0602E7B0 RID: 190384 RVA: 0x00CF850C File Offset: 0x00CF670C
		private void RefreshRedDot()
		{
			if (this.CanShowRedDot != null && this.CanShowRedDot(this.TitleOrInstanceId))
			{
				UUIItem item = base.GetItem(9);
				if (item == null)
				{
					return;
				}
				item.SetUIActive(true);
				return;
			}
			else
			{
				UUIItem item2 = base.GetItem(9);
				if (item2 == null)
				{
					return;
				}
				item2.SetUIActive(false);
				return;
			}
		}

		// Token: 0x04018BF6 RID: 101366
		private UUIExtendToggle ExtendToggle;

		// Token: 0x04018BF7 RID: 101367
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<int, UUIExtendToggle, bool> OnClickCallback;

		// Token: 0x04018BF8 RID: 101368
		[Nullable(new byte[]
		{
			2,
			1,
			2
		})]
		private Action<int, UUIExtendToggle, InstanceDetectionDynamicData> OnClickCallbackOnlyOneGrid;

		// Token: 0x04018BF9 RID: 101369
		private Func<int, bool> CanShowRedDot;

		// Token: 0x04018BFA RID: 101370
		private TimerHandle TimerHandle;

		// Token: 0x04018BFB RID: 101371
		private int TitleOrInstanceId;

		// Token: 0x04018BFC RID: 101372
		private bool IsSelect;

		// Token: 0x04018BFD RID: 101373
		private bool IsOnlyOneGrid;

		// Token: 0x04018BFE RID: 101374
		private Action TimerRefreshFunction;

		// Token: 0x04018BFF RID: 101375
		private bool NeedOnTimer;

		// Token: 0x04018C00 RID: 101376
		public InstanceDetectionDynamicData CurrentData;

		// Token: 0x04018C01 RID: 101377
		public string SubtitleTextId;

		// Token: 0x04018C02 RID: 101378
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public string[] SubtitleTextArgs;

		// Token: 0x04018C03 RID: 101379
		public bool HasOverrideFinishState;

		// Token: 0x04018C04 RID: 101380
		public bool OverrideFinishState;

		// Token: 0x04018C05 RID: 101381
		public string IconRightPath;

		// Token: 0x04018C06 RID: 101382
		private InstanceDungeonViewModelBase ParentModel;
	}
}
