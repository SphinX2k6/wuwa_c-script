using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075CB RID: 30155
	public struct IVisualNovelPerformanceUiShake : IFlatbufferObject
	{
		// Token: 0x1700E509 RID: 58633
		// (get) Token: 0x06036EBA RID: 224954 RVA: 0x007745BF File Offset: 0x007727BF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036EBB RID: 224955 RVA: 0x007745CC File Offset: 0x007727CC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036EBC RID: 224956 RVA: 0x007745D4 File Offset: 0x007727D4
		public static IVisualNovelPerformanceUiShake GetRootAsIVisualNovelPerformanceUiShake(ByteBuffer _bb)
		{
			return IVisualNovelPerformanceUiShake.GetRootAsIVisualNovelPerformanceUiShake(_bb, default(IVisualNovelPerformanceUiShake));
		}

		// Token: 0x06036EBD RID: 224957 RVA: 0x007745F0 File Offset: 0x007727F0
		public static IVisualNovelPerformanceUiShake GetRootAsIVisualNovelPerformanceUiShake(ByteBuffer _bb, IVisualNovelPerformanceUiShake obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036EBE RID: 224958 RVA: 0x0077460D File Offset: 0x0077280D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036EBF RID: 224959 RVA: 0x0077461C File Offset: 0x0077281C
		public IVisualNovelPerformanceUiShake __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E50A RID: 58634
		// (get) Token: 0x06036EC0 RID: 224960 RVA: 0x0077462C File Offset: 0x0077282C
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

		// Token: 0x1700E50B RID: 58635
		// (get) Token: 0x06036EC1 RID: 224961 RVA: 0x00774668 File Offset: 0x00772868
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

		// Token: 0x1700E50C RID: 58636
		// (get) Token: 0x06036EC2 RID: 224962 RVA: 0x007746A8 File Offset: 0x007728A8
		public EVisualNovelUiShakeType ShakeType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return EVisualNovelUiShakeType.Random;
				}
				return (EVisualNovelUiShakeType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E50D RID: 58637
		// (get) Token: 0x06036EC3 RID: 224963 RVA: 0x007746E4 File Offset: 0x007728E4
		public EVisualNovelShakeIntensity Intensity
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return EVisualNovelShakeIntensity.Weak;
				}
				return (EVisualNovelShakeIntensity)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E50E RID: 58638
		// (get) Token: 0x06036EC4 RID: 224964 RVA: 0x00774724 File Offset: 0x00772924
		public float Duration
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E50F RID: 58639
		// (get) Token: 0x06036EC5 RID: 224965 RVA: 0x00774768 File Offset: 0x00772968
		public string ScreenEffectDa
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06036EC6 RID: 224966 RVA: 0x007747A0 File Offset: 0x007729A0
		public Span<byte> GetScreenEffectDaBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06036EC7 RID: 224967 RVA: 0x007747B0 File Offset: 0x007729B0
		public byte[] GetScreenEffectDaArray()
		{
			return this.__p.__vector_as_array<byte>(14);
		}

		// Token: 0x1700E510 RID: 58640
		// (get) Token: 0x06036EC8 RID: 224968 RVA: 0x007747C0 File Offset: 0x007729C0
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

		// Token: 0x06036EC9 RID: 224969 RVA: 0x00774800 File Offset: 0x00772A00
		public static Offset<IVisualNovelPerformanceUiShake> CreateIVisualNovelPerformanceUiShake(FlatBufferBuilder builder, EVisualNovelPerformanceType Type = EVisualNovelPerformanceType.Enter, float StartTime = 0f, EVisualNovelUiShakeType ShakeType = EVisualNovelUiShakeType.Random, EVisualNovelShakeIntensity Intensity = EVisualNovelShakeIntensity.Weak, float Duration = 0f, StringOffset ScreenEffectDaOffset = default(StringOffset), byte NullMask = 0)
		{
			builder.StartTable(7);
			IVisualNovelPerformanceUiShake.AddScreenEffectDa(builder, ScreenEffectDaOffset);
			IVisualNovelPerformanceUiShake.AddDuration(builder, Duration);
			IVisualNovelPerformanceUiShake.AddStartTime(builder, StartTime);
			IVisualNovelPerformanceUiShake.AddNullMask(builder, NullMask);
			IVisualNovelPerformanceUiShake.AddIntensity(builder, Intensity);
			IVisualNovelPerformanceUiShake.AddShakeType(builder, ShakeType);
			IVisualNovelPerformanceUiShake.AddType(builder, Type);
			return IVisualNovelPerformanceUiShake.EndIVisualNovelPerformanceUiShake(builder);
		}

		// Token: 0x06036ECA RID: 224970 RVA: 0x0077484F File Offset: 0x00772A4F
		public static void StartIVisualNovelPerformanceUiShake(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06036ECB RID: 224971 RVA: 0x00774858 File Offset: 0x00772A58
		public static void AddType(FlatBufferBuilder builder, EVisualNovelPerformanceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036ECC RID: 224972 RVA: 0x00774863 File Offset: 0x00772A63
		public static void AddStartTime(FlatBufferBuilder builder, float startTime)
		{
			builder.AddFloat(1, startTime, 0.0);
		}

		// Token: 0x06036ECD RID: 224973 RVA: 0x00774876 File Offset: 0x00772A76
		public static void AddShakeType(FlatBufferBuilder builder, EVisualNovelUiShakeType shakeType)
		{
			builder.AddByte(2, (byte)shakeType, 0);
		}

		// Token: 0x06036ECE RID: 224974 RVA: 0x00774881 File Offset: 0x00772A81
		public static void AddIntensity(FlatBufferBuilder builder, EVisualNovelShakeIntensity intensity)
		{
			builder.AddByte(3, (byte)intensity, 0);
		}

		// Token: 0x06036ECF RID: 224975 RVA: 0x0077488C File Offset: 0x00772A8C
		public static void AddDuration(FlatBufferBuilder builder, float duration)
		{
			builder.AddFloat(4, duration, 0.0);
		}

		// Token: 0x06036ED0 RID: 224976 RVA: 0x0077489F File Offset: 0x00772A9F
		public static void AddScreenEffectDa(FlatBufferBuilder builder, StringOffset screenEffectDaOffset)
		{
			builder.AddOffset(5, screenEffectDaOffset.Value, 0);
		}

		// Token: 0x06036ED1 RID: 224977 RVA: 0x007748AF File Offset: 0x00772AAF
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06036ED2 RID: 224978 RVA: 0x007748BA File Offset: 0x00772ABA
		public static Offset<IVisualNovelPerformanceUiShake> EndIVisualNovelPerformanceUiShake(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelPerformanceUiShake>(builder.EndTable());
		}

		// Token: 0x06036ED3 RID: 224979 RVA: 0x007748C8 File Offset: 0x00772AC8
		public IVisualNovelPerformanceUiShakeT UnPack()
		{
			IVisualNovelPerformanceUiShakeT visualNovelPerformanceUiShakeT = new IVisualNovelPerformanceUiShakeT();
			this.UnPackTo(visualNovelPerformanceUiShakeT);
			return visualNovelPerformanceUiShakeT;
		}

		// Token: 0x06036ED4 RID: 224980 RVA: 0x007748E4 File Offset: 0x00772AE4
		public void UnPackTo(IVisualNovelPerformanceUiShakeT _o)
		{
			_o.Type = this.Type;
			_o.StartTime = this.StartTime;
			_o.ShakeType = this.ShakeType;
			_o.Intensity = this.Intensity;
			_o.Duration = this.Duration;
			_o.ScreenEffectDa = this.ScreenEffectDa;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06036ED5 RID: 224981 RVA: 0x00774948 File Offset: 0x00772B48
		public static Offset<IVisualNovelPerformanceUiShake> Pack(FlatBufferBuilder builder, IVisualNovelPerformanceUiShakeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelPerformanceUiShake>);
			}
			StringOffset screenEffectDaOffset = (_o.ScreenEffectDa == null) ? default(StringOffset) : builder.CreateString(_o.ScreenEffectDa);
			return IVisualNovelPerformanceUiShake.CreateIVisualNovelPerformanceUiShake(builder, _o.Type, _o.StartTime, _o.ShakeType, _o.Intensity, _o.Duration, screenEffectDaOffset, _o.NullMask);
		}

		// Token: 0x04012523 RID: 75043
		private Table __p;
	}
}
