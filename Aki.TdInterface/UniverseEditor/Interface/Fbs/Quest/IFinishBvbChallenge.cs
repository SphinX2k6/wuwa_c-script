using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200426B RID: 17003
	public struct IFinishBvbChallenge : IFlatbufferObject
	{
		// Token: 0x170073F9 RID: 29689
		// (get) Token: 0x06017B2E RID: 97070 RVA: 0x0036169B File Offset: 0x0035F89B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017B2F RID: 97071 RVA: 0x003616A8 File Offset: 0x0035F8A8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017B30 RID: 97072 RVA: 0x003616B0 File Offset: 0x0035F8B0
		public static IFinishBvbChallenge GetRootAsIFinishBvbChallenge(ByteBuffer _bb)
		{
			return IFinishBvbChallenge.GetRootAsIFinishBvbChallenge(_bb, default(IFinishBvbChallenge));
		}

		// Token: 0x06017B31 RID: 97073 RVA: 0x003616CC File Offset: 0x0035F8CC
		public static IFinishBvbChallenge GetRootAsIFinishBvbChallenge(ByteBuffer _bb, IFinishBvbChallenge obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017B32 RID: 97074 RVA: 0x003616E9 File Offset: 0x0035F8E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017B33 RID: 97075 RVA: 0x003616F8 File Offset: 0x0035F8F8
		public IFinishBvbChallenge __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170073FA RID: 29690
		// (get) Token: 0x06017B34 RID: 97076 RVA: 0x00361708 File Offset: 0x0035F908
		public EChildQuest Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EChildQuest.DoInteract;
				}
				return (EChildQuest)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170073FB RID: 29691
		// (get) Token: 0x06017B35 RID: 97077 RVA: 0x00361744 File Offset: 0x0035F944
		public IConditionGroup? PreConditions
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170073FC RID: 29692
		// (get) Token: 0x06017B36 RID: 97078 RVA: 0x003617A4 File Offset: 0x0035F9A4
		public int BvbChallengeId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06017B37 RID: 97079 RVA: 0x003617E0 File Offset: 0x0035F9E0
		public static Offset<IFinishBvbChallenge> CreateIFinishBvbChallenge(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), int BvbChallengeId = 0)
		{
			builder.StartTable(3);
			IFinishBvbChallenge.AddBvbChallengeId(builder, BvbChallengeId);
			IFinishBvbChallenge.AddPreConditions(builder, PreConditionsOffset);
			IFinishBvbChallenge.AddType(builder, Type);
			return IFinishBvbChallenge.EndIFinishBvbChallenge(builder);
		}

		// Token: 0x06017B38 RID: 97080 RVA: 0x00361804 File Offset: 0x0035FA04
		public static void StartIFinishBvbChallenge(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06017B39 RID: 97081 RVA: 0x0036180D File Offset: 0x0035FA0D
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017B3A RID: 97082 RVA: 0x00361818 File Offset: 0x0035FA18
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06017B3B RID: 97083 RVA: 0x00361828 File Offset: 0x0035FA28
		public static void AddBvbChallengeId(FlatBufferBuilder builder, int bvbChallengeId)
		{
			builder.AddInt(2, bvbChallengeId, 0);
		}

		// Token: 0x06017B3C RID: 97084 RVA: 0x00361833 File Offset: 0x0035FA33
		public static Offset<IFinishBvbChallenge> EndIFinishBvbChallenge(FlatBufferBuilder builder)
		{
			return new Offset<IFinishBvbChallenge>(builder.EndTable());
		}

		// Token: 0x06017B3D RID: 97085 RVA: 0x00361840 File Offset: 0x0035FA40
		public IFinishBvbChallengeT UnPack()
		{
			IFinishBvbChallengeT finishBvbChallengeT = new IFinishBvbChallengeT();
			this.UnPackTo(finishBvbChallengeT);
			return finishBvbChallengeT;
		}

		// Token: 0x06017B3E RID: 97086 RVA: 0x0036185C File Offset: 0x0035FA5C
		public void UnPackTo(IFinishBvbChallengeT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.BvbChallengeId = this.BvbChallengeId;
		}

		// Token: 0x06017B3F RID: 97087 RVA: 0x003618B0 File Offset: 0x0035FAB0
		public static Offset<IFinishBvbChallenge> Pack(FlatBufferBuilder builder, IFinishBvbChallengeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFinishBvbChallenge>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			return IFinishBvbChallenge.CreateIFinishBvbChallenge(builder, _o.Type, preConditionsOffset, _o.BvbChallengeId);
		}

		// Token: 0x0400C18D RID: 49549
		private Table __p;
	}
}
