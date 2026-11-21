using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007416 RID: 29718
	public class IPhoneBoardTypeBase_UnionUnion
	{
		// Token: 0x1700DA4E RID: 55886
		// (get) Token: 0x06033FE8 RID: 212968 RVA: 0x007021A9 File Offset: 0x007003A9
		// (set) Token: 0x06033FE9 RID: 212969 RVA: 0x007021B1 File Offset: 0x007003B1
		public IPhoneBoardTypeBase_Union Type { get; set; }

		// Token: 0x1700DA4F RID: 55887
		// (get) Token: 0x06033FEA RID: 212970 RVA: 0x007021BA File Offset: 0x007003BA
		// (set) Token: 0x06033FEB RID: 212971 RVA: 0x007021C2 File Offset: 0x007003C2
		public object Value { get; set; }

		// Token: 0x06033FEC RID: 212972 RVA: 0x007021CB File Offset: 0x007003CB
		public IPhoneBoardTypeBase_UnionUnion()
		{
			this.Type = IPhoneBoardTypeBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06033FED RID: 212973 RVA: 0x007021E1 File Offset: 0x007003E1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06033FEE RID: 212974 RVA: 0x007021F3 File Offset: 0x007003F3
		public IPhoneBoardTypeBaseT AsIPhoneBoardTypeBase()
		{
			return this.As<IPhoneBoardTypeBaseT>();
		}

		// Token: 0x06033FEF RID: 212975 RVA: 0x007021FB File Offset: 0x007003FB
		public static IPhoneBoardTypeBase_UnionUnion FromIPhoneBoardTypeBase(IPhoneBoardTypeBaseT _iphoneboardtypebase)
		{
			return new IPhoneBoardTypeBase_UnionUnion
			{
				Type = IPhoneBoardTypeBase_Union.IPhoneBoardTypeBase,
				Value = _iphoneboardtypebase
			};
		}

		// Token: 0x06033FF0 RID: 212976 RVA: 0x00702210 File Offset: 0x00700410
		public IMessageBoardT AsIMessageBoard()
		{
			return this.As<IMessageBoardT>();
		}

		// Token: 0x06033FF1 RID: 212977 RVA: 0x00702218 File Offset: 0x00700418
		public static IPhoneBoardTypeBase_UnionUnion FromIMessageBoard(IMessageBoardT _imessageboard)
		{
			return new IPhoneBoardTypeBase_UnionUnion
			{
				Type = IPhoneBoardTypeBase_Union.IMessageBoard,
				Value = _imessageboard
			};
		}

		// Token: 0x06033FF2 RID: 212978 RVA: 0x00702230 File Offset: 0x00700430
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
