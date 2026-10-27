using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003BB6 RID: 15286
	public struct IShowTimelineConfig : IFlatbufferObject
	{
		// Token: 0x170068D3 RID: 26835
		// (get) Token: 0x06014F8B RID: 85899 RVA: 0x0030A989 File Offset: 0x00308B89
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06014F8C RID: 85900 RVA: 0x0030A996 File Offset: 0x00308B96
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06014F8D RID: 85901 RVA: 0x0030A9A0 File Offset: 0x00308BA0
		public static IShowTimelineConfig GetRootAsIShowTimelineConfig(ByteBuffer _bb)
		{
			return IShowTimelineConfig.GetRootAsIShowTimelineConfig(_bb, default(IShowTimelineConfig));
		}

		// Token: 0x06014F8E RID: 85902 RVA: 0x0030A9BC File Offset: 0x00308BBC
		public static IShowTimelineConfig GetRootAsIShowTimelineConfig(ByteBuffer _bb, IShowTimelineConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06014F8F RID: 85903 RVA: 0x0030A9D9 File Offset: 0x00308BD9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06014F90 RID: 85904 RVA: 0x0030A9E8 File Offset: 0x00308BE8
		public IShowTimelineConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170068D4 RID: 26836
		// (get) Token: 0x06014F91 RID: 85905 RVA: 0x0030A9F8 File Offset: 0x00308BF8
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

		// Token: 0x06014F92 RID: 85906 RVA: 0x0030AA2F File Offset: 0x00308C2F
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06014F93 RID: 85907 RVA: 0x0030AA3E File Offset: 0x00308C3E
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x170068D5 RID: 26837
		// (get) Token: 0x06014F94 RID: 85908 RVA: 0x0030AA4C File Offset: 0x00308C4C
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

		// Token: 0x06014F95 RID: 85909 RVA: 0x0030AA83 File Offset: 0x00308C83
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06014F96 RID: 85910 RVA: 0x0030AA92 File Offset: 0x00308C92
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x170068D6 RID: 26838
		// (get) Token: 0x06014F97 RID: 85911 RVA: 0x0030AAA0 File Offset: 0x00308CA0
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

		// Token: 0x06014F98 RID: 85912 RVA: 0x0030AAFD File Offset: 0x00308CFD
		public static Offset<IShowTimelineConfig> CreateIShowTimelineConfig(FlatBufferBuilder builder, StringOffset IdOffset = default(StringOffset), StringOffset NameOffset = default(StringOffset), Offset<IShowTimelineTrack> TrackOffset = default(Offset<IShowTimelineTrack>))
		{
			builder.StartTable(3);
			IShowTimelineConfig.AddTrack(builder, TrackOffset);
			IShowTimelineConfig.AddName(builder, NameOffset);
			IShowTimelineConfig.AddId(builder, IdOffset);
			return IShowTimelineConfig.EndIShowTimelineConfig(builder);
		}

		// Token: 0x06014F99 RID: 85913 RVA: 0x0030AB21 File Offset: 0x00308D21
		public static void StartIShowTimelineConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06014F9A RID: 85914 RVA: 0x0030AB2A File Offset: 0x00308D2A
		public static void AddId(FlatBufferBuilder builder, StringOffset idOffset)
		{
			builder.AddOffset(0, idOffset.Value, 0);
		}

		// Token: 0x06014F9B RID: 85915 RVA: 0x0030AB3A File Offset: 0x00308D3A
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(1, nameOffset.Value, 0);
		}

		// Token: 0x06014F9C RID: 85916 RVA: 0x0030AB4A File Offset: 0x00308D4A
		public static void AddTrack(FlatBufferBuilder builder, Offset<IShowTimelineTrack> trackOffset)
		{
			builder.AddOffset(2, trackOffset.Value, 0);
		}

		// Token: 0x06014F9D RID: 85917 RVA: 0x0030AB5A File Offset: 0x00308D5A
		public static Offset<IShowTimelineConfig> EndIShowTimelineConfig(FlatBufferBuilder builder)
		{
			return new Offset<IShowTimelineConfig>(builder.EndTable());
		}

		// Token: 0x06014F9E RID: 85918 RVA: 0x0030AB68 File Offset: 0x00308D68
		public IShowTimelineConfigT UnPack()
		{
			IShowTimelineConfigT showTimelineConfigT = new IShowTimelineConfigT();
			this.UnPackTo(showTimelineConfigT);
			return showTimelineConfigT;
		}

		// Token: 0x06014F9F RID: 85919 RVA: 0x0030AB84 File Offset: 0x00308D84
		public void UnPackTo(IShowTimelineConfigT _o)
		{
			_o.Id = this.Id;
			_o.Name = this.Name;
			_o.Track = ((this.Track != null) ? this.Track.Value.UnPack() : null);
		}

		// Token: 0x06014FA0 RID: 85920 RVA: 0x0030ABD8 File Offset: 0x00308DD8
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

		// Token: 0x0400B13B RID: 45371
		private Table __p;
	}
}
