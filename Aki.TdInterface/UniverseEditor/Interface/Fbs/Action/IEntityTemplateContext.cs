using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D6D RID: 28013
	public struct IEntityTemplateContext : IFlatbufferObject
	{
		// Token: 0x1700CD84 RID: 52612
		// (get) Token: 0x0603054E RID: 197966 RVA: 0x006915BC File Offset: 0x0068F7BC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603054F RID: 197967 RVA: 0x006915C9 File Offset: 0x0068F7C9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030550 RID: 197968 RVA: 0x006915D0 File Offset: 0x0068F7D0
		public static IEntityTemplateContext GetRootAsIEntityTemplateContext(ByteBuffer _bb)
		{
			return IEntityTemplateContext.GetRootAsIEntityTemplateContext(_bb, default(IEntityTemplateContext));
		}

		// Token: 0x06030551 RID: 197969 RVA: 0x006915EC File Offset: 0x0068F7EC
		public static IEntityTemplateContext GetRootAsIEntityTemplateContext(ByteBuffer _bb, IEntityTemplateContext obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030552 RID: 197970 RVA: 0x00691609 File Offset: 0x0068F809
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030553 RID: 197971 RVA: 0x00691618 File Offset: 0x0068F818
		public IEntityTemplateContext __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CD85 RID: 52613
		// (get) Token: 0x06030554 RID: 197972 RVA: 0x00691628 File Offset: 0x0068F828
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

		// Token: 0x1700CD86 RID: 52614
		// (get) Token: 0x06030555 RID: 197973 RVA: 0x00691664 File Offset: 0x0068F864
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

		// Token: 0x06030556 RID: 197974 RVA: 0x0069169B File Offset: 0x0068F89B
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06030557 RID: 197975 RVA: 0x006916AA File Offset: 0x0068F8AA
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06030558 RID: 197976 RVA: 0x006916B8 File Offset: 0x0068F8B8
		public static Offset<IEntityTemplateContext> CreateIEntityTemplateContext(FlatBufferBuilder builder, EVarContext Type = EVarContext.None, StringOffset IdOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IEntityTemplateContext.AddId(builder, IdOffset);
			IEntityTemplateContext.AddType(builder, Type);
			return IEntityTemplateContext.EndIEntityTemplateContext(builder);
		}

		// Token: 0x06030559 RID: 197977 RVA: 0x006916D5 File Offset: 0x0068F8D5
		public static void StartIEntityTemplateContext(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603055A RID: 197978 RVA: 0x006916DE File Offset: 0x0068F8DE
		public static void AddType(FlatBufferBuilder builder, EVarContext type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603055B RID: 197979 RVA: 0x006916E9 File Offset: 0x0068F8E9
		public static void AddId(FlatBufferBuilder builder, StringOffset idOffset)
		{
			builder.AddOffset(1, idOffset.Value, 0);
		}

		// Token: 0x0603055C RID: 197980 RVA: 0x006916F9 File Offset: 0x0068F8F9
		public static Offset<IEntityTemplateContext> EndIEntityTemplateContext(FlatBufferBuilder builder)
		{
			return new Offset<IEntityTemplateContext>(builder.EndTable());
		}

		// Token: 0x0603055D RID: 197981 RVA: 0x00691708 File Offset: 0x0068F908
		public IEntityTemplateContextT UnPack()
		{
			IEntityTemplateContextT entityTemplateContextT = new IEntityTemplateContextT();
			this.UnPackTo(entityTemplateContextT);
			return entityTemplateContextT;
		}

		// Token: 0x0603055E RID: 197982 RVA: 0x00691723 File Offset: 0x0068F923
		public void UnPackTo(IEntityTemplateContextT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
		}

		// Token: 0x0603055F RID: 197983 RVA: 0x00691740 File Offset: 0x0068F940
		public static Offset<IEntityTemplateContext> Pack(FlatBufferBuilder builder, IEntityTemplateContextT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityTemplateContext>);
			}
			StringOffset idOffset = (_o.Id == null) ? default(StringOffset) : builder.CreateString(_o.Id);
			return IEntityTemplateContext.CreateIEntityTemplateContext(builder, _o.Type, idOffset);
		}

		// Token: 0x04011BF0 RID: 72688
		private Table __p;
	}
}
