using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F09 RID: 3849
	public struct PhotoFightActivityGroup : IFlatbufferObject
	{
		// Token: 0x170027D0 RID: 10192
		// (get) Token: 0x0600AB99 RID: 43929 RVA: 0x002B9E7D File Offset: 0x002B807D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AB9A RID: 43930 RVA: 0x002B9E8A File Offset: 0x002B808A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AB9B RID: 43931 RVA: 0x002B9E94 File Offset: 0x002B8094
		public static PhotoFightActivityGroup GetRootAsPhotoFightActivityGroup(ByteBuffer _bb)
		{
			return PhotoFightActivityGroup.GetRootAsPhotoFightActivityGroup(_bb, default(PhotoFightActivityGroup));
		}

		// Token: 0x0600AB9C RID: 43932 RVA: 0x002B9EB0 File Offset: 0x002B80B0
		public static PhotoFightActivityGroup GetRootAsPhotoFightActivityGroup(ByteBuffer _bb, PhotoFightActivityGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AB9D RID: 43933 RVA: 0x002B9ECD File Offset: 0x002B80CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AB9E RID: 43934 RVA: 0x002B9EDC File Offset: 0x002B80DC
		public PhotoFightActivityGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170027D1 RID: 10193
		// (get) Token: 0x0600AB9F RID: 43935 RVA: 0x002B9EEC File Offset: 0x002B80EC
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

		// Token: 0x170027D2 RID: 10194
		// (get) Token: 0x0600ABA0 RID: 43936 RVA: 0x002B9F28 File Offset: 0x002B8128
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

		// Token: 0x170027D3 RID: 10195
		// (get) Token: 0x0600ABA1 RID: 43937 RVA: 0x002B9F64 File Offset: 0x002B8164
		public int SortId
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

		// Token: 0x0600ABA2 RID: 43938 RVA: 0x002B9FA0 File Offset: 0x002B81A0
		public int Difficulty(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170027D4 RID: 10196
		// (get) Token: 0x0600ABA3 RID: 43939 RVA: 0x002B9FE0 File Offset: 0x002B81E0
		public int DifficultyLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600ABA4 RID: 43940 RVA: 0x002BA00C File Offset: 0x002B820C
		public Span<int> GetDifficultyBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600ABA5 RID: 43941 RVA: 0x002BA01C File Offset: 0x002B821C
		public int[] GetDifficultyArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x170027D5 RID: 10197
		// (get) Token: 0x0600ABA6 RID: 43942 RVA: 0x002BA034 File Offset: 0x002B8234
		public int OpenDay
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170027D6 RID: 10198
		// (get) Token: 0x0600ABA7 RID: 43943 RVA: 0x002BA074 File Offset: 0x002B8274
		public string TargetRoleListName
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

		// Token: 0x0600ABA8 RID: 43944 RVA: 0x002BA0AC File Offset: 0x002B82AC
		public Span<byte> GetTargetRoleListNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600ABA9 RID: 43945 RVA: 0x002BA0BC File Offset: 0x002B82BC
		public byte[] GetTargetRoleListNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170027D7 RID: 10199
		// (get) Token: 0x0600ABAA RID: 43946 RVA: 0x002BA0D4 File Offset: 0x002B82D4
		public string ThemeName
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600ABAB RID: 43947 RVA: 0x002BA10C File Offset: 0x002B830C
		public Span<byte> GetThemeNameBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600ABAC RID: 43948 RVA: 0x002BA11C File Offset: 0x002B831C
		public byte[] GetThemeNameArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170027D8 RID: 10200
		// (get) Token: 0x0600ABAD RID: 43949 RVA: 0x002BA134 File Offset: 0x002B8334
		public string RoleTextureLight
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600ABAE RID: 43950 RVA: 0x002BA16C File Offset: 0x002B836C
		public Span<byte> GetRoleTextureLightBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600ABAF RID: 43951 RVA: 0x002BA17C File Offset: 0x002B837C
		public byte[] GetRoleTextureLightArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170027D9 RID: 10201
		// (get) Token: 0x0600ABB0 RID: 43952 RVA: 0x002BA194 File Offset: 0x002B8394
		public string RoleTextureDark
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600ABB1 RID: 43953 RVA: 0x002BA1CC File Offset: 0x002B83CC
		public Span<byte> GetRoleTextureDarkBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600ABB2 RID: 43954 RVA: 0x002BA1DC File Offset: 0x002B83DC
		public byte[] GetRoleTextureDarkArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x170027DA RID: 10202
		// (get) Token: 0x0600ABB3 RID: 43955 RVA: 0x002BA1F4 File Offset: 0x002B83F4
		public string NumSprite
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600ABB4 RID: 43956 RVA: 0x002BA22C File Offset: 0x002B842C
		public Span<byte> GetNumSpriteBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600ABB5 RID: 43957 RVA: 0x002BA23C File Offset: 0x002B843C
		public byte[] GetNumSpriteArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x170027DB RID: 10203
		// (get) Token: 0x0600ABB6 RID: 43958 RVA: 0x002BA254 File Offset: 0x002B8454
		public string NumTextureAdd
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600ABB7 RID: 43959 RVA: 0x002BA28C File Offset: 0x002B848C
		public Span<byte> GetNumTextureAddBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600ABB8 RID: 43960 RVA: 0x002BA29C File Offset: 0x002B849C
		public byte[] GetNumTextureAddArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x0600ABB9 RID: 43961 RVA: 0x002BA2B4 File Offset: 0x002B84B4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DifficultyIter()或GetDifficultyBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Difficulty()
		{
			PhotoFightActivityGroup photoFightActivityGroup = this;
			return photoFightActivityGroup.GetDifficultyArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600ABBA RID: 43962 RVA: 0x002BA2D8 File Offset: 0x002B84D8
		[NullableContext(1)]
		public readonly IEnumerable<int> DifficultyIter()
		{
			PhotoFightActivityGroup.<DifficultyIter>d__46 <DifficultyIter>d__ = new PhotoFightActivityGroup.<DifficultyIter>d__46(-2);
			<DifficultyIter>d__.<>3__<>4__this = this;
			return <DifficultyIter>d__;
		}

		// Token: 0x04004FD1 RID: 20433
		private Table __p;
	}
}
