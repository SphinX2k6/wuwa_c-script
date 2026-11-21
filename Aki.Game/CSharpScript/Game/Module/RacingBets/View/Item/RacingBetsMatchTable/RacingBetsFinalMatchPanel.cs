using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RacingBets.Data;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RacingBets.View.Item.RacingBetsMatchTable
{
	// Token: 0x02003EF0 RID: 16112
	public class RacingBetsFinalMatchPanel : UiPanelBase
	{
		// Token: 0x06028E0D RID: 167437 RVA: 0x00B78844 File Offset: 0x00B76A44
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIHorizontalLayout)),
				new ValueTuple<int, Type>(9, typeof(UUIItem)),
				new ValueTuple<int, Type>(10, typeof(UUITexture)),
				new ValueTuple<int, Type>(11, typeof(UUISprite)),
				new ValueTuple<int, Type>(12, typeof(UUIItem)),
				new ValueTuple<int, Type>(13, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(14, typeof(UUIText)),
				new ValueTuple<int, Type>(15, typeof(UUIText))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(13, new Action(this.OnReplayClick))
			};
		}

		// Token: 0x06028E0E RID: 167438 RVA: 0x00B789D1 File Offset: 0x00B76BD1
		protected override void OnBeforeCreate()
		{
			this.UiLevelSequence = new UiBehaviorLevelSequence(this);
			base.AddUiBehavior(this.UiLevelSequence);
		}

		// Token: 0x06028E0F RID: 167439 RVA: 0x00B789EC File Offset: 0x00B76BEC
		protected override UniTask OnBeforeStartAsync()
		{
			RacingBetsFinalMatchPanel.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RacingBetsFinalMatchPanel.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06028E10 RID: 167440 RVA: 0x00B78A30 File Offset: 0x00B76C30
		protected override void OnBeforeShow()
		{
			RacingBetsLegMatchData racingBetsLegMatchData = this.MatchData.GetLegMatchList()[0];
			UUIButtonComponent button = base.GetButton(13);
			if (button != null)
			{
				button.RootUIComp.Get().SetUIActive(racingBetsLegMatchData.IsLegMatchFinished());
			}
			UUIText text = base.GetText(14);
			if (text != null)
			{
				text.SetText(TimeUtil.Instance.DateFormat6String(racingBetsLegMatchData.MatchStartTime), true);
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(15), racingBetsLegMatchData.Name, Array.Empty<object>());
			RacingBetsLegMatchData curLegMatchData = RacingBetsModel.Instance.GetRacingBetsSeasonData().GetCurLegMatchData();
			if (curLegMatchData != null)
			{
				UUIItem item = base.GetItem(12);
				if (item == null)
				{
					return;
				}
				item.SetUIActive(curLegMatchData.Id == racingBetsLegMatchData.Id);
			}
		}

		// Token: 0x06028E11 RID: 167441 RVA: 0x00B78AEC File Offset: 0x00B76CEC
		private void OnReplayClick()
		{
			RacingBetsSeasonData racingBetsSeasonData = RacingBetsModel.Instance.GetRacingBetsSeasonData();
			RacingBetsLegMatchData racingBetsLegMatchData = this.MatchData.GetLegMatchList()[0];
			RacingBetsController.Instance.RacingBetMatchActionRequest(racingBetsSeasonData.Id, racingBetsLegMatchData.Id);
		}

		// Token: 0x06028E12 RID: 167442 RVA: 0x00B78B2C File Offset: 0x00B76D2C
		public void PlayAnim()
		{
			UiBehaviorLevelSequence uiLevelSequence = this.UiLevelSequence;
			if (uiLevelSequence != null)
			{
				uiLevelSequence.PlaySequence("Start", false, null);
			}
			GenericLayout<RacingBetsMatchTableDangoItem, IRacingBetsMatchTableDangoItemData> dangoLayout = this.DangoLayout;
			if (dangoLayout == null)
			{
				return;
			}
			dangoLayout.PlayGridAnim();
		}

		// Token: 0x0401638A RID: 91018
		[Nullable(1)]
		private RacingBetsGroupMatchData MatchData;

		// Token: 0x0401638B RID: 91019
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RacingBetsMatchTableDangoItem, IRacingBetsMatchTableDangoItemData> DangoLayout;

		// Token: 0x0401638C RID: 91020
		[Nullable(2)]
		public UiBehaviorLevelSequence UiLevelSequence;

		// Token: 0x02009AA7 RID: 39591
		private class EComponent
		{
			// Token: 0x0403030B RID: 197387
			public const int ItemLine1 = 0;

			// Token: 0x0403030C RID: 197388
			public const int ItemLine2 = 1;

			// Token: 0x0403030D RID: 197389
			public const int ItemLine3 = 2;

			// Token: 0x0403030E RID: 197390
			public const int ItemLine4 = 3;

			// Token: 0x0403030F RID: 197391
			public const int ItemLine5 = 4;

			// Token: 0x04030310 RID: 197392
			public const int ItemLine6 = 5;

			// Token: 0x04030311 RID: 197393
			public const int ItemLineMid = 6;

			// Token: 0x04030312 RID: 197394
			public const int LayoutDango = 7;

			// Token: 0x04030313 RID: 197395
			public const int ItemDango = 8;

			// Token: 0x04030314 RID: 197396
			public const int ItemWinnerPanel = 9;

			// Token: 0x04030315 RID: 197397
			public const int TextureIcon = 10;

			// Token: 0x04030316 RID: 197398
			public const int SpriteEmpty = 11;

			// Token: 0x04030317 RID: 197399
			public const int ItemRacing = 12;

			// Token: 0x04030318 RID: 197400
			public const int BtnReplay = 13;

			// Token: 0x04030319 RID: 197401
			public const int TextDate = 14;

			// Token: 0x0403031A RID: 197402
			public const int TextLegMatchName = 15;
		}
	}
}
