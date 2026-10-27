using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004292 RID: 17042
	public struct IWarningPreformFadeInScreen : IFlatbufferObject
	{
		// Token: 0x17007905 RID: 30981
		// (get) Token: 0x06019403 RID: 103427 RVA: 0x003A09E3 File Offset: 0x0039EBE3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019404 RID: 103428 RVA: 0x003A09F0 File Offset: 0x0039EBF0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019405 RID: 103429 RVA: 0x003A09F8 File Offset: 0x0039EBF8
		public static IWarningPreformFadeInScreen GetRootAsIWarningPreformFadeInScreen(ByteBuffer _bb)
		{
			return IWarningPreformFadeInScreen.GetRootAsIWarningPreformFadeInScreen(_bb, default(IWarningPreformFadeInScreen));
		}

		// Token: 0x06019406 RID: 103430 RVA: 0x003A0A14 File Offset: 0x0039EC14
		public static IWarningPreformFadeInScreen GetRootAsIWarningPreformFadeInScreen(ByteBuffer _bb, IWarningPreformFadeInScreen obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019407 RID: 103431 RVA: 0x003A0A31 File Offset: 0x0039EC31
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019408 RID: 103432 RVA: 0x003A0A40 File Offset: 0x0039EC40
		public IWarningPreformFadeInScreen __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007906 RID: 30982
		// (get) Token: 0x06019409 RID: 103433 RVA: 0x003A0A50 File Offset: 0x0039EC50
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

		// Token: 0x0601940A RID: 103434 RVA: 0x003A0A8C File Offset: 0x0039EC8C
		public static Offset<IWarningPreformFadeInScreen> CreateIWarningPreformFadeInScreen(FlatBufferBuilder builder, EWarningPreformType Type = EWarningPreformType.FadeInScreen)
		{
			builder.StartTable(1);
			IWarningPreformFadeInScreen.AddType(builder, Type);
			return IWarningPreformFadeInScreen.EndIWarningPreformFadeInScreen(builder);
		}

		// Token: 0x0601940B RID: 103435 RVA: 0x003A0AA2 File Offset: 0x0039ECA2
		public static void StartIWarningPreformFadeInScreen(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601940C RID: 103436 RVA: 0x003A0AAB File Offset: 0x0039ECAB
		public static void AddType(FlatBufferBuilder builder, EWarningPreformType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601940D RID: 103437 RVA: 0x003A0AB6 File Offset: 0x0039ECB6
		public static Offset<IWarningPreformFadeInScreen> EndIWarningPreformFadeInScreen(FlatBufferBuilder builder)
		{
			return new Offset<IWarningPreformFadeInScreen>(builder.EndTable());
		}

		// Token: 0x0601940E RID: 103438 RVA: 0x003A0AC4 File Offset: 0x0039ECC4
		public IWarningPreformFadeInScreenT UnPack()
		{
			IWarningPreformFadeInScreenT warningPreformFadeInScreenT = new IWarningPreformFadeInScreenT();
			this.UnPackTo(warningPreformFadeInScreenT);
			return warningPreformFadeInScreenT;
		}

		// Token: 0x0601940F RID: 103439 RVA: 0x003A0ADF File Offset: 0x0039ECDF
		public void UnPackTo(IWarningPreformFadeInScreenT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06019410 RID: 103440 RVA: 0x003A0AF0 File Offset: 0x0039ECF0
		public static Offset<IWarningPreformFadeInScreen> Pack(FlatBufferBuilder builder, IWarningPreformFadeInScreenT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWarningPreformFadeInScreen>);
			}
			return IWarningPreformFadeInScreen.CreateIWarningPreformFadeInScreen(builder, _o.Type);
		}

		// Token: 0x0400BF32 RID: 48946
		private Table __p;
	}
}
