using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200554E RID: 21838
	public struct IMeshNpcModel : IFlatbufferObject
	{
		// Token: 0x1700A149 RID: 41289
		// (get) Token: 0x060241A7 RID: 147879 RVA: 0x004FCE75 File Offset: 0x004FB075
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060241A8 RID: 147880 RVA: 0x004FCE82 File Offset: 0x004FB082
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060241A9 RID: 147881 RVA: 0x004FCE8C File Offset: 0x004FB08C
		public static IMeshNpcModel GetRootAsIMeshNpcModel(ByteBuffer _bb)
		{
			return IMeshNpcModel.GetRootAsIMeshNpcModel(_bb, default(IMeshNpcModel));
		}

		// Token: 0x060241AA RID: 147882 RVA: 0x004FCEA8 File Offset: 0x004FB0A8
		public static IMeshNpcModel GetRootAsIMeshNpcModel(ByteBuffer _bb, IMeshNpcModel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060241AB RID: 147883 RVA: 0x004FCEC5 File Offset: 0x004FB0C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060241AC RID: 147884 RVA: 0x004FCED4 File Offset: 0x004FB0D4
		public IMeshNpcModel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A14A RID: 41290
		// (get) Token: 0x060241AD RID: 147885 RVA: 0x004FCEE4 File Offset: 0x004FB0E4
		public ENpcModelType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ENpcModelType.Mesh;
				}
				return (ENpcModelType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A14B RID: 41291
		// (get) Token: 0x060241AE RID: 147886 RVA: 0x004FCF20 File Offset: 0x004FB120
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

		// Token: 0x060241AF RID: 147887 RVA: 0x004FCF57 File Offset: 0x004FB157
		public Span<byte> GetMeshBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060241B0 RID: 147888 RVA: 0x004FCF66 File Offset: 0x004FB166
		public byte[] GetMeshArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x060241B1 RID: 147889 RVA: 0x004FCF74 File Offset: 0x004FB174
		public static Offset<IMeshNpcModel> CreateIMeshNpcModel(FlatBufferBuilder builder, ENpcModelType Type = ENpcModelType.Mesh, StringOffset MeshOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IMeshNpcModel.AddMesh(builder, MeshOffset);
			IMeshNpcModel.AddType(builder, Type);
			return IMeshNpcModel.EndIMeshNpcModel(builder);
		}

		// Token: 0x060241B2 RID: 147890 RVA: 0x004FCF91 File Offset: 0x004FB191
		public static void StartIMeshNpcModel(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060241B3 RID: 147891 RVA: 0x004FCF9A File Offset: 0x004FB19A
		public static void AddType(FlatBufferBuilder builder, ENpcModelType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060241B4 RID: 147892 RVA: 0x004FCFA5 File Offset: 0x004FB1A5
		public static void AddMesh(FlatBufferBuilder builder, StringOffset meshOffset)
		{
			builder.AddOffset(1, meshOffset.Value, 0);
		}

		// Token: 0x060241B5 RID: 147893 RVA: 0x004FCFB5 File Offset: 0x004FB1B5
		public static Offset<IMeshNpcModel> EndIMeshNpcModel(FlatBufferBuilder builder)
		{
			return new Offset<IMeshNpcModel>(builder.EndTable());
		}

		// Token: 0x060241B6 RID: 147894 RVA: 0x004FCFC4 File Offset: 0x004FB1C4
		public IMeshNpcModelT UnPack()
		{
			IMeshNpcModelT meshNpcModelT = new IMeshNpcModelT();
			this.UnPackTo(meshNpcModelT);
			return meshNpcModelT;
		}

		// Token: 0x060241B7 RID: 147895 RVA: 0x004FCFDF File Offset: 0x004FB1DF
		public void UnPackTo(IMeshNpcModelT _o)
		{
			_o.Type = this.Type;
			_o.Mesh = this.Mesh;
		}

		// Token: 0x060241B8 RID: 147896 RVA: 0x004FCFFC File Offset: 0x004FB1FC
		public static Offset<IMeshNpcModel> Pack(FlatBufferBuilder builder, IMeshNpcModelT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMeshNpcModel>);
			}
			StringOffset meshOffset = (_o.Mesh == null) ? default(StringOffset) : builder.CreateString(_o.Mesh);
			return IMeshNpcModel.CreateIMeshNpcModel(builder, _o.Type, meshOffset);
		}

		// Token: 0x0400E85D RID: 59485
		private Table __p;
	}
}
