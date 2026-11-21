using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200432B RID: 17195
	public struct IKurotatoConditionStepUpgradeReward : IFlatbufferObject
	{
		// Token: 0x170075B0 RID: 30128
		// (get) Token: 0x060182F0 RID: 99056 RVA: 0x00372A6D File Offset: 0x00370C6D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060182F1 RID: 99057 RVA: 0x00372A7A File Offset: 0x00370C7A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060182F2 RID: 99058 RVA: 0x00372A84 File Offset: 0x00370C84
		public static IKurotatoConditionStepUpgradeReward GetRootAsIKurotatoConditionStepUpgradeReward(ByteBuffer _bb)
		{
			return IKurotatoConditionStepUpgradeReward.GetRootAsIKurotatoConditionStepUpgradeReward(_bb, default(IKurotatoConditionStepUpgradeReward));
		}

		// Token: 0x060182F3 RID: 99059 RVA: 0x00372AA0 File Offset: 0x00370CA0
		public static IKurotatoConditionStepUpgradeReward GetRootAsIKurotatoConditionStepUpgradeReward(ByteBuffer _bb, IKurotatoConditionStepUpgradeReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060182F4 RID: 99060 RVA: 0x00372ABD File Offset: 0x00370CBD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060182F5 RID: 99061 RVA: 0x00372ACC File Offset: 0x00370CCC
		public IKurotatoConditionStepUpgradeReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170075B1 RID: 30129
		// (get) Token: 0x060182F6 RID: 99062 RVA: 0x00372ADC File Offset: 0x00370CDC
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

		// Token: 0x060182F7 RID: 99063 RVA: 0x00372B18 File Offset: 0x00370D18
		public static Offset<IKurotatoConditionStepUpgradeReward> CreateIKurotatoConditionStepUpgradeReward(FlatBufferBuilder builder, EKurotatoConditionStep Type = EKurotatoConditionStep.Prepare)
		{
			builder.StartTable(1);
			IKurotatoConditionStepUpgradeReward.AddType(builder, Type);
			return IKurotatoConditionStepUpgradeReward.EndIKurotatoConditionStepUpgradeReward(builder);
		}

		// Token: 0x060182F8 RID: 99064 RVA: 0x00372B2E File Offset: 0x00370D2E
		public static void StartIKurotatoConditionStepUpgradeReward(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060182F9 RID: 99065 RVA: 0x00372B37 File Offset: 0x00370D37
		public static void AddType(FlatBufferBuilder builder, EKurotatoConditionStep type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060182FA RID: 99066 RVA: 0x00372B42 File Offset: 0x00370D42
		public static Offset<IKurotatoConditionStepUpgradeReward> EndIKurotatoConditionStepUpgradeReward(FlatBufferBuilder builder)
		{
			return new Offset<IKurotatoConditionStepUpgradeReward>(builder.EndTable());
		}

		// Token: 0x060182FB RID: 99067 RVA: 0x00372B50 File Offset: 0x00370D50
		public IKurotatoConditionStepUpgradeRewardT UnPack()
		{
			IKurotatoConditionStepUpgradeRewardT kurotatoConditionStepUpgradeRewardT = new IKurotatoConditionStepUpgradeRewardT();
			this.UnPackTo(kurotatoConditionStepUpgradeRewardT);
			return kurotatoConditionStepUpgradeRewardT;
		}

		// Token: 0x060182FC RID: 99068 RVA: 0x00372B6B File Offset: 0x00370D6B
		public void UnPackTo(IKurotatoConditionStepUpgradeRewardT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060182FD RID: 99069 RVA: 0x00372B7C File Offset: 0x00370D7C
		public static Offset<IKurotatoConditionStepUpgradeReward> Pack(FlatBufferBuilder builder, IKurotatoConditionStepUpgradeRewardT _o)
		{
			if (_o == null)
			{
				return default(Offset<IKurotatoConditionStepUpgradeReward>);
			}
			return IKurotatoConditionStepUpgradeReward.CreateIKurotatoConditionStepUpgradeReward(builder, _o.Type);
		}

		// Token: 0x0400C2A8 RID: 49832
		private Table __p;
	}
}
