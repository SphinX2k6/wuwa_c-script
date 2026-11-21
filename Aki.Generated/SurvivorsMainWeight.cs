using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001234 RID: 4660
	public struct SurvivorsMainWeight : IFlatbufferObject
	{
		// Token: 0x17003C38 RID: 15416
		// (get) Token: 0x0600E816 RID: 59414 RVA: 0x0034FD46 File Offset: 0x0034DF46
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E817 RID: 59415 RVA: 0x0034FD53 File Offset: 0x0034DF53
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E818 RID: 59416 RVA: 0x0034FD5C File Offset: 0x0034DF5C
		public static SurvivorsMainWeight GetRootAsSurvivorsMainWeight(ByteBuffer _bb)
		{
			return SurvivorsMainWeight.GetRootAsSurvivorsMainWeight(_bb, default(SurvivorsMainWeight));
		}

		// Token: 0x0600E819 RID: 59417 RVA: 0x0034FD78 File Offset: 0x0034DF78
		public static SurvivorsMainWeight GetRootAsSurvivorsMainWeight(ByteBuffer _bb, SurvivorsMainWeight obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E81A RID: 59418 RVA: 0x0034FD95 File Offset: 0x0034DF95
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E81B RID: 59419 RVA: 0x0034FDA4 File Offset: 0x0034DFA4
		public SurvivorsMainWeight __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003C39 RID: 15417
		// (get) Token: 0x0600E81C RID: 59420 RVA: 0x0034FDB4 File Offset: 0x0034DFB4
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

		// Token: 0x17003C3A RID: 15418
		// (get) Token: 0x0600E81D RID: 59421 RVA: 0x0034FDF0 File Offset: 0x0034DFF0
		public int WeaponId
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

		// Token: 0x04005879 RID: 22649
		private Table __p;
	}
}
