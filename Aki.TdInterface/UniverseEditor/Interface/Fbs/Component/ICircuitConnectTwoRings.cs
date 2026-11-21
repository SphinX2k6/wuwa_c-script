using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054F9 RID: 21753
	public struct ICircuitConnectTwoRings : IFlatbufferObject
	{
		// Token: 0x17009B5C RID: 39772
		// (get) Token: 0x0602258B RID: 140683 RVA: 0x004BBBE1 File Offset: 0x004B9DE1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602258C RID: 140684 RVA: 0x004BBBEE File Offset: 0x004B9DEE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602258D RID: 140685 RVA: 0x004BBBF8 File Offset: 0x004B9DF8
		public static ICircuitConnectTwoRings GetRootAsICircuitConnectTwoRings(ByteBuffer _bb)
		{
			return ICircuitConnectTwoRings.GetRootAsICircuitConnectTwoRings(_bb, default(ICircuitConnectTwoRings));
		}

		// Token: 0x0602258E RID: 140686 RVA: 0x004BBC14 File Offset: 0x004B9E14
		public static ICircuitConnectTwoRings GetRootAsICircuitConnectTwoRings(ByteBuffer _bb, ICircuitConnectTwoRings obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602258F RID: 140687 RVA: 0x004BBC31 File Offset: 0x004B9E31
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022590 RID: 140688 RVA: 0x004BBC40 File Offset: 0x004B9E40
		public ICircuitConnectTwoRings __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009B5D RID: 39773
		// (get) Token: 0x06022591 RID: 140689 RVA: 0x004BBC50 File Offset: 0x004B9E50
		public ECircuitConnectMode Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECircuitConnectMode.TwoRings;
				}
				return (ECircuitConnectMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06022592 RID: 140690 RVA: 0x004BBC8C File Offset: 0x004B9E8C
		public static Offset<ICircuitConnectTwoRings> CreateICircuitConnectTwoRings(FlatBufferBuilder builder, ECircuitConnectMode Type = ECircuitConnectMode.TwoRings)
		{
			builder.StartTable(1);
			ICircuitConnectTwoRings.AddType(builder, Type);
			return ICircuitConnectTwoRings.EndICircuitConnectTwoRings(builder);
		}

		// Token: 0x06022593 RID: 140691 RVA: 0x004BBCA2 File Offset: 0x004B9EA2
		public static void StartICircuitConnectTwoRings(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06022594 RID: 140692 RVA: 0x004BBCAB File Offset: 0x004B9EAB
		public static void AddType(FlatBufferBuilder builder, ECircuitConnectMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06022595 RID: 140693 RVA: 0x004BBCB6 File Offset: 0x004B9EB6
		public static Offset<ICircuitConnectTwoRings> EndICircuitConnectTwoRings(FlatBufferBuilder builder)
		{
			return new Offset<ICircuitConnectTwoRings>(builder.EndTable());
		}

		// Token: 0x06022596 RID: 140694 RVA: 0x004BBCC4 File Offset: 0x004B9EC4
		public ICircuitConnectTwoRingsT UnPack()
		{
			ICircuitConnectTwoRingsT circuitConnectTwoRingsT = new ICircuitConnectTwoRingsT();
			this.UnPackTo(circuitConnectTwoRingsT);
			return circuitConnectTwoRingsT;
		}

		// Token: 0x06022597 RID: 140695 RVA: 0x004BBCDF File Offset: 0x004B9EDF
		public void UnPackTo(ICircuitConnectTwoRingsT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06022598 RID: 140696 RVA: 0x004BBCF0 File Offset: 0x004B9EF0
		public static Offset<ICircuitConnectTwoRings> Pack(FlatBufferBuilder builder, ICircuitConnectTwoRingsT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICircuitConnectTwoRings>);
			}
			return ICircuitConnectTwoRings.CreateICircuitConnectTwoRings(builder, _o.Type);
		}

		// Token: 0x0400EA56 RID: 59990
		private Table __p;
	}
}
