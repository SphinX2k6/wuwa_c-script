using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007CE3 RID: 31971
	public struct IUsePhantomSkill : IFlatbufferObject
	{
		// Token: 0x1700EF4D RID: 61261
		// (get) Token: 0x06039AF0 RID: 236272 RVA: 0x007C83DA File Offset: 0x007C65DA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039AF1 RID: 236273 RVA: 0x007C83E7 File Offset: 0x007C65E7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039AF2 RID: 236274 RVA: 0x007C83F0 File Offset: 0x007C65F0
		public static IUsePhantomSkill GetRootAsIUsePhantomSkill(ByteBuffer _bb)
		{
			return IUsePhantomSkill.GetRootAsIUsePhantomSkill(_bb, default(IUsePhantomSkill));
		}

		// Token: 0x06039AF3 RID: 236275 RVA: 0x007C840C File Offset: 0x007C660C
		public static IUsePhantomSkill GetRootAsIUsePhantomSkill(ByteBuffer _bb, IUsePhantomSkill obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06039AF4 RID: 236276 RVA: 0x007C8429 File Offset: 0x007C6629
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06039AF5 RID: 236277 RVA: 0x007C8438 File Offset: 0x007C6638
		public IUsePhantomSkill __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EF4E RID: 61262
		// (get) Token: 0x06039AF6 RID: 236278 RVA: 0x007C8448 File Offset: 0x007C6648
		public EPhantomSkillType SkillType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPhantomSkillType.ChallengeSuccess;
				}
				return (EPhantomSkillType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700EF4F RID: 61263
		// (get) Token: 0x06039AF7 RID: 236279 RVA: 0x007C8484 File Offset: 0x007C6684
		public ISkillBlackboardVector? BlackboardPos
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new ISkillBlackboardVector?(default(ISkillBlackboardVector).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700EF50 RID: 61264
		// (get) Token: 0x06039AF8 RID: 236280 RVA: 0x007C84E4 File Offset: 0x007C66E4
		public ISkillBlackboardVector? BlackboardRot
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new ISkillBlackboardVector?(default(ISkillBlackboardVector).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06039AF9 RID: 236281 RVA: 0x007C8541 File Offset: 0x007C6741
		public static Offset<IUsePhantomSkill> CreateIUsePhantomSkill(FlatBufferBuilder builder, EPhantomSkillType SkillType = EPhantomSkillType.ChallengeSuccess, Offset<ISkillBlackboardVector> BlackboardPosOffset = default(Offset<ISkillBlackboardVector>), Offset<ISkillBlackboardVector> BlackboardRotOffset = default(Offset<ISkillBlackboardVector>))
		{
			builder.StartTable(3);
			IUsePhantomSkill.AddBlackboardRot(builder, BlackboardRotOffset);
			IUsePhantomSkill.AddBlackboardPos(builder, BlackboardPosOffset);
			IUsePhantomSkill.AddSkillType(builder, SkillType);
			return IUsePhantomSkill.EndIUsePhantomSkill(builder);
		}

		// Token: 0x06039AFA RID: 236282 RVA: 0x007C8565 File Offset: 0x007C6765
		public static void StartIUsePhantomSkill(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06039AFB RID: 236283 RVA: 0x007C856E File Offset: 0x007C676E
		public static void AddSkillType(FlatBufferBuilder builder, EPhantomSkillType skillType)
		{
			builder.AddByte(0, (byte)skillType, 0);
		}

		// Token: 0x06039AFC RID: 236284 RVA: 0x007C8579 File Offset: 0x007C6779
		public static void AddBlackboardPos(FlatBufferBuilder builder, Offset<ISkillBlackboardVector> blackboardPosOffset)
		{
			builder.AddOffset(1, blackboardPosOffset.Value, 0);
		}

		// Token: 0x06039AFD RID: 236285 RVA: 0x007C8589 File Offset: 0x007C6789
		public static void AddBlackboardRot(FlatBufferBuilder builder, Offset<ISkillBlackboardVector> blackboardRotOffset)
		{
			builder.AddOffset(2, blackboardRotOffset.Value, 0);
		}

		// Token: 0x06039AFE RID: 236286 RVA: 0x007C8599 File Offset: 0x007C6799
		public static Offset<IUsePhantomSkill> EndIUsePhantomSkill(FlatBufferBuilder builder)
		{
			return new Offset<IUsePhantomSkill>(builder.EndTable());
		}

		// Token: 0x06039AFF RID: 236287 RVA: 0x007C85A8 File Offset: 0x007C67A8
		public IUsePhantomSkillT UnPack()
		{
			IUsePhantomSkillT usePhantomSkillT = new IUsePhantomSkillT();
			this.UnPackTo(usePhantomSkillT);
			return usePhantomSkillT;
		}

		// Token: 0x06039B00 RID: 236288 RVA: 0x007C85C4 File Offset: 0x007C67C4
		public void UnPackTo(IUsePhantomSkillT _o)
		{
			_o.SkillType = this.SkillType;
			_o.BlackboardPos = ((this.BlackboardPos != null) ? this.BlackboardPos.Value.UnPack() : null);
			_o.BlackboardRot = ((this.BlackboardRot != null) ? this.BlackboardRot.Value.UnPack() : null);
		}

		// Token: 0x06039B01 RID: 236289 RVA: 0x007C863C File Offset: 0x007C683C
		public static Offset<IUsePhantomSkill> Pack(FlatBufferBuilder builder, IUsePhantomSkillT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUsePhantomSkill>);
			}
			Offset<ISkillBlackboardVector> blackboardPosOffset = (_o.BlackboardPos == null) ? default(Offset<ISkillBlackboardVector>) : ISkillBlackboardVector.Pack(builder, _o.BlackboardPos);
			Offset<ISkillBlackboardVector> blackboardRotOffset = (_o.BlackboardRot == null) ? default(Offset<ISkillBlackboardVector>) : ISkillBlackboardVector.Pack(builder, _o.BlackboardRot);
			return IUsePhantomSkill.CreateIUsePhantomSkill(builder, _o.SkillType, blackboardPosOffset, blackboardRotOffset);
		}

		// Token: 0x040133F2 RID: 78834
		private Table __p;
	}
}
