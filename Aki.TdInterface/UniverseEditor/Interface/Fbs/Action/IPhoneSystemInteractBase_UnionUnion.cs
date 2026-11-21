using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007428 RID: 29736
	public class IPhoneSystemInteractBase_UnionUnion
	{
		// Token: 0x1700DA67 RID: 55911
		// (get) Token: 0x06034064 RID: 213092 RVA: 0x00702E61 File Offset: 0x00701061
		// (set) Token: 0x06034065 RID: 213093 RVA: 0x00702E69 File Offset: 0x00701069
		public IPhoneSystemInteractBase_Union Type { get; set; }

		// Token: 0x1700DA68 RID: 55912
		// (get) Token: 0x06034066 RID: 213094 RVA: 0x00702E72 File Offset: 0x00701072
		// (set) Token: 0x06034067 RID: 213095 RVA: 0x00702E7A File Offset: 0x0070107A
		public object Value { get; set; }

		// Token: 0x06034068 RID: 213096 RVA: 0x00702E83 File Offset: 0x00701083
		public IPhoneSystemInteractBase_UnionUnion()
		{
			this.Type = IPhoneSystemInteractBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06034069 RID: 213097 RVA: 0x00702E99 File Offset: 0x00701099
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603406A RID: 213098 RVA: 0x00702EAB File Offset: 0x007010AB
		public IPhoneSystemInteractBaseT AsIPhoneSystemInteractBase()
		{
			return this.As<IPhoneSystemInteractBaseT>();
		}

		// Token: 0x0603406B RID: 213099 RVA: 0x00702EB3 File Offset: 0x007010B3
		public static IPhoneSystemInteractBase_UnionUnion FromIPhoneSystemInteractBase(IPhoneSystemInteractBaseT _iphonesysteminteractbase)
		{
			return new IPhoneSystemInteractBase_UnionUnion
			{
				Type = IPhoneSystemInteractBase_Union.IPhoneSystemInteractBase,
				Value = _iphonesysteminteractbase
			};
		}

		// Token: 0x0603406C RID: 213100 RVA: 0x00702EC8 File Offset: 0x007010C8
		public ISendPhoneMessageT AsISendPhoneMessage()
		{
			return this.As<ISendPhoneMessageT>();
		}

		// Token: 0x0603406D RID: 213101 RVA: 0x00702ED0 File Offset: 0x007010D0
		public static IPhoneSystemInteractBase_UnionUnion FromISendPhoneMessage(ISendPhoneMessageT _isendphonemessage)
		{
			return new IPhoneSystemInteractBase_UnionUnion
			{
				Type = IPhoneSystemInteractBase_Union.ISendPhoneMessage,
				Value = _isendphonemessage
			};
		}

		// Token: 0x0603406E RID: 213102 RVA: 0x00702EE5 File Offset: 0x007010E5
		public IDeletePhoneMessageT AsIDeletePhoneMessage()
		{
			return this.As<IDeletePhoneMessageT>();
		}

		// Token: 0x0603406F RID: 213103 RVA: 0x00702EED File Offset: 0x007010ED
		public static IPhoneSystemInteractBase_UnionUnion FromIDeletePhoneMessage(IDeletePhoneMessageT _ideletephonemessage)
		{
			return new IPhoneSystemInteractBase_UnionUnion
			{
				Type = IPhoneSystemInteractBase_Union.IDeletePhoneMessage,
				Value = _ideletephonemessage
			};
		}

		// Token: 0x06034070 RID: 213104 RVA: 0x00702F02 File Offset: 0x00701102
		public IOpenPhoneMessageBoardT AsIOpenPhoneMessageBoard()
		{
			return this.As<IOpenPhoneMessageBoardT>();
		}

		// Token: 0x06034071 RID: 213105 RVA: 0x00702F0A File Offset: 0x0070110A
		public static IPhoneSystemInteractBase_UnionUnion FromIOpenPhoneMessageBoard(IOpenPhoneMessageBoardT _iopenphonemessageboard)
		{
			return new IPhoneSystemInteractBase_UnionUnion
			{
				Type = IPhoneSystemInteractBase_Union.IOpenPhoneMessageBoard,
				Value = _iopenphonemessageboard
			};
		}

		// Token: 0x06034072 RID: 213106 RVA: 0x00702F1F File Offset: 0x0070111F
		public IFlowOpenPhoneMessageT AsIFlowOpenPhoneMessage()
		{
			return this.As<IFlowOpenPhoneMessageT>();
		}

		// Token: 0x06034073 RID: 213107 RVA: 0x00702F27 File Offset: 0x00701127
		public static IPhoneSystemInteractBase_UnionUnion FromIFlowOpenPhoneMessage(IFlowOpenPhoneMessageT _iflowopenphonemessage)
		{
			return new IPhoneSystemInteractBase_UnionUnion
			{
				Type = IPhoneSystemInteractBase_Union.IFlowOpenPhoneMessage,
				Value = _iflowopenphonemessage
			};
		}

		// Token: 0x06034074 RID: 213108 RVA: 0x00702F3C File Offset: 0x0070113C
		public static int Pack(FlatBufferBuilder builder, IPhoneSystemInteractBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IPhoneSystemInteractBase_Union.IPhoneSystemInteractBase:
				return IPhoneSystemInteractBase.Pack(builder, _o.AsIPhoneSystemInteractBase()).Value;
			case IPhoneSystemInteractBase_Union.ISendPhoneMessage:
				return ISendPhoneMessage.Pack(builder, _o.AsISendPhoneMessage()).Value;
			case IPhoneSystemInteractBase_Union.IDeletePhoneMessage:
				return IDeletePhoneMessage.Pack(builder, _o.AsIDeletePhoneMessage()).Value;
			case IPhoneSystemInteractBase_Union.IOpenPhoneMessageBoard:
				return IOpenPhoneMessageBoard.Pack(builder, _o.AsIOpenPhoneMessageBoard()).Value;
			case IPhoneSystemInteractBase_Union.IFlowOpenPhoneMessage:
				return IFlowOpenPhoneMessage.Pack(builder, _o.AsIFlowOpenPhoneMessage()).Value;
			default:
				return 0;
			}
		}
	}
}
