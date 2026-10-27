using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006762 RID: 26466
	public struct IFadeBackgroundFadeInEffectScreenEffect : IFlatbufferObject
	{
		// Token: 0x1700C47A RID: 50298
		// (get) Token: 0x0602E0AB RID: 188587 RVA: 0x0064A9F8 File Offset: 0x00648BF8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E0AC RID: 188588 RVA: 0x0064AA05 File Offset: 0x00648C05
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E0AD RID: 188589 RVA: 0x0064AA0C File Offset: 0x00648C0C
		public static IFadeBackgroundFadeInEffectScreenEffect GetRootAsIFadeBackgroundFadeInEffectScreenEffect(ByteBuffer _bb)
		{
			return IFadeBackgroundFadeInEffectScreenEffect.GetRootAsIFadeBackgroundFadeInEffectScreenEffect(_bb, default(IFadeBackgroundFadeInEffectScreenEffect));
		}

		// Token: 0x0602E0AE RID: 188590 RVA: 0x0064AA28 File Offset: 0x00648C28
		public static IFadeBackgroundFadeInEffectScreenEffect GetRootAsIFadeBackgroundFadeInEffectScreenEffect(ByteBuffer _bb, IFadeBackgroundFadeInEffectScreenEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E0AF RID: 188591 RVA: 0x0064AA45 File Offset: 0x00648C45
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E0B0 RID: 188592 RVA: 0x0064AA54 File Offset: 0x00648C54
		public IFadeBackgroundFadeInEffectScreenEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C47B RID: 50299
		// (get) Token: 0x0602E0B1 RID: 188593 RVA: 0x0064AA64 File Offset: 0x00648C64
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

		// Token: 0x1700C47C RID: 50300
		// (get) Token: 0x0602E0B2 RID: 188594 RVA: 0x0064AAA0 File Offset: 0x00648CA0
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

		// Token: 0x0602E0B3 RID: 188595 RVA: 0x0064AAD7 File Offset: 0x00648CD7
		public Span<byte> GetScreenEffectBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602E0B4 RID: 188596 RVA: 0x0064AAE6 File Offset: 0x00648CE6
		public byte[] GetScreenEffectArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602E0B5 RID: 188597 RVA: 0x0064AAF4 File Offset: 0x00648CF4
		public static Offset<IFadeBackgroundFadeInEffectScreenEffect> CreateIFadeBackgroundFadeInEffectScreenEffect(FlatBufferBuilder builder, EFadeBackgroundFadeInEffectType Type = EFadeBackgroundFadeInEffectType.Black, StringOffset ScreenEffectOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IFadeBackgroundFadeInEffectScreenEffect.AddScreenEffect(builder, ScreenEffectOffset);
			IFadeBackgroundFadeInEffectScreenEffect.AddType(builder, Type);
			return IFadeBackgroundFadeInEffectScreenEffect.EndIFadeBackgroundFadeInEffectScreenEffect(builder);
		}

		// Token: 0x0602E0B6 RID: 188598 RVA: 0x0064AB11 File Offset: 0x00648D11
		public static void StartIFadeBackgroundFadeInEffectScreenEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602E0B7 RID: 188599 RVA: 0x0064AB1A File Offset: 0x00648D1A
		public static void AddType(FlatBufferBuilder builder, EFadeBackgroundFadeInEffectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E0B8 RID: 188600 RVA: 0x0064AB25 File Offset: 0x00648D25
		public static void AddScreenEffect(FlatBufferBuilder builder, StringOffset screenEffectOffset)
		{
			builder.AddOffset(1, screenEffectOffset.Value, 0);
		}

		// Token: 0x0602E0B9 RID: 188601 RVA: 0x0064AB35 File Offset: 0x00648D35
		public static Offset<IFadeBackgroundFadeInEffectScreenEffect> EndIFadeBackgroundFadeInEffectScreenEffect(FlatBufferBuilder builder)
		{
			return new Offset<IFadeBackgroundFadeInEffectScreenEffect>(builder.EndTable());
		}

		// Token: 0x0602E0BA RID: 188602 RVA: 0x0064AB44 File Offset: 0x00648D44
		public IFadeBackgroundFadeInEffectScreenEffectT UnPack()
		{
			IFadeBackgroundFadeInEffectScreenEffectT fadeBackgroundFadeInEffectScreenEffectT = new IFadeBackgroundFadeInEffectScreenEffectT();
			this.UnPackTo(fadeBackgroundFadeInEffectScreenEffectT);
			return fadeBackgroundFadeInEffectScreenEffectT;
		}

		// Token: 0x0602E0BB RID: 188603 RVA: 0x0064AB5F File Offset: 0x00648D5F
		public void UnPackTo(IFadeBackgroundFadeInEffectScreenEffectT _o)
		{
			_o.Type = this.Type;
			_o.ScreenEffect = this.ScreenEffect;
		}

		// Token: 0x0602E0BC RID: 188604 RVA: 0x0064AB7C File Offset: 0x00648D7C
		public static Offset<IFadeBackgroundFadeInEffectScreenEffect> Pack(FlatBufferBuilder builder, IFadeBackgroundFadeInEffectScreenEffectT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFadeBackgroundFadeInEffectScreenEffect>);
			}
			StringOffset screenEffectOffset = (_o.ScreenEffect == null) ? default(StringOffset) : builder.CreateString(_o.ScreenEffect);
			return IFadeBackgroundFadeInEffectScreenEffect.CreateIFadeBackgroundFadeInEffectScreenEffect(builder, _o.Type, screenEffectOffset);
		}

		// Token: 0x04010E56 RID: 69206
		private Table __p;
	}
}
