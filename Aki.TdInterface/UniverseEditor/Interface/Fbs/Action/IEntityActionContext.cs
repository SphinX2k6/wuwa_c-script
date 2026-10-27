using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066D5 RID: 26325
	public struct IEntityActionContext : IFlatbufferObject
	{
		// Token: 0x1700C390 RID: 50064
		// (get) Token: 0x0602DC2F RID: 187439 RVA: 0x006425D9 File Offset: 0x006407D9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DC30 RID: 187440 RVA: 0x006425E6 File Offset: 0x006407E6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DC31 RID: 187441 RVA: 0x006425F0 File Offset: 0x006407F0
		public static IEntityActionContext GetRootAsIEntityActionContext(ByteBuffer _bb)
		{
			return IEntityActionContext.GetRootAsIEntityActionContext(_bb, default(IEntityActionContext));
		}

		// Token: 0x0602DC32 RID: 187442 RVA: 0x0064260C File Offset: 0x0064080C
		public static IEntityActionContext GetRootAsIEntityActionContext(ByteBuffer _bb, IEntityActionContext obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DC33 RID: 187443 RVA: 0x00642629 File Offset: 0x00640829
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DC34 RID: 187444 RVA: 0x00642638 File Offset: 0x00640838
		public IEntityActionContext __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C391 RID: 50065
		// (get) Token: 0x0602DC35 RID: 187445 RVA: 0x00642648 File Offset: 0x00640848
		public string Type
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

		// Token: 0x0602DC36 RID: 187446 RVA: 0x0064267F File Offset: 0x0064087F
		public Span<byte> GetTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602DC37 RID: 187447 RVA: 0x0064268E File Offset: 0x0064088E
		public byte[] GetTypeArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x0602DC38 RID: 187448 RVA: 0x0064269C File Offset: 0x0064089C
		public static Offset<IEntityActionContext> CreateIEntityActionContext(FlatBufferBuilder builder, StringOffset TypeOffset = default(StringOffset))
		{
			builder.StartTable(1);
			IEntityActionContext.AddType(builder, TypeOffset);
			return IEntityActionContext.EndIEntityActionContext(builder);
		}

		// Token: 0x0602DC39 RID: 187449 RVA: 0x006426B2 File Offset: 0x006408B2
		public static void StartIEntityActionContext(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602DC3A RID: 187450 RVA: 0x006426BB File Offset: 0x006408BB
		public static void AddType(FlatBufferBuilder builder, StringOffset typeOffset)
		{
			builder.AddOffset(0, typeOffset.Value, 0);
		}

		// Token: 0x0602DC3B RID: 187451 RVA: 0x006426CB File Offset: 0x006408CB
		public static Offset<IEntityActionContext> EndIEntityActionContext(FlatBufferBuilder builder)
		{
			return new Offset<IEntityActionContext>(builder.EndTable());
		}

		// Token: 0x0602DC3C RID: 187452 RVA: 0x006426D8 File Offset: 0x006408D8
		public IEntityActionContextT UnPack()
		{
			IEntityActionContextT entityActionContextT = new IEntityActionContextT();
			this.UnPackTo(entityActionContextT);
			return entityActionContextT;
		}

		// Token: 0x0602DC3D RID: 187453 RVA: 0x006426F3 File Offset: 0x006408F3
		public void UnPackTo(IEntityActionContextT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602DC3E RID: 187454 RVA: 0x00642704 File Offset: 0x00640904
		public static Offset<IEntityActionContext> Pack(FlatBufferBuilder builder, IEntityActionContextT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityActionContext>);
			}
			StringOffset typeOffset = (_o.Type == null) ? default(StringOffset) : builder.CreateString(_o.Type);
			return IEntityActionContext.CreateIEntityActionContext(builder, typeOffset);
		}

		// Token: 0x04010D9E RID: 69022
		private Table __p;
	}
}
