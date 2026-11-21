using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200752F RID: 29999
	public class IProgramSpecialConfigBase_UnionUnion
	{
		// Token: 0x1700DCAF RID: 56495
		// (get) Token: 0x060349A5 RID: 215461 RVA: 0x00714201 File Offset: 0x00712401
		// (set) Token: 0x060349A6 RID: 215462 RVA: 0x00714209 File Offset: 0x00712409
		public IProgramSpecialConfigBase_Union Type { get; set; }

		// Token: 0x1700DCB0 RID: 56496
		// (get) Token: 0x060349A7 RID: 215463 RVA: 0x00714212 File Offset: 0x00712412
		// (set) Token: 0x060349A8 RID: 215464 RVA: 0x0071421A File Offset: 0x0071241A
		public object Value { get; set; }

		// Token: 0x060349A9 RID: 215465 RVA: 0x00714223 File Offset: 0x00712423
		public IProgramSpecialConfigBase_UnionUnion()
		{
			this.Type = IProgramSpecialConfigBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060349AA RID: 215466 RVA: 0x00714239 File Offset: 0x00712439
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060349AB RID: 215467 RVA: 0x0071424B File Offset: 0x0071244B
		public IProgramSpecialConfigBaseT AsIProgramSpecialConfigBase()
		{
			return this.As<IProgramSpecialConfigBaseT>();
		}

		// Token: 0x060349AC RID: 215468 RVA: 0x00714253 File Offset: 0x00712453
		public static IProgramSpecialConfigBase_UnionUnion FromIProgramSpecialConfigBase(IProgramSpecialConfigBaseT _iprogramspecialconfigbase)
		{
			return new IProgramSpecialConfigBase_UnionUnion
			{
				Type = IProgramSpecialConfigBase_Union.IProgramSpecialConfigBase,
				Value = _iprogramspecialconfigbase
			};
		}

		// Token: 0x060349AD RID: 215469 RVA: 0x00714268 File Offset: 0x00712468
		public IMp4UiReplaceMaterialT AsIMp4UiReplaceMaterial()
		{
			return this.As<IMp4UiReplaceMaterialT>();
		}

		// Token: 0x060349AE RID: 215470 RVA: 0x00714270 File Offset: 0x00712470
		public static IProgramSpecialConfigBase_UnionUnion FromIMp4UiReplaceMaterial(IMp4UiReplaceMaterialT _imp4uireplacematerial)
		{
			return new IProgramSpecialConfigBase_UnionUnion
			{
				Type = IProgramSpecialConfigBase_Union.IMp4UiReplaceMaterial,
				Value = _imp4uireplacematerial
			};
		}

		// Token: 0x060349AF RID: 215471 RVA: 0x00714288 File Offset: 0x00712488
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
