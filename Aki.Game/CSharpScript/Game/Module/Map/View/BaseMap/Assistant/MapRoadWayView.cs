using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.View.BaseMap.Assistant
{
	// Token: 0x02004477 RID: 17527
	public class MapRoadWayView : UiPanelBase
	{
		// Token: 0x0602C47B RID: 181371 RVA: 0x00C720DC File Offset: 0x00C702DC
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

		// Token: 0x0602C47C RID: 181372 RVA: 0x00C72124 File Offset: 0x00C70324
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

		// Token: 0x0200A151 RID: 41297
		public static class EComponents
		{
			// Token: 0x040321B6 RID: 205238
			public const int RoadWayTexture = 0;
		}
	}
}
