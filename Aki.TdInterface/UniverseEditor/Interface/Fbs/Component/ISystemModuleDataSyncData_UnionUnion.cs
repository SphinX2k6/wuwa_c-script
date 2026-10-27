using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A20 RID: 23072
	public class ISystemModuleDataSyncData_UnionUnion
	{
		// Token: 0x1700AD6E RID: 44398
		// (get) Token: 0x060272ED RID: 160493 RVA: 0x00563D09 File Offset: 0x00561F09
		// (set) Token: 0x060272EE RID: 160494 RVA: 0x00563D11 File Offset: 0x00561F11
		public ISystemModuleDataSyncData_Union Type { get; set; }

		// Token: 0x1700AD6F RID: 44399
		// (get) Token: 0x060272EF RID: 160495 RVA: 0x00563D1A File Offset: 0x00561F1A
		// (set) Token: 0x060272F0 RID: 160496 RVA: 0x00563D22 File Offset: 0x00561F22
		public object Value { get; set; }

		// Token: 0x060272F1 RID: 160497 RVA: 0x00563D2B File Offset: 0x00561F2B
		public ISystemModuleDataSyncData_UnionUnion()
		{
			this.Type = ISystemModuleDataSyncData_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060272F2 RID: 160498 RVA: 0x00563D41 File Offset: 0x00561F41
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060272F3 RID: 160499 RVA: 0x00563D53 File Offset: 0x00561F53
		public ISystemModuleDataSyncDataT AsISystemModuleDataSyncData()
		{
			return this.As<ISystemModuleDataSyncDataT>();
		}

		// Token: 0x060272F4 RID: 160500 RVA: 0x00563D5B File Offset: 0x00561F5B
		public static ISystemModuleDataSyncData_UnionUnion FromISystemModuleDataSyncData(ISystemModuleDataSyncDataT _isystemmoduledatasyncdata)
		{
			return new ISystemModuleDataSyncData_UnionUnion
			{
				Type = ISystemModuleDataSyncData_Union.ISystemModuleDataSyncData,
				Value = _isystemmoduledatasyncdata
			};
		}

		// Token: 0x060272F5 RID: 160501 RVA: 0x00563D70 File Offset: 0x00561F70
		public ISystemModuleDataSyncMotorRacingT AsISystemModuleDataSyncMotorRacing()
		{
			return this.As<ISystemModuleDataSyncMotorRacingT>();
		}

		// Token: 0x060272F6 RID: 160502 RVA: 0x00563D78 File Offset: 0x00561F78
		public static ISystemModuleDataSyncData_UnionUnion FromISystemModuleDataSyncMotorRacing(ISystemModuleDataSyncMotorRacingT _isystemmoduledatasyncmotorracing)
		{
			return new ISystemModuleDataSyncData_UnionUnion
			{
				Type = ISystemModuleDataSyncData_Union.ISystemModuleDataSyncMotorRacing,
				Value = _isystemmoduledatasyncmotorracing
			};
		}

		// Token: 0x060272F7 RID: 160503 RVA: 0x00563D90 File Offset: 0x00561F90
		public static int Pack(FlatBufferBuilder builder, ISystemModuleDataSyncData_UnionUnion _o)
		{
			ISystemModuleDataSyncData_Union type = _o.Type;
			if (type == ISystemModuleDataSyncData_Union.ISystemModuleDataSyncData)
			{
				return ISystemModuleDataSyncData.Pack(builder, _o.AsISystemModuleDataSyncData()).Value;
			}
			if (type != ISystemModuleDataSyncData_Union.ISystemModuleDataSyncMotorRacing)
			{
				return 0;
			}
			return ISystemModuleDataSyncMotorRacing.Pack(builder, _o.AsISystemModuleDataSyncMotorRacing()).Value;
		}
	}
}
