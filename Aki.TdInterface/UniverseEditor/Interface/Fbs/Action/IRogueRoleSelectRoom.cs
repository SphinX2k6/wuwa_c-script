using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EEB RID: 28395
	public struct IRogueRoleSelectRoom : IFlatbufferObject
	{
		// Token: 0x1700D341 RID: 54081
		// (get) Token: 0x060322DB RID: 205531 RVA: 0x006C806E File Offset: 0x006C626E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060322DC RID: 205532 RVA: 0x006C807B File Offset: 0x006C627B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060322DD RID: 205533 RVA: 0x006C8084 File Offset: 0x006C6284
		public static IRogueRoleSelectRoom GetRootAsIRogueRoleSelectRoom(ByteBuffer _bb)
		{
			return IRogueRoleSelectRoom.GetRootAsIRogueRoleSelectRoom(_bb, default(IRogueRoleSelectRoom));
		}

		// Token: 0x060322DE RID: 205534 RVA: 0x006C80A0 File Offset: 0x006C62A0
		public static IRogueRoleSelectRoom GetRootAsIRogueRoleSelectRoom(ByteBuffer _bb, IRogueRoleSelectRoom obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060322DF RID: 205535 RVA: 0x006C80BD File Offset: 0x006C62BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060322E0 RID: 205536 RVA: 0x006C80CC File Offset: 0x006C62CC
		public IRogueRoleSelectRoom __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D342 RID: 54082
		// (get) Token: 0x060322E1 RID: 205537 RVA: 0x006C80DC File Offset: 0x006C62DC
		public ERogueSelectRoomType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERogueSelectRoomType.Role;
				}
				return (ERogueSelectRoomType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060322E2 RID: 205538 RVA: 0x006C8118 File Offset: 0x006C6318
		public static Offset<IRogueRoleSelectRoom> CreateIRogueRoleSelectRoom(FlatBufferBuilder builder, ERogueSelectRoomType Type = ERogueSelectRoomType.Role)
		{
			builder.StartTable(1);
			IRogueRoleSelectRoom.AddType(builder, Type);
			return IRogueRoleSelectRoom.EndIRogueRoleSelectRoom(builder);
		}

		// Token: 0x060322E3 RID: 205539 RVA: 0x006C812E File Offset: 0x006C632E
		public static void StartIRogueRoleSelectRoom(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060322E4 RID: 205540 RVA: 0x006C8137 File Offset: 0x006C6337
		public static void AddType(FlatBufferBuilder builder, ERogueSelectRoomType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060322E5 RID: 205541 RVA: 0x006C8142 File Offset: 0x006C6342
		public static Offset<IRogueRoleSelectRoom> EndIRogueRoleSelectRoom(FlatBufferBuilder builder)
		{
			return new Offset<IRogueRoleSelectRoom>(builder.EndTable());
		}

		// Token: 0x060322E6 RID: 205542 RVA: 0x006C8150 File Offset: 0x006C6350
		public IRogueRoleSelectRoomT UnPack()
		{
			IRogueRoleSelectRoomT rogueRoleSelectRoomT = new IRogueRoleSelectRoomT();
			this.UnPackTo(rogueRoleSelectRoomT);
			return rogueRoleSelectRoomT;
		}

		// Token: 0x060322E7 RID: 205543 RVA: 0x006C816B File Offset: 0x006C636B
		public void UnPackTo(IRogueRoleSelectRoomT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060322E8 RID: 205544 RVA: 0x006C817C File Offset: 0x006C637C
		public static Offset<IRogueRoleSelectRoom> Pack(FlatBufferBuilder builder, IRogueRoleSelectRoomT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRogueRoleSelectRoom>);
			}
			return IRogueRoleSelectRoom.CreateIRogueRoleSelectRoom(builder, _o.Type);
		}

		// Token: 0x040118E0 RID: 71904
		private Table __p;
	}
}
