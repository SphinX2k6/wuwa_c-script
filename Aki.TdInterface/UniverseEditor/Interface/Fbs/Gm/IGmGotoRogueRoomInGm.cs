using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004ACB RID: 19147
	public struct IGmGotoRogueRoomInGm : IFlatbufferObject
	{
		// Token: 0x17008627 RID: 34343
		// (get) Token: 0x0601CD3E RID: 118078 RVA: 0x0040F6D4 File Offset: 0x0040D8D4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601CD3F RID: 118079 RVA: 0x0040F6E1 File Offset: 0x0040D8E1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601CD40 RID: 118080 RVA: 0x0040F6E8 File Offset: 0x0040D8E8
		public static IGmGotoRogueRoomInGm GetRootAsIGmGotoRogueRoomInGm(ByteBuffer _bb)
		{
			return IGmGotoRogueRoomInGm.GetRootAsIGmGotoRogueRoomInGm(_bb, default(IGmGotoRogueRoomInGm));
		}

		// Token: 0x0601CD41 RID: 118081 RVA: 0x0040F704 File Offset: 0x0040D904
		public static IGmGotoRogueRoomInGm GetRootAsIGmGotoRogueRoomInGm(ByteBuffer _bb, IGmGotoRogueRoomInGm obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601CD42 RID: 118082 RVA: 0x0040F721 File Offset: 0x0040D921
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601CD43 RID: 118083 RVA: 0x0040F730 File Offset: 0x0040D930
		public IGmGotoRogueRoomInGm __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008628 RID: 34344
		// (get) Token: 0x0601CD44 RID: 118084 RVA: 0x0040F740 File Offset: 0x0040D940
		public EGmCommand Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGmCommand.SkipToLevelPlayNode;
				}
				return (EGmCommand)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008629 RID: 34345
		// (get) Token: 0x0601CD45 RID: 118085 RVA: 0x0040F77C File Offset: 0x0040D97C
		public int RoomId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700862A RID: 34346
		// (get) Token: 0x0601CD46 RID: 118086 RVA: 0x0040F7B8 File Offset: 0x0040D9B8
		public string RoomType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601CD47 RID: 118087 RVA: 0x0040F7EF File Offset: 0x0040D9EF
		public Span<byte> GetRoomTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0601CD48 RID: 118088 RVA: 0x0040F7FE File Offset: 0x0040D9FE
		public byte[] GetRoomTypeArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x0601CD49 RID: 118089 RVA: 0x0040F80C File Offset: 0x0040DA0C
		public static Offset<IGmGotoRogueRoomInGm> CreateIGmGotoRogueRoomInGm(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode, int RoomId = 0, StringOffset RoomTypeOffset = default(StringOffset))
		{
			builder.StartTable(3);
			IGmGotoRogueRoomInGm.AddRoomType(builder, RoomTypeOffset);
			IGmGotoRogueRoomInGm.AddRoomId(builder, RoomId);
			IGmGotoRogueRoomInGm.AddType(builder, Type);
			return IGmGotoRogueRoomInGm.EndIGmGotoRogueRoomInGm(builder);
		}

		// Token: 0x0601CD4A RID: 118090 RVA: 0x0040F830 File Offset: 0x0040DA30
		public static void StartIGmGotoRogueRoomInGm(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601CD4B RID: 118091 RVA: 0x0040F839 File Offset: 0x0040DA39
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601CD4C RID: 118092 RVA: 0x0040F844 File Offset: 0x0040DA44
		public static void AddRoomId(FlatBufferBuilder builder, int roomId)
		{
			builder.AddInt(1, roomId, 0);
		}

		// Token: 0x0601CD4D RID: 118093 RVA: 0x0040F84F File Offset: 0x0040DA4F
		public static void AddRoomType(FlatBufferBuilder builder, StringOffset roomTypeOffset)
		{
			builder.AddOffset(2, roomTypeOffset.Value, 0);
		}

		// Token: 0x0601CD4E RID: 118094 RVA: 0x0040F85F File Offset: 0x0040DA5F
		public static Offset<IGmGotoRogueRoomInGm> EndIGmGotoRogueRoomInGm(FlatBufferBuilder builder)
		{
			return new Offset<IGmGotoRogueRoomInGm>(builder.EndTable());
		}

		// Token: 0x0601CD4F RID: 118095 RVA: 0x0040F86C File Offset: 0x0040DA6C
		public IGmGotoRogueRoomInGmT UnPack()
		{
			IGmGotoRogueRoomInGmT gmGotoRogueRoomInGmT = new IGmGotoRogueRoomInGmT();
			this.UnPackTo(gmGotoRogueRoomInGmT);
			return gmGotoRogueRoomInGmT;
		}

		// Token: 0x0601CD50 RID: 118096 RVA: 0x0040F887 File Offset: 0x0040DA87
		public void UnPackTo(IGmGotoRogueRoomInGmT _o)
		{
			_o.Type = this.Type;
			_o.RoomId = this.RoomId;
			_o.RoomType = this.RoomType;
		}

		// Token: 0x0601CD51 RID: 118097 RVA: 0x0040F8B0 File Offset: 0x0040DAB0
		public static Offset<IGmGotoRogueRoomInGm> Pack(FlatBufferBuilder builder, IGmGotoRogueRoomInGmT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGmGotoRogueRoomInGm>);
			}
			StringOffset roomTypeOffset = (_o.RoomType == null) ? default(StringOffset) : builder.CreateString(_o.RoomType);
			return IGmGotoRogueRoomInGm.CreateIGmGotoRogueRoomInGm(builder, _o.Type, _o.RoomId, roomTypeOffset);
		}

		// Token: 0x0400D24C RID: 53836
		private Table __p;
	}
}
