using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055BC RID: 21948
	public struct ICustomPrimitiveDataConfig : IFlatbufferObject
	{
		// Token: 0x17009D20 RID: 40224
		// (get) Token: 0x06022E99 RID: 143001 RVA: 0x004CE8AE File Offset: 0x004CCAAE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022E9A RID: 143002 RVA: 0x004CE8BB File Offset: 0x004CCABB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022E9B RID: 143003 RVA: 0x004CE8C4 File Offset: 0x004CCAC4
		public static ICustomPrimitiveDataConfig GetRootAsICustomPrimitiveDataConfig(ByteBuffer _bb)
		{
			return ICustomPrimitiveDataConfig.GetRootAsICustomPrimitiveDataConfig(_bb, default(ICustomPrimitiveDataConfig));
		}

		// Token: 0x06022E9C RID: 143004 RVA: 0x004CE8E0 File Offset: 0x004CCAE0
		public static ICustomPrimitiveDataConfig GetRootAsICustomPrimitiveDataConfig(ByteBuffer _bb, ICustomPrimitiveDataConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022E9D RID: 143005 RVA: 0x004CE8FD File Offset: 0x004CCAFD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022E9E RID: 143006 RVA: 0x004CE90C File Offset: 0x004CCB0C
		public ICustomPrimitiveDataConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009D21 RID: 40225
		// (get) Token: 0x06022E9F RID: 143007 RVA: 0x004CE91C File Offset: 0x004CCB1C
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

		// Token: 0x06022EA0 RID: 143008 RVA: 0x004CE958 File Offset: 0x004CCB58
		public ICustomPrimitiveMapping? PrimitiveConfigs(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ICustomPrimitiveMapping?(default(ICustomPrimitiveMapping).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009D22 RID: 40226
		// (get) Token: 0x06022EA1 RID: 143009 RVA: 0x004CE9B8 File Offset: 0x004CCBB8
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

		// Token: 0x17009D23 RID: 40227
		// (get) Token: 0x06022EA2 RID: 143010 RVA: 0x004CE9E4 File Offset: 0x004CCBE4
		public bool IsChildEffective
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009D24 RID: 40228
		// (get) Token: 0x06022EA3 RID: 143011 RVA: 0x004CEA24 File Offset: 0x004CCC24
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

		// Token: 0x06022EA4 RID: 143012 RVA: 0x004CEA61 File Offset: 0x004CCC61
		public static Offset<ICustomPrimitiveDataConfig> CreateICustomPrimitiveDataConfig(FlatBufferBuilder builder, EProceduralMaterialType Type = EProceduralMaterialType.CustomPrimitiveData, VectorOffset PrimitiveConfigsOffset = default(VectorOffset), bool IsChildEffective = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			ICustomPrimitiveDataConfig.AddPrimitiveConfigs(builder, PrimitiveConfigsOffset);
			ICustomPrimitiveDataConfig.AddNullMask(builder, NullMask);
			ICustomPrimitiveDataConfig.AddIsChildEffective(builder, IsChildEffective);
			ICustomPrimitiveDataConfig.AddType(builder, Type);
			return ICustomPrimitiveDataConfig.EndICustomPrimitiveDataConfig(builder);
		}

		// Token: 0x06022EA5 RID: 143013 RVA: 0x004CEA8D File Offset: 0x004CCC8D
		public static void StartICustomPrimitiveDataConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06022EA6 RID: 143014 RVA: 0x004CEA96 File Offset: 0x004CCC96
		public static void AddType(FlatBufferBuilder builder, EProceduralMaterialType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06022EA7 RID: 143015 RVA: 0x004CEAA1 File Offset: 0x004CCCA1
		public static void AddPrimitiveConfigs(FlatBufferBuilder builder, VectorOffset primitiveConfigsOffset)
		{
			builder.AddOffset(1, primitiveConfigsOffset.Value, 0);
		}

		// Token: 0x06022EA8 RID: 143016 RVA: 0x004CEAB4 File Offset: 0x004CCCB4
		public static VectorOffset CreatePrimitiveConfigsVector(FlatBufferBuilder builder, Offset<ICustomPrimitiveMapping>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06022EA9 RID: 143017 RVA: 0x004CEAF4 File Offset: 0x004CCCF4
		public static VectorOffset CreatePrimitiveConfigsVectorBlock(FlatBufferBuilder builder, Offset<ICustomPrimitiveMapping>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ICustomPrimitiveMapping>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022EAA RID: 143018 RVA: 0x004CEB0E File Offset: 0x004CCD0E
		public static VectorOffset CreatePrimitiveConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ICustomPrimitiveMapping>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ICustomPrimitiveMapping>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022EAB RID: 143019 RVA: 0x004CEB2C File Offset: 0x004CCD2C
		public static VectorOffset CreatePrimitiveConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ICustomPrimitiveMapping>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06022EAC RID: 143020 RVA: 0x004CEB45 File Offset: 0x004CCD45
		public static void StartPrimitiveConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06022EAD RID: 143021 RVA: 0x004CEB50 File Offset: 0x004CCD50
		public static void AddIsChildEffective(FlatBufferBuilder builder, bool isChildEffective)
		{
			builder.AddBool(2, isChildEffective, false);
		}

		// Token: 0x06022EAE RID: 143022 RVA: 0x004CEB5B File Offset: 0x004CCD5B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06022EAF RID: 143023 RVA: 0x004CEB66 File Offset: 0x004CCD66
		public static Offset<ICustomPrimitiveDataConfig> EndICustomPrimitiveDataConfig(FlatBufferBuilder builder)
		{
			return new Offset<ICustomPrimitiveDataConfig>(builder.EndTable());
		}

		// Token: 0x06022EB0 RID: 143024 RVA: 0x004CEB74 File Offset: 0x004CCD74
		public ICustomPrimitiveDataConfigT UnPack()
		{
			ICustomPrimitiveDataConfigT customPrimitiveDataConfigT = new ICustomPrimitiveDataConfigT();
			this.UnPackTo(customPrimitiveDataConfigT);
			return customPrimitiveDataConfigT;
		}

		// Token: 0x06022EB1 RID: 143025 RVA: 0x004CEB90 File Offset: 0x004CCD90
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

		// Token: 0x06022EB2 RID: 143026 RVA: 0x004CEC14 File Offset: 0x004CCE14
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

		// Token: 0x0400EC4D RID: 60493
		private Table __p;
	}
}
