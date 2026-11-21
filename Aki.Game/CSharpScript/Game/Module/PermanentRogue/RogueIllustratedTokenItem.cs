using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RogueBattle;
using CSharpScript.Game.Module.Roguelike;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PermanentRogue
{
	// Token: 0x020042EE RID: 17134
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RogueIllustratedTokenItem : GridProxyAbstract<RogueResGainData>
	{
		// Token: 0x0602B5A4 RID: 177572 RVA: 0x00C2EA4C File Offset: 0x00C2CC4C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUITexture)),
				new ValueTuple<int, Type>(1, typeof(UUITexture)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUIHorizontalLayout)),
				new ValueTuple<int, Type>(4, typeof(UUIText)),
				new ValueTuple<int, Type>(5, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUIItem)),
				new ValueTuple<int, Type>(9, typeof(UUIItem)),
				new ValueTuple<int, Type>(10, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUISprite))
			};
		}

		// Token: 0x0602B5A5 RID: 177573 RVA: 0x00C2EB58 File Offset: 0x00C2CD58
		protected override void OnBeforeShow()
		{
			EventSystem.Instance.Add(EEventName.RogueBattleDescModeChange, new Action(this.RefreshDescText));
		}

		// Token: 0x0602B5A6 RID: 177574 RVA: 0x00C2EB76 File Offset: 0x00C2CD76
		protected override void OnBeforeHide()
		{
			EventSystem.Instance.Remove(EEventName.RogueBattleDescModeChange, new Action(this.RefreshDescText));
		}

		// Token: 0x0602B5A7 RID: 177575 RVA: 0x00C2EB94 File Offset: 0x00C2CD94
		protected override void OnStart()
		{
			this.ElementLayout = new GenericLayout<RogueBattleTokenElement, int>(base.GetHorizontalLayout(3), () => new RogueBattleTokenElement(), null, false, true);
			base.GetExtendToggle(5).SetEnable(false);
			base.GetExtendToggle(5).SetToggleState(EToggleState.ETT_UnDetermined, false, false, false);
			base.GetItem(6).SetUIActive(false);
		}

		// Token: 0x0602B5A8 RID: 177576 RVA: 0x00C2EC00 File Offset: 0x00C2CE00
		[NullableContext(1)]
		public override void Refresh(RogueResGainData data, bool isSelected, int gridIndex)
		{
			RogueIllustratedTokenItem.<>c__DisplayClass8_0 CS$<>8__locals1 = new RogueIllustratedTokenItem.<>c__DisplayClass8_0();
			CS$<>8__locals1.data = data;
			CS$<>8__locals1.<>4__this = this;
			if (CS$<>8__locals1.data.RogueResToken == null)
			{
				Log.Instance.Error(ELogModule.RogueBattle, ELogAuthor.LPH, "RogueBattleTokenItem.Refresh data.RogueResToken is null", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			RogueResToken rogueResToken = CS$<>8__locals1.data.RogueResToken;
			RogueBattleConfig instance = RogueBattleConfig.Instance;
			RogueResBuffPool? rogueResBuffPool = (instance != null) ? instance.GetRogueResBuffPoolById(rogueResToken.ConfigId) : null;
			if (rogueResBuffPool == null)
			{
				return;
			}
			this.GainData = CS$<>8__locals1.data;
			RogueResCollection? config = ConfigRogueResCollectionById.GetConfig(rogueResToken.ConfigId, true);
			SignState collectItemState = ActivityPermanentRogueModel.Instance.GetCollectItemState(config.Value.IdKey);
			this.IsUnlock = (collectItemState > SignState.Lock);
			base.GetText(2).ShowTextNew(this.IsUnlock ? rogueResBuffPool.Value.BuffName : "RogueRes_CollectionEventLock");
			base.SetTextureByPath(rogueResBuffPool.Value.BuffIcon, base.GetTexture(1), null, null);
			WeeklyRogueConfig instance2 = WeeklyRogueConfig.Instance;
			RogueWeekQualityConfig? rogueWeekQualityConfig = (instance2 != null) ? instance2.GetRogueWeeklyQualityConfig(rogueResBuffPool.Value.Quality) : null;
			if (rogueWeekQualityConfig != null)
			{
				base.SetTextureByPath(rogueWeekQualityConfig.Value.TokenBg, base.GetTexture(0), null, null);
			}
			base.GetSprite(7).SetColor(FColor.FromHex(rogueWeekQualityConfig.Value.TokenColor));
			base.GetItem(8).SetUIActive(rogueResBuffPool.Value.Quality == 6);
			base.GetItem(9).SetUIActive(rogueResBuffPool.Value.Quality == 5);
			this.RefreshDescText();
			UiAsyncTask task = new UiAsyncTask("RogueBattleTokenItem.Refresh", delegate()
			{
				RogueIllustratedTokenItem.<>c__DisplayClass8_0.<<Refresh>b__0>d <<Refresh>b__0>d;
				<<Refresh>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<Refresh>b__0>d.<>4__this = CS$<>8__locals1;
				<<Refresh>b__0>d.<>1__state = -1;
				<<Refresh>b__0>d.<>t__builder.Start<RogueIllustratedTokenItem.<>c__DisplayClass8_0.<<Refresh>b__0>d>(ref <<Refresh>b__0>d);
				return <<Refresh>b__0>d.<>t__builder.Task;
			}, null);
			base.RunAsyncTask(task);
		}

		// Token: 0x0602B5A9 RID: 177577 RVA: 0x00C2EE00 File Offset: 0x00C2D000
		public void RefreshDescText()
		{
			if (this.GainData == null)
			{
				return;
			}
			if (!this.IsUnlock)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(4), "RogueRes_CollectionEventLock", Array.Empty<object>());
				return;
			}
			RogueResToken rogueResToken = this.GainData.RogueResToken;
			RogueBattleConfig instance = RogueBattleConfig.Instance;
			RogueResBuffPool? rogueResBuffPool = (instance != null) ? instance.GetRogueResBuffPoolById(rogueResToken.ConfigId) : null;
			if (rogueResBuffPool == null)
			{
				return;
			}
			if (RogueBattleModel.Instance.DescMode == EDescModel.SIMPLE)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(4), rogueResBuffPool.Value.BuffDescSimple, Array.Empty<object>());
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), rogueResBuffPool.Value.BuffDesc, rogueResBuffPool.Value.BuffDescParam());
		}

		// Token: 0x0401766E RID: 95854
		public RogueResGainData GainData;

		// Token: 0x0401766F RID: 95855
		public Action<int?> OnClickHandle;

		// Token: 0x04017670 RID: 95856
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<RogueBattleTokenElement, int> ElementLayout;

		// Token: 0x04017671 RID: 95857
		private bool IsUnlock;
	}
}
