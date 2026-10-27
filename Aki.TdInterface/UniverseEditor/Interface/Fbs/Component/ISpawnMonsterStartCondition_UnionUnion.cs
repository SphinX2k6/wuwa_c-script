using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005966 RID: 22886
	public class ISpawnMonsterStartCondition_UnionUnion
	{
		// Token: 0x1700ABC2 RID: 43970
		// (get) Token: 0x06026BC9 RID: 158665 RVA: 0x0055559D File Offset: 0x0055379D
		// (set) Token: 0x06026BCA RID: 158666 RVA: 0x005555A5 File Offset: 0x005537A5
		public ISpawnMonsterStartCondition_Union Type { get; set; }

		// Token: 0x1700ABC3 RID: 43971
		// (get) Token: 0x06026BCB RID: 158667 RVA: 0x005555AE File Offset: 0x005537AE
		// (set) Token: 0x06026BCC RID: 158668 RVA: 0x005555B6 File Offset: 0x005537B6
		public object Value { get; set; }

		// Token: 0x06026BCD RID: 158669 RVA: 0x005555BF File Offset: 0x005537BF
		public ISpawnMonsterStartCondition_UnionUnion()
		{
			this.Type = ISpawnMonsterStartCondition_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06026BCE RID: 158670 RVA: 0x005555D5 File Offset: 0x005537D5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06026BCF RID: 158671 RVA: 0x005555E7 File Offset: 0x005537E7
		public ISpawnMonsterStartConditionT AsISpawnMonsterStartCondition()
		{
			return this.As<ISpawnMonsterStartConditionT>();
		}

		// Token: 0x06026BD0 RID: 158672 RVA: 0x005555EF File Offset: 0x005537EF
		public static ISpawnMonsterStartCondition_UnionUnion FromISpawnMonsterStartCondition(ISpawnMonsterStartConditionT _ispawnmonsterstartcondition)
		{
			return new ISpawnMonsterStartCondition_UnionUnion
			{
				Type = ISpawnMonsterStartCondition_Union.ISpawnMonsterStartCondition,
				Value = _ispawnmonsterstartcondition
			};
		}

		// Token: 0x06026BD1 RID: 158673 RVA: 0x00555604 File Offset: 0x00553804
		public IImmediateStartConditionT AsIImmediateStartCondition()
		{
			return this.As<IImmediateStartConditionT>();
		}

		// Token: 0x06026BD2 RID: 158674 RVA: 0x0055560C File Offset: 0x0055380C
		public static ISpawnMonsterStartCondition_UnionUnion FromIImmediateStartCondition(IImmediateStartConditionT _iimmediatestartcondition)
		{
			return new ISpawnMonsterStartCondition_UnionUnion
			{
				Type = ISpawnMonsterStartCondition_Union.IImmediateStartCondition,
				Value = _iimmediatestartcondition
			};
		}

		// Token: 0x06026BD3 RID: 158675 RVA: 0x00555621 File Offset: 0x00553821
		public ITriggerRangeStartConditionT AsITriggerRangeStartCondition()
		{
			return this.As<ITriggerRangeStartConditionT>();
		}

		// Token: 0x06026BD4 RID: 158676 RVA: 0x00555629 File Offset: 0x00553829
		public static ISpawnMonsterStartCondition_UnionUnion FromITriggerRangeStartCondition(ITriggerRangeStartConditionT _itriggerrangestartcondition)
		{
			return new ISpawnMonsterStartCondition_UnionUnion
			{
				Type = ISpawnMonsterStartCondition_Union.ITriggerRangeStartCondition,
				Value = _itriggerrangestartcondition
			};
		}

		// Token: 0x06026BD5 RID: 158677 RVA: 0x00555640 File Offset: 0x00553840
		public static int Pack(FlatBufferBuilder builder, ISpawnMonsterStartCondition_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ISpawnMonsterStartCondition_Union.ISpawnMonsterStartCondition:
				return ISpawnMonsterStartCondition.Pack(builder, _o.AsISpawnMonsterStartCondition()).Value;
			case ISpawnMonsterStartCondition_Union.IImmediateStartCondition:
				return IImmediateStartCondition.Pack(builder, _o.AsIImmediateStartCondition()).Value;
			case ISpawnMonsterStartCondition_Union.ITriggerRangeStartCondition:
				return ITriggerRangeStartCondition.Pack(builder, _o.AsITriggerRangeStartCondition()).Value;
			default:
				return 0;
			}
		}
	}
}
