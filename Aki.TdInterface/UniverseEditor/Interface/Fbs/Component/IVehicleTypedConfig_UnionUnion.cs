using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006143 RID: 24899
	public class IVehicleTypedConfig_UnionUnion
	{
		// Token: 0x1700B975 RID: 47477
		// (get) Token: 0x0602A402 RID: 173058 RVA: 0x005C3F09 File Offset: 0x005C2109
		// (set) Token: 0x0602A403 RID: 173059 RVA: 0x005C3F11 File Offset: 0x005C2111
		public IVehicleTypedConfig_Union Type { get; set; }

		// Token: 0x1700B976 RID: 47478
		// (get) Token: 0x0602A404 RID: 173060 RVA: 0x005C3F1A File Offset: 0x005C211A
		// (set) Token: 0x0602A405 RID: 173061 RVA: 0x005C3F22 File Offset: 0x005C2122
		public object Value { get; set; }

		// Token: 0x0602A406 RID: 173062 RVA: 0x005C3F2B File Offset: 0x005C212B
		public IVehicleTypedConfig_UnionUnion()
		{
			this.Type = IVehicleTypedConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602A407 RID: 173063 RVA: 0x005C3F41 File Offset: 0x005C2141
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602A408 RID: 173064 RVA: 0x005C3F53 File Offset: 0x005C2153
		public IVehicleTypedConfigT AsIVehicleTypedConfig()
		{
			return this.As<IVehicleTypedConfigT>();
		}

		// Token: 0x0602A409 RID: 173065 RVA: 0x005C3F5B File Offset: 0x005C215B
		public static IVehicleTypedConfig_UnionUnion FromIVehicleTypedConfig(IVehicleTypedConfigT _ivehicletypedconfig)
		{
			return new IVehicleTypedConfig_UnionUnion
			{
				Type = IVehicleTypedConfig_Union.IVehicleTypedConfig,
				Value = _ivehicletypedconfig
			};
		}

		// Token: 0x0602A40A RID: 173066 RVA: 0x005C3F70 File Offset: 0x005C2170
		public IVehicleTypedMotorConfigT AsIVehicleTypedMotorConfig()
		{
			return this.As<IVehicleTypedMotorConfigT>();
		}

		// Token: 0x0602A40B RID: 173067 RVA: 0x005C3F78 File Offset: 0x005C2178
		public static IVehicleTypedConfig_UnionUnion FromIVehicleTypedMotorConfig(IVehicleTypedMotorConfigT _ivehicletypedmotorconfig)
		{
			return new IVehicleTypedConfig_UnionUnion
			{
				Type = IVehicleTypedConfig_Union.IVehicleTypedMotorConfig,
				Value = _ivehicletypedmotorconfig
			};
		}

		// Token: 0x0602A40C RID: 173068 RVA: 0x005C3F90 File Offset: 0x005C2190
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
