using System;
using Aki.UniverseEditor.Interface.Fbs.Editor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047A8 RID: 18344
	public struct IEntityDescription : IFlatbufferObject
	{
		// Token: 0x170083BB RID: 33723
		// (get) Token: 0x0601C4CD RID: 115917 RVA: 0x00401A4B File Offset: 0x003FFC4B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C4CE RID: 115918 RVA: 0x00401A58 File Offset: 0x003FFC58
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C4CF RID: 115919 RVA: 0x00401A60 File Offset: 0x003FFC60
		public static IEntityDescription GetRootAsIEntityDescription(ByteBuffer _bb)
		{
			return IEntityDescription.GetRootAsIEntityDescription(_bb, default(IEntityDescription));
		}

		// Token: 0x0601C4D0 RID: 115920 RVA: 0x00401A7C File Offset: 0x003FFC7C
		public static IEntityDescription GetRootAsIEntityDescription(ByteBuffer _bb, IEntityDescription obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C4D1 RID: 115921 RVA: 0x00401A99 File Offset: 0x003FFC99
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C4D2 RID: 115922 RVA: 0x00401AA8 File Offset: 0x003FFCA8
		public IEntityDescription __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170083BC RID: 33724
		// (get) Token: 0x0601C4D3 RID: 115923 RVA: 0x00401AB8 File Offset: 0x003FFCB8
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

		// Token: 0x0601C4D4 RID: 115924 RVA: 0x00401AEF File Offset: 0x003FFCEF
		public Span<byte> GetCategoryBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601C4D5 RID: 115925 RVA: 0x00401AFE File Offset: 0x003FFCFE
		public byte[] GetCategoryArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x170083BD RID: 33725
		// (get) Token: 0x0601C4D6 RID: 115926 RVA: 0x00401B0C File Offset: 0x003FFD0C
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

		// Token: 0x170083BE RID: 33726
		// (get) Token: 0x0601C4D7 RID: 115927 RVA: 0x00401B48 File Offset: 0x003FFD48
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

		// Token: 0x0601C4D8 RID: 115928 RVA: 0x00401B7F File Offset: 0x003FFD7F
		public Span<byte> GetStatusBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0601C4D9 RID: 115929 RVA: 0x00401B8E File Offset: 0x003FFD8E
		public byte[] GetStatusArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x170083BF RID: 33727
		// (get) Token: 0x0601C4DA RID: 115930 RVA: 0x00401B9C File Offset: 0x003FFD9C
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

		// Token: 0x0601C4DB RID: 115931 RVA: 0x00401BD4 File Offset: 0x003FFDD4
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0601C4DC RID: 115932 RVA: 0x00401BE4 File Offset: 0x003FFDE4
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x0601C4DD RID: 115933 RVA: 0x00401BF3 File Offset: 0x003FFDF3
		public static Offset<IEntityDescription> CreateIEntityDescription(FlatBufferBuilder builder, StringOffset CategoryOffset = default(StringOffset), ETdDeveloper Owner = ETdDeveloper.None, StringOffset StatusOffset = default(StringOffset), StringOffset DescriptionOffset = default(StringOffset))
		{
			builder.StartTable(4);
			IEntityDescription.AddDescription(builder, DescriptionOffset);
			IEntityDescription.AddStatus(builder, StatusOffset);
			IEntityDescription.AddCategory(builder, CategoryOffset);
			IEntityDescription.AddOwner(builder, Owner);
			return IEntityDescription.EndIEntityDescription(builder);
		}

		// Token: 0x0601C4DE RID: 115934 RVA: 0x00401C1F File Offset: 0x003FFE1F
		public static void StartIEntityDescription(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601C4DF RID: 115935 RVA: 0x00401C28 File Offset: 0x003FFE28
		public static void AddCategory(FlatBufferBuilder builder, StringOffset categoryOffset)
		{
			builder.AddOffset(0, categoryOffset.Value, 0);
		}

		// Token: 0x0601C4E0 RID: 115936 RVA: 0x00401C38 File Offset: 0x003FFE38
		public static void AddOwner(FlatBufferBuilder builder, ETdDeveloper owner)
		{
			builder.AddByte(1, (byte)owner, 0);
		}

		// Token: 0x0601C4E1 RID: 115937 RVA: 0x00401C43 File Offset: 0x003FFE43
		public static void AddStatus(FlatBufferBuilder builder, StringOffset statusOffset)
		{
			builder.AddOffset(2, statusOffset.Value, 0);
		}

		// Token: 0x0601C4E2 RID: 115938 RVA: 0x00401C53 File Offset: 0x003FFE53
		public static void AddDescription(FlatBufferBuilder builder, StringOffset descriptionOffset)
		{
			builder.AddOffset(3, descriptionOffset.Value, 0);
		}

		// Token: 0x0601C4E3 RID: 115939 RVA: 0x00401C63 File Offset: 0x003FFE63
		public static Offset<IEntityDescription> EndIEntityDescription(FlatBufferBuilder builder)
		{
			return new Offset<IEntityDescription>(builder.EndTable());
		}

		// Token: 0x0601C4E4 RID: 115940 RVA: 0x00401C70 File Offset: 0x003FFE70
		public IEntityDescriptionT UnPack()
		{
			IEntityDescriptionT entityDescriptionT = new IEntityDescriptionT();
			this.UnPackTo(entityDescriptionT);
			return entityDescriptionT;
		}

		// Token: 0x0601C4E5 RID: 115941 RVA: 0x00401C8B File Offset: 0x003FFE8B
		public void UnPackTo(IEntityDescriptionT _o)
		{
			_o.Category = this.Category;
			_o.Owner = this.Owner;
			_o.Status = this.Status;
			_o.Description = this.Description;
		}

		// Token: 0x0601C4E6 RID: 115942 RVA: 0x00401CC0 File Offset: 0x003FFEC0
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

		// Token: 0x0400CC26 RID: 52262
		private Table __p;
	}
}
