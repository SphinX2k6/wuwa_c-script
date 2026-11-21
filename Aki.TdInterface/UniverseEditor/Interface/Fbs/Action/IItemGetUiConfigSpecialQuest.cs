using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007073 RID: 28787
	public struct IItemGetUiConfigSpecialQuest : IFlatbufferObject
	{
		// Token: 0x1700D2CC RID: 53964
		// (get) Token: 0x06031EA1 RID: 204449 RVA: 0x006C1646 File Offset: 0x006BF846
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031EA2 RID: 204450 RVA: 0x006C1653 File Offset: 0x006BF853
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031EA3 RID: 204451 RVA: 0x006C165C File Offset: 0x006BF85C
		public static IItemGetUiConfigSpecialQuest GetRootAsIItemGetUiConfigSpecialQuest(ByteBuffer _bb)
		{
			return IItemGetUiConfigSpecialQuest.GetRootAsIItemGetUiConfigSpecialQuest(_bb, default(IItemGetUiConfigSpecialQuest));
		}

		// Token: 0x06031EA4 RID: 204452 RVA: 0x006C1678 File Offset: 0x006BF878
		public static IItemGetUiConfigSpecialQuest GetRootAsIItemGetUiConfigSpecialQuest(ByteBuffer _bb, IItemGetUiConfigSpecialQuest obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031EA5 RID: 204453 RVA: 0x006C1695 File Offset: 0x006BF895
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031EA6 RID: 204454 RVA: 0x006C16A4 File Offset: 0x006BF8A4
		public IItemGetUiConfigSpecialQuest __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D2CD RID: 53965
		// (get) Token: 0x06031EA7 RID: 204455 RVA: 0x006C16B4 File Offset: 0x006BF8B4
		public EItemGetUiType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EItemGetUiType.None;
				}
				return (EItemGetUiType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D2CE RID: 53966
		// (get) Token: 0x06031EA8 RID: 204456 RVA: 0x006C16F0 File Offset: 0x006BF8F0
		public string Title
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

		// Token: 0x06031EA9 RID: 204457 RVA: 0x006C1727 File Offset: 0x006BF927
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06031EAA RID: 204458 RVA: 0x006C1736 File Offset: 0x006BF936
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700D2CF RID: 53967
		// (get) Token: 0x06031EAB RID: 204459 RVA: 0x006C1744 File Offset: 0x006BF944
		public bool ShowDetail
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D2D0 RID: 53968
		// (get) Token: 0x06031EAC RID: 204460 RVA: 0x006C1784 File Offset: 0x006BF984
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06031EAD RID: 204461 RVA: 0x006C17C1 File Offset: 0x006BF9C1
		public static Offset<IItemGetUiConfigSpecialQuest> CreateIItemGetUiConfigSpecialQuest(FlatBufferBuilder builder, EItemGetUiType Type = EItemGetUiType.None, StringOffset TitleOffset = default(StringOffset), bool ShowDetail = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			IItemGetUiConfigSpecialQuest.AddTitle(builder, TitleOffset);
			IItemGetUiConfigSpecialQuest.AddNullMask(builder, NullMask);
			IItemGetUiConfigSpecialQuest.AddShowDetail(builder, ShowDetail);
			IItemGetUiConfigSpecialQuest.AddType(builder, Type);
			return IItemGetUiConfigSpecialQuest.EndIItemGetUiConfigSpecialQuest(builder);
		}

		// Token: 0x06031EAE RID: 204462 RVA: 0x006C17ED File Offset: 0x006BF9ED
		public static void StartIItemGetUiConfigSpecialQuest(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06031EAF RID: 204463 RVA: 0x006C17F6 File Offset: 0x006BF9F6
		public static void AddType(FlatBufferBuilder builder, EItemGetUiType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031EB0 RID: 204464 RVA: 0x006C1801 File Offset: 0x006BFA01
		public static void AddTitle(FlatBufferBuilder builder, StringOffset titleOffset)
		{
			builder.AddOffset(1, titleOffset.Value, 0);
		}

		// Token: 0x06031EB1 RID: 204465 RVA: 0x006C1811 File Offset: 0x006BFA11
		public static void AddShowDetail(FlatBufferBuilder builder, bool showDetail)
		{
			builder.AddBool(2, showDetail, false);
		}

		// Token: 0x06031EB2 RID: 204466 RVA: 0x006C181C File Offset: 0x006BFA1C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06031EB3 RID: 204467 RVA: 0x006C1827 File Offset: 0x006BFA27
		public static Offset<IItemGetUiConfigSpecialQuest> EndIItemGetUiConfigSpecialQuest(FlatBufferBuilder builder)
		{
			return new Offset<IItemGetUiConfigSpecialQuest>(builder.EndTable());
		}

		// Token: 0x06031EB4 RID: 204468 RVA: 0x006C1834 File Offset: 0x006BFA34
		public IItemGetUiConfigSpecialQuestT UnPack()
		{
			IItemGetUiConfigSpecialQuestT itemGetUiConfigSpecialQuestT = new IItemGetUiConfigSpecialQuestT();
			this.UnPackTo(itemGetUiConfigSpecialQuestT);
			return itemGetUiConfigSpecialQuestT;
		}

		// Token: 0x06031EB5 RID: 204469 RVA: 0x006C184F File Offset: 0x006BFA4F
		public void UnPackTo(IItemGetUiConfigSpecialQuestT _o)
		{
			_o.Type = this.Type;
			_o.Title = this.Title;
			_o.ShowDetail = this.ShowDetail;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06031EB6 RID: 204470 RVA: 0x006C1884 File Offset: 0x006BFA84
		public static Offset<IItemGetUiConfigSpecialQuest> Pack(FlatBufferBuilder builder, IItemGetUiConfigSpecialQuestT _o)
		{
			if (_o == null)
			{
				return default(Offset<IItemGetUiConfigSpecialQuest>);
			}
			StringOffset titleOffset = (_o.Title == null) ? default(StringOffset) : builder.CreateString(_o.Title);
			return IItemGetUiConfigSpecialQuest.CreateIItemGetUiConfigSpecialQuest(builder, _o.Type, titleOffset, _o.ShowDetail, _o.NullMask);
		}

		// Token: 0x04011FDC RID: 73692
		private Table __p;
	}
}
