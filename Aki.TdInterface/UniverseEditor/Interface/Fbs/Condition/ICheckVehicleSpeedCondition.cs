using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005052 RID: 20562
	public struct ICheckVehicleSpeedCondition : IFlatbufferObject
	{
		// Token: 0x1700932A RID: 37674
		// (get) Token: 0x06020245 RID: 131653 RVA: 0x004754B0 File Offset: 0x004736B0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020246 RID: 131654 RVA: 0x004754BD File Offset: 0x004736BD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020247 RID: 131655 RVA: 0x004754C4 File Offset: 0x004736C4
		public static ICheckVehicleSpeedCondition GetRootAsICheckVehicleSpeedCondition(ByteBuffer _bb)
		{
			return ICheckVehicleSpeedCondition.GetRootAsICheckVehicleSpeedCondition(_bb, default(ICheckVehicleSpeedCondition));
		}

		// Token: 0x06020248 RID: 131656 RVA: 0x004754E0 File Offset: 0x004736E0
		public static ICheckVehicleSpeedCondition GetRootAsICheckVehicleSpeedCondition(ByteBuffer _bb, ICheckVehicleSpeedCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020249 RID: 131657 RVA: 0x004754FD File Offset: 0x004736FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602024A RID: 131658 RVA: 0x0047550C File Offset: 0x0047370C
		public ICheckVehicleSpeedCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700932B RID: 37675
		// (get) Token: 0x0602024B RID: 131659 RVA: 0x0047551C File Offset: 0x0047371C
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

		// Token: 0x1700932C RID: 37676
		// (get) Token: 0x0602024C RID: 131660 RVA: 0x00475558 File Offset: 0x00473758
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

		// Token: 0x1700932D RID: 37677
		// (get) Token: 0x0602024D RID: 131661 RVA: 0x00475594 File Offset: 0x00473794
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

		// Token: 0x0602024E RID: 131662 RVA: 0x004755D4 File Offset: 0x004737D4
		public static Offset<ICheckVehicleSpeedCondition> CreateICheckVehicleSpeedCondition(FlatBufferBuilder builder, EVehicleConditionType Type = EVehicleConditionType.UsingVehicle, ECompare CompareType = ECompare.Eq, float Speed = 0f)
		{
			builder.StartTable(3);
			ICheckVehicleSpeedCondition.AddSpeed(builder, Speed);
			ICheckVehicleSpeedCondition.AddCompareType(builder, CompareType);
			ICheckVehicleSpeedCondition.AddType(builder, Type);
			return ICheckVehicleSpeedCondition.EndICheckVehicleSpeedCondition(builder);
		}

		// Token: 0x0602024F RID: 131663 RVA: 0x004755F8 File Offset: 0x004737F8
		public static void StartICheckVehicleSpeedCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06020250 RID: 131664 RVA: 0x00475601 File Offset: 0x00473801
		public static void AddType(FlatBufferBuilder builder, EVehicleConditionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020251 RID: 131665 RVA: 0x0047560C File Offset: 0x0047380C
		public static void AddCompareType(FlatBufferBuilder builder, ECompare compareType)
		{
			builder.AddByte(1, (byte)compareType, 0);
		}

		// Token: 0x06020252 RID: 131666 RVA: 0x00475617 File Offset: 0x00473817
		public static void AddSpeed(FlatBufferBuilder builder, float speed)
		{
			builder.AddFloat(2, speed, 0.0);
		}

		// Token: 0x06020253 RID: 131667 RVA: 0x0047562A File Offset: 0x0047382A
		public static Offset<ICheckVehicleSpeedCondition> EndICheckVehicleSpeedCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICheckVehicleSpeedCondition>(builder.EndTable());
		}

		// Token: 0x06020254 RID: 131668 RVA: 0x00475638 File Offset: 0x00473838
		public ICheckVehicleSpeedConditionT UnPack()
		{
			ICheckVehicleSpeedConditionT checkVehicleSpeedConditionT = new ICheckVehicleSpeedConditionT();
			this.UnPackTo(checkVehicleSpeedConditionT);
			return checkVehicleSpeedConditionT;
		}

		// Token: 0x06020255 RID: 131669 RVA: 0x00475653 File Offset: 0x00473853
		public void UnPackTo(ICheckVehicleSpeedConditionT _o)
		{
			_o.Type = this.Type;
			_o.CompareType = this.CompareType;
			_o.Speed = this.Speed;
		}

		// Token: 0x06020256 RID: 131670 RVA: 0x0047567C File Offset: 0x0047387C
		public static Offset<ICheckVehicleSpeedCondition> Pack(FlatBufferBuilder builder, ICheckVehicleSpeedConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckVehicleSpeedCondition>);
			}
			return ICheckVehicleSpeedCondition.CreateICheckVehicleSpeedCondition(builder, _o.Type, _o.CompareType, _o.Speed);
		}

		// Token: 0x0400DF34 RID: 57140
		private Table __p;
	}
}
