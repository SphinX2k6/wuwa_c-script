using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B6B RID: 19307
	public struct ICheckVehicleSpeedCondition : IFlatbufferObject
	{
		// Token: 0x17008C1A RID: 35866
		// (get) Token: 0x0601E6B7 RID: 124599 RVA: 0x00442C64 File Offset: 0x00440E64
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E6B8 RID: 124600 RVA: 0x00442C71 File Offset: 0x00440E71
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E6B9 RID: 124601 RVA: 0x00442C78 File Offset: 0x00440E78
		public static ICheckVehicleSpeedCondition GetRootAsICheckVehicleSpeedCondition(ByteBuffer _bb)
		{
			return ICheckVehicleSpeedCondition.GetRootAsICheckVehicleSpeedCondition(_bb, default(ICheckVehicleSpeedCondition));
		}

		// Token: 0x0601E6BA RID: 124602 RVA: 0x00442C94 File Offset: 0x00440E94
		public static ICheckVehicleSpeedCondition GetRootAsICheckVehicleSpeedCondition(ByteBuffer _bb, ICheckVehicleSpeedCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E6BB RID: 124603 RVA: 0x00442CB1 File Offset: 0x00440EB1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E6BC RID: 124604 RVA: 0x00442CC0 File Offset: 0x00440EC0
		public ICheckVehicleSpeedCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008C1B RID: 35867
		// (get) Token: 0x0601E6BD RID: 124605 RVA: 0x00442CD0 File Offset: 0x00440ED0
		public EVehicleConditionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVehicleConditionType.UsingVehicle;
				}
				return (EVehicleConditionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008C1C RID: 35868
		// (get) Token: 0x0601E6BE RID: 124606 RVA: 0x00442D0C File Offset: 0x00440F0C
		public ECompare CompareType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008C1D RID: 35869
		// (get) Token: 0x0601E6BF RID: 124607 RVA: 0x00442D48 File Offset: 0x00440F48
		public float Speed
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601E6C0 RID: 124608 RVA: 0x00442D88 File Offset: 0x00440F88
		public static Offset<ICheckVehicleSpeedCondition> CreateICheckVehicleSpeedCondition(FlatBufferBuilder builder, EVehicleConditionType Type = EVehicleConditionType.UsingVehicle, ECompare CompareType = ECompare.Eq, float Speed = 0f)
		{
			builder.StartTable(3);
			ICheckVehicleSpeedCondition.AddSpeed(builder, Speed);
			ICheckVehicleSpeedCondition.AddCompareType(builder, CompareType);
			ICheckVehicleSpeedCondition.AddType(builder, Type);
			return ICheckVehicleSpeedCondition.EndICheckVehicleSpeedCondition(builder);
		}

		// Token: 0x0601E6C1 RID: 124609 RVA: 0x00442DAC File Offset: 0x00440FAC
		public static void StartICheckVehicleSpeedCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601E6C2 RID: 124610 RVA: 0x00442DB5 File Offset: 0x00440FB5
		public static void AddType(FlatBufferBuilder builder, EVehicleConditionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E6C3 RID: 124611 RVA: 0x00442DC0 File Offset: 0x00440FC0
		public static void AddCompareType(FlatBufferBuilder builder, ECompare compareType)
		{
			builder.AddByte(1, (byte)compareType, 0);
		}

		// Token: 0x0601E6C4 RID: 124612 RVA: 0x00442DCB File Offset: 0x00440FCB
		public static void AddSpeed(FlatBufferBuilder builder, float speed)
		{
			builder.AddFloat(2, speed, 0.0);
		}

		// Token: 0x0601E6C5 RID: 124613 RVA: 0x00442DDE File Offset: 0x00440FDE
		public static Offset<ICheckVehicleSpeedCondition> EndICheckVehicleSpeedCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICheckVehicleSpeedCondition>(builder.EndTable());
		}

		// Token: 0x0601E6C6 RID: 124614 RVA: 0x00442DEC File Offset: 0x00440FEC
		public ICheckVehicleSpeedConditionT UnPack()
		{
			ICheckVehicleSpeedConditionT checkVehicleSpeedConditionT = new ICheckVehicleSpeedConditionT();
			this.UnPackTo(checkVehicleSpeedConditionT);
			return checkVehicleSpeedConditionT;
		}

		// Token: 0x0601E6C7 RID: 124615 RVA: 0x00442E07 File Offset: 0x00441007
		public void UnPackTo(ICheckVehicleSpeedConditionT _o)
		{
			_o.Type = this.Type;
			_o.CompareType = this.CompareType;
			_o.Speed = this.Speed;
		}

		// Token: 0x0601E6C8 RID: 124616 RVA: 0x00442E30 File Offset: 0x00441030
		public static Offset<ICheckVehicleSpeedCondition> Pack(FlatBufferBuilder builder, ICheckVehicleSpeedConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckVehicleSpeedCondition>);
			}
			return ICheckVehicleSpeedCondition.CreateICheckVehicleSpeedCondition(builder, _o.Type, _o.CompareType, _o.Speed);
		}

		// Token: 0x0400D434 RID: 54324
		private Table __p;
	}
}
