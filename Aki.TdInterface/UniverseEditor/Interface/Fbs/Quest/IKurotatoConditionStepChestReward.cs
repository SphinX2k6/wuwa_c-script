using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004319 RID: 17177
	public struct IKurotatoConditionStepChestReward : IFlatbufferObject
	{
		// Token: 0x1700759E RID: 30110
		// (get) Token: 0x06018284 RID: 98948 RVA: 0x0037219D File Offset: 0x0037039D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018285 RID: 98949 RVA: 0x003721AA File Offset: 0x003703AA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018286 RID: 98950 RVA: 0x003721B4 File Offset: 0x003703B4
		public static IKurotatoConditionStepChestReward GetRootAsIKurotatoConditionStepChestReward(ByteBuffer _bb)
		{
			return IKurotatoConditionStepChestReward.GetRootAsIKurotatoConditionStepChestReward(_bb, default(IKurotatoConditionStepChestReward));
		}

		// Token: 0x06018287 RID: 98951 RVA: 0x003721D0 File Offset: 0x003703D0
		public static IKurotatoConditionStepChestReward GetRootAsIKurotatoConditionStepChestReward(ByteBuffer _bb, IKurotatoConditionStepChestReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018288 RID: 98952 RVA: 0x003721ED File Offset: 0x003703ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018289 RID: 98953 RVA: 0x003721FC File Offset: 0x003703FC
		public IKurotatoConditionStepChestReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700759F RID: 30111
		// (get) Token: 0x0601828A RID: 98954 RVA: 0x0037220C File Offset: 0x0037040C
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

		// Token: 0x0601828B RID: 98955 RVA: 0x00372248 File Offset: 0x00370448
		public static Offset<IKurotatoConditionStepChestReward> CreateIKurotatoConditionStepChestReward(FlatBufferBuilder builder, EKurotatoConditionStep Type = EKurotatoConditionStep.Prepare)
		{
			builder.StartTable(1);
			IKurotatoConditionStepChestReward.AddType(builder, Type);
			return IKurotatoConditionStepChestReward.EndIKurotatoConditionStepChestReward(builder);
		}

		// Token: 0x0601828C RID: 98956 RVA: 0x0037225E File Offset: 0x0037045E
		public static void StartIKurotatoConditionStepChestReward(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601828D RID: 98957 RVA: 0x00372267 File Offset: 0x00370467
		public static void AddType(FlatBufferBuilder builder, EKurotatoConditionStep type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601828E RID: 98958 RVA: 0x00372272 File Offset: 0x00370472
		public static Offset<IKurotatoConditionStepChestReward> EndIKurotatoConditionStepChestReward(FlatBufferBuilder builder)
		{
			return new Offset<IKurotatoConditionStepChestReward>(builder.EndTable());
		}

		// Token: 0x0601828F RID: 98959 RVA: 0x00372280 File Offset: 0x00370480
		public IKurotatoConditionStepChestRewardT UnPack()
		{
			IKurotatoConditionStepChestRewardT kurotatoConditionStepChestRewardT = new IKurotatoConditionStepChestRewardT();
			this.UnPackTo(kurotatoConditionStepChestRewardT);
			return kurotatoConditionStepChestRewardT;
		}

		// Token: 0x06018290 RID: 98960 RVA: 0x0037229B File Offset: 0x0037049B
		public void UnPackTo(IKurotatoConditionStepChestRewardT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06018291 RID: 98961 RVA: 0x003722AC File Offset: 0x003704AC
		public static Offset<IKurotatoConditionStepChestReward> Pack(FlatBufferBuilder builder, IKurotatoConditionStepChestRewardT _o)
		{
			if (_o == null)
			{
				return default(Offset<IKurotatoConditionStepChestReward>);
			}
			return IKurotatoConditionStepChestReward.CreateIKurotatoConditionStepChestReward(builder, _o.Type);
		}

		// Token: 0x0400C29C RID: 49820
		private Table __p;
	}
}
