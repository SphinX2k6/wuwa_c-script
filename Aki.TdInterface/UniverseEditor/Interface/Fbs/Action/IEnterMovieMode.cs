using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066B4 RID: 26292
	public struct IEnterMovieMode : IFlatbufferObject
	{
		// Token: 0x1700C355 RID: 50005
		// (get) Token: 0x0602DB2E RID: 187182 RVA: 0x006409BE File Offset: 0x0063EBBE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DB2F RID: 187183 RVA: 0x006409CB File Offset: 0x0063EBCB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DB30 RID: 187184 RVA: 0x006409D4 File Offset: 0x0063EBD4
		public static IEnterMovieMode GetRootAsIEnterMovieMode(ByteBuffer _bb)
		{
			return IEnterMovieMode.GetRootAsIEnterMovieMode(_bb, default(IEnterMovieMode));
		}

		// Token: 0x0602DB31 RID: 187185 RVA: 0x006409F0 File Offset: 0x0063EBF0
		public static IEnterMovieMode GetRootAsIEnterMovieMode(ByteBuffer _bb, IEnterMovieMode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DB32 RID: 187186 RVA: 0x00640A0D File Offset: 0x0063EC0D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DB33 RID: 187187 RVA: 0x00640A1C File Offset: 0x0063EC1C
		public IEnterMovieMode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C356 RID: 50006
		// (get) Token: 0x0602DB34 RID: 187188 RVA: 0x00640A2C File Offset: 0x0063EC2C
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

		// Token: 0x1700C357 RID: 50007
		// (get) Token: 0x0602DB35 RID: 187189 RVA: 0x00640A8C File Offset: 0x0063EC8C
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

		// Token: 0x1700C358 RID: 50008
		// (get) Token: 0x0602DB36 RID: 187190 RVA: 0x00640AEC File Offset: 0x0063ECEC
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

		// Token: 0x1700C359 RID: 50009
		// (get) Token: 0x0602DB37 RID: 187191 RVA: 0x00640B2C File Offset: 0x0063ED2C
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

		// Token: 0x0602DB38 RID: 187192 RVA: 0x00640B6C File Offset: 0x0063ED6C
		public TTable? DurationType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602DB39 RID: 187193 RVA: 0x00640BB4 File Offset: 0x0063EDB4
		public IWaitMovieModeBorderAnimFinished DurationTypeAsIWaitMovieModeBorderAnimFinished()
		{
			return this.DurationType<IWaitMovieModeBorderAnimFinished>().Value;
		}

		// Token: 0x0602DB3A RID: 187194 RVA: 0x00640BD0 File Offset: 0x0063EDD0
		public IWaitMovieModeFixedTime DurationTypeAsIWaitMovieModeFixedTime()
		{
			return this.DurationType<IWaitMovieModeFixedTime>().Value;
		}

		// Token: 0x1700C35A RID: 50010
		// (get) Token: 0x0602DB3B RID: 187195 RVA: 0x00640BEC File Offset: 0x0063EDEC
		public bool AutoExitInFlow
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C35B RID: 50011
		// (get) Token: 0x0602DB3C RID: 187196 RVA: 0x00640C2C File Offset: 0x0063EE2C
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

		// Token: 0x0602DB3D RID: 187197 RVA: 0x00640C6C File Offset: 0x0063EE6C
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

		// Token: 0x0602DB3E RID: 187198 RVA: 0x00640CBB File Offset: 0x0063EEBB
		public static void StartIEnterMovieMode(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0602DB3F RID: 187199 RVA: 0x00640CC4 File Offset: 0x0063EEC4
		public static void AddMovieCameraConfig(FlatBufferBuilder builder, Offset<IMovieCameraConfig> movieCameraConfigOffset)
		{
			builder.AddOffset(0, movieCameraConfigOffset.Value, 0);
		}

		// Token: 0x0602DB40 RID: 187200 RVA: 0x00640CD4 File Offset: 0x0063EED4
		public static void AddEnableFuncConfig(FlatBufferBuilder builder, Offset<IEnableFuncConfig> enableFuncConfigOffset)
		{
			builder.AddOffset(1, enableFuncConfigOffset.Value, 0);
		}

		// Token: 0x0602DB41 RID: 187201 RVA: 0x00640CE4 File Offset: 0x0063EEE4
		public static void AddBorderAnimDuration(FlatBufferBuilder builder, float borderAnimDuration)
		{
			builder.AddFloat(2, borderAnimDuration, 0.0);
		}

		// Token: 0x0602DB42 RID: 187202 RVA: 0x00640CF7 File Offset: 0x0063EEF7
		public static void AddDurationTypeType(FlatBufferBuilder builder, TEnterMovieModeDurationType durationTypeType)
		{
			builder.AddByte(3, (byte)durationTypeType, 0);
		}

		// Token: 0x0602DB43 RID: 187203 RVA: 0x00640D02 File Offset: 0x0063EF02
		public static void AddDurationType(FlatBufferBuilder builder, int durationTypeOffset)
		{
			builder.AddOffset(4, durationTypeOffset, 0);
		}

		// Token: 0x0602DB44 RID: 187204 RVA: 0x00640D0D File Offset: 0x0063EF0D
		public static void AddAutoExitInFlow(FlatBufferBuilder builder, bool autoExitInFlow)
		{
			builder.AddBool(5, autoExitInFlow, false);
		}

		// Token: 0x0602DB45 RID: 187205 RVA: 0x00640D18 File Offset: 0x0063EF18
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x0602DB46 RID: 187206 RVA: 0x00640D23 File Offset: 0x0063EF23
		public static Offset<IEnterMovieMode> EndIEnterMovieMode(FlatBufferBuilder builder)
		{
			return new Offset<IEnterMovieMode>(builder.EndTable());
		}

		// Token: 0x0602DB47 RID: 187207 RVA: 0x00640D30 File Offset: 0x0063EF30
		public IEnterMovieModeT UnPack()
		{
			IEnterMovieModeT enterMovieModeT = new IEnterMovieModeT();
			this.UnPackTo(enterMovieModeT);
			return enterMovieModeT;
		}

		// Token: 0x0602DB48 RID: 187208 RVA: 0x00640D4C File Offset: 0x0063EF4C
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

		// Token: 0x0602DB49 RID: 187209 RVA: 0x00640E7C File Offset: 0x0063F07C
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

		// Token: 0x04010D71 RID: 68977
		private Table __p;
	}
}
