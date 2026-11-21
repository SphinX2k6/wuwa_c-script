using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C9C RID: 23708
	public struct IPasserbyNpcNearSplineStartFirstExitOrder : IFlatbufferObject
	{
		// Token: 0x1700AE23 RID: 44579
		// (get) Token: 0x06027537 RID: 161079 RVA: 0x005624F4 File Offset: 0x005606F4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027538 RID: 161080 RVA: 0x00562501 File Offset: 0x00560701
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027539 RID: 161081 RVA: 0x00562508 File Offset: 0x00560708
		public static IPasserbyNpcNearSplineStartFirstExitOrder GetRootAsIPasserbyNpcNearSplineStartFirstExitOrder(ByteBuffer _bb)
		{
			return IPasserbyNpcNearSplineStartFirstExitOrder.GetRootAsIPasserbyNpcNearSplineStartFirstExitOrder(_bb, default(IPasserbyNpcNearSplineStartFirstExitOrder));
		}

		// Token: 0x0602753A RID: 161082 RVA: 0x00562524 File Offset: 0x00560724
		public static IPasserbyNpcNearSplineStartFirstExitOrder GetRootAsIPasserbyNpcNearSplineStartFirstExitOrder(ByteBuffer _bb, IPasserbyNpcNearSplineStartFirstExitOrder obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602753B RID: 161083 RVA: 0x00562541 File Offset: 0x00560741
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602753C RID: 161084 RVA: 0x00562550 File Offset: 0x00560750
		public IPasserbyNpcNearSplineStartFirstExitOrder __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AE24 RID: 44580
		// (get) Token: 0x0602753D RID: 161085 RVA: 0x00562560 File Offset: 0x00560760
		public EPasserbyNpcExitOrderType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPasserbyNpcExitOrderType.NearSplineStartFirst;
				}
				return (EPasserbyNpcExitOrderType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602753E RID: 161086 RVA: 0x0056259C File Offset: 0x0056079C
		public static Offset<IPasserbyNpcNearSplineStartFirstExitOrder> CreateIPasserbyNpcNearSplineStartFirstExitOrder(FlatBufferBuilder builder, EPasserbyNpcExitOrderType Type = EPasserbyNpcExitOrderType.NearSplineStartFirst)
		{
			builder.StartTable(1);
			IPasserbyNpcNearSplineStartFirstExitOrder.AddType(builder, Type);
			return IPasserbyNpcNearSplineStartFirstExitOrder.EndIPasserbyNpcNearSplineStartFirstExitOrder(builder);
		}

		// Token: 0x0602753F RID: 161087 RVA: 0x005625B2 File Offset: 0x005607B2
		public static void StartIPasserbyNpcNearSplineStartFirstExitOrder(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06027540 RID: 161088 RVA: 0x005625BB File Offset: 0x005607BB
		public static void AddType(FlatBufferBuilder builder, EPasserbyNpcExitOrderType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06027541 RID: 161089 RVA: 0x005625C6 File Offset: 0x005607C6
		public static Offset<IPasserbyNpcNearSplineStartFirstExitOrder> EndIPasserbyNpcNearSplineStartFirstExitOrder(FlatBufferBuilder builder)
		{
			return new Offset<IPasserbyNpcNearSplineStartFirstExitOrder>(builder.EndTable());
		}

		// Token: 0x06027542 RID: 161090 RVA: 0x005625D4 File Offset: 0x005607D4
		public IPasserbyNpcNearSplineStartFirstExitOrderT UnPack()
		{
			IPasserbyNpcNearSplineStartFirstExitOrderT passerbyNpcNearSplineStartFirstExitOrderT = new IPasserbyNpcNearSplineStartFirstExitOrderT();
			this.UnPackTo(passerbyNpcNearSplineStartFirstExitOrderT);
			return passerbyNpcNearSplineStartFirstExitOrderT;
		}

		// Token: 0x06027543 RID: 161091 RVA: 0x005625EF File Offset: 0x005607EF
		public void UnPackTo(IPasserbyNpcNearSplineStartFirstExitOrderT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06027544 RID: 161092 RVA: 0x00562600 File Offset: 0x00560800
		public static Offset<IPasserbyNpcNearSplineStartFirstExitOrder> Pack(FlatBufferBuilder builder, IPasserbyNpcNearSplineStartFirstExitOrderT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPasserbyNpcNearSplineStartFirstExitOrder>);
			}
			return IPasserbyNpcNearSplineStartFirstExitOrder.CreateIPasserbyNpcNearSplineStartFirstExitOrder(builder, _o.Type);
		}

		// Token: 0x0400F7AD RID: 63405
		private Table __p;
	}
}
