using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066FA RID: 26362
	public struct IActiveRange : IFlatbufferObject
	{
		// Token: 0x1700BF9B RID: 49051
		// (get) Token: 0x0602CA21 RID: 182817 RVA: 0x0061B98E File Offset: 0x00619B8E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CA22 RID: 182818 RVA: 0x0061B99B File Offset: 0x00619B9B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CA23 RID: 182819 RVA: 0x0061B9A4 File Offset: 0x00619BA4
		public static IActiveRange GetRootAsIActiveRange(ByteBuffer _bb)
		{
			return IActiveRange.GetRootAsIActiveRange(_bb, default(IActiveRange));
		}

		// Token: 0x0602CA24 RID: 182820 RVA: 0x0061B9C0 File Offset: 0x00619BC0
		public static IActiveRange GetRootAsIActiveRange(ByteBuffer _bb, IActiveRange obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CA25 RID: 182821 RVA: 0x0061B9DD File Offset: 0x00619BDD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CA26 RID: 182822 RVA: 0x0061B9EC File Offset: 0x00619BEC
		public IActiveRange __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BF9C RID: 49052
		// (get) Token: 0x0602CA27 RID: 182823 RVA: 0x0061B9FC File Offset: 0x00619BFC
		public IVectorInfo? CheckPoint
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700BF9D RID: 49053
		// (get) Token: 0x0602CA28 RID: 182824 RVA: 0x0061BA5C File Offset: 0x00619C5C
		public int CheckEnterRange
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BF9E RID: 49054
		// (get) Token: 0x0602CA29 RID: 182825 RVA: 0x0061BA98 File Offset: 0x00619C98
		public int CheckLeaveRange
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BF9F RID: 49055
		// (get) Token: 0x0602CA2A RID: 182826 RVA: 0x0061BAD4 File Offset: 0x00619CD4
		public bool AllowRangeExceed
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700BFA0 RID: 49056
		// (get) Token: 0x0602CA2B RID: 182827 RVA: 0x0061BB14 File Offset: 0x00619D14
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602CA2C RID: 182828 RVA: 0x0061BB51 File Offset: 0x00619D51
		public static Offset<IActiveRange> CreateIActiveRange(FlatBufferBuilder builder, Offset<IVectorInfo> CheckPointOffset = default(Offset<IVectorInfo>), int CheckEnterRange = 0, int CheckLeaveRange = 0, bool AllowRangeExceed = false, byte NullMask = 0)
		{
			builder.StartTable(5);
			IActiveRange.AddCheckLeaveRange(builder, CheckLeaveRange);
			IActiveRange.AddCheckEnterRange(builder, CheckEnterRange);
			IActiveRange.AddCheckPoint(builder, CheckPointOffset);
			IActiveRange.AddNullMask(builder, NullMask);
			IActiveRange.AddAllowRangeExceed(builder, AllowRangeExceed);
			return IActiveRange.EndIActiveRange(builder);
		}

		// Token: 0x0602CA2D RID: 182829 RVA: 0x0061BB85 File Offset: 0x00619D85
		public static void StartIActiveRange(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602CA2E RID: 182830 RVA: 0x0061BB8E File Offset: 0x00619D8E
		public static void AddCheckPoint(FlatBufferBuilder builder, Offset<IVectorInfo> checkPointOffset)
		{
			builder.AddOffset(0, checkPointOffset.Value, 0);
		}

		// Token: 0x0602CA2F RID: 182831 RVA: 0x0061BB9E File Offset: 0x00619D9E
		public static void AddCheckEnterRange(FlatBufferBuilder builder, int checkEnterRange)
		{
			builder.AddInt(1, checkEnterRange, 0);
		}

		// Token: 0x0602CA30 RID: 182832 RVA: 0x0061BBA9 File Offset: 0x00619DA9
		public static void AddCheckLeaveRange(FlatBufferBuilder builder, int checkLeaveRange)
		{
			builder.AddInt(2, checkLeaveRange, 0);
		}

		// Token: 0x0602CA31 RID: 182833 RVA: 0x0061BBB4 File Offset: 0x00619DB4
		public static void AddAllowRangeExceed(FlatBufferBuilder builder, bool allowRangeExceed)
		{
			builder.AddBool(3, allowRangeExceed, false);
		}

		// Token: 0x0602CA32 RID: 182834 RVA: 0x0061BBBF File Offset: 0x00619DBF
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0602CA33 RID: 182835 RVA: 0x0061BBCA File Offset: 0x00619DCA
		public static Offset<IActiveRange> EndIActiveRange(FlatBufferBuilder builder)
		{
			return new Offset<IActiveRange>(builder.EndTable());
		}

		// Token: 0x0602CA34 RID: 182836 RVA: 0x0061BBD8 File Offset: 0x00619DD8
		public IActiveRangeT UnPack()
		{
			IActiveRangeT activeRangeT = new IActiveRangeT();
			this.UnPackTo(activeRangeT);
			return activeRangeT;
		}

		// Token: 0x0602CA35 RID: 182837 RVA: 0x0061BBF4 File Offset: 0x00619DF4
		public void UnPackTo(IActiveRangeT _o)
		{
			_o.CheckPoint = ((this.CheckPoint != null) ? this.CheckPoint.Value.UnPack() : null);
			_o.CheckEnterRange = this.CheckEnterRange;
			_o.CheckLeaveRange = this.CheckLeaveRange;
			_o.AllowRangeExceed = this.AllowRangeExceed;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602CA36 RID: 182838 RVA: 0x0061BC60 File Offset: 0x00619E60
		public static Offset<IActiveRange> Pack(FlatBufferBuilder builder, IActiveRangeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActiveRange>);
			}
			Offset<IVectorInfo> checkPointOffset = (_o.CheckPoint == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.CheckPoint);
			return IActiveRange.CreateIActiveRange(builder, checkPointOffset, _o.CheckEnterRange, _o.CheckLeaveRange, _o.AllowRangeExceed, _o.NullMask);
		}

		// Token: 0x0401122F RID: 70191
		private Table __p;
	}
}
