using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001081 RID: 4225
	public struct RealmBetweenConfig : IFlatbufferObject
	{
		// Token: 0x17002D91 RID: 11665
		// (get) Token: 0x0600BF86 RID: 49030 RVA: 0x002F4795 File Offset: 0x002F2995
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BF87 RID: 49031 RVA: 0x002F47A2 File Offset: 0x002F29A2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BF88 RID: 49032 RVA: 0x002F47AC File Offset: 0x002F29AC
		public static RealmBetweenConfig GetRootAsRealmBetweenConfig(ByteBuffer _bb)
		{
			return RealmBetweenConfig.GetRootAsRealmBetweenConfig(_bb, default(RealmBetweenConfig));
		}

		// Token: 0x0600BF89 RID: 49033 RVA: 0x002F47C8 File Offset: 0x002F29C8
		public static RealmBetweenConfig GetRootAsRealmBetweenConfig(ByteBuffer _bb, RealmBetweenConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BF8A RID: 49034 RVA: 0x002F47E5 File Offset: 0x002F29E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BF8B RID: 49035 RVA: 0x002F47F4 File Offset: 0x002F29F4
		public RealmBetweenConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002D92 RID: 11666
		// (get) Token: 0x0600BF8C RID: 49036 RVA: 0x002F4804 File Offset: 0x002F2A04
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

		// Token: 0x17002D93 RID: 11667
		// (get) Token: 0x0600BF8D RID: 49037 RVA: 0x002F4840 File Offset: 0x002F2A40
		public int MaxLevel
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

		// Token: 0x17002D94 RID: 11668
		// (get) Token: 0x0600BF8E RID: 49038 RVA: 0x002F487C File Offset: 0x002F2A7C
		public int ExpItemId
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

		// Token: 0x17002D95 RID: 11669
		// (get) Token: 0x0600BF8F RID: 49039 RVA: 0x002F48B8 File Offset: 0x002F2AB8
		public int FinalRewardId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04005651 RID: 22097
		private Table __p;
	}
}
