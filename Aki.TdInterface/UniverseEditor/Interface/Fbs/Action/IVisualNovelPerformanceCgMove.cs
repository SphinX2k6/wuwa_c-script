using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D9A RID: 32154
	public struct IVisualNovelPerformanceCgMove : IFlatbufferObject
	{
		// Token: 0x1700F08A RID: 61578
		// (get) Token: 0x0603A0D2 RID: 237778 RVA: 0x007D3467 File Offset: 0x007D1667
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603A0D3 RID: 237779 RVA: 0x007D3474 File Offset: 0x007D1674
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603A0D4 RID: 237780 RVA: 0x007D347C File Offset: 0x007D167C
		public static IVisualNovelPerformanceCgMove GetRootAsIVisualNovelPerformanceCgMove(ByteBuffer _bb)
		{
			return IVisualNovelPerformanceCgMove.GetRootAsIVisualNovelPerformanceCgMove(_bb, default(IVisualNovelPerformanceCgMove));
		}

		// Token: 0x0603A0D5 RID: 237781 RVA: 0x007D3498 File Offset: 0x007D1698
		public static IVisualNovelPerformanceCgMove GetRootAsIVisualNovelPerformanceCgMove(ByteBuffer _bb, IVisualNovelPerformanceCgMove obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603A0D6 RID: 237782 RVA: 0x007D34B5 File Offset: 0x007D16B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603A0D7 RID: 237783 RVA: 0x007D34C4 File Offset: 0x007D16C4
		public IVisualNovelPerformanceCgMove __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700F08B RID: 61579
		// (get) Token: 0x0603A0D8 RID: 237784 RVA: 0x007D34D4 File Offset: 0x007D16D4
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

		// Token: 0x1700F08C RID: 61580
		// (get) Token: 0x0603A0D9 RID: 237785 RVA: 0x007D3510 File Offset: 0x007D1710
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

		// Token: 0x1700F08D RID: 61581
		// (get) Token: 0x0603A0DA RID: 237786 RVA: 0x007D3550 File Offset: 0x007D1750
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

		// Token: 0x1700F08E RID: 61582
		// (get) Token: 0x0603A0DB RID: 237787 RVA: 0x007D35B0 File Offset: 0x007D17B0
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

		// Token: 0x1700F08F RID: 61583
		// (get) Token: 0x0603A0DC RID: 237788 RVA: 0x007D3610 File Offset: 0x007D1810
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

		// Token: 0x0603A0DD RID: 237789 RVA: 0x007D3650 File Offset: 0x007D1850
		public TTable? EaseCurve<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0603A0DE RID: 237790 RVA: 0x007D3698 File Offset: 0x007D1898
		public IEaseCurveCustom EaseCurveAsIEaseCurveCustom()
		{
			return this.EaseCurve<IEaseCurveCustom>().Value;
		}

		// Token: 0x0603A0DF RID: 237791 RVA: 0x007D36B4 File Offset: 0x007D18B4
		public IEaseCurvePreset EaseCurveAsIEaseCurvePreset()
		{
			return this.EaseCurve<IEaseCurvePreset>().Value;
		}

		// Token: 0x1700F090 RID: 61584
		// (get) Token: 0x0603A0E0 RID: 237792 RVA: 0x007D36D0 File Offset: 0x007D18D0
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

		// Token: 0x1700F091 RID: 61585
		// (get) Token: 0x0603A0E1 RID: 237793 RVA: 0x007D3714 File Offset: 0x007D1914
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

		// Token: 0x0603A0E2 RID: 237794 RVA: 0x007D3754 File Offset: 0x007D1954
		public static Offset<IVisualNovelPerformanceCgMove> CreateIVisualNovelPerformanceCgMove(FlatBufferBuilder builder, EVisualNovelPerformanceType Type = EVisualNovelPerformanceType.Enter, float StartTime = 0f, Offset<IVisualNovelPortraitTransform> StartTransformOffset = default(Offset<IVisualNovelPortraitTransform>), Offset<IVisualNovelPortraitTransform> TargetTransformOffset = default(Offset<IVisualNovelPortraitTransform>), TEaseCurveType EaseCurve_type = TEaseCurveType.NONE, int EaseCurveOffset = 0, float Duration = 0f, byte NullMask = 0)
		{
			builder.StartTable(8);
			IVisualNovelPerformanceCgMove.AddDuration(builder, Duration);
			IVisualNovelPerformanceCgMove.AddEaseCurve(builder, EaseCurveOffset);
			IVisualNovelPerformanceCgMove.AddTargetTransform(builder, TargetTransformOffset);
			IVisualNovelPerformanceCgMove.AddStartTransform(builder, StartTransformOffset);
			IVisualNovelPerformanceCgMove.AddStartTime(builder, StartTime);
			IVisualNovelPerformanceCgMove.AddNullMask(builder, NullMask);
			IVisualNovelPerformanceCgMove.AddEaseCurveType(builder, EaseCurve_type);
			IVisualNovelPerformanceCgMove.AddType(builder, Type);
			return IVisualNovelPerformanceCgMove.EndIVisualNovelPerformanceCgMove(builder);
		}

		// Token: 0x0603A0E3 RID: 237795 RVA: 0x007D37AB File Offset: 0x007D19AB
		public static void StartIVisualNovelPerformanceCgMove(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x0603A0E4 RID: 237796 RVA: 0x007D37B4 File Offset: 0x007D19B4
		public static void AddType(FlatBufferBuilder builder, EVisualNovelPerformanceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603A0E5 RID: 237797 RVA: 0x007D37BF File Offset: 0x007D19BF
		public static void AddStartTime(FlatBufferBuilder builder, float startTime)
		{
			builder.AddFloat(1, startTime, 0.0);
		}

		// Token: 0x0603A0E6 RID: 237798 RVA: 0x007D37D2 File Offset: 0x007D19D2
		public static void AddStartTransform(FlatBufferBuilder builder, Offset<IVisualNovelPortraitTransform> startTransformOffset)
		{
			builder.AddOffset(2, startTransformOffset.Value, 0);
		}

		// Token: 0x0603A0E7 RID: 237799 RVA: 0x007D37E2 File Offset: 0x007D19E2
		public static void AddTargetTransform(FlatBufferBuilder builder, Offset<IVisualNovelPortraitTransform> targetTransformOffset)
		{
			builder.AddOffset(3, targetTransformOffset.Value, 0);
		}

		// Token: 0x0603A0E8 RID: 237800 RVA: 0x007D37F2 File Offset: 0x007D19F2
		public static void AddEaseCurveType(FlatBufferBuilder builder, TEaseCurveType easeCurveType)
		{
			builder.AddByte(4, (byte)easeCurveType, 0);
		}

		// Token: 0x0603A0E9 RID: 237801 RVA: 0x007D37FD File Offset: 0x007D19FD
		public static void AddEaseCurve(FlatBufferBuilder builder, int easeCurveOffset)
		{
			builder.AddOffset(5, easeCurveOffset, 0);
		}

		// Token: 0x0603A0EA RID: 237802 RVA: 0x007D3808 File Offset: 0x007D1A08
		public static void AddDuration(FlatBufferBuilder builder, float duration)
		{
			builder.AddFloat(6, duration, 0.0);
		}

		// Token: 0x0603A0EB RID: 237803 RVA: 0x007D381B File Offset: 0x007D1A1B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x0603A0EC RID: 237804 RVA: 0x007D3826 File Offset: 0x007D1A26
		public static Offset<IVisualNovelPerformanceCgMove> EndIVisualNovelPerformanceCgMove(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelPerformanceCgMove>(builder.EndTable());
		}

		// Token: 0x0603A0ED RID: 237805 RVA: 0x007D3834 File Offset: 0x007D1A34
		public IVisualNovelPerformanceCgMoveT UnPack()
		{
			IVisualNovelPerformanceCgMoveT visualNovelPerformanceCgMoveT = new IVisualNovelPerformanceCgMoveT();
			this.UnPackTo(visualNovelPerformanceCgMoveT);
			return visualNovelPerformanceCgMoveT;
		}

		// Token: 0x0603A0EE RID: 237806 RVA: 0x007D3850 File Offset: 0x007D1A50
		public void UnPackTo(IVisualNovelPerformanceCgMoveT _o)
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

		// Token: 0x0603A0EF RID: 237807 RVA: 0x007D3988 File Offset: 0x007D1B88
		public static Offset<IVisualNovelPerformanceCgMove> Pack(FlatBufferBuilder builder, IVisualNovelPerformanceCgMoveT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelPerformanceCgMove>);
			}
			Offset<IVisualNovelPortraitTransform> startTransformOffset = (_o.StartTransform == null) ? default(Offset<IVisualNovelPortraitTransform>) : IVisualNovelPortraitTransform.Pack(builder, _o.StartTransform);
			Offset<IVisualNovelPortraitTransform> targetTransformOffset = (_o.TargetTransform == null) ? default(Offset<IVisualNovelPortraitTransform>) : IVisualNovelPortraitTransform.Pack(builder, _o.TargetTransform);
			TEaseCurveType easeCurve_type = (_o.EaseCurve == null) ? TEaseCurveType.NONE : _o.EaseCurve.Type;
			int easeCurveOffset = (_o.EaseCurve == null) ? 0 : TEaseCurveTypeUnion.Pack(builder, _o.EaseCurve);
			return IVisualNovelPerformanceCgMove.CreateIVisualNovelPerformanceCgMove(builder, _o.Type, _o.StartTime, startTransformOffset, targetTransformOffset, easeCurve_type, easeCurveOffset, _o.Duration, _o.NullMask);
		}

		// Token: 0x040134F9 RID: 79097
		private Table __p;
	}
}
