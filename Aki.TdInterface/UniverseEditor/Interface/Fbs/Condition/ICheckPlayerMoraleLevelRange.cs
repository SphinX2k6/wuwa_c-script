using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004AF3 RID: 19187
	public struct ICheckPlayerMoraleLevelRange : IFlatbufferObject
	{
		// Token: 0x17008B1F RID: 35615
		// (get) Token: 0x0601E26A RID: 123498 RVA: 0x0043A7AE File Offset: 0x004389AE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E26B RID: 123499 RVA: 0x0043A7BB File Offset: 0x004389BB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E26C RID: 123500 RVA: 0x0043A7C4 File Offset: 0x004389C4
		public static ICheckPlayerMoraleLevelRange GetRootAsICheckPlayerMoraleLevelRange(ByteBuffer _bb)
		{
			return ICheckPlayerMoraleLevelRange.GetRootAsICheckPlayerMoraleLevelRange(_bb, default(ICheckPlayerMoraleLevelRange));
		}

		// Token: 0x0601E26D RID: 123501 RVA: 0x0043A7E0 File Offset: 0x004389E0
		public static ICheckPlayerMoraleLevelRange GetRootAsICheckPlayerMoraleLevelRange(ByteBuffer _bb, ICheckPlayerMoraleLevelRange obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E26E RID: 123502 RVA: 0x0043A7FD File Offset: 0x004389FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E26F RID: 123503 RVA: 0x0043A80C File Offset: 0x00438A0C
		public ICheckPlayerMoraleLevelRange __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008B20 RID: 35616
		// (get) Token: 0x0601E270 RID: 123504 RVA: 0x0043A81C File Offset: 0x00438A1C
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008B21 RID: 35617
		// (get) Token: 0x0601E271 RID: 123505 RVA: 0x0043A858 File Offset: 0x00438A58
		public int MinMoraleLevel
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

		// Token: 0x17008B22 RID: 35618
		// (get) Token: 0x0601E272 RID: 123506 RVA: 0x0043A894 File Offset: 0x00438A94
		public int MaxMoraleLevel
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

		// Token: 0x0601E273 RID: 123507 RVA: 0x0043A8D0 File Offset: 0x00438AD0
		public static Offset<ICheckPlayerMoraleLevelRange> CreateICheckPlayerMoraleLevelRange(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int MinMoraleLevel = 0, int MaxMoraleLevel = 0)
		{
			builder.StartTable(3);
			ICheckPlayerMoraleLevelRange.AddMaxMoraleLevel(builder, MaxMoraleLevel);
			ICheckPlayerMoraleLevelRange.AddMinMoraleLevel(builder, MinMoraleLevel);
			ICheckPlayerMoraleLevelRange.AddType(builder, Type);
			return ICheckPlayerMoraleLevelRange.EndICheckPlayerMoraleLevelRange(builder);
		}

		// Token: 0x0601E274 RID: 123508 RVA: 0x0043A8F4 File Offset: 0x00438AF4
		public static void StartICheckPlayerMoraleLevelRange(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601E275 RID: 123509 RVA: 0x0043A8FD File Offset: 0x00438AFD
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E276 RID: 123510 RVA: 0x0043A908 File Offset: 0x00438B08
		public static void AddMinMoraleLevel(FlatBufferBuilder builder, int minMoraleLevel)
		{
			builder.AddInt(1, minMoraleLevel, 0);
		}

		// Token: 0x0601E277 RID: 123511 RVA: 0x0043A913 File Offset: 0x00438B13
		public static void AddMaxMoraleLevel(FlatBufferBuilder builder, int maxMoraleLevel)
		{
			builder.AddInt(2, maxMoraleLevel, 0);
		}

		// Token: 0x0601E278 RID: 123512 RVA: 0x0043A91E File Offset: 0x00438B1E
		public static Offset<ICheckPlayerMoraleLevelRange> EndICheckPlayerMoraleLevelRange(FlatBufferBuilder builder)
		{
			return new Offset<ICheckPlayerMoraleLevelRange>(builder.EndTable());
		}

		// Token: 0x0601E279 RID: 123513 RVA: 0x0043A92C File Offset: 0x00438B2C
		public ICheckPlayerMoraleLevelRangeT UnPack()
		{
			ICheckPlayerMoraleLevelRangeT checkPlayerMoraleLevelRangeT = new ICheckPlayerMoraleLevelRangeT();
			this.UnPackTo(checkPlayerMoraleLevelRangeT);
			return checkPlayerMoraleLevelRangeT;
		}

		// Token: 0x0601E27A RID: 123514 RVA: 0x0043A947 File Offset: 0x00438B47
		public void UnPackTo(ICheckPlayerMoraleLevelRangeT _o)
		{
			_o.Type = this.Type;
			_o.MinMoraleLevel = this.MinMoraleLevel;
			_o.MaxMoraleLevel = this.MaxMoraleLevel;
		}

		// Token: 0x0601E27B RID: 123515 RVA: 0x0043A970 File Offset: 0x00438B70
		public static Offset<ICheckPlayerMoraleLevelRange> Pack(FlatBufferBuilder builder, ICheckPlayerMoraleLevelRangeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckPlayerMoraleLevelRange>);
			}
			return ICheckPlayerMoraleLevelRange.CreateICheckPlayerMoraleLevelRange(builder, _o.Type, _o.MinMoraleLevel, _o.MaxMoraleLevel);
		}

		// Token: 0x0400D384 RID: 54148
		private Table __p;
	}
}
