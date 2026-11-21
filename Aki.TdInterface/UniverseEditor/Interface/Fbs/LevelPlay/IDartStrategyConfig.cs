using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020048FC RID: 18684
	public struct IDartStrategyConfig : IFlatbufferObject
	{
		// Token: 0x17008219 RID: 33305
		// (get) Token: 0x0601BACB RID: 113355 RVA: 0x003E9910 File Offset: 0x003E7B10
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601BACC RID: 113356 RVA: 0x003E991D File Offset: 0x003E7B1D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601BACD RID: 113357 RVA: 0x003E9924 File Offset: 0x003E7B24
		public static IDartStrategyConfig GetRootAsIDartStrategyConfig(ByteBuffer _bb)
		{
			return IDartStrategyConfig.GetRootAsIDartStrategyConfig(_bb, default(IDartStrategyConfig));
		}

		// Token: 0x0601BACE RID: 113358 RVA: 0x003E9940 File Offset: 0x003E7B40
		public static IDartStrategyConfig GetRootAsIDartStrategyConfig(ByteBuffer _bb, IDartStrategyConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601BACF RID: 113359 RVA: 0x003E995D File Offset: 0x003E7B5D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601BAD0 RID: 113360 RVA: 0x003E996C File Offset: 0x003E7B6C
		public IDartStrategyConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700821A RID: 33306
		// (get) Token: 0x0601BAD1 RID: 113361 RVA: 0x003E997C File Offset: 0x003E7B7C
		public IDartThrowStrategy? ThrowStrategy
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IDartThrowStrategy?(default(IDartThrowStrategy).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700821B RID: 33307
		// (get) Token: 0x0601BAD2 RID: 113362 RVA: 0x003E99DC File Offset: 0x003E7BDC
		public IDartHitJudge? HitJudge
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IDartHitJudge?(default(IDartHitJudge).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601BAD3 RID: 113363 RVA: 0x003E9A39 File Offset: 0x003E7C39
		public static Offset<IDartStrategyConfig> CreateIDartStrategyConfig(FlatBufferBuilder builder, Offset<IDartThrowStrategy> ThrowStrategyOffset = default(Offset<IDartThrowStrategy>), Offset<IDartHitJudge> HitJudgeOffset = default(Offset<IDartHitJudge>))
		{
			builder.StartTable(2);
			IDartStrategyConfig.AddHitJudge(builder, HitJudgeOffset);
			IDartStrategyConfig.AddThrowStrategy(builder, ThrowStrategyOffset);
			return IDartStrategyConfig.EndIDartStrategyConfig(builder);
		}

		// Token: 0x0601BAD4 RID: 113364 RVA: 0x003E9A56 File Offset: 0x003E7C56
		public static void StartIDartStrategyConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601BAD5 RID: 113365 RVA: 0x003E9A5F File Offset: 0x003E7C5F
		public static void AddThrowStrategy(FlatBufferBuilder builder, Offset<IDartThrowStrategy> throwStrategyOffset)
		{
			builder.AddOffset(0, throwStrategyOffset.Value, 0);
		}

		// Token: 0x0601BAD6 RID: 113366 RVA: 0x003E9A6F File Offset: 0x003E7C6F
		public static void AddHitJudge(FlatBufferBuilder builder, Offset<IDartHitJudge> hitJudgeOffset)
		{
			builder.AddOffset(1, hitJudgeOffset.Value, 0);
		}

		// Token: 0x0601BAD7 RID: 113367 RVA: 0x003E9A7F File Offset: 0x003E7C7F
		public static Offset<IDartStrategyConfig> EndIDartStrategyConfig(FlatBufferBuilder builder)
		{
			return new Offset<IDartStrategyConfig>(builder.EndTable());
		}

		// Token: 0x0601BAD8 RID: 113368 RVA: 0x003E9A8C File Offset: 0x003E7C8C
		public IDartStrategyConfigT UnPack()
		{
			IDartStrategyConfigT dartStrategyConfigT = new IDartStrategyConfigT();
			this.UnPackTo(dartStrategyConfigT);
			return dartStrategyConfigT;
		}

		// Token: 0x0601BAD9 RID: 113369 RVA: 0x003E9AA8 File Offset: 0x003E7CA8
		public void UnPackTo(IDartStrategyConfigT _o)
		{
			_o.ThrowStrategy = ((this.ThrowStrategy != null) ? this.ThrowStrategy.Value.UnPack() : null);
			_o.HitJudge = ((this.HitJudge != null) ? this.HitJudge.Value.UnPack() : null);
		}

		// Token: 0x0601BADA RID: 113370 RVA: 0x003E9B14 File Offset: 0x003E7D14
		public static Offset<IDartStrategyConfig> Pack(FlatBufferBuilder builder, IDartStrategyConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDartStrategyConfig>);
			}
			Offset<IDartThrowStrategy> throwStrategyOffset = (_o.ThrowStrategy == null) ? default(Offset<IDartThrowStrategy>) : IDartThrowStrategy.Pack(builder, _o.ThrowStrategy);
			Offset<IDartHitJudge> hitJudgeOffset = (_o.HitJudge == null) ? default(Offset<IDartHitJudge>) : IDartHitJudge.Pack(builder, _o.HitJudge);
			return IDartStrategyConfig.CreateIDartStrategyConfig(builder, throwStrategyOffset, hitJudgeOffset);
		}

		// Token: 0x0400CEC8 RID: 52936
		private Table __p;
	}
}
