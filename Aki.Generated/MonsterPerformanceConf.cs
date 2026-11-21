using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EFF RID: 3839
	public struct MonsterPerformanceConf : IFlatbufferObject
	{
		// Token: 0x17001FEE RID: 8174
		// (get) Token: 0x06009B80 RID: 39808 RVA: 0x002A608D File Offset: 0x002A428D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009B81 RID: 39809 RVA: 0x002A609A File Offset: 0x002A429A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009B82 RID: 39810 RVA: 0x002A60A4 File Offset: 0x002A42A4
		public static MonsterPerformanceConf GetRootAsMonsterPerformanceConf(ByteBuffer _bb)
		{
			return MonsterPerformanceConf.GetRootAsMonsterPerformanceConf(_bb, default(MonsterPerformanceConf));
		}

		// Token: 0x06009B83 RID: 39811 RVA: 0x002A60C0 File Offset: 0x002A42C0
		public static MonsterPerformanceConf GetRootAsMonsterPerformanceConf(ByteBuffer _bb, MonsterPerformanceConf obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009B84 RID: 39812 RVA: 0x002A60DD File Offset: 0x002A42DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009B85 RID: 39813 RVA: 0x002A60EC File Offset: 0x002A42EC
		public MonsterPerformanceConf __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001FEF RID: 8175
		// (get) Token: 0x06009B86 RID: 39814 RVA: 0x002A60FC File Offset: 0x002A42FC
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

		// Token: 0x17001FF0 RID: 8176
		// (get) Token: 0x06009B87 RID: 39815 RVA: 0x002A6138 File Offset: 0x002A4338
		public int MonsterPerformanceId
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

		// Token: 0x06009B88 RID: 39816 RVA: 0x002A6174 File Offset: 0x002A4374
		public int SkillIds(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001FF1 RID: 8177
		// (get) Token: 0x06009B89 RID: 39817 RVA: 0x002A61B4 File Offset: 0x002A43B4
		public int SkillIdsLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06009B8A RID: 39818 RVA: 0x002A61DF File Offset: 0x002A43DF
		public Span<int> GetSkillIdsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06009B8B RID: 39819 RVA: 0x002A61EE File Offset: 0x002A43EE
		public int[] GetSkillIdsArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x17001FF2 RID: 8178
		// (get) Token: 0x06009B8C RID: 39820 RVA: 0x002A6208 File Offset: 0x002A4408
		public string Tag
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009B8D RID: 39821 RVA: 0x002A6240 File Offset: 0x002A4440
		public Span<byte> GetTagBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06009B8E RID: 39822 RVA: 0x002A6250 File Offset: 0x002A4450
		public byte[] GetTagArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x06009B8F RID: 39823 RVA: 0x002A6268 File Offset: 0x002A4468
		[NullableContext(1)]
		public int[] SkillIds()
		{
			return this.GetSkillIdsArray();
		}

		// Token: 0x06009B90 RID: 39824 RVA: 0x002A6270 File Offset: 0x002A4470
		[NullableContext(1)]
		public IEnumerable<int> SkillIdsIter()
		{
			MonsterPerformanceConf.<SkillIdsIter>d__22 <SkillIdsIter>d__ = new MonsterPerformanceConf.<SkillIdsIter>d__22(-2);
			<SkillIdsIter>d__.<>3__<>4__this = this;
			return <SkillIdsIter>d__;
		}

		// Token: 0x040054A4 RID: 21668
		private Table __p;
	}
}
