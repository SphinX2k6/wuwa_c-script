using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053E0 RID: 21472
	public struct IIconNearByTrackingConfig : IFlatbufferObject
	{
		// Token: 0x17009E07 RID: 40455
		// (get) Token: 0x06023407 RID: 144391 RVA: 0x004E1BA2 File Offset: 0x004DFDA2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023408 RID: 144392 RVA: 0x004E1BAF File Offset: 0x004DFDAF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023409 RID: 144393 RVA: 0x004E1BB8 File Offset: 0x004DFDB8
		public static IIconNearByTrackingConfig GetRootAsIIconNearByTrackingConfig(ByteBuffer _bb)
		{
			return IIconNearByTrackingConfig.GetRootAsIIconNearByTrackingConfig(_bb, default(IIconNearByTrackingConfig));
		}

		// Token: 0x0602340A RID: 144394 RVA: 0x004E1BD4 File Offset: 0x004DFDD4
		public static IIconNearByTrackingConfig GetRootAsIIconNearByTrackingConfig(ByteBuffer _bb, IIconNearByTrackingConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602340B RID: 144395 RVA: 0x004E1BF1 File Offset: 0x004DFDF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602340C RID: 144396 RVA: 0x004E1C00 File Offset: 0x004DFE00
		public IIconNearByTrackingConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009E08 RID: 40456
		// (get) Token: 0x0602340D RID: 144397 RVA: 0x004E1C10 File Offset: 0x004DFE10
		public int ShowRange
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

		// Token: 0x17009E09 RID: 40457
		// (get) Token: 0x0602340E RID: 144398 RVA: 0x004E1C4C File Offset: 0x004DFE4C
		public int HideRange
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

		// Token: 0x17009E0A RID: 40458
		// (get) Token: 0x0602340F RID: 144399 RVA: 0x004E1C88 File Offset: 0x004DFE88
		public ENearbyTrackingTexture TexturePath
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return ENearbyTrackingTexture.BigTeleporter;
				}
				return (ENearbyTrackingTexture)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009E0B RID: 40459
		// (get) Token: 0x06023410 RID: 144400 RVA: 0x004E1CC4 File Offset: 0x004DFEC4
		public IVectorInfo? UiOffset
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009E0C RID: 40460
		// (get) Token: 0x06023411 RID: 144401 RVA: 0x004E1D24 File Offset: 0x004DFF24
		public float Duration
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009E0D RID: 40461
		// (get) Token: 0x06023412 RID: 144402 RVA: 0x004E1D68 File Offset: 0x004DFF68
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

		// Token: 0x06023413 RID: 144403 RVA: 0x004E1DA5 File Offset: 0x004DFFA5
		public static Offset<IIconNearByTrackingConfig> CreateIIconNearByTrackingConfig(FlatBufferBuilder builder, int ShowRange = 0, int HideRange = 0, ENearbyTrackingTexture TexturePath = ENearbyTrackingTexture.BigTeleporter, Offset<IVectorInfo> UiOffsetOffset = default(Offset<IVectorInfo>), float Duration = 0f, byte NullMask = 0)
		{
			builder.StartTable(6);
			IIconNearByTrackingConfig.AddDuration(builder, Duration);
			IIconNearByTrackingConfig.AddUiOffset(builder, UiOffsetOffset);
			IIconNearByTrackingConfig.AddHideRange(builder, HideRange);
			IIconNearByTrackingConfig.AddShowRange(builder, ShowRange);
			IIconNearByTrackingConfig.AddNullMask(builder, NullMask);
			IIconNearByTrackingConfig.AddTexturePath(builder, TexturePath);
			return IIconNearByTrackingConfig.EndIIconNearByTrackingConfig(builder);
		}

		// Token: 0x06023414 RID: 144404 RVA: 0x004E1DE1 File Offset: 0x004DFFE1
		public static void StartIIconNearByTrackingConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06023415 RID: 144405 RVA: 0x004E1DEA File Offset: 0x004DFFEA
		public static void AddShowRange(FlatBufferBuilder builder, int showRange)
		{
			builder.AddInt(0, showRange, 0);
		}

		// Token: 0x06023416 RID: 144406 RVA: 0x004E1DF5 File Offset: 0x004DFFF5
		public static void AddHideRange(FlatBufferBuilder builder, int hideRange)
		{
			builder.AddInt(1, hideRange, 0);
		}

		// Token: 0x06023417 RID: 144407 RVA: 0x004E1E00 File Offset: 0x004E0000
		public static void AddTexturePath(FlatBufferBuilder builder, ENearbyTrackingTexture texturePath)
		{
			builder.AddByte(2, (byte)texturePath, 0);
		}

		// Token: 0x06023418 RID: 144408 RVA: 0x004E1E0B File Offset: 0x004E000B
		public static void AddUiOffset(FlatBufferBuilder builder, Offset<IVectorInfo> uiOffsetOffset)
		{
			builder.AddOffset(3, uiOffsetOffset.Value, 0);
		}

		// Token: 0x06023419 RID: 144409 RVA: 0x004E1E1B File Offset: 0x004E001B
		public static void AddDuration(FlatBufferBuilder builder, float duration)
		{
			builder.AddFloat(4, duration, 0.0);
		}

		// Token: 0x0602341A RID: 144410 RVA: 0x004E1E2E File Offset: 0x004E002E
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0602341B RID: 144411 RVA: 0x004E1E39 File Offset: 0x004E0039
		public static Offset<IIconNearByTrackingConfig> EndIIconNearByTrackingConfig(FlatBufferBuilder builder)
		{
			return new Offset<IIconNearByTrackingConfig>(builder.EndTable());
		}

		// Token: 0x0602341C RID: 144412 RVA: 0x004E1E48 File Offset: 0x004E0048
		public IIconNearByTrackingConfigT UnPack()
		{
			IIconNearByTrackingConfigT iconNearByTrackingConfigT = new IIconNearByTrackingConfigT();
			this.UnPackTo(iconNearByTrackingConfigT);
			return iconNearByTrackingConfigT;
		}

		// Token: 0x0602341D RID: 144413 RVA: 0x004E1E64 File Offset: 0x004E0064
		public void UnPackTo(IIconNearByTrackingConfigT _o)
		{
			_o.ShowRange = this.ShowRange;
			_o.HideRange = this.HideRange;
			_o.TexturePath = this.TexturePath;
			_o.UiOffset = ((this.UiOffset != null) ? this.UiOffset.Value.UnPack() : null);
			_o.Duration = this.Duration;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602341E RID: 144414 RVA: 0x004E1EDC File Offset: 0x004E00DC
		public static Offset<IIconNearByTrackingConfig> Pack(FlatBufferBuilder builder, IIconNearByTrackingConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IIconNearByTrackingConfig>);
			}
			Offset<IVectorInfo> uiOffsetOffset = (_o.UiOffset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.UiOffset);
			return IIconNearByTrackingConfig.CreateIIconNearByTrackingConfig(builder, _o.ShowRange, _o.HideRange, _o.TexturePath, uiOffsetOffset, _o.Duration, _o.NullMask);
		}

		// Token: 0x0400E61F RID: 58911
		private Table __p;
	}
}
