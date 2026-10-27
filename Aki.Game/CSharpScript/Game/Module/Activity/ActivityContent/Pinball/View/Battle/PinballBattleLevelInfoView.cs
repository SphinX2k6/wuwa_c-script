using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Battle
{
	// Token: 0x02006371 RID: 25457
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballBattleLevelInfoView : UiPanelBase
	{
		// Token: 0x17009344 RID: 37700
		// (get) Token: 0x0604008F RID: 262287 RVA: 0x00F7DE71 File Offset: 0x00F7C071
		// (set) Token: 0x06040090 RID: 262288 RVA: 0x00F7DE79 File Offset: 0x00F7C079
		public new IPinballBattleLevelInfoViewParam OpenParam { get; set; }

		// Token: 0x06040091 RID: 262289 RVA: 0x00F7DE84 File Offset: 0x00F7C084
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06040092 RID: 262290 RVA: 0x00F7DF71 File Offset: 0x00F7C171
		protected override void OnStart()
		{
			this.StarLayout = new GenericLayout<PinballBattleLevelInfoTargetItem, PinballBattleLevelInfoTargetData>(base.GetVerticalLayout(4), new Func<PinballBattleLevelInfoTargetItem>(this.InitStarItem), base.GetItem(5).GetOwner() as AUIBaseActor, false, true);
		}

		// Token: 0x06040093 RID: 262291 RVA: 0x00F7DFA4 File Offset: 0x00F7C1A4
		private PinballBattleLevelInfoTargetItem InitStarItem()
		{
			return new PinballBattleLevelInfoTargetItem();
		}

		// Token: 0x06040094 RID: 262292 RVA: 0x00F7DFAC File Offset: 0x00F7C1AC
		protected override void OnBeforeShow()
		{
			PinballLevelConfig? pinballLevelConfigById = PinballConfig.Instance.GetPinballLevelConfigById(this.OpenParam.LevelId);
			if (pinballLevelConfigById == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Pinball;
				ELogAuthor author = ELogAuthor.CB;
				string message = "找不到关卡配置";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("LevelId", this.OpenParam.LevelId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(1), pinballLevelConfigById.Value.Desc, Array.Empty<object>());
			switch (this.OpenParam.LevelType)
			{
			case EPinballLevelShowType.Normal:
			case EPinballLevelShowType.Tower:
			{
				base.GetItem(2).SetUIActive(true);
				List<PinballBattleLevelInfoTargetData> list = new List<PinballBattleLevelInfoTargetData>();
				for (int i = 0; i < pinballLevelConfigById.Value.StarCondLength; i++)
				{
					int targetId = pinballLevelConfigById.Value.StarCond(i);
					PinballLevelTarget? pinballLevelTargetConfigById = PinballConfig.Instance.GetPinballLevelTargetConfigById(targetId);
					PinballBattleLevelInfoTargetData item = new PinballBattleLevelInfoTargetData
					{
						IsSpecial = false,
						IsFinish = ((pinballLevelTargetConfigById.Value.CondType == 2) ? (this.OpenParam.Score >= pinballLevelTargetConfigById.Value.NeedNum) : (this.OpenParam.StarInfo[i] > 0)),
						Desc = pinballLevelTargetConfigById.Value.CondDesc,
						Value = pinballLevelTargetConfigById.Value.NeedNum
					};
					list.Add(item);
				}
				GenericLayout<PinballBattleLevelInfoTargetItem, PinballBattleLevelInfoTargetData> starLayout = this.StarLayout;
				if (starLayout == null)
				{
					return;
				}
				starLayout.RefreshByData(list, null, false);
				return;
			}
			case EPinballLevelShowType.Cow:
			{
				base.GetItem(2).SetUIActive(true);
				List<PinballBattleLevelInfoTargetData> list2 = new List<PinballBattleLevelInfoTargetData>();
				for (int j = 0; j < pinballLevelConfigById.Value.ScoreLevelRewardLength; j++)
				{
					DicIntInt? dicIntInt = pinballLevelConfigById.Value.ScoreLevelReward(j);
					if (dicIntInt != null)
					{
						int key = dicIntInt.Value.Key;
						PinballBattleLevelInfoTargetData item2 = new PinballBattleLevelInfoTargetData
						{
							IsSpecial = true,
							IsFinish = (this.OpenParam.Score >= key),
							Desc = "Pinball_Level_Conditon04",
							Value = key
						};
						list2.Add(item2);
					}
				}
				GenericLayout<PinballBattleLevelInfoTargetItem, PinballBattleLevelInfoTargetData> starLayout2 = this.StarLayout;
				if (starLayout2 == null)
				{
					return;
				}
				starLayout2.RefreshByData(list2, null, false);
				return;
			}
			case EPinballLevelShowType.Daily:
				base.GetItem(2).SetUIActive(false);
				return;
			default:
				return;
			}
		}

		// Token: 0x040215FB RID: 136699
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<PinballBattleLevelInfoTargetItem, PinballBattleLevelInfoTargetData> StarLayout;

		// Token: 0x0200C58C RID: 50572
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x0403BA13 RID: 244243
			Scroll,
			// Token: 0x0403BA14 RID: 244244
			LevelDesc,
			// Token: 0x0403BA15 RID: 244245
			PnlLevelTarget,
			// Token: 0x0403BA16 RID: 244246
			TextTargetTitle,
			// Token: 0x0403BA17 RID: 244247
			LevelTargetLayout,
			// Token: 0x0403BA18 RID: 244248
			LevelTargetLayoutItem
		}
	}
}
