using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068E5 RID: 26853
	public struct IHideGroup : IFlatbufferObject
	{
		// Token: 0x1700C73F RID: 51007
		// (get) Token: 0x0602ED76 RID: 191862 RVA: 0x00664044 File Offset: 0x00662244
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602ED77 RID: 191863 RVA: 0x00664051 File Offset: 0x00662251
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602ED78 RID: 191864 RVA: 0x00664058 File Offset: 0x00662258
		public static IHideGroup GetRootAsIHideGroup(ByteBuffer _bb)
		{
			return IHideGroup.GetRootAsIHideGroup(_bb, default(IHideGroup));
		}

		// Token: 0x0602ED79 RID: 191865 RVA: 0x00664074 File Offset: 0x00662274
		public static IHideGroup GetRootAsIHideGroup(ByteBuffer _bb, IHideGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602ED7A RID: 191866 RVA: 0x00664091 File Offset: 0x00662291
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602ED7B RID: 191867 RVA: 0x006640A0 File Offset: 0x006622A0
		public IHideGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C740 RID: 51008
		// (get) Token: 0x0602ED7C RID: 191868 RVA: 0x006640B0 File Offset: 0x006622B0
		public string GroupKey
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

		// Token: 0x0602ED7D RID: 191869 RVA: 0x006640E7 File Offset: 0x006622E7
		public Span<byte> GetGroupKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602ED7E RID: 191870 RVA: 0x006640F6 File Offset: 0x006622F6
		public byte[] GetGroupKeyArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700C741 RID: 51009
		// (get) Token: 0x0602ED7F RID: 191871 RVA: 0x00664104 File Offset: 0x00662304
		public THideGroupConfig HideConfigType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return THideGroupConfig.NONE;
				}
				return (THideGroupConfig)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602ED80 RID: 191872 RVA: 0x00664140 File Offset: 0x00662340
		public TTable? HideConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602ED81 RID: 191873 RVA: 0x00664184 File Offset: 0x00662384
		public IHideSpecifyDataLayers HideConfigAsIHideSpecifyDataLayers()
		{
			return this.HideConfig<IHideSpecifyDataLayers>().Value;
		}

		// Token: 0x0602ED82 RID: 191874 RVA: 0x006641A0 File Offset: 0x006623A0
		public IHideSpecifyEntityGroup HideConfigAsIHideSpecifyEntityGroup()
		{
			return this.HideConfig<IHideSpecifyEntityGroup>().Value;
		}

		// Token: 0x0602ED83 RID: 191875 RVA: 0x006641BC File Offset: 0x006623BC
		public IHideSpecifyLevelPlayGroup HideConfigAsIHideSpecifyLevelPlayGroup()
		{
			return this.HideConfig<IHideSpecifyLevelPlayGroup>().Value;
		}

		// Token: 0x0602ED84 RID: 191876 RVA: 0x006641D8 File Offset: 0x006623D8
		public IHideWorldEntityAndLevelPlayGroup HideConfigAsIHideWorldEntityAndLevelPlayGroup()
		{
			return this.HideConfig<IHideWorldEntityAndLevelPlayGroup>().Value;
		}

		// Token: 0x0602ED85 RID: 191877 RVA: 0x006641F4 File Offset: 0x006623F4
		public IHideWorldMonsterAndMonsterTreasureGroup HideConfigAsIHideWorldMonsterAndMonsterTreasureGroup()
		{
			return this.HideConfig<IHideWorldMonsterAndMonsterTreasureGroup>().Value;
		}

		// Token: 0x1700C742 RID: 51010
		// (get) Token: 0x0602ED86 RID: 191878 RVA: 0x00664210 File Offset: 0x00662410
		public bool IsHidePasserByNpc
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C743 RID: 51011
		// (get) Token: 0x0602ED87 RID: 191879 RVA: 0x00664250 File Offset: 0x00662450
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602ED88 RID: 191880 RVA: 0x0066428D File Offset: 0x0066248D
		public static Offset<IHideGroup> CreateIHideGroup(FlatBufferBuilder builder, StringOffset GroupKeyOffset = default(StringOffset), THideGroupConfig HideConfig_type = THideGroupConfig.NONE, int HideConfigOffset = 0, bool IsHidePasserByNpc = false, byte NullMask = 0)
		{
			builder.StartTable(5);
			IHideGroup.AddHideConfig(builder, HideConfigOffset);
			IHideGroup.AddGroupKey(builder, GroupKeyOffset);
			IHideGroup.AddNullMask(builder, NullMask);
			IHideGroup.AddIsHidePasserByNpc(builder, IsHidePasserByNpc);
			IHideGroup.AddHideConfigType(builder, HideConfig_type);
			return IHideGroup.EndIHideGroup(builder);
		}

		// Token: 0x0602ED89 RID: 191881 RVA: 0x006642C1 File Offset: 0x006624C1
		public static void StartIHideGroup(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602ED8A RID: 191882 RVA: 0x006642CA File Offset: 0x006624CA
		public static void AddGroupKey(FlatBufferBuilder builder, StringOffset groupKeyOffset)
		{
			builder.AddOffset(0, groupKeyOffset.Value, 0);
		}

		// Token: 0x0602ED8B RID: 191883 RVA: 0x006642DA File Offset: 0x006624DA
		public static void AddHideConfigType(FlatBufferBuilder builder, THideGroupConfig hideConfigType)
		{
			builder.AddByte(1, (byte)hideConfigType, 0);
		}

		// Token: 0x0602ED8C RID: 191884 RVA: 0x006642E5 File Offset: 0x006624E5
		public static void AddHideConfig(FlatBufferBuilder builder, int hideConfigOffset)
		{
			builder.AddOffset(2, hideConfigOffset, 0);
		}

		// Token: 0x0602ED8D RID: 191885 RVA: 0x006642F0 File Offset: 0x006624F0
		public static void AddIsHidePasserByNpc(FlatBufferBuilder builder, bool isHidePasserByNpc)
		{
			builder.AddBool(3, isHidePasserByNpc, false);
		}

		// Token: 0x0602ED8E RID: 191886 RVA: 0x006642FB File Offset: 0x006624FB
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0602ED8F RID: 191887 RVA: 0x00664306 File Offset: 0x00662506
		public static Offset<IHideGroup> EndIHideGroup(FlatBufferBuilder builder)
		{
			return new Offset<IHideGroup>(builder.EndTable());
		}

		// Token: 0x0602ED90 RID: 191888 RVA: 0x00664314 File Offset: 0x00662514
		public IHideGroupT UnPack()
		{
			IHideGroupT hideGroupT = new IHideGroupT();
			this.UnPackTo(hideGroupT);
			return hideGroupT;
		}

		// Token: 0x0602ED91 RID: 191889 RVA: 0x00664330 File Offset: 0x00662530
		public void UnPackTo(IHideGroupT _o)
		{
			_o.GroupKey = this.GroupKey;
			_o.HideConfig = new THideGroupConfigUnion();
			_o.HideConfig.Type = this.HideConfigType;
			switch (this.HideConfigType)
			{
			case THideGroupConfig.IHideSpecifyDataLayers:
				_o.HideConfig.Value = ((this.HideConfig<IHideSpecifyDataLayers>() != null) ? this.HideConfig<IHideSpecifyDataLayers>().Value.UnPack() : null);
				break;
			case THideGroupConfig.IHideSpecifyEntityGroup:
				_o.HideConfig.Value = ((this.HideConfig<IHideSpecifyEntityGroup>() != null) ? this.HideConfig<IHideSpecifyEntityGroup>().Value.UnPack() : null);
				break;
			case THideGroupConfig.IHideSpecifyLevelPlayGroup:
				_o.HideConfig.Value = ((this.HideConfig<IHideSpecifyLevelPlayGroup>() != null) ? this.HideConfig<IHideSpecifyLevelPlayGroup>().Value.UnPack() : null);
				break;
			case THideGroupConfig.IHideWorldEntityAndLevelPlayGroup:
				_o.HideConfig.Value = ((this.HideConfig<IHideWorldEntityAndLevelPlayGroup>() != null) ? this.HideConfig<IHideWorldEntityAndLevelPlayGroup>().Value.UnPack() : null);
				break;
			case THideGroupConfig.IHideWorldMonsterAndMonsterTreasureGroup:
				_o.HideConfig.Value = ((this.HideConfig<IHideWorldMonsterAndMonsterTreasureGroup>() != null) ? this.HideConfig<IHideWorldMonsterAndMonsterTreasureGroup>().Value.UnPack() : null);
				break;
			}
			_o.IsHidePasserByNpc = this.IsHidePasserByNpc;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602ED92 RID: 191890 RVA: 0x006644C4 File Offset: 0x006626C4
		public static Offset<IHideGroup> Pack(FlatBufferBuilder builder, IHideGroupT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHideGroup>);
			}
			StringOffset groupKeyOffset = (_o.GroupKey == null) ? default(StringOffset) : builder.CreateString(_o.GroupKey);
			THideGroupConfig hideConfig_type = (_o.HideConfig == null) ? THideGroupConfig.NONE : _o.HideConfig.Type;
			int hideConfigOffset = (_o.HideConfig == null) ? 0 : THideGroupConfigUnion.Pack(builder, _o.HideConfig);
			return IHideGroup.CreateIHideGroup(builder, groupKeyOffset, hideConfig_type, hideConfigOffset, _o.IsHidePasserByNpc, _o.NullMask);
		}

		// Token: 0x0401104C RID: 69708
		private Table __p;
	}
}
