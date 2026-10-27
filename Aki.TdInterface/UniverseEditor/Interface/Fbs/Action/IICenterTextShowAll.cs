using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200693F RID: 26943
	public struct IICenterTextShowAll : IFlatbufferObject
	{
		// Token: 0x1700C7E7 RID: 51175
		// (get) Token: 0x0602F0BA RID: 192698 RVA: 0x00669BF0 File Offset: 0x00667DF0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F0BB RID: 192699 RVA: 0x00669BFD File Offset: 0x00667DFD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F0BC RID: 192700 RVA: 0x00669C04 File Offset: 0x00667E04
		public static IICenterTextShowAll GetRootAsIICenterTextShowAll(ByteBuffer _bb)
		{
			return IICenterTextShowAll.GetRootAsIICenterTextShowAll(_bb, default(IICenterTextShowAll));
		}

		// Token: 0x0602F0BD RID: 192701 RVA: 0x00669C20 File Offset: 0x00667E20
		public static IICenterTextShowAll GetRootAsIICenterTextShowAll(ByteBuffer _bb, IICenterTextShowAll obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F0BE RID: 192702 RVA: 0x00669C3D File Offset: 0x00667E3D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F0BF RID: 192703 RVA: 0x00669C4C File Offset: 0x00667E4C
		public IICenterTextShowAll __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C7E8 RID: 51176
		// (get) Token: 0x0602F0C0 RID: 192704 RVA: 0x00669C5C File Offset: 0x00667E5C
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

		// Token: 0x0602F0C1 RID: 192705 RVA: 0x00669C98 File Offset: 0x00667E98
		public static Offset<IICenterTextShowAll> CreateIICenterTextShowAll(FlatBufferBuilder builder, ECenterTextShowAnim Type = ECenterTextShowAnim.ShowAll)
		{
			builder.StartTable(1);
			IICenterTextShowAll.AddType(builder, Type);
			return IICenterTextShowAll.EndIICenterTextShowAll(builder);
		}

		// Token: 0x0602F0C2 RID: 192706 RVA: 0x00669CAE File Offset: 0x00667EAE
		public static void StartIICenterTextShowAll(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602F0C3 RID: 192707 RVA: 0x00669CB7 File Offset: 0x00667EB7
		public static void AddType(FlatBufferBuilder builder, ECenterTextShowAnim type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F0C4 RID: 192708 RVA: 0x00669CC2 File Offset: 0x00667EC2
		public static Offset<IICenterTextShowAll> EndIICenterTextShowAll(FlatBufferBuilder builder)
		{
			return new Offset<IICenterTextShowAll>(builder.EndTable());
		}

		// Token: 0x0602F0C5 RID: 192709 RVA: 0x00669CD0 File Offset: 0x00667ED0
		public IICenterTextShowAllT UnPack()
		{
			IICenterTextShowAllT iicenterTextShowAllT = new IICenterTextShowAllT();
			this.UnPackTo(iicenterTextShowAllT);
			return iicenterTextShowAllT;
		}

		// Token: 0x0602F0C6 RID: 192710 RVA: 0x00669CEB File Offset: 0x00667EEB
		public void UnPackTo(IICenterTextShowAllT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602F0C7 RID: 192711 RVA: 0x00669CFC File Offset: 0x00667EFC
		public static Offset<IICenterTextShowAll> Pack(FlatBufferBuilder builder, IICenterTextShowAllT _o)
		{
			if (_o == null)
			{
				return default(Offset<IICenterTextShowAll>);
			}
			return IICenterTextShowAll.CreateIICenterTextShowAll(builder, _o.Type);
		}

		// Token: 0x040110BE RID: 69822
		private Table __p;
	}
}
