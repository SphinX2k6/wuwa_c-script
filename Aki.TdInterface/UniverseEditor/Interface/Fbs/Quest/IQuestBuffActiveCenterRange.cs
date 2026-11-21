using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004409 RID: 17417
	public struct IQuestBuffActiveCenterRange : IFlatbufferObject
	{
		// Token: 0x1700785C RID: 30812
		// (get) Token: 0x06018D40 RID: 101696 RVA: 0x0038A7B3 File Offset: 0x003889B3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018D41 RID: 101697 RVA: 0x0038A7C0 File Offset: 0x003889C0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018D42 RID: 101698 RVA: 0x0038A7C8 File Offset: 0x003889C8
		public static IQuestBuffActiveCenterRange GetRootAsIQuestBuffActiveCenterRange(ByteBuffer _bb)
		{
			return IQuestBuffActiveCenterRange.GetRootAsIQuestBuffActiveCenterRange(_bb, default(IQuestBuffActiveCenterRange));
		}

		// Token: 0x06018D43 RID: 101699 RVA: 0x0038A7E4 File Offset: 0x003889E4
		public static IQuestBuffActiveCenterRange GetRootAsIQuestBuffActiveCenterRange(ByteBuffer _bb, IQuestBuffActiveCenterRange obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018D44 RID: 101700 RVA: 0x0038A801 File Offset: 0x00388A01
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018D45 RID: 101701 RVA: 0x0038A810 File Offset: 0x00388A10
		public IQuestBuffActiveCenterRange __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700785D RID: 30813
		// (get) Token: 0x06018D46 RID: 101702 RVA: 0x0038A820 File Offset: 0x00388A20
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

		// Token: 0x1700785E RID: 30814
		// (get) Token: 0x06018D47 RID: 101703 RVA: 0x0038A880 File Offset: 0x00388A80
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

		// Token: 0x1700785F RID: 30815
		// (get) Token: 0x06018D48 RID: 101704 RVA: 0x0038A8BC File Offset: 0x00388ABC
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

		// Token: 0x06018D49 RID: 101705 RVA: 0x0038A8F8 File Offset: 0x00388AF8
		public static Offset<IQuestBuffActiveCenterRange> CreateIQuestBuffActiveCenterRange(FlatBufferBuilder builder, Offset<IVectorInfo> CheckPointOffset = default(Offset<IVectorInfo>), int CheckEnterRange = 0, int CheckLeaveRange = 0)
		{
			builder.StartTable(3);
			IQuestBuffActiveCenterRange.AddCheckLeaveRange(builder, CheckLeaveRange);
			IQuestBuffActiveCenterRange.AddCheckEnterRange(builder, CheckEnterRange);
			IQuestBuffActiveCenterRange.AddCheckPoint(builder, CheckPointOffset);
			return IQuestBuffActiveCenterRange.EndIQuestBuffActiveCenterRange(builder);
		}

		// Token: 0x06018D4A RID: 101706 RVA: 0x0038A91C File Offset: 0x00388B1C
		public static void StartIQuestBuffActiveCenterRange(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06018D4B RID: 101707 RVA: 0x0038A925 File Offset: 0x00388B25
		public static void AddCheckPoint(FlatBufferBuilder builder, Offset<IVectorInfo> checkPointOffset)
		{
			builder.AddOffset(0, checkPointOffset.Value, 0);
		}

		// Token: 0x06018D4C RID: 101708 RVA: 0x0038A935 File Offset: 0x00388B35
		public static void AddCheckEnterRange(FlatBufferBuilder builder, int checkEnterRange)
		{
			builder.AddInt(1, checkEnterRange, 0);
		}

		// Token: 0x06018D4D RID: 101709 RVA: 0x0038A940 File Offset: 0x00388B40
		public static void AddCheckLeaveRange(FlatBufferBuilder builder, int checkLeaveRange)
		{
			builder.AddInt(2, checkLeaveRange, 0);
		}

		// Token: 0x06018D4E RID: 101710 RVA: 0x0038A94B File Offset: 0x00388B4B
		public static Offset<IQuestBuffActiveCenterRange> EndIQuestBuffActiveCenterRange(FlatBufferBuilder builder)
		{
			return new Offset<IQuestBuffActiveCenterRange>(builder.EndTable());
		}

		// Token: 0x06018D4F RID: 101711 RVA: 0x0038A958 File Offset: 0x00388B58
		public IQuestBuffActiveCenterRangeT UnPack()
		{
			IQuestBuffActiveCenterRangeT questBuffActiveCenterRangeT = new IQuestBuffActiveCenterRangeT();
			this.UnPackTo(questBuffActiveCenterRangeT);
			return questBuffActiveCenterRangeT;
		}

		// Token: 0x06018D50 RID: 101712 RVA: 0x0038A974 File Offset: 0x00388B74
		public void UnPackTo(IQuestBuffActiveCenterRangeT _o)
		{
			_o.CheckPoint = ((this.CheckPoint != null) ? this.CheckPoint.Value.UnPack() : null);
			_o.CheckEnterRange = this.CheckEnterRange;
			_o.CheckLeaveRange = this.CheckLeaveRange;
		}

		// Token: 0x06018D51 RID: 101713 RVA: 0x0038A9C8 File Offset: 0x00388BC8
		public static Offset<IQuestBuffActiveCenterRange> Pack(FlatBufferBuilder builder, IQuestBuffActiveCenterRangeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestBuffActiveCenterRange>);
			}
			Offset<IVectorInfo> checkPointOffset = (_o.CheckPoint == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.CheckPoint);
			return IQuestBuffActiveCenterRange.CreateIQuestBuffActiveCenterRange(builder, checkPointOffset, _o.CheckEnterRange, _o.CheckLeaveRange);
		}

		// Token: 0x0400C44B RID: 50251
		private Table __p;
	}
}
