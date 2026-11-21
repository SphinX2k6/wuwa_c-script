using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AE0 RID: 23264
	public struct IMeshNpcModel : IFlatbufferObject
	{
		// Token: 0x1700A9BD RID: 43453
		// (get) Token: 0x06026342 RID: 156482 RVA: 0x0053C55D File Offset: 0x0053A75D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026343 RID: 156483 RVA: 0x0053C56A File Offset: 0x0053A76A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026344 RID: 156484 RVA: 0x0053C574 File Offset: 0x0053A774
		public static IMeshNpcModel GetRootAsIMeshNpcModel(ByteBuffer _bb)
		{
			return IMeshNpcModel.GetRootAsIMeshNpcModel(_bb, default(IMeshNpcModel));
		}

		// Token: 0x06026345 RID: 156485 RVA: 0x0053C590 File Offset: 0x0053A790
		public static IMeshNpcModel GetRootAsIMeshNpcModel(ByteBuffer _bb, IMeshNpcModel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026346 RID: 156486 RVA: 0x0053C5AD File Offset: 0x0053A7AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026347 RID: 156487 RVA: 0x0053C5BC File Offset: 0x0053A7BC
		public IMeshNpcModel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A9BE RID: 43454
		// (get) Token: 0x06026348 RID: 156488 RVA: 0x0053C5CC File Offset: 0x0053A7CC
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

		// Token: 0x1700A9BF RID: 43455
		// (get) Token: 0x06026349 RID: 156489 RVA: 0x0053C608 File Offset: 0x0053A808
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

		// Token: 0x0602634A RID: 156490 RVA: 0x0053C63F File Offset: 0x0053A83F
		public Span<byte> GetMeshBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602634B RID: 156491 RVA: 0x0053C64E File Offset: 0x0053A84E
		public byte[] GetMeshArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602634C RID: 156492 RVA: 0x0053C65C File Offset: 0x0053A85C
		public static Offset<IMeshNpcModel> CreateIMeshNpcModel(FlatBufferBuilder builder, ENpcModelType Type = ENpcModelType.Mesh, StringOffset MeshOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IMeshNpcModel.AddMesh(builder, MeshOffset);
			IMeshNpcModel.AddType(builder, Type);
			return IMeshNpcModel.EndIMeshNpcModel(builder);
		}

		// Token: 0x0602634D RID: 156493 RVA: 0x0053C679 File Offset: 0x0053A879
		public static void StartIMeshNpcModel(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602634E RID: 156494 RVA: 0x0053C682 File Offset: 0x0053A882
		public static void AddType(FlatBufferBuilder builder, ENpcModelType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602634F RID: 156495 RVA: 0x0053C68D File Offset: 0x0053A88D
		public static void AddMesh(FlatBufferBuilder builder, StringOffset meshOffset)
		{
			builder.AddOffset(1, meshOffset.Value, 0);
		}

		// Token: 0x06026350 RID: 156496 RVA: 0x0053C69D File Offset: 0x0053A89D
		public static Offset<IMeshNpcModel> EndIMeshNpcModel(FlatBufferBuilder builder)
		{
			return new Offset<IMeshNpcModel>(builder.EndTable());
		}

		// Token: 0x06026351 RID: 156497 RVA: 0x0053C6AC File Offset: 0x0053A8AC
		public IMeshNpcModelT UnPack()
		{
			IMeshNpcModelT meshNpcModelT = new IMeshNpcModelT();
			this.UnPackTo(meshNpcModelT);
			return meshNpcModelT;
		}

		// Token: 0x06026352 RID: 156498 RVA: 0x0053C6C7 File Offset: 0x0053A8C7
		public void UnPackTo(IMeshNpcModelT _o)
		{
			_o.Type = this.Type;
			_o.Mesh = this.Mesh;
		}

		// Token: 0x06026353 RID: 156499 RVA: 0x0053C6E4 File Offset: 0x0053A8E4
		public static Offset<IMeshNpcModel> Pack(FlatBufferBuilder builder, IMeshNpcModelT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMeshNpcModel>);
			}
			StringOffset meshOffset = (_o.Mesh == null) ? default(StringOffset) : builder.CreateString(_o.Mesh);
			return IMeshNpcModel.CreateIMeshNpcModel(builder, _o.Type, meshOffset);
		}

		// Token: 0x0400F4AE RID: 62638
		private Table __p;
	}
}
