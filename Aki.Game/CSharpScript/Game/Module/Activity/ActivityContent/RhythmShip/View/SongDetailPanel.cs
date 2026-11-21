using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip.View
{
	// Token: 0x020051AD RID: 20909
	public class SongDetailPanel : UiPanelBase
	{
		// Token: 0x060342C2 RID: 213698 RVA: 0x00E99070 File Offset: 0x00E97270
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUITexture)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUIText)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIText)),
				new ValueTuple<int, Type>(6, typeof(UUIHorizontalLayout)),
				new ValueTuple<int, Type>(7, typeof(UUIItem))
			};
		}

		// Token: 0x060342C3 RID: 213699 RVA: 0x00E99138 File Offset: 0x00E97338
		protected override void OnStart()
		{
			this.StarLayout = new GenericLayout<RhythmShipPauseStarItem, bool>(base.GetHorizontalLayout(6), () => new RhythmShipPauseStarItem(), null, false, true);
		}

		// Token: 0x060342C4 RID: 213700 RVA: 0x00E99170 File Offset: 0x00E97370
		public void RefreshPanel()
		{
			RhythmShipLevel? rhythmShipLevelById = RhythmShipConfig.Instance.GetRhythmShipLevelById(RhythmShipModel.Instance.RhythmShipLevelId);
			if (rhythmShipLevelById == null)
			{
				return;
			}
			base.SetTextureByPath(rhythmShipLevelById.Value.DesTexture, base.GetTexture(0), null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), rhythmShipLevelById.Value.Name, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), rhythmShipLevelById.Value.DesName, Array.Empty<object>());
			base.GetText(5).SetText(RhythmShipModel.Instance.GetCurrentPauseTime() + "/" + rhythmShipLevelById.Value.TimeText, true);
			RhythmSubLevel? rhythmShipSubLevelById = RhythmShipConfig.Instance.GetRhythmShipSubLevelById(RhythmShipModel.Instance.RhythmShipSubLevelId);
			if (rhythmShipSubLevelById == null)
			{
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), RhythmShipDefine.rhythmShipDifficultyText[rhythmShipSubLevelById.Value.Difficulty], Array.Empty<object>());
			IEnumerable<RhythmSubLevel> enumerable = RhythmShipConfig.Instance.GetRhythmShipSubLevelByLevelId(RhythmShipModel.Instance.RhythmShipLevelId) ?? new List<RhythmSubLevel>();
			int num = 0;
			foreach (RhythmSubLevel rhythmSubLevel in enumerable)
			{
				if (rhythmSubLevel.Id == RhythmShipModel.Instance.RhythmShipSubLevelId)
				{
					num = rhythmSubLevel.StarLevel;
					break;
				}
			}
			List<bool> list = new List<bool>();
			for (int i = 1; i <= 9; i++)
			{
				if (i <= num)
				{
					list.Add(true);
				}
				else
				{
					list.Add(false);
				}
			}
			GenericLayout<RhythmShipPauseStarItem, bool> starLayout = this.StarLayout;
			if (starLayout == null)
			{
				return;
			}
			starLayout.RefreshByData(list, null, false);
		}

		// Token: 0x0401BA9C RID: 113308
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<RhythmShipPauseStarItem, bool> StarLayout;
	}
}
