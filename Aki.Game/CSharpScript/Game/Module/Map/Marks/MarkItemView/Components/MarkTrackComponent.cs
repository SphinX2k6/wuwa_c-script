using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Map.MapDefine;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView.Components
{
	// Token: 0x0200554C RID: 21836
	public class MarkTrackComponent : MarkPanelBase
	{
		// Token: 0x06037B81 RID: 228225 RVA: 0x00D386F4 File Offset: 0x00D368F4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUINiagara));
			this.ComponentRegisterInfos = list;
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>();
		}

		// Token: 0x06037B82 RID: 228226 RVA: 0x00D38748 File Offset: 0x00D36948
		protected override void OnStart()
		{
			UUINiagara uiNiagara = base.GetUiNiagara(0);
			if (uiNiagara != null)
			{
				if (this.MapType == EMapType.WorldMap)
				{
					uiNiagara.bAdaptPosAndSizeChanged = true;
				}
				else
				{
					uiNiagara.bAdaptPosAndSizeChanged = false;
				}
			}
			Vector vector = new Vector((double)this.TrackFxScale, (double)this.TrackFxScale, 1.0);
			UUIItem rootItem = this.RootItem;
			FVectorDouble fvectorDouble = vector.ToUeVector(false);
			FVector fvector = fvectorDouble;
			rootItem.SetUIRelativeScale3D(fvector);
		}

		// Token: 0x0401D44E RID: 119886
		public EMapType MapType = EMapType.WorldMap;

		// Token: 0x0401D44F RID: 119887
		public float TrackFxScale = 1f;

		// Token: 0x0200B778 RID: 46968
		public static class EMarkTrackNiaComponents
		{
			// Token: 0x040378B2 RID: 227506
			public const int NiaTrace = 0;
		}
	}
}
