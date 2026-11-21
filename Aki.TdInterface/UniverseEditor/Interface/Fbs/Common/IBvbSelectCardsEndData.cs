using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006398 RID: 25496
	public struct IBvbSelectCardsEndData : IFlatbufferObject
	{
		// Token: 0x1700BC77 RID: 48247
		// (get) Token: 0x0602B4BC RID: 177340 RVA: 0x005E7080 File Offset: 0x005E5280
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B4BD RID: 177341 RVA: 0x005E708D File Offset: 0x005E528D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B4BE RID: 177342 RVA: 0x005E7094 File Offset: 0x005E5294
		public static IBvbSelectCardsEndData GetRootAsIBvbSelectCardsEndData(ByteBuffer _bb)
		{
			return IBvbSelectCardsEndData.GetRootAsIBvbSelectCardsEndData(_bb, default(IBvbSelectCardsEndData));
		}

		// Token: 0x0602B4BF RID: 177343 RVA: 0x005E70B0 File Offset: 0x005E52B0
		public static IBvbSelectCardsEndData GetRootAsIBvbSelectCardsEndData(ByteBuffer _bb, IBvbSelectCardsEndData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B4C0 RID: 177344 RVA: 0x005E70CD File Offset: 0x005E52CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B4C1 RID: 177345 RVA: 0x005E70DC File Offset: 0x005E52DC
		public IBvbSelectCardsEndData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BC78 RID: 48248
		// (get) Token: 0x0602B4C2 RID: 177346 RVA: 0x005E70EC File Offset: 0x005E52EC
		public EBvbEventName Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBvbEventName.AIEvolution;
				}
				return (EBvbEventName)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602B4C3 RID: 177347 RVA: 0x005E7128 File Offset: 0x005E5328
		public static Offset<IBvbSelectCardsEndData> CreateIBvbSelectCardsEndData(FlatBufferBuilder builder, EBvbEventName Type = EBvbEventName.AIEvolution)
		{
			builder.StartTable(1);
			IBvbSelectCardsEndData.AddType(builder, Type);
			return IBvbSelectCardsEndData.EndIBvbSelectCardsEndData(builder);
		}

		// Token: 0x0602B4C4 RID: 177348 RVA: 0x005E713E File Offset: 0x005E533E
		public static void StartIBvbSelectCardsEndData(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602B4C5 RID: 177349 RVA: 0x005E7147 File Offset: 0x005E5347
		public static void AddType(FlatBufferBuilder builder, EBvbEventName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B4C6 RID: 177350 RVA: 0x005E7152 File Offset: 0x005E5352
		public static Offset<IBvbSelectCardsEndData> EndIBvbSelectCardsEndData(FlatBufferBuilder builder)
		{
			return new Offset<IBvbSelectCardsEndData>(builder.EndTable());
		}

		// Token: 0x0602B4C7 RID: 177351 RVA: 0x005E7160 File Offset: 0x005E5360
		public IBvbSelectCardsEndDataT UnPack()
		{
			IBvbSelectCardsEndDataT bvbSelectCardsEndDataT = new IBvbSelectCardsEndDataT();
			this.UnPackTo(bvbSelectCardsEndDataT);
			return bvbSelectCardsEndDataT;
		}

		// Token: 0x0602B4C8 RID: 177352 RVA: 0x005E717B File Offset: 0x005E537B
		public void UnPackTo(IBvbSelectCardsEndDataT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602B4C9 RID: 177353 RVA: 0x005E718C File Offset: 0x005E538C
		public static Offset<IBvbSelectCardsEndData> Pack(FlatBufferBuilder builder, IBvbSelectCardsEndDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbSelectCardsEndData>);
			}
			return IBvbSelectCardsEndData.CreateIBvbSelectCardsEndData(builder, _o.Type);
		}

		// Token: 0x04010480 RID: 66688
		private Table __p;
	}
}
