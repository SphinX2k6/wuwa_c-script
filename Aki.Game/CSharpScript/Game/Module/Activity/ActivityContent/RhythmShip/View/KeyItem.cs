using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip.View
{
	// Token: 0x0200624E RID: 25166
	internal class KeyItem : GridProxyAbstract<int>
	{
		// Token: 0x0603F651 RID: 259665 RVA: 0x00F53650 File Offset: 0x00F51850
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUITexture)),
				new ValueTuple<int, Type>(1, typeof(UUIText))
			};
		}

		// Token: 0x0603F652 RID: 259666 RVA: 0x00F5368C File Offset: 0x00F5188C
		public override void Refresh(int data, bool isSelected, int gridIndex)
		{
			RhythmShipAction? rhythmShipActionById = RhythmShipConfig.Instance.GetRhythmShipActionById(data);
			if (rhythmShipActionById == null)
			{
				return;
			}
			base.SetTextureByPath(rhythmShipActionById.Value.Icon, base.GetTexture(0), null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), rhythmShipActionById.Value.Name, Array.Empty<object>());
		}
	}
}
