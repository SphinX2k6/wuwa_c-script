using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A0F RID: 14863
	public struct IBlackBoardEntityId : IFlatbufferObject
	{
		// Token: 0x170065DA RID: 26074
		// (get) Token: 0x0601414F RID: 82255 RVA: 0x002F098E File Offset: 0x002EEB8E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06014150 RID: 82256 RVA: 0x002F099B File Offset: 0x002EEB9B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06014151 RID: 82257 RVA: 0x002F09A4 File Offset: 0x002EEBA4
		public static IBlackBoardEntityId GetRootAsIBlackBoardEntityId(ByteBuffer _bb)
		{
			return IBlackBoardEntityId.GetRootAsIBlackBoardEntityId(_bb, default(IBlackBoardEntityId));
		}

		// Token: 0x06014152 RID: 82258 RVA: 0x002F09C0 File Offset: 0x002EEBC0
		public static IBlackBoardEntityId GetRootAsIBlackBoardEntityId(ByteBuffer _bb, IBlackBoardEntityId obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06014153 RID: 82259 RVA: 0x002F09DD File Offset: 0x002EEBDD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06014154 RID: 82260 RVA: 0x002F09EC File Offset: 0x002EEBEC
		public IBlackBoardEntityId __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170065DB RID: 26075
		// (get) Token: 0x06014155 RID: 82261 RVA: 0x002F09FC File Offset: 0x002EEBFC
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

		// Token: 0x170065DC RID: 26076
		// (get) Token: 0x06014156 RID: 82262 RVA: 0x002F0A38 File Offset: 0x002EEC38
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

		// Token: 0x06014157 RID: 82263 RVA: 0x002F0A6F File Offset: 0x002EEC6F
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06014158 RID: 82264 RVA: 0x002F0A7E File Offset: 0x002EEC7E
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x170065DD RID: 26077
		// (get) Token: 0x06014159 RID: 82265 RVA: 0x002F0A8C File Offset: 0x002EEC8C
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

		// Token: 0x0601415A RID: 82266 RVA: 0x002F0AC8 File Offset: 0x002EECC8
		public static Offset<IBlackBoardEntityId> CreateIBlackBoardEntityId(FlatBufferBuilder builder, EBlackBoardType Type = EBlackBoardType.Boolean, StringOffset KeyOffset = default(StringOffset), int EntityId = 0)
		{
			builder.StartTable(3);
			IBlackBoardEntityId.AddEntityId(builder, EntityId);
			IBlackBoardEntityId.AddKey(builder, KeyOffset);
			IBlackBoardEntityId.AddType(builder, Type);
			return IBlackBoardEntityId.EndIBlackBoardEntityId(builder);
		}

		// Token: 0x0601415B RID: 82267 RVA: 0x002F0AEC File Offset: 0x002EECEC
		public static void StartIBlackBoardEntityId(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601415C RID: 82268 RVA: 0x002F0AF5 File Offset: 0x002EECF5
		public static void AddType(FlatBufferBuilder builder, EBlackBoardType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601415D RID: 82269 RVA: 0x002F0B00 File Offset: 0x002EED00
		public static void AddKey(FlatBufferBuilder builder, StringOffset keyOffset)
		{
			builder.AddOffset(1, keyOffset.Value, 0);
		}

		// Token: 0x0601415E RID: 82270 RVA: 0x002F0B10 File Offset: 0x002EED10
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(2, entityId, 0);
		}

		// Token: 0x0601415F RID: 82271 RVA: 0x002F0B1B File Offset: 0x002EED1B
		public static Offset<IBlackBoardEntityId> EndIBlackBoardEntityId(FlatBufferBuilder builder)
		{
			return new Offset<IBlackBoardEntityId>(builder.EndTable());
		}

		// Token: 0x06014160 RID: 82272 RVA: 0x002F0B28 File Offset: 0x002EED28
		public IBlackBoardEntityIdT UnPack()
		{
			IBlackBoardEntityIdT blackBoardEntityIdT = new IBlackBoardEntityIdT();
			this.UnPackTo(blackBoardEntityIdT);
			return blackBoardEntityIdT;
		}

		// Token: 0x06014161 RID: 82273 RVA: 0x002F0B43 File Offset: 0x002EED43
		public void UnPackTo(IBlackBoardEntityIdT _o)
		{
			_o.Type = this.Type;
			_o.Key = this.Key;
			_o.EntityId = this.EntityId;
		}

		// Token: 0x06014162 RID: 82274 RVA: 0x002F0B6C File Offset: 0x002EED6C
		public static Offset<IBlackBoardEntityId> Pack(FlatBufferBuilder builder, IBlackBoardEntityIdT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBlackBoardEntityId>);
			}
			StringOffset keyOffset = (_o.Key == null) ? default(StringOffset) : builder.CreateString(_o.Key);
			return IBlackBoardEntityId.CreateIBlackBoardEntityId(builder, _o.Type, keyOffset, _o.EntityId);
		}

		// Token: 0x0400AE78 RID: 44664
		private Table __p;
	}
}
