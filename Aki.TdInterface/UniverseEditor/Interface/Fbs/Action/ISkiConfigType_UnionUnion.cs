using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007125 RID: 28965
	public class ISkiConfigType_UnionUnion
	{
		// Token: 0x1700D74F RID: 55119
		// (get) Token: 0x060335AD RID: 210349 RVA: 0x006EC290 File Offset: 0x006EA490
		// (set) Token: 0x060335AE RID: 210350 RVA: 0x006EC298 File Offset: 0x006EA498
		public ISkiConfigType_Union Type { get; set; }

		// Token: 0x1700D750 RID: 55120
		// (get) Token: 0x060335AF RID: 210351 RVA: 0x006EC2A1 File Offset: 0x006EA4A1
		// (set) Token: 0x060335B0 RID: 210352 RVA: 0x006EC2A9 File Offset: 0x006EA4A9
		public object Value { get; set; }

		// Token: 0x060335B1 RID: 210353 RVA: 0x006EC2B2 File Offset: 0x006EA4B2
		public ISkiConfigType_UnionUnion()
		{
			this.Type = ISkiConfigType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060335B2 RID: 210354 RVA: 0x006EC2C8 File Offset: 0x006EA4C8
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060335B3 RID: 210355 RVA: 0x006EC2DA File Offset: 0x006EA4DA
		public ISkiConfigTypeT AsISkiConfigType()
		{
			return this.As<ISkiConfigTypeT>();
		}

		// Token: 0x060335B4 RID: 210356 RVA: 0x006EC2E2 File Offset: 0x006EA4E2
		public static ISkiConfigType_UnionUnion FromISkiConfigType(ISkiConfigTypeT _iskiconfigtype)
		{
			return new ISkiConfigType_UnionUnion
			{
				Type = ISkiConfigType_Union.ISkiConfigType,
				Value = _iskiconfigtype
			};
		}

		// Token: 0x060335B5 RID: 210357 RVA: 0x006EC2F7 File Offset: 0x006EA4F7
		public IOpenSkiConfigT AsIOpenSkiConfig()
		{
			return this.As<IOpenSkiConfigT>();
		}

		// Token: 0x060335B6 RID: 210358 RVA: 0x006EC2FF File Offset: 0x006EA4FF
		public static ISkiConfigType_UnionUnion FromIOpenSkiConfig(IOpenSkiConfigT _iopenskiconfig)
		{
			return new ISkiConfigType_UnionUnion
			{
				Type = ISkiConfigType_Union.IOpenSkiConfig,
				Value = _iopenskiconfig
			};
		}

		// Token: 0x060335B7 RID: 210359 RVA: 0x006EC314 File Offset: 0x006EA514
		public ICloseSkiConfigT AsICloseSkiConfig()
		{
			return this.As<ICloseSkiConfigT>();
		}

		// Token: 0x060335B8 RID: 210360 RVA: 0x006EC31C File Offset: 0x006EA51C
		public static ISkiConfigType_UnionUnion FromICloseSkiConfig(ICloseSkiConfigT _icloseskiconfig)
		{
			return new ISkiConfigType_UnionUnion
			{
				Type = ISkiConfigType_Union.ICloseSkiConfig,
				Value = _icloseskiconfig
			};
		}

		// Token: 0x060335B9 RID: 210361 RVA: 0x006EC331 File Offset: 0x006EA531
		public IAccelerateSkiConfigT AsIAccelerateSkiConfig()
		{
			return this.As<IAccelerateSkiConfigT>();
		}

		// Token: 0x060335BA RID: 210362 RVA: 0x006EC339 File Offset: 0x006EA539
		public static ISkiConfigType_UnionUnion FromIAccelerateSkiConfig(IAccelerateSkiConfigT _iaccelerateskiconfig)
		{
			return new ISkiConfigType_UnionUnion
			{
				Type = ISkiConfigType_Union.IAccelerateSkiConfig,
				Value = _iaccelerateskiconfig
			};
		}

		// Token: 0x060335BB RID: 210363 RVA: 0x006EC350 File Offset: 0x006EA550
		public static int Pack(FlatBufferBuilder builder, ISkiConfigType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ISkiConfigType_Union.ISkiConfigType:
				return ISkiConfigType.Pack(builder, _o.AsISkiConfigType()).Value;
			case ISkiConfigType_Union.IOpenSkiConfig:
				return IOpenSkiConfig.Pack(builder, _o.AsIOpenSkiConfig()).Value;
			case ISkiConfigType_Union.ICloseSkiConfig:
				return ICloseSkiConfig.Pack(builder, _o.AsICloseSkiConfig()).Value;
			case ISkiConfigType_Union.IAccelerateSkiConfig:
				return IAccelerateSkiConfig.Pack(builder, _o.AsIAccelerateSkiConfig()).Value;
			default:
				return 0;
			}
		}
	}
}
