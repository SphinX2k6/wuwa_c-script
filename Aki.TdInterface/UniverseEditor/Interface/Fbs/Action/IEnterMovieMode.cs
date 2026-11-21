using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D2E RID: 27950
	public struct IEnterMovieMode : IFlatbufferObject
	{
		// Token: 0x1700CD06 RID: 52486
		// (get) Token: 0x0603034B RID: 197451 RVA: 0x0068DC72 File Offset: 0x0068BE72
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603034C RID: 197452 RVA: 0x0068DC7F File Offset: 0x0068BE7F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603034D RID: 197453 RVA: 0x0068DC88 File Offset: 0x0068BE88
		public static IEnterMovieMode GetRootAsIEnterMovieMode(ByteBuffer _bb)
		{
			return IEnterMovieMode.GetRootAsIEnterMovieMode(_bb, default(IEnterMovieMode));
		}

		// Token: 0x0603034E RID: 197454 RVA: 0x0068DCA4 File Offset: 0x0068BEA4
		public static IEnterMovieMode GetRootAsIEnterMovieMode(ByteBuffer _bb, IEnterMovieMode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603034F RID: 197455 RVA: 0x0068DCC1 File Offset: 0x0068BEC1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030350 RID: 197456 RVA: 0x0068DCD0 File Offset: 0x0068BED0
		public IEnterMovieMode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CD07 RID: 52487
		// (get) Token: 0x06030351 RID: 197457 RVA: 0x0068DCE0 File Offset: 0x0068BEE0
		public IMovieCameraConfig? MovieCameraConfig
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IMovieCameraConfig?(default(IMovieCameraConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700CD08 RID: 52488
		// (get) Token: 0x06030352 RID: 197458 RVA: 0x0068DD40 File Offset: 0x0068BF40
		public IEnableFuncConfig? EnableFuncConfig
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IEnableFuncConfig?(default(IEnableFuncConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700CD09 RID: 52489
		// (get) Token: 0x06030353 RID: 197459 RVA: 0x0068DDA0 File Offset: 0x0068BFA0
		public float BorderAnimDuration
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CD0A RID: 52490
		// (get) Token: 0x06030354 RID: 197460 RVA: 0x0068DDE0 File Offset: 0x0068BFE0
		public TEnterMovieModeDurationType DurationTypeType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return TEnterMovieModeDurationType.NONE;
				}
				return (TEnterMovieModeDurationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030355 RID: 197461 RVA: 0x0068DE20 File Offset: 0x0068C020
		public TTable? DurationType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06030356 RID: 197462 RVA: 0x0068DE68 File Offset: 0x0068C068
		public IWaitMovieModeBorderAnimFinished DurationTypeAsIWaitMovieModeBorderAnimFinished()
		{
			return this.DurationType<IWaitMovieModeBorderAnimFinished>().Value;
		}

		// Token: 0x06030357 RID: 197463 RVA: 0x0068DE84 File Offset: 0x0068C084
		public IWaitMovieModeFixedTime DurationTypeAsIWaitMovieModeFixedTime()
		{
			return this.DurationType<IWaitMovieModeFixedTime>().Value;
		}

		// Token: 0x1700CD0B RID: 52491
		// (get) Token: 0x06030358 RID: 197464 RVA: 0x0068DEA0 File Offset: 0x0068C0A0
		public bool AutoExitInFlow
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CD0C RID: 52492
		// (get) Token: 0x06030359 RID: 197465 RVA: 0x0068DEE0 File Offset: 0x0068C0E0
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603035A RID: 197466 RVA: 0x0068DF20 File Offset: 0x0068C120
		public static Offset<IEnterMovieMode> CreateIEnterMovieMode(FlatBufferBuilder builder, Offset<IMovieCameraConfig> MovieCameraConfigOffset = default(Offset<IMovieCameraConfig>), Offset<IEnableFuncConfig> EnableFuncConfigOffset = default(Offset<IEnableFuncConfig>), float BorderAnimDuration = 0f, TEnterMovieModeDurationType DurationType_type = TEnterMovieModeDurationType.NONE, int DurationTypeOffset = 0, bool AutoExitInFlow = false, byte NullMask = 0)
		{
			builder.StartTable(7);
			IEnterMovieMode.AddDurationType(builder, DurationTypeOffset);
			IEnterMovieMode.AddBorderAnimDuration(builder, BorderAnimDuration);
			IEnterMovieMode.AddEnableFuncConfig(builder, EnableFuncConfigOffset);
			IEnterMovieMode.AddMovieCameraConfig(builder, MovieCameraConfigOffset);
			IEnterMovieMode.AddNullMask(builder, NullMask);
			IEnterMovieMode.AddAutoExitInFlow(builder, AutoExitInFlow);
			IEnterMovieMode.AddDurationTypeType(builder, DurationType_type);
			return IEnterMovieMode.EndIEnterMovieMode(builder);
		}

		// Token: 0x0603035B RID: 197467 RVA: 0x0068DF6F File Offset: 0x0068C16F
		public static void StartIEnterMovieMode(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0603035C RID: 197468 RVA: 0x0068DF78 File Offset: 0x0068C178
		public static void AddMovieCameraConfig(FlatBufferBuilder builder, Offset<IMovieCameraConfig> movieCameraConfigOffset)
		{
			builder.AddOffset(0, movieCameraConfigOffset.Value, 0);
		}

		// Token: 0x0603035D RID: 197469 RVA: 0x0068DF88 File Offset: 0x0068C188
		public static void AddEnableFuncConfig(FlatBufferBuilder builder, Offset<IEnableFuncConfig> enableFuncConfigOffset)
		{
			builder.AddOffset(1, enableFuncConfigOffset.Value, 0);
		}

		// Token: 0x0603035E RID: 197470 RVA: 0x0068DF98 File Offset: 0x0068C198
		public static void AddBorderAnimDuration(FlatBufferBuilder builder, float borderAnimDuration)
		{
			builder.AddFloat(2, borderAnimDuration, 0.0);
		}

		// Token: 0x0603035F RID: 197471 RVA: 0x0068DFAB File Offset: 0x0068C1AB
		public static void AddDurationTypeType(FlatBufferBuilder builder, TEnterMovieModeDurationType durationTypeType)
		{
			builder.AddByte(3, (byte)durationTypeType, 0);
		}

		// Token: 0x06030360 RID: 197472 RVA: 0x0068DFB6 File Offset: 0x0068C1B6
		public static void AddDurationType(FlatBufferBuilder builder, int durationTypeOffset)
		{
			builder.AddOffset(4, durationTypeOffset, 0);
		}

		// Token: 0x06030361 RID: 197473 RVA: 0x0068DFC1 File Offset: 0x0068C1C1
		public static void AddAutoExitInFlow(FlatBufferBuilder builder, bool autoExitInFlow)
		{
			builder.AddBool(5, autoExitInFlow, false);
		}

		// Token: 0x06030362 RID: 197474 RVA: 0x0068DFCC File Offset: 0x0068C1CC
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06030363 RID: 197475 RVA: 0x0068DFD7 File Offset: 0x0068C1D7
		public static Offset<IEnterMovieMode> EndIEnterMovieMode(FlatBufferBuilder builder)
		{
			return new Offset<IEnterMovieMode>(builder.EndTable());
		}

		// Token: 0x06030364 RID: 197476 RVA: 0x0068DFE4 File Offset: 0x0068C1E4
		public IEnterMovieModeT UnPack()
		{
			IEnterMovieModeT enterMovieModeT = new IEnterMovieModeT();
			this.UnPackTo(enterMovieModeT);
			return enterMovieModeT;
		}

		// Token: 0x06030365 RID: 197477 RVA: 0x0068E000 File Offset: 0x0068C200
		public void UnPackTo(IEnterMovieModeT _o)
		{
			_o.MovieCameraConfig = ((this.MovieCameraConfig != null) ? this.MovieCameraConfig.Value.UnPack() : null);
			_o.EnableFuncConfig = ((this.EnableFuncConfig != null) ? this.EnableFuncConfig.Value.UnPack() : null);
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
			_o.AutoExitInFlow = this.AutoExitInFlow;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06030366 RID: 197478 RVA: 0x0068E130 File Offset: 0x0068C330
		public static Offset<IEnterMovieMode> Pack(FlatBufferBuilder builder, IEnterMovieModeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnterMovieMode>);
			}
			Offset<IMovieCameraConfig> movieCameraConfigOffset = (_o.MovieCameraConfig == null) ? default(Offset<IMovieCameraConfig>) : IMovieCameraConfig.Pack(builder, _o.MovieCameraConfig);
			Offset<IEnableFuncConfig> enableFuncConfigOffset = (_o.EnableFuncConfig == null) ? default(Offset<IEnableFuncConfig>) : IEnableFuncConfig.Pack(builder, _o.EnableFuncConfig);
			TEnterMovieModeDurationType durationType_type = (_o.DurationType == null) ? TEnterMovieModeDurationType.NONE : _o.DurationType.Type;
			int durationTypeOffset = (_o.DurationType == null) ? 0 : TEnterMovieModeDurationTypeUnion.Pack(builder, _o.DurationType);
			return IEnterMovieMode.CreateIEnterMovieMode(builder, movieCameraConfigOffset, enableFuncConfigOffset, _o.BorderAnimDuration, durationType_type, durationTypeOffset, _o.AutoExitInFlow, _o.NullMask);
		}

		// Token: 0x04011B97 RID: 72599
		private Table __p;
	}
}
