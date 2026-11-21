using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020046EE RID: 18158
	public struct IWarningPreformFadeInScreen : IFlatbufferObject
	{
		// Token: 0x17007F36 RID: 32566
		// (get) Token: 0x0601AB6F RID: 109423 RVA: 0x003CC0BB File Offset: 0x003CA2BB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601AB70 RID: 109424 RVA: 0x003CC0C8 File Offset: 0x003CA2C8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601AB71 RID: 109425 RVA: 0x003CC0D0 File Offset: 0x003CA2D0
		public static IWarningPreformFadeInScreen GetRootAsIWarningPreformFadeInScreen(ByteBuffer _bb)
		{
			return IWarningPreformFadeInScreen.GetRootAsIWarningPreformFadeInScreen(_bb, default(IWarningPreformFadeInScreen));
		}

		// Token: 0x0601AB72 RID: 109426 RVA: 0x003CC0EC File Offset: 0x003CA2EC
		public static IWarningPreformFadeInScreen GetRootAsIWarningPreformFadeInScreen(ByteBuffer _bb, IWarningPreformFadeInScreen obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601AB73 RID: 109427 RVA: 0x003CC109 File Offset: 0x003CA309
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601AB74 RID: 109428 RVA: 0x003CC118 File Offset: 0x003CA318
		public IWarningPreformFadeInScreen __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007F37 RID: 32567
		// (get) Token: 0x0601AB75 RID: 109429 RVA: 0x003CC128 File Offset: 0x003CA328
		public EWarningPreformType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EWarningPreformType.FadeInScreen;
				}
				return (EWarningPreformType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601AB76 RID: 109430 RVA: 0x003CC164 File Offset: 0x003CA364
		public static Offset<IWarningPreformFadeInScreen> CreateIWarningPreformFadeInScreen(FlatBufferBuilder builder, EWarningPreformType Type = EWarningPreformType.FadeInScreen)
		{
			builder.StartTable(1);
			IWarningPreformFadeInScreen.AddType(builder, Type);
			return IWarningPreformFadeInScreen.EndIWarningPreformFadeInScreen(builder);
		}

		// Token: 0x0601AB77 RID: 109431 RVA: 0x003CC17A File Offset: 0x003CA37A
		public static void StartIWarningPreformFadeInScreen(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601AB78 RID: 109432 RVA: 0x003CC183 File Offset: 0x003CA383
		public static void AddType(FlatBufferBuilder builder, EWarningPreformType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601AB79 RID: 109433 RVA: 0x003CC18E File Offset: 0x003CA38E
		public static Offset<IWarningPreformFadeInScreen> EndIWarningPreformFadeInScreen(FlatBufferBuilder builder)
		{
			return new Offset<IWarningPreformFadeInScreen>(builder.EndTable());
		}

		// Token: 0x0601AB7A RID: 109434 RVA: 0x003CC19C File Offset: 0x003CA39C
		public IWarningPreformFadeInScreenT UnPack()
		{
			IWarningPreformFadeInScreenT warningPreformFadeInScreenT = new IWarningPreformFadeInScreenT();
			this.UnPackTo(warningPreformFadeInScreenT);
			return warningPreformFadeInScreenT;
		}

		// Token: 0x0601AB7B RID: 109435 RVA: 0x003CC1B7 File Offset: 0x003CA3B7
		public void UnPackTo(IWarningPreformFadeInScreenT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601AB7C RID: 109436 RVA: 0x003CC1C8 File Offset: 0x003CA3C8
		public static Offset<IWarningPreformFadeInScreen> Pack(FlatBufferBuilder builder, IWarningPreformFadeInScreenT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWarningPreformFadeInScreen>);
			}
			return IWarningPreformFadeInScreen.CreateIWarningPreformFadeInScreen(builder, _o.Type);
		}

		// Token: 0x0400C93F RID: 51519
		private Table __p;
	}
}
