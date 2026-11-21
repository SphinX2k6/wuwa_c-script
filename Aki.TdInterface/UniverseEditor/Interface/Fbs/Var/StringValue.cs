using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F49 RID: 16201
	public struct StringValue : IFlatbufferObject
	{
		// Token: 0x17006DB3 RID: 28083
		// (get) Token: 0x0601608F RID: 90255 RVA: 0x0032A194 File Offset: 0x00328394
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016090 RID: 90256 RVA: 0x0032A1A1 File Offset: 0x003283A1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016091 RID: 90257 RVA: 0x0032A1A8 File Offset: 0x003283A8
		public static StringValue GetRootAsStringValue(ByteBuffer _bb)
		{
			return StringValue.GetRootAsStringValue(_bb, default(StringValue));
		}

		// Token: 0x06016092 RID: 90258 RVA: 0x0032A1C4 File Offset: 0x003283C4
		public static StringValue GetRootAsStringValue(ByteBuffer _bb, StringValue obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016093 RID: 90259 RVA: 0x0032A1E1 File Offset: 0x003283E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016094 RID: 90260 RVA: 0x0032A1F0 File Offset: 0x003283F0
		public StringValue __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006DB4 RID: 28084
		// (get) Token: 0x06016095 RID: 90261 RVA: 0x0032A200 File Offset: 0x00328400
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

		// Token: 0x06016096 RID: 90262 RVA: 0x0032A237 File Offset: 0x00328437
		public Span<byte> GetValueBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06016097 RID: 90263 RVA: 0x0032A246 File Offset: 0x00328446
		public byte[] GetValueArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x06016098 RID: 90264 RVA: 0x0032A254 File Offset: 0x00328454
		public static Offset<StringValue> CreateStringValue(FlatBufferBuilder builder, StringOffset valueOffset = default(StringOffset))
		{
			builder.StartTable(1);
			StringValue.AddValue(builder, valueOffset);
			return StringValue.EndStringValue(builder);
		}

		// Token: 0x06016099 RID: 90265 RVA: 0x0032A26A File Offset: 0x0032846A
		public static void StartStringValue(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601609A RID: 90266 RVA: 0x0032A273 File Offset: 0x00328473
		public static void AddValue(FlatBufferBuilder builder, StringOffset valueOffset)
		{
			builder.AddOffset(0, valueOffset.Value, 0);
		}

		// Token: 0x0601609B RID: 90267 RVA: 0x0032A283 File Offset: 0x00328483
		public static Offset<StringValue> EndStringValue(FlatBufferBuilder builder)
		{
			return new Offset<StringValue>(builder.EndTable());
		}

		// Token: 0x0601609C RID: 90268 RVA: 0x0032A290 File Offset: 0x00328490
		public StringValueT UnPack()
		{
			StringValueT stringValueT = new StringValueT();
			this.UnPackTo(stringValueT);
			return stringValueT;
		}

		// Token: 0x0601609D RID: 90269 RVA: 0x0032A2AB File Offset: 0x003284AB
		public void UnPackTo(StringValueT _o)
		{
			_o.Value = this.Value;
		}

		// Token: 0x0601609E RID: 90270 RVA: 0x0032A2BC File Offset: 0x003284BC
		public static Offset<StringValue> Pack(FlatBufferBuilder builder, StringValueT _o)
		{
			if (_o == null)
			{
				return default(Offset<StringValue>);
			}
			StringOffset valueOffset = (_o.Value == null) ? default(StringOffset) : builder.CreateString(_o.Value);
			return StringValue.CreateStringValue(builder, valueOffset);
		}

		// Token: 0x0400B995 RID: 47509
		private Table __p;
	}
}
