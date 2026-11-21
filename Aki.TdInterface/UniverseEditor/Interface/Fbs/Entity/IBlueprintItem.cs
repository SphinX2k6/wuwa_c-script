using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004BE6 RID: 19430
	public struct IBlueprintItem : IFlatbufferObject
	{
		// Token: 0x17008979 RID: 35193
		// (get) Token: 0x0601DA92 RID: 121490 RVA: 0x00429993 File Offset: 0x00427B93
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DA93 RID: 121491 RVA: 0x004299A0 File Offset: 0x00427BA0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DA94 RID: 121492 RVA: 0x004299A8 File Offset: 0x00427BA8
		public static IBlueprintItem GetRootAsIBlueprintItem(ByteBuffer _bb)
		{
			return IBlueprintItem.GetRootAsIBlueprintItem(_bb, default(IBlueprintItem));
		}

		// Token: 0x0601DA95 RID: 121493 RVA: 0x004299C4 File Offset: 0x00427BC4
		public static IBlueprintItem GetRootAsIBlueprintItem(ByteBuffer _bb, IBlueprintItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DA96 RID: 121494 RVA: 0x004299E1 File Offset: 0x00427BE1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DA97 RID: 121495 RVA: 0x004299F0 File Offset: 0x00427BF0
		public IBlueprintItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700897A RID: 35194
		// (get) Token: 0x0601DA98 RID: 121496 RVA: 0x00429A00 File Offset: 0x00427C00
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

		// Token: 0x1700897B RID: 35195
		// (get) Token: 0x0601DA99 RID: 121497 RVA: 0x00429A3C File Offset: 0x00427C3C
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

		// Token: 0x0601DA9A RID: 121498 RVA: 0x00429A73 File Offset: 0x00427C73
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601DA9B RID: 121499 RVA: 0x00429A82 File Offset: 0x00427C82
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700897C RID: 35196
		// (get) Token: 0x0601DA9C RID: 121500 RVA: 0x00429A90 File Offset: 0x00427C90
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

		// Token: 0x1700897D RID: 35197
		// (get) Token: 0x0601DA9D RID: 121501 RVA: 0x00429ACC File Offset: 0x00427CCC
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

		// Token: 0x1700897E RID: 35198
		// (get) Token: 0x0601DA9E RID: 121502 RVA: 0x00429B0C File Offset: 0x00427D0C
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

		// Token: 0x1700897F RID: 35199
		// (get) Token: 0x0601DA9F RID: 121503 RVA: 0x00429B4C File Offset: 0x00427D4C
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

		// Token: 0x0601DAA0 RID: 121504 RVA: 0x00429B84 File Offset: 0x00427D84
		public Span<byte> GetMainTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0601DAA1 RID: 121505 RVA: 0x00429B94 File Offset: 0x00427D94
		public byte[] GetMainTypeArray()
		{
			return this.__p.__vector_as_array<byte>(14);
		}

		// Token: 0x17008980 RID: 35200
		// (get) Token: 0x0601DAA2 RID: 121506 RVA: 0x00429BA4 File Offset: 0x00427DA4
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

		// Token: 0x0601DAA3 RID: 121507 RVA: 0x00429BDC File Offset: 0x00427DDC
		public Span<byte> GetSubTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0601DAA4 RID: 121508 RVA: 0x00429BEC File Offset: 0x00427DEC
		public byte[] GetSubTypeArray()
		{
			return this.__p.__vector_as_array<byte>(16);
		}

		// Token: 0x17008981 RID: 35201
		// (get) Token: 0x0601DAA5 RID: 121509 RVA: 0x00429BFC File Offset: 0x00427DFC
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

		// Token: 0x0601DAA6 RID: 121510 RVA: 0x00429C34 File Offset: 0x00427E34
		public Span<byte> GetTagsBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0601DAA7 RID: 121511 RVA: 0x00429C44 File Offset: 0x00427E44
		public byte[] GetTagsArray()
		{
			return this.__p.__vector_as_array<byte>(18);
		}

		// Token: 0x17008982 RID: 35202
		// (get) Token: 0x0601DAA8 RID: 121512 RVA: 0x00429C54 File Offset: 0x00427E54
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

		// Token: 0x0601DAA9 RID: 121513 RVA: 0x00429C94 File Offset: 0x00427E94
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

		// Token: 0x0601DAAA RID: 121514 RVA: 0x00429CF4 File Offset: 0x00427EF4
		public static void StartIBlueprintItem(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x0601DAAB RID: 121515 RVA: 0x00429CFE File Offset: 0x00427EFE
		public static void AddEntityType(FlatBufferBuilder builder, EEntity entityType)
		{
			builder.AddUshort(0, (ushort)entityType, 0);
		}

		// Token: 0x0601DAAC RID: 121516 RVA: 0x00429D09 File Offset: 0x00427F09
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(1, nameOffset.Value, 0);
		}

		// Token: 0x0601DAAD RID: 121517 RVA: 0x00429D19 File Offset: 0x00427F19
		public static void AddEntityLogic(FlatBufferBuilder builder, EEntityLogic entityLogic)
		{
			builder.AddByte(2, (byte)entityLogic, 0);
		}

		// Token: 0x0601DAAE RID: 121518 RVA: 0x00429D24 File Offset: 0x00427F24
		public static void AddModelId(FlatBufferBuilder builder, int modelId)
		{
			builder.AddInt(3, modelId, 0);
		}

		// Token: 0x0601DAAF RID: 121519 RVA: 0x00429D2F File Offset: 0x00427F2F
		public static void AddHalfHeight(FlatBufferBuilder builder, int halfHeight)
		{
			builder.AddInt(4, halfHeight, 0);
		}

		// Token: 0x0601DAB0 RID: 121520 RVA: 0x00429D3A File Offset: 0x00427F3A
		public static void AddMainType(FlatBufferBuilder builder, StringOffset mainTypeOffset)
		{
			builder.AddOffset(5, mainTypeOffset.Value, 0);
		}

		// Token: 0x0601DAB1 RID: 121521 RVA: 0x00429D4A File Offset: 0x00427F4A
		public static void AddSubType(FlatBufferBuilder builder, StringOffset subTypeOffset)
		{
			builder.AddOffset(6, subTypeOffset.Value, 0);
		}

		// Token: 0x0601DAB2 RID: 121522 RVA: 0x00429D5A File Offset: 0x00427F5A
		public static void AddTags(FlatBufferBuilder builder, StringOffset tagsOffset)
		{
			builder.AddOffset(7, tagsOffset.Value, 0);
		}

		// Token: 0x0601DAB3 RID: 121523 RVA: 0x00429D6A File Offset: 0x00427F6A
		public static void AddTrackHeight(FlatBufferBuilder builder, int trackHeight)
		{
			builder.AddInt(8, trackHeight, 0);
		}

		// Token: 0x0601DAB4 RID: 121524 RVA: 0x00429D75 File Offset: 0x00427F75
		public static Offset<IBlueprintItem> EndIBlueprintItem(FlatBufferBuilder builder)
		{
			return new Offset<IBlueprintItem>(builder.EndTable());
		}

		// Token: 0x0601DAB5 RID: 121525 RVA: 0x00429D84 File Offset: 0x00427F84
		public IBlueprintItemT UnPack()
		{
			IBlueprintItemT blueprintItemT = new IBlueprintItemT();
			this.UnPackTo(blueprintItemT);
			return blueprintItemT;
		}

		// Token: 0x0601DAB6 RID: 121526 RVA: 0x00429DA0 File Offset: 0x00427FA0
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

		// Token: 0x0601DAB7 RID: 121527 RVA: 0x00429E1C File Offset: 0x0042801C
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

		// Token: 0x0400D60E RID: 54798
		private Table __p;
	}
}
