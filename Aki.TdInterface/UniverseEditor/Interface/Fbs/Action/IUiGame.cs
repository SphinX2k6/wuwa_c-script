using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C95 RID: 31893
	public struct IUiGame : IFlatbufferObject
	{
		// Token: 0x1700EED2 RID: 61138
		// (get) Token: 0x06039853 RID: 235603 RVA: 0x007C386C File Offset: 0x007C1A6C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039854 RID: 235604 RVA: 0x007C3879 File Offset: 0x007C1A79
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039855 RID: 235605 RVA: 0x007C3880 File Offset: 0x007C1A80
		public static IUiGame GetRootAsIUiGame(ByteBuffer _bb)
		{
			return IUiGame.GetRootAsIUiGame(_bb, default(IUiGame));
		}

		// Token: 0x06039856 RID: 235606 RVA: 0x007C389C File Offset: 0x007C1A9C
		public static IUiGame GetRootAsIUiGame(ByteBuffer _bb, IUiGame obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06039857 RID: 235607 RVA: 0x007C38B9 File Offset: 0x007C1AB9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06039858 RID: 235608 RVA: 0x007C38C8 File Offset: 0x007C1AC8
		public IUiGame __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EED3 RID: 61139
		// (get) Token: 0x06039859 RID: 235609 RVA: 0x007C38D8 File Offset: 0x007C1AD8
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

		// Token: 0x0603985A RID: 235610 RVA: 0x007C3914 File Offset: 0x007C1B14
		public static Offset<IUiGame> CreateIUiGame(FlatBufferBuilder builder, ESimpleGameplayType Type = ESimpleGameplayType.Cipher)
		{
			builder.StartTable(1);
			IUiGame.AddType(builder, Type);
			return IUiGame.EndIUiGame(builder);
		}

		// Token: 0x0603985B RID: 235611 RVA: 0x007C392A File Offset: 0x007C1B2A
		public static void StartIUiGame(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603985C RID: 235612 RVA: 0x007C3933 File Offset: 0x007C1B33
		public static void AddType(FlatBufferBuilder builder, ESimpleGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603985D RID: 235613 RVA: 0x007C393E File Offset: 0x007C1B3E
		public static Offset<IUiGame> EndIUiGame(FlatBufferBuilder builder)
		{
			return new Offset<IUiGame>(builder.EndTable());
		}

		// Token: 0x0603985E RID: 235614 RVA: 0x007C394C File Offset: 0x007C1B4C
		public IUiGameT UnPack()
		{
			IUiGameT uiGameT = new IUiGameT();
			this.UnPackTo(uiGameT);
			return uiGameT;
		}

		// Token: 0x0603985F RID: 235615 RVA: 0x007C3967 File Offset: 0x007C1B67
		public void UnPackTo(IUiGameT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06039860 RID: 235616 RVA: 0x007C3978 File Offset: 0x007C1B78
		public static Offset<IUiGame> Pack(FlatBufferBuilder builder, IUiGameT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUiGame>);
			}
			return IUiGame.CreateIUiGame(builder, _o.Type);
		}

		// Token: 0x04013368 RID: 78696
		private Table __p;
	}
}
