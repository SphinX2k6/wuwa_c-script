using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E89 RID: 3721
	public struct KurotatoLevelGroup : IFlatbufferObject
	{
		// Token: 0x17001C17 RID: 7191
		// (get) Token: 0x0600906F RID: 36975 RVA: 0x0028E4A6 File Offset: 0x0028C6A6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009070 RID: 36976 RVA: 0x0028E4B3 File Offset: 0x0028C6B3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009071 RID: 36977 RVA: 0x0028E4BC File Offset: 0x0028C6BC
		public static KurotatoLevelGroup GetRootAsKurotatoLevelGroup(ByteBuffer _bb)
		{
			return KurotatoLevelGroup.GetRootAsKurotatoLevelGroup(_bb, default(KurotatoLevelGroup));
		}

		// Token: 0x06009072 RID: 36978 RVA: 0x0028E4D8 File Offset: 0x0028C6D8
		public static KurotatoLevelGroup GetRootAsKurotatoLevelGroup(ByteBuffer _bb, KurotatoLevelGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009073 RID: 36979 RVA: 0x0028E4F5 File Offset: 0x0028C6F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009074 RID: 36980 RVA: 0x0028E504 File Offset: 0x0028C704
		public KurotatoLevelGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001C18 RID: 7192
		// (get) Token: 0x06009075 RID: 36981 RVA: 0x0028E514 File Offset: 0x0028C714
		public int GroupId
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

		// Token: 0x17001C19 RID: 7193
		// (get) Token: 0x06009076 RID: 36982 RVA: 0x0028E550 File Offset: 0x0028C750
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

		// Token: 0x17001C1A RID: 7194
		// (get) Token: 0x06009077 RID: 36983 RVA: 0x0028E58C File Offset: 0x0028C78C
		public int PerId
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

		// Token: 0x17001C1B RID: 7195
		// (get) Token: 0x06009078 RID: 36984 RVA: 0x0028E5C8 File Offset: 0x0028C7C8
		public int LevelId
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

		// Token: 0x17001C1C RID: 7196
		// (get) Token: 0x06009079 RID: 36985 RVA: 0x0028E608 File Offset: 0x0028C808
		public string Name
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

		// Token: 0x0600907A RID: 36986 RVA: 0x0028E640 File Offset: 0x0028C840
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600907B RID: 36987 RVA: 0x0028E650 File Offset: 0x0028C850
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17001C1D RID: 7197
		// (get) Token: 0x0600907C RID: 36988 RVA: 0x0028E668 File Offset: 0x0028C868
		public string TitleBg
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600907D RID: 36989 RVA: 0x0028E6A0 File Offset: 0x0028C8A0
		public Span<byte> GetTitleBgBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600907E RID: 36990 RVA: 0x0028E6B0 File Offset: 0x0028C8B0
		public byte[] GetTitleBgArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x0600907F RID: 36991 RVA: 0x0028E6C8 File Offset: 0x0028C8C8
		public int DifficultyGroup(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001C1E RID: 7198
		// (get) Token: 0x06009080 RID: 36992 RVA: 0x0028E708 File Offset: 0x0028C908
		public int DifficultyGroupLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06009081 RID: 36993 RVA: 0x0028E734 File Offset: 0x0028C934
		public Span<int> GetDifficultyGroupBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x06009082 RID: 36994 RVA: 0x0028E744 File Offset: 0x0028C944
		public int[] GetDifficultyGroupArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x06009083 RID: 36995 RVA: 0x0028E75C File Offset: 0x0028C95C
		public int SecondGroup(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001C1F RID: 7199
		// (get) Token: 0x06009084 RID: 36996 RVA: 0x0028E79C File Offset: 0x0028C99C
		public int SecondGroupLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06009085 RID: 36997 RVA: 0x0028E7C8 File Offset: 0x0028C9C8
		public Span<int> GetSecondGroupBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x06009086 RID: 36998 RVA: 0x0028E7D8 File Offset: 0x0028C9D8
		public int[] GetSecondGroupArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x06009087 RID: 36999 RVA: 0x0028E7F0 File Offset: 0x0028C9F0
		[NullableContext(1)]
		public int[] DifficultyGroup()
		{
			return this.GetDifficultyGroupArray();
		}

		// Token: 0x06009088 RID: 37000 RVA: 0x0028E7F8 File Offset: 0x0028C9F8
		[NullableContext(1)]
		public IEnumerable<int> DifficultyGroupIter()
		{
			KurotatoLevelGroup.<DifficultyGroupIter>d__35 <DifficultyGroupIter>d__ = new KurotatoLevelGroup.<DifficultyGroupIter>d__35(-2);
			<DifficultyGroupIter>d__.<>3__<>4__this = this;
			return <DifficultyGroupIter>d__;
		}

		// Token: 0x06009089 RID: 37001 RVA: 0x0028E80D File Offset: 0x0028CA0D
		[NullableContext(1)]
		public int[] SecondGroup()
		{
			return this.GetSecondGroupArray();
		}

		// Token: 0x0600908A RID: 37002 RVA: 0x0028E815 File Offset: 0x0028CA15
		[NullableContext(1)]
		public IEnumerable<int> SecondGroupIter()
		{
			KurotatoLevelGroup.<SecondGroupIter>d__37 <SecondGroupIter>d__ = new KurotatoLevelGroup.<SecondGroupIter>d__37(-2);
			<SecondGroupIter>d__.<>3__<>4__this = this;
			return <SecondGroupIter>d__;
		}

		// Token: 0x0400541A RID: 21530
		private Table __p;
	}
}
