using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BB8 RID: 23480
	public struct INpcBumpShow : IFlatbufferObject
	{
		// Token: 0x1700ABA0 RID: 43936
		// (get) Token: 0x06026B5B RID: 158555 RVA: 0x0054C7B8 File Offset: 0x0054A9B8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026B5C RID: 158556 RVA: 0x0054C7C5 File Offset: 0x0054A9C5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026B5D RID: 158557 RVA: 0x0054C7CC File Offset: 0x0054A9CC
		public static INpcBumpShow GetRootAsINpcBumpShow(ByteBuffer _bb)
		{
			return INpcBumpShow.GetRootAsINpcBumpShow(_bb, default(INpcBumpShow));
		}

		// Token: 0x06026B5E RID: 158558 RVA: 0x0054C7E8 File Offset: 0x0054A9E8
		public static INpcBumpShow GetRootAsINpcBumpShow(ByteBuffer _bb, INpcBumpShow obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026B5F RID: 158559 RVA: 0x0054C805 File Offset: 0x0054AA05
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026B60 RID: 158560 RVA: 0x0054C814 File Offset: 0x0054AA14
		public INpcBumpShow __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ABA1 RID: 43937
		// (get) Token: 0x06026B61 RID: 158561 RVA: 0x0054C824 File Offset: 0x0054AA24
		public INpcPerformBubble? BumpBubble
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new INpcPerformBubble?(default(INpcPerformBubble).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06026B62 RID: 158562 RVA: 0x0054C881 File Offset: 0x0054AA81
		public static Offset<INpcBumpShow> CreateINpcBumpShow(FlatBufferBuilder builder, Offset<INpcPerformBubble> BumpBubbleOffset = default(Offset<INpcPerformBubble>))
		{
			builder.StartTable(1);
			INpcBumpShow.AddBumpBubble(builder, BumpBubbleOffset);
			return INpcBumpShow.EndINpcBumpShow(builder);
		}

		// Token: 0x06026B63 RID: 158563 RVA: 0x0054C897 File Offset: 0x0054AA97
		public static void StartINpcBumpShow(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06026B64 RID: 158564 RVA: 0x0054C8A0 File Offset: 0x0054AAA0
		public static void AddBumpBubble(FlatBufferBuilder builder, Offset<INpcPerformBubble> bumpBubbleOffset)
		{
			builder.AddOffset(0, bumpBubbleOffset.Value, 0);
		}

		// Token: 0x06026B65 RID: 158565 RVA: 0x0054C8B0 File Offset: 0x0054AAB0
		public static Offset<INpcBumpShow> EndINpcBumpShow(FlatBufferBuilder builder)
		{
			return new Offset<INpcBumpShow>(builder.EndTable());
		}

		// Token: 0x06026B66 RID: 158566 RVA: 0x0054C8C0 File Offset: 0x0054AAC0
		public INpcBumpShowT UnPack()
		{
			INpcBumpShowT npcBumpShowT = new INpcBumpShowT();
			this.UnPackTo(npcBumpShowT);
			return npcBumpShowT;
		}

		// Token: 0x06026B67 RID: 158567 RVA: 0x0054C8DC File Offset: 0x0054AADC
		public void UnPackTo(INpcBumpShowT _o)
		{
			_o.BumpBubble = ((this.BumpBubble != null) ? this.BumpBubble.Value.UnPack() : null);
		}

		// Token: 0x06026B68 RID: 158568 RVA: 0x0054C918 File Offset: 0x0054AB18
		public static Offset<INpcBumpShow> Pack(FlatBufferBuilder builder, INpcBumpShowT _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcBumpShow>);
			}
			Offset<INpcPerformBubble> bumpBubbleOffset = (_o.BumpBubble == null) ? default(Offset<INpcPerformBubble>) : INpcPerformBubble.Pack(builder, _o.BumpBubble);
			return INpcBumpShow.CreateINpcBumpShow(builder, bumpBubbleOffset);
		}

		// Token: 0x0400F601 RID: 62977
		private Table __p;
	}
}
