using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FC8 RID: 16328
	public struct IQuestBuffActiveCenterRange : IFlatbufferObject
	{
		// Token: 0x1700725C RID: 29276
		// (get) Token: 0x060176AD RID: 95917 RVA: 0x00360A89 File Offset: 0x0035EC89
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060176AE RID: 95918 RVA: 0x00360A96 File Offset: 0x0035EC96
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060176AF RID: 95919 RVA: 0x00360AA0 File Offset: 0x0035ECA0
		public static IQuestBuffActiveCenterRange GetRootAsIQuestBuffActiveCenterRange(ByteBuffer _bb)
		{
			return IQuestBuffActiveCenterRange.GetRootAsIQuestBuffActiveCenterRange(_bb, default(IQuestBuffActiveCenterRange));
		}

		// Token: 0x060176B0 RID: 95920 RVA: 0x00360ABC File Offset: 0x0035ECBC
		public static IQuestBuffActiveCenterRange GetRootAsIQuestBuffActiveCenterRange(ByteBuffer _bb, IQuestBuffActiveCenterRange obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060176B1 RID: 95921 RVA: 0x00360AD9 File Offset: 0x0035ECD9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060176B2 RID: 95922 RVA: 0x00360AE8 File Offset: 0x0035ECE8
		public IQuestBuffActiveCenterRange __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700725D RID: 29277
		// (get) Token: 0x060176B3 RID: 95923 RVA: 0x00360AF8 File Offset: 0x0035ECF8
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

		// Token: 0x1700725E RID: 29278
		// (get) Token: 0x060176B4 RID: 95924 RVA: 0x00360B58 File Offset: 0x0035ED58
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

		// Token: 0x1700725F RID: 29279
		// (get) Token: 0x060176B5 RID: 95925 RVA: 0x00360B94 File Offset: 0x0035ED94
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

		// Token: 0x060176B6 RID: 95926 RVA: 0x00360BD0 File Offset: 0x0035EDD0
		public static Offset<IQuestBuffActiveCenterRange> CreateIQuestBuffActiveCenterRange(FlatBufferBuilder builder, Offset<IVectorInfo> CheckPointOffset = default(Offset<IVectorInfo>), int CheckEnterRange = 0, int CheckLeaveRange = 0)
		{
			builder.StartTable(3);
			IQuestBuffActiveCenterRange.AddCheckLeaveRange(builder, CheckLeaveRange);
			IQuestBuffActiveCenterRange.AddCheckEnterRange(builder, CheckEnterRange);
			IQuestBuffActiveCenterRange.AddCheckPoint(builder, CheckPointOffset);
			return IQuestBuffActiveCenterRange.EndIQuestBuffActiveCenterRange(builder);
		}

		// Token: 0x060176B7 RID: 95927 RVA: 0x00360BF4 File Offset: 0x0035EDF4
		public static void StartIQuestBuffActiveCenterRange(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060176B8 RID: 95928 RVA: 0x00360BFD File Offset: 0x0035EDFD
		public static void AddCheckPoint(FlatBufferBuilder builder, Offset<IVectorInfo> checkPointOffset)
		{
			builder.AddOffset(0, checkPointOffset.Value, 0);
		}

		// Token: 0x060176B9 RID: 95929 RVA: 0x00360C0D File Offset: 0x0035EE0D
		public static void AddCheckEnterRange(FlatBufferBuilder builder, int checkEnterRange)
		{
			builder.AddInt(1, checkEnterRange, 0);
		}

		// Token: 0x060176BA RID: 95930 RVA: 0x00360C18 File Offset: 0x0035EE18
		public static void AddCheckLeaveRange(FlatBufferBuilder builder, int checkLeaveRange)
		{
			builder.AddInt(2, checkLeaveRange, 0);
		}

		// Token: 0x060176BB RID: 95931 RVA: 0x00360C23 File Offset: 0x0035EE23
		public static Offset<IQuestBuffActiveCenterRange> EndIQuestBuffActiveCenterRange(FlatBufferBuilder builder)
		{
			return new Offset<IQuestBuffActiveCenterRange>(builder.EndTable());
		}

		// Token: 0x060176BC RID: 95932 RVA: 0x00360C30 File Offset: 0x0035EE30
		public IQuestBuffActiveCenterRangeT UnPack()
		{
			IQuestBuffActiveCenterRangeT questBuffActiveCenterRangeT = new IQuestBuffActiveCenterRangeT();
			this.UnPackTo(questBuffActiveCenterRangeT);
			return questBuffActiveCenterRangeT;
		}

		// Token: 0x060176BD RID: 95933 RVA: 0x00360C4C File Offset: 0x0035EE4C
		public void UnPackTo(IQuestBuffActiveCenterRangeT _o)
		{
			_o.CheckPoint = ((this.CheckPoint != null) ? this.CheckPoint.Value.UnPack() : null);
			_o.CheckEnterRange = this.CheckEnterRange;
			_o.CheckLeaveRange = this.CheckLeaveRange;
		}

		// Token: 0x060176BE RID: 95934 RVA: 0x00360CA0 File Offset: 0x0035EEA0
		public static Offset<IQuestBuffActiveCenterRange> Pack(FlatBufferBuilder builder, IQuestBuffActiveCenterRangeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestBuffActiveCenterRange>);
			}
			Offset<IVectorInfo> checkPointOffset = (_o.CheckPoint == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.CheckPoint);
			return IQuestBuffActiveCenterRange.CreateIQuestBuffActiveCenterRange(builder, checkPointOffset, _o.CheckEnterRange, _o.CheckLeaveRange);
		}

		// Token: 0x0400BA65 RID: 47717
		private Table __p;
	}
}
