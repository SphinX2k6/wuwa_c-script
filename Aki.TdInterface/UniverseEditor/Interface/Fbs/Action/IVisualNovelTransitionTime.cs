using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075F2 RID: 30194
	public struct IVisualNovelTransitionTime : IFlatbufferObject
	{
		// Token: 0x1700E559 RID: 58713
		// (get) Token: 0x06036FF4 RID: 225268 RVA: 0x007765E8 File Offset: 0x007747E8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036FF5 RID: 225269 RVA: 0x007765F5 File Offset: 0x007747F5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036FF6 RID: 225270 RVA: 0x007765FC File Offset: 0x007747FC
		public static IVisualNovelTransitionTime GetRootAsIVisualNovelTransitionTime(ByteBuffer _bb)
		{
			return IVisualNovelTransitionTime.GetRootAsIVisualNovelTransitionTime(_bb, default(IVisualNovelTransitionTime));
		}

		// Token: 0x06036FF7 RID: 225271 RVA: 0x00776618 File Offset: 0x00774818
		public static IVisualNovelTransitionTime GetRootAsIVisualNovelTransitionTime(ByteBuffer _bb, IVisualNovelTransitionTime obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036FF8 RID: 225272 RVA: 0x00776635 File Offset: 0x00774835
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036FF9 RID: 225273 RVA: 0x00776644 File Offset: 0x00774844
		public IVisualNovelTransitionTime __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E55A RID: 58714
		// (get) Token: 0x06036FFA RID: 225274 RVA: 0x00776654 File Offset: 0x00774854
		public EVisualNovelTransitionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVisualNovelTransitionType.Location;
				}
				return (EVisualNovelTransitionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E55B RID: 58715
		// (get) Token: 0x06036FFB RID: 225275 RVA: 0x00776690 File Offset: 0x00774890
		public IVisualNovelDate? EndDate
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVisualNovelDate?(default(IVisualNovelDate).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700E55C RID: 58716
		// (get) Token: 0x06036FFC RID: 225276 RVA: 0x007766F0 File Offset: 0x007748F0
		public int EndPeriodId
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

		// Token: 0x1700E55D RID: 58717
		// (get) Token: 0x06036FFD RID: 225277 RVA: 0x0077672C File Offset: 0x0077492C
		public bool IsFullScreen
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E55E RID: 58718
		// (get) Token: 0x06036FFE RID: 225278 RVA: 0x0077676C File Offset: 0x0077496C
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

		// Token: 0x06036FFF RID: 225279 RVA: 0x007767A9 File Offset: 0x007749A9
		public static Offset<IVisualNovelTransitionTime> CreateIVisualNovelTransitionTime(FlatBufferBuilder builder, EVisualNovelTransitionType Type = EVisualNovelTransitionType.Location, Offset<IVisualNovelDate> EndDateOffset = default(Offset<IVisualNovelDate>), int EndPeriodId = 0, bool IsFullScreen = false, byte NullMask = 0)
		{
			builder.StartTable(5);
			IVisualNovelTransitionTime.AddEndPeriodId(builder, EndPeriodId);
			IVisualNovelTransitionTime.AddEndDate(builder, EndDateOffset);
			IVisualNovelTransitionTime.AddNullMask(builder, NullMask);
			IVisualNovelTransitionTime.AddIsFullScreen(builder, IsFullScreen);
			IVisualNovelTransitionTime.AddType(builder, Type);
			return IVisualNovelTransitionTime.EndIVisualNovelTransitionTime(builder);
		}

		// Token: 0x06037000 RID: 225280 RVA: 0x007767DD File Offset: 0x007749DD
		public static void StartIVisualNovelTransitionTime(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06037001 RID: 225281 RVA: 0x007767E6 File Offset: 0x007749E6
		public static void AddType(FlatBufferBuilder builder, EVisualNovelTransitionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06037002 RID: 225282 RVA: 0x007767F1 File Offset: 0x007749F1
		public static void AddEndDate(FlatBufferBuilder builder, Offset<IVisualNovelDate> endDateOffset)
		{
			builder.AddOffset(1, endDateOffset.Value, 0);
		}

		// Token: 0x06037003 RID: 225283 RVA: 0x00776801 File Offset: 0x00774A01
		public static void AddEndPeriodId(FlatBufferBuilder builder, int endPeriodId)
		{
			builder.AddInt(2, endPeriodId, 0);
		}

		// Token: 0x06037004 RID: 225284 RVA: 0x0077680C File Offset: 0x00774A0C
		public static void AddIsFullScreen(FlatBufferBuilder builder, bool isFullScreen)
		{
			builder.AddBool(3, isFullScreen, false);
		}

		// Token: 0x06037005 RID: 225285 RVA: 0x00776817 File Offset: 0x00774A17
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06037006 RID: 225286 RVA: 0x00776822 File Offset: 0x00774A22
		public static Offset<IVisualNovelTransitionTime> EndIVisualNovelTransitionTime(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelTransitionTime>(builder.EndTable());
		}

		// Token: 0x06037007 RID: 225287 RVA: 0x00776830 File Offset: 0x00774A30
		public IVisualNovelTransitionTimeT UnPack()
		{
			IVisualNovelTransitionTimeT visualNovelTransitionTimeT = new IVisualNovelTransitionTimeT();
			this.UnPackTo(visualNovelTransitionTimeT);
			return visualNovelTransitionTimeT;
		}

		// Token: 0x06037008 RID: 225288 RVA: 0x0077684C File Offset: 0x00774A4C
		public void UnPackTo(IVisualNovelTransitionTimeT _o)
		{
			_o.Type = this.Type;
			_o.EndDate = ((this.EndDate != null) ? this.EndDate.Value.UnPack() : null);
			_o.EndPeriodId = this.EndPeriodId;
			_o.IsFullScreen = this.IsFullScreen;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06037009 RID: 225289 RVA: 0x007768B8 File Offset: 0x00774AB8
		public static Offset<IVisualNovelTransitionTime> Pack(FlatBufferBuilder builder, IVisualNovelTransitionTimeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelTransitionTime>);
			}
			Offset<IVisualNovelDate> endDateOffset = (_o.EndDate == null) ? default(Offset<IVisualNovelDate>) : IVisualNovelDate.Pack(builder, _o.EndDate);
			return IVisualNovelTransitionTime.CreateIVisualNovelTransitionTime(builder, _o.Type, endDateOffset, _o.EndPeriodId, _o.IsFullScreen, _o.NullMask);
		}

		// Token: 0x04012560 RID: 75104
		private Table __p;
	}
}
