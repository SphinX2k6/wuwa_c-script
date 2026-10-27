using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006771 RID: 26481
	public struct IFadeBackgroundFadeOutEffectScreenEffect : IFlatbufferObject
	{
		// Token: 0x1700C492 RID: 50322
		// (get) Token: 0x0602E11B RID: 188699 RVA: 0x0064B5AC File Offset: 0x006497AC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E11C RID: 188700 RVA: 0x0064B5B9 File Offset: 0x006497B9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E11D RID: 188701 RVA: 0x0064B5C0 File Offset: 0x006497C0
		public static IFadeBackgroundFadeOutEffectScreenEffect GetRootAsIFadeBackgroundFadeOutEffectScreenEffect(ByteBuffer _bb)
		{
			return IFadeBackgroundFadeOutEffectScreenEffect.GetRootAsIFadeBackgroundFadeOutEffectScreenEffect(_bb, default(IFadeBackgroundFadeOutEffectScreenEffect));
		}

		// Token: 0x0602E11E RID: 188702 RVA: 0x0064B5DC File Offset: 0x006497DC
		public static IFadeBackgroundFadeOutEffectScreenEffect GetRootAsIFadeBackgroundFadeOutEffectScreenEffect(ByteBuffer _bb, IFadeBackgroundFadeOutEffectScreenEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E11F RID: 188703 RVA: 0x0064B5F9 File Offset: 0x006497F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E120 RID: 188704 RVA: 0x0064B608 File Offset: 0x00649808
		public IFadeBackgroundFadeOutEffectScreenEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C493 RID: 50323
		// (get) Token: 0x0602E121 RID: 188705 RVA: 0x0064B618 File Offset: 0x00649818
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

		// Token: 0x1700C494 RID: 50324
		// (get) Token: 0x0602E122 RID: 188706 RVA: 0x0064B654 File Offset: 0x00649854
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

		// Token: 0x0602E123 RID: 188707 RVA: 0x0064B68B File Offset: 0x0064988B
		public Span<byte> GetScreenEffectBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602E124 RID: 188708 RVA: 0x0064B69A File Offset: 0x0064989A
		public byte[] GetScreenEffectArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602E125 RID: 188709 RVA: 0x0064B6A8 File Offset: 0x006498A8
		public static Offset<IFadeBackgroundFadeOutEffectScreenEffect> CreateIFadeBackgroundFadeOutEffectScreenEffect(FlatBufferBuilder builder, EFadeBackgroundFadeOutEffectType Type = EFadeBackgroundFadeOutEffectType.Black, StringOffset ScreenEffectOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IFadeBackgroundFadeOutEffectScreenEffect.AddScreenEffect(builder, ScreenEffectOffset);
			IFadeBackgroundFadeOutEffectScreenEffect.AddType(builder, Type);
			return IFadeBackgroundFadeOutEffectScreenEffect.EndIFadeBackgroundFadeOutEffectScreenEffect(builder);
		}

		// Token: 0x0602E126 RID: 188710 RVA: 0x0064B6C5 File Offset: 0x006498C5
		public static void StartIFadeBackgroundFadeOutEffectScreenEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602E127 RID: 188711 RVA: 0x0064B6CE File Offset: 0x006498CE
		public static void AddType(FlatBufferBuilder builder, EFadeBackgroundFadeOutEffectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E128 RID: 188712 RVA: 0x0064B6D9 File Offset: 0x006498D9
		public static void AddScreenEffect(FlatBufferBuilder builder, StringOffset screenEffectOffset)
		{
			builder.AddOffset(1, screenEffectOffset.Value, 0);
		}

		// Token: 0x0602E129 RID: 188713 RVA: 0x0064B6E9 File Offset: 0x006498E9
		public static Offset<IFadeBackgroundFadeOutEffectScreenEffect> EndIFadeBackgroundFadeOutEffectScreenEffect(FlatBufferBuilder builder)
		{
			return new Offset<IFadeBackgroundFadeOutEffectScreenEffect>(builder.EndTable());
		}

		// Token: 0x0602E12A RID: 188714 RVA: 0x0064B6F8 File Offset: 0x006498F8
		public IFadeBackgroundFadeOutEffectScreenEffectT UnPack()
		{
			IFadeBackgroundFadeOutEffectScreenEffectT fadeBackgroundFadeOutEffectScreenEffectT = new IFadeBackgroundFadeOutEffectScreenEffectT();
			this.UnPackTo(fadeBackgroundFadeOutEffectScreenEffectT);
			return fadeBackgroundFadeOutEffectScreenEffectT;
		}

		// Token: 0x0602E12B RID: 188715 RVA: 0x0064B713 File Offset: 0x00649913
		public void UnPackTo(IFadeBackgroundFadeOutEffectScreenEffectT _o)
		{
			_o.Type = this.Type;
			_o.ScreenEffect = this.ScreenEffect;
		}

		// Token: 0x0602E12C RID: 188716 RVA: 0x0064B730 File Offset: 0x00649930
		public static Offset<IFadeBackgroundFadeOutEffectScreenEffect> Pack(FlatBufferBuilder builder, IFadeBackgroundFadeOutEffectScreenEffectT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFadeBackgroundFadeOutEffectScreenEffect>);
			}
			StringOffset screenEffectOffset = (_o.ScreenEffect == null) ? default(StringOffset) : builder.CreateString(_o.ScreenEffect);
			return IFadeBackgroundFadeOutEffectScreenEffect.CreateIFadeBackgroundFadeOutEffectScreenEffect(builder, _o.Type, screenEffectOffset);
		}

		// Token: 0x04010E6A RID: 69226
		private Table __p;
	}
}
