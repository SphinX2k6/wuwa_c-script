using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004765 RID: 18277
	public class TRecallDataUnion
	{
		// Token: 0x17007F99 RID: 32665
		// (get) Token: 0x0601AEAB RID: 110251 RVA: 0x003D1600 File Offset: 0x003CF800
		// (set) Token: 0x0601AEAC RID: 110252 RVA: 0x003D1608 File Offset: 0x003CF808
		public TRecallData Type { get; set; }

		// Token: 0x17007F9A RID: 32666
		// (get) Token: 0x0601AEAD RID: 110253 RVA: 0x003D1611 File Offset: 0x003CF811
		// (set) Token: 0x0601AEAE RID: 110254 RVA: 0x003D1619 File Offset: 0x003CF819
		public object Value { get; set; }

		// Token: 0x0601AEAF RID: 110255 RVA: 0x003D1622 File Offset: 0x003CF822
		public TRecallDataUnion()
		{
			this.Type = TRecallData.NONE;
			this.Value = null;
		}

		// Token: 0x0601AEB0 RID: 110256 RVA: 0x003D1638 File Offset: 0x003CF838
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601AEB1 RID: 110257 RVA: 0x003D164A File Offset: 0x003CF84A
		public ILevelPlayRecallDataT AsILevelPlayRecallData()
		{
			return this.As<ILevelPlayRecallDataT>();
		}

		// Token: 0x0601AEB2 RID: 110258 RVA: 0x003D1652 File Offset: 0x003CF852
		public static TRecallDataUnion FromILevelPlayRecallData(ILevelPlayRecallDataT _ilevelplayrecalldata)
		{
			return new TRecallDataUnion
			{
				Type = TRecallData.ILevelPlayRecallData,
				Value = _ilevelplayrecalldata
			};
		}

		// Token: 0x0601AEB3 RID: 110259 RVA: 0x003D1667 File Offset: 0x003CF867
		public IQuestRecallDataT AsIQuestRecallData()
		{
			return this.As<IQuestRecallDataT>();
		}

		// Token: 0x0601AEB4 RID: 110260 RVA: 0x003D166F File Offset: 0x003CF86F
		public static TRecallDataUnion FromIQuestRecallData(IQuestRecallDataT _iquestrecalldata)
		{
			return new TRecallDataUnion
			{
				Type = TRecallData.IQuestRecallData,
				Value = _iquestrecalldata
			};
		}

		// Token: 0x0601AEB5 RID: 110261 RVA: 0x003D1684 File Offset: 0x003CF884
		public static int Pack(FlatBufferBuilder builder, TRecallDataUnion _o)
		{
			TRecallData type = _o.Type;
			if (type == TRecallData.ILevelPlayRecallData)
			{
				return ILevelPlayRecallData.Pack(builder, _o.AsILevelPlayRecallData()).Value;
			}
			if (type != TRecallData.IQuestRecallData)
			{
				return 0;
			}
			return IQuestRecallData.Pack(builder, _o.AsIQuestRecallData()).Value;
		}
	}
}
