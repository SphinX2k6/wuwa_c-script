using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200459B RID: 17819
	public struct ISurvivorsRougeConditionStepBattle : IFlatbufferObject
	{
		// Token: 0x17007C98 RID: 31896
		// (get) Token: 0x06019FD8 RID: 106456 RVA: 0x003B4BCA File Offset: 0x003B2DCA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019FD9 RID: 106457 RVA: 0x003B4BD7 File Offset: 0x003B2DD7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019FDA RID: 106458 RVA: 0x003B4BE0 File Offset: 0x003B2DE0
		public static ISurvivorsRougeConditionStepBattle GetRootAsISurvivorsRougeConditionStepBattle(ByteBuffer _bb)
		{
			return ISurvivorsRougeConditionStepBattle.GetRootAsISurvivorsRougeConditionStepBattle(_bb, default(ISurvivorsRougeConditionStepBattle));
		}

		// Token: 0x06019FDB RID: 106459 RVA: 0x003B4BFC File Offset: 0x003B2DFC
		public static ISurvivorsRougeConditionStepBattle GetRootAsISurvivorsRougeConditionStepBattle(ByteBuffer _bb, ISurvivorsRougeConditionStepBattle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019FDC RID: 106460 RVA: 0x003B4C19 File Offset: 0x003B2E19
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019FDD RID: 106461 RVA: 0x003B4C28 File Offset: 0x003B2E28
		public ISurvivorsRougeConditionStepBattle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007C99 RID: 31897
		// (get) Token: 0x06019FDE RID: 106462 RVA: 0x003B4C38 File Offset: 0x003B2E38
		public ESurvivorsRougeConditionStep Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESurvivorsRougeConditionStep.Prepare;
				}
				return (ESurvivorsRougeConditionStep)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06019FDF RID: 106463 RVA: 0x003B4C74 File Offset: 0x003B2E74
		public static Offset<ISurvivorsRougeConditionStepBattle> CreateISurvivorsRougeConditionStepBattle(FlatBufferBuilder builder, ESurvivorsRougeConditionStep Type = ESurvivorsRougeConditionStep.Prepare)
		{
			builder.StartTable(1);
			ISurvivorsRougeConditionStepBattle.AddType(builder, Type);
			return ISurvivorsRougeConditionStepBattle.EndISurvivorsRougeConditionStepBattle(builder);
		}

		// Token: 0x06019FE0 RID: 106464 RVA: 0x003B4C8A File Offset: 0x003B2E8A
		public static void StartISurvivorsRougeConditionStepBattle(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06019FE1 RID: 106465 RVA: 0x003B4C93 File Offset: 0x003B2E93
		public static void AddType(FlatBufferBuilder builder, ESurvivorsRougeConditionStep type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019FE2 RID: 106466 RVA: 0x003B4C9E File Offset: 0x003B2E9E
		public static Offset<ISurvivorsRougeConditionStepBattle> EndISurvivorsRougeConditionStepBattle(FlatBufferBuilder builder)
		{
			return new Offset<ISurvivorsRougeConditionStepBattle>(builder.EndTable());
		}

		// Token: 0x06019FE3 RID: 106467 RVA: 0x003B4CAC File Offset: 0x003B2EAC
		public ISurvivorsRougeConditionStepBattleT UnPack()
		{
			ISurvivorsRougeConditionStepBattleT survivorsRougeConditionStepBattleT = new ISurvivorsRougeConditionStepBattleT();
			this.UnPackTo(survivorsRougeConditionStepBattleT);
			return survivorsRougeConditionStepBattleT;
		}

		// Token: 0x06019FE4 RID: 106468 RVA: 0x003B4CC7 File Offset: 0x003B2EC7
		public void UnPackTo(ISurvivorsRougeConditionStepBattleT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06019FE5 RID: 106469 RVA: 0x003B4CD8 File Offset: 0x003B2ED8
		public static Offset<ISurvivorsRougeConditionStepBattle> Pack(FlatBufferBuilder builder, ISurvivorsRougeConditionStepBattleT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISurvivorsRougeConditionStepBattle>);
			}
			return ISurvivorsRougeConditionStepBattle.CreateISurvivorsRougeConditionStepBattle(builder, _o.Type);
		}

		// Token: 0x0400C767 RID: 51047
		private Table __p;
	}
}
