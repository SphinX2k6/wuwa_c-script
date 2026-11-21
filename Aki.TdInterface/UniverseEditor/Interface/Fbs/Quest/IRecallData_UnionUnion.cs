using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020044CA RID: 17610
	public class IRecallData_UnionUnion
	{
		// Token: 0x17007A97 RID: 31383
		// (get) Token: 0x0601971C RID: 104220 RVA: 0x003A14E6 File Offset: 0x0039F6E6
		// (set) Token: 0x0601971D RID: 104221 RVA: 0x003A14EE File Offset: 0x0039F6EE
		public IRecallData_Union Type { get; set; }

		// Token: 0x17007A98 RID: 31384
		// (get) Token: 0x0601971E RID: 104222 RVA: 0x003A14F7 File Offset: 0x0039F6F7
		// (set) Token: 0x0601971F RID: 104223 RVA: 0x003A14FF File Offset: 0x0039F6FF
		public object Value { get; set; }

		// Token: 0x06019720 RID: 104224 RVA: 0x003A1508 File Offset: 0x0039F708
		public IRecallData_UnionUnion()
		{
			this.Type = IRecallData_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06019721 RID: 104225 RVA: 0x003A151E File Offset: 0x0039F71E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06019722 RID: 104226 RVA: 0x003A1530 File Offset: 0x0039F730
		public IRecallDataT AsIRecallData()
		{
			return this.As<IRecallDataT>();
		}

		// Token: 0x06019723 RID: 104227 RVA: 0x003A1538 File Offset: 0x0039F738
		public static IRecallData_UnionUnion FromIRecallData(IRecallDataT _irecalldata)
		{
			return new IRecallData_UnionUnion
			{
				Type = IRecallData_Union.IRecallData,
				Value = _irecalldata
			};
		}

		// Token: 0x06019724 RID: 104228 RVA: 0x003A154D File Offset: 0x0039F74D
		public IQuestRecallDataT AsIQuestRecallData()
		{
			return this.As<IQuestRecallDataT>();
		}

		// Token: 0x06019725 RID: 104229 RVA: 0x003A1555 File Offset: 0x0039F755
		public static IRecallData_UnionUnion FromIQuestRecallData(IQuestRecallDataT _iquestrecalldata)
		{
			return new IRecallData_UnionUnion
			{
				Type = IRecallData_Union.IQuestRecallData,
				Value = _iquestrecalldata
			};
		}

		// Token: 0x06019726 RID: 104230 RVA: 0x003A156A File Offset: 0x0039F76A
		public ILevelPlayRecallDataT AsILevelPlayRecallData()
		{
			return this.As<ILevelPlayRecallDataT>();
		}

		// Token: 0x06019727 RID: 104231 RVA: 0x003A1572 File Offset: 0x0039F772
		public static IRecallData_UnionUnion FromILevelPlayRecallData(ILevelPlayRecallDataT _ilevelplayrecalldata)
		{
			return new IRecallData_UnionUnion
			{
				Type = IRecallData_Union.ILevelPlayRecallData,
				Value = _ilevelplayrecalldata
			};
		}

		// Token: 0x06019728 RID: 104232 RVA: 0x003A1588 File Offset: 0x0039F788
		public static int Pack(FlatBufferBuilder builder, IRecallData_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IRecallData_Union.IRecallData:
				return IRecallData.Pack(builder, _o.AsIRecallData()).Value;
			case IRecallData_Union.IQuestRecallData:
				return IQuestRecallData.Pack(builder, _o.AsIQuestRecallData()).Value;
			case IRecallData_Union.ILevelPlayRecallData:
				return ILevelPlayRecallData.Pack(builder, _o.AsILevelPlayRecallData()).Value;
			default:
				return 0;
			}
		}
	}
}
