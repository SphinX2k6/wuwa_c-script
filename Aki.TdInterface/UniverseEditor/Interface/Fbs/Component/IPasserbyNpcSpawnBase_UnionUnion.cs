using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056D8 RID: 22232
	public class IPasserbyNpcSpawnBase_UnionUnion
	{
		// Token: 0x1700A570 RID: 42352
		// (get) Token: 0x0602522E RID: 152110 RVA: 0x0052047C File Offset: 0x0051E67C
		// (set) Token: 0x0602522F RID: 152111 RVA: 0x00520484 File Offset: 0x0051E684
		public IPasserbyNpcSpawnBase_Union Type { get; set; }

		// Token: 0x1700A571 RID: 42353
		// (get) Token: 0x06025230 RID: 152112 RVA: 0x0052048D File Offset: 0x0051E68D
		// (set) Token: 0x06025231 RID: 152113 RVA: 0x00520495 File Offset: 0x0051E695
		public object Value { get; set; }

		// Token: 0x06025232 RID: 152114 RVA: 0x0052049E File Offset: 0x0051E69E
		public IPasserbyNpcSpawnBase_UnionUnion()
		{
			this.Type = IPasserbyNpcSpawnBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06025233 RID: 152115 RVA: 0x005204B4 File Offset: 0x0051E6B4
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06025234 RID: 152116 RVA: 0x005204C6 File Offset: 0x0051E6C6
		public IPasserbyNpcSpawnBaseT AsIPasserbyNpcSpawnBase()
		{
			return this.As<IPasserbyNpcSpawnBaseT>();
		}

		// Token: 0x06025235 RID: 152117 RVA: 0x005204CE File Offset: 0x0051E6CE
		public static IPasserbyNpcSpawnBase_UnionUnion FromIPasserbyNpcSpawnBase(IPasserbyNpcSpawnBaseT _ipasserbynpcspawnbase)
		{
			return new IPasserbyNpcSpawnBase_UnionUnion
			{
				Type = IPasserbyNpcSpawnBase_Union.IPasserbyNpcSpawnBase,
				Value = _ipasserbynpcspawnbase
			};
		}

		// Token: 0x06025236 RID: 152118 RVA: 0x005204E3 File Offset: 0x0051E6E3
		public IPasserbyNpcFixIntervalSpawnT AsIPasserbyNpcFixIntervalSpawn()
		{
			return this.As<IPasserbyNpcFixIntervalSpawnT>();
		}

		// Token: 0x06025237 RID: 152119 RVA: 0x005204EB File Offset: 0x0051E6EB
		public static IPasserbyNpcSpawnBase_UnionUnion FromIPasserbyNpcFixIntervalSpawn(IPasserbyNpcFixIntervalSpawnT _ipasserbynpcfixintervalspawn)
		{
			return new IPasserbyNpcSpawnBase_UnionUnion
			{
				Type = IPasserbyNpcSpawnBase_Union.IPasserbyNpcFixIntervalSpawn,
				Value = _ipasserbynpcfixintervalspawn
			};
		}

		// Token: 0x06025238 RID: 152120 RVA: 0x00520500 File Offset: 0x0051E700
		public static int Pack(FlatBufferBuilder builder, IPasserbyNpcSpawnBase_UnionUnion _o)
		{
			IPasserbyNpcSpawnBase_Union type = _o.Type;
			if (type == IPasserbyNpcSpawnBase_Union.IPasserbyNpcSpawnBase)
			{
				return IPasserbyNpcSpawnBase.Pack(builder, _o.AsIPasserbyNpcSpawnBase()).Value;
			}
			if (type != IPasserbyNpcSpawnBase_Union.IPasserbyNpcFixIntervalSpawn)
			{
				return 0;
			}
			return IPasserbyNpcFixIntervalSpawn.Pack(builder, _o.AsIPasserbyNpcFixIntervalSpawn()).Value;
		}
	}
}
