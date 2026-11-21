using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CBE RID: 23742
	public class IPasserbyNpcSpawnBase_UnionUnion
	{
		// Token: 0x1700AE65 RID: 44645
		// (get) Token: 0x0602764F RID: 161359 RVA: 0x00564548 File Offset: 0x00562748
		// (set) Token: 0x06027650 RID: 161360 RVA: 0x00564550 File Offset: 0x00562750
		public IPasserbyNpcSpawnBase_Union Type { get; set; }

		// Token: 0x1700AE66 RID: 44646
		// (get) Token: 0x06027651 RID: 161361 RVA: 0x00564559 File Offset: 0x00562759
		// (set) Token: 0x06027652 RID: 161362 RVA: 0x00564561 File Offset: 0x00562761
		public object Value { get; set; }

		// Token: 0x06027653 RID: 161363 RVA: 0x0056456A File Offset: 0x0056276A
		public IPasserbyNpcSpawnBase_UnionUnion()
		{
			this.Type = IPasserbyNpcSpawnBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06027654 RID: 161364 RVA: 0x00564580 File Offset: 0x00562780
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06027655 RID: 161365 RVA: 0x00564592 File Offset: 0x00562792
		public IPasserbyNpcSpawnBaseT AsIPasserbyNpcSpawnBase()
		{
			return this.As<IPasserbyNpcSpawnBaseT>();
		}

		// Token: 0x06027656 RID: 161366 RVA: 0x0056459A File Offset: 0x0056279A
		public static IPasserbyNpcSpawnBase_UnionUnion FromIPasserbyNpcSpawnBase(IPasserbyNpcSpawnBaseT _ipasserbynpcspawnbase)
		{
			return new IPasserbyNpcSpawnBase_UnionUnion
			{
				Type = IPasserbyNpcSpawnBase_Union.IPasserbyNpcSpawnBase,
				Value = _ipasserbynpcspawnbase
			};
		}

		// Token: 0x06027657 RID: 161367 RVA: 0x005645AF File Offset: 0x005627AF
		public IPasserbyNpcFixIntervalSpawnT AsIPasserbyNpcFixIntervalSpawn()
		{
			return this.As<IPasserbyNpcFixIntervalSpawnT>();
		}

		// Token: 0x06027658 RID: 161368 RVA: 0x005645B7 File Offset: 0x005627B7
		public static IPasserbyNpcSpawnBase_UnionUnion FromIPasserbyNpcFixIntervalSpawn(IPasserbyNpcFixIntervalSpawnT _ipasserbynpcfixintervalspawn)
		{
			return new IPasserbyNpcSpawnBase_UnionUnion
			{
				Type = IPasserbyNpcSpawnBase_Union.IPasserbyNpcFixIntervalSpawn,
				Value = _ipasserbynpcfixintervalspawn
			};
		}

		// Token: 0x06027659 RID: 161369 RVA: 0x005645CC File Offset: 0x005627CC
		public IPasserbyNpcOnceOnConditionMetSpawnT AsIPasserbyNpcOnceOnConditionMetSpawn()
		{
			return this.As<IPasserbyNpcOnceOnConditionMetSpawnT>();
		}

		// Token: 0x0602765A RID: 161370 RVA: 0x005645D4 File Offset: 0x005627D4
		public static IPasserbyNpcSpawnBase_UnionUnion FromIPasserbyNpcOnceOnConditionMetSpawn(IPasserbyNpcOnceOnConditionMetSpawnT _ipasserbynpconceonconditionmetspawn)
		{
			return new IPasserbyNpcSpawnBase_UnionUnion
			{
				Type = IPasserbyNpcSpawnBase_Union.IPasserbyNpcOnceOnConditionMetSpawn,
				Value = _ipasserbynpconceonconditionmetspawn
			};
		}

		// Token: 0x0602765B RID: 161371 RVA: 0x005645EC File Offset: 0x005627EC
		public static int Pack(FlatBufferBuilder builder, IPasserbyNpcSpawnBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IPasserbyNpcSpawnBase_Union.IPasserbyNpcSpawnBase:
				return IPasserbyNpcSpawnBase.Pack(builder, _o.AsIPasserbyNpcSpawnBase()).Value;
			case IPasserbyNpcSpawnBase_Union.IPasserbyNpcFixIntervalSpawn:
				return IPasserbyNpcFixIntervalSpawn.Pack(builder, _o.AsIPasserbyNpcFixIntervalSpawn()).Value;
			case IPasserbyNpcSpawnBase_Union.IPasserbyNpcOnceOnConditionMetSpawn:
				return IPasserbyNpcOnceOnConditionMetSpawn.Pack(builder, _o.AsIPasserbyNpcOnceOnConditionMetSpawn()).Value;
			default:
				return 0;
			}
		}
	}
}
