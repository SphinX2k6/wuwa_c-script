using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074ED RID: 29933
	public struct IUsePhantomSkill : IFlatbufferObject
	{
		// Token: 0x1700E323 RID: 58147
		// (get) Token: 0x060366DB RID: 222939 RVA: 0x0076518A File Offset: 0x0076338A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060366DC RID: 222940 RVA: 0x00765197 File Offset: 0x00763397
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060366DD RID: 222941 RVA: 0x007651A0 File Offset: 0x007633A0
		public static IUsePhantomSkill GetRootAsIUsePhantomSkill(ByteBuffer _bb)
		{
			return IUsePhantomSkill.GetRootAsIUsePhantomSkill(_bb, default(IUsePhantomSkill));
		}

		// Token: 0x060366DE RID: 222942 RVA: 0x007651BC File Offset: 0x007633BC
		public static IUsePhantomSkill GetRootAsIUsePhantomSkill(ByteBuffer _bb, IUsePhantomSkill obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060366DF RID: 222943 RVA: 0x007651D9 File Offset: 0x007633D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060366E0 RID: 222944 RVA: 0x007651E8 File Offset: 0x007633E8
		public IUsePhantomSkill __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E324 RID: 58148
		// (get) Token: 0x060366E1 RID: 222945 RVA: 0x007651F8 File Offset: 0x007633F8
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

		// Token: 0x1700E325 RID: 58149
		// (get) Token: 0x060366E2 RID: 222946 RVA: 0x00765234 File Offset: 0x00763434
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

		// Token: 0x1700E326 RID: 58150
		// (get) Token: 0x060366E3 RID: 222947 RVA: 0x00765294 File Offset: 0x00763494
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

		// Token: 0x060366E4 RID: 222948 RVA: 0x007652F1 File Offset: 0x007634F1
		public static Offset<IUsePhantomSkill> CreateIUsePhantomSkill(FlatBufferBuilder builder, EPhantomSkillType SkillType = EPhantomSkillType.ChallengeSuccess, Offset<ISkillBlackboardVector> BlackboardPosOffset = default(Offset<ISkillBlackboardVector>), Offset<ISkillBlackboardVector> BlackboardRotOffset = default(Offset<ISkillBlackboardVector>))
		{
			builder.StartTable(3);
			IUsePhantomSkill.AddBlackboardRot(builder, BlackboardRotOffset);
			IUsePhantomSkill.AddBlackboardPos(builder, BlackboardPosOffset);
			IUsePhantomSkill.AddSkillType(builder, SkillType);
			return IUsePhantomSkill.EndIUsePhantomSkill(builder);
		}

		// Token: 0x060366E5 RID: 222949 RVA: 0x00765315 File Offset: 0x00763515
		public static void StartIUsePhantomSkill(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060366E6 RID: 222950 RVA: 0x0076531E File Offset: 0x0076351E
		public static void AddSkillType(FlatBufferBuilder builder, EPhantomSkillType skillType)
		{
			builder.AddByte(0, (byte)skillType, 0);
		}

		// Token: 0x060366E7 RID: 222951 RVA: 0x00765329 File Offset: 0x00763529
		public static void AddBlackboardPos(FlatBufferBuilder builder, Offset<ISkillBlackboardVector> blackboardPosOffset)
		{
			builder.AddOffset(1, blackboardPosOffset.Value, 0);
		}

		// Token: 0x060366E8 RID: 222952 RVA: 0x00765339 File Offset: 0x00763539
		public static void AddBlackboardRot(FlatBufferBuilder builder, Offset<ISkillBlackboardVector> blackboardRotOffset)
		{
			builder.AddOffset(2, blackboardRotOffset.Value, 0);
		}

		// Token: 0x060366E9 RID: 222953 RVA: 0x00765349 File Offset: 0x00763549
		public static Offset<IUsePhantomSkill> EndIUsePhantomSkill(FlatBufferBuilder builder)
		{
			return new Offset<IUsePhantomSkill>(builder.EndTable());
		}

		// Token: 0x060366EA RID: 222954 RVA: 0x00765358 File Offset: 0x00763558
		public IUsePhantomSkillT UnPack()
		{
			IUsePhantomSkillT usePhantomSkillT = new IUsePhantomSkillT();
			this.UnPackTo(usePhantomSkillT);
			return usePhantomSkillT;
		}

		// Token: 0x060366EB RID: 222955 RVA: 0x00765374 File Offset: 0x00763574
		public void UnPackTo(IUsePhantomSkillT _o)
		{
			_o.SkillType = this.SkillType;
			_o.BlackboardPos = ((this.BlackboardPos != null) ? this.BlackboardPos.Value.UnPack() : null);
			_o.BlackboardRot = ((this.BlackboardRot != null) ? this.BlackboardRot.Value.UnPack() : null);
		}

		// Token: 0x060366EC RID: 222956 RVA: 0x007653EC File Offset: 0x007635EC
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

		// Token: 0x040123C1 RID: 74689
		private Table __p;
	}
}
