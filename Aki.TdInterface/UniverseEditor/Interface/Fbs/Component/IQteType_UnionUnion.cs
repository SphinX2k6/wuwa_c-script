using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005DCB RID: 24011
	public class IQteType_UnionUnion
	{
		// Token: 0x1700B0D3 RID: 45267
		// (get) Token: 0x06028076 RID: 163958 RVA: 0x005796B6 File Offset: 0x005778B6
		// (set) Token: 0x06028077 RID: 163959 RVA: 0x005796BE File Offset: 0x005778BE
		public IQteType_Union Type { get; set; }

		// Token: 0x1700B0D4 RID: 45268
		// (get) Token: 0x06028078 RID: 163960 RVA: 0x005796C7 File Offset: 0x005778C7
		// (set) Token: 0x06028079 RID: 163961 RVA: 0x005796CF File Offset: 0x005778CF
		public object Value { get; set; }

		// Token: 0x0602807A RID: 163962 RVA: 0x005796D8 File Offset: 0x005778D8
		public IQteType_UnionUnion()
		{
			this.Type = IQteType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602807B RID: 163963 RVA: 0x005796EE File Offset: 0x005778EE
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602807C RID: 163964 RVA: 0x00579700 File Offset: 0x00577900
		public IQteTypeT AsIQteType()
		{
			return this.As<IQteTypeT>();
		}

		// Token: 0x0602807D RID: 163965 RVA: 0x00579708 File Offset: 0x00577908
		public static IQteType_UnionUnion FromIQteType(IQteTypeT _iqtetype)
		{
			return new IQteType_UnionUnion
			{
				Type = IQteType_Union.IQteType,
				Value = _iqtetype
			};
		}

		// Token: 0x0602807E RID: 163966 RVA: 0x0057971D File Offset: 0x0057791D
		public ISingleBtnQteT AsISingleBtnQte()
		{
			return this.As<ISingleBtnQteT>();
		}

		// Token: 0x0602807F RID: 163967 RVA: 0x00579725 File Offset: 0x00577925
		public static IQteType_UnionUnion FromISingleBtnQte(ISingleBtnQteT _isinglebtnqte)
		{
			return new IQteType_UnionUnion
			{
				Type = IQteType_Union.ISingleBtnQte,
				Value = _isinglebtnqte
			};
		}

		// Token: 0x06028080 RID: 163968 RVA: 0x0057973C File Offset: 0x0057793C
		public static int Pack(FlatBufferBuilder builder, IQteType_UnionUnion _o)
		{
			IQteType_Union type = _o.Type;
			if (type == IQteType_Union.IQteType)
			{
				return IQteType.Pack(builder, _o.AsIQteType()).Value;
			}
			if (type != IQteType_Union.ISingleBtnQte)
			{
				return 0;
			}
			return ISingleBtnQte.Pack(builder, _o.AsISingleBtnQte()).Value;
		}
	}
}
