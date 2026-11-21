using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RacingBets.Data;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RacingBets.View.Item.RacingBetsMatchTable
{
	// Token: 0x02003EF2 RID: 16114
	[NullableContext(1)]
	[Nullable(0)]
	public class RacingBetsMatchItem : RacingBetsMatchItemBase
	{
		// Token: 0x06028E1C RID: 167452 RVA: 0x00B78DFC File Offset: 0x00B76FFC
		static RacingBetsMatchItem()
		{
			Dictionary<ERacingBetsMatchType, string> dictionary = new Dictionary<ERacingBetsMatchType, string>();
			dictionary[ERacingBetsMatchType.Normal] = "/Game/Aki/UI/UIResources/UiActivity/Image/ActivityRacehorse/T_MatchTableBgA.T_MatchTableBgA";
			dictionary[ERacingBetsMatchType.Failure] = "/Game/Aki/UI/UIResources/UiActivity/Image/ActivityRacehorse/T_MatchTableBgD.T_MatchTableBgD";
			dictionary[ERacingBetsMatchType.Farewell] = "/Game/Aki/UI/UIResources/UiActivity/Image/ActivityRacehorse/T_MatchTableBgC.T_MatchTableBgC";
			RacingBetsMatchItem.TypeToBgPath = dictionary;
			Dictionary<ERacingBetsMatchType, string> dictionary2 = new Dictionary<ERacingBetsMatchType, string>();
			dictionary2[ERacingBetsMatchType.Normal] = "/Game/Aki/UI/UIResources/UiActivity/Atlas/ActivityRacehorse/SP_StateIconA.SP_StateIconA";
			dictionary2[ERacingBetsMatchType.Failure] = "/Game/Aki/UI/UIResources/UiActivity/Atlas/ActivityRacehorse/SP_StateIconD.SP_StateIconD";
			dictionary2[ERacingBetsMatchType.Farewell] = "/Game/Aki/UI/UIResources/UiActivity/Atlas/ActivityRacehorse/SP_StateIconC.SP_StateIconC";
			RacingBetsMatchItem.TypeToEmojiPath = dictionary2;
		}

		// Token: 0x06028E1D RID: 167453 RVA: 0x00B78E68 File Offset: 0x00B77068
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUITexture)),
				new ValueTuple<int, Type>(1, typeof(UUISprite)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUIHorizontalLayout)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(8, typeof(UUIText)),
				new ValueTuple<int, Type>(9, typeof(UUIText)),
				new ValueTuple<int, Type>(10, typeof(UUIItem)),
				new ValueTuple<int, Type>(11, typeof(UUIItem)),
				new ValueTuple<int, Type>(12, typeof(UUIItem)),
				new ValueTuple<int, Type>(13, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(14, typeof(UUIText)),
				new ValueTuple<int, Type>(15, typeof(UUIText)),
				new ValueTuple<int, Type>(16, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(17, typeof(UUIText)),
				new ValueTuple<int, Type>(18, typeof(UUIText))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(13, new Action(this.OnFirstHalfMatchReplayClick)),
				new ValueTuple<int, Delegate>(16, new Action(this.OnSecondHalfMatchReplayClick)),
				new ValueTuple<int, Delegate>(7, new Action(this.OnFirstHalfMatchReplayClick))
			};
		}

		// Token: 0x06028E1E RID: 167454 RVA: 0x00B7906C File Offset: 0x00B7726C
		protected override UniTask OnBeforeStartAsync()
		{
			RacingBetsMatchItem.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RacingBetsMatchItem.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06028E1F RID: 167455 RVA: 0x00B790B0 File Offset: 0x00B772B0
		protected override void OnBeforeShow()
		{
			base.OnBeforeShow();
			string path;
			if (RacingBetsMatchItem.TypeToBgPath.TryGetValue(this.MatchType, out path))
			{
				base.SetTextureByPath(path, base.GetTexture(0), null, null);
			}
			string path2;
			if (RacingBetsMatchItem.TypeToEmojiPath.TryGetValue(this.MatchType, out path2))
			{
				this.SetSpriteByPath(path2, base.GetSprite(1), false, null, null);
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), this.MatchData.Name, Array.Empty<object>());
			List<RacingBetsLegMatchData> legMatchList = this.MatchData.GetLegMatchList();
			RacingBetsLegMatchData racingBetsLegMatchData = legMatchList[0];
			RacingBetsLegMatchData racingBetsLegMatchData2 = (legMatchList.Count > 1) ? legMatchList[1] : null;
			UUIItem item = base.GetItem(5);
			if (item != null)
			{
				item.SetUIActive(racingBetsLegMatchData2 == null);
			}
			UUIItem item2 = base.GetItem(10);
			if (item2 != null)
			{
				item2.SetUIActive(racingBetsLegMatchData2 != null);
			}
			UUIText text = base.GetText(9);
			if (text != null)
			{
				text.SetText(TimeUtil.Instance.DateFormat6String(racingBetsLegMatchData.MatchStartTime), true);
			}
			UUIText text2 = base.GetText(15);
			if (text2 != null)
			{
				text2.SetText(TimeUtil.Instance.DateFormat6String(racingBetsLegMatchData.MatchStartTime), true);
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(8), racingBetsLegMatchData.SimpleName, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(14), racingBetsLegMatchData.SimpleName, Array.Empty<object>());
			if (racingBetsLegMatchData2 != null)
			{
				UUIText text3 = base.GetText(18);
				if (text3 != null)
				{
					text3.SetText(TimeUtil.Instance.DateFormat6String(racingBetsLegMatchData2.MatchStartTime), true);
				}
				LguiUtil.Instance.SetLocalTextNew(base.GetText(17), racingBetsLegMatchData2.SimpleName, Array.Empty<object>());
			}
			this.RefreshStatus();
		}

		// Token: 0x06028E20 RID: 167456 RVA: 0x00B79268 File Offset: 0x00B77468
		public void RefreshStatus()
		{
			List<RacingBetsLegMatchData> legMatchList = this.MatchData.GetLegMatchList();
			RacingBetsLegMatchData racingBetsLegMatchData = legMatchList[0];
			RacingBetsLegMatchData racingBetsLegMatchData2 = (legMatchList.Count > 1) ? legMatchList[1] : null;
			RacingBetsLegMatchData curLegMatchData = RacingBetsModel.Instance.GetRacingBetsSeasonData().GetCurLegMatchData();
			if (curLegMatchData != null)
			{
				UUIItem item = base.GetItem(6);
				if (item != null)
				{
					item.SetUIActive(curLegMatchData.Id == racingBetsLegMatchData.Id);
				}
				UUIItem item2 = base.GetItem(11);
				if (item2 != null)
				{
					item2.SetUIActive(curLegMatchData.Id == racingBetsLegMatchData.Id);
				}
				UUIItem item3 = base.GetItem(12);
				if (item3 != null)
				{
					item3.SetUIActive(racingBetsLegMatchData2 != null && curLegMatchData.Id == racingBetsLegMatchData2.Id);
				}
			}
			UUIButtonComponent button = base.GetButton(7);
			if (button != null)
			{
				button.RootUIComp.Get().SetUIActive(racingBetsLegMatchData.IsLegMatchFinished());
			}
			UUIButtonComponent button2 = base.GetButton(13);
			if (button2 != null)
			{
				button2.RootUIComp.Get().SetUIActive(racingBetsLegMatchData.IsLegMatchFinished());
			}
			UUIButtonComponent button3 = base.GetButton(16);
			if (button3 == null)
			{
				return;
			}
			button3.RootUIComp.Get().SetUIActive(racingBetsLegMatchData2 != null && racingBetsLegMatchData2.IsLegMatchFinished());
		}

		// Token: 0x06028E21 RID: 167457 RVA: 0x00B79391 File Offset: 0x00B77591
		public void SetMatchId(int matchId)
		{
			this.GroupMatchId = matchId;
			this.MatchData = RacingBetsModel.Instance.GetRacingBetsGroupMatchData(this.GroupMatchId);
		}

		// Token: 0x06028E22 RID: 167458 RVA: 0x00B793B0 File Offset: 0x00B775B0
		private void OnFirstHalfMatchReplayClick()
		{
			RacingBetsSeasonData racingBetsSeasonData = RacingBetsModel.Instance.GetRacingBetsSeasonData();
			RacingBetsLegMatchData racingBetsLegMatchData = this.MatchData.GetLegMatchList()[0];
			RacingBetsController.Instance.RacingBetMatchActionRequest(racingBetsSeasonData.Id, racingBetsLegMatchData.Id);
		}

		// Token: 0x06028E23 RID: 167459 RVA: 0x00B793F0 File Offset: 0x00B775F0
		private void OnSecondHalfMatchReplayClick()
		{
			RacingBetsSeasonData racingBetsSeasonData = RacingBetsModel.Instance.GetRacingBetsSeasonData();
			List<RacingBetsLegMatchData> legMatchList = this.MatchData.GetLegMatchList();
			if (legMatchList.Count > 1)
			{
				RacingBetsLegMatchData racingBetsLegMatchData = legMatchList[1];
				RacingBetsController.Instance.RacingBetMatchActionRequest(racingBetsSeasonData.Id, racingBetsLegMatchData.Id);
			}
		}

		// Token: 0x04016391 RID: 91025
		private static readonly Dictionary<ERacingBetsMatchType, string> TypeToBgPath;

		// Token: 0x04016392 RID: 91026
		private static readonly Dictionary<ERacingBetsMatchType, string> TypeToEmojiPath;

		// Token: 0x04016393 RID: 91027
		public int GroupMatchId;

		// Token: 0x04016394 RID: 91028
		public ERacingBetsMatchType MatchType;

		// Token: 0x04016395 RID: 91029
		private RacingBetsGroupMatchData MatchData;

		// Token: 0x02009AAF RID: 39599
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x0403033A RID: 197434
			public const int TextureBg = 0;

			// Token: 0x0403033B RID: 197435
			public const int SpriteEmoji = 1;

			// Token: 0x0403033C RID: 197436
			public const int TextName = 2;

			// Token: 0x0403033D RID: 197437
			public const int LayoutDango = 3;

			// Token: 0x0403033E RID: 197438
			public const int ItemRole = 4;

			// Token: 0x0403033F RID: 197439
			public const int ItemOneLegMatchPanel = 5;

			// Token: 0x04030340 RID: 197440
			public const int ItemOneLegMatchRacing = 6;

			// Token: 0x04030341 RID: 197441
			public const int BtnOneLegMatchReplay = 7;

			// Token: 0x04030342 RID: 197442
			public const int TextLegMatchName = 8;

			// Token: 0x04030343 RID: 197443
			public const int TextDate = 9;

			// Token: 0x04030344 RID: 197444
			public const int ItemTwoLegMatchPanel = 10;

			// Token: 0x04030345 RID: 197445
			public const int ItemFirstHaltMatchRacing = 11;

			// Token: 0x04030346 RID: 197446
			public const int ItemSecondHaltMatchRacing = 12;

			// Token: 0x04030347 RID: 197447
			public const int BtnFirstHaltMatchReplay = 13;

			// Token: 0x04030348 RID: 197448
			public const int TextFirstHaltName = 14;

			// Token: 0x04030349 RID: 197449
			public const int TextFirstHaltDate = 15;

			// Token: 0x0403034A RID: 197450
			public const int BtnSecondHaltMatchReplay = 16;

			// Token: 0x0403034B RID: 197451
			public const int TextSecondHaltName = 17;

			// Token: 0x0403034C RID: 197452
			public const int TextSecondHaltDate = 18;
		}
	}
}
