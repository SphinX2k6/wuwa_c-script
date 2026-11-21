using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200602D RID: 24621
	public class ISystemModuleDataSyncData_UnionUnion
	{
		// Token: 0x1700B6A6 RID: 46758
		// (get) Token: 0x06029865 RID: 170085 RVA: 0x005AACCD File Offset: 0x005A8ECD
		// (set) Token: 0x06029866 RID: 170086 RVA: 0x005AACD5 File Offset: 0x005A8ED5
		public ISystemModuleDataSyncData_Union Type { get; set; }

		// Token: 0x1700B6A7 RID: 46759
		// (get) Token: 0x06029867 RID: 170087 RVA: 0x005AACDE File Offset: 0x005A8EDE
		// (set) Token: 0x06029868 RID: 170088 RVA: 0x005AACE6 File Offset: 0x005A8EE6
		public object Value { get; set; }

		// Token: 0x06029869 RID: 170089 RVA: 0x005AACEF File Offset: 0x005A8EEF
		public ISystemModuleDataSyncData_UnionUnion()
		{
			this.Type = ISystemModuleDataSyncData_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602986A RID: 170090 RVA: 0x005AAD05 File Offset: 0x005A8F05
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602986B RID: 170091 RVA: 0x005AAD17 File Offset: 0x005A8F17
		public ISystemModuleDataSyncDataT AsISystemModuleDataSyncData()
		{
			return this.As<ISystemModuleDataSyncDataT>();
		}

		// Token: 0x0602986C RID: 170092 RVA: 0x005AAD1F File Offset: 0x005A8F1F
		public static ISystemModuleDataSyncData_UnionUnion FromISystemModuleDataSyncData(ISystemModuleDataSyncDataT _isystemmoduledatasyncdata)
		{
			return new ISystemModuleDataSyncData_UnionUnion
			{
				Type = ISystemModuleDataSyncData_Union.ISystemModuleDataSyncData,
				Value = _isystemmoduledatasyncdata
			};
		}

		// Token: 0x0602986D RID: 170093 RVA: 0x005AAD34 File Offset: 0x005A8F34
		public ISystemModuleDataSyncMotorRacingT AsISystemModuleDataSyncMotorRacing()
		{
			return this.As<ISystemModuleDataSyncMotorRacingT>();
		}

		// Token: 0x0602986E RID: 170094 RVA: 0x005AAD3C File Offset: 0x005A8F3C
		public static ISystemModuleDataSyncData_UnionUnion FromISystemModuleDataSyncMotorRacing(ISystemModuleDataSyncMotorRacingT _isystemmoduledatasyncmotorracing)
		{
			return new ISystemModuleDataSyncData_UnionUnion
			{
				Type = ISystemModuleDataSyncData_Union.ISystemModuleDataSyncMotorRacing,
				Value = _isystemmoduledatasyncmotorracing
			};
		}

		// Token: 0x0602986F RID: 170095 RVA: 0x005AAD54 File Offset: 0x005A8F54
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
