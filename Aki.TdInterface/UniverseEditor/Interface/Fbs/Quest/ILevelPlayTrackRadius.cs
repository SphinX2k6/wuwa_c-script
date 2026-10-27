using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F05 RID: 16133
	public struct ILevelPlayTrackRadius : IFlatbufferObject
	{
		// Token: 0x17006FE9 RID: 28649
		// (get) Token: 0x06016D6C RID: 93548 RVA: 0x0034B2BB File Offset: 0x003494BB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016D6D RID: 93549 RVA: 0x0034B2C8 File Offset: 0x003494C8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016D6E RID: 93550 RVA: 0x0034B2D0 File Offset: 0x003494D0
		public static ILevelPlayTrackRadius GetRootAsILevelPlayTrackRadius(ByteBuffer _bb)
		{
			return ILevelPlayTrackRadius.GetRootAsILevelPlayTrackRadius(_bb, default(ILevelPlayTrackRadius));
		}

		// Token: 0x06016D6F RID: 93551 RVA: 0x0034B2EC File Offset: 0x003494EC
		public static ILevelPlayTrackRadius GetRootAsILevelPlayTrackRadius(ByteBuffer _bb, ILevelPlayTrackRadius obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016D70 RID: 93552 RVA: 0x0034B309 File Offset: 0x00349509
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016D71 RID: 93553 RVA: 0x0034B318 File Offset: 0x00349518
		public ILevelPlayTrackRadius __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006FEA RID: 28650
		// (get) Token: 0x06016D72 RID: 93554 RVA: 0x0034B328 File Offset: 0x00349528
		public int TrackRadius
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

		// Token: 0x06016D73 RID: 93555 RVA: 0x0034B364 File Offset: 0x00349564
		public static Offset<ILevelPlayTrackRadius> CreateILevelPlayTrackRadius(FlatBufferBuilder builder, int TrackRadius = 0)
		{
			builder.StartTable(1);
			ILevelPlayTrackRadius.AddTrackRadius(builder, TrackRadius);
			return ILevelPlayTrackRadius.EndILevelPlayTrackRadius(builder);
		}

		// Token: 0x06016D74 RID: 93556 RVA: 0x0034B37A File Offset: 0x0034957A
		public static void StartILevelPlayTrackRadius(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06016D75 RID: 93557 RVA: 0x0034B383 File Offset: 0x00349583
		public static void AddTrackRadius(FlatBufferBuilder builder, int trackRadius)
		{
			builder.AddInt(0, trackRadius, 0);
		}

		// Token: 0x06016D76 RID: 93558 RVA: 0x0034B38E File Offset: 0x0034958E
		public static Offset<ILevelPlayTrackRadius> EndILevelPlayTrackRadius(FlatBufferBuilder builder)
		{
			return new Offset<ILevelPlayTrackRadius>(builder.EndTable());
		}

		// Token: 0x06016D77 RID: 93559 RVA: 0x0034B39C File Offset: 0x0034959C
		public ILevelPlayTrackRadiusT UnPack()
		{
			ILevelPlayTrackRadiusT levelPlayTrackRadiusT = new ILevelPlayTrackRadiusT();
			this.UnPackTo(levelPlayTrackRadiusT);
			return levelPlayTrackRadiusT;
		}

		// Token: 0x06016D78 RID: 93560 RVA: 0x0034B3B7 File Offset: 0x003495B7
		public void UnPackTo(ILevelPlayTrackRadiusT _o)
		{
			_o.TrackRadius = this.TrackRadius;
		}

		// Token: 0x06016D79 RID: 93561 RVA: 0x0034B3C8 File Offset: 0x003495C8
		public static Offset<ILevelPlayTrackRadius> Pack(FlatBufferBuilder builder, ILevelPlayTrackRadiusT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILevelPlayTrackRadius>);
			}
			return ILevelPlayTrackRadius.CreateILevelPlayTrackRadius(builder, _o.TrackRadius);
		}

		// Token: 0x0400B8E3 RID: 47331
		private Table __p;
	}
}
