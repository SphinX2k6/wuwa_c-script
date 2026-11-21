using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DDF RID: 28127
	public struct IFadeBackgroundFadeInEffectBlack : IFlatbufferObject
	{
		// Token: 0x1700CE25 RID: 52773
		// (get) Token: 0x060308CF RID: 198863 RVA: 0x00697D71 File Offset: 0x00695F71
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060308D0 RID: 198864 RVA: 0x00697D7E File Offset: 0x00695F7E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060308D1 RID: 198865 RVA: 0x00697D88 File Offset: 0x00695F88
		public static IFadeBackgroundFadeInEffectBlack GetRootAsIFadeBackgroundFadeInEffectBlack(ByteBuffer _bb)
		{
			return IFadeBackgroundFadeInEffectBlack.GetRootAsIFadeBackgroundFadeInEffectBlack(_bb, default(IFadeBackgroundFadeInEffectBlack));
		}

		// Token: 0x060308D2 RID: 198866 RVA: 0x00697DA4 File Offset: 0x00695FA4
		public static IFadeBackgroundFadeInEffectBlack GetRootAsIFadeBackgroundFadeInEffectBlack(ByteBuffer _bb, IFadeBackgroundFadeInEffectBlack obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060308D3 RID: 198867 RVA: 0x00697DC1 File Offset: 0x00695FC1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060308D4 RID: 198868 RVA: 0x00697DD0 File Offset: 0x00695FD0
		public IFadeBackgroundFadeInEffectBlack __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CE26 RID: 52774
		// (get) Token: 0x060308D5 RID: 198869 RVA: 0x00697DE0 File Offset: 0x00695FE0
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

		// Token: 0x1700CE27 RID: 52775
		// (get) Token: 0x060308D6 RID: 198870 RVA: 0x00697E1C File Offset: 0x0069601C
		public EFadeInScreenShowType FadeColor
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EFadeInScreenShowType.White;
				}
				return (EFadeInScreenShowType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CE28 RID: 52776
		// (get) Token: 0x060308D7 RID: 198871 RVA: 0x00697E58 File Offset: 0x00696058
		public float FadeInTime
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CE29 RID: 52777
		// (get) Token: 0x060308D8 RID: 198872 RVA: 0x00697E98 File Offset: 0x00696098
		public float FadeOutTime
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

		// Token: 0x1700CE2A RID: 52778
		// (get) Token: 0x060308D9 RID: 198873 RVA: 0x00697EDC File Offset: 0x006960DC
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

		// Token: 0x060308DA RID: 198874 RVA: 0x00697F19 File Offset: 0x00696119
		public static Offset<IFadeBackgroundFadeInEffectBlack> CreateIFadeBackgroundFadeInEffectBlack(FlatBufferBuilder builder, EFadeBackgroundFadeInEffectType Type = EFadeBackgroundFadeInEffectType.Black, EFadeInScreenShowType FadeColor = EFadeInScreenShowType.White, float FadeInTime = 0f, float FadeOutTime = 0f, byte NullMask = 0)
		{
			builder.StartTable(5);
			IFadeBackgroundFadeInEffectBlack.AddFadeOutTime(builder, FadeOutTime);
			IFadeBackgroundFadeInEffectBlack.AddFadeInTime(builder, FadeInTime);
			IFadeBackgroundFadeInEffectBlack.AddNullMask(builder, NullMask);
			IFadeBackgroundFadeInEffectBlack.AddFadeColor(builder, FadeColor);
			IFadeBackgroundFadeInEffectBlack.AddType(builder, Type);
			return IFadeBackgroundFadeInEffectBlack.EndIFadeBackgroundFadeInEffectBlack(builder);
		}

		// Token: 0x060308DB RID: 198875 RVA: 0x00697F4D File Offset: 0x0069614D
		public static void StartIFadeBackgroundFadeInEffectBlack(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x060308DC RID: 198876 RVA: 0x00697F56 File Offset: 0x00696156
		public static void AddType(FlatBufferBuilder builder, EFadeBackgroundFadeInEffectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060308DD RID: 198877 RVA: 0x00697F61 File Offset: 0x00696161
		public static void AddFadeColor(FlatBufferBuilder builder, EFadeInScreenShowType fadeColor)
		{
			builder.AddByte(1, (byte)fadeColor, 0);
		}

		// Token: 0x060308DE RID: 198878 RVA: 0x00697F6C File Offset: 0x0069616C
		public static void AddFadeInTime(FlatBufferBuilder builder, float fadeInTime)
		{
			builder.AddFloat(2, fadeInTime, 0.0);
		}

		// Token: 0x060308DF RID: 198879 RVA: 0x00697F7F File Offset: 0x0069617F
		public static void AddFadeOutTime(FlatBufferBuilder builder, float fadeOutTime)
		{
			builder.AddFloat(3, fadeOutTime, 0.0);
		}

		// Token: 0x060308E0 RID: 198880 RVA: 0x00697F92 File Offset: 0x00696192
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x060308E1 RID: 198881 RVA: 0x00697F9D File Offset: 0x0069619D
		public static Offset<IFadeBackgroundFadeInEffectBlack> EndIFadeBackgroundFadeInEffectBlack(FlatBufferBuilder builder)
		{
			return new Offset<IFadeBackgroundFadeInEffectBlack>(builder.EndTable());
		}

		// Token: 0x060308E2 RID: 198882 RVA: 0x00697FAC File Offset: 0x006961AC
		public IFadeBackgroundFadeInEffectBlackT UnPack()
		{
			IFadeBackgroundFadeInEffectBlackT fadeBackgroundFadeInEffectBlackT = new IFadeBackgroundFadeInEffectBlackT();
			this.UnPackTo(fadeBackgroundFadeInEffectBlackT);
			return fadeBackgroundFadeInEffectBlackT;
		}

		// Token: 0x060308E3 RID: 198883 RVA: 0x00697FC7 File Offset: 0x006961C7
		public void UnPackTo(IFadeBackgroundFadeInEffectBlackT _o)
		{
			_o.Type = this.Type;
			_o.FadeColor = this.FadeColor;
			_o.FadeInTime = this.FadeInTime;
			_o.FadeOutTime = this.FadeOutTime;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060308E4 RID: 198884 RVA: 0x00698008 File Offset: 0x00696208
		public static Offset<IFadeBackgroundFadeInEffectBlack> Pack(FlatBufferBuilder builder, IFadeBackgroundFadeInEffectBlackT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFadeBackgroundFadeInEffectBlack>);
			}
			return IFadeBackgroundFadeInEffectBlack.CreateIFadeBackgroundFadeInEffectBlack(builder, _o.Type, _o.FadeColor, _o.FadeInTime, _o.FadeOutTime, _o.NullMask);
		}

		// Token: 0x04011C82 RID: 72834
		private Table __p;
	}
}
