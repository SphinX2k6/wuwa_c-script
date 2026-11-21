using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D8E RID: 32142
	public struct IVisualNovelPerformanceActivityAction : IFlatbufferObject
	{
		// Token: 0x1700F069 RID: 61545
		// (get) Token: 0x0603A042 RID: 237634 RVA: 0x007D21A1 File Offset: 0x007D03A1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603A043 RID: 237635 RVA: 0x007D21AE File Offset: 0x007D03AE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603A044 RID: 237636 RVA: 0x007D21B8 File Offset: 0x007D03B8
		public static IVisualNovelPerformanceActivityAction GetRootAsIVisualNovelPerformanceActivityAction(ByteBuffer _bb)
		{
			return IVisualNovelPerformanceActivityAction.GetRootAsIVisualNovelPerformanceActivityAction(_bb, default(IVisualNovelPerformanceActivityAction));
		}

		// Token: 0x0603A045 RID: 237637 RVA: 0x007D21D4 File Offset: 0x007D03D4
		public static IVisualNovelPerformanceActivityAction GetRootAsIVisualNovelPerformanceActivityAction(ByteBuffer _bb, IVisualNovelPerformanceActivityAction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603A046 RID: 237638 RVA: 0x007D21F1 File Offset: 0x007D03F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603A047 RID: 237639 RVA: 0x007D2200 File Offset: 0x007D0400
		public IVisualNovelPerformanceActivityAction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700F06A RID: 61546
		// (get) Token: 0x0603A048 RID: 237640 RVA: 0x007D2210 File Offset: 0x007D0410
		public EVisualNovelPerformanceType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVisualNovelPerformanceType.Enter;
				}
				return (EVisualNovelPerformanceType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700F06B RID: 61547
		// (get) Token: 0x0603A049 RID: 237641 RVA: 0x007D224C File Offset: 0x007D044C
		public float StartTime
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700F06C RID: 61548
		// (get) Token: 0x0603A04A RID: 237642 RVA: 0x007D228C File Offset: 0x007D048C
		public IVisualNovelActivityActionSolarSchool? ActivityActionConfig
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IVisualNovelActivityActionSolarSchool?(default(IVisualNovelActivityActionSolarSchool).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700F06D RID: 61549
		// (get) Token: 0x0603A04B RID: 237643 RVA: 0x007D22EC File Offset: 0x007D04EC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603A04C RID: 237644 RVA: 0x007D2329 File Offset: 0x007D0529
		public static Offset<IVisualNovelPerformanceActivityAction> CreateIVisualNovelPerformanceActivityAction(FlatBufferBuilder builder, EVisualNovelPerformanceType Type = EVisualNovelPerformanceType.Enter, float StartTime = 0f, Offset<IVisualNovelActivityActionSolarSchool> ActivityActionConfigOffset = default(Offset<IVisualNovelActivityActionSolarSchool>), byte NullMask = 0)
		{
			builder.StartTable(4);
			IVisualNovelPerformanceActivityAction.AddActivityActionConfig(builder, ActivityActionConfigOffset);
			IVisualNovelPerformanceActivityAction.AddStartTime(builder, StartTime);
			IVisualNovelPerformanceActivityAction.AddNullMask(builder, NullMask);
			IVisualNovelPerformanceActivityAction.AddType(builder, Type);
			return IVisualNovelPerformanceActivityAction.EndIVisualNovelPerformanceActivityAction(builder);
		}

		// Token: 0x0603A04D RID: 237645 RVA: 0x007D2355 File Offset: 0x007D0555
		public static void StartIVisualNovelPerformanceActivityAction(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0603A04E RID: 237646 RVA: 0x007D235E File Offset: 0x007D055E
		public static void AddType(FlatBufferBuilder builder, EVisualNovelPerformanceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603A04F RID: 237647 RVA: 0x007D2369 File Offset: 0x007D0569
		public static void AddStartTime(FlatBufferBuilder builder, float startTime)
		{
			builder.AddFloat(1, startTime, 0.0);
		}

		// Token: 0x0603A050 RID: 237648 RVA: 0x007D237C File Offset: 0x007D057C
		public static void AddActivityActionConfig(FlatBufferBuilder builder, Offset<IVisualNovelActivityActionSolarSchool> activityActionConfigOffset)
		{
			builder.AddOffset(2, activityActionConfigOffset.Value, 0);
		}

		// Token: 0x0603A051 RID: 237649 RVA: 0x007D238C File Offset: 0x007D058C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0603A052 RID: 237650 RVA: 0x007D2397 File Offset: 0x007D0597
		public static Offset<IVisualNovelPerformanceActivityAction> EndIVisualNovelPerformanceActivityAction(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelPerformanceActivityAction>(builder.EndTable());
		}

		// Token: 0x0603A053 RID: 237651 RVA: 0x007D23A4 File Offset: 0x007D05A4
		public IVisualNovelPerformanceActivityActionT UnPack()
		{
			IVisualNovelPerformanceActivityActionT visualNovelPerformanceActivityActionT = new IVisualNovelPerformanceActivityActionT();
			this.UnPackTo(visualNovelPerformanceActivityActionT);
			return visualNovelPerformanceActivityActionT;
		}

		// Token: 0x0603A054 RID: 237652 RVA: 0x007D23C0 File Offset: 0x007D05C0
		public void UnPackTo(IVisualNovelPerformanceActivityActionT _o)
		{
			_o.Type = this.Type;
			_o.StartTime = this.StartTime;
			_o.ActivityActionConfig = ((this.ActivityActionConfig != null) ? this.ActivityActionConfig.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0603A055 RID: 237653 RVA: 0x007D2420 File Offset: 0x007D0620
		public static Offset<IVisualNovelPerformanceActivityAction> Pack(FlatBufferBuilder builder, IVisualNovelPerformanceActivityActionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelPerformanceActivityAction>);
			}
			Offset<IVisualNovelActivityActionSolarSchool> activityActionConfigOffset = (_o.ActivityActionConfig == null) ? default(Offset<IVisualNovelActivityActionSolarSchool>) : IVisualNovelActivityActionSolarSchool.Pack(builder, _o.ActivityActionConfig);
			return IVisualNovelPerformanceActivityAction.CreateIVisualNovelPerformanceActivityAction(builder, _o.Type, _o.StartTime, activityActionConfigOffset, _o.NullMask);
		}

		// Token: 0x040134D3 RID: 79059
		private Table __p;
	}
}
