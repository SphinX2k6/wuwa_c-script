using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200749F RID: 29855
	public struct IUiGame : IFlatbufferObject
	{
		// Token: 0x1700E2AE RID: 58030
		// (get) Token: 0x06036450 RID: 222288 RVA: 0x007608B0 File Offset: 0x0075EAB0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036451 RID: 222289 RVA: 0x007608BD File Offset: 0x0075EABD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036452 RID: 222290 RVA: 0x007608C4 File Offset: 0x0075EAC4
		public static IUiGame GetRootAsIUiGame(ByteBuffer _bb)
		{
			return IUiGame.GetRootAsIUiGame(_bb, default(IUiGame));
		}

		// Token: 0x06036453 RID: 222291 RVA: 0x007608E0 File Offset: 0x0075EAE0
		public static IUiGame GetRootAsIUiGame(ByteBuffer _bb, IUiGame obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036454 RID: 222292 RVA: 0x007608FD File Offset: 0x0075EAFD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036455 RID: 222293 RVA: 0x0076090C File Offset: 0x0075EB0C
		public IUiGame __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E2AF RID: 58031
		// (get) Token: 0x06036456 RID: 222294 RVA: 0x0076091C File Offset: 0x0075EB1C
		public ESimpleGameplayType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESimpleGameplayType.Cipher;
				}
				return (ESimpleGameplayType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06036457 RID: 222295 RVA: 0x00760958 File Offset: 0x0075EB58
		public static Offset<IUiGame> CreateIUiGame(FlatBufferBuilder builder, ESimpleGameplayType Type = ESimpleGameplayType.Cipher)
		{
			builder.StartTable(1);
			IUiGame.AddType(builder, Type);
			return IUiGame.EndIUiGame(builder);
		}

		// Token: 0x06036458 RID: 222296 RVA: 0x0076096E File Offset: 0x0075EB6E
		public static void StartIUiGame(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06036459 RID: 222297 RVA: 0x00760977 File Offset: 0x0075EB77
		public static void AddType(FlatBufferBuilder builder, ESimpleGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603645A RID: 222298 RVA: 0x00760982 File Offset: 0x0075EB82
		public static Offset<IUiGame> EndIUiGame(FlatBufferBuilder builder)
		{
			return new Offset<IUiGame>(builder.EndTable());
		}

		// Token: 0x0603645B RID: 222299 RVA: 0x00760990 File Offset: 0x0075EB90
		public IUiGameT UnPack()
		{
			IUiGameT uiGameT = new IUiGameT();
			this.UnPackTo(uiGameT);
			return uiGameT;
		}

		// Token: 0x0603645C RID: 222300 RVA: 0x007609AB File Offset: 0x0075EBAB
		public void UnPackTo(IUiGameT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0603645D RID: 222301 RVA: 0x007609BC File Offset: 0x0075EBBC
		public static Offset<IUiGame> Pack(FlatBufferBuilder builder, IUiGameT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUiGame>);
			}
			return IUiGame.CreateIUiGame(builder, _o.Type);
		}

		// Token: 0x0401233D RID: 74557
		private Table __p;
	}
}
