using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001142 RID: 4418
	public struct RoleSkillInput : IFlatbufferObject
	{
		// Token: 0x1700337F RID: 13183
		// (get) Token: 0x0600D05E RID: 53342 RVA: 0x00319B22 File Offset: 0x00317D22
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D05F RID: 53343 RVA: 0x00319B2F File Offset: 0x00317D2F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D060 RID: 53344 RVA: 0x00319B38 File Offset: 0x00317D38
		public static RoleSkillInput GetRootAsRoleSkillInput(ByteBuffer _bb)
		{
			return RoleSkillInput.GetRootAsRoleSkillInput(_bb, default(RoleSkillInput));
		}

		// Token: 0x0600D061 RID: 53345 RVA: 0x00319B54 File Offset: 0x00317D54
		public static RoleSkillInput GetRootAsRoleSkillInput(ByteBuffer _bb, RoleSkillInput obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D062 RID: 53346 RVA: 0x00319B71 File Offset: 0x00317D71
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D063 RID: 53347 RVA: 0x00319B80 File Offset: 0x00317D80
		public RoleSkillInput __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003380 RID: 13184
		// (get) Token: 0x0600D064 RID: 53348 RVA: 0x00319B90 File Offset: 0x00317D90
		public int RoleId
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

		// Token: 0x0600D065 RID: 53349 RVA: 0x00319BCC File Offset: 0x00317DCC
		public int SkillInputIdList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003381 RID: 13185
		// (get) Token: 0x0600D066 RID: 53350 RVA: 0x00319C0C File Offset: 0x00317E0C
		public int SkillInputIdListLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600D067 RID: 53351 RVA: 0x00319C37 File Offset: 0x00317E37
		public Span<int> GetSkillInputIdListBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600D068 RID: 53352 RVA: 0x00319C46 File Offset: 0x00317E46
		public int[] GetSkillInputIdListArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x17003382 RID: 13186
		// (get) Token: 0x0600D069 RID: 53353 RVA: 0x00319C60 File Offset: 0x00317E60
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D06A RID: 53354 RVA: 0x00319C97 File Offset: 0x00317E97
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600D06B RID: 53355 RVA: 0x00319CA6 File Offset: 0x00317EA6
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D06C RID: 53356 RVA: 0x00319CC0 File Offset: 0x00317EC0
		public string SkillDescList(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003383 RID: 13187
		// (get) Token: 0x0600D06D RID: 53357 RVA: 0x00319CFC File Offset: 0x00317EFC
		public int SkillDescListLength
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

		// Token: 0x0600D06E RID: 53358 RVA: 0x00319D28 File Offset: 0x00317F28
		public string DescList(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003384 RID: 13188
		// (get) Token: 0x0600D06F RID: 53359 RVA: 0x00319D64 File Offset: 0x00317F64
		public int DescListLength
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

		// Token: 0x0600D070 RID: 53360 RVA: 0x00319D90 File Offset: 0x00317F90
		[NullableContext(1)]
		public string[] DescList()
		{
			return this.DescListIter().ToArray<string>();
		}

		// Token: 0x0600D071 RID: 53361 RVA: 0x00319D9D File Offset: 0x00317F9D
		[NullableContext(1)]
		public IEnumerable<string> DescListIter()
		{
			RoleSkillInput.<DescListIter>d__26 <DescListIter>d__ = new RoleSkillInput.<DescListIter>d__26(-2);
			<DescListIter>d__.<>3__<>4__this = this;
			return <DescListIter>d__;
		}

		// Token: 0x0600D072 RID: 53362 RVA: 0x00319DB2 File Offset: 0x00317FB2
		[NullableContext(1)]
		public string[] SkillDescList()
		{
			return this.SkillDescListIter().ToArray<string>();
		}

		// Token: 0x0600D073 RID: 53363 RVA: 0x00319DBF File Offset: 0x00317FBF
		[NullableContext(1)]
		public IEnumerable<string> SkillDescListIter()
		{
			RoleSkillInput.<SkillDescListIter>d__28 <SkillDescListIter>d__ = new RoleSkillInput.<SkillDescListIter>d__28(-2);
			<SkillDescListIter>d__.<>3__<>4__this = this;
			return <SkillDescListIter>d__;
		}

		// Token: 0x0600D074 RID: 53364 RVA: 0x00319DD4 File Offset: 0x00317FD4
		[NullableContext(1)]
		public int[] SkillInputIdList()
		{
			return this.GetSkillInputIdListArray();
		}

		// Token: 0x0600D075 RID: 53365 RVA: 0x00319DDC File Offset: 0x00317FDC
		[NullableContext(1)]
		public IEnumerable<int> SkillInputIdListIter()
		{
			RoleSkillInput.<SkillInputIdListIter>d__30 <SkillInputIdListIter>d__ = new RoleSkillInput.<SkillInputIdListIter>d__30(-2);
			<SkillInputIdListIter>d__.<>3__<>4__this = this;
			return <SkillInputIdListIter>d__;
		}

		// Token: 0x04005744 RID: 22340
		private Table __p;
	}
}
