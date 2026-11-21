using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005208 RID: 21000
	public struct IVehicleCondition : IFlatbufferObject
	{
		// Token: 0x1700964A RID: 38474
		// (get) Token: 0x06021129 RID: 135465 RVA: 0x00491C3D File Offset: 0x0048FE3D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602112A RID: 135466 RVA: 0x00491C4A File Offset: 0x0048FE4A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602112B RID: 135467 RVA: 0x00491C54 File Offset: 0x0048FE54
		public static IVehicleCondition GetRootAsIVehicleCondition(ByteBuffer _bb)
		{
			return IVehicleCondition.GetRootAsIVehicleCondition(_bb, default(IVehicleCondition));
		}

		// Token: 0x0602112C RID: 135468 RVA: 0x00491C70 File Offset: 0x0048FE70
		public static IVehicleCondition GetRootAsIVehicleCondition(ByteBuffer _bb, IVehicleCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602112D RID: 135469 RVA: 0x00491C8D File Offset: 0x0048FE8D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602112E RID: 135470 RVA: 0x00491C9C File Offset: 0x0048FE9C
		public IVehicleCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700964B RID: 38475
		// (get) Token: 0x0602112F RID: 135471 RVA: 0x00491CAC File Offset: 0x0048FEAC
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

		// Token: 0x06021130 RID: 135472 RVA: 0x00491CE8 File Offset: 0x0048FEE8
		public static Offset<IVehicleCondition> CreateIVehicleCondition(FlatBufferBuilder builder, EVehicleConditionType Type = EVehicleConditionType.UsingVehicle)
		{
			builder.StartTable(1);
			IVehicleCondition.AddType(builder, Type);
			return IVehicleCondition.EndIVehicleCondition(builder);
		}

		// Token: 0x06021131 RID: 135473 RVA: 0x00491CFE File Offset: 0x0048FEFE
		public static void StartIVehicleCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06021132 RID: 135474 RVA: 0x00491D07 File Offset: 0x0048FF07
		public static void AddType(FlatBufferBuilder builder, EVehicleConditionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06021133 RID: 135475 RVA: 0x00491D12 File Offset: 0x0048FF12
		public static Offset<IVehicleCondition> EndIVehicleCondition(FlatBufferBuilder builder)
		{
			return new Offset<IVehicleCondition>(builder.EndTable());
		}

		// Token: 0x06021134 RID: 135476 RVA: 0x00491D20 File Offset: 0x0048FF20
		public IVehicleConditionT UnPack()
		{
			IVehicleConditionT vehicleConditionT = new IVehicleConditionT();
			this.UnPackTo(vehicleConditionT);
			return vehicleConditionT;
		}

		// Token: 0x06021135 RID: 135477 RVA: 0x00491D3B File Offset: 0x0048FF3B
		public void UnPackTo(IVehicleConditionT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06021136 RID: 135478 RVA: 0x00491D4C File Offset: 0x0048FF4C
		public static Offset<IVehicleCondition> Pack(FlatBufferBuilder builder, IVehicleConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVehicleCondition>);
			}
			return IVehicleCondition.CreateIVehicleCondition(builder, _o.Type);
		}

		// Token: 0x0400E215 RID: 57877
		private Table __p;
	}
}
