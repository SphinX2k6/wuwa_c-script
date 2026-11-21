using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200461F RID: 17951
	public struct ITetrisPlayModeMainLine : IFlatbufferObject
	{
		// Token: 0x17007D8D RID: 32141
		// (get) Token: 0x0601A418 RID: 107544 RVA: 0x003BCF00 File Offset: 0x003BB100
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A419 RID: 107545 RVA: 0x003BCF0D File Offset: 0x003BB10D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A41A RID: 107546 RVA: 0x003BCF14 File Offset: 0x003BB114
		public static ITetrisPlayModeMainLine GetRootAsITetrisPlayModeMainLine(ByteBuffer _bb)
		{
			return ITetrisPlayModeMainLine.GetRootAsITetrisPlayModeMainLine(_bb, default(ITetrisPlayModeMainLine));
		}

		// Token: 0x0601A41B RID: 107547 RVA: 0x003BCF30 File Offset: 0x003BB130
		public static ITetrisPlayModeMainLine GetRootAsITetrisPlayModeMainLine(ByteBuffer _bb, ITetrisPlayModeMainLine obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A41C RID: 107548 RVA: 0x003BCF4D File Offset: 0x003BB14D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A41D RID: 107549 RVA: 0x003BCF5C File Offset: 0x003BB15C
		public ITetrisPlayModeMainLine __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007D8E RID: 32142
		// (get) Token: 0x0601A41E RID: 107550 RVA: 0x003BCF6C File Offset: 0x003BB16C
		public ETetrisPlayMode Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETetrisPlayMode.Normal;
				}
				return (ETetrisPlayMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007D8F RID: 32143
		// (get) Token: 0x0601A41F RID: 107551 RVA: 0x003BCFA8 File Offset: 0x003BB1A8
		public int EntityId
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

		// Token: 0x17007D90 RID: 32144
		// (get) Token: 0x0601A420 RID: 107552 RVA: 0x003BCFE4 File Offset: 0x003BB1E4
		public string EntityState
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

		// Token: 0x0601A421 RID: 107553 RVA: 0x003BD01B File Offset: 0x003BB21B
		public Span<byte> GetEntityStateBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0601A422 RID: 107554 RVA: 0x003BD02A File Offset: 0x003BB22A
		public byte[] GetEntityStateArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x17007D91 RID: 32145
		// (get) Token: 0x0601A423 RID: 107555 RVA: 0x003BD038 File Offset: 0x003BB238
		public int FieldHeight
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007D92 RID: 32146
		// (get) Token: 0x0601A424 RID: 107556 RVA: 0x003BD078 File Offset: 0x003BB278
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601A425 RID: 107557 RVA: 0x003BD0B5 File Offset: 0x003BB2B5
		public static Offset<ITetrisPlayModeMainLine> CreateITetrisPlayModeMainLine(FlatBufferBuilder builder, ETetrisPlayMode Type = ETetrisPlayMode.Normal, int EntityId = 0, StringOffset EntityStateOffset = default(StringOffset), int FieldHeight = 0, byte NullMask = 0)
		{
			builder.StartTable(5);
			ITetrisPlayModeMainLine.AddFieldHeight(builder, FieldHeight);
			ITetrisPlayModeMainLine.AddEntityState(builder, EntityStateOffset);
			ITetrisPlayModeMainLine.AddEntityId(builder, EntityId);
			ITetrisPlayModeMainLine.AddNullMask(builder, NullMask);
			ITetrisPlayModeMainLine.AddType(builder, Type);
			return ITetrisPlayModeMainLine.EndITetrisPlayModeMainLine(builder);
		}

		// Token: 0x0601A426 RID: 107558 RVA: 0x003BD0E9 File Offset: 0x003BB2E9
		public static void StartITetrisPlayModeMainLine(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601A427 RID: 107559 RVA: 0x003BD0F2 File Offset: 0x003BB2F2
		public static void AddType(FlatBufferBuilder builder, ETetrisPlayMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A428 RID: 107560 RVA: 0x003BD0FD File Offset: 0x003BB2FD
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x0601A429 RID: 107561 RVA: 0x003BD108 File Offset: 0x003BB308
		public static void AddEntityState(FlatBufferBuilder builder, StringOffset entityStateOffset)
		{
			builder.AddOffset(2, entityStateOffset.Value, 0);
		}

		// Token: 0x0601A42A RID: 107562 RVA: 0x003BD118 File Offset: 0x003BB318
		public static void AddFieldHeight(FlatBufferBuilder builder, int fieldHeight)
		{
			builder.AddInt(3, fieldHeight, 0);
		}

		// Token: 0x0601A42B RID: 107563 RVA: 0x003BD123 File Offset: 0x003BB323
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0601A42C RID: 107564 RVA: 0x003BD12E File Offset: 0x003BB32E
		public static Offset<ITetrisPlayModeMainLine> EndITetrisPlayModeMainLine(FlatBufferBuilder builder)
		{
			return new Offset<ITetrisPlayModeMainLine>(builder.EndTable());
		}

		// Token: 0x0601A42D RID: 107565 RVA: 0x003BD13C File Offset: 0x003BB33C
		public ITetrisPlayModeMainLineT UnPack()
		{
			ITetrisPlayModeMainLineT tetrisPlayModeMainLineT = new ITetrisPlayModeMainLineT();
			this.UnPackTo(tetrisPlayModeMainLineT);
			return tetrisPlayModeMainLineT;
		}

		// Token: 0x0601A42E RID: 107566 RVA: 0x003BD157 File Offset: 0x003BB357
		public void UnPackTo(ITetrisPlayModeMainLineT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
			_o.EntityState = this.EntityState;
			_o.FieldHeight = this.FieldHeight;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601A42F RID: 107567 RVA: 0x003BD198 File Offset: 0x003BB398
		public static Offset<ITetrisPlayModeMainLine> Pack(FlatBufferBuilder builder, ITetrisPlayModeMainLineT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITetrisPlayModeMainLine>);
			}
			StringOffset entityStateOffset = (_o.EntityState == null) ? default(StringOffset) : builder.CreateString(_o.EntityState);
			return ITetrisPlayModeMainLine.CreateITetrisPlayModeMainLine(builder, _o.Type, _o.EntityId, entityStateOffset, _o.FieldHeight, _o.NullMask);
		}

		// Token: 0x0400C819 RID: 51225
		private Table __p;
	}
}
