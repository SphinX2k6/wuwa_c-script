using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072C8 RID: 29384
	public struct IMp4GamepadShakeFadeInConfig : IFlatbufferObject
	{
		// Token: 0x1700D77B RID: 55163
		// (get) Token: 0x060333AD RID: 209837 RVA: 0x006E983D File Offset: 0x006E7A3D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060333AE RID: 209838 RVA: 0x006E984A File Offset: 0x006E7A4A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060333AF RID: 209839 RVA: 0x006E9854 File Offset: 0x006E7A54
		public static IMp4GamepadShakeFadeInConfig GetRootAsIMp4GamepadShakeFadeInConfig(ByteBuffer _bb)
		{
			return IMp4GamepadShakeFadeInConfig.GetRootAsIMp4GamepadShakeFadeInConfig(_bb, default(IMp4GamepadShakeFadeInConfig));
		}

		// Token: 0x060333B0 RID: 209840 RVA: 0x006E9870 File Offset: 0x006E7A70
		public static IMp4GamepadShakeFadeInConfig GetRootAsIMp4GamepadShakeFadeInConfig(ByteBuffer _bb, IMp4GamepadShakeFadeInConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060333B1 RID: 209841 RVA: 0x006E988D File Offset: 0x006E7A8D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060333B2 RID: 209842 RVA: 0x006E989C File Offset: 0x006E7A9C
		public IMp4GamepadShakeFadeInConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D77C RID: 55164
		// (get) Token: 0x060333B3 RID: 209843 RVA: 0x006E98AC File Offset: 0x006E7AAC
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

		// Token: 0x1700D77D RID: 55165
		// (get) Token: 0x060333B4 RID: 209844 RVA: 0x006E98EC File Offset: 0x006E7AEC
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

		// Token: 0x1700D77E RID: 55166
		// (get) Token: 0x060333B5 RID: 209845 RVA: 0x006E9928 File Offset: 0x006E7B28
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

		// Token: 0x060333B6 RID: 209846 RVA: 0x006E9964 File Offset: 0x006E7B64
		public static Offset<IMp4GamepadShakeFadeInConfig> CreateIMp4GamepadShakeFadeInConfig(FlatBufferBuilder builder, float FadeInTime = 0f, EMp4GamepadShakeCurve FadeInCurve = EMp4GamepadShakeCurve.Linear, byte NullMask = 0)
		{
			builder.StartTable(3);
			IMp4GamepadShakeFadeInConfig.AddFadeInTime(builder, FadeInTime);
			IMp4GamepadShakeFadeInConfig.AddNullMask(builder, NullMask);
			IMp4GamepadShakeFadeInConfig.AddFadeInCurve(builder, FadeInCurve);
			return IMp4GamepadShakeFadeInConfig.EndIMp4GamepadShakeFadeInConfig(builder);
		}

		// Token: 0x060333B7 RID: 209847 RVA: 0x006E9988 File Offset: 0x006E7B88
		public static void StartIMp4GamepadShakeFadeInConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060333B8 RID: 209848 RVA: 0x006E9991 File Offset: 0x006E7B91
		public static void AddFadeInTime(FlatBufferBuilder builder, float fadeInTime)
		{
			builder.AddFloat(0, fadeInTime, 0.0);
		}

		// Token: 0x060333B9 RID: 209849 RVA: 0x006E99A4 File Offset: 0x006E7BA4
		public static void AddFadeInCurve(FlatBufferBuilder builder, EMp4GamepadShakeCurve fadeInCurve)
		{
			builder.AddByte(1, (byte)fadeInCurve, 0);
		}

		// Token: 0x060333BA RID: 209850 RVA: 0x006E99AF File Offset: 0x006E7BAF
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x060333BB RID: 209851 RVA: 0x006E99BA File Offset: 0x006E7BBA
		public static Offset<IMp4GamepadShakeFadeInConfig> EndIMp4GamepadShakeFadeInConfig(FlatBufferBuilder builder)
		{
			return new Offset<IMp4GamepadShakeFadeInConfig>(builder.EndTable());
		}

		// Token: 0x060333BC RID: 209852 RVA: 0x006E99C8 File Offset: 0x006E7BC8
		public IMp4GamepadShakeFadeInConfigT UnPack()
		{
			IMp4GamepadShakeFadeInConfigT mp4GamepadShakeFadeInConfigT = new IMp4GamepadShakeFadeInConfigT();
			this.UnPackTo(mp4GamepadShakeFadeInConfigT);
			return mp4GamepadShakeFadeInConfigT;
		}

		// Token: 0x060333BD RID: 209853 RVA: 0x006E99E3 File Offset: 0x006E7BE3
		public void UnPackTo(IMp4GamepadShakeFadeInConfigT _o)
		{
			_o.FadeInTime = this.FadeInTime;
			_o.FadeInCurve = this.FadeInCurve;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060333BE RID: 209854 RVA: 0x006E9A0C File Offset: 0x006E7C0C
		public static Offset<IMp4GamepadShakeFadeInConfig> Pack(FlatBufferBuilder builder, IMp4GamepadShakeFadeInConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMp4GamepadShakeFadeInConfig>);
			}
			return IMp4GamepadShakeFadeInConfig.CreateIMp4GamepadShakeFadeInConfig(builder, _o.FadeInTime, _o.FadeInCurve, _o.NullMask);
		}

		// Token: 0x04012369 RID: 74601
		private Table __p;
	}
}
