using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200766F RID: 30319
	public struct IRogueRoleSelectRoom : IFlatbufferObject
	{
		// Token: 0x1700DE98 RID: 56984
		// (get) Token: 0x0603531B RID: 217883 RVA: 0x00723DA2 File Offset: 0x00721FA2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603531C RID: 217884 RVA: 0x00723DAF File Offset: 0x00721FAF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603531D RID: 217885 RVA: 0x00723DB8 File Offset: 0x00721FB8
		public static IRogueRoleSelectRoom GetRootAsIRogueRoleSelectRoom(ByteBuffer _bb)
		{
			return IRogueRoleSelectRoom.GetRootAsIRogueRoleSelectRoom(_bb, default(IRogueRoleSelectRoom));
		}

		// Token: 0x0603531E RID: 217886 RVA: 0x00723DD4 File Offset: 0x00721FD4
		public static IRogueRoleSelectRoom GetRootAsIRogueRoleSelectRoom(ByteBuffer _bb, IRogueRoleSelectRoom obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603531F RID: 217887 RVA: 0x00723DF1 File Offset: 0x00721FF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035320 RID: 217888 RVA: 0x00723E00 File Offset: 0x00722000
		public IRogueRoleSelectRoom __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DE99 RID: 56985
		// (get) Token: 0x06035321 RID: 217889 RVA: 0x00723E10 File Offset: 0x00722010
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

		// Token: 0x06035322 RID: 217890 RVA: 0x00723E4C File Offset: 0x0072204C
		public static Offset<IRogueRoleSelectRoom> CreateIRogueRoleSelectRoom(FlatBufferBuilder builder, ERogueSelectRoomType Type = ERogueSelectRoomType.Role)
		{
			builder.StartTable(1);
			IRogueRoleSelectRoom.AddType(builder, Type);
			return IRogueRoleSelectRoom.EndIRogueRoleSelectRoom(builder);
		}

		// Token: 0x06035323 RID: 217891 RVA: 0x00723E62 File Offset: 0x00722062
		public static void StartIRogueRoleSelectRoom(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06035324 RID: 217892 RVA: 0x00723E6B File Offset: 0x0072206B
		public static void AddType(FlatBufferBuilder builder, ERogueSelectRoomType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035325 RID: 217893 RVA: 0x00723E76 File Offset: 0x00722076
		public static Offset<IRogueRoleSelectRoom> EndIRogueRoleSelectRoom(FlatBufferBuilder builder)
		{
			return new Offset<IRogueRoleSelectRoom>(builder.EndTable());
		}

		// Token: 0x06035326 RID: 217894 RVA: 0x00723E84 File Offset: 0x00722084
		public IRogueRoleSelectRoomT UnPack()
		{
			IRogueRoleSelectRoomT rogueRoleSelectRoomT = new IRogueRoleSelectRoomT();
			this.UnPackTo(rogueRoleSelectRoomT);
			return rogueRoleSelectRoomT;
		}

		// Token: 0x06035327 RID: 217895 RVA: 0x00723E9F File Offset: 0x0072209F
		public void UnPackTo(IRogueRoleSelectRoomT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06035328 RID: 217896 RVA: 0x00723EB0 File Offset: 0x007220B0
		public static Offset<IRogueRoleSelectRoom> Pack(FlatBufferBuilder builder, IRogueRoleSelectRoomT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRogueRoleSelectRoom>);
			}
			return IRogueRoleSelectRoom.CreateIRogueRoleSelectRoom(builder, _o.Type);
		}

		// Token: 0x04012865 RID: 75877
		private Table __p;
	}
}
