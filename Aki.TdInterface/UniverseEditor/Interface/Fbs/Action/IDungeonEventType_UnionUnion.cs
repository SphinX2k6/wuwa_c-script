using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006619 RID: 26137
	public class IDungeonEventType_UnionUnion
	{
		// Token: 0x1700C238 RID: 49720
		// (get) Token: 0x0602D639 RID: 185913 RVA: 0x00638335 File Offset: 0x00636535
		// (set) Token: 0x0602D63A RID: 185914 RVA: 0x0063833D File Offset: 0x0063653D
		public IDungeonEventType_Union Type { get; set; }

		// Token: 0x1700C239 RID: 49721
		// (get) Token: 0x0602D63B RID: 185915 RVA: 0x00638346 File Offset: 0x00636546
		// (set) Token: 0x0602D63C RID: 185916 RVA: 0x0063834E File Offset: 0x0063654E
		public object Value { get; set; }

		// Token: 0x0602D63D RID: 185917 RVA: 0x00638357 File Offset: 0x00636557
		public IDungeonEventType_UnionUnion()
		{
			this.Type = IDungeonEventType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602D63E RID: 185918 RVA: 0x0063836D File Offset: 0x0063656D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602D63F RID: 185919 RVA: 0x0063837F File Offset: 0x0063657F
		public IDungeonEventTypeT AsIDungeonEventType()
		{
			return this.As<IDungeonEventTypeT>();
		}

		// Token: 0x0602D640 RID: 185920 RVA: 0x00638387 File Offset: 0x00636587
		public static IDungeonEventType_UnionUnion FromIDungeonEventType(IDungeonEventTypeT _idungeoneventtype)
		{
			return new IDungeonEventType_UnionUnion
			{
				Type = IDungeonEventType_Union.IDungeonEventType,
				Value = _idungeoneventtype
			};
		}

		// Token: 0x0602D641 RID: 185921 RVA: 0x0063839C File Offset: 0x0063659C
		public IRecordTimeStampTypeT AsIRecordTimeStampType()
		{
			return this.As<IRecordTimeStampTypeT>();
		}

		// Token: 0x0602D642 RID: 185922 RVA: 0x006383A4 File Offset: 0x006365A4
		public static IDungeonEventType_UnionUnion FromIRecordTimeStampType(IRecordTimeStampTypeT _irecordtimestamptype)
		{
			return new IDungeonEventType_UnionUnion
			{
				Type = IDungeonEventType_Union.IRecordTimeStampType,
				Value = _irecordtimestamptype
			};
		}

		// Token: 0x0602D643 RID: 185923 RVA: 0x006383BC File Offset: 0x006365BC
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
