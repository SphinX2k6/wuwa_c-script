using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200718A RID: 29066
	public struct IMainScreen : IFlatbufferObject
	{
		// Token: 0x1700D4C6 RID: 54470
		// (get) Token: 0x06032878 RID: 206968 RVA: 0x006D4299 File Offset: 0x006D2499
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032879 RID: 206969 RVA: 0x006D42A6 File Offset: 0x006D24A6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603287A RID: 206970 RVA: 0x006D42B0 File Offset: 0x006D24B0
		public static IMainScreen GetRootAsIMainScreen(ByteBuffer _bb)
		{
			return IMainScreen.GetRootAsIMainScreen(_bb, default(IMainScreen));
		}

		// Token: 0x0603287B RID: 206971 RVA: 0x006D42CC File Offset: 0x006D24CC
		public static IMainScreen GetRootAsIMainScreen(ByteBuffer _bb, IMainScreen obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603287C RID: 206972 RVA: 0x006D42E9 File Offset: 0x006D24E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603287D RID: 206973 RVA: 0x006D42F8 File Offset: 0x006D24F8
		public IMainScreen __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D4C7 RID: 54471
		// (get) Token: 0x0603287E RID: 206974 RVA: 0x006D4308 File Offset: 0x006D2508
		public EScreenType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EScreenType.Main;
				}
				return (EScreenType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603287F RID: 206975 RVA: 0x006D4344 File Offset: 0x006D2544
		public static Offset<IMainScreen> CreateIMainScreen(FlatBufferBuilder builder, EScreenType Type = EScreenType.Main)
		{
			builder.StartTable(1);
			IMainScreen.AddType(builder, Type);
			return IMainScreen.EndIMainScreen(builder);
		}

		// Token: 0x06032880 RID: 206976 RVA: 0x006D435A File Offset: 0x006D255A
		public static void StartIMainScreen(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06032881 RID: 206977 RVA: 0x006D4363 File Offset: 0x006D2563
		public static void AddType(FlatBufferBuilder builder, EScreenType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032882 RID: 206978 RVA: 0x006D436E File Offset: 0x006D256E
		public static Offset<IMainScreen> EndIMainScreen(FlatBufferBuilder builder)
		{
			return new Offset<IMainScreen>(builder.EndTable());
		}

		// Token: 0x06032883 RID: 206979 RVA: 0x006D437C File Offset: 0x006D257C
		public IMainScreenT UnPack()
		{
			IMainScreenT mainScreenT = new IMainScreenT();
			this.UnPackTo(mainScreenT);
			return mainScreenT;
		}

		// Token: 0x06032884 RID: 206980 RVA: 0x006D4397 File Offset: 0x006D2597
		public void UnPackTo(IMainScreenT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06032885 RID: 206981 RVA: 0x006D43A8 File Offset: 0x006D25A8
		public static Offset<IMainScreen> Pack(FlatBufferBuilder builder, IMainScreenT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMainScreen>);
			}
			return IMainScreen.CreateIMainScreen(builder, _o.Type);
		}

		// Token: 0x04012185 RID: 74117
		private Table __p;
	}
}
