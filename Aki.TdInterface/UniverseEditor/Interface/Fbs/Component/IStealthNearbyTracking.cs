using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059CB RID: 22987
	public struct IStealthNearbyTracking : IFlatbufferObject
	{
		// Token: 0x1700ACA8 RID: 44200
		// (get) Token: 0x06026FB4 RID: 159668 RVA: 0x0055D30F File Offset: 0x0055B50F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026FB5 RID: 159669 RVA: 0x0055D31C File Offset: 0x0055B51C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026FB6 RID: 159670 RVA: 0x0055D324 File Offset: 0x0055B524
		public static IStealthNearbyTracking GetRootAsIStealthNearbyTracking(ByteBuffer _bb)
		{
			return IStealthNearbyTracking.GetRootAsIStealthNearbyTracking(_bb, default(IStealthNearbyTracking));
		}

		// Token: 0x06026FB7 RID: 159671 RVA: 0x0055D340 File Offset: 0x0055B540
		public static IStealthNearbyTracking GetRootAsIStealthNearbyTracking(ByteBuffer _bb, IStealthNearbyTracking obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026FB8 RID: 159672 RVA: 0x0055D35D File Offset: 0x0055B55D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026FB9 RID: 159673 RVA: 0x0055D36C File Offset: 0x0055B56C
		public IStealthNearbyTracking __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ACA9 RID: 44201
		// (get) Token: 0x06026FBA RID: 159674 RVA: 0x0055D37C File Offset: 0x0055B57C
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

		// Token: 0x1700ACAA RID: 44202
		// (get) Token: 0x06026FBB RID: 159675 RVA: 0x0055D3B8 File Offset: 0x0055B5B8
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

		// Token: 0x1700ACAB RID: 44203
		// (get) Token: 0x06026FBC RID: 159676 RVA: 0x0055D3F4 File Offset: 0x0055B5F4
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

		// Token: 0x1700ACAC RID: 44204
		// (get) Token: 0x06026FBD RID: 159677 RVA: 0x0055D430 File Offset: 0x0055B630
		public string Icon
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

		// Token: 0x06026FBE RID: 159678 RVA: 0x0055D468 File Offset: 0x0055B668
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06026FBF RID: 159679 RVA: 0x0055D478 File Offset: 0x0055B678
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700ACAD RID: 44205
		// (get) Token: 0x06026FC0 RID: 159680 RVA: 0x0055D488 File Offset: 0x0055B688
		public IVectorInfo? IconOffset
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

		// Token: 0x06026FC1 RID: 159681 RVA: 0x0055D4E6 File Offset: 0x0055B6E6
		public static Offset<IStealthNearbyTracking> CreateIStealthNearbyTracking(FlatBufferBuilder builder, ENearbyTrackingType Type = ENearbyTrackingType.Icon, int ShowRange = 0, int HideRange = 0, StringOffset IconOffset = default(StringOffset), Offset<IVectorInfo> IconOffsetOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(5);
			IStealthNearbyTracking.AddIconOffset(builder, IconOffsetOffset);
			IStealthNearbyTracking.AddIcon(builder, IconOffset);
			IStealthNearbyTracking.AddHideRange(builder, HideRange);
			IStealthNearbyTracking.AddShowRange(builder, ShowRange);
			IStealthNearbyTracking.AddType(builder, Type);
			return IStealthNearbyTracking.EndIStealthNearbyTracking(builder);
		}

		// Token: 0x06026FC2 RID: 159682 RVA: 0x0055D51A File Offset: 0x0055B71A
		public static void StartIStealthNearbyTracking(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06026FC3 RID: 159683 RVA: 0x0055D523 File Offset: 0x0055B723
		public static void AddType(FlatBufferBuilder builder, ENearbyTrackingType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06026FC4 RID: 159684 RVA: 0x0055D52E File Offset: 0x0055B72E
		public static void AddShowRange(FlatBufferBuilder builder, int showRange)
		{
			builder.AddInt(1, showRange, 0);
		}

		// Token: 0x06026FC5 RID: 159685 RVA: 0x0055D539 File Offset: 0x0055B739
		public static void AddHideRange(FlatBufferBuilder builder, int hideRange)
		{
			builder.AddInt(2, hideRange, 0);
		}

		// Token: 0x06026FC6 RID: 159686 RVA: 0x0055D544 File Offset: 0x0055B744
		public static void AddIcon(FlatBufferBuilder builder, StringOffset iconOffset)
		{
			builder.AddOffset(3, iconOffset.Value, 0);
		}

		// Token: 0x06026FC7 RID: 159687 RVA: 0x0055D554 File Offset: 0x0055B754
		public static void AddIconOffset(FlatBufferBuilder builder, Offset<IVectorInfo> iconOffsetOffset)
		{
			builder.AddOffset(4, iconOffsetOffset.Value, 0);
		}

		// Token: 0x06026FC8 RID: 159688 RVA: 0x0055D564 File Offset: 0x0055B764
		public static Offset<IStealthNearbyTracking> EndIStealthNearbyTracking(FlatBufferBuilder builder)
		{
			return new Offset<IStealthNearbyTracking>(builder.EndTable());
		}

		// Token: 0x06026FC9 RID: 159689 RVA: 0x0055D574 File Offset: 0x0055B774
		public IStealthNearbyTrackingT UnPack()
		{
			IStealthNearbyTrackingT stealthNearbyTrackingT = new IStealthNearbyTrackingT();
			this.UnPackTo(stealthNearbyTrackingT);
			return stealthNearbyTrackingT;
		}

		// Token: 0x06026FCA RID: 159690 RVA: 0x0055D590 File Offset: 0x0055B790
		public void UnPackTo(IStealthNearbyTrackingT _o)
		{
			_o.Type = this.Type;
			_o.ShowRange = this.ShowRange;
			_o.HideRange = this.HideRange;
			_o.Icon = this.Icon;
			_o.IconOffset = ((this.IconOffset != null) ? this.IconOffset.Value.UnPack() : null);
		}

		// Token: 0x06026FCB RID: 159691 RVA: 0x0055D5FC File Offset: 0x0055B7FC
		public static Offset<IStealthNearbyTracking> Pack(FlatBufferBuilder builder, IStealthNearbyTrackingT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStealthNearbyTracking>);
			}
			StringOffset iconOffset = (_o.Icon == null) ? default(StringOffset) : builder.CreateString(_o.Icon);
			Offset<IVectorInfo> iconOffsetOffset = (_o.IconOffset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.IconOffset);
			return IStealthNearbyTracking.CreateIStealthNearbyTracking(builder, _o.Type, _o.ShowRange, _o.HideRange, iconOffset, iconOffsetOffset);
		}

		// Token: 0x0400EFF6 RID: 61430
		private Table __p;
	}
}
