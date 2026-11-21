using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006271 RID: 25201
	public class TInteractStyleUnion
	{
		// Token: 0x1700BB62 RID: 47970
		// (get) Token: 0x0602AE27 RID: 175655 RVA: 0x005DA902 File Offset: 0x005D8B02
		// (set) Token: 0x0602AE28 RID: 175656 RVA: 0x005DA90A File Offset: 0x005D8B0A
		public TInteractStyle Type { get; set; }

		// Token: 0x1700BB63 RID: 47971
		// (get) Token: 0x0602AE29 RID: 175657 RVA: 0x005DA913 File Offset: 0x005D8B13
		// (set) Token: 0x0602AE2A RID: 175658 RVA: 0x005DA91B File Offset: 0x005D8B1B
		public object Value { get; set; }

		// Token: 0x0602AE2B RID: 175659 RVA: 0x005DA924 File Offset: 0x005D8B24
		public TInteractStyleUnion()
		{
			this.Type = TInteractStyle.NONE;
			this.Value = null;
		}

		// Token: 0x0602AE2C RID: 175660 RVA: 0x005DA93A File Offset: 0x005D8B3A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602AE2D RID: 175661 RVA: 0x005DA94C File Offset: 0x005D8B4C
		public IInteractStyleEntityPartT AsIInteractStyleEntityPart()
		{
			return this.As<IInteractStyleEntityPartT>();
		}

		// Token: 0x0602AE2E RID: 175662 RVA: 0x005DA954 File Offset: 0x005D8B54
		public static TInteractStyleUnion FromIInteractStyleEntityPart(IInteractStyleEntityPartT _iinteractstyleentitypart)
		{
			return new TInteractStyleUnion
			{
				Type = TInteractStyle.IInteractStyleEntityPart,
				Value = _iinteractstyleentitypart
			};
		}

		// Token: 0x0602AE2F RID: 175663 RVA: 0x005DA969 File Offset: 0x005D8B69
		public IInteractStylePanoramaT AsIInteractStylePanorama()
		{
			return this.As<IInteractStylePanoramaT>();
		}

		// Token: 0x0602AE30 RID: 175664 RVA: 0x005DA971 File Offset: 0x005D8B71
		public static TInteractStyleUnion FromIInteractStylePanorama(IInteractStylePanoramaT _iinteractstylepanorama)
		{
			return new TInteractStyleUnion
			{
				Type = TInteractStyle.IInteractStylePanorama,
				Value = _iinteractstylepanorama
			};
		}

		// Token: 0x0602AE31 RID: 175665 RVA: 0x005DA988 File Offset: 0x005D8B88
		public static int Pack(FlatBufferBuilder builder, TInteractStyleUnion _o)
		{
			TInteractStyle type = _o.Type;
			if (type == TInteractStyle.IInteractStyleEntityPart)
			{
				return IInteractStyleEntityPart.Pack(builder, _o.AsIInteractStyleEntityPart()).Value;
			}
			if (type != TInteractStyle.IInteractStylePanorama)
			{
				return 0;
			}
			return IInteractStylePanorama.Pack(builder, _o.AsIInteractStylePanorama()).Value;
		}
	}
}
