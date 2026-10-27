using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DB4 RID: 28084
	public class IProgramSpecialConfigBase_UnionUnion
	{
		// Token: 0x1700D167 RID: 53607
		// (get) Token: 0x060319A9 RID: 203177 RVA: 0x006B8B19 File Offset: 0x006B6D19
		// (set) Token: 0x060319AA RID: 203178 RVA: 0x006B8B21 File Offset: 0x006B6D21
		public IProgramSpecialConfigBase_Union Type { get; set; }

		// Token: 0x1700D168 RID: 53608
		// (get) Token: 0x060319AB RID: 203179 RVA: 0x006B8B2A File Offset: 0x006B6D2A
		// (set) Token: 0x060319AC RID: 203180 RVA: 0x006B8B32 File Offset: 0x006B6D32
		public object Value { get; set; }

		// Token: 0x060319AD RID: 203181 RVA: 0x006B8B3B File Offset: 0x006B6D3B
		public IProgramSpecialConfigBase_UnionUnion()
		{
			this.Type = IProgramSpecialConfigBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060319AE RID: 203182 RVA: 0x006B8B51 File Offset: 0x006B6D51
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060319AF RID: 203183 RVA: 0x006B8B63 File Offset: 0x006B6D63
		public IProgramSpecialConfigBaseT AsIProgramSpecialConfigBase()
		{
			return this.As<IProgramSpecialConfigBaseT>();
		}

		// Token: 0x060319B0 RID: 203184 RVA: 0x006B8B6B File Offset: 0x006B6D6B
		public static IProgramSpecialConfigBase_UnionUnion FromIProgramSpecialConfigBase(IProgramSpecialConfigBaseT _iprogramspecialconfigbase)
		{
			return new IProgramSpecialConfigBase_UnionUnion
			{
				Type = IProgramSpecialConfigBase_Union.IProgramSpecialConfigBase,
				Value = _iprogramspecialconfigbase
			};
		}

		// Token: 0x060319B1 RID: 203185 RVA: 0x006B8B80 File Offset: 0x006B6D80
		public IMp4UiReplaceMaterialT AsIMp4UiReplaceMaterial()
		{
			return this.As<IMp4UiReplaceMaterialT>();
		}

		// Token: 0x060319B2 RID: 203186 RVA: 0x006B8B88 File Offset: 0x006B6D88
		public static IProgramSpecialConfigBase_UnionUnion FromIMp4UiReplaceMaterial(IMp4UiReplaceMaterialT _imp4uireplacematerial)
		{
			return new IProgramSpecialConfigBase_UnionUnion
			{
				Type = IProgramSpecialConfigBase_Union.IMp4UiReplaceMaterial,
				Value = _imp4uireplacematerial
			};
		}

		// Token: 0x060319B3 RID: 203187 RVA: 0x006B8BA0 File Offset: 0x006B6DA0
		public static int Pack(FlatBufferBuilder builder, IProgramSpecialConfigBase_UnionUnion _o)
		{
			IProgramSpecialConfigBase_Union type = _o.Type;
			if (type == IProgramSpecialConfigBase_Union.IProgramSpecialConfigBase)
			{
				return IProgramSpecialConfigBase.Pack(builder, _o.AsIProgramSpecialConfigBase()).Value;
			}
			if (type != IProgramSpecialConfigBase_Union.IMp4UiReplaceMaterial)
			{
				return 0;
			}
			return IMp4UiReplaceMaterial.Pack(builder, _o.AsIMp4UiReplaceMaterial()).Value;
		}
	}
}
