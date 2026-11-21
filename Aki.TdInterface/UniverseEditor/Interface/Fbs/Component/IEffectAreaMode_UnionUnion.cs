using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005677 RID: 22135
	public class IEffectAreaMode_UnionUnion
	{
		// Token: 0x17009F23 RID: 40739
		// (get) Token: 0x0602365C RID: 144988 RVA: 0x004DE7A5 File Offset: 0x004DC9A5
		// (set) Token: 0x0602365D RID: 144989 RVA: 0x004DE7AD File Offset: 0x004DC9AD
		public IEffectAreaMode_Union Type { get; set; }

		// Token: 0x17009F24 RID: 40740
		// (get) Token: 0x0602365E RID: 144990 RVA: 0x004DE7B6 File Offset: 0x004DC9B6
		// (set) Token: 0x0602365F RID: 144991 RVA: 0x004DE7BE File Offset: 0x004DC9BE
		public object Value { get; set; }

		// Token: 0x06023660 RID: 144992 RVA: 0x004DE7C7 File Offset: 0x004DC9C7
		public IEffectAreaMode_UnionUnion()
		{
			this.Type = IEffectAreaMode_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06023661 RID: 144993 RVA: 0x004DE7DD File Offset: 0x004DC9DD
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06023662 RID: 144994 RVA: 0x004DE7EF File Offset: 0x004DC9EF
		public IEffectAreaModeT AsIEffectAreaMode()
		{
			return this.As<IEffectAreaModeT>();
		}

		// Token: 0x06023663 RID: 144995 RVA: 0x004DE7F7 File Offset: 0x004DC9F7
		public static IEffectAreaMode_UnionUnion FromIEffectAreaMode(IEffectAreaModeT _ieffectareamode)
		{
			return new IEffectAreaMode_UnionUnion
			{
				Type = IEffectAreaMode_Union.IEffectAreaMode,
				Value = _ieffectareamode
			};
		}

		// Token: 0x06023664 RID: 144996 RVA: 0x004DE80C File Offset: 0x004DCA0C
		public IBuffAreaT AsIBuffArea()
		{
			return this.As<IBuffAreaT>();
		}

		// Token: 0x06023665 RID: 144997 RVA: 0x004DE814 File Offset: 0x004DCA14
		public static IEffectAreaMode_UnionUnion FromIBuffArea(IBuffAreaT _ibuffarea)
		{
			return new IEffectAreaMode_UnionUnion
			{
				Type = IEffectAreaMode_Union.IBuffArea,
				Value = _ibuffarea
			};
		}

		// Token: 0x06023666 RID: 144998 RVA: 0x004DE82C File Offset: 0x004DCA2C
		public static int Pack(FlatBufferBuilder builder, IEffectAreaMode_UnionUnion _o)
		{
			IEffectAreaMode_Union type = _o.Type;
			if (type == IEffectAreaMode_Union.IEffectAreaMode)
			{
				return IEffectAreaMode.Pack(builder, _o.AsIEffectAreaMode()).Value;
			}
			if (type != IEffectAreaMode_Union.IBuffArea)
			{
				return 0;
			}
			return IBuffArea.Pack(builder, _o.AsIBuffArea()).Value;
		}
	}
}
