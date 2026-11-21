using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011B3 RID: 4531
	public struct SkillButtonCustom : IFlatbufferObject
	{
		// Token: 0x17003781 RID: 14209
		// (get) Token: 0x0600DB87 RID: 56199 RVA: 0x00332CEC File Offset: 0x00330EEC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DB88 RID: 56200 RVA: 0x00332CF9 File Offset: 0x00330EF9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DB89 RID: 56201 RVA: 0x00332D00 File Offset: 0x00330F00
		public static SkillButtonCustom GetRootAsSkillButtonCustom(ByteBuffer _bb)
		{
			return SkillButtonCustom.GetRootAsSkillButtonCustom(_bb, default(SkillButtonCustom));
		}

		// Token: 0x0600DB8A RID: 56202 RVA: 0x00332D1C File Offset: 0x00330F1C
		public static SkillButtonCustom GetRootAsSkillButtonCustom(ByteBuffer _bb, SkillButtonCustom obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DB8B RID: 56203 RVA: 0x00332D39 File Offset: 0x00330F39
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DB8C RID: 56204 RVA: 0x00332D48 File Offset: 0x00330F48
		public SkillButtonCustom __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003782 RID: 14210
		// (get) Token: 0x0600DB8D RID: 56205 RVA: 0x00332D58 File Offset: 0x00330F58
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

		// Token: 0x17003783 RID: 14211
		// (get) Token: 0x0600DB8E RID: 56206 RVA: 0x00332D94 File Offset: 0x00330F94
		public int Type
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

		// Token: 0x0600DB8F RID: 56207 RVA: 0x00332DD0 File Offset: 0x00330FD0
		public int TagIds(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003784 RID: 14212
		// (get) Token: 0x0600DB90 RID: 56208 RVA: 0x00332E10 File Offset: 0x00331010
		public int TagIdsLength
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

		// Token: 0x0600DB91 RID: 56209 RVA: 0x00332E3B File Offset: 0x0033103B
		public Span<int> GetTagIdsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600DB92 RID: 56210 RVA: 0x00332E4A File Offset: 0x0033104A
		public int[] GetTagIdsArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x0600DB93 RID: 56211 RVA: 0x00332E64 File Offset: 0x00331064
		public long BuffIds(int j)
		{
			int num = this.__p.__offset(10);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x17003785 RID: 14213
		// (get) Token: 0x0600DB94 RID: 56212 RVA: 0x00332EB0 File Offset: 0x003310B0
		public int BuffIdsLength
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

		// Token: 0x0600DB95 RID: 56213 RVA: 0x00332EDC File Offset: 0x003310DC
		public Span<long> GetBuffIdsBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(10, 8));
		}

		// Token: 0x0600DB96 RID: 56214 RVA: 0x00332EF1 File Offset: 0x003310F1
		public long[] GetBuffIdsArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(10) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x0600DB97 RID: 56215 RVA: 0x00332F30 File Offset: 0x00331130
		public string Params(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003786 RID: 14214
		// (get) Token: 0x0600DB98 RID: 56216 RVA: 0x00332F6C File Offset: 0x0033116C
		public int ParamsLength
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

		// Token: 0x0600DB99 RID: 56217 RVA: 0x00332F98 File Offset: 0x00331198
		[NullableContext(1)]
		public long[] BuffIds()
		{
			return this.GetBuffIdsArray();
		}

		// Token: 0x0600DB9A RID: 56218 RVA: 0x00332FA0 File Offset: 0x003311A0
		[NullableContext(1)]
		public IEnumerable<long> BuffIdsIter()
		{
			SkillButtonCustom.<BuffIdsIter>d__26 <BuffIdsIter>d__ = new SkillButtonCustom.<BuffIdsIter>d__26(-2);
			<BuffIdsIter>d__.<>3__<>4__this = this;
			return <BuffIdsIter>d__;
		}

		// Token: 0x0600DB9B RID: 56219 RVA: 0x00332FB5 File Offset: 0x003311B5
		[NullableContext(1)]
		public string[] Params()
		{
			return this.ParamsIter().ToArray<string>();
		}

		// Token: 0x0600DB9C RID: 56220 RVA: 0x00332FC2 File Offset: 0x003311C2
		[NullableContext(1)]
		public IEnumerable<string> ParamsIter()
		{
			SkillButtonCustom.<ParamsIter>d__28 <ParamsIter>d__ = new SkillButtonCustom.<ParamsIter>d__28(-2);
			<ParamsIter>d__.<>3__<>4__this = this;
			return <ParamsIter>d__;
		}

		// Token: 0x0600DB9D RID: 56221 RVA: 0x00332FD7 File Offset: 0x003311D7
		[NullableContext(1)]
		public int[] TagIds()
		{
			return this.GetTagIdsArray();
		}

		// Token: 0x0600DB9E RID: 56222 RVA: 0x00332FDF File Offset: 0x003311DF
		[NullableContext(1)]
		public IEnumerable<int> TagIdsIter()
		{
			SkillButtonCustom.<TagIdsIter>d__30 <TagIdsIter>d__ = new SkillButtonCustom.<TagIdsIter>d__30(-2);
			<TagIdsIter>d__.<>3__<>4__this = this;
			return <TagIdsIter>d__;
		}

		// Token: 0x040057D1 RID: 22481
		private Table __p;
	}
}
