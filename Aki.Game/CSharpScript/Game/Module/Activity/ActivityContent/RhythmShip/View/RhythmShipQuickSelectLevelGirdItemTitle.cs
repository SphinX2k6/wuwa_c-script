using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip.View
{
	// Token: 0x020051B4 RID: 20916
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RhythmShipQuickSelectLevelGirdItemTitle : SyncGridProxyAbstract<RhythmShipQuickSelectLevelData>
	{
		// Token: 0x060342CC RID: 213708 RVA: 0x00E99579 File Offset: 0x00E97779
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText))
			};
		}

		// Token: 0x060342CD RID: 213709 RVA: 0x00E9959C File Offset: 0x00E9779C
		public override void Refresh(RhythmShipQuickSelectLevelData data)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.TitleText, Array.Empty<object>());
		}
	}
}
