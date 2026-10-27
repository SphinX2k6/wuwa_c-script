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
	// Token: 0x02005866 RID: 22630
	[NullableContext(2)]
	[Nullable(0)]
	public class InstanceSeriesItem : UiPanelBase
	{
		// Token: 0x0603987D RID: 235645 RVA: 0x00DA8D60 File Offset: 0x00DA6F60
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

		// Token: 0x0603987E RID: 235646 RVA: 0x00DA8F44 File Offset: 0x00DA7144
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

		// Token: 0x0603987F RID: 235647 RVA: 0x00DA8FD5 File Offset: 0x00DA71D5
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove<int>(EEventName.OnChallengeInstanceRedDot, new Action<int>(this.OnChallengeInstanceRedDot));
			if (this.TimerHandle != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
				this.TimerHandle = null;
			}
		}

		// Token: 0x06039880 RID: 235648 RVA: 0x00DA9013 File Offset: 0x00DA7213
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

		// Token: 0x06039881 RID: 235649 RVA: 0x00DA902E File Offset: 0x00DA722E
		[NullableContext(1)]
		public UUIText GetTitleText()
		{
			return base.GetText(3);
		}

		// Token: 0x06039882 RID: 235650 RVA: 0x00DA9038 File Offset: 0x00DA7238
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

		// Token: 0x06039883 RID: 235651 RVA: 0x00DA914C File Offset: 0x00DA734C
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

		// Token: 0x06039884 RID: 235652 RVA: 0x00DA9274 File Offset: 0x00DA7474
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

		// Token: 0x06039885 RID: 235653 RVA: 0x00DA93AC File Offset: 0x00DA75AC
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

		// Token: 0x06039886 RID: 235654 RVA: 0x00DA9458 File Offset: 0x00DA7658
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

		// Token: 0x06039887 RID: 235655 RVA: 0x00DA9539 File Offset: 0x00DA7739
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

		// Token: 0x06039888 RID: 235656 RVA: 0x00DA954E File Offset: 0x00DA774E
		public void RefreshSubtitleByIdAndArgs()
		{
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(8), this.SubtitleTextId, this.SubtitleTextArgs ?? Array.Empty<string>());
		}

		// Token: 0x06039889 RID: 235657 RVA: 0x00DA9578 File Offset: 0x00DA7778
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

		// Token: 0x0603988A RID: 235658 RVA: 0x00DA95EC File Offset: 0x00DA77EC
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

		// Token: 0x0603988B RID: 235659 RVA: 0x00DA964A File Offset: 0x00DA784A
		private void UpdateFinishState()
		{
			if (this.HasOverrideFinishState)
			{
				base.GetItem(6).SetUIActive(this.OverrideFinishState);
			}
		}

		// Token: 0x0603988C RID: 235660 RVA: 0x00DA9668 File Offset: 0x00DA7868
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

		// Token: 0x0603988D RID: 235661 RVA: 0x00DA96A0 File Offset: 0x00DA78A0
		[NullableContext(1)]
		public void BindClickCallback(Action<int, UUIExtendToggle, bool> onClickCallback)
		{
			this.OnClickCallback = onClickCallback;
		}

		// Token: 0x0603988E RID: 235662 RVA: 0x00DA96A9 File Offset: 0x00DA78A9
		public void BindClickCallbackOnlyOneGrid([Nullable(new byte[]
		{
			1,
			1,
			2
		})] Action<int, UUIExtendToggle, InstanceDetectionDynamicData> onClickCallback)
		{
			this.OnClickCallbackOnlyOneGrid = onClickCallback;
		}

		// Token: 0x0603988F RID: 235663 RVA: 0x00DA96B2 File Offset: 0x00DA78B2
		[NullableContext(1)]
		public void BindCanShowRedDot(Func<int, bool> canShowRedDot)
		{
			this.CanShowRedDot = canShowRedDot;
		}

		// Token: 0x06039890 RID: 235664 RVA: 0x00DA96BC File Offset: 0x00DA78BC
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

		// Token: 0x06039891 RID: 235665 RVA: 0x00DA9720 File Offset: 0x00DA7920
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

		// Token: 0x06039892 RID: 235666 RVA: 0x00DA97B8 File Offset: 0x00DA79B8
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

		// Token: 0x06039893 RID: 235667 RVA: 0x00DA97E4 File Offset: 0x00DA79E4
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

		// Token: 0x0401E159 RID: 123225
		private UUIExtendToggle ExtendToggle;

		// Token: 0x0401E15A RID: 123226
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<int, UUIExtendToggle, bool> OnClickCallback;

		// Token: 0x0401E15B RID: 123227
		[Nullable(new byte[]
		{
			2,
			1,
			2
		})]
		private Action<int, UUIExtendToggle, InstanceDetectionDynamicData> OnClickCallbackOnlyOneGrid;

		// Token: 0x0401E15C RID: 123228
		private Func<int, bool> CanShowRedDot;

		// Token: 0x0401E15D RID: 123229
		private TimerHandle TimerHandle;

		// Token: 0x0401E15E RID: 123230
		private int TitleOrInstanceId;

		// Token: 0x0401E15F RID: 123231
		private bool IsSelect;

		// Token: 0x0401E160 RID: 123232
		private bool IsOnlyOneGrid;

		// Token: 0x0401E161 RID: 123233
		private Action TimerRefreshFunction;

		// Token: 0x0401E162 RID: 123234
		private bool NeedOnTimer;

		// Token: 0x0401E163 RID: 123235
		public InstanceDetectionDynamicData CurrentData;

		// Token: 0x0401E164 RID: 123236
		public string SubtitleTextId;

		// Token: 0x0401E165 RID: 123237
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public string[] SubtitleTextArgs;

		// Token: 0x0401E166 RID: 123238
		public bool HasOverrideFinishState;

		// Token: 0x0401E167 RID: 123239
		public bool OverrideFinishState;

		// Token: 0x0401E168 RID: 123240
		public string IconRightPath;

		// Token: 0x0401E169 RID: 123241
		private InstanceDungeonViewModelBase ParentModel;
	}
}
