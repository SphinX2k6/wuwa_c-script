using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B68 RID: 19304
	public struct ICheckVehicleCondition : IFlatbufferObject
	{
		// Token: 0x17008C15 RID: 35861
		// (get) Token: 0x0601E69B RID: 124571 RVA: 0x0044282E File Offset: 0x00440A2E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E69C RID: 124572 RVA: 0x0044283B File Offset: 0x00440A3B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E69D RID: 124573 RVA: 0x00442844 File Offset: 0x00440A44
		public static ICheckVehicleCondition GetRootAsICheckVehicleCondition(ByteBuffer _bb)
		{
			return ICheckVehicleCondition.GetRootAsICheckVehicleCondition(_bb, default(ICheckVehicleCondition));
		}

		// Token: 0x0601E69E RID: 124574 RVA: 0x00442860 File Offset: 0x00440A60
		public static ICheckVehicleCondition GetRootAsICheckVehicleCondition(ByteBuffer _bb, ICheckVehicleCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E69F RID: 124575 RVA: 0x0044287D File Offset: 0x00440A7D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E6A0 RID: 124576 RVA: 0x0044288C File Offset: 0x00440A8C
		public ICheckVehicleCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008C16 RID: 35862
		// (get) Token: 0x0601E6A1 RID: 124577 RVA: 0x0044289C File Offset: 0x00440A9C
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008C17 RID: 35863
		// (get) Token: 0x0601E6A2 RID: 124578 RVA: 0x004428D8 File Offset: 0x00440AD8
		public TVehicleCondition ConditionType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TVehicleCondition.NONE;
				}
				return (TVehicleCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601E6A3 RID: 124579 RVA: 0x00442914 File Offset: 0x00440B14
		public TTable? Condition<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601E6A4 RID: 124580 RVA: 0x00442958 File Offset: 0x00440B58
		public ICheckIsPlayerUsingVehicle ConditionAsICheckIsPlayerUsingVehicle()
		{
			return this.Condition<ICheckIsPlayerUsingVehicle>().Value;
		}

		// Token: 0x0601E6A5 RID: 124581 RVA: 0x00442974 File Offset: 0x00440B74
		public ICheckIsUsingVehicle ConditionAsICheckIsUsingVehicle()
		{
			return this.Condition<ICheckIsUsingVehicle>().Value;
		}

		// Token: 0x0601E6A6 RID: 124582 RVA: 0x00442990 File Offset: 0x00440B90
		public ICheckVehicleSpeedCondition ConditionAsICheckVehicleSpeedCondition()
		{
			return this.Condition<ICheckVehicleSpeedCondition>().Value;
		}

		// Token: 0x0601E6A7 RID: 124583 RVA: 0x004429AC File Offset: 0x00440BAC
		public ICheckVehicleTriggerAngleCondition ConditionAsICheckVehicleTriggerAngleCondition()
		{
			return this.Condition<ICheckVehicleTriggerAngleCondition>().Value;
		}

		// Token: 0x0601E6A8 RID: 124584 RVA: 0x004429C7 File Offset: 0x00440BC7
		public static Offset<ICheckVehicleCondition> CreateICheckVehicleCondition(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, TVehicleCondition Condition_type = TVehicleCondition.NONE, int ConditionOffset = 0)
		{
			builder.StartTable(3);
			ICheckVehicleCondition.AddCondition(builder, ConditionOffset);
			ICheckVehicleCondition.AddConditionType(builder, Condition_type);
			ICheckVehicleCondition.AddType(builder, Type);
			return ICheckVehicleCondition.EndICheckVehicleCondition(builder);
		}

		// Token: 0x0601E6A9 RID: 124585 RVA: 0x004429EB File Offset: 0x00440BEB
		public static void StartICheckVehicleCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601E6AA RID: 124586 RVA: 0x004429F4 File Offset: 0x00440BF4
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E6AB RID: 124587 RVA: 0x004429FF File Offset: 0x00440BFF
		public static void AddConditionType(FlatBufferBuilder builder, TVehicleCondition conditionType)
		{
			builder.AddByte(1, (byte)conditionType, 0);
		}

		// Token: 0x0601E6AC RID: 124588 RVA: 0x00442A0A File Offset: 0x00440C0A
		public static void AddCondition(FlatBufferBuilder builder, int conditionOffset)
		{
			builder.AddOffset(2, conditionOffset, 0);
		}

		// Token: 0x0601E6AD RID: 124589 RVA: 0x00442A15 File Offset: 0x00440C15
		public static Offset<ICheckVehicleCondition> EndICheckVehicleCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICheckVehicleCondition>(builder.EndTable());
		}

		// Token: 0x0601E6AE RID: 124590 RVA: 0x00442A24 File Offset: 0x00440C24
		public ICheckVehicleConditionT UnPack()
		{
			ICheckVehicleConditionT checkVehicleConditionT = new ICheckVehicleConditionT();
			this.UnPackTo(checkVehicleConditionT);
			return checkVehicleConditionT;
		}

		// Token: 0x0601E6AF RID: 124591 RVA: 0x00442A40 File Offset: 0x00440C40
		public void UnPackTo(ICheckVehicleConditionT _o)
		{
			_o.Type = this.Type;
			_o.Condition = new TVehicleConditionUnion();
			_o.Condition.Type = this.ConditionType;
			switch (this.ConditionType)
			{
			case TVehicleCondition.ICheckIsPlayerUsingVehicle:
				_o.Condition.Value = ((this.Condition<ICheckIsPlayerUsingVehicle>() != null) ? this.Condition<ICheckIsPlayerUsingVehicle>().Value.UnPack() : null);
				return;
			case TVehicleCondition.ICheckIsUsingVehicle:
				_o.Condition.Value = ((this.Condition<ICheckIsUsingVehicle>() != null) ? this.Condition<ICheckIsUsingVehicle>().Value.UnPack() : null);
				return;
			case TVehicleCondition.ICheckVehicleSpeedCondition:
				_o.Condition.Value = ((this.Condition<ICheckVehicleSpeedCondition>() != null) ? this.Condition<ICheckVehicleSpeedCondition>().Value.UnPack() : null);
				return;
			case TVehicleCondition.ICheckVehicleTriggerAngleCondition:
				_o.Condition.Value = ((this.Condition<ICheckVehicleTriggerAngleCondition>() != null) ? this.Condition<ICheckVehicleTriggerAngleCondition>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x0601E6B0 RID: 124592 RVA: 0x00442B70 File Offset: 0x00440D70
		public static Offset<ICheckVehicleCondition> Pack(FlatBufferBuilder builder, ICheckVehicleConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckVehicleCondition>);
			}
			TVehicleCondition condition_type = (_o.Condition == null) ? TVehicleCondition.NONE : _o.Condition.Type;
			int conditionOffset = (_o.Condition == null) ? 0 : TVehicleConditionUnion.Pack(builder, _o.Condition);
			return ICheckVehicleCondition.CreateICheckVehicleCondition(builder, _o.Type, condition_type, conditionOffset);
		}

		// Token: 0x0400D431 RID: 54321
		private Table __p;
	}
}
