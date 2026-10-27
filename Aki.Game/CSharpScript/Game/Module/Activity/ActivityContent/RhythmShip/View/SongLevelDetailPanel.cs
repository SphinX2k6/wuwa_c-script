using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip.View
{
	// Token: 0x02006225 RID: 25125
	public class SongLevelDetailPanel : UiPanelBase
	{
		// Token: 0x0603F5DE RID: 259550 RVA: 0x00F517A8 File Offset: 0x00F4F9A8
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUITexture)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIText))
			};
		}

		// Token: 0x0603F5DF RID: 259551 RVA: 0x00F51830 File Offset: 0x00F4FA30
		public void RefreshPanelByLevelId(int levelId)
		{
			RhythmShipLevel? rhythmShipLevelById = RhythmShipConfig.Instance.GetRhythmShipLevelById(levelId);
			if (rhythmShipLevelById == null)
			{
				return;
			}
			base.SetTextureByPath(rhythmShipLevelById.Value.DesTexture, base.GetTexture(0), null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), rhythmShipLevelById.Value.Name, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), rhythmShipLevelById.Value.DesName, Array.Empty<object>());
			base.GetText(4).SetText(rhythmShipLevelById.Value.TimeText, true);
		}
	}
}
