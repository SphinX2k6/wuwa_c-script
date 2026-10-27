using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CB2 RID: 27826
	public class IPhoneSystemInteractBase_UnionUnion
	{
		// Token: 0x1700CF2A RID: 53034
		// (get) Token: 0x0603108D RID: 200845 RVA: 0x006A7C2D File Offset: 0x006A5E2D
		// (set) Token: 0x0603108E RID: 200846 RVA: 0x006A7C35 File Offset: 0x006A5E35
		public IPhoneSystemInteractBase_Union Type { get; set; }

		// Token: 0x1700CF2B RID: 53035
		// (get) Token: 0x0603108F RID: 200847 RVA: 0x006A7C3E File Offset: 0x006A5E3E
		// (set) Token: 0x06031090 RID: 200848 RVA: 0x006A7C46 File Offset: 0x006A5E46
		public object Value { get; set; }

		// Token: 0x06031091 RID: 200849 RVA: 0x006A7C4F File Offset: 0x006A5E4F
		public IPhoneSystemInteractBase_UnionUnion()
		{
			this.Type = IPhoneSystemInteractBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06031092 RID: 200850 RVA: 0x006A7C65 File Offset: 0x006A5E65
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06031093 RID: 200851 RVA: 0x006A7C77 File Offset: 0x006A5E77
		public IPhoneSystemInteractBaseT AsIPhoneSystemInteractBase()
		{
			return this.As<IPhoneSystemInteractBaseT>();
		}

		// Token: 0x06031094 RID: 200852 RVA: 0x006A7C7F File Offset: 0x006A5E7F
		public static IPhoneSystemInteractBase_UnionUnion FromIPhoneSystemInteractBase(IPhoneSystemInteractBaseT _iphonesysteminteractbase)
		{
			return new IPhoneSystemInteractBase_UnionUnion
			{
				Type = IPhoneSystemInteractBase_Union.IPhoneSystemInteractBase,
				Value = _iphonesysteminteractbase
			};
		}

		// Token: 0x06031095 RID: 200853 RVA: 0x006A7C94 File Offset: 0x006A5E94
		public ISendPhoneMessageT AsISendPhoneMessage()
		{
			return this.As<ISendPhoneMessageT>();
		}

		// Token: 0x06031096 RID: 200854 RVA: 0x006A7C9C File Offset: 0x006A5E9C
		public static IPhoneSystemInteractBase_UnionUnion FromISendPhoneMessage(ISendPhoneMessageT _isendphonemessage)
		{
			return new IPhoneSystemInteractBase_UnionUnion
			{
				Type = IPhoneSystemInteractBase_Union.ISendPhoneMessage,
				Value = _isendphonemessage
			};
		}

		// Token: 0x06031097 RID: 200855 RVA: 0x006A7CB1 File Offset: 0x006A5EB1
		public IDeletePhoneMessageT AsIDeletePhoneMessage()
		{
			return this.As<IDeletePhoneMessageT>();
		}

		// Token: 0x06031098 RID: 200856 RVA: 0x006A7CB9 File Offset: 0x006A5EB9
		public static IPhoneSystemInteractBase_UnionUnion FromIDeletePhoneMessage(IDeletePhoneMessageT _ideletephonemessage)
		{
			return new IPhoneSystemInteractBase_UnionUnion
			{
				Type = IPhoneSystemInteractBase_Union.IDeletePhoneMessage,
				Value = _ideletephonemessage
			};
		}

		// Token: 0x06031099 RID: 200857 RVA: 0x006A7CCE File Offset: 0x006A5ECE
		public IOpenPhoneMessageBoardT AsIOpenPhoneMessageBoard()
		{
			return this.As<IOpenPhoneMessageBoardT>();
		}

		// Token: 0x0603109A RID: 200858 RVA: 0x006A7CD6 File Offset: 0x006A5ED6
		public static IPhoneSystemInteractBase_UnionUnion FromIOpenPhoneMessageBoard(IOpenPhoneMessageBoardT _iopenphonemessageboard)
		{
			return new IPhoneSystemInteractBase_UnionUnion
			{
				Type = IPhoneSystemInteractBase_Union.IOpenPhoneMessageBoard,
				Value = _iopenphonemessageboard
			};
		}

		// Token: 0x0603109B RID: 200859 RVA: 0x006A7CEB File Offset: 0x006A5EEB
		public IFlowOpenPhoneMessageT AsIFlowOpenPhoneMessage()
		{
			return this.As<IFlowOpenPhoneMessageT>();
		}

		// Token: 0x0603109C RID: 200860 RVA: 0x006A7CF3 File Offset: 0x006A5EF3
		public static IPhoneSystemInteractBase_UnionUnion FromIFlowOpenPhoneMessage(IFlowOpenPhoneMessageT _iflowopenphonemessage)
		{
			return new IPhoneSystemInteractBase_UnionUnion
			{
				Type = IPhoneSystemInteractBase_Union.IFlowOpenPhoneMessage,
				Value = _iflowopenphonemessage
			};
		}

		// Token: 0x0603109D RID: 200861 RVA: 0x006A7D08 File Offset: 0x006A5F08
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
