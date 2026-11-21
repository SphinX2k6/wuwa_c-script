using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020049AA RID: 18858
	public struct IRemainScoreLeCondition : IFlatbufferObject
	{
		// Token: 0x17008400 RID: 33792
		// (get) Token: 0x0601C288 RID: 115336 RVA: 0x003FA212 File Offset: 0x003F8412
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C289 RID: 115337 RVA: 0x003FA21F File Offset: 0x003F841F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C28A RID: 115338 RVA: 0x003FA228 File Offset: 0x003F8428
		public static IRemainScoreLeCondition GetRootAsIRemainScoreLeCondition(ByteBuffer _bb)
		{
			return IRemainScoreLeCondition.GetRootAsIRemainScoreLeCondition(_bb, default(IRemainScoreLeCondition));
		}

		// Token: 0x0601C28B RID: 115339 RVA: 0x003FA244 File Offset: 0x003F8444
		public static IRemainScoreLeCondition GetRootAsIRemainScoreLeCondition(ByteBuffer _bb, IRemainScoreLeCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C28C RID: 115340 RVA: 0x003FA261 File Offset: 0x003F8461
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C28D RID: 115341 RVA: 0x003FA270 File Offset: 0x003F8470
		public IRemainScoreLeCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008401 RID: 33793
		// (get) Token: 0x0601C28E RID: 115342 RVA: 0x003FA280 File Offset: 0x003F8480
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

		// Token: 0x17008402 RID: 33794
		// (get) Token: 0x0601C28F RID: 115343 RVA: 0x003FA2BC File Offset: 0x003F84BC
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

		// Token: 0x0601C290 RID: 115344 RVA: 0x003FA2F8 File Offset: 0x003F84F8
		public static Offset<IRemainScoreLeCondition> CreateIRemainScoreLeCondition(FlatBufferBuilder builder, EDartSkillConditionType Type = EDartSkillConditionType.RemainScoreGe, int Score = 0)
		{
			builder.StartTable(2);
			IRemainScoreLeCondition.AddScore(builder, Score);
			IRemainScoreLeCondition.AddType(builder, Type);
			return IRemainScoreLeCondition.EndIRemainScoreLeCondition(builder);
		}

		// Token: 0x0601C291 RID: 115345 RVA: 0x003FA315 File Offset: 0x003F8515
		public static void StartIRemainScoreLeCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601C292 RID: 115346 RVA: 0x003FA31E File Offset: 0x003F851E
		public static void AddType(FlatBufferBuilder builder, EDartSkillConditionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601C293 RID: 115347 RVA: 0x003FA329 File Offset: 0x003F8529
		public static void AddScore(FlatBufferBuilder builder, int score)
		{
			builder.AddInt(1, score, 0);
		}

		// Token: 0x0601C294 RID: 115348 RVA: 0x003FA334 File Offset: 0x003F8534
		public static Offset<IRemainScoreLeCondition> EndIRemainScoreLeCondition(FlatBufferBuilder builder)
		{
			return new Offset<IRemainScoreLeCondition>(builder.EndTable());
		}

		// Token: 0x0601C295 RID: 115349 RVA: 0x003FA344 File Offset: 0x003F8544
		public IRemainScoreLeConditionT UnPack()
		{
			IRemainScoreLeConditionT remainScoreLeConditionT = new IRemainScoreLeConditionT();
			this.UnPackTo(remainScoreLeConditionT);
			return remainScoreLeConditionT;
		}

		// Token: 0x0601C296 RID: 115350 RVA: 0x003FA35F File Offset: 0x003F855F
		public void UnPackTo(IRemainScoreLeConditionT _o)
		{
			_o.Type = this.Type;
			_o.Score = this.Score;
		}

		// Token: 0x0601C297 RID: 115351 RVA: 0x003FA37C File Offset: 0x003F857C
		public static Offset<IRemainScoreLeCondition> Pack(FlatBufferBuilder builder, IRemainScoreLeConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRemainScoreLeCondition>);
			}
			return IRemainScoreLeCondition.CreateIRemainScoreLeCondition(builder, _o.Type, _o.Score);
		}

		// Token: 0x0400CFF6 RID: 53238
		private Table __p;
	}
}
