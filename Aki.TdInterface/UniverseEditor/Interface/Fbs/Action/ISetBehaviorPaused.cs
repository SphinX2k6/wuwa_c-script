using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007795 RID: 30613
	public struct ISetBehaviorPaused : IFlatbufferObject
	{
		// Token: 0x1700E04C RID: 57420
		// (get) Token: 0x06035BBE RID: 220094 RVA: 0x00733149 File Offset: 0x00731349
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035BBF RID: 220095 RVA: 0x00733156 File Offset: 0x00731356
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Struct(_i, _bb);
		}

		// Token: 0x06035BC0 RID: 220096 RVA: 0x00733165 File Offset: 0x00731365
		public ISetBehaviorPaused __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E04D RID: 57421
		// (get) Token: 0x06035BC1 RID: 220097 RVA: 0x00733175 File Offset: 0x00731375
		public bool IsPaused
		{
			get
			{
				return this.__p.bb.Get(this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06035BC2 RID: 220098 RVA: 0x00733195 File Offset: 0x00731395
		public static Offset<ISetBehaviorPaused> CreateISetBehaviorPaused(FlatBufferBuilder builder, bool IsPaused)
		{
			builder.Prep(1, 1);
			builder.PutBool(IsPaused);
			return new Offset<ISetBehaviorPaused>(builder.Offset);
		}

		// Token: 0x06035BC3 RID: 220099 RVA: 0x007331B4 File Offset: 0x007313B4
		public ISetBehaviorPausedT UnPack()
		{
			ISetBehaviorPausedT setBehaviorPausedT = new ISetBehaviorPausedT();
			this.UnPackTo(setBehaviorPausedT);
			return setBehaviorPausedT;
		}

		// Token: 0x06035BC4 RID: 220100 RVA: 0x007331CF File Offset: 0x007313CF
		public void UnPackTo(ISetBehaviorPausedT _o)
		{
			_o.IsPaused = this.IsPaused;
		}

		// Token: 0x06035BC5 RID: 220101 RVA: 0x007331E0 File Offset: 0x007313E0
		public static Offset<ISetBehaviorPaused> Pack(FlatBufferBuilder builder, ISetBehaviorPausedT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetBehaviorPaused>);
			}
			return ISetBehaviorPaused.CreateISetBehaviorPaused(builder, _o.IsPaused);
		}

		// Token: 0x040129BB RID: 76219
		private Struct __p;
	}
}
