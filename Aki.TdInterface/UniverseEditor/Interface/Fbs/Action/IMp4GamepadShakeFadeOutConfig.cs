using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072CB RID: 29387
	public struct IMp4GamepadShakeFadeOutConfig : IFlatbufferObject
	{
		// Token: 0x1700D782 RID: 55170
		// (get) Token: 0x060333C7 RID: 209863 RVA: 0x006E9AE0 File Offset: 0x006E7CE0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060333C8 RID: 209864 RVA: 0x006E9AED File Offset: 0x006E7CED
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060333C9 RID: 209865 RVA: 0x006E9AF4 File Offset: 0x006E7CF4
		public static IMp4GamepadShakeFadeOutConfig GetRootAsIMp4GamepadShakeFadeOutConfig(ByteBuffer _bb)
		{
			return IMp4GamepadShakeFadeOutConfig.GetRootAsIMp4GamepadShakeFadeOutConfig(_bb, default(IMp4GamepadShakeFadeOutConfig));
		}

		// Token: 0x060333CA RID: 209866 RVA: 0x006E9B10 File Offset: 0x006E7D10
		public static IMp4GamepadShakeFadeOutConfig GetRootAsIMp4GamepadShakeFadeOutConfig(ByteBuffer _bb, IMp4GamepadShakeFadeOutConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060333CB RID: 209867 RVA: 0x006E9B2D File Offset: 0x006E7D2D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060333CC RID: 209868 RVA: 0x006E9B3C File Offset: 0x006E7D3C
		public IMp4GamepadShakeFadeOutConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D783 RID: 55171
		// (get) Token: 0x060333CD RID: 209869 RVA: 0x006E9B4C File Offset: 0x006E7D4C
		public float FadeOutTime
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

		// Token: 0x1700D784 RID: 55172
		// (get) Token: 0x060333CE RID: 209870 RVA: 0x006E9B8C File Offset: 0x006E7D8C
		public EMp4GamepadShakeCurve FadeOutCurve
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

		// Token: 0x1700D785 RID: 55173
		// (get) Token: 0x060333CF RID: 209871 RVA: 0x006E9BC8 File Offset: 0x006E7DC8
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

		// Token: 0x060333D0 RID: 209872 RVA: 0x006E9C04 File Offset: 0x006E7E04
		public static Offset<IMp4GamepadShakeFadeOutConfig> CreateIMp4GamepadShakeFadeOutConfig(FlatBufferBuilder builder, float FadeOutTime = 0f, EMp4GamepadShakeCurve FadeOutCurve = EMp4GamepadShakeCurve.Linear, byte NullMask = 0)
		{
			builder.StartTable(3);
			IMp4GamepadShakeFadeOutConfig.AddFadeOutTime(builder, FadeOutTime);
			IMp4GamepadShakeFadeOutConfig.AddNullMask(builder, NullMask);
			IMp4GamepadShakeFadeOutConfig.AddFadeOutCurve(builder, FadeOutCurve);
			return IMp4GamepadShakeFadeOutConfig.EndIMp4GamepadShakeFadeOutConfig(builder);
		}

		// Token: 0x060333D1 RID: 209873 RVA: 0x006E9C28 File Offset: 0x006E7E28
		public static void StartIMp4GamepadShakeFadeOutConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060333D2 RID: 209874 RVA: 0x006E9C31 File Offset: 0x006E7E31
		public static void AddFadeOutTime(FlatBufferBuilder builder, float fadeOutTime)
		{
			builder.AddFloat(0, fadeOutTime, 0.0);
		}

		// Token: 0x060333D3 RID: 209875 RVA: 0x006E9C44 File Offset: 0x006E7E44
		public static void AddFadeOutCurve(FlatBufferBuilder builder, EMp4GamepadShakeCurve fadeOutCurve)
		{
			builder.AddByte(1, (byte)fadeOutCurve, 0);
		}

		// Token: 0x060333D4 RID: 209876 RVA: 0x006E9C4F File Offset: 0x006E7E4F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x060333D5 RID: 209877 RVA: 0x006E9C5A File Offset: 0x006E7E5A
		public static Offset<IMp4GamepadShakeFadeOutConfig> EndIMp4GamepadShakeFadeOutConfig(FlatBufferBuilder builder)
		{
			return new Offset<IMp4GamepadShakeFadeOutConfig>(builder.EndTable());
		}

		// Token: 0x060333D6 RID: 209878 RVA: 0x006E9C68 File Offset: 0x006E7E68
		public IMp4GamepadShakeFadeOutConfigT UnPack()
		{
			IMp4GamepadShakeFadeOutConfigT mp4GamepadShakeFadeOutConfigT = new IMp4GamepadShakeFadeOutConfigT();
			this.UnPackTo(mp4GamepadShakeFadeOutConfigT);
			return mp4GamepadShakeFadeOutConfigT;
		}

		// Token: 0x060333D7 RID: 209879 RVA: 0x006E9C83 File Offset: 0x006E7E83
		public void UnPackTo(IMp4GamepadShakeFadeOutConfigT _o)
		{
			_o.FadeOutTime = this.FadeOutTime;
			_o.FadeOutCurve = this.FadeOutCurve;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060333D8 RID: 209880 RVA: 0x006E9CAC File Offset: 0x006E7EAC
		public static Offset<IMp4GamepadShakeFadeOutConfig> Pack(FlatBufferBuilder builder, IMp4GamepadShakeFadeOutConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMp4GamepadShakeFadeOutConfig>);
			}
			return IMp4GamepadShakeFadeOutConfig.CreateIMp4GamepadShakeFadeOutConfig(builder, _o.FadeOutTime, _o.FadeOutCurve, _o.NullMask);
		}

		// Token: 0x0401236D RID: 74605
		private Table __p;
	}
}
