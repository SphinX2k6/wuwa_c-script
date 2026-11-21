using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006468 RID: 25704
	public class IOutAreaBorderType_UnionUnion
	{
		// Token: 0x1700BDB8 RID: 48568
		// (get) Token: 0x0602BAD8 RID: 178904 RVA: 0x005F1C59 File Offset: 0x005EFE59
		// (set) Token: 0x0602BAD9 RID: 178905 RVA: 0x005F1C61 File Offset: 0x005EFE61
		public IOutAreaBorderType_Union Type { get; set; }

		// Token: 0x1700BDB9 RID: 48569
		// (get) Token: 0x0602BADA RID: 178906 RVA: 0x005F1C6A File Offset: 0x005EFE6A
		// (set) Token: 0x0602BADB RID: 178907 RVA: 0x005F1C72 File Offset: 0x005EFE72
		public object Value { get; set; }

		// Token: 0x0602BADC RID: 178908 RVA: 0x005F1C7B File Offset: 0x005EFE7B
		public IOutAreaBorderType_UnionUnion()
		{
			this.Type = IOutAreaBorderType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602BADD RID: 178909 RVA: 0x005F1C91 File Offset: 0x005EFE91
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602BADE RID: 178910 RVA: 0x005F1CA3 File Offset: 0x005EFEA3
		public IOutAreaBorderTypeT AsIOutAreaBorderType()
		{
			return this.As<IOutAreaBorderTypeT>();
		}

		// Token: 0x0602BADF RID: 178911 RVA: 0x005F1CAB File Offset: 0x005EFEAB
		public static IOutAreaBorderType_UnionUnion FromIOutAreaBorderType(IOutAreaBorderTypeT _ioutareabordertype)
		{
			return new IOutAreaBorderType_UnionUnion
			{
				Type = IOutAreaBorderType_Union.IOutAreaBorderType,
				Value = _ioutareabordertype
			};
		}

		// Token: 0x0602BAE0 RID: 178912 RVA: 0x005F1CC0 File Offset: 0x005EFEC0
		public IOutAreaBorderTimerConfigT AsIOutAreaBorderTimerConfig()
		{
			return this.As<IOutAreaBorderTimerConfigT>();
		}

		// Token: 0x0602BAE1 RID: 178913 RVA: 0x005F1CC8 File Offset: 0x005EFEC8
		public static IOutAreaBorderType_UnionUnion FromIOutAreaBorderTimerConfig(IOutAreaBorderTimerConfigT _ioutareabordertimerconfig)
		{
			return new IOutAreaBorderType_UnionUnion
			{
				Type = IOutAreaBorderType_Union.IOutAreaBorderTimerConfig,
				Value = _ioutareabordertimerconfig
			};
		}

		// Token: 0x0602BAE2 RID: 178914 RVA: 0x005F1CE0 File Offset: 0x005EFEE0
		public static int Pack(FlatBufferBuilder builder, IOutAreaBorderType_UnionUnion _o)
		{
			IOutAreaBorderType_Union type = _o.Type;
			if (type == IOutAreaBorderType_Union.IOutAreaBorderType)
			{
				return IOutAreaBorderType.Pack(builder, _o.AsIOutAreaBorderType()).Value;
			}
			if (type != IOutAreaBorderType_Union.IOutAreaBorderTimerConfig)
			{
				return 0;
			}
			return IOutAreaBorderTimerConfig.Pack(builder, _o.AsIOutAreaBorderTimerConfig()).Value;
		}
	}
}
