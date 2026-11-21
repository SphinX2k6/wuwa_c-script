using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A10 RID: 31248
	public struct ISundialPuzzleGameplay : IFlatbufferObject
	{
		// Token: 0x1700E4FA RID: 58618
		// (get) Token: 0x060370E2 RID: 225506 RVA: 0x0075BA5A File Offset: 0x00759C5A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060370E3 RID: 225507 RVA: 0x0075BA67 File Offset: 0x00759C67
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060370E4 RID: 225508 RVA: 0x0075BA70 File Offset: 0x00759C70
		public static ISundialPuzzleGameplay GetRootAsISundialPuzzleGameplay(ByteBuffer _bb)
		{
			return ISundialPuzzleGameplay.GetRootAsISundialPuzzleGameplay(_bb, default(ISundialPuzzleGameplay));
		}

		// Token: 0x060370E5 RID: 225509 RVA: 0x0075BA8C File Offset: 0x00759C8C
		public static ISundialPuzzleGameplay GetRootAsISundialPuzzleGameplay(ByteBuffer _bb, ISundialPuzzleGameplay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060370E6 RID: 225510 RVA: 0x0075BAA9 File Offset: 0x00759CA9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060370E7 RID: 225511 RVA: 0x0075BAB8 File Offset: 0x00759CB8
		public ISundialPuzzleGameplay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E4FB RID: 58619
		// (get) Token: 0x060370E8 RID: 225512 RVA: 0x0075BAC8 File Offset: 0x00759CC8
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

		// Token: 0x060370E9 RID: 225513 RVA: 0x0075BB04 File Offset: 0x00759D04
		public static Offset<ISundialPuzzleGameplay> CreateISundialPuzzleGameplay(FlatBufferBuilder builder, ESimpleGameplayType Type = ESimpleGameplayType.Cipher)
		{
			builder.StartTable(1);
			ISundialPuzzleGameplay.AddType(builder, Type);
			return ISundialPuzzleGameplay.EndISundialPuzzleGameplay(builder);
		}

		// Token: 0x060370EA RID: 225514 RVA: 0x0075BB1A File Offset: 0x00759D1A
		public static void StartISundialPuzzleGameplay(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060370EB RID: 225515 RVA: 0x0075BB23 File Offset: 0x00759D23
		public static void AddType(FlatBufferBuilder builder, ESimpleGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060370EC RID: 225516 RVA: 0x0075BB2E File Offset: 0x00759D2E
		public static Offset<ISundialPuzzleGameplay> EndISundialPuzzleGameplay(FlatBufferBuilder builder)
		{
			return new Offset<ISundialPuzzleGameplay>(builder.EndTable());
		}

		// Token: 0x060370ED RID: 225517 RVA: 0x0075BB3C File Offset: 0x00759D3C
		public ISundialPuzzleGameplayT UnPack()
		{
			ISundialPuzzleGameplayT sundialPuzzleGameplayT = new ISundialPuzzleGameplayT();
			this.UnPackTo(sundialPuzzleGameplayT);
			return sundialPuzzleGameplayT;
		}

		// Token: 0x060370EE RID: 225518 RVA: 0x0075BB57 File Offset: 0x00759D57
		public void UnPackTo(ISundialPuzzleGameplayT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060370EF RID: 225519 RVA: 0x0075BB68 File Offset: 0x00759D68
		public static Offset<ISundialPuzzleGameplay> Pack(FlatBufferBuilder builder, ISundialPuzzleGameplayT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISundialPuzzleGameplay>);
			}
			return ISundialPuzzleGameplay.CreateISundialPuzzleGameplay(builder, _o.Type);
		}

		// Token: 0x04012D30 RID: 77104
		private Table __p;
	}
}
