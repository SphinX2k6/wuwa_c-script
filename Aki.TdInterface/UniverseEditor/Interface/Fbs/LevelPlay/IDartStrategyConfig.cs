using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004494 RID: 17556
	public struct IDartStrategyConfig : IFlatbufferObject
	{
		// Token: 0x17007BDA RID: 31706
		// (get) Token: 0x0601A2FA RID: 107258 RVA: 0x003BD704 File Offset: 0x003BB904
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A2FB RID: 107259 RVA: 0x003BD711 File Offset: 0x003BB911
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A2FC RID: 107260 RVA: 0x003BD718 File Offset: 0x003BB918
		public static IDartStrategyConfig GetRootAsIDartStrategyConfig(ByteBuffer _bb)
		{
			return IDartStrategyConfig.GetRootAsIDartStrategyConfig(_bb, default(IDartStrategyConfig));
		}

		// Token: 0x0601A2FD RID: 107261 RVA: 0x003BD734 File Offset: 0x003BB934
		public static IDartStrategyConfig GetRootAsIDartStrategyConfig(ByteBuffer _bb, IDartStrategyConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A2FE RID: 107262 RVA: 0x003BD751 File Offset: 0x003BB951
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A2FF RID: 107263 RVA: 0x003BD760 File Offset: 0x003BB960
		public IDartStrategyConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007BDB RID: 31707
		// (get) Token: 0x0601A300 RID: 107264 RVA: 0x003BD770 File Offset: 0x003BB970
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

		// Token: 0x17007BDC RID: 31708
		// (get) Token: 0x0601A301 RID: 107265 RVA: 0x003BD7D0 File Offset: 0x003BB9D0
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

		// Token: 0x0601A302 RID: 107266 RVA: 0x003BD82D File Offset: 0x003BBA2D
		public static Offset<IDartStrategyConfig> CreateIDartStrategyConfig(FlatBufferBuilder builder, Offset<IDartThrowStrategy> ThrowStrategyOffset = default(Offset<IDartThrowStrategy>), Offset<IDartHitJudge> HitJudgeOffset = default(Offset<IDartHitJudge>))
		{
			builder.StartTable(2);
			IDartStrategyConfig.AddHitJudge(builder, HitJudgeOffset);
			IDartStrategyConfig.AddThrowStrategy(builder, ThrowStrategyOffset);
			return IDartStrategyConfig.EndIDartStrategyConfig(builder);
		}

		// Token: 0x0601A303 RID: 107267 RVA: 0x003BD84A File Offset: 0x003BBA4A
		public static void StartIDartStrategyConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601A304 RID: 107268 RVA: 0x003BD853 File Offset: 0x003BBA53
		public static void AddThrowStrategy(FlatBufferBuilder builder, Offset<IDartThrowStrategy> throwStrategyOffset)
		{
			builder.AddOffset(0, throwStrategyOffset.Value, 0);
		}

		// Token: 0x0601A305 RID: 107269 RVA: 0x003BD863 File Offset: 0x003BBA63
		public static void AddHitJudge(FlatBufferBuilder builder, Offset<IDartHitJudge> hitJudgeOffset)
		{
			builder.AddOffset(1, hitJudgeOffset.Value, 0);
		}

		// Token: 0x0601A306 RID: 107270 RVA: 0x003BD873 File Offset: 0x003BBA73
		public static Offset<IDartStrategyConfig> EndIDartStrategyConfig(FlatBufferBuilder builder)
		{
			return new Offset<IDartStrategyConfig>(builder.EndTable());
		}

		// Token: 0x0601A307 RID: 107271 RVA: 0x003BD880 File Offset: 0x003BBA80
		public IDartStrategyConfigT UnPack()
		{
			IDartStrategyConfigT dartStrategyConfigT = new IDartStrategyConfigT();
			this.UnPackTo(dartStrategyConfigT);
			return dartStrategyConfigT;
		}

		// Token: 0x0601A308 RID: 107272 RVA: 0x003BD89C File Offset: 0x003BBA9C
		public void UnPackTo(IDartStrategyConfigT _o)
		{
			_o.ThrowStrategy = ((this.ThrowStrategy != null) ? this.ThrowStrategy.Value.UnPack() : null);
			_o.HitJudge = ((this.HitJudge != null) ? this.HitJudge.Value.UnPack() : null);
		}

		// Token: 0x0601A309 RID: 107273 RVA: 0x003BD908 File Offset: 0x003BBB08
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

		// Token: 0x0400C49A RID: 50330
		private Table __p;
	}
}
