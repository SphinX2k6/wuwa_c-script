using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F0D RID: 16141
	public struct IVarIntValidateConfig : IFlatbufferObject
	{
		// Token: 0x17006D4D RID: 27981
		// (get) Token: 0x06015EA7 RID: 89767 RVA: 0x00326EA0 File Offset: 0x003250A0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015EA8 RID: 89768 RVA: 0x00326EAD File Offset: 0x003250AD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015EA9 RID: 89769 RVA: 0x00326EB4 File Offset: 0x003250B4
		public static IVarIntValidateConfig GetRootAsIVarIntValidateConfig(ByteBuffer _bb)
		{
			return IVarIntValidateConfig.GetRootAsIVarIntValidateConfig(_bb, default(IVarIntValidateConfig));
		}

		// Token: 0x06015EAA RID: 89770 RVA: 0x00326ED0 File Offset: 0x003250D0
		public static IVarIntValidateConfig GetRootAsIVarIntValidateConfig(ByteBuffer _bb, IVarIntValidateConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015EAB RID: 89771 RVA: 0x00326EED File Offset: 0x003250ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015EAC RID: 89772 RVA: 0x00326EFC File Offset: 0x003250FC
		public IVarIntValidateConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006D4E RID: 27982
		// (get) Token: 0x06015EAD RID: 89773 RVA: 0x00326F0C File Offset: 0x0032510C
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

		// Token: 0x06015EAE RID: 89774 RVA: 0x00326F48 File Offset: 0x00325148
		public int ValidList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17006D4F RID: 27983
		// (get) Token: 0x06015EAF RID: 89775 RVA: 0x00326F88 File Offset: 0x00325188
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

		// Token: 0x06015EB0 RID: 89776 RVA: 0x00326FB3 File Offset: 0x003251B3
		public Span<int> GetValidListBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06015EB1 RID: 89777 RVA: 0x00326FC2 File Offset: 0x003251C2
		public int[] GetValidListArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x17006D50 RID: 27984
		// (get) Token: 0x06015EB2 RID: 89778 RVA: 0x00326FD0 File Offset: 0x003251D0
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

		// Token: 0x17006D51 RID: 27985
		// (get) Token: 0x06015EB3 RID: 89779 RVA: 0x0032700C File Offset: 0x0032520C
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

		// Token: 0x17006D52 RID: 27986
		// (get) Token: 0x06015EB4 RID: 89780 RVA: 0x0032704C File Offset: 0x0032524C
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

		// Token: 0x06015EB5 RID: 89781 RVA: 0x00327089 File Offset: 0x00325289
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

		// Token: 0x06015EB6 RID: 89782 RVA: 0x003270BD File Offset: 0x003252BD
		public static void StartIVarIntValidateConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06015EB7 RID: 89783 RVA: 0x003270C6 File Offset: 0x003252C6
		public static void AddType(FlatBufferBuilder builder, EVar type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015EB8 RID: 89784 RVA: 0x003270D1 File Offset: 0x003252D1
		public static void AddValidList(FlatBufferBuilder builder, VectorOffset validListOffset)
		{
			builder.AddOffset(1, validListOffset.Value, 0);
		}

		// Token: 0x06015EB9 RID: 89785 RVA: 0x003270E4 File Offset: 0x003252E4
		public static VectorOffset CreateValidListVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06015EBA RID: 89786 RVA: 0x0032711B File Offset: 0x0032531B
		public static VectorOffset CreateValidListVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06015EBB RID: 89787 RVA: 0x00327135 File Offset: 0x00325335
		public static VectorOffset CreateValidListVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06015EBC RID: 89788 RVA: 0x00327153 File Offset: 0x00325353
		public static VectorOffset CreateValidListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06015EBD RID: 89789 RVA: 0x0032716C File Offset: 0x0032536C
		public static void StartValidListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06015EBE RID: 89790 RVA: 0x00327177 File Offset: 0x00325377
		public static void AddMinValue(FlatBufferBuilder builder, int minValue)
		{
			builder.AddInt(2, minValue, 0);
		}

		// Token: 0x06015EBF RID: 89791 RVA: 0x00327182 File Offset: 0x00325382
		public static void AddMaxValue(FlatBufferBuilder builder, int maxValue)
		{
			builder.AddInt(3, maxValue, 0);
		}

		// Token: 0x06015EC0 RID: 89792 RVA: 0x0032718D File Offset: 0x0032538D
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06015EC1 RID: 89793 RVA: 0x00327198 File Offset: 0x00325398
		public static Offset<IVarIntValidateConfig> EndIVarIntValidateConfig(FlatBufferBuilder builder)
		{
			return new Offset<IVarIntValidateConfig>(builder.EndTable());
		}

		// Token: 0x06015EC2 RID: 89794 RVA: 0x003271A8 File Offset: 0x003253A8
		public IVarIntValidateConfigT UnPack()
		{
			IVarIntValidateConfigT varIntValidateConfigT = new IVarIntValidateConfigT();
			this.UnPackTo(varIntValidateConfigT);
			return varIntValidateConfigT;
		}

		// Token: 0x06015EC3 RID: 89795 RVA: 0x003271C4 File Offset: 0x003253C4
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

		// Token: 0x06015EC4 RID: 89796 RVA: 0x00327230 File Offset: 0x00325430
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

		// Token: 0x0400B946 RID: 47430
		private Table __p;
	}
}
