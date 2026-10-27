using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007598 RID: 30104
	public struct IVisualNovelPerformanceBackgroundMove : IFlatbufferObject
	{
		// Token: 0x1700E445 RID: 58437
		// (get) Token: 0x06036C30 RID: 224304 RVA: 0x0076EF8B File Offset: 0x0076D18B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036C31 RID: 224305 RVA: 0x0076EF98 File Offset: 0x0076D198
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036C32 RID: 224306 RVA: 0x0076EFA0 File Offset: 0x0076D1A0
		public static IVisualNovelPerformanceBackgroundMove GetRootAsIVisualNovelPerformanceBackgroundMove(ByteBuffer _bb)
		{
			return IVisualNovelPerformanceBackgroundMove.GetRootAsIVisualNovelPerformanceBackgroundMove(_bb, default(IVisualNovelPerformanceBackgroundMove));
		}

		// Token: 0x06036C33 RID: 224307 RVA: 0x0076EFBC File Offset: 0x0076D1BC
		public static IVisualNovelPerformanceBackgroundMove GetRootAsIVisualNovelPerformanceBackgroundMove(ByteBuffer _bb, IVisualNovelPerformanceBackgroundMove obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036C34 RID: 224308 RVA: 0x0076EFD9 File Offset: 0x0076D1D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036C35 RID: 224309 RVA: 0x0076EFE8 File Offset: 0x0076D1E8
		public IVisualNovelPerformanceBackgroundMove __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E446 RID: 58438
		// (get) Token: 0x06036C36 RID: 224310 RVA: 0x0076EFF8 File Offset: 0x0076D1F8
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

		// Token: 0x1700E447 RID: 58439
		// (get) Token: 0x06036C37 RID: 224311 RVA: 0x0076F034 File Offset: 0x0076D234
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

		// Token: 0x1700E448 RID: 58440
		// (get) Token: 0x06036C38 RID: 224312 RVA: 0x0076F074 File Offset: 0x0076D274
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

		// Token: 0x1700E449 RID: 58441
		// (get) Token: 0x06036C39 RID: 224313 RVA: 0x0076F0D4 File Offset: 0x0076D2D4
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

		// Token: 0x1700E44A RID: 58442
		// (get) Token: 0x06036C3A RID: 224314 RVA: 0x0076F134 File Offset: 0x0076D334
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

		// Token: 0x06036C3B RID: 224315 RVA: 0x0076F174 File Offset: 0x0076D374
		public TTable? EaseCurve<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06036C3C RID: 224316 RVA: 0x0076F1BC File Offset: 0x0076D3BC
		public IEaseCurveCustom EaseCurveAsIEaseCurveCustom()
		{
			return this.EaseCurve<IEaseCurveCustom>().Value;
		}

		// Token: 0x06036C3D RID: 224317 RVA: 0x0076F1D8 File Offset: 0x0076D3D8
		public IEaseCurvePreset EaseCurveAsIEaseCurvePreset()
		{
			return this.EaseCurve<IEaseCurvePreset>().Value;
		}

		// Token: 0x1700E44B RID: 58443
		// (get) Token: 0x06036C3E RID: 224318 RVA: 0x0076F1F4 File Offset: 0x0076D3F4
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

		// Token: 0x1700E44C RID: 58444
		// (get) Token: 0x06036C3F RID: 224319 RVA: 0x0076F238 File Offset: 0x0076D438
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

		// Token: 0x06036C40 RID: 224320 RVA: 0x0076F278 File Offset: 0x0076D478
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

		// Token: 0x06036C41 RID: 224321 RVA: 0x0076F2CF File Offset: 0x0076D4CF
		public static void StartIVisualNovelPerformanceBackgroundMove(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x06036C42 RID: 224322 RVA: 0x0076F2D8 File Offset: 0x0076D4D8
		public static void AddType(FlatBufferBuilder builder, EVisualNovelPerformanceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036C43 RID: 224323 RVA: 0x0076F2E3 File Offset: 0x0076D4E3
		public static void AddStartTime(FlatBufferBuilder builder, float startTime)
		{
			builder.AddFloat(1, startTime, 0.0);
		}

		// Token: 0x06036C44 RID: 224324 RVA: 0x0076F2F6 File Offset: 0x0076D4F6
		public static void AddStartTransform(FlatBufferBuilder builder, Offset<IVisualNovelPortraitTransform> startTransformOffset)
		{
			builder.AddOffset(2, startTransformOffset.Value, 0);
		}

		// Token: 0x06036C45 RID: 224325 RVA: 0x0076F306 File Offset: 0x0076D506
		public static void AddTargetTransform(FlatBufferBuilder builder, Offset<IVisualNovelPortraitTransform> targetTransformOffset)
		{
			builder.AddOffset(3, targetTransformOffset.Value, 0);
		}

		// Token: 0x06036C46 RID: 224326 RVA: 0x0076F316 File Offset: 0x0076D516
		public static void AddEaseCurveType(FlatBufferBuilder builder, TEaseCurveType easeCurveType)
		{
			builder.AddByte(4, (byte)easeCurveType, 0);
		}

		// Token: 0x06036C47 RID: 224327 RVA: 0x0076F321 File Offset: 0x0076D521
		public static void AddEaseCurve(FlatBufferBuilder builder, int easeCurveOffset)
		{
			builder.AddOffset(5, easeCurveOffset, 0);
		}

		// Token: 0x06036C48 RID: 224328 RVA: 0x0076F32C File Offset: 0x0076D52C
		public static void AddDuration(FlatBufferBuilder builder, float duration)
		{
			builder.AddFloat(6, duration, 0.0);
		}

		// Token: 0x06036C49 RID: 224329 RVA: 0x0076F33F File Offset: 0x0076D53F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x06036C4A RID: 224330 RVA: 0x0076F34A File Offset: 0x0076D54A
		public static Offset<IVisualNovelPerformanceBackgroundMove> EndIVisualNovelPerformanceBackgroundMove(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelPerformanceBackgroundMove>(builder.EndTable());
		}

		// Token: 0x06036C4B RID: 224331 RVA: 0x0076F358 File Offset: 0x0076D558
		public IVisualNovelPerformanceBackgroundMoveT UnPack()
		{
			IVisualNovelPerformanceBackgroundMoveT visualNovelPerformanceBackgroundMoveT = new IVisualNovelPerformanceBackgroundMoveT();
			this.UnPackTo(visualNovelPerformanceBackgroundMoveT);
			return visualNovelPerformanceBackgroundMoveT;
		}

		// Token: 0x06036C4C RID: 224332 RVA: 0x0076F374 File Offset: 0x0076D574
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

		// Token: 0x06036C4D RID: 224333 RVA: 0x0076F4AC File Offset: 0x0076D6AC
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

		// Token: 0x040124A4 RID: 74916
		private Table __p;
	}
}
