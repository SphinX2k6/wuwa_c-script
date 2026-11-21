using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005055 RID: 20565
	public struct ICheckVehicleTriggerAngleCondition : IFlatbufferObject
	{
		// Token: 0x17009331 RID: 37681
		// (get) Token: 0x0602025F RID: 131679 RVA: 0x00475750 File Offset: 0x00473950
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020260 RID: 131680 RVA: 0x0047575D File Offset: 0x0047395D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020261 RID: 131681 RVA: 0x00475764 File Offset: 0x00473964
		public static ICheckVehicleTriggerAngleCondition GetRootAsICheckVehicleTriggerAngleCondition(ByteBuffer _bb)
		{
			return ICheckVehicleTriggerAngleCondition.GetRootAsICheckVehicleTriggerAngleCondition(_bb, default(ICheckVehicleTriggerAngleCondition));
		}

		// Token: 0x06020262 RID: 131682 RVA: 0x00475780 File Offset: 0x00473980
		public static ICheckVehicleTriggerAngleCondition GetRootAsICheckVehicleTriggerAngleCondition(ByteBuffer _bb, ICheckVehicleTriggerAngleCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020263 RID: 131683 RVA: 0x0047579D File Offset: 0x0047399D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020264 RID: 131684 RVA: 0x004757AC File Offset: 0x004739AC
		public ICheckVehicleTriggerAngleCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009332 RID: 37682
		// (get) Token: 0x06020265 RID: 131685 RVA: 0x004757BC File Offset: 0x004739BC
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

		// Token: 0x17009333 RID: 37683
		// (get) Token: 0x06020266 RID: 131686 RVA: 0x004757F8 File Offset: 0x004739F8
		public float HorizontalAngle
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009334 RID: 37684
		// (get) Token: 0x06020267 RID: 131687 RVA: 0x00475838 File Offset: 0x00473A38
		public float VerticalAngle
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

		// Token: 0x06020268 RID: 131688 RVA: 0x00475878 File Offset: 0x00473A78
		public static Offset<ICheckVehicleTriggerAngleCondition> CreateICheckVehicleTriggerAngleCondition(FlatBufferBuilder builder, EVehicleConditionType Type = EVehicleConditionType.UsingVehicle, float HorizontalAngle = 0f, float VerticalAngle = 0f)
		{
			builder.StartTable(3);
			ICheckVehicleTriggerAngleCondition.AddVerticalAngle(builder, VerticalAngle);
			ICheckVehicleTriggerAngleCondition.AddHorizontalAngle(builder, HorizontalAngle);
			ICheckVehicleTriggerAngleCondition.AddType(builder, Type);
			return ICheckVehicleTriggerAngleCondition.EndICheckVehicleTriggerAngleCondition(builder);
		}

		// Token: 0x06020269 RID: 131689 RVA: 0x0047589C File Offset: 0x00473A9C
		public static void StartICheckVehicleTriggerAngleCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602026A RID: 131690 RVA: 0x004758A5 File Offset: 0x00473AA5
		public static void AddType(FlatBufferBuilder builder, EVehicleConditionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602026B RID: 131691 RVA: 0x004758B0 File Offset: 0x00473AB0
		public static void AddHorizontalAngle(FlatBufferBuilder builder, float horizontalAngle)
		{
			builder.AddFloat(1, horizontalAngle, 0.0);
		}

		// Token: 0x0602026C RID: 131692 RVA: 0x004758C3 File Offset: 0x00473AC3
		public static void AddVerticalAngle(FlatBufferBuilder builder, float verticalAngle)
		{
			builder.AddFloat(2, verticalAngle, 0.0);
		}

		// Token: 0x0602026D RID: 131693 RVA: 0x004758D6 File Offset: 0x00473AD6
		public static Offset<ICheckVehicleTriggerAngleCondition> EndICheckVehicleTriggerAngleCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICheckVehicleTriggerAngleCondition>(builder.EndTable());
		}

		// Token: 0x0602026E RID: 131694 RVA: 0x004758E4 File Offset: 0x00473AE4
		public ICheckVehicleTriggerAngleConditionT UnPack()
		{
			ICheckVehicleTriggerAngleConditionT checkVehicleTriggerAngleConditionT = new ICheckVehicleTriggerAngleConditionT();
			this.UnPackTo(checkVehicleTriggerAngleConditionT);
			return checkVehicleTriggerAngleConditionT;
		}

		// Token: 0x0602026F RID: 131695 RVA: 0x004758FF File Offset: 0x00473AFF
		public void UnPackTo(ICheckVehicleTriggerAngleConditionT _o)
		{
			_o.Type = this.Type;
			_o.HorizontalAngle = this.HorizontalAngle;
			_o.VerticalAngle = this.VerticalAngle;
		}

		// Token: 0x06020270 RID: 131696 RVA: 0x00475928 File Offset: 0x00473B28
		public static Offset<ICheckVehicleTriggerAngleCondition> Pack(FlatBufferBuilder builder, ICheckVehicleTriggerAngleConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckVehicleTriggerAngleCondition>);
			}
			return ICheckVehicleTriggerAngleCondition.CreateICheckVehicleTriggerAngleCondition(builder, _o.Type, _o.HorizontalAngle, _o.VerticalAngle);
		}

		// Token: 0x0400DF38 RID: 57144
		private Table __p;
	}
}
