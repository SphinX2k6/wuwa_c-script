using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004157 RID: 16727
	public struct ISurvivorsRougeConditionStepBattle : IFlatbufferObject
	{
		// Token: 0x17007689 RID: 30345
		// (get) Token: 0x06018910 RID: 100624 RVA: 0x0038A60E File Offset: 0x0038880E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018911 RID: 100625 RVA: 0x0038A61B File Offset: 0x0038881B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018912 RID: 100626 RVA: 0x0038A624 File Offset: 0x00388824
		public static ISurvivorsRougeConditionStepBattle GetRootAsISurvivorsRougeConditionStepBattle(ByteBuffer _bb)
		{
			return ISurvivorsRougeConditionStepBattle.GetRootAsISurvivorsRougeConditionStepBattle(_bb, default(ISurvivorsRougeConditionStepBattle));
		}

		// Token: 0x06018913 RID: 100627 RVA: 0x0038A640 File Offset: 0x00388840
		public static ISurvivorsRougeConditionStepBattle GetRootAsISurvivorsRougeConditionStepBattle(ByteBuffer _bb, ISurvivorsRougeConditionStepBattle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018914 RID: 100628 RVA: 0x0038A65D File Offset: 0x0038885D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018915 RID: 100629 RVA: 0x0038A66C File Offset: 0x0038886C
		public ISurvivorsRougeConditionStepBattle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700768A RID: 30346
		// (get) Token: 0x06018916 RID: 100630 RVA: 0x0038A67C File Offset: 0x0038887C
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

		// Token: 0x06018917 RID: 100631 RVA: 0x0038A6B8 File Offset: 0x003888B8
		public static Offset<ISurvivorsRougeConditionStepBattle> CreateISurvivorsRougeConditionStepBattle(FlatBufferBuilder builder, ESurvivorsRougeConditionStep Type = ESurvivorsRougeConditionStep.Prepare)
		{
			builder.StartTable(1);
			ISurvivorsRougeConditionStepBattle.AddType(builder, Type);
			return ISurvivorsRougeConditionStepBattle.EndISurvivorsRougeConditionStepBattle(builder);
		}

		// Token: 0x06018918 RID: 100632 RVA: 0x0038A6CE File Offset: 0x003888CE
		public static void StartISurvivorsRougeConditionStepBattle(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06018919 RID: 100633 RVA: 0x0038A6D7 File Offset: 0x003888D7
		public static void AddType(FlatBufferBuilder builder, ESurvivorsRougeConditionStep type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601891A RID: 100634 RVA: 0x0038A6E2 File Offset: 0x003888E2
		public static Offset<ISurvivorsRougeConditionStepBattle> EndISurvivorsRougeConditionStepBattle(FlatBufferBuilder builder)
		{
			return new Offset<ISurvivorsRougeConditionStepBattle>(builder.EndTable());
		}

		// Token: 0x0601891B RID: 100635 RVA: 0x0038A6F0 File Offset: 0x003888F0
		public ISurvivorsRougeConditionStepBattleT UnPack()
		{
			ISurvivorsRougeConditionStepBattleT survivorsRougeConditionStepBattleT = new ISurvivorsRougeConditionStepBattleT();
			this.UnPackTo(survivorsRougeConditionStepBattleT);
			return survivorsRougeConditionStepBattleT;
		}

		// Token: 0x0601891C RID: 100636 RVA: 0x0038A70B File Offset: 0x0038890B
		public void UnPackTo(ISurvivorsRougeConditionStepBattleT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601891D RID: 100637 RVA: 0x0038A71C File Offset: 0x0038891C
		public static Offset<ISurvivorsRougeConditionStepBattle> Pack(FlatBufferBuilder builder, ISurvivorsRougeConditionStepBattleT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISurvivorsRougeConditionStepBattle>);
			}
			return ISurvivorsRougeConditionStepBattle.CreateISurvivorsRougeConditionStepBattle(builder, _o.Type);
		}

		// Token: 0x0400BD79 RID: 48505
		private Table __p;
	}
}
