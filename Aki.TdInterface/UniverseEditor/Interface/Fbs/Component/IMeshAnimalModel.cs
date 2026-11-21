using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005ADD RID: 23261
	public struct IMeshAnimalModel : IFlatbufferObject
	{
		// Token: 0x1700A9B8 RID: 43448
		// (get) Token: 0x0602632A RID: 156458 RVA: 0x0053C329 File Offset: 0x0053A529
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602632B RID: 156459 RVA: 0x0053C336 File Offset: 0x0053A536
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602632C RID: 156460 RVA: 0x0053C340 File Offset: 0x0053A540
		public static IMeshAnimalModel GetRootAsIMeshAnimalModel(ByteBuffer _bb)
		{
			return IMeshAnimalModel.GetRootAsIMeshAnimalModel(_bb, default(IMeshAnimalModel));
		}

		// Token: 0x0602632D RID: 156461 RVA: 0x0053C35C File Offset: 0x0053A55C
		public static IMeshAnimalModel GetRootAsIMeshAnimalModel(ByteBuffer _bb, IMeshAnimalModel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602632E RID: 156462 RVA: 0x0053C379 File Offset: 0x0053A579
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602632F RID: 156463 RVA: 0x0053C388 File Offset: 0x0053A588
		public IMeshAnimalModel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A9B9 RID: 43449
		// (get) Token: 0x06026330 RID: 156464 RVA: 0x0053C398 File Offset: 0x0053A598
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

		// Token: 0x1700A9BA RID: 43450
		// (get) Token: 0x06026331 RID: 156465 RVA: 0x0053C3D4 File Offset: 0x0053A5D4
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

		// Token: 0x06026332 RID: 156466 RVA: 0x0053C40B File Offset: 0x0053A60B
		public Span<byte> GetMeshBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06026333 RID: 156467 RVA: 0x0053C41A File Offset: 0x0053A61A
		public byte[] GetMeshArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06026334 RID: 156468 RVA: 0x0053C428 File Offset: 0x0053A628
		public static Offset<IMeshAnimalModel> CreateIMeshAnimalModel(FlatBufferBuilder builder, EAnimalModelType Type = EAnimalModelType.Mesh, StringOffset MeshOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IMeshAnimalModel.AddMesh(builder, MeshOffset);
			IMeshAnimalModel.AddType(builder, Type);
			return IMeshAnimalModel.EndIMeshAnimalModel(builder);
		}

		// Token: 0x06026335 RID: 156469 RVA: 0x0053C445 File Offset: 0x0053A645
		public static void StartIMeshAnimalModel(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06026336 RID: 156470 RVA: 0x0053C44E File Offset: 0x0053A64E
		public static void AddType(FlatBufferBuilder builder, EAnimalModelType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06026337 RID: 156471 RVA: 0x0053C459 File Offset: 0x0053A659
		public static void AddMesh(FlatBufferBuilder builder, StringOffset meshOffset)
		{
			builder.AddOffset(1, meshOffset.Value, 0);
		}

		// Token: 0x06026338 RID: 156472 RVA: 0x0053C469 File Offset: 0x0053A669
		public static Offset<IMeshAnimalModel> EndIMeshAnimalModel(FlatBufferBuilder builder)
		{
			return new Offset<IMeshAnimalModel>(builder.EndTable());
		}

		// Token: 0x06026339 RID: 156473 RVA: 0x0053C478 File Offset: 0x0053A678
		public IMeshAnimalModelT UnPack()
		{
			IMeshAnimalModelT meshAnimalModelT = new IMeshAnimalModelT();
			this.UnPackTo(meshAnimalModelT);
			return meshAnimalModelT;
		}

		// Token: 0x0602633A RID: 156474 RVA: 0x0053C493 File Offset: 0x0053A693
		public void UnPackTo(IMeshAnimalModelT _o)
		{
			_o.Type = this.Type;
			_o.Mesh = this.Mesh;
		}

		// Token: 0x0602633B RID: 156475 RVA: 0x0053C4B0 File Offset: 0x0053A6B0
		public static Offset<IMeshAnimalModel> Pack(FlatBufferBuilder builder, IMeshAnimalModelT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMeshAnimalModel>);
			}
			StringOffset meshOffset = (_o.Mesh == null) ? default(StringOffset) : builder.CreateString(_o.Mesh);
			return IMeshAnimalModel.CreateIMeshAnimalModel(builder, _o.Type, meshOffset);
		}

		// Token: 0x0400F4AB RID: 62635
		private Table __p;
	}
}
