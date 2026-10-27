using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200451B RID: 17691
	public struct ILevelPlayTrack : IFlatbufferObject
	{
		// Token: 0x17007D64 RID: 32100
		// (get) Token: 0x0601A959 RID: 108889 RVA: 0x003CBB54 File Offset: 0x003C9D54
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A95A RID: 108890 RVA: 0x003CBB61 File Offset: 0x003C9D61
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A95B RID: 108891 RVA: 0x003CBB68 File Offset: 0x003C9D68
		public static ILevelPlayTrack GetRootAsILevelPlayTrack(ByteBuffer _bb)
		{
			return ILevelPlayTrack.GetRootAsILevelPlayTrack(_bb, default(ILevelPlayTrack));
		}

		// Token: 0x0601A95C RID: 108892 RVA: 0x003CBB84 File Offset: 0x003C9D84
		public static ILevelPlayTrack GetRootAsILevelPlayTrack(ByteBuffer _bb, ILevelPlayTrack obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A95D RID: 108893 RVA: 0x003CBBA1 File Offset: 0x003C9DA1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A95E RID: 108894 RVA: 0x003CBBB0 File Offset: 0x003C9DB0
		public ILevelPlayTrack __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007D65 RID: 32101
		// (get) Token: 0x0601A95F RID: 108895 RVA: 0x003CBBC0 File Offset: 0x003C9DC0
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

		// Token: 0x17007D66 RID: 32102
		// (get) Token: 0x0601A960 RID: 108896 RVA: 0x003CBBFC File Offset: 0x003C9DFC
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

		// Token: 0x17007D67 RID: 32103
		// (get) Token: 0x0601A961 RID: 108897 RVA: 0x003CBC38 File Offset: 0x003C9E38
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

		// Token: 0x17007D68 RID: 32104
		// (get) Token: 0x0601A962 RID: 108898 RVA: 0x003CBC74 File Offset: 0x003C9E74
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

		// Token: 0x0601A963 RID: 108899 RVA: 0x003CBCB1 File Offset: 0x003C9EB1
		public static Offset<ILevelPlayTrack> CreateILevelPlayTrack(FlatBufferBuilder builder, int TrackRadius = 0, int TrackPriority = 0, int RangeEntity = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			ILevelPlayTrack.AddRangeEntity(builder, RangeEntity);
			ILevelPlayTrack.AddTrackPriority(builder, TrackPriority);
			ILevelPlayTrack.AddTrackRadius(builder, TrackRadius);
			ILevelPlayTrack.AddNullMask(builder, NullMask);
			return ILevelPlayTrack.EndILevelPlayTrack(builder);
		}

		// Token: 0x0601A964 RID: 108900 RVA: 0x003CBCDD File Offset: 0x003C9EDD
		public static void StartILevelPlayTrack(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601A965 RID: 108901 RVA: 0x003CBCE6 File Offset: 0x003C9EE6
		public static void AddTrackRadius(FlatBufferBuilder builder, int trackRadius)
		{
			builder.AddInt(0, trackRadius, 0);
		}

		// Token: 0x0601A966 RID: 108902 RVA: 0x003CBCF1 File Offset: 0x003C9EF1
		public static void AddTrackPriority(FlatBufferBuilder builder, int trackPriority)
		{
			builder.AddInt(1, trackPriority, 0);
		}

		// Token: 0x0601A967 RID: 108903 RVA: 0x003CBCFC File Offset: 0x003C9EFC
		public static void AddRangeEntity(FlatBufferBuilder builder, int rangeEntity)
		{
			builder.AddInt(2, rangeEntity, 0);
		}

		// Token: 0x0601A968 RID: 108904 RVA: 0x003CBD07 File Offset: 0x003C9F07
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0601A969 RID: 108905 RVA: 0x003CBD12 File Offset: 0x003C9F12
		public static Offset<ILevelPlayTrack> EndILevelPlayTrack(FlatBufferBuilder builder)
		{
			return new Offset<ILevelPlayTrack>(builder.EndTable());
		}

		// Token: 0x0601A96A RID: 108906 RVA: 0x003CBD20 File Offset: 0x003C9F20
		public ILevelPlayTrackT UnPack()
		{
			ILevelPlayTrackT levelPlayTrackT = new ILevelPlayTrackT();
			this.UnPackTo(levelPlayTrackT);
			return levelPlayTrackT;
		}

		// Token: 0x0601A96B RID: 108907 RVA: 0x003CBD3B File Offset: 0x003C9F3B
		public void UnPackTo(ILevelPlayTrackT _o)
		{
			_o.TrackRadius = this.TrackRadius;
			_o.TrackPriority = this.TrackPriority;
			_o.RangeEntity = this.RangeEntity;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601A96C RID: 108908 RVA: 0x003CBD70 File Offset: 0x003C9F70
		public static Offset<ILevelPlayTrack> Pack(FlatBufferBuilder builder, ILevelPlayTrackT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILevelPlayTrack>);
			}
			return ILevelPlayTrack.CreateILevelPlayTrack(builder, _o.TrackRadius, _o.TrackPriority, _o.RangeEntity, _o.NullMask);
		}

		// Token: 0x0400C593 RID: 50579
		private Table __p;
	}
}
