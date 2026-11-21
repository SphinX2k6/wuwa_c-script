using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005975 RID: 22901
	public struct IIndependentSystemRewardComponent : IFlatbufferObject
	{
		// Token: 0x1700A65C RID: 42588
		// (get) Token: 0x06025547 RID: 152903 RVA: 0x0051FB09 File Offset: 0x0051DD09
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025548 RID: 152904 RVA: 0x0051FB16 File Offset: 0x0051DD16
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025549 RID: 152905 RVA: 0x0051FB20 File Offset: 0x0051DD20
		public static IIndependentSystemRewardComponent GetRootAsIIndependentSystemRewardComponent(ByteBuffer _bb)
		{
			return IIndependentSystemRewardComponent.GetRootAsIIndependentSystemRewardComponent(_bb, default(IIndependentSystemRewardComponent));
		}

		// Token: 0x0602554A RID: 152906 RVA: 0x0051FB3C File Offset: 0x0051DD3C
		public static IIndependentSystemRewardComponent GetRootAsIIndependentSystemRewardComponent(ByteBuffer _bb, IIndependentSystemRewardComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602554B RID: 152907 RVA: 0x0051FB59 File Offset: 0x0051DD59
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602554C RID: 152908 RVA: 0x0051FB68 File Offset: 0x0051DD68
		public IIndependentSystemRewardComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A65D RID: 42589
		// (get) Token: 0x0602554D RID: 152909 RVA: 0x0051FB78 File Offset: 0x0051DD78
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A65E RID: 42590
		// (get) Token: 0x0602554E RID: 152910 RVA: 0x0051FBB8 File Offset: 0x0051DDB8
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

		// Token: 0x1700A65F RID: 42591
		// (get) Token: 0x0602554F RID: 152911 RVA: 0x0051FC18 File Offset: 0x0051DE18
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

		// Token: 0x06025550 RID: 152912 RVA: 0x0051FC54 File Offset: 0x0051DE54
		public static Offset<IIndependentSystemRewardComponent> CreateIIndependentSystemRewardComponent(FlatBufferBuilder builder, bool Disabled = false, Offset<IDarkTideIndependentSystemReward> RewardTypeOffset = default(Offset<IDarkTideIndependentSystemReward>), byte NullMask = 0)
		{
			builder.StartTable(3);
			IIndependentSystemRewardComponent.AddRewardType(builder, RewardTypeOffset);
			IIndependentSystemRewardComponent.AddNullMask(builder, NullMask);
			IIndependentSystemRewardComponent.AddDisabled(builder, Disabled);
			return IIndependentSystemRewardComponent.EndIIndependentSystemRewardComponent(builder);
		}

		// Token: 0x06025551 RID: 152913 RVA: 0x0051FC78 File Offset: 0x0051DE78
		public static void StartIIndependentSystemRewardComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06025552 RID: 152914 RVA: 0x0051FC81 File Offset: 0x0051DE81
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06025553 RID: 152915 RVA: 0x0051FC8C File Offset: 0x0051DE8C
		public static void AddRewardType(FlatBufferBuilder builder, Offset<IDarkTideIndependentSystemReward> rewardTypeOffset)
		{
			builder.AddOffset(1, rewardTypeOffset.Value, 0);
		}

		// Token: 0x06025554 RID: 152916 RVA: 0x0051FC9C File Offset: 0x0051DE9C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06025555 RID: 152917 RVA: 0x0051FCA7 File Offset: 0x0051DEA7
		public static Offset<IIndependentSystemRewardComponent> EndIIndependentSystemRewardComponent(FlatBufferBuilder builder)
		{
			return new Offset<IIndependentSystemRewardComponent>(builder.EndTable());
		}

		// Token: 0x06025556 RID: 152918 RVA: 0x0051FCB4 File Offset: 0x0051DEB4
		public IIndependentSystemRewardComponentT UnPack()
		{
			IIndependentSystemRewardComponentT independentSystemRewardComponentT = new IIndependentSystemRewardComponentT();
			this.UnPackTo(independentSystemRewardComponentT);
			return independentSystemRewardComponentT;
		}

		// Token: 0x06025557 RID: 152919 RVA: 0x0051FCD0 File Offset: 0x0051DED0
		public void UnPackTo(IIndependentSystemRewardComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.RewardType = ((this.RewardType != null) ? this.RewardType.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06025558 RID: 152920 RVA: 0x0051FD24 File Offset: 0x0051DF24
		public static Offset<IIndependentSystemRewardComponent> Pack(FlatBufferBuilder builder, IIndependentSystemRewardComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IIndependentSystemRewardComponent>);
			}
			Offset<IDarkTideIndependentSystemReward> rewardTypeOffset = (_o.RewardType == null) ? default(Offset<IDarkTideIndependentSystemReward>) : IDarkTideIndependentSystemReward.Pack(builder, _o.RewardType);
			return IIndependentSystemRewardComponent.CreateIIndependentSystemRewardComponent(builder, _o.Disabled, rewardTypeOffset, _o.NullMask);
		}

		// Token: 0x0400F260 RID: 62048
		private Table __p;
	}
}
