using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006098 RID: 24728
	public struct IActiveRange : IFlatbufferObject
	{
		// Token: 0x1700B630 RID: 46640
		// (get) Token: 0x0602A340 RID: 172864 RVA: 0x005D19E6 File Offset: 0x005CFBE6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A341 RID: 172865 RVA: 0x005D19F3 File Offset: 0x005CFBF3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A342 RID: 172866 RVA: 0x005D19FC File Offset: 0x005CFBFC
		public static IActiveRange GetRootAsIActiveRange(ByteBuffer _bb)
		{
			return IActiveRange.GetRootAsIActiveRange(_bb, default(IActiveRange));
		}

		// Token: 0x0602A343 RID: 172867 RVA: 0x005D1A18 File Offset: 0x005CFC18
		public static IActiveRange GetRootAsIActiveRange(ByteBuffer _bb, IActiveRange obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A344 RID: 172868 RVA: 0x005D1A35 File Offset: 0x005CFC35
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A345 RID: 172869 RVA: 0x005D1A44 File Offset: 0x005CFC44
		public IActiveRange __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B631 RID: 46641
		// (get) Token: 0x0602A346 RID: 172870 RVA: 0x005D1A54 File Offset: 0x005CFC54
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

		// Token: 0x1700B632 RID: 46642
		// (get) Token: 0x0602A347 RID: 172871 RVA: 0x005D1AB4 File Offset: 0x005CFCB4
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

		// Token: 0x1700B633 RID: 46643
		// (get) Token: 0x0602A348 RID: 172872 RVA: 0x005D1AF0 File Offset: 0x005CFCF0
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

		// Token: 0x1700B634 RID: 46644
		// (get) Token: 0x0602A349 RID: 172873 RVA: 0x005D1B2C File Offset: 0x005CFD2C
		public bool AllowRangeExceed
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B635 RID: 46645
		// (get) Token: 0x0602A34A RID: 172874 RVA: 0x005D1B6C File Offset: 0x005CFD6C
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

		// Token: 0x0602A34B RID: 172875 RVA: 0x005D1BA9 File Offset: 0x005CFDA9
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

		// Token: 0x0602A34C RID: 172876 RVA: 0x005D1BDD File Offset: 0x005CFDDD
		public static void StartIActiveRange(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602A34D RID: 172877 RVA: 0x005D1BE6 File Offset: 0x005CFDE6
		public static void AddCheckPoint(FlatBufferBuilder builder, Offset<IVectorInfo> checkPointOffset)
		{
			builder.AddOffset(0, checkPointOffset.Value, 0);
		}

		// Token: 0x0602A34E RID: 172878 RVA: 0x005D1BF6 File Offset: 0x005CFDF6
		public static void AddCheckEnterRange(FlatBufferBuilder builder, int checkEnterRange)
		{
			builder.AddInt(1, checkEnterRange, 0);
		}

		// Token: 0x0602A34F RID: 172879 RVA: 0x005D1C01 File Offset: 0x005CFE01
		public static void AddCheckLeaveRange(FlatBufferBuilder builder, int checkLeaveRange)
		{
			builder.AddInt(2, checkLeaveRange, 0);
		}

		// Token: 0x0602A350 RID: 172880 RVA: 0x005D1C0C File Offset: 0x005CFE0C
		public static void AddAllowRangeExceed(FlatBufferBuilder builder, bool allowRangeExceed)
		{
			builder.AddBool(3, allowRangeExceed, false);
		}

		// Token: 0x0602A351 RID: 172881 RVA: 0x005D1C17 File Offset: 0x005CFE17
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0602A352 RID: 172882 RVA: 0x005D1C22 File Offset: 0x005CFE22
		public static Offset<IActiveRange> EndIActiveRange(FlatBufferBuilder builder)
		{
			return new Offset<IActiveRange>(builder.EndTable());
		}

		// Token: 0x0602A353 RID: 172883 RVA: 0x005D1C30 File Offset: 0x005CFE30
		public IActiveRangeT UnPack()
		{
			IActiveRangeT activeRangeT = new IActiveRangeT();
			this.UnPackTo(activeRangeT);
			return activeRangeT;
		}

		// Token: 0x0602A354 RID: 172884 RVA: 0x005D1C4C File Offset: 0x005CFE4C
		public void UnPackTo(IActiveRangeT _o)
		{
			_o.CheckPoint = ((this.CheckPoint != null) ? this.CheckPoint.Value.UnPack() : null);
			_o.CheckEnterRange = this.CheckEnterRange;
			_o.CheckLeaveRange = this.CheckLeaveRange;
			_o.AllowRangeExceed = this.AllowRangeExceed;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602A355 RID: 172885 RVA: 0x005D1CB8 File Offset: 0x005CFEB8
		public static Offset<IActiveRange> Pack(FlatBufferBuilder builder, IActiveRangeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActiveRange>);
			}
			Offset<IVectorInfo> checkPointOffset = (_o.CheckPoint == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.CheckPoint);
			return IActiveRange.CreateIActiveRange(builder, checkPointOffset, _o.CheckEnterRange, _o.CheckLeaveRange, _o.AllowRangeExceed, _o.NullMask);
		}

		// Token: 0x0401042B RID: 66603
		private Table __p;
	}
}
