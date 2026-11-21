using System;
using Aki.UniverseEditor.Interface.Fbs.Editor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C10 RID: 19472
	public struct IEntityDescription : IFlatbufferObject
	{
		// Token: 0x170089FC RID: 35324
		// (get) Token: 0x0601DCA2 RID: 122018 RVA: 0x0042DCE7 File Offset: 0x0042BEE7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DCA3 RID: 122019 RVA: 0x0042DCF4 File Offset: 0x0042BEF4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DCA4 RID: 122020 RVA: 0x0042DCFC File Offset: 0x0042BEFC
		public static IEntityDescription GetRootAsIEntityDescription(ByteBuffer _bb)
		{
			return IEntityDescription.GetRootAsIEntityDescription(_bb, default(IEntityDescription));
		}

		// Token: 0x0601DCA5 RID: 122021 RVA: 0x0042DD18 File Offset: 0x0042BF18
		public static IEntityDescription GetRootAsIEntityDescription(ByteBuffer _bb, IEntityDescription obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DCA6 RID: 122022 RVA: 0x0042DD35 File Offset: 0x0042BF35
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DCA7 RID: 122023 RVA: 0x0042DD44 File Offset: 0x0042BF44
		public IEntityDescription __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170089FD RID: 35325
		// (get) Token: 0x0601DCA8 RID: 122024 RVA: 0x0042DD54 File Offset: 0x0042BF54
		public string Category
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

		// Token: 0x0601DCA9 RID: 122025 RVA: 0x0042DD8B File Offset: 0x0042BF8B
		public Span<byte> GetCategoryBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601DCAA RID: 122026 RVA: 0x0042DD9A File Offset: 0x0042BF9A
		public byte[] GetCategoryArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x170089FE RID: 35326
		// (get) Token: 0x0601DCAB RID: 122027 RVA: 0x0042DDA8 File Offset: 0x0042BFA8
		public ETdDeveloper Owner
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ETdDeveloper.None;
				}
				return (ETdDeveloper)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170089FF RID: 35327
		// (get) Token: 0x0601DCAC RID: 122028 RVA: 0x0042DDE4 File Offset: 0x0042BFE4
		public string Status
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

		// Token: 0x0601DCAD RID: 122029 RVA: 0x0042DE1B File Offset: 0x0042C01B
		public Span<byte> GetStatusBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0601DCAE RID: 122030 RVA: 0x0042DE2A File Offset: 0x0042C02A
		public byte[] GetStatusArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x17008A00 RID: 35328
		// (get) Token: 0x0601DCAF RID: 122031 RVA: 0x0042DE38 File Offset: 0x0042C038
		public string Description
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

		// Token: 0x0601DCB0 RID: 122032 RVA: 0x0042DE70 File Offset: 0x0042C070
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0601DCB1 RID: 122033 RVA: 0x0042DE80 File Offset: 0x0042C080
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x0601DCB2 RID: 122034 RVA: 0x0042DE8F File Offset: 0x0042C08F
		public static Offset<IEntityDescription> CreateIEntityDescription(FlatBufferBuilder builder, StringOffset CategoryOffset = default(StringOffset), ETdDeveloper Owner = ETdDeveloper.None, StringOffset StatusOffset = default(StringOffset), StringOffset DescriptionOffset = default(StringOffset))
		{
			builder.StartTable(4);
			IEntityDescription.AddDescription(builder, DescriptionOffset);
			IEntityDescription.AddStatus(builder, StatusOffset);
			IEntityDescription.AddCategory(builder, CategoryOffset);
			IEntityDescription.AddOwner(builder, Owner);
			return IEntityDescription.EndIEntityDescription(builder);
		}

		// Token: 0x0601DCB3 RID: 122035 RVA: 0x0042DEBB File Offset: 0x0042C0BB
		public static void StartIEntityDescription(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601DCB4 RID: 122036 RVA: 0x0042DEC4 File Offset: 0x0042C0C4
		public static void AddCategory(FlatBufferBuilder builder, StringOffset categoryOffset)
		{
			builder.AddOffset(0, categoryOffset.Value, 0);
		}

		// Token: 0x0601DCB5 RID: 122037 RVA: 0x0042DED4 File Offset: 0x0042C0D4
		public static void AddOwner(FlatBufferBuilder builder, ETdDeveloper owner)
		{
			builder.AddByte(1, (byte)owner, 0);
		}

		// Token: 0x0601DCB6 RID: 122038 RVA: 0x0042DEDF File Offset: 0x0042C0DF
		public static void AddStatus(FlatBufferBuilder builder, StringOffset statusOffset)
		{
			builder.AddOffset(2, statusOffset.Value, 0);
		}

		// Token: 0x0601DCB7 RID: 122039 RVA: 0x0042DEEF File Offset: 0x0042C0EF
		public static void AddDescription(FlatBufferBuilder builder, StringOffset descriptionOffset)
		{
			builder.AddOffset(3, descriptionOffset.Value, 0);
		}

		// Token: 0x0601DCB8 RID: 122040 RVA: 0x0042DEFF File Offset: 0x0042C0FF
		public static Offset<IEntityDescription> EndIEntityDescription(FlatBufferBuilder builder)
		{
			return new Offset<IEntityDescription>(builder.EndTable());
		}

		// Token: 0x0601DCB9 RID: 122041 RVA: 0x0042DF0C File Offset: 0x0042C10C
		public IEntityDescriptionT UnPack()
		{
			IEntityDescriptionT entityDescriptionT = new IEntityDescriptionT();
			this.UnPackTo(entityDescriptionT);
			return entityDescriptionT;
		}

		// Token: 0x0601DCBA RID: 122042 RVA: 0x0042DF27 File Offset: 0x0042C127
		public void UnPackTo(IEntityDescriptionT _o)
		{
			_o.Category = this.Category;
			_o.Owner = this.Owner;
			_o.Status = this.Status;
			_o.Description = this.Description;
		}

		// Token: 0x0601DCBB RID: 122043 RVA: 0x0042DF5C File Offset: 0x0042C15C
		public static Offset<IEntityDescription> Pack(FlatBufferBuilder builder, IEntityDescriptionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityDescription>);
			}
			StringOffset categoryOffset = (_o.Category == null) ? default(StringOffset) : builder.CreateString(_o.Category);
			StringOffset statusOffset = (_o.Status == null) ? default(StringOffset) : builder.CreateString(_o.Status);
			StringOffset descriptionOffset = (_o.Description == null) ? default(StringOffset) : builder.CreateString(_o.Description);
			return IEntityDescription.CreateIEntityDescription(builder, categoryOffset, _o.Owner, statusOffset, descriptionOffset);
		}

		// Token: 0x0400D65C RID: 54876
		private Table __p;
	}
}
