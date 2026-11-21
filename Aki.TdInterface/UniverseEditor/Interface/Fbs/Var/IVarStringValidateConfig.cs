using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F1C RID: 16156
	public struct IVarStringValidateConfig : IFlatbufferObject
	{
		// Token: 0x17006D66 RID: 28006
		// (get) Token: 0x06015F1D RID: 89885 RVA: 0x003279E2 File Offset: 0x00325BE2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015F1E RID: 89886 RVA: 0x003279EF File Offset: 0x00325BEF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015F1F RID: 89887 RVA: 0x003279F8 File Offset: 0x00325BF8
		public static IVarStringValidateConfig GetRootAsIVarStringValidateConfig(ByteBuffer _bb)
		{
			return IVarStringValidateConfig.GetRootAsIVarStringValidateConfig(_bb, default(IVarStringValidateConfig));
		}

		// Token: 0x06015F20 RID: 89888 RVA: 0x00327A14 File Offset: 0x00325C14
		public static IVarStringValidateConfig GetRootAsIVarStringValidateConfig(ByteBuffer _bb, IVarStringValidateConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015F21 RID: 89889 RVA: 0x00327A31 File Offset: 0x00325C31
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015F22 RID: 89890 RVA: 0x00327A40 File Offset: 0x00325C40
		public IVarStringValidateConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006D67 RID: 28007
		// (get) Token: 0x06015F23 RID: 89891 RVA: 0x00327A50 File Offset: 0x00325C50
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

		// Token: 0x06015F24 RID: 89892 RVA: 0x00327A8C File Offset: 0x00325C8C
		public string ValidList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17006D68 RID: 28008
		// (get) Token: 0x06015F25 RID: 89893 RVA: 0x00327AC8 File Offset: 0x00325CC8
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

		// Token: 0x17006D69 RID: 28009
		// (get) Token: 0x06015F26 RID: 89894 RVA: 0x00327AF4 File Offset: 0x00325CF4
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06015F27 RID: 89895 RVA: 0x00327B30 File Offset: 0x00325D30
		public static Offset<IVarStringValidateConfig> CreateIVarStringValidateConfig(FlatBufferBuilder builder, EVar Type = EVar.Boolean, VectorOffset ValidListOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			IVarStringValidateConfig.AddValidList(builder, ValidListOffset);
			IVarStringValidateConfig.AddNullMask(builder, NullMask);
			IVarStringValidateConfig.AddType(builder, Type);
			return IVarStringValidateConfig.EndIVarStringValidateConfig(builder);
		}

		// Token: 0x06015F28 RID: 89896 RVA: 0x00327B54 File Offset: 0x00325D54
		public static void StartIVarStringValidateConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06015F29 RID: 89897 RVA: 0x00327B5D File Offset: 0x00325D5D
		public static void AddType(FlatBufferBuilder builder, EVar type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015F2A RID: 89898 RVA: 0x00327B68 File Offset: 0x00325D68
		public static void AddValidList(FlatBufferBuilder builder, VectorOffset validListOffset)
		{
			builder.AddOffset(1, validListOffset.Value, 0);
		}

		// Token: 0x06015F2B RID: 89899 RVA: 0x00327B78 File Offset: 0x00325D78
		public static VectorOffset CreateValidListVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06015F2C RID: 89900 RVA: 0x00327BB8 File Offset: 0x00325DB8
		public static VectorOffset CreateValidListVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06015F2D RID: 89901 RVA: 0x00327BD2 File Offset: 0x00325DD2
		public static VectorOffset CreateValidListVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06015F2E RID: 89902 RVA: 0x00327BF0 File Offset: 0x00325DF0
		public static VectorOffset CreateValidListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06015F2F RID: 89903 RVA: 0x00327C09 File Offset: 0x00325E09
		public static void StartValidListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06015F30 RID: 89904 RVA: 0x00327C14 File Offset: 0x00325E14
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06015F31 RID: 89905 RVA: 0x00327C1F File Offset: 0x00325E1F
		public static Offset<IVarStringValidateConfig> EndIVarStringValidateConfig(FlatBufferBuilder builder)
		{
			return new Offset<IVarStringValidateConfig>(builder.EndTable());
		}

		// Token: 0x06015F32 RID: 89906 RVA: 0x00327C2C File Offset: 0x00325E2C
		public IVarStringValidateConfigT UnPack()
		{
			IVarStringValidateConfigT varStringValidateConfigT = new IVarStringValidateConfigT();
			this.UnPackTo(varStringValidateConfigT);
			return varStringValidateConfigT;
		}

		// Token: 0x06015F33 RID: 89907 RVA: 0x00327C48 File Offset: 0x00325E48
		public void UnPackTo(IVarStringValidateConfigT _o)
		{
			_o.Type = this.Type;
			_o.ValidList = new List<string>();
			for (int i = 0; i < this.ValidListLength; i++)
			{
				_o.ValidList.Add(this.ValidList(i));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06015F34 RID: 89908 RVA: 0x00327C9C File Offset: 0x00325E9C
		public static Offset<IVarStringValidateConfig> Pack(FlatBufferBuilder builder, IVarStringValidateConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVarStringValidateConfig>);
			}
			VectorOffset validListOffset = default(VectorOffset);
			if (_o.ValidList != null)
			{
				StringOffset[] array = new StringOffset[_o.ValidList.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = builder.CreateString(_o.ValidList[i]);
				}
				validListOffset = IVarStringValidateConfig.CreateValidListVector(builder, array);
			}
			return IVarStringValidateConfig.CreateIVarStringValidateConfig(builder, _o.Type, validListOffset, _o.NullMask);
		}

		// Token: 0x0400B955 RID: 47445
		private Table __p;
	}
}
