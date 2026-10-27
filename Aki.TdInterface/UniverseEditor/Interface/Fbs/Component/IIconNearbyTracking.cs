using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053DD RID: 21469
	public struct IIconNearbyTracking : IFlatbufferObject
	{
		// Token: 0x17009DF8 RID: 40440
		// (get) Token: 0x060233DD RID: 144349 RVA: 0x004E1639 File Offset: 0x004DF839
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060233DE RID: 144350 RVA: 0x004E1646 File Offset: 0x004DF846
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060233DF RID: 144351 RVA: 0x004E1650 File Offset: 0x004DF850
		public static IIconNearbyTracking GetRootAsIIconNearbyTracking(ByteBuffer _bb)
		{
			return IIconNearbyTracking.GetRootAsIIconNearbyTracking(_bb, default(IIconNearbyTracking));
		}

		// Token: 0x060233E0 RID: 144352 RVA: 0x004E166C File Offset: 0x004DF86C
		public static IIconNearbyTracking GetRootAsIIconNearbyTracking(ByteBuffer _bb, IIconNearbyTracking obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060233E1 RID: 144353 RVA: 0x004E1689 File Offset: 0x004DF889
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060233E2 RID: 144354 RVA: 0x004E1698 File Offset: 0x004DF898
		public IIconNearbyTracking __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009DF9 RID: 40441
		// (get) Token: 0x060233E3 RID: 144355 RVA: 0x004E16A8 File Offset: 0x004DF8A8
		public ENearbyTrackingType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ENearbyTrackingType.Icon;
				}
				return (ENearbyTrackingType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009DFA RID: 40442
		// (get) Token: 0x060233E4 RID: 144356 RVA: 0x004E16E4 File Offset: 0x004DF8E4
		public int ShowRange
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

		// Token: 0x17009DFB RID: 40443
		// (get) Token: 0x060233E5 RID: 144357 RVA: 0x004E1720 File Offset: 0x004DF920
		public int HideRange
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

		// Token: 0x17009DFC RID: 40444
		// (get) Token: 0x060233E6 RID: 144358 RVA: 0x004E175C File Offset: 0x004DF95C
		public ENearbyTrackingTexture TexturePath
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return ENearbyTrackingTexture.BigTeleporter;
				}
				return (ENearbyTrackingTexture)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009DFD RID: 40445
		// (get) Token: 0x060233E7 RID: 144359 RVA: 0x004E179C File Offset: 0x004DF99C
		public IVectorInfo? UiOffset
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009DFE RID: 40446
		// (get) Token: 0x060233E8 RID: 144360 RVA: 0x004E17FC File Offset: 0x004DF9FC
		public float Duration
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009DFF RID: 40447
		// (get) Token: 0x060233E9 RID: 144361 RVA: 0x004E1840 File Offset: 0x004DFA40
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060233EA RID: 144362 RVA: 0x004E1880 File Offset: 0x004DFA80
		public static Offset<IIconNearbyTracking> CreateIIconNearbyTracking(FlatBufferBuilder builder, ENearbyTrackingType Type = ENearbyTrackingType.Icon, int ShowRange = 0, int HideRange = 0, ENearbyTrackingTexture TexturePath = ENearbyTrackingTexture.BigTeleporter, Offset<IVectorInfo> UiOffsetOffset = default(Offset<IVectorInfo>), float Duration = 0f, byte NullMask = 0)
		{
			builder.StartTable(7);
			IIconNearbyTracking.AddDuration(builder, Duration);
			IIconNearbyTracking.AddUiOffset(builder, UiOffsetOffset);
			IIconNearbyTracking.AddHideRange(builder, HideRange);
			IIconNearbyTracking.AddShowRange(builder, ShowRange);
			IIconNearbyTracking.AddNullMask(builder, NullMask);
			IIconNearbyTracking.AddTexturePath(builder, TexturePath);
			IIconNearbyTracking.AddType(builder, Type);
			return IIconNearbyTracking.EndIIconNearbyTracking(builder);
		}

		// Token: 0x060233EB RID: 144363 RVA: 0x004E18CF File Offset: 0x004DFACF
		public static void StartIIconNearbyTracking(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x060233EC RID: 144364 RVA: 0x004E18D8 File Offset: 0x004DFAD8
		public static void AddType(FlatBufferBuilder builder, ENearbyTrackingType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060233ED RID: 144365 RVA: 0x004E18E3 File Offset: 0x004DFAE3
		public static void AddShowRange(FlatBufferBuilder builder, int showRange)
		{
			builder.AddInt(1, showRange, 0);
		}

		// Token: 0x060233EE RID: 144366 RVA: 0x004E18EE File Offset: 0x004DFAEE
		public static void AddHideRange(FlatBufferBuilder builder, int hideRange)
		{
			builder.AddInt(2, hideRange, 0);
		}

		// Token: 0x060233EF RID: 144367 RVA: 0x004E18F9 File Offset: 0x004DFAF9
		public static void AddTexturePath(FlatBufferBuilder builder, ENearbyTrackingTexture texturePath)
		{
			builder.AddByte(3, (byte)texturePath, 0);
		}

		// Token: 0x060233F0 RID: 144368 RVA: 0x004E1904 File Offset: 0x004DFB04
		public static void AddUiOffset(FlatBufferBuilder builder, Offset<IVectorInfo> uiOffsetOffset)
		{
			builder.AddOffset(4, uiOffsetOffset.Value, 0);
		}

		// Token: 0x060233F1 RID: 144369 RVA: 0x004E1914 File Offset: 0x004DFB14
		public static void AddDuration(FlatBufferBuilder builder, float duration)
		{
			builder.AddFloat(5, duration, 0.0);
		}

		// Token: 0x060233F2 RID: 144370 RVA: 0x004E1927 File Offset: 0x004DFB27
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x060233F3 RID: 144371 RVA: 0x004E1932 File Offset: 0x004DFB32
		public static Offset<IIconNearbyTracking> EndIIconNearbyTracking(FlatBufferBuilder builder)
		{
			return new Offset<IIconNearbyTracking>(builder.EndTable());
		}

		// Token: 0x060233F4 RID: 144372 RVA: 0x004E1940 File Offset: 0x004DFB40
		public IIconNearbyTrackingT UnPack()
		{
			IIconNearbyTrackingT iconNearbyTrackingT = new IIconNearbyTrackingT();
			this.UnPackTo(iconNearbyTrackingT);
			return iconNearbyTrackingT;
		}

		// Token: 0x060233F5 RID: 144373 RVA: 0x004E195C File Offset: 0x004DFB5C
		public void UnPackTo(IIconNearbyTrackingT _o)
		{
			_o.Type = this.Type;
			_o.ShowRange = this.ShowRange;
			_o.HideRange = this.HideRange;
			_o.TexturePath = this.TexturePath;
			_o.UiOffset = ((this.UiOffset != null) ? this.UiOffset.Value.UnPack() : null);
			_o.Duration = this.Duration;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060233F6 RID: 144374 RVA: 0x004E19E0 File Offset: 0x004DFBE0
		public static Offset<IIconNearbyTracking> Pack(FlatBufferBuilder builder, IIconNearbyTrackingT _o)
		{
			if (_o == null)
			{
				return default(Offset<IIconNearbyTracking>);
			}
			Offset<IVectorInfo> uiOffsetOffset = (_o.UiOffset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.UiOffset);
			return IIconNearbyTracking.CreateIIconNearbyTracking(builder, _o.Type, _o.ShowRange, _o.HideRange, _o.TexturePath, uiOffsetOffset, _o.Duration, _o.NullMask);
		}

		// Token: 0x0400E617 RID: 58903
		private Table __p;
	}
}
