using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FEE RID: 4078
	public struct PhotoFightActivityGroup : IFlatbufferObject
	{
		// Token: 0x17002836 RID: 10294
		// (get) Token: 0x0600B1BA RID: 45498 RVA: 0x002D6B46 File Offset: 0x002D4D46
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B1BB RID: 45499 RVA: 0x002D6B53 File Offset: 0x002D4D53
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B1BC RID: 45500 RVA: 0x002D6B5C File Offset: 0x002D4D5C
		public static PhotoFightActivityGroup GetRootAsPhotoFightActivityGroup(ByteBuffer _bb)
		{
			return PhotoFightActivityGroup.GetRootAsPhotoFightActivityGroup(_bb, default(PhotoFightActivityGroup));
		}

		// Token: 0x0600B1BD RID: 45501 RVA: 0x002D6B78 File Offset: 0x002D4D78
		public static PhotoFightActivityGroup GetRootAsPhotoFightActivityGroup(ByteBuffer _bb, PhotoFightActivityGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B1BE RID: 45502 RVA: 0x002D6B95 File Offset: 0x002D4D95
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B1BF RID: 45503 RVA: 0x002D6BA4 File Offset: 0x002D4DA4
		public PhotoFightActivityGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002837 RID: 10295
		// (get) Token: 0x0600B1C0 RID: 45504 RVA: 0x002D6BB4 File Offset: 0x002D4DB4
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

		// Token: 0x17002838 RID: 10296
		// (get) Token: 0x0600B1C1 RID: 45505 RVA: 0x002D6BF0 File Offset: 0x002D4DF0
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

		// Token: 0x17002839 RID: 10297
		// (get) Token: 0x0600B1C2 RID: 45506 RVA: 0x002D6C2C File Offset: 0x002D4E2C
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

		// Token: 0x0600B1C3 RID: 45507 RVA: 0x002D6C68 File Offset: 0x002D4E68
		public int Difficulty(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700283A RID: 10298
		// (get) Token: 0x0600B1C4 RID: 45508 RVA: 0x002D6CA8 File Offset: 0x002D4EA8
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

		// Token: 0x0600B1C5 RID: 45509 RVA: 0x002D6CD4 File Offset: 0x002D4ED4
		public Span<int> GetDifficultyBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600B1C6 RID: 45510 RVA: 0x002D6CE4 File Offset: 0x002D4EE4
		public int[] GetDifficultyArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x1700283B RID: 10299
		// (get) Token: 0x0600B1C7 RID: 45511 RVA: 0x002D6CFC File Offset: 0x002D4EFC
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

		// Token: 0x1700283C RID: 10300
		// (get) Token: 0x0600B1C8 RID: 45512 RVA: 0x002D6D3C File Offset: 0x002D4F3C
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

		// Token: 0x0600B1C9 RID: 45513 RVA: 0x002D6D74 File Offset: 0x002D4F74
		public Span<byte> GetTargetRoleListNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600B1CA RID: 45514 RVA: 0x002D6D84 File Offset: 0x002D4F84
		public byte[] GetTargetRoleListNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x1700283D RID: 10301
		// (get) Token: 0x0600B1CB RID: 45515 RVA: 0x002D6D9C File Offset: 0x002D4F9C
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

		// Token: 0x0600B1CC RID: 45516 RVA: 0x002D6DD4 File Offset: 0x002D4FD4
		public Span<byte> GetThemeNameBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600B1CD RID: 45517 RVA: 0x002D6DE4 File Offset: 0x002D4FE4
		public byte[] GetThemeNameArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x1700283E RID: 10302
		// (get) Token: 0x0600B1CE RID: 45518 RVA: 0x002D6DFC File Offset: 0x002D4FFC
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

		// Token: 0x0600B1CF RID: 45519 RVA: 0x002D6E34 File Offset: 0x002D5034
		public Span<byte> GetRoleTextureLightBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600B1D0 RID: 45520 RVA: 0x002D6E44 File Offset: 0x002D5044
		public byte[] GetRoleTextureLightArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x1700283F RID: 10303
		// (get) Token: 0x0600B1D1 RID: 45521 RVA: 0x002D6E5C File Offset: 0x002D505C
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

		// Token: 0x0600B1D2 RID: 45522 RVA: 0x002D6E94 File Offset: 0x002D5094
		public Span<byte> GetRoleTextureDarkBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600B1D3 RID: 45523 RVA: 0x002D6EA4 File Offset: 0x002D50A4
		public byte[] GetRoleTextureDarkArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17002840 RID: 10304
		// (get) Token: 0x0600B1D4 RID: 45524 RVA: 0x002D6EBC File Offset: 0x002D50BC
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

		// Token: 0x0600B1D5 RID: 45525 RVA: 0x002D6EF4 File Offset: 0x002D50F4
		public Span<byte> GetNumSpriteBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600B1D6 RID: 45526 RVA: 0x002D6F04 File Offset: 0x002D5104
		public byte[] GetNumSpriteArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17002841 RID: 10305
		// (get) Token: 0x0600B1D7 RID: 45527 RVA: 0x002D6F1C File Offset: 0x002D511C
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

		// Token: 0x0600B1D8 RID: 45528 RVA: 0x002D6F54 File Offset: 0x002D5154
		public Span<byte> GetNumTextureAddBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600B1D9 RID: 45529 RVA: 0x002D6F64 File Offset: 0x002D5164
		public byte[] GetNumTextureAddArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x0600B1DA RID: 45530 RVA: 0x002D6F7C File Offset: 0x002D517C
		[NullableContext(1)]
		public int[] Difficulty()
		{
			return this.GetDifficultyArray();
		}

		// Token: 0x0600B1DB RID: 45531 RVA: 0x002D6F84 File Offset: 0x002D5184
		[NullableContext(1)]
		public IEnumerable<int> DifficultyIter()
		{
			PhotoFightActivityGroup.<DifficultyIter>d__46 <DifficultyIter>d__ = new PhotoFightActivityGroup.<DifficultyIter>d__46(-2);
			<DifficultyIter>d__.<>3__<>4__this = this;
			return <DifficultyIter>d__;
		}

		// Token: 0x040055B6 RID: 21942
		private Table __p;
	}
}
