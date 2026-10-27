using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006726 RID: 26406
	public struct IExitMovieMode : IFlatbufferObject
	{
		// Token: 0x1700C41F RID: 50207
		// (get) Token: 0x0602DEEC RID: 188140 RVA: 0x00647852 File Offset: 0x00645A52
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DEED RID: 188141 RVA: 0x0064785F File Offset: 0x00645A5F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DEEE RID: 188142 RVA: 0x00647868 File Offset: 0x00645A68
		public static IExitMovieMode GetRootAsIExitMovieMode(ByteBuffer _bb)
		{
			return IExitMovieMode.GetRootAsIExitMovieMode(_bb, default(IExitMovieMode));
		}

		// Token: 0x0602DEEF RID: 188143 RVA: 0x00647884 File Offset: 0x00645A84
		public static IExitMovieMode GetRootAsIExitMovieMode(ByteBuffer _bb, IExitMovieMode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DEF0 RID: 188144 RVA: 0x006478A1 File Offset: 0x00645AA1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DEF1 RID: 188145 RVA: 0x006478B0 File Offset: 0x00645AB0
		public IExitMovieMode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C420 RID: 50208
		// (get) Token: 0x0602DEF2 RID: 188146 RVA: 0x006478C0 File Offset: 0x00645AC0
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

		// Token: 0x1700C421 RID: 50209
		// (get) Token: 0x0602DEF3 RID: 188147 RVA: 0x00647900 File Offset: 0x00645B00
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

		// Token: 0x0602DEF4 RID: 188148 RVA: 0x0064793C File Offset: 0x00645B3C
		public TTable? DurationType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602DEF5 RID: 188149 RVA: 0x00647980 File Offset: 0x00645B80
		public IWaitMovieModeBorderAnimFinished DurationTypeAsIWaitMovieModeBorderAnimFinished()
		{
			return this.DurationType<IWaitMovieModeBorderAnimFinished>().Value;
		}

		// Token: 0x0602DEF6 RID: 188150 RVA: 0x0064799C File Offset: 0x00645B9C
		public IWaitMovieModeFixedTime DurationTypeAsIWaitMovieModeFixedTime()
		{
			return this.DurationType<IWaitMovieModeFixedTime>().Value;
		}

		// Token: 0x1700C422 RID: 50210
		// (get) Token: 0x0602DEF7 RID: 188151 RVA: 0x006479B8 File Offset: 0x00645BB8
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

		// Token: 0x1700C423 RID: 50211
		// (get) Token: 0x0602DEF8 RID: 188152 RVA: 0x00647A18 File Offset: 0x00645C18
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

		// Token: 0x0602DEF9 RID: 188153 RVA: 0x00647A55 File Offset: 0x00645C55
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

		// Token: 0x0602DEFA RID: 188154 RVA: 0x00647A89 File Offset: 0x00645C89
		public static void StartIExitMovieMode(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602DEFB RID: 188155 RVA: 0x00647A92 File Offset: 0x00645C92
		public static void AddBorderAnimDuration(FlatBufferBuilder builder, float borderAnimDuration)
		{
			builder.AddFloat(0, borderAnimDuration, 0.0);
		}

		// Token: 0x0602DEFC RID: 188156 RVA: 0x00647AA5 File Offset: 0x00645CA5
		public static void AddDurationTypeType(FlatBufferBuilder builder, TEnterMovieModeDurationType durationTypeType)
		{
			builder.AddByte(1, (byte)durationTypeType, 0);
		}

		// Token: 0x0602DEFD RID: 188157 RVA: 0x00647AB0 File Offset: 0x00645CB0
		public static void AddDurationType(FlatBufferBuilder builder, int durationTypeOffset)
		{
			builder.AddOffset(2, durationTypeOffset, 0);
		}

		// Token: 0x0602DEFE RID: 188158 RVA: 0x00647ABB File Offset: 0x00645CBB
		public static void AddFadeOutMaskConfig(FlatBufferBuilder builder, Offset<IMovieModeFadeOutMaskConfig> fadeOutMaskConfigOffset)
		{
			builder.AddOffset(3, fadeOutMaskConfigOffset.Value, 0);
		}

		// Token: 0x0602DEFF RID: 188159 RVA: 0x00647ACB File Offset: 0x00645CCB
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0602DF00 RID: 188160 RVA: 0x00647AD6 File Offset: 0x00645CD6
		public static Offset<IExitMovieMode> EndIExitMovieMode(FlatBufferBuilder builder)
		{
			return new Offset<IExitMovieMode>(builder.EndTable());
		}

		// Token: 0x0602DF01 RID: 188161 RVA: 0x00647AE4 File Offset: 0x00645CE4
		public IExitMovieModeT UnPack()
		{
			IExitMovieModeT exitMovieModeT = new IExitMovieModeT();
			this.UnPackTo(exitMovieModeT);
			return exitMovieModeT;
		}

		// Token: 0x0602DF02 RID: 188162 RVA: 0x00647B00 File Offset: 0x00645D00
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

		// Token: 0x0602DF03 RID: 188163 RVA: 0x00647BF0 File Offset: 0x00645DF0
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

		// Token: 0x04010E0B RID: 69131
		private Table __p;
	}
}
