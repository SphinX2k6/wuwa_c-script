using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D61 RID: 23905
	public struct IBvbSelectCardsEndData : IFlatbufferObject
	{
		// Token: 0x1700B316 RID: 45846
		// (get) Token: 0x06028E52 RID: 167506 RVA: 0x0059E610 File Offset: 0x0059C810
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028E53 RID: 167507 RVA: 0x0059E61D File Offset: 0x0059C81D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028E54 RID: 167508 RVA: 0x0059E624 File Offset: 0x0059C824
		public static IBvbSelectCardsEndData GetRootAsIBvbSelectCardsEndData(ByteBuffer _bb)
		{
			return IBvbSelectCardsEndData.GetRootAsIBvbSelectCardsEndData(_bb, default(IBvbSelectCardsEndData));
		}

		// Token: 0x06028E55 RID: 167509 RVA: 0x0059E640 File Offset: 0x0059C840
		public static IBvbSelectCardsEndData GetRootAsIBvbSelectCardsEndData(ByteBuffer _bb, IBvbSelectCardsEndData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028E56 RID: 167510 RVA: 0x0059E65D File Offset: 0x0059C85D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028E57 RID: 167511 RVA: 0x0059E66C File Offset: 0x0059C86C
		public IBvbSelectCardsEndData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B317 RID: 45847
		// (get) Token: 0x06028E58 RID: 167512 RVA: 0x0059E67C File Offset: 0x0059C87C
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

		// Token: 0x06028E59 RID: 167513 RVA: 0x0059E6B8 File Offset: 0x0059C8B8
		public static Offset<IBvbSelectCardsEndData> CreateIBvbSelectCardsEndData(FlatBufferBuilder builder, EBvbEventName Type = EBvbEventName.AIEvolution)
		{
			builder.StartTable(1);
			IBvbSelectCardsEndData.AddType(builder, Type);
			return IBvbSelectCardsEndData.EndIBvbSelectCardsEndData(builder);
		}

		// Token: 0x06028E5A RID: 167514 RVA: 0x0059E6CE File Offset: 0x0059C8CE
		public static void StartIBvbSelectCardsEndData(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06028E5B RID: 167515 RVA: 0x0059E6D7 File Offset: 0x0059C8D7
		public static void AddType(FlatBufferBuilder builder, EBvbEventName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06028E5C RID: 167516 RVA: 0x0059E6E2 File Offset: 0x0059C8E2
		public static Offset<IBvbSelectCardsEndData> EndIBvbSelectCardsEndData(FlatBufferBuilder builder)
		{
			return new Offset<IBvbSelectCardsEndData>(builder.EndTable());
		}

		// Token: 0x06028E5D RID: 167517 RVA: 0x0059E6F0 File Offset: 0x0059C8F0
		public IBvbSelectCardsEndDataT UnPack()
		{
			IBvbSelectCardsEndDataT bvbSelectCardsEndDataT = new IBvbSelectCardsEndDataT();
			this.UnPackTo(bvbSelectCardsEndDataT);
			return bvbSelectCardsEndDataT;
		}

		// Token: 0x06028E5E RID: 167518 RVA: 0x0059E70B File Offset: 0x0059C90B
		public void UnPackTo(IBvbSelectCardsEndDataT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06028E5F RID: 167519 RVA: 0x0059E71C File Offset: 0x0059C91C
		public static Offset<IBvbSelectCardsEndData> Pack(FlatBufferBuilder builder, IBvbSelectCardsEndDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbSelectCardsEndData>);
			}
			return IBvbSelectCardsEndData.CreateIBvbSelectCardsEndData(builder, _o.Type);
		}

		// Token: 0x0400F72E RID: 63278
		private Table __p;
	}
}
