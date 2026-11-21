using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x02004B83 RID: 19331
	public struct Record_String_String : IFlatbufferObject
	{
		// Token: 0x170088AC RID: 34988
		// (get) Token: 0x0601D700 RID: 120576 RVA: 0x0042249C File Offset: 0x0042069C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D701 RID: 120577 RVA: 0x004224A9 File Offset: 0x004206A9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D702 RID: 120578 RVA: 0x004224B0 File Offset: 0x004206B0
		public static Record_String_String GetRootAsRecord_String_String(ByteBuffer _bb)
		{
			return Record_String_String.GetRootAsRecord_String_String(_bb, default(Record_String_String));
		}

		// Token: 0x0601D703 RID: 120579 RVA: 0x004224CC File Offset: 0x004206CC
		public static Record_String_String GetRootAsRecord_String_String(ByteBuffer _bb, Record_String_String obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D704 RID: 120580 RVA: 0x004224E9 File Offset: 0x004206E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D705 RID: 120581 RVA: 0x004224F8 File Offset: 0x004206F8
		public Record_String_String __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170088AD RID: 34989
		// (get) Token: 0x0601D706 RID: 120582 RVA: 0x00422508 File Offset: 0x00420708
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

		// Token: 0x0601D707 RID: 120583 RVA: 0x0042253F File Offset: 0x0042073F
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601D708 RID: 120584 RVA: 0x0042254E File Offset: 0x0042074E
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x170088AE RID: 34990
		// (get) Token: 0x0601D709 RID: 120585 RVA: 0x0042255C File Offset: 0x0042075C
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

		// Token: 0x0601D70A RID: 120586 RVA: 0x00422593 File Offset: 0x00420793
		public Span<byte> GetValueBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601D70B RID: 120587 RVA: 0x004225A2 File Offset: 0x004207A2
		public byte[] GetValueArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0601D70C RID: 120588 RVA: 0x004225B0 File Offset: 0x004207B0
		public static Offset<Record_String_String> CreateRecord_String_String(FlatBufferBuilder builder, StringOffset KeyOffset = default(StringOffset), StringOffset ValueOffset = default(StringOffset))
		{
			builder.StartTable(2);
			Record_String_String.AddValue(builder, ValueOffset);
			Record_String_String.AddKey(builder, KeyOffset);
			return Record_String_String.EndRecord_String_String(builder);
		}

		// Token: 0x0601D70D RID: 120589 RVA: 0x004225CD File Offset: 0x004207CD
		public static void StartRecord_String_String(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601D70E RID: 120590 RVA: 0x004225D6 File Offset: 0x004207D6
		public static void AddKey(FlatBufferBuilder builder, StringOffset keyOffset)
		{
			builder.AddOffset(0, keyOffset.Value, 0);
		}

		// Token: 0x0601D70F RID: 120591 RVA: 0x004225E6 File Offset: 0x004207E6
		public static void AddValue(FlatBufferBuilder builder, StringOffset valueOffset)
		{
			builder.AddOffset(1, valueOffset.Value, 0);
		}

		// Token: 0x0601D710 RID: 120592 RVA: 0x004225F6 File Offset: 0x004207F6
		public static Offset<Record_String_String> EndRecord_String_String(FlatBufferBuilder builder)
		{
			return new Offset<Record_String_String>(builder.EndTable());
		}

		// Token: 0x0601D711 RID: 120593 RVA: 0x00422604 File Offset: 0x00420804
		public Record_String_StringT UnPack()
		{
			Record_String_StringT record_String_StringT = new Record_String_StringT();
			this.UnPackTo(record_String_StringT);
			return record_String_StringT;
		}

		// Token: 0x0601D712 RID: 120594 RVA: 0x0042261F File Offset: 0x0042081F
		public void UnPackTo(Record_String_StringT _o)
		{
			_o.Key = this.Key;
			_o.Value = this.Value;
		}

		// Token: 0x0601D713 RID: 120595 RVA: 0x0042263C File Offset: 0x0042083C
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

		// Token: 0x0400D41C RID: 54300
		private Table __p;
	}
}
