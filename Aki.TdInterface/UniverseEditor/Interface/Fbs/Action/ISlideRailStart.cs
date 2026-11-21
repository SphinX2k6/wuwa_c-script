using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007920 RID: 31008
	public struct ISlideRailStart : IFlatbufferObject
	{
		// Token: 0x1700E36A RID: 58218
		// (get) Token: 0x06036988 RID: 223624 RVA: 0x0074E7A0 File Offset: 0x0074C9A0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036989 RID: 223625 RVA: 0x0074E7AD File Offset: 0x0074C9AD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603698A RID: 223626 RVA: 0x0074E7B4 File Offset: 0x0074C9B4
		public static ISlideRailStart GetRootAsISlideRailStart(ByteBuffer _bb)
		{
			return ISlideRailStart.GetRootAsISlideRailStart(_bb, default(ISlideRailStart));
		}

		// Token: 0x0603698B RID: 223627 RVA: 0x0074E7D0 File Offset: 0x0074C9D0
		public static ISlideRailStart GetRootAsISlideRailStart(ByteBuffer _bb, ISlideRailStart obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603698C RID: 223628 RVA: 0x0074E7ED File Offset: 0x0074C9ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603698D RID: 223629 RVA: 0x0074E7FC File Offset: 0x0074C9FC
		public ISlideRailStart __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E36B RID: 58219
		// (get) Token: 0x0603698E RID: 223630 RVA: 0x0074E80C File Offset: 0x0074CA0C
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

		// Token: 0x1700E36C RID: 58220
		// (get) Token: 0x0603698F RID: 223631 RVA: 0x0074E848 File Offset: 0x0074CA48
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

		// Token: 0x06036990 RID: 223632 RVA: 0x0074E87F File Offset: 0x0074CA7F
		public Span<byte> GetSlidePerformDaPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06036991 RID: 223633 RVA: 0x0074E88E File Offset: 0x0074CA8E
		public byte[] GetSlidePerformDaPathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700E36D RID: 58221
		// (get) Token: 0x06036992 RID: 223634 RVA: 0x0074E89C File Offset: 0x0074CA9C
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

		// Token: 0x1700E36E RID: 58222
		// (get) Token: 0x06036993 RID: 223635 RVA: 0x0074E8FC File Offset: 0x0074CAFC
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

		// Token: 0x06036994 RID: 223636 RVA: 0x0074E95A File Offset: 0x0074CB5A
		public static Offset<ISlideRailStart> CreateISlideRailStart(FlatBufferBuilder builder, int RailEntityId = 0, StringOffset SlidePerformDaPathOffset = default(StringOffset), Offset<ISlideRailFollowConfig> SlideRailFollowConfigOffset = default(Offset<ISlideRailFollowConfig>), Offset<ISlideRailRTPCParams> RTPCParamsOffset = default(Offset<ISlideRailRTPCParams>))
		{
			builder.StartTable(4);
			ISlideRailStart.AddRTPCParams(builder, RTPCParamsOffset);
			ISlideRailStart.AddSlideRailFollowConfig(builder, SlideRailFollowConfigOffset);
			ISlideRailStart.AddSlidePerformDaPath(builder, SlidePerformDaPathOffset);
			ISlideRailStart.AddRailEntityId(builder, RailEntityId);
			return ISlideRailStart.EndISlideRailStart(builder);
		}

		// Token: 0x06036995 RID: 223637 RVA: 0x0074E986 File Offset: 0x0074CB86
		public static void StartISlideRailStart(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06036996 RID: 223638 RVA: 0x0074E98F File Offset: 0x0074CB8F
		public static void AddRailEntityId(FlatBufferBuilder builder, int railEntityId)
		{
			builder.AddInt(0, railEntityId, 0);
		}

		// Token: 0x06036997 RID: 223639 RVA: 0x0074E99A File Offset: 0x0074CB9A
		public static void AddSlidePerformDaPath(FlatBufferBuilder builder, StringOffset slidePerformDaPathOffset)
		{
			builder.AddOffset(1, slidePerformDaPathOffset.Value, 0);
		}

		// Token: 0x06036998 RID: 223640 RVA: 0x0074E9AA File Offset: 0x0074CBAA
		public static void AddSlideRailFollowConfig(FlatBufferBuilder builder, Offset<ISlideRailFollowConfig> slideRailFollowConfigOffset)
		{
			builder.AddOffset(2, slideRailFollowConfigOffset.Value, 0);
		}

		// Token: 0x06036999 RID: 223641 RVA: 0x0074E9BA File Offset: 0x0074CBBA
		public static void AddRTPCParams(FlatBufferBuilder builder, Offset<ISlideRailRTPCParams> rTPCParamsOffset)
		{
			builder.AddOffset(3, rTPCParamsOffset.Value, 0);
		}

		// Token: 0x0603699A RID: 223642 RVA: 0x0074E9CA File Offset: 0x0074CBCA
		public static Offset<ISlideRailStart> EndISlideRailStart(FlatBufferBuilder builder)
		{
			return new Offset<ISlideRailStart>(builder.EndTable());
		}

		// Token: 0x0603699B RID: 223643 RVA: 0x0074E9D8 File Offset: 0x0074CBD8
		public ISlideRailStartT UnPack()
		{
			ISlideRailStartT slideRailStartT = new ISlideRailStartT();
			this.UnPackTo(slideRailStartT);
			return slideRailStartT;
		}

		// Token: 0x0603699C RID: 223644 RVA: 0x0074E9F4 File Offset: 0x0074CBF4
		public void UnPackTo(ISlideRailStartT _o)
		{
			_o.RailEntityId = this.RailEntityId;
			_o.SlidePerformDaPath = this.SlidePerformDaPath;
			_o.SlideRailFollowConfig = ((this.SlideRailFollowConfig != null) ? this.SlideRailFollowConfig.Value.UnPack() : null);
			_o.RTPCParams = ((this.RTPCParams != null) ? this.RTPCParams.Value.UnPack() : null);
		}

		// Token: 0x0603699D RID: 223645 RVA: 0x0074EA78 File Offset: 0x0074CC78
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

		// Token: 0x04012BDF RID: 76767
		private Table __p;
	}
}
