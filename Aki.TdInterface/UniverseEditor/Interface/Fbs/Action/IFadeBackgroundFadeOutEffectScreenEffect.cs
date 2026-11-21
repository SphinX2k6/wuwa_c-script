using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DF1 RID: 28145
	public struct IFadeBackgroundFadeOutEffectScreenEffect : IFlatbufferObject
	{
		// Token: 0x1700CE48 RID: 52808
		// (get) Token: 0x06030961 RID: 199009 RVA: 0x00698CF0 File Offset: 0x00696EF0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030962 RID: 199010 RVA: 0x00698CFD File Offset: 0x00696EFD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030963 RID: 199011 RVA: 0x00698D04 File Offset: 0x00696F04
		public static IFadeBackgroundFadeOutEffectScreenEffect GetRootAsIFadeBackgroundFadeOutEffectScreenEffect(ByteBuffer _bb)
		{
			return IFadeBackgroundFadeOutEffectScreenEffect.GetRootAsIFadeBackgroundFadeOutEffectScreenEffect(_bb, default(IFadeBackgroundFadeOutEffectScreenEffect));
		}

		// Token: 0x06030964 RID: 199012 RVA: 0x00698D20 File Offset: 0x00696F20
		public static IFadeBackgroundFadeOutEffectScreenEffect GetRootAsIFadeBackgroundFadeOutEffectScreenEffect(ByteBuffer _bb, IFadeBackgroundFadeOutEffectScreenEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030965 RID: 199013 RVA: 0x00698D3D File Offset: 0x00696F3D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030966 RID: 199014 RVA: 0x00698D4C File Offset: 0x00696F4C
		public IFadeBackgroundFadeOutEffectScreenEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CE49 RID: 52809
		// (get) Token: 0x06030967 RID: 199015 RVA: 0x00698D5C File Offset: 0x00696F5C
		public EFadeBackgroundFadeOutEffectType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EFadeBackgroundFadeOutEffectType.Black;
				}
				return (EFadeBackgroundFadeOutEffectType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CE4A RID: 52810
		// (get) Token: 0x06030968 RID: 199016 RVA: 0x00698D98 File Offset: 0x00696F98
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

		// Token: 0x06030969 RID: 199017 RVA: 0x00698DCF File Offset: 0x00696FCF
		public Span<byte> GetScreenEffectBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0603096A RID: 199018 RVA: 0x00698DDE File Offset: 0x00696FDE
		public byte[] GetScreenEffectArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0603096B RID: 199019 RVA: 0x00698DEC File Offset: 0x00696FEC
		public static Offset<IFadeBackgroundFadeOutEffectScreenEffect> CreateIFadeBackgroundFadeOutEffectScreenEffect(FlatBufferBuilder builder, EFadeBackgroundFadeOutEffectType Type = EFadeBackgroundFadeOutEffectType.Black, StringOffset ScreenEffectOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IFadeBackgroundFadeOutEffectScreenEffect.AddScreenEffect(builder, ScreenEffectOffset);
			IFadeBackgroundFadeOutEffectScreenEffect.AddType(builder, Type);
			return IFadeBackgroundFadeOutEffectScreenEffect.EndIFadeBackgroundFadeOutEffectScreenEffect(builder);
		}

		// Token: 0x0603096C RID: 199020 RVA: 0x00698E09 File Offset: 0x00697009
		public static void StartIFadeBackgroundFadeOutEffectScreenEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603096D RID: 199021 RVA: 0x00698E12 File Offset: 0x00697012
		public static void AddType(FlatBufferBuilder builder, EFadeBackgroundFadeOutEffectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603096E RID: 199022 RVA: 0x00698E1D File Offset: 0x0069701D
		public static void AddScreenEffect(FlatBufferBuilder builder, StringOffset screenEffectOffset)
		{
			builder.AddOffset(1, screenEffectOffset.Value, 0);
		}

		// Token: 0x0603096F RID: 199023 RVA: 0x00698E2D File Offset: 0x0069702D
		public static Offset<IFadeBackgroundFadeOutEffectScreenEffect> EndIFadeBackgroundFadeOutEffectScreenEffect(FlatBufferBuilder builder)
		{
			return new Offset<IFadeBackgroundFadeOutEffectScreenEffect>(builder.EndTable());
		}

		// Token: 0x06030970 RID: 199024 RVA: 0x00698E3C File Offset: 0x0069703C
		public IFadeBackgroundFadeOutEffectScreenEffectT UnPack()
		{
			IFadeBackgroundFadeOutEffectScreenEffectT fadeBackgroundFadeOutEffectScreenEffectT = new IFadeBackgroundFadeOutEffectScreenEffectT();
			this.UnPackTo(fadeBackgroundFadeOutEffectScreenEffectT);
			return fadeBackgroundFadeOutEffectScreenEffectT;
		}

		// Token: 0x06030971 RID: 199025 RVA: 0x00698E57 File Offset: 0x00697057
		public void UnPackTo(IFadeBackgroundFadeOutEffectScreenEffectT _o)
		{
			_o.Type = this.Type;
			_o.ScreenEffect = this.ScreenEffect;
		}

		// Token: 0x06030972 RID: 199026 RVA: 0x00698E74 File Offset: 0x00697074
		public static Offset<IFadeBackgroundFadeOutEffectScreenEffect> Pack(FlatBufferBuilder builder, IFadeBackgroundFadeOutEffectScreenEffectT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFadeBackgroundFadeOutEffectScreenEffect>);
			}
			StringOffset screenEffectOffset = (_o.ScreenEffect == null) ? default(StringOffset) : builder.CreateString(_o.ScreenEffect);
			return IFadeBackgroundFadeOutEffectScreenEffect.CreateIFadeBackgroundFadeOutEffectScreenEffect(builder, _o.Type, screenEffectOffset);
		}

		// Token: 0x04011C9C RID: 72860
		private Table __p;
	}
}
