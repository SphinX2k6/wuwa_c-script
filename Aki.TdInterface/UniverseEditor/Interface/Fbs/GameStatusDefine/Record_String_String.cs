using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x0200471B RID: 18203
	public struct Record_String_String : IFlatbufferObject
	{
		// Token: 0x1700826B RID: 33387
		// (get) Token: 0x0601BF2B RID: 114475 RVA: 0x003F6200 File Offset: 0x003F4400
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601BF2C RID: 114476 RVA: 0x003F620D File Offset: 0x003F440D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601BF2D RID: 114477 RVA: 0x003F6214 File Offset: 0x003F4414
		public static Record_String_String GetRootAsRecord_String_String(ByteBuffer _bb)
		{
			return Record_String_String.GetRootAsRecord_String_String(_bb, default(Record_String_String));
		}

		// Token: 0x0601BF2E RID: 114478 RVA: 0x003F6230 File Offset: 0x003F4430
		public static Record_String_String GetRootAsRecord_String_String(ByteBuffer _bb, Record_String_String obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601BF2F RID: 114479 RVA: 0x003F624D File Offset: 0x003F444D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601BF30 RID: 114480 RVA: 0x003F625C File Offset: 0x003F445C
		public Record_String_String __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700826C RID: 33388
		// (get) Token: 0x0601BF31 RID: 114481 RVA: 0x003F626C File Offset: 0x003F446C
		public string Key
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BF32 RID: 114482 RVA: 0x003F62A3 File Offset: 0x003F44A3
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601BF33 RID: 114483 RVA: 0x003F62B2 File Offset: 0x003F44B2
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700826D RID: 33389
		// (get) Token: 0x0601BF34 RID: 114484 RVA: 0x003F62C0 File Offset: 0x003F44C0
		public string Value
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

		// Token: 0x0601BF35 RID: 114485 RVA: 0x003F62F7 File Offset: 0x003F44F7
		public Span<byte> GetValueBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601BF36 RID: 114486 RVA: 0x003F6306 File Offset: 0x003F4506
		public byte[] GetValueArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0601BF37 RID: 114487 RVA: 0x003F6314 File Offset: 0x003F4514
		public static Offset<Record_String_String> CreateRecord_String_String(FlatBufferBuilder builder, StringOffset KeyOffset = default(StringOffset), StringOffset ValueOffset = default(StringOffset))
		{
			builder.StartTable(2);
			Record_String_String.AddValue(builder, ValueOffset);
			Record_String_String.AddKey(builder, KeyOffset);
			return Record_String_String.EndRecord_String_String(builder);
		}

		// Token: 0x0601BF38 RID: 114488 RVA: 0x003F6331 File Offset: 0x003F4531
		public static void StartRecord_String_String(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601BF39 RID: 114489 RVA: 0x003F633A File Offset: 0x003F453A
		public static void AddKey(FlatBufferBuilder builder, StringOffset keyOffset)
		{
			builder.AddOffset(0, keyOffset.Value, 0);
		}

		// Token: 0x0601BF3A RID: 114490 RVA: 0x003F634A File Offset: 0x003F454A
		public static void AddValue(FlatBufferBuilder builder, StringOffset valueOffset)
		{
			builder.AddOffset(1, valueOffset.Value, 0);
		}

		// Token: 0x0601BF3B RID: 114491 RVA: 0x003F635A File Offset: 0x003F455A
		public static Offset<Record_String_String> EndRecord_String_String(FlatBufferBuilder builder)
		{
			return new Offset<Record_String_String>(builder.EndTable());
		}

		// Token: 0x0601BF3C RID: 114492 RVA: 0x003F6368 File Offset: 0x003F4568
		public Record_String_StringT UnPack()
		{
			Record_String_StringT record_String_StringT = new Record_String_StringT();
			this.UnPackTo(record_String_StringT);
			return record_String_StringT;
		}

		// Token: 0x0601BF3D RID: 114493 RVA: 0x003F6383 File Offset: 0x003F4583
		public void UnPackTo(Record_String_StringT _o)
		{
			_o.Key = this.Key;
			_o.Value = this.Value;
		}

		// Token: 0x0601BF3E RID: 114494 RVA: 0x003F63A0 File Offset: 0x003F45A0
		public static Offset<Record_String_String> Pack(FlatBufferBuilder builder, Record_String_StringT _o)
		{
			if (_o == null)
			{
				return default(Offset<Record_String_String>);
			}
			StringOffset keyOffset = (_o.Key == null) ? default(StringOffset) : builder.CreateString(_o.Key);
			StringOffset valueOffset = (_o.Value == null) ? default(StringOffset) : builder.CreateString(_o.Value);
			return Record_String_String.CreateRecord_String_String(builder, keyOffset, valueOffset);
		}

		// Token: 0x0400C9ED RID: 51693
		private Table __p;
	}
}
