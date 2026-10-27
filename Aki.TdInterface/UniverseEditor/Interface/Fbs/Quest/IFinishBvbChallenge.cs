using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E30 RID: 15920
	public struct IFinishBvbChallenge : IFlatbufferObject
	{
		// Token: 0x17006E13 RID: 28179
		// (get) Token: 0x06016501 RID: 91393 RVA: 0x00338AA3 File Offset: 0x00336CA3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016502 RID: 91394 RVA: 0x00338AB0 File Offset: 0x00336CB0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016503 RID: 91395 RVA: 0x00338AB8 File Offset: 0x00336CB8
		public static IFinishBvbChallenge GetRootAsIFinishBvbChallenge(ByteBuffer _bb)
		{
			return IFinishBvbChallenge.GetRootAsIFinishBvbChallenge(_bb, default(IFinishBvbChallenge));
		}

		// Token: 0x06016504 RID: 91396 RVA: 0x00338AD4 File Offset: 0x00336CD4
		public static IFinishBvbChallenge GetRootAsIFinishBvbChallenge(ByteBuffer _bb, IFinishBvbChallenge obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016505 RID: 91397 RVA: 0x00338AF1 File Offset: 0x00336CF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016506 RID: 91398 RVA: 0x00338B00 File Offset: 0x00336D00
		public IFinishBvbChallenge __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006E14 RID: 28180
		// (get) Token: 0x06016507 RID: 91399 RVA: 0x00338B10 File Offset: 0x00336D10
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

		// Token: 0x17006E15 RID: 28181
		// (get) Token: 0x06016508 RID: 91400 RVA: 0x00338B4C File Offset: 0x00336D4C
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

		// Token: 0x17006E16 RID: 28182
		// (get) Token: 0x06016509 RID: 91401 RVA: 0x00338BAC File Offset: 0x00336DAC
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

		// Token: 0x0601650A RID: 91402 RVA: 0x00338BE8 File Offset: 0x00336DE8
		public static Offset<IFinishBvbChallenge> CreateIFinishBvbChallenge(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), int BvbChallengeId = 0)
		{
			builder.StartTable(3);
			IFinishBvbChallenge.AddBvbChallengeId(builder, BvbChallengeId);
			IFinishBvbChallenge.AddPreConditions(builder, PreConditionsOffset);
			IFinishBvbChallenge.AddType(builder, Type);
			return IFinishBvbChallenge.EndIFinishBvbChallenge(builder);
		}

		// Token: 0x0601650B RID: 91403 RVA: 0x00338C0C File Offset: 0x00336E0C
		public static void StartIFinishBvbChallenge(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601650C RID: 91404 RVA: 0x00338C15 File Offset: 0x00336E15
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601650D RID: 91405 RVA: 0x00338C20 File Offset: 0x00336E20
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x0601650E RID: 91406 RVA: 0x00338C30 File Offset: 0x00336E30
		public static void AddBvbChallengeId(FlatBufferBuilder builder, int bvbChallengeId)
		{
			builder.AddInt(2, bvbChallengeId, 0);
		}

		// Token: 0x0601650F RID: 91407 RVA: 0x00338C3B File Offset: 0x00336E3B
		public static Offset<IFinishBvbChallenge> EndIFinishBvbChallenge(FlatBufferBuilder builder)
		{
			return new Offset<IFinishBvbChallenge>(builder.EndTable());
		}

		// Token: 0x06016510 RID: 91408 RVA: 0x00338C48 File Offset: 0x00336E48
		public IFinishBvbChallengeT UnPack()
		{
			IFinishBvbChallengeT finishBvbChallengeT = new IFinishBvbChallengeT();
			this.UnPackTo(finishBvbChallengeT);
			return finishBvbChallengeT;
		}

		// Token: 0x06016511 RID: 91409 RVA: 0x00338C64 File Offset: 0x00336E64
		public void UnPackTo(IFinishBvbChallengeT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.BvbChallengeId = this.BvbChallengeId;
		}

		// Token: 0x06016512 RID: 91410 RVA: 0x00338CB8 File Offset: 0x00336EB8
		public static Offset<IFinishBvbChallenge> Pack(FlatBufferBuilder builder, IFinishBvbChallengeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFinishBvbChallenge>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			return IFinishBvbChallenge.CreateIFinishBvbChallenge(builder, _o.Type, preConditionsOffset, _o.BvbChallengeId);
		}

		// Token: 0x0400B7B5 RID: 47029
		private Table __p;
	}
}
