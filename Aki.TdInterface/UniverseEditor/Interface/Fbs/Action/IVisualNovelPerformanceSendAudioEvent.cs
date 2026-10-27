using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075BF RID: 30143
	public struct IVisualNovelPerformanceSendAudioEvent : IFlatbufferObject
	{
		// Token: 0x1700E4E1 RID: 58593
		// (get) Token: 0x06036E36 RID: 224822 RVA: 0x0077366F File Offset: 0x0077186F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036E37 RID: 224823 RVA: 0x0077367C File Offset: 0x0077187C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036E38 RID: 224824 RVA: 0x00773684 File Offset: 0x00771884
		public static IVisualNovelPerformanceSendAudioEvent GetRootAsIVisualNovelPerformanceSendAudioEvent(ByteBuffer _bb)
		{
			return IVisualNovelPerformanceSendAudioEvent.GetRootAsIVisualNovelPerformanceSendAudioEvent(_bb, default(IVisualNovelPerformanceSendAudioEvent));
		}

		// Token: 0x06036E39 RID: 224825 RVA: 0x007736A0 File Offset: 0x007718A0
		public static IVisualNovelPerformanceSendAudioEvent GetRootAsIVisualNovelPerformanceSendAudioEvent(ByteBuffer _bb, IVisualNovelPerformanceSendAudioEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036E3A RID: 224826 RVA: 0x007736BD File Offset: 0x007718BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036E3B RID: 224827 RVA: 0x007736CC File Offset: 0x007718CC
		public IVisualNovelPerformanceSendAudioEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E4E2 RID: 58594
		// (get) Token: 0x06036E3C RID: 224828 RVA: 0x007736DC File Offset: 0x007718DC
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

		// Token: 0x1700E4E3 RID: 58595
		// (get) Token: 0x06036E3D RID: 224829 RVA: 0x00773718 File Offset: 0x00771918
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

		// Token: 0x1700E4E4 RID: 58596
		// (get) Token: 0x06036E3E RID: 224830 RVA: 0x00773758 File Offset: 0x00771958
		public string AudioEvent
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06036E3F RID: 224831 RVA: 0x0077378F File Offset: 0x0077198F
		public Span<byte> GetAudioEventBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06036E40 RID: 224832 RVA: 0x0077379E File Offset: 0x0077199E
		public byte[] GetAudioEventArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700E4E5 RID: 58597
		// (get) Token: 0x06036E41 RID: 224833 RVA: 0x007737AC File Offset: 0x007719AC
		public float EndFadeOutTime
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E4E6 RID: 58598
		// (get) Token: 0x06036E42 RID: 224834 RVA: 0x007737F0 File Offset: 0x007719F0
		public bool IsNotCountTimeAndNotInterrupted
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E4E7 RID: 58599
		// (get) Token: 0x06036E43 RID: 224835 RVA: 0x00773830 File Offset: 0x00771A30
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

		// Token: 0x06036E44 RID: 224836 RVA: 0x0077386D File Offset: 0x00771A6D
		public static Offset<IVisualNovelPerformanceSendAudioEvent> CreateIVisualNovelPerformanceSendAudioEvent(FlatBufferBuilder builder, EVisualNovelPerformanceType Type = EVisualNovelPerformanceType.Enter, float StartTime = 0f, StringOffset AudioEventOffset = default(StringOffset), float EndFadeOutTime = 0f, bool IsNotCountTimeAndNotInterrupted = false, byte NullMask = 0)
		{
			builder.StartTable(6);
			IVisualNovelPerformanceSendAudioEvent.AddEndFadeOutTime(builder, EndFadeOutTime);
			IVisualNovelPerformanceSendAudioEvent.AddAudioEvent(builder, AudioEventOffset);
			IVisualNovelPerformanceSendAudioEvent.AddStartTime(builder, StartTime);
			IVisualNovelPerformanceSendAudioEvent.AddNullMask(builder, NullMask);
			IVisualNovelPerformanceSendAudioEvent.AddIsNotCountTimeAndNotInterrupted(builder, IsNotCountTimeAndNotInterrupted);
			IVisualNovelPerformanceSendAudioEvent.AddType(builder, Type);
			return IVisualNovelPerformanceSendAudioEvent.EndIVisualNovelPerformanceSendAudioEvent(builder);
		}

		// Token: 0x06036E45 RID: 224837 RVA: 0x007738A9 File Offset: 0x00771AA9
		public static void StartIVisualNovelPerformanceSendAudioEvent(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06036E46 RID: 224838 RVA: 0x007738B2 File Offset: 0x00771AB2
		public static void AddType(FlatBufferBuilder builder, EVisualNovelPerformanceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036E47 RID: 224839 RVA: 0x007738BD File Offset: 0x00771ABD
		public static void AddStartTime(FlatBufferBuilder builder, float startTime)
		{
			builder.AddFloat(1, startTime, 0.0);
		}

		// Token: 0x06036E48 RID: 224840 RVA: 0x007738D0 File Offset: 0x00771AD0
		public static void AddAudioEvent(FlatBufferBuilder builder, StringOffset audioEventOffset)
		{
			builder.AddOffset(2, audioEventOffset.Value, 0);
		}

		// Token: 0x06036E49 RID: 224841 RVA: 0x007738E0 File Offset: 0x00771AE0
		public static void AddEndFadeOutTime(FlatBufferBuilder builder, float endFadeOutTime)
		{
			builder.AddFloat(3, endFadeOutTime, 0.0);
		}

		// Token: 0x06036E4A RID: 224842 RVA: 0x007738F3 File Offset: 0x00771AF3
		public static void AddIsNotCountTimeAndNotInterrupted(FlatBufferBuilder builder, bool isNotCountTimeAndNotInterrupted)
		{
			builder.AddBool(4, isNotCountTimeAndNotInterrupted, false);
		}

		// Token: 0x06036E4B RID: 224843 RVA: 0x007738FE File Offset: 0x00771AFE
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06036E4C RID: 224844 RVA: 0x00773909 File Offset: 0x00771B09
		public static Offset<IVisualNovelPerformanceSendAudioEvent> EndIVisualNovelPerformanceSendAudioEvent(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelPerformanceSendAudioEvent>(builder.EndTable());
		}

		// Token: 0x06036E4D RID: 224845 RVA: 0x00773918 File Offset: 0x00771B18
		public IVisualNovelPerformanceSendAudioEventT UnPack()
		{
			IVisualNovelPerformanceSendAudioEventT visualNovelPerformanceSendAudioEventT = new IVisualNovelPerformanceSendAudioEventT();
			this.UnPackTo(visualNovelPerformanceSendAudioEventT);
			return visualNovelPerformanceSendAudioEventT;
		}

		// Token: 0x06036E4E RID: 224846 RVA: 0x00773934 File Offset: 0x00771B34
		public void UnPackTo(IVisualNovelPerformanceSendAudioEventT _o)
		{
			_o.Type = this.Type;
			_o.StartTime = this.StartTime;
			_o.AudioEvent = this.AudioEvent;
			_o.EndFadeOutTime = this.EndFadeOutTime;
			_o.IsNotCountTimeAndNotInterrupted = this.IsNotCountTimeAndNotInterrupted;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06036E4F RID: 224847 RVA: 0x0077398C File Offset: 0x00771B8C
		public static Offset<IVisualNovelPerformanceSendAudioEvent> Pack(FlatBufferBuilder builder, IVisualNovelPerformanceSendAudioEventT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelPerformanceSendAudioEvent>);
			}
			StringOffset audioEventOffset = (_o.AudioEvent == null) ? default(StringOffset) : builder.CreateString(_o.AudioEvent);
			return IVisualNovelPerformanceSendAudioEvent.CreateIVisualNovelPerformanceSendAudioEvent(builder, _o.Type, _o.StartTime, audioEventOffset, _o.EndFadeOutTime, _o.IsNotCountTimeAndNotInterrupted, _o.NullMask);
		}

		// Token: 0x0401250D RID: 75021
		private Table __p;
	}
}
