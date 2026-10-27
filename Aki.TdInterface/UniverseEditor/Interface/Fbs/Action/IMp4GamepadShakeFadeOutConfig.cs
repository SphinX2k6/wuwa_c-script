using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B85 RID: 27525
	public struct IMp4GamepadShakeFadeOutConfig : IFlatbufferObject
	{
		// Token: 0x1700CC9D RID: 52381
		// (get) Token: 0x0603056F RID: 197999 RVA: 0x006914C0 File Offset: 0x0068F6C0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030570 RID: 198000 RVA: 0x006914CD File Offset: 0x0068F6CD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030571 RID: 198001 RVA: 0x006914D4 File Offset: 0x0068F6D4
		public static IMp4GamepadShakeFadeOutConfig GetRootAsIMp4GamepadShakeFadeOutConfig(ByteBuffer _bb)
		{
			return IMp4GamepadShakeFadeOutConfig.GetRootAsIMp4GamepadShakeFadeOutConfig(_bb, default(IMp4GamepadShakeFadeOutConfig));
		}

		// Token: 0x06030572 RID: 198002 RVA: 0x006914F0 File Offset: 0x0068F6F0
		public static IMp4GamepadShakeFadeOutConfig GetRootAsIMp4GamepadShakeFadeOutConfig(ByteBuffer _bb, IMp4GamepadShakeFadeOutConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030573 RID: 198003 RVA: 0x0069150D File Offset: 0x0068F70D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030574 RID: 198004 RVA: 0x0069151C File Offset: 0x0068F71C
		public IMp4GamepadShakeFadeOutConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CC9E RID: 52382
		// (get) Token: 0x06030575 RID: 198005 RVA: 0x0069152C File Offset: 0x0068F72C
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

		// Token: 0x1700CC9F RID: 52383
		// (get) Token: 0x06030576 RID: 198006 RVA: 0x0069156C File Offset: 0x0068F76C
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

		// Token: 0x1700CCA0 RID: 52384
		// (get) Token: 0x06030577 RID: 198007 RVA: 0x006915A8 File Offset: 0x0068F7A8
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

		// Token: 0x06030578 RID: 198008 RVA: 0x006915E4 File Offset: 0x0068F7E4
		public static Offset<IMp4GamepadShakeFadeOutConfig> CreateIMp4GamepadShakeFadeOutConfig(FlatBufferBuilder builder, float FadeOutTime = 0f, EMp4GamepadShakeCurve FadeOutCurve = EMp4GamepadShakeCurve.Linear, byte NullMask = 0)
		{
			builder.StartTable(3);
			IMp4GamepadShakeFadeOutConfig.AddFadeOutTime(builder, FadeOutTime);
			IMp4GamepadShakeFadeOutConfig.AddNullMask(builder, NullMask);
			IMp4GamepadShakeFadeOutConfig.AddFadeOutCurve(builder, FadeOutCurve);
			return IMp4GamepadShakeFadeOutConfig.EndIMp4GamepadShakeFadeOutConfig(builder);
		}

		// Token: 0x06030579 RID: 198009 RVA: 0x00691608 File Offset: 0x0068F808
		public static void StartIMp4GamepadShakeFadeOutConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0603057A RID: 198010 RVA: 0x00691611 File Offset: 0x0068F811
		public static void AddFadeOutTime(FlatBufferBuilder builder, float fadeOutTime)
		{
			builder.AddFloat(0, fadeOutTime, 0.0);
		}

		// Token: 0x0603057B RID: 198011 RVA: 0x00691624 File Offset: 0x0068F824
		public static void AddFadeOutCurve(FlatBufferBuilder builder, EMp4GamepadShakeCurve fadeOutCurve)
		{
			builder.AddByte(1, (byte)fadeOutCurve, 0);
		}

		// Token: 0x0603057C RID: 198012 RVA: 0x0069162F File Offset: 0x0068F82F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0603057D RID: 198013 RVA: 0x0069163A File Offset: 0x0068F83A
		public static Offset<IMp4GamepadShakeFadeOutConfig> EndIMp4GamepadShakeFadeOutConfig(FlatBufferBuilder builder)
		{
			return new Offset<IMp4GamepadShakeFadeOutConfig>(builder.EndTable());
		}

		// Token: 0x0603057E RID: 198014 RVA: 0x00691648 File Offset: 0x0068F848
		public IMp4GamepadShakeFadeOutConfigT UnPack()
		{
			IMp4GamepadShakeFadeOutConfigT mp4GamepadShakeFadeOutConfigT = new IMp4GamepadShakeFadeOutConfigT();
			this.UnPackTo(mp4GamepadShakeFadeOutConfigT);
			return mp4GamepadShakeFadeOutConfigT;
		}

		// Token: 0x0603057F RID: 198015 RVA: 0x00691663 File Offset: 0x0068F863
		public void UnPackTo(IMp4GamepadShakeFadeOutConfigT _o)
		{
			_o.FadeOutTime = this.FadeOutTime;
			_o.FadeOutCurve = this.FadeOutCurve;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06030580 RID: 198016 RVA: 0x0069168C File Offset: 0x0068F88C
		public static Offset<IMp4GamepadShakeFadeOutConfig> Pack(FlatBufferBuilder builder, IMp4GamepadShakeFadeOutConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMp4GamepadShakeFadeOutConfig>);
			}
			return IMp4GamepadShakeFadeOutConfig.CreateIMp4GamepadShakeFadeOutConfig(builder, _o.FadeOutTime, _o.FadeOutCurve, _o.NullMask);
		}

		// Token: 0x04011444 RID: 70724
		private Table __p;
	}
}
