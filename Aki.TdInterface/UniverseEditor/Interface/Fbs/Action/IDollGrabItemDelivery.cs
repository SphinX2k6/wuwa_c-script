using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006600 RID: 26112
	public struct IDollGrabItemDelivery : IFlatbufferObject
	{
		// Token: 0x1700C204 RID: 49668
		// (get) Token: 0x0602D563 RID: 185699 RVA: 0x00636C6E File Offset: 0x00634E6E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D564 RID: 185700 RVA: 0x00636C7B File Offset: 0x00634E7B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D565 RID: 185701 RVA: 0x00636C84 File Offset: 0x00634E84
		public static IDollGrabItemDelivery GetRootAsIDollGrabItemDelivery(ByteBuffer _bb)
		{
			return IDollGrabItemDelivery.GetRootAsIDollGrabItemDelivery(_bb, default(IDollGrabItemDelivery));
		}

		// Token: 0x0602D566 RID: 185702 RVA: 0x00636CA0 File Offset: 0x00634EA0
		public static IDollGrabItemDelivery GetRootAsIDollGrabItemDelivery(ByteBuffer _bb, IDollGrabItemDelivery obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D567 RID: 185703 RVA: 0x00636CBD File Offset: 0x00634EBD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D568 RID: 185704 RVA: 0x00636CCC File Offset: 0x00634ECC
		public IDollGrabItemDelivery __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C205 RID: 49669
		// (get) Token: 0x0602D569 RID: 185705 RVA: 0x00636CDC File Offset: 0x00634EDC
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

		// Token: 0x0602D56A RID: 185706 RVA: 0x00636D18 File Offset: 0x00634F18
		public static Offset<IDollGrabItemDelivery> CreateIDollGrabItemDelivery(FlatBufferBuilder builder, int ShowcaseId = 0)
		{
			builder.StartTable(1);
			IDollGrabItemDelivery.AddShowcaseId(builder, ShowcaseId);
			return IDollGrabItemDelivery.EndIDollGrabItemDelivery(builder);
		}

		// Token: 0x0602D56B RID: 185707 RVA: 0x00636D2E File Offset: 0x00634F2E
		public static void StartIDollGrabItemDelivery(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602D56C RID: 185708 RVA: 0x00636D37 File Offset: 0x00634F37
		public static void AddShowcaseId(FlatBufferBuilder builder, int showcaseId)
		{
			builder.AddInt(0, showcaseId, 0);
		}

		// Token: 0x0602D56D RID: 185709 RVA: 0x00636D42 File Offset: 0x00634F42
		public static Offset<IDollGrabItemDelivery> EndIDollGrabItemDelivery(FlatBufferBuilder builder)
		{
			return new Offset<IDollGrabItemDelivery>(builder.EndTable());
		}

		// Token: 0x0602D56E RID: 185710 RVA: 0x00636D50 File Offset: 0x00634F50
		public IDollGrabItemDeliveryT UnPack()
		{
			IDollGrabItemDeliveryT dollGrabItemDeliveryT = new IDollGrabItemDeliveryT();
			this.UnPackTo(dollGrabItemDeliveryT);
			return dollGrabItemDeliveryT;
		}

		// Token: 0x0602D56F RID: 185711 RVA: 0x00636D6B File Offset: 0x00634F6B
		public void UnPackTo(IDollGrabItemDeliveryT _o)
		{
			_o.ShowcaseId = this.ShowcaseId;
		}

		// Token: 0x0602D570 RID: 185712 RVA: 0x00636D7C File Offset: 0x00634F7C
		public static Offset<IDollGrabItemDelivery> Pack(FlatBufferBuilder builder, IDollGrabItemDeliveryT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDollGrabItemDelivery>);
			}
			return IDollGrabItemDelivery.CreateIDollGrabItemDelivery(builder, _o.ShowcaseId);
		}

		// Token: 0x04010C85 RID: 68741
		private Table __p;
	}
}
