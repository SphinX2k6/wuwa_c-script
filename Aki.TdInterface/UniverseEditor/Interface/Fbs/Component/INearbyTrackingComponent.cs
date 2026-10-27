using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055F3 RID: 22003
	public struct INearbyTrackingComponent : IFlatbufferObject
	{
		// Token: 0x1700A2CA RID: 41674
		// (get) Token: 0x06024803 RID: 149507 RVA: 0x00509AAD File Offset: 0x00507CAD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024804 RID: 149508 RVA: 0x00509ABA File Offset: 0x00507CBA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024805 RID: 149509 RVA: 0x00509AC4 File Offset: 0x00507CC4
		public static INearbyTrackingComponent GetRootAsINearbyTrackingComponent(ByteBuffer _bb)
		{
			return INearbyTrackingComponent.GetRootAsINearbyTrackingComponent(_bb, default(INearbyTrackingComponent));
		}

		// Token: 0x06024806 RID: 149510 RVA: 0x00509AE0 File Offset: 0x00507CE0
		public static INearbyTrackingComponent GetRootAsINearbyTrackingComponent(ByteBuffer _bb, INearbyTrackingComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024807 RID: 149511 RVA: 0x00509AFD File Offset: 0x00507CFD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024808 RID: 149512 RVA: 0x00509B0C File Offset: 0x00507D0C
		public INearbyTrackingComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A2CB RID: 41675
		// (get) Token: 0x06024809 RID: 149513 RVA: 0x00509B1C File Offset: 0x00507D1C
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A2CC RID: 41676
		// (get) Token: 0x0602480A RID: 149514 RVA: 0x00509B5C File Offset: 0x00507D5C
		public bool IsEnable
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A2CD RID: 41677
		// (get) Token: 0x0602480B RID: 149515 RVA: 0x00509B9C File Offset: 0x00507D9C
		public bool IsEnableWhileUnlock
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A2CE RID: 41678
		// (get) Token: 0x0602480C RID: 149516 RVA: 0x00509BDC File Offset: 0x00507DDC
		public bool IsEnbaleWhileHoming
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A2CF RID: 41679
		// (get) Token: 0x0602480D RID: 149517 RVA: 0x00509C1C File Offset: 0x00507E1C
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

		// Token: 0x0602480E RID: 149518 RVA: 0x00509C5C File Offset: 0x00507E5C
		public TTable? TrackingType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602480F RID: 149519 RVA: 0x00509CA4 File Offset: 0x00507EA4
		public IAudioPointNearbyTracking TrackingTypeAsIAudioPointNearbyTracking()
		{
			return this.TrackingType<IAudioPointNearbyTracking>().Value;
		}

		// Token: 0x06024810 RID: 149520 RVA: 0x00509CC0 File Offset: 0x00507EC0
		public ICompassTracking TrackingTypeAsICompassTracking()
		{
			return this.TrackingType<ICompassTracking>().Value;
		}

		// Token: 0x06024811 RID: 149521 RVA: 0x00509CDC File Offset: 0x00507EDC
		public IIconNearbyTracking TrackingTypeAsIIconNearbyTracking()
		{
			return this.TrackingType<IIconNearbyTracking>().Value;
		}

		// Token: 0x06024812 RID: 149522 RVA: 0x00509CF8 File Offset: 0x00507EF8
		public IStealthNearbyTracking TrackingTypeAsIStealthNearbyTracking()
		{
			return this.TrackingType<IStealthNearbyTracking>().Value;
		}

		// Token: 0x1700A2D0 RID: 41680
		// (get) Token: 0x06024813 RID: 149523 RVA: 0x00509D14 File Offset: 0x00507F14
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

		// Token: 0x06024814 RID: 149524 RVA: 0x00509D54 File Offset: 0x00507F54
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

		// Token: 0x06024815 RID: 149525 RVA: 0x00509DA3 File Offset: 0x00507FA3
		public static void StartINearbyTrackingComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06024816 RID: 149526 RVA: 0x00509DAC File Offset: 0x00507FAC
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06024817 RID: 149527 RVA: 0x00509DB7 File Offset: 0x00507FB7
		public static void AddIsEnable(FlatBufferBuilder builder, bool isEnable)
		{
			builder.AddBool(1, isEnable, false);
		}

		// Token: 0x06024818 RID: 149528 RVA: 0x00509DC2 File Offset: 0x00507FC2
		public static void AddIsEnableWhileUnlock(FlatBufferBuilder builder, bool isEnableWhileUnlock)
		{
			builder.AddBool(2, isEnableWhileUnlock, false);
		}

		// Token: 0x06024819 RID: 149529 RVA: 0x00509DCD File Offset: 0x00507FCD
		public static void AddIsEnbaleWhileHoming(FlatBufferBuilder builder, bool isEnbaleWhileHoming)
		{
			builder.AddBool(3, isEnbaleWhileHoming, false);
		}

		// Token: 0x0602481A RID: 149530 RVA: 0x00509DD8 File Offset: 0x00507FD8
		public static void AddTrackingTypeType(FlatBufferBuilder builder, TNearbyTracking trackingTypeType)
		{
			builder.AddByte(4, (byte)trackingTypeType, 0);
		}

		// Token: 0x0602481B RID: 149531 RVA: 0x00509DE3 File Offset: 0x00507FE3
		public static void AddTrackingType(FlatBufferBuilder builder, int trackingTypeOffset)
		{
			builder.AddOffset(5, trackingTypeOffset, 0);
		}

		// Token: 0x0602481C RID: 149532 RVA: 0x00509DEE File Offset: 0x00507FEE
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x0602481D RID: 149533 RVA: 0x00509DF9 File Offset: 0x00507FF9
		public static Offset<INearbyTrackingComponent> EndINearbyTrackingComponent(FlatBufferBuilder builder)
		{
			return new Offset<INearbyTrackingComponent>(builder.EndTable());
		}

		// Token: 0x0602481E RID: 149534 RVA: 0x00509E08 File Offset: 0x00508008
		public INearbyTrackingComponentT UnPack()
		{
			INearbyTrackingComponentT nearbyTrackingComponentT = new INearbyTrackingComponentT();
			this.UnPackTo(nearbyTrackingComponentT);
			return nearbyTrackingComponentT;
		}

		// Token: 0x0602481F RID: 149535 RVA: 0x00509E24 File Offset: 0x00508024
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
			case TNearbyTracking.IIconNearbyTracking:
				_o.TrackingType.Value = ((this.TrackingType<IIconNearbyTracking>() != null) ? this.TrackingType<IIconNearbyTracking>().Value.UnPack() : null);
				break;
			case TNearbyTracking.IStealthNearbyTracking:
				_o.TrackingType.Value = ((this.TrackingType<IStealthNearbyTracking>() != null) ? this.TrackingType<IStealthNearbyTracking>().Value.UnPack() : null);
				break;
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06024820 RID: 149536 RVA: 0x00509F90 File Offset: 0x00508190
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

		// Token: 0x0400E95F RID: 59743
		private Table __p;
	}
}
