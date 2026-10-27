using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066ED RID: 26349
	public struct IEntityTemplateContext : IFlatbufferObject
	{
		// Token: 0x1700C3CE RID: 50126
		// (get) Token: 0x0602DD11 RID: 187665 RVA: 0x00644048 File Offset: 0x00642248
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DD12 RID: 187666 RVA: 0x00644055 File Offset: 0x00642255
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DD13 RID: 187667 RVA: 0x0064405C File Offset: 0x0064225C
		public static IEntityTemplateContext GetRootAsIEntityTemplateContext(ByteBuffer _bb)
		{
			return IEntityTemplateContext.GetRootAsIEntityTemplateContext(_bb, default(IEntityTemplateContext));
		}

		// Token: 0x0602DD14 RID: 187668 RVA: 0x00644078 File Offset: 0x00642278
		public static IEntityTemplateContext GetRootAsIEntityTemplateContext(ByteBuffer _bb, IEntityTemplateContext obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DD15 RID: 187669 RVA: 0x00644095 File Offset: 0x00642295
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DD16 RID: 187670 RVA: 0x006440A4 File Offset: 0x006422A4
		public IEntityTemplateContext __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C3CF RID: 50127
		// (get) Token: 0x0602DD17 RID: 187671 RVA: 0x006440B4 File Offset: 0x006422B4
		public EVarContext Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVarContext.None;
				}
				return (EVarContext)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C3D0 RID: 50128
		// (get) Token: 0x0602DD18 RID: 187672 RVA: 0x006440F0 File Offset: 0x006422F0
		public string Id
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

		// Token: 0x0602DD19 RID: 187673 RVA: 0x00644127 File Offset: 0x00642327
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602DD1A RID: 187674 RVA: 0x00644136 File Offset: 0x00642336
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602DD1B RID: 187675 RVA: 0x00644144 File Offset: 0x00642344
		public static Offset<IEntityTemplateContext> CreateIEntityTemplateContext(FlatBufferBuilder builder, EVarContext Type = EVarContext.None, StringOffset IdOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IEntityTemplateContext.AddId(builder, IdOffset);
			IEntityTemplateContext.AddType(builder, Type);
			return IEntityTemplateContext.EndIEntityTemplateContext(builder);
		}

		// Token: 0x0602DD1C RID: 187676 RVA: 0x00644161 File Offset: 0x00642361
		public static void StartIEntityTemplateContext(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602DD1D RID: 187677 RVA: 0x0064416A File Offset: 0x0064236A
		public static void AddType(FlatBufferBuilder builder, EVarContext type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602DD1E RID: 187678 RVA: 0x00644175 File Offset: 0x00642375
		public static void AddId(FlatBufferBuilder builder, StringOffset idOffset)
		{
			builder.AddOffset(1, idOffset.Value, 0);
		}

		// Token: 0x0602DD1F RID: 187679 RVA: 0x00644185 File Offset: 0x00642385
		public static Offset<IEntityTemplateContext> EndIEntityTemplateContext(FlatBufferBuilder builder)
		{
			return new Offset<IEntityTemplateContext>(builder.EndTable());
		}

		// Token: 0x0602DD20 RID: 187680 RVA: 0x00644194 File Offset: 0x00642394
		public IEntityTemplateContextT UnPack()
		{
			IEntityTemplateContextT entityTemplateContextT = new IEntityTemplateContextT();
			this.UnPackTo(entityTemplateContextT);
			return entityTemplateContextT;
		}

		// Token: 0x0602DD21 RID: 187681 RVA: 0x006441AF File Offset: 0x006423AF
		public void UnPackTo(IEntityTemplateContextT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
		}

		// Token: 0x0602DD22 RID: 187682 RVA: 0x006441CC File Offset: 0x006423CC
		public static Offset<IEntityTemplateContext> Pack(FlatBufferBuilder builder, IEntityTemplateContextT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityTemplateContext>);
			}
			StringOffset idOffset = (_o.Id == null) ? default(StringOffset) : builder.CreateString(_o.Id);
			return IEntityTemplateContext.CreateIEntityTemplateContext(builder, _o.Type, idOffset);
		}

		// Token: 0x04010DC1 RID: 69057
		private Table __p;
	}
}
