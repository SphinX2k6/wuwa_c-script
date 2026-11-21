using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FF2 RID: 28658
	public struct IICenterTextShowAll : IFlatbufferObject
	{
		// Token: 0x1700D1EA RID: 53738
		// (get) Token: 0x06031A8A RID: 203402 RVA: 0x006BA0D8 File Offset: 0x006B82D8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031A8B RID: 203403 RVA: 0x006BA0E5 File Offset: 0x006B82E5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031A8C RID: 203404 RVA: 0x006BA0EC File Offset: 0x006B82EC
		public static IICenterTextShowAll GetRootAsIICenterTextShowAll(ByteBuffer _bb)
		{
			return IICenterTextShowAll.GetRootAsIICenterTextShowAll(_bb, default(IICenterTextShowAll));
		}

		// Token: 0x06031A8D RID: 203405 RVA: 0x006BA108 File Offset: 0x006B8308
		public static IICenterTextShowAll GetRootAsIICenterTextShowAll(ByteBuffer _bb, IICenterTextShowAll obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031A8E RID: 203406 RVA: 0x006BA125 File Offset: 0x006B8325
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031A8F RID: 203407 RVA: 0x006BA134 File Offset: 0x006B8334
		public IICenterTextShowAll __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D1EB RID: 53739
		// (get) Token: 0x06031A90 RID: 203408 RVA: 0x006BA144 File Offset: 0x006B8344
		public ECenterTextShowAnim Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECenterTextShowAnim.ShowAll;
				}
				return (ECenterTextShowAnim)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06031A91 RID: 203409 RVA: 0x006BA180 File Offset: 0x006B8380
		public static Offset<IICenterTextShowAll> CreateIICenterTextShowAll(FlatBufferBuilder builder, ECenterTextShowAnim Type = ECenterTextShowAnim.ShowAll)
		{
			builder.StartTable(1);
			IICenterTextShowAll.AddType(builder, Type);
			return IICenterTextShowAll.EndIICenterTextShowAll(builder);
		}

		// Token: 0x06031A92 RID: 203410 RVA: 0x006BA196 File Offset: 0x006B8396
		public static void StartIICenterTextShowAll(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06031A93 RID: 203411 RVA: 0x006BA19F File Offset: 0x006B839F
		public static void AddType(FlatBufferBuilder builder, ECenterTextShowAnim type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031A94 RID: 203412 RVA: 0x006BA1AA File Offset: 0x006B83AA
		public static Offset<IICenterTextShowAll> EndIICenterTextShowAll(FlatBufferBuilder builder)
		{
			return new Offset<IICenterTextShowAll>(builder.EndTable());
		}

		// Token: 0x06031A95 RID: 203413 RVA: 0x006BA1B8 File Offset: 0x006B83B8
		public IICenterTextShowAllT UnPack()
		{
			IICenterTextShowAllT iicenterTextShowAllT = new IICenterTextShowAllT();
			this.UnPackTo(iicenterTextShowAllT);
			return iicenterTextShowAllT;
		}

		// Token: 0x06031A96 RID: 203414 RVA: 0x006BA1D3 File Offset: 0x006B83D3
		public void UnPackTo(IICenterTextShowAllT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06031A97 RID: 203415 RVA: 0x006BA1E4 File Offset: 0x006B83E4
		public static Offset<IICenterTextShowAll> Pack(FlatBufferBuilder builder, IICenterTextShowAllT _o)
		{
			if (_o == null)
			{
				return default(Offset<IICenterTextShowAll>);
			}
			return IICenterTextShowAll.CreateIICenterTextShowAll(builder, _o.Type);
		}

		// Token: 0x04011F2A RID: 73514
		private Table __p;
	}
}
