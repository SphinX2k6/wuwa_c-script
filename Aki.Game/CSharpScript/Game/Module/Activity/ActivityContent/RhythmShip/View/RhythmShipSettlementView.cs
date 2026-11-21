using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip.View
{
	// Token: 0x020051D1 RID: 20945
	public class RhythmShipSettlementView : UiViewBase
	{
		// Token: 0x06034326 RID: 213798 RVA: 0x00E9A6AA File Offset: 0x00E988AA
		[NullableContext(1)]
		public RhythmShipSettlementView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06034327 RID: 213799 RVA: 0x00E9A6BC File Offset: 0x00E988BC
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUITexture)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIText)),
				new ValueTuple<int, Type>(4, typeof(UUITexture)),
				new ValueTuple<int, Type>(5, typeof(UUITexture)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIGridLayout)),
				new ValueTuple<int, Type>(8, typeof(UUIItem)),
				new ValueTuple<int, Type>(9, typeof(UUIText)),
				new ValueTuple<int, Type>(10, typeof(UUIText)),
				new ValueTuple<int, Type>(11, typeof(UUIText)),
				new ValueTuple<int, Type>(12, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(13, typeof(UUIButtonComponent))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(12, new Action(this.OnClickRestartBtn)),
				new ValueTuple<int, Delegate>(13, new Action(this.OnClickGoOnGameBtn))
			};
		}

		// Token: 0x06034328 RID: 213800 RVA: 0x00E9A84A File Offset: 0x00E98A4A
		protected override void OnStart()
		{
			this.RhythmItemLayout = new GenericLayout<RhythmShipSettlementItem, ValueTuple<int, int>>(base.GetGridLayout(7), () => new RhythmShipSettlementItem(), null, false, true);
			this.RefreshView();
		}

		// Token: 0x06034329 RID: 213801 RVA: 0x00E9A888 File Offset: 0x00E98A88
		private void RefreshView()
		{
			IRhythmShipSettlementViewData rhythmShipSettlementViewData = this.OpenParam as IRhythmShipSettlementViewData;
			RhythmSubLevel? rhythmShipSubLevelById = RhythmShipConfig.Instance.GetRhythmShipSubLevelById(rhythmShipSettlementViewData.SubLevelId);
			if (rhythmShipSubLevelById == null)
			{
				return;
			}
			this.SubLevelId = rhythmShipSettlementViewData.SubLevelId;
			RhythmShipLevel? rhythmShipLevelById = RhythmShipConfig.Instance.GetRhythmShipLevelById(rhythmShipSubLevelById.Value.LevelId);
			if (rhythmShipLevelById == null)
			{
				return;
			}
			this.LevelId = rhythmShipSubLevelById.Value.LevelId;
			this.PlanetId = rhythmShipLevelById.Value.Planet;
			this.PlanetType = (ERhythmShipPlanetType)RhythmShipConfig.Instance.GetRhythmShipPlanetById(rhythmShipLevelById.Value.Planet).Value.Type;
			base.SetTextureByPath(rhythmShipLevelById.Value.DesTexture, base.GetTexture(0), null, null);
			RhythmShipRank rank = rhythmShipSettlementViewData.Payload.Rank;
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(RhythmShipDefine.rhythmShipLevelRatingBgTexture[(int)rank]);
			base.SetTextureByPath(resourcePath, base.GetTexture(4), null, null);
			string resourcePath2 = UiResourceConfig.Instance.GetResourcePath(RhythmShipDefine.rhythmShipLevelRatingSettlementTexture[(int)rank]);
			base.SetTextureByPath(resourcePath2, base.GetTexture(5), null, null);
			base.GetItem(6).SetUIActive(rank >= RhythmShipRank.S);
			base.GetText(1).SetText(rhythmShipSettlementViewData.Payload.Score.ToString(), true);
			base.GetText(9).SetText((rhythmShipSettlementViewData.Payload.Completion / 100).ToString() + "%", true);
			base.GetText(10).SetText(rhythmShipSettlementViewData.Payload.MaxCombo.ToString(), true);
			Dictionary<int, RhythmSubLevelPb> subLevelInfoMapBySubLevelId = RhythmShipModel.Instance.GetSubLevelInfoMapBySubLevelId(rhythmShipSettlementViewData.SubLevelId);
			RhythmSubLevelPb rhythmSubLevelPb = null;
			if (subLevelInfoMapBySubLevelId != null)
			{
				subLevelInfoMapBySubLevelId.TryGetValue(rhythmShipSettlementViewData.SubLevelId, out rhythmSubLevelPb);
			}
			int? num = (rhythmSubLevelPb != null) ? new int?(rhythmSubLevelPb.BestScore) : null;
			if (num != null && num.Value != 0)
			{
				base.GetText(11).SetText(num.Value.ToString(), true);
			}
			else
			{
				base.GetText(11).SetText("----", true);
			}
			base.GetItem(2).SetUIActive(rhythmShipSettlementViewData.Payload.Score >= num.GetValueOrDefault());
			List<ValueTuple<int, int>> list = new List<ValueTuple<int, int>>();
			foreach (KeyValuePair<ERhythmShipSettlementType, int> keyValuePair in rhythmShipSettlementViewData.SettlementItemMap)
			{
				list.Add(new ValueTuple<int, int>((int)keyValuePair.Key, keyValuePair.Value));
			}
			GenericLayout<RhythmShipSettlementItem, ValueTuple<int, int>> rhythmItemLayout = this.RhythmItemLayout;
			if (rhythmItemLayout == null)
			{
				return;
			}
			rhythmItemLayout.RefreshByData(list, null, false);
		}

		// Token: 0x0603432A RID: 213802 RVA: 0x00E9AB8C File Offset: 0x00E98D8C
		private void OnClickRestartBtn()
		{
			InstanceDungeonEntranceController.Instance.RestartInstanceDungeon(false).Forget<bool>();
		}

		// Token: 0x0603432B RID: 213803 RVA: 0x00E9ABA0 File Offset: 0x00E98DA0
		private void OnClickGoOnGameBtn()
		{
			RhythmShipChoseLevelViewData param = new RhythmShipChoseLevelViewData
			{
				OpenShowType = this.PlanetType,
				PlanetId = new int?(this.PlanetId),
				LevelId = new int?(this.LevelId),
				SubLevelId = new int?(this.SubLevelId)
			};
			UiManager.Instance.OpenView(EUiViewName.RhythmShipChoseLevelView, param, null);
			base.CloseMe(null);
		}

		// Token: 0x0401BB04 RID: 113412
		[Nullable(new byte[]
		{
			2,
			1,
			0
		})]
		private GenericLayout<RhythmShipSettlementItem, ValueTuple<int, int>> RhythmItemLayout;

		// Token: 0x0401BB05 RID: 113413
		private ERhythmShipPlanetType PlanetType = ERhythmShipPlanetType.Normal;

		// Token: 0x0401BB06 RID: 113414
		private int PlanetId;

		// Token: 0x0401BB07 RID: 113415
		private int LevelId;

		// Token: 0x0401BB08 RID: 113416
		private int SubLevelId;
	}
}
