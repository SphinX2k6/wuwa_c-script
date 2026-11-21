using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007679 RID: 30329
	public class IRogueSelectRoomType_UnionUnion
	{
		// Token: 0x1700DEA1 RID: 56993
		// (get) Token: 0x06035351 RID: 217937 RVA: 0x0072428D File Offset: 0x0072248D
		// (set) Token: 0x06035352 RID: 217938 RVA: 0x00724295 File Offset: 0x00722495
		public IRogueSelectRoomType_Union Type { get; set; }

		// Token: 0x1700DEA2 RID: 56994
		// (get) Token: 0x06035353 RID: 217939 RVA: 0x0072429E File Offset: 0x0072249E
		// (set) Token: 0x06035354 RID: 217940 RVA: 0x007242A6 File Offset: 0x007224A6
		public object Value { get; set; }

		// Token: 0x06035355 RID: 217941 RVA: 0x007242AF File Offset: 0x007224AF
		public IRogueSelectRoomType_UnionUnion()
		{
			this.Type = IRogueSelectRoomType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06035356 RID: 217942 RVA: 0x007242C5 File Offset: 0x007224C5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06035357 RID: 217943 RVA: 0x007242D7 File Offset: 0x007224D7
		public IRogueSelectRoomTypeT AsIRogueSelectRoomType()
		{
			return this.As<IRogueSelectRoomTypeT>();
		}

		// Token: 0x06035358 RID: 217944 RVA: 0x007242DF File Offset: 0x007224DF
		public static IRogueSelectRoomType_UnionUnion FromIRogueSelectRoomType(IRogueSelectRoomTypeT _irogueselectroomtype)
		{
			return new IRogueSelectRoomType_UnionUnion
			{
				Type = IRogueSelectRoomType_Union.IRogueSelectRoomType,
				Value = _irogueselectroomtype
			};
		}

		// Token: 0x06035359 RID: 217945 RVA: 0x007242F4 File Offset: 0x007224F4
		public IRogueRoleSelectRoomT AsIRogueRoleSelectRoom()
		{
			return this.As<IRogueRoleSelectRoomT>();
		}

		// Token: 0x0603535A RID: 217946 RVA: 0x007242FC File Offset: 0x007224FC
		public static IRogueSelectRoomType_UnionUnion FromIRogueRoleSelectRoom(IRogueRoleSelectRoomT _irogueroleselectroom)
		{
			return new IRogueSelectRoomType_UnionUnion
			{
				Type = IRogueSelectRoomType_Union.IRogueRoleSelectRoom,
				Value = _irogueroleselectroom
			};
		}

		// Token: 0x0603535B RID: 217947 RVA: 0x00724314 File Offset: 0x00722514
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
