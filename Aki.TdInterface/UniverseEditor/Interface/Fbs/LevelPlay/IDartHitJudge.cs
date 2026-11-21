using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020048DB RID: 18651
	public struct IDartHitJudge : IFlatbufferObject
	{
		// Token: 0x170081EB RID: 33259
		// (get) Token: 0x0601B9BB RID: 113083 RVA: 0x003E75D8 File Offset: 0x003E57D8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B9BC RID: 113084 RVA: 0x003E75E5 File Offset: 0x003E57E5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B9BD RID: 113085 RVA: 0x003E75EC File Offset: 0x003E57EC
		public static IDartHitJudge GetRootAsIDartHitJudge(ByteBuffer _bb)
		{
			return IDartHitJudge.GetRootAsIDartHitJudge(_bb, default(IDartHitJudge));
		}

		// Token: 0x0601B9BE RID: 113086 RVA: 0x003E7608 File Offset: 0x003E5808
		public static IDartHitJudge GetRootAsIDartHitJudge(ByteBuffer _bb, IDartHitJudge obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B9BF RID: 113087 RVA: 0x003E7625 File Offset: 0x003E5825
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B9C0 RID: 113088 RVA: 0x003E7634 File Offset: 0x003E5834
		public IDartHitJudge __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170081EC RID: 33260
		// (get) Token: 0x0601B9C1 RID: 113089 RVA: 0x003E7644 File Offset: 0x003E5844
		public IDartPreciseJudge? Precise
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IDartPreciseJudge?(default(IDartPreciseJudge).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170081ED RID: 33261
		// (get) Token: 0x0601B9C2 RID: 113090 RVA: 0x003E76A4 File Offset: 0x003E58A4
		public IDartScatterJudge? Scatter
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IDartScatterJudge?(default(IDartScatterJudge).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170081EE RID: 33262
		// (get) Token: 0x0601B9C3 RID: 113091 RVA: 0x003E7704 File Offset: 0x003E5904
		public IDartMissJudge? Miss
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IDartMissJudge?(default(IDartMissJudge).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601B9C4 RID: 113092 RVA: 0x003E7761 File Offset: 0x003E5961
		public static Offset<IDartHitJudge> CreateIDartHitJudge(FlatBufferBuilder builder, Offset<IDartPreciseJudge> PreciseOffset = default(Offset<IDartPreciseJudge>), Offset<IDartScatterJudge> ScatterOffset = default(Offset<IDartScatterJudge>), Offset<IDartMissJudge> MissOffset = default(Offset<IDartMissJudge>))
		{
			builder.StartTable(3);
			IDartHitJudge.AddMiss(builder, MissOffset);
			IDartHitJudge.AddScatter(builder, ScatterOffset);
			IDartHitJudge.AddPrecise(builder, PreciseOffset);
			return IDartHitJudge.EndIDartHitJudge(builder);
		}

		// Token: 0x0601B9C5 RID: 113093 RVA: 0x003E7785 File Offset: 0x003E5985
		public static void StartIDartHitJudge(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601B9C6 RID: 113094 RVA: 0x003E778E File Offset: 0x003E598E
		public static void AddPrecise(FlatBufferBuilder builder, Offset<IDartPreciseJudge> preciseOffset)
		{
			builder.AddOffset(0, preciseOffset.Value, 0);
		}

		// Token: 0x0601B9C7 RID: 113095 RVA: 0x003E779E File Offset: 0x003E599E
		public static void AddScatter(FlatBufferBuilder builder, Offset<IDartScatterJudge> scatterOffset)
		{
			builder.AddOffset(1, scatterOffset.Value, 0);
		}

		// Token: 0x0601B9C8 RID: 113096 RVA: 0x003E77AE File Offset: 0x003E59AE
		public static void AddMiss(FlatBufferBuilder builder, Offset<IDartMissJudge> missOffset)
		{
			builder.AddOffset(2, missOffset.Value, 0);
		}

		// Token: 0x0601B9C9 RID: 113097 RVA: 0x003E77BE File Offset: 0x003E59BE
		public static Offset<IDartHitJudge> EndIDartHitJudge(FlatBufferBuilder builder)
		{
			return new Offset<IDartHitJudge>(builder.EndTable());
		}

		// Token: 0x0601B9CA RID: 113098 RVA: 0x003E77CC File Offset: 0x003E59CC
		public IDartHitJudgeT UnPack()
		{
			IDartHitJudgeT dartHitJudgeT = new IDartHitJudgeT();
			this.UnPackTo(dartHitJudgeT);
			return dartHitJudgeT;
		}

		// Token: 0x0601B9CB RID: 113099 RVA: 0x003E77E8 File Offset: 0x003E59E8
		public void UnPackTo(IDartHitJudgeT _o)
		{
			_o.Precise = ((this.Precise != null) ? this.Precise.Value.UnPack() : null);
			_o.Scatter = ((this.Scatter != null) ? this.Scatter.Value.UnPack() : null);
			_o.Miss = ((this.Miss != null) ? this.Miss.Value.UnPack() : null);
		}

		// Token: 0x0601B9CC RID: 113100 RVA: 0x003E7888 File Offset: 0x003E5A88
		public static Offset<IDartHitJudge> Pack(FlatBufferBuilder builder, IDartHitJudgeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDartHitJudge>);
			}
			Offset<IDartPreciseJudge> preciseOffset = (_o.Precise == null) ? default(Offset<IDartPreciseJudge>) : IDartPreciseJudge.Pack(builder, _o.Precise);
			Offset<IDartScatterJudge> scatterOffset = (_o.Scatter == null) ? default(Offset<IDartScatterJudge>) : IDartScatterJudge.Pack(builder, _o.Scatter);
			Offset<IDartMissJudge> missOffset = (_o.Miss == null) ? default(Offset<IDartMissJudge>) : IDartMissJudge.Pack(builder, _o.Miss);
			return IDartHitJudge.CreateIDartHitJudge(builder, preciseOffset, scatterOffset, missOffset);
		}

		// Token: 0x0400CE96 RID: 52886
		private Table __p;
	}
}
