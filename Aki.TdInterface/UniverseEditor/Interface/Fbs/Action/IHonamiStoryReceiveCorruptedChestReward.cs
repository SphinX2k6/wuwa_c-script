using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FE0 RID: 28640
	public struct IHonamiStoryReceiveCorruptedChestReward : IFlatbufferObject
	{
		// Token: 0x1700D1C0 RID: 53696
		// (get) Token: 0x060319DA RID: 203226 RVA: 0x006B8C2C File Offset: 0x006B6E2C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060319DB RID: 203227 RVA: 0x006B8C39 File Offset: 0x006B6E39
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060319DC RID: 203228 RVA: 0x006B8C40 File Offset: 0x006B6E40
		public static IHonamiStoryReceiveCorruptedChestReward GetRootAsIHonamiStoryReceiveCorruptedChestReward(ByteBuffer _bb)
		{
			return IHonamiStoryReceiveCorruptedChestReward.GetRootAsIHonamiStoryReceiveCorruptedChestReward(_bb, default(IHonamiStoryReceiveCorruptedChestReward));
		}

		// Token: 0x060319DD RID: 203229 RVA: 0x006B8C5C File Offset: 0x006B6E5C
		public static IHonamiStoryReceiveCorruptedChestReward GetRootAsIHonamiStoryReceiveCorruptedChestReward(ByteBuffer _bb, IHonamiStoryReceiveCorruptedChestReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060319DE RID: 203230 RVA: 0x006B8C79 File Offset: 0x006B6E79
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060319DF RID: 203231 RVA: 0x006B8C88 File Offset: 0x006B6E88
		public IHonamiStoryReceiveCorruptedChestReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D1C1 RID: 53697
		// (get) Token: 0x060319E0 RID: 203232 RVA: 0x006B8C98 File Offset: 0x006B6E98
		public int Cost
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

		// Token: 0x1700D1C2 RID: 53698
		// (get) Token: 0x060319E1 RID: 203233 RVA: 0x006B8CD4 File Offset: 0x006B6ED4
		public int CostGroup
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

		// Token: 0x1700D1C3 RID: 53699
		// (get) Token: 0x060319E2 RID: 203234 RVA: 0x006B8D10 File Offset: 0x006B6F10
		public string ChangeSelfEntityStateAfterReceived
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060319E3 RID: 203235 RVA: 0x006B8D47 File Offset: 0x006B6F47
		public Span<byte> GetChangeSelfEntityStateAfterReceivedBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060319E4 RID: 203236 RVA: 0x006B8D56 File Offset: 0x006B6F56
		public byte[] GetChangeSelfEntityStateAfterReceivedArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700D1C4 RID: 53700
		// (get) Token: 0x060319E5 RID: 203237 RVA: 0x006B8D64 File Offset: 0x006B6F64
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

		// Token: 0x060319E6 RID: 203238 RVA: 0x006B8DA1 File Offset: 0x006B6FA1
		public static Offset<IHonamiStoryReceiveCorruptedChestReward> CreateIHonamiStoryReceiveCorruptedChestReward(FlatBufferBuilder builder, int Cost = 0, int CostGroup = 0, StringOffset ChangeSelfEntityStateAfterReceivedOffset = default(StringOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			IHonamiStoryReceiveCorruptedChestReward.AddChangeSelfEntityStateAfterReceived(builder, ChangeSelfEntityStateAfterReceivedOffset);
			IHonamiStoryReceiveCorruptedChestReward.AddCostGroup(builder, CostGroup);
			IHonamiStoryReceiveCorruptedChestReward.AddCost(builder, Cost);
			IHonamiStoryReceiveCorruptedChestReward.AddNullMask(builder, NullMask);
			return IHonamiStoryReceiveCorruptedChestReward.EndIHonamiStoryReceiveCorruptedChestReward(builder);
		}

		// Token: 0x060319E7 RID: 203239 RVA: 0x006B8DCD File Offset: 0x006B6FCD
		public static void StartIHonamiStoryReceiveCorruptedChestReward(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060319E8 RID: 203240 RVA: 0x006B8DD6 File Offset: 0x006B6FD6
		public static void AddCost(FlatBufferBuilder builder, int cost)
		{
			builder.AddInt(0, cost, 0);
		}

		// Token: 0x060319E9 RID: 203241 RVA: 0x006B8DE1 File Offset: 0x006B6FE1
		public static void AddCostGroup(FlatBufferBuilder builder, int costGroup)
		{
			builder.AddInt(1, costGroup, 0);
		}

		// Token: 0x060319EA RID: 203242 RVA: 0x006B8DEC File Offset: 0x006B6FEC
		public static void AddChangeSelfEntityStateAfterReceived(FlatBufferBuilder builder, StringOffset changeSelfEntityStateAfterReceivedOffset)
		{
			builder.AddOffset(2, changeSelfEntityStateAfterReceivedOffset.Value, 0);
		}

		// Token: 0x060319EB RID: 203243 RVA: 0x006B8DFC File Offset: 0x006B6FFC
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x060319EC RID: 203244 RVA: 0x006B8E07 File Offset: 0x006B7007
		public static Offset<IHonamiStoryReceiveCorruptedChestReward> EndIHonamiStoryReceiveCorruptedChestReward(FlatBufferBuilder builder)
		{
			return new Offset<IHonamiStoryReceiveCorruptedChestReward>(builder.EndTable());
		}

		// Token: 0x060319ED RID: 203245 RVA: 0x006B8E14 File Offset: 0x006B7014
		public IHonamiStoryReceiveCorruptedChestRewardT UnPack()
		{
			IHonamiStoryReceiveCorruptedChestRewardT honamiStoryReceiveCorruptedChestRewardT = new IHonamiStoryReceiveCorruptedChestRewardT();
			this.UnPackTo(honamiStoryReceiveCorruptedChestRewardT);
			return honamiStoryReceiveCorruptedChestRewardT;
		}

		// Token: 0x060319EE RID: 203246 RVA: 0x006B8E2F File Offset: 0x006B702F
		public void UnPackTo(IHonamiStoryReceiveCorruptedChestRewardT _o)
		{
			_o.Cost = this.Cost;
			_o.CostGroup = this.CostGroup;
			_o.ChangeSelfEntityStateAfterReceived = this.ChangeSelfEntityStateAfterReceived;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060319EF RID: 203247 RVA: 0x006B8E64 File Offset: 0x006B7064
		public static Offset<IHonamiStoryReceiveCorruptedChestReward> Pack(FlatBufferBuilder builder, IHonamiStoryReceiveCorruptedChestRewardT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHonamiStoryReceiveCorruptedChestReward>);
			}
			StringOffset changeSelfEntityStateAfterReceivedOffset = (_o.ChangeSelfEntityStateAfterReceived == null) ? default(StringOffset) : builder.CreateString(_o.ChangeSelfEntityStateAfterReceived);
			return IHonamiStoryReceiveCorruptedChestReward.CreateIHonamiStoryReceiveCorruptedChestReward(builder, _o.Cost, _o.CostGroup, changeSelfEntityStateAfterReceivedOffset, _o.NullMask);
		}

		// Token: 0x04011F12 RID: 73490
		private Table __p;
	}
}
