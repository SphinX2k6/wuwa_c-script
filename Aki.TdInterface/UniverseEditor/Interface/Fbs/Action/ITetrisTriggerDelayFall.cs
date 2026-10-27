using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073CD RID: 29645
	public struct ITetrisTriggerDelayFall : IFlatbufferObject
	{
		// Token: 0x1700E12E RID: 57646
		// (get) Token: 0x06035D8B RID: 220555 RVA: 0x00754657 File Offset: 0x00752857
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035D8C RID: 220556 RVA: 0x00754664 File Offset: 0x00752864
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035D8D RID: 220557 RVA: 0x0075466C File Offset: 0x0075286C
		public static ITetrisTriggerDelayFall GetRootAsITetrisTriggerDelayFall(ByteBuffer _bb)
		{
			return ITetrisTriggerDelayFall.GetRootAsITetrisTriggerDelayFall(_bb, default(ITetrisTriggerDelayFall));
		}

		// Token: 0x06035D8E RID: 220558 RVA: 0x00754688 File Offset: 0x00752888
		public static ITetrisTriggerDelayFall GetRootAsITetrisTriggerDelayFall(ByteBuffer _bb, ITetrisTriggerDelayFall obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035D8F RID: 220559 RVA: 0x007546A5 File Offset: 0x007528A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035D90 RID: 220560 RVA: 0x007546B4 File Offset: 0x007528B4
		public ITetrisTriggerDelayFall __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06035D91 RID: 220561 RVA: 0x007546C4 File Offset: 0x007528C4
		public static void StartITetrisTriggerDelayFall(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x06035D92 RID: 220562 RVA: 0x007546CD File Offset: 0x007528CD
		public static Offset<ITetrisTriggerDelayFall> EndITetrisTriggerDelayFall(FlatBufferBuilder builder)
		{
			return new Offset<ITetrisTriggerDelayFall>(builder.EndTable());
		}

		// Token: 0x06035D93 RID: 220563 RVA: 0x007546DC File Offset: 0x007528DC
		public ITetrisTriggerDelayFallT UnPack()
		{
			ITetrisTriggerDelayFallT tetrisTriggerDelayFallT = new ITetrisTriggerDelayFallT();
			this.UnPackTo(tetrisTriggerDelayFallT);
			return tetrisTriggerDelayFallT;
		}

		// Token: 0x06035D94 RID: 220564 RVA: 0x007546F7 File Offset: 0x007528F7
		public void UnPackTo(ITetrisTriggerDelayFallT _o)
		{
		}

		// Token: 0x06035D95 RID: 220565 RVA: 0x007546FC File Offset: 0x007528FC
		public static Offset<ITetrisTriggerDelayFall> Pack(FlatBufferBuilder builder, ITetrisTriggerDelayFallT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITetrisTriggerDelayFall>);
			}
			ITetrisTriggerDelayFall.StartITetrisTriggerDelayFall(builder);
			return ITetrisTriggerDelayFall.EndITetrisTriggerDelayFall(builder);
		}

		// Token: 0x04012218 RID: 74264
		private Table __p;
	}
}
