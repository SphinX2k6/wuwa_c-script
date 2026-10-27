using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200497A RID: 18810
	public class IBattleCondition_UnionUnion
	{
		// Token: 0x170087D8 RID: 34776
		// (get) Token: 0x0601D514 RID: 120084 RVA: 0x00422829 File Offset: 0x00420A29
		// (set) Token: 0x0601D515 RID: 120085 RVA: 0x00422831 File Offset: 0x00420A31
		public IBattleCondition_Union Type { get; set; }

		// Token: 0x170087D9 RID: 34777
		// (get) Token: 0x0601D516 RID: 120086 RVA: 0x0042283A File Offset: 0x00420A3A
		// (set) Token: 0x0601D517 RID: 120087 RVA: 0x00422842 File Offset: 0x00420A42
		public object Value { get; set; }

		// Token: 0x0601D518 RID: 120088 RVA: 0x0042284B File Offset: 0x00420A4B
		public IBattleCondition_UnionUnion()
		{
			this.Type = IBattleCondition_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601D519 RID: 120089 RVA: 0x00422861 File Offset: 0x00420A61
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601D51A RID: 120090 RVA: 0x00422873 File Offset: 0x00420A73
		public IBattleConditionT AsIBattleCondition()
		{
			return this.As<IBattleConditionT>();
		}

		// Token: 0x0601D51B RID: 120091 RVA: 0x0042287B File Offset: 0x00420A7B
		public static IBattleCondition_UnionUnion FromIBattleCondition(IBattleConditionT _ibattlecondition)
		{
			return new IBattleCondition_UnionUnion
			{
				Type = IBattleCondition_Union.IBattleCondition,
				Value = _ibattlecondition
			};
		}

		// Token: 0x0601D51C RID: 120092 RVA: 0x00422890 File Offset: 0x00420A90
		public IBattleTagConditionT AsIBattleTagCondition()
		{
			return this.As<IBattleTagConditionT>();
		}

		// Token: 0x0601D51D RID: 120093 RVA: 0x00422898 File Offset: 0x00420A98
		public static IBattleCondition_UnionUnion FromIBattleTagCondition(IBattleTagConditionT _ibattletagcondition)
		{
			return new IBattleCondition_UnionUnion
			{
				Type = IBattleCondition_Union.IBattleTagCondition,
				Value = _ibattletagcondition
			};
		}

		// Token: 0x0601D51E RID: 120094 RVA: 0x004228AD File Offset: 0x00420AAD
		public IPerfectDodgeConditionT AsIPerfectDodgeCondition()
		{
			return this.As<IPerfectDodgeConditionT>();
		}

		// Token: 0x0601D51F RID: 120095 RVA: 0x004228B5 File Offset: 0x00420AB5
		public static IBattleCondition_UnionUnion FromIPerfectDodgeCondition(IPerfectDodgeConditionT _iperfectdodgecondition)
		{
			return new IBattleCondition_UnionUnion
			{
				Type = IBattleCondition_Union.IPerfectDodgeCondition,
				Value = _iperfectdodgecondition
			};
		}

		// Token: 0x0601D520 RID: 120096 RVA: 0x004228CA File Offset: 0x00420ACA
		public ICounterAttackConditionT AsICounterAttackCondition()
		{
			return this.As<ICounterAttackConditionT>();
		}

		// Token: 0x0601D521 RID: 120097 RVA: 0x004228D2 File Offset: 0x00420AD2
		public static IBattleCondition_UnionUnion FromICounterAttackCondition(ICounterAttackConditionT _icounterattackcondition)
		{
			return new IBattleCondition_UnionUnion
			{
				Type = IBattleCondition_Union.ICounterAttackCondition,
				Value = _icounterattackcondition
			};
		}

		// Token: 0x0601D522 RID: 120098 RVA: 0x004228E8 File Offset: 0x00420AE8
		public static int Pack(FlatBufferBuilder builder, IBattleCondition_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IBattleCondition_Union.IBattleCondition:
				return IBattleCondition.Pack(builder, _o.AsIBattleCondition()).Value;
			case IBattleCondition_Union.IBattleTagCondition:
				return IBattleTagCondition.Pack(builder, _o.AsIBattleTagCondition()).Value;
			case IBattleCondition_Union.IPerfectDodgeCondition:
				return IPerfectDodgeCondition.Pack(builder, _o.AsIPerfectDodgeCondition()).Value;
			case IBattleCondition_Union.ICounterAttackCondition:
				return ICounterAttackCondition.Pack(builder, _o.AsICounterAttackCondition()).Value;
			default:
				return 0;
			}
		}
	}
}
