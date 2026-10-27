using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D58 RID: 23896
	public struct IBvbPlayerTurnStartData : IFlatbufferObject
	{
		// Token: 0x1700B30E RID: 45838
		// (get) Token: 0x06028E20 RID: 167456 RVA: 0x0059E1D5 File Offset: 0x0059C3D5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028E21 RID: 167457 RVA: 0x0059E1E2 File Offset: 0x0059C3E2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028E22 RID: 167458 RVA: 0x0059E1EC File Offset: 0x0059C3EC
		public static IBvbPlayerTurnStartData GetRootAsIBvbPlayerTurnStartData(ByteBuffer _bb)
		{
			return IBvbPlayerTurnStartData.GetRootAsIBvbPlayerTurnStartData(_bb, default(IBvbPlayerTurnStartData));
		}

		// Token: 0x06028E23 RID: 167459 RVA: 0x0059E208 File Offset: 0x0059C408
		public static IBvbPlayerTurnStartData GetRootAsIBvbPlayerTurnStartData(ByteBuffer _bb, IBvbPlayerTurnStartData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028E24 RID: 167460 RVA: 0x0059E225 File Offset: 0x0059C425
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028E25 RID: 167461 RVA: 0x0059E234 File Offset: 0x0059C434
		public IBvbPlayerTurnStartData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B30F RID: 45839
		// (get) Token: 0x06028E26 RID: 167462 RVA: 0x0059E244 File Offset: 0x0059C444
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

		// Token: 0x06028E27 RID: 167463 RVA: 0x0059E280 File Offset: 0x0059C480
		public static Offset<IBvbPlayerTurnStartData> CreateIBvbPlayerTurnStartData(FlatBufferBuilder builder, EBvbEventName Type = EBvbEventName.AIEvolution)
		{
			builder.StartTable(1);
			IBvbPlayerTurnStartData.AddType(builder, Type);
			return IBvbPlayerTurnStartData.EndIBvbPlayerTurnStartData(builder);
		}

		// Token: 0x06028E28 RID: 167464 RVA: 0x0059E296 File Offset: 0x0059C496
		public static void StartIBvbPlayerTurnStartData(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06028E29 RID: 167465 RVA: 0x0059E29F File Offset: 0x0059C49F
		public static void AddType(FlatBufferBuilder builder, EBvbEventName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06028E2A RID: 167466 RVA: 0x0059E2AA File Offset: 0x0059C4AA
		public static Offset<IBvbPlayerTurnStartData> EndIBvbPlayerTurnStartData(FlatBufferBuilder builder)
		{
			return new Offset<IBvbPlayerTurnStartData>(builder.EndTable());
		}

		// Token: 0x06028E2B RID: 167467 RVA: 0x0059E2B8 File Offset: 0x0059C4B8
		public IBvbPlayerTurnStartDataT UnPack()
		{
			IBvbPlayerTurnStartDataT bvbPlayerTurnStartDataT = new IBvbPlayerTurnStartDataT();
			this.UnPackTo(bvbPlayerTurnStartDataT);
			return bvbPlayerTurnStartDataT;
		}

		// Token: 0x06028E2C RID: 167468 RVA: 0x0059E2D3 File Offset: 0x0059C4D3
		public void UnPackTo(IBvbPlayerTurnStartDataT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06028E2D RID: 167469 RVA: 0x0059E2E4 File Offset: 0x0059C4E4
		public static Offset<IBvbPlayerTurnStartData> Pack(FlatBufferBuilder builder, IBvbPlayerTurnStartDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbPlayerTurnStartData>);
			}
			return IBvbPlayerTurnStartData.CreateIBvbPlayerTurnStartData(builder, _o.Type);
		}

		// Token: 0x0400F723 RID: 63267
		private Table __p;
	}
}
