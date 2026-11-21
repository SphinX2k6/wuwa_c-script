using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007672 RID: 30322
	public struct IRogueSelectRoom : IFlatbufferObject
	{
		// Token: 0x1700DE9B RID: 56987
		// (get) Token: 0x0603532D RID: 217901 RVA: 0x00723F19 File Offset: 0x00722119
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603532E RID: 217902 RVA: 0x00723F26 File Offset: 0x00722126
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603532F RID: 217903 RVA: 0x00723F30 File Offset: 0x00722130
		public static IRogueSelectRoom GetRootAsIRogueSelectRoom(ByteBuffer _bb)
		{
			return IRogueSelectRoom.GetRootAsIRogueSelectRoom(_bb, default(IRogueSelectRoom));
		}

		// Token: 0x06035330 RID: 217904 RVA: 0x00723F4C File Offset: 0x0072214C
		public static IRogueSelectRoom GetRootAsIRogueSelectRoom(ByteBuffer _bb, IRogueSelectRoom obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035331 RID: 217905 RVA: 0x00723F69 File Offset: 0x00722169
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035332 RID: 217906 RVA: 0x00723F78 File Offset: 0x00722178
		public IRogueSelectRoom __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DE9C RID: 56988
		// (get) Token: 0x06035333 RID: 217907 RVA: 0x00723F88 File Offset: 0x00722188
		public IRogueRoleSelectRoom? Config
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IRogueRoleSelectRoom?(default(IRogueRoleSelectRoom).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06035334 RID: 217908 RVA: 0x00723FE5 File Offset: 0x007221E5
		public static Offset<IRogueSelectRoom> CreateIRogueSelectRoom(FlatBufferBuilder builder, Offset<IRogueRoleSelectRoom> ConfigOffset = default(Offset<IRogueRoleSelectRoom>))
		{
			builder.StartTable(1);
			IRogueSelectRoom.AddConfig(builder, ConfigOffset);
			return IRogueSelectRoom.EndIRogueSelectRoom(builder);
		}

		// Token: 0x06035335 RID: 217909 RVA: 0x00723FFB File Offset: 0x007221FB
		public static void StartIRogueSelectRoom(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06035336 RID: 217910 RVA: 0x00724004 File Offset: 0x00722204
		public static void AddConfig(FlatBufferBuilder builder, Offset<IRogueRoleSelectRoom> configOffset)
		{
			builder.AddOffset(0, configOffset.Value, 0);
		}

		// Token: 0x06035337 RID: 217911 RVA: 0x00724014 File Offset: 0x00722214
		public static Offset<IRogueSelectRoom> EndIRogueSelectRoom(FlatBufferBuilder builder)
		{
			return new Offset<IRogueSelectRoom>(builder.EndTable());
		}

		// Token: 0x06035338 RID: 217912 RVA: 0x00724024 File Offset: 0x00722224
		public IRogueSelectRoomT UnPack()
		{
			IRogueSelectRoomT rogueSelectRoomT = new IRogueSelectRoomT();
			this.UnPackTo(rogueSelectRoomT);
			return rogueSelectRoomT;
		}

		// Token: 0x06035339 RID: 217913 RVA: 0x00724040 File Offset: 0x00722240
		public void UnPackTo(IRogueSelectRoomT _o)
		{
			_o.Config = ((this.Config != null) ? this.Config.Value.UnPack() : null);
		}

		// Token: 0x0603533A RID: 217914 RVA: 0x0072407C File Offset: 0x0072227C
		public static Offset<IRogueSelectRoom> Pack(FlatBufferBuilder builder, IRogueSelectRoomT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRogueSelectRoom>);
			}
			Offset<IRogueRoleSelectRoom> configOffset = (_o.Config == null) ? default(Offset<IRogueRoleSelectRoom>) : IRogueRoleSelectRoom.Pack(builder, _o.Config);
			return IRogueSelectRoom.CreateIRogueSelectRoom(builder, configOffset);
		}

		// Token: 0x04012867 RID: 75879
		private Table __p;
	}
}
