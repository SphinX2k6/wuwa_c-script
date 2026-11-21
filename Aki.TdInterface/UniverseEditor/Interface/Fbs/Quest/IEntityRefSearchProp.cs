using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004247 RID: 16967
	public struct IEntityRefSearchProp : IFlatbufferObject
	{
		// Token: 0x170073AD RID: 29613
		// (get) Token: 0x060179C7 RID: 96711 RVA: 0x0035E3A4 File Offset: 0x0035C5A4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060179C8 RID: 96712 RVA: 0x0035E3B1 File Offset: 0x0035C5B1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060179C9 RID: 96713 RVA: 0x0035E3B8 File Offset: 0x0035C5B8
		public static IEntityRefSearchProp GetRootAsIEntityRefSearchProp(ByteBuffer _bb)
		{
			return IEntityRefSearchProp.GetRootAsIEntityRefSearchProp(_bb, default(IEntityRefSearchProp));
		}

		// Token: 0x060179CA RID: 96714 RVA: 0x0035E3D4 File Offset: 0x0035C5D4
		public static IEntityRefSearchProp GetRootAsIEntityRefSearchProp(ByteBuffer _bb, IEntityRefSearchProp obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060179CB RID: 96715 RVA: 0x0035E3F1 File Offset: 0x0035C5F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060179CC RID: 96716 RVA: 0x0035E400 File Offset: 0x0035C600
		public IEntityRefSearchProp __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170073AE RID: 29614
		// (get) Token: 0x060179CD RID: 96717 RVA: 0x0035E410 File Offset: 0x0035C610
		public string SearchText
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

		// Token: 0x060179CE RID: 96718 RVA: 0x0035E447 File Offset: 0x0035C647
		public Span<byte> GetSearchTextBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x060179CF RID: 96719 RVA: 0x0035E456 File Offset: 0x0035C656
		public byte[] GetSearchTextArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x170073AF RID: 29615
		// (get) Token: 0x060179D0 RID: 96720 RVA: 0x0035E464 File Offset: 0x0035C664
		public int ResultCount
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170073B0 RID: 29616
		// (get) Token: 0x060179D1 RID: 96721 RVA: 0x0035E4A0 File Offset: 0x0035C6A0
		public int ResultIndex
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170073B1 RID: 29617
		// (get) Token: 0x060179D2 RID: 96722 RVA: 0x0035E4DC File Offset: 0x0035C6DC
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

		// Token: 0x060179D3 RID: 96723 RVA: 0x0035E519 File Offset: 0x0035C719
		public static Offset<IEntityRefSearchProp> CreateIEntityRefSearchProp(FlatBufferBuilder builder, StringOffset SearchTextOffset = default(StringOffset), int ResultCount = 0, int ResultIndex = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			IEntityRefSearchProp.AddResultIndex(builder, ResultIndex);
			IEntityRefSearchProp.AddResultCount(builder, ResultCount);
			IEntityRefSearchProp.AddSearchText(builder, SearchTextOffset);
			IEntityRefSearchProp.AddNullMask(builder, NullMask);
			return IEntityRefSearchProp.EndIEntityRefSearchProp(builder);
		}

		// Token: 0x060179D4 RID: 96724 RVA: 0x0035E545 File Offset: 0x0035C745
		public static void StartIEntityRefSearchProp(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060179D5 RID: 96725 RVA: 0x0035E54E File Offset: 0x0035C74E
		public static void AddSearchText(FlatBufferBuilder builder, StringOffset searchTextOffset)
		{
			builder.AddOffset(0, searchTextOffset.Value, 0);
		}

		// Token: 0x060179D6 RID: 96726 RVA: 0x0035E55E File Offset: 0x0035C75E
		public static void AddResultCount(FlatBufferBuilder builder, int resultCount)
		{
			builder.AddInt(1, resultCount, 0);
		}

		// Token: 0x060179D7 RID: 96727 RVA: 0x0035E569 File Offset: 0x0035C769
		public static void AddResultIndex(FlatBufferBuilder builder, int resultIndex)
		{
			builder.AddInt(2, resultIndex, 0);
		}

		// Token: 0x060179D8 RID: 96728 RVA: 0x0035E574 File Offset: 0x0035C774
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x060179D9 RID: 96729 RVA: 0x0035E57F File Offset: 0x0035C77F
		public static Offset<IEntityRefSearchProp> EndIEntityRefSearchProp(FlatBufferBuilder builder)
		{
			return new Offset<IEntityRefSearchProp>(builder.EndTable());
		}

		// Token: 0x060179DA RID: 96730 RVA: 0x0035E58C File Offset: 0x0035C78C
		public IEntityRefSearchPropT UnPack()
		{
			IEntityRefSearchPropT entityRefSearchPropT = new IEntityRefSearchPropT();
			this.UnPackTo(entityRefSearchPropT);
			return entityRefSearchPropT;
		}

		// Token: 0x060179DB RID: 96731 RVA: 0x0035E5A7 File Offset: 0x0035C7A7
		public void UnPackTo(IEntityRefSearchPropT _o)
		{
			_o.SearchText = this.SearchText;
			_o.ResultCount = this.ResultCount;
			_o.ResultIndex = this.ResultIndex;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060179DC RID: 96732 RVA: 0x0035E5DC File Offset: 0x0035C7DC
		public static Offset<IEntityRefSearchProp> Pack(FlatBufferBuilder builder, IEntityRefSearchPropT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityRefSearchProp>);
			}
			StringOffset searchTextOffset = (_o.SearchText == null) ? default(StringOffset) : builder.CreateString(_o.SearchText);
			return IEntityRefSearchProp.CreateIEntityRefSearchProp(builder, searchTextOffset, _o.ResultCount, _o.ResultIndex, _o.NullMask);
		}

		// Token: 0x0400C156 RID: 49494
		private Table __p;
	}
}
