using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007421 RID: 29729
	public struct IPhoneSystemInteract : IFlatbufferObject
	{
		// Token: 0x1700DA61 RID: 55905
		// (get) Token: 0x0603403A RID: 213050 RVA: 0x0070293C File Offset: 0x00700B3C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603403B RID: 213051 RVA: 0x00702949 File Offset: 0x00700B49
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603403C RID: 213052 RVA: 0x00702950 File Offset: 0x00700B50
		public static IPhoneSystemInteract GetRootAsIPhoneSystemInteract(ByteBuffer _bb)
		{
			return IPhoneSystemInteract.GetRootAsIPhoneSystemInteract(_bb, default(IPhoneSystemInteract));
		}

		// Token: 0x0603403D RID: 213053 RVA: 0x0070296C File Offset: 0x00700B6C
		public static IPhoneSystemInteract GetRootAsIPhoneSystemInteract(ByteBuffer _bb, IPhoneSystemInteract obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603403E RID: 213054 RVA: 0x00702989 File Offset: 0x00700B89
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603403F RID: 213055 RVA: 0x00702998 File Offset: 0x00700B98
		public IPhoneSystemInteract __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DA62 RID: 55906
		// (get) Token: 0x06034040 RID: 213056 RVA: 0x007029A8 File Offset: 0x00700BA8
		public TPhoneSystemInteract InteractTypeType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TPhoneSystemInteract.NONE;
				}
				return (TPhoneSystemInteract)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06034041 RID: 213057 RVA: 0x007029E4 File Offset: 0x00700BE4
		public TTable? InteractType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06034042 RID: 213058 RVA: 0x00702A28 File Offset: 0x00700C28
		public IDeletePhoneMessage InteractTypeAsIDeletePhoneMessage()
		{
			return this.InteractType<IDeletePhoneMessage>().Value;
		}

		// Token: 0x06034043 RID: 213059 RVA: 0x00702A44 File Offset: 0x00700C44
		public IFlowOpenPhoneMessage InteractTypeAsIFlowOpenPhoneMessage()
		{
			return this.InteractType<IFlowOpenPhoneMessage>().Value;
		}

		// Token: 0x06034044 RID: 213060 RVA: 0x00702A60 File Offset: 0x00700C60
		public IOpenPhoneMessageBoard InteractTypeAsIOpenPhoneMessageBoard()
		{
			return this.InteractType<IOpenPhoneMessageBoard>().Value;
		}

		// Token: 0x06034045 RID: 213061 RVA: 0x00702A7C File Offset: 0x00700C7C
		public ISendPhoneMessage InteractTypeAsISendPhoneMessage()
		{
			return this.InteractType<ISendPhoneMessage>().Value;
		}

		// Token: 0x06034046 RID: 213062 RVA: 0x00702A97 File Offset: 0x00700C97
		public static Offset<IPhoneSystemInteract> CreateIPhoneSystemInteract(FlatBufferBuilder builder, TPhoneSystemInteract InteractType_type = TPhoneSystemInteract.NONE, int InteractTypeOffset = 0)
		{
			builder.StartTable(2);
			IPhoneSystemInteract.AddInteractType(builder, InteractTypeOffset);
			IPhoneSystemInteract.AddInteractTypeType(builder, InteractType_type);
			return IPhoneSystemInteract.EndIPhoneSystemInteract(builder);
		}

		// Token: 0x06034047 RID: 213063 RVA: 0x00702AB4 File Offset: 0x00700CB4
		public static void StartIPhoneSystemInteract(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06034048 RID: 213064 RVA: 0x00702ABD File Offset: 0x00700CBD
		public static void AddInteractTypeType(FlatBufferBuilder builder, TPhoneSystemInteract interactTypeType)
		{
			builder.AddByte(0, (byte)interactTypeType, 0);
		}

		// Token: 0x06034049 RID: 213065 RVA: 0x00702AC8 File Offset: 0x00700CC8
		public static void AddInteractType(FlatBufferBuilder builder, int interactTypeOffset)
		{
			builder.AddOffset(1, interactTypeOffset, 0);
		}

		// Token: 0x0603404A RID: 213066 RVA: 0x00702AD3 File Offset: 0x00700CD3
		public static Offset<IPhoneSystemInteract> EndIPhoneSystemInteract(FlatBufferBuilder builder)
		{
			return new Offset<IPhoneSystemInteract>(builder.EndTable());
		}

		// Token: 0x0603404B RID: 213067 RVA: 0x00702AE0 File Offset: 0x00700CE0
		public IPhoneSystemInteractT UnPack()
		{
			IPhoneSystemInteractT phoneSystemInteractT = new IPhoneSystemInteractT();
			this.UnPackTo(phoneSystemInteractT);
			return phoneSystemInteractT;
		}

		// Token: 0x0603404C RID: 213068 RVA: 0x00702AFC File Offset: 0x00700CFC
		public void UnPackTo(IPhoneSystemInteractT _o)
		{
			_o.InteractType = new TPhoneSystemInteractUnion();
			_o.InteractType.Type = this.InteractTypeType;
			switch (this.InteractTypeType)
			{
			case TPhoneSystemInteract.IDeletePhoneMessage:
				_o.InteractType.Value = ((this.InteractType<IDeletePhoneMessage>() != null) ? this.InteractType<IDeletePhoneMessage>().Value.UnPack() : null);
				return;
			case TPhoneSystemInteract.IFlowOpenPhoneMessage:
				_o.InteractType.Value = ((this.InteractType<IFlowOpenPhoneMessage>() != null) ? this.InteractType<IFlowOpenPhoneMessage>().Value.UnPack() : null);
				return;
			case TPhoneSystemInteract.IOpenPhoneMessageBoard:
				_o.InteractType.Value = ((this.InteractType<IOpenPhoneMessageBoard>() != null) ? this.InteractType<IOpenPhoneMessageBoard>().Value.UnPack() : null);
				return;
			case TPhoneSystemInteract.ISendPhoneMessage:
				_o.InteractType.Value = ((this.InteractType<ISendPhoneMessage>() != null) ? this.InteractType<ISendPhoneMessage>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x0603404D RID: 213069 RVA: 0x00702C20 File Offset: 0x00700E20
		public static Offset<IPhoneSystemInteract> Pack(FlatBufferBuilder builder, IPhoneSystemInteractT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPhoneSystemInteract>);
			}
			TPhoneSystemInteract interactType_type = (_o.InteractType == null) ? TPhoneSystemInteract.NONE : _o.InteractType.Type;
			int interactTypeOffset = (_o.InteractType == null) ? 0 : TPhoneSystemInteractUnion.Pack(builder, _o.InteractType);
			return IPhoneSystemInteract.CreateIPhoneSystemInteract(builder, interactType_type, interactTypeOffset);
		}

		// Token: 0x04012575 RID: 75125
		private Table __p;
	}
}
