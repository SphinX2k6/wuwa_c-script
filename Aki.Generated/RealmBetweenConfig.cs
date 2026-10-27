using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F9A RID: 3994
	public struct RealmBetweenConfig : IFlatbufferObject
	{
		// Token: 0x17002D19 RID: 11545
		// (get) Token: 0x0600B949 RID: 47433 RVA: 0x002D7F7D File Offset: 0x002D617D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B94A RID: 47434 RVA: 0x002D7F8A File Offset: 0x002D618A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B94B RID: 47435 RVA: 0x002D7F94 File Offset: 0x002D6194
		public static RealmBetweenConfig GetRootAsRealmBetweenConfig(ByteBuffer _bb)
		{
			return RealmBetweenConfig.GetRootAsRealmBetweenConfig(_bb, default(RealmBetweenConfig));
		}

		// Token: 0x0600B94C RID: 47436 RVA: 0x002D7FB0 File Offset: 0x002D61B0
		public static RealmBetweenConfig GetRootAsRealmBetweenConfig(ByteBuffer _bb, RealmBetweenConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B94D RID: 47437 RVA: 0x002D7FCD File Offset: 0x002D61CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B94E RID: 47438 RVA: 0x002D7FDC File Offset: 0x002D61DC
		public RealmBetweenConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002D1A RID: 11546
		// (get) Token: 0x0600B94F RID: 47439 RVA: 0x002D7FEC File Offset: 0x002D61EC
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

		// Token: 0x17002D1B RID: 11547
		// (get) Token: 0x0600B950 RID: 47440 RVA: 0x002D8028 File Offset: 0x002D6228
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

		// Token: 0x17002D1C RID: 11548
		// (get) Token: 0x0600B951 RID: 47441 RVA: 0x002D8064 File Offset: 0x002D6264
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

		// Token: 0x17002D1D RID: 11549
		// (get) Token: 0x0600B952 RID: 47442 RVA: 0x002D80A0 File Offset: 0x002D62A0
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

		// Token: 0x0400506A RID: 20586
		private Table __p;
	}
}
