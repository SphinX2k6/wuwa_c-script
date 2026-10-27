using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B82 RID: 27522
	public struct IMp4GamepadShakeFadeInConfig : IFlatbufferObject
	{
		// Token: 0x1700CC96 RID: 52374
		// (get) Token: 0x06030555 RID: 197973 RVA: 0x0069121D File Offset: 0x0068F41D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030556 RID: 197974 RVA: 0x0069122A File Offset: 0x0068F42A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030557 RID: 197975 RVA: 0x00691234 File Offset: 0x0068F434
		public static IMp4GamepadShakeFadeInConfig GetRootAsIMp4GamepadShakeFadeInConfig(ByteBuffer _bb)
		{
			return IMp4GamepadShakeFadeInConfig.GetRootAsIMp4GamepadShakeFadeInConfig(_bb, default(IMp4GamepadShakeFadeInConfig));
		}

		// Token: 0x06030558 RID: 197976 RVA: 0x00691250 File Offset: 0x0068F450
		public static IMp4GamepadShakeFadeInConfig GetRootAsIMp4GamepadShakeFadeInConfig(ByteBuffer _bb, IMp4GamepadShakeFadeInConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030559 RID: 197977 RVA: 0x0069126D File Offset: 0x0068F46D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603055A RID: 197978 RVA: 0x0069127C File Offset: 0x0068F47C
		public IMp4GamepadShakeFadeInConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CC97 RID: 52375
		// (get) Token: 0x0603055B RID: 197979 RVA: 0x0069128C File Offset: 0x0068F48C
		public float FadeInTime
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CC98 RID: 52376
		// (get) Token: 0x0603055C RID: 197980 RVA: 0x006912CC File Offset: 0x0068F4CC
		public EMp4GamepadShakeCurve FadeInCurve
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EMp4GamepadShakeCurve.Linear;
				}
				return (EMp4GamepadShakeCurve)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CC99 RID: 52377
		// (get) Token: 0x0603055D RID: 197981 RVA: 0x00691308 File Offset: 0x0068F508
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603055E RID: 197982 RVA: 0x00691344 File Offset: 0x0068F544
		public static Offset<IMp4GamepadShakeFadeInConfig> CreateIMp4GamepadShakeFadeInConfig(FlatBufferBuilder builder, float FadeInTime = 0f, EMp4GamepadShakeCurve FadeInCurve = EMp4GamepadShakeCurve.Linear, byte NullMask = 0)
		{
			builder.StartTable(3);
			IMp4GamepadShakeFadeInConfig.AddFadeInTime(builder, FadeInTime);
			IMp4GamepadShakeFadeInConfig.AddNullMask(builder, NullMask);
			IMp4GamepadShakeFadeInConfig.AddFadeInCurve(builder, FadeInCurve);
			return IMp4GamepadShakeFadeInConfig.EndIMp4GamepadShakeFadeInConfig(builder);
		}

		// Token: 0x0603055F RID: 197983 RVA: 0x00691368 File Offset: 0x0068F568
		public static void StartIMp4GamepadShakeFadeInConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06030560 RID: 197984 RVA: 0x00691371 File Offset: 0x0068F571
		public static void AddFadeInTime(FlatBufferBuilder builder, float fadeInTime)
		{
			builder.AddFloat(0, fadeInTime, 0.0);
		}

		// Token: 0x06030561 RID: 197985 RVA: 0x00691384 File Offset: 0x0068F584
		public static void AddFadeInCurve(FlatBufferBuilder builder, EMp4GamepadShakeCurve fadeInCurve)
		{
			builder.AddByte(1, (byte)fadeInCurve, 0);
		}

		// Token: 0x06030562 RID: 197986 RVA: 0x0069138F File Offset: 0x0068F58F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06030563 RID: 197987 RVA: 0x0069139A File Offset: 0x0068F59A
		public static Offset<IMp4GamepadShakeFadeInConfig> EndIMp4GamepadShakeFadeInConfig(FlatBufferBuilder builder)
		{
			return new Offset<IMp4GamepadShakeFadeInConfig>(builder.EndTable());
		}

		// Token: 0x06030564 RID: 197988 RVA: 0x006913A8 File Offset: 0x0068F5A8
		public IMp4GamepadShakeFadeInConfigT UnPack()
		{
			IMp4GamepadShakeFadeInConfigT mp4GamepadShakeFadeInConfigT = new IMp4GamepadShakeFadeInConfigT();
			this.UnPackTo(mp4GamepadShakeFadeInConfigT);
			return mp4GamepadShakeFadeInConfigT;
		}

		// Token: 0x06030565 RID: 197989 RVA: 0x006913C3 File Offset: 0x0068F5C3
		public void UnPackTo(IMp4GamepadShakeFadeInConfigT _o)
		{
			_o.FadeInTime = this.FadeInTime;
			_o.FadeInCurve = this.FadeInCurve;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06030566 RID: 197990 RVA: 0x006913EC File Offset: 0x0068F5EC
		public static Offset<IMp4GamepadShakeFadeInConfig> Pack(FlatBufferBuilder builder, IMp4GamepadShakeFadeInConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMp4GamepadShakeFadeInConfig>);
			}
			return IMp4GamepadShakeFadeInConfig.CreateIMp4GamepadShakeFadeInConfig(builder, _o.FadeInTime, _o.FadeInCurve, _o.NullMask);
		}

		// Token: 0x04011440 RID: 70720
		private Table __p;
	}
}
