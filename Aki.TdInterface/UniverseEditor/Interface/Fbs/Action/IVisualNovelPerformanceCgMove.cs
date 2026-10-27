using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075A1 RID: 30113
	public struct IVisualNovelPerformanceCgMove : IFlatbufferObject
	{
		// Token: 0x1700E45D RID: 58461
		// (get) Token: 0x06036CA4 RID: 224420 RVA: 0x0076FEE8 File Offset: 0x0076E0E8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036CA5 RID: 224421 RVA: 0x0076FEF5 File Offset: 0x0076E0F5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036CA6 RID: 224422 RVA: 0x0076FEFC File Offset: 0x0076E0FC
		public static IVisualNovelPerformanceCgMove GetRootAsIVisualNovelPerformanceCgMove(ByteBuffer _bb)
		{
			return IVisualNovelPerformanceCgMove.GetRootAsIVisualNovelPerformanceCgMove(_bb, default(IVisualNovelPerformanceCgMove));
		}

		// Token: 0x06036CA7 RID: 224423 RVA: 0x0076FF18 File Offset: 0x0076E118
		public static IVisualNovelPerformanceCgMove GetRootAsIVisualNovelPerformanceCgMove(ByteBuffer _bb, IVisualNovelPerformanceCgMove obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036CA8 RID: 224424 RVA: 0x0076FF35 File Offset: 0x0076E135
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036CA9 RID: 224425 RVA: 0x0076FF44 File Offset: 0x0076E144
		public IVisualNovelPerformanceCgMove __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E45E RID: 58462
		// (get) Token: 0x06036CAA RID: 224426 RVA: 0x0076FF54 File Offset: 0x0076E154
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

		// Token: 0x1700E45F RID: 58463
		// (get) Token: 0x06036CAB RID: 224427 RVA: 0x0076FF90 File Offset: 0x0076E190
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

		// Token: 0x1700E460 RID: 58464
		// (get) Token: 0x06036CAC RID: 224428 RVA: 0x0076FFD0 File Offset: 0x0076E1D0
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

		// Token: 0x1700E461 RID: 58465
		// (get) Token: 0x06036CAD RID: 224429 RVA: 0x00770030 File Offset: 0x0076E230
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

		// Token: 0x1700E462 RID: 58466
		// (get) Token: 0x06036CAE RID: 224430 RVA: 0x00770090 File Offset: 0x0076E290
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

		// Token: 0x06036CAF RID: 224431 RVA: 0x007700D0 File Offset: 0x0076E2D0
		public TTable? EaseCurve<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06036CB0 RID: 224432 RVA: 0x00770118 File Offset: 0x0076E318
		public IEaseCurveCustom EaseCurveAsIEaseCurveCustom()
		{
			return this.EaseCurve<IEaseCurveCustom>().Value;
		}

		// Token: 0x06036CB1 RID: 224433 RVA: 0x00770134 File Offset: 0x0076E334
		public IEaseCurvePreset EaseCurveAsIEaseCurvePreset()
		{
			return this.EaseCurve<IEaseCurvePreset>().Value;
		}

		// Token: 0x1700E463 RID: 58467
		// (get) Token: 0x06036CB2 RID: 224434 RVA: 0x00770150 File Offset: 0x0076E350
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

		// Token: 0x1700E464 RID: 58468
		// (get) Token: 0x06036CB3 RID: 224435 RVA: 0x00770194 File Offset: 0x0076E394
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

		// Token: 0x06036CB4 RID: 224436 RVA: 0x007701D4 File Offset: 0x0076E3D4
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

		// Token: 0x06036CB5 RID: 224437 RVA: 0x0077022B File Offset: 0x0076E42B
		public static void StartIVisualNovelPerformanceCgMove(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x06036CB6 RID: 224438 RVA: 0x00770234 File Offset: 0x0076E434
		public static void AddType(FlatBufferBuilder builder, EVisualNovelPerformanceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036CB7 RID: 224439 RVA: 0x0077023F File Offset: 0x0076E43F
		public static void AddStartTime(FlatBufferBuilder builder, float startTime)
		{
			builder.AddFloat(1, startTime, 0.0);
		}

		// Token: 0x06036CB8 RID: 224440 RVA: 0x00770252 File Offset: 0x0076E452
		public static void AddStartTransform(FlatBufferBuilder builder, Offset<IVisualNovelPortraitTransform> startTransformOffset)
		{
			builder.AddOffset(2, startTransformOffset.Value, 0);
		}

		// Token: 0x06036CB9 RID: 224441 RVA: 0x00770262 File Offset: 0x0076E462
		public static void AddTargetTransform(FlatBufferBuilder builder, Offset<IVisualNovelPortraitTransform> targetTransformOffset)
		{
			builder.AddOffset(3, targetTransformOffset.Value, 0);
		}

		// Token: 0x06036CBA RID: 224442 RVA: 0x00770272 File Offset: 0x0076E472
		public static void AddEaseCurveType(FlatBufferBuilder builder, TEaseCurveType easeCurveType)
		{
			builder.AddByte(4, (byte)easeCurveType, 0);
		}

		// Token: 0x06036CBB RID: 224443 RVA: 0x0077027D File Offset: 0x0076E47D
		public static void AddEaseCurve(FlatBufferBuilder builder, int easeCurveOffset)
		{
			builder.AddOffset(5, easeCurveOffset, 0);
		}

		// Token: 0x06036CBC RID: 224444 RVA: 0x00770288 File Offset: 0x0076E488
		public static void AddDuration(FlatBufferBuilder builder, float duration)
		{
			builder.AddFloat(6, duration, 0.0);
		}

		// Token: 0x06036CBD RID: 224445 RVA: 0x0077029B File Offset: 0x0076E49B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x06036CBE RID: 224446 RVA: 0x007702A6 File Offset: 0x0076E4A6
		public static Offset<IVisualNovelPerformanceCgMove> EndIVisualNovelPerformanceCgMove(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelPerformanceCgMove>(builder.EndTable());
		}

		// Token: 0x06036CBF RID: 224447 RVA: 0x007702B4 File Offset: 0x0076E4B4
		public IVisualNovelPerformanceCgMoveT UnPack()
		{
			IVisualNovelPerformanceCgMoveT visualNovelPerformanceCgMoveT = new IVisualNovelPerformanceCgMoveT();
			this.UnPackTo(visualNovelPerformanceCgMoveT);
			return visualNovelPerformanceCgMoveT;
		}

		// Token: 0x06036CC0 RID: 224448 RVA: 0x007702D0 File Offset: 0x0076E4D0
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

		// Token: 0x06036CC1 RID: 224449 RVA: 0x00770408 File Offset: 0x0076E608
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

		// Token: 0x040124C6 RID: 74950
		private Table __p;
	}
}
