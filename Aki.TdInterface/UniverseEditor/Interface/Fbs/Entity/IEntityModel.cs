using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C19 RID: 19481
	public struct IEntityModel : IFlatbufferObject
	{
		// Token: 0x17008A0F RID: 35343
		// (get) Token: 0x0601DCF8 RID: 122104 RVA: 0x0042E6D8 File Offset: 0x0042C8D8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DCF9 RID: 122105 RVA: 0x0042E6E5 File Offset: 0x0042C8E5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DCFA RID: 122106 RVA: 0x0042E6EC File Offset: 0x0042C8EC
		public static IEntityModel GetRootAsIEntityModel(ByteBuffer _bb)
		{
			return IEntityModel.GetRootAsIEntityModel(_bb, default(IEntityModel));
		}

		// Token: 0x0601DCFB RID: 122107 RVA: 0x0042E708 File Offset: 0x0042C908
		public static IEntityModel GetRootAsIEntityModel(ByteBuffer _bb, IEntityModel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DCFC RID: 122108 RVA: 0x0042E725 File Offset: 0x0042C925
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DCFD RID: 122109 RVA: 0x0042E734 File Offset: 0x0042C934
		public IEntityModel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008A10 RID: 35344
		// (get) Token: 0x0601DCFE RID: 122110 RVA: 0x0042E744 File Offset: 0x0042C944
		public string BluePrintId
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

		// Token: 0x0601DCFF RID: 122111 RVA: 0x0042E77B File Offset: 0x0042C97B
		public Span<byte> GetBluePrintIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601DD00 RID: 122112 RVA: 0x0042E78A File Offset: 0x0042C98A
		public byte[] GetBluePrintIdArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17008A11 RID: 35345
		// (get) Token: 0x0601DD01 RID: 122113 RVA: 0x0042E798 File Offset: 0x0042C998
		public string BluePrintClass
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

		// Token: 0x0601DD02 RID: 122114 RVA: 0x0042E7CF File Offset: 0x0042C9CF
		public Span<byte> GetBluePrintClassBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601DD03 RID: 122115 RVA: 0x0042E7DE File Offset: 0x0042C9DE
		public byte[] GetBluePrintClassArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17008A12 RID: 35346
		// (get) Token: 0x0601DD04 RID: 122116 RVA: 0x0042E7EC File Offset: 0x0042C9EC
		public string MeshPath
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601DD05 RID: 122117 RVA: 0x0042E823 File Offset: 0x0042CA23
		public Span<byte> GetMeshPathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0601DD06 RID: 122118 RVA: 0x0042E832 File Offset: 0x0042CA32
		public byte[] GetMeshPathArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x17008A13 RID: 35347
		// (get) Token: 0x0601DD07 RID: 122119 RVA: 0x0042E840 File Offset: 0x0042CA40
		public string AnimPath
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601DD08 RID: 122120 RVA: 0x0042E878 File Offset: 0x0042CA78
		public Span<byte> GetAnimPathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0601DD09 RID: 122121 RVA: 0x0042E888 File Offset: 0x0042CA88
		public byte[] GetAnimPathArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x0601DD0A RID: 122122 RVA: 0x0042E898 File Offset: 0x0042CA98
		public string Materials(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17008A14 RID: 35348
		// (get) Token: 0x0601DD0B RID: 122123 RVA: 0x0042E8D4 File Offset: 0x0042CAD4
		public int MaterialsLength
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

		// Token: 0x0601DD0C RID: 122124 RVA: 0x0042E900 File Offset: 0x0042CB00
		public static Offset<IEntityModel> CreateIEntityModel(FlatBufferBuilder builder, StringOffset BluePrintIdOffset = default(StringOffset), StringOffset BluePrintClassOffset = default(StringOffset), StringOffset MeshPathOffset = default(StringOffset), StringOffset AnimPathOffset = default(StringOffset), VectorOffset MaterialsOffset = default(VectorOffset))
		{
			builder.StartTable(5);
			IEntityModel.AddMaterials(builder, MaterialsOffset);
			IEntityModel.AddAnimPath(builder, AnimPathOffset);
			IEntityModel.AddMeshPath(builder, MeshPathOffset);
			IEntityModel.AddBluePrintClass(builder, BluePrintClassOffset);
			IEntityModel.AddBluePrintId(builder, BluePrintIdOffset);
			return IEntityModel.EndIEntityModel(builder);
		}

		// Token: 0x0601DD0D RID: 122125 RVA: 0x0042E934 File Offset: 0x0042CB34
		public static void StartIEntityModel(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601DD0E RID: 122126 RVA: 0x0042E93D File Offset: 0x0042CB3D
		public static void AddBluePrintId(FlatBufferBuilder builder, StringOffset bluePrintIdOffset)
		{
			builder.AddOffset(0, bluePrintIdOffset.Value, 0);
		}

		// Token: 0x0601DD0F RID: 122127 RVA: 0x0042E94D File Offset: 0x0042CB4D
		public static void AddBluePrintClass(FlatBufferBuilder builder, StringOffset bluePrintClassOffset)
		{
			builder.AddOffset(1, bluePrintClassOffset.Value, 0);
		}

		// Token: 0x0601DD10 RID: 122128 RVA: 0x0042E95D File Offset: 0x0042CB5D
		public static void AddMeshPath(FlatBufferBuilder builder, StringOffset meshPathOffset)
		{
			builder.AddOffset(2, meshPathOffset.Value, 0);
		}

		// Token: 0x0601DD11 RID: 122129 RVA: 0x0042E96D File Offset: 0x0042CB6D
		public static void AddAnimPath(FlatBufferBuilder builder, StringOffset animPathOffset)
		{
			builder.AddOffset(3, animPathOffset.Value, 0);
		}

		// Token: 0x0601DD12 RID: 122130 RVA: 0x0042E97D File Offset: 0x0042CB7D
		public static void AddMaterials(FlatBufferBuilder builder, VectorOffset materialsOffset)
		{
			builder.AddOffset(4, materialsOffset.Value, 0);
		}

		// Token: 0x0601DD13 RID: 122131 RVA: 0x0042E990 File Offset: 0x0042CB90
		public static VectorOffset CreateMaterialsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601DD14 RID: 122132 RVA: 0x0042E9D0 File Offset: 0x0042CBD0
		public static VectorOffset CreateMaterialsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601DD15 RID: 122133 RVA: 0x0042E9EA File Offset: 0x0042CBEA
		public static VectorOffset CreateMaterialsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601DD16 RID: 122134 RVA: 0x0042EA08 File Offset: 0x0042CC08
		public static VectorOffset CreateMaterialsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601DD17 RID: 122135 RVA: 0x0042EA21 File Offset: 0x0042CC21
		public static void StartMaterialsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601DD18 RID: 122136 RVA: 0x0042EA2C File Offset: 0x0042CC2C
		public static Offset<IEntityModel> EndIEntityModel(FlatBufferBuilder builder)
		{
			return new Offset<IEntityModel>(builder.EndTable());
		}

		// Token: 0x0601DD19 RID: 122137 RVA: 0x0042EA3C File Offset: 0x0042CC3C
		public IEntityModelT UnPack()
		{
			IEntityModelT entityModelT = new IEntityModelT();
			this.UnPackTo(entityModelT);
			return entityModelT;
		}

		// Token: 0x0601DD1A RID: 122138 RVA: 0x0042EA58 File Offset: 0x0042CC58
		public void UnPackTo(IEntityModelT _o)
		{
			_o.BluePrintId = this.BluePrintId;
			_o.BluePrintClass = this.BluePrintClass;
			_o.MeshPath = this.MeshPath;
			_o.AnimPath = this.AnimPath;
			_o.Materials = new List<string>();
			for (int i = 0; i < this.MaterialsLength; i++)
			{
				_o.Materials.Add(this.Materials(i));
			}
		}

		// Token: 0x0601DD1B RID: 122139 RVA: 0x0042EAC4 File Offset: 0x0042CCC4
		public static Offset<IEntityModel> Pack(FlatBufferBuilder builder, IEntityModelT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityModel>);
			}
			StringOffset bluePrintIdOffset = (_o.BluePrintId == null) ? default(StringOffset) : builder.CreateString(_o.BluePrintId);
			StringOffset bluePrintClassOffset = (_o.BluePrintClass == null) ? default(StringOffset) : builder.CreateString(_o.BluePrintClass);
			StringOffset meshPathOffset = (_o.MeshPath == null) ? default(StringOffset) : builder.CreateString(_o.MeshPath);
			StringOffset animPathOffset = (_o.AnimPath == null) ? default(StringOffset) : builder.CreateString(_o.AnimPath);
			VectorOffset materialsOffset = default(VectorOffset);
			if (_o.Materials != null)
			{
				StringOffset[] array = new StringOffset[_o.Materials.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = builder.CreateString(_o.Materials[i]);
				}
				materialsOffset = IEntityModel.CreateMaterialsVector(builder, array);
			}
			return IEntityModel.CreateIEntityModel(builder, bluePrintIdOffset, bluePrintClassOffset, meshPathOffset, animPathOffset, materialsOffset);
		}

		// Token: 0x0400D667 RID: 54887
		private Table __p;
	}
}
