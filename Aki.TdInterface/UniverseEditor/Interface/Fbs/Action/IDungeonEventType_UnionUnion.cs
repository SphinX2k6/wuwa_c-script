using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C8A RID: 27786
	public class IDungeonEventType_UnionUnion
	{
		// Token: 0x1700CBD6 RID: 52182
		// (get) Token: 0x0602FE0A RID: 196106 RVA: 0x00684E9D File Offset: 0x0068309D
		// (set) Token: 0x0602FE0B RID: 196107 RVA: 0x00684EA5 File Offset: 0x006830A5
		public IDungeonEventType_Union Type { get; set; }

		// Token: 0x1700CBD7 RID: 52183
		// (get) Token: 0x0602FE0C RID: 196108 RVA: 0x00684EAE File Offset: 0x006830AE
		// (set) Token: 0x0602FE0D RID: 196109 RVA: 0x00684EB6 File Offset: 0x006830B6
		public object Value { get; set; }

		// Token: 0x0602FE0E RID: 196110 RVA: 0x00684EBF File Offset: 0x006830BF
		public IDungeonEventType_UnionUnion()
		{
			this.Type = IDungeonEventType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602FE0F RID: 196111 RVA: 0x00684ED5 File Offset: 0x006830D5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602FE10 RID: 196112 RVA: 0x00684EE7 File Offset: 0x006830E7
		public IDungeonEventTypeT AsIDungeonEventType()
		{
			return this.As<IDungeonEventTypeT>();
		}

		// Token: 0x0602FE11 RID: 196113 RVA: 0x00684EEF File Offset: 0x006830EF
		public static IDungeonEventType_UnionUnion FromIDungeonEventType(IDungeonEventTypeT _idungeoneventtype)
		{
			return new IDungeonEventType_UnionUnion
			{
				Type = IDungeonEventType_Union.IDungeonEventType,
				Value = _idungeoneventtype
			};
		}

		// Token: 0x0602FE12 RID: 196114 RVA: 0x00684F04 File Offset: 0x00683104
		public IRecordTimeStampTypeT AsIRecordTimeStampType()
		{
			return this.As<IRecordTimeStampTypeT>();
		}

		// Token: 0x0602FE13 RID: 196115 RVA: 0x00684F0C File Offset: 0x0068310C
		public static IDungeonEventType_UnionUnion FromIRecordTimeStampType(IRecordTimeStampTypeT _irecordtimestamptype)
		{
			return new IDungeonEventType_UnionUnion
			{
				Type = IDungeonEventType_Union.IRecordTimeStampType,
				Value = _irecordtimestamptype
			};
		}

		// Token: 0x0602FE14 RID: 196116 RVA: 0x00684F24 File Offset: 0x00683124
		public static int Pack(FlatBufferBuilder builder, IDungeonEventType_UnionUnion _o)
		{
			IDungeonEventType_Union type = _o.Type;
			if (type == IDungeonEventType_Union.IDungeonEventType)
			{
				return IDungeonEventType.Pack(builder, _o.AsIDungeonEventType()).Value;
			}
			if (type != IDungeonEventType_Union.IRecordTimeStampType)
			{
				return 0;
			}
			return IRecordTimeStampType.Pack(builder, _o.AsIRecordTimeStampType()).Value;
		}
	}
}
