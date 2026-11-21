using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DE2 RID: 28130
	public struct IFadeBackgroundFadeInEffectScreenEffect : IFlatbufferObject
	{
		// Token: 0x1700CE30 RID: 52784
		// (get) Token: 0x060308F1 RID: 198897 RVA: 0x0069813C File Offset: 0x0069633C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060308F2 RID: 198898 RVA: 0x00698149 File Offset: 0x00696349
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060308F3 RID: 198899 RVA: 0x00698150 File Offset: 0x00696350
		public static IFadeBackgroundFadeInEffectScreenEffect GetRootAsIFadeBackgroundFadeInEffectScreenEffect(ByteBuffer _bb)
		{
			return IFadeBackgroundFadeInEffectScreenEffect.GetRootAsIFadeBackgroundFadeInEffectScreenEffect(_bb, default(IFadeBackgroundFadeInEffectScreenEffect));
		}

		// Token: 0x060308F4 RID: 198900 RVA: 0x0069816C File Offset: 0x0069636C
		public static IFadeBackgroundFadeInEffectScreenEffect GetRootAsIFadeBackgroundFadeInEffectScreenEffect(ByteBuffer _bb, IFadeBackgroundFadeInEffectScreenEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060308F5 RID: 198901 RVA: 0x00698189 File Offset: 0x00696389
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060308F6 RID: 198902 RVA: 0x00698198 File Offset: 0x00696398
		public IFadeBackgroundFadeInEffectScreenEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CE31 RID: 52785
		// (get) Token: 0x060308F7 RID: 198903 RVA: 0x006981A8 File Offset: 0x006963A8
		public EFadeBackgroundFadeInEffectType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EFadeBackgroundFadeInEffectType.Black;
				}
				return (EFadeBackgroundFadeInEffectType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CE32 RID: 52786
		// (get) Token: 0x060308F8 RID: 198904 RVA: 0x006981E4 File Offset: 0x006963E4
		public string ScreenEffect
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060308F9 RID: 198905 RVA: 0x0069821B File Offset: 0x0069641B
		public Span<byte> GetScreenEffectBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060308FA RID: 198906 RVA: 0x0069822A File Offset: 0x0069642A
		public byte[] GetScreenEffectArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x060308FB RID: 198907 RVA: 0x00698238 File Offset: 0x00696438
		public static Offset<IFadeBackgroundFadeInEffectScreenEffect> CreateIFadeBackgroundFadeInEffectScreenEffect(FlatBufferBuilder builder, EFadeBackgroundFadeInEffectType Type = EFadeBackgroundFadeInEffectType.Black, StringOffset ScreenEffectOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IFadeBackgroundFadeInEffectScreenEffect.AddScreenEffect(builder, ScreenEffectOffset);
			IFadeBackgroundFadeInEffectScreenEffect.AddType(builder, Type);
			return IFadeBackgroundFadeInEffectScreenEffect.EndIFadeBackgroundFadeInEffectScreenEffect(builder);
		}

		// Token: 0x060308FC RID: 198908 RVA: 0x00698255 File Offset: 0x00696455
		public static void StartIFadeBackgroundFadeInEffectScreenEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060308FD RID: 198909 RVA: 0x0069825E File Offset: 0x0069645E
		public static void AddType(FlatBufferBuilder builder, EFadeBackgroundFadeInEffectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060308FE RID: 198910 RVA: 0x00698269 File Offset: 0x00696469
		public static void AddScreenEffect(FlatBufferBuilder builder, StringOffset screenEffectOffset)
		{
			builder.AddOffset(1, screenEffectOffset.Value, 0);
		}

		// Token: 0x060308FF RID: 198911 RVA: 0x00698279 File Offset: 0x00696479
		public static Offset<IFadeBackgroundFadeInEffectScreenEffect> EndIFadeBackgroundFadeInEffectScreenEffect(FlatBufferBuilder builder)
		{
			return new Offset<IFadeBackgroundFadeInEffectScreenEffect>(builder.EndTable());
		}

		// Token: 0x06030900 RID: 198912 RVA: 0x00698288 File Offset: 0x00696488
		public IFadeBackgroundFadeInEffectScreenEffectT UnPack()
		{
			IFadeBackgroundFadeInEffectScreenEffectT fadeBackgroundFadeInEffectScreenEffectT = new IFadeBackgroundFadeInEffectScreenEffectT();
			this.UnPackTo(fadeBackgroundFadeInEffectScreenEffectT);
			return fadeBackgroundFadeInEffectScreenEffectT;
		}

		// Token: 0x06030901 RID: 198913 RVA: 0x006982A3 File Offset: 0x006964A3
		public void UnPackTo(IFadeBackgroundFadeInEffectScreenEffectT _o)
		{
			_o.Type = this.Type;
			_o.ScreenEffect = this.ScreenEffect;
		}

		// Token: 0x06030902 RID: 198914 RVA: 0x006982C0 File Offset: 0x006964C0
		public static Offset<IFadeBackgroundFadeInEffectScreenEffect> Pack(FlatBufferBuilder builder, IFadeBackgroundFadeInEffectScreenEffectT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFadeBackgroundFadeInEffectScreenEffect>);
			}
			StringOffset screenEffectOffset = (_o.ScreenEffect == null) ? default(StringOffset) : builder.CreateString(_o.ScreenEffect);
			return IFadeBackgroundFadeInEffectScreenEffect.CreateIFadeBackgroundFadeInEffectScreenEffect(builder, _o.Type, screenEffectOffset);
		}

		// Token: 0x04011C88 RID: 72840
		private Table __p;
	}
}
