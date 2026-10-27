using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003EED RID: 16109
	public struct IKurotatoConditionStepUpgradeReward : IFlatbufferObject
	{
		// Token: 0x17006FC1 RID: 28609
		// (get) Token: 0x06016C99 RID: 93337 RVA: 0x003498A1 File Offset: 0x00347AA1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016C9A RID: 93338 RVA: 0x003498AE File Offset: 0x00347AAE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016C9B RID: 93339 RVA: 0x003498B8 File Offset: 0x00347AB8
		public static IKurotatoConditionStepUpgradeReward GetRootAsIKurotatoConditionStepUpgradeReward(ByteBuffer _bb)
		{
			return IKurotatoConditionStepUpgradeReward.GetRootAsIKurotatoConditionStepUpgradeReward(_bb, default(IKurotatoConditionStepUpgradeReward));
		}

		// Token: 0x06016C9C RID: 93340 RVA: 0x003498D4 File Offset: 0x00347AD4
		public static IKurotatoConditionStepUpgradeReward GetRootAsIKurotatoConditionStepUpgradeReward(ByteBuffer _bb, IKurotatoConditionStepUpgradeReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016C9D RID: 93341 RVA: 0x003498F1 File Offset: 0x00347AF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016C9E RID: 93342 RVA: 0x00349900 File Offset: 0x00347B00
		public IKurotatoConditionStepUpgradeReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006FC2 RID: 28610
		// (get) Token: 0x06016C9F RID: 93343 RVA: 0x00349910 File Offset: 0x00347B10
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

		// Token: 0x06016CA0 RID: 93344 RVA: 0x0034994C File Offset: 0x00347B4C
		public static Offset<IKurotatoConditionStepUpgradeReward> CreateIKurotatoConditionStepUpgradeReward(FlatBufferBuilder builder, EKurotatoConditionStep Type = EKurotatoConditionStep.Prepare)
		{
			builder.StartTable(1);
			IKurotatoConditionStepUpgradeReward.AddType(builder, Type);
			return IKurotatoConditionStepUpgradeReward.EndIKurotatoConditionStepUpgradeReward(builder);
		}

		// Token: 0x06016CA1 RID: 93345 RVA: 0x00349962 File Offset: 0x00347B62
		public static void StartIKurotatoConditionStepUpgradeReward(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06016CA2 RID: 93346 RVA: 0x0034996B File Offset: 0x00347B6B
		public static void AddType(FlatBufferBuilder builder, EKurotatoConditionStep type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016CA3 RID: 93347 RVA: 0x00349976 File Offset: 0x00347B76
		public static Offset<IKurotatoConditionStepUpgradeReward> EndIKurotatoConditionStepUpgradeReward(FlatBufferBuilder builder)
		{
			return new Offset<IKurotatoConditionStepUpgradeReward>(builder.EndTable());
		}

		// Token: 0x06016CA4 RID: 93348 RVA: 0x00349984 File Offset: 0x00347B84
		public IKurotatoConditionStepUpgradeRewardT UnPack()
		{
			IKurotatoConditionStepUpgradeRewardT kurotatoConditionStepUpgradeRewardT = new IKurotatoConditionStepUpgradeRewardT();
			this.UnPackTo(kurotatoConditionStepUpgradeRewardT);
			return kurotatoConditionStepUpgradeRewardT;
		}

		// Token: 0x06016CA5 RID: 93349 RVA: 0x0034999F File Offset: 0x00347B9F
		public void UnPackTo(IKurotatoConditionStepUpgradeRewardT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06016CA6 RID: 93350 RVA: 0x003499B0 File Offset: 0x00347BB0
		public static Offset<IKurotatoConditionStepUpgradeReward> Pack(FlatBufferBuilder builder, IKurotatoConditionStepUpgradeRewardT _o)
		{
			if (_o == null)
			{
				return default(Offset<IKurotatoConditionStepUpgradeReward>);
			}
			return IKurotatoConditionStepUpgradeReward.CreateIKurotatoConditionStepUpgradeReward(builder, _o.Type);
		}

		// Token: 0x0400B8CB RID: 47307
		private Table __p;
	}
}
