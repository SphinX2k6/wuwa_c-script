using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.ActivityCondition;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020059E7 RID: 23015
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class SolarSchoolQuestItem : GridProxyAbstract<SolarSchoolQuestItemData>
	{
		// Token: 0x17006C49 RID: 27721
		// (get) Token: 0x06038B0A RID: 232202 RVA: 0x00FDDF95 File Offset: 0x00FDC195
		// (set) Token: 0x06038B0B RID: 232203 RVA: 0x00FDDF9D File Offset: 0x00FDC19D
		public Action<int> JumpCallback { get; set; }

		// Token: 0x17006C4A RID: 27722
		// (get) Token: 0x06038B0C RID: 232204 RVA: 0x00FDDFA6 File Offset: 0x00FDC1A6
		// (set) Token: 0x06038B0D RID: 232205 RVA: 0x00FDDFAE File Offset: 0x00FDC1AE
		public Action<int> HelpCallback { get; set; }

		// Token: 0x06038B0E RID: 232206 RVA: 0x00FDDFB8 File Offset: 0x00FDC1B8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 10;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.OnBtnLookClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06038B0F RID: 232207 RVA: 0x00FDE168 File Offset: 0x00FDC368
		protected override UniTask OnBeforeStartAsync()
		{
			SolarSchoolQuestItem.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SolarSchoolQuestItem.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038B10 RID: 232208 RVA: 0x00FDE1AC File Offset: 0x00FDC3AC
		[NullableContext(1)]
		public override void Refresh(SolarSchoolQuestItemData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			SolarSchoolQuestReward? questReward = SolarSchoolConfig.Instance.GetQuestReward(data.RewardId);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), ((questReward != null) ? questReward.GetValueOrDefault().Desc : null) ?? string.Empty, Array.Empty<object>());
			UUIText text = base.GetText(2);
			if (text != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
				defaultInterpolatedStringHandler.AppendLiteral("+");
				defaultInterpolatedStringHandler.AppendFormatted<int>((questReward != null) ? questReward.GetValueOrDefault().RewardProgress : 0);
				text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
			UUIText text2 = base.GetText(4);
			int num;
			int progress = this.GetProgress(data, out num);
			int num2 = (questReward != null) ? questReward.GetValueOrDefault().ConditionId : 0;
			string text3 = ((questReward != null) ? questReward.GetValueOrDefault().Desc : null) ?? string.Empty;
			if (num2 != 0)
			{
				ActivityCondition? conditionConfig = ActivityConditionConfig.Instance.GetConditionConfig(num2);
				if (conditionConfig != null)
				{
					text3 = conditionConfig.Value.Description;
				}
			}
			if (string.IsNullOrEmpty(text3))
			{
				if (text2 != null)
				{
					text2.SetText(string.Empty, true);
				}
			}
			else
			{
				LguiUtil.Instance.SetLocalTextNew(text2, text3, new int[]
				{
					progress,
					num
				});
			}
			SolarSchoolQuestItem.ERowState rowState = this.GetRowState(data);
			UUIItem item = base.GetItem(8);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUIItem item2 = base.GetItem(6);
			if (item2 != null)
			{
				item2.SetUIActive(rowState == SolarSchoolQuestItem.ERowState.Done);
			}
			SolarSchoolBtnItem gotoBtn = this.GotoBtn;
			if (gotoBtn != null)
			{
				gotoBtn.SetUiActive(rowState == SolarSchoolQuestItem.ERowState.Goto);
			}
			UUIText text4 = base.GetText(9);
			if (text4 != null)
			{
				text4.SetUIActive(rowState == SolarSchoolQuestItem.ERowState.Doing);
			}
			this.SetButtonVisible(5, this.HasHelp(data));
		}

		// Token: 0x06038B11 RID: 232209 RVA: 0x00FDE386 File Offset: 0x00FDC586
		public override void Clear()
		{
			this.Data = null;
		}

		// Token: 0x06038B12 RID: 232210 RVA: 0x00FDE38F File Offset: 0x00FDC58F
		[NullableContext(1)]
		public override object GetKey(SolarSchoolQuestItemData data, int displayIndex)
		{
			return data.RewardId;
		}

		// Token: 0x06038B13 RID: 232211 RVA: 0x00FDE39C File Offset: 0x00FDC59C
		[NullableContext(1)]
		[return: Nullable(2)]
		private SolarSchoolSingleQuestData GetQuestData(SolarSchoolQuestItemData data)
		{
			return SolarSchoolGamePlayModel.Instance.QuestData.GetQuestData(data.QuestId);
		}

		// Token: 0x06038B14 RID: 232212 RVA: 0x00FDE3B3 File Offset: 0x00FDC5B3
		[NullableContext(1)]
		private SolarSchoolQuestItem.ERowState GetRowState(SolarSchoolQuestItemData data)
		{
			if (this.GetQuestData(data).IsRewardFinished(data.RewardId))
			{
				return SolarSchoolQuestItem.ERowState.Done;
			}
			if (!this.HasJump(data))
			{
				return SolarSchoolQuestItem.ERowState.Doing;
			}
			return SolarSchoolQuestItem.ERowState.Goto;
		}

		// Token: 0x06038B15 RID: 232213 RVA: 0x00FDE3D8 File Offset: 0x00FDC5D8
		[NullableContext(1)]
		private int GetProgress(SolarSchoolQuestItemData data, out int target)
		{
			SolarSchoolSingleQuestData questData = this.GetQuestData(data);
			SolarSchoolQuestRewardData solarSchoolQuestRewardData = (questData != null) ? questData.GetReward(data.RewardId) : null;
			if (solarSchoolQuestRewardData == null)
			{
				target = 1;
				return 0;
			}
			return solarSchoolQuestRewardData.GetProgress(out target);
		}

		// Token: 0x06038B16 RID: 232214 RVA: 0x00FDE410 File Offset: 0x00FDC610
		[NullableContext(1)]
		private bool HasHelp(SolarSchoolQuestItemData data)
		{
			SolarSchoolQuestReward? solarSchoolQuestReward;
			return !string.IsNullOrEmpty((SolarSchoolConfig.Instance.GetQuestReward(data.RewardId) != null) ? solarSchoolQuestReward.GetValueOrDefault().TxtHelpInfo : null);
		}

		// Token: 0x06038B17 RID: 232215 RVA: 0x00FDE451 File Offset: 0x00FDC651
		[NullableContext(1)]
		private bool HasJump(SolarSchoolQuestItemData data)
		{
			return data.AllowJump && SolarSchoolUtils.CollectQuestRewardJumps(data.RewardId).Count > 0;
		}

		// Token: 0x06038B18 RID: 232216 RVA: 0x00FDE470 File Offset: 0x00FDC670
		private void SetButtonVisible(int component, bool visible)
		{
			UUIButtonComponent button = base.GetButton(component);
			if (button == null)
			{
				return;
			}
			UUIItem uuiitem = button.RootUIComp.Get();
			if (uuiitem == null)
			{
				return;
			}
			uuiitem.SetUIActive(visible);
		}

		// Token: 0x06038B19 RID: 232217 RVA: 0x00FDE4A1 File Offset: 0x00FDC6A1
		private void OnGotoClick()
		{
			if (this.Data == null || this.GetRowState(this.Data) != SolarSchoolQuestItem.ERowState.Goto)
			{
				return;
			}
			Action<int> jumpCallback = this.JumpCallback;
			if (jumpCallback == null)
			{
				return;
			}
			jumpCallback(this.Data.RewardId);
		}

		// Token: 0x06038B1A RID: 232218 RVA: 0x00FDE4D6 File Offset: 0x00FDC6D6
		private void OnBtnLookClick()
		{
			if (this.Data == null || !this.HasHelp(this.Data))
			{
				return;
			}
			Action<int> helpCallback = this.HelpCallback;
			if (helpCallback == null)
			{
				return;
			}
			helpCallback(this.Data.RewardId);
		}

		// Token: 0x0401DD9E RID: 122270
		private SolarSchoolBtnItem GotoBtn;

		// Token: 0x0401DD9F RID: 122271
		private SolarSchoolQuestItemData Data;

		// Token: 0x0200B59E RID: 46494
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403829C RID: 230044
			public const int BtnClick = 0;

			// Token: 0x0403829D RID: 230045
			public const int TexIcon = 1;

			// Token: 0x0403829E RID: 230046
			public const int TxtAddNum = 2;

			// Token: 0x0403829F RID: 230047
			public const int TxtName = 3;

			// Token: 0x040382A0 RID: 230048
			public const int TxtNum = 4;

			// Token: 0x040382A1 RID: 230049
			public const int BtnHelp = 5;

			// Token: 0x040382A2 RID: 230050
			public const int PnlDone = 6;

			// Token: 0x040382A3 RID: 230051
			public const int BtnJump = 7;

			// Token: 0x040382A4 RID: 230052
			public const int PnlLock = 8;

			// Token: 0x040382A5 RID: 230053
			public const int TxtDoing = 9;
		}

		// Token: 0x0200B59F RID: 46495
		[NullableContext(0)]
		private enum ERowState
		{
			// Token: 0x040382A7 RID: 230055
			Done,
			// Token: 0x040382A8 RID: 230056
			Goto,
			// Token: 0x040382A9 RID: 230057
			Doing
		}
	}
}
