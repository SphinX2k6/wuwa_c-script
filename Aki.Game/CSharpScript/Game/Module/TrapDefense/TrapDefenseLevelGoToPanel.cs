using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A54 RID: 14932
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseLevelGoToPanel : UiPanelBase
	{
		// Token: 0x06026611 RID: 157201 RVA: 0x00AC0164 File Offset: 0x00ABE364
		public UniTask Init(UUIItem item)
		{
			TrapDefenseLevelGoToPanel.<Init>d__2 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.item = item;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<TrapDefenseLevelGoToPanel.<Init>d__2>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x06026612 RID: 157202 RVA: 0x00AC01B0 File Offset: 0x00ABE3B0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickBtnGoTo));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06026613 RID: 157203 RVA: 0x00AC031C File Offset: 0x00ABE51C
		public void UpdateData(TrapDefenseLevelData data)
		{
			this.LevelData = data;
			if (data.IsUnlock)
			{
				UUIItem item = base.GetItem(7);
				if (item != null)
				{
					item.SetUIActive(data.IsUnlock);
				}
				this.ShowGotoBtn();
				return;
			}
			bool flag = data.IsReachOpenTime();
			UUIItem item2 = base.GetItem(1);
			if (item2 != null)
			{
				item2.SetUIActive(!flag);
			}
			this.SetBtnEnabled(true);
			if (!flag)
			{
				this.SetBtnEnabled(false);
				UUIText text = base.GetText(2);
				if (text != null)
				{
					text.SetText(data.GetUnlockTimeFormat(), true);
				}
				UUIItem item3 = base.GetItem(3);
				if (item3 == null)
				{
					return;
				}
				item3.SetUIActive(false);
				return;
			}
			else
			{
				UUIItem item4 = base.GetItem(7);
				if (item4 != null)
				{
					item4.SetUIActive(data.IsUnlockCondition);
				}
				if (data.IsUnlockCondition)
				{
					this.ShowGotoBtn();
					return;
				}
				this.UpdateLockConditionInfo();
				return;
			}
		}

		// Token: 0x06026614 RID: 157204 RVA: 0x00AC03DE File Offset: 0x00ABE5DE
		private void ShowGotoBtn()
		{
			this.SetBtnEnabled(true);
			UUIItem item = base.GetItem(3);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUIItem item2 = base.GetItem(1);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(false);
		}

		// Token: 0x06026615 RID: 157205 RVA: 0x00AC040C File Offset: 0x00ABE60C
		private void SetBtnEnabled(bool enable)
		{
			UUIButtonComponent button = base.GetButton(0);
			if (button == null)
			{
				return;
			}
			button.SetSelfInteractive(enable);
		}

		// Token: 0x06026616 RID: 157206 RVA: 0x00AC0420 File Offset: 0x00ABE620
		public void OnClickBtnGoTo()
		{
			if (GameModeModel.Instance.IsMulti)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("Trapdefence_NoOlineTpye", Array.Empty<object>());
				return;
			}
			Action cb = delegate()
			{
				TrapDefenseModel.Instance.RequestStartChallenge(this.LevelData);
			};
			if (this.LevelData.IsLeaved)
			{
				TrapDefenseModel.Instance.RequestStartChallenge(this.LevelData);
				return;
			}
			if (!TrapDefenseModel.Instance.CheckNextLevelThreshold(this.LevelData, cb, UiModel.Instance.NormalStack.Peek()))
			{
				TrapDefenseModel.Instance.RequestStartChallenge(this.LevelData);
			}
		}

		// Token: 0x06026617 RID: 157207 RVA: 0x00AC04B0 File Offset: 0x00ABE6B0
		public void UpdateLockConditionInfo()
		{
			ValueTuple<ELevelGeneralCondition, int, string, Dictionary<string, string>> openConditionLockCondition = this.LevelData.GetOpenConditionLockCondition();
			ELevelGeneralCondition item = openConditionLockCondition.Item1;
			int item2 = openConditionLockCondition.Item2;
			string item3 = openConditionLockCondition.Item3;
			Dictionary<string, string> item4 = openConditionLockCondition.Item4;
			if (item == ELevelGeneralCondition.TrapDefensePassFullStar)
			{
				this.SetBtnEnabled(false);
				UUIItem item5 = base.GetItem(3);
				if (item5 != null)
				{
					item5.SetUIActive(false);
				}
				UUIItem item6 = base.GetItem(1);
				if (item6 != null)
				{
					item6.SetUIActive(true);
				}
				UUIText text = base.GetText(2);
				if (text == null)
				{
					return;
				}
				text.ShowTextNew(item3);
				return;
			}
			else
			{
				if (item == ELevelGeneralCondition.TrapDefenseTotalStar)
				{
					int allGetStarByLevel = TrapDefenseModel.Instance.GetAllGetStarByLevel();
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
					defaultInterpolatedStringHandler.AppendFormatted<int>(allGetStarByLevel);
					defaultInterpolatedStringHandler.AppendLiteral("/");
					defaultInterpolatedStringHandler.AppendFormatted<int>(item2);
					string newText = defaultInterpolatedStringHandler.ToStringAndClear();
					UUIItem item7 = base.GetItem(3);
					if (item7 != null)
					{
						item7.SetUIActive(true);
					}
					UUIItem item8 = base.GetItem(1);
					if (item8 != null)
					{
						item8.SetUIActive(false);
					}
					UUIText text2 = base.GetText(5);
					if (text2 != null)
					{
						text2.SetText(newText, true);
					}
					this.SetBtnEnabled(false);
					return;
				}
				if (item == ELevelGeneralCondition.TrapDefenseChallengeStar)
				{
					this.SetBtnEnabled(false);
					UUIItem item9 = base.GetItem(3);
					if (item9 != null)
					{
						item9.SetUIActive(true);
					}
					UUIItem item10 = base.GetItem(1);
					if (item10 != null)
					{
						item10.SetUIActive(false);
					}
					string s;
					int num;
					int key = (item4.TryGetValue("ChallengeId", out s) && int.TryParse(s, out num)) ? num : 0;
					TrapDefenseLevelData trapDefenseLevelData;
					TrapDefenseModel.Instance.LevelDataFromIdMap.TryGetValue(key, out trapDefenseLevelData);
					int num2 = (trapDefenseLevelData != null) ? trapDefenseLevelData.ReachTargetIndexList.Count : 0;
					LguiUtil.Instance.SetLocalTextNew(base.GetText(4), item3, new <>z__ReadOnlyArray<object>(new object[]
					{
						num2,
						item2
					}));
					return;
				}
				this.ShowGotoBtn();
				return;
			}
		}

		// Token: 0x040150E9 RID: 86249
		public TrapDefenseLevelData LevelData;

		// Token: 0x02009621 RID: 38433
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x0402EDF6 RID: 191990
			public const int BtnGoTo = 0;

			// Token: 0x0402EDF7 RID: 191991
			public const int ItemRootTime = 1;

			// Token: 0x0402EDF8 RID: 191992
			public const int TextDownTime = 2;

			// Token: 0x0402EDF9 RID: 191993
			public const int ItemRootProgress = 3;

			// Token: 0x0402EDFA RID: 191994
			public const int TextDescProgress = 4;

			// Token: 0x0402EDFB RID: 191995
			public const int TextStarProgress = 5;

			// Token: 0x0402EDFC RID: 191996
			public const int ItemRedDot = 6;

			// Token: 0x0402EDFD RID: 191997
			public const int PanelButton = 7;
		}
	}
}
