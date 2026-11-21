using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200789F RID: 30879
	public struct IShowAllHidedGroupInFlow : IFlatbufferObject
	{
		// Token: 0x1700E269 RID: 57961
		// (get) Token: 0x06036518 RID: 222488 RVA: 0x00745F61 File Offset: 0x00744161
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036519 RID: 222489 RVA: 0x00745F6E File Offset: 0x0074416E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603651A RID: 222490 RVA: 0x00745F78 File Offset: 0x00744178
		public static IShowAllHidedGroupInFlow GetRootAsIShowAllHidedGroupInFlow(ByteBuffer _bb)
		{
			return IShowAllHidedGroupInFlow.GetRootAsIShowAllHidedGroupInFlow(_bb, default(IShowAllHidedGroupInFlow));
		}

		// Token: 0x0603651B RID: 222491 RVA: 0x00745F94 File Offset: 0x00744194
		public static IShowAllHidedGroupInFlow GetRootAsIShowAllHidedGroupInFlow(ByteBuffer _bb, IShowAllHidedGroupInFlow obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603651C RID: 222492 RVA: 0x00745FB1 File Offset: 0x007441B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603651D RID: 222493 RVA: 0x00745FC0 File Offset: 0x007441C0
		public IShowAllHidedGroupInFlow __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0603651E RID: 222494 RVA: 0x00745FD0 File Offset: 0x007441D0
		public static void StartIShowAllHidedGroupInFlow(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x0603651F RID: 222495 RVA: 0x00745FD9 File Offset: 0x007441D9
		public static Offset<IShowAllHidedGroupInFlow> EndIShowAllHidedGroupInFlow(FlatBufferBuilder builder)
		{
			return new Offset<IShowAllHidedGroupInFlow>(builder.EndTable());
		}

		// Token: 0x06036520 RID: 222496 RVA: 0x00745FE8 File Offset: 0x007441E8
		public IShowAllHidedGroupInFlowT UnPack()
		{
			IShowAllHidedGroupInFlowT showAllHidedGroupInFlowT = new IShowAllHidedGroupInFlowT();
			this.UnPackTo(showAllHidedGroupInFlowT);
			return showAllHidedGroupInFlowT;
		}

		// Token: 0x06036521 RID: 222497 RVA: 0x00746003 File Offset: 0x00744203
		public void UnPackTo(IShowAllHidedGroupInFlowT _o)
		{
		}

		// Token: 0x06036522 RID: 222498 RVA: 0x00746008 File Offset: 0x00744208
		public static Offset<IShowAllHidedGroupInFlow> Pack(FlatBufferBuilder builder, IShowAllHidedGroupInFlowT _o)
		{
			if (_o == null)
			{
				return default(Offset<IShowAllHidedGroupInFlow>);
			}
			IShowAllHidedGroupInFlow.StartIShowAllHidedGroupInFlow(builder);
			return IShowAllHidedGroupInFlow.EndIShowAllHidedGroupInFlow(builder);
		}

		// Token: 0x04012B2D RID: 76589
		private Table __p;
	}
}
