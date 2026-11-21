using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005963 RID: 22883
	public struct IIconNearbyTracking : IFlatbufferObject
	{
		// Token: 0x1700A632 RID: 42546
		// (get) Token: 0x06025495 RID: 152725 RVA: 0x0051E665 File Offset: 0x0051C865
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025496 RID: 152726 RVA: 0x0051E672 File Offset: 0x0051C872
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025497 RID: 152727 RVA: 0x0051E67C File Offset: 0x0051C87C
		public static IIconNearbyTracking GetRootAsIIconNearbyTracking(ByteBuffer _bb)
		{
			return IIconNearbyTracking.GetRootAsIIconNearbyTracking(_bb, default(IIconNearbyTracking));
		}

		// Token: 0x06025498 RID: 152728 RVA: 0x0051E698 File Offset: 0x0051C898
		public static IIconNearbyTracking GetRootAsIIconNearbyTracking(ByteBuffer _bb, IIconNearbyTracking obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025499 RID: 152729 RVA: 0x0051E6B5 File Offset: 0x0051C8B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602549A RID: 152730 RVA: 0x0051E6C4 File Offset: 0x0051C8C4
		public IIconNearbyTracking __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A633 RID: 42547
		// (get) Token: 0x0602549B RID: 152731 RVA: 0x0051E6D4 File Offset: 0x0051C8D4
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

		// Token: 0x1700A634 RID: 42548
		// (get) Token: 0x0602549C RID: 152732 RVA: 0x0051E710 File Offset: 0x0051C910
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

		// Token: 0x1700A635 RID: 42549
		// (get) Token: 0x0602549D RID: 152733 RVA: 0x0051E74C File Offset: 0x0051C94C
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

		// Token: 0x1700A636 RID: 42550
		// (get) Token: 0x0602549E RID: 152734 RVA: 0x0051E788 File Offset: 0x0051C988
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

		// Token: 0x1700A637 RID: 42551
		// (get) Token: 0x0602549F RID: 152735 RVA: 0x0051E7C8 File Offset: 0x0051C9C8
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

		// Token: 0x1700A638 RID: 42552
		// (get) Token: 0x060254A0 RID: 152736 RVA: 0x0051E828 File Offset: 0x0051CA28
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

		// Token: 0x1700A639 RID: 42553
		// (get) Token: 0x060254A1 RID: 152737 RVA: 0x0051E86C File Offset: 0x0051CA6C
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

		// Token: 0x060254A2 RID: 152738 RVA: 0x0051E8AC File Offset: 0x0051CAAC
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

		// Token: 0x060254A3 RID: 152739 RVA: 0x0051E8FB File Offset: 0x0051CAFB
		public static void StartIIconNearbyTracking(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x060254A4 RID: 152740 RVA: 0x0051E904 File Offset: 0x0051CB04
		public static void AddType(FlatBufferBuilder builder, ENearbyTrackingType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060254A5 RID: 152741 RVA: 0x0051E90F File Offset: 0x0051CB0F
		public static void AddShowRange(FlatBufferBuilder builder, int showRange)
		{
			builder.AddInt(1, showRange, 0);
		}

		// Token: 0x060254A6 RID: 152742 RVA: 0x0051E91A File Offset: 0x0051CB1A
		public static void AddHideRange(FlatBufferBuilder builder, int hideRange)
		{
			builder.AddInt(2, hideRange, 0);
		}

		// Token: 0x060254A7 RID: 152743 RVA: 0x0051E925 File Offset: 0x0051CB25
		public static void AddTexturePath(FlatBufferBuilder builder, ENearbyTrackingTexture texturePath)
		{
			builder.AddByte(3, (byte)texturePath, 0);
		}

		// Token: 0x060254A8 RID: 152744 RVA: 0x0051E930 File Offset: 0x0051CB30
		public static void AddUiOffset(FlatBufferBuilder builder, Offset<IVectorInfo> uiOffsetOffset)
		{
			builder.AddOffset(4, uiOffsetOffset.Value, 0);
		}

		// Token: 0x060254A9 RID: 152745 RVA: 0x0051E940 File Offset: 0x0051CB40
		public static void AddDuration(FlatBufferBuilder builder, float duration)
		{
			builder.AddFloat(5, duration, 0.0);
		}

		// Token: 0x060254AA RID: 152746 RVA: 0x0051E953 File Offset: 0x0051CB53
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x060254AB RID: 152747 RVA: 0x0051E95E File Offset: 0x0051CB5E
		public static Offset<IIconNearbyTracking> EndIIconNearbyTracking(FlatBufferBuilder builder)
		{
			return new Offset<IIconNearbyTracking>(builder.EndTable());
		}

		// Token: 0x060254AC RID: 152748 RVA: 0x0051E96C File Offset: 0x0051CB6C
		public IIconNearbyTrackingT UnPack()
		{
			IIconNearbyTrackingT iconNearbyTrackingT = new IIconNearbyTrackingT();
			this.UnPackTo(iconNearbyTrackingT);
			return iconNearbyTrackingT;
		}

		// Token: 0x060254AD RID: 152749 RVA: 0x0051E988 File Offset: 0x0051CB88
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

		// Token: 0x060254AE RID: 152750 RVA: 0x0051EA0C File Offset: 0x0051CC0C
		public static Offset<IIconNearbyTracking> Pack(FlatBufferBuilder builder, IIconNearbyTrackingT _o)
		{
			if (_o == null)
			{
				return default(Offset<IIconNearbyTracking>);
			}
			Offset<IVectorInfo> uiOffsetOffset = (_o.UiOffset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.UiOffset);
			return IIconNearbyTracking.CreateIIconNearbyTracking(builder, _o.Type, _o.ShowRange, _o.HideRange, _o.TexturePath, uiOffsetOffset, _o.Duration, _o.NullMask);
		}

		// Token: 0x0400F248 RID: 62024
		private Table __p;
	}
}
