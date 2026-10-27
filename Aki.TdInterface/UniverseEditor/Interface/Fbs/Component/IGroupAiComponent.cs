using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005330 RID: 21296
	public struct IGroupAiComponent : IFlatbufferObject
	{
		// Token: 0x17009C6F RID: 40047
		// (get) Token: 0x06022D0E RID: 142606 RVA: 0x004D2F83 File Offset: 0x004D1183
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022D0F RID: 142607 RVA: 0x004D2F90 File Offset: 0x004D1190
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022D10 RID: 142608 RVA: 0x004D2F98 File Offset: 0x004D1198
		public static IGroupAiComponent GetRootAsIGroupAiComponent(ByteBuffer _bb)
		{
			return IGroupAiComponent.GetRootAsIGroupAiComponent(_bb, default(IGroupAiComponent));
		}

		// Token: 0x06022D11 RID: 142609 RVA: 0x004D2FB4 File Offset: 0x004D11B4
		public static IGroupAiComponent GetRootAsIGroupAiComponent(ByteBuffer _bb, IGroupAiComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022D12 RID: 142610 RVA: 0x004D2FD1 File Offset: 0x004D11D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022D13 RID: 142611 RVA: 0x004D2FE0 File Offset: 0x004D11E0
		public IGroupAiComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009C70 RID: 40048
		// (get) Token: 0x06022D14 RID: 142612 RVA: 0x004D2FF0 File Offset: 0x004D11F0
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06022D15 RID: 142613 RVA: 0x004D3030 File Offset: 0x004D1230
		public int Entities(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17009C71 RID: 40049
		// (get) Token: 0x06022D16 RID: 142614 RVA: 0x004D3070 File Offset: 0x004D1270
		public int EntitiesLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06022D17 RID: 142615 RVA: 0x004D309B File Offset: 0x004D129B
		public Span<int> GetEntitiesBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06022D18 RID: 142616 RVA: 0x004D30AA File Offset: 0x004D12AA
		public int[] GetEntitiesArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x17009C72 RID: 40050
		// (get) Token: 0x06022D19 RID: 142617 RVA: 0x004D30B8 File Offset: 0x004D12B8
		public TGroupAiOption OptionType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TGroupAiOption.NONE;
				}
				return (TGroupAiOption)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06022D1A RID: 142618 RVA: 0x004D30F4 File Offset: 0x004D12F4
		public TTable? Option<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06022D1B RID: 142619 RVA: 0x004D313C File Offset: 0x004D133C
		public IGroupAiModeDefault OptionAsIGroupAiModeDefault()
		{
			return this.Option<IGroupAiModeDefault>().Value;
		}

		// Token: 0x06022D1C RID: 142620 RVA: 0x004D3158 File Offset: 0x004D1358
		public IGroupAiMonsterEcology OptionAsIGroupAiMonsterEcology()
		{
			return this.Option<IGroupAiMonsterEcology>().Value;
		}

		// Token: 0x06022D1D RID: 142621 RVA: 0x004D3174 File Offset: 0x004D1374
		public IGroupAiPatrol OptionAsIGroupAiPatrol()
		{
			return this.Option<IGroupAiPatrol>().Value;
		}

		// Token: 0x06022D1E RID: 142622 RVA: 0x004D3190 File Offset: 0x004D1390
		public string SyncTags(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17009C73 RID: 40051
		// (get) Token: 0x06022D1F RID: 142623 RVA: 0x004D31CC File Offset: 0x004D13CC
		public int SyncTagsLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17009C74 RID: 40052
		// (get) Token: 0x06022D20 RID: 142624 RVA: 0x004D31F8 File Offset: 0x004D13F8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06022D21 RID: 142625 RVA: 0x004D3235 File Offset: 0x004D1435
		public static Offset<IGroupAiComponent> CreateIGroupAiComponent(FlatBufferBuilder builder, bool Disabled = false, VectorOffset EntitiesOffset = default(VectorOffset), TGroupAiOption Option_type = TGroupAiOption.NONE, int OptionOffset = 0, VectorOffset SyncTagsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(6);
			IGroupAiComponent.AddSyncTags(builder, SyncTagsOffset);
			IGroupAiComponent.AddOption(builder, OptionOffset);
			IGroupAiComponent.AddEntities(builder, EntitiesOffset);
			IGroupAiComponent.AddNullMask(builder, NullMask);
			IGroupAiComponent.AddOptionType(builder, Option_type);
			IGroupAiComponent.AddDisabled(builder, Disabled);
			return IGroupAiComponent.EndIGroupAiComponent(builder);
		}

		// Token: 0x06022D22 RID: 142626 RVA: 0x004D3271 File Offset: 0x004D1471
		public static void StartIGroupAiComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06022D23 RID: 142627 RVA: 0x004D327A File Offset: 0x004D147A
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06022D24 RID: 142628 RVA: 0x004D3285 File Offset: 0x004D1485
		public static void AddEntities(FlatBufferBuilder builder, VectorOffset entitiesOffset)
		{
			builder.AddOffset(1, entitiesOffset.Value, 0);
		}

		// Token: 0x06022D25 RID: 142629 RVA: 0x004D3298 File Offset: 0x004D1498
		public static VectorOffset CreateEntitiesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06022D26 RID: 142630 RVA: 0x004D32CF File Offset: 0x004D14CF
		public static VectorOffset CreateEntitiesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06022D27 RID: 142631 RVA: 0x004D32E9 File Offset: 0x004D14E9
		public static VectorOffset CreateEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06022D28 RID: 142632 RVA: 0x004D3307 File Offset: 0x004D1507
		public static VectorOffset CreateEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06022D29 RID: 142633 RVA: 0x004D3320 File Offset: 0x004D1520
		public static void StartEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06022D2A RID: 142634 RVA: 0x004D332B File Offset: 0x004D152B
		public static void AddOptionType(FlatBufferBuilder builder, TGroupAiOption optionType)
		{
			builder.AddByte(2, (byte)optionType, 0);
		}

		// Token: 0x06022D2B RID: 142635 RVA: 0x004D3336 File Offset: 0x004D1536
		public static void AddOption(FlatBufferBuilder builder, int optionOffset)
		{
			builder.AddOffset(3, optionOffset, 0);
		}

		// Token: 0x06022D2C RID: 142636 RVA: 0x004D3341 File Offset: 0x004D1541
		public static void AddSyncTags(FlatBufferBuilder builder, VectorOffset syncTagsOffset)
		{
			builder.AddOffset(4, syncTagsOffset.Value, 0);
		}

		// Token: 0x06022D2D RID: 142637 RVA: 0x004D3354 File Offset: 0x004D1554
		public static VectorOffset CreateSyncTagsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06022D2E RID: 142638 RVA: 0x004D3394 File Offset: 0x004D1594
		public static VectorOffset CreateSyncTagsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06022D2F RID: 142639 RVA: 0x004D33AE File Offset: 0x004D15AE
		public static VectorOffset CreateSyncTagsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06022D30 RID: 142640 RVA: 0x004D33CC File Offset: 0x004D15CC
		public static VectorOffset CreateSyncTagsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06022D31 RID: 142641 RVA: 0x004D33E5 File Offset: 0x004D15E5
		public static void StartSyncTagsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06022D32 RID: 142642 RVA: 0x004D33F0 File Offset: 0x004D15F0
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06022D33 RID: 142643 RVA: 0x004D33FB File Offset: 0x004D15FB
		public static Offset<IGroupAiComponent> EndIGroupAiComponent(FlatBufferBuilder builder)
		{
			return new Offset<IGroupAiComponent>(builder.EndTable());
		}

		// Token: 0x06022D34 RID: 142644 RVA: 0x004D3408 File Offset: 0x004D1608
		public IGroupAiComponentT UnPack()
		{
			IGroupAiComponentT groupAiComponentT = new IGroupAiComponentT();
			this.UnPackTo(groupAiComponentT);
			return groupAiComponentT;
		}

		// Token: 0x06022D35 RID: 142645 RVA: 0x004D3424 File Offset: 0x004D1624
		public void UnPackTo(IGroupAiComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.Entities = new List<int>();
			for (int i = 0; i < this.EntitiesLength; i++)
			{
				_o.Entities.Add(this.Entities(i));
			}
			_o.Option = new TGroupAiOptionUnion();
			_o.Option.Type = this.OptionType;
			switch (this.OptionType)
			{
			case TGroupAiOption.IGroupAiModeDefault:
				_o.Option.Value = ((this.Option<IGroupAiModeDefault>() != null) ? this.Option<IGroupAiModeDefault>().Value.UnPack() : null);
				break;
			case TGroupAiOption.IGroupAiMonsterEcology:
				_o.Option.Value = ((this.Option<IGroupAiMonsterEcology>() != null) ? this.Option<IGroupAiMonsterEcology>().Value.UnPack() : null);
				break;
			case TGroupAiOption.IGroupAiPatrol:
				_o.Option.Value = ((this.Option<IGroupAiPatrol>() != null) ? this.Option<IGroupAiPatrol>().Value.UnPack() : null);
				break;
			}
			_o.SyncTags = new List<string>();
			for (int j = 0; j < this.SyncTagsLength; j++)
			{
				_o.SyncTags.Add(this.SyncTags(j));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06022D36 RID: 142646 RVA: 0x004D358C File Offset: 0x004D178C
		public static Offset<IGroupAiComponent> Pack(FlatBufferBuilder builder, IGroupAiComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGroupAiComponent>);
			}
			VectorOffset entitiesOffset = default(VectorOffset);
			if (_o.Entities != null)
			{
				int[] data = _o.Entities.ToArray();
				entitiesOffset = IGroupAiComponent.CreateEntitiesVector(builder, data);
			}
			TGroupAiOption option_type = (_o.Option == null) ? TGroupAiOption.NONE : _o.Option.Type;
			int optionOffset = (_o.Option == null) ? 0 : TGroupAiOptionUnion.Pack(builder, _o.Option);
			VectorOffset syncTagsOffset = default(VectorOffset);
			if (_o.SyncTags != null)
			{
				StringOffset[] array = new StringOffset[_o.SyncTags.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = builder.CreateString(_o.SyncTags[i]);
				}
				syncTagsOffset = IGroupAiComponent.CreateSyncTagsVector(builder, array);
			}
			return IGroupAiComponent.CreateIGroupAiComponent(builder, _o.Disabled, entitiesOffset, option_type, optionOffset, syncTagsOffset, _o.NullMask);
		}

		// Token: 0x0400E4F4 RID: 58612
		private Table __p;
	}
}
