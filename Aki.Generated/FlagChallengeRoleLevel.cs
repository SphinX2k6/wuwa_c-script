using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C98 RID: 3224
	public struct FlagChallengeRoleLevel : IFlatbufferObject
	{
		// Token: 0x1700123A RID: 4666
		// (get) Token: 0x0600718A RID: 29066 RVA: 0x00236649 File Offset: 0x00234849
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600718B RID: 29067 RVA: 0x00236656 File Offset: 0x00234856
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600718C RID: 29068 RVA: 0x00236660 File Offset: 0x00234860
		public static FlagChallengeRoleLevel GetRootAsFlagChallengeRoleLevel(ByteBuffer _bb)
		{
			return FlagChallengeRoleLevel.GetRootAsFlagChallengeRoleLevel(_bb, default(FlagChallengeRoleLevel));
		}

		// Token: 0x0600718D RID: 29069 RVA: 0x0023667C File Offset: 0x0023487C
		public static FlagChallengeRoleLevel GetRootAsFlagChallengeRoleLevel(ByteBuffer _bb, FlagChallengeRoleLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600718E RID: 29070 RVA: 0x00236699 File Offset: 0x00234899
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600718F RID: 29071 RVA: 0x002366A8 File Offset: 0x002348A8
		public FlagChallengeRoleLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700123B RID: 4667
		// (get) Token: 0x06007190 RID: 29072 RVA: 0x002366B8 File Offset: 0x002348B8
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

		// Token: 0x1700123C RID: 4668
		// (get) Token: 0x06007191 RID: 29073 RVA: 0x002366F4 File Offset: 0x002348F4
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

		// Token: 0x1700123D RID: 4669
		// (get) Token: 0x06007192 RID: 29074 RVA: 0x00236730 File Offset: 0x00234930
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

		// Token: 0x1700123E RID: 4670
		// (get) Token: 0x06007193 RID: 29075 RVA: 0x0023676C File Offset: 0x0023496C
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

		// Token: 0x1700123F RID: 4671
		// (get) Token: 0x06007194 RID: 29076 RVA: 0x002367AC File Offset: 0x002349AC
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

		// Token: 0x06007195 RID: 29077 RVA: 0x002367E4 File Offset: 0x002349E4
		public Span<byte> GetLvAddDescBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06007196 RID: 29078 RVA: 0x002367F4 File Offset: 0x002349F4
		public byte[] GetLvAddDescArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x04004CEF RID: 19695
		private Table __p;
	}
}
