using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075B9 RID: 30137
	public struct IVisualNovelPerformancePortraitEffect : IFlatbufferObject
	{
		// Token: 0x1700E4CB RID: 58571
		// (get) Token: 0x06036DF2 RID: 224754 RVA: 0x00772E70 File Offset: 0x00771070
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036DF3 RID: 224755 RVA: 0x00772E7D File Offset: 0x0077107D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036DF4 RID: 224756 RVA: 0x00772E84 File Offset: 0x00771084
		public static IVisualNovelPerformancePortraitEffect GetRootAsIVisualNovelPerformancePortraitEffect(ByteBuffer _bb)
		{
			return IVisualNovelPerformancePortraitEffect.GetRootAsIVisualNovelPerformancePortraitEffect(_bb, default(IVisualNovelPerformancePortraitEffect));
		}

		// Token: 0x06036DF5 RID: 224757 RVA: 0x00772EA0 File Offset: 0x007710A0
		public static IVisualNovelPerformancePortraitEffect GetRootAsIVisualNovelPerformancePortraitEffect(ByteBuffer _bb, IVisualNovelPerformancePortraitEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036DF6 RID: 224758 RVA: 0x00772EBD File Offset: 0x007710BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036DF7 RID: 224759 RVA: 0x00772ECC File Offset: 0x007710CC
		public IVisualNovelPerformancePortraitEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E4CC RID: 58572
		// (get) Token: 0x06036DF8 RID: 224760 RVA: 0x00772EDC File Offset: 0x007710DC
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

		// Token: 0x1700E4CD RID: 58573
		// (get) Token: 0x06036DF9 RID: 224761 RVA: 0x00772F18 File Offset: 0x00771118
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

		// Token: 0x1700E4CE RID: 58574
		// (get) Token: 0x06036DFA RID: 224762 RVA: 0x00772F58 File Offset: 0x00771158
		public int WhoId
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

		// Token: 0x1700E4CF RID: 58575
		// (get) Token: 0x06036DFB RID: 224763 RVA: 0x00772F94 File Offset: 0x00771194
		public EVisualNovelPortraitEffectType EffectType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return EVisualNovelPortraitEffectType.Jump;
				}
				return (EVisualNovelPortraitEffectType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E4D0 RID: 58576
		// (get) Token: 0x06036DFC RID: 224764 RVA: 0x00772FD4 File Offset: 0x007711D4
		public EVisualNovelAmplitude Amplitude
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return EVisualNovelAmplitude.Small;
				}
				return (EVisualNovelAmplitude)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E4D1 RID: 58577
		// (get) Token: 0x06036DFD RID: 224765 RVA: 0x00773014 File Offset: 0x00771214
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06036DFE RID: 224766 RVA: 0x00773051 File Offset: 0x00771251
		public static Offset<IVisualNovelPerformancePortraitEffect> CreateIVisualNovelPerformancePortraitEffect(FlatBufferBuilder builder, EVisualNovelPerformanceType Type = EVisualNovelPerformanceType.Enter, float StartTime = 0f, int WhoId = 0, EVisualNovelPortraitEffectType EffectType = EVisualNovelPortraitEffectType.Jump, EVisualNovelAmplitude Amplitude = EVisualNovelAmplitude.Small, byte NullMask = 0)
		{
			builder.StartTable(6);
			IVisualNovelPerformancePortraitEffect.AddWhoId(builder, WhoId);
			IVisualNovelPerformancePortraitEffect.AddStartTime(builder, StartTime);
			IVisualNovelPerformancePortraitEffect.AddNullMask(builder, NullMask);
			IVisualNovelPerformancePortraitEffect.AddAmplitude(builder, Amplitude);
			IVisualNovelPerformancePortraitEffect.AddEffectType(builder, EffectType);
			IVisualNovelPerformancePortraitEffect.AddType(builder, Type);
			return IVisualNovelPerformancePortraitEffect.EndIVisualNovelPerformancePortraitEffect(builder);
		}

		// Token: 0x06036DFF RID: 224767 RVA: 0x0077308D File Offset: 0x0077128D
		public static void StartIVisualNovelPerformancePortraitEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06036E00 RID: 224768 RVA: 0x00773096 File Offset: 0x00771296
		public static void AddType(FlatBufferBuilder builder, EVisualNovelPerformanceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036E01 RID: 224769 RVA: 0x007730A1 File Offset: 0x007712A1
		public static void AddStartTime(FlatBufferBuilder builder, float startTime)
		{
			builder.AddFloat(1, startTime, 0.0);
		}

		// Token: 0x06036E02 RID: 224770 RVA: 0x007730B4 File Offset: 0x007712B4
		public static void AddWhoId(FlatBufferBuilder builder, int whoId)
		{
			builder.AddInt(2, whoId, 0);
		}

		// Token: 0x06036E03 RID: 224771 RVA: 0x007730BF File Offset: 0x007712BF
		public static void AddEffectType(FlatBufferBuilder builder, EVisualNovelPortraitEffectType effectType)
		{
			builder.AddByte(3, (byte)effectType, 0);
		}

		// Token: 0x06036E04 RID: 224772 RVA: 0x007730CA File Offset: 0x007712CA
		public static void AddAmplitude(FlatBufferBuilder builder, EVisualNovelAmplitude amplitude)
		{
			builder.AddByte(4, (byte)amplitude, 0);
		}

		// Token: 0x06036E05 RID: 224773 RVA: 0x007730D5 File Offset: 0x007712D5
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06036E06 RID: 224774 RVA: 0x007730E0 File Offset: 0x007712E0
		public static Offset<IVisualNovelPerformancePortraitEffect> EndIVisualNovelPerformancePortraitEffect(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelPerformancePortraitEffect>(builder.EndTable());
		}

		// Token: 0x06036E07 RID: 224775 RVA: 0x007730F0 File Offset: 0x007712F0
		public IVisualNovelPerformancePortraitEffectT UnPack()
		{
			IVisualNovelPerformancePortraitEffectT visualNovelPerformancePortraitEffectT = new IVisualNovelPerformancePortraitEffectT();
			this.UnPackTo(visualNovelPerformancePortraitEffectT);
			return visualNovelPerformancePortraitEffectT;
		}

		// Token: 0x06036E08 RID: 224776 RVA: 0x0077310C File Offset: 0x0077130C
		public void UnPackTo(IVisualNovelPerformancePortraitEffectT _o)
		{
			_o.Type = this.Type;
			_o.StartTime = this.StartTime;
			_o.WhoId = this.WhoId;
			_o.EffectType = this.EffectType;
			_o.Amplitude = this.Amplitude;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06036E09 RID: 224777 RVA: 0x00773164 File Offset: 0x00771364
		public static Offset<IVisualNovelPerformancePortraitEffect> Pack(FlatBufferBuilder builder, IVisualNovelPerformancePortraitEffectT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelPerformancePortraitEffect>);
			}
			return IVisualNovelPerformancePortraitEffect.CreateIVisualNovelPerformancePortraitEffect(builder, _o.Type, _o.StartTime, _o.WhoId, _o.EffectType, _o.Amplitude, _o.NullMask);
		}

		// Token: 0x04012501 RID: 75009
		private Table __p;
	}
}
