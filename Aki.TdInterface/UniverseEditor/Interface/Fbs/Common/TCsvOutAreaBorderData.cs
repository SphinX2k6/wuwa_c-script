using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E75 RID: 24181
	public struct TCsvOutAreaBorderData : IFlatbufferObject
	{
		// Token: 0x1700B4C3 RID: 46275
		// (get) Token: 0x060296B8 RID: 169656 RVA: 0x005AD328 File Offset: 0x005AB528
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060296B9 RID: 169657 RVA: 0x005AD335 File Offset: 0x005AB535
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060296BA RID: 169658 RVA: 0x005AD33C File Offset: 0x005AB53C
		public static TCsvOutAreaBorderData GetRootAsTCsvOutAreaBorderData(ByteBuffer _bb)
		{
			return TCsvOutAreaBorderData.GetRootAsTCsvOutAreaBorderData(_bb, default(TCsvOutAreaBorderData));
		}

		// Token: 0x060296BB RID: 169659 RVA: 0x005AD358 File Offset: 0x005AB558
		public static TCsvOutAreaBorderData GetRootAsTCsvOutAreaBorderData(ByteBuffer _bb, TCsvOutAreaBorderData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060296BC RID: 169660 RVA: 0x005AD375 File Offset: 0x005AB575
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060296BD RID: 169661 RVA: 0x005AD384 File Offset: 0x005AB584
		public TCsvOutAreaBorderData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B4C4 RID: 46276
		// (get) Token: 0x060296BE RID: 169662 RVA: 0x005AD394 File Offset: 0x005AB594
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

		// Token: 0x1700B4C5 RID: 46277
		// (get) Token: 0x060296BF RID: 169663 RVA: 0x005AD3D0 File Offset: 0x005AB5D0
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

		// Token: 0x060296C0 RID: 169664 RVA: 0x005AD42D File Offset: 0x005AB62D
		public static Offset<TCsvOutAreaBorderData> CreateTCsvOutAreaBorderData(FlatBufferBuilder builder, int Id = 0, Offset<IOutAreaBorderTimerConfig> DataOffset = default(Offset<IOutAreaBorderTimerConfig>))
		{
			builder.StartTable(2);
			TCsvOutAreaBorderData.AddData(builder, DataOffset);
			TCsvOutAreaBorderData.AddId(builder, Id);
			return TCsvOutAreaBorderData.EndTCsvOutAreaBorderData(builder);
		}

		// Token: 0x060296C1 RID: 169665 RVA: 0x005AD44A File Offset: 0x005AB64A
		public static void StartTCsvOutAreaBorderData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060296C2 RID: 169666 RVA: 0x005AD453 File Offset: 0x005AB653
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x060296C3 RID: 169667 RVA: 0x005AD45E File Offset: 0x005AB65E
		public static void AddData(FlatBufferBuilder builder, Offset<IOutAreaBorderTimerConfig> dataOffset)
		{
			builder.AddOffset(1, dataOffset.Value, 0);
		}

		// Token: 0x060296C4 RID: 169668 RVA: 0x005AD46E File Offset: 0x005AB66E
		public static Offset<TCsvOutAreaBorderData> EndTCsvOutAreaBorderData(FlatBufferBuilder builder)
		{
			return new Offset<TCsvOutAreaBorderData>(builder.EndTable());
		}

		// Token: 0x060296C5 RID: 169669 RVA: 0x005AD47C File Offset: 0x005AB67C
		public TCsvOutAreaBorderDataT UnPack()
		{
			TCsvOutAreaBorderDataT tcsvOutAreaBorderDataT = new TCsvOutAreaBorderDataT();
			this.UnPackTo(tcsvOutAreaBorderDataT);
			return tcsvOutAreaBorderDataT;
		}

		// Token: 0x060296C6 RID: 169670 RVA: 0x005AD498 File Offset: 0x005AB698
		public void UnPackTo(TCsvOutAreaBorderDataT _o)
		{
			_o.Id = this.Id;
			_o.Data = ((this.Data != null) ? this.Data.Value.UnPack() : null);
		}

		// Token: 0x060296C7 RID: 169671 RVA: 0x005AD4E0 File Offset: 0x005AB6E0
		public static Offset<TCsvOutAreaBorderData> Pack(FlatBufferBuilder builder, TCsvOutAreaBorderDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<TCsvOutAreaBorderData>);
			}
			Offset<IOutAreaBorderTimerConfig> dataOffset = (_o.Data == null) ? default(Offset<IOutAreaBorderTimerConfig>) : IOutAreaBorderTimerConfig.Pack(builder, _o.Data);
			return TCsvOutAreaBorderData.CreateTCsvOutAreaBorderData(builder, _o.Id, dataOffset);
		}

		// Token: 0x0400F8A3 RID: 63651
		private Table __p;
	}
}
