using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020060BE RID: 24766
	public struct ITimeScheduleRefreshPosition : IFlatbufferObject
	{
		// Token: 0x1700B817 RID: 47127
		// (get) Token: 0x06029E6E RID: 171630 RVA: 0x005B8266 File Offset: 0x005B6466
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029E6F RID: 171631 RVA: 0x005B8273 File Offset: 0x005B6473
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029E70 RID: 171632 RVA: 0x005B827C File Offset: 0x005B647C
		public static ITimeScheduleRefreshPosition GetRootAsITimeScheduleRefreshPosition(ByteBuffer _bb)
		{
			return ITimeScheduleRefreshPosition.GetRootAsITimeScheduleRefreshPosition(_bb, default(ITimeScheduleRefreshPosition));
		}

		// Token: 0x06029E71 RID: 171633 RVA: 0x005B8298 File Offset: 0x005B6498
		public static ITimeScheduleRefreshPosition GetRootAsITimeScheduleRefreshPosition(ByteBuffer _bb, ITimeScheduleRefreshPosition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029E72 RID: 171634 RVA: 0x005B82B5 File Offset: 0x005B64B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029E73 RID: 171635 RVA: 0x005B82C4 File Offset: 0x005B64C4
		public ITimeScheduleRefreshPosition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B818 RID: 47128
		// (get) Token: 0x06029E74 RID: 171636 RVA: 0x005B82D4 File Offset: 0x005B64D4
		public ETimeScheduleRefreshPositionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETimeScheduleRefreshPositionType.FixedPositions;
				}
				return (ETimeScheduleRefreshPositionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06029E75 RID: 171637 RVA: 0x005B8310 File Offset: 0x005B6510
		public static Offset<ITimeScheduleRefreshPosition> CreateITimeScheduleRefreshPosition(FlatBufferBuilder builder, ETimeScheduleRefreshPositionType Type = ETimeScheduleRefreshPositionType.FixedPositions)
		{
			builder.StartTable(1);
			ITimeScheduleRefreshPosition.AddType(builder, Type);
			return ITimeScheduleRefreshPosition.EndITimeScheduleRefreshPosition(builder);
		}

		// Token: 0x06029E76 RID: 171638 RVA: 0x005B8326 File Offset: 0x005B6526
		public static void StartITimeScheduleRefreshPosition(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06029E77 RID: 171639 RVA: 0x005B832F File Offset: 0x005B652F
		public static void AddType(FlatBufferBuilder builder, ETimeScheduleRefreshPositionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06029E78 RID: 171640 RVA: 0x005B833A File Offset: 0x005B653A
		public static Offset<ITimeScheduleRefreshPosition> EndITimeScheduleRefreshPosition(FlatBufferBuilder builder)
		{
			return new Offset<ITimeScheduleRefreshPosition>(builder.EndTable());
		}

		// Token: 0x06029E79 RID: 171641 RVA: 0x005B8348 File Offset: 0x005B6548
		public ITimeScheduleRefreshPositionT UnPack()
		{
			ITimeScheduleRefreshPositionT timeScheduleRefreshPositionT = new ITimeScheduleRefreshPositionT();
			this.UnPackTo(timeScheduleRefreshPositionT);
			return timeScheduleRefreshPositionT;
		}

		// Token: 0x06029E7A RID: 171642 RVA: 0x005B8363 File Offset: 0x005B6563
		public void UnPackTo(ITimeScheduleRefreshPositionT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06029E7B RID: 171643 RVA: 0x005B8374 File Offset: 0x005B6574
		public static Offset<ITimeScheduleRefreshPosition> Pack(FlatBufferBuilder builder, ITimeScheduleRefreshPositionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITimeScheduleRefreshPosition>);
			}
			return ITimeScheduleRefreshPosition.CreateITimeScheduleRefreshPosition(builder, _o.Type);
		}

		// Token: 0x0400FE6E RID: 65134
		private Table __p;
	}
}
