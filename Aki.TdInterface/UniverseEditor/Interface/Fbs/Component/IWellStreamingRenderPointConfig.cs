using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B74 RID: 23412
	public struct IWellStreamingRenderPointConfig : IFlatbufferObject
	{
		// Token: 0x1700B0E9 RID: 45289
		// (get) Token: 0x06028117 RID: 164119 RVA: 0x0058223F File Offset: 0x0058043F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028118 RID: 164120 RVA: 0x0058224C File Offset: 0x0058044C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028119 RID: 164121 RVA: 0x00582254 File Offset: 0x00580454
		public static IWellStreamingRenderPointConfig GetRootAsIWellStreamingRenderPointConfig(ByteBuffer _bb)
		{
			return IWellStreamingRenderPointConfig.GetRootAsIWellStreamingRenderPointConfig(_bb, default(IWellStreamingRenderPointConfig));
		}

		// Token: 0x0602811A RID: 164122 RVA: 0x00582270 File Offset: 0x00580470
		public static IWellStreamingRenderPointConfig GetRootAsIWellStreamingRenderPointConfig(ByteBuffer _bb, IWellStreamingRenderPointConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602811B RID: 164123 RVA: 0x0058228D File Offset: 0x0058048D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602811C RID: 164124 RVA: 0x0058229C File Offset: 0x0058049C
		public IWellStreamingRenderPointConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B0EA RID: 45290
		// (get) Token: 0x0602811D RID: 164125 RVA: 0x005822AC File Offset: 0x005804AC
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

		// Token: 0x1700B0EB RID: 45291
		// (get) Token: 0x0602811E RID: 164126 RVA: 0x0058230C File Offset: 0x0058050C
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

		// Token: 0x1700B0EC RID: 45292
		// (get) Token: 0x0602811F RID: 164127 RVA: 0x0058236C File Offset: 0x0058056C
		public bool IsRenderStreamingPointEntity
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B0ED RID: 45293
		// (get) Token: 0x06028120 RID: 164128 RVA: 0x005823AC File Offset: 0x005805AC
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

		// Token: 0x06028121 RID: 164129 RVA: 0x005823E4 File Offset: 0x005805E4
		public Span<byte> GetRtRenderRefPosActorKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06028122 RID: 164130 RVA: 0x005823F4 File Offset: 0x005805F4
		public byte[] GetRtRenderRefPosActorKeyArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700B0EE RID: 45294
		// (get) Token: 0x06028123 RID: 164131 RVA: 0x00582404 File Offset: 0x00580604
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

		// Token: 0x06028124 RID: 164132 RVA: 0x0058243C File Offset: 0x0058063C
		public Span<byte> GetFallbackCubeMapTexturePathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06028125 RID: 164133 RVA: 0x0058244C File Offset: 0x0058064C
		public byte[] GetFallbackCubeMapTexturePathArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x1700B0EF RID: 45295
		// (get) Token: 0x06028126 RID: 164134 RVA: 0x0058245C File Offset: 0x0058065C
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

		// Token: 0x06028127 RID: 164135 RVA: 0x00582499 File Offset: 0x00580699
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

		// Token: 0x06028128 RID: 164136 RVA: 0x005824D5 File Offset: 0x005806D5
		public static void StartIWellStreamingRenderPointConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06028129 RID: 164137 RVA: 0x005824DE File Offset: 0x005806DE
		public static void AddTargetConfig(FlatBufferBuilder builder, Offset<IPortalRenderConfig> targetConfigOffset)
		{
			builder.AddOffset(0, targetConfigOffset.Value, 0);
		}

		// Token: 0x0602812A RID: 164138 RVA: 0x005824EE File Offset: 0x005806EE
		public static void AddRtSize(FlatBufferBuilder builder, Offset<IRtSize> rtSizeOffset)
		{
			builder.AddOffset(1, rtSizeOffset.Value, 0);
		}

		// Token: 0x0602812B RID: 164139 RVA: 0x005824FE File Offset: 0x005806FE
		public static void AddIsRenderStreamingPointEntity(FlatBufferBuilder builder, bool isRenderStreamingPointEntity)
		{
			builder.AddBool(2, isRenderStreamingPointEntity, false);
		}

		// Token: 0x0602812C RID: 164140 RVA: 0x00582509 File Offset: 0x00580709
		public static void AddRtRenderRefPosActorKey(FlatBufferBuilder builder, StringOffset rtRenderRefPosActorKeyOffset)
		{
			builder.AddOffset(3, rtRenderRefPosActorKeyOffset.Value, 0);
		}

		// Token: 0x0602812D RID: 164141 RVA: 0x00582519 File Offset: 0x00580719
		public static void AddFallbackCubeMapTexturePath(FlatBufferBuilder builder, StringOffset fallbackCubeMapTexturePathOffset)
		{
			builder.AddOffset(4, fallbackCubeMapTexturePathOffset.Value, 0);
		}

		// Token: 0x0602812E RID: 164142 RVA: 0x00582529 File Offset: 0x00580729
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0602812F RID: 164143 RVA: 0x00582534 File Offset: 0x00580734
		public static Offset<IWellStreamingRenderPointConfig> EndIWellStreamingRenderPointConfig(FlatBufferBuilder builder)
		{
			return new Offset<IWellStreamingRenderPointConfig>(builder.EndTable());
		}

		// Token: 0x06028130 RID: 164144 RVA: 0x00582544 File Offset: 0x00580744
		public IWellStreamingRenderPointConfigT UnPack()
		{
			IWellStreamingRenderPointConfigT wellStreamingRenderPointConfigT = new IWellStreamingRenderPointConfigT();
			this.UnPackTo(wellStreamingRenderPointConfigT);
			return wellStreamingRenderPointConfigT;
		}

		// Token: 0x06028131 RID: 164145 RVA: 0x00582560 File Offset: 0x00580760
		public void UnPackTo(IWellStreamingRenderPointConfigT _o)
		{
			_o.TargetConfig = ((this.TargetConfig != null) ? this.TargetConfig.Value.UnPack() : null);
			_o.RtSize = ((this.RtSize != null) ? this.RtSize.Value.UnPack() : null);
			_o.IsRenderStreamingPointEntity = this.IsRenderStreamingPointEntity;
			_o.RtRenderRefPosActorKey = this.RtRenderRefPosActorKey;
			_o.FallbackCubeMapTexturePath = this.FallbackCubeMapTexturePath;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06028132 RID: 164146 RVA: 0x005825FC File Offset: 0x005807FC
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

		// Token: 0x0400F2C9 RID: 62153
		private Table __p;
	}
}
