using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x020048DD RID: 18653
	public struct Record_String_Boolean : IFlatbufferObject
	{
		// Token: 0x17008769 RID: 34665
		// (get) Token: 0x0601D2CC RID: 119500 RVA: 0x0041E2E9 File Offset: 0x0041C4E9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D2CD RID: 119501 RVA: 0x0041E2F6 File Offset: 0x0041C4F6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D2CE RID: 119502 RVA: 0x0041E300 File Offset: 0x0041C500
		public static Record_String_Boolean GetRootAsRecord_String_Boolean(ByteBuffer _bb)
		{
			return Record_String_Boolean.GetRootAsRecord_String_Boolean(_bb, default(Record_String_Boolean));
		}

		// Token: 0x0601D2CF RID: 119503 RVA: 0x0041E31C File Offset: 0x0041C51C
		public static Record_String_Boolean GetRootAsRecord_String_Boolean(ByteBuffer _bb, Record_String_Boolean obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D2D0 RID: 119504 RVA: 0x0041E339 File Offset: 0x0041C539
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D2D1 RID: 119505 RVA: 0x0041E348 File Offset: 0x0041C548
		public Record_String_Boolean __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700876A RID: 34666
		// (get) Token: 0x0601D2D2 RID: 119506 RVA: 0x0041E358 File Offset: 0x0041C558
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

		// Token: 0x0601D2D3 RID: 119507 RVA: 0x0041E38F File Offset: 0x0041C58F
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601D2D4 RID: 119508 RVA: 0x0041E39E File Offset: 0x0041C59E
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700876B RID: 34667
		// (get) Token: 0x0601D2D5 RID: 119509 RVA: 0x0041E3AC File Offset: 0x0041C5AC
		public bool Value
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601D2D6 RID: 119510 RVA: 0x0041E3EB File Offset: 0x0041C5EB
		public static Offset<Record_String_Boolean> CreateRecord_String_Boolean(FlatBufferBuilder builder, StringOffset KeyOffset = default(StringOffset), bool Value = false)
		{
			builder.StartTable(2);
			Record_String_Boolean.AddKey(builder, KeyOffset);
			Record_String_Boolean.AddValue(builder, Value);
			return Record_String_Boolean.EndRecord_String_Boolean(builder);
		}

		// Token: 0x0601D2D7 RID: 119511 RVA: 0x0041E408 File Offset: 0x0041C608
		public static void StartRecord_String_Boolean(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601D2D8 RID: 119512 RVA: 0x0041E411 File Offset: 0x0041C611
		public static void AddKey(FlatBufferBuilder builder, StringOffset keyOffset)
		{
			builder.AddOffset(0, keyOffset.Value, 0);
		}

		// Token: 0x0601D2D9 RID: 119513 RVA: 0x0041E421 File Offset: 0x0041C621
		public static void AddValue(FlatBufferBuilder builder, bool value)
		{
			builder.AddBool(1, value, false);
		}

		// Token: 0x0601D2DA RID: 119514 RVA: 0x0041E42C File Offset: 0x0041C62C
		public static Offset<Record_String_Boolean> EndRecord_String_Boolean(FlatBufferBuilder builder)
		{
			return new Offset<Record_String_Boolean>(builder.EndTable());
		}

		// Token: 0x0601D2DB RID: 119515 RVA: 0x0041E43C File Offset: 0x0041C63C
		public Record_String_BooleanT UnPack()
		{
			Record_String_BooleanT record_String_BooleanT = new Record_String_BooleanT();
			this.UnPackTo(record_String_BooleanT);
			return record_String_BooleanT;
		}

		// Token: 0x0601D2DC RID: 119516 RVA: 0x0041E457 File Offset: 0x0041C657
		public void UnPackTo(Record_String_BooleanT _o)
		{
			_o.Key = this.Key;
			_o.Value = this.Value;
		}

		// Token: 0x0601D2DD RID: 119517 RVA: 0x0041E474 File Offset: 0x0041C674
		public static Offset<Record_String_Boolean> Pack(FlatBufferBuilder builder, Record_String_BooleanT _o)
		{
			if (_o == null)
			{
				return default(Offset<Record_String_Boolean>);
			}
			StringOffset keyOffset = (_o.Key == null) ? default(StringOffset) : builder.CreateString(_o.Key);
			return Record_String_Boolean.CreateRecord_String_Boolean(builder, keyOffset, _o.Value);
		}

		// Token: 0x0400CEE7 RID: 52967
		private Table __p;
	}
}
