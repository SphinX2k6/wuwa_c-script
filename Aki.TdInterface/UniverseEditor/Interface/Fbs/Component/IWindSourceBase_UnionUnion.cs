using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B84 RID: 23428
	public class IWindSourceBase_UnionUnion
	{
		// Token: 0x1700B10C RID: 45324
		// (get) Token: 0x060281A9 RID: 164265 RVA: 0x00583365 File Offset: 0x00581565
		// (set) Token: 0x060281AA RID: 164266 RVA: 0x0058336D File Offset: 0x0058156D
		public IWindSourceBase_Union Type { get; set; }

		// Token: 0x1700B10D RID: 45325
		// (get) Token: 0x060281AB RID: 164267 RVA: 0x00583376 File Offset: 0x00581576
		// (set) Token: 0x060281AC RID: 164268 RVA: 0x0058337E File Offset: 0x0058157E
		public object Value { get; set; }

		// Token: 0x060281AD RID: 164269 RVA: 0x00583387 File Offset: 0x00581587
		public IWindSourceBase_UnionUnion()
		{
			this.Type = IWindSourceBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060281AE RID: 164270 RVA: 0x0058339D File Offset: 0x0058159D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060281AF RID: 164271 RVA: 0x005833AF File Offset: 0x005815AF
		public IWindSourceBaseT AsIWindSourceBase()
		{
			return this.As<IWindSourceBaseT>();
		}

		// Token: 0x060281B0 RID: 164272 RVA: 0x005833B7 File Offset: 0x005815B7
		public static IWindSourceBase_UnionUnion FromIWindSourceBase(IWindSourceBaseT _iwindsourcebase)
		{
			return new IWindSourceBase_UnionUnion
			{
				Type = IWindSourceBase_Union.IWindSourceBase,
				Value = _iwindsourcebase
			};
		}

		// Token: 0x060281B1 RID: 164273 RVA: 0x005833CC File Offset: 0x005815CC
		public IWindDirectionalT AsIWindDirectional()
		{
			return this.As<IWindDirectionalT>();
		}

		// Token: 0x060281B2 RID: 164274 RVA: 0x005833D4 File Offset: 0x005815D4
		public static IWindSourceBase_UnionUnion FromIWindDirectional(IWindDirectionalT _iwinddirectional)
		{
			return new IWindSourceBase_UnionUnion
			{
				Type = IWindSourceBase_Union.IWindDirectional,
				Value = _iwinddirectional
			};
		}

		// Token: 0x060281B3 RID: 164275 RVA: 0x005833EC File Offset: 0x005815EC
		public static int Pack(FlatBufferBuilder builder, IWindSourceBase_UnionUnion _o)
		{
			IWindSourceBase_Union type = _o.Type;
			if (type == IWindSourceBase_Union.IWindSourceBase)
			{
				return IWindSourceBase.Pack(builder, _o.AsIWindSourceBase()).Value;
			}
			if (type != IWindSourceBase_Union.IWindDirectional)
			{
				return 0;
			}
			return IWindDirectional.Pack(builder, _o.AsIWindDirectional()).Value;
		}
	}
}
