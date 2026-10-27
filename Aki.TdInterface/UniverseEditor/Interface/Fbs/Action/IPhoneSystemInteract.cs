using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CAB RID: 27819
	public struct IPhoneSystemInteract : IFlatbufferObject
	{
		// Token: 0x1700CF24 RID: 53028
		// (get) Token: 0x06031063 RID: 200803 RVA: 0x006A7708 File Offset: 0x006A5908
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031064 RID: 200804 RVA: 0x006A7715 File Offset: 0x006A5915
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031065 RID: 200805 RVA: 0x006A771C File Offset: 0x006A591C
		public static IPhoneSystemInteract GetRootAsIPhoneSystemInteract(ByteBuffer _bb)
		{
			return IPhoneSystemInteract.GetRootAsIPhoneSystemInteract(_bb, default(IPhoneSystemInteract));
		}

		// Token: 0x06031066 RID: 200806 RVA: 0x006A7738 File Offset: 0x006A5938
		public static IPhoneSystemInteract GetRootAsIPhoneSystemInteract(ByteBuffer _bb, IPhoneSystemInteract obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031067 RID: 200807 RVA: 0x006A7755 File Offset: 0x006A5955
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031068 RID: 200808 RVA: 0x006A7764 File Offset: 0x006A5964
		public IPhoneSystemInteract __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CF25 RID: 53029
		// (get) Token: 0x06031069 RID: 200809 RVA: 0x006A7774 File Offset: 0x006A5974
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

		// Token: 0x0603106A RID: 200810 RVA: 0x006A77B0 File Offset: 0x006A59B0
		public TTable? InteractType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0603106B RID: 200811 RVA: 0x006A77F4 File Offset: 0x006A59F4
		public IDeletePhoneMessage InteractTypeAsIDeletePhoneMessage()
		{
			return this.InteractType<IDeletePhoneMessage>().Value;
		}

		// Token: 0x0603106C RID: 200812 RVA: 0x006A7810 File Offset: 0x006A5A10
		public IFlowOpenPhoneMessage InteractTypeAsIFlowOpenPhoneMessage()
		{
			return this.InteractType<IFlowOpenPhoneMessage>().Value;
		}

		// Token: 0x0603106D RID: 200813 RVA: 0x006A782C File Offset: 0x006A5A2C
		public IOpenPhoneMessageBoard InteractTypeAsIOpenPhoneMessageBoard()
		{
			return this.InteractType<IOpenPhoneMessageBoard>().Value;
		}

		// Token: 0x0603106E RID: 200814 RVA: 0x006A7848 File Offset: 0x006A5A48
		public ISendPhoneMessage InteractTypeAsISendPhoneMessage()
		{
			return this.InteractType<ISendPhoneMessage>().Value;
		}

		// Token: 0x0603106F RID: 200815 RVA: 0x006A7863 File Offset: 0x006A5A63
		public static Offset<IPhoneSystemInteract> CreateIPhoneSystemInteract(FlatBufferBuilder builder, TPhoneSystemInteract InteractType_type = TPhoneSystemInteract.NONE, int InteractTypeOffset = 0)
		{
			builder.StartTable(2);
			IPhoneSystemInteract.AddInteractType(builder, InteractTypeOffset);
			IPhoneSystemInteract.AddInteractTypeType(builder, InteractType_type);
			return IPhoneSystemInteract.EndIPhoneSystemInteract(builder);
		}

		// Token: 0x06031070 RID: 200816 RVA: 0x006A7880 File Offset: 0x006A5A80
		public static void StartIPhoneSystemInteract(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06031071 RID: 200817 RVA: 0x006A7889 File Offset: 0x006A5A89
		public static void AddInteractTypeType(FlatBufferBuilder builder, TPhoneSystemInteract interactTypeType)
		{
			builder.AddByte(0, (byte)interactTypeType, 0);
		}

		// Token: 0x06031072 RID: 200818 RVA: 0x006A7894 File Offset: 0x006A5A94
		public static void AddInteractType(FlatBufferBuilder builder, int interactTypeOffset)
		{
			builder.AddOffset(1, interactTypeOffset, 0);
		}

		// Token: 0x06031073 RID: 200819 RVA: 0x006A789F File Offset: 0x006A5A9F
		public static Offset<IPhoneSystemInteract> EndIPhoneSystemInteract(FlatBufferBuilder builder)
		{
			return new Offset<IPhoneSystemInteract>(builder.EndTable());
		}

		// Token: 0x06031074 RID: 200820 RVA: 0x006A78AC File Offset: 0x006A5AAC
		public IPhoneSystemInteractT UnPack()
		{
			IPhoneSystemInteractT phoneSystemInteractT = new IPhoneSystemInteractT();
			this.UnPackTo(phoneSystemInteractT);
			return phoneSystemInteractT;
		}

		// Token: 0x06031075 RID: 200821 RVA: 0x006A78C8 File Offset: 0x006A5AC8
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

		// Token: 0x06031076 RID: 200822 RVA: 0x006A79EC File Offset: 0x006A5BEC
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

		// Token: 0x04011605 RID: 71173
		private Table __p;
	}
}
