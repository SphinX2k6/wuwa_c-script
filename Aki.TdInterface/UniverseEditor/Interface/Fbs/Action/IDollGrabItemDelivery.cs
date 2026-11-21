using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C71 RID: 27761
	public struct IDollGrabItemDelivery : IFlatbufferObject
	{
		// Token: 0x1700CBA2 RID: 52130
		// (get) Token: 0x0602FD34 RID: 195892 RVA: 0x006837D6 File Offset: 0x006819D6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FD35 RID: 195893 RVA: 0x006837E3 File Offset: 0x006819E3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FD36 RID: 195894 RVA: 0x006837EC File Offset: 0x006819EC
		public static IDollGrabItemDelivery GetRootAsIDollGrabItemDelivery(ByteBuffer _bb)
		{
			return IDollGrabItemDelivery.GetRootAsIDollGrabItemDelivery(_bb, default(IDollGrabItemDelivery));
		}

		// Token: 0x0602FD37 RID: 195895 RVA: 0x00683808 File Offset: 0x00681A08
		public static IDollGrabItemDelivery GetRootAsIDollGrabItemDelivery(ByteBuffer _bb, IDollGrabItemDelivery obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FD38 RID: 195896 RVA: 0x00683825 File Offset: 0x00681A25
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FD39 RID: 195897 RVA: 0x00683834 File Offset: 0x00681A34
		public IDollGrabItemDelivery __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CBA3 RID: 52131
		// (get) Token: 0x0602FD3A RID: 195898 RVA: 0x00683844 File Offset: 0x00681A44
		public int ShowcaseId
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

		// Token: 0x0602FD3B RID: 195899 RVA: 0x00683880 File Offset: 0x00681A80
		public static Offset<IDollGrabItemDelivery> CreateIDollGrabItemDelivery(FlatBufferBuilder builder, int ShowcaseId = 0)
		{
			builder.StartTable(1);
			IDollGrabItemDelivery.AddShowcaseId(builder, ShowcaseId);
			return IDollGrabItemDelivery.EndIDollGrabItemDelivery(builder);
		}

		// Token: 0x0602FD3C RID: 195900 RVA: 0x00683896 File Offset: 0x00681A96
		public static void StartIDollGrabItemDelivery(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602FD3D RID: 195901 RVA: 0x0068389F File Offset: 0x00681A9F
		public static void AddShowcaseId(FlatBufferBuilder builder, int showcaseId)
		{
			builder.AddInt(0, showcaseId, 0);
		}

		// Token: 0x0602FD3E RID: 195902 RVA: 0x006838AA File Offset: 0x00681AAA
		public static Offset<IDollGrabItemDelivery> EndIDollGrabItemDelivery(FlatBufferBuilder builder)
		{
			return new Offset<IDollGrabItemDelivery>(builder.EndTable());
		}

		// Token: 0x0602FD3F RID: 195903 RVA: 0x006838B8 File Offset: 0x00681AB8
		public IDollGrabItemDeliveryT UnPack()
		{
			IDollGrabItemDeliveryT dollGrabItemDeliveryT = new IDollGrabItemDeliveryT();
			this.UnPackTo(dollGrabItemDeliveryT);
			return dollGrabItemDeliveryT;
		}

		// Token: 0x0602FD40 RID: 195904 RVA: 0x006838D3 File Offset: 0x00681AD3
		public void UnPackTo(IDollGrabItemDeliveryT _o)
		{
			_o.ShowcaseId = this.ShowcaseId;
		}

		// Token: 0x0602FD41 RID: 195905 RVA: 0x006838E4 File Offset: 0x00681AE4
		public static Offset<IDollGrabItemDelivery> Pack(FlatBufferBuilder builder, IDollGrabItemDeliveryT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDollGrabItemDelivery>);
			}
			return IDollGrabItemDelivery.CreateIDollGrabItemDelivery(builder, _o.ShowcaseId);
		}

		// Token: 0x04011AA0 RID: 72352
		private Table __p;
	}
}
