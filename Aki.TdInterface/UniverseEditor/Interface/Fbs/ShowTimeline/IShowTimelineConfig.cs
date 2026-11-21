using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003FBE RID: 16318
	public struct IShowTimelineConfig : IFlatbufferObject
	{
		// Token: 0x17006E76 RID: 28278
		// (get) Token: 0x06016463 RID: 91235 RVA: 0x003311E5 File Offset: 0x0032F3E5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016464 RID: 91236 RVA: 0x003311F2 File Offset: 0x0032F3F2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016465 RID: 91237 RVA: 0x003311FC File Offset: 0x0032F3FC
		public static IShowTimelineConfig GetRootAsIShowTimelineConfig(ByteBuffer _bb)
		{
			return IShowTimelineConfig.GetRootAsIShowTimelineConfig(_bb, default(IShowTimelineConfig));
		}

		// Token: 0x06016466 RID: 91238 RVA: 0x00331218 File Offset: 0x0032F418
		public static IShowTimelineConfig GetRootAsIShowTimelineConfig(ByteBuffer _bb, IShowTimelineConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016467 RID: 91239 RVA: 0x00331235 File Offset: 0x0032F435
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016468 RID: 91240 RVA: 0x00331244 File Offset: 0x0032F444
		public IShowTimelineConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006E77 RID: 28279
		// (get) Token: 0x06016469 RID: 91241 RVA: 0x00331254 File Offset: 0x0032F454
		public string Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601646A RID: 91242 RVA: 0x0033128B File Offset: 0x0032F48B
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601646B RID: 91243 RVA: 0x0033129A File Offset: 0x0032F49A
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17006E78 RID: 28280
		// (get) Token: 0x0601646C RID: 91244 RVA: 0x003312A8 File Offset: 0x0032F4A8
		public string Name
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601646D RID: 91245 RVA: 0x003312DF File Offset: 0x0032F4DF
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601646E RID: 91246 RVA: 0x003312EE File Offset: 0x0032F4EE
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17006E79 RID: 28281
		// (get) Token: 0x0601646F RID: 91247 RVA: 0x003312FC File Offset: 0x0032F4FC
		public IShowTimelineTrack? Track
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IShowTimelineTrack?(default(IShowTimelineTrack).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06016470 RID: 91248 RVA: 0x00331359 File Offset: 0x0032F559
		public static Offset<IShowTimelineConfig> CreateIShowTimelineConfig(FlatBufferBuilder builder, StringOffset IdOffset = default(StringOffset), StringOffset NameOffset = default(StringOffset), Offset<IShowTimelineTrack> TrackOffset = default(Offset<IShowTimelineTrack>))
		{
			builder.StartTable(3);
			IShowTimelineConfig.AddTrack(builder, TrackOffset);
			IShowTimelineConfig.AddName(builder, NameOffset);
			IShowTimelineConfig.AddId(builder, IdOffset);
			return IShowTimelineConfig.EndIShowTimelineConfig(builder);
		}

		// Token: 0x06016471 RID: 91249 RVA: 0x0033137D File Offset: 0x0032F57D
		public static void StartIShowTimelineConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06016472 RID: 91250 RVA: 0x00331386 File Offset: 0x0032F586
		public static void AddId(FlatBufferBuilder builder, StringOffset idOffset)
		{
			builder.AddOffset(0, idOffset.Value, 0);
		}

		// Token: 0x06016473 RID: 91251 RVA: 0x00331396 File Offset: 0x0032F596
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(1, nameOffset.Value, 0);
		}

		// Token: 0x06016474 RID: 91252 RVA: 0x003313A6 File Offset: 0x0032F5A6
		public static void AddTrack(FlatBufferBuilder builder, Offset<IShowTimelineTrack> trackOffset)
		{
			builder.AddOffset(2, trackOffset.Value, 0);
		}

		// Token: 0x06016475 RID: 91253 RVA: 0x003313B6 File Offset: 0x0032F5B6
		public static Offset<IShowTimelineConfig> EndIShowTimelineConfig(FlatBufferBuilder builder)
		{
			return new Offset<IShowTimelineConfig>(builder.EndTable());
		}

		// Token: 0x06016476 RID: 91254 RVA: 0x003313C4 File Offset: 0x0032F5C4
		public IShowTimelineConfigT UnPack()
		{
			IShowTimelineConfigT showTimelineConfigT = new IShowTimelineConfigT();
			this.UnPackTo(showTimelineConfigT);
			return showTimelineConfigT;
		}

		// Token: 0x06016477 RID: 91255 RVA: 0x003313E0 File Offset: 0x0032F5E0
		public void UnPackTo(IShowTimelineConfigT _o)
		{
			_o.Id = this.Id;
			_o.Name = this.Name;
			_o.Track = ((this.Track != null) ? this.Track.Value.UnPack() : null);
		}

		// Token: 0x06016478 RID: 91256 RVA: 0x00331434 File Offset: 0x0032F634
		public static Offset<IShowTimelineConfig> Pack(FlatBufferBuilder builder, IShowTimelineConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IShowTimelineConfig>);
			}
			StringOffset idOffset = (_o.Id == null) ? default(StringOffset) : builder.CreateString(_o.Id);
			StringOffset nameOffset = (_o.Name == null) ? default(StringOffset) : builder.CreateString(_o.Name);
			Offset<IShowTimelineTrack> trackOffset = (_o.Track == null) ? default(Offset<IShowTimelineTrack>) : IShowTimelineTrack.Pack(builder, _o.Track);
			return IShowTimelineConfig.CreateIShowTimelineConfig(builder, idOffset, nameOffset, trackOffset);
		}

		// Token: 0x0400BABA RID: 47802
		private Table __p;
	}
}
