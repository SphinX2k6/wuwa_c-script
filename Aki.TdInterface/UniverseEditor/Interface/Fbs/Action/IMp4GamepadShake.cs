using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072C5 RID: 29381
	public struct IMp4GamepadShake : IFlatbufferObject
	{
		// Token: 0x1700D770 RID: 55152
		// (get) Token: 0x0603338B RID: 209803 RVA: 0x006E937C File Offset: 0x006E757C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603338C RID: 209804 RVA: 0x006E9389 File Offset: 0x006E7589
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603338D RID: 209805 RVA: 0x006E9390 File Offset: 0x006E7590
		public static IMp4GamepadShake GetRootAsIMp4GamepadShake(ByteBuffer _bb)
		{
			return IMp4GamepadShake.GetRootAsIMp4GamepadShake(_bb, default(IMp4GamepadShake));
		}

		// Token: 0x0603338E RID: 209806 RVA: 0x006E93AC File Offset: 0x006E75AC
		public static IMp4GamepadShake GetRootAsIMp4GamepadShake(ByteBuffer _bb, IMp4GamepadShake obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603338F RID: 209807 RVA: 0x006E93C9 File Offset: 0x006E75C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033390 RID: 209808 RVA: 0x006E93D8 File Offset: 0x006E75D8
		public IMp4GamepadShake __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D771 RID: 55153
		// (get) Token: 0x06033391 RID: 209809 RVA: 0x006E93E8 File Offset: 0x006E75E8
		public EGamepadShakeType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGamepadShakeType.Onetime;
				}
				return (EGamepadShakeType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D772 RID: 55154
		// (get) Token: 0x06033392 RID: 209810 RVA: 0x006E9424 File Offset: 0x006E7624
		public IMp4GamepadShakeFadeInConfig? FadeInConfig
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IMp4GamepadShakeFadeInConfig?(default(IMp4GamepadShakeFadeInConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700D773 RID: 55155
		// (get) Token: 0x06033393 RID: 209811 RVA: 0x006E9484 File Offset: 0x006E7684
		public IMp4GamepadShakeFadeOutConfig? FadeOutConfig
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IMp4GamepadShakeFadeOutConfig?(default(IMp4GamepadShakeFadeOutConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700D774 RID: 55156
		// (get) Token: 0x06033394 RID: 209812 RVA: 0x006E94E4 File Offset: 0x006E76E4
		public float ShakeScale
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

		// Token: 0x1700D775 RID: 55157
		// (get) Token: 0x06033395 RID: 209813 RVA: 0x006E9528 File Offset: 0x006E7728
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

		// Token: 0x06033396 RID: 209814 RVA: 0x006E9565 File Offset: 0x006E7765
		public static Offset<IMp4GamepadShake> CreateIMp4GamepadShake(FlatBufferBuilder builder, EGamepadShakeType Type = EGamepadShakeType.Onetime, Offset<IMp4GamepadShakeFadeInConfig> FadeInConfigOffset = default(Offset<IMp4GamepadShakeFadeInConfig>), Offset<IMp4GamepadShakeFadeOutConfig> FadeOutConfigOffset = default(Offset<IMp4GamepadShakeFadeOutConfig>), float ShakeScale = 0f, byte NullMask = 0)
		{
			builder.StartTable(5);
			IMp4GamepadShake.AddShakeScale(builder, ShakeScale);
			IMp4GamepadShake.AddFadeOutConfig(builder, FadeOutConfigOffset);
			IMp4GamepadShake.AddFadeInConfig(builder, FadeInConfigOffset);
			IMp4GamepadShake.AddNullMask(builder, NullMask);
			IMp4GamepadShake.AddType(builder, Type);
			return IMp4GamepadShake.EndIMp4GamepadShake(builder);
		}

		// Token: 0x06033397 RID: 209815 RVA: 0x006E9599 File Offset: 0x006E7799
		public static void StartIMp4GamepadShake(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06033398 RID: 209816 RVA: 0x006E95A2 File Offset: 0x006E77A2
		public static void AddType(FlatBufferBuilder builder, EGamepadShakeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033399 RID: 209817 RVA: 0x006E95AD File Offset: 0x006E77AD
		public static void AddFadeInConfig(FlatBufferBuilder builder, Offset<IMp4GamepadShakeFadeInConfig> fadeInConfigOffset)
		{
			builder.AddOffset(1, fadeInConfigOffset.Value, 0);
		}

		// Token: 0x0603339A RID: 209818 RVA: 0x006E95BD File Offset: 0x006E77BD
		public static void AddFadeOutConfig(FlatBufferBuilder builder, Offset<IMp4GamepadShakeFadeOutConfig> fadeOutConfigOffset)
		{
			builder.AddOffset(2, fadeOutConfigOffset.Value, 0);
		}

		// Token: 0x0603339B RID: 209819 RVA: 0x006E95CD File Offset: 0x006E77CD
		public static void AddShakeScale(FlatBufferBuilder builder, float shakeScale)
		{
			builder.AddFloat(3, shakeScale, 0.0);
		}

		// Token: 0x0603339C RID: 209820 RVA: 0x006E95E0 File Offset: 0x006E77E0
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0603339D RID: 209821 RVA: 0x006E95EB File Offset: 0x006E77EB
		public static Offset<IMp4GamepadShake> EndIMp4GamepadShake(FlatBufferBuilder builder)
		{
			return new Offset<IMp4GamepadShake>(builder.EndTable());
		}

		// Token: 0x0603339E RID: 209822 RVA: 0x006E95F8 File Offset: 0x006E77F8
		public IMp4GamepadShakeT UnPack()
		{
			IMp4GamepadShakeT mp4GamepadShakeT = new IMp4GamepadShakeT();
			this.UnPackTo(mp4GamepadShakeT);
			return mp4GamepadShakeT;
		}

		// Token: 0x0603339F RID: 209823 RVA: 0x006E9614 File Offset: 0x006E7814
		public void UnPackTo(IMp4GamepadShakeT _o)
		{
			_o.Type = this.Type;
			_o.FadeInConfig = ((this.FadeInConfig != null) ? this.FadeInConfig.Value.UnPack() : null);
			_o.FadeOutConfig = ((this.FadeOutConfig != null) ? this.FadeOutConfig.Value.UnPack() : null);
			_o.ShakeScale = this.ShakeScale;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060333A0 RID: 209824 RVA: 0x006E96A4 File Offset: 0x006E78A4
		public static Offset<IMp4GamepadShake> Pack(FlatBufferBuilder builder, IMp4GamepadShakeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMp4GamepadShake>);
			}
			Offset<IMp4GamepadShakeFadeInConfig> fadeInConfigOffset = (_o.FadeInConfig == null) ? default(Offset<IMp4GamepadShakeFadeInConfig>) : IMp4GamepadShakeFadeInConfig.Pack(builder, _o.FadeInConfig);
			Offset<IMp4GamepadShakeFadeOutConfig> fadeOutConfigOffset = (_o.FadeOutConfig == null) ? default(Offset<IMp4GamepadShakeFadeOutConfig>) : IMp4GamepadShakeFadeOutConfig.Pack(builder, _o.FadeOutConfig);
			return IMp4GamepadShake.CreateIMp4GamepadShake(builder, _o.Type, fadeInConfigOffset, fadeOutConfigOffset, _o.ShakeScale, _o.NullMask);
		}

		// Token: 0x04012363 RID: 74595
		private Table __p;
	}
}
