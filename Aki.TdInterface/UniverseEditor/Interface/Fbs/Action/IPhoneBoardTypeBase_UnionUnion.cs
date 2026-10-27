using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CA0 RID: 27808
	public class IPhoneBoardTypeBase_UnionUnion
	{
		// Token: 0x1700CF11 RID: 53009
		// (get) Token: 0x06031011 RID: 200721 RVA: 0x006A6F75 File Offset: 0x006A5175
		// (set) Token: 0x06031012 RID: 200722 RVA: 0x006A6F7D File Offset: 0x006A517D
		public IPhoneBoardTypeBase_Union Type { get; set; }

		// Token: 0x1700CF12 RID: 53010
		// (get) Token: 0x06031013 RID: 200723 RVA: 0x006A6F86 File Offset: 0x006A5186
		// (set) Token: 0x06031014 RID: 200724 RVA: 0x006A6F8E File Offset: 0x006A518E
		public object Value { get; set; }

		// Token: 0x06031015 RID: 200725 RVA: 0x006A6F97 File Offset: 0x006A5197
		public IPhoneBoardTypeBase_UnionUnion()
		{
			this.Type = IPhoneBoardTypeBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06031016 RID: 200726 RVA: 0x006A6FAD File Offset: 0x006A51AD
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06031017 RID: 200727 RVA: 0x006A6FBF File Offset: 0x006A51BF
		public IPhoneBoardTypeBaseT AsIPhoneBoardTypeBase()
		{
			return this.As<IPhoneBoardTypeBaseT>();
		}

		// Token: 0x06031018 RID: 200728 RVA: 0x006A6FC7 File Offset: 0x006A51C7
		public static IPhoneBoardTypeBase_UnionUnion FromIPhoneBoardTypeBase(IPhoneBoardTypeBaseT _iphoneboardtypebase)
		{
			return new IPhoneBoardTypeBase_UnionUnion
			{
				Type = IPhoneBoardTypeBase_Union.IPhoneBoardTypeBase,
				Value = _iphoneboardtypebase
			};
		}

		// Token: 0x06031019 RID: 200729 RVA: 0x006A6FDC File Offset: 0x006A51DC
		public IMessageBoardT AsIMessageBoard()
		{
			return this.As<IMessageBoardT>();
		}

		// Token: 0x0603101A RID: 200730 RVA: 0x006A6FE4 File Offset: 0x006A51E4
		public static IPhoneBoardTypeBase_UnionUnion FromIMessageBoard(IMessageBoardT _imessageboard)
		{
			return new IPhoneBoardTypeBase_UnionUnion
			{
				Type = IPhoneBoardTypeBase_Union.IMessageBoard,
				Value = _imessageboard
			};
		}

		// Token: 0x0603101B RID: 200731 RVA: 0x006A6FFC File Offset: 0x006A51FC
		public static int Pack(FlatBufferBuilder builder, IPhoneBoardTypeBase_UnionUnion _o)
		{
			IPhoneBoardTypeBase_Union type = _o.Type;
			if (type == IPhoneBoardTypeBase_Union.IPhoneBoardTypeBase)
			{
				return IPhoneBoardTypeBase.Pack(builder, _o.AsIPhoneBoardTypeBase()).Value;
			}
			if (type != IPhoneBoardTypeBase_Union.IMessageBoard)
			{
				return 0;
			}
			return IMessageBoard.Pack(builder, _o.AsIMessageBoard()).Value;
		}
	}
}
