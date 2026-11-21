using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C84 RID: 23684
	public struct IPasserbyNpcIntervalExit : IFlatbufferObject
	{
		// Token: 0x1700AE01 RID: 44545
		// (get) Token: 0x06027499 RID: 160921 RVA: 0x00561502 File Offset: 0x0055F702
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602749A RID: 160922 RVA: 0x0056150F File Offset: 0x0055F70F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602749B RID: 160923 RVA: 0x00561518 File Offset: 0x0055F718
		public static IPasserbyNpcIntervalExit GetRootAsIPasserbyNpcIntervalExit(ByteBuffer _bb)
		{
			return IPasserbyNpcIntervalExit.GetRootAsIPasserbyNpcIntervalExit(_bb, default(IPasserbyNpcIntervalExit));
		}

		// Token: 0x0602749C RID: 160924 RVA: 0x00561534 File Offset: 0x0055F734
		public static IPasserbyNpcIntervalExit GetRootAsIPasserbyNpcIntervalExit(ByteBuffer _bb, IPasserbyNpcIntervalExit obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602749D RID: 160925 RVA: 0x00561551 File Offset: 0x0055F751
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602749E RID: 160926 RVA: 0x00561560 File Offset: 0x0055F760
		public IPasserbyNpcIntervalExit __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AE02 RID: 44546
		// (get) Token: 0x0602749F RID: 160927 RVA: 0x00561570 File Offset: 0x0055F770
		public IPasserbyNpcPerNpcRandomExitInterval? IntervalType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IPasserbyNpcPerNpcRandomExitInterval?(default(IPasserbyNpcPerNpcRandomExitInterval).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060274A0 RID: 160928 RVA: 0x005615CD File Offset: 0x0055F7CD
		public static Offset<IPasserbyNpcIntervalExit> CreateIPasserbyNpcIntervalExit(FlatBufferBuilder builder, Offset<IPasserbyNpcPerNpcRandomExitInterval> IntervalTypeOffset = default(Offset<IPasserbyNpcPerNpcRandomExitInterval>))
		{
			builder.StartTable(1);
			IPasserbyNpcIntervalExit.AddIntervalType(builder, IntervalTypeOffset);
			return IPasserbyNpcIntervalExit.EndIPasserbyNpcIntervalExit(builder);
		}

		// Token: 0x060274A1 RID: 160929 RVA: 0x005615E3 File Offset: 0x0055F7E3
		public static void StartIPasserbyNpcIntervalExit(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060274A2 RID: 160930 RVA: 0x005615EC File Offset: 0x0055F7EC
		public static void AddIntervalType(FlatBufferBuilder builder, Offset<IPasserbyNpcPerNpcRandomExitInterval> intervalTypeOffset)
		{
			builder.AddOffset(0, intervalTypeOffset.Value, 0);
		}

		// Token: 0x060274A3 RID: 160931 RVA: 0x005615FC File Offset: 0x0055F7FC
		public static Offset<IPasserbyNpcIntervalExit> EndIPasserbyNpcIntervalExit(FlatBufferBuilder builder)
		{
			return new Offset<IPasserbyNpcIntervalExit>(builder.EndTable());
		}

		// Token: 0x060274A4 RID: 160932 RVA: 0x0056160C File Offset: 0x0055F80C
		public IPasserbyNpcIntervalExitT UnPack()
		{
			IPasserbyNpcIntervalExitT passerbyNpcIntervalExitT = new IPasserbyNpcIntervalExitT();
			this.UnPackTo(passerbyNpcIntervalExitT);
			return passerbyNpcIntervalExitT;
		}

		// Token: 0x060274A5 RID: 160933 RVA: 0x00561628 File Offset: 0x0055F828
		public void UnPackTo(IPasserbyNpcIntervalExitT _o)
		{
			_o.IntervalType = ((this.IntervalType != null) ? this.IntervalType.Value.UnPack() : null);
		}

		// Token: 0x060274A6 RID: 160934 RVA: 0x00561664 File Offset: 0x0055F864
		public static Offset<IPasserbyNpcIntervalExit> Pack(FlatBufferBuilder builder, IPasserbyNpcIntervalExitT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPasserbyNpcIntervalExit>);
			}
			Offset<IPasserbyNpcPerNpcRandomExitInterval> intervalTypeOffset = (_o.IntervalType == null) ? default(Offset<IPasserbyNpcPerNpcRandomExitInterval>) : IPasserbyNpcPerNpcRandomExitInterval.Pack(builder, _o.IntervalType);
			return IPasserbyNpcIntervalExit.CreateIPasserbyNpcIntervalExit(builder, intervalTypeOffset);
		}

		// Token: 0x0400F78E RID: 63374
		private Table __p;
	}
}
