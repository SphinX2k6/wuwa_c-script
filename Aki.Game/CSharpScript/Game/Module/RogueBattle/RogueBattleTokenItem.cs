using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Roguelike;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02003E83 RID: 16003
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RogueBattleTokenItem : GridProxyAbstract<RogueResGainData>
	{
		// Token: 0x06028A71 RID: 166513 RVA: 0x00B694C4 File Offset: 0x00B676C4
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
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(5, new Action<EToggleState>(this.ToggleCallBackInternal))
			};
		}

		// Token: 0x06028A72 RID: 166514 RVA: 0x00B695F4 File Offset: 0x00B677F4
		protected override void OnStart()
		{
			this.ElementLayout = new GenericLayout<RogueBattleTokenElement, int>(base.GetHorizontalLayout(3), () => new RogueBattleTokenElement(), null, false, true);
			base.GetItem(10).SetUIActive(false);
		}

		// Token: 0x06028A73 RID: 166515 RVA: 0x00B69643 File Offset: 0x00B67843
		protected override void OnBeforeShow()
		{
			EventSystem.Instance.Add(EEventName.RogueBattleDescModeChange, new Action(this.RefreshDescText));
		}

		// Token: 0x06028A74 RID: 166516 RVA: 0x00B69661 File Offset: 0x00B67861
		protected override void OnBeforeHide()
		{
			EventSystem.Instance.Remove(EEventName.RogueBattleDescModeChange, new Action(this.RefreshDescText));
		}

		// Token: 0x06028A75 RID: 166517 RVA: 0x00B69680 File Offset: 0x00B67880
		private void ToggleCallBackInternal(EToggleState state)
		{
			if (base.GetExtendToggle(5).GetToggleState() == EToggleState.ETT_Checked)
			{
				this.OnSelected(true);
				Action<int?> onClickHandle = this.OnClickHandle;
				if (onClickHandle == null)
				{
					return;
				}
				onClickHandle(new int?(base.GridIndex));
				return;
			}
			else
			{
				this.OnDeselected(true);
				Action<int?> onClickHandle2 = this.OnClickHandle;
				if (onClickHandle2 == null)
				{
					return;
				}
				onClickHandle2(null);
				return;
			}
		}

		// Token: 0x06028A76 RID: 166518 RVA: 0x00B696E0 File Offset: 0x00B678E0
		[NullableContext(1)]
		public override void Refresh(RogueResGainData data, bool isSelected, int gridIndex)
		{
			RogueBattleTokenItem.<>c__DisplayClass8_0 CS$<>8__locals1 = new RogueBattleTokenItem.<>c__DisplayClass8_0();
			CS$<>8__locals1.data = data;
			CS$<>8__locals1.<>4__this = this;
			if (CS$<>8__locals1.data.RogueResToken == null)
			{
				Log.Instance.Error(ELogModule.RogueBattle, ELogAuthor.LPH, "RogueBattleTokenItem.Refresh data.RogueResToken is null", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.GainData = CS$<>8__locals1.data;
			RogueResToken rogueResToken = CS$<>8__locals1.data.RogueResToken;
			base.GetItem(6).SetUIActive(rogueResToken.IsNew);
			RogueResBuffPool? rogueResBuffPoolById = RogueBattleConfig.Instance.GetRogueResBuffPoolById(rogueResToken.ConfigId);
			if (rogueResBuffPoolById == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RogueBattle;
				ELogAuthor author = ELogAuthor.LPH;
				string message = "RogueBattleTokenItem.Refresh tokenConfig is null";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ConfigId", rogueResToken.ConfigId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			base.GetText(2).ShowTextNew(rogueResBuffPoolById.Value.BuffName);
			base.SetTextureByPath(rogueResBuffPoolById.Value.BuffIcon, base.GetTexture(1), null, null);
			RogueWeekQualityConfig? rogueWeeklyQualityConfig = WeeklyRogueConfig.Instance.GetRogueWeeklyQualityConfig(rogueResBuffPoolById.Value.Quality);
			if (rogueWeeklyQualityConfig != null)
			{
				base.SetTextureByPath(rogueWeeklyQualityConfig.Value.TokenBg, base.GetTexture(0), null, null);
				base.GetSprite(7).SetColor(FColor.FromHex(rogueWeeklyQualityConfig.Value.TokenColor));
			}
			base.GetItem(8).SetUIActive(rogueResBuffPoolById.Value.Quality == 6);
			base.GetItem(9).SetUIActive(rogueResBuffPoolById.Value.Quality == 5);
			this.RefreshDescText();
			UiAsyncTask task = new UiAsyncTask("RogueBattleTokenItem.Refresh", delegate()
			{
				RogueBattleTokenItem.<>c__DisplayClass8_0.<<Refresh>b__0>d <<Refresh>b__0>d;
				<<Refresh>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<Refresh>b__0>d.<>4__this = CS$<>8__locals1;
				<<Refresh>b__0>d.<>1__state = -1;
				<<Refresh>b__0>d.<>t__builder.Start<RogueBattleTokenItem.<>c__DisplayClass8_0.<<Refresh>b__0>d>(ref <<Refresh>b__0>d);
				return <<Refresh>b__0>d.<>t__builder.Task;
			}, null);
			base.RunAsyncTask(task);
		}

		// Token: 0x06028A77 RID: 166519 RVA: 0x00B698C0 File Offset: 0x00B67AC0
		public void RefreshDescText()
		{
			if (this.GainData == null)
			{
				return;
			}
			RogueResToken rogueResToken = this.GainData.RogueResToken;
			RogueResBuffPool? rogueResBuffPoolById = RogueBattleConfig.Instance.GetRogueResBuffPoolById(rogueResToken.ConfigId);
			if (rogueResBuffPoolById == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RogueBattle;
				ELogAuthor author = ELogAuthor.LPH;
				string message = "RogueBattleTokenItem.RefreshDescText tokenConfig is null";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ConfigId", rogueResToken.ConfigId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			if (RogueBattleModel.Instance.DescMode == EDescModel.SIMPLE)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(4), rogueResBuffPoolById.Value.BuffDescSimple, Array.Empty<object>());
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), rogueResBuffPoolById.Value.BuffDesc, rogueResBuffPoolById.Value.BuffDescParam());
		}

		// Token: 0x06028A78 RID: 166520 RVA: 0x00B69992 File Offset: 0x00B67B92
		public override void OnSelected(bool fireEvent)
		{
			RogueBattleModel.Instance.SelectGainData = this.GainData;
			base.GetExtendToggle(5).SetToggleState(EToggleState.ETT_Checked, false, false, false);
		}

		// Token: 0x06028A79 RID: 166521 RVA: 0x00B699B5 File Offset: 0x00B67BB5
		public override void OnDeselected(bool fireEvent)
		{
			RogueBattleModel.Instance.SelectGainData = null;
			base.GetExtendToggle(5).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x040161D9 RID: 90585
		public RogueResGainData GainData;

		// Token: 0x040161DA RID: 90586
		public Action<int?> OnClickHandle;

		// Token: 0x040161DB RID: 90587
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<RogueBattleTokenElement, int> ElementLayout;
	}
}
