using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059E1 RID: 23009
	public struct IInteractPlayerDiractionToLeisure : IFlatbufferObject
	{
		// Token: 0x1700A73D RID: 42813
		// (get) Token: 0x06025921 RID: 153889 RVA: 0x0052735C File Offset: 0x0052555C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025922 RID: 153890 RVA: 0x00527369 File Offset: 0x00525569
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025923 RID: 153891 RVA: 0x00527370 File Offset: 0x00525570
		public static IInteractPlayerDiractionToLeisure GetRootAsIInteractPlayerDiractionToLeisure(ByteBuffer _bb)
		{
			return IInteractPlayerDiractionToLeisure.GetRootAsIInteractPlayerDiractionToLeisure(_bb, default(IInteractPlayerDiractionToLeisure));
		}

		// Token: 0x06025924 RID: 153892 RVA: 0x0052738C File Offset: 0x0052558C
		public static IInteractPlayerDiractionToLeisure GetRootAsIInteractPlayerDiractionToLeisure(ByteBuffer _bb, IInteractPlayerDiractionToLeisure obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025925 RID: 153893 RVA: 0x005273A9 File Offset: 0x005255A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025926 RID: 153894 RVA: 0x005273B8 File Offset: 0x005255B8
		public IInteractPlayerDiractionToLeisure __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A73E RID: 42814
		// (get) Token: 0x06025927 RID: 153895 RVA: 0x005273C8 File Offset: 0x005255C8
		public EInteractPlayerDiractionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EInteractPlayerDiractionType.Npc;
				}
				return (EInteractPlayerDiractionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A73F RID: 42815
		// (get) Token: 0x06025928 RID: 153896 RVA: 0x00527404 File Offset: 0x00525604
		public int Begin
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A740 RID: 42816
		// (get) Token: 0x06025929 RID: 153897 RVA: 0x00527440 File Offset: 0x00525640
		public int End
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602592A RID: 153898 RVA: 0x0052747C File Offset: 0x0052567C
		public static Offset<IInteractPlayerDiractionToLeisure> CreateIInteractPlayerDiractionToLeisure(FlatBufferBuilder builder, EInteractPlayerDiractionType Type = EInteractPlayerDiractionType.Npc, int Begin = 0, int End = 0)
		{
			builder.StartTable(3);
			IInteractPlayerDiractionToLeisure.AddEnd(builder, End);
			IInteractPlayerDiractionToLeisure.AddBegin(builder, Begin);
			IInteractPlayerDiractionToLeisure.AddType(builder, Type);
			return IInteractPlayerDiractionToLeisure.EndIInteractPlayerDiractionToLeisure(builder);
		}

		// Token: 0x0602592B RID: 153899 RVA: 0x005274A0 File Offset: 0x005256A0
		public static void StartIInteractPlayerDiractionToLeisure(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602592C RID: 153900 RVA: 0x005274A9 File Offset: 0x005256A9
		public static void AddType(FlatBufferBuilder builder, EInteractPlayerDiractionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602592D RID: 153901 RVA: 0x005274B4 File Offset: 0x005256B4
		public static void AddBegin(FlatBufferBuilder builder, int begin)
		{
			builder.AddInt(1, begin, 0);
		}

		// Token: 0x0602592E RID: 153902 RVA: 0x005274BF File Offset: 0x005256BF
		public static void AddEnd(FlatBufferBuilder builder, int end)
		{
			builder.AddInt(2, end, 0);
		}

		// Token: 0x0602592F RID: 153903 RVA: 0x005274CA File Offset: 0x005256CA
		public static Offset<IInteractPlayerDiractionToLeisure> EndIInteractPlayerDiractionToLeisure(FlatBufferBuilder builder)
		{
			return new Offset<IInteractPlayerDiractionToLeisure>(builder.EndTable());
		}

		// Token: 0x06025930 RID: 153904 RVA: 0x005274D8 File Offset: 0x005256D8
		public IInteractPlayerDiractionToLeisureT UnPack()
		{
			IInteractPlayerDiractionToLeisureT interactPlayerDiractionToLeisureT = new IInteractPlayerDiractionToLeisureT();
			this.UnPackTo(interactPlayerDiractionToLeisureT);
			return interactPlayerDiractionToLeisureT;
		}

		// Token: 0x06025931 RID: 153905 RVA: 0x005274F3 File Offset: 0x005256F3
		public void UnPackTo(IInteractPlayerDiractionToLeisureT _o)
		{
			_o.Type = this.Type;
			_o.Begin = this.Begin;
			_o.End = this.End;
		}

		// Token: 0x06025932 RID: 153906 RVA: 0x0052751C File Offset: 0x0052571C
		public static Offset<IInteractPlayerDiractionToLeisure> Pack(FlatBufferBuilder builder, IInteractPlayerDiractionToLeisureT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInteractPlayerDiractionToLeisure>);
			}
			return IInteractPlayerDiractionToLeisure.CreateIInteractPlayerDiractionToLeisure(builder, _o.Type, _o.Begin, _o.End);
		}

		// Token: 0x0400F305 RID: 62213
		private Table __p;
	}
}
