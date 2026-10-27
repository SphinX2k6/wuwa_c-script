using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RacingBets.Data;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RacingBets.View.Item.RacingBetsMatchTable
{
	// Token: 0x02004F29 RID: 20265
	[NullableContext(1)]
	[Nullable(0)]
	public class RacingBetsMatchItem : RacingBetsMatchItemBase
	{
		// Token: 0x06033FAE RID: 212910 RVA: 0x00C2F654 File Offset: 0x00C2D854
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

		// Token: 0x06033FAF RID: 212911 RVA: 0x00C2F6C0 File Offset: 0x00C2D8C0
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

		// Token: 0x06033FB0 RID: 212912 RVA: 0x00C2F8C4 File Offset: 0x00C2DAC4
		protected override UniTask OnBeforeStartAsync()
		{
			RacingBetsMatchItem.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RacingBetsMatchItem.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033FB1 RID: 212913 RVA: 0x00C2F908 File Offset: 0x00C2DB08
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

		// Token: 0x06033FB2 RID: 212914 RVA: 0x00C2FAC0 File Offset: 0x00C2DCC0
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

		// Token: 0x06033FB3 RID: 212915 RVA: 0x00C2FBE9 File Offset: 0x00C2DDE9
		public void SetMatchId(int matchId)
		{
			this.GroupMatchId = matchId;
			this.MatchData = RacingBetsModel.Instance.GetRacingBetsGroupMatchData(this.GroupMatchId);
		}

		// Token: 0x06033FB4 RID: 212916 RVA: 0x00C2FC08 File Offset: 0x00C2DE08
		private void OnFirstHalfMatchReplayClick()
		{
			RacingBetsSeasonData racingBetsSeasonData = RacingBetsModel.Instance.GetRacingBetsSeasonData();
			RacingBetsLegMatchData racingBetsLegMatchData = this.MatchData.GetLegMatchList()[0];
			RacingBetsController.Instance.RacingBetMatchActionRequest(racingBetsSeasonData.Id, racingBetsLegMatchData.Id);
		}

		// Token: 0x06033FB5 RID: 212917 RVA: 0x00C2FC48 File Offset: 0x00C2DE48
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

		// Token: 0x0401B9BC RID: 113084
		private static readonly Dictionary<ERacingBetsMatchType, string> TypeToBgPath;

		// Token: 0x0401B9BD RID: 113085
		private static readonly Dictionary<ERacingBetsMatchType, string> TypeToEmojiPath;

		// Token: 0x0401B9BE RID: 113086
		public int GroupMatchId;

		// Token: 0x0401B9BF RID: 113087
		public ERacingBetsMatchType MatchType;

		// Token: 0x0401B9C0 RID: 113088
		private RacingBetsGroupMatchData MatchData;

		// Token: 0x0200B07F RID: 45183
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x0403590F RID: 219407
			public const int TextureBg = 0;

			// Token: 0x04035910 RID: 219408
			public const int SpriteEmoji = 1;

			// Token: 0x04035911 RID: 219409
			public const int TextName = 2;

			// Token: 0x04035912 RID: 219410
			public const int LayoutDango = 3;

			// Token: 0x04035913 RID: 219411
			public const int ItemRole = 4;

			// Token: 0x04035914 RID: 219412
			public const int ItemOneLegMatchPanel = 5;

			// Token: 0x04035915 RID: 219413
			public const int ItemOneLegMatchRacing = 6;

			// Token: 0x04035916 RID: 219414
			public const int BtnOneLegMatchReplay = 7;

			// Token: 0x04035917 RID: 219415
			public const int TextLegMatchName = 8;

			// Token: 0x04035918 RID: 219416
			public const int TextDate = 9;

			// Token: 0x04035919 RID: 219417
			public const int ItemTwoLegMatchPanel = 10;

			// Token: 0x0403591A RID: 219418
			public const int ItemFirstHaltMatchRacing = 11;

			// Token: 0x0403591B RID: 219419
			public const int ItemSecondHaltMatchRacing = 12;

			// Token: 0x0403591C RID: 219420
			public const int BtnFirstHaltMatchReplay = 13;

			// Token: 0x0403591D RID: 219421
			public const int TextFirstHaltName = 14;

			// Token: 0x0403591E RID: 219422
			public const int TextFirstHaltDate = 15;

			// Token: 0x0403591F RID: 219423
			public const int BtnSecondHaltMatchReplay = 16;

			// Token: 0x04035920 RID: 219424
			public const int TextSecondHaltName = 17;

			// Token: 0x04035921 RID: 219425
			public const int TextSecondHaltDate = 18;
		}
	}
}
