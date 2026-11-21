using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B9F RID: 31647
	public struct ITeleportTransitionWithFadeInScreen : IFlatbufferObject
	{
		// Token: 0x1700ECF9 RID: 60665
		// (get) Token: 0x0603902F RID: 233519 RVA: 0x007B4805 File Offset: 0x007B2A05
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039030 RID: 233520 RVA: 0x007B4812 File Offset: 0x007B2A12
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039031 RID: 233521 RVA: 0x007B481C File Offset: 0x007B2A1C
		public static ITeleportTransitionWithFadeInScreen GetRootAsITeleportTransitionWithFadeInScreen(ByteBuffer _bb)
		{
			return ITeleportTransitionWithFadeInScreen.GetRootAsITeleportTransitionWithFadeInScreen(_bb, default(ITeleportTransitionWithFadeInScreen));
		}

		// Token: 0x06039032 RID: 233522 RVA: 0x007B4838 File Offset: 0x007B2A38
		public static ITeleportTransitionWithFadeInScreen GetRootAsITeleportTransitionWithFadeInScreen(ByteBuffer _bb, ITeleportTransitionWithFadeInScreen obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06039033 RID: 233523 RVA: 0x007B4855 File Offset: 0x007B2A55
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06039034 RID: 233524 RVA: 0x007B4864 File Offset: 0x007B2A64
		public ITeleportTransitionWithFadeInScreen __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ECFA RID: 60666
		// (get) Token: 0x06039035 RID: 233525 RVA: 0x007B4874 File Offset: 0x007B2A74
		public ETeleportTransitionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETeleportTransitionType.PlayMp4;
				}
				return (ETeleportTransitionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700ECFB RID: 60667
		// (get) Token: 0x06039036 RID: 233526 RVA: 0x007B48B0 File Offset: 0x007B2AB0
		public EFadeInScreenShowType ScreenType
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

		// Token: 0x1700ECFC RID: 60668
		// (get) Token: 0x06039037 RID: 233527 RVA: 0x007B48EC File Offset: 0x007B2AEC
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

		// Token: 0x06039038 RID: 233528 RVA: 0x007B4928 File Offset: 0x007B2B28
		public static Offset<ITeleportTransitionWithFadeInScreen> CreateITeleportTransitionWithFadeInScreen(FlatBufferBuilder builder, ETeleportTransitionType Type = ETeleportTransitionType.PlayMp4, EFadeInScreenShowType ScreenType = EFadeInScreenShowType.White, byte NullMask = 0)
		{
			builder.StartTable(3);
			ITeleportTransitionWithFadeInScreen.AddNullMask(builder, NullMask);
			ITeleportTransitionWithFadeInScreen.AddScreenType(builder, ScreenType);
			ITeleportTransitionWithFadeInScreen.AddType(builder, Type);
			return ITeleportTransitionWithFadeInScreen.EndITeleportTransitionWithFadeInScreen(builder);
		}

		// Token: 0x06039039 RID: 233529 RVA: 0x007B494C File Offset: 0x007B2B4C
		public static void StartITeleportTransitionWithFadeInScreen(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0603903A RID: 233530 RVA: 0x007B4955 File Offset: 0x007B2B55
		public static void AddType(FlatBufferBuilder builder, ETeleportTransitionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603903B RID: 233531 RVA: 0x007B4960 File Offset: 0x007B2B60
		public static void AddScreenType(FlatBufferBuilder builder, EFadeInScreenShowType screenType)
		{
			builder.AddByte(1, (byte)screenType, 0);
		}

		// Token: 0x0603903C RID: 233532 RVA: 0x007B496B File Offset: 0x007B2B6B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0603903D RID: 233533 RVA: 0x007B4976 File Offset: 0x007B2B76
		public static Offset<ITeleportTransitionWithFadeInScreen> EndITeleportTransitionWithFadeInScreen(FlatBufferBuilder builder)
		{
			return new Offset<ITeleportTransitionWithFadeInScreen>(builder.EndTable());
		}

		// Token: 0x0603903E RID: 233534 RVA: 0x007B4984 File Offset: 0x007B2B84
		public ITeleportTransitionWithFadeInScreenT UnPack()
		{
			ITeleportTransitionWithFadeInScreenT teleportTransitionWithFadeInScreenT = new ITeleportTransitionWithFadeInScreenT();
			this.UnPackTo(teleportTransitionWithFadeInScreenT);
			return teleportTransitionWithFadeInScreenT;
		}

		// Token: 0x0603903F RID: 233535 RVA: 0x007B499F File Offset: 0x007B2B9F
		public void UnPackTo(ITeleportTransitionWithFadeInScreenT _o)
		{
			_o.Type = this.Type;
			_o.ScreenType = this.ScreenType;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06039040 RID: 233536 RVA: 0x007B49C8 File Offset: 0x007B2BC8
		public static Offset<ITeleportTransitionWithFadeInScreen> Pack(FlatBufferBuilder builder, ITeleportTransitionWithFadeInScreenT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITeleportTransitionWithFadeInScreen>);
			}
			return ITeleportTransitionWithFadeInScreen.CreateITeleportTransitionWithFadeInScreen(builder, _o.Type, _o.ScreenType, _o.NullMask);
		}

		// Token: 0x0401320B RID: 78347
		private Table __p;
	}
}
