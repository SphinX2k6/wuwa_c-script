using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CEC RID: 27884
	public struct IEnableNearbyTracking : IFlatbufferObject
	{
		// Token: 0x1700CC7E RID: 52350
		// (get) Token: 0x06030110 RID: 196880 RVA: 0x00689FC9 File Offset: 0x006881C9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030111 RID: 196881 RVA: 0x00689FD6 File Offset: 0x006881D6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030112 RID: 196882 RVA: 0x00689FE0 File Offset: 0x006881E0
		public static IEnableNearbyTracking GetRootAsIEnableNearbyTracking(ByteBuffer _bb)
		{
			return IEnableNearbyTracking.GetRootAsIEnableNearbyTracking(_bb, default(IEnableNearbyTracking));
		}

		// Token: 0x06030113 RID: 196883 RVA: 0x00689FFC File Offset: 0x006881FC
		public static IEnableNearbyTracking GetRootAsIEnableNearbyTracking(ByteBuffer _bb, IEnableNearbyTracking obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030114 RID: 196884 RVA: 0x0068A019 File Offset: 0x00688219
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030115 RID: 196885 RVA: 0x0068A028 File Offset: 0x00688228
		public IEnableNearbyTracking __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CC7F RID: 52351
		// (get) Token: 0x06030116 RID: 196886 RVA: 0x0068A038 File Offset: 0x00688238
		public bool IsEnable
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CC80 RID: 52352
		// (get) Token: 0x06030117 RID: 196887 RVA: 0x0068A078 File Offset: 0x00688278
		public TControlTrackingType ControlTypeType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TControlTrackingType.NONE;
				}
				return (TControlTrackingType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030118 RID: 196888 RVA: 0x0068A0B4 File Offset: 0x006882B4
		public TTable? ControlType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06030119 RID: 196889 RVA: 0x0068A0F8 File Offset: 0x006882F8
		public IControlTrackingOther ControlTypeAsIControlTrackingOther()
		{
			return this.ControlType<IControlTrackingOther>().Value;
		}

		// Token: 0x0603011A RID: 196890 RVA: 0x0068A114 File Offset: 0x00688314
		public IControlTrackingSelf ControlTypeAsIControlTrackingSelf()
		{
			return this.ControlType<IControlTrackingSelf>().Value;
		}

		// Token: 0x0603011B RID: 196891 RVA: 0x0068A12F File Offset: 0x0068832F
		public static Offset<IEnableNearbyTracking> CreateIEnableNearbyTracking(FlatBufferBuilder builder, bool IsEnable = false, TControlTrackingType ControlType_type = TControlTrackingType.NONE, int ControlTypeOffset = 0)
		{
			builder.StartTable(3);
			IEnableNearbyTracking.AddControlType(builder, ControlTypeOffset);
			IEnableNearbyTracking.AddControlTypeType(builder, ControlType_type);
			IEnableNearbyTracking.AddIsEnable(builder, IsEnable);
			return IEnableNearbyTracking.EndIEnableNearbyTracking(builder);
		}

		// Token: 0x0603011C RID: 196892 RVA: 0x0068A153 File Offset: 0x00688353
		public static void StartIEnableNearbyTracking(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0603011D RID: 196893 RVA: 0x0068A15C File Offset: 0x0068835C
		public static void AddIsEnable(FlatBufferBuilder builder, bool isEnable)
		{
			builder.AddBool(0, isEnable, false);
		}

		// Token: 0x0603011E RID: 196894 RVA: 0x0068A167 File Offset: 0x00688367
		public static void AddControlTypeType(FlatBufferBuilder builder, TControlTrackingType controlTypeType)
		{
			builder.AddByte(1, (byte)controlTypeType, 0);
		}

		// Token: 0x0603011F RID: 196895 RVA: 0x0068A172 File Offset: 0x00688372
		public static void AddControlType(FlatBufferBuilder builder, int controlTypeOffset)
		{
			builder.AddOffset(2, controlTypeOffset, 0);
		}

		// Token: 0x06030120 RID: 196896 RVA: 0x0068A17D File Offset: 0x0068837D
		public static Offset<IEnableNearbyTracking> EndIEnableNearbyTracking(FlatBufferBuilder builder)
		{
			return new Offset<IEnableNearbyTracking>(builder.EndTable());
		}

		// Token: 0x06030121 RID: 196897 RVA: 0x0068A18C File Offset: 0x0068838C
		public IEnableNearbyTrackingT UnPack()
		{
			IEnableNearbyTrackingT enableNearbyTrackingT = new IEnableNearbyTrackingT();
			this.UnPackTo(enableNearbyTrackingT);
			return enableNearbyTrackingT;
		}

		// Token: 0x06030122 RID: 196898 RVA: 0x0068A1A8 File Offset: 0x006883A8
		public void UnPackTo(IEnableNearbyTrackingT _o)
		{
			_o.IsEnable = this.IsEnable;
			_o.ControlType = new TControlTrackingTypeUnion();
			_o.ControlType.Type = this.ControlTypeType;
			TControlTrackingType controlTypeType = this.ControlTypeType;
			if (controlTypeType == TControlTrackingType.IControlTrackingOther)
			{
				_o.ControlType.Value = ((this.ControlType<IControlTrackingOther>() != null) ? this.ControlType<IControlTrackingOther>().Value.UnPack() : null);
				return;
			}
			if (controlTypeType != TControlTrackingType.IControlTrackingSelf)
			{
				return;
			}
			_o.ControlType.Value = ((this.ControlType<IControlTrackingSelf>() != null) ? this.ControlType<IControlTrackingSelf>().Value.UnPack() : null);
		}

		// Token: 0x06030123 RID: 196899 RVA: 0x0068A258 File Offset: 0x00688458
		public static Offset<IEnableNearbyTracking> Pack(FlatBufferBuilder builder, IEnableNearbyTrackingT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnableNearbyTracking>);
			}
			TControlTrackingType controlType_type = (_o.ControlType == null) ? TControlTrackingType.NONE : _o.ControlType.Type;
			int controlTypeOffset = (_o.ControlType == null) ? 0 : TControlTrackingTypeUnion.Pack(builder, _o.ControlType);
			return IEnableNearbyTracking.CreateIEnableNearbyTracking(builder, _o.IsEnable, controlType_type, controlTypeOffset);
		}

		// Token: 0x04011B3D RID: 72509
		private Table __p;
	}
}
