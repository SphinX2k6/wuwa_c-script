using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041FA RID: 16890
	public class ITrackEffectType_UnionUnion
	{
		// Token: 0x170077DE RID: 30686
		// (get) Token: 0x06018EAE RID: 102062 RVA: 0x00395CF5 File Offset: 0x00393EF5
		// (set) Token: 0x06018EAF RID: 102063 RVA: 0x00395CFD File Offset: 0x00393EFD
		public ITrackEffectType_Union Type { get; set; }

		// Token: 0x170077DF RID: 30687
		// (get) Token: 0x06018EB0 RID: 102064 RVA: 0x00395D06 File Offset: 0x00393F06
		// (set) Token: 0x06018EB1 RID: 102065 RVA: 0x00395D0E File Offset: 0x00393F0E
		public object Value { get; set; }

		// Token: 0x06018EB2 RID: 102066 RVA: 0x00395D17 File Offset: 0x00393F17
		public ITrackEffectType_UnionUnion()
		{
			this.Type = ITrackEffectType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06018EB3 RID: 102067 RVA: 0x00395D2D File Offset: 0x00393F2D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06018EB4 RID: 102068 RVA: 0x00395D3F File Offset: 0x00393F3F
		public ITrackEffectTypeT AsITrackEffectType()
		{
			return this.As<ITrackEffectTypeT>();
		}

		// Token: 0x06018EB5 RID: 102069 RVA: 0x00395D47 File Offset: 0x00393F47
		public static ITrackEffectType_UnionUnion FromITrackEffectType(ITrackEffectTypeT _itrackeffecttype)
		{
			return new ITrackEffectType_UnionUnion
			{
				Type = ITrackEffectType_Union.ITrackEffectType,
				Value = _itrackeffecttype
			};
		}

		// Token: 0x06018EB6 RID: 102070 RVA: 0x00395D5C File Offset: 0x00393F5C
		public ITrackEffectAutoChangeT AsITrackEffectAutoChange()
		{
			return this.As<ITrackEffectAutoChangeT>();
		}

		// Token: 0x06018EB7 RID: 102071 RVA: 0x00395D64 File Offset: 0x00393F64
		public static ITrackEffectType_UnionUnion FromITrackEffectAutoChange(ITrackEffectAutoChangeT _itrackeffectautochange)
		{
			return new ITrackEffectType_UnionUnion
			{
				Type = ITrackEffectType_Union.ITrackEffectAutoChange,
				Value = _itrackeffectautochange
			};
		}

		// Token: 0x06018EB8 RID: 102072 RVA: 0x00395D7C File Offset: 0x00393F7C
		public static int Pack(FlatBufferBuilder builder, ITrackEffectType_UnionUnion _o)
		{
			ITrackEffectType_Union type = _o.Type;
			if (type == ITrackEffectType_Union.ITrackEffectType)
			{
				return ITrackEffectType.Pack(builder, _o.AsITrackEffectType()).Value;
			}
			if (type != ITrackEffectType_Union.ITrackEffectAutoChange)
			{
				return 0;
			}
			return ITrackEffectAutoChange.Pack(builder, _o.AsITrackEffectAutoChange()).Value;
		}
	}
}
