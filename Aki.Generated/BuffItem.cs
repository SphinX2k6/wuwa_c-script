using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C36 RID: 3126
	public struct BuffItem : IFlatbufferObject
	{
		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x060056D9 RID: 22233 RVA: 0x0020C102 File Offset: 0x0020A302
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060056DA RID: 22234 RVA: 0x0020C10F File Offset: 0x0020A30F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060056DB RID: 22235 RVA: 0x0020C118 File Offset: 0x0020A318
		public static BuffItem GetRootAsBuffItem(ByteBuffer _bb)
		{
			return BuffItem.GetRootAsBuffItem(_bb, default(BuffItem));
		}

		// Token: 0x060056DC RID: 22236 RVA: 0x0020C134 File Offset: 0x0020A334
		public static BuffItem GetRootAsBuffItem(ByteBuffer _bb, BuffItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060056DD RID: 22237 RVA: 0x0020C151 File Offset: 0x0020A351
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060056DE RID: 22238 RVA: 0x0020C160 File Offset: 0x0020A360
		public BuffItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x060056DF RID: 22239 RVA: 0x0020C170 File Offset: 0x0020A370
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

		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x060056E0 RID: 22240 RVA: 0x0020C1AC File Offset: 0x0020A3AC
		public int PublicCdGroup
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

		// Token: 0x060056E1 RID: 22241 RVA: 0x0020C1E8 File Offset: 0x0020A3E8
		public long Buffs(int j)
		{
			int num = this.__p.__offset(8);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x060056E2 RID: 22242 RVA: 0x0020C234 File Offset: 0x0020A434
		public int BuffsLength
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

		// Token: 0x060056E3 RID: 22243 RVA: 0x0020C25F File Offset: 0x0020A45F
		public Span<long> GetBuffsBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(8, 8));
		}

		// Token: 0x060056E4 RID: 22244 RVA: 0x0020C273 File Offset: 0x0020A473
		public long[] GetBuffsArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(8) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x060056E5 RID: 22245 RVA: 0x0020C2B0 File Offset: 0x0020A4B0
		public int Cd
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

		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x060056E6 RID: 22246 RVA: 0x0020C2F0 File Offset: 0x0020A4F0
		public bool Share
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x060056E7 RID: 22247 RVA: 0x0020C330 File Offset: 0x0020A530
		[NullableContext(1)]
		public long[] Buffs()
		{
			return this.GetBuffsArray();
		}

		// Token: 0x060056E8 RID: 22248 RVA: 0x0020C338 File Offset: 0x0020A538
		[NullableContext(1)]
		public IEnumerable<long> BuffsIter()
		{
			BuffItem.<BuffsIter>d__22 <BuffsIter>d__ = new BuffItem.<BuffsIter>d__22(-2);
			<BuffsIter>d__.<>3__<>4__this = this;
			return <BuffsIter>d__;
		}

		// Token: 0x04005133 RID: 20787
		private Table __p;
	}
}
