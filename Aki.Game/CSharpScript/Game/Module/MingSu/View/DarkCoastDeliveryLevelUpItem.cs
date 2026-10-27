using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.MingSu.View
{
	// Token: 0x020053D9 RID: 21465
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DarkCoastDeliveryLevelUpItem : GridProxyAbstract<DarkCoastDeliveryLevelData>
	{
		// Token: 0x06036DD7 RID: 224727 RVA: 0x00CFE570 File Offset: 0x00CFC770
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUITexture))
			};
		}

		// Token: 0x06036DD8 RID: 224728 RVA: 0x00CFE594 File Offset: 0x00CFC794
		[NullableContext(1)]
		public override void Refresh(DarkCoastDeliveryLevelData data, bool isSelected, int gridIndex)
		{
			string visionTexture = data.Config.VisionTexture;
			base.SetTextureShowUntilLoaded(visionTexture, base.GetTexture(0), null);
		}

		// Token: 0x0200B67D RID: 46717
		private static class EComponent
		{
			// Token: 0x04037475 RID: 226421
			public const int VisionTexture = 0;
		}
	}
}
