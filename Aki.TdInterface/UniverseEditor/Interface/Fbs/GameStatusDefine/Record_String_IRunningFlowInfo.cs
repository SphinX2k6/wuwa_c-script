using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x02004B80 RID: 19328
	public struct Record_String_IRunningFlowInfo : IFlatbufferObject
	{
		// Token: 0x170088A7 RID: 34983
		// (get) Token: 0x0601D6E8 RID: 120552 RVA: 0x004221DA File Offset: 0x004203DA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D6E9 RID: 120553 RVA: 0x004221E7 File Offset: 0x004203E7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D6EA RID: 120554 RVA: 0x004221F0 File Offset: 0x004203F0
		public static Record_String_IRunningFlowInfo GetRootAsRecord_String_IRunningFlowInfo(ByteBuffer _bb)
		{
			return Record_String_IRunningFlowInfo.GetRootAsRecord_String_IRunningFlowInfo(_bb, default(Record_String_IRunningFlowInfo));
		}

		// Token: 0x0601D6EB RID: 120555 RVA: 0x0042220C File Offset: 0x0042040C
		public static Record_String_IRunningFlowInfo GetRootAsRecord_String_IRunningFlowInfo(ByteBuffer _bb, Record_String_IRunningFlowInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D6EC RID: 120556 RVA: 0x00422229 File Offset: 0x00420429
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D6ED RID: 120557 RVA: 0x00422238 File Offset: 0x00420438
		public Record_String_IRunningFlowInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170088A8 RID: 34984
		// (get) Token: 0x0601D6EE RID: 120558 RVA: 0x00422248 File Offset: 0x00420448
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

		// Token: 0x0601D6EF RID: 120559 RVA: 0x0042227F File Offset: 0x0042047F
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601D6F0 RID: 120560 RVA: 0x0042228E File Offset: 0x0042048E
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x170088A9 RID: 34985
		// (get) Token: 0x0601D6F1 RID: 120561 RVA: 0x0042229C File Offset: 0x0042049C
		public IRunningFlowInfo? Value
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IRunningFlowInfo?(default(IRunningFlowInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601D6F2 RID: 120562 RVA: 0x004222F9 File Offset: 0x004204F9
		public static Offset<Record_String_IRunningFlowInfo> CreateRecord_String_IRunningFlowInfo(FlatBufferBuilder builder, StringOffset KeyOffset = default(StringOffset), Offset<IRunningFlowInfo> ValueOffset = default(Offset<IRunningFlowInfo>))
		{
			builder.StartTable(2);
			Record_String_IRunningFlowInfo.AddValue(builder, ValueOffset);
			Record_String_IRunningFlowInfo.AddKey(builder, KeyOffset);
			return Record_String_IRunningFlowInfo.EndRecord_String_IRunningFlowInfo(builder);
		}

		// Token: 0x0601D6F3 RID: 120563 RVA: 0x00422316 File Offset: 0x00420516
		public static void StartRecord_String_IRunningFlowInfo(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601D6F4 RID: 120564 RVA: 0x0042231F File Offset: 0x0042051F
		public static void AddKey(FlatBufferBuilder builder, StringOffset keyOffset)
		{
			builder.AddOffset(0, keyOffset.Value, 0);
		}

		// Token: 0x0601D6F5 RID: 120565 RVA: 0x0042232F File Offset: 0x0042052F
		public static void AddValue(FlatBufferBuilder builder, Offset<IRunningFlowInfo> valueOffset)
		{
			builder.AddOffset(1, valueOffset.Value, 0);
		}

		// Token: 0x0601D6F6 RID: 120566 RVA: 0x0042233F File Offset: 0x0042053F
		public static Offset<Record_String_IRunningFlowInfo> EndRecord_String_IRunningFlowInfo(FlatBufferBuilder builder)
		{
			return new Offset<Record_String_IRunningFlowInfo>(builder.EndTable());
		}

		// Token: 0x0601D6F7 RID: 120567 RVA: 0x0042234C File Offset: 0x0042054C
		public Record_String_IRunningFlowInfoT UnPack()
		{
			Record_String_IRunningFlowInfoT record_String_IRunningFlowInfoT = new Record_String_IRunningFlowInfoT();
			this.UnPackTo(record_String_IRunningFlowInfoT);
			return record_String_IRunningFlowInfoT;
		}

		// Token: 0x0601D6F8 RID: 120568 RVA: 0x00422368 File Offset: 0x00420568
		public void UnPackTo(Record_String_IRunningFlowInfoT _o)
		{
			_o.Key = this.Key;
			_o.Value = ((this.Value != null) ? this.Value.Value.UnPack() : null);
		}

		// Token: 0x0601D6F9 RID: 120569 RVA: 0x004223B0 File Offset: 0x004205B0
		public static Offset<Record_String_IRunningFlowInfo> Pack(FlatBufferBuilder builder, Record_String_IRunningFlowInfoT _o)
		{
			if (_o == null)
			{
				return default(Offset<Record_String_IRunningFlowInfo>);
			}
			StringOffset keyOffset = (_o.Key == null) ? default(StringOffset) : builder.CreateString(_o.Key);
			Offset<IRunningFlowInfo> valueOffset = (_o.Value == null) ? default(Offset<IRunningFlowInfo>) : IRunningFlowInfo.Pack(builder, _o.Value);
			return Record_String_IRunningFlowInfo.CreateRecord_String_IRunningFlowInfo(builder, keyOffset, valueOffset);
		}

		// Token: 0x0400D419 RID: 54297
		private Table __p;
	}
}
