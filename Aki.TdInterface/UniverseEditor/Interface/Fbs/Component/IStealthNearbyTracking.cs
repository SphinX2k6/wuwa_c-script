using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005FD8 RID: 24536
	public struct IStealthNearbyTracking : IFlatbufferObject
	{
		// Token: 0x1700B5E0 RID: 46560
		// (get) Token: 0x0602952C RID: 169260 RVA: 0x005A42D3 File Offset: 0x005A24D3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602952D RID: 169261 RVA: 0x005A42E0 File Offset: 0x005A24E0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602952E RID: 169262 RVA: 0x005A42E8 File Offset: 0x005A24E8
		public static IStealthNearbyTracking GetRootAsIStealthNearbyTracking(ByteBuffer _bb)
		{
			return IStealthNearbyTracking.GetRootAsIStealthNearbyTracking(_bb, default(IStealthNearbyTracking));
		}

		// Token: 0x0602952F RID: 169263 RVA: 0x005A4304 File Offset: 0x005A2504
		public static IStealthNearbyTracking GetRootAsIStealthNearbyTracking(ByteBuffer _bb, IStealthNearbyTracking obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029530 RID: 169264 RVA: 0x005A4321 File Offset: 0x005A2521
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029531 RID: 169265 RVA: 0x005A4330 File Offset: 0x005A2530
		public IStealthNearbyTracking __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B5E1 RID: 46561
		// (get) Token: 0x06029532 RID: 169266 RVA: 0x005A4340 File Offset: 0x005A2540
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

		// Token: 0x1700B5E2 RID: 46562
		// (get) Token: 0x06029533 RID: 169267 RVA: 0x005A437C File Offset: 0x005A257C
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

		// Token: 0x1700B5E3 RID: 46563
		// (get) Token: 0x06029534 RID: 169268 RVA: 0x005A43B8 File Offset: 0x005A25B8
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

		// Token: 0x1700B5E4 RID: 46564
		// (get) Token: 0x06029535 RID: 169269 RVA: 0x005A43F4 File Offset: 0x005A25F4
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

		// Token: 0x06029536 RID: 169270 RVA: 0x005A442C File Offset: 0x005A262C
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06029537 RID: 169271 RVA: 0x005A443C File Offset: 0x005A263C
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700B5E5 RID: 46565
		// (get) Token: 0x06029538 RID: 169272 RVA: 0x005A444C File Offset: 0x005A264C
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

		// Token: 0x06029539 RID: 169273 RVA: 0x005A44AA File Offset: 0x005A26AA
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

		// Token: 0x0602953A RID: 169274 RVA: 0x005A44DE File Offset: 0x005A26DE
		public static void StartIStealthNearbyTracking(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602953B RID: 169275 RVA: 0x005A44E7 File Offset: 0x005A26E7
		public static void AddType(FlatBufferBuilder builder, ENearbyTrackingType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602953C RID: 169276 RVA: 0x005A44F2 File Offset: 0x005A26F2
		public static void AddShowRange(FlatBufferBuilder builder, int showRange)
		{
			builder.AddInt(1, showRange, 0);
		}

		// Token: 0x0602953D RID: 169277 RVA: 0x005A44FD File Offset: 0x005A26FD
		public static void AddHideRange(FlatBufferBuilder builder, int hideRange)
		{
			builder.AddInt(2, hideRange, 0);
		}

		// Token: 0x0602953E RID: 169278 RVA: 0x005A4508 File Offset: 0x005A2708
		public static void AddIcon(FlatBufferBuilder builder, StringOffset iconOffset)
		{
			builder.AddOffset(3, iconOffset.Value, 0);
		}

		// Token: 0x0602953F RID: 169279 RVA: 0x005A4518 File Offset: 0x005A2718
		public static void AddIconOffset(FlatBufferBuilder builder, Offset<IVectorInfo> iconOffsetOffset)
		{
			builder.AddOffset(4, iconOffsetOffset.Value, 0);
		}

		// Token: 0x06029540 RID: 169280 RVA: 0x005A4528 File Offset: 0x005A2728
		public static Offset<IStealthNearbyTracking> EndIStealthNearbyTracking(FlatBufferBuilder builder)
		{
			return new Offset<IStealthNearbyTracking>(builder.EndTable());
		}

		// Token: 0x06029541 RID: 169281 RVA: 0x005A4538 File Offset: 0x005A2738
		public IStealthNearbyTrackingT UnPack()
		{
			IStealthNearbyTrackingT stealthNearbyTrackingT = new IStealthNearbyTrackingT();
			this.UnPackTo(stealthNearbyTrackingT);
			return stealthNearbyTrackingT;
		}

		// Token: 0x06029542 RID: 169282 RVA: 0x005A4554 File Offset: 0x005A2754
		public void UnPackTo(IStealthNearbyTrackingT _o)
		{
			_o.Type = this.Type;
			_o.ShowRange = this.ShowRange;
			_o.HideRange = this.HideRange;
			_o.Icon = this.Icon;
			_o.IconOffset = ((this.IconOffset != null) ? this.IconOffset.Value.UnPack() : null);
		}

		// Token: 0x06029543 RID: 169283 RVA: 0x005A45C0 File Offset: 0x005A27C0
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

		// Token: 0x0400FCED RID: 64749
		private Table __p;
	}
}
