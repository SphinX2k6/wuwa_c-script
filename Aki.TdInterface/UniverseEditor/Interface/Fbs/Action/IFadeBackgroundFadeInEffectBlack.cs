using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200675F RID: 26463
	public struct IFadeBackgroundFadeInEffectBlack : IFlatbufferObject
	{
		// Token: 0x1700C46F RID: 50287
		// (get) Token: 0x0602E089 RID: 188553 RVA: 0x0064A62D File Offset: 0x0064882D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E08A RID: 188554 RVA: 0x0064A63A File Offset: 0x0064883A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E08B RID: 188555 RVA: 0x0064A644 File Offset: 0x00648844
		public static IFadeBackgroundFadeInEffectBlack GetRootAsIFadeBackgroundFadeInEffectBlack(ByteBuffer _bb)
		{
			return IFadeBackgroundFadeInEffectBlack.GetRootAsIFadeBackgroundFadeInEffectBlack(_bb, default(IFadeBackgroundFadeInEffectBlack));
		}

		// Token: 0x0602E08C RID: 188556 RVA: 0x0064A660 File Offset: 0x00648860
		public static IFadeBackgroundFadeInEffectBlack GetRootAsIFadeBackgroundFadeInEffectBlack(ByteBuffer _bb, IFadeBackgroundFadeInEffectBlack obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E08D RID: 188557 RVA: 0x0064A67D File Offset: 0x0064887D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E08E RID: 188558 RVA: 0x0064A68C File Offset: 0x0064888C
		public IFadeBackgroundFadeInEffectBlack __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C470 RID: 50288
		// (get) Token: 0x0602E08F RID: 188559 RVA: 0x0064A69C File Offset: 0x0064889C
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

		// Token: 0x1700C471 RID: 50289
		// (get) Token: 0x0602E090 RID: 188560 RVA: 0x0064A6D8 File Offset: 0x006488D8
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

		// Token: 0x1700C472 RID: 50290
		// (get) Token: 0x0602E091 RID: 188561 RVA: 0x0064A714 File Offset: 0x00648914
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

		// Token: 0x1700C473 RID: 50291
		// (get) Token: 0x0602E092 RID: 188562 RVA: 0x0064A754 File Offset: 0x00648954
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

		// Token: 0x1700C474 RID: 50292
		// (get) Token: 0x0602E093 RID: 188563 RVA: 0x0064A798 File Offset: 0x00648998
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

		// Token: 0x0602E094 RID: 188564 RVA: 0x0064A7D5 File Offset: 0x006489D5
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

		// Token: 0x0602E095 RID: 188565 RVA: 0x0064A809 File Offset: 0x00648A09
		public static void StartIFadeBackgroundFadeInEffectBlack(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602E096 RID: 188566 RVA: 0x0064A812 File Offset: 0x00648A12
		public static void AddType(FlatBufferBuilder builder, EFadeBackgroundFadeInEffectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E097 RID: 188567 RVA: 0x0064A81D File Offset: 0x00648A1D
		public static void AddFadeColor(FlatBufferBuilder builder, EFadeInScreenShowType fadeColor)
		{
			builder.AddByte(1, (byte)fadeColor, 0);
		}

		// Token: 0x0602E098 RID: 188568 RVA: 0x0064A828 File Offset: 0x00648A28
		public static void AddFadeInTime(FlatBufferBuilder builder, float fadeInTime)
		{
			builder.AddFloat(2, fadeInTime, 0.0);
		}

		// Token: 0x0602E099 RID: 188569 RVA: 0x0064A83B File Offset: 0x00648A3B
		public static void AddFadeOutTime(FlatBufferBuilder builder, float fadeOutTime)
		{
			builder.AddFloat(3, fadeOutTime, 0.0);
		}

		// Token: 0x0602E09A RID: 188570 RVA: 0x0064A84E File Offset: 0x00648A4E
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0602E09B RID: 188571 RVA: 0x0064A859 File Offset: 0x00648A59
		public static Offset<IFadeBackgroundFadeInEffectBlack> EndIFadeBackgroundFadeInEffectBlack(FlatBufferBuilder builder)
		{
			return new Offset<IFadeBackgroundFadeInEffectBlack>(builder.EndTable());
		}

		// Token: 0x0602E09C RID: 188572 RVA: 0x0064A868 File Offset: 0x00648A68
		public IFadeBackgroundFadeInEffectBlackT UnPack()
		{
			IFadeBackgroundFadeInEffectBlackT fadeBackgroundFadeInEffectBlackT = new IFadeBackgroundFadeInEffectBlackT();
			this.UnPackTo(fadeBackgroundFadeInEffectBlackT);
			return fadeBackgroundFadeInEffectBlackT;
		}

		// Token: 0x0602E09D RID: 188573 RVA: 0x0064A883 File Offset: 0x00648A83
		public void UnPackTo(IFadeBackgroundFadeInEffectBlackT _o)
		{
			_o.Type = this.Type;
			_o.FadeColor = this.FadeColor;
			_o.FadeInTime = this.FadeInTime;
			_o.FadeOutTime = this.FadeOutTime;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602E09E RID: 188574 RVA: 0x0064A8C4 File Offset: 0x00648AC4
		public static Offset<IFadeBackgroundFadeInEffectBlack> Pack(FlatBufferBuilder builder, IFadeBackgroundFadeInEffectBlackT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFadeBackgroundFadeInEffectBlack>);
			}
			return IFadeBackgroundFadeInEffectBlack.CreateIFadeBackgroundFadeInEffectBlack(builder, _o.Type, _o.FadeColor, _o.FadeInTime, _o.FadeOutTime, _o.NullMask);
		}

		// Token: 0x04010E50 RID: 69200
		private Table __p;
	}
}
