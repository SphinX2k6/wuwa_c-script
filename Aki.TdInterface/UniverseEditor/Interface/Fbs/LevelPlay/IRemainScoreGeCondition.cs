using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020049A7 RID: 18855
	public struct IRemainScoreGeCondition : IFlatbufferObject
	{
		// Token: 0x170083FB RID: 33787
		// (get) Token: 0x0601C272 RID: 115314 RVA: 0x003FA011 File Offset: 0x003F8211
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C273 RID: 115315 RVA: 0x003FA01E File Offset: 0x003F821E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C274 RID: 115316 RVA: 0x003FA028 File Offset: 0x003F8228
		public static IRemainScoreGeCondition GetRootAsIRemainScoreGeCondition(ByteBuffer _bb)
		{
			return IRemainScoreGeCondition.GetRootAsIRemainScoreGeCondition(_bb, default(IRemainScoreGeCondition));
		}

		// Token: 0x0601C275 RID: 115317 RVA: 0x003FA044 File Offset: 0x003F8244
		public static IRemainScoreGeCondition GetRootAsIRemainScoreGeCondition(ByteBuffer _bb, IRemainScoreGeCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C276 RID: 115318 RVA: 0x003FA061 File Offset: 0x003F8261
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C277 RID: 115319 RVA: 0x003FA070 File Offset: 0x003F8270
		public IRemainScoreGeCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170083FC RID: 33788
		// (get) Token: 0x0601C278 RID: 115320 RVA: 0x003FA080 File Offset: 0x003F8280
		public EDartSkillConditionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EDartSkillConditionType.RemainScoreGe;
				}
				return (EDartSkillConditionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170083FD RID: 33789
		// (get) Token: 0x0601C279 RID: 115321 RVA: 0x003FA0BC File Offset: 0x003F82BC
		public int Score
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601C27A RID: 115322 RVA: 0x003FA0F8 File Offset: 0x003F82F8
		public static Offset<IRemainScoreGeCondition> CreateIRemainScoreGeCondition(FlatBufferBuilder builder, EDartSkillConditionType Type = EDartSkillConditionType.RemainScoreGe, int Score = 0)
		{
			builder.StartTable(2);
			IRemainScoreGeCondition.AddScore(builder, Score);
			IRemainScoreGeCondition.AddType(builder, Type);
			return IRemainScoreGeCondition.EndIRemainScoreGeCondition(builder);
		}

		// Token: 0x0601C27B RID: 115323 RVA: 0x003FA115 File Offset: 0x003F8315
		public static void StartIRemainScoreGeCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601C27C RID: 115324 RVA: 0x003FA11E File Offset: 0x003F831E
		public static void AddType(FlatBufferBuilder builder, EDartSkillConditionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601C27D RID: 115325 RVA: 0x003FA129 File Offset: 0x003F8329
		public static void AddScore(FlatBufferBuilder builder, int score)
		{
			builder.AddInt(1, score, 0);
		}

		// Token: 0x0601C27E RID: 115326 RVA: 0x003FA134 File Offset: 0x003F8334
		public static Offset<IRemainScoreGeCondition> EndIRemainScoreGeCondition(FlatBufferBuilder builder)
		{
			return new Offset<IRemainScoreGeCondition>(builder.EndTable());
		}

		// Token: 0x0601C27F RID: 115327 RVA: 0x003FA144 File Offset: 0x003F8344
		public IRemainScoreGeConditionT UnPack()
		{
			IRemainScoreGeConditionT remainScoreGeConditionT = new IRemainScoreGeConditionT();
			this.UnPackTo(remainScoreGeConditionT);
			return remainScoreGeConditionT;
		}

		// Token: 0x0601C280 RID: 115328 RVA: 0x003FA15F File Offset: 0x003F835F
		public void UnPackTo(IRemainScoreGeConditionT _o)
		{
			_o.Type = this.Type;
			_o.Score = this.Score;
		}

		// Token: 0x0601C281 RID: 115329 RVA: 0x003FA17C File Offset: 0x003F837C
		public static Offset<IRemainScoreGeCondition> Pack(FlatBufferBuilder builder, IRemainScoreGeConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRemainScoreGeCondition>);
			}
			return IRemainScoreGeCondition.CreateIRemainScoreGeCondition(builder, _o.Type, _o.Score);
		}

		// Token: 0x0400CFF3 RID: 53235
		private Table __p;
	}
}
