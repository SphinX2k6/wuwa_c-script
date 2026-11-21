using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.MingSu.View
{
	// Token: 0x020043BC RID: 17340
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DarkCoastDeliveryLevelUpItem : GridProxyAbstract<DarkCoastDeliveryLevelData>
	{
		// Token: 0x0602BD1E RID: 179486 RVA: 0x00C4D640 File Offset: 0x00C4B840
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUITexture))
			};
		}

		// Token: 0x0602BD1F RID: 179487 RVA: 0x00C4D664 File Offset: 0x00C4B864
		[NullableContext(1)]
		public override void Refresh(DarkCoastDeliveryLevelData data, bool isSelected, int gridIndex)
		{
			string visionTexture = data.Config.VisionTexture;
			base.SetTextureShowUntilLoaded(visionTexture, base.GetTexture(0), null);
		}

		// Token: 0x0200A0B5 RID: 41141
		private static class EComponent
		{
			// Token: 0x04031ECA RID: 204490
			public const int VisionTexture = 0;
		}
	}
}
