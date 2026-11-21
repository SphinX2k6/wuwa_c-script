using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip.View
{
	// Token: 0x020051CC RID: 20940
	internal class KeyItem : GridProxyAbstract<int>
	{
		// Token: 0x06034312 RID: 213778 RVA: 0x00E9A5AC File Offset: 0x00E987AC
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUITexture)),
				new ValueTuple<int, Type>(1, typeof(UUIText))
			};
		}

		// Token: 0x06034313 RID: 213779 RVA: 0x00E9A5E8 File Offset: 0x00E987E8
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
