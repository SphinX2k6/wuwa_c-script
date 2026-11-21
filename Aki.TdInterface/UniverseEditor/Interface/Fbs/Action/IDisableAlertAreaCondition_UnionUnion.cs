using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C30 RID: 27696
	public class IDisableAlertAreaCondition_UnionUnion
	{
		// Token: 0x1700CAEF RID: 51951
		// (get) Token: 0x0602FA82 RID: 195202 RVA: 0x0067DFB9 File Offset: 0x0067C1B9
		// (set) Token: 0x0602FA83 RID: 195203 RVA: 0x0067DFC1 File Offset: 0x0067C1C1
		public IDisableAlertAreaCondition_Union Type { get; set; }

		// Token: 0x1700CAF0 RID: 51952
		// (get) Token: 0x0602FA84 RID: 195204 RVA: 0x0067DFCA File Offset: 0x0067C1CA
		// (set) Token: 0x0602FA85 RID: 195205 RVA: 0x0067DFD2 File Offset: 0x0067C1D2
		public object Value { get; set; }

		// Token: 0x0602FA86 RID: 195206 RVA: 0x0067DFDB File Offset: 0x0067C1DB
		public IDisableAlertAreaCondition_UnionUnion()
		{
			this.Type = IDisableAlertAreaCondition_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602FA87 RID: 195207 RVA: 0x0067DFF1 File Offset: 0x0067C1F1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602FA88 RID: 195208 RVA: 0x0067E003 File Offset: 0x0067C203
		public IDisableAlertAreaConditionT AsIDisableAlertAreaCondition()
		{
			return this.As<IDisableAlertAreaConditionT>();
		}

		// Token: 0x0602FA89 RID: 195209 RVA: 0x0067E00B File Offset: 0x0067C20B
		public static IDisableAlertAreaCondition_UnionUnion FromIDisableAlertAreaCondition(IDisableAlertAreaConditionT _idisablealertareacondition)
		{
			return new IDisableAlertAreaCondition_UnionUnion
			{
				Type = IDisableAlertAreaCondition_Union.IDisableAlertAreaCondition,
				Value = _idisablealertareacondition
			};
		}

		// Token: 0x0602FA8A RID: 195210 RVA: 0x0067E020 File Offset: 0x0067C220
		public IDisableAlertAreaDungeonConditionT AsIDisableAlertAreaDungeonCondition()
		{
			return this.As<IDisableAlertAreaDungeonConditionT>();
		}

		// Token: 0x0602FA8B RID: 195211 RVA: 0x0067E028 File Offset: 0x0067C228
		public static IDisableAlertAreaCondition_UnionUnion FromIDisableAlertAreaDungeonCondition(IDisableAlertAreaDungeonConditionT _idisablealertareadungeoncondition)
		{
			return new IDisableAlertAreaCondition_UnionUnion
			{
				Type = IDisableAlertAreaCondition_Union.IDisableAlertAreaDungeonCondition,
				Value = _idisablealertareadungeoncondition
			};
		}

		// Token: 0x0602FA8C RID: 195212 RVA: 0x0067E03D File Offset: 0x0067C23D
		public IDisableAlertAreaQuestConditionT AsIDisableAlertAreaQuestCondition()
		{
			return this.As<IDisableAlertAreaQuestConditionT>();
		}

		// Token: 0x0602FA8D RID: 195213 RVA: 0x0067E045 File Offset: 0x0067C245
		public static IDisableAlertAreaCondition_UnionUnion FromIDisableAlertAreaQuestCondition(IDisableAlertAreaQuestConditionT _idisablealertareaquestcondition)
		{
			return new IDisableAlertAreaCondition_UnionUnion
			{
				Type = IDisableAlertAreaCondition_Union.IDisableAlertAreaQuestCondition,
				Value = _idisablealertareaquestcondition
			};
		}

		// Token: 0x0602FA8E RID: 195214 RVA: 0x0067E05C File Offset: 0x0067C25C
		public static int Pack(FlatBufferBuilder builder, IDisableAlertAreaCondition_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IDisableAlertAreaCondition_Union.IDisableAlertAreaCondition:
				return IDisableAlertAreaCondition.Pack(builder, _o.AsIDisableAlertAreaCondition()).Value;
			case IDisableAlertAreaCondition_Union.IDisableAlertAreaDungeonCondition:
				return IDisableAlertAreaDungeonCondition.Pack(builder, _o.AsIDisableAlertAreaDungeonCondition()).Value;
			case IDisableAlertAreaCondition_Union.IDisableAlertAreaQuestCondition:
				return IDisableAlertAreaQuestCondition.Pack(builder, _o.AsIDisableAlertAreaQuestCondition()).Value;
			default:
				return 0;
			}
		}
	}
}
