using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003DE4 RID: 15844
	public struct IBlackBoard : IFlatbufferObject
	{
		// Token: 0x17006AFE RID: 27390
		// (get) Token: 0x06015437 RID: 87095 RVA: 0x00313689 File Offset: 0x00311889
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015438 RID: 87096 RVA: 0x00313696 File Offset: 0x00311896
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015439 RID: 87097 RVA: 0x003136A0 File Offset: 0x003118A0
		public static IBlackBoard GetRootAsIBlackBoard(ByteBuffer _bb)
		{
			return IBlackBoard.GetRootAsIBlackBoard(_bb, default(IBlackBoard));
		}

		// Token: 0x0601543A RID: 87098 RVA: 0x003136BC File Offset: 0x003118BC
		public static IBlackBoard GetRootAsIBlackBoard(ByteBuffer _bb, IBlackBoard obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601543B RID: 87099 RVA: 0x003136D9 File Offset: 0x003118D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601543C RID: 87100 RVA: 0x003136E8 File Offset: 0x003118E8
		public IBlackBoard __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006AFF RID: 27391
		// (get) Token: 0x0601543D RID: 87101 RVA: 0x003136F8 File Offset: 0x003118F8
		public EBlackBoardType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBlackBoardType.Boolean;
				}
				return (EBlackBoardType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006B00 RID: 27392
		// (get) Token: 0x0601543E RID: 87102 RVA: 0x00313734 File Offset: 0x00311934
		public string Key
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601543F RID: 87103 RVA: 0x0031376B File Offset: 0x0031196B
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06015440 RID: 87104 RVA: 0x0031377A File Offset: 0x0031197A
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06015441 RID: 87105 RVA: 0x00313788 File Offset: 0x00311988
		public static Offset<IBlackBoard> CreateIBlackBoard(FlatBufferBuilder builder, EBlackBoardType Type = EBlackBoardType.Boolean, StringOffset KeyOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IBlackBoard.AddKey(builder, KeyOffset);
			IBlackBoard.AddType(builder, Type);
			return IBlackBoard.EndIBlackBoard(builder);
		}

		// Token: 0x06015442 RID: 87106 RVA: 0x003137A5 File Offset: 0x003119A5
		public static void StartIBlackBoard(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06015443 RID: 87107 RVA: 0x003137AE File Offset: 0x003119AE
		public static void AddType(FlatBufferBuilder builder, EBlackBoardType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015444 RID: 87108 RVA: 0x003137B9 File Offset: 0x003119B9
		public static void AddKey(FlatBufferBuilder builder, StringOffset keyOffset)
		{
			builder.AddOffset(1, keyOffset.Value, 0);
		}

		// Token: 0x06015445 RID: 87109 RVA: 0x003137C9 File Offset: 0x003119C9
		public static Offset<IBlackBoard> EndIBlackBoard(FlatBufferBuilder builder)
		{
			return new Offset<IBlackBoard>(builder.EndTable());
		}

		// Token: 0x06015446 RID: 87110 RVA: 0x003137D8 File Offset: 0x003119D8
		public IBlackBoardT UnPack()
		{
			IBlackBoardT blackBoardT = new IBlackBoardT();
			this.UnPackTo(blackBoardT);
			return blackBoardT;
		}

		// Token: 0x06015447 RID: 87111 RVA: 0x003137F3 File Offset: 0x003119F3
		public void UnPackTo(IBlackBoardT _o)
		{
			_o.Type = this.Type;
			_o.Key = this.Key;
		}

		// Token: 0x06015448 RID: 87112 RVA: 0x00313810 File Offset: 0x00311A10
		public static Offset<IBlackBoard> Pack(FlatBufferBuilder builder, IBlackBoardT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBlackBoard>);
			}
			StringOffset keyOffset = (_o.Key == null) ? default(StringOffset) : builder.CreateString(_o.Key);
			return IBlackBoard.CreateIBlackBoard(builder, _o.Type, keyOffset);
		}

		// Token: 0x0400B793 RID: 46995
		private Table __p;
	}
}
