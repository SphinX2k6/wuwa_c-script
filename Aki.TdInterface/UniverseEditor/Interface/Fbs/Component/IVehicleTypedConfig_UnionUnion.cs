using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B2D RID: 23341
	public class IVehicleTypedConfig_UnionUnion
	{
		// Token: 0x1700B02D RID: 45101
		// (get) Token: 0x06027E3E RID: 163390 RVA: 0x0057C4B5 File Offset: 0x0057A6B5
		// (set) Token: 0x06027E3F RID: 163391 RVA: 0x0057C4BD File Offset: 0x0057A6BD
		public IVehicleTypedConfig_Union Type { get; set; }

		// Token: 0x1700B02E RID: 45102
		// (get) Token: 0x06027E40 RID: 163392 RVA: 0x0057C4C6 File Offset: 0x0057A6C6
		// (set) Token: 0x06027E41 RID: 163393 RVA: 0x0057C4CE File Offset: 0x0057A6CE
		public object Value { get; set; }

		// Token: 0x06027E42 RID: 163394 RVA: 0x0057C4D7 File Offset: 0x0057A6D7
		public IVehicleTypedConfig_UnionUnion()
		{
			this.Type = IVehicleTypedConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06027E43 RID: 163395 RVA: 0x0057C4ED File Offset: 0x0057A6ED
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06027E44 RID: 163396 RVA: 0x0057C4FF File Offset: 0x0057A6FF
		public IVehicleTypedConfigT AsIVehicleTypedConfig()
		{
			return this.As<IVehicleTypedConfigT>();
		}

		// Token: 0x06027E45 RID: 163397 RVA: 0x0057C507 File Offset: 0x0057A707
		public static IVehicleTypedConfig_UnionUnion FromIVehicleTypedConfig(IVehicleTypedConfigT _ivehicletypedconfig)
		{
			return new IVehicleTypedConfig_UnionUnion
			{
				Type = IVehicleTypedConfig_Union.IVehicleTypedConfig,
				Value = _ivehicletypedconfig
			};
		}

		// Token: 0x06027E46 RID: 163398 RVA: 0x0057C51C File Offset: 0x0057A71C
		public IVehicleTypedMotorConfigT AsIVehicleTypedMotorConfig()
		{
			return this.As<IVehicleTypedMotorConfigT>();
		}

		// Token: 0x06027E47 RID: 163399 RVA: 0x0057C524 File Offset: 0x0057A724
		public static IVehicleTypedConfig_UnionUnion FromIVehicleTypedMotorConfig(IVehicleTypedMotorConfigT _ivehicletypedmotorconfig)
		{
			return new IVehicleTypedConfig_UnionUnion
			{
				Type = IVehicleTypedConfig_Union.IVehicleTypedMotorConfig,
				Value = _ivehicletypedmotorconfig
			};
		}

		// Token: 0x06027E48 RID: 163400 RVA: 0x0057C53C File Offset: 0x0057A73C
		public static int Pack(FlatBufferBuilder builder, IVehicleTypedConfig_UnionUnion _o)
		{
			IVehicleTypedConfig_Union type = _o.Type;
			if (type == IVehicleTypedConfig_Union.IVehicleTypedConfig)
			{
				return IVehicleTypedConfig.Pack(builder, _o.AsIVehicleTypedConfig()).Value;
			}
			if (type != IVehicleTypedConfig_Union.IVehicleTypedMotorConfig)
			{
				return 0;
			}
			return IVehicleTypedMotorConfig.Pack(builder, _o.AsIVehicleTypedMotorConfig()).Value;
		}
	}
}
