using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006474 RID: 25716
	public struct ICommonBtPlaceholder : IFlatbufferObject
	{
		// Token: 0x1700BF58 RID: 48984
		// (get) Token: 0x0602C89F RID: 182431 RVA: 0x0061D704 File Offset: 0x0061B904
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C8A0 RID: 182432 RVA: 0x0061D711 File Offset: 0x0061B911
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C8A1 RID: 182433 RVA: 0x0061D718 File Offset: 0x0061B918
		public static ICommonBtPlaceholder GetRootAsICommonBtPlaceholder(ByteBuffer _bb)
		{
			return ICommonBtPlaceholder.GetRootAsICommonBtPlaceholder(_bb, default(ICommonBtPlaceholder));
		}

		// Token: 0x0602C8A2 RID: 182434 RVA: 0x0061D734 File Offset: 0x0061B934
		public static ICommonBtPlaceholder GetRootAsICommonBtPlaceholder(ByteBuffer _bb, ICommonBtPlaceholder obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C8A3 RID: 182435 RVA: 0x0061D751 File Offset: 0x0061B951
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C8A4 RID: 182436 RVA: 0x0061D760 File Offset: 0x0061B960
		public ICommonBtPlaceholder __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BF59 RID: 48985
		// (get) Token: 0x0602C8A5 RID: 182437 RVA: 0x0061D770 File Offset: 0x0061B970
		public int Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BF5A RID: 48986
		// (get) Token: 0x0602C8A6 RID: 182438 RVA: 0x0061D7AC File Offset: 0x0061B9AC
		public string Name
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

		// Token: 0x0602C8A7 RID: 182439 RVA: 0x0061D7E3 File Offset: 0x0061B9E3
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602C8A8 RID: 182440 RVA: 0x0061D7F2 File Offset: 0x0061B9F2
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700BF5B RID: 48987
		// (get) Token: 0x0602C8A9 RID: 182441 RVA: 0x0061D800 File Offset: 0x0061BA00
		public TCommonBtPlaceholderValue ValueType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TCommonBtPlaceholderValue.NONE;
				}
				return (TCommonBtPlaceholderValue)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602C8AA RID: 182442 RVA: 0x0061D83C File Offset: 0x0061BA3C
		public TTable? Value<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602C8AB RID: 182443 RVA: 0x0061D884 File Offset: 0x0061BA84
		public ICommonBtOverrideActionInfo ValueAsICommonBtOverrideActionInfo()
		{
			return this.Value<ICommonBtOverrideActionInfo>().Value;
		}

		// Token: 0x0602C8AC RID: 182444 RVA: 0x0061D8A0 File Offset: 0x0061BAA0
		public ICommonBtOverrideConditionInfo ValueAsICommonBtOverrideConditionInfo()
		{
			return this.Value<ICommonBtOverrideConditionInfo>().Value;
		}

		// Token: 0x0602C8AD RID: 182445 RVA: 0x0061D8BC File Offset: 0x0061BABC
		public int RefTaskIds(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700BF5C RID: 48988
		// (get) Token: 0x0602C8AE RID: 182446 RVA: 0x0061D8FC File Offset: 0x0061BAFC
		public int RefTaskIdsLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0602C8AF RID: 182447 RVA: 0x0061D928 File Offset: 0x0061BB28
		public Span<int> GetRefTaskIdsBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0602C8B0 RID: 182448 RVA: 0x0061D938 File Offset: 0x0061BB38
		public int[] GetRefTaskIdsArray()
		{
			return this.__p.__vector_as_array<int>(12);
		}

		// Token: 0x0602C8B1 RID: 182449 RVA: 0x0061D947 File Offset: 0x0061BB47
		public static Offset<ICommonBtPlaceholder> CreateICommonBtPlaceholder(FlatBufferBuilder builder, int Id = 0, StringOffset NameOffset = default(StringOffset), TCommonBtPlaceholderValue Value_type = TCommonBtPlaceholderValue.NONE, int ValueOffset = 0, VectorOffset RefTaskIdsOffset = default(VectorOffset))
		{
			builder.StartTable(5);
			ICommonBtPlaceholder.AddRefTaskIds(builder, RefTaskIdsOffset);
			ICommonBtPlaceholder.AddValue(builder, ValueOffset);
			ICommonBtPlaceholder.AddName(builder, NameOffset);
			ICommonBtPlaceholder.AddId(builder, Id);
			ICommonBtPlaceholder.AddValueType(builder, Value_type);
			return ICommonBtPlaceholder.EndICommonBtPlaceholder(builder);
		}

		// Token: 0x0602C8B2 RID: 182450 RVA: 0x0061D97B File Offset: 0x0061BB7B
		public static void StartICommonBtPlaceholder(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602C8B3 RID: 182451 RVA: 0x0061D984 File Offset: 0x0061BB84
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0602C8B4 RID: 182452 RVA: 0x0061D98F File Offset: 0x0061BB8F
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(1, nameOffset.Value, 0);
		}

		// Token: 0x0602C8B5 RID: 182453 RVA: 0x0061D99F File Offset: 0x0061BB9F
		public static void AddValueType(FlatBufferBuilder builder, TCommonBtPlaceholderValue valueType)
		{
			builder.AddByte(2, (byte)valueType, 0);
		}

		// Token: 0x0602C8B6 RID: 182454 RVA: 0x0061D9AA File Offset: 0x0061BBAA
		public static void AddValue(FlatBufferBuilder builder, int valueOffset)
		{
			builder.AddOffset(3, valueOffset, 0);
		}

		// Token: 0x0602C8B7 RID: 182455 RVA: 0x0061D9B5 File Offset: 0x0061BBB5
		public static void AddRefTaskIds(FlatBufferBuilder builder, VectorOffset refTaskIdsOffset)
		{
			builder.AddOffset(4, refTaskIdsOffset.Value, 0);
		}

		// Token: 0x0602C8B8 RID: 182456 RVA: 0x0061D9C8 File Offset: 0x0061BBC8
		public static VectorOffset CreateRefTaskIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602C8B9 RID: 182457 RVA: 0x0061D9FF File Offset: 0x0061BBFF
		public static VectorOffset CreateRefTaskIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602C8BA RID: 182458 RVA: 0x0061DA19 File Offset: 0x0061BC19
		public static VectorOffset CreateRefTaskIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602C8BB RID: 182459 RVA: 0x0061DA37 File Offset: 0x0061BC37
		public static VectorOffset CreateRefTaskIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602C8BC RID: 182460 RVA: 0x0061DA50 File Offset: 0x0061BC50
		public static void StartRefTaskIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602C8BD RID: 182461 RVA: 0x0061DA5B File Offset: 0x0061BC5B
		public static Offset<ICommonBtPlaceholder> EndICommonBtPlaceholder(FlatBufferBuilder builder)
		{
			return new Offset<ICommonBtPlaceholder>(builder.EndTable());
		}

		// Token: 0x0602C8BE RID: 182462 RVA: 0x0061DA68 File Offset: 0x0061BC68
		public ICommonBtPlaceholderT UnPack()
		{
			ICommonBtPlaceholderT commonBtPlaceholderT = new ICommonBtPlaceholderT();
			this.UnPackTo(commonBtPlaceholderT);
			return commonBtPlaceholderT;
		}

		// Token: 0x0602C8BF RID: 182463 RVA: 0x0061DA84 File Offset: 0x0061BC84
		public void UnPackTo(ICommonBtPlaceholderT _o)
		{
			_o.Id = this.Id;
			_o.Name = this.Name;
			_o.Value = new TCommonBtPlaceholderValueUnion();
			_o.Value.Type = this.ValueType;
			TCommonBtPlaceholderValue valueType = this.ValueType;
			if (valueType != TCommonBtPlaceholderValue.ICommonBtOverrideActionInfo)
			{
				if (valueType == TCommonBtPlaceholderValue.ICommonBtOverrideConditionInfo)
				{
					_o.Value.Value = ((this.Value<ICommonBtOverrideConditionInfo>() != null) ? this.Value<ICommonBtOverrideConditionInfo>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.Value.Value = ((this.Value<ICommonBtOverrideActionInfo>() != null) ? this.Value<ICommonBtOverrideActionInfo>().Value.UnPack() : null);
			}
			_o.RefTaskIds = new List<int>();
			for (int i = 0; i < this.RefTaskIdsLength; i++)
			{
				_o.RefTaskIds.Add(this.RefTaskIds(i));
			}
		}

		// Token: 0x0602C8C0 RID: 182464 RVA: 0x0061DB74 File Offset: 0x0061BD74
		public static Offset<ICommonBtPlaceholder> Pack(FlatBufferBuilder builder, ICommonBtPlaceholderT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonBtPlaceholder>);
			}
			StringOffset nameOffset = (_o.Name == null) ? default(StringOffset) : builder.CreateString(_o.Name);
			TCommonBtPlaceholderValue value_type = (_o.Value == null) ? TCommonBtPlaceholderValue.NONE : _o.Value.Type;
			int valueOffset = (_o.Value == null) ? 0 : TCommonBtPlaceholderValueUnion.Pack(builder, _o.Value);
			VectorOffset refTaskIdsOffset = default(VectorOffset);
			if (_o.RefTaskIds != null)
			{
				int[] data = _o.RefTaskIds.ToArray();
				refTaskIdsOffset = ICommonBtPlaceholder.CreateRefTaskIdsVector(builder, data);
			}
			return ICommonBtPlaceholder.CreateICommonBtPlaceholder(builder, _o.Id, nameOffset, value_type, valueOffset, refTaskIdsOffset);
		}

		// Token: 0x04010A75 RID: 68213
		private Table __p;
	}
}
