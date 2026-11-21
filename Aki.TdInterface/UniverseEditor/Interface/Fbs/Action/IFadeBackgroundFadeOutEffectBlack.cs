using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DEE RID: 28142
	public struct IFadeBackgroundFadeOutEffectBlack : IFlatbufferObject
	{
		// Token: 0x1700CE3D RID: 52797
		// (get) Token: 0x0603093F RID: 198975 RVA: 0x00698925 File Offset: 0x00696B25
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030940 RID: 198976 RVA: 0x00698932 File Offset: 0x00696B32
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030941 RID: 198977 RVA: 0x0069893C File Offset: 0x00696B3C
		public static IFadeBackgroundFadeOutEffectBlack GetRootAsIFadeBackgroundFadeOutEffectBlack(ByteBuffer _bb)
		{
			return IFadeBackgroundFadeOutEffectBlack.GetRootAsIFadeBackgroundFadeOutEffectBlack(_bb, default(IFadeBackgroundFadeOutEffectBlack));
		}

		// Token: 0x06030942 RID: 198978 RVA: 0x00698958 File Offset: 0x00696B58
		public static IFadeBackgroundFadeOutEffectBlack GetRootAsIFadeBackgroundFadeOutEffectBlack(ByteBuffer _bb, IFadeBackgroundFadeOutEffectBlack obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030943 RID: 198979 RVA: 0x00698975 File Offset: 0x00696B75
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030944 RID: 198980 RVA: 0x00698984 File Offset: 0x00696B84
		public IFadeBackgroundFadeOutEffectBlack __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CE3E RID: 52798
		// (get) Token: 0x06030945 RID: 198981 RVA: 0x00698994 File Offset: 0x00696B94
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

		// Token: 0x1700CE3F RID: 52799
		// (get) Token: 0x06030946 RID: 198982 RVA: 0x006989D0 File Offset: 0x00696BD0
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

		// Token: 0x1700CE40 RID: 52800
		// (get) Token: 0x06030947 RID: 198983 RVA: 0x00698A0C File Offset: 0x00696C0C
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

		// Token: 0x1700CE41 RID: 52801
		// (get) Token: 0x06030948 RID: 198984 RVA: 0x00698A4C File Offset: 0x00696C4C
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

		// Token: 0x1700CE42 RID: 52802
		// (get) Token: 0x06030949 RID: 198985 RVA: 0x00698A90 File Offset: 0x00696C90
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

		// Token: 0x0603094A RID: 198986 RVA: 0x00698ACD File Offset: 0x00696CCD
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

		// Token: 0x0603094B RID: 198987 RVA: 0x00698B01 File Offset: 0x00696D01
		public static void StartIFadeBackgroundFadeOutEffectBlack(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0603094C RID: 198988 RVA: 0x00698B0A File Offset: 0x00696D0A
		public static void AddType(FlatBufferBuilder builder, EFadeBackgroundFadeOutEffectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603094D RID: 198989 RVA: 0x00698B15 File Offset: 0x00696D15
		public static void AddFadeColor(FlatBufferBuilder builder, EFadeInScreenShowType fadeColor)
		{
			builder.AddByte(1, (byte)fadeColor, 0);
		}

		// Token: 0x0603094E RID: 198990 RVA: 0x00698B20 File Offset: 0x00696D20
		public static void AddFadeInTime(FlatBufferBuilder builder, float fadeInTime)
		{
			builder.AddFloat(2, fadeInTime, 0.0);
		}

		// Token: 0x0603094F RID: 198991 RVA: 0x00698B33 File Offset: 0x00696D33
		public static void AddFadeOutTime(FlatBufferBuilder builder, float fadeOutTime)
		{
			builder.AddFloat(3, fadeOutTime, 0.0);
		}

		// Token: 0x06030950 RID: 198992 RVA: 0x00698B46 File Offset: 0x00696D46
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06030951 RID: 198993 RVA: 0x00698B51 File Offset: 0x00696D51
		public static Offset<IFadeBackgroundFadeOutEffectBlack> EndIFadeBackgroundFadeOutEffectBlack(FlatBufferBuilder builder)
		{
			return new Offset<IFadeBackgroundFadeOutEffectBlack>(builder.EndTable());
		}

		// Token: 0x06030952 RID: 198994 RVA: 0x00698B60 File Offset: 0x00696D60
		public IFadeBackgroundFadeOutEffectBlackT UnPack()
		{
			IFadeBackgroundFadeOutEffectBlackT fadeBackgroundFadeOutEffectBlackT = new IFadeBackgroundFadeOutEffectBlackT();
			this.UnPackTo(fadeBackgroundFadeOutEffectBlackT);
			return fadeBackgroundFadeOutEffectBlackT;
		}

		// Token: 0x06030953 RID: 198995 RVA: 0x00698B7B File Offset: 0x00696D7B
		public void UnPackTo(IFadeBackgroundFadeOutEffectBlackT _o)
		{
			_o.Type = this.Type;
			_o.FadeColor = this.FadeColor;
			_o.FadeInTime = this.FadeInTime;
			_o.FadeOutTime = this.FadeOutTime;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06030954 RID: 198996 RVA: 0x00698BBC File Offset: 0x00696DBC
		public static Offset<IFadeBackgroundFadeOutEffectBlack> Pack(FlatBufferBuilder builder, IFadeBackgroundFadeOutEffectBlackT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFadeBackgroundFadeOutEffectBlack>);
			}
			return IFadeBackgroundFadeOutEffectBlack.CreateIFadeBackgroundFadeOutEffectBlack(builder, _o.Type, _o.FadeColor, _o.FadeInTime, _o.FadeOutTime, _o.NullMask);
		}

		// Token: 0x04011C96 RID: 72854
		private Table __p;
	}
}
