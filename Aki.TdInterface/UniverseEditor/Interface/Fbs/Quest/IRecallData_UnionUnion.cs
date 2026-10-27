using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004089 RID: 16521
	public class IRecallData_UnionUnion
	{
		// Token: 0x17007495 RID: 29845
		// (get) Token: 0x06018083 RID: 98435 RVA: 0x003776AE File Offset: 0x003758AE
		// (set) Token: 0x06018084 RID: 98436 RVA: 0x003776B6 File Offset: 0x003758B6
		public IRecallData_Union Type { get; set; }

		// Token: 0x17007496 RID: 29846
		// (get) Token: 0x06018085 RID: 98437 RVA: 0x003776BF File Offset: 0x003758BF
		// (set) Token: 0x06018086 RID: 98438 RVA: 0x003776C7 File Offset: 0x003758C7
		public object Value { get; set; }

		// Token: 0x06018087 RID: 98439 RVA: 0x003776D0 File Offset: 0x003758D0
		public IRecallData_UnionUnion()
		{
			this.Type = IRecallData_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06018088 RID: 98440 RVA: 0x003776E6 File Offset: 0x003758E6
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06018089 RID: 98441 RVA: 0x003776F8 File Offset: 0x003758F8
		public IRecallDataT AsIRecallData()
		{
			return this.As<IRecallDataT>();
		}

		// Token: 0x0601808A RID: 98442 RVA: 0x00377700 File Offset: 0x00375900
		public static IRecallData_UnionUnion FromIRecallData(IRecallDataT _irecalldata)
		{
			return new IRecallData_UnionUnion
			{
				Type = IRecallData_Union.IRecallData,
				Value = _irecalldata
			};
		}

		// Token: 0x0601808B RID: 98443 RVA: 0x00377715 File Offset: 0x00375915
		public IQuestRecallDataT AsIQuestRecallData()
		{
			return this.As<IQuestRecallDataT>();
		}

		// Token: 0x0601808C RID: 98444 RVA: 0x0037771D File Offset: 0x0037591D
		public static IRecallData_UnionUnion FromIQuestRecallData(IQuestRecallDataT _iquestrecalldata)
		{
			return new IRecallData_UnionUnion
			{
				Type = IRecallData_Union.IQuestRecallData,
				Value = _iquestrecalldata
			};
		}

		// Token: 0x0601808D RID: 98445 RVA: 0x00377732 File Offset: 0x00375932
		public ILevelPlayRecallDataT AsILevelPlayRecallData()
		{
			return this.As<ILevelPlayRecallDataT>();
		}

		// Token: 0x0601808E RID: 98446 RVA: 0x0037773A File Offset: 0x0037593A
		public static IRecallData_UnionUnion FromILevelPlayRecallData(ILevelPlayRecallDataT _ilevelplayrecalldata)
		{
			return new IRecallData_UnionUnion
			{
				Type = IRecallData_Union.ILevelPlayRecallData,
				Value = _ilevelplayrecalldata
			};
		}

		// Token: 0x0601808F RID: 98447 RVA: 0x00377750 File Offset: 0x00375950
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
