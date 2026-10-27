using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070D3 RID: 28883
	public struct IShowAllHidedGroupInFlow : IFlatbufferObject
	{
		// Token: 0x1700D686 RID: 54918
		// (get) Token: 0x06033276 RID: 209526 RVA: 0x006E5955 File Offset: 0x006E3B55
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033277 RID: 209527 RVA: 0x006E5962 File Offset: 0x006E3B62
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033278 RID: 209528 RVA: 0x006E596C File Offset: 0x006E3B6C
		public static IShowAllHidedGroupInFlow GetRootAsIShowAllHidedGroupInFlow(ByteBuffer _bb)
		{
			return IShowAllHidedGroupInFlow.GetRootAsIShowAllHidedGroupInFlow(_bb, default(IShowAllHidedGroupInFlow));
		}

		// Token: 0x06033279 RID: 209529 RVA: 0x006E5988 File Offset: 0x006E3B88
		public static IShowAllHidedGroupInFlow GetRootAsIShowAllHidedGroupInFlow(ByteBuffer _bb, IShowAllHidedGroupInFlow obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603327A RID: 209530 RVA: 0x006E59A5 File Offset: 0x006E3BA5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603327B RID: 209531 RVA: 0x006E59B4 File Offset: 0x006E3BB4
		public IShowAllHidedGroupInFlow __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0603327C RID: 209532 RVA: 0x006E59C4 File Offset: 0x006E3BC4
		public static void StartIShowAllHidedGroupInFlow(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x0603327D RID: 209533 RVA: 0x006E59CD File Offset: 0x006E3BCD
		public static Offset<IShowAllHidedGroupInFlow> EndIShowAllHidedGroupInFlow(FlatBufferBuilder builder)
		{
			return new Offset<IShowAllHidedGroupInFlow>(builder.EndTable());
		}

		// Token: 0x0603327E RID: 209534 RVA: 0x006E59DC File Offset: 0x006E3BDC
		public IShowAllHidedGroupInFlowT UnPack()
		{
			IShowAllHidedGroupInFlowT showAllHidedGroupInFlowT = new IShowAllHidedGroupInFlowT();
			this.UnPackTo(showAllHidedGroupInFlowT);
			return showAllHidedGroupInFlowT;
		}

		// Token: 0x0603327F RID: 209535 RVA: 0x006E59F7 File Offset: 0x006E3BF7
		public void UnPackTo(IShowAllHidedGroupInFlowT _o)
		{
		}

		// Token: 0x06033280 RID: 209536 RVA: 0x006E59FC File Offset: 0x006E3BFC
		public static Offset<IShowAllHidedGroupInFlow> Pack(FlatBufferBuilder builder, IShowAllHidedGroupInFlowT _o)
		{
			if (_o == null)
			{
				return default(Offset<IShowAllHidedGroupInFlow>);
			}
			IShowAllHidedGroupInFlow.StartIShowAllHidedGroupInFlow(builder);
			return IShowAllHidedGroupInFlow.EndIShowAllHidedGroupInFlow(builder);
		}

		// Token: 0x04011B3F RID: 72511
		private Table __p;
	}
}
