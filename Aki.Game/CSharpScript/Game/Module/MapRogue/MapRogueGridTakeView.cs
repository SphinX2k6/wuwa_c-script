using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x02005601 RID: 22017
	[NullableContext(1)]
	[Nullable(0)]
	public class MapRogueGridTakeView : UiViewBase
	{
		// Token: 0x060380B3 RID: 229555 RVA: 0x00D45C2D File Offset: 0x00D43E2D
		public MapRogueGridTakeView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060380B4 RID: 229556 RVA: 0x00D45C38 File Offset: 0x00D43E38
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIArtText)),
				new ValueTuple<int, Type>(3, typeof(UUIArtText)),
				new ValueTuple<int, Type>(4, typeof(UUIVerticalLayout)),
				new ValueTuple<int, Type>(5, typeof(UUIItem))
			};
		}

		// Token: 0x060380B5 RID: 229557 RVA: 0x00D45CD4 File Offset: 0x00D43ED4
		protected override UniTask OnBeforeStartAsync()
		{
			MapRogueGridTakeView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MapRogueGridTakeView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060380B6 RID: 229558 RVA: 0x00D45D17 File Offset: 0x00D43F17
		protected override void OnStart()
		{
			this.RewardLayout = new GenericLayout<CSharpScript.Game.Module.MapRogue.RewardItem, ChangeItemInfoData>(base.GetVerticalLayout(4), new Func<CSharpScript.Game.Module.MapRogue.RewardItem>(this.OnCreateRewardItem), null, false, true);
		}

		// Token: 0x060380B7 RID: 229559 RVA: 0x00D45D3C File Offset: 0x00D43F3C
		protected override void OnBeforeShow()
		{
			int? num = this.OpenParam as int?;
			if (num != null)
			{
				int? num2 = num;
				int num3 = 0;
				if (!(num2.GetValueOrDefault() == num3 & num2 != null))
				{
					this.OpIncId = num.Value;
					MapRogueOp opData = MapRogueModel.Instance.GetOpData(this.OpIncId);
					if (opData == null)
					{
						return;
					}
					ShowViewOp showViewOp = opData.Data.ShowViewOp;
					GridTakeView gridTakeView = (showViewOp != null) ? showViewOp.GridTakeView : null;
					if (gridTakeView == null)
					{
						return;
					}
					base.GetArtText(2).SetText(gridTakeView.OldTeamLevel.ToString());
					base.GetArtText(3).SetText(gridTakeView.NewTeamLevel.ToString());
					List<ChangeItemInfoData> list = new List<ChangeItemInfoData>();
					foreach (int id in gridTakeView.Effects)
					{
						RogueResEffect? rogueEffectById = MapRogueConfig.Instance.GetRogueEffectById(id);
						if (rogueEffectById != null)
						{
							RogueResEffectTag? rogueEffectTagById = MapRogueConfig.Instance.GetRogueEffectTagById(rogueEffectById.Value.Tag);
							if (rogueEffectTagById != null)
							{
								string text;
								if (!rogueEffectTagById.Value.IsRatio)
								{
									text = rogueEffectById.Value.DescIntParam.ToString();
								}
								else
								{
									DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
									defaultInterpolatedStringHandler.AppendFormatted<int>(rogueEffectById.Value.DescIntParam);
									defaultInterpolatedStringHandler.AppendLiteral("%");
									text = defaultInterpolatedStringHandler.ToStringAndClear();
								}
								string value = text;
								ChangeItemInfoData item = new ChangeItemInfoData
								{
									TitleId = rogueEffectTagById.Value.Text,
									Value = value
								};
								list.Add(item);
							}
						}
					}
					GenericLayout<CSharpScript.Game.Module.MapRogue.RewardItem, ChangeItemInfoData> rewardLayout = this.RewardLayout;
					if (rewardLayout == null)
					{
						return;
					}
					rewardLayout.RefreshByData(list, null, false);
					return;
				}
			}
		}

		// Token: 0x060380B8 RID: 229560 RVA: 0x00D45F24 File Offset: 0x00D44124
		protected override void OnAfterShow()
		{
			MapRogueOp opData = MapRogueModel.Instance.GetOpData(this.OpIncId);
			if (opData == null)
			{
				return;
			}
			ShowViewOp showViewOp = opData.Data.ShowViewOp;
			GridTakeView gridTakeView = (showViewOp != null) ? showViewOp.GridTakeView : null;
			if (gridTakeView == null)
			{
				return;
			}
			int mood = MapRogueModel.Instance.GameInfo.Mood;
			int preChangeMood = gridTakeView.PreChangeMood;
			int currentValue = mood - preChangeMood;
			MapRoguePopupBase bgItem = this.BgItem;
			if (bgItem != null)
			{
				MapRogueMoodBar moodBar = bgItem.MoodBar;
				if (moodBar != null)
				{
					moodBar.SetCurrentValue(currentValue);
				}
			}
			MapRoguePopupBase bgItem2 = this.BgItem;
			if (bgItem2 == null)
			{
				return;
			}
			MapRogueMoodBar moodBar2 = bgItem2.MoodBar;
			if (moodBar2 == null)
			{
				return;
			}
			moodBar2.ShowPreviewValue(preChangeMood, mood);
		}

		// Token: 0x060380B9 RID: 229561 RVA: 0x00D45FB8 File Offset: 0x00D441B8
		private CSharpScript.Game.Module.MapRogue.RewardItem OnCreateRewardItem()
		{
			return new CSharpScript.Game.Module.MapRogue.RewardItem();
		}

		// Token: 0x060380BA RID: 229562 RVA: 0x00D45FBF File Offset: 0x00D441BF
		private void OnMaskBtnClick()
		{
			MapRogueModel.Instance.ExecuteOpData(this.OpIncId, delegate(bool success)
			{
				if (success)
				{
					base.CloseMe(null);
				}
			});
		}

		// Token: 0x060380BB RID: 229563 RVA: 0x00D45FDD File Offset: 0x00D441DD
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (configParams.Length == 0)
			{
				return null;
			}
			MapRoguePopupBase bgItem = this.BgItem;
			if (bgItem == null)
			{
				return null;
			}
			return bgItem.GetGuideUiItemAndUiItemForShowEx(configParams);
		}

		// Token: 0x0401D745 RID: 120645
		protected int OpIncId;

		// Token: 0x0401D746 RID: 120646
		[Nullable(2)]
		protected MapRoguePopupBase BgItem;

		// Token: 0x0401D747 RID: 120647
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		protected GenericLayout<CSharpScript.Game.Module.MapRogue.RewardItem, ChangeItemInfoData> RewardLayout;
	}
}
