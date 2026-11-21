using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DF0 RID: 3568
	public struct GPUMonster : IFlatbufferObject
	{
		// Token: 0x1700165F RID: 5727
		// (get) Token: 0x060081B7 RID: 33207 RVA: 0x0026C576 File Offset: 0x0026A776
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060081B8 RID: 33208 RVA: 0x0026C583 File Offset: 0x0026A783
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060081B9 RID: 33209 RVA: 0x0026C58C File Offset: 0x0026A78C
		public static GPUMonster GetRootAsGPUMonster(ByteBuffer _bb)
		{
			return GPUMonster.GetRootAsGPUMonster(_bb, default(GPUMonster));
		}

		// Token: 0x060081BA RID: 33210 RVA: 0x0026C5A8 File Offset: 0x0026A7A8
		public static GPUMonster GetRootAsGPUMonster(ByteBuffer _bb, GPUMonster obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060081BB RID: 33211 RVA: 0x0026C5C5 File Offset: 0x0026A7C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060081BC RID: 33212 RVA: 0x0026C5D4 File Offset: 0x0026A7D4
		public GPUMonster __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001660 RID: 5728
		// (get) Token: 0x060081BD RID: 33213 RVA: 0x0026C5E4 File Offset: 0x0026A7E4
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

		// Token: 0x17001661 RID: 5729
		// (get) Token: 0x060081BE RID: 33214 RVA: 0x0026C620 File Offset: 0x0026A820
		public int TemplateId
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

		// Token: 0x17001662 RID: 5730
		// (get) Token: 0x060081BF RID: 33215 RVA: 0x0026C65C File Offset: 0x0026A85C
		public int SimpleCombatSubtypeId
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

		// Token: 0x060081C0 RID: 33216 RVA: 0x0026C698 File Offset: 0x0026A898
		public int InitBuffs(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001663 RID: 5731
		// (get) Token: 0x060081C1 RID: 33217 RVA: 0x0026C6D8 File Offset: 0x0026A8D8
		public int InitBuffsLength
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

		// Token: 0x060081C2 RID: 33218 RVA: 0x0026C704 File Offset: 0x0026A904
		public Span<int> GetInitBuffsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x060081C3 RID: 33219 RVA: 0x0026C714 File Offset: 0x0026A914
		public int[] GetInitBuffsArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x17001664 RID: 5732
		// (get) Token: 0x060081C4 RID: 33220 RVA: 0x0026C72C File Offset: 0x0026A92C
		public int Prop
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

		// Token: 0x060081C5 RID: 33221 RVA: 0x0026C769 File Offset: 0x0026A969
		[NullableContext(1)]
		public int[] InitBuffs()
		{
			return this.GetInitBuffsArray();
		}

		// Token: 0x060081C6 RID: 33222 RVA: 0x0026C771 File Offset: 0x0026A971
		[NullableContext(1)]
		public IEnumerable<int> InitBuffsIter()
		{
			GPUMonster.<InitBuffsIter>d__22 <InitBuffsIter>d__ = new GPUMonster.<InitBuffsIter>d__22(-2);
			<InitBuffsIter>d__.<>3__<>4__this = this;
			return <InitBuffsIter>d__;
		}

		// Token: 0x04005366 RID: 21350
		private Table __p;
	}
}
