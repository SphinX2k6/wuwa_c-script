using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B6E RID: 19310
	public struct ICheckVehicleTriggerAngleCondition : IFlatbufferObject
	{
		// Token: 0x17008C21 RID: 35873
		// (get) Token: 0x0601E6D1 RID: 124625 RVA: 0x00442F04 File Offset: 0x00441104
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E6D2 RID: 124626 RVA: 0x00442F11 File Offset: 0x00441111
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E6D3 RID: 124627 RVA: 0x00442F18 File Offset: 0x00441118
		public static ICheckVehicleTriggerAngleCondition GetRootAsICheckVehicleTriggerAngleCondition(ByteBuffer _bb)
		{
			return ICheckVehicleTriggerAngleCondition.GetRootAsICheckVehicleTriggerAngleCondition(_bb, default(ICheckVehicleTriggerAngleCondition));
		}

		// Token: 0x0601E6D4 RID: 124628 RVA: 0x00442F34 File Offset: 0x00441134
		public static ICheckVehicleTriggerAngleCondition GetRootAsICheckVehicleTriggerAngleCondition(ByteBuffer _bb, ICheckVehicleTriggerAngleCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E6D5 RID: 124629 RVA: 0x00442F51 File Offset: 0x00441151
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E6D6 RID: 124630 RVA: 0x00442F60 File Offset: 0x00441160
		public ICheckVehicleTriggerAngleCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008C22 RID: 35874
		// (get) Token: 0x0601E6D7 RID: 124631 RVA: 0x00442F70 File Offset: 0x00441170
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

		// Token: 0x17008C23 RID: 35875
		// (get) Token: 0x0601E6D8 RID: 124632 RVA: 0x00442FAC File Offset: 0x004411AC
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

		// Token: 0x17008C24 RID: 35876
		// (get) Token: 0x0601E6D9 RID: 124633 RVA: 0x00442FEC File Offset: 0x004411EC
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

		// Token: 0x0601E6DA RID: 124634 RVA: 0x0044302C File Offset: 0x0044122C
		public static Offset<ICheckVehicleTriggerAngleCondition> CreateICheckVehicleTriggerAngleCondition(FlatBufferBuilder builder, EVehicleConditionType Type = EVehicleConditionType.UsingVehicle, float HorizontalAngle = 0f, float VerticalAngle = 0f)
		{
			builder.StartTable(3);
			ICheckVehicleTriggerAngleCondition.AddVerticalAngle(builder, VerticalAngle);
			ICheckVehicleTriggerAngleCondition.AddHorizontalAngle(builder, HorizontalAngle);
			ICheckVehicleTriggerAngleCondition.AddType(builder, Type);
			return ICheckVehicleTriggerAngleCondition.EndICheckVehicleTriggerAngleCondition(builder);
		}

		// Token: 0x0601E6DB RID: 124635 RVA: 0x00443050 File Offset: 0x00441250
		public static void StartICheckVehicleTriggerAngleCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601E6DC RID: 124636 RVA: 0x00443059 File Offset: 0x00441259
		public static void AddType(FlatBufferBuilder builder, EVehicleConditionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E6DD RID: 124637 RVA: 0x00443064 File Offset: 0x00441264
		public static void AddHorizontalAngle(FlatBufferBuilder builder, float horizontalAngle)
		{
			builder.AddFloat(1, horizontalAngle, 0.0);
		}

		// Token: 0x0601E6DE RID: 124638 RVA: 0x00443077 File Offset: 0x00441277
		public static void AddVerticalAngle(FlatBufferBuilder builder, float verticalAngle)
		{
			builder.AddFloat(2, verticalAngle, 0.0);
		}

		// Token: 0x0601E6DF RID: 124639 RVA: 0x0044308A File Offset: 0x0044128A
		public static Offset<ICheckVehicleTriggerAngleCondition> EndICheckVehicleTriggerAngleCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICheckVehicleTriggerAngleCondition>(builder.EndTable());
		}

		// Token: 0x0601E6E0 RID: 124640 RVA: 0x00443098 File Offset: 0x00441298
		public ICheckVehicleTriggerAngleConditionT UnPack()
		{
			ICheckVehicleTriggerAngleConditionT checkVehicleTriggerAngleConditionT = new ICheckVehicleTriggerAngleConditionT();
			this.UnPackTo(checkVehicleTriggerAngleConditionT);
			return checkVehicleTriggerAngleConditionT;
		}

		// Token: 0x0601E6E1 RID: 124641 RVA: 0x004430B3 File Offset: 0x004412B3
		public void UnPackTo(ICheckVehicleTriggerAngleConditionT _o)
		{
			_o.Type = this.Type;
			_o.HorizontalAngle = this.HorizontalAngle;
			_o.VerticalAngle = this.VerticalAngle;
		}

		// Token: 0x0601E6E2 RID: 124642 RVA: 0x004430DC File Offset: 0x004412DC
		public static Offset<ICheckVehicleTriggerAngleCondition> Pack(FlatBufferBuilder builder, ICheckVehicleTriggerAngleConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckVehicleTriggerAngleCondition>);
			}
			return ICheckVehicleTriggerAngleCondition.CreateICheckVehicleTriggerAngleCondition(builder, _o.Type, _o.HorizontalAngle, _o.VerticalAngle);
		}

		// Token: 0x0400D438 RID: 54328
		private Table __p;
	}
}
