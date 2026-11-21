using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004983 RID: 18819
	public struct ILevelPlayTrack : IFlatbufferObject
	{
		// Token: 0x170083A5 RID: 33701
		// (get) Token: 0x0601C12E RID: 114990 RVA: 0x003F7DF0 File Offset: 0x003F5FF0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C12F RID: 114991 RVA: 0x003F7DFD File Offset: 0x003F5FFD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C130 RID: 114992 RVA: 0x003F7E04 File Offset: 0x003F6004
		public static ILevelPlayTrack GetRootAsILevelPlayTrack(ByteBuffer _bb)
		{
			return ILevelPlayTrack.GetRootAsILevelPlayTrack(_bb, default(ILevelPlayTrack));
		}

		// Token: 0x0601C131 RID: 114993 RVA: 0x003F7E20 File Offset: 0x003F6020
		public static ILevelPlayTrack GetRootAsILevelPlayTrack(ByteBuffer _bb, ILevelPlayTrack obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C132 RID: 114994 RVA: 0x003F7E3D File Offset: 0x003F603D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C133 RID: 114995 RVA: 0x003F7E4C File Offset: 0x003F604C
		public ILevelPlayTrack __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170083A6 RID: 33702
		// (get) Token: 0x0601C134 RID: 114996 RVA: 0x003F7E5C File Offset: 0x003F605C
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

		// Token: 0x170083A7 RID: 33703
		// (get) Token: 0x0601C135 RID: 114997 RVA: 0x003F7E98 File Offset: 0x003F6098
		public int TrackPriority
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

		// Token: 0x170083A8 RID: 33704
		// (get) Token: 0x0601C136 RID: 114998 RVA: 0x003F7ED4 File Offset: 0x003F60D4
		public int RangeEntity
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

		// Token: 0x170083A9 RID: 33705
		// (get) Token: 0x0601C137 RID: 114999 RVA: 0x003F7F10 File Offset: 0x003F6110
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601C138 RID: 115000 RVA: 0x003F7F4D File Offset: 0x003F614D
		public static Offset<ILevelPlayTrack> CreateILevelPlayTrack(FlatBufferBuilder builder, int TrackRadius = 0, int TrackPriority = 0, int RangeEntity = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			ILevelPlayTrack.AddRangeEntity(builder, RangeEntity);
			ILevelPlayTrack.AddTrackPriority(builder, TrackPriority);
			ILevelPlayTrack.AddTrackRadius(builder, TrackRadius);
			ILevelPlayTrack.AddNullMask(builder, NullMask);
			return ILevelPlayTrack.EndILevelPlayTrack(builder);
		}

		// Token: 0x0601C139 RID: 115001 RVA: 0x003F7F79 File Offset: 0x003F6179
		public static void StartILevelPlayTrack(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601C13A RID: 115002 RVA: 0x003F7F82 File Offset: 0x003F6182
		public static void AddTrackRadius(FlatBufferBuilder builder, int trackRadius)
		{
			builder.AddInt(0, trackRadius, 0);
		}

		// Token: 0x0601C13B RID: 115003 RVA: 0x003F7F8D File Offset: 0x003F618D
		public static void AddTrackPriority(FlatBufferBuilder builder, int trackPriority)
		{
			builder.AddInt(1, trackPriority, 0);
		}

		// Token: 0x0601C13C RID: 115004 RVA: 0x003F7F98 File Offset: 0x003F6198
		public static void AddRangeEntity(FlatBufferBuilder builder, int rangeEntity)
		{
			builder.AddInt(2, rangeEntity, 0);
		}

		// Token: 0x0601C13D RID: 115005 RVA: 0x003F7FA3 File Offset: 0x003F61A3
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0601C13E RID: 115006 RVA: 0x003F7FAE File Offset: 0x003F61AE
		public static Offset<ILevelPlayTrack> EndILevelPlayTrack(FlatBufferBuilder builder)
		{
			return new Offset<ILevelPlayTrack>(builder.EndTable());
		}

		// Token: 0x0601C13F RID: 115007 RVA: 0x003F7FBC File Offset: 0x003F61BC
		public ILevelPlayTrackT UnPack()
		{
			ILevelPlayTrackT levelPlayTrackT = new ILevelPlayTrackT();
			this.UnPackTo(levelPlayTrackT);
			return levelPlayTrackT;
		}

		// Token: 0x0601C140 RID: 115008 RVA: 0x003F7FD7 File Offset: 0x003F61D7
		public void UnPackTo(ILevelPlayTrackT _o)
		{
			_o.TrackRadius = this.TrackRadius;
			_o.TrackPriority = this.TrackPriority;
			_o.RangeEntity = this.RangeEntity;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601C141 RID: 115009 RVA: 0x003F800C File Offset: 0x003F620C
		public static Offset<ILevelPlayTrack> Pack(FlatBufferBuilder builder, ILevelPlayTrackT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILevelPlayTrack>);
			}
			return ILevelPlayTrack.CreateILevelPlayTrack(builder, _o.TrackRadius, _o.TrackPriority, _o.RangeEntity, _o.NullMask);
		}

		// Token: 0x0400CFC2 RID: 53186
		private Table __p;
	}
}
