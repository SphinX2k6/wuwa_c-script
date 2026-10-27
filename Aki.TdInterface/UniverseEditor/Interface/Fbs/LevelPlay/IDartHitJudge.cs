using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004473 RID: 17523
	public struct IDartHitJudge : IFlatbufferObject
	{
		// Token: 0x17007BAC RID: 31660
		// (get) Token: 0x0601A1EA RID: 106986 RVA: 0x003BB3CC File Offset: 0x003B95CC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A1EB RID: 106987 RVA: 0x003BB3D9 File Offset: 0x003B95D9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A1EC RID: 106988 RVA: 0x003BB3E0 File Offset: 0x003B95E0
		public static IDartHitJudge GetRootAsIDartHitJudge(ByteBuffer _bb)
		{
			return IDartHitJudge.GetRootAsIDartHitJudge(_bb, default(IDartHitJudge));
		}

		// Token: 0x0601A1ED RID: 106989 RVA: 0x003BB3FC File Offset: 0x003B95FC
		public static IDartHitJudge GetRootAsIDartHitJudge(ByteBuffer _bb, IDartHitJudge obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A1EE RID: 106990 RVA: 0x003BB419 File Offset: 0x003B9619
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A1EF RID: 106991 RVA: 0x003BB428 File Offset: 0x003B9628
		public IDartHitJudge __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007BAD RID: 31661
		// (get) Token: 0x0601A1F0 RID: 106992 RVA: 0x003BB438 File Offset: 0x003B9638
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

		// Token: 0x17007BAE RID: 31662
		// (get) Token: 0x0601A1F1 RID: 106993 RVA: 0x003BB498 File Offset: 0x003B9698
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

		// Token: 0x17007BAF RID: 31663
		// (get) Token: 0x0601A1F2 RID: 106994 RVA: 0x003BB4F8 File Offset: 0x003B96F8
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

		// Token: 0x0601A1F3 RID: 106995 RVA: 0x003BB555 File Offset: 0x003B9755
		public static Offset<IDartHitJudge> CreateIDartHitJudge(FlatBufferBuilder builder, Offset<IDartPreciseJudge> PreciseOffset = default(Offset<IDartPreciseJudge>), Offset<IDartScatterJudge> ScatterOffset = default(Offset<IDartScatterJudge>), Offset<IDartMissJudge> MissOffset = default(Offset<IDartMissJudge>))
		{
			builder.StartTable(3);
			IDartHitJudge.AddMiss(builder, MissOffset);
			IDartHitJudge.AddScatter(builder, ScatterOffset);
			IDartHitJudge.AddPrecise(builder, PreciseOffset);
			return IDartHitJudge.EndIDartHitJudge(builder);
		}

		// Token: 0x0601A1F4 RID: 106996 RVA: 0x003BB579 File Offset: 0x003B9779
		public static void StartIDartHitJudge(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601A1F5 RID: 106997 RVA: 0x003BB582 File Offset: 0x003B9782
		public static void AddPrecise(FlatBufferBuilder builder, Offset<IDartPreciseJudge> preciseOffset)
		{
			builder.AddOffset(0, preciseOffset.Value, 0);
		}

		// Token: 0x0601A1F6 RID: 106998 RVA: 0x003BB592 File Offset: 0x003B9792
		public static void AddScatter(FlatBufferBuilder builder, Offset<IDartScatterJudge> scatterOffset)
		{
			builder.AddOffset(1, scatterOffset.Value, 0);
		}

		// Token: 0x0601A1F7 RID: 106999 RVA: 0x003BB5A2 File Offset: 0x003B97A2
		public static void AddMiss(FlatBufferBuilder builder, Offset<IDartMissJudge> missOffset)
		{
			builder.AddOffset(2, missOffset.Value, 0);
		}

		// Token: 0x0601A1F8 RID: 107000 RVA: 0x003BB5B2 File Offset: 0x003B97B2
		public static Offset<IDartHitJudge> EndIDartHitJudge(FlatBufferBuilder builder)
		{
			return new Offset<IDartHitJudge>(builder.EndTable());
		}

		// Token: 0x0601A1F9 RID: 107001 RVA: 0x003BB5C0 File Offset: 0x003B97C0
		public IDartHitJudgeT UnPack()
		{
			IDartHitJudgeT dartHitJudgeT = new IDartHitJudgeT();
			this.UnPackTo(dartHitJudgeT);
			return dartHitJudgeT;
		}

		// Token: 0x0601A1FA RID: 107002 RVA: 0x003BB5DC File Offset: 0x003B97DC
		public void UnPackTo(IDartHitJudgeT _o)
		{
			_o.Precise = ((this.Precise != null) ? this.Precise.Value.UnPack() : null);
			_o.Scatter = ((this.Scatter != null) ? this.Scatter.Value.UnPack() : null);
			_o.Miss = ((this.Miss != null) ? this.Miss.Value.UnPack() : null);
		}

		// Token: 0x0601A1FB RID: 107003 RVA: 0x003BB67C File Offset: 0x003B987C
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

		// Token: 0x0400C468 RID: 50280
		private Table __p;
	}
}
