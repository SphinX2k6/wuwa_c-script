using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200505A RID: 20570
	public struct ICustomPrimitiveDataConfig : IFlatbufferObject
	{
		// Token: 0x1700953A RID: 38202
		// (get) Token: 0x06020F5F RID: 135007 RVA: 0x00494BFA File Offset: 0x00492DFA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020F60 RID: 135008 RVA: 0x00494C07 File Offset: 0x00492E07
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020F61 RID: 135009 RVA: 0x00494C10 File Offset: 0x00492E10
		public static ICustomPrimitiveDataConfig GetRootAsICustomPrimitiveDataConfig(ByteBuffer _bb)
		{
			return ICustomPrimitiveDataConfig.GetRootAsICustomPrimitiveDataConfig(_bb, default(ICustomPrimitiveDataConfig));
		}

		// Token: 0x06020F62 RID: 135010 RVA: 0x00494C2C File Offset: 0x00492E2C
		public static ICustomPrimitiveDataConfig GetRootAsICustomPrimitiveDataConfig(ByteBuffer _bb, ICustomPrimitiveDataConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020F63 RID: 135011 RVA: 0x00494C49 File Offset: 0x00492E49
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020F64 RID: 135012 RVA: 0x00494C58 File Offset: 0x00492E58
		public ICustomPrimitiveDataConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700953B RID: 38203
		// (get) Token: 0x06020F65 RID: 135013 RVA: 0x00494C68 File Offset: 0x00492E68
		public EProceduralMaterialType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EProceduralMaterialType.CustomPrimitiveData;
				}
				return (EProceduralMaterialType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06020F66 RID: 135014 RVA: 0x00494CA4 File Offset: 0x00492EA4
		public ICustomPrimitiveMapping? PrimitiveConfigs(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ICustomPrimitiveMapping?(default(ICustomPrimitiveMapping).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700953C RID: 38204
		// (get) Token: 0x06020F67 RID: 135015 RVA: 0x00494D04 File Offset: 0x00492F04
		public int PrimitiveConfigsLength
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

		// Token: 0x1700953D RID: 38205
		// (get) Token: 0x06020F68 RID: 135016 RVA: 0x00494D30 File Offset: 0x00492F30
		public bool IsChildEffective
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700953E RID: 38206
		// (get) Token: 0x06020F69 RID: 135017 RVA: 0x00494D70 File Offset: 0x00492F70
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06020F6A RID: 135018 RVA: 0x00494DAD File Offset: 0x00492FAD
		public static Offset<ICustomPrimitiveDataConfig> CreateICustomPrimitiveDataConfig(FlatBufferBuilder builder, EProceduralMaterialType Type = EProceduralMaterialType.CustomPrimitiveData, VectorOffset PrimitiveConfigsOffset = default(VectorOffset), bool IsChildEffective = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			ICustomPrimitiveDataConfig.AddPrimitiveConfigs(builder, PrimitiveConfigsOffset);
			ICustomPrimitiveDataConfig.AddNullMask(builder, NullMask);
			ICustomPrimitiveDataConfig.AddIsChildEffective(builder, IsChildEffective);
			ICustomPrimitiveDataConfig.AddType(builder, Type);
			return ICustomPrimitiveDataConfig.EndICustomPrimitiveDataConfig(builder);
		}

		// Token: 0x06020F6B RID: 135019 RVA: 0x00494DD9 File Offset: 0x00492FD9
		public static void StartICustomPrimitiveDataConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06020F6C RID: 135020 RVA: 0x00494DE2 File Offset: 0x00492FE2
		public static void AddType(FlatBufferBuilder builder, EProceduralMaterialType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020F6D RID: 135021 RVA: 0x00494DED File Offset: 0x00492FED
		public static void AddPrimitiveConfigs(FlatBufferBuilder builder, VectorOffset primitiveConfigsOffset)
		{
			builder.AddOffset(1, primitiveConfigsOffset.Value, 0);
		}

		// Token: 0x06020F6E RID: 135022 RVA: 0x00494E00 File Offset: 0x00493000
		public static VectorOffset CreatePrimitiveConfigsVector(FlatBufferBuilder builder, Offset<ICustomPrimitiveMapping>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06020F6F RID: 135023 RVA: 0x00494E40 File Offset: 0x00493040
		public static VectorOffset CreatePrimitiveConfigsVectorBlock(FlatBufferBuilder builder, Offset<ICustomPrimitiveMapping>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ICustomPrimitiveMapping>>(data);
			return builder.EndVector();
		}

		// Token: 0x06020F70 RID: 135024 RVA: 0x00494E5A File Offset: 0x0049305A
		public static VectorOffset CreatePrimitiveConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ICustomPrimitiveMapping>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ICustomPrimitiveMapping>>(data);
			return builder.EndVector();
		}

		// Token: 0x06020F71 RID: 135025 RVA: 0x00494E78 File Offset: 0x00493078
		public static VectorOffset CreatePrimitiveConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ICustomPrimitiveMapping>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06020F72 RID: 135026 RVA: 0x00494E91 File Offset: 0x00493091
		public static void StartPrimitiveConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06020F73 RID: 135027 RVA: 0x00494E9C File Offset: 0x0049309C
		public static void AddIsChildEffective(FlatBufferBuilder builder, bool isChildEffective)
		{
			builder.AddBool(2, isChildEffective, false);
		}

		// Token: 0x06020F74 RID: 135028 RVA: 0x00494EA7 File Offset: 0x004930A7
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06020F75 RID: 135029 RVA: 0x00494EB2 File Offset: 0x004930B2
		public static Offset<ICustomPrimitiveDataConfig> EndICustomPrimitiveDataConfig(FlatBufferBuilder builder)
		{
			return new Offset<ICustomPrimitiveDataConfig>(builder.EndTable());
		}

		// Token: 0x06020F76 RID: 135030 RVA: 0x00494EC0 File Offset: 0x004930C0
		public ICustomPrimitiveDataConfigT UnPack()
		{
			ICustomPrimitiveDataConfigT customPrimitiveDataConfigT = new ICustomPrimitiveDataConfigT();
			this.UnPackTo(customPrimitiveDataConfigT);
			return customPrimitiveDataConfigT;
		}

		// Token: 0x06020F77 RID: 135031 RVA: 0x00494EDC File Offset: 0x004930DC
		public void UnPackTo(ICustomPrimitiveDataConfigT _o)
		{
			_o.Type = this.Type;
			_o.PrimitiveConfigs = new List<ICustomPrimitiveMappingT>();
			for (int i = 0; i < this.PrimitiveConfigsLength; i++)
			{
				_o.PrimitiveConfigs.Add((this.PrimitiveConfigs(i) != null) ? this.PrimitiveConfigs(i).Value.UnPack() : null);
			}
			_o.IsChildEffective = this.IsChildEffective;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06020F78 RID: 135032 RVA: 0x00494F60 File Offset: 0x00493160
		public static Offset<ICustomPrimitiveDataConfig> Pack(FlatBufferBuilder builder, ICustomPrimitiveDataConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICustomPrimitiveDataConfig>);
			}
			VectorOffset primitiveConfigsOffset = default(VectorOffset);
			if (_o.PrimitiveConfigs != null)
			{
				Offset<ICustomPrimitiveMapping>[] array = new Offset<ICustomPrimitiveMapping>[_o.PrimitiveConfigs.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ICustomPrimitiveMapping.Pack(builder, _o.PrimitiveConfigs[i]);
				}
				primitiveConfigsOffset = ICustomPrimitiveDataConfig.CreatePrimitiveConfigsVector(builder, array);
			}
			return ICustomPrimitiveDataConfig.CreateICustomPrimitiveDataConfig(builder, _o.Type, primitiveConfigsOffset, _o.IsChildEffective, _o.NullMask);
		}

		// Token: 0x0400E054 RID: 57428
		private Table __p;
	}
}
