using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A6F RID: 14959
	public struct IBvbNpcCurEnergy : IFlatbufferObject
	{
		// Token: 0x17006681 RID: 26241
		// (get) Token: 0x06014475 RID: 83061 RVA: 0x002F6299 File Offset: 0x002F4499
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06014476 RID: 83062 RVA: 0x002F62A6 File Offset: 0x002F44A6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06014477 RID: 83063 RVA: 0x002F62B0 File Offset: 0x002F44B0
		public static IBvbNpcCurEnergy GetRootAsIBvbNpcCurEnergy(ByteBuffer _bb)
		{
			return IBvbNpcCurEnergy.GetRootAsIBvbNpcCurEnergy(_bb, default(IBvbNpcCurEnergy));
		}

		// Token: 0x06014478 RID: 83064 RVA: 0x002F62CC File Offset: 0x002F44CC
		public static IBvbNpcCurEnergy GetRootAsIBvbNpcCurEnergy(ByteBuffer _bb, IBvbNpcCurEnergy obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06014479 RID: 83065 RVA: 0x002F62E9 File Offset: 0x002F44E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601447A RID: 83066 RVA: 0x002F62F8 File Offset: 0x002F44F8
		public IBvbNpcCurEnergy __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006682 RID: 26242
		// (get) Token: 0x0601447B RID: 83067 RVA: 0x002F6308 File Offset: 0x002F4508
		public ESystemVarName Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESystemVarName.CommonHotFixVar;
				}
				return (ESystemVarName)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601447C RID: 83068 RVA: 0x002F6344 File Offset: 0x002F4544
		public static Offset<IBvbNpcCurEnergy> CreateIBvbNpcCurEnergy(FlatBufferBuilder builder, ESystemVarName Type = ESystemVarName.CommonHotFixVar)
		{
			builder.StartTable(1);
			IBvbNpcCurEnergy.AddType(builder, Type);
			return IBvbNpcCurEnergy.EndIBvbNpcCurEnergy(builder);
		}

		// Token: 0x0601447D RID: 83069 RVA: 0x002F635A File Offset: 0x002F455A
		public static void StartIBvbNpcCurEnergy(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601447E RID: 83070 RVA: 0x002F6363 File Offset: 0x002F4563
		public static void AddType(FlatBufferBuilder builder, ESystemVarName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601447F RID: 83071 RVA: 0x002F636E File Offset: 0x002F456E
		public static Offset<IBvbNpcCurEnergy> EndIBvbNpcCurEnergy(FlatBufferBuilder builder)
		{
			return new Offset<IBvbNpcCurEnergy>(builder.EndTable());
		}

		// Token: 0x06014480 RID: 83072 RVA: 0x002F637C File Offset: 0x002F457C
		public IBvbNpcCurEnergyT UnPack()
		{
			IBvbNpcCurEnergyT bvbNpcCurEnergyT = new IBvbNpcCurEnergyT();
			this.UnPackTo(bvbNpcCurEnergyT);
			return bvbNpcCurEnergyT;
		}

		// Token: 0x06014481 RID: 83073 RVA: 0x002F6397 File Offset: 0x002F4597
		public void UnPackTo(IBvbNpcCurEnergyT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06014482 RID: 83074 RVA: 0x002F63A8 File Offset: 0x002F45A8
		public static Offset<IBvbNpcCurEnergy> Pack(FlatBufferBuilder builder, IBvbNpcCurEnergyT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbNpcCurEnergy>);
			}
			return IBvbNpcCurEnergy.CreateIBvbNpcCurEnergy(builder, _o.Type);
		}

		// Token: 0x0400AEF0 RID: 44784
		private Table __p;
	}
}
