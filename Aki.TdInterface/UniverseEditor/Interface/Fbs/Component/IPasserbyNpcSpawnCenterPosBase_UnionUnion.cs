using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CC4 RID: 23748
	public class IPasserbyNpcSpawnCenterPosBase_UnionUnion
	{
		// Token: 0x1700AE6A RID: 44650
		// (get) Token: 0x0602766F RID: 161391 RVA: 0x00564809 File Offset: 0x00562A09
		// (set) Token: 0x06027670 RID: 161392 RVA: 0x00564811 File Offset: 0x00562A11
		public IPasserbyNpcSpawnCenterPosBase_Union Type { get; set; }

		// Token: 0x1700AE6B RID: 44651
		// (get) Token: 0x06027671 RID: 161393 RVA: 0x0056481A File Offset: 0x00562A1A
		// (set) Token: 0x06027672 RID: 161394 RVA: 0x00564822 File Offset: 0x00562A22
		public object Value { get; set; }

		// Token: 0x06027673 RID: 161395 RVA: 0x0056482B File Offset: 0x00562A2B
		public IPasserbyNpcSpawnCenterPosBase_UnionUnion()
		{
			this.Type = IPasserbyNpcSpawnCenterPosBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06027674 RID: 161396 RVA: 0x00564841 File Offset: 0x00562A41
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06027675 RID: 161397 RVA: 0x00564853 File Offset: 0x00562A53
		public IPasserbyNpcSpawnCenterPosBaseT AsIPasserbyNpcSpawnCenterPosBase()
		{
			return this.As<IPasserbyNpcSpawnCenterPosBaseT>();
		}

		// Token: 0x06027676 RID: 161398 RVA: 0x0056485B File Offset: 0x00562A5B
		public static IPasserbyNpcSpawnCenterPosBase_UnionUnion FromIPasserbyNpcSpawnCenterPosBase(IPasserbyNpcSpawnCenterPosBaseT _ipasserbynpcspawncenterposbase)
		{
			return new IPasserbyNpcSpawnCenterPosBase_UnionUnion
			{
				Type = IPasserbyNpcSpawnCenterPosBase_Union.IPasserbyNpcSpawnCenterPosBase,
				Value = _ipasserbynpcspawncenterposbase
			};
		}

		// Token: 0x06027677 RID: 161399 RVA: 0x00564870 File Offset: 0x00562A70
		public IPasserbyNpcSelfSpawnCenterPosT AsIPasserbyNpcSelfSpawnCenterPos()
		{
			return this.As<IPasserbyNpcSelfSpawnCenterPosT>();
		}

		// Token: 0x06027678 RID: 161400 RVA: 0x00564878 File Offset: 0x00562A78
		public static IPasserbyNpcSpawnCenterPosBase_UnionUnion FromIPasserbyNpcSelfSpawnCenterPos(IPasserbyNpcSelfSpawnCenterPosT _ipasserbynpcselfspawncenterpos)
		{
			return new IPasserbyNpcSpawnCenterPosBase_UnionUnion
			{
				Type = IPasserbyNpcSpawnCenterPosBase_Union.IPasserbyNpcSelfSpawnCenterPos,
				Value = _ipasserbynpcselfspawncenterpos
			};
		}

		// Token: 0x06027679 RID: 161401 RVA: 0x00564890 File Offset: 0x00562A90
		public static int Pack(FlatBufferBuilder builder, IPasserbyNpcSpawnCenterPosBase_UnionUnion _o)
		{
			IPasserbyNpcSpawnCenterPosBase_Union type = _o.Type;
			if (type == IPasserbyNpcSpawnCenterPosBase_Union.IPasserbyNpcSpawnCenterPosBase)
			{
				return IPasserbyNpcSpawnCenterPosBase.Pack(builder, _o.AsIPasserbyNpcSpawnCenterPosBase()).Value;
			}
			if (type != IPasserbyNpcSpawnCenterPosBase_Union.IPasserbyNpcSelfSpawnCenterPos)
			{
				return 0;
			}
			return IPasserbyNpcSelfSpawnCenterPos.Pack(builder, _o.AsIPasserbyNpcSelfSpawnCenterPos()).Value;
		}
	}
}
