using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075CD RID: 30157
	public struct IRemoveFlowInteractOption : IFlatbufferObject
	{
		// Token: 0x1700DDAE RID: 56750
		// (get) Token: 0x06034E74 RID: 216692 RVA: 0x0071C095 File Offset: 0x0071A295
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034E75 RID: 216693 RVA: 0x0071C0A2 File Offset: 0x0071A2A2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034E76 RID: 216694 RVA: 0x0071C0AC File Offset: 0x0071A2AC
		public static IRemoveFlowInteractOption GetRootAsIRemoveFlowInteractOption(ByteBuffer _bb)
		{
			return IRemoveFlowInteractOption.GetRootAsIRemoveFlowInteractOption(_bb, default(IRemoveFlowInteractOption));
		}

		// Token: 0x06034E77 RID: 216695 RVA: 0x0071C0C8 File Offset: 0x0071A2C8
		public static IRemoveFlowInteractOption GetRootAsIRemoveFlowInteractOption(ByteBuffer _bb, IRemoveFlowInteractOption obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034E78 RID: 216696 RVA: 0x0071C0E5 File Offset: 0x0071A2E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034E79 RID: 216697 RVA: 0x0071C0F4 File Offset: 0x0071A2F4
		public IRemoveFlowInteractOption __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DDAF RID: 56751
		// (get) Token: 0x06034E7A RID: 216698 RVA: 0x0071C104 File Offset: 0x0071A304
		public IFlowIndex? Flow
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IFlowIndex?(default(IFlowIndex).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700DDB0 RID: 56752
		// (get) Token: 0x06034E7B RID: 216699 RVA: 0x0071C164 File Offset: 0x0071A364
		public int EntityId
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

		// Token: 0x1700DDB1 RID: 56753
		// (get) Token: 0x06034E7C RID: 216700 RVA: 0x0071C1A0 File Offset: 0x0071A3A0
		public string InteractToken
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06034E7D RID: 216701 RVA: 0x0071C1D7 File Offset: 0x0071A3D7
		public Span<byte> GetInteractTokenBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06034E7E RID: 216702 RVA: 0x0071C1E6 File Offset: 0x0071A3E6
		public byte[] GetInteractTokenArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x06034E7F RID: 216703 RVA: 0x0071C1F4 File Offset: 0x0071A3F4
		public static Offset<IRemoveFlowInteractOption> CreateIRemoveFlowInteractOption(FlatBufferBuilder builder, Offset<IFlowIndex> FlowOffset = default(Offset<IFlowIndex>), int EntityId = 0, StringOffset InteractTokenOffset = default(StringOffset))
		{
			builder.StartTable(3);
			IRemoveFlowInteractOption.AddInteractToken(builder, InteractTokenOffset);
			IRemoveFlowInteractOption.AddEntityId(builder, EntityId);
			IRemoveFlowInteractOption.AddFlow(builder, FlowOffset);
			return IRemoveFlowInteractOption.EndIRemoveFlowInteractOption(builder);
		}

		// Token: 0x06034E80 RID: 216704 RVA: 0x0071C218 File Offset: 0x0071A418
		public static void StartIRemoveFlowInteractOption(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06034E81 RID: 216705 RVA: 0x0071C221 File Offset: 0x0071A421
		public static void AddFlow(FlatBufferBuilder builder, Offset<IFlowIndex> flowOffset)
		{
			builder.AddOffset(0, flowOffset.Value, 0);
		}

		// Token: 0x06034E82 RID: 216706 RVA: 0x0071C231 File Offset: 0x0071A431
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x06034E83 RID: 216707 RVA: 0x0071C23C File Offset: 0x0071A43C
		public static void AddInteractToken(FlatBufferBuilder builder, StringOffset interactTokenOffset)
		{
			builder.AddOffset(2, interactTokenOffset.Value, 0);
		}

		// Token: 0x06034E84 RID: 216708 RVA: 0x0071C24C File Offset: 0x0071A44C
		public static Offset<IRemoveFlowInteractOption> EndIRemoveFlowInteractOption(FlatBufferBuilder builder)
		{
			return new Offset<IRemoveFlowInteractOption>(builder.EndTable());
		}

		// Token: 0x06034E85 RID: 216709 RVA: 0x0071C25C File Offset: 0x0071A45C
		public IRemoveFlowInteractOptionT UnPack()
		{
			IRemoveFlowInteractOptionT removeFlowInteractOptionT = new IRemoveFlowInteractOptionT();
			this.UnPackTo(removeFlowInteractOptionT);
			return removeFlowInteractOptionT;
		}

		// Token: 0x06034E86 RID: 216710 RVA: 0x0071C278 File Offset: 0x0071A478
		public void UnPackTo(IRemoveFlowInteractOptionT _o)
		{
			_o.Flow = ((this.Flow != null) ? this.Flow.Value.UnPack() : null);
			_o.EntityId = this.EntityId;
			_o.InteractToken = this.InteractToken;
		}

		// Token: 0x06034E87 RID: 216711 RVA: 0x0071C2CC File Offset: 0x0071A4CC
		public static Offset<IRemoveFlowInteractOption> Pack(FlatBufferBuilder builder, IRemoveFlowInteractOptionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRemoveFlowInteractOption>);
			}
			Offset<IFlowIndex> flowOffset = (_o.Flow == null) ? default(Offset<IFlowIndex>) : IFlowIndex.Pack(builder, _o.Flow);
			StringOffset interactTokenOffset = (_o.InteractToken == null) ? default(StringOffset) : builder.CreateString(_o.InteractToken);
			return IRemoveFlowInteractOption.CreateIRemoveFlowInteractOption(builder, flowOffset, _o.EntityId, interactTokenOffset);
		}

		// Token: 0x040127B4 RID: 75700
		private Table __p;
	}
}
