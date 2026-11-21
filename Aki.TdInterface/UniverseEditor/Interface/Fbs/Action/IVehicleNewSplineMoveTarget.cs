using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D19 RID: 32025
	public struct IVehicleNewSplineMoveTarget : IFlatbufferObject
	{
		// Token: 0x1700EFB6 RID: 61366
		// (get) Token: 0x06039CDB RID: 236763 RVA: 0x007CC664 File Offset: 0x007CA864
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039CDC RID: 236764 RVA: 0x007CC671 File Offset: 0x007CA871
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039CDD RID: 236765 RVA: 0x007CC678 File Offset: 0x007CA878
		public static IVehicleNewSplineMoveTarget GetRootAsIVehicleNewSplineMoveTarget(ByteBuffer _bb)
		{
			return IVehicleNewSplineMoveTarget.GetRootAsIVehicleNewSplineMoveTarget(_bb, default(IVehicleNewSplineMoveTarget));
		}

		// Token: 0x06039CDE RID: 236766 RVA: 0x007CC694 File Offset: 0x007CA894
		public static IVehicleNewSplineMoveTarget GetRootAsIVehicleNewSplineMoveTarget(ByteBuffer _bb, IVehicleNewSplineMoveTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06039CDF RID: 236767 RVA: 0x007CC6B1 File Offset: 0x007CA8B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06039CE0 RID: 236768 RVA: 0x007CC6C0 File Offset: 0x007CA8C0
		public IVehicleNewSplineMoveTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EFB7 RID: 61367
		// (get) Token: 0x06039CE1 RID: 236769 RVA: 0x007CC6D0 File Offset: 0x007CA8D0
		public ENewSplineMoveTargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ENewSplineMoveTargetType.Player;
				}
				return (ENewSplineMoveTargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700EFB8 RID: 61368
		// (get) Token: 0x06039CE2 RID: 236770 RVA: 0x007CC70C File Offset: 0x007CA90C
		public TTargetVehicle TargetVehicleType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TTargetVehicle.NONE;
				}
				return (TTargetVehicle)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06039CE3 RID: 236771 RVA: 0x007CC748 File Offset: 0x007CA948
		public TTable? TargetVehicle<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06039CE4 RID: 236772 RVA: 0x007CC78C File Offset: 0x007CA98C
		public IAppointedVehicle TargetVehicleAsIAppointedVehicle()
		{
			return this.TargetVehicle<IAppointedVehicle>().Value;
		}

		// Token: 0x06039CE5 RID: 236773 RVA: 0x007CC7A8 File Offset: 0x007CA9A8
		public ICurrentVehicle TargetVehicleAsICurrentVehicle()
		{
			return this.TargetVehicle<ICurrentVehicle>().Value;
		}

		// Token: 0x06039CE6 RID: 236774 RVA: 0x007CC7C4 File Offset: 0x007CA9C4
		public IFishingBoatVehicle TargetVehicleAsIFishingBoatVehicle()
		{
			return this.TargetVehicle<IFishingBoatVehicle>().Value;
		}

		// Token: 0x06039CE7 RID: 236775 RVA: 0x007CC7E0 File Offset: 0x007CA9E0
		public ISelfVehicle TargetVehicleAsISelfVehicle()
		{
			return this.TargetVehicle<ISelfVehicle>().Value;
		}

		// Token: 0x06039CE8 RID: 236776 RVA: 0x007CC7FC File Offset: 0x007CA9FC
		public ITriggeredVehicle TargetVehicleAsITriggeredVehicle()
		{
			return this.TargetVehicle<ITriggeredVehicle>().Value;
		}

		// Token: 0x06039CE9 RID: 236777 RVA: 0x007CC818 File Offset: 0x007CAA18
		public IVehiclePlayerMotor TargetVehicleAsIVehiclePlayerMotor()
		{
			return this.TargetVehicle<IVehiclePlayerMotor>().Value;
		}

		// Token: 0x06039CEA RID: 236778 RVA: 0x007CC834 File Offset: 0x007CAA34
		public IVehicleTeam TargetVehicleAsIVehicleTeam()
		{
			return this.TargetVehicle<IVehicleTeam>().Value;
		}

		// Token: 0x1700EFB9 RID: 61369
		// (get) Token: 0x06039CEB RID: 236779 RVA: 0x007CC850 File Offset: 0x007CAA50
		public bool IsLookDir
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700EFBA RID: 61370
		// (get) Token: 0x06039CEC RID: 236780 RVA: 0x007CC890 File Offset: 0x007CAA90
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06039CED RID: 236781 RVA: 0x007CC8CD File Offset: 0x007CAACD
		public static Offset<IVehicleNewSplineMoveTarget> CreateIVehicleNewSplineMoveTarget(FlatBufferBuilder builder, ENewSplineMoveTargetType Type = ENewSplineMoveTargetType.Player, TTargetVehicle TargetVehicle_type = TTargetVehicle.NONE, int TargetVehicleOffset = 0, bool IsLookDir = false, byte NullMask = 0)
		{
			builder.StartTable(5);
			IVehicleNewSplineMoveTarget.AddTargetVehicle(builder, TargetVehicleOffset);
			IVehicleNewSplineMoveTarget.AddNullMask(builder, NullMask);
			IVehicleNewSplineMoveTarget.AddIsLookDir(builder, IsLookDir);
			IVehicleNewSplineMoveTarget.AddTargetVehicleType(builder, TargetVehicle_type);
			IVehicleNewSplineMoveTarget.AddType(builder, Type);
			return IVehicleNewSplineMoveTarget.EndIVehicleNewSplineMoveTarget(builder);
		}

		// Token: 0x06039CEE RID: 236782 RVA: 0x007CC901 File Offset: 0x007CAB01
		public static void StartIVehicleNewSplineMoveTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06039CEF RID: 236783 RVA: 0x007CC90A File Offset: 0x007CAB0A
		public static void AddType(FlatBufferBuilder builder, ENewSplineMoveTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06039CF0 RID: 236784 RVA: 0x007CC915 File Offset: 0x007CAB15
		public static void AddTargetVehicleType(FlatBufferBuilder builder, TTargetVehicle targetVehicleType)
		{
			builder.AddByte(1, (byte)targetVehicleType, 0);
		}

		// Token: 0x06039CF1 RID: 236785 RVA: 0x007CC920 File Offset: 0x007CAB20
		public static void AddTargetVehicle(FlatBufferBuilder builder, int targetVehicleOffset)
		{
			builder.AddOffset(2, targetVehicleOffset, 0);
		}

		// Token: 0x06039CF2 RID: 236786 RVA: 0x007CC92B File Offset: 0x007CAB2B
		public static void AddIsLookDir(FlatBufferBuilder builder, bool isLookDir)
		{
			builder.AddBool(3, isLookDir, false);
		}

		// Token: 0x06039CF3 RID: 236787 RVA: 0x007CC936 File Offset: 0x007CAB36
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06039CF4 RID: 236788 RVA: 0x007CC941 File Offset: 0x007CAB41
		public static Offset<IVehicleNewSplineMoveTarget> EndIVehicleNewSplineMoveTarget(FlatBufferBuilder builder)
		{
			return new Offset<IVehicleNewSplineMoveTarget>(builder.EndTable());
		}

		// Token: 0x06039CF5 RID: 236789 RVA: 0x007CC950 File Offset: 0x007CAB50
		public IVehicleNewSplineMoveTargetT UnPack()
		{
			IVehicleNewSplineMoveTargetT vehicleNewSplineMoveTargetT = new IVehicleNewSplineMoveTargetT();
			this.UnPackTo(vehicleNewSplineMoveTargetT);
			return vehicleNewSplineMoveTargetT;
		}

		// Token: 0x06039CF6 RID: 236790 RVA: 0x007CC96C File Offset: 0x007CAB6C
		public void UnPackTo(IVehicleNewSplineMoveTargetT _o)
		{
			_o.Type = this.Type;
			_o.TargetVehicle = new TTargetVehicleUnion();
			_o.TargetVehicle.Type = this.TargetVehicleType;
			switch (this.TargetVehicleType)
			{
			case TTargetVehicle.IAppointedVehicle:
				_o.TargetVehicle.Value = ((this.TargetVehicle<IAppointedVehicle>() != null) ? this.TargetVehicle<IAppointedVehicle>().Value.UnPack() : null);
				break;
			case TTargetVehicle.ICurrentVehicle:
				_o.TargetVehicle.Value = ((this.TargetVehicle<ICurrentVehicle>() != null) ? this.TargetVehicle<ICurrentVehicle>().Value.UnPack() : null);
				break;
			case TTargetVehicle.IFishingBoatVehicle:
				_o.TargetVehicle.Value = ((this.TargetVehicle<IFishingBoatVehicle>() != null) ? this.TargetVehicle<IFishingBoatVehicle>().Value.UnPack() : null);
				break;
			case TTargetVehicle.ISelfVehicle:
				_o.TargetVehicle.Value = ((this.TargetVehicle<ISelfVehicle>() != null) ? this.TargetVehicle<ISelfVehicle>().Value.UnPack() : null);
				break;
			case TTargetVehicle.ITriggeredVehicle:
				_o.TargetVehicle.Value = ((this.TargetVehicle<ITriggeredVehicle>() != null) ? this.TargetVehicle<ITriggeredVehicle>().Value.UnPack() : null);
				break;
			case TTargetVehicle.IVehiclePlayerMotor:
				_o.TargetVehicle.Value = ((this.TargetVehicle<IVehiclePlayerMotor>() != null) ? this.TargetVehicle<IVehiclePlayerMotor>().Value.UnPack() : null);
				break;
			case TTargetVehicle.IVehicleTeam:
				_o.TargetVehicle.Value = ((this.TargetVehicle<IVehicleTeam>() != null) ? this.TargetVehicle<IVehicleTeam>().Value.UnPack() : null);
				break;
			}
			_o.IsLookDir = this.IsLookDir;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06039CF7 RID: 236791 RVA: 0x007CCB80 File Offset: 0x007CAD80
		public static Offset<IVehicleNewSplineMoveTarget> Pack(FlatBufferBuilder builder, IVehicleNewSplineMoveTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVehicleNewSplineMoveTarget>);
			}
			TTargetVehicle targetVehicle_type = (_o.TargetVehicle == null) ? TTargetVehicle.NONE : _o.TargetVehicle.Type;
			int targetVehicleOffset = (_o.TargetVehicle == null) ? 0 : TTargetVehicleUnion.Pack(builder, _o.TargetVehicle);
			return IVehicleNewSplineMoveTarget.CreateIVehicleNewSplineMoveTarget(builder, _o.Type, targetVehicle_type, targetVehicleOffset, _o.IsLookDir, _o.NullMask);
		}

		// Token: 0x04013444 RID: 78916
		private Table __p;
	}
}
