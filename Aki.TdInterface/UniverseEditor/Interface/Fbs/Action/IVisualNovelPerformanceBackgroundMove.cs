using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D91 RID: 32145
	public struct IVisualNovelPerformanceBackgroundMove : IFlatbufferObject
	{
		// Token: 0x1700F072 RID: 61554
		// (get) Token: 0x0603A060 RID: 237664 RVA: 0x007D2553 File Offset: 0x007D0753
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603A061 RID: 237665 RVA: 0x007D2560 File Offset: 0x007D0760
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603A062 RID: 237666 RVA: 0x007D2568 File Offset: 0x007D0768
		public static IVisualNovelPerformanceBackgroundMove GetRootAsIVisualNovelPerformanceBackgroundMove(ByteBuffer _bb)
		{
			return IVisualNovelPerformanceBackgroundMove.GetRootAsIVisualNovelPerformanceBackgroundMove(_bb, default(IVisualNovelPerformanceBackgroundMove));
		}

		// Token: 0x0603A063 RID: 237667 RVA: 0x007D2584 File Offset: 0x007D0784
		public static IVisualNovelPerformanceBackgroundMove GetRootAsIVisualNovelPerformanceBackgroundMove(ByteBuffer _bb, IVisualNovelPerformanceBackgroundMove obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603A064 RID: 237668 RVA: 0x007D25A1 File Offset: 0x007D07A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603A065 RID: 237669 RVA: 0x007D25B0 File Offset: 0x007D07B0
		public IVisualNovelPerformanceBackgroundMove __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700F073 RID: 61555
		// (get) Token: 0x0603A066 RID: 237670 RVA: 0x007D25C0 File Offset: 0x007D07C0
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

		// Token: 0x1700F074 RID: 61556
		// (get) Token: 0x0603A067 RID: 237671 RVA: 0x007D25FC File Offset: 0x007D07FC
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

		// Token: 0x1700F075 RID: 61557
		// (get) Token: 0x0603A068 RID: 237672 RVA: 0x007D263C File Offset: 0x007D083C
		public IVisualNovelPortraitTransform? StartTransform
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IVisualNovelPortraitTransform?(default(IVisualNovelPortraitTransform).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700F076 RID: 61558
		// (get) Token: 0x0603A069 RID: 237673 RVA: 0x007D269C File Offset: 0x007D089C
		public IVisualNovelPortraitTransform? TargetTransform
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IVisualNovelPortraitTransform?(default(IVisualNovelPortraitTransform).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700F077 RID: 61559
		// (get) Token: 0x0603A06A RID: 237674 RVA: 0x007D26FC File Offset: 0x007D08FC
		public TEaseCurveType EaseCurveType
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return TEaseCurveType.NONE;
				}
				return (TEaseCurveType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603A06B RID: 237675 RVA: 0x007D273C File Offset: 0x007D093C
		public TTable? EaseCurve<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0603A06C RID: 237676 RVA: 0x007D2784 File Offset: 0x007D0984
		public IEaseCurveCustom EaseCurveAsIEaseCurveCustom()
		{
			return this.EaseCurve<IEaseCurveCustom>().Value;
		}

		// Token: 0x0603A06D RID: 237677 RVA: 0x007D27A0 File Offset: 0x007D09A0
		public IEaseCurvePreset EaseCurveAsIEaseCurvePreset()
		{
			return this.EaseCurve<IEaseCurvePreset>().Value;
		}

		// Token: 0x1700F078 RID: 61560
		// (get) Token: 0x0603A06E RID: 237678 RVA: 0x007D27BC File Offset: 0x007D09BC
		public float Duration
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700F079 RID: 61561
		// (get) Token: 0x0603A06F RID: 237679 RVA: 0x007D2800 File Offset: 0x007D0A00
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603A070 RID: 237680 RVA: 0x007D2840 File Offset: 0x007D0A40
		public static Offset<IVisualNovelPerformanceBackgroundMove> CreateIVisualNovelPerformanceBackgroundMove(FlatBufferBuilder builder, EVisualNovelPerformanceType Type = EVisualNovelPerformanceType.Enter, float StartTime = 0f, Offset<IVisualNovelPortraitTransform> StartTransformOffset = default(Offset<IVisualNovelPortraitTransform>), Offset<IVisualNovelPortraitTransform> TargetTransformOffset = default(Offset<IVisualNovelPortraitTransform>), TEaseCurveType EaseCurve_type = TEaseCurveType.NONE, int EaseCurveOffset = 0, float Duration = 0f, byte NullMask = 0)
		{
			builder.StartTable(8);
			IVisualNovelPerformanceBackgroundMove.AddDuration(builder, Duration);
			IVisualNovelPerformanceBackgroundMove.AddEaseCurve(builder, EaseCurveOffset);
			IVisualNovelPerformanceBackgroundMove.AddTargetTransform(builder, TargetTransformOffset);
			IVisualNovelPerformanceBackgroundMove.AddStartTransform(builder, StartTransformOffset);
			IVisualNovelPerformanceBackgroundMove.AddStartTime(builder, StartTime);
			IVisualNovelPerformanceBackgroundMove.AddNullMask(builder, NullMask);
			IVisualNovelPerformanceBackgroundMove.AddEaseCurveType(builder, EaseCurve_type);
			IVisualNovelPerformanceBackgroundMove.AddType(builder, Type);
			return IVisualNovelPerformanceBackgroundMove.EndIVisualNovelPerformanceBackgroundMove(builder);
		}

		// Token: 0x0603A071 RID: 237681 RVA: 0x007D2897 File Offset: 0x007D0A97
		public static void StartIVisualNovelPerformanceBackgroundMove(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x0603A072 RID: 237682 RVA: 0x007D28A0 File Offset: 0x007D0AA0
		public static void AddType(FlatBufferBuilder builder, EVisualNovelPerformanceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603A073 RID: 237683 RVA: 0x007D28AB File Offset: 0x007D0AAB
		public static void AddStartTime(FlatBufferBuilder builder, float startTime)
		{
			builder.AddFloat(1, startTime, 0.0);
		}

		// Token: 0x0603A074 RID: 237684 RVA: 0x007D28BE File Offset: 0x007D0ABE
		public static void AddStartTransform(FlatBufferBuilder builder, Offset<IVisualNovelPortraitTransform> startTransformOffset)
		{
			builder.AddOffset(2, startTransformOffset.Value, 0);
		}

		// Token: 0x0603A075 RID: 237685 RVA: 0x007D28CE File Offset: 0x007D0ACE
		public static void AddTargetTransform(FlatBufferBuilder builder, Offset<IVisualNovelPortraitTransform> targetTransformOffset)
		{
			builder.AddOffset(3, targetTransformOffset.Value, 0);
		}

		// Token: 0x0603A076 RID: 237686 RVA: 0x007D28DE File Offset: 0x007D0ADE
		public static void AddEaseCurveType(FlatBufferBuilder builder, TEaseCurveType easeCurveType)
		{
			builder.AddByte(4, (byte)easeCurveType, 0);
		}

		// Token: 0x0603A077 RID: 237687 RVA: 0x007D28E9 File Offset: 0x007D0AE9
		public static void AddEaseCurve(FlatBufferBuilder builder, int easeCurveOffset)
		{
			builder.AddOffset(5, easeCurveOffset, 0);
		}

		// Token: 0x0603A078 RID: 237688 RVA: 0x007D28F4 File Offset: 0x007D0AF4
		public static void AddDuration(FlatBufferBuilder builder, float duration)
		{
			builder.AddFloat(6, duration, 0.0);
		}

		// Token: 0x0603A079 RID: 237689 RVA: 0x007D2907 File Offset: 0x007D0B07
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x0603A07A RID: 237690 RVA: 0x007D2912 File Offset: 0x007D0B12
		public static Offset<IVisualNovelPerformanceBackgroundMove> EndIVisualNovelPerformanceBackgroundMove(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelPerformanceBackgroundMove>(builder.EndTable());
		}

		// Token: 0x0603A07B RID: 237691 RVA: 0x007D2920 File Offset: 0x007D0B20
		public IVisualNovelPerformanceBackgroundMoveT UnPack()
		{
			IVisualNovelPerformanceBackgroundMoveT visualNovelPerformanceBackgroundMoveT = new IVisualNovelPerformanceBackgroundMoveT();
			this.UnPackTo(visualNovelPerformanceBackgroundMoveT);
			return visualNovelPerformanceBackgroundMoveT;
		}

		// Token: 0x0603A07C RID: 237692 RVA: 0x007D293C File Offset: 0x007D0B3C
		public void UnPackTo(IVisualNovelPerformanceBackgroundMoveT _o)
		{
			_o.Type = this.Type;
			_o.StartTime = this.StartTime;
			_o.StartTransform = ((this.StartTransform != null) ? this.StartTransform.Value.UnPack() : null);
			_o.TargetTransform = ((this.TargetTransform != null) ? this.TargetTransform.Value.UnPack() : null);
			_o.EaseCurve = new TEaseCurveTypeUnion();
			_o.EaseCurve.Type = this.EaseCurveType;
			TEaseCurveType easeCurveType = this.EaseCurveType;
			if (easeCurveType != TEaseCurveType.IEaseCurveCustom)
			{
				if (easeCurveType == TEaseCurveType.IEaseCurvePreset)
				{
					_o.EaseCurve.Value = ((this.EaseCurve<IEaseCurvePreset>() != null) ? this.EaseCurve<IEaseCurvePreset>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.EaseCurve.Value = ((this.EaseCurve<IEaseCurveCustom>() != null) ? this.EaseCurve<IEaseCurveCustom>().Value.UnPack() : null);
			}
			_o.Duration = this.Duration;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0603A07D RID: 237693 RVA: 0x007D2A74 File Offset: 0x007D0C74
		public static Offset<IVisualNovelPerformanceBackgroundMove> Pack(FlatBufferBuilder builder, IVisualNovelPerformanceBackgroundMoveT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelPerformanceBackgroundMove>);
			}
			Offset<IVisualNovelPortraitTransform> startTransformOffset = (_o.StartTransform == null) ? default(Offset<IVisualNovelPortraitTransform>) : IVisualNovelPortraitTransform.Pack(builder, _o.StartTransform);
			Offset<IVisualNovelPortraitTransform> targetTransformOffset = (_o.TargetTransform == null) ? default(Offset<IVisualNovelPortraitTransform>) : IVisualNovelPortraitTransform.Pack(builder, _o.TargetTransform);
			TEaseCurveType easeCurve_type = (_o.EaseCurve == null) ? TEaseCurveType.NONE : _o.EaseCurve.Type;
			int easeCurveOffset = (_o.EaseCurve == null) ? 0 : TEaseCurveTypeUnion.Pack(builder, _o.EaseCurve);
			return IVisualNovelPerformanceBackgroundMove.CreateIVisualNovelPerformanceBackgroundMove(builder, _o.Type, _o.StartTime, startTransformOffset, targetTransformOffset, easeCurve_type, easeCurveOffset, _o.Duration, _o.NullMask);
		}

		// Token: 0x040134D8 RID: 79064
		private Table __p;
	}
}
