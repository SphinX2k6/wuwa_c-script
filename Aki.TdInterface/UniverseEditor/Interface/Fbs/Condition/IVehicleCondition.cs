using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004D0C RID: 19724
	public struct IVehicleCondition : IFlatbufferObject
	{
		// Token: 0x17008F11 RID: 36625
		// (get) Token: 0x0601F4E4 RID: 128228 RVA: 0x0045DCED File Offset: 0x0045BEED
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F4E5 RID: 128229 RVA: 0x0045DCFA File Offset: 0x0045BEFA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F4E6 RID: 128230 RVA: 0x0045DD04 File Offset: 0x0045BF04
		public static IVehicleCondition GetRootAsIVehicleCondition(ByteBuffer _bb)
		{
			return IVehicleCondition.GetRootAsIVehicleCondition(_bb, default(IVehicleCondition));
		}

		// Token: 0x0601F4E7 RID: 128231 RVA: 0x0045DD20 File Offset: 0x0045BF20
		public static IVehicleCondition GetRootAsIVehicleCondition(ByteBuffer _bb, IVehicleCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F4E8 RID: 128232 RVA: 0x0045DD3D File Offset: 0x0045BF3D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F4E9 RID: 128233 RVA: 0x0045DD4C File Offset: 0x0045BF4C
		public IVehicleCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008F12 RID: 36626
		// (get) Token: 0x0601F4EA RID: 128234 RVA: 0x0045DD5C File Offset: 0x0045BF5C
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

		// Token: 0x0601F4EB RID: 128235 RVA: 0x0045DD98 File Offset: 0x0045BF98
		public static Offset<IVehicleCondition> CreateIVehicleCondition(FlatBufferBuilder builder, EVehicleConditionType Type = EVehicleConditionType.UsingVehicle)
		{
			builder.StartTable(1);
			IVehicleCondition.AddType(builder, Type);
			return IVehicleCondition.EndIVehicleCondition(builder);
		}

		// Token: 0x0601F4EC RID: 128236 RVA: 0x0045DDAE File Offset: 0x0045BFAE
		public static void StartIVehicleCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601F4ED RID: 128237 RVA: 0x0045DDB7 File Offset: 0x0045BFB7
		public static void AddType(FlatBufferBuilder builder, EVehicleConditionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F4EE RID: 128238 RVA: 0x0045DDC2 File Offset: 0x0045BFC2
		public static Offset<IVehicleCondition> EndIVehicleCondition(FlatBufferBuilder builder)
		{
			return new Offset<IVehicleCondition>(builder.EndTable());
		}

		// Token: 0x0601F4EF RID: 128239 RVA: 0x0045DDD0 File Offset: 0x0045BFD0
		public IVehicleConditionT UnPack()
		{
			IVehicleConditionT vehicleConditionT = new IVehicleConditionT();
			this.UnPackTo(vehicleConditionT);
			return vehicleConditionT;
		}

		// Token: 0x0601F4F0 RID: 128240 RVA: 0x0045DDEB File Offset: 0x0045BFEB
		public void UnPackTo(IVehicleConditionT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601F4F1 RID: 128241 RVA: 0x0045DDFC File Offset: 0x0045BFFC
		public static Offset<IVehicleCondition> Pack(FlatBufferBuilder builder, IVehicleConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVehicleCondition>);
			}
			return IVehicleCondition.CreateIVehicleCondition(builder, _o.Type);
		}

		// Token: 0x0400D6E8 RID: 55016
		private Table __p;
	}
}
