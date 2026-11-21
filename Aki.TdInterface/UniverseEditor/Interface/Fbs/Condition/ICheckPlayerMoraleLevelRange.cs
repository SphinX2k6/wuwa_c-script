using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004FCE RID: 20430
	public struct ICheckPlayerMoraleLevelRange : IFlatbufferObject
	{
		// Token: 0x17009220 RID: 37408
		// (get) Token: 0x0601FDAB RID: 130475 RVA: 0x0046C85A File Offset: 0x0046AA5A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FDAC RID: 130476 RVA: 0x0046C867 File Offset: 0x0046AA67
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FDAD RID: 130477 RVA: 0x0046C870 File Offset: 0x0046AA70
		public static ICheckPlayerMoraleLevelRange GetRootAsICheckPlayerMoraleLevelRange(ByteBuffer _bb)
		{
			return ICheckPlayerMoraleLevelRange.GetRootAsICheckPlayerMoraleLevelRange(_bb, default(ICheckPlayerMoraleLevelRange));
		}

		// Token: 0x0601FDAE RID: 130478 RVA: 0x0046C88C File Offset: 0x0046AA8C
		public static ICheckPlayerMoraleLevelRange GetRootAsICheckPlayerMoraleLevelRange(ByteBuffer _bb, ICheckPlayerMoraleLevelRange obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FDAF RID: 130479 RVA: 0x0046C8A9 File Offset: 0x0046AAA9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FDB0 RID: 130480 RVA: 0x0046C8B8 File Offset: 0x0046AAB8
		public ICheckPlayerMoraleLevelRange __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009221 RID: 37409
		// (get) Token: 0x0601FDB1 RID: 130481 RVA: 0x0046C8C8 File Offset: 0x0046AAC8
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

		// Token: 0x17009222 RID: 37410
		// (get) Token: 0x0601FDB2 RID: 130482 RVA: 0x0046C904 File Offset: 0x0046AB04
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

		// Token: 0x17009223 RID: 37411
		// (get) Token: 0x0601FDB3 RID: 130483 RVA: 0x0046C940 File Offset: 0x0046AB40
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

		// Token: 0x0601FDB4 RID: 130484 RVA: 0x0046C97C File Offset: 0x0046AB7C
		public static Offset<ICheckPlayerMoraleLevelRange> CreateICheckPlayerMoraleLevelRange(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int MinMoraleLevel = 0, int MaxMoraleLevel = 0)
		{
			builder.StartTable(3);
			ICheckPlayerMoraleLevelRange.AddMaxMoraleLevel(builder, MaxMoraleLevel);
			ICheckPlayerMoraleLevelRange.AddMinMoraleLevel(builder, MinMoraleLevel);
			ICheckPlayerMoraleLevelRange.AddType(builder, Type);
			return ICheckPlayerMoraleLevelRange.EndICheckPlayerMoraleLevelRange(builder);
		}

		// Token: 0x0601FDB5 RID: 130485 RVA: 0x0046C9A0 File Offset: 0x0046ABA0
		public static void StartICheckPlayerMoraleLevelRange(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601FDB6 RID: 130486 RVA: 0x0046C9A9 File Offset: 0x0046ABA9
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601FDB7 RID: 130487 RVA: 0x0046C9B4 File Offset: 0x0046ABB4
		public static void AddMinMoraleLevel(FlatBufferBuilder builder, int minMoraleLevel)
		{
			builder.AddInt(1, minMoraleLevel, 0);
		}

		// Token: 0x0601FDB8 RID: 130488 RVA: 0x0046C9BF File Offset: 0x0046ABBF
		public static void AddMaxMoraleLevel(FlatBufferBuilder builder, int maxMoraleLevel)
		{
			builder.AddInt(2, maxMoraleLevel, 0);
		}

		// Token: 0x0601FDB9 RID: 130489 RVA: 0x0046C9CA File Offset: 0x0046ABCA
		public static Offset<ICheckPlayerMoraleLevelRange> EndICheckPlayerMoraleLevelRange(FlatBufferBuilder builder)
		{
			return new Offset<ICheckPlayerMoraleLevelRange>(builder.EndTable());
		}

		// Token: 0x0601FDBA RID: 130490 RVA: 0x0046C9D8 File Offset: 0x0046ABD8
		public ICheckPlayerMoraleLevelRangeT UnPack()
		{
			ICheckPlayerMoraleLevelRangeT checkPlayerMoraleLevelRangeT = new ICheckPlayerMoraleLevelRangeT();
			this.UnPackTo(checkPlayerMoraleLevelRangeT);
			return checkPlayerMoraleLevelRangeT;
		}

		// Token: 0x0601FDBB RID: 130491 RVA: 0x0046C9F3 File Offset: 0x0046ABF3
		public void UnPackTo(ICheckPlayerMoraleLevelRangeT _o)
		{
			_o.Type = this.Type;
			_o.MinMoraleLevel = this.MinMoraleLevel;
			_o.MaxMoraleLevel = this.MaxMoraleLevel;
		}

		// Token: 0x0601FDBC RID: 130492 RVA: 0x0046CA1C File Offset: 0x0046AC1C
		public static Offset<ICheckPlayerMoraleLevelRange> Pack(FlatBufferBuilder builder, ICheckPlayerMoraleLevelRangeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckPlayerMoraleLevelRange>);
			}
			return ICheckPlayerMoraleLevelRange.CreateICheckPlayerMoraleLevelRange(builder, _o.Type, _o.MinMoraleLevel, _o.MaxMoraleLevel);
		}

		// Token: 0x0400DE75 RID: 56949
		private Table __p;
	}
}
