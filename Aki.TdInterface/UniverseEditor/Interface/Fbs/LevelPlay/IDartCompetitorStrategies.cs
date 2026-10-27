using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004470 RID: 17520
	public struct IDartCompetitorStrategies : IFlatbufferObject
	{
		// Token: 0x17007BA5 RID: 31653
		// (get) Token: 0x0601A1D0 RID: 106960 RVA: 0x003BB13C File Offset: 0x003B933C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A1D1 RID: 106961 RVA: 0x003BB149 File Offset: 0x003B9349
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A1D2 RID: 106962 RVA: 0x003BB150 File Offset: 0x003B9350
		public static IDartCompetitorStrategies GetRootAsIDartCompetitorStrategies(ByteBuffer _bb)
		{
			return IDartCompetitorStrategies.GetRootAsIDartCompetitorStrategies(_bb, default(IDartCompetitorStrategies));
		}

		// Token: 0x0601A1D3 RID: 106963 RVA: 0x003BB16C File Offset: 0x003B936C
		public static IDartCompetitorStrategies GetRootAsIDartCompetitorStrategies(ByteBuffer _bb, IDartCompetitorStrategies obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A1D4 RID: 106964 RVA: 0x003BB189 File Offset: 0x003B9389
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A1D5 RID: 106965 RVA: 0x003BB198 File Offset: 0x003B9398
		public IDartCompetitorStrategies __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007BA6 RID: 31654
		// (get) Token: 0x0601A1D6 RID: 106966 RVA: 0x003BB1A8 File Offset: 0x003B93A8
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

		// Token: 0x17007BA7 RID: 31655
		// (get) Token: 0x0601A1D7 RID: 106967 RVA: 0x003BB1E4 File Offset: 0x003B93E4
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

		// Token: 0x17007BA8 RID: 31656
		// (get) Token: 0x0601A1D8 RID: 106968 RVA: 0x003BB220 File Offset: 0x003B9420
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

		// Token: 0x0601A1D9 RID: 106969 RVA: 0x003BB25C File Offset: 0x003B945C
		public static Offset<IDartCompetitorStrategies> CreateIDartCompetitorStrategies(FlatBufferBuilder builder, int Mode301Strategy = 0, int Mode501Strategy = 0, int Mode701Strategy = 0)
		{
			builder.StartTable(3);
			IDartCompetitorStrategies.AddMode701Strategy(builder, Mode701Strategy);
			IDartCompetitorStrategies.AddMode501Strategy(builder, Mode501Strategy);
			IDartCompetitorStrategies.AddMode301Strategy(builder, Mode301Strategy);
			return IDartCompetitorStrategies.EndIDartCompetitorStrategies(builder);
		}

		// Token: 0x0601A1DA RID: 106970 RVA: 0x003BB280 File Offset: 0x003B9480
		public static void StartIDartCompetitorStrategies(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601A1DB RID: 106971 RVA: 0x003BB289 File Offset: 0x003B9489
		public static void AddMode301Strategy(FlatBufferBuilder builder, int mode301Strategy)
		{
			builder.AddInt(0, mode301Strategy, 0);
		}

		// Token: 0x0601A1DC RID: 106972 RVA: 0x003BB294 File Offset: 0x003B9494
		public static void AddMode501Strategy(FlatBufferBuilder builder, int mode501Strategy)
		{
			builder.AddInt(1, mode501Strategy, 0);
		}

		// Token: 0x0601A1DD RID: 106973 RVA: 0x003BB29F File Offset: 0x003B949F
		public static void AddMode701Strategy(FlatBufferBuilder builder, int mode701Strategy)
		{
			builder.AddInt(2, mode701Strategy, 0);
		}

		// Token: 0x0601A1DE RID: 106974 RVA: 0x003BB2AA File Offset: 0x003B94AA
		public static Offset<IDartCompetitorStrategies> EndIDartCompetitorStrategies(FlatBufferBuilder builder)
		{
			return new Offset<IDartCompetitorStrategies>(builder.EndTable());
		}

		// Token: 0x0601A1DF RID: 106975 RVA: 0x003BB2B8 File Offset: 0x003B94B8
		public IDartCompetitorStrategiesT UnPack()
		{
			IDartCompetitorStrategiesT dartCompetitorStrategiesT = new IDartCompetitorStrategiesT();
			this.UnPackTo(dartCompetitorStrategiesT);
			return dartCompetitorStrategiesT;
		}

		// Token: 0x0601A1E0 RID: 106976 RVA: 0x003BB2D3 File Offset: 0x003B94D3
		public void UnPackTo(IDartCompetitorStrategiesT _o)
		{
			_o.Mode301Strategy = this.Mode301Strategy;
			_o.Mode501Strategy = this.Mode501Strategy;
			_o.Mode701Strategy = this.Mode701Strategy;
		}

		// Token: 0x0601A1E1 RID: 106977 RVA: 0x003BB2FC File Offset: 0x003B94FC
		public static Offset<IDartCompetitorStrategies> Pack(FlatBufferBuilder builder, IDartCompetitorStrategiesT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDartCompetitorStrategies>);
			}
			return IDartCompetitorStrategies.CreateIDartCompetitorStrategies(builder, _o.Mode301Strategy, _o.Mode501Strategy, _o.Mode701Strategy);
		}

		// Token: 0x0400C464 RID: 50276
		private Table __p;
	}
}
