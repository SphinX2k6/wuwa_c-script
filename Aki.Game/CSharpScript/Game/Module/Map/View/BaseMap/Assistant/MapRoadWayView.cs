using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.View.BaseMap.Assistant
{
	// Token: 0x02005494 RID: 21652
	public class MapRoadWayView : UiPanelBase
	{
		// Token: 0x06037525 RID: 226597 RVA: 0x00D22520 File Offset: 0x00D20720
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06037526 RID: 226598 RVA: 0x00D22568 File Offset: 0x00D20768
		[NullableContext(1)]
		public void SetTexture(string path)
		{
			UUITexture texture = base.GetTexture(0);
			base.TrySetTextureByPath(path, texture, null, delegate(bool success)
			{
				UUITexture texture = texture;
				if (texture == null)
				{
					return;
				}
				texture.SetSizeFromTexture();
			});
		}

		// Token: 0x0200B71B RID: 46875
		public static class EComponents
		{
			// Token: 0x04037760 RID: 227168
			public const int RoadWayTexture = 0;
		}
	}
}
