using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.MapRogue;
using CSharpScript.Game.Module.PermanentRogue;
using CSharpScript.Game.Ui;
using CSharpScript.Module.InstanceDungeon;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02003ECA RID: 16074
	[NullableContext(2)]
	[Nullable(0)]
	public class RogueBattleSettleView : UiViewBase
	{
		// Token: 0x06028C4A RID: 166986 RVA: 0x00B6FFFD File Offset: 0x00B6E1FD
		[NullableContext(1)]
		public RogueBattleSettleView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06028C4B RID: 166987 RVA: 0x00B70008 File Offset: 0x00B6E208
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(8, typeof(UUIText)),
				new ValueTuple<int, Type>(9, typeof(UUIText)),
				new ValueTuple<int, Type>(10, typeof(UUIText)),
				new ValueTuple<int, Type>(11, typeof(UUIText)),
				new ValueTuple<int, Type>(12, typeof(UUIItem)),
				new ValueTuple<int, Type>(13, typeof(UUISprite))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action(this.OnClickBtnLeft)),
				new ValueTuple<int, Delegate>(1, new Action(this.OnClickBtnRight)),
				new ValueTuple<int, Delegate>(7, new Action(this.OnClickBtnMask)),
				new ValueTuple<int, Delegate>(3, new Action(this.OnClickBtnMask))
			};
		}

		// Token: 0x06028C4C RID: 166988 RVA: 0x00B701C4 File Offset: 0x00B6E3C4
		private void OnClickBtnLeft()
		{
			this.PageIndex--;
			this.RefreshPanel();
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.PlayLevelSequenceByName("SwitchL", false, null, false);
		}

		// Token: 0x06028C4D RID: 166989 RVA: 0x00B70208 File Offset: 0x00B6E408
		private void OnClickBtnRight()
		{
			this.PageIndex++;
			this.RefreshPanel();
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.PlayLevelSequenceByName("SwitchR", false, null, false);
		}

		// Token: 0x06028C4E RID: 166990 RVA: 0x00B7024C File Offset: 0x00B6E44C
		private void OnClickBtnMask()
		{
			if (this.PageIndex == 0)
			{
				this.OnClickBtnRight();
				return;
			}
			if (MapRogueController.Instance.CheckInMapRogueInstance())
			{
				int instanceId = InstanceDungeonEntranceModel.Instance.InstanceId;
				ActivityPermanentRogueController.Instance.SetReturnToWorld(instanceId);
				InstanceDungeonEntranceController.Instance.LeaveInstanceDungeon().Forget<bool>();
				return;
			}
			base.CloseMe(null);
		}

		// Token: 0x06028C4F RID: 166991 RVA: 0x00B702A4 File Offset: 0x00B6E4A4
		protected override UniTask OnBeforeStartAsync()
		{
			RogueBattleSettleView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RogueBattleSettleView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06028C50 RID: 166992 RVA: 0x00B702E8 File Offset: 0x00B6E4E8
		protected void RefreshDetail()
		{
			InstResultView instResultView = (InstResultView)this.OpenParam;
			if (instResultView == null)
			{
				return;
			}
			int teamLevel = instResultView.TeamLevel;
			int count = instResultView.Roles.Count;
			int num = 0;
			using (IEnumerator<RoleBondInfo> enumerator = instResultView.RoleBondInfos.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.Level != 0)
					{
						num++;
					}
				}
			}
			string textStringId = instResultView.IsSucc ? "RogueRes_Settle_Title_Success" : "RogueRes_Settle_Title_Fail";
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), textStringId, Array.Empty<object>());
			int num2 = 0;
			foreach (RogueResGainData rogueResGainData in instResultView.Roles)
			{
				num2 += rogueResGainData.RogueResRole.Level;
			}
			base.GetText(8).SetText(teamLevel.ToString(), true);
			base.GetText(9).SetText(count.ToString(), true);
			base.GetText(10).SetText(num2.ToString(), true);
			base.GetText(11).SetText(num.ToString(), true);
			base.GetItem(12).SetUIActive(instResultView.IsNewRecord);
			RogueResGridExplore? exploreByInstId = MapRogueConfig.Instance.GetExploreByInstId(instResultView.InstId);
			if (exploreByInstId != null)
			{
				int value = 0;
				foreach (DicIntInt dicIntInt in exploreByInstId.Value.RankMapIter())
				{
					int key = dicIntInt.Key;
					int value2 = dicIntInt.Value;
					if (instResultView.Score < value2)
					{
						value = key - 1;
						break;
					}
					value = key;
				}
				switch (value)
				{
				case 1:
					AudioSystem.Instance.SetState("ui_rogue_settle", "settle_c", true);
					break;
				case 2:
					AudioSystem.Instance.SetState("ui_rogue_settle", "settle_b", true);
					break;
				case 3:
					AudioSystem.Instance.SetState("ui_rogue_settle", "settle_a", true);
					break;
				case 4:
					AudioSystem.Instance.SetState("ui_rogue_settle", "settle_s", true);
					break;
				}
				AudioSystem.Instance.PostEvent("play_ui_fx_spl_rogue_accounts");
				UiResourceConfig instance = UiResourceConfig.Instance;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 1);
				defaultInterpolatedStringHandler.AppendLiteral("RogueRes_Settle_Rank_");
				defaultInterpolatedStringHandler.AppendFormatted<int>(value);
				string resourcePath = instance.GetResourcePath(defaultInterpolatedStringHandler.ToStringAndClear());
				base.TrySetSpriteByPath(resourcePath, base.GetSprite(13), false, null, null);
			}
		}

		// Token: 0x06028C51 RID: 166993 RVA: 0x00B705AC File Offset: 0x00B6E7AC
		protected void RefreshPanel()
		{
			RogueBattleSettleChallengeInfoPanel challengeInfoPanelComponent = this.ChallengeInfoPanelComponent;
			if (challengeInfoPanelComponent != null)
			{
				challengeInfoPanelComponent.GetRootItem().SetUIActive(this.PageIndex == 0);
			}
			RogueBattleSettleDataInfoPanel dataInfoPanelComponent = this.DataInfoPanelComponent;
			if (dataInfoPanelComponent != null)
			{
				dataInfoPanelComponent.GetRootItem().SetUIActive(this.PageIndex == 1);
			}
			base.GetButton(0).RootUIComp.Get().SetUIActive(this.PageIndex > 0);
			base.GetButton(1).RootUIComp.Get().SetUIActive(this.PageIndex < 1);
		}

		// Token: 0x040162E7 RID: 90855
		protected RogueBattleSettleChallengeInfoPanel ChallengeInfoPanelComponent;

		// Token: 0x040162E8 RID: 90856
		protected RogueBattleSettleDataInfoPanel DataInfoPanelComponent;

		// Token: 0x040162E9 RID: 90857
		protected int PageIndex;

		// Token: 0x040162EA RID: 90858
		protected LevelSequencePlayer LevelSequencePlayer;
	}
}
