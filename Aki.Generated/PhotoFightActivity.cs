using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F08 RID: 3848
	public struct PhotoFightActivity : IFlatbufferObject
	{
		// Token: 0x170027C0 RID: 10176
		// (get) Token: 0x0600AB68 RID: 43880 RVA: 0x002B97C8 File Offset: 0x002B79C8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AB69 RID: 43881 RVA: 0x002B97D5 File Offset: 0x002B79D5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AB6A RID: 43882 RVA: 0x002B97DC File Offset: 0x002B79DC
		public static PhotoFightActivity GetRootAsPhotoFightActivity(ByteBuffer _bb)
		{
			return PhotoFightActivity.GetRootAsPhotoFightActivity(_bb, default(PhotoFightActivity));
		}

		// Token: 0x0600AB6B RID: 43883 RVA: 0x002B97F8 File Offset: 0x002B79F8
		public static PhotoFightActivity GetRootAsPhotoFightActivity(ByteBuffer _bb, PhotoFightActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AB6C RID: 43884 RVA: 0x002B9815 File Offset: 0x002B7A15
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AB6D RID: 43885 RVA: 0x002B9824 File Offset: 0x002B7A24
		public PhotoFightActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170027C1 RID: 10177
		// (get) Token: 0x0600AB6E RID: 43886 RVA: 0x002B9834 File Offset: 0x002B7A34
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

		// Token: 0x170027C2 RID: 10178
		// (get) Token: 0x0600AB6F RID: 43887 RVA: 0x002B9870 File Offset: 0x002B7A70
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

		// Token: 0x170027C3 RID: 10179
		// (get) Token: 0x0600AB70 RID: 43888 RVA: 0x002B98AC File Offset: 0x002B7AAC
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

		// Token: 0x170027C4 RID: 10180
		// (get) Token: 0x0600AB71 RID: 43889 RVA: 0x002B98E8 File Offset: 0x002B7AE8
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

		// Token: 0x0600AB72 RID: 43890 RVA: 0x002B9928 File Offset: 0x002B7B28
		public int TrailRole(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170027C5 RID: 10181
		// (get) Token: 0x0600AB73 RID: 43891 RVA: 0x002B9968 File Offset: 0x002B7B68
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

		// Token: 0x0600AB74 RID: 43892 RVA: 0x002B9994 File Offset: 0x002B7B94
		public Span<int> GetTrailRoleBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600AB75 RID: 43893 RVA: 0x002B99A4 File Offset: 0x002B7BA4
		public int[] GetTrailRoleArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x0600AB76 RID: 43894 RVA: 0x002B99BC File Offset: 0x002B7BBC
		public int PreSelectRoleList(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170027C6 RID: 10182
		// (get) Token: 0x0600AB77 RID: 43895 RVA: 0x002B99FC File Offset: 0x002B7BFC
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

		// Token: 0x0600AB78 RID: 43896 RVA: 0x002B9A28 File Offset: 0x002B7C28
		public Span<int> GetPreSelectRoleListBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600AB79 RID: 43897 RVA: 0x002B9A38 File Offset: 0x002B7C38
		public int[] GetPreSelectRoleListArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x0600AB7A RID: 43898 RVA: 0x002B9A50 File Offset: 0x002B7C50
		public int TargetRoles(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170027C7 RID: 10183
		// (get) Token: 0x0600AB7B RID: 43899 RVA: 0x002B9A90 File Offset: 0x002B7C90
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

		// Token: 0x0600AB7C RID: 43900 RVA: 0x002B9ABC File Offset: 0x002B7CBC
		public Span<int> GetTargetRolesBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x0600AB7D RID: 43901 RVA: 0x002B9ACC File Offset: 0x002B7CCC
		public int[] GetTargetRolesArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x170027C8 RID: 10184
		// (get) Token: 0x0600AB7E RID: 43902 RVA: 0x002B9AE4 File Offset: 0x002B7CE4
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

		// Token: 0x0600AB7F RID: 43903 RVA: 0x002B9B1C File Offset: 0x002B7D1C
		public Span<byte> GetLevelNameBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600AB80 RID: 43904 RVA: 0x002B9B2C File Offset: 0x002B7D2C
		public byte[] GetLevelNameArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170027C9 RID: 10185
		// (get) Token: 0x0600AB81 RID: 43905 RVA: 0x002B9B44 File Offset: 0x002B7D44
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

		// Token: 0x0600AB82 RID: 43906 RVA: 0x002B9B7C File Offset: 0x002B7D7C
		public Span<byte> GetLevelSimpleNameBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600AB83 RID: 43907 RVA: 0x002B9B8C File Offset: 0x002B7D8C
		public byte[] GetLevelSimpleNameArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x170027CA RID: 10186
		// (get) Token: 0x0600AB84 RID: 43908 RVA: 0x002B9BA4 File Offset: 0x002B7DA4
		public bool IsDifficulty
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170027CB RID: 10187
		// (get) Token: 0x0600AB85 RID: 43909 RVA: 0x002B9BE4 File Offset: 0x002B7DE4
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

		// Token: 0x0600AB86 RID: 43910 RVA: 0x002B9C1C File Offset: 0x002B7E1C
		public Span<byte> GetRoleBigTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600AB87 RID: 43911 RVA: 0x002B9C2C File Offset: 0x002B7E2C
		public byte[] GetRoleBigTextureArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x0600AB88 RID: 43912 RVA: 0x002B9C44 File Offset: 0x002B7E44
		public string TaskDescriptionText(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170027CC RID: 10188
		// (get) Token: 0x0600AB89 RID: 43913 RVA: 0x002B9C80 File Offset: 0x002B7E80
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

		// Token: 0x170027CD RID: 10189
		// (get) Token: 0x0600AB8A RID: 43914 RVA: 0x002B9CAC File Offset: 0x002B7EAC
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

		// Token: 0x0600AB8B RID: 43915 RVA: 0x002B9CE4 File Offset: 0x002B7EE4
		public Span<byte> GetNpcHeadIconBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600AB8C RID: 43916 RVA: 0x002B9CF4 File Offset: 0x002B7EF4
		public byte[] GetNpcHeadIconArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x170027CE RID: 10190
		// (get) Token: 0x0600AB8D RID: 43917 RVA: 0x002B9D0C File Offset: 0x002B7F0C
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

		// Token: 0x0600AB8E RID: 43918 RVA: 0x002B9D44 File Offset: 0x002B7F44
		public Span<byte> GetNpcDialogueBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600AB8F RID: 43919 RVA: 0x002B9D54 File Offset: 0x002B7F54
		public byte[] GetNpcDialogueArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x170027CF RID: 10191
		// (get) Token: 0x0600AB90 RID: 43920 RVA: 0x002B9D6C File Offset: 0x002B7F6C
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

		// Token: 0x0600AB91 RID: 43921 RVA: 0x002B9DAC File Offset: 0x002B7FAC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PreSelectRoleListIter()或GetPreSelectRoleListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] PreSelectRoleList()
		{
			PhotoFightActivity photoFightActivity = this;
			return photoFightActivity.GetPreSelectRoleListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600AB92 RID: 43922 RVA: 0x002B9DD0 File Offset: 0x002B7FD0
		[NullableContext(1)]
		public readonly IEnumerable<int> PreSelectRoleListIter()
		{
			PhotoFightActivity.<PreSelectRoleListIter>d__59 <PreSelectRoleListIter>d__ = new PhotoFightActivity.<PreSelectRoleListIter>d__59(-2);
			<PreSelectRoleListIter>d__.<>3__<>4__this = this;
			return <PreSelectRoleListIter>d__;
		}

		// Token: 0x0600AB93 RID: 43923 RVA: 0x002B9DE8 File Offset: 0x002B7FE8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用TargetRolesIter()或GetTargetRolesBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] TargetRoles()
		{
			PhotoFightActivity photoFightActivity = this;
			return photoFightActivity.GetTargetRolesArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600AB94 RID: 43924 RVA: 0x002B9E0C File Offset: 0x002B800C
		[NullableContext(1)]
		public readonly IEnumerable<int> TargetRolesIter()
		{
			PhotoFightActivity.<TargetRolesIter>d__61 <TargetRolesIter>d__ = new PhotoFightActivity.<TargetRolesIter>d__61(-2);
			<TargetRolesIter>d__.<>3__<>4__this = this;
			return <TargetRolesIter>d__;
		}

		// Token: 0x0600AB95 RID: 43925 RVA: 0x002B9E21 File Offset: 0x002B8021
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用TaskDescriptionTextIter()或GetTaskDescriptionTextBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] TaskDescriptionText()
		{
			return this.TaskDescriptionTextIter().ToArray<string>();
		}

		// Token: 0x0600AB96 RID: 43926 RVA: 0x002B9E2E File Offset: 0x002B802E
		[NullableContext(1)]
		public readonly IEnumerable<string> TaskDescriptionTextIter()
		{
			PhotoFightActivity.<TaskDescriptionTextIter>d__63 <TaskDescriptionTextIter>d__ = new PhotoFightActivity.<TaskDescriptionTextIter>d__63(-2);
			<TaskDescriptionTextIter>d__.<>3__<>4__this = this;
			return <TaskDescriptionTextIter>d__;
		}

		// Token: 0x0600AB97 RID: 43927 RVA: 0x002B9E44 File Offset: 0x002B8044
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用TrailRoleIter()或GetTrailRoleBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] TrailRole()
		{
			PhotoFightActivity photoFightActivity = this;
			return photoFightActivity.GetTrailRoleArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600AB98 RID: 43928 RVA: 0x002B9E68 File Offset: 0x002B8068
		[NullableContext(1)]
		public readonly IEnumerable<int> TrailRoleIter()
		{
			PhotoFightActivity.<TrailRoleIter>d__65 <TrailRoleIter>d__ = new PhotoFightActivity.<TrailRoleIter>d__65(-2);
			<TrailRoleIter>d__.<>3__<>4__this = this;
			return <TrailRoleIter>d__;
		}

		// Token: 0x04004FD0 RID: 20432
		private Table __p;
	}
}
