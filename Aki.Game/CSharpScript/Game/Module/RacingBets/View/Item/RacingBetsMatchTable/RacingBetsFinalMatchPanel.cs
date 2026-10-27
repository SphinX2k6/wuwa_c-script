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
	// Token: 0x02004F27 RID: 20263
	public class RacingBetsFinalMatchPanel : UiPanelBase
	{
		// Token: 0x06033F9F RID: 212895 RVA: 0x00C2F09C File Offset: 0x00C2D29C
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

		// Token: 0x06033FA0 RID: 212896 RVA: 0x00C2F229 File Offset: 0x00C2D429
		protected override void OnBeforeCreate()
		{
			this.UiLevelSequence = new UiBehaviorLevelSequence(this);
			base.AddUiBehavior(this.UiLevelSequence);
		}

		// Token: 0x06033FA1 RID: 212897 RVA: 0x00C2F244 File Offset: 0x00C2D444
		protected override UniTask OnBeforeStartAsync()
		{
			RacingBetsFinalMatchPanel.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RacingBetsFinalMatchPanel.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033FA2 RID: 212898 RVA: 0x00C2F288 File Offset: 0x00C2D488
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

		// Token: 0x06033FA3 RID: 212899 RVA: 0x00C2F344 File Offset: 0x00C2D544
		private void OnReplayClick()
		{
			RacingBetsSeasonData racingBetsSeasonData = RacingBetsModel.Instance.GetRacingBetsSeasonData();
			RacingBetsLegMatchData racingBetsLegMatchData = this.MatchData.GetLegMatchList()[0];
			RacingBetsController.Instance.RacingBetMatchActionRequest(racingBetsSeasonData.Id, racingBetsLegMatchData.Id);
		}

		// Token: 0x06033FA4 RID: 212900 RVA: 0x00C2F384 File Offset: 0x00C2D584
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

		// Token: 0x0401B9B5 RID: 113077
		[Nullable(1)]
		private RacingBetsGroupMatchData MatchData;

		// Token: 0x0401B9B6 RID: 113078
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RacingBetsMatchTableDangoItem, IRacingBetsMatchTableDangoItemData> DangoLayout;

		// Token: 0x0401B9B7 RID: 113079
		[Nullable(2)]
		public UiBehaviorLevelSequence UiLevelSequence;

		// Token: 0x0200B077 RID: 45175
		private class EComponent
		{
			// Token: 0x040358E0 RID: 219360
			public const int ItemLine1 = 0;

			// Token: 0x040358E1 RID: 219361
			public const int ItemLine2 = 1;

			// Token: 0x040358E2 RID: 219362
			public const int ItemLine3 = 2;

			// Token: 0x040358E3 RID: 219363
			public const int ItemLine4 = 3;

			// Token: 0x040358E4 RID: 219364
			public const int ItemLine5 = 4;

			// Token: 0x040358E5 RID: 219365
			public const int ItemLine6 = 5;

			// Token: 0x040358E6 RID: 219366
			public const int ItemLineMid = 6;

			// Token: 0x040358E7 RID: 219367
			public const int LayoutDango = 7;

			// Token: 0x040358E8 RID: 219368
			public const int ItemDango = 8;

			// Token: 0x040358E9 RID: 219369
			public const int ItemWinnerPanel = 9;

			// Token: 0x040358EA RID: 219370
			public const int TextureIcon = 10;

			// Token: 0x040358EB RID: 219371
			public const int SpriteEmpty = 11;

			// Token: 0x040358EC RID: 219372
			public const int ItemRacing = 12;

			// Token: 0x040358ED RID: 219373
			public const int BtnReplay = 13;

			// Token: 0x040358EE RID: 219374
			public const int TextDate = 14;

			// Token: 0x040358EF RID: 219375
			public const int TextLegMatchName = 15;
		}
	}
}
