using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200449D RID: 17565
	public struct IDoubleScoreZone : IFlatbufferObject
	{
		// Token: 0x17007BF1 RID: 31729
		// (get) Token: 0x0601A384 RID: 107396 RVA: 0x003BF1D6 File Offset: 0x003BD3D6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A385 RID: 107397 RVA: 0x003BF1E3 File Offset: 0x003BD3E3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A386 RID: 107398 RVA: 0x003BF1EC File Offset: 0x003BD3EC
		public static IDoubleScoreZone GetRootAsIDoubleScoreZone(ByteBuffer _bb)
		{
			return IDoubleScoreZone.GetRootAsIDoubleScoreZone(_bb, default(IDoubleScoreZone));
		}

		// Token: 0x0601A387 RID: 107399 RVA: 0x003BF208 File Offset: 0x003BD408
		public static IDoubleScoreZone GetRootAsIDoubleScoreZone(ByteBuffer _bb, IDoubleScoreZone obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A388 RID: 107400 RVA: 0x003BF225 File Offset: 0x003BD425
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A389 RID: 107401 RVA: 0x003BF234 File Offset: 0x003BD434
		public IDoubleScoreZone __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007BF2 RID: 31730
		// (get) Token: 0x0601A38A RID: 107402 RVA: 0x003BF244 File Offset: 0x003BD444
		public EDartboardZoneType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EDartboardZoneType.CenterBull;
				}
				return (EDartboardZoneType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007BF3 RID: 31731
		// (get) Token: 0x0601A38B RID: 107403 RVA: 0x003BF280 File Offset: 0x003BD480
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

		// Token: 0x17007BF4 RID: 31732
		// (get) Token: 0x0601A38C RID: 107404 RVA: 0x003BF2BC File Offset: 0x003BD4BC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601A38D RID: 107405 RVA: 0x003BF2F8 File Offset: 0x003BD4F8
		public static Offset<IDoubleScoreZone> CreateIDoubleScoreZone(FlatBufferBuilder builder, EDartboardZoneType Type = EDartboardZoneType.CenterBull, int Score = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			IDoubleScoreZone.AddScore(builder, Score);
			IDoubleScoreZone.AddNullMask(builder, NullMask);
			IDoubleScoreZone.AddType(builder, Type);
			return IDoubleScoreZone.EndIDoubleScoreZone(builder);
		}

		// Token: 0x0601A38E RID: 107406 RVA: 0x003BF31C File Offset: 0x003BD51C
		public static void StartIDoubleScoreZone(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601A38F RID: 107407 RVA: 0x003BF325 File Offset: 0x003BD525
		public static void AddType(FlatBufferBuilder builder, EDartboardZoneType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A390 RID: 107408 RVA: 0x003BF330 File Offset: 0x003BD530
		public static void AddScore(FlatBufferBuilder builder, int score)
		{
			builder.AddInt(1, score, 0);
		}

		// Token: 0x0601A391 RID: 107409 RVA: 0x003BF33B File Offset: 0x003BD53B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0601A392 RID: 107410 RVA: 0x003BF346 File Offset: 0x003BD546
		public static Offset<IDoubleScoreZone> EndIDoubleScoreZone(FlatBufferBuilder builder)
		{
			return new Offset<IDoubleScoreZone>(builder.EndTable());
		}

		// Token: 0x0601A393 RID: 107411 RVA: 0x003BF354 File Offset: 0x003BD554
		public IDoubleScoreZoneT UnPack()
		{
			IDoubleScoreZoneT doubleScoreZoneT = new IDoubleScoreZoneT();
			this.UnPackTo(doubleScoreZoneT);
			return doubleScoreZoneT;
		}

		// Token: 0x0601A394 RID: 107412 RVA: 0x003BF36F File Offset: 0x003BD56F
		public void UnPackTo(IDoubleScoreZoneT _o)
		{
			_o.Type = this.Type;
			_o.Score = this.Score;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601A395 RID: 107413 RVA: 0x003BF398 File Offset: 0x003BD598
		public static Offset<IDoubleScoreZone> Pack(FlatBufferBuilder builder, IDoubleScoreZoneT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDoubleScoreZone>);
			}
			return IDoubleScoreZone.CreateIDoubleScoreZone(builder, _o.Type, _o.Score, _o.NullMask);
		}

		// Token: 0x0400C4A5 RID: 50341
		private Table __p;
	}
}
