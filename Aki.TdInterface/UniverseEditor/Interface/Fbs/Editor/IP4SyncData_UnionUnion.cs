using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004CFB RID: 19707
	public class IP4SyncData_UnionUnion
	{
		// Token: 0x17008D0C RID: 36108
		// (get) Token: 0x0601E7DB RID: 124891 RVA: 0x004452D5 File Offset: 0x004434D5
		// (set) Token: 0x0601E7DC RID: 124892 RVA: 0x004452DD File Offset: 0x004434DD
		public IP4SyncData_Union Type { get; set; }

		// Token: 0x17008D0D RID: 36109
		// (get) Token: 0x0601E7DD RID: 124893 RVA: 0x004452E6 File Offset: 0x004434E6
		// (set) Token: 0x0601E7DE RID: 124894 RVA: 0x004452EE File Offset: 0x004434EE
		public object Value { get; set; }

		// Token: 0x0601E7DF RID: 124895 RVA: 0x004452F7 File Offset: 0x004434F7
		public IP4SyncData_UnionUnion()
		{
			this.Type = IP4SyncData_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601E7E0 RID: 124896 RVA: 0x0044530D File Offset: 0x0044350D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601E7E1 RID: 124897 RVA: 0x0044531F File Offset: 0x0044351F
		public IP4SyncDataT AsIP4SyncData()
		{
			return this.As<IP4SyncDataT>();
		}

		// Token: 0x0601E7E2 RID: 124898 RVA: 0x00445327 File Offset: 0x00443527
		public static IP4SyncData_UnionUnion FromIP4SyncData(IP4SyncDataT _ip4syncdata)
		{
			return new IP4SyncData_UnionUnion
			{
				Type = IP4SyncData_Union.IP4SyncData,
				Value = _ip4syncdata
			};
		}

		// Token: 0x0601E7E3 RID: 124899 RVA: 0x0044533C File Offset: 0x0044353C
		public IEditorSaviorSyncDataT AsIEditorSaviorSyncData()
		{
			return this.As<IEditorSaviorSyncDataT>();
		}

		// Token: 0x0601E7E4 RID: 124900 RVA: 0x00445344 File Offset: 0x00443544
		public static IP4SyncData_UnionUnion FromIEditorSaviorSyncData(IEditorSaviorSyncDataT _ieditorsaviorsyncdata)
		{
			return new IP4SyncData_UnionUnion
			{
				Type = IP4SyncData_Union.IEditorSaviorSyncData,
				Value = _ieditorsaviorsyncdata
			};
		}

		// Token: 0x0601E7E5 RID: 124901 RVA: 0x00445359 File Offset: 0x00443559
		public IUgsSyncDataT AsIUgsSyncData()
		{
			return this.As<IUgsSyncDataT>();
		}

		// Token: 0x0601E7E6 RID: 124902 RVA: 0x00445361 File Offset: 0x00443561
		public static IP4SyncData_UnionUnion FromIUgsSyncData(IUgsSyncDataT _iugssyncdata)
		{
			return new IP4SyncData_UnionUnion
			{
				Type = IP4SyncData_Union.IUgsSyncData,
				Value = _iugssyncdata
			};
		}

		// Token: 0x0601E7E7 RID: 124903 RVA: 0x00445378 File Offset: 0x00443578
		public static int Pack(FlatBufferBuilder builder, IP4SyncData_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IP4SyncData_Union.IP4SyncData:
				return IP4SyncData.Pack(builder, _o.AsIP4SyncData()).Value;
			case IP4SyncData_Union.IEditorSaviorSyncData:
				return IEditorSaviorSyncData.Pack(builder, _o.AsIEditorSaviorSyncData()).Value;
			case IP4SyncData_Union.IUgsSyncData:
				return IUgsSyncData.Pack(builder, _o.AsIUgsSyncData()).Value;
			default:
				return 0;
			}
		}
	}
}
