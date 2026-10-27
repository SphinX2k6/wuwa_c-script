using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003B05 RID: 15109
	public struct IVarFloatValidateConfig : IFlatbufferObject
	{
		// Token: 0x170067A2 RID: 26530
		// (get) Token: 0x060149AF RID: 84399 RVA: 0x002FFFF1 File Offset: 0x002FE1F1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060149B0 RID: 84400 RVA: 0x002FFFFE File Offset: 0x002FE1FE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060149B1 RID: 84401 RVA: 0x00300008 File Offset: 0x002FE208
		public static IVarFloatValidateConfig GetRootAsIVarFloatValidateConfig(ByteBuffer _bb)
		{
			return IVarFloatValidateConfig.GetRootAsIVarFloatValidateConfig(_bb, default(IVarFloatValidateConfig));
		}

		// Token: 0x060149B2 RID: 84402 RVA: 0x00300024 File Offset: 0x002FE224
		public static IVarFloatValidateConfig GetRootAsIVarFloatValidateConfig(ByteBuffer _bb, IVarFloatValidateConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060149B3 RID: 84403 RVA: 0x00300041 File Offset: 0x002FE241
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060149B4 RID: 84404 RVA: 0x00300050 File Offset: 0x002FE250
		public IVarFloatValidateConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170067A3 RID: 26531
		// (get) Token: 0x060149B5 RID: 84405 RVA: 0x00300060 File Offset: 0x002FE260
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

		// Token: 0x060149B6 RID: 84406 RVA: 0x0030009C File Offset: 0x002FE29C
		public float ValidList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170067A4 RID: 26532
		// (get) Token: 0x060149B7 RID: 84407 RVA: 0x003000E0 File Offset: 0x002FE2E0
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

		// Token: 0x060149B8 RID: 84408 RVA: 0x0030010B File Offset: 0x002FE30B
		public Span<float> GetValidListBytes()
		{
			return this.__p.__vector_as_span<float>(6, 4);
		}

		// Token: 0x060149B9 RID: 84409 RVA: 0x0030011A File Offset: 0x002FE31A
		public float[] GetValidListArray()
		{
			return this.__p.__vector_as_array<float>(6);
		}

		// Token: 0x170067A5 RID: 26533
		// (get) Token: 0x060149BA RID: 84410 RVA: 0x00300128 File Offset: 0x002FE328
		public float MinValue
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170067A6 RID: 26534
		// (get) Token: 0x060149BB RID: 84411 RVA: 0x00300168 File Offset: 0x002FE368
		public float MaxValue
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170067A7 RID: 26535
		// (get) Token: 0x060149BC RID: 84412 RVA: 0x003001AC File Offset: 0x002FE3AC
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

		// Token: 0x060149BD RID: 84413 RVA: 0x003001E9 File Offset: 0x002FE3E9
		public static Offset<IVarFloatValidateConfig> CreateIVarFloatValidateConfig(FlatBufferBuilder builder, EVar Type = EVar.Boolean, VectorOffset ValidListOffset = default(VectorOffset), float MinValue = 0f, float MaxValue = 0f, byte NullMask = 0)
		{
			builder.StartTable(5);
			IVarFloatValidateConfig.AddMaxValue(builder, MaxValue);
			IVarFloatValidateConfig.AddMinValue(builder, MinValue);
			IVarFloatValidateConfig.AddValidList(builder, ValidListOffset);
			IVarFloatValidateConfig.AddNullMask(builder, NullMask);
			IVarFloatValidateConfig.AddType(builder, Type);
			return IVarFloatValidateConfig.EndIVarFloatValidateConfig(builder);
		}

		// Token: 0x060149BE RID: 84414 RVA: 0x0030021D File Offset: 0x002FE41D
		public static void StartIVarFloatValidateConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x060149BF RID: 84415 RVA: 0x00300226 File Offset: 0x002FE426
		public static void AddType(FlatBufferBuilder builder, EVar type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060149C0 RID: 84416 RVA: 0x00300231 File Offset: 0x002FE431
		public static void AddValidList(FlatBufferBuilder builder, VectorOffset validListOffset)
		{
			builder.AddOffset(1, validListOffset.Value, 0);
		}

		// Token: 0x060149C1 RID: 84417 RVA: 0x00300244 File Offset: 0x002FE444
		public static VectorOffset CreateValidListVector(FlatBufferBuilder builder, float[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddFloat(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060149C2 RID: 84418 RVA: 0x0030027B File Offset: 0x002FE47B
		public static VectorOffset CreateValidListVectorBlock(FlatBufferBuilder builder, float[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<float>(data);
			return builder.EndVector();
		}

		// Token: 0x060149C3 RID: 84419 RVA: 0x00300295 File Offset: 0x002FE495
		public static VectorOffset CreateValidListVectorBlock(FlatBufferBuilder builder, ArraySegment<float> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<float>(data);
			return builder.EndVector();
		}

		// Token: 0x060149C4 RID: 84420 RVA: 0x003002B3 File Offset: 0x002FE4B3
		public static VectorOffset CreateValidListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<float>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060149C5 RID: 84421 RVA: 0x003002CC File Offset: 0x002FE4CC
		public static void StartValidListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060149C6 RID: 84422 RVA: 0x003002D7 File Offset: 0x002FE4D7
		public static void AddMinValue(FlatBufferBuilder builder, float minValue)
		{
			builder.AddFloat(2, minValue, 0.0);
		}

		// Token: 0x060149C7 RID: 84423 RVA: 0x003002EA File Offset: 0x002FE4EA
		public static void AddMaxValue(FlatBufferBuilder builder, float maxValue)
		{
			builder.AddFloat(3, maxValue, 0.0);
		}

		// Token: 0x060149C8 RID: 84424 RVA: 0x003002FD File Offset: 0x002FE4FD
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x060149C9 RID: 84425 RVA: 0x00300308 File Offset: 0x002FE508
		public static Offset<IVarFloatValidateConfig> EndIVarFloatValidateConfig(FlatBufferBuilder builder)
		{
			return new Offset<IVarFloatValidateConfig>(builder.EndTable());
		}

		// Token: 0x060149CA RID: 84426 RVA: 0x00300318 File Offset: 0x002FE518
		public IVarFloatValidateConfigT UnPack()
		{
			IVarFloatValidateConfigT varFloatValidateConfigT = new IVarFloatValidateConfigT();
			this.UnPackTo(varFloatValidateConfigT);
			return varFloatValidateConfigT;
		}

		// Token: 0x060149CB RID: 84427 RVA: 0x00300334 File Offset: 0x002FE534
		public void UnPackTo(IVarFloatValidateConfigT _o)
		{
			_o.Type = this.Type;
			_o.ValidList = new List<float>();
			for (int i = 0; i < this.ValidListLength; i++)
			{
				_o.ValidList.Add(this.ValidList(i));
			}
			_o.MinValue = this.MinValue;
			_o.MaxValue = this.MaxValue;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060149CC RID: 84428 RVA: 0x003003A0 File Offset: 0x002FE5A0
		public static Offset<IVarFloatValidateConfig> Pack(FlatBufferBuilder builder, IVarFloatValidateConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVarFloatValidateConfig>);
			}
			VectorOffset validListOffset = default(VectorOffset);
			if (_o.ValidList != null)
			{
				float[] data = _o.ValidList.ToArray();
				validListOffset = IVarFloatValidateConfig.CreateValidListVector(builder, data);
			}
			return IVarFloatValidateConfig.CreateIVarFloatValidateConfig(builder, _o.Type, validListOffset, _o.MinValue, _o.MaxValue, _o.NullMask);
		}

		// Token: 0x0400AFD0 RID: 45008
		private Table __p;
	}
}
