using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004896 RID: 18582
	public class IP4SyncData_UnionUnion
	{
		// Token: 0x170086C4 RID: 34500
		// (get) Token: 0x0601CFEE RID: 118766 RVA: 0x00418B39 File Offset: 0x00416D39
		// (set) Token: 0x0601CFEF RID: 118767 RVA: 0x00418B41 File Offset: 0x00416D41
		public IP4SyncData_Union Type { get; set; }

		// Token: 0x170086C5 RID: 34501
		// (get) Token: 0x0601CFF0 RID: 118768 RVA: 0x00418B4A File Offset: 0x00416D4A
		// (set) Token: 0x0601CFF1 RID: 118769 RVA: 0x00418B52 File Offset: 0x00416D52
		public object Value { get; set; }

		// Token: 0x0601CFF2 RID: 118770 RVA: 0x00418B5B File Offset: 0x00416D5B
		public IP4SyncData_UnionUnion()
		{
			this.Type = IP4SyncData_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601CFF3 RID: 118771 RVA: 0x00418B71 File Offset: 0x00416D71
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601CFF4 RID: 118772 RVA: 0x00418B83 File Offset: 0x00416D83
		public IP4SyncDataT AsIP4SyncData()
		{
			return this.As<IP4SyncDataT>();
		}

		// Token: 0x0601CFF5 RID: 118773 RVA: 0x00418B8B File Offset: 0x00416D8B
		public static IP4SyncData_UnionUnion FromIP4SyncData(IP4SyncDataT _ip4syncdata)
		{
			return new IP4SyncData_UnionUnion
			{
				Type = IP4SyncData_Union.IP4SyncData,
				Value = _ip4syncdata
			};
		}

		// Token: 0x0601CFF6 RID: 118774 RVA: 0x00418BA0 File Offset: 0x00416DA0
		public IEditorSaviorSyncDataT AsIEditorSaviorSyncData()
		{
			return this.As<IEditorSaviorSyncDataT>();
		}

		// Token: 0x0601CFF7 RID: 118775 RVA: 0x00418BA8 File Offset: 0x00416DA8
		public static IP4SyncData_UnionUnion FromIEditorSaviorSyncData(IEditorSaviorSyncDataT _ieditorsaviorsyncdata)
		{
			return new IP4SyncData_UnionUnion
			{
				Type = IP4SyncData_Union.IEditorSaviorSyncData,
				Value = _ieditorsaviorsyncdata
			};
		}

		// Token: 0x0601CFF8 RID: 118776 RVA: 0x00418BBD File Offset: 0x00416DBD
		public IUgsSyncDataT AsIUgsSyncData()
		{
			return this.As<IUgsSyncDataT>();
		}

		// Token: 0x0601CFF9 RID: 118777 RVA: 0x00418BC5 File Offset: 0x00416DC5
		public static IP4SyncData_UnionUnion FromIUgsSyncData(IUgsSyncDataT _iugssyncdata)
		{
			return new IP4SyncData_UnionUnion
			{
				Type = IP4SyncData_Union.IUgsSyncData,
				Value = _iugssyncdata
			};
		}

		// Token: 0x0601CFFA RID: 118778 RVA: 0x00418BDC File Offset: 0x00416DDC
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
