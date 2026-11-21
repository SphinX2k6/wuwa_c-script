using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001141 RID: 4417
	public struct RoleSkillFightTrick : IFlatbufferObject
	{
		// Token: 0x17003379 RID: 13177
		// (get) Token: 0x0600D04C RID: 53324 RVA: 0x003198ED File Offset: 0x00317AED
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D04D RID: 53325 RVA: 0x003198FA File Offset: 0x00317AFA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D04E RID: 53326 RVA: 0x00319904 File Offset: 0x00317B04
		public static RoleSkillFightTrick GetRootAsRoleSkillFightTrick(ByteBuffer _bb)
		{
			return RoleSkillFightTrick.GetRootAsRoleSkillFightTrick(_bb, default(RoleSkillFightTrick));
		}

		// Token: 0x0600D04F RID: 53327 RVA: 0x00319920 File Offset: 0x00317B20
		public static RoleSkillFightTrick GetRootAsRoleSkillFightTrick(ByteBuffer _bb, RoleSkillFightTrick obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D050 RID: 53328 RVA: 0x0031993D File Offset: 0x00317B3D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D051 RID: 53329 RVA: 0x0031994C File Offset: 0x00317B4C
		public RoleSkillFightTrick __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700337A RID: 13178
		// (get) Token: 0x0600D052 RID: 53330 RVA: 0x0031995C File Offset: 0x00317B5C
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

		// Token: 0x1700337B RID: 13179
		// (get) Token: 0x0600D053 RID: 53331 RVA: 0x00319998 File Offset: 0x00317B98
		public int RoleId
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

		// Token: 0x1700337C RID: 13180
		// (get) Token: 0x0600D054 RID: 53332 RVA: 0x003199D4 File Offset: 0x00317BD4
		public string SkillTitle
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

		// Token: 0x0600D055 RID: 53333 RVA: 0x00319A0B File Offset: 0x00317C0B
		public Span<byte> GetSkillTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600D056 RID: 53334 RVA: 0x00319A1A File Offset: 0x00317C1A
		public byte[] GetSkillTitleArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D057 RID: 53335 RVA: 0x00319A34 File Offset: 0x00317C34
		public int SkillDesc(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700337D RID: 13181
		// (get) Token: 0x0600D058 RID: 53336 RVA: 0x00319A74 File Offset: 0x00317C74
		public int SkillDescLength
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

		// Token: 0x0600D059 RID: 53337 RVA: 0x00319AA0 File Offset: 0x00317CA0
		public Span<int> GetSkillDescBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600D05A RID: 53338 RVA: 0x00319AB0 File Offset: 0x00317CB0
		public int[] GetSkillDescArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x1700337E RID: 13182
		// (get) Token: 0x0600D05B RID: 53339 RVA: 0x00319AC8 File Offset: 0x00317CC8
		public int Type
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

		// Token: 0x0600D05C RID: 53340 RVA: 0x00319B05 File Offset: 0x00317D05
		[NullableContext(1)]
		public int[] SkillDesc()
		{
			return this.GetSkillDescArray();
		}

		// Token: 0x0600D05D RID: 53341 RVA: 0x00319B0D File Offset: 0x00317D0D
		[NullableContext(1)]
		public IEnumerable<int> SkillDescIter()
		{
			RoleSkillFightTrick.<SkillDescIter>d__24 <SkillDescIter>d__ = new RoleSkillFightTrick.<SkillDescIter>d__24(-2);
			<SkillDescIter>d__.<>3__<>4__this = this;
			return <SkillDescIter>d__;
		}

		// Token: 0x04005743 RID: 22339
		private Table __p;
	}
}
