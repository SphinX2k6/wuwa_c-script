using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E4C RID: 28236
	public struct IRemoveFlowInteractOption : IFlatbufferObject
	{
		// Token: 0x1700D25C RID: 53852
		// (get) Token: 0x06031E4C RID: 204364 RVA: 0x006C0596 File Offset: 0x006BE796
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031E4D RID: 204365 RVA: 0x006C05A3 File Offset: 0x006BE7A3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031E4E RID: 204366 RVA: 0x006C05AC File Offset: 0x006BE7AC
		public static IRemoveFlowInteractOption GetRootAsIRemoveFlowInteractOption(ByteBuffer _bb)
		{
			return IRemoveFlowInteractOption.GetRootAsIRemoveFlowInteractOption(_bb, default(IRemoveFlowInteractOption));
		}

		// Token: 0x06031E4F RID: 204367 RVA: 0x006C05C8 File Offset: 0x006BE7C8
		public static IRemoveFlowInteractOption GetRootAsIRemoveFlowInteractOption(ByteBuffer _bb, IRemoveFlowInteractOption obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031E50 RID: 204368 RVA: 0x006C05E5 File Offset: 0x006BE7E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031E51 RID: 204369 RVA: 0x006C05F4 File Offset: 0x006BE7F4
		public IRemoveFlowInteractOption __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D25D RID: 53853
		// (get) Token: 0x06031E52 RID: 204370 RVA: 0x006C0604 File Offset: 0x006BE804
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

		// Token: 0x1700D25E RID: 53854
		// (get) Token: 0x06031E53 RID: 204371 RVA: 0x006C0664 File Offset: 0x006BE864
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

		// Token: 0x1700D25F RID: 53855
		// (get) Token: 0x06031E54 RID: 204372 RVA: 0x006C06A0 File Offset: 0x006BE8A0
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

		// Token: 0x06031E55 RID: 204373 RVA: 0x006C06D7 File Offset: 0x006BE8D7
		public Span<byte> GetInteractTokenBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06031E56 RID: 204374 RVA: 0x006C06E6 File Offset: 0x006BE8E6
		public byte[] GetInteractTokenArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x06031E57 RID: 204375 RVA: 0x006C06F4 File Offset: 0x006BE8F4
		public static Offset<IRemoveFlowInteractOption> CreateIRemoveFlowInteractOption(FlatBufferBuilder builder, Offset<IFlowIndex> FlowOffset = default(Offset<IFlowIndex>), int EntityId = 0, StringOffset InteractTokenOffset = default(StringOffset))
		{
			builder.StartTable(3);
			IRemoveFlowInteractOption.AddInteractToken(builder, InteractTokenOffset);
			IRemoveFlowInteractOption.AddEntityId(builder, EntityId);
			IRemoveFlowInteractOption.AddFlow(builder, FlowOffset);
			return IRemoveFlowInteractOption.EndIRemoveFlowInteractOption(builder);
		}

		// Token: 0x06031E58 RID: 204376 RVA: 0x006C0718 File Offset: 0x006BE918
		public static void StartIRemoveFlowInteractOption(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06031E59 RID: 204377 RVA: 0x006C0721 File Offset: 0x006BE921
		public static void AddFlow(FlatBufferBuilder builder, Offset<IFlowIndex> flowOffset)
		{
			builder.AddOffset(0, flowOffset.Value, 0);
		}

		// Token: 0x06031E5A RID: 204378 RVA: 0x006C0731 File Offset: 0x006BE931
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x06031E5B RID: 204379 RVA: 0x006C073C File Offset: 0x006BE93C
		public static void AddInteractToken(FlatBufferBuilder builder, StringOffset interactTokenOffset)
		{
			builder.AddOffset(2, interactTokenOffset.Value, 0);
		}

		// Token: 0x06031E5C RID: 204380 RVA: 0x006C074C File Offset: 0x006BE94C
		public static Offset<IRemoveFlowInteractOption> EndIRemoveFlowInteractOption(FlatBufferBuilder builder)
		{
			return new Offset<IRemoveFlowInteractOption>(builder.EndTable());
		}

		// Token: 0x06031E5D RID: 204381 RVA: 0x006C075C File Offset: 0x006BE95C
		public IRemoveFlowInteractOptionT UnPack()
		{
			IRemoveFlowInteractOptionT removeFlowInteractOptionT = new IRemoveFlowInteractOptionT();
			this.UnPackTo(removeFlowInteractOptionT);
			return removeFlowInteractOptionT;
		}

		// Token: 0x06031E5E RID: 204382 RVA: 0x006C0778 File Offset: 0x006BE978
		public void UnPackTo(IRemoveFlowInteractOptionT _o)
		{
			_o.Flow = ((this.Flow != null) ? this.Flow.Value.UnPack() : null);
			_o.EntityId = this.EntityId;
			_o.InteractToken = this.InteractToken;
		}

		// Token: 0x06031E5F RID: 204383 RVA: 0x006C07CC File Offset: 0x006BE9CC
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

		// Token: 0x04011832 RID: 71730
		private Table __p;
	}
}
