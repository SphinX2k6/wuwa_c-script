using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020065C8 RID: 26056
	public class IDisableAlertAreaCondition_UnionUnion
	{
		// Token: 0x1700C160 RID: 49504
		// (get) Token: 0x0602D2FE RID: 185086 RVA: 0x00631DF5 File Offset: 0x0062FFF5
		// (set) Token: 0x0602D2FF RID: 185087 RVA: 0x00631DFD File Offset: 0x0062FFFD
		public IDisableAlertAreaCondition_Union Type { get; set; }

		// Token: 0x1700C161 RID: 49505
		// (get) Token: 0x0602D300 RID: 185088 RVA: 0x00631E06 File Offset: 0x00630006
		// (set) Token: 0x0602D301 RID: 185089 RVA: 0x00631E0E File Offset: 0x0063000E
		public object Value { get; set; }

		// Token: 0x0602D302 RID: 185090 RVA: 0x00631E17 File Offset: 0x00630017
		public IDisableAlertAreaCondition_UnionUnion()
		{
			this.Type = IDisableAlertAreaCondition_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602D303 RID: 185091 RVA: 0x00631E2D File Offset: 0x0063002D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602D304 RID: 185092 RVA: 0x00631E3F File Offset: 0x0063003F
		public IDisableAlertAreaConditionT AsIDisableAlertAreaCondition()
		{
			return this.As<IDisableAlertAreaConditionT>();
		}

		// Token: 0x0602D305 RID: 185093 RVA: 0x00631E47 File Offset: 0x00630047
		public static IDisableAlertAreaCondition_UnionUnion FromIDisableAlertAreaCondition(IDisableAlertAreaConditionT _idisablealertareacondition)
		{
			return new IDisableAlertAreaCondition_UnionUnion
			{
				Type = IDisableAlertAreaCondition_Union.IDisableAlertAreaCondition,
				Value = _idisablealertareacondition
			};
		}

		// Token: 0x0602D306 RID: 185094 RVA: 0x00631E5C File Offset: 0x0063005C
		public IDisableAlertAreaDungeonConditionT AsIDisableAlertAreaDungeonCondition()
		{
			return this.As<IDisableAlertAreaDungeonConditionT>();
		}

		// Token: 0x0602D307 RID: 185095 RVA: 0x00631E64 File Offset: 0x00630064
		public static IDisableAlertAreaCondition_UnionUnion FromIDisableAlertAreaDungeonCondition(IDisableAlertAreaDungeonConditionT _idisablealertareadungeoncondition)
		{
			return new IDisableAlertAreaCondition_UnionUnion
			{
				Type = IDisableAlertAreaCondition_Union.IDisableAlertAreaDungeonCondition,
				Value = _idisablealertareadungeoncondition
			};
		}

		// Token: 0x0602D308 RID: 185096 RVA: 0x00631E79 File Offset: 0x00630079
		public IDisableAlertAreaQuestConditionT AsIDisableAlertAreaQuestCondition()
		{
			return this.As<IDisableAlertAreaQuestConditionT>();
		}

		// Token: 0x0602D309 RID: 185097 RVA: 0x00631E81 File Offset: 0x00630081
		public static IDisableAlertAreaCondition_UnionUnion FromIDisableAlertAreaQuestCondition(IDisableAlertAreaQuestConditionT _idisablealertareaquestcondition)
		{
			return new IDisableAlertAreaCondition_UnionUnion
			{
				Type = IDisableAlertAreaCondition_Union.IDisableAlertAreaQuestCondition,
				Value = _idisablealertareaquestcondition
			};
		}

		// Token: 0x0602D30A RID: 185098 RVA: 0x00631E98 File Offset: 0x00630098
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
