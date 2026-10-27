using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047F3 RID: 18419
	public struct Record_String_IBlueprintItem : IFlatbufferObject
	{
		// Token: 0x1700845E RID: 33886
		// (get) Token: 0x0601C7CC RID: 116684 RVA: 0x00407A35 File Offset: 0x00405C35
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C7CD RID: 116685 RVA: 0x00407A42 File Offset: 0x00405C42
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C7CE RID: 116686 RVA: 0x00407A4C File Offset: 0x00405C4C
		public static Record_String_IBlueprintItem GetRootAsRecord_String_IBlueprintItem(ByteBuffer _bb)
		{
			return Record_String_IBlueprintItem.GetRootAsRecord_String_IBlueprintItem(_bb, default(Record_String_IBlueprintItem));
		}

		// Token: 0x0601C7CF RID: 116687 RVA: 0x00407A68 File Offset: 0x00405C68
		public static Record_String_IBlueprintItem GetRootAsRecord_String_IBlueprintItem(ByteBuffer _bb, Record_String_IBlueprintItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C7D0 RID: 116688 RVA: 0x00407A85 File Offset: 0x00405C85
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C7D1 RID: 116689 RVA: 0x00407A94 File Offset: 0x00405C94
		public Record_String_IBlueprintItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700845F RID: 33887
		// (get) Token: 0x0601C7D2 RID: 116690 RVA: 0x00407AA4 File Offset: 0x00405CA4
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

		// Token: 0x0601C7D3 RID: 116691 RVA: 0x00407ADB File Offset: 0x00405CDB
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601C7D4 RID: 116692 RVA: 0x00407AEA File Offset: 0x00405CEA
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17008460 RID: 33888
		// (get) Token: 0x0601C7D5 RID: 116693 RVA: 0x00407AF8 File Offset: 0x00405CF8
		public IBlueprintItem? Value
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IBlueprintItem?(default(IBlueprintItem).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601C7D6 RID: 116694 RVA: 0x00407B55 File Offset: 0x00405D55
		public static Offset<Record_String_IBlueprintItem> CreateRecord_String_IBlueprintItem(FlatBufferBuilder builder, StringOffset KeyOffset = default(StringOffset), Offset<IBlueprintItem> ValueOffset = default(Offset<IBlueprintItem>))
		{
			builder.StartTable(2);
			Record_String_IBlueprintItem.AddValue(builder, ValueOffset);
			Record_String_IBlueprintItem.AddKey(builder, KeyOffset);
			return Record_String_IBlueprintItem.EndRecord_String_IBlueprintItem(builder);
		}

		// Token: 0x0601C7D7 RID: 116695 RVA: 0x00407B72 File Offset: 0x00405D72
		public static void StartRecord_String_IBlueprintItem(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601C7D8 RID: 116696 RVA: 0x00407B7B File Offset: 0x00405D7B
		public static void AddKey(FlatBufferBuilder builder, StringOffset keyOffset)
		{
			builder.AddOffset(0, keyOffset.Value, 0);
		}

		// Token: 0x0601C7D9 RID: 116697 RVA: 0x00407B8B File Offset: 0x00405D8B
		public static void AddValue(FlatBufferBuilder builder, Offset<IBlueprintItem> valueOffset)
		{
			builder.AddOffset(1, valueOffset.Value, 0);
		}

		// Token: 0x0601C7DA RID: 116698 RVA: 0x00407B9B File Offset: 0x00405D9B
		public static Offset<Record_String_IBlueprintItem> EndRecord_String_IBlueprintItem(FlatBufferBuilder builder)
		{
			return new Offset<Record_String_IBlueprintItem>(builder.EndTable());
		}

		// Token: 0x0601C7DB RID: 116699 RVA: 0x00407BA8 File Offset: 0x00405DA8
		public Record_String_IBlueprintItemT UnPack()
		{
			Record_String_IBlueprintItemT record_String_IBlueprintItemT = new Record_String_IBlueprintItemT();
			this.UnPackTo(record_String_IBlueprintItemT);
			return record_String_IBlueprintItemT;
		}

		// Token: 0x0601C7DC RID: 116700 RVA: 0x00407BC4 File Offset: 0x00405DC4
		public void UnPackTo(Record_String_IBlueprintItemT _o)
		{
			_o.Key = this.Key;
			_o.Value = ((this.Value != null) ? this.Value.Value.UnPack() : null);
		}

		// Token: 0x0601C7DD RID: 116701 RVA: 0x00407C0C File Offset: 0x00405E0C
		public static Offset<Record_String_IBlueprintItem> Pack(FlatBufferBuilder builder, Record_String_IBlueprintItemT _o)
		{
			if (_o == null)
			{
				return default(Offset<Record_String_IBlueprintItem>);
			}
			StringOffset keyOffset = (_o.Key == null) ? default(StringOffset) : builder.CreateString(_o.Key);
			Offset<IBlueprintItem> valueOffset = (_o.Value == null) ? default(Offset<IBlueprintItem>) : IBlueprintItem.Pack(builder, _o.Value);
			return Record_String_IBlueprintItem.CreateRecord_String_IBlueprintItem(builder, keyOffset, valueOffset);
		}

		// Token: 0x0400CC8A RID: 52362
		private Table __p;
	}
}
