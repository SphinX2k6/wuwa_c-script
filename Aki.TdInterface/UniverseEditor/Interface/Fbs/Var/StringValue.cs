using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003B47 RID: 15175
	public struct StringValue : IFlatbufferObject
	{
		// Token: 0x17006818 RID: 26648
		// (get) Token: 0x06014BE5 RID: 84965 RVA: 0x00303F04 File Offset: 0x00302104
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06014BE6 RID: 84966 RVA: 0x00303F11 File Offset: 0x00302111
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06014BE7 RID: 84967 RVA: 0x00303F18 File Offset: 0x00302118
		public static StringValue GetRootAsStringValue(ByteBuffer _bb)
		{
			return StringValue.GetRootAsStringValue(_bb, default(StringValue));
		}

		// Token: 0x06014BE8 RID: 84968 RVA: 0x00303F34 File Offset: 0x00302134
		public static StringValue GetRootAsStringValue(ByteBuffer _bb, StringValue obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06014BE9 RID: 84969 RVA: 0x00303F51 File Offset: 0x00302151
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06014BEA RID: 84970 RVA: 0x00303F60 File Offset: 0x00302160
		public StringValue __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006819 RID: 26649
		// (get) Token: 0x06014BEB RID: 84971 RVA: 0x00303F70 File Offset: 0x00302170
		public string Value
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

		// Token: 0x06014BEC RID: 84972 RVA: 0x00303FA7 File Offset: 0x003021A7
		public Span<byte> GetValueBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06014BED RID: 84973 RVA: 0x00303FB6 File Offset: 0x003021B6
		public byte[] GetValueArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x06014BEE RID: 84974 RVA: 0x00303FC4 File Offset: 0x003021C4
		public static Offset<StringValue> CreateStringValue(FlatBufferBuilder builder, StringOffset valueOffset = default(StringOffset))
		{
			builder.StartTable(1);
			StringValue.AddValue(builder, valueOffset);
			return StringValue.EndStringValue(builder);
		}

		// Token: 0x06014BEF RID: 84975 RVA: 0x00303FDA File Offset: 0x003021DA
		public static void StartStringValue(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06014BF0 RID: 84976 RVA: 0x00303FE3 File Offset: 0x003021E3
		public static void AddValue(FlatBufferBuilder builder, StringOffset valueOffset)
		{
			builder.AddOffset(0, valueOffset.Value, 0);
		}

		// Token: 0x06014BF1 RID: 84977 RVA: 0x00303FF3 File Offset: 0x003021F3
		public static Offset<StringValue> EndStringValue(FlatBufferBuilder builder)
		{
			return new Offset<StringValue>(builder.EndTable());
		}

		// Token: 0x06014BF2 RID: 84978 RVA: 0x00304000 File Offset: 0x00302200
		public StringValueT UnPack()
		{
			StringValueT stringValueT = new StringValueT();
			this.UnPackTo(stringValueT);
			return stringValueT;
		}

		// Token: 0x06014BF3 RID: 84979 RVA: 0x0030401B File Offset: 0x0030221B
		public void UnPackTo(StringValueT _o)
		{
			_o.Value = this.Value;
		}

		// Token: 0x06014BF4 RID: 84980 RVA: 0x0030402C File Offset: 0x0030222C
		public static Offset<StringValue> Pack(FlatBufferBuilder builder, StringValueT _o)
		{
			if (_o == null)
			{
				return default(Offset<StringValue>);
			}
			StringOffset valueOffset = (_o.Value == null) ? default(StringOffset) : builder.CreateString(_o.Value);
			return StringValue.CreateStringValue(builder, valueOffset);
		}

		// Token: 0x0400B028 RID: 45096
		private Table __p;
	}
}
