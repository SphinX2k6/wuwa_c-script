using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F79 RID: 32633
	public class TPhoneSystemInteractUnion
	{
		// Token: 0x1700F2C9 RID: 62153
		// (get) Token: 0x0603AD0B RID: 240907 RVA: 0x007E7C32 File Offset: 0x007E5E32
		// (set) Token: 0x0603AD0C RID: 240908 RVA: 0x007E7C3A File Offset: 0x007E5E3A
		public TPhoneSystemInteract Type { get; set; }

		// Token: 0x1700F2CA RID: 62154
		// (get) Token: 0x0603AD0D RID: 240909 RVA: 0x007E7C43 File Offset: 0x007E5E43
		// (set) Token: 0x0603AD0E RID: 240910 RVA: 0x007E7C4B File Offset: 0x007E5E4B
		public object Value { get; set; }

		// Token: 0x0603AD0F RID: 240911 RVA: 0x007E7C54 File Offset: 0x007E5E54
		public TPhoneSystemInteractUnion()
		{
			this.Type = TPhoneSystemInteract.NONE;
			this.Value = null;
		}

		// Token: 0x0603AD10 RID: 240912 RVA: 0x007E7C6A File Offset: 0x007E5E6A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603AD11 RID: 240913 RVA: 0x007E7C7C File Offset: 0x007E5E7C
		public IDeletePhoneMessageT AsIDeletePhoneMessage()
		{
			return this.As<IDeletePhoneMessageT>();
		}

		// Token: 0x0603AD12 RID: 240914 RVA: 0x007E7C84 File Offset: 0x007E5E84
		public static TPhoneSystemInteractUnion FromIDeletePhoneMessage(IDeletePhoneMessageT _ideletephonemessage)
		{
			return new TPhoneSystemInteractUnion
			{
				Type = TPhoneSystemInteract.IDeletePhoneMessage,
				Value = _ideletephonemessage
			};
		}

		// Token: 0x0603AD13 RID: 240915 RVA: 0x007E7C99 File Offset: 0x007E5E99
		public IFlowOpenPhoneMessageT AsIFlowOpenPhoneMessage()
		{
			return this.As<IFlowOpenPhoneMessageT>();
		}

		// Token: 0x0603AD14 RID: 240916 RVA: 0x007E7CA1 File Offset: 0x007E5EA1
		public static TPhoneSystemInteractUnion FromIFlowOpenPhoneMessage(IFlowOpenPhoneMessageT _iflowopenphonemessage)
		{
			return new TPhoneSystemInteractUnion
			{
				Type = TPhoneSystemInteract.IFlowOpenPhoneMessage,
				Value = _iflowopenphonemessage
			};
		}

		// Token: 0x0603AD15 RID: 240917 RVA: 0x007E7CB6 File Offset: 0x007E5EB6
		public IOpenPhoneMessageBoardT AsIOpenPhoneMessageBoard()
		{
			return this.As<IOpenPhoneMessageBoardT>();
		}

		// Token: 0x0603AD16 RID: 240918 RVA: 0x007E7CBE File Offset: 0x007E5EBE
		public static TPhoneSystemInteractUnion FromIOpenPhoneMessageBoard(IOpenPhoneMessageBoardT _iopenphonemessageboard)
		{
			return new TPhoneSystemInteractUnion
			{
				Type = TPhoneSystemInteract.IOpenPhoneMessageBoard,
				Value = _iopenphonemessageboard
			};
		}

		// Token: 0x0603AD17 RID: 240919 RVA: 0x007E7CD3 File Offset: 0x007E5ED3
		public ISendPhoneMessageT AsISendPhoneMessage()
		{
			return this.As<ISendPhoneMessageT>();
		}

		// Token: 0x0603AD18 RID: 240920 RVA: 0x007E7CDB File Offset: 0x007E5EDB
		public static TPhoneSystemInteractUnion FromISendPhoneMessage(ISendPhoneMessageT _isendphonemessage)
		{
			return new TPhoneSystemInteractUnion
			{
				Type = TPhoneSystemInteract.ISendPhoneMessage,
				Value = _isendphonemessage
			};
		}

		// Token: 0x0603AD19 RID: 240921 RVA: 0x007E7CF0 File Offset: 0x007E5EF0
		public static int Pack(FlatBufferBuilder builder, TPhoneSystemInteractUnion _o)
		{
			switch (_o.Type)
			{
			case TPhoneSystemInteract.IDeletePhoneMessage:
				return IDeletePhoneMessage.Pack(builder, _o.AsIDeletePhoneMessage()).Value;
			case TPhoneSystemInteract.IFlowOpenPhoneMessage:
				return IFlowOpenPhoneMessage.Pack(builder, _o.AsIFlowOpenPhoneMessage()).Value;
			case TPhoneSystemInteract.IOpenPhoneMessageBoard:
				return IOpenPhoneMessageBoard.Pack(builder, _o.AsIOpenPhoneMessageBoard()).Value;
			case TPhoneSystemInteract.ISendPhoneMessage:
				return ISendPhoneMessage.Pack(builder, _o.AsISendPhoneMessage()).Value;
			default:
				return 0;
			}
		}
	}
}
