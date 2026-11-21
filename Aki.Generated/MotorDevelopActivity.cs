using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F1B RID: 3867
	public struct MotorDevelopActivity : IFlatbufferObject
	{
		// Token: 0x170020BA RID: 8378
		// (get) Token: 0x06009D92 RID: 40338 RVA: 0x002AA642 File Offset: 0x002A8842
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009D93 RID: 40339 RVA: 0x002AA64F File Offset: 0x002A884F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009D94 RID: 40340 RVA: 0x002AA658 File Offset: 0x002A8858
		public static MotorDevelopActivity GetRootAsMotorDevelopActivity(ByteBuffer _bb)
		{
			return MotorDevelopActivity.GetRootAsMotorDevelopActivity(_bb, default(MotorDevelopActivity));
		}

		// Token: 0x06009D95 RID: 40341 RVA: 0x002AA674 File Offset: 0x002A8874
		public static MotorDevelopActivity GetRootAsMotorDevelopActivity(ByteBuffer _bb, MotorDevelopActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009D96 RID: 40342 RVA: 0x002AA691 File Offset: 0x002A8891
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009D97 RID: 40343 RVA: 0x002AA6A0 File Offset: 0x002A88A0
		public MotorDevelopActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170020BB RID: 8379
		// (get) Token: 0x06009D98 RID: 40344 RVA: 0x002AA6B0 File Offset: 0x002A88B0
		public int ActivityId
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

		// Token: 0x170020BC RID: 8380
		// (get) Token: 0x06009D99 RID: 40345 RVA: 0x002AA6EC File Offset: 0x002A88EC
		public int SkillTreeId
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

		// Token: 0x040054C1 RID: 21697
		private Table __p;
	}
}
