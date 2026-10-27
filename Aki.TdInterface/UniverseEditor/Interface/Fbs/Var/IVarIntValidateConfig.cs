using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003B0B RID: 15115
	public struct IVarIntValidateConfig : IFlatbufferObject
	{
		// Token: 0x170067B2 RID: 26546
		// (get) Token: 0x060149FD RID: 84477 RVA: 0x00300C10 File Offset: 0x002FEE10
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060149FE RID: 84478 RVA: 0x00300C1D File Offset: 0x002FEE1D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060149FF RID: 84479 RVA: 0x00300C24 File Offset: 0x002FEE24
		public static IVarIntValidateConfig GetRootAsIVarIntValidateConfig(ByteBuffer _bb)
		{
			return IVarIntValidateConfig.GetRootAsIVarIntValidateConfig(_bb, default(IVarIntValidateConfig));
		}

		// Token: 0x06014A00 RID: 84480 RVA: 0x00300C40 File Offset: 0x002FEE40
		public static IVarIntValidateConfig GetRootAsIVarIntValidateConfig(ByteBuffer _bb, IVarIntValidateConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06014A01 RID: 84481 RVA: 0x00300C5D File Offset: 0x002FEE5D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06014A02 RID: 84482 RVA: 0x00300C6C File Offset: 0x002FEE6C
		public IVarIntValidateConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170067B3 RID: 26547
		// (get) Token: 0x06014A03 RID: 84483 RVA: 0x00300C7C File Offset: 0x002FEE7C
		public EVar Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVar.Boolean;
				}
				return (EVar)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06014A04 RID: 84484 RVA: 0x00300CB8 File Offset: 0x002FEEB8
		public int ValidList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170067B4 RID: 26548
		// (get) Token: 0x06014A05 RID: 84485 RVA: 0x00300CF8 File Offset: 0x002FEEF8
		public int ValidListLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06014A06 RID: 84486 RVA: 0x00300D23 File Offset: 0x002FEF23
		public Span<int> GetValidListBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06014A07 RID: 84487 RVA: 0x00300D32 File Offset: 0x002FEF32
		public int[] GetValidListArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x170067B5 RID: 26549
		// (get) Token: 0x06014A08 RID: 84488 RVA: 0x00300D40 File Offset: 0x002FEF40
		public int MinValue
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170067B6 RID: 26550
		// (get) Token: 0x06014A09 RID: 84489 RVA: 0x00300D7C File Offset: 0x002FEF7C
		public int MaxValue
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170067B7 RID: 26551
		// (get) Token: 0x06014A0A RID: 84490 RVA: 0x00300DBC File Offset: 0x002FEFBC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06014A0B RID: 84491 RVA: 0x00300DF9 File Offset: 0x002FEFF9
		public static Offset<IVarIntValidateConfig> CreateIVarIntValidateConfig(FlatBufferBuilder builder, EVar Type = EVar.Boolean, VectorOffset ValidListOffset = default(VectorOffset), int MinValue = 0, int MaxValue = 0, byte NullMask = 0)
		{
			builder.StartTable(5);
			IVarIntValidateConfig.AddMaxValue(builder, MaxValue);
			IVarIntValidateConfig.AddMinValue(builder, MinValue);
			IVarIntValidateConfig.AddValidList(builder, ValidListOffset);
			IVarIntValidateConfig.AddNullMask(builder, NullMask);
			IVarIntValidateConfig.AddType(builder, Type);
			return IVarIntValidateConfig.EndIVarIntValidateConfig(builder);
		}

		// Token: 0x06014A0C RID: 84492 RVA: 0x00300E2D File Offset: 0x002FF02D
		public static void StartIVarIntValidateConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06014A0D RID: 84493 RVA: 0x00300E36 File Offset: 0x002FF036
		public static void AddType(FlatBufferBuilder builder, EVar type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06014A0E RID: 84494 RVA: 0x00300E41 File Offset: 0x002FF041
		public static void AddValidList(FlatBufferBuilder builder, VectorOffset validListOffset)
		{
			builder.AddOffset(1, validListOffset.Value, 0);
		}

		// Token: 0x06014A0F RID: 84495 RVA: 0x00300E54 File Offset: 0x002FF054
		public static VectorOffset CreateValidListVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06014A10 RID: 84496 RVA: 0x00300E8B File Offset: 0x002FF08B
		public static VectorOffset CreateValidListVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06014A11 RID: 84497 RVA: 0x00300EA5 File Offset: 0x002FF0A5
		public static VectorOffset CreateValidListVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06014A12 RID: 84498 RVA: 0x00300EC3 File Offset: 0x002FF0C3
		public static VectorOffset CreateValidListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06014A13 RID: 84499 RVA: 0x00300EDC File Offset: 0x002FF0DC
		public static void StartValidListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06014A14 RID: 84500 RVA: 0x00300EE7 File Offset: 0x002FF0E7
		public static void AddMinValue(FlatBufferBuilder builder, int minValue)
		{
			builder.AddInt(2, minValue, 0);
		}

		// Token: 0x06014A15 RID: 84501 RVA: 0x00300EF2 File Offset: 0x002FF0F2
		public static void AddMaxValue(FlatBufferBuilder builder, int maxValue)
		{
			builder.AddInt(3, maxValue, 0);
		}

		// Token: 0x06014A16 RID: 84502 RVA: 0x00300EFD File Offset: 0x002FF0FD
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06014A17 RID: 84503 RVA: 0x00300F08 File Offset: 0x002FF108
		public static Offset<IVarIntValidateConfig> EndIVarIntValidateConfig(FlatBufferBuilder builder)
		{
			return new Offset<IVarIntValidateConfig>(builder.EndTable());
		}

		// Token: 0x06014A18 RID: 84504 RVA: 0x00300F18 File Offset: 0x002FF118
		public IVarIntValidateConfigT UnPack()
		{
			IVarIntValidateConfigT varIntValidateConfigT = new IVarIntValidateConfigT();
			this.UnPackTo(varIntValidateConfigT);
			return varIntValidateConfigT;
		}

		// Token: 0x06014A19 RID: 84505 RVA: 0x00300F34 File Offset: 0x002FF134
		public void UnPackTo(IVarIntValidateConfigT _o)
		{
			_o.Type = this.Type;
			_o.ValidList = new List<int>();
			for (int i = 0; i < this.ValidListLength; i++)
			{
				_o.ValidList.Add(this.ValidList(i));
			}
			_o.MinValue = this.MinValue;
			_o.MaxValue = this.MaxValue;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06014A1A RID: 84506 RVA: 0x00300FA0 File Offset: 0x002FF1A0
		public static Offset<IVarIntValidateConfig> Pack(FlatBufferBuilder builder, IVarIntValidateConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVarIntValidateConfig>);
			}
			VectorOffset validListOffset = default(VectorOffset);
			if (_o.ValidList != null)
			{
				int[] data = _o.ValidList.ToArray();
				validListOffset = IVarIntValidateConfig.CreateValidListVector(builder, data);
			}
			return IVarIntValidateConfig.CreateIVarIntValidateConfig(builder, _o.Type, validListOffset, _o.MinValue, _o.MaxValue, _o.NullMask);
		}

		// Token: 0x0400AFD9 RID: 45017
		private Table __p;
	}
}
