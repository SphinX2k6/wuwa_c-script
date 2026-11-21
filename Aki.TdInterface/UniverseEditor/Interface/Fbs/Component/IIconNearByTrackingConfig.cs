using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005966 RID: 22886
	public struct IIconNearByTrackingConfig : IFlatbufferObject
	{
		// Token: 0x1700A641 RID: 42561
		// (get) Token: 0x060254BF RID: 152767 RVA: 0x0051EBCE File Offset: 0x0051CDCE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060254C0 RID: 152768 RVA: 0x0051EBDB File Offset: 0x0051CDDB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060254C1 RID: 152769 RVA: 0x0051EBE4 File Offset: 0x0051CDE4
		public static IIconNearByTrackingConfig GetRootAsIIconNearByTrackingConfig(ByteBuffer _bb)
		{
			return IIconNearByTrackingConfig.GetRootAsIIconNearByTrackingConfig(_bb, default(IIconNearByTrackingConfig));
		}

		// Token: 0x060254C2 RID: 152770 RVA: 0x0051EC00 File Offset: 0x0051CE00
		public static IIconNearByTrackingConfig GetRootAsIIconNearByTrackingConfig(ByteBuffer _bb, IIconNearByTrackingConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060254C3 RID: 152771 RVA: 0x0051EC1D File Offset: 0x0051CE1D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060254C4 RID: 152772 RVA: 0x0051EC2C File Offset: 0x0051CE2C
		public IIconNearByTrackingConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A642 RID: 42562
		// (get) Token: 0x060254C5 RID: 152773 RVA: 0x0051EC3C File Offset: 0x0051CE3C
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

		// Token: 0x1700A643 RID: 42563
		// (get) Token: 0x060254C6 RID: 152774 RVA: 0x0051EC78 File Offset: 0x0051CE78
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

		// Token: 0x1700A644 RID: 42564
		// (get) Token: 0x060254C7 RID: 152775 RVA: 0x0051ECB4 File Offset: 0x0051CEB4
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

		// Token: 0x1700A645 RID: 42565
		// (get) Token: 0x060254C8 RID: 152776 RVA: 0x0051ECF0 File Offset: 0x0051CEF0
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

		// Token: 0x1700A646 RID: 42566
		// (get) Token: 0x060254C9 RID: 152777 RVA: 0x0051ED50 File Offset: 0x0051CF50
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

		// Token: 0x1700A647 RID: 42567
		// (get) Token: 0x060254CA RID: 152778 RVA: 0x0051ED94 File Offset: 0x0051CF94
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

		// Token: 0x060254CB RID: 152779 RVA: 0x0051EDD1 File Offset: 0x0051CFD1
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

		// Token: 0x060254CC RID: 152780 RVA: 0x0051EE0D File Offset: 0x0051D00D
		public static void StartIIconNearByTrackingConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x060254CD RID: 152781 RVA: 0x0051EE16 File Offset: 0x0051D016
		public static void AddShowRange(FlatBufferBuilder builder, int showRange)
		{
			builder.AddInt(0, showRange, 0);
		}

		// Token: 0x060254CE RID: 152782 RVA: 0x0051EE21 File Offset: 0x0051D021
		public static void AddHideRange(FlatBufferBuilder builder, int hideRange)
		{
			builder.AddInt(1, hideRange, 0);
		}

		// Token: 0x060254CF RID: 152783 RVA: 0x0051EE2C File Offset: 0x0051D02C
		public static void AddTexturePath(FlatBufferBuilder builder, ENearbyTrackingTexture texturePath)
		{
			builder.AddByte(2, (byte)texturePath, 0);
		}

		// Token: 0x060254D0 RID: 152784 RVA: 0x0051EE37 File Offset: 0x0051D037
		public static void AddUiOffset(FlatBufferBuilder builder, Offset<IVectorInfo> uiOffsetOffset)
		{
			builder.AddOffset(3, uiOffsetOffset.Value, 0);
		}

		// Token: 0x060254D1 RID: 152785 RVA: 0x0051EE47 File Offset: 0x0051D047
		public static void AddDuration(FlatBufferBuilder builder, float duration)
		{
			builder.AddFloat(4, duration, 0.0);
		}

		// Token: 0x060254D2 RID: 152786 RVA: 0x0051EE5A File Offset: 0x0051D05A
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x060254D3 RID: 152787 RVA: 0x0051EE65 File Offset: 0x0051D065
		public static Offset<IIconNearByTrackingConfig> EndIIconNearByTrackingConfig(FlatBufferBuilder builder)
		{
			return new Offset<IIconNearByTrackingConfig>(builder.EndTable());
		}

		// Token: 0x060254D4 RID: 152788 RVA: 0x0051EE74 File Offset: 0x0051D074
		public IIconNearByTrackingConfigT UnPack()
		{
			IIconNearByTrackingConfigT iconNearByTrackingConfigT = new IIconNearByTrackingConfigT();
			this.UnPackTo(iconNearByTrackingConfigT);
			return iconNearByTrackingConfigT;
		}

		// Token: 0x060254D5 RID: 152789 RVA: 0x0051EE90 File Offset: 0x0051D090
		public void UnPackTo(IIconNearByTrackingConfigT _o)
		{
			_o.ShowRange = this.ShowRange;
			_o.HideRange = this.HideRange;
			_o.TexturePath = this.TexturePath;
			_o.UiOffset = ((this.UiOffset != null) ? this.UiOffset.Value.UnPack() : null);
			_o.Duration = this.Duration;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060254D6 RID: 152790 RVA: 0x0051EF08 File Offset: 0x0051D108
		public static Offset<IIconNearByTrackingConfig> Pack(FlatBufferBuilder builder, IIconNearByTrackingConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IIconNearByTrackingConfig>);
			}
			Offset<IVectorInfo> uiOffsetOffset = (_o.UiOffset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.UiOffset);
			return IIconNearByTrackingConfig.CreateIIconNearByTrackingConfig(builder, _o.ShowRange, _o.HideRange, _o.TexturePath, uiOffsetOffset, _o.Duration, _o.NullMask);
		}

		// Token: 0x0400F250 RID: 62032
		private Table __p;
	}
}
