using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073B8 RID: 29624
	public struct ITeleportTransitionWithFadeInScreen : IFlatbufferObject
	{
		// Token: 0x1700E0E9 RID: 57577
		// (get) Token: 0x06035C94 RID: 220308 RVA: 0x007522C5 File Offset: 0x007504C5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035C95 RID: 220309 RVA: 0x007522D2 File Offset: 0x007504D2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035C96 RID: 220310 RVA: 0x007522DC File Offset: 0x007504DC
		public static ITeleportTransitionWithFadeInScreen GetRootAsITeleportTransitionWithFadeInScreen(ByteBuffer _bb)
		{
			return ITeleportTransitionWithFadeInScreen.GetRootAsITeleportTransitionWithFadeInScreen(_bb, default(ITeleportTransitionWithFadeInScreen));
		}

		// Token: 0x06035C97 RID: 220311 RVA: 0x007522F8 File Offset: 0x007504F8
		public static ITeleportTransitionWithFadeInScreen GetRootAsITeleportTransitionWithFadeInScreen(ByteBuffer _bb, ITeleportTransitionWithFadeInScreen obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035C98 RID: 220312 RVA: 0x00752315 File Offset: 0x00750515
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035C99 RID: 220313 RVA: 0x00752324 File Offset: 0x00750524
		public ITeleportTransitionWithFadeInScreen __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E0EA RID: 57578
		// (get) Token: 0x06035C9A RID: 220314 RVA: 0x00752334 File Offset: 0x00750534
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

		// Token: 0x1700E0EB RID: 57579
		// (get) Token: 0x06035C9B RID: 220315 RVA: 0x00752370 File Offset: 0x00750570
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

		// Token: 0x1700E0EC RID: 57580
		// (get) Token: 0x06035C9C RID: 220316 RVA: 0x007523AC File Offset: 0x007505AC
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

		// Token: 0x06035C9D RID: 220317 RVA: 0x007523E8 File Offset: 0x007505E8
		public static Offset<ITeleportTransitionWithFadeInScreen> CreateITeleportTransitionWithFadeInScreen(FlatBufferBuilder builder, ETeleportTransitionType Type = ETeleportTransitionType.PlayMp4, EFadeInScreenShowType ScreenType = EFadeInScreenShowType.White, byte NullMask = 0)
		{
			builder.StartTable(3);
			ITeleportTransitionWithFadeInScreen.AddNullMask(builder, NullMask);
			ITeleportTransitionWithFadeInScreen.AddScreenType(builder, ScreenType);
			ITeleportTransitionWithFadeInScreen.AddType(builder, Type);
			return ITeleportTransitionWithFadeInScreen.EndITeleportTransitionWithFadeInScreen(builder);
		}

		// Token: 0x06035C9E RID: 220318 RVA: 0x0075240C File Offset: 0x0075060C
		public static void StartITeleportTransitionWithFadeInScreen(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06035C9F RID: 220319 RVA: 0x00752415 File Offset: 0x00750615
		public static void AddType(FlatBufferBuilder builder, ETeleportTransitionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035CA0 RID: 220320 RVA: 0x00752420 File Offset: 0x00750620
		public static void AddScreenType(FlatBufferBuilder builder, EFadeInScreenShowType screenType)
		{
			builder.AddByte(1, (byte)screenType, 0);
		}

		// Token: 0x06035CA1 RID: 220321 RVA: 0x0075242B File Offset: 0x0075062B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06035CA2 RID: 220322 RVA: 0x00752436 File Offset: 0x00750636
		public static Offset<ITeleportTransitionWithFadeInScreen> EndITeleportTransitionWithFadeInScreen(FlatBufferBuilder builder)
		{
			return new Offset<ITeleportTransitionWithFadeInScreen>(builder.EndTable());
		}

		// Token: 0x06035CA3 RID: 220323 RVA: 0x00752444 File Offset: 0x00750644
		public ITeleportTransitionWithFadeInScreenT UnPack()
		{
			ITeleportTransitionWithFadeInScreenT teleportTransitionWithFadeInScreenT = new ITeleportTransitionWithFadeInScreenT();
			this.UnPackTo(teleportTransitionWithFadeInScreenT);
			return teleportTransitionWithFadeInScreenT;
		}

		// Token: 0x06035CA4 RID: 220324 RVA: 0x0075245F File Offset: 0x0075065F
		public void UnPackTo(ITeleportTransitionWithFadeInScreenT _o)
		{
			_o.Type = this.Type;
			_o.ScreenType = this.ScreenType;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06035CA5 RID: 220325 RVA: 0x00752488 File Offset: 0x00750688
		public static Offset<ITeleportTransitionWithFadeInScreen> Pack(FlatBufferBuilder builder, ITeleportTransitionWithFadeInScreenT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITeleportTransitionWithFadeInScreen>);
			}
			return ITeleportTransitionWithFadeInScreen.CreateITeleportTransitionWithFadeInScreen(builder, _o.Type, _o.ScreenType, _o.NullMask);
		}

		// Token: 0x040121F2 RID: 74226
		private Table __p;
	}
}
