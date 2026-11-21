using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054F6 RID: 21750
	public struct ICircuitConnectThreeRings : IFlatbufferObject
	{
		// Token: 0x17009B59 RID: 39769
		// (get) Token: 0x06022579 RID: 140665 RVA: 0x004BBA6A File Offset: 0x004B9C6A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602257A RID: 140666 RVA: 0x004BBA77 File Offset: 0x004B9C77
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602257B RID: 140667 RVA: 0x004BBA80 File Offset: 0x004B9C80
		public static ICircuitConnectThreeRings GetRootAsICircuitConnectThreeRings(ByteBuffer _bb)
		{
			return ICircuitConnectThreeRings.GetRootAsICircuitConnectThreeRings(_bb, default(ICircuitConnectThreeRings));
		}

		// Token: 0x0602257C RID: 140668 RVA: 0x004BBA9C File Offset: 0x004B9C9C
		public static ICircuitConnectThreeRings GetRootAsICircuitConnectThreeRings(ByteBuffer _bb, ICircuitConnectThreeRings obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602257D RID: 140669 RVA: 0x004BBAB9 File Offset: 0x004B9CB9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602257E RID: 140670 RVA: 0x004BBAC8 File Offset: 0x004B9CC8
		public ICircuitConnectThreeRings __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009B5A RID: 39770
		// (get) Token: 0x0602257F RID: 140671 RVA: 0x004BBAD8 File Offset: 0x004B9CD8
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

		// Token: 0x06022580 RID: 140672 RVA: 0x004BBB14 File Offset: 0x004B9D14
		public static Offset<ICircuitConnectThreeRings> CreateICircuitConnectThreeRings(FlatBufferBuilder builder, ECircuitConnectMode Type = ECircuitConnectMode.TwoRings)
		{
			builder.StartTable(1);
			ICircuitConnectThreeRings.AddType(builder, Type);
			return ICircuitConnectThreeRings.EndICircuitConnectThreeRings(builder);
		}

		// Token: 0x06022581 RID: 140673 RVA: 0x004BBB2A File Offset: 0x004B9D2A
		public static void StartICircuitConnectThreeRings(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06022582 RID: 140674 RVA: 0x004BBB33 File Offset: 0x004B9D33
		public static void AddType(FlatBufferBuilder builder, ECircuitConnectMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06022583 RID: 140675 RVA: 0x004BBB3E File Offset: 0x004B9D3E
		public static Offset<ICircuitConnectThreeRings> EndICircuitConnectThreeRings(FlatBufferBuilder builder)
		{
			return new Offset<ICircuitConnectThreeRings>(builder.EndTable());
		}

		// Token: 0x06022584 RID: 140676 RVA: 0x004BBB4C File Offset: 0x004B9D4C
		public ICircuitConnectThreeRingsT UnPack()
		{
			ICircuitConnectThreeRingsT circuitConnectThreeRingsT = new ICircuitConnectThreeRingsT();
			this.UnPackTo(circuitConnectThreeRingsT);
			return circuitConnectThreeRingsT;
		}

		// Token: 0x06022585 RID: 140677 RVA: 0x004BBB67 File Offset: 0x004B9D67
		public void UnPackTo(ICircuitConnectThreeRingsT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06022586 RID: 140678 RVA: 0x004BBB78 File Offset: 0x004B9D78
		public static Offset<ICircuitConnectThreeRings> Pack(FlatBufferBuilder builder, ICircuitConnectThreeRingsT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICircuitConnectThreeRings>);
			}
			return ICircuitConnectThreeRings.CreateICircuitConnectThreeRings(builder, _o.Type);
		}

		// Token: 0x0400EA54 RID: 59988
		private Table __p;
	}
}
