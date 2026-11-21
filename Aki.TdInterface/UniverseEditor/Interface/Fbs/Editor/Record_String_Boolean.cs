using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004D42 RID: 19778
	public struct Record_String_Boolean : IFlatbufferObject
	{
		// Token: 0x17008DB1 RID: 36273
		// (get) Token: 0x0601EAB9 RID: 125625 RVA: 0x0044AA85 File Offset: 0x00448C85
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601EABA RID: 125626 RVA: 0x0044AA92 File Offset: 0x00448C92
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601EABB RID: 125627 RVA: 0x0044AA9C File Offset: 0x00448C9C
		public static Record_String_Boolean GetRootAsRecord_String_Boolean(ByteBuffer _bb)
		{
			return Record_String_Boolean.GetRootAsRecord_String_Boolean(_bb, default(Record_String_Boolean));
		}

		// Token: 0x0601EABC RID: 125628 RVA: 0x0044AAB8 File Offset: 0x00448CB8
		public static Record_String_Boolean GetRootAsRecord_String_Boolean(ByteBuffer _bb, Record_String_Boolean obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601EABD RID: 125629 RVA: 0x0044AAD5 File Offset: 0x00448CD5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601EABE RID: 125630 RVA: 0x0044AAE4 File Offset: 0x00448CE4
		public Record_String_Boolean __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008DB2 RID: 36274
		// (get) Token: 0x0601EABF RID: 125631 RVA: 0x0044AAF4 File Offset: 0x00448CF4
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

		// Token: 0x0601EAC0 RID: 125632 RVA: 0x0044AB2B File Offset: 0x00448D2B
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601EAC1 RID: 125633 RVA: 0x0044AB3A File Offset: 0x00448D3A
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17008DB3 RID: 36275
		// (get) Token: 0x0601EAC2 RID: 125634 RVA: 0x0044AB48 File Offset: 0x00448D48
		public bool Value
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601EAC3 RID: 125635 RVA: 0x0044AB87 File Offset: 0x00448D87
		public static Offset<Record_String_Boolean> CreateRecord_String_Boolean(FlatBufferBuilder builder, StringOffset KeyOffset = default(StringOffset), bool Value = false)
		{
			builder.StartTable(2);
			Record_String_Boolean.AddKey(builder, KeyOffset);
			Record_String_Boolean.AddValue(builder, Value);
			return Record_String_Boolean.EndRecord_String_Boolean(builder);
		}

		// Token: 0x0601EAC4 RID: 125636 RVA: 0x0044ABA4 File Offset: 0x00448DA4
		public static void StartRecord_String_Boolean(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601EAC5 RID: 125637 RVA: 0x0044ABAD File Offset: 0x00448DAD
		public static void AddKey(FlatBufferBuilder builder, StringOffset keyOffset)
		{
			builder.AddOffset(0, keyOffset.Value, 0);
		}

		// Token: 0x0601EAC6 RID: 125638 RVA: 0x0044ABBD File Offset: 0x00448DBD
		public static void AddValue(FlatBufferBuilder builder, bool value)
		{
			builder.AddBool(1, value, false);
		}

		// Token: 0x0601EAC7 RID: 125639 RVA: 0x0044ABC8 File Offset: 0x00448DC8
		public static Offset<Record_String_Boolean> EndRecord_String_Boolean(FlatBufferBuilder builder)
		{
			return new Offset<Record_String_Boolean>(builder.EndTable());
		}

		// Token: 0x0601EAC8 RID: 125640 RVA: 0x0044ABD8 File Offset: 0x00448DD8
		public Record_String_BooleanT UnPack()
		{
			Record_String_BooleanT record_String_BooleanT = new Record_String_BooleanT();
			this.UnPackTo(record_String_BooleanT);
			return record_String_BooleanT;
		}

		// Token: 0x0601EAC9 RID: 125641 RVA: 0x0044ABF3 File Offset: 0x00448DF3
		public void UnPackTo(Record_String_BooleanT _o)
		{
			_o.Key = this.Key;
			_o.Value = this.Value;
		}

		// Token: 0x0601EACA RID: 125642 RVA: 0x0044AC10 File Offset: 0x00448E10
		public static Offset<Record_String_Boolean> Pack(FlatBufferBuilder builder, Record_String_BooleanT _o)
		{
			if (_o == null)
			{
				return default(Offset<Record_String_Boolean>);
			}
			StringOffset keyOffset = (_o.Key == null) ? default(StringOffset) : builder.CreateString(_o.Key);
			return Record_String_Boolean.CreateRecord_String_Boolean(builder, keyOffset, _o.Value);
		}

		// Token: 0x0400D920 RID: 55584
		private Table __p;
	}
}
