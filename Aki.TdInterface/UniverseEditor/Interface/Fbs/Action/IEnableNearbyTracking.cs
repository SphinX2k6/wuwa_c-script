using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006678 RID: 26232
	public struct IEnableNearbyTracking : IFlatbufferObject
	{
		// Token: 0x1700C2DB RID: 49883
		// (get) Token: 0x0602D927 RID: 186663 RVA: 0x0063D22D File Offset: 0x0063B42D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D928 RID: 186664 RVA: 0x0063D23A File Offset: 0x0063B43A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D929 RID: 186665 RVA: 0x0063D244 File Offset: 0x0063B444
		public static IEnableNearbyTracking GetRootAsIEnableNearbyTracking(ByteBuffer _bb)
		{
			return IEnableNearbyTracking.GetRootAsIEnableNearbyTracking(_bb, default(IEnableNearbyTracking));
		}

		// Token: 0x0602D92A RID: 186666 RVA: 0x0063D260 File Offset: 0x0063B460
		public static IEnableNearbyTracking GetRootAsIEnableNearbyTracking(ByteBuffer _bb, IEnableNearbyTracking obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D92B RID: 186667 RVA: 0x0063D27D File Offset: 0x0063B47D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D92C RID: 186668 RVA: 0x0063D28C File Offset: 0x0063B48C
		public IEnableNearbyTracking __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C2DC RID: 49884
		// (get) Token: 0x0602D92D RID: 186669 RVA: 0x0063D29C File Offset: 0x0063B49C
		public bool IsEnable
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C2DD RID: 49885
		// (get) Token: 0x0602D92E RID: 186670 RVA: 0x0063D2DC File Offset: 0x0063B4DC
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

		// Token: 0x0602D92F RID: 186671 RVA: 0x0063D318 File Offset: 0x0063B518
		public TTable? ControlType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602D930 RID: 186672 RVA: 0x0063D35C File Offset: 0x0063B55C
		public IControlTrackingOther ControlTypeAsIControlTrackingOther()
		{
			return this.ControlType<IControlTrackingOther>().Value;
		}

		// Token: 0x0602D931 RID: 186673 RVA: 0x0063D378 File Offset: 0x0063B578
		public IControlTrackingSelf ControlTypeAsIControlTrackingSelf()
		{
			return this.ControlType<IControlTrackingSelf>().Value;
		}

		// Token: 0x0602D932 RID: 186674 RVA: 0x0063D393 File Offset: 0x0063B593
		public static Offset<IEnableNearbyTracking> CreateIEnableNearbyTracking(FlatBufferBuilder builder, bool IsEnable = false, TControlTrackingType ControlType_type = TControlTrackingType.NONE, int ControlTypeOffset = 0)
		{
			builder.StartTable(3);
			IEnableNearbyTracking.AddControlType(builder, ControlTypeOffset);
			IEnableNearbyTracking.AddControlTypeType(builder, ControlType_type);
			IEnableNearbyTracking.AddIsEnable(builder, IsEnable);
			return IEnableNearbyTracking.EndIEnableNearbyTracking(builder);
		}

		// Token: 0x0602D933 RID: 186675 RVA: 0x0063D3B7 File Offset: 0x0063B5B7
		public static void StartIEnableNearbyTracking(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602D934 RID: 186676 RVA: 0x0063D3C0 File Offset: 0x0063B5C0
		public static void AddIsEnable(FlatBufferBuilder builder, bool isEnable)
		{
			builder.AddBool(0, isEnable, false);
		}

		// Token: 0x0602D935 RID: 186677 RVA: 0x0063D3CB File Offset: 0x0063B5CB
		public static void AddControlTypeType(FlatBufferBuilder builder, TControlTrackingType controlTypeType)
		{
			builder.AddByte(1, (byte)controlTypeType, 0);
		}

		// Token: 0x0602D936 RID: 186678 RVA: 0x0063D3D6 File Offset: 0x0063B5D6
		public static void AddControlType(FlatBufferBuilder builder, int controlTypeOffset)
		{
			builder.AddOffset(2, controlTypeOffset, 0);
		}

		// Token: 0x0602D937 RID: 186679 RVA: 0x0063D3E1 File Offset: 0x0063B5E1
		public static Offset<IEnableNearbyTracking> EndIEnableNearbyTracking(FlatBufferBuilder builder)
		{
			return new Offset<IEnableNearbyTracking>(builder.EndTable());
		}

		// Token: 0x0602D938 RID: 186680 RVA: 0x0063D3F0 File Offset: 0x0063B5F0
		public IEnableNearbyTrackingT UnPack()
		{
			IEnableNearbyTrackingT enableNearbyTrackingT = new IEnableNearbyTrackingT();
			this.UnPackTo(enableNearbyTrackingT);
			return enableNearbyTrackingT;
		}

		// Token: 0x0602D939 RID: 186681 RVA: 0x0063D40C File Offset: 0x0063B60C
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

		// Token: 0x0602D93A RID: 186682 RVA: 0x0063D4BC File Offset: 0x0063B6BC
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

		// Token: 0x04010D1F RID: 68895
		private Table __p;
	}
}
