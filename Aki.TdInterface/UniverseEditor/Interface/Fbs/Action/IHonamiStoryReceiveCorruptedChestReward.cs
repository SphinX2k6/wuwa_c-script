using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200692D RID: 26925
	public struct IHonamiStoryReceiveCorruptedChestReward : IFlatbufferObject
	{
		// Token: 0x1700C7BD RID: 51133
		// (get) Token: 0x0602F00A RID: 192522 RVA: 0x00668744 File Offset: 0x00666944
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F00B RID: 192523 RVA: 0x00668751 File Offset: 0x00666951
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F00C RID: 192524 RVA: 0x00668758 File Offset: 0x00666958
		public static IHonamiStoryReceiveCorruptedChestReward GetRootAsIHonamiStoryReceiveCorruptedChestReward(ByteBuffer _bb)
		{
			return IHonamiStoryReceiveCorruptedChestReward.GetRootAsIHonamiStoryReceiveCorruptedChestReward(_bb, default(IHonamiStoryReceiveCorruptedChestReward));
		}

		// Token: 0x0602F00D RID: 192525 RVA: 0x00668774 File Offset: 0x00666974
		public static IHonamiStoryReceiveCorruptedChestReward GetRootAsIHonamiStoryReceiveCorruptedChestReward(ByteBuffer _bb, IHonamiStoryReceiveCorruptedChestReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F00E RID: 192526 RVA: 0x00668791 File Offset: 0x00666991
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F00F RID: 192527 RVA: 0x006687A0 File Offset: 0x006669A0
		public IHonamiStoryReceiveCorruptedChestReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C7BE RID: 51134
		// (get) Token: 0x0602F010 RID: 192528 RVA: 0x006687B0 File Offset: 0x006669B0
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

		// Token: 0x1700C7BF RID: 51135
		// (get) Token: 0x0602F011 RID: 192529 RVA: 0x006687EC File Offset: 0x006669EC
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

		// Token: 0x1700C7C0 RID: 51136
		// (get) Token: 0x0602F012 RID: 192530 RVA: 0x00668828 File Offset: 0x00666A28
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

		// Token: 0x0602F013 RID: 192531 RVA: 0x0066885F File Offset: 0x00666A5F
		public Span<byte> GetChangeSelfEntityStateAfterReceivedBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0602F014 RID: 192532 RVA: 0x0066886E File Offset: 0x00666A6E
		public byte[] GetChangeSelfEntityStateAfterReceivedArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700C7C1 RID: 51137
		// (get) Token: 0x0602F015 RID: 192533 RVA: 0x0066887C File Offset: 0x00666A7C
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

		// Token: 0x0602F016 RID: 192534 RVA: 0x006688B9 File Offset: 0x00666AB9
		public static Offset<IHonamiStoryReceiveCorruptedChestReward> CreateIHonamiStoryReceiveCorruptedChestReward(FlatBufferBuilder builder, int Cost = 0, int CostGroup = 0, StringOffset ChangeSelfEntityStateAfterReceivedOffset = default(StringOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			IHonamiStoryReceiveCorruptedChestReward.AddChangeSelfEntityStateAfterReceived(builder, ChangeSelfEntityStateAfterReceivedOffset);
			IHonamiStoryReceiveCorruptedChestReward.AddCostGroup(builder, CostGroup);
			IHonamiStoryReceiveCorruptedChestReward.AddCost(builder, Cost);
			IHonamiStoryReceiveCorruptedChestReward.AddNullMask(builder, NullMask);
			return IHonamiStoryReceiveCorruptedChestReward.EndIHonamiStoryReceiveCorruptedChestReward(builder);
		}

		// Token: 0x0602F017 RID: 192535 RVA: 0x006688E5 File Offset: 0x00666AE5
		public static void StartIHonamiStoryReceiveCorruptedChestReward(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602F018 RID: 192536 RVA: 0x006688EE File Offset: 0x00666AEE
		public static void AddCost(FlatBufferBuilder builder, int cost)
		{
			builder.AddInt(0, cost, 0);
		}

		// Token: 0x0602F019 RID: 192537 RVA: 0x006688F9 File Offset: 0x00666AF9
		public static void AddCostGroup(FlatBufferBuilder builder, int costGroup)
		{
			builder.AddInt(1, costGroup, 0);
		}

		// Token: 0x0602F01A RID: 192538 RVA: 0x00668904 File Offset: 0x00666B04
		public static void AddChangeSelfEntityStateAfterReceived(FlatBufferBuilder builder, StringOffset changeSelfEntityStateAfterReceivedOffset)
		{
			builder.AddOffset(2, changeSelfEntityStateAfterReceivedOffset.Value, 0);
		}

		// Token: 0x0602F01B RID: 192539 RVA: 0x00668914 File Offset: 0x00666B14
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602F01C RID: 192540 RVA: 0x0066891F File Offset: 0x00666B1F
		public static Offset<IHonamiStoryReceiveCorruptedChestReward> EndIHonamiStoryReceiveCorruptedChestReward(FlatBufferBuilder builder)
		{
			return new Offset<IHonamiStoryReceiveCorruptedChestReward>(builder.EndTable());
		}

		// Token: 0x0602F01D RID: 192541 RVA: 0x0066892C File Offset: 0x00666B2C
		public IHonamiStoryReceiveCorruptedChestRewardT UnPack()
		{
			IHonamiStoryReceiveCorruptedChestRewardT honamiStoryReceiveCorruptedChestRewardT = new IHonamiStoryReceiveCorruptedChestRewardT();
			this.UnPackTo(honamiStoryReceiveCorruptedChestRewardT);
			return honamiStoryReceiveCorruptedChestRewardT;
		}

		// Token: 0x0602F01E RID: 192542 RVA: 0x00668947 File Offset: 0x00666B47
		public void UnPackTo(IHonamiStoryReceiveCorruptedChestRewardT _o)
		{
			_o.Cost = this.Cost;
			_o.CostGroup = this.CostGroup;
			_o.ChangeSelfEntityStateAfterReceived = this.ChangeSelfEntityStateAfterReceived;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602F01F RID: 192543 RVA: 0x0066897C File Offset: 0x00666B7C
		public static Offset<IHonamiStoryReceiveCorruptedChestReward> Pack(FlatBufferBuilder builder, IHonamiStoryReceiveCorruptedChestRewardT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHonamiStoryReceiveCorruptedChestReward>);
			}
			StringOffset changeSelfEntityStateAfterReceivedOffset = (_o.ChangeSelfEntityStateAfterReceived == null) ? default(StringOffset) : builder.CreateString(_o.ChangeSelfEntityStateAfterReceived);
			return IHonamiStoryReceiveCorruptedChestReward.CreateIHonamiStoryReceiveCorruptedChestReward(builder, _o.Cost, _o.CostGroup, changeSelfEntityStateAfterReceivedOffset, _o.NullMask);
		}

		// Token: 0x040110A6 RID: 69798
		private Table __p;
	}
}
