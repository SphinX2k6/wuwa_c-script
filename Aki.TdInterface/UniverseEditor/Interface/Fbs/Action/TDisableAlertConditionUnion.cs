using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076A8 RID: 30376
	public class TDisableAlertConditionUnion
	{
		// Token: 0x1700E609 RID: 58889
		// (get) Token: 0x0603743A RID: 226362 RVA: 0x0077D3FE File Offset: 0x0077B5FE
		// (set) Token: 0x0603743B RID: 226363 RVA: 0x0077D406 File Offset: 0x0077B606
		public TDisableAlertCondition Type { get; set; }

		// Token: 0x1700E60A RID: 58890
		// (get) Token: 0x0603743C RID: 226364 RVA: 0x0077D40F File Offset: 0x0077B60F
		// (set) Token: 0x0603743D RID: 226365 RVA: 0x0077D417 File Offset: 0x0077B617
		public object Value { get; set; }

		// Token: 0x0603743E RID: 226366 RVA: 0x0077D420 File Offset: 0x0077B620
		public TDisableAlertConditionUnion()
		{
			this.Type = TDisableAlertCondition.NONE;
			this.Value = null;
		}

		// Token: 0x0603743F RID: 226367 RVA: 0x0077D436 File Offset: 0x0077B636
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037440 RID: 226368 RVA: 0x0077D448 File Offset: 0x0077B648
		public IDisableAlertAreaDungeonConditionT AsIDisableAlertAreaDungeonCondition()
		{
			return this.As<IDisableAlertAreaDungeonConditionT>();
		}

		// Token: 0x06037441 RID: 226369 RVA: 0x0077D450 File Offset: 0x0077B650
		public static TDisableAlertConditionUnion FromIDisableAlertAreaDungeonCondition(IDisableAlertAreaDungeonConditionT _idisablealertareadungeoncondition)
		{
			return new TDisableAlertConditionUnion
			{
				Type = TDisableAlertCondition.IDisableAlertAreaDungeonCondition,
				Value = _idisablealertareadungeoncondition
			};
		}

		// Token: 0x06037442 RID: 226370 RVA: 0x0077D465 File Offset: 0x0077B665
		public IDisableAlertAreaQuestConditionT AsIDisableAlertAreaQuestCondition()
		{
			return this.As<IDisableAlertAreaQuestConditionT>();
		}

		// Token: 0x06037443 RID: 226371 RVA: 0x0077D46D File Offset: 0x0077B66D
		public static TDisableAlertConditionUnion FromIDisableAlertAreaQuestCondition(IDisableAlertAreaQuestConditionT _idisablealertareaquestcondition)
		{
			return new TDisableAlertConditionUnion
			{
				Type = TDisableAlertCondition.IDisableAlertAreaQuestCondition,
				Value = _idisablealertareaquestcondition
			};
		}

		// Token: 0x06037444 RID: 226372 RVA: 0x0077D484 File Offset: 0x0077B684
		public static int Pack(FlatBufferBuilder builder, TDisableAlertConditionUnion _o)
		{
			TDisableAlertCondition type = _o.Type;
			if (type == TDisableAlertCondition.IDisableAlertAreaDungeonCondition)
			{
				return IDisableAlertAreaDungeonCondition.Pack(builder, _o.AsIDisableAlertAreaDungeonCondition()).Value;
			}
			if (type != TDisableAlertCondition.IDisableAlertAreaQuestCondition)
			{
				return 0;
			}
			return IDisableAlertAreaQuestCondition.Pack(builder, _o.AsIDisableAlertAreaQuestCondition()).Value;
		}
	}
}
