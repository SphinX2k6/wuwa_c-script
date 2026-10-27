using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E2B RID: 24107
	public class IOutAreaBorderType_UnionUnion
	{
		// Token: 0x1700B452 RID: 46162
		// (get) Token: 0x0602944E RID: 169038 RVA: 0x005A8F29 File Offset: 0x005A7129
		// (set) Token: 0x0602944F RID: 169039 RVA: 0x005A8F31 File Offset: 0x005A7131
		public IOutAreaBorderType_Union Type { get; set; }

		// Token: 0x1700B453 RID: 46163
		// (get) Token: 0x06029450 RID: 169040 RVA: 0x005A8F3A File Offset: 0x005A713A
		// (set) Token: 0x06029451 RID: 169041 RVA: 0x005A8F42 File Offset: 0x005A7142
		public object Value { get; set; }

		// Token: 0x06029452 RID: 169042 RVA: 0x005A8F4B File Offset: 0x005A714B
		public IOutAreaBorderType_UnionUnion()
		{
			this.Type = IOutAreaBorderType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06029453 RID: 169043 RVA: 0x005A8F61 File Offset: 0x005A7161
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06029454 RID: 169044 RVA: 0x005A8F73 File Offset: 0x005A7173
		public IOutAreaBorderTypeT AsIOutAreaBorderType()
		{
			return this.As<IOutAreaBorderTypeT>();
		}

		// Token: 0x06029455 RID: 169045 RVA: 0x005A8F7B File Offset: 0x005A717B
		public static IOutAreaBorderType_UnionUnion FromIOutAreaBorderType(IOutAreaBorderTypeT _ioutareabordertype)
		{
			return new IOutAreaBorderType_UnionUnion
			{
				Type = IOutAreaBorderType_Union.IOutAreaBorderType,
				Value = _ioutareabordertype
			};
		}

		// Token: 0x06029456 RID: 169046 RVA: 0x005A8F90 File Offset: 0x005A7190
		public IOutAreaBorderTimerConfigT AsIOutAreaBorderTimerConfig()
		{
			return this.As<IOutAreaBorderTimerConfigT>();
		}

		// Token: 0x06029457 RID: 169047 RVA: 0x005A8F98 File Offset: 0x005A7198
		public static IOutAreaBorderType_UnionUnion FromIOutAreaBorderTimerConfig(IOutAreaBorderTimerConfigT _ioutareabordertimerconfig)
		{
			return new IOutAreaBorderType_UnionUnion
			{
				Type = IOutAreaBorderType_Union.IOutAreaBorderTimerConfig,
				Value = _ioutareabordertimerconfig
			};
		}

		// Token: 0x06029458 RID: 169048 RVA: 0x005A8FB0 File Offset: 0x005A71B0
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
