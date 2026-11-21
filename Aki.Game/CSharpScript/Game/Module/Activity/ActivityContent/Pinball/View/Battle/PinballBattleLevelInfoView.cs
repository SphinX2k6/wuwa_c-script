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
	// Token: 0x020052EF RID: 21231
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballBattleLevelInfoView : UiPanelBase
	{
		// Token: 0x170066A6 RID: 26278
		// (get) Token: 0x06034D50 RID: 216400 RVA: 0x00EC4DD1 File Offset: 0x00EC2FD1
		// (set) Token: 0x06034D51 RID: 216401 RVA: 0x00EC4DD9 File Offset: 0x00EC2FD9
		public new IPinballBattleLevelInfoViewParam OpenParam { get; set; }

		// Token: 0x06034D52 RID: 216402 RVA: 0x00EC4DE4 File Offset: 0x00EC2FE4
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

		// Token: 0x06034D53 RID: 216403 RVA: 0x00EC4ED1 File Offset: 0x00EC30D1
		protected override void OnStart()
		{
			this.StarLayout = new GenericLayout<PinballBattleLevelInfoTargetItem, PinballBattleLevelInfoTargetData>(base.GetVerticalLayout(4), new Func<PinballBattleLevelInfoTargetItem>(this.InitStarItem), base.GetItem(5).GetOwner() as AUIBaseActor, false, true);
		}

		// Token: 0x06034D54 RID: 216404 RVA: 0x00EC4F04 File Offset: 0x00EC3104
		private PinballBattleLevelInfoTargetItem InitStarItem()
		{
			return new PinballBattleLevelInfoTargetItem();
		}

		// Token: 0x06034D55 RID: 216405 RVA: 0x00EC4F0C File Offset: 0x00EC310C
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

		// Token: 0x0401BF2A RID: 114474
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<PinballBattleLevelInfoTargetItem, PinballBattleLevelInfoTargetData> StarLayout;

		// Token: 0x0200AF73 RID: 44915
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x04036375 RID: 222069
			Scroll,
			// Token: 0x04036376 RID: 222070
			LevelDesc,
			// Token: 0x04036377 RID: 222071
			PnlLevelTarget,
			// Token: 0x04036378 RID: 222072
			TextTargetTitle,
			// Token: 0x04036379 RID: 222073
			LevelTargetLayout,
			// Token: 0x0403637A RID: 222074
			LevelTargetLayoutItem
		}
	}
}
