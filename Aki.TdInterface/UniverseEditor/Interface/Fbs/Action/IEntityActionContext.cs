using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D4F RID: 27983
	public struct IEntityActionContext : IFlatbufferObject
	{
		// Token: 0x1700CD41 RID: 52545
		// (get) Token: 0x0603044C RID: 197708 RVA: 0x0068F88D File Offset: 0x0068DA8D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603044D RID: 197709 RVA: 0x0068F89A File Offset: 0x0068DA9A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603044E RID: 197710 RVA: 0x0068F8A4 File Offset: 0x0068DAA4
		public static IEntityActionContext GetRootAsIEntityActionContext(ByteBuffer _bb)
		{
			return IEntityActionContext.GetRootAsIEntityActionContext(_bb, default(IEntityActionContext));
		}

		// Token: 0x0603044F RID: 197711 RVA: 0x0068F8C0 File Offset: 0x0068DAC0
		public static IEntityActionContext GetRootAsIEntityActionContext(ByteBuffer _bb, IEntityActionContext obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030450 RID: 197712 RVA: 0x0068F8DD File Offset: 0x0068DADD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030451 RID: 197713 RVA: 0x0068F8EC File Offset: 0x0068DAEC
		public IEntityActionContext __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CD42 RID: 52546
		// (get) Token: 0x06030452 RID: 197714 RVA: 0x0068F8FC File Offset: 0x0068DAFC
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

		// Token: 0x06030453 RID: 197715 RVA: 0x0068F933 File Offset: 0x0068DB33
		public Span<byte> GetTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06030454 RID: 197716 RVA: 0x0068F942 File Offset: 0x0068DB42
		public byte[] GetTypeArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x06030455 RID: 197717 RVA: 0x0068F950 File Offset: 0x0068DB50
		public static Offset<IEntityActionContext> CreateIEntityActionContext(FlatBufferBuilder builder, StringOffset TypeOffset = default(StringOffset))
		{
			builder.StartTable(1);
			IEntityActionContext.AddType(builder, TypeOffset);
			return IEntityActionContext.EndIEntityActionContext(builder);
		}

		// Token: 0x06030456 RID: 197718 RVA: 0x0068F966 File Offset: 0x0068DB66
		public static void StartIEntityActionContext(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06030457 RID: 197719 RVA: 0x0068F96F File Offset: 0x0068DB6F
		public static void AddType(FlatBufferBuilder builder, StringOffset typeOffset)
		{
			builder.AddOffset(0, typeOffset.Value, 0);
		}

		// Token: 0x06030458 RID: 197720 RVA: 0x0068F97F File Offset: 0x0068DB7F
		public static Offset<IEntityActionContext> EndIEntityActionContext(FlatBufferBuilder builder)
		{
			return new Offset<IEntityActionContext>(builder.EndTable());
		}

		// Token: 0x06030459 RID: 197721 RVA: 0x0068F98C File Offset: 0x0068DB8C
		public IEntityActionContextT UnPack()
		{
			IEntityActionContextT entityActionContextT = new IEntityActionContextT();
			this.UnPackTo(entityActionContextT);
			return entityActionContextT;
		}

		// Token: 0x0603045A RID: 197722 RVA: 0x0068F9A7 File Offset: 0x0068DBA7
		public void UnPackTo(IEntityActionContextT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0603045B RID: 197723 RVA: 0x0068F9B8 File Offset: 0x0068DBB8
		public static Offset<IEntityActionContext> Pack(FlatBufferBuilder builder, IEntityActionContextT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityActionContext>);
			}
			StringOffset typeOffset = (_o.Type == null) ? default(StringOffset) : builder.CreateString(_o.Type);
			return IEntityActionContext.CreateIEntityActionContext(builder, typeOffset);
		}

		// Token: 0x04011BC4 RID: 72644
		private Table __p;
	}
}
