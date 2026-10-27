using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077ED RID: 30701
	public class TTrapDefensePlayerOperationTypeUnion
	{
		// Token: 0x1700E6E1 RID: 59105
		// (get) Token: 0x06037ACE RID: 228046 RVA: 0x0078737C File Offset: 0x0078557C
		// (set) Token: 0x06037ACF RID: 228047 RVA: 0x00787384 File Offset: 0x00785584
		public TTrapDefensePlayerOperationType Type { get; set; }

		// Token: 0x1700E6E2 RID: 59106
		// (get) Token: 0x06037AD0 RID: 228048 RVA: 0x0078738D File Offset: 0x0078558D
		// (set) Token: 0x06037AD1 RID: 228049 RVA: 0x00787395 File Offset: 0x00785595
		public object Value { get; set; }

		// Token: 0x06037AD2 RID: 228050 RVA: 0x0078739E File Offset: 0x0078559E
		public TTrapDefensePlayerOperationTypeUnion()
		{
			this.Type = TTrapDefensePlayerOperationType.NONE;
			this.Value = null;
		}

		// Token: 0x06037AD3 RID: 228051 RVA: 0x007873B4 File Offset: 0x007855B4
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037AD4 RID: 228052 RVA: 0x007873C6 File Offset: 0x007855C6
		public ITrapDefensePlayerOperationConstructTrapT AsITrapDefensePlayerOperationConstructTrap()
		{
			return this.As<ITrapDefensePlayerOperationConstructTrapT>();
		}

		// Token: 0x06037AD5 RID: 228053 RVA: 0x007873CE File Offset: 0x007855CE
		public static TTrapDefensePlayerOperationTypeUnion FromITrapDefensePlayerOperationConstructTrap(ITrapDefensePlayerOperationConstructTrapT _itrapdefenseplayeroperationconstructtrap)
		{
			return new TTrapDefensePlayerOperationTypeUnion
			{
				Type = TTrapDefensePlayerOperationType.ITrapDefensePlayerOperationConstructTrap,
				Value = _itrapdefenseplayeroperationconstructtrap
			};
		}

		// Token: 0x06037AD6 RID: 228054 RVA: 0x007873E3 File Offset: 0x007855E3
		public ITrapDefensePlayerOperationRecycleTrapT AsITrapDefensePlayerOperationRecycleTrap()
		{
			return this.As<ITrapDefensePlayerOperationRecycleTrapT>();
		}

		// Token: 0x06037AD7 RID: 228055 RVA: 0x007873EB File Offset: 0x007855EB
		public static TTrapDefensePlayerOperationTypeUnion FromITrapDefensePlayerOperationRecycleTrap(ITrapDefensePlayerOperationRecycleTrapT _itrapdefenseplayeroperationrecycletrap)
		{
			return new TTrapDefensePlayerOperationTypeUnion
			{
				Type = TTrapDefensePlayerOperationType.ITrapDefensePlayerOperationRecycleTrap,
				Value = _itrapdefenseplayeroperationrecycletrap
			};
		}

		// Token: 0x06037AD8 RID: 228056 RVA: 0x00787400 File Offset: 0x00785600
		public ITrapDefensePlayerOperationSpawnMonsterT AsITrapDefensePlayerOperationSpawnMonster()
		{
			return this.As<ITrapDefensePlayerOperationSpawnMonsterT>();
		}

		// Token: 0x06037AD9 RID: 228057 RVA: 0x00787408 File Offset: 0x00785608
		public static TTrapDefensePlayerOperationTypeUnion FromITrapDefensePlayerOperationSpawnMonster(ITrapDefensePlayerOperationSpawnMonsterT _itrapdefenseplayeroperationspawnmonster)
		{
			return new TTrapDefensePlayerOperationTypeUnion
			{
				Type = TTrapDefensePlayerOperationType.ITrapDefensePlayerOperationSpawnMonster,
				Value = _itrapdefenseplayeroperationspawnmonster
			};
		}

		// Token: 0x06037ADA RID: 228058 RVA: 0x00787420 File Offset: 0x00785620
		public static int Pack(FlatBufferBuilder builder, TTrapDefensePlayerOperationTypeUnion _o)
		{
			switch (_o.Type)
			{
			case TTrapDefensePlayerOperationType.ITrapDefensePlayerOperationConstructTrap:
				return ITrapDefensePlayerOperationConstructTrap.Pack(builder, _o.AsITrapDefensePlayerOperationConstructTrap()).Value;
			case TTrapDefensePlayerOperationType.ITrapDefensePlayerOperationRecycleTrap:
				return ITrapDefensePlayerOperationRecycleTrap.Pack(builder, _o.AsITrapDefensePlayerOperationRecycleTrap()).Value;
			case TTrapDefensePlayerOperationType.ITrapDefensePlayerOperationSpawnMonster:
				return ITrapDefensePlayerOperationSpawnMonster.Pack(builder, _o.AsITrapDefensePlayerOperationSpawnMonster()).Value;
			default:
				return 0;
			}
		}
	}
}
