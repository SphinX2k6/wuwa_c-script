using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069C3 RID: 27075
	public struct IItemGetUiConfigSpecialQuest : IFlatbufferObject
	{
		// Token: 0x1700C8CC RID: 51404
		// (get) Token: 0x0602F4E1 RID: 193761 RVA: 0x006712EE File Offset: 0x0066F4EE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F4E2 RID: 193762 RVA: 0x006712FB File Offset: 0x0066F4FB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F4E3 RID: 193763 RVA: 0x00671304 File Offset: 0x0066F504
		public static IItemGetUiConfigSpecialQuest GetRootAsIItemGetUiConfigSpecialQuest(ByteBuffer _bb)
		{
			return IItemGetUiConfigSpecialQuest.GetRootAsIItemGetUiConfigSpecialQuest(_bb, default(IItemGetUiConfigSpecialQuest));
		}

		// Token: 0x0602F4E4 RID: 193764 RVA: 0x00671320 File Offset: 0x0066F520
		public static IItemGetUiConfigSpecialQuest GetRootAsIItemGetUiConfigSpecialQuest(ByteBuffer _bb, IItemGetUiConfigSpecialQuest obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F4E5 RID: 193765 RVA: 0x0067133D File Offset: 0x0066F53D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F4E6 RID: 193766 RVA: 0x0067134C File Offset: 0x0066F54C
		public IItemGetUiConfigSpecialQuest __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C8CD RID: 51405
		// (get) Token: 0x0602F4E7 RID: 193767 RVA: 0x0067135C File Offset: 0x0066F55C
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

		// Token: 0x1700C8CE RID: 51406
		// (get) Token: 0x0602F4E8 RID: 193768 RVA: 0x00671398 File Offset: 0x0066F598
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

		// Token: 0x0602F4E9 RID: 193769 RVA: 0x006713CF File Offset: 0x0066F5CF
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602F4EA RID: 193770 RVA: 0x006713DE File Offset: 0x0066F5DE
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700C8CF RID: 51407
		// (get) Token: 0x0602F4EB RID: 193771 RVA: 0x006713EC File Offset: 0x0066F5EC
		public bool ShowDetail
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C8D0 RID: 51408
		// (get) Token: 0x0602F4EC RID: 193772 RVA: 0x0067142C File Offset: 0x0066F62C
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

		// Token: 0x0602F4ED RID: 193773 RVA: 0x00671469 File Offset: 0x0066F669
		public static Offset<IItemGetUiConfigSpecialQuest> CreateIItemGetUiConfigSpecialQuest(FlatBufferBuilder builder, EItemGetUiType Type = EItemGetUiType.None, StringOffset TitleOffset = default(StringOffset), bool ShowDetail = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			IItemGetUiConfigSpecialQuest.AddTitle(builder, TitleOffset);
			IItemGetUiConfigSpecialQuest.AddNullMask(builder, NullMask);
			IItemGetUiConfigSpecialQuest.AddShowDetail(builder, ShowDetail);
			IItemGetUiConfigSpecialQuest.AddType(builder, Type);
			return IItemGetUiConfigSpecialQuest.EndIItemGetUiConfigSpecialQuest(builder);
		}

		// Token: 0x0602F4EE RID: 193774 RVA: 0x00671495 File Offset: 0x0066F695
		public static void StartIItemGetUiConfigSpecialQuest(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602F4EF RID: 193775 RVA: 0x0067149E File Offset: 0x0066F69E
		public static void AddType(FlatBufferBuilder builder, EItemGetUiType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F4F0 RID: 193776 RVA: 0x006714A9 File Offset: 0x0066F6A9
		public static void AddTitle(FlatBufferBuilder builder, StringOffset titleOffset)
		{
			builder.AddOffset(1, titleOffset.Value, 0);
		}

		// Token: 0x0602F4F1 RID: 193777 RVA: 0x006714B9 File Offset: 0x0066F6B9
		public static void AddShowDetail(FlatBufferBuilder builder, bool showDetail)
		{
			builder.AddBool(2, showDetail, false);
		}

		// Token: 0x0602F4F2 RID: 193778 RVA: 0x006714C4 File Offset: 0x0066F6C4
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602F4F3 RID: 193779 RVA: 0x006714CF File Offset: 0x0066F6CF
		public static Offset<IItemGetUiConfigSpecialQuest> EndIItemGetUiConfigSpecialQuest(FlatBufferBuilder builder)
		{
			return new Offset<IItemGetUiConfigSpecialQuest>(builder.EndTable());
		}

		// Token: 0x0602F4F4 RID: 193780 RVA: 0x006714DC File Offset: 0x0066F6DC
		public IItemGetUiConfigSpecialQuestT UnPack()
		{
			IItemGetUiConfigSpecialQuestT itemGetUiConfigSpecialQuestT = new IItemGetUiConfigSpecialQuestT();
			this.UnPackTo(itemGetUiConfigSpecialQuestT);
			return itemGetUiConfigSpecialQuestT;
		}

		// Token: 0x0602F4F5 RID: 193781 RVA: 0x006714F7 File Offset: 0x0066F6F7
		public void UnPackTo(IItemGetUiConfigSpecialQuestT _o)
		{
			_o.Type = this.Type;
			_o.Title = this.Title;
			_o.ShowDetail = this.ShowDetail;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602F4F6 RID: 193782 RVA: 0x0067152C File Offset: 0x0066F72C
		public static Offset<IItemGetUiConfigSpecialQuest> Pack(FlatBufferBuilder builder, IItemGetUiConfigSpecialQuestT _o)
		{
			if (_o == null)
			{
				return default(Offset<IItemGetUiConfigSpecialQuest>);
			}
			StringOffset titleOffset = (_o.Title == null) ? default(StringOffset) : builder.CreateString(_o.Title);
			return IItemGetUiConfigSpecialQuest.CreateIItemGetUiConfigSpecialQuest(builder, _o.Type, titleOffset, _o.ShowDetail, _o.NullMask);
		}

		// Token: 0x04011172 RID: 70002
		private Table __p;
	}
}
