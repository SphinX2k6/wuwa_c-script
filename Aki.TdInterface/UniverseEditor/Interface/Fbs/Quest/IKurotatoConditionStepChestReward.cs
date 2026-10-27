using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003EDB RID: 16091
	public struct IKurotatoConditionStepChestReward : IFlatbufferObject
	{
		// Token: 0x17006FAF RID: 28591
		// (get) Token: 0x06016C2D RID: 93229 RVA: 0x00348FD1 File Offset: 0x003471D1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016C2E RID: 93230 RVA: 0x00348FDE File Offset: 0x003471DE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016C2F RID: 93231 RVA: 0x00348FE8 File Offset: 0x003471E8
		public static IKurotatoConditionStepChestReward GetRootAsIKurotatoConditionStepChestReward(ByteBuffer _bb)
		{
			return IKurotatoConditionStepChestReward.GetRootAsIKurotatoConditionStepChestReward(_bb, default(IKurotatoConditionStepChestReward));
		}

		// Token: 0x06016C30 RID: 93232 RVA: 0x00349004 File Offset: 0x00347204
		public static IKurotatoConditionStepChestReward GetRootAsIKurotatoConditionStepChestReward(ByteBuffer _bb, IKurotatoConditionStepChestReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016C31 RID: 93233 RVA: 0x00349021 File Offset: 0x00347221
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016C32 RID: 93234 RVA: 0x00349030 File Offset: 0x00347230
		public IKurotatoConditionStepChestReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006FB0 RID: 28592
		// (get) Token: 0x06016C33 RID: 93235 RVA: 0x00349040 File Offset: 0x00347240
		public EKurotatoConditionStep Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EKurotatoConditionStep.Prepare;
				}
				return (EKurotatoConditionStep)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06016C34 RID: 93236 RVA: 0x0034907C File Offset: 0x0034727C
		public static Offset<IKurotatoConditionStepChestReward> CreateIKurotatoConditionStepChestReward(FlatBufferBuilder builder, EKurotatoConditionStep Type = EKurotatoConditionStep.Prepare)
		{
			builder.StartTable(1);
			IKurotatoConditionStepChestReward.AddType(builder, Type);
			return IKurotatoConditionStepChestReward.EndIKurotatoConditionStepChestReward(builder);
		}

		// Token: 0x06016C35 RID: 93237 RVA: 0x00349092 File Offset: 0x00347292
		public static void StartIKurotatoConditionStepChestReward(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06016C36 RID: 93238 RVA: 0x0034909B File Offset: 0x0034729B
		public static void AddType(FlatBufferBuilder builder, EKurotatoConditionStep type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016C37 RID: 93239 RVA: 0x003490A6 File Offset: 0x003472A6
		public static Offset<IKurotatoConditionStepChestReward> EndIKurotatoConditionStepChestReward(FlatBufferBuilder builder)
		{
			return new Offset<IKurotatoConditionStepChestReward>(builder.EndTable());
		}

		// Token: 0x06016C38 RID: 93240 RVA: 0x003490B4 File Offset: 0x003472B4
		public IKurotatoConditionStepChestRewardT UnPack()
		{
			IKurotatoConditionStepChestRewardT kurotatoConditionStepChestRewardT = new IKurotatoConditionStepChestRewardT();
			this.UnPackTo(kurotatoConditionStepChestRewardT);
			return kurotatoConditionStepChestRewardT;
		}

		// Token: 0x06016C39 RID: 93241 RVA: 0x003490CF File Offset: 0x003472CF
		public void UnPackTo(IKurotatoConditionStepChestRewardT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06016C3A RID: 93242 RVA: 0x003490E0 File Offset: 0x003472E0
		public static Offset<IKurotatoConditionStepChestReward> Pack(FlatBufferBuilder builder, IKurotatoConditionStepChestRewardT _o)
		{
			if (_o == null)
			{
				return default(Offset<IKurotatoConditionStepChestReward>);
			}
			return IKurotatoConditionStepChestReward.CreateIKurotatoConditionStepChestReward(builder, _o.Type);
		}

		// Token: 0x0400B8BF RID: 47295
		private Table __p;
	}
}
