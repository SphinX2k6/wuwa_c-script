using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004653 RID: 18003
	public class ITrackEffectType_UnionUnion
	{
		// Token: 0x17007E0C RID: 32268
		// (get) Token: 0x0601A608 RID: 108040 RVA: 0x003C1255 File Offset: 0x003BF455
		// (set) Token: 0x0601A609 RID: 108041 RVA: 0x003C125D File Offset: 0x003BF45D
		public ITrackEffectType_Union Type { get; set; }

		// Token: 0x17007E0D RID: 32269
		// (get) Token: 0x0601A60A RID: 108042 RVA: 0x003C1266 File Offset: 0x003BF466
		// (set) Token: 0x0601A60B RID: 108043 RVA: 0x003C126E File Offset: 0x003BF46E
		public object Value { get; set; }

		// Token: 0x0601A60C RID: 108044 RVA: 0x003C1277 File Offset: 0x003BF477
		public ITrackEffectType_UnionUnion()
		{
			this.Type = ITrackEffectType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601A60D RID: 108045 RVA: 0x003C128D File Offset: 0x003BF48D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601A60E RID: 108046 RVA: 0x003C129F File Offset: 0x003BF49F
		public ITrackEffectTypeT AsITrackEffectType()
		{
			return this.As<ITrackEffectTypeT>();
		}

		// Token: 0x0601A60F RID: 108047 RVA: 0x003C12A7 File Offset: 0x003BF4A7
		public static ITrackEffectType_UnionUnion FromITrackEffectType(ITrackEffectTypeT _itrackeffecttype)
		{
			return new ITrackEffectType_UnionUnion
			{
				Type = ITrackEffectType_Union.ITrackEffectType,
				Value = _itrackeffecttype
			};
		}

		// Token: 0x0601A610 RID: 108048 RVA: 0x003C12BC File Offset: 0x003BF4BC
		public ITrackEffectAutoChangeT AsITrackEffectAutoChange()
		{
			return this.As<ITrackEffectAutoChangeT>();
		}

		// Token: 0x0601A611 RID: 108049 RVA: 0x003C12C4 File Offset: 0x003BF4C4
		public static ITrackEffectType_UnionUnion FromITrackEffectAutoChange(ITrackEffectAutoChangeT _itrackeffectautochange)
		{
			return new ITrackEffectType_UnionUnion
			{
				Type = ITrackEffectType_Union.ITrackEffectAutoChange,
				Value = _itrackeffectautochange
			};
		}

		// Token: 0x0601A612 RID: 108050 RVA: 0x003C12DC File Offset: 0x003BF4DC
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
