using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.InstanceDungeon.Define;
using CSharpScript.Game.Ui;
using CSharpScript.Module.InstanceDungeon;
using UnrealEngine;

namespace CSharpScript.Game.Module.InstanceDungeon
{
	// Token: 0x02005875 RID: 22645
	[NullableContext(1)]
	[Nullable(0)]
	public class InstanceDungeonGrid : UiPanelBase
	{
		// Token: 0x060399DE RID: 235998 RVA: 0x00DB132C File Offset: 0x00DAF52C
		public InstanceDungeonGrid(int id, UUIItem uiItem)
		{
			this.InstanceId = id;
		}

		// Token: 0x17008A67 RID: 35431
		// (get) Token: 0x060399DF RID: 235999 RVA: 0x00DB133B File Offset: 0x00DAF53B
		// (set) Token: 0x060399E0 RID: 236000 RVA: 0x00DB1343 File Offset: 0x00DAF543
		public Action<int> ClickCallback
		{
			get
			{
				return this.ClickCallbackInternal;
			}
			set
			{
				this.ClickCallbackInternal = value;
			}
		}

		// Token: 0x060399E1 RID: 236001 RVA: 0x00DB134C File Offset: 0x00DAF54C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 11;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action<EToggleState>(this.OnClickToggle));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060399E2 RID: 236002 RVA: 0x00DB151E File Offset: 0x00DAF71E
		private void OnClickToggle(EToggleState toState)
		{
			if (toState == EToggleState.ETT_Checked)
			{
				this.ClickCallbackInternal(this.InstanceId);
			}
		}

		// Token: 0x060399E3 RID: 236003 RVA: 0x00DB1538 File Offset: 0x00DAF738
		protected override void OnStart()
		{
			base.GetItem(4).SetUIActive(false);
			UUIText text = base.GetText(1);
			UUIItem item = base.GetItem(10);
			if (!InstanceDungeonEntranceModel.Instance.CheckInstanceCanChallenge(this.InstanceId))
			{
				text.SetUIActive(false);
				item.SetUIActive(true);
				return;
			}
			text.SetUIActive(true);
			item.SetUIActive(false);
		}

		// Token: 0x060399E4 RID: 236004 RVA: 0x00DB1592 File Offset: 0x00DAF792
		protected override void OnBeforeDestroy()
		{
		}

		// Token: 0x060399E5 RID: 236005 RVA: 0x00DB1594 File Offset: 0x00DAF794
		public void ShowTitle(int titleId)
		{
			base.GetItem(4).SetUIActive(true);
			InstanceDungeonTitle? titleConfig = InstanceDungeonConfig.Instance.GetTitleConfig(titleId);
			if (titleConfig != null)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(5), titleConfig.Value.CommonText, Array.Empty<object>());
			}
			int enterControlId = InstanceDungeonConfig.Instance.GetConfig(this.InstanceId).Value.EnterControlId;
			InstanceDungeonData instanceData = InstanceDungeonEntranceModel.Instance.GetInstanceData(enterControlId);
			if (instanceData != null)
			{
				int limitChallengedTimes = instanceData.LimitChallengedTimes;
				base.GetItem(6).SetUIActive(true);
				base.GetText(8).SetUIActive(true);
				base.GetText(8).SetText(instanceData.LeftChallengedTimes.ToString() + "/" + instanceData.LimitChallengedTimes.ToString(), true);
			}
			else
			{
				base.GetItem(6).SetUIActive(false);
				base.GetText(8).SetUIActive(false);
			}
			long num = InstanceDungeonEntranceModel.Instance.GetInstanceResetTime(this.InstanceId).GetValueOrDefault();
			if (num <= 0L)
			{
				num = InstanceDungeonEntranceModel.Instance.EntranceEndTime;
			}
			double num2 = (double)num - TimeUtil.Instance.GetServerTime();
			if (num > 0L && num2 > 0.0)
			{
				base.GetItem(7).SetUIActive(true);
				CommonDefine.IRemainTime remainTime = TimeUtil.Instance.CalculateRemainingTime(num2, CommonDefine.ETimeType.Minute);
				LguiUtil.Instance.SetLocalText(base.GetText(9), remainTime.TextId, new <>z__ReadOnlySingleElementList<object>(remainTime.TimeValue));
				return;
			}
			base.GetItem(7).SetUIActive(false);
		}

		// Token: 0x060399E6 RID: 236006 RVA: 0x00DB1730 File Offset: 0x00DAF930
		public void SetSelected(bool value, bool ignoreAnim = false)
		{
			if (!ignoreAnim)
			{
				base.GetExtendToggle(2).SetToggleState(value ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
				return;
			}
			base.GetExtendToggle(2).SetToggleStateForce(value ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, true, false);
		}

		// Token: 0x060399E7 RID: 236007 RVA: 0x00DB1763 File Offset: 0x00DAF963
		public void OnDeselected(bool fireEvent)
		{
			this.SetSelected(false, fireEvent);
		}

		// Token: 0x060399E8 RID: 236008 RVA: 0x00DB176D File Offset: 0x00DAF96D
		public void Refresh()
		{
			this.UpdateView(this.InstanceId);
		}

		// Token: 0x060399E9 RID: 236009 RVA: 0x00DB177C File Offset: 0x00DAF97C
		public void UpdateView(int instanceId)
		{
			if (instanceId == 0)
			{
				Log.Instance.Error(ELogModule.InstanceDungeon, ELogAuthor.TL, "副本格子视图刷新失败，instanceId非法", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			base.GetText(0).ShowTextNew(InstanceDungeonConfig.Instance.GetConfig(instanceId).Value.MapName);
			int recommendLevel = InstanceDungeonConfig.Instance.GetRecommendLevel(instanceId, WorldLevelModel.Instance.CurWorldLevel);
			LguiUtil.Instance.SetLocalText(base.GetText(1), "InstanceDungeonRecommendLevel", new <>z__ReadOnlySingleElementList<object>(recommendLevel));
			base.GetItem(3).SetUIActive(!InstanceDungeonEntranceModel.Instance.CheckInstanceUnlock(instanceId));
		}

		// Token: 0x0401E1E1 RID: 123361
		private readonly int InstanceId;

		// Token: 0x0401E1E2 RID: 123362
		private Action<int> ClickCallbackInternal;

		// Token: 0x0200BAD1 RID: 47825
		[NullableContext(0)]
		private static class EChildCom
		{
			// Token: 0x0403873F RID: 231231
			public const int TextName = 0;

			// Token: 0x04038740 RID: 231232
			public const int TextRecommendLevel = 1;

			// Token: 0x04038741 RID: 231233
			public const int ToggleClick = 2;

			// Token: 0x04038742 RID: 231234
			public const int UIItemLock = 3;

			// Token: 0x04038743 RID: 231235
			public const int UIItemTitle = 4;

			// Token: 0x04038744 RID: 231236
			public const int TextTitle = 5;

			// Token: 0x04038745 RID: 231237
			public const int UIItemFrequency = 6;

			// Token: 0x04038746 RID: 231238
			public const int UIItemTime = 7;

			// Token: 0x04038747 RID: 231239
			public const int TextFrequency = 8;

			// Token: 0x04038748 RID: 231240
			public const int TextTime = 9;

			// Token: 0x04038749 RID: 231241
			public const int UIItemFinish = 10;
		}
	}
}
