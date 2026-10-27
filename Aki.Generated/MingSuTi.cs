using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E0B RID: 3595
	public struct MingSuTi : IFlatbufferObject
	{
		// Token: 0x17001F11 RID: 7953
		// (get) Token: 0x0600942A RID: 37930 RVA: 0x002859A5 File Offset: 0x00283BA5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600942B RID: 37931 RVA: 0x002859B2 File Offset: 0x00283BB2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600942C RID: 37932 RVA: 0x002859BC File Offset: 0x00283BBC
		public static MingSuTi GetRootAsMingSuTi(ByteBuffer _bb)
		{
			return MingSuTi.GetRootAsMingSuTi(_bb, default(MingSuTi));
		}

		// Token: 0x0600942D RID: 37933 RVA: 0x002859D8 File Offset: 0x00283BD8
		public static MingSuTi GetRootAsMingSuTi(ByteBuffer _bb, MingSuTi obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600942E RID: 37934 RVA: 0x002859F5 File Offset: 0x00283BF5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600942F RID: 37935 RVA: 0x00285A04 File Offset: 0x00283C04
		public MingSuTi __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001F12 RID: 7954
		// (get) Token: 0x06009430 RID: 37936 RVA: 0x00285A14 File Offset: 0x00283C14
		public int Id
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

		// Token: 0x17001F13 RID: 7955
		// (get) Token: 0x06009431 RID: 37937 RVA: 0x00285A50 File Offset: 0x00283C50
		public int Type
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

		// Token: 0x04004EB0 RID: 20144
		private Table __p;
	}
}
