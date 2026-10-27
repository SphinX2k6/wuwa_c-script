using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075B6 RID: 30134
	public struct IVisualNovelPerformancePlayScreenEffect : IFlatbufferObject
	{
		// Token: 0x1700E4C0 RID: 58560
		// (get) Token: 0x06036DCE RID: 224718 RVA: 0x00772A72 File Offset: 0x00770C72
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036DCF RID: 224719 RVA: 0x00772A7F File Offset: 0x00770C7F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036DD0 RID: 224720 RVA: 0x00772A88 File Offset: 0x00770C88
		public static IVisualNovelPerformancePlayScreenEffect GetRootAsIVisualNovelPerformancePlayScreenEffect(ByteBuffer _bb)
		{
			return IVisualNovelPerformancePlayScreenEffect.GetRootAsIVisualNovelPerformancePlayScreenEffect(_bb, default(IVisualNovelPerformancePlayScreenEffect));
		}

		// Token: 0x06036DD1 RID: 224721 RVA: 0x00772AA4 File Offset: 0x00770CA4
		public static IVisualNovelPerformancePlayScreenEffect GetRootAsIVisualNovelPerformancePlayScreenEffect(ByteBuffer _bb, IVisualNovelPerformancePlayScreenEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036DD2 RID: 224722 RVA: 0x00772AC1 File Offset: 0x00770CC1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036DD3 RID: 224723 RVA: 0x00772AD0 File Offset: 0x00770CD0
		public IVisualNovelPerformancePlayScreenEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E4C1 RID: 58561
		// (get) Token: 0x06036DD4 RID: 224724 RVA: 0x00772AE0 File Offset: 0x00770CE0
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

		// Token: 0x1700E4C2 RID: 58562
		// (get) Token: 0x06036DD5 RID: 224725 RVA: 0x00772B1C File Offset: 0x00770D1C
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

		// Token: 0x1700E4C3 RID: 58563
		// (get) Token: 0x06036DD6 RID: 224726 RVA: 0x00772B5C File Offset: 0x00770D5C
		public string ScreenEffectDa
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

		// Token: 0x06036DD7 RID: 224727 RVA: 0x00772B93 File Offset: 0x00770D93
		public Span<byte> GetScreenEffectDaBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06036DD8 RID: 224728 RVA: 0x00772BA2 File Offset: 0x00770DA2
		public byte[] GetScreenEffectDaArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700E4C4 RID: 58564
		// (get) Token: 0x06036DD9 RID: 224729 RVA: 0x00772BB0 File Offset: 0x00770DB0
		public float DestroyCountdown
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

		// Token: 0x1700E4C5 RID: 58565
		// (get) Token: 0x06036DDA RID: 224730 RVA: 0x00772BF4 File Offset: 0x00770DF4
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

		// Token: 0x06036DDB RID: 224731 RVA: 0x00772C31 File Offset: 0x00770E31
		public static Offset<IVisualNovelPerformancePlayScreenEffect> CreateIVisualNovelPerformancePlayScreenEffect(FlatBufferBuilder builder, EVisualNovelPerformanceType Type = EVisualNovelPerformanceType.Enter, float StartTime = 0f, StringOffset ScreenEffectDaOffset = default(StringOffset), float DestroyCountdown = 0f, byte NullMask = 0)
		{
			builder.StartTable(5);
			IVisualNovelPerformancePlayScreenEffect.AddDestroyCountdown(builder, DestroyCountdown);
			IVisualNovelPerformancePlayScreenEffect.AddScreenEffectDa(builder, ScreenEffectDaOffset);
			IVisualNovelPerformancePlayScreenEffect.AddStartTime(builder, StartTime);
			IVisualNovelPerformancePlayScreenEffect.AddNullMask(builder, NullMask);
			IVisualNovelPerformancePlayScreenEffect.AddType(builder, Type);
			return IVisualNovelPerformancePlayScreenEffect.EndIVisualNovelPerformancePlayScreenEffect(builder);
		}

		// Token: 0x06036DDC RID: 224732 RVA: 0x00772C65 File Offset: 0x00770E65
		public static void StartIVisualNovelPerformancePlayScreenEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06036DDD RID: 224733 RVA: 0x00772C6E File Offset: 0x00770E6E
		public static void AddType(FlatBufferBuilder builder, EVisualNovelPerformanceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036DDE RID: 224734 RVA: 0x00772C79 File Offset: 0x00770E79
		public static void AddStartTime(FlatBufferBuilder builder, float startTime)
		{
			builder.AddFloat(1, startTime, 0.0);
		}

		// Token: 0x06036DDF RID: 224735 RVA: 0x00772C8C File Offset: 0x00770E8C
		public static void AddScreenEffectDa(FlatBufferBuilder builder, StringOffset screenEffectDaOffset)
		{
			builder.AddOffset(2, screenEffectDaOffset.Value, 0);
		}

		// Token: 0x06036DE0 RID: 224736 RVA: 0x00772C9C File Offset: 0x00770E9C
		public static void AddDestroyCountdown(FlatBufferBuilder builder, float destroyCountdown)
		{
			builder.AddFloat(3, destroyCountdown, 0.0);
		}

		// Token: 0x06036DE1 RID: 224737 RVA: 0x00772CAF File Offset: 0x00770EAF
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06036DE2 RID: 224738 RVA: 0x00772CBA File Offset: 0x00770EBA
		public static Offset<IVisualNovelPerformancePlayScreenEffect> EndIVisualNovelPerformancePlayScreenEffect(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelPerformancePlayScreenEffect>(builder.EndTable());
		}

		// Token: 0x06036DE3 RID: 224739 RVA: 0x00772CC8 File Offset: 0x00770EC8
		public IVisualNovelPerformancePlayScreenEffectT UnPack()
		{
			IVisualNovelPerformancePlayScreenEffectT visualNovelPerformancePlayScreenEffectT = new IVisualNovelPerformancePlayScreenEffectT();
			this.UnPackTo(visualNovelPerformancePlayScreenEffectT);
			return visualNovelPerformancePlayScreenEffectT;
		}

		// Token: 0x06036DE4 RID: 224740 RVA: 0x00772CE3 File Offset: 0x00770EE3
		public void UnPackTo(IVisualNovelPerformancePlayScreenEffectT _o)
		{
			_o.Type = this.Type;
			_o.StartTime = this.StartTime;
			_o.ScreenEffectDa = this.ScreenEffectDa;
			_o.DestroyCountdown = this.DestroyCountdown;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06036DE5 RID: 224741 RVA: 0x00772D24 File Offset: 0x00770F24
		public static Offset<IVisualNovelPerformancePlayScreenEffect> Pack(FlatBufferBuilder builder, IVisualNovelPerformancePlayScreenEffectT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelPerformancePlayScreenEffect>);
			}
			StringOffset screenEffectDaOffset = (_o.ScreenEffectDa == null) ? default(StringOffset) : builder.CreateString(_o.ScreenEffectDa);
			return IVisualNovelPerformancePlayScreenEffect.CreateIVisualNovelPerformancePlayScreenEffect(builder, _o.Type, _o.StartTime, screenEffectDaOffset, _o.DestroyCountdown, _o.NullMask);
		}

		// Token: 0x040124FB RID: 75003
		private Table __p;
	}
}
