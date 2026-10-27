using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005623 RID: 22051
	public struct INpcHitShow : IFlatbufferObject
	{
		// Token: 0x1700A325 RID: 41765
		// (get) Token: 0x06024993 RID: 149907 RVA: 0x0050C98B File Offset: 0x0050AB8B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024994 RID: 149908 RVA: 0x0050C998 File Offset: 0x0050AB98
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024995 RID: 149909 RVA: 0x0050C9A0 File Offset: 0x0050ABA0
		public static INpcHitShow GetRootAsINpcHitShow(ByteBuffer _bb)
		{
			return INpcHitShow.GetRootAsINpcHitShow(_bb, default(INpcHitShow));
		}

		// Token: 0x06024996 RID: 149910 RVA: 0x0050C9BC File Offset: 0x0050ABBC
		public static INpcHitShow GetRootAsINpcHitShow(ByteBuffer _bb, INpcHitShow obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024997 RID: 149911 RVA: 0x0050C9D9 File Offset: 0x0050ABD9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024998 RID: 149912 RVA: 0x0050C9E8 File Offset: 0x0050ABE8
		public INpcHitShow __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A326 RID: 41766
		// (get) Token: 0x06024999 RID: 149913 RVA: 0x0050C9F8 File Offset: 0x0050ABF8
		public string HitMontage
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

		// Token: 0x0602499A RID: 149914 RVA: 0x0050CA2F File Offset: 0x0050AC2F
		public Span<byte> GetHitMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602499B RID: 149915 RVA: 0x0050CA3E File Offset: 0x0050AC3E
		public byte[] GetHitMontageArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700A327 RID: 41767
		// (get) Token: 0x0602499C RID: 149916 RVA: 0x0050CA4C File Offset: 0x0050AC4C
		public IBubbleIndex? HitBubble
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IBubbleIndex?(default(IBubbleIndex).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A328 RID: 41768
		// (get) Token: 0x0602499D RID: 149917 RVA: 0x0050CAAC File Offset: 0x0050ACAC
		public int BubbleRate
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

		// Token: 0x0602499E RID: 149918 RVA: 0x0050CAE8 File Offset: 0x0050ACE8
		public static Offset<INpcHitShow> CreateINpcHitShow(FlatBufferBuilder builder, StringOffset HitMontageOffset = default(StringOffset), Offset<IBubbleIndex> HitBubbleOffset = default(Offset<IBubbleIndex>), int BubbleRate = 0)
		{
			builder.StartTable(3);
			INpcHitShow.AddBubbleRate(builder, BubbleRate);
			INpcHitShow.AddHitBubble(builder, HitBubbleOffset);
			INpcHitShow.AddHitMontage(builder, HitMontageOffset);
			return INpcHitShow.EndINpcHitShow(builder);
		}

		// Token: 0x0602499F RID: 149919 RVA: 0x0050CB0C File Offset: 0x0050AD0C
		public static void StartINpcHitShow(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060249A0 RID: 149920 RVA: 0x0050CB15 File Offset: 0x0050AD15
		public static void AddHitMontage(FlatBufferBuilder builder, StringOffset hitMontageOffset)
		{
			builder.AddOffset(0, hitMontageOffset.Value, 0);
		}

		// Token: 0x060249A1 RID: 149921 RVA: 0x0050CB25 File Offset: 0x0050AD25
		public static void AddHitBubble(FlatBufferBuilder builder, Offset<IBubbleIndex> hitBubbleOffset)
		{
			builder.AddOffset(1, hitBubbleOffset.Value, 0);
		}

		// Token: 0x060249A2 RID: 149922 RVA: 0x0050CB35 File Offset: 0x0050AD35
		public static void AddBubbleRate(FlatBufferBuilder builder, int bubbleRate)
		{
			builder.AddInt(2, bubbleRate, 0);
		}

		// Token: 0x060249A3 RID: 149923 RVA: 0x0050CB40 File Offset: 0x0050AD40
		public static Offset<INpcHitShow> EndINpcHitShow(FlatBufferBuilder builder)
		{
			return new Offset<INpcHitShow>(builder.EndTable());
		}

		// Token: 0x060249A4 RID: 149924 RVA: 0x0050CB50 File Offset: 0x0050AD50
		public INpcHitShowT UnPack()
		{
			INpcHitShowT npcHitShowT = new INpcHitShowT();
			this.UnPackTo(npcHitShowT);
			return npcHitShowT;
		}

		// Token: 0x060249A5 RID: 149925 RVA: 0x0050CB6C File Offset: 0x0050AD6C
		public void UnPackTo(INpcHitShowT _o)
		{
			_o.HitMontage = this.HitMontage;
			_o.HitBubble = ((this.HitBubble != null) ? this.HitBubble.Value.UnPack() : null);
			_o.BubbleRate = this.BubbleRate;
		}

		// Token: 0x060249A6 RID: 149926 RVA: 0x0050CBC0 File Offset: 0x0050ADC0
		public static Offset<INpcHitShow> Pack(FlatBufferBuilder builder, INpcHitShowT _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcHitShow>);
			}
			StringOffset hitMontageOffset = (_o.HitMontage == null) ? default(StringOffset) : builder.CreateString(_o.HitMontage);
			Offset<IBubbleIndex> hitBubbleOffset = (_o.HitBubble == null) ? default(Offset<IBubbleIndex>) : IBubbleIndex.Pack(builder, _o.HitBubble);
			return INpcHitShow.CreateINpcHitShow(builder, hitMontageOffset, hitBubbleOffset, _o.BubbleRate);
		}

		// Token: 0x0400E9A6 RID: 59814
		private Table __p;
	}
}
