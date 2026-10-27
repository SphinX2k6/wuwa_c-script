using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip.View
{
	// Token: 0x02006236 RID: 25142
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RhythmShipQuickSelectLevelGirdItemTitle : SyncGridProxyAbstract<RhythmShipQuickSelectLevelData>
	{
		// Token: 0x0603F60B RID: 259595 RVA: 0x00F5261D File Offset: 0x00F5081D
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText))
			};
		}

		// Token: 0x0603F60C RID: 259596 RVA: 0x00F52640 File Offset: 0x00F50840
		public override void Refresh(RhythmShipQuickSelectLevelData data)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.TitleText, Array.Empty<object>());
		}
	}
}
