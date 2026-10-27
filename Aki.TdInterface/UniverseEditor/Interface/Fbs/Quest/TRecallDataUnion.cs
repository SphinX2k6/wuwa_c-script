using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004306 RID: 17158
	public class TRecallDataUnion
	{
		// Token: 0x17007966 RID: 31078
		// (get) Token: 0x06019729 RID: 104233 RVA: 0x003A5CD0 File Offset: 0x003A3ED0
		// (set) Token: 0x0601972A RID: 104234 RVA: 0x003A5CD8 File Offset: 0x003A3ED8
		public TRecallData Type { get; set; }

		// Token: 0x17007967 RID: 31079
		// (get) Token: 0x0601972B RID: 104235 RVA: 0x003A5CE1 File Offset: 0x003A3EE1
		// (set) Token: 0x0601972C RID: 104236 RVA: 0x003A5CE9 File Offset: 0x003A3EE9
		public object Value { get; set; }

		// Token: 0x0601972D RID: 104237 RVA: 0x003A5CF2 File Offset: 0x003A3EF2
		public TRecallDataUnion()
		{
			this.Type = TRecallData.NONE;
			this.Value = null;
		}

		// Token: 0x0601972E RID: 104238 RVA: 0x003A5D08 File Offset: 0x003A3F08
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601972F RID: 104239 RVA: 0x003A5D1A File Offset: 0x003A3F1A
		public ILevelPlayRecallDataT AsILevelPlayRecallData()
		{
			return this.As<ILevelPlayRecallDataT>();
		}

		// Token: 0x06019730 RID: 104240 RVA: 0x003A5D22 File Offset: 0x003A3F22
		public static TRecallDataUnion FromILevelPlayRecallData(ILevelPlayRecallDataT _ilevelplayrecalldata)
		{
			return new TRecallDataUnion
			{
				Type = TRecallData.ILevelPlayRecallData,
				Value = _ilevelplayrecalldata
			};
		}

		// Token: 0x06019731 RID: 104241 RVA: 0x003A5D37 File Offset: 0x003A3F37
		public IQuestRecallDataT AsIQuestRecallData()
		{
			return this.As<IQuestRecallDataT>();
		}

		// Token: 0x06019732 RID: 104242 RVA: 0x003A5D3F File Offset: 0x003A3F3F
		public static TRecallDataUnion FromIQuestRecallData(IQuestRecallDataT _iquestrecalldata)
		{
			return new TRecallDataUnion
			{
				Type = TRecallData.IQuestRecallData,
				Value = _iquestrecalldata
			};
		}

		// Token: 0x06019733 RID: 104243 RVA: 0x003A5D54 File Offset: 0x003A3F54
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
