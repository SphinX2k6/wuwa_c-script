using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007BB4 RID: 31668
	public struct ITetrisTriggerDelayFall : IFlatbufferObject
	{
		// Token: 0x1700ED3E RID: 60734
		// (get) Token: 0x06039126 RID: 233766 RVA: 0x007B6B97 File Offset: 0x007B4D97
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039127 RID: 233767 RVA: 0x007B6BA4 File Offset: 0x007B4DA4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039128 RID: 233768 RVA: 0x007B6BAC File Offset: 0x007B4DAC
		public static ITetrisTriggerDelayFall GetRootAsITetrisTriggerDelayFall(ByteBuffer _bb)
		{
			return ITetrisTriggerDelayFall.GetRootAsITetrisTriggerDelayFall(_bb, default(ITetrisTriggerDelayFall));
		}

		// Token: 0x06039129 RID: 233769 RVA: 0x007B6BC8 File Offset: 0x007B4DC8
		public static ITetrisTriggerDelayFall GetRootAsITetrisTriggerDelayFall(ByteBuffer _bb, ITetrisTriggerDelayFall obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603912A RID: 233770 RVA: 0x007B6BE5 File Offset: 0x007B4DE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603912B RID: 233771 RVA: 0x007B6BF4 File Offset: 0x007B4DF4
		public ITetrisTriggerDelayFall __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0603912C RID: 233772 RVA: 0x007B6C04 File Offset: 0x007B4E04
		public static void StartITetrisTriggerDelayFall(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x0603912D RID: 233773 RVA: 0x007B6C0D File Offset: 0x007B4E0D
		public static Offset<ITetrisTriggerDelayFall> EndITetrisTriggerDelayFall(FlatBufferBuilder builder)
		{
			return new Offset<ITetrisTriggerDelayFall>(builder.EndTable());
		}

		// Token: 0x0603912E RID: 233774 RVA: 0x007B6C1C File Offset: 0x007B4E1C
		public ITetrisTriggerDelayFallT UnPack()
		{
			ITetrisTriggerDelayFallT tetrisTriggerDelayFallT = new ITetrisTriggerDelayFallT();
			this.UnPackTo(tetrisTriggerDelayFallT);
			return tetrisTriggerDelayFallT;
		}

		// Token: 0x0603912F RID: 233775 RVA: 0x007B6C37 File Offset: 0x007B4E37
		public void UnPackTo(ITetrisTriggerDelayFallT _o)
		{
		}

		// Token: 0x06039130 RID: 233776 RVA: 0x007B6C3C File Offset: 0x007B4E3C
		public static Offset<ITetrisTriggerDelayFall> Pack(FlatBufferBuilder builder, ITetrisTriggerDelayFallT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITetrisTriggerDelayFall>);
			}
			ITetrisTriggerDelayFall.StartITetrisTriggerDelayFall(builder);
			return ITetrisTriggerDelayFall.EndITetrisTriggerDelayFall(builder);
		}

		// Token: 0x04013231 RID: 78385
		private Table __p;
	}
}
