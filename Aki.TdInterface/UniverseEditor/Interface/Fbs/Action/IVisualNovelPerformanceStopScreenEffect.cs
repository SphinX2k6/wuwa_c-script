using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075C2 RID: 30146
	public struct IVisualNovelPerformanceStopScreenEffect : IFlatbufferObject
	{
		// Token: 0x1700E4EE RID: 58606
		// (get) Token: 0x06036E5E RID: 224862 RVA: 0x00773B04 File Offset: 0x00771D04
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036E5F RID: 224863 RVA: 0x00773B11 File Offset: 0x00771D11
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036E60 RID: 224864 RVA: 0x00773B18 File Offset: 0x00771D18
		public static IVisualNovelPerformanceStopScreenEffect GetRootAsIVisualNovelPerformanceStopScreenEffect(ByteBuffer _bb)
		{
			return IVisualNovelPerformanceStopScreenEffect.GetRootAsIVisualNovelPerformanceStopScreenEffect(_bb, default(IVisualNovelPerformanceStopScreenEffect));
		}

		// Token: 0x06036E61 RID: 224865 RVA: 0x00773B34 File Offset: 0x00771D34
		public static IVisualNovelPerformanceStopScreenEffect GetRootAsIVisualNovelPerformanceStopScreenEffect(ByteBuffer _bb, IVisualNovelPerformanceStopScreenEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036E62 RID: 224866 RVA: 0x00773B51 File Offset: 0x00771D51
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036E63 RID: 224867 RVA: 0x00773B60 File Offset: 0x00771D60
		public IVisualNovelPerformanceStopScreenEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E4EF RID: 58607
		// (get) Token: 0x06036E64 RID: 224868 RVA: 0x00773B70 File Offset: 0x00771D70
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

		// Token: 0x1700E4F0 RID: 58608
		// (get) Token: 0x06036E65 RID: 224869 RVA: 0x00773BAC File Offset: 0x00771DAC
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

		// Token: 0x1700E4F1 RID: 58609
		// (get) Token: 0x06036E66 RID: 224870 RVA: 0x00773BEC File Offset: 0x00771DEC
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

		// Token: 0x06036E67 RID: 224871 RVA: 0x00773C23 File Offset: 0x00771E23
		public Span<byte> GetScreenEffectDaBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06036E68 RID: 224872 RVA: 0x00773C32 File Offset: 0x00771E32
		public byte[] GetScreenEffectDaArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700E4F2 RID: 58610
		// (get) Token: 0x06036E69 RID: 224873 RVA: 0x00773C40 File Offset: 0x00771E40
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06036E6A RID: 224874 RVA: 0x00773C7D File Offset: 0x00771E7D
		public static Offset<IVisualNovelPerformanceStopScreenEffect> CreateIVisualNovelPerformanceStopScreenEffect(FlatBufferBuilder builder, EVisualNovelPerformanceType Type = EVisualNovelPerformanceType.Enter, float StartTime = 0f, StringOffset ScreenEffectDaOffset = default(StringOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			IVisualNovelPerformanceStopScreenEffect.AddScreenEffectDa(builder, ScreenEffectDaOffset);
			IVisualNovelPerformanceStopScreenEffect.AddStartTime(builder, StartTime);
			IVisualNovelPerformanceStopScreenEffect.AddNullMask(builder, NullMask);
			IVisualNovelPerformanceStopScreenEffect.AddType(builder, Type);
			return IVisualNovelPerformanceStopScreenEffect.EndIVisualNovelPerformanceStopScreenEffect(builder);
		}

		// Token: 0x06036E6B RID: 224875 RVA: 0x00773CA9 File Offset: 0x00771EA9
		public static void StartIVisualNovelPerformanceStopScreenEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06036E6C RID: 224876 RVA: 0x00773CB2 File Offset: 0x00771EB2
		public static void AddType(FlatBufferBuilder builder, EVisualNovelPerformanceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036E6D RID: 224877 RVA: 0x00773CBD File Offset: 0x00771EBD
		public static void AddStartTime(FlatBufferBuilder builder, float startTime)
		{
			builder.AddFloat(1, startTime, 0.0);
		}

		// Token: 0x06036E6E RID: 224878 RVA: 0x00773CD0 File Offset: 0x00771ED0
		public static void AddScreenEffectDa(FlatBufferBuilder builder, StringOffset screenEffectDaOffset)
		{
			builder.AddOffset(2, screenEffectDaOffset.Value, 0);
		}

		// Token: 0x06036E6F RID: 224879 RVA: 0x00773CE0 File Offset: 0x00771EE0
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06036E70 RID: 224880 RVA: 0x00773CEB File Offset: 0x00771EEB
		public static Offset<IVisualNovelPerformanceStopScreenEffect> EndIVisualNovelPerformanceStopScreenEffect(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelPerformanceStopScreenEffect>(builder.EndTable());
		}

		// Token: 0x06036E71 RID: 224881 RVA: 0x00773CF8 File Offset: 0x00771EF8
		public IVisualNovelPerformanceStopScreenEffectT UnPack()
		{
			IVisualNovelPerformanceStopScreenEffectT visualNovelPerformanceStopScreenEffectT = new IVisualNovelPerformanceStopScreenEffectT();
			this.UnPackTo(visualNovelPerformanceStopScreenEffectT);
			return visualNovelPerformanceStopScreenEffectT;
		}

		// Token: 0x06036E72 RID: 224882 RVA: 0x00773D13 File Offset: 0x00771F13
		public void UnPackTo(IVisualNovelPerformanceStopScreenEffectT _o)
		{
			_o.Type = this.Type;
			_o.StartTime = this.StartTime;
			_o.ScreenEffectDa = this.ScreenEffectDa;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06036E73 RID: 224883 RVA: 0x00773D48 File Offset: 0x00771F48
		public static Offset<IVisualNovelPerformanceStopScreenEffect> Pack(FlatBufferBuilder builder, IVisualNovelPerformanceStopScreenEffectT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelPerformanceStopScreenEffect>);
			}
			StringOffset screenEffectDaOffset = (_o.ScreenEffectDa == null) ? default(StringOffset) : builder.CreateString(_o.ScreenEffectDa);
			return IVisualNovelPerformanceStopScreenEffect.CreateIVisualNovelPerformanceStopScreenEffect(builder, _o.Type, _o.StartTime, screenEffectDaOffset, _o.NullMask);
		}

		// Token: 0x04012514 RID: 75028
		private Table __p;
	}
}
