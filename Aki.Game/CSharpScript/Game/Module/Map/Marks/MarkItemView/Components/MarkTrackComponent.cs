using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Map.MapDefine;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView.Components
{
	// Token: 0x0200451E RID: 17694
	public class MarkTrackComponent : MarkPanelBase
	{
		// Token: 0x0602CA51 RID: 182865 RVA: 0x00C861C8 File Offset: 0x00C843C8
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

		// Token: 0x0602CA52 RID: 182866 RVA: 0x00C8621C File Offset: 0x00C8441C
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

		// Token: 0x04017ED7 RID: 98007
		public EMapType MapType = EMapType.WorldMap;

		// Token: 0x04017ED8 RID: 98008
		public float TrackFxScale = 1f;

		// Token: 0x0200A1A3 RID: 41379
		public static class EMarkTrackNiaComponents
		{
			// Token: 0x040322DD RID: 205533
			public const int NiaTrace = 0;
		}
	}
}
