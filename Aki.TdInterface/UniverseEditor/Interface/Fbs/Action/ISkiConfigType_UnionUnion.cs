using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020078F1 RID: 30961
	public class ISkiConfigType_UnionUnion
	{
		// Token: 0x1700E332 RID: 58162
		// (get) Token: 0x0603684F RID: 223311 RVA: 0x0074C89C File Offset: 0x0074AA9C
		// (set) Token: 0x06036850 RID: 223312 RVA: 0x0074C8A4 File Offset: 0x0074AAA4
		public ISkiConfigType_Union Type { get; set; }

		// Token: 0x1700E333 RID: 58163
		// (get) Token: 0x06036851 RID: 223313 RVA: 0x0074C8AD File Offset: 0x0074AAAD
		// (set) Token: 0x06036852 RID: 223314 RVA: 0x0074C8B5 File Offset: 0x0074AAB5
		public object Value { get; set; }

		// Token: 0x06036853 RID: 223315 RVA: 0x0074C8BE File Offset: 0x0074AABE
		public ISkiConfigType_UnionUnion()
		{
			this.Type = ISkiConfigType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06036854 RID: 223316 RVA: 0x0074C8D4 File Offset: 0x0074AAD4
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06036855 RID: 223317 RVA: 0x0074C8E6 File Offset: 0x0074AAE6
		public ISkiConfigTypeT AsISkiConfigType()
		{
			return this.As<ISkiConfigTypeT>();
		}

		// Token: 0x06036856 RID: 223318 RVA: 0x0074C8EE File Offset: 0x0074AAEE
		public static ISkiConfigType_UnionUnion FromISkiConfigType(ISkiConfigTypeT _iskiconfigtype)
		{
			return new ISkiConfigType_UnionUnion
			{
				Type = ISkiConfigType_Union.ISkiConfigType,
				Value = _iskiconfigtype
			};
		}

		// Token: 0x06036857 RID: 223319 RVA: 0x0074C903 File Offset: 0x0074AB03
		public IOpenSkiConfigT AsIOpenSkiConfig()
		{
			return this.As<IOpenSkiConfigT>();
		}

		// Token: 0x06036858 RID: 223320 RVA: 0x0074C90B File Offset: 0x0074AB0B
		public static ISkiConfigType_UnionUnion FromIOpenSkiConfig(IOpenSkiConfigT _iopenskiconfig)
		{
			return new ISkiConfigType_UnionUnion
			{
				Type = ISkiConfigType_Union.IOpenSkiConfig,
				Value = _iopenskiconfig
			};
		}

		// Token: 0x06036859 RID: 223321 RVA: 0x0074C920 File Offset: 0x0074AB20
		public ICloseSkiConfigT AsICloseSkiConfig()
		{
			return this.As<ICloseSkiConfigT>();
		}

		// Token: 0x0603685A RID: 223322 RVA: 0x0074C928 File Offset: 0x0074AB28
		public static ISkiConfigType_UnionUnion FromICloseSkiConfig(ICloseSkiConfigT _icloseskiconfig)
		{
			return new ISkiConfigType_UnionUnion
			{
				Type = ISkiConfigType_Union.ICloseSkiConfig,
				Value = _icloseskiconfig
			};
		}

		// Token: 0x0603685B RID: 223323 RVA: 0x0074C93D File Offset: 0x0074AB3D
		public IAccelerateSkiConfigT AsIAccelerateSkiConfig()
		{
			return this.As<IAccelerateSkiConfigT>();
		}

		// Token: 0x0603685C RID: 223324 RVA: 0x0074C945 File Offset: 0x0074AB45
		public static ISkiConfigType_UnionUnion FromIAccelerateSkiConfig(IAccelerateSkiConfigT _iaccelerateskiconfig)
		{
			return new ISkiConfigType_UnionUnion
			{
				Type = ISkiConfigType_Union.IAccelerateSkiConfig,
				Value = _iaccelerateskiconfig
			};
		}

		// Token: 0x0603685D RID: 223325 RVA: 0x0074C95C File Offset: 0x0074AB5C
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
