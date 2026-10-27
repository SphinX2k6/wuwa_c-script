using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200554B RID: 21835
	public struct IMeshAnimalModel : IFlatbufferObject
	{
		// Token: 0x1700A144 RID: 41284
		// (get) Token: 0x0602418F RID: 147855 RVA: 0x004FCC43 File Offset: 0x004FAE43
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024190 RID: 147856 RVA: 0x004FCC50 File Offset: 0x004FAE50
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024191 RID: 147857 RVA: 0x004FCC58 File Offset: 0x004FAE58
		public static IMeshAnimalModel GetRootAsIMeshAnimalModel(ByteBuffer _bb)
		{
			return IMeshAnimalModel.GetRootAsIMeshAnimalModel(_bb, default(IMeshAnimalModel));
		}

		// Token: 0x06024192 RID: 147858 RVA: 0x004FCC74 File Offset: 0x004FAE74
		public static IMeshAnimalModel GetRootAsIMeshAnimalModel(ByteBuffer _bb, IMeshAnimalModel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024193 RID: 147859 RVA: 0x004FCC91 File Offset: 0x004FAE91
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024194 RID: 147860 RVA: 0x004FCCA0 File Offset: 0x004FAEA0
		public IMeshAnimalModel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A145 RID: 41285
		// (get) Token: 0x06024195 RID: 147861 RVA: 0x004FCCB0 File Offset: 0x004FAEB0
		public EAnimalModelType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EAnimalModelType.Mesh;
				}
				return (EAnimalModelType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A146 RID: 41286
		// (get) Token: 0x06024196 RID: 147862 RVA: 0x004FCCEC File Offset: 0x004FAEEC
		public string Mesh
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

		// Token: 0x06024197 RID: 147863 RVA: 0x004FCD23 File Offset: 0x004FAF23
		public Span<byte> GetMeshBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06024198 RID: 147864 RVA: 0x004FCD32 File Offset: 0x004FAF32
		public byte[] GetMeshArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06024199 RID: 147865 RVA: 0x004FCD40 File Offset: 0x004FAF40
		public static Offset<IMeshAnimalModel> CreateIMeshAnimalModel(FlatBufferBuilder builder, EAnimalModelType Type = EAnimalModelType.Mesh, StringOffset MeshOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IMeshAnimalModel.AddMesh(builder, MeshOffset);
			IMeshAnimalModel.AddType(builder, Type);
			return IMeshAnimalModel.EndIMeshAnimalModel(builder);
		}

		// Token: 0x0602419A RID: 147866 RVA: 0x004FCD5D File Offset: 0x004FAF5D
		public static void StartIMeshAnimalModel(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602419B RID: 147867 RVA: 0x004FCD66 File Offset: 0x004FAF66
		public static void AddType(FlatBufferBuilder builder, EAnimalModelType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602419C RID: 147868 RVA: 0x004FCD71 File Offset: 0x004FAF71
		public static void AddMesh(FlatBufferBuilder builder, StringOffset meshOffset)
		{
			builder.AddOffset(1, meshOffset.Value, 0);
		}

		// Token: 0x0602419D RID: 147869 RVA: 0x004FCD81 File Offset: 0x004FAF81
		public static Offset<IMeshAnimalModel> EndIMeshAnimalModel(FlatBufferBuilder builder)
		{
			return new Offset<IMeshAnimalModel>(builder.EndTable());
		}

		// Token: 0x0602419E RID: 147870 RVA: 0x004FCD90 File Offset: 0x004FAF90
		public IMeshAnimalModelT UnPack()
		{
			IMeshAnimalModelT meshAnimalModelT = new IMeshAnimalModelT();
			this.UnPackTo(meshAnimalModelT);
			return meshAnimalModelT;
		}

		// Token: 0x0602419F RID: 147871 RVA: 0x004FCDAB File Offset: 0x004FAFAB
		public void UnPackTo(IMeshAnimalModelT _o)
		{
			_o.Type = this.Type;
			_o.Mesh = this.Mesh;
		}

		// Token: 0x060241A0 RID: 147872 RVA: 0x004FCDC8 File Offset: 0x004FAFC8
		public static Offset<IMeshAnimalModel> Pack(FlatBufferBuilder builder, IMeshAnimalModelT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMeshAnimalModel>);
			}
			StringOffset meshOffset = (_o.Mesh == null) ? default(StringOffset) : builder.CreateString(_o.Mesh);
			return IMeshAnimalModel.CreateIMeshAnimalModel(builder, _o.Type, meshOffset);
		}

		// Token: 0x0400E85A RID: 59482
		private Table __p;
	}
}
