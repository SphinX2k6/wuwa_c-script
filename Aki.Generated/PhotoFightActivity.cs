using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FED RID: 4077
	public struct PhotoFightActivity : IFlatbufferObject
	{
		// Token: 0x17002826 RID: 10278
		// (get) Token: 0x0600B189 RID: 45449 RVA: 0x002D64EC File Offset: 0x002D46EC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B18A RID: 45450 RVA: 0x002D64F9 File Offset: 0x002D46F9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B18B RID: 45451 RVA: 0x002D6500 File Offset: 0x002D4700
		public static PhotoFightActivity GetRootAsPhotoFightActivity(ByteBuffer _bb)
		{
			return PhotoFightActivity.GetRootAsPhotoFightActivity(_bb, default(PhotoFightActivity));
		}

		// Token: 0x0600B18C RID: 45452 RVA: 0x002D651C File Offset: 0x002D471C
		public static PhotoFightActivity GetRootAsPhotoFightActivity(ByteBuffer _bb, PhotoFightActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B18D RID: 45453 RVA: 0x002D6539 File Offset: 0x002D4739
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B18E RID: 45454 RVA: 0x002D6548 File Offset: 0x002D4748
		public PhotoFightActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002827 RID: 10279
		// (get) Token: 0x0600B18F RID: 45455 RVA: 0x002D6558 File Offset: 0x002D4758
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

		// Token: 0x17002828 RID: 10280
		// (get) Token: 0x0600B190 RID: 45456 RVA: 0x002D6594 File Offset: 0x002D4794
		public int InstId
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

		// Token: 0x17002829 RID: 10281
		// (get) Token: 0x0600B191 RID: 45457 RVA: 0x002D65D0 File Offset: 0x002D47D0
		public int PreInstId
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

		// Token: 0x1700282A RID: 10282
		// (get) Token: 0x0600B192 RID: 45458 RVA: 0x002D660C File Offset: 0x002D480C
		public int SortId
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

		// Token: 0x0600B193 RID: 45459 RVA: 0x002D664C File Offset: 0x002D484C
		public int TrailRole(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700282B RID: 10283
		// (get) Token: 0x0600B194 RID: 45460 RVA: 0x002D668C File Offset: 0x002D488C
		public int TrailRoleLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600B195 RID: 45461 RVA: 0x002D66B8 File Offset: 0x002D48B8
		public Span<int> GetTrailRoleBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600B196 RID: 45462 RVA: 0x002D66C8 File Offset: 0x002D48C8
		public int[] GetTrailRoleArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x0600B197 RID: 45463 RVA: 0x002D66E0 File Offset: 0x002D48E0
		public int PreSelectRoleList(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700282C RID: 10284
		// (get) Token: 0x0600B198 RID: 45464 RVA: 0x002D6720 File Offset: 0x002D4920
		public int PreSelectRoleListLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600B199 RID: 45465 RVA: 0x002D674C File Offset: 0x002D494C
		public Span<int> GetPreSelectRoleListBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600B19A RID: 45466 RVA: 0x002D675C File Offset: 0x002D495C
		public int[] GetPreSelectRoleListArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x0600B19B RID: 45467 RVA: 0x002D6774 File Offset: 0x002D4974
		public int TargetRoles(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700282D RID: 10285
		// (get) Token: 0x0600B19C RID: 45468 RVA: 0x002D67B4 File Offset: 0x002D49B4
		public int TargetRolesLength
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

		// Token: 0x0600B19D RID: 45469 RVA: 0x002D67E0 File Offset: 0x002D49E0
		public Span<int> GetTargetRolesBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x0600B19E RID: 45470 RVA: 0x002D67F0 File Offset: 0x002D49F0
		public int[] GetTargetRolesArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x1700282E RID: 10286
		// (get) Token: 0x0600B19F RID: 45471 RVA: 0x002D6808 File Offset: 0x002D4A08
		public string LevelName
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

		// Token: 0x0600B1A0 RID: 45472 RVA: 0x002D6840 File Offset: 0x002D4A40
		public Span<byte> GetLevelNameBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600B1A1 RID: 45473 RVA: 0x002D6850 File Offset: 0x002D4A50
		public byte[] GetLevelNameArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x1700282F RID: 10287
		// (get) Token: 0x0600B1A2 RID: 45474 RVA: 0x002D6868 File Offset: 0x002D4A68
		public string LevelSimpleName
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

		// Token: 0x0600B1A3 RID: 45475 RVA: 0x002D68A0 File Offset: 0x002D4AA0
		public Span<byte> GetLevelSimpleNameBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600B1A4 RID: 45476 RVA: 0x002D68B0 File Offset: 0x002D4AB0
		public byte[] GetLevelSimpleNameArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17002830 RID: 10288
		// (get) Token: 0x0600B1A5 RID: 45477 RVA: 0x002D68C8 File Offset: 0x002D4AC8
		public bool IsDifficulty
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002831 RID: 10289
		// (get) Token: 0x0600B1A6 RID: 45478 RVA: 0x002D6908 File Offset: 0x002D4B08
		public string RoleBigTexture
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

		// Token: 0x0600B1A7 RID: 45479 RVA: 0x002D6940 File Offset: 0x002D4B40
		public Span<byte> GetRoleBigTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600B1A8 RID: 45480 RVA: 0x002D6950 File Offset: 0x002D4B50
		public byte[] GetRoleBigTextureArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x0600B1A9 RID: 45481 RVA: 0x002D6968 File Offset: 0x002D4B68
		public string TaskDescriptionText(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002832 RID: 10290
		// (get) Token: 0x0600B1AA RID: 45482 RVA: 0x002D69A4 File Offset: 0x002D4BA4
		public int TaskDescriptionTextLength
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17002833 RID: 10291
		// (get) Token: 0x0600B1AB RID: 45483 RVA: 0x002D69D0 File Offset: 0x002D4BD0
		public string NpcHeadIcon
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B1AC RID: 45484 RVA: 0x002D6A08 File Offset: 0x002D4C08
		public Span<byte> GetNpcHeadIconBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600B1AD RID: 45485 RVA: 0x002D6A18 File Offset: 0x002D4C18
		public byte[] GetNpcHeadIconArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17002834 RID: 10292
		// (get) Token: 0x0600B1AE RID: 45486 RVA: 0x002D6A30 File Offset: 0x002D4C30
		public string NpcDialogue
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B1AF RID: 45487 RVA: 0x002D6A68 File Offset: 0x002D4C68
		public Span<byte> GetNpcDialogueBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600B1B0 RID: 45488 RVA: 0x002D6A78 File Offset: 0x002D4C78
		public byte[] GetNpcDialogueArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x17002835 RID: 10293
		// (get) Token: 0x0600B1B1 RID: 45489 RVA: 0x002D6A90 File Offset: 0x002D4C90
		public int LoadingId
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B1B2 RID: 45490 RVA: 0x002D6ACD File Offset: 0x002D4CCD
		[NullableContext(1)]
		public int[] PreSelectRoleList()
		{
			return this.GetPreSelectRoleListArray();
		}

		// Token: 0x0600B1B3 RID: 45491 RVA: 0x002D6AD5 File Offset: 0x002D4CD5
		[NullableContext(1)]
		public IEnumerable<int> PreSelectRoleListIter()
		{
			PhotoFightActivity.<PreSelectRoleListIter>d__59 <PreSelectRoleListIter>d__ = new PhotoFightActivity.<PreSelectRoleListIter>d__59(-2);
			<PreSelectRoleListIter>d__.<>3__<>4__this = this;
			return <PreSelectRoleListIter>d__;
		}

		// Token: 0x0600B1B4 RID: 45492 RVA: 0x002D6AEA File Offset: 0x002D4CEA
		[NullableContext(1)]
		public int[] TargetRoles()
		{
			return this.GetTargetRolesArray();
		}

		// Token: 0x0600B1B5 RID: 45493 RVA: 0x002D6AF2 File Offset: 0x002D4CF2
		[NullableContext(1)]
		public IEnumerable<int> TargetRolesIter()
		{
			PhotoFightActivity.<TargetRolesIter>d__61 <TargetRolesIter>d__ = new PhotoFightActivity.<TargetRolesIter>d__61(-2);
			<TargetRolesIter>d__.<>3__<>4__this = this;
			return <TargetRolesIter>d__;
		}

		// Token: 0x0600B1B6 RID: 45494 RVA: 0x002D6B07 File Offset: 0x002D4D07
		[NullableContext(1)]
		public string[] TaskDescriptionText()
		{
			return this.TaskDescriptionTextIter().ToArray<string>();
		}

		// Token: 0x0600B1B7 RID: 45495 RVA: 0x002D6B14 File Offset: 0x002D4D14
		[NullableContext(1)]
		public IEnumerable<string> TaskDescriptionTextIter()
		{
			PhotoFightActivity.<TaskDescriptionTextIter>d__63 <TaskDescriptionTextIter>d__ = new PhotoFightActivity.<TaskDescriptionTextIter>d__63(-2);
			<TaskDescriptionTextIter>d__.<>3__<>4__this = this;
			return <TaskDescriptionTextIter>d__;
		}

		// Token: 0x0600B1B8 RID: 45496 RVA: 0x002D6B29 File Offset: 0x002D4D29
		[NullableContext(1)]
		public int[] TrailRole()
		{
			return this.GetTrailRoleArray();
		}

		// Token: 0x0600B1B9 RID: 45497 RVA: 0x002D6B31 File Offset: 0x002D4D31
		[NullableContext(1)]
		public IEnumerable<int> TrailRoleIter()
		{
			PhotoFightActivity.<TrailRoleIter>d__65 <TrailRoleIter>d__ = new PhotoFightActivity.<TrailRoleIter>d__65(-2);
			<TrailRoleIter>d__.<>3__<>4__this = this;
			return <TrailRoleIter>d__;
		}

		// Token: 0x040055B5 RID: 21941
		private Table __p;
	}
}
