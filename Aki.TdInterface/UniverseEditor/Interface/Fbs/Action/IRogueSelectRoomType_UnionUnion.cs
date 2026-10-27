using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EF5 RID: 28405
	public class IRogueSelectRoomType_UnionUnion
	{
		// Token: 0x1700D34A RID: 54090
		// (get) Token: 0x06032311 RID: 205585 RVA: 0x006C8559 File Offset: 0x006C6759
		// (set) Token: 0x06032312 RID: 205586 RVA: 0x006C8561 File Offset: 0x006C6761
		public IRogueSelectRoomType_Union Type { get; set; }

		// Token: 0x1700D34B RID: 54091
		// (get) Token: 0x06032313 RID: 205587 RVA: 0x006C856A File Offset: 0x006C676A
		// (set) Token: 0x06032314 RID: 205588 RVA: 0x006C8572 File Offset: 0x006C6772
		public object Value { get; set; }

		// Token: 0x06032315 RID: 205589 RVA: 0x006C857B File Offset: 0x006C677B
		public IRogueSelectRoomType_UnionUnion()
		{
			this.Type = IRogueSelectRoomType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06032316 RID: 205590 RVA: 0x006C8591 File Offset: 0x006C6791
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06032317 RID: 205591 RVA: 0x006C85A3 File Offset: 0x006C67A3
		public IRogueSelectRoomTypeT AsIRogueSelectRoomType()
		{
			return this.As<IRogueSelectRoomTypeT>();
		}

		// Token: 0x06032318 RID: 205592 RVA: 0x006C85AB File Offset: 0x006C67AB
		public static IRogueSelectRoomType_UnionUnion FromIRogueSelectRoomType(IRogueSelectRoomTypeT _irogueselectroomtype)
		{
			return new IRogueSelectRoomType_UnionUnion
			{
				Type = IRogueSelectRoomType_Union.IRogueSelectRoomType,
				Value = _irogueselectroomtype
			};
		}

		// Token: 0x06032319 RID: 205593 RVA: 0x006C85C0 File Offset: 0x006C67C0
		public IRogueRoleSelectRoomT AsIRogueRoleSelectRoom()
		{
			return this.As<IRogueRoleSelectRoomT>();
		}

		// Token: 0x0603231A RID: 205594 RVA: 0x006C85C8 File Offset: 0x006C67C8
		public static IRogueSelectRoomType_UnionUnion FromIRogueRoleSelectRoom(IRogueRoleSelectRoomT _irogueroleselectroom)
		{
			return new IRogueSelectRoomType_UnionUnion
			{
				Type = IRogueSelectRoomType_Union.IRogueRoleSelectRoom,
				Value = _irogueroleselectroom
			};
		}

		// Token: 0x0603231B RID: 205595 RVA: 0x006C85E0 File Offset: 0x006C67E0
		public static int Pack(FlatBufferBuilder builder, IRogueSelectRoomType_UnionUnion _o)
		{
			IRogueSelectRoomType_Union type = _o.Type;
			if (type == IRogueSelectRoomType_Union.IRogueSelectRoomType)
			{
				return IRogueSelectRoomType.Pack(builder, _o.AsIRogueSelectRoomType()).Value;
			}
			if (type != IRogueSelectRoomType_Union.IRogueRoleSelectRoom)
			{
				return 0;
			}
			return IRogueRoleSelectRoom.Pack(builder, _o.AsIRogueRoleSelectRoom()).Value;
		}
	}
}
