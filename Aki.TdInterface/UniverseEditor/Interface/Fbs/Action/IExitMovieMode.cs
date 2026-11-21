using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DA6 RID: 28070
	public struct IExitMovieMode : IFlatbufferObject
	{
		// Token: 0x1700CDD5 RID: 52693
		// (get) Token: 0x06030732 RID: 198450 RVA: 0x00694F96 File Offset: 0x00693196
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030733 RID: 198451 RVA: 0x00694FA3 File Offset: 0x006931A3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030734 RID: 198452 RVA: 0x00694FAC File Offset: 0x006931AC
		public static IExitMovieMode GetRootAsIExitMovieMode(ByteBuffer _bb)
		{
			return IExitMovieMode.GetRootAsIExitMovieMode(_bb, default(IExitMovieMode));
		}

		// Token: 0x06030735 RID: 198453 RVA: 0x00694FC8 File Offset: 0x006931C8
		public static IExitMovieMode GetRootAsIExitMovieMode(ByteBuffer _bb, IExitMovieMode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030736 RID: 198454 RVA: 0x00694FE5 File Offset: 0x006931E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030737 RID: 198455 RVA: 0x00694FF4 File Offset: 0x006931F4
		public IExitMovieMode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CDD6 RID: 52694
		// (get) Token: 0x06030738 RID: 198456 RVA: 0x00695004 File Offset: 0x00693204
		public float BorderAnimDuration
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CDD7 RID: 52695
		// (get) Token: 0x06030739 RID: 198457 RVA: 0x00695044 File Offset: 0x00693244
		public TEnterMovieModeDurationType DurationTypeType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TEnterMovieModeDurationType.NONE;
				}
				return (TEnterMovieModeDurationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603073A RID: 198458 RVA: 0x00695080 File Offset: 0x00693280
		public TTable? DurationType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0603073B RID: 198459 RVA: 0x006950C4 File Offset: 0x006932C4
		public IWaitMovieModeBorderAnimFinished DurationTypeAsIWaitMovieModeBorderAnimFinished()
		{
			return this.DurationType<IWaitMovieModeBorderAnimFinished>().Value;
		}

		// Token: 0x0603073C RID: 198460 RVA: 0x006950E0 File Offset: 0x006932E0
		public IWaitMovieModeFixedTime DurationTypeAsIWaitMovieModeFixedTime()
		{
			return this.DurationType<IWaitMovieModeFixedTime>().Value;
		}

		// Token: 0x1700CDD8 RID: 52696
		// (get) Token: 0x0603073D RID: 198461 RVA: 0x006950FC File Offset: 0x006932FC
		public IMovieModeFadeOutMaskConfig? FadeOutMaskConfig
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IMovieModeFadeOutMaskConfig?(default(IMovieModeFadeOutMaskConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700CDD9 RID: 52697
		// (get) Token: 0x0603073E RID: 198462 RVA: 0x0069515C File Offset: 0x0069335C
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

		// Token: 0x0603073F RID: 198463 RVA: 0x00695199 File Offset: 0x00693399
		public static Offset<IExitMovieMode> CreateIExitMovieMode(FlatBufferBuilder builder, float BorderAnimDuration = 0f, TEnterMovieModeDurationType DurationType_type = TEnterMovieModeDurationType.NONE, int DurationTypeOffset = 0, Offset<IMovieModeFadeOutMaskConfig> FadeOutMaskConfigOffset = default(Offset<IMovieModeFadeOutMaskConfig>), byte NullMask = 0)
		{
			builder.StartTable(5);
			IExitMovieMode.AddFadeOutMaskConfig(builder, FadeOutMaskConfigOffset);
			IExitMovieMode.AddDurationType(builder, DurationTypeOffset);
			IExitMovieMode.AddBorderAnimDuration(builder, BorderAnimDuration);
			IExitMovieMode.AddNullMask(builder, NullMask);
			IExitMovieMode.AddDurationTypeType(builder, DurationType_type);
			return IExitMovieMode.EndIExitMovieMode(builder);
		}

		// Token: 0x06030740 RID: 198464 RVA: 0x006951CD File Offset: 0x006933CD
		public static void StartIExitMovieMode(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06030741 RID: 198465 RVA: 0x006951D6 File Offset: 0x006933D6
		public static void AddBorderAnimDuration(FlatBufferBuilder builder, float borderAnimDuration)
		{
			builder.AddFloat(0, borderAnimDuration, 0.0);
		}

		// Token: 0x06030742 RID: 198466 RVA: 0x006951E9 File Offset: 0x006933E9
		public static void AddDurationTypeType(FlatBufferBuilder builder, TEnterMovieModeDurationType durationTypeType)
		{
			builder.AddByte(1, (byte)durationTypeType, 0);
		}

		// Token: 0x06030743 RID: 198467 RVA: 0x006951F4 File Offset: 0x006933F4
		public static void AddDurationType(FlatBufferBuilder builder, int durationTypeOffset)
		{
			builder.AddOffset(2, durationTypeOffset, 0);
		}

		// Token: 0x06030744 RID: 198468 RVA: 0x006951FF File Offset: 0x006933FF
		public static void AddFadeOutMaskConfig(FlatBufferBuilder builder, Offset<IMovieModeFadeOutMaskConfig> fadeOutMaskConfigOffset)
		{
			builder.AddOffset(3, fadeOutMaskConfigOffset.Value, 0);
		}

		// Token: 0x06030745 RID: 198469 RVA: 0x0069520F File Offset: 0x0069340F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06030746 RID: 198470 RVA: 0x0069521A File Offset: 0x0069341A
		public static Offset<IExitMovieMode> EndIExitMovieMode(FlatBufferBuilder builder)
		{
			return new Offset<IExitMovieMode>(builder.EndTable());
		}

		// Token: 0x06030747 RID: 198471 RVA: 0x00695228 File Offset: 0x00693428
		public IExitMovieModeT UnPack()
		{
			IExitMovieModeT exitMovieModeT = new IExitMovieModeT();
			this.UnPackTo(exitMovieModeT);
			return exitMovieModeT;
		}

		// Token: 0x06030748 RID: 198472 RVA: 0x00695244 File Offset: 0x00693444
		public void UnPackTo(IExitMovieModeT _o)
		{
			_o.BorderAnimDuration = this.BorderAnimDuration;
			_o.DurationType = new TEnterMovieModeDurationTypeUnion();
			_o.DurationType.Type = this.DurationTypeType;
			TEnterMovieModeDurationType durationTypeType = this.DurationTypeType;
			if (durationTypeType != TEnterMovieModeDurationType.IWaitMovieModeBorderAnimFinished)
			{
				if (durationTypeType == TEnterMovieModeDurationType.IWaitMovieModeFixedTime)
				{
					_o.DurationType.Value = ((this.DurationType<IWaitMovieModeFixedTime>() != null) ? this.DurationType<IWaitMovieModeFixedTime>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.DurationType.Value = ((this.DurationType<IWaitMovieModeBorderAnimFinished>() != null) ? this.DurationType<IWaitMovieModeBorderAnimFinished>().Value.UnPack() : null);
			}
			_o.FadeOutMaskConfig = ((this.FadeOutMaskConfig != null) ? this.FadeOutMaskConfig.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06030749 RID: 198473 RVA: 0x00695334 File Offset: 0x00693534
		public static Offset<IExitMovieMode> Pack(FlatBufferBuilder builder, IExitMovieModeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IExitMovieMode>);
			}
			TEnterMovieModeDurationType durationType_type = (_o.DurationType == null) ? TEnterMovieModeDurationType.NONE : _o.DurationType.Type;
			int durationTypeOffset = (_o.DurationType == null) ? 0 : TEnterMovieModeDurationTypeUnion.Pack(builder, _o.DurationType);
			Offset<IMovieModeFadeOutMaskConfig> fadeOutMaskConfigOffset = (_o.FadeOutMaskConfig == null) ? default(Offset<IMovieModeFadeOutMaskConfig>) : IMovieModeFadeOutMaskConfig.Pack(builder, _o.FadeOutMaskConfig);
			return IExitMovieMode.CreateIExitMovieMode(builder, _o.BorderAnimDuration, durationType_type, durationTypeOffset, fadeOutMaskConfigOffset, _o.NullMask);
		}

		// Token: 0x04011C3D RID: 72765
		private Table __p;
	}
}
