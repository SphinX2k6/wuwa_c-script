using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001321 RID: 4897
	public struct TetrisBombConfig : IFlatbufferObject
	{
		// Token: 0x170042BB RID: 17083
		// (get) Token: 0x0600F954 RID: 63828 RVA: 0x00375E70 File Offset: 0x00374070
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F955 RID: 63829 RVA: 0x00375E7D File Offset: 0x0037407D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F956 RID: 63830 RVA: 0x00375E84 File Offset: 0x00374084
		public static TetrisBombConfig GetRootAsTetrisBombConfig(ByteBuffer _bb)
		{
			return TetrisBombConfig.GetRootAsTetrisBombConfig(_bb, default(TetrisBombConfig));
		}

		// Token: 0x0600F957 RID: 63831 RVA: 0x00375EA0 File Offset: 0x003740A0
		public static TetrisBombConfig GetRootAsTetrisBombConfig(ByteBuffer _bb, TetrisBombConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F958 RID: 63832 RVA: 0x00375EBD File Offset: 0x003740BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F959 RID: 63833 RVA: 0x00375ECC File Offset: 0x003740CC
		public TetrisBombConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170042BC RID: 17084
		// (get) Token: 0x0600F95A RID: 63834 RVA: 0x00375EDC File Offset: 0x003740DC
		public int BombProbability
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170042BD RID: 17085
		// (get) Token: 0x0600F95B RID: 63835 RVA: 0x00375F18 File Offset: 0x00374118
		public int SuperBombProbability
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

		// Token: 0x170042BE RID: 17086
		// (get) Token: 0x0600F95C RID: 63836 RVA: 0x00375F54 File Offset: 0x00374154
		public int AllBombProbability
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x040059A7 RID: 22951
		private Table __p;
	}
}
