using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006ADC RID: 27356
	public struct ICommonBtPlaceholder : IFlatbufferObject
	{
		// Token: 0x1700C8DA RID: 51418
		// (get) Token: 0x0602EFF0 RID: 192496 RVA: 0x00668D10 File Offset: 0x00666F10
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EFF1 RID: 192497 RVA: 0x00668D1D File Offset: 0x00666F1D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602EFF2 RID: 192498 RVA: 0x00668D24 File Offset: 0x00666F24
		public static ICommonBtPlaceholder GetRootAsICommonBtPlaceholder(ByteBuffer _bb)
		{
			return ICommonBtPlaceholder.GetRootAsICommonBtPlaceholder(_bb, default(ICommonBtPlaceholder));
		}

		// Token: 0x0602EFF3 RID: 192499 RVA: 0x00668D40 File Offset: 0x00666F40
		public static ICommonBtPlaceholder GetRootAsICommonBtPlaceholder(ByteBuffer _bb, ICommonBtPlaceholder obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EFF4 RID: 192500 RVA: 0x00668D5D File Offset: 0x00666F5D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EFF5 RID: 192501 RVA: 0x00668D6C File Offset: 0x00666F6C
		public ICommonBtPlaceholder __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C8DB RID: 51419
		// (get) Token: 0x0602EFF6 RID: 192502 RVA: 0x00668D7C File Offset: 0x00666F7C
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

		// Token: 0x1700C8DC RID: 51420
		// (get) Token: 0x0602EFF7 RID: 192503 RVA: 0x00668DB8 File Offset: 0x00666FB8
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

		// Token: 0x0602EFF8 RID: 192504 RVA: 0x00668DEF File Offset: 0x00666FEF
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602EFF9 RID: 192505 RVA: 0x00668DFE File Offset: 0x00666FFE
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700C8DD RID: 51421
		// (get) Token: 0x0602EFFA RID: 192506 RVA: 0x00668E0C File Offset: 0x0066700C
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

		// Token: 0x0602EFFB RID: 192507 RVA: 0x00668E48 File Offset: 0x00667048
		public TTable? Value<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602EFFC RID: 192508 RVA: 0x00668E90 File Offset: 0x00667090
		public ICommonBtOverrideActionInfo ValueAsICommonBtOverrideActionInfo()
		{
			return this.Value<ICommonBtOverrideActionInfo>().Value;
		}

		// Token: 0x0602EFFD RID: 192509 RVA: 0x00668EAC File Offset: 0x006670AC
		public ICommonBtOverrideConditionInfo ValueAsICommonBtOverrideConditionInfo()
		{
			return this.Value<ICommonBtOverrideConditionInfo>().Value;
		}

		// Token: 0x0602EFFE RID: 192510 RVA: 0x00668EC8 File Offset: 0x006670C8
		public int RefTaskIds(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700C8DE RID: 51422
		// (get) Token: 0x0602EFFF RID: 192511 RVA: 0x00668F08 File Offset: 0x00667108
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

		// Token: 0x0602F000 RID: 192512 RVA: 0x00668F34 File Offset: 0x00667134
		public Span<int> GetRefTaskIdsBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0602F001 RID: 192513 RVA: 0x00668F44 File Offset: 0x00667144
		public int[] GetRefTaskIdsArray()
		{
			return this.__p.__vector_as_array<int>(12);
		}

		// Token: 0x0602F002 RID: 192514 RVA: 0x00668F53 File Offset: 0x00667153
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

		// Token: 0x0602F003 RID: 192515 RVA: 0x00668F87 File Offset: 0x00667187
		public static void StartICommonBtPlaceholder(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602F004 RID: 192516 RVA: 0x00668F90 File Offset: 0x00667190
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0602F005 RID: 192517 RVA: 0x00668F9B File Offset: 0x0066719B
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(1, nameOffset.Value, 0);
		}

		// Token: 0x0602F006 RID: 192518 RVA: 0x00668FAB File Offset: 0x006671AB
		public static void AddValueType(FlatBufferBuilder builder, TCommonBtPlaceholderValue valueType)
		{
			builder.AddByte(2, (byte)valueType, 0);
		}

		// Token: 0x0602F007 RID: 192519 RVA: 0x00668FB6 File Offset: 0x006671B6
		public static void AddValue(FlatBufferBuilder builder, int valueOffset)
		{
			builder.AddOffset(3, valueOffset, 0);
		}

		// Token: 0x0602F008 RID: 192520 RVA: 0x00668FC1 File Offset: 0x006671C1
		public static void AddRefTaskIds(FlatBufferBuilder builder, VectorOffset refTaskIdsOffset)
		{
			builder.AddOffset(4, refTaskIdsOffset.Value, 0);
		}

		// Token: 0x0602F009 RID: 192521 RVA: 0x00668FD4 File Offset: 0x006671D4
		public static VectorOffset CreateRefTaskIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602F00A RID: 192522 RVA: 0x0066900B File Offset: 0x0066720B
		public static VectorOffset CreateRefTaskIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602F00B RID: 192523 RVA: 0x00669025 File Offset: 0x00667225
		public static VectorOffset CreateRefTaskIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602F00C RID: 192524 RVA: 0x00669043 File Offset: 0x00667243
		public static VectorOffset CreateRefTaskIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602F00D RID: 192525 RVA: 0x0066905C File Offset: 0x0066725C
		public static void StartRefTaskIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602F00E RID: 192526 RVA: 0x00669067 File Offset: 0x00667267
		public static Offset<ICommonBtPlaceholder> EndICommonBtPlaceholder(FlatBufferBuilder builder)
		{
			return new Offset<ICommonBtPlaceholder>(builder.EndTable());
		}

		// Token: 0x0602F00F RID: 192527 RVA: 0x00669074 File Offset: 0x00667274
		public ICommonBtPlaceholderT UnPack()
		{
			ICommonBtPlaceholderT commonBtPlaceholderT = new ICommonBtPlaceholderT();
			this.UnPackTo(commonBtPlaceholderT);
			return commonBtPlaceholderT;
		}

		// Token: 0x0602F010 RID: 192528 RVA: 0x00669090 File Offset: 0x00667290
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

		// Token: 0x0602F011 RID: 192529 RVA: 0x00669180 File Offset: 0x00667380
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

		// Token: 0x04011880 RID: 71808
		private Table __p;
	}
}
