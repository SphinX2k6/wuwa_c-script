using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020064B8 RID: 25784
	public struct TCsvOutAreaBorderData : IFlatbufferObject
	{
		// Token: 0x1700BE2E RID: 48686
		// (get) Token: 0x0602BD60 RID: 179552 RVA: 0x005F62CC File Offset: 0x005F44CC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BD61 RID: 179553 RVA: 0x005F62D9 File Offset: 0x005F44D9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BD62 RID: 179554 RVA: 0x005F62E0 File Offset: 0x005F44E0
		public static TCsvOutAreaBorderData GetRootAsTCsvOutAreaBorderData(ByteBuffer _bb)
		{
			return TCsvOutAreaBorderData.GetRootAsTCsvOutAreaBorderData(_bb, default(TCsvOutAreaBorderData));
		}

		// Token: 0x0602BD63 RID: 179555 RVA: 0x005F62FC File Offset: 0x005F44FC
		public static TCsvOutAreaBorderData GetRootAsTCsvOutAreaBorderData(ByteBuffer _bb, TCsvOutAreaBorderData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BD64 RID: 179556 RVA: 0x005F6319 File Offset: 0x005F4519
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BD65 RID: 179557 RVA: 0x005F6328 File Offset: 0x005F4528
		public TCsvOutAreaBorderData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BE2F RID: 48687
		// (get) Token: 0x0602BD66 RID: 179558 RVA: 0x005F6338 File Offset: 0x005F4538
		public int Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BE30 RID: 48688
		// (get) Token: 0x0602BD67 RID: 179559 RVA: 0x005F6374 File Offset: 0x005F4574
		public IOutAreaBorderTimerConfig? Data
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IOutAreaBorderTimerConfig?(default(IOutAreaBorderTimerConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0602BD68 RID: 179560 RVA: 0x005F63D1 File Offset: 0x005F45D1
		public static Offset<TCsvOutAreaBorderData> CreateTCsvOutAreaBorderData(FlatBufferBuilder builder, int Id = 0, Offset<IOutAreaBorderTimerConfig> DataOffset = default(Offset<IOutAreaBorderTimerConfig>))
		{
			builder.StartTable(2);
			TCsvOutAreaBorderData.AddData(builder, DataOffset);
			TCsvOutAreaBorderData.AddId(builder, Id);
			return TCsvOutAreaBorderData.EndTCsvOutAreaBorderData(builder);
		}

		// Token: 0x0602BD69 RID: 179561 RVA: 0x005F63EE File Offset: 0x005F45EE
		public static void StartTCsvOutAreaBorderData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602BD6A RID: 179562 RVA: 0x005F63F7 File Offset: 0x005F45F7
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0602BD6B RID: 179563 RVA: 0x005F6402 File Offset: 0x005F4602
		public static void AddData(FlatBufferBuilder builder, Offset<IOutAreaBorderTimerConfig> dataOffset)
		{
			builder.AddOffset(1, dataOffset.Value, 0);
		}

		// Token: 0x0602BD6C RID: 179564 RVA: 0x005F6412 File Offset: 0x005F4612
		public static Offset<TCsvOutAreaBorderData> EndTCsvOutAreaBorderData(FlatBufferBuilder builder)
		{
			return new Offset<TCsvOutAreaBorderData>(builder.EndTable());
		}

		// Token: 0x0602BD6D RID: 179565 RVA: 0x005F6420 File Offset: 0x005F4620
		public TCsvOutAreaBorderDataT UnPack()
		{
			TCsvOutAreaBorderDataT tcsvOutAreaBorderDataT = new TCsvOutAreaBorderDataT();
			this.UnPackTo(tcsvOutAreaBorderDataT);
			return tcsvOutAreaBorderDataT;
		}

		// Token: 0x0602BD6E RID: 179566 RVA: 0x005F643C File Offset: 0x005F463C
		public void UnPackTo(TCsvOutAreaBorderDataT _o)
		{
			_o.Id = this.Id;
			_o.Data = ((this.Data != null) ? this.Data.Value.UnPack() : null);
		}

		// Token: 0x0602BD6F RID: 179567 RVA: 0x005F6484 File Offset: 0x005F4684
		public static Offset<TCsvOutAreaBorderData> Pack(FlatBufferBuilder builder, TCsvOutAreaBorderDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<TCsvOutAreaBorderData>);
			}
			Offset<IOutAreaBorderTimerConfig> dataOffset = (_o.Data == null) ? default(Offset<IOutAreaBorderTimerConfig>) : IOutAreaBorderTimerConfig.Pack(builder, _o.Data);
			return TCsvOutAreaBorderData.CreateTCsvOutAreaBorderData(builder, _o.Id, dataOffset);
		}

		// Token: 0x04010606 RID: 67078
		private Table __p;
	}
}
