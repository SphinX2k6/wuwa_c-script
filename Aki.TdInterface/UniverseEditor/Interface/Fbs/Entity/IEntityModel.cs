using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047B1 RID: 18353
	public struct IEntityModel : IFlatbufferObject
	{
		// Token: 0x170083CE RID: 33742
		// (get) Token: 0x0601C523 RID: 116003 RVA: 0x0040243C File Offset: 0x0040063C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C524 RID: 116004 RVA: 0x00402449 File Offset: 0x00400649
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C525 RID: 116005 RVA: 0x00402450 File Offset: 0x00400650
		public static IEntityModel GetRootAsIEntityModel(ByteBuffer _bb)
		{
			return IEntityModel.GetRootAsIEntityModel(_bb, default(IEntityModel));
		}

		// Token: 0x0601C526 RID: 116006 RVA: 0x0040246C File Offset: 0x0040066C
		public static IEntityModel GetRootAsIEntityModel(ByteBuffer _bb, IEntityModel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C527 RID: 116007 RVA: 0x00402489 File Offset: 0x00400689
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C528 RID: 116008 RVA: 0x00402498 File Offset: 0x00400698
		public IEntityModel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170083CF RID: 33743
		// (get) Token: 0x0601C529 RID: 116009 RVA: 0x004024A8 File Offset: 0x004006A8
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

		// Token: 0x0601C52A RID: 116010 RVA: 0x004024DF File Offset: 0x004006DF
		public Span<byte> GetBluePrintIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601C52B RID: 116011 RVA: 0x004024EE File Offset: 0x004006EE
		public byte[] GetBluePrintIdArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x170083D0 RID: 33744
		// (get) Token: 0x0601C52C RID: 116012 RVA: 0x004024FC File Offset: 0x004006FC
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

		// Token: 0x0601C52D RID: 116013 RVA: 0x00402533 File Offset: 0x00400733
		public Span<byte> GetBluePrintClassBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601C52E RID: 116014 RVA: 0x00402542 File Offset: 0x00400742
		public byte[] GetBluePrintClassArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x170083D1 RID: 33745
		// (get) Token: 0x0601C52F RID: 116015 RVA: 0x00402550 File Offset: 0x00400750
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

		// Token: 0x0601C530 RID: 116016 RVA: 0x00402587 File Offset: 0x00400787
		public Span<byte> GetMeshPathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0601C531 RID: 116017 RVA: 0x00402596 File Offset: 0x00400796
		public byte[] GetMeshPathArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x170083D2 RID: 33746
		// (get) Token: 0x0601C532 RID: 116018 RVA: 0x004025A4 File Offset: 0x004007A4
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

		// Token: 0x0601C533 RID: 116019 RVA: 0x004025DC File Offset: 0x004007DC
		public Span<byte> GetAnimPathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0601C534 RID: 116020 RVA: 0x004025EC File Offset: 0x004007EC
		public byte[] GetAnimPathArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x0601C535 RID: 116021 RVA: 0x004025FC File Offset: 0x004007FC
		public string Materials(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170083D3 RID: 33747
		// (get) Token: 0x0601C536 RID: 116022 RVA: 0x00402638 File Offset: 0x00400838
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

		// Token: 0x0601C537 RID: 116023 RVA: 0x00402664 File Offset: 0x00400864
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

		// Token: 0x0601C538 RID: 116024 RVA: 0x00402698 File Offset: 0x00400898
		public static void StartIEntityModel(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601C539 RID: 116025 RVA: 0x004026A1 File Offset: 0x004008A1
		public static void AddBluePrintId(FlatBufferBuilder builder, StringOffset bluePrintIdOffset)
		{
			builder.AddOffset(0, bluePrintIdOffset.Value, 0);
		}

		// Token: 0x0601C53A RID: 116026 RVA: 0x004026B1 File Offset: 0x004008B1
		public static void AddBluePrintClass(FlatBufferBuilder builder, StringOffset bluePrintClassOffset)
		{
			builder.AddOffset(1, bluePrintClassOffset.Value, 0);
		}

		// Token: 0x0601C53B RID: 116027 RVA: 0x004026C1 File Offset: 0x004008C1
		public static void AddMeshPath(FlatBufferBuilder builder, StringOffset meshPathOffset)
		{
			builder.AddOffset(2, meshPathOffset.Value, 0);
		}

		// Token: 0x0601C53C RID: 116028 RVA: 0x004026D1 File Offset: 0x004008D1
		public static void AddAnimPath(FlatBufferBuilder builder, StringOffset animPathOffset)
		{
			builder.AddOffset(3, animPathOffset.Value, 0);
		}

		// Token: 0x0601C53D RID: 116029 RVA: 0x004026E1 File Offset: 0x004008E1
		public static void AddMaterials(FlatBufferBuilder builder, VectorOffset materialsOffset)
		{
			builder.AddOffset(4, materialsOffset.Value, 0);
		}

		// Token: 0x0601C53E RID: 116030 RVA: 0x004026F4 File Offset: 0x004008F4
		public static VectorOffset CreateMaterialsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C53F RID: 116031 RVA: 0x00402734 File Offset: 0x00400934
		public static VectorOffset CreateMaterialsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C540 RID: 116032 RVA: 0x0040274E File Offset: 0x0040094E
		public static VectorOffset CreateMaterialsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C541 RID: 116033 RVA: 0x0040276C File Offset: 0x0040096C
		public static VectorOffset CreateMaterialsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C542 RID: 116034 RVA: 0x00402785 File Offset: 0x00400985
		public static void StartMaterialsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601C543 RID: 116035 RVA: 0x00402790 File Offset: 0x00400990
		public static Offset<IEntityModel> EndIEntityModel(FlatBufferBuilder builder)
		{
			return new Offset<IEntityModel>(builder.EndTable());
		}

		// Token: 0x0601C544 RID: 116036 RVA: 0x004027A0 File Offset: 0x004009A0
		public IEntityModelT UnPack()
		{
			IEntityModelT entityModelT = new IEntityModelT();
			this.UnPackTo(entityModelT);
			return entityModelT;
		}

		// Token: 0x0601C545 RID: 116037 RVA: 0x004027BC File Offset: 0x004009BC
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

		// Token: 0x0601C546 RID: 116038 RVA: 0x00402828 File Offset: 0x00400A28
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

		// Token: 0x0400CC31 RID: 52273
		private Table __p;
	}
}
