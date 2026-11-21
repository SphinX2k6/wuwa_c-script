using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020048D8 RID: 18648
	public struct IDartCompetitorStrategies : IFlatbufferObject
	{
		// Token: 0x170081E4 RID: 33252
		// (get) Token: 0x0601B9A1 RID: 113057 RVA: 0x003E7348 File Offset: 0x003E5548
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B9A2 RID: 113058 RVA: 0x003E7355 File Offset: 0x003E5555
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B9A3 RID: 113059 RVA: 0x003E735C File Offset: 0x003E555C
		public static IDartCompetitorStrategies GetRootAsIDartCompetitorStrategies(ByteBuffer _bb)
		{
			return IDartCompetitorStrategies.GetRootAsIDartCompetitorStrategies(_bb, default(IDartCompetitorStrategies));
		}

		// Token: 0x0601B9A4 RID: 113060 RVA: 0x003E7378 File Offset: 0x003E5578
		public static IDartCompetitorStrategies GetRootAsIDartCompetitorStrategies(ByteBuffer _bb, IDartCompetitorStrategies obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B9A5 RID: 113061 RVA: 0x003E7395 File Offset: 0x003E5595
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B9A6 RID: 113062 RVA: 0x003E73A4 File Offset: 0x003E55A4
		public IDartCompetitorStrategies __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170081E5 RID: 33253
		// (get) Token: 0x0601B9A7 RID: 113063 RVA: 0x003E73B4 File Offset: 0x003E55B4
		public int Mode301Strategy
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170081E6 RID: 33254
		// (get) Token: 0x0601B9A8 RID: 113064 RVA: 0x003E73F0 File Offset: 0x003E55F0
		public int Mode501Strategy
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

		// Token: 0x170081E7 RID: 33255
		// (get) Token: 0x0601B9A9 RID: 113065 RVA: 0x003E742C File Offset: 0x003E562C
		public int Mode701Strategy
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

		// Token: 0x0601B9AA RID: 113066 RVA: 0x003E7468 File Offset: 0x003E5668
		public static Offset<IDartCompetitorStrategies> CreateIDartCompetitorStrategies(FlatBufferBuilder builder, int Mode301Strategy = 0, int Mode501Strategy = 0, int Mode701Strategy = 0)
		{
			builder.StartTable(3);
			IDartCompetitorStrategies.AddMode701Strategy(builder, Mode701Strategy);
			IDartCompetitorStrategies.AddMode501Strategy(builder, Mode501Strategy);
			IDartCompetitorStrategies.AddMode301Strategy(builder, Mode301Strategy);
			return IDartCompetitorStrategies.EndIDartCompetitorStrategies(builder);
		}

		// Token: 0x0601B9AB RID: 113067 RVA: 0x003E748C File Offset: 0x003E568C
		public static void StartIDartCompetitorStrategies(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601B9AC RID: 113068 RVA: 0x003E7495 File Offset: 0x003E5695
		public static void AddMode301Strategy(FlatBufferBuilder builder, int mode301Strategy)
		{
			builder.AddInt(0, mode301Strategy, 0);
		}

		// Token: 0x0601B9AD RID: 113069 RVA: 0x003E74A0 File Offset: 0x003E56A0
		public static void AddMode501Strategy(FlatBufferBuilder builder, int mode501Strategy)
		{
			builder.AddInt(1, mode501Strategy, 0);
		}

		// Token: 0x0601B9AE RID: 113070 RVA: 0x003E74AB File Offset: 0x003E56AB
		public static void AddMode701Strategy(FlatBufferBuilder builder, int mode701Strategy)
		{
			builder.AddInt(2, mode701Strategy, 0);
		}

		// Token: 0x0601B9AF RID: 113071 RVA: 0x003E74B6 File Offset: 0x003E56B6
		public static Offset<IDartCompetitorStrategies> EndIDartCompetitorStrategies(FlatBufferBuilder builder)
		{
			return new Offset<IDartCompetitorStrategies>(builder.EndTable());
		}

		// Token: 0x0601B9B0 RID: 113072 RVA: 0x003E74C4 File Offset: 0x003E56C4
		public IDartCompetitorStrategiesT UnPack()
		{
			IDartCompetitorStrategiesT dartCompetitorStrategiesT = new IDartCompetitorStrategiesT();
			this.UnPackTo(dartCompetitorStrategiesT);
			return dartCompetitorStrategiesT;
		}

		// Token: 0x0601B9B1 RID: 113073 RVA: 0x003E74DF File Offset: 0x003E56DF
		public void UnPackTo(IDartCompetitorStrategiesT _o)
		{
			_o.Mode301Strategy = this.Mode301Strategy;
			_o.Mode501Strategy = this.Mode501Strategy;
			_o.Mode701Strategy = this.Mode701Strategy;
		}

		// Token: 0x0601B9B2 RID: 113074 RVA: 0x003E7508 File Offset: 0x003E5708
		public static Offset<IDartCompetitorStrategies> Pack(FlatBufferBuilder builder, IDartCompetitorStrategiesT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDartCompetitorStrategies>);
			}
			return IDartCompetitorStrategies.CreateIDartCompetitorStrategies(builder, _o.Mode301Strategy, _o.Mode501Strategy, _o.Mode701Strategy);
		}

		// Token: 0x0400CE92 RID: 52882
		private Table __p;
	}
}
