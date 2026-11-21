using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x0200638C RID: 25484
	public struct IBvbPlayerTurnEndData : IFlatbufferObject
	{
		// Token: 0x1700BC6C RID: 48236
		// (get) Token: 0x0602B478 RID: 177272 RVA: 0x005E6ACD File Offset: 0x005E4CCD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B479 RID: 177273 RVA: 0x005E6ADA File Offset: 0x005E4CDA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B47A RID: 177274 RVA: 0x005E6AE4 File Offset: 0x005E4CE4
		public static IBvbPlayerTurnEndData GetRootAsIBvbPlayerTurnEndData(ByteBuffer _bb)
		{
			return IBvbPlayerTurnEndData.GetRootAsIBvbPlayerTurnEndData(_bb, default(IBvbPlayerTurnEndData));
		}

		// Token: 0x0602B47B RID: 177275 RVA: 0x005E6B00 File Offset: 0x005E4D00
		public static IBvbPlayerTurnEndData GetRootAsIBvbPlayerTurnEndData(ByteBuffer _bb, IBvbPlayerTurnEndData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B47C RID: 177276 RVA: 0x005E6B1D File Offset: 0x005E4D1D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B47D RID: 177277 RVA: 0x005E6B2C File Offset: 0x005E4D2C
		public IBvbPlayerTurnEndData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BC6D RID: 48237
		// (get) Token: 0x0602B47E RID: 177278 RVA: 0x005E6B3C File Offset: 0x005E4D3C
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

		// Token: 0x0602B47F RID: 177279 RVA: 0x005E6B78 File Offset: 0x005E4D78
		public static Offset<IBvbPlayerTurnEndData> CreateIBvbPlayerTurnEndData(FlatBufferBuilder builder, EBvbEventName Type = EBvbEventName.AIEvolution)
		{
			builder.StartTable(1);
			IBvbPlayerTurnEndData.AddType(builder, Type);
			return IBvbPlayerTurnEndData.EndIBvbPlayerTurnEndData(builder);
		}

		// Token: 0x0602B480 RID: 177280 RVA: 0x005E6B8E File Offset: 0x005E4D8E
		public static void StartIBvbPlayerTurnEndData(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602B481 RID: 177281 RVA: 0x005E6B97 File Offset: 0x005E4D97
		public static void AddType(FlatBufferBuilder builder, EBvbEventName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B482 RID: 177282 RVA: 0x005E6BA2 File Offset: 0x005E4DA2
		public static Offset<IBvbPlayerTurnEndData> EndIBvbPlayerTurnEndData(FlatBufferBuilder builder)
		{
			return new Offset<IBvbPlayerTurnEndData>(builder.EndTable());
		}

		// Token: 0x0602B483 RID: 177283 RVA: 0x005E6BB0 File Offset: 0x005E4DB0
		public IBvbPlayerTurnEndDataT UnPack()
		{
			IBvbPlayerTurnEndDataT bvbPlayerTurnEndDataT = new IBvbPlayerTurnEndDataT();
			this.UnPackTo(bvbPlayerTurnEndDataT);
			return bvbPlayerTurnEndDataT;
		}

		// Token: 0x0602B484 RID: 177284 RVA: 0x005E6BCB File Offset: 0x005E4DCB
		public void UnPackTo(IBvbPlayerTurnEndDataT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602B485 RID: 177285 RVA: 0x005E6BDC File Offset: 0x005E4DDC
		public static Offset<IBvbPlayerTurnEndData> Pack(FlatBufferBuilder builder, IBvbPlayerTurnEndDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbPlayerTurnEndData>);
			}
			return IBvbPlayerTurnEndData.CreateIBvbPlayerTurnEndData(builder, _o.Type);
		}

		// Token: 0x04010473 RID: 66675
		private Table __p;
	}
}
