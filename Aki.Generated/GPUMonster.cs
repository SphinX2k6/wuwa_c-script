using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D0B RID: 3339
	public struct GPUMonster : IFlatbufferObject
	{
		// Token: 0x170015FE RID: 5630
		// (get) Token: 0x06007B9F RID: 31647 RVA: 0x0024DA99 File Offset: 0x0024BC99
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007BA0 RID: 31648 RVA: 0x0024DAA6 File Offset: 0x0024BCA6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007BA1 RID: 31649 RVA: 0x0024DAB0 File Offset: 0x0024BCB0
		public static GPUMonster GetRootAsGPUMonster(ByteBuffer _bb)
		{
			return GPUMonster.GetRootAsGPUMonster(_bb, default(GPUMonster));
		}

		// Token: 0x06007BA2 RID: 31650 RVA: 0x0024DACC File Offset: 0x0024BCCC
		public static GPUMonster GetRootAsGPUMonster(ByteBuffer _bb, GPUMonster obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007BA3 RID: 31651 RVA: 0x0024DAE9 File Offset: 0x0024BCE9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007BA4 RID: 31652 RVA: 0x0024DAF8 File Offset: 0x0024BCF8
		public GPUMonster __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170015FF RID: 5631
		// (get) Token: 0x06007BA5 RID: 31653 RVA: 0x0024DB08 File Offset: 0x0024BD08
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

		// Token: 0x17001600 RID: 5632
		// (get) Token: 0x06007BA6 RID: 31654 RVA: 0x0024DB44 File Offset: 0x0024BD44
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

		// Token: 0x17001601 RID: 5633
		// (get) Token: 0x06007BA7 RID: 31655 RVA: 0x0024DB80 File Offset: 0x0024BD80
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

		// Token: 0x06007BA8 RID: 31656 RVA: 0x0024DBBC File Offset: 0x0024BDBC
		public int InitBuffs(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001602 RID: 5634
		// (get) Token: 0x06007BA9 RID: 31657 RVA: 0x0024DBFC File Offset: 0x0024BDFC
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

		// Token: 0x06007BAA RID: 31658 RVA: 0x0024DC28 File Offset: 0x0024BE28
		public Span<int> GetInitBuffsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06007BAB RID: 31659 RVA: 0x0024DC38 File Offset: 0x0024BE38
		public int[] GetInitBuffsArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x17001603 RID: 5635
		// (get) Token: 0x06007BAC RID: 31660 RVA: 0x0024DC50 File Offset: 0x0024BE50
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

		// Token: 0x06007BAD RID: 31661 RVA: 0x0024DC90 File Offset: 0x0024BE90
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用InitBuffsIter()或GetInitBuffsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] InitBuffs()
		{
			GPUMonster gpumonster = this;
			return gpumonster.GetInitBuffsArray() ?? Array.Empty<int>();
		}

		// Token: 0x06007BAE RID: 31662 RVA: 0x0024DCB4 File Offset: 0x0024BEB4
		[NullableContext(1)]
		public readonly IEnumerable<int> InitBuffsIter()
		{
			GPUMonster.<InitBuffsIter>d__22 <InitBuffsIter>d__ = new GPUMonster.<InitBuffsIter>d__22(-2);
			<InitBuffsIter>d__.<>3__<>4__this = this;
			return <InitBuffsIter>d__;
		}

		// Token: 0x04004D81 RID: 19841
		private Table __p;
	}
}
