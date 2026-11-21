using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C5B RID: 19547
	public struct Record_String_IBlueprintItem : IFlatbufferObject
	{
		// Token: 0x17008AA9 RID: 35497
		// (get) Token: 0x0601DFC9 RID: 122825 RVA: 0x00434385 File Offset: 0x00432585
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DFCA RID: 122826 RVA: 0x00434392 File Offset: 0x00432592
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DFCB RID: 122827 RVA: 0x0043439C File Offset: 0x0043259C
		public static Record_String_IBlueprintItem GetRootAsRecord_String_IBlueprintItem(ByteBuffer _bb)
		{
			return Record_String_IBlueprintItem.GetRootAsRecord_String_IBlueprintItem(_bb, default(Record_String_IBlueprintItem));
		}

		// Token: 0x0601DFCC RID: 122828 RVA: 0x004343B8 File Offset: 0x004325B8
		public static Record_String_IBlueprintItem GetRootAsRecord_String_IBlueprintItem(ByteBuffer _bb, Record_String_IBlueprintItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DFCD RID: 122829 RVA: 0x004343D5 File Offset: 0x004325D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DFCE RID: 122830 RVA: 0x004343E4 File Offset: 0x004325E4
		public Record_String_IBlueprintItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008AAA RID: 35498
		// (get) Token: 0x0601DFCF RID: 122831 RVA: 0x004343F4 File Offset: 0x004325F4
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

		// Token: 0x0601DFD0 RID: 122832 RVA: 0x0043442B File Offset: 0x0043262B
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601DFD1 RID: 122833 RVA: 0x0043443A File Offset: 0x0043263A
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17008AAB RID: 35499
		// (get) Token: 0x0601DFD2 RID: 122834 RVA: 0x00434448 File Offset: 0x00432648
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

		// Token: 0x0601DFD3 RID: 122835 RVA: 0x004344A5 File Offset: 0x004326A5
		public static Offset<Record_String_IBlueprintItem> CreateRecord_String_IBlueprintItem(FlatBufferBuilder builder, StringOffset KeyOffset = default(StringOffset), Offset<IBlueprintItem> ValueOffset = default(Offset<IBlueprintItem>))
		{
			builder.StartTable(2);
			Record_String_IBlueprintItem.AddValue(builder, ValueOffset);
			Record_String_IBlueprintItem.AddKey(builder, KeyOffset);
			return Record_String_IBlueprintItem.EndRecord_String_IBlueprintItem(builder);
		}

		// Token: 0x0601DFD4 RID: 122836 RVA: 0x004344C2 File Offset: 0x004326C2
		public static void StartRecord_String_IBlueprintItem(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601DFD5 RID: 122837 RVA: 0x004344CB File Offset: 0x004326CB
		public static void AddKey(FlatBufferBuilder builder, StringOffset keyOffset)
		{
			builder.AddOffset(0, keyOffset.Value, 0);
		}

		// Token: 0x0601DFD6 RID: 122838 RVA: 0x004344DB File Offset: 0x004326DB
		public static void AddValue(FlatBufferBuilder builder, Offset<IBlueprintItem> valueOffset)
		{
			builder.AddOffset(1, valueOffset.Value, 0);
		}

		// Token: 0x0601DFD7 RID: 122839 RVA: 0x004344EB File Offset: 0x004326EB
		public static Offset<Record_String_IBlueprintItem> EndRecord_String_IBlueprintItem(FlatBufferBuilder builder)
		{
			return new Offset<Record_String_IBlueprintItem>(builder.EndTable());
		}

		// Token: 0x0601DFD8 RID: 122840 RVA: 0x004344F8 File Offset: 0x004326F8
		public Record_String_IBlueprintItemT UnPack()
		{
			Record_String_IBlueprintItemT record_String_IBlueprintItemT = new Record_String_IBlueprintItemT();
			this.UnPackTo(record_String_IBlueprintItemT);
			return record_String_IBlueprintItemT;
		}

		// Token: 0x0601DFD9 RID: 122841 RVA: 0x00434514 File Offset: 0x00432714
		public void UnPackTo(Record_String_IBlueprintItemT _o)
		{
			_o.Key = this.Key;
			_o.Value = ((this.Value != null) ? this.Value.Value.UnPack() : null);
		}

		// Token: 0x0601DFDA RID: 122842 RVA: 0x0043455C File Offset: 0x0043275C
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

		// Token: 0x0400D6C5 RID: 54981
		private Table __p;
	}
}
