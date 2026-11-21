using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003DED RID: 15853
	public struct IBlackBoardEntityPos : IFlatbufferObject
	{
		// Token: 0x17006B11 RID: 27409
		// (get) Token: 0x06015487 RID: 87175 RVA: 0x00313E32 File Offset: 0x00312032
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015488 RID: 87176 RVA: 0x00313E3F File Offset: 0x0031203F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015489 RID: 87177 RVA: 0x00313E48 File Offset: 0x00312048
		public static IBlackBoardEntityPos GetRootAsIBlackBoardEntityPos(ByteBuffer _bb)
		{
			return IBlackBoardEntityPos.GetRootAsIBlackBoardEntityPos(_bb, default(IBlackBoardEntityPos));
		}

		// Token: 0x0601548A RID: 87178 RVA: 0x00313E64 File Offset: 0x00312064
		public static IBlackBoardEntityPos GetRootAsIBlackBoardEntityPos(ByteBuffer _bb, IBlackBoardEntityPos obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601548B RID: 87179 RVA: 0x00313E81 File Offset: 0x00312081
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601548C RID: 87180 RVA: 0x00313E90 File Offset: 0x00312090
		public IBlackBoardEntityPos __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006B12 RID: 27410
		// (get) Token: 0x0601548D RID: 87181 RVA: 0x00313EA0 File Offset: 0x003120A0
		public EBlackBoardType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBlackBoardType.Boolean;
				}
				return (EBlackBoardType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006B13 RID: 27411
		// (get) Token: 0x0601548E RID: 87182 RVA: 0x00313EDC File Offset: 0x003120DC
		public string Key
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601548F RID: 87183 RVA: 0x00313F13 File Offset: 0x00312113
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06015490 RID: 87184 RVA: 0x00313F22 File Offset: 0x00312122
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17006B14 RID: 27412
		// (get) Token: 0x06015491 RID: 87185 RVA: 0x00313F30 File Offset: 0x00312130
		public int EntityId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06015492 RID: 87186 RVA: 0x00313F6C File Offset: 0x0031216C
		public static Offset<IBlackBoardEntityPos> CreateIBlackBoardEntityPos(FlatBufferBuilder builder, EBlackBoardType Type = EBlackBoardType.Boolean, StringOffset KeyOffset = default(StringOffset), int EntityId = 0)
		{
			builder.StartTable(3);
			IBlackBoardEntityPos.AddEntityId(builder, EntityId);
			IBlackBoardEntityPos.AddKey(builder, KeyOffset);
			IBlackBoardEntityPos.AddType(builder, Type);
			return IBlackBoardEntityPos.EndIBlackBoardEntityPos(builder);
		}

		// Token: 0x06015493 RID: 87187 RVA: 0x00313F90 File Offset: 0x00312190
		public static void StartIBlackBoardEntityPos(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06015494 RID: 87188 RVA: 0x00313F99 File Offset: 0x00312199
		public static void AddType(FlatBufferBuilder builder, EBlackBoardType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015495 RID: 87189 RVA: 0x00313FA4 File Offset: 0x003121A4
		public static void AddKey(FlatBufferBuilder builder, StringOffset keyOffset)
		{
			builder.AddOffset(1, keyOffset.Value, 0);
		}

		// Token: 0x06015496 RID: 87190 RVA: 0x00313FB4 File Offset: 0x003121B4
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(2, entityId, 0);
		}

		// Token: 0x06015497 RID: 87191 RVA: 0x00313FBF File Offset: 0x003121BF
		public static Offset<IBlackBoardEntityPos> EndIBlackBoardEntityPos(FlatBufferBuilder builder)
		{
			return new Offset<IBlackBoardEntityPos>(builder.EndTable());
		}

		// Token: 0x06015498 RID: 87192 RVA: 0x00313FCC File Offset: 0x003121CC
		public IBlackBoardEntityPosT UnPack()
		{
			IBlackBoardEntityPosT blackBoardEntityPosT = new IBlackBoardEntityPosT();
			this.UnPackTo(blackBoardEntityPosT);
			return blackBoardEntityPosT;
		}

		// Token: 0x06015499 RID: 87193 RVA: 0x00313FE7 File Offset: 0x003121E7
		public void UnPackTo(IBlackBoardEntityPosT _o)
		{
			_o.Type = this.Type;
			_o.Key = this.Key;
			_o.EntityId = this.EntityId;
		}

		// Token: 0x0601549A RID: 87194 RVA: 0x00314010 File Offset: 0x00312210
		public static Offset<IBlackBoardEntityPos> Pack(FlatBufferBuilder builder, IBlackBoardEntityPosT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBlackBoardEntityPos>);
			}
			StringOffset keyOffset = (_o.Key == null) ? default(StringOffset) : builder.CreateString(_o.Key);
			return IBlackBoardEntityPos.CreateIBlackBoardEntityPos(builder, _o.Type, keyOffset, _o.EntityId);
		}

		// Token: 0x0400B79E RID: 47006
		private Table __p;
	}
}
