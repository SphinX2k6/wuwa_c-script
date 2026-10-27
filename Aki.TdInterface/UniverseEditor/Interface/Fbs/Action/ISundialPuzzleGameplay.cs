using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200723B RID: 29243
	public struct ISundialPuzzleGameplay : IFlatbufferObject
	{
		// Token: 0x1700D901 RID: 55553
		// (get) Token: 0x06033DE0 RID: 212448 RVA: 0x006FA6FA File Offset: 0x006F88FA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033DE1 RID: 212449 RVA: 0x006FA707 File Offset: 0x006F8907
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033DE2 RID: 212450 RVA: 0x006FA710 File Offset: 0x006F8910
		public static ISundialPuzzleGameplay GetRootAsISundialPuzzleGameplay(ByteBuffer _bb)
		{
			return ISundialPuzzleGameplay.GetRootAsISundialPuzzleGameplay(_bb, default(ISundialPuzzleGameplay));
		}

		// Token: 0x06033DE3 RID: 212451 RVA: 0x006FA72C File Offset: 0x006F892C
		public static ISundialPuzzleGameplay GetRootAsISundialPuzzleGameplay(ByteBuffer _bb, ISundialPuzzleGameplay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033DE4 RID: 212452 RVA: 0x006FA749 File Offset: 0x006F8949
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033DE5 RID: 212453 RVA: 0x006FA758 File Offset: 0x006F8958
		public ISundialPuzzleGameplay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D902 RID: 55554
		// (get) Token: 0x06033DE6 RID: 212454 RVA: 0x006FA768 File Offset: 0x006F8968
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

		// Token: 0x06033DE7 RID: 212455 RVA: 0x006FA7A4 File Offset: 0x006F89A4
		public static Offset<ISundialPuzzleGameplay> CreateISundialPuzzleGameplay(FlatBufferBuilder builder, ESimpleGameplayType Type = ESimpleGameplayType.Cipher)
		{
			builder.StartTable(1);
			ISundialPuzzleGameplay.AddType(builder, Type);
			return ISundialPuzzleGameplay.EndISundialPuzzleGameplay(builder);
		}

		// Token: 0x06033DE8 RID: 212456 RVA: 0x006FA7BA File Offset: 0x006F89BA
		public static void StartISundialPuzzleGameplay(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06033DE9 RID: 212457 RVA: 0x006FA7C3 File Offset: 0x006F89C3
		public static void AddType(FlatBufferBuilder builder, ESimpleGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033DEA RID: 212458 RVA: 0x006FA7CE File Offset: 0x006F89CE
		public static Offset<ISundialPuzzleGameplay> EndISundialPuzzleGameplay(FlatBufferBuilder builder)
		{
			return new Offset<ISundialPuzzleGameplay>(builder.EndTable());
		}

		// Token: 0x06033DEB RID: 212459 RVA: 0x006FA7DC File Offset: 0x006F89DC
		public ISundialPuzzleGameplayT UnPack()
		{
			ISundialPuzzleGameplayT sundialPuzzleGameplayT = new ISundialPuzzleGameplayT();
			this.UnPackTo(sundialPuzzleGameplayT);
			return sundialPuzzleGameplayT;
		}

		// Token: 0x06033DEC RID: 212460 RVA: 0x006FA7F7 File Offset: 0x006F89F7
		public void UnPackTo(ISundialPuzzleGameplayT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06033DED RID: 212461 RVA: 0x006FA808 File Offset: 0x006F8A08
		public static Offset<ISundialPuzzleGameplay> Pack(FlatBufferBuilder builder, ISundialPuzzleGameplayT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISundialPuzzleGameplay>);
			}
			return ISundialPuzzleGameplay.CreateISundialPuzzleGameplay(builder, _o.Type);
		}

		// Token: 0x04011D2E RID: 73006
		private Table __p;
	}
}
