using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200618A RID: 24970
	public struct IWellStreamingRenderPointConfig : IFlatbufferObject
	{
		// Token: 0x1700BA31 RID: 47665
		// (get) Token: 0x0602A6DB RID: 173787 RVA: 0x005C9CCF File Offset: 0x005C7ECF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A6DC RID: 173788 RVA: 0x005C9CDC File Offset: 0x005C7EDC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A6DD RID: 173789 RVA: 0x005C9CE4 File Offset: 0x005C7EE4
		public static IWellStreamingRenderPointConfig GetRootAsIWellStreamingRenderPointConfig(ByteBuffer _bb)
		{
			return IWellStreamingRenderPointConfig.GetRootAsIWellStreamingRenderPointConfig(_bb, default(IWellStreamingRenderPointConfig));
		}

		// Token: 0x0602A6DE RID: 173790 RVA: 0x005C9D00 File Offset: 0x005C7F00
		public static IWellStreamingRenderPointConfig GetRootAsIWellStreamingRenderPointConfig(ByteBuffer _bb, IWellStreamingRenderPointConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A6DF RID: 173791 RVA: 0x005C9D1D File Offset: 0x005C7F1D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A6E0 RID: 173792 RVA: 0x005C9D2C File Offset: 0x005C7F2C
		public IWellStreamingRenderPointConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BA32 RID: 47666
		// (get) Token: 0x0602A6E1 RID: 173793 RVA: 0x005C9D3C File Offset: 0x005C7F3C
		public IPortalRenderConfig? TargetConfig
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IPortalRenderConfig?(default(IPortalRenderConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700BA33 RID: 47667
		// (get) Token: 0x0602A6E2 RID: 173794 RVA: 0x005C9D9C File Offset: 0x005C7F9C
		public IRtSize? RtSize
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IRtSize?(default(IRtSize).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700BA34 RID: 47668
		// (get) Token: 0x0602A6E3 RID: 173795 RVA: 0x005C9DFC File Offset: 0x005C7FFC
		public bool IsRenderStreamingPointEntity
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700BA35 RID: 47669
		// (get) Token: 0x0602A6E4 RID: 173796 RVA: 0x005C9E3C File Offset: 0x005C803C
		public string RtRenderRefPosActorKey
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602A6E5 RID: 173797 RVA: 0x005C9E74 File Offset: 0x005C8074
		public Span<byte> GetRtRenderRefPosActorKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0602A6E6 RID: 173798 RVA: 0x005C9E84 File Offset: 0x005C8084
		public byte[] GetRtRenderRefPosActorKeyArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700BA36 RID: 47670
		// (get) Token: 0x0602A6E7 RID: 173799 RVA: 0x005C9E94 File Offset: 0x005C8094
		public string FallbackCubeMapTexturePath
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602A6E8 RID: 173800 RVA: 0x005C9ECC File Offset: 0x005C80CC
		public Span<byte> GetFallbackCubeMapTexturePathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0602A6E9 RID: 173801 RVA: 0x005C9EDC File Offset: 0x005C80DC
		public byte[] GetFallbackCubeMapTexturePathArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x1700BA37 RID: 47671
		// (get) Token: 0x0602A6EA RID: 173802 RVA: 0x005C9EEC File Offset: 0x005C80EC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602A6EB RID: 173803 RVA: 0x005C9F29 File Offset: 0x005C8129
		public static Offset<IWellStreamingRenderPointConfig> CreateIWellStreamingRenderPointConfig(FlatBufferBuilder builder, Offset<IPortalRenderConfig> TargetConfigOffset = default(Offset<IPortalRenderConfig>), Offset<IRtSize> RtSizeOffset = default(Offset<IRtSize>), bool IsRenderStreamingPointEntity = false, StringOffset RtRenderRefPosActorKeyOffset = default(StringOffset), StringOffset FallbackCubeMapTexturePathOffset = default(StringOffset), byte NullMask = 0)
		{
			builder.StartTable(6);
			IWellStreamingRenderPointConfig.AddFallbackCubeMapTexturePath(builder, FallbackCubeMapTexturePathOffset);
			IWellStreamingRenderPointConfig.AddRtRenderRefPosActorKey(builder, RtRenderRefPosActorKeyOffset);
			IWellStreamingRenderPointConfig.AddRtSize(builder, RtSizeOffset);
			IWellStreamingRenderPointConfig.AddTargetConfig(builder, TargetConfigOffset);
			IWellStreamingRenderPointConfig.AddNullMask(builder, NullMask);
			IWellStreamingRenderPointConfig.AddIsRenderStreamingPointEntity(builder, IsRenderStreamingPointEntity);
			return IWellStreamingRenderPointConfig.EndIWellStreamingRenderPointConfig(builder);
		}

		// Token: 0x0602A6EC RID: 173804 RVA: 0x005C9F65 File Offset: 0x005C8165
		public static void StartIWellStreamingRenderPointConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0602A6ED RID: 173805 RVA: 0x005C9F6E File Offset: 0x005C816E
		public static void AddTargetConfig(FlatBufferBuilder builder, Offset<IPortalRenderConfig> targetConfigOffset)
		{
			builder.AddOffset(0, targetConfigOffset.Value, 0);
		}

		// Token: 0x0602A6EE RID: 173806 RVA: 0x005C9F7E File Offset: 0x005C817E
		public static void AddRtSize(FlatBufferBuilder builder, Offset<IRtSize> rtSizeOffset)
		{
			builder.AddOffset(1, rtSizeOffset.Value, 0);
		}

		// Token: 0x0602A6EF RID: 173807 RVA: 0x005C9F8E File Offset: 0x005C818E
		public static void AddIsRenderStreamingPointEntity(FlatBufferBuilder builder, bool isRenderStreamingPointEntity)
		{
			builder.AddBool(2, isRenderStreamingPointEntity, false);
		}

		// Token: 0x0602A6F0 RID: 173808 RVA: 0x005C9F99 File Offset: 0x005C8199
		public static void AddRtRenderRefPosActorKey(FlatBufferBuilder builder, StringOffset rtRenderRefPosActorKeyOffset)
		{
			builder.AddOffset(3, rtRenderRefPosActorKeyOffset.Value, 0);
		}

		// Token: 0x0602A6F1 RID: 173809 RVA: 0x005C9FA9 File Offset: 0x005C81A9
		public static void AddFallbackCubeMapTexturePath(FlatBufferBuilder builder, StringOffset fallbackCubeMapTexturePathOffset)
		{
			builder.AddOffset(4, fallbackCubeMapTexturePathOffset.Value, 0);
		}

		// Token: 0x0602A6F2 RID: 173810 RVA: 0x005C9FB9 File Offset: 0x005C81B9
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0602A6F3 RID: 173811 RVA: 0x005C9FC4 File Offset: 0x005C81C4
		public static Offset<IWellStreamingRenderPointConfig> EndIWellStreamingRenderPointConfig(FlatBufferBuilder builder)
		{
			return new Offset<IWellStreamingRenderPointConfig>(builder.EndTable());
		}

		// Token: 0x0602A6F4 RID: 173812 RVA: 0x005C9FD4 File Offset: 0x005C81D4
		public IWellStreamingRenderPointConfigT UnPack()
		{
			IWellStreamingRenderPointConfigT wellStreamingRenderPointConfigT = new IWellStreamingRenderPointConfigT();
			this.UnPackTo(wellStreamingRenderPointConfigT);
			return wellStreamingRenderPointConfigT;
		}

		// Token: 0x0602A6F5 RID: 173813 RVA: 0x005C9FF0 File Offset: 0x005C81F0
		public void UnPackTo(IWellStreamingRenderPointConfigT _o)
		{
			_o.TargetConfig = ((this.TargetConfig != null) ? this.TargetConfig.Value.UnPack() : null);
			_o.RtSize = ((this.RtSize != null) ? this.RtSize.Value.UnPack() : null);
			_o.IsRenderStreamingPointEntity = this.IsRenderStreamingPointEntity;
			_o.RtRenderRefPosActorKey = this.RtRenderRefPosActorKey;
			_o.FallbackCubeMapTexturePath = this.FallbackCubeMapTexturePath;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602A6F6 RID: 173814 RVA: 0x005CA08C File Offset: 0x005C828C
		public static Offset<IWellStreamingRenderPointConfig> Pack(FlatBufferBuilder builder, IWellStreamingRenderPointConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWellStreamingRenderPointConfig>);
			}
			Offset<IPortalRenderConfig> targetConfigOffset = (_o.TargetConfig == null) ? default(Offset<IPortalRenderConfig>) : IPortalRenderConfig.Pack(builder, _o.TargetConfig);
			Offset<IRtSize> rtSizeOffset = (_o.RtSize == null) ? default(Offset<IRtSize>) : IRtSize.Pack(builder, _o.RtSize);
			StringOffset rtRenderRefPosActorKeyOffset = (_o.RtRenderRefPosActorKey == null) ? default(StringOffset) : builder.CreateString(_o.RtRenderRefPosActorKey);
			StringOffset fallbackCubeMapTexturePathOffset = (_o.FallbackCubeMapTexturePath == null) ? default(StringOffset) : builder.CreateString(_o.FallbackCubeMapTexturePath);
			return IWellStreamingRenderPointConfig.CreateIWellStreamingRenderPointConfig(builder, targetConfigOffset, rtSizeOffset, _o.IsRenderStreamingPointEntity, rtRenderRefPosActorKeyOffset, fallbackCubeMapTexturePathOffset, _o.NullMask);
		}

		// Token: 0x0400FFCF RID: 65487
		private Table __p;
	}
}
