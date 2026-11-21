using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B91 RID: 23441
	public struct INearbyTrackingComponent : IFlatbufferObject
	{
		// Token: 0x1700AB52 RID: 43858
		// (get) Token: 0x06026A10 RID: 158224 RVA: 0x0054A025 File Offset: 0x00548225
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026A11 RID: 158225 RVA: 0x0054A032 File Offset: 0x00548232
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026A12 RID: 158226 RVA: 0x0054A03C File Offset: 0x0054823C
		public static INearbyTrackingComponent GetRootAsINearbyTrackingComponent(ByteBuffer _bb)
		{
			return INearbyTrackingComponent.GetRootAsINearbyTrackingComponent(_bb, default(INearbyTrackingComponent));
		}

		// Token: 0x06026A13 RID: 158227 RVA: 0x0054A058 File Offset: 0x00548258
		public static INearbyTrackingComponent GetRootAsINearbyTrackingComponent(ByteBuffer _bb, INearbyTrackingComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026A14 RID: 158228 RVA: 0x0054A075 File Offset: 0x00548275
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026A15 RID: 158229 RVA: 0x0054A084 File Offset: 0x00548284
		public INearbyTrackingComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AB53 RID: 43859
		// (get) Token: 0x06026A16 RID: 158230 RVA: 0x0054A094 File Offset: 0x00548294
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AB54 RID: 43860
		// (get) Token: 0x06026A17 RID: 158231 RVA: 0x0054A0D4 File Offset: 0x005482D4
		public bool IsEnable
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AB55 RID: 43861
		// (get) Token: 0x06026A18 RID: 158232 RVA: 0x0054A114 File Offset: 0x00548314
		public bool IsEnableWhileUnlock
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AB56 RID: 43862
		// (get) Token: 0x06026A19 RID: 158233 RVA: 0x0054A154 File Offset: 0x00548354
		public bool IsEnbaleWhileHoming
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AB57 RID: 43863
		// (get) Token: 0x06026A1A RID: 158234 RVA: 0x0054A194 File Offset: 0x00548394
		public TNearbyTracking TrackingTypeType
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return TNearbyTracking.NONE;
				}
				return (TNearbyTracking)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026A1B RID: 158235 RVA: 0x0054A1D4 File Offset: 0x005483D4
		public TTable? TrackingType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06026A1C RID: 158236 RVA: 0x0054A21C File Offset: 0x0054841C
		public IAudioPointNearbyTracking TrackingTypeAsIAudioPointNearbyTracking()
		{
			return this.TrackingType<IAudioPointNearbyTracking>().Value;
		}

		// Token: 0x06026A1D RID: 158237 RVA: 0x0054A238 File Offset: 0x00548438
		public ICompassTracking TrackingTypeAsICompassTracking()
		{
			return this.TrackingType<ICompassTracking>().Value;
		}

		// Token: 0x06026A1E RID: 158238 RVA: 0x0054A254 File Offset: 0x00548454
		public IDarkTideNearbyTracking TrackingTypeAsIDarkTideNearbyTracking()
		{
			return this.TrackingType<IDarkTideNearbyTracking>().Value;
		}

		// Token: 0x06026A1F RID: 158239 RVA: 0x0054A270 File Offset: 0x00548470
		public IIconNearbyTracking TrackingTypeAsIIconNearbyTracking()
		{
			return this.TrackingType<IIconNearbyTracking>().Value;
		}

		// Token: 0x06026A20 RID: 158240 RVA: 0x0054A28C File Offset: 0x0054848C
		public IStealthNearbyTracking TrackingTypeAsIStealthNearbyTracking()
		{
			return this.TrackingType<IStealthNearbyTracking>().Value;
		}

		// Token: 0x1700AB58 RID: 43864
		// (get) Token: 0x06026A21 RID: 158241 RVA: 0x0054A2A8 File Offset: 0x005484A8
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

		// Token: 0x06026A22 RID: 158242 RVA: 0x0054A2E8 File Offset: 0x005484E8
		public static Offset<INearbyTrackingComponent> CreateINearbyTrackingComponent(FlatBufferBuilder builder, bool Disabled = false, bool IsEnable = false, bool IsEnableWhileUnlock = false, bool IsEnbaleWhileHoming = false, TNearbyTracking TrackingType_type = TNearbyTracking.NONE, int TrackingTypeOffset = 0, byte NullMask = 0)
		{
			builder.StartTable(7);
			INearbyTrackingComponent.AddTrackingType(builder, TrackingTypeOffset);
			INearbyTrackingComponent.AddNullMask(builder, NullMask);
			INearbyTrackingComponent.AddTrackingTypeType(builder, TrackingType_type);
			INearbyTrackingComponent.AddIsEnbaleWhileHoming(builder, IsEnbaleWhileHoming);
			INearbyTrackingComponent.AddIsEnableWhileUnlock(builder, IsEnableWhileUnlock);
			INearbyTrackingComponent.AddIsEnable(builder, IsEnable);
			INearbyTrackingComponent.AddDisabled(builder, Disabled);
			return INearbyTrackingComponent.EndINearbyTrackingComponent(builder);
		}

		// Token: 0x06026A23 RID: 158243 RVA: 0x0054A337 File Offset: 0x00548537
		public static void StartINearbyTrackingComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06026A24 RID: 158244 RVA: 0x0054A340 File Offset: 0x00548540
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06026A25 RID: 158245 RVA: 0x0054A34B File Offset: 0x0054854B
		public static void AddIsEnable(FlatBufferBuilder builder, bool isEnable)
		{
			builder.AddBool(1, isEnable, false);
		}

		// Token: 0x06026A26 RID: 158246 RVA: 0x0054A356 File Offset: 0x00548556
		public static void AddIsEnableWhileUnlock(FlatBufferBuilder builder, bool isEnableWhileUnlock)
		{
			builder.AddBool(2, isEnableWhileUnlock, false);
		}

		// Token: 0x06026A27 RID: 158247 RVA: 0x0054A361 File Offset: 0x00548561
		public static void AddIsEnbaleWhileHoming(FlatBufferBuilder builder, bool isEnbaleWhileHoming)
		{
			builder.AddBool(3, isEnbaleWhileHoming, false);
		}

		// Token: 0x06026A28 RID: 158248 RVA: 0x0054A36C File Offset: 0x0054856C
		public static void AddTrackingTypeType(FlatBufferBuilder builder, TNearbyTracking trackingTypeType)
		{
			builder.AddByte(4, (byte)trackingTypeType, 0);
		}

		// Token: 0x06026A29 RID: 158249 RVA: 0x0054A377 File Offset: 0x00548577
		public static void AddTrackingType(FlatBufferBuilder builder, int trackingTypeOffset)
		{
			builder.AddOffset(5, trackingTypeOffset, 0);
		}

		// Token: 0x06026A2A RID: 158250 RVA: 0x0054A382 File Offset: 0x00548582
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06026A2B RID: 158251 RVA: 0x0054A38D File Offset: 0x0054858D
		public static Offset<INearbyTrackingComponent> EndINearbyTrackingComponent(FlatBufferBuilder builder)
		{
			return new Offset<INearbyTrackingComponent>(builder.EndTable());
		}

		// Token: 0x06026A2C RID: 158252 RVA: 0x0054A39C File Offset: 0x0054859C
		public INearbyTrackingComponentT UnPack()
		{
			INearbyTrackingComponentT nearbyTrackingComponentT = new INearbyTrackingComponentT();
			this.UnPackTo(nearbyTrackingComponentT);
			return nearbyTrackingComponentT;
		}

		// Token: 0x06026A2D RID: 158253 RVA: 0x0054A3B8 File Offset: 0x005485B8
		public void UnPackTo(INearbyTrackingComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.IsEnable = this.IsEnable;
			_o.IsEnableWhileUnlock = this.IsEnableWhileUnlock;
			_o.IsEnbaleWhileHoming = this.IsEnbaleWhileHoming;
			_o.TrackingType = new TNearbyTrackingUnion();
			_o.TrackingType.Type = this.TrackingTypeType;
			switch (this.TrackingTypeType)
			{
			case TNearbyTracking.IAudioPointNearbyTracking:
				_o.TrackingType.Value = ((this.TrackingType<IAudioPointNearbyTracking>() != null) ? this.TrackingType<IAudioPointNearbyTracking>().Value.UnPack() : null);
				break;
			case TNearbyTracking.ICompassTracking:
				_o.TrackingType.Value = ((this.TrackingType<ICompassTracking>() != null) ? this.TrackingType<ICompassTracking>().Value.UnPack() : null);
				break;
			case TNearbyTracking.IDarkTideNearbyTracking:
				_o.TrackingType.Value = ((this.TrackingType<IDarkTideNearbyTracking>() != null) ? this.TrackingType<IDarkTideNearbyTracking>().Value.UnPack() : null);
				break;
			case TNearbyTracking.IIconNearbyTracking:
				_o.TrackingType.Value = ((this.TrackingType<IIconNearbyTracking>() != null) ? this.TrackingType<IIconNearbyTracking>().Value.UnPack() : null);
				break;
			case TNearbyTracking.IStealthNearbyTracking:
				_o.TrackingType.Value = ((this.TrackingType<IStealthNearbyTracking>() != null) ? this.TrackingType<IStealthNearbyTracking>().Value.UnPack() : null);
				break;
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06026A2E RID: 158254 RVA: 0x0054A564 File Offset: 0x00548764
		public static Offset<INearbyTrackingComponent> Pack(FlatBufferBuilder builder, INearbyTrackingComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<INearbyTrackingComponent>);
			}
			TNearbyTracking trackingType_type = (_o.TrackingType == null) ? TNearbyTracking.NONE : _o.TrackingType.Type;
			int trackingTypeOffset = (_o.TrackingType == null) ? 0 : TNearbyTrackingUnion.Pack(builder, _o.TrackingType);
			return INearbyTrackingComponent.CreateINearbyTrackingComponent(builder, _o.Disabled, _o.IsEnable, _o.IsEnableWhileUnlock, _o.IsEnbaleWhileHoming, trackingType_type, trackingTypeOffset, _o.NullMask);
		}

		// Token: 0x0400F5C1 RID: 62913
		private Table __p;
	}
}
