using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007154 RID: 29012
	public struct ISlideRailStart : IFlatbufferObject
	{
		// Token: 0x1700D785 RID: 55173
		// (get) Token: 0x060336DE RID: 210654 RVA: 0x006EDF94 File Offset: 0x006EC194
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060336DF RID: 210655 RVA: 0x006EDFA1 File Offset: 0x006EC1A1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060336E0 RID: 210656 RVA: 0x006EDFA8 File Offset: 0x006EC1A8
		public static ISlideRailStart GetRootAsISlideRailStart(ByteBuffer _bb)
		{
			return ISlideRailStart.GetRootAsISlideRailStart(_bb, default(ISlideRailStart));
		}

		// Token: 0x060336E1 RID: 210657 RVA: 0x006EDFC4 File Offset: 0x006EC1C4
		public static ISlideRailStart GetRootAsISlideRailStart(ByteBuffer _bb, ISlideRailStart obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060336E2 RID: 210658 RVA: 0x006EDFE1 File Offset: 0x006EC1E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060336E3 RID: 210659 RVA: 0x006EDFF0 File Offset: 0x006EC1F0
		public ISlideRailStart __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D786 RID: 55174
		// (get) Token: 0x060336E4 RID: 210660 RVA: 0x006EE000 File Offset: 0x006EC200
		public int RailEntityId
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

		// Token: 0x1700D787 RID: 55175
		// (get) Token: 0x060336E5 RID: 210661 RVA: 0x006EE03C File Offset: 0x006EC23C
		public string SlidePerformDaPath
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

		// Token: 0x060336E6 RID: 210662 RVA: 0x006EE073 File Offset: 0x006EC273
		public Span<byte> GetSlidePerformDaPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060336E7 RID: 210663 RVA: 0x006EE082 File Offset: 0x006EC282
		public byte[] GetSlidePerformDaPathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700D788 RID: 55176
		// (get) Token: 0x060336E8 RID: 210664 RVA: 0x006EE090 File Offset: 0x006EC290
		public ISlideRailFollowConfig? SlideRailFollowConfig
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new ISlideRailFollowConfig?(default(ISlideRailFollowConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700D789 RID: 55177
		// (get) Token: 0x060336E9 RID: 210665 RVA: 0x006EE0F0 File Offset: 0x006EC2F0
		public ISlideRailRTPCParams? RTPCParams
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new ISlideRailRTPCParams?(default(ISlideRailRTPCParams).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060336EA RID: 210666 RVA: 0x006EE14E File Offset: 0x006EC34E
		public static Offset<ISlideRailStart> CreateISlideRailStart(FlatBufferBuilder builder, int RailEntityId = 0, StringOffset SlidePerformDaPathOffset = default(StringOffset), Offset<ISlideRailFollowConfig> SlideRailFollowConfigOffset = default(Offset<ISlideRailFollowConfig>), Offset<ISlideRailRTPCParams> RTPCParamsOffset = default(Offset<ISlideRailRTPCParams>))
		{
			builder.StartTable(4);
			ISlideRailStart.AddRTPCParams(builder, RTPCParamsOffset);
			ISlideRailStart.AddSlideRailFollowConfig(builder, SlideRailFollowConfigOffset);
			ISlideRailStart.AddSlidePerformDaPath(builder, SlidePerformDaPathOffset);
			ISlideRailStart.AddRailEntityId(builder, RailEntityId);
			return ISlideRailStart.EndISlideRailStart(builder);
		}

		// Token: 0x060336EB RID: 210667 RVA: 0x006EE17A File Offset: 0x006EC37A
		public static void StartISlideRailStart(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060336EC RID: 210668 RVA: 0x006EE183 File Offset: 0x006EC383
		public static void AddRailEntityId(FlatBufferBuilder builder, int railEntityId)
		{
			builder.AddInt(0, railEntityId, 0);
		}

		// Token: 0x060336ED RID: 210669 RVA: 0x006EE18E File Offset: 0x006EC38E
		public static void AddSlidePerformDaPath(FlatBufferBuilder builder, StringOffset slidePerformDaPathOffset)
		{
			builder.AddOffset(1, slidePerformDaPathOffset.Value, 0);
		}

		// Token: 0x060336EE RID: 210670 RVA: 0x006EE19E File Offset: 0x006EC39E
		public static void AddSlideRailFollowConfig(FlatBufferBuilder builder, Offset<ISlideRailFollowConfig> slideRailFollowConfigOffset)
		{
			builder.AddOffset(2, slideRailFollowConfigOffset.Value, 0);
		}

		// Token: 0x060336EF RID: 210671 RVA: 0x006EE1AE File Offset: 0x006EC3AE
		public static void AddRTPCParams(FlatBufferBuilder builder, Offset<ISlideRailRTPCParams> rTPCParamsOffset)
		{
			builder.AddOffset(3, rTPCParamsOffset.Value, 0);
		}

		// Token: 0x060336F0 RID: 210672 RVA: 0x006EE1BE File Offset: 0x006EC3BE
		public static Offset<ISlideRailStart> EndISlideRailStart(FlatBufferBuilder builder)
		{
			return new Offset<ISlideRailStart>(builder.EndTable());
		}

		// Token: 0x060336F1 RID: 210673 RVA: 0x006EE1CC File Offset: 0x006EC3CC
		public ISlideRailStartT UnPack()
		{
			ISlideRailStartT slideRailStartT = new ISlideRailStartT();
			this.UnPackTo(slideRailStartT);
			return slideRailStartT;
		}

		// Token: 0x060336F2 RID: 210674 RVA: 0x006EE1E8 File Offset: 0x006EC3E8
		public void UnPackTo(ISlideRailStartT _o)
		{
			_o.RailEntityId = this.RailEntityId;
			_o.SlidePerformDaPath = this.SlidePerformDaPath;
			_o.SlideRailFollowConfig = ((this.SlideRailFollowConfig != null) ? this.SlideRailFollowConfig.Value.UnPack() : null);
			_o.RTPCParams = ((this.RTPCParams != null) ? this.RTPCParams.Value.UnPack() : null);
		}

		// Token: 0x060336F3 RID: 210675 RVA: 0x006EE26C File Offset: 0x006EC46C
		public static Offset<ISlideRailStart> Pack(FlatBufferBuilder builder, ISlideRailStartT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISlideRailStart>);
			}
			StringOffset slidePerformDaPathOffset = (_o.SlidePerformDaPath == null) ? default(StringOffset) : builder.CreateString(_o.SlidePerformDaPath);
			Offset<ISlideRailFollowConfig> slideRailFollowConfigOffset = (_o.SlideRailFollowConfig == null) ? default(Offset<ISlideRailFollowConfig>) : ISlideRailFollowConfig.Pack(builder, _o.SlideRailFollowConfig);
			Offset<ISlideRailRTPCParams> rtpcparamsOffset = (_o.RTPCParams == null) ? default(Offset<ISlideRailRTPCParams>) : ISlideRailRTPCParams.Pack(builder, _o.RTPCParams);
			return ISlideRailStart.CreateISlideRailStart(builder, _o.RailEntityId, slidePerformDaPathOffset, slideRailFollowConfigOffset, rtpcparamsOffset);
		}

		// Token: 0x04011BF0 RID: 72688
		private Table __p;
	}
}
