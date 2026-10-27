using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007750 RID: 30544
	public class TPhoneSystemInteractUnion
	{
		// Token: 0x1700E679 RID: 59001
		// (get) Token: 0x060377CE RID: 227278 RVA: 0x00782C5E File Offset: 0x00780E5E
		// (set) Token: 0x060377CF RID: 227279 RVA: 0x00782C66 File Offset: 0x00780E66
		public TPhoneSystemInteract Type { get; set; }

		// Token: 0x1700E67A RID: 59002
		// (get) Token: 0x060377D0 RID: 227280 RVA: 0x00782C6F File Offset: 0x00780E6F
		// (set) Token: 0x060377D1 RID: 227281 RVA: 0x00782C77 File Offset: 0x00780E77
		public object Value { get; set; }

		// Token: 0x060377D2 RID: 227282 RVA: 0x00782C80 File Offset: 0x00780E80
		public TPhoneSystemInteractUnion()
		{
			this.Type = TPhoneSystemInteract.NONE;
			this.Value = null;
		}

		// Token: 0x060377D3 RID: 227283 RVA: 0x00782C96 File Offset: 0x00780E96
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060377D4 RID: 227284 RVA: 0x00782CA8 File Offset: 0x00780EA8
		public IDeletePhoneMessageT AsIDeletePhoneMessage()
		{
			return this.As<IDeletePhoneMessageT>();
		}

		// Token: 0x060377D5 RID: 227285 RVA: 0x00782CB0 File Offset: 0x00780EB0
		public static TPhoneSystemInteractUnion FromIDeletePhoneMessage(IDeletePhoneMessageT _ideletephonemessage)
		{
			return new TPhoneSystemInteractUnion
			{
				Type = TPhoneSystemInteract.IDeletePhoneMessage,
				Value = _ideletephonemessage
			};
		}

		// Token: 0x060377D6 RID: 227286 RVA: 0x00782CC5 File Offset: 0x00780EC5
		public IFlowOpenPhoneMessageT AsIFlowOpenPhoneMessage()
		{
			return this.As<IFlowOpenPhoneMessageT>();
		}

		// Token: 0x060377D7 RID: 227287 RVA: 0x00782CCD File Offset: 0x00780ECD
		public static TPhoneSystemInteractUnion FromIFlowOpenPhoneMessage(IFlowOpenPhoneMessageT _iflowopenphonemessage)
		{
			return new TPhoneSystemInteractUnion
			{
				Type = TPhoneSystemInteract.IFlowOpenPhoneMessage,
				Value = _iflowopenphonemessage
			};
		}

		// Token: 0x060377D8 RID: 227288 RVA: 0x00782CE2 File Offset: 0x00780EE2
		public IOpenPhoneMessageBoardT AsIOpenPhoneMessageBoard()
		{
			return this.As<IOpenPhoneMessageBoardT>();
		}

		// Token: 0x060377D9 RID: 227289 RVA: 0x00782CEA File Offset: 0x00780EEA
		public static TPhoneSystemInteractUnion FromIOpenPhoneMessageBoard(IOpenPhoneMessageBoardT _iopenphonemessageboard)
		{
			return new TPhoneSystemInteractUnion
			{
				Type = TPhoneSystemInteract.IOpenPhoneMessageBoard,
				Value = _iopenphonemessageboard
			};
		}

		// Token: 0x060377DA RID: 227290 RVA: 0x00782CFF File Offset: 0x00780EFF
		public ISendPhoneMessageT AsISendPhoneMessage()
		{
			return this.As<ISendPhoneMessageT>();
		}

		// Token: 0x060377DB RID: 227291 RVA: 0x00782D07 File Offset: 0x00780F07
		public static TPhoneSystemInteractUnion FromISendPhoneMessage(ISendPhoneMessageT _isendphonemessage)
		{
			return new TPhoneSystemInteractUnion
			{
				Type = TPhoneSystemInteract.ISendPhoneMessage,
				Value = _isendphonemessage
			};
		}

		// Token: 0x060377DC RID: 227292 RVA: 0x00782D1C File Offset: 0x00780F1C
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
