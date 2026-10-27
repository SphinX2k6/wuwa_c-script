using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200676E RID: 26478
	public struct IFadeBackgroundFadeOutEffectBlack : IFlatbufferObject
	{
		// Token: 0x1700C487 RID: 50311
		// (get) Token: 0x0602E0F9 RID: 188665 RVA: 0x0064B1E1 File Offset: 0x006493E1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E0FA RID: 188666 RVA: 0x0064B1EE File Offset: 0x006493EE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E0FB RID: 188667 RVA: 0x0064B1F8 File Offset: 0x006493F8
		public static IFadeBackgroundFadeOutEffectBlack GetRootAsIFadeBackgroundFadeOutEffectBlack(ByteBuffer _bb)
		{
			return IFadeBackgroundFadeOutEffectBlack.GetRootAsIFadeBackgroundFadeOutEffectBlack(_bb, default(IFadeBackgroundFadeOutEffectBlack));
		}

		// Token: 0x0602E0FC RID: 188668 RVA: 0x0064B214 File Offset: 0x00649414
		public static IFadeBackgroundFadeOutEffectBlack GetRootAsIFadeBackgroundFadeOutEffectBlack(ByteBuffer _bb, IFadeBackgroundFadeOutEffectBlack obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E0FD RID: 188669 RVA: 0x0064B231 File Offset: 0x00649431
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E0FE RID: 188670 RVA: 0x0064B240 File Offset: 0x00649440
		public IFadeBackgroundFadeOutEffectBlack __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C488 RID: 50312
		// (get) Token: 0x0602E0FF RID: 188671 RVA: 0x0064B250 File Offset: 0x00649450
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

		// Token: 0x1700C489 RID: 50313
		// (get) Token: 0x0602E100 RID: 188672 RVA: 0x0064B28C File Offset: 0x0064948C
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

		// Token: 0x1700C48A RID: 50314
		// (get) Token: 0x0602E101 RID: 188673 RVA: 0x0064B2C8 File Offset: 0x006494C8
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

		// Token: 0x1700C48B RID: 50315
		// (get) Token: 0x0602E102 RID: 188674 RVA: 0x0064B308 File Offset: 0x00649508
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

		// Token: 0x1700C48C RID: 50316
		// (get) Token: 0x0602E103 RID: 188675 RVA: 0x0064B34C File Offset: 0x0064954C
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

		// Token: 0x0602E104 RID: 188676 RVA: 0x0064B389 File Offset: 0x00649589
		public static Offset<IFadeBackgroundFadeOutEffectBlack> CreateIFadeBackgroundFadeOutEffectBlack(FlatBufferBuilder builder, EFadeBackgroundFadeOutEffectType Type = EFadeBackgroundFadeOutEffectType.Black, EFadeInScreenShowType FadeColor = EFadeInScreenShowType.White, float FadeInTime = 0f, float FadeOutTime = 0f, byte NullMask = 0)
		{
			builder.StartTable(5);
			IFadeBackgroundFadeOutEffectBlack.AddFadeOutTime(builder, FadeOutTime);
			IFadeBackgroundFadeOutEffectBlack.AddFadeInTime(builder, FadeInTime);
			IFadeBackgroundFadeOutEffectBlack.AddNullMask(builder, NullMask);
			IFadeBackgroundFadeOutEffectBlack.AddFadeColor(builder, FadeColor);
			IFadeBackgroundFadeOutEffectBlack.AddType(builder, Type);
			return IFadeBackgroundFadeOutEffectBlack.EndIFadeBackgroundFadeOutEffectBlack(builder);
		}

		// Token: 0x0602E105 RID: 188677 RVA: 0x0064B3BD File Offset: 0x006495BD
		public static void StartIFadeBackgroundFadeOutEffectBlack(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602E106 RID: 188678 RVA: 0x0064B3C6 File Offset: 0x006495C6
		public static void AddType(FlatBufferBuilder builder, EFadeBackgroundFadeOutEffectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E107 RID: 188679 RVA: 0x0064B3D1 File Offset: 0x006495D1
		public static void AddFadeColor(FlatBufferBuilder builder, EFadeInScreenShowType fadeColor)
		{
			builder.AddByte(1, (byte)fadeColor, 0);
		}

		// Token: 0x0602E108 RID: 188680 RVA: 0x0064B3DC File Offset: 0x006495DC
		public static void AddFadeInTime(FlatBufferBuilder builder, float fadeInTime)
		{
			builder.AddFloat(2, fadeInTime, 0.0);
		}

		// Token: 0x0602E109 RID: 188681 RVA: 0x0064B3EF File Offset: 0x006495EF
		public static void AddFadeOutTime(FlatBufferBuilder builder, float fadeOutTime)
		{
			builder.AddFloat(3, fadeOutTime, 0.0);
		}

		// Token: 0x0602E10A RID: 188682 RVA: 0x0064B402 File Offset: 0x00649602
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0602E10B RID: 188683 RVA: 0x0064B40D File Offset: 0x0064960D
		public static Offset<IFadeBackgroundFadeOutEffectBlack> EndIFadeBackgroundFadeOutEffectBlack(FlatBufferBuilder builder)
		{
			return new Offset<IFadeBackgroundFadeOutEffectBlack>(builder.EndTable());
		}

		// Token: 0x0602E10C RID: 188684 RVA: 0x0064B41C File Offset: 0x0064961C
		public IFadeBackgroundFadeOutEffectBlackT UnPack()
		{
			IFadeBackgroundFadeOutEffectBlackT fadeBackgroundFadeOutEffectBlackT = new IFadeBackgroundFadeOutEffectBlackT();
			this.UnPackTo(fadeBackgroundFadeOutEffectBlackT);
			return fadeBackgroundFadeOutEffectBlackT;
		}

		// Token: 0x0602E10D RID: 188685 RVA: 0x0064B437 File Offset: 0x00649637
		public void UnPackTo(IFadeBackgroundFadeOutEffectBlackT _o)
		{
			_o.Type = this.Type;
			_o.FadeColor = this.FadeColor;
			_o.FadeInTime = this.FadeInTime;
			_o.FadeOutTime = this.FadeOutTime;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602E10E RID: 188686 RVA: 0x0064B478 File Offset: 0x00649678
		public static Offset<IFadeBackgroundFadeOutEffectBlack> Pack(FlatBufferBuilder builder, IFadeBackgroundFadeOutEffectBlackT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFadeBackgroundFadeOutEffectBlack>);
			}
			return IFadeBackgroundFadeOutEffectBlack.CreateIFadeBackgroundFadeOutEffectBlack(builder, _o.Type, _o.FadeColor, _o.FadeInTime, _o.FadeOutTime, _o.NullMask);
		}

		// Token: 0x04010E64 RID: 69220
		private Table __p;
	}
}
