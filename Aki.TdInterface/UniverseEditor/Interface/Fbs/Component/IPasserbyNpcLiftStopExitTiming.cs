using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C90 RID: 23696
	public struct IPasserbyNpcLiftStopExitTiming : IFlatbufferObject
	{
		// Token: 0x1700AE0E RID: 44558
		// (get) Token: 0x060274DF RID: 160991 RVA: 0x00561BFE File Offset: 0x0055FDFE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060274E0 RID: 160992 RVA: 0x00561C0B File Offset: 0x0055FE0B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060274E1 RID: 160993 RVA: 0x00561C14 File Offset: 0x0055FE14
		public static IPasserbyNpcLiftStopExitTiming GetRootAsIPasserbyNpcLiftStopExitTiming(ByteBuffer _bb)
		{
			return IPasserbyNpcLiftStopExitTiming.GetRootAsIPasserbyNpcLiftStopExitTiming(_bb, default(IPasserbyNpcLiftStopExitTiming));
		}

		// Token: 0x060274E2 RID: 160994 RVA: 0x00561C30 File Offset: 0x0055FE30
		public static IPasserbyNpcLiftStopExitTiming GetRootAsIPasserbyNpcLiftStopExitTiming(ByteBuffer _bb, IPasserbyNpcLiftStopExitTiming obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060274E3 RID: 160995 RVA: 0x00561C4D File Offset: 0x0055FE4D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060274E4 RID: 160996 RVA: 0x00561C5C File Offset: 0x0055FE5C
		public IPasserbyNpcLiftStopExitTiming __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AE0F RID: 44559
		// (get) Token: 0x060274E5 RID: 160997 RVA: 0x00561C6C File Offset: 0x0055FE6C
		public EPasserbyNpcExitTimingType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPasserbyNpcExitTimingType.LiftStop;
				}
				return (EPasserbyNpcExitTimingType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AE10 RID: 44560
		// (get) Token: 0x060274E6 RID: 160998 RVA: 0x00561CA8 File Offset: 0x0055FEA8
		public IPasserbyNpcIntervalExit? IntervalExit
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IPasserbyNpcIntervalExit?(default(IPasserbyNpcIntervalExit).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060274E7 RID: 160999 RVA: 0x00561D05 File Offset: 0x0055FF05
		public static Offset<IPasserbyNpcLiftStopExitTiming> CreateIPasserbyNpcLiftStopExitTiming(FlatBufferBuilder builder, EPasserbyNpcExitTimingType Type = EPasserbyNpcExitTimingType.LiftStop, Offset<IPasserbyNpcIntervalExit> IntervalExitOffset = default(Offset<IPasserbyNpcIntervalExit>))
		{
			builder.StartTable(2);
			IPasserbyNpcLiftStopExitTiming.AddIntervalExit(builder, IntervalExitOffset);
			IPasserbyNpcLiftStopExitTiming.AddType(builder, Type);
			return IPasserbyNpcLiftStopExitTiming.EndIPasserbyNpcLiftStopExitTiming(builder);
		}

		// Token: 0x060274E8 RID: 161000 RVA: 0x00561D22 File Offset: 0x0055FF22
		public static void StartIPasserbyNpcLiftStopExitTiming(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060274E9 RID: 161001 RVA: 0x00561D2B File Offset: 0x0055FF2B
		public static void AddType(FlatBufferBuilder builder, EPasserbyNpcExitTimingType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060274EA RID: 161002 RVA: 0x00561D36 File Offset: 0x0055FF36
		public static void AddIntervalExit(FlatBufferBuilder builder, Offset<IPasserbyNpcIntervalExit> intervalExitOffset)
		{
			builder.AddOffset(1, intervalExitOffset.Value, 0);
		}

		// Token: 0x060274EB RID: 161003 RVA: 0x00561D46 File Offset: 0x0055FF46
		public static Offset<IPasserbyNpcLiftStopExitTiming> EndIPasserbyNpcLiftStopExitTiming(FlatBufferBuilder builder)
		{
			return new Offset<IPasserbyNpcLiftStopExitTiming>(builder.EndTable());
		}

		// Token: 0x060274EC RID: 161004 RVA: 0x00561D54 File Offset: 0x0055FF54
		public IPasserbyNpcLiftStopExitTimingT UnPack()
		{
			IPasserbyNpcLiftStopExitTimingT passerbyNpcLiftStopExitTimingT = new IPasserbyNpcLiftStopExitTimingT();
			this.UnPackTo(passerbyNpcLiftStopExitTimingT);
			return passerbyNpcLiftStopExitTimingT;
		}

		// Token: 0x060274ED RID: 161005 RVA: 0x00561D70 File Offset: 0x0055FF70
		public void UnPackTo(IPasserbyNpcLiftStopExitTimingT _o)
		{
			_o.Type = this.Type;
			_o.IntervalExit = ((this.IntervalExit != null) ? this.IntervalExit.Value.UnPack() : null);
		}

		// Token: 0x060274EE RID: 161006 RVA: 0x00561DB8 File Offset: 0x0055FFB8
		public static Offset<IPasserbyNpcLiftStopExitTiming> Pack(FlatBufferBuilder builder, IPasserbyNpcLiftStopExitTimingT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPasserbyNpcLiftStopExitTiming>);
			}
			Offset<IPasserbyNpcIntervalExit> intervalExitOffset = (_o.IntervalExit == null) ? default(Offset<IPasserbyNpcIntervalExit>) : IPasserbyNpcIntervalExit.Pack(builder, _o.IntervalExit);
			return IPasserbyNpcLiftStopExitTiming.CreateIPasserbyNpcLiftStopExitTiming(builder, _o.Type, intervalExitOffset);
		}

		// Token: 0x0400F79B RID: 63387
		private Table __p;
	}
}
