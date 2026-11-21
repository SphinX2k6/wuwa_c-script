using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D7C RID: 3452
	public struct FlagChallengeRoleLevel : IFlatbufferObject
	{
		// Token: 0x17001297 RID: 4759
		// (get) Token: 0x06007795 RID: 30613 RVA: 0x00255631 File Offset: 0x00253831
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007796 RID: 30614 RVA: 0x0025563E File Offset: 0x0025383E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007797 RID: 30615 RVA: 0x00255648 File Offset: 0x00253848
		public static FlagChallengeRoleLevel GetRootAsFlagChallengeRoleLevel(ByteBuffer _bb)
		{
			return FlagChallengeRoleLevel.GetRootAsFlagChallengeRoleLevel(_bb, default(FlagChallengeRoleLevel));
		}

		// Token: 0x06007798 RID: 30616 RVA: 0x00255664 File Offset: 0x00253864
		public static FlagChallengeRoleLevel GetRootAsFlagChallengeRoleLevel(ByteBuffer _bb, FlagChallengeRoleLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007799 RID: 30617 RVA: 0x00255681 File Offset: 0x00253881
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600779A RID: 30618 RVA: 0x00255690 File Offset: 0x00253890
		public FlagChallengeRoleLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001298 RID: 4760
		// (get) Token: 0x0600779B RID: 30619 RVA: 0x002556A0 File Offset: 0x002538A0
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

		// Token: 0x17001299 RID: 4761
		// (get) Token: 0x0600779C RID: 30620 RVA: 0x002556DC File Offset: 0x002538DC
		public int ActivityId
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

		// Token: 0x1700129A RID: 4762
		// (get) Token: 0x0600779D RID: 30621 RVA: 0x00255718 File Offset: 0x00253918
		public int Level
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

		// Token: 0x1700129B RID: 4763
		// (get) Token: 0x0600779E RID: 30622 RVA: 0x00255754 File Offset: 0x00253954
		public int Experience
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

		// Token: 0x1700129C RID: 4764
		// (get) Token: 0x0600779F RID: 30623 RVA: 0x00255794 File Offset: 0x00253994
		public string LvAddDesc
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060077A0 RID: 30624 RVA: 0x002557CC File Offset: 0x002539CC
		public Span<byte> GetLvAddDescBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060077A1 RID: 30625 RVA: 0x002557DC File Offset: 0x002539DC
		public byte[] GetLvAddDescArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x040052D3 RID: 21203
		private Table __p;
	}
}
