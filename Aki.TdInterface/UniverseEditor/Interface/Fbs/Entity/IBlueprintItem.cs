using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x0200477E RID: 18302
	public struct IBlueprintItem : IFlatbufferObject
	{
		// Token: 0x17008338 RID: 33592
		// (get) Token: 0x0601C2BD RID: 115389 RVA: 0x003FD6F7 File Offset: 0x003FB8F7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C2BE RID: 115390 RVA: 0x003FD704 File Offset: 0x003FB904
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C2BF RID: 115391 RVA: 0x003FD70C File Offset: 0x003FB90C
		public static IBlueprintItem GetRootAsIBlueprintItem(ByteBuffer _bb)
		{
			return IBlueprintItem.GetRootAsIBlueprintItem(_bb, default(IBlueprintItem));
		}

		// Token: 0x0601C2C0 RID: 115392 RVA: 0x003FD728 File Offset: 0x003FB928
		public static IBlueprintItem GetRootAsIBlueprintItem(ByteBuffer _bb, IBlueprintItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C2C1 RID: 115393 RVA: 0x003FD745 File Offset: 0x003FB945
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C2C2 RID: 115394 RVA: 0x003FD754 File Offset: 0x003FB954
		public IBlueprintItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008339 RID: 33593
		// (get) Token: 0x0601C2C3 RID: 115395 RVA: 0x003FD764 File Offset: 0x003FB964
		public EEntity EntityType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EEntity.CharacterEntity;
				}
				return (EEntity)this.__p.bb.GetUshort(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700833A RID: 33594
		// (get) Token: 0x0601C2C4 RID: 115396 RVA: 0x003FD7A0 File Offset: 0x003FB9A0
		public string Name
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

		// Token: 0x0601C2C5 RID: 115397 RVA: 0x003FD7D7 File Offset: 0x003FB9D7
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601C2C6 RID: 115398 RVA: 0x003FD7E6 File Offset: 0x003FB9E6
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700833B RID: 33595
		// (get) Token: 0x0601C2C7 RID: 115399 RVA: 0x003FD7F4 File Offset: 0x003FB9F4
		public EEntityLogic EntityLogic
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return EEntityLogic.Item;
				}
				return (EEntityLogic)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700833C RID: 33596
		// (get) Token: 0x0601C2C8 RID: 115400 RVA: 0x003FD830 File Offset: 0x003FBA30
		public int ModelId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700833D RID: 33597
		// (get) Token: 0x0601C2C9 RID: 115401 RVA: 0x003FD870 File Offset: 0x003FBA70
		public int HalfHeight
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700833E RID: 33598
		// (get) Token: 0x0601C2CA RID: 115402 RVA: 0x003FD8B0 File Offset: 0x003FBAB0
		public string MainType
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601C2CB RID: 115403 RVA: 0x003FD8E8 File Offset: 0x003FBAE8
		public Span<byte> GetMainTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0601C2CC RID: 115404 RVA: 0x003FD8F8 File Offset: 0x003FBAF8
		public byte[] GetMainTypeArray()
		{
			return this.__p.__vector_as_array<byte>(14);
		}

		// Token: 0x1700833F RID: 33599
		// (get) Token: 0x0601C2CD RID: 115405 RVA: 0x003FD908 File Offset: 0x003FBB08
		public string SubType
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601C2CE RID: 115406 RVA: 0x003FD940 File Offset: 0x003FBB40
		public Span<byte> GetSubTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0601C2CF RID: 115407 RVA: 0x003FD950 File Offset: 0x003FBB50
		public byte[] GetSubTypeArray()
		{
			return this.__p.__vector_as_array<byte>(16);
		}

		// Token: 0x17008340 RID: 33600
		// (get) Token: 0x0601C2D0 RID: 115408 RVA: 0x003FD960 File Offset: 0x003FBB60
		public string Tags
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601C2D1 RID: 115409 RVA: 0x003FD998 File Offset: 0x003FBB98
		public Span<byte> GetTagsBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0601C2D2 RID: 115410 RVA: 0x003FD9A8 File Offset: 0x003FBBA8
		public byte[] GetTagsArray()
		{
			return this.__p.__vector_as_array<byte>(18);
		}

		// Token: 0x17008341 RID: 33601
		// (get) Token: 0x0601C2D3 RID: 115411 RVA: 0x003FD9B8 File Offset: 0x003FBBB8
		public int TrackHeight
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601C2D4 RID: 115412 RVA: 0x003FD9F8 File Offset: 0x003FBBF8
		public static Offset<IBlueprintItem> CreateIBlueprintItem(FlatBufferBuilder builder, EEntity EntityType = EEntity.CharacterEntity, StringOffset NameOffset = default(StringOffset), EEntityLogic EntityLogic = EEntityLogic.Item, int ModelId = 0, int HalfHeight = 0, StringOffset MainTypeOffset = default(StringOffset), StringOffset SubTypeOffset = default(StringOffset), StringOffset TagsOffset = default(StringOffset), int TrackHeight = 0)
		{
			builder.StartTable(9);
			IBlueprintItem.AddTrackHeight(builder, TrackHeight);
			IBlueprintItem.AddTags(builder, TagsOffset);
			IBlueprintItem.AddSubType(builder, SubTypeOffset);
			IBlueprintItem.AddMainType(builder, MainTypeOffset);
			IBlueprintItem.AddHalfHeight(builder, HalfHeight);
			IBlueprintItem.AddModelId(builder, ModelId);
			IBlueprintItem.AddName(builder, NameOffset);
			IBlueprintItem.AddEntityType(builder, EntityType);
			IBlueprintItem.AddEntityLogic(builder, EntityLogic);
			return IBlueprintItem.EndIBlueprintItem(builder);
		}

		// Token: 0x0601C2D5 RID: 115413 RVA: 0x003FDA58 File Offset: 0x003FBC58
		public static void StartIBlueprintItem(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x0601C2D6 RID: 115414 RVA: 0x003FDA62 File Offset: 0x003FBC62
		public static void AddEntityType(FlatBufferBuilder builder, EEntity entityType)
		{
			builder.AddUshort(0, (ushort)entityType, 0);
		}

		// Token: 0x0601C2D7 RID: 115415 RVA: 0x003FDA6D File Offset: 0x003FBC6D
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(1, nameOffset.Value, 0);
		}

		// Token: 0x0601C2D8 RID: 115416 RVA: 0x003FDA7D File Offset: 0x003FBC7D
		public static void AddEntityLogic(FlatBufferBuilder builder, EEntityLogic entityLogic)
		{
			builder.AddByte(2, (byte)entityLogic, 0);
		}

		// Token: 0x0601C2D9 RID: 115417 RVA: 0x003FDA88 File Offset: 0x003FBC88
		public static void AddModelId(FlatBufferBuilder builder, int modelId)
		{
			builder.AddInt(3, modelId, 0);
		}

		// Token: 0x0601C2DA RID: 115418 RVA: 0x003FDA93 File Offset: 0x003FBC93
		public static void AddHalfHeight(FlatBufferBuilder builder, int halfHeight)
		{
			builder.AddInt(4, halfHeight, 0);
		}

		// Token: 0x0601C2DB RID: 115419 RVA: 0x003FDA9E File Offset: 0x003FBC9E
		public static void AddMainType(FlatBufferBuilder builder, StringOffset mainTypeOffset)
		{
			builder.AddOffset(5, mainTypeOffset.Value, 0);
		}

		// Token: 0x0601C2DC RID: 115420 RVA: 0x003FDAAE File Offset: 0x003FBCAE
		public static void AddSubType(FlatBufferBuilder builder, StringOffset subTypeOffset)
		{
			builder.AddOffset(6, subTypeOffset.Value, 0);
		}

		// Token: 0x0601C2DD RID: 115421 RVA: 0x003FDABE File Offset: 0x003FBCBE
		public static void AddTags(FlatBufferBuilder builder, StringOffset tagsOffset)
		{
			builder.AddOffset(7, tagsOffset.Value, 0);
		}

		// Token: 0x0601C2DE RID: 115422 RVA: 0x003FDACE File Offset: 0x003FBCCE
		public static void AddTrackHeight(FlatBufferBuilder builder, int trackHeight)
		{
			builder.AddInt(8, trackHeight, 0);
		}

		// Token: 0x0601C2DF RID: 115423 RVA: 0x003FDAD9 File Offset: 0x003FBCD9
		public static Offset<IBlueprintItem> EndIBlueprintItem(FlatBufferBuilder builder)
		{
			return new Offset<IBlueprintItem>(builder.EndTable());
		}

		// Token: 0x0601C2E0 RID: 115424 RVA: 0x003FDAE8 File Offset: 0x003FBCE8
		public IBlueprintItemT UnPack()
		{
			IBlueprintItemT blueprintItemT = new IBlueprintItemT();
			this.UnPackTo(blueprintItemT);
			return blueprintItemT;
		}

		// Token: 0x0601C2E1 RID: 115425 RVA: 0x003FDB04 File Offset: 0x003FBD04
		public void UnPackTo(IBlueprintItemT _o)
		{
			_o.EntityType = this.EntityType;
			_o.Name = this.Name;
			_o.EntityLogic = this.EntityLogic;
			_o.ModelId = this.ModelId;
			_o.HalfHeight = this.HalfHeight;
			_o.MainType = this.MainType;
			_o.SubType = this.SubType;
			_o.Tags = this.Tags;
			_o.TrackHeight = this.TrackHeight;
		}

		// Token: 0x0601C2E2 RID: 115426 RVA: 0x003FDB80 File Offset: 0x003FBD80
		public static Offset<IBlueprintItem> Pack(FlatBufferBuilder builder, IBlueprintItemT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBlueprintItem>);
			}
			StringOffset nameOffset = (_o.Name == null) ? default(StringOffset) : builder.CreateString(_o.Name);
			StringOffset mainTypeOffset = (_o.MainType == null) ? default(StringOffset) : builder.CreateString(_o.MainType);
			StringOffset subTypeOffset = (_o.SubType == null) ? default(StringOffset) : builder.CreateString(_o.SubType);
			StringOffset tagsOffset = (_o.Tags == null) ? default(StringOffset) : builder.CreateString(_o.Tags);
			return IBlueprintItem.CreateIBlueprintItem(builder, _o.EntityType, nameOffset, _o.EntityLogic, _o.ModelId, _o.HalfHeight, mainTypeOffset, subTypeOffset, tagsOffset, _o.TrackHeight);
		}

		// Token: 0x0400CBD8 RID: 52184
		private Table __p;
	}
}
