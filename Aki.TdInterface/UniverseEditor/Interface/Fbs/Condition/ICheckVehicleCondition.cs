using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200504F RID: 20559
	public struct ICheckVehicleCondition : IFlatbufferObject
	{
		// Token: 0x17009325 RID: 37669
		// (get) Token: 0x06020229 RID: 131625 RVA: 0x0047507A File Offset: 0x0047327A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602022A RID: 131626 RVA: 0x00475087 File Offset: 0x00473287
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602022B RID: 131627 RVA: 0x00475090 File Offset: 0x00473290
		public static ICheckVehicleCondition GetRootAsICheckVehicleCondition(ByteBuffer _bb)
		{
			return ICheckVehicleCondition.GetRootAsICheckVehicleCondition(_bb, default(ICheckVehicleCondition));
		}

		// Token: 0x0602022C RID: 131628 RVA: 0x004750AC File Offset: 0x004732AC
		public static ICheckVehicleCondition GetRootAsICheckVehicleCondition(ByteBuffer _bb, ICheckVehicleCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602022D RID: 131629 RVA: 0x004750C9 File Offset: 0x004732C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602022E RID: 131630 RVA: 0x004750D8 File Offset: 0x004732D8
		public ICheckVehicleCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009326 RID: 37670
		// (get) Token: 0x0602022F RID: 131631 RVA: 0x004750E8 File Offset: 0x004732E8
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

		// Token: 0x17009327 RID: 37671
		// (get) Token: 0x06020230 RID: 131632 RVA: 0x00475124 File Offset: 0x00473324
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

		// Token: 0x06020231 RID: 131633 RVA: 0x00475160 File Offset: 0x00473360
		public TTable? Condition<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06020232 RID: 131634 RVA: 0x004751A4 File Offset: 0x004733A4
		public ICheckIsPlayerUsingVehicle ConditionAsICheckIsPlayerUsingVehicle()
		{
			return this.Condition<ICheckIsPlayerUsingVehicle>().Value;
		}

		// Token: 0x06020233 RID: 131635 RVA: 0x004751C0 File Offset: 0x004733C0
		public ICheckIsUsingVehicle ConditionAsICheckIsUsingVehicle()
		{
			return this.Condition<ICheckIsUsingVehicle>().Value;
		}

		// Token: 0x06020234 RID: 131636 RVA: 0x004751DC File Offset: 0x004733DC
		public ICheckVehicleSpeedCondition ConditionAsICheckVehicleSpeedCondition()
		{
			return this.Condition<ICheckVehicleSpeedCondition>().Value;
		}

		// Token: 0x06020235 RID: 131637 RVA: 0x004751F8 File Offset: 0x004733F8
		public ICheckVehicleTriggerAngleCondition ConditionAsICheckVehicleTriggerAngleCondition()
		{
			return this.Condition<ICheckVehicleTriggerAngleCondition>().Value;
		}

		// Token: 0x06020236 RID: 131638 RVA: 0x00475213 File Offset: 0x00473413
		public static Offset<ICheckVehicleCondition> CreateICheckVehicleCondition(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, TVehicleCondition Condition_type = TVehicleCondition.NONE, int ConditionOffset = 0)
		{
			builder.StartTable(3);
			ICheckVehicleCondition.AddCondition(builder, ConditionOffset);
			ICheckVehicleCondition.AddConditionType(builder, Condition_type);
			ICheckVehicleCondition.AddType(builder, Type);
			return ICheckVehicleCondition.EndICheckVehicleCondition(builder);
		}

		// Token: 0x06020237 RID: 131639 RVA: 0x00475237 File Offset: 0x00473437
		public static void StartICheckVehicleCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06020238 RID: 131640 RVA: 0x00475240 File Offset: 0x00473440
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020239 RID: 131641 RVA: 0x0047524B File Offset: 0x0047344B
		public static void AddConditionType(FlatBufferBuilder builder, TVehicleCondition conditionType)
		{
			builder.AddByte(1, (byte)conditionType, 0);
		}

		// Token: 0x0602023A RID: 131642 RVA: 0x00475256 File Offset: 0x00473456
		public static void AddCondition(FlatBufferBuilder builder, int conditionOffset)
		{
			builder.AddOffset(2, conditionOffset, 0);
		}

		// Token: 0x0602023B RID: 131643 RVA: 0x00475261 File Offset: 0x00473461
		public static Offset<ICheckVehicleCondition> EndICheckVehicleCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICheckVehicleCondition>(builder.EndTable());
		}

		// Token: 0x0602023C RID: 131644 RVA: 0x00475270 File Offset: 0x00473470
		public ICheckVehicleConditionT UnPack()
		{
			ICheckVehicleConditionT checkVehicleConditionT = new ICheckVehicleConditionT();
			this.UnPackTo(checkVehicleConditionT);
			return checkVehicleConditionT;
		}

		// Token: 0x0602023D RID: 131645 RVA: 0x0047528C File Offset: 0x0047348C
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

		// Token: 0x0602023E RID: 131646 RVA: 0x004753BC File Offset: 0x004735BC
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

		// Token: 0x0400DF31 RID: 57137
		private Table __p;
	}
}
