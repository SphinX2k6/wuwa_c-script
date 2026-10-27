using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053EF RID: 21487
	public struct IIndependentSystemRewardComponent : IFlatbufferObject
	{
		// Token: 0x17009E22 RID: 40482
		// (get) Token: 0x0602348F RID: 144527 RVA: 0x004E2ADD File Offset: 0x004E0CDD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023490 RID: 144528 RVA: 0x004E2AEA File Offset: 0x004E0CEA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023491 RID: 144529 RVA: 0x004E2AF4 File Offset: 0x004E0CF4
		public static IIndependentSystemRewardComponent GetRootAsIIndependentSystemRewardComponent(ByteBuffer _bb)
		{
			return IIndependentSystemRewardComponent.GetRootAsIIndependentSystemRewardComponent(_bb, default(IIndependentSystemRewardComponent));
		}

		// Token: 0x06023492 RID: 144530 RVA: 0x004E2B10 File Offset: 0x004E0D10
		public static IIndependentSystemRewardComponent GetRootAsIIndependentSystemRewardComponent(ByteBuffer _bb, IIndependentSystemRewardComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023493 RID: 144531 RVA: 0x004E2B2D File Offset: 0x004E0D2D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023494 RID: 144532 RVA: 0x004E2B3C File Offset: 0x004E0D3C
		public IIndependentSystemRewardComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009E23 RID: 40483
		// (get) Token: 0x06023495 RID: 144533 RVA: 0x004E2B4C File Offset: 0x004E0D4C
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009E24 RID: 40484
		// (get) Token: 0x06023496 RID: 144534 RVA: 0x004E2B8C File Offset: 0x004E0D8C
		public IDarkTideIndependentSystemReward? RewardType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IDarkTideIndependentSystemReward?(default(IDarkTideIndependentSystemReward).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009E25 RID: 40485
		// (get) Token: 0x06023497 RID: 144535 RVA: 0x004E2BEC File Offset: 0x004E0DEC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023498 RID: 144536 RVA: 0x004E2C28 File Offset: 0x004E0E28
		public static Offset<IIndependentSystemRewardComponent> CreateIIndependentSystemRewardComponent(FlatBufferBuilder builder, bool Disabled = false, Offset<IDarkTideIndependentSystemReward> RewardTypeOffset = default(Offset<IDarkTideIndependentSystemReward>), byte NullMask = 0)
		{
			builder.StartTable(3);
			IIndependentSystemRewardComponent.AddRewardType(builder, RewardTypeOffset);
			IIndependentSystemRewardComponent.AddNullMask(builder, NullMask);
			IIndependentSystemRewardComponent.AddDisabled(builder, Disabled);
			return IIndependentSystemRewardComponent.EndIIndependentSystemRewardComponent(builder);
		}

		// Token: 0x06023499 RID: 144537 RVA: 0x004E2C4C File Offset: 0x004E0E4C
		public static void StartIIndependentSystemRewardComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602349A RID: 144538 RVA: 0x004E2C55 File Offset: 0x004E0E55
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x0602349B RID: 144539 RVA: 0x004E2C60 File Offset: 0x004E0E60
		public static void AddRewardType(FlatBufferBuilder builder, Offset<IDarkTideIndependentSystemReward> rewardTypeOffset)
		{
			builder.AddOffset(1, rewardTypeOffset.Value, 0);
		}

		// Token: 0x0602349C RID: 144540 RVA: 0x004E2C70 File Offset: 0x004E0E70
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602349D RID: 144541 RVA: 0x004E2C7B File Offset: 0x004E0E7B
		public static Offset<IIndependentSystemRewardComponent> EndIIndependentSystemRewardComponent(FlatBufferBuilder builder)
		{
			return new Offset<IIndependentSystemRewardComponent>(builder.EndTable());
		}

		// Token: 0x0602349E RID: 144542 RVA: 0x004E2C88 File Offset: 0x004E0E88
		public IIndependentSystemRewardComponentT UnPack()
		{
			IIndependentSystemRewardComponentT independentSystemRewardComponentT = new IIndependentSystemRewardComponentT();
			this.UnPackTo(independentSystemRewardComponentT);
			return independentSystemRewardComponentT;
		}

		// Token: 0x0602349F RID: 144543 RVA: 0x004E2CA4 File Offset: 0x004E0EA4
		public void UnPackTo(IIndependentSystemRewardComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.RewardType = ((this.RewardType != null) ? this.RewardType.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060234A0 RID: 144544 RVA: 0x004E2CF8 File Offset: 0x004E0EF8
		public static Offset<IIndependentSystemRewardComponent> Pack(FlatBufferBuilder builder, IIndependentSystemRewardComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IIndependentSystemRewardComponent>);
			}
			Offset<IDarkTideIndependentSystemReward> rewardTypeOffset = (_o.RewardType == null) ? default(Offset<IDarkTideIndependentSystemReward>) : IDarkTideIndependentSystemReward.Pack(builder, _o.RewardType);
			return IIndependentSystemRewardComponent.CreateIIndependentSystemRewardComponent(builder, _o.Disabled, rewardTypeOffset, _o.NullMask);
		}

		// Token: 0x0400E62F RID: 58927
		private Table __p;
	}
}
