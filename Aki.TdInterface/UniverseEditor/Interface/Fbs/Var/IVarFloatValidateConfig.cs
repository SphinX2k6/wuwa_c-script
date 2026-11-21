using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F07 RID: 16135
	public struct IVarFloatValidateConfig : IFlatbufferObject
	{
		// Token: 0x17006D3D RID: 27965
		// (get) Token: 0x06015E59 RID: 89689 RVA: 0x00326281 File Offset: 0x00324481
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015E5A RID: 89690 RVA: 0x0032628E File Offset: 0x0032448E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015E5B RID: 89691 RVA: 0x00326298 File Offset: 0x00324498
		public static IVarFloatValidateConfig GetRootAsIVarFloatValidateConfig(ByteBuffer _bb)
		{
			return IVarFloatValidateConfig.GetRootAsIVarFloatValidateConfig(_bb, default(IVarFloatValidateConfig));
		}

		// Token: 0x06015E5C RID: 89692 RVA: 0x003262B4 File Offset: 0x003244B4
		public static IVarFloatValidateConfig GetRootAsIVarFloatValidateConfig(ByteBuffer _bb, IVarFloatValidateConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015E5D RID: 89693 RVA: 0x003262D1 File Offset: 0x003244D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015E5E RID: 89694 RVA: 0x003262E0 File Offset: 0x003244E0
		public IVarFloatValidateConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006D3E RID: 27966
		// (get) Token: 0x06015E5F RID: 89695 RVA: 0x003262F0 File Offset: 0x003244F0
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

		// Token: 0x06015E60 RID: 89696 RVA: 0x0032632C File Offset: 0x0032452C
		public float ValidList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17006D3F RID: 27967
		// (get) Token: 0x06015E61 RID: 89697 RVA: 0x00326370 File Offset: 0x00324570
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

		// Token: 0x06015E62 RID: 89698 RVA: 0x0032639B File Offset: 0x0032459B
		public Span<float> GetValidListBytes()
		{
			return this.__p.__vector_as_span<float>(6, 4);
		}

		// Token: 0x06015E63 RID: 89699 RVA: 0x003263AA File Offset: 0x003245AA
		public float[] GetValidListArray()
		{
			return this.__p.__vector_as_array<float>(6);
		}

		// Token: 0x17006D40 RID: 27968
		// (get) Token: 0x06015E64 RID: 89700 RVA: 0x003263B8 File Offset: 0x003245B8
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

		// Token: 0x17006D41 RID: 27969
		// (get) Token: 0x06015E65 RID: 89701 RVA: 0x003263F8 File Offset: 0x003245F8
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

		// Token: 0x17006D42 RID: 27970
		// (get) Token: 0x06015E66 RID: 89702 RVA: 0x0032643C File Offset: 0x0032463C
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

		// Token: 0x06015E67 RID: 89703 RVA: 0x00326479 File Offset: 0x00324679
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

		// Token: 0x06015E68 RID: 89704 RVA: 0x003264AD File Offset: 0x003246AD
		public static void StartIVarFloatValidateConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06015E69 RID: 89705 RVA: 0x003264B6 File Offset: 0x003246B6
		public static void AddType(FlatBufferBuilder builder, EVar type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015E6A RID: 89706 RVA: 0x003264C1 File Offset: 0x003246C1
		public static void AddValidList(FlatBufferBuilder builder, VectorOffset validListOffset)
		{
			builder.AddOffset(1, validListOffset.Value, 0);
		}

		// Token: 0x06015E6B RID: 89707 RVA: 0x003264D4 File Offset: 0x003246D4
		public static VectorOffset CreateValidListVector(FlatBufferBuilder builder, float[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddFloat(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06015E6C RID: 89708 RVA: 0x0032650B File Offset: 0x0032470B
		public static VectorOffset CreateValidListVectorBlock(FlatBufferBuilder builder, float[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<float>(data);
			return builder.EndVector();
		}

		// Token: 0x06015E6D RID: 89709 RVA: 0x00326525 File Offset: 0x00324725
		public static VectorOffset CreateValidListVectorBlock(FlatBufferBuilder builder, ArraySegment<float> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<float>(data);
			return builder.EndVector();
		}

		// Token: 0x06015E6E RID: 89710 RVA: 0x00326543 File Offset: 0x00324743
		public static VectorOffset CreateValidListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<float>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06015E6F RID: 89711 RVA: 0x0032655C File Offset: 0x0032475C
		public static void StartValidListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06015E70 RID: 89712 RVA: 0x00326567 File Offset: 0x00324767
		public static void AddMinValue(FlatBufferBuilder builder, float minValue)
		{
			builder.AddFloat(2, minValue, 0.0);
		}

		// Token: 0x06015E71 RID: 89713 RVA: 0x0032657A File Offset: 0x0032477A
		public static void AddMaxValue(FlatBufferBuilder builder, float maxValue)
		{
			builder.AddFloat(3, maxValue, 0.0);
		}

		// Token: 0x06015E72 RID: 89714 RVA: 0x0032658D File Offset: 0x0032478D
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06015E73 RID: 89715 RVA: 0x00326598 File Offset: 0x00324798
		public static Offset<IVarFloatValidateConfig> EndIVarFloatValidateConfig(FlatBufferBuilder builder)
		{
			return new Offset<IVarFloatValidateConfig>(builder.EndTable());
		}

		// Token: 0x06015E74 RID: 89716 RVA: 0x003265A8 File Offset: 0x003247A8
		public IVarFloatValidateConfigT UnPack()
		{
			IVarFloatValidateConfigT varFloatValidateConfigT = new IVarFloatValidateConfigT();
			this.UnPackTo(varFloatValidateConfigT);
			return varFloatValidateConfigT;
		}

		// Token: 0x06015E75 RID: 89717 RVA: 0x003265C4 File Offset: 0x003247C4
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

		// Token: 0x06015E76 RID: 89718 RVA: 0x00326630 File Offset: 0x00324830
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

		// Token: 0x0400B93D RID: 47421
		private Table __p;
	}
}
