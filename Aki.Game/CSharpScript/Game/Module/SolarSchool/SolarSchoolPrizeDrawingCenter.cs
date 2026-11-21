using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x0200592F RID: 22831
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolPrizeDrawingCenter : Singleton
	{
		// Token: 0x17006BCF RID: 27599
		// (get) Token: 0x0603840E RID: 230414 RVA: 0x00FBA892 File Offset: 0x00FB8A92
		private static SolarSchoolGamePlayModel Model
		{
			get
			{
				return SolarSchoolGamePlayModel.Instance;
			}
		}

		// Token: 0x17006BD0 RID: 27600
		// (get) Token: 0x0603840F RID: 230415 RVA: 0x00FBA899 File Offset: 0x00FB8A99
		private static SolarSchoolPrizeDrawingData Data
		{
			get
			{
				return SolarSchoolPrizeDrawingCenter.Model.PrizeDrawingData;
			}
		}

		// Token: 0x17006BD1 RID: 27601
		// (get) Token: 0x06038410 RID: 230416 RVA: 0x00FBA8A5 File Offset: 0x00FB8AA5
		// (set) Token: 0x06038411 RID: 230417 RVA: 0x00FBA8AD File Offset: 0x00FB8AAD
		public int CurrentActivityId { get; private set; }

		// Token: 0x06038412 RID: 230418 RVA: 0x00FBA8B6 File Offset: 0x00FB8AB6
		public void SetCurrentActivityId(int activityId)
		{
			this.CurrentActivityId = activityId;
		}

		// Token: 0x06038413 RID: 230419 RVA: 0x00FBA8BF File Offset: 0x00FB8ABF
		private PrizeActivity? GetActivityConfig()
		{
			return SolarSchoolConfig.Instance.GetPrizeActivityById(this.CurrentActivityId);
		}

		// Token: 0x06038414 RID: 230420 RVA: 0x00FBA8D1 File Offset: 0x00FB8AD1
		public int GetCostItemId()
		{
			return this.GetCostA().Id;
		}

		// Token: 0x06038415 RID: 230421 RVA: 0x00FBA8E0 File Offset: 0x00FB8AE0
		public SolarSchoolCostCurrency GetCostA()
		{
			PrizeActivity? activityConfig = this.GetActivityConfig();
			if (activityConfig == null)
			{
				return new SolarSchoolCostCurrency(ESolarSchoolCostSource.Item, 0, 0);
			}
			return new SolarSchoolCostCurrency((ESolarSchoolCostSource)activityConfig.Value.CostItem1Type, activityConfig.Value.CostItem1Id, 1);
		}

		// Token: 0x06038416 RID: 230422 RVA: 0x00FBA92C File Offset: 0x00FB8B2C
		public SolarSchoolCostCurrency GetCostB()
		{
			PrizeActivity? activityConfig = this.GetActivityConfig();
			if (activityConfig == null)
			{
				return new SolarSchoolCostCurrency(ESolarSchoolCostSource.Item, 0, 0);
			}
			return new SolarSchoolCostCurrency((ESolarSchoolCostSource)activityConfig.Value.CostItem2Type, activityConfig.Value.CostItem2Id, activityConfig.Value.CostItem2Num);
		}

		// Token: 0x06038417 RID: 230423 RVA: 0x00FBA984 File Offset: 0x00FB8B84
		public int GetCostConfirmId()
		{
			if (this.GetActivityConfig() == null)
			{
				return 0;
			}
			PrizeActivity? prizeActivity;
			return prizeActivity.GetValueOrDefault().CostItem2ConfirmId;
		}

		// Token: 0x06038418 RID: 230424 RVA: 0x00FBA9B4 File Offset: 0x00FB8BB4
		public int GetNotEnoughConfirmId()
		{
			if (this.GetActivityConfig() == null)
			{
				return 0;
			}
			PrizeActivity? prizeActivity;
			return prizeActivity.GetValueOrDefault().CostItem1ConfirmId;
		}

		// Token: 0x06038419 RID: 230425 RVA: 0x00FBA9E4 File Offset: 0x00FB8BE4
		public IReadOnlyList<PrizeAwardsGroup> GetAllAwardGroup(int kujiId)
		{
			List<PrizeAwardsGroup> list = new List<PrizeAwardsGroup>();
			PrizeActivity? prizeActivity;
			int num = (this.GetActivityConfig() != null) ? prizeActivity.GetValueOrDefault().AwardsAmount : 0;
			for (int i = 1; i <= num; i++)
			{
				PrizeAwardsGroup? prizeAwardsGroupById = SolarSchoolConfig.Instance.GetPrizeAwardsGroupById(i);
				if (prizeAwardsGroupById != null)
				{
					list.Add(prizeAwardsGroupById.Value);
				}
			}
			return list;
		}

		// Token: 0x0603841A RID: 230426 RVA: 0x00FBAA50 File Offset: 0x00FB8C50
		public List<ISolarSchoolPrizeAwardData> GetAllAwardItem(int kujiId)
		{
			List<ISolarSchoolPrizeAwardData> list = new List<ISolarSchoolPrizeAwardData>();
			foreach (PrizeAwardsGroup prizeAwardsGroup in this.GetAllAwardGroup(kujiId))
			{
				list.Add(new SolarSchoolPrizeAwardData
				{
					ItemId = prizeAwardsGroup.RewardId,
					Count = 1,
					Times = prizeAwardsGroup.Amount,
					Rare = prizeAwardsGroup.Rank
				});
			}
			return list;
		}

		// Token: 0x0603841B RID: 230427 RVA: 0x00FBAAD8 File Offset: 0x00FB8CD8
		public int GetDrawnCount(int groupId)
		{
			return SolarSchoolPrizeDrawingCenter.Data.GetDrawnCount(groupId);
		}

		// Token: 0x0603841C RID: 230428 RVA: 0x00FBAAE8 File Offset: 0x00FB8CE8
		public int GetGroupMaxAmount(int groupId)
		{
			if (SolarSchoolConfig.Instance.GetPrizeAwardsGroupById(groupId) == null)
			{
				return 0;
			}
			PrizeAwardsGroup? prizeAwardsGroup;
			return prizeAwardsGroup.GetValueOrDefault().Amount;
		}

		// Token: 0x0603841D RID: 230429 RVA: 0x00FBAB1B File Offset: 0x00FB8D1B
		public bool IsGroupDrawnOut(int groupId)
		{
			return this.GetDrawnCount(groupId) >= this.GetGroupMaxAmount(groupId);
		}

		// Token: 0x0603841E RID: 230430 RVA: 0x00FBAB30 File Offset: 0x00FB8D30
		public int GetCurrentProgress(int kujiId)
		{
			int num = 0;
			foreach (PrizeAwardsGroup prizeAwardsGroup in this.GetAllAwardGroup(kujiId))
			{
				num += this.GetDrawnCount(prizeAwardsGroup.Id);
			}
			return num;
		}

		// Token: 0x0603841F RID: 230431 RVA: 0x00FBAB8C File Offset: 0x00FB8D8C
		public int GetTotalProgress(int kujiId)
		{
			int num = 0;
			foreach (PrizeAwardsGroup prizeAwardsGroup in this.GetAllAwardGroup(kujiId))
			{
				num += prizeAwardsGroup.Amount;
			}
			return num;
		}

		// Token: 0x06038420 RID: 230432 RVA: 0x00FBABE0 File Offset: 0x00FB8DE0
		public bool IsAllFinished(int kujiId)
		{
			return this.GetCurrentProgress(kujiId) >= this.GetTotalProgress(kujiId);
		}

		// Token: 0x06038421 RID: 230433 RVA: 0x00FBABF5 File Offset: 0x00FB8DF5
		public int GetCoinCount()
		{
			return this.GetCurrencyCount(this.GetCostA());
		}

		// Token: 0x06038422 RID: 230434 RVA: 0x00FBAC04 File Offset: 0x00FB8E04
		public int GetCurrencyCount(SolarSchoolCostCurrency currency)
		{
			if (!currency.Valid)
			{
				return 0;
			}
			ESolarSchoolCostSource source = currency.Source;
			int result;
			if (source != ESolarSchoolCostSource.Item)
			{
				if (source != ESolarSchoolCostSource.Attr)
				{
					result = 0;
				}
				else
				{
					result = SolarSchoolPrizeDrawingCenter.Model.PlayerData.GetAttr((ESolarSchoolSecondAttr)currency.Id);
				}
			}
			else
			{
				result = SolarSchoolPrizeDrawingCenter.Model.InventoryData.GetItemCount(currency.Id);
			}
			return result;
		}

		// Token: 0x06038423 RID: 230435 RVA: 0x00FBAC60 File Offset: 0x00FB8E60
		public string GetCurrencyIcon(SolarSchoolCostCurrency currency)
		{
			if (!currency.Valid)
			{
				return string.Empty;
			}
			ESolarSchoolCostSource source = currency.Source;
			if (source == ESolarSchoolCostSource.Item)
			{
				SolarSchoolItem? solarSchoolItem;
				return ((SolarSchoolConfig.Instance.GetItem(currency.Id) != null) ? solarSchoolItem.GetValueOrDefault().Icon : null) ?? string.Empty;
			}
			if (source != ESolarSchoolCostSource.Attr)
			{
				return string.Empty;
			}
			SolarSchoolAttr? solarSchoolAttr;
			return ((SolarSchoolConfig.Instance.TryGetAttrByType(SolarSchoolPrizeDrawingCenter.Model.ActivityId, currency.Id) != null) ? solarSchoolAttr.GetValueOrDefault().YellowIconSmall : null) ?? string.Empty;
		}

		// Token: 0x06038424 RID: 230436 RVA: 0x00FBAD09 File Offset: 0x00FB8F09
		public bool HasEnough(SolarSchoolCostCurrency currency)
		{
			return currency.Valid && this.GetCurrencyCount(currency) >= currency.Num;
		}

		// Token: 0x06038425 RID: 230437 RVA: 0x00FBAD28 File Offset: 0x00FB8F28
		public void ConsumeCurrency(SolarSchoolCostCurrency currency)
		{
			if (!currency.Valid)
			{
				return;
			}
			ESolarSchoolCostSource source = currency.Source;
			if (source == ESolarSchoolCostSource.Item)
			{
				SolarSchoolPrizeDrawingCenter.Model.AddItem(currency.Id, -currency.Num);
				return;
			}
			if (source != ESolarSchoolCostSource.Attr)
			{
				return;
			}
			SolarSchoolPrizeDrawingCenter.Model.PlayerData.AddAttr((ESolarSchoolSecondAttr)currency.Id, -currency.Num);
		}

		// Token: 0x06038426 RID: 230438 RVA: 0x00FBAD84 File Offset: 0x00FB8F84
		public bool HaveEnoughCoinToRoll()
		{
			return this.HasEnough(this.GetCostA()) || this.HasEnough(this.GetCostB());
		}

		// Token: 0x06038427 RID: 230439 RVA: 0x00FBADA2 File Offset: 0x00FB8FA2
		public ESolarSchoolDrawCostCheck ResolveDrawCost()
		{
			if (this.HasEnough(this.GetCostA()))
			{
				return ESolarSchoolDrawCostCheck.UseA;
			}
			if (this.HasEnough(this.GetCostB()))
			{
				return ESolarSchoolDrawCostCheck.NeedConfirmB;
			}
			return ESolarSchoolDrawCostCheck.NotEnough;
		}

		// Token: 0x06038428 RID: 230440 RVA: 0x00FBADC8 File Offset: 0x00FB8FC8
		[NullableContext(2)]
		public unsafe ISolarSchoolPrizeAwardData Draw(int kujiId, SolarSchoolCostCurrency cost)
		{
			if (!SolarSchoolPrizeDrawingCenter.Model.IsInGamePlay)
			{
				return null;
			}
			if (this.IsAllFinished(kujiId))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 一番赏已抽空，无法继续";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("kujiId", kujiId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			if (!this.HasEnough(cost))
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.SolarSchool;
				ELogAuthor author2 = ELogAuthor.LRC;
				string message2 = "[SolarSchool] 一番赏货币不足";
				<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("kujiId", kujiId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("costId", cost.Id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("need", cost.Num);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("have", this.GetCurrencyCount(cost));
				instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
				return null;
			}
			SolarSchoolPrizeDrawingCenter.EDrawFilter edrawFilter = this.ResolveDrawFilter(kujiId);
			PrizeAwardsGroup prizeAwardsGroup;
			if (!this.TryPickGroup(kujiId, edrawFilter, out prizeAwardsGroup) && edrawFilter != SolarSchoolPrizeDrawingCenter.EDrawFilter.All && !this.TryPickGroup(kujiId, SolarSchoolPrizeDrawingCenter.EDrawFilter.All, out prizeAwardsGroup))
			{
				return null;
			}
			int rewardId = prizeAwardsGroup.RewardId;
			this.ConsumeCurrency(cost);
			SolarSchoolPrizeDrawingCenter.Model.AddItem(rewardId, 1);
			SolarSchoolPrizeDrawingCenter.Data.AddDrawn(prizeAwardsGroup.Id, 1);
			EventSystem.Instance.Emit(EEventName.OnPrizeDrawingRewardStatusChanged);
			if (prizeAwardsGroup.Rank == 0)
			{
				SolarSchoolPrizeDrawingCenter.Data.ResetNoSCount();
			}
			else
			{
				SolarSchoolPrizeDrawingCenter.Data.IncNoSCount();
			}
			return new SolarSchoolPrizeAwardData
			{
				ItemId = rewardId,
				Count = 1,
				Times = 1,
				Rare = prizeAwardsGroup.Rank
			};
		}

		// Token: 0x06038429 RID: 230441 RVA: 0x00FBAF84 File Offset: 0x00FB9184
		private SolarSchoolPrizeDrawingCenter.EDrawFilter ResolveDrawFilter(int kujiId)
		{
			PrizeActivity? activityConfig = this.GetActivityConfig();
			if (activityConfig == null)
			{
				return SolarSchoolPrizeDrawingCenter.EDrawFilter.All;
			}
			int notSGroup = activityConfig.Value.NotSGroup;
			int mustSGroup = activityConfig.Value.MustSGroup;
			if (this.GetCurrentProgress(kujiId) < notSGroup)
			{
				return SolarSchoolPrizeDrawingCenter.EDrawFilter.NonS;
			}
			if (mustSGroup > 0 && SolarSchoolPrizeDrawingCenter.Data.GetNoSCount() >= mustSGroup)
			{
				return SolarSchoolPrizeDrawingCenter.EDrawFilter.OnlyS;
			}
			return SolarSchoolPrizeDrawingCenter.EDrawFilter.All;
		}

		// Token: 0x0603842A RID: 230442 RVA: 0x00FBAFE4 File Offset: 0x00FB91E4
		private static bool MatchFilter(SolarSchoolPrizeDrawingCenter.EDrawFilter filter, int rank)
		{
			bool result;
			if (filter != SolarSchoolPrizeDrawingCenter.EDrawFilter.NonS)
			{
				result = (filter != SolarSchoolPrizeDrawingCenter.EDrawFilter.OnlyS || rank == 0);
			}
			else
			{
				result = (rank != 0);
			}
			return result;
		}

		// Token: 0x0603842B RID: 230443 RVA: 0x00FBB00C File Offset: 0x00FB920C
		private bool TryPickGroup(int kujiId, SolarSchoolPrizeDrawingCenter.EDrawFilter filter, out PrizeAwardsGroup picked)
		{
			picked = default(PrizeAwardsGroup);
			long num = 0L;
			foreach (PrizeAwardsGroup group in this.GetAllAwardGroup(kujiId))
			{
				num += (long)this.GetPickWeight(group, filter);
			}
			if (num <= 0L)
			{
				return false;
			}
			long num2 = (long)RandomSystem.GetRandomInteger() % num;
			foreach (PrizeAwardsGroup prizeAwardsGroup in this.GetAllAwardGroup(kujiId))
			{
				int pickWeight = this.GetPickWeight(prizeAwardsGroup, filter);
				if (pickWeight > 0)
				{
					if (num2 < (long)pickWeight)
					{
						picked = prizeAwardsGroup;
						return true;
					}
					num2 -= (long)pickWeight;
				}
			}
			return false;
		}

		// Token: 0x0603842C RID: 230444 RVA: 0x00FBB0E0 File Offset: 0x00FB92E0
		private int GetPickWeight(PrizeAwardsGroup group, SolarSchoolPrizeDrawingCenter.EDrawFilter filter)
		{
			if (!SolarSchoolPrizeDrawingCenter.MatchFilter(filter, group.Rank))
			{
				return 0;
			}
			if (group.Amount - this.GetDrawnCount(group.Id) <= 0)
			{
				return 0;
			}
			if (group.Weight <= 0)
			{
				return 0;
			}
			return group.Weight;
		}

		// Token: 0x17006BD2 RID: 27602
		// (get) Token: 0x0603842D RID: 230445 RVA: 0x00FBB120 File Offset: 0x00FB9320
		public static SolarSchoolPrizeDrawingCenter Instance
		{
			get
			{
				if (SolarSchoolPrizeDrawingCenter._instance == null)
				{
					SolarSchoolPrizeDrawingCenter._instance = new SolarSchoolPrizeDrawingCenter();
					SolarSchoolPrizeDrawingCenter._instance.OnInit();
				}
				return SolarSchoolPrizeDrawingCenter._instance;
			}
		}

		// Token: 0x0603842E RID: 230446 RVA: 0x00FBB143 File Offset: 0x00FB9343
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603842F RID: 230447 RVA: 0x00FBB145 File Offset: 0x00FB9345
		public static void ResetStaticDefaultValue()
		{
			SolarSchoolPrizeDrawingCenter instance = SolarSchoolPrizeDrawingCenter._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			SolarSchoolPrizeDrawingCenter._instance = null;
		}

		// Token: 0x06038430 RID: 230448 RVA: 0x00FBB15E File Offset: 0x00FB935E
		static SolarSchoolPrizeDrawingCenter()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SolarSchoolPrizeDrawingCenter.CreateStaticDefaultValue), new Action(SolarSchoolPrizeDrawingCenter.ResetStaticDefaultValue));
		}

		// Token: 0x0401DA16 RID: 121366
		public const int CostItemCount = 1;

		// Token: 0x0401DA17 RID: 121367
		[Nullable(2)]
		private static SolarSchoolPrizeDrawingCenter _instance;

		// Token: 0x0200B4E9 RID: 46313
		[NullableContext(0)]
		private enum EDrawFilter
		{
			// Token: 0x04037EFA RID: 229114
			All,
			// Token: 0x04037EFB RID: 229115
			NonS,
			// Token: 0x04037EFC RID: 229116
			OnlyS
		}
	}
}
