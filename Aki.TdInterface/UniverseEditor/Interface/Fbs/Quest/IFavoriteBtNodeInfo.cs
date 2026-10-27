using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E2A RID: 15914
	public struct IFavoriteBtNodeInfo : IFlatbufferObject
	{
		// Token: 0x17006E07 RID: 28167
		// (get) Token: 0x060164CB RID: 91339 RVA: 0x003383E0 File Offset: 0x003365E0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060164CC RID: 91340 RVA: 0x003383ED File Offset: 0x003365ED
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060164CD RID: 91341 RVA: 0x003383F4 File Offset: 0x003365F4
		public static IFavoriteBtNodeInfo GetRootAsIFavoriteBtNodeInfo(ByteBuffer _bb)
		{
			return IFavoriteBtNodeInfo.GetRootAsIFavoriteBtNodeInfo(_bb, default(IFavoriteBtNodeInfo));
		}

		// Token: 0x060164CE RID: 91342 RVA: 0x00338410 File Offset: 0x00336610
		public static IFavoriteBtNodeInfo GetRootAsIFavoriteBtNodeInfo(ByteBuffer _bb, IFavoriteBtNodeInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060164CF RID: 91343 RVA: 0x0033842D File Offset: 0x0033662D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060164D0 RID: 91344 RVA: 0x0033843C File Offset: 0x0033663C
		public IFavoriteBtNodeInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006E08 RID: 28168
		// (get) Token: 0x060164D1 RID: 91345 RVA: 0x0033844C File Offset: 0x0033664C
		public int Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006E09 RID: 28169
		// (get) Token: 0x060164D2 RID: 91346 RVA: 0x00338488 File Offset: 0x00336688
		public string Desc
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

		// Token: 0x060164D3 RID: 91347 RVA: 0x003384BF File Offset: 0x003366BF
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060164D4 RID: 91348 RVA: 0x003384CE File Offset: 0x003366CE
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x060164D5 RID: 91349 RVA: 0x003384DC File Offset: 0x003366DC
		public static Offset<IFavoriteBtNodeInfo> CreateIFavoriteBtNodeInfo(FlatBufferBuilder builder, int Id = 0, StringOffset DescOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IFavoriteBtNodeInfo.AddDesc(builder, DescOffset);
			IFavoriteBtNodeInfo.AddId(builder, Id);
			return IFavoriteBtNodeInfo.EndIFavoriteBtNodeInfo(builder);
		}

		// Token: 0x060164D6 RID: 91350 RVA: 0x003384F9 File Offset: 0x003366F9
		public static void StartIFavoriteBtNodeInfo(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060164D7 RID: 91351 RVA: 0x00338502 File Offset: 0x00336702
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x060164D8 RID: 91352 RVA: 0x0033850D File Offset: 0x0033670D
		public static void AddDesc(FlatBufferBuilder builder, StringOffset descOffset)
		{
			builder.AddOffset(1, descOffset.Value, 0);
		}

		// Token: 0x060164D9 RID: 91353 RVA: 0x0033851D File Offset: 0x0033671D
		public static Offset<IFavoriteBtNodeInfo> EndIFavoriteBtNodeInfo(FlatBufferBuilder builder)
		{
			return new Offset<IFavoriteBtNodeInfo>(builder.EndTable());
		}

		// Token: 0x060164DA RID: 91354 RVA: 0x0033852C File Offset: 0x0033672C
		public IFavoriteBtNodeInfoT UnPack()
		{
			IFavoriteBtNodeInfoT favoriteBtNodeInfoT = new IFavoriteBtNodeInfoT();
			this.UnPackTo(favoriteBtNodeInfoT);
			return favoriteBtNodeInfoT;
		}

		// Token: 0x060164DB RID: 91355 RVA: 0x00338547 File Offset: 0x00336747
		public void UnPackTo(IFavoriteBtNodeInfoT _o)
		{
			_o.Id = this.Id;
			_o.Desc = this.Desc;
		}

		// Token: 0x060164DC RID: 91356 RVA: 0x00338564 File Offset: 0x00336764
		public static Offset<IFavoriteBtNodeInfo> Pack(FlatBufferBuilder builder, IFavoriteBtNodeInfoT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFavoriteBtNodeInfo>);
			}
			StringOffset descOffset = (_o.Desc == null) ? default(StringOffset) : builder.CreateString(_o.Desc);
			return IFavoriteBtNodeInfo.CreateIFavoriteBtNodeInfo(builder, _o.Id, descOffset);
		}

		// Token: 0x0400B7AE RID: 47022
		private Table __p;
	}
}
