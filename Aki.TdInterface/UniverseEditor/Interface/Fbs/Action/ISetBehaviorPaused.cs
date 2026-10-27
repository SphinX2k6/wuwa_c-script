using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FCC RID: 28620
	public struct ISetBehaviorPaused : IFlatbufferObject
	{
		// Token: 0x1700D478 RID: 54392
		// (get) Token: 0x06032958 RID: 207192 RVA: 0x006D3505 File Offset: 0x006D1705
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032959 RID: 207193 RVA: 0x006D3512 File Offset: 0x006D1712
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Struct(_i, _bb);
		}

		// Token: 0x0603295A RID: 207194 RVA: 0x006D3521 File Offset: 0x006D1721
		public ISetBehaviorPaused __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D479 RID: 54393
		// (get) Token: 0x0603295B RID: 207195 RVA: 0x006D3531 File Offset: 0x006D1731
		public bool IsPaused
		{
			get
			{
				return this.__p.bb.Get(this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0603295C RID: 207196 RVA: 0x006D3551 File Offset: 0x006D1751
		public static Offset<ISetBehaviorPaused> CreateISetBehaviorPaused(FlatBufferBuilder builder, bool IsPaused)
		{
			builder.Prep(1, 1);
			builder.PutBool(IsPaused);
			return new Offset<ISetBehaviorPaused>(builder.Offset);
		}

		// Token: 0x0603295D RID: 207197 RVA: 0x006D3570 File Offset: 0x006D1770
		public ISetBehaviorPausedT UnPack()
		{
			ISetBehaviorPausedT setBehaviorPausedT = new ISetBehaviorPausedT();
			this.UnPackTo(setBehaviorPausedT);
			return setBehaviorPausedT;
		}

		// Token: 0x0603295E RID: 207198 RVA: 0x006D358B File Offset: 0x006D178B
		public void UnPackTo(ISetBehaviorPausedT _o)
		{
			_o.IsPaused = this.IsPaused;
		}

		// Token: 0x0603295F RID: 207199 RVA: 0x006D359C File Offset: 0x006D179C
		public static Offset<ISetBehaviorPaused> Pack(FlatBufferBuilder builder, ISetBehaviorPausedT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetBehaviorPaused>);
			}
			return ISetBehaviorPaused.CreateISetBehaviorPaused(builder, _o.IsPaused);
		}

		// Token: 0x040119D6 RID: 72150
		private Struct __p;
	}
}
