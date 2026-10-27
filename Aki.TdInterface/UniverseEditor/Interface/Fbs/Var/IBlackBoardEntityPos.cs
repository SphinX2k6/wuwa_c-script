using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A12 RID: 14866
	public struct IBlackBoardEntityPos : IFlatbufferObject
	{
		// Token: 0x170065E1 RID: 26081
		// (get) Token: 0x0601416B RID: 82283 RVA: 0x002F0C46 File Offset: 0x002EEE46
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601416C RID: 82284 RVA: 0x002F0C53 File Offset: 0x002EEE53
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601416D RID: 82285 RVA: 0x002F0C5C File Offset: 0x002EEE5C
		public static IBlackBoardEntityPos GetRootAsIBlackBoardEntityPos(ByteBuffer _bb)
		{
			return IBlackBoardEntityPos.GetRootAsIBlackBoardEntityPos(_bb, default(IBlackBoardEntityPos));
		}

		// Token: 0x0601416E RID: 82286 RVA: 0x002F0C78 File Offset: 0x002EEE78
		public static IBlackBoardEntityPos GetRootAsIBlackBoardEntityPos(ByteBuffer _bb, IBlackBoardEntityPos obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601416F RID: 82287 RVA: 0x002F0C95 File Offset: 0x002EEE95
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06014170 RID: 82288 RVA: 0x002F0CA4 File Offset: 0x002EEEA4
		public IBlackBoardEntityPos __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170065E2 RID: 26082
		// (get) Token: 0x06014171 RID: 82289 RVA: 0x002F0CB4 File Offset: 0x002EEEB4
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

		// Token: 0x170065E3 RID: 26083
		// (get) Token: 0x06014172 RID: 82290 RVA: 0x002F0CF0 File Offset: 0x002EEEF0
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

		// Token: 0x06014173 RID: 82291 RVA: 0x002F0D27 File Offset: 0x002EEF27
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06014174 RID: 82292 RVA: 0x002F0D36 File Offset: 0x002EEF36
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x170065E4 RID: 26084
		// (get) Token: 0x06014175 RID: 82293 RVA: 0x002F0D44 File Offset: 0x002EEF44
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

		// Token: 0x06014176 RID: 82294 RVA: 0x002F0D80 File Offset: 0x002EEF80
		public static Offset<IBlackBoardEntityPos> CreateIBlackBoardEntityPos(FlatBufferBuilder builder, EBlackBoardType Type = EBlackBoardType.Boolean, StringOffset KeyOffset = default(StringOffset), int EntityId = 0)
		{
			builder.StartTable(3);
			IBlackBoardEntityPos.AddEntityId(builder, EntityId);
			IBlackBoardEntityPos.AddKey(builder, KeyOffset);
			IBlackBoardEntityPos.AddType(builder, Type);
			return IBlackBoardEntityPos.EndIBlackBoardEntityPos(builder);
		}

		// Token: 0x06014177 RID: 82295 RVA: 0x002F0DA4 File Offset: 0x002EEFA4
		public static void StartIBlackBoardEntityPos(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06014178 RID: 82296 RVA: 0x002F0DAD File Offset: 0x002EEFAD
		public static void AddType(FlatBufferBuilder builder, EBlackBoardType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06014179 RID: 82297 RVA: 0x002F0DB8 File Offset: 0x002EEFB8
		public static void AddKey(FlatBufferBuilder builder, StringOffset keyOffset)
		{
			builder.AddOffset(1, keyOffset.Value, 0);
		}

		// Token: 0x0601417A RID: 82298 RVA: 0x002F0DC8 File Offset: 0x002EEFC8
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(2, entityId, 0);
		}

		// Token: 0x0601417B RID: 82299 RVA: 0x002F0DD3 File Offset: 0x002EEFD3
		public static Offset<IBlackBoardEntityPos> EndIBlackBoardEntityPos(FlatBufferBuilder builder)
		{
			return new Offset<IBlackBoardEntityPos>(builder.EndTable());
		}

		// Token: 0x0601417C RID: 82300 RVA: 0x002F0DE0 File Offset: 0x002EEFE0
		public IBlackBoardEntityPosT UnPack()
		{
			IBlackBoardEntityPosT blackBoardEntityPosT = new IBlackBoardEntityPosT();
			this.UnPackTo(blackBoardEntityPosT);
			return blackBoardEntityPosT;
		}

		// Token: 0x0601417D RID: 82301 RVA: 0x002F0DFB File Offset: 0x002EEFFB
		public void UnPackTo(IBlackBoardEntityPosT _o)
		{
			_o.Type = this.Type;
			_o.Key = this.Key;
			_o.EntityId = this.EntityId;
		}

		// Token: 0x0601417E RID: 82302 RVA: 0x002F0E24 File Offset: 0x002EF024
		public static Offset<IBlackBoardEntityPos> Pack(FlatBufferBuilder builder, IBlackBoardEntityPosT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBlackBoardEntityPos>);
			}
			StringOffset keyOffset = (_o.Key == null) ? default(StringOffset) : builder.CreateString(_o.Key);
			return IBlackBoardEntityPos.CreateIBlackBoardEntityPos(builder, _o.Type, keyOffset, _o.EntityId);
		}

		// Token: 0x0400AE7C RID: 44668
		private Table __p;
	}
}
