using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D0E RID: 3342
	public struct GPURole : IFlatbufferObject
	{
		// Token: 0x1700160E RID: 5646
		// (get) Token: 0x06007BD2 RID: 31698 RVA: 0x0024E141 File Offset: 0x0024C341
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007BD3 RID: 31699 RVA: 0x0024E14E File Offset: 0x0024C34E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007BD4 RID: 31700 RVA: 0x0024E158 File Offset: 0x0024C358
		public static GPURole GetRootAsGPURole(ByteBuffer _bb)
		{
			return GPURole.GetRootAsGPURole(_bb, default(GPURole));
		}

		// Token: 0x06007BD5 RID: 31701 RVA: 0x0024E174 File Offset: 0x0024C374
		public static GPURole GetRootAsGPURole(ByteBuffer _bb, GPURole obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007BD6 RID: 31702 RVA: 0x0024E191 File Offset: 0x0024C391
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007BD7 RID: 31703 RVA: 0x0024E1A0 File Offset: 0x0024C3A0
		public GPURole __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700160F RID: 5647
		// (get) Token: 0x06007BD8 RID: 31704 RVA: 0x0024E1B0 File Offset: 0x0024C3B0
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

		// Token: 0x17001610 RID: 5648
		// (get) Token: 0x06007BD9 RID: 31705 RVA: 0x0024E1EC File Offset: 0x0024C3EC
		public int SimpleCombatSubtypeId
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

		// Token: 0x17001611 RID: 5649
		// (get) Token: 0x06007BDA RID: 31706 RVA: 0x0024E228 File Offset: 0x0024C428
		public int RoleId
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

		// Token: 0x17001612 RID: 5650
		// (get) Token: 0x06007BDB RID: 31707 RVA: 0x0024E264 File Offset: 0x0024C464
		public int TemplateId
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

		// Token: 0x06007BDC RID: 31708 RVA: 0x0024E2A4 File Offset: 0x0024C4A4
		public int InitBuffs(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001613 RID: 5651
		// (get) Token: 0x06007BDD RID: 31709 RVA: 0x0024E2E4 File Offset: 0x0024C4E4
		public int InitBuffsLength
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

		// Token: 0x06007BDE RID: 31710 RVA: 0x0024E310 File Offset: 0x0024C510
		public Span<int> GetInitBuffsBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x06007BDF RID: 31711 RVA: 0x0024E320 File Offset: 0x0024C520
		public int[] GetInitBuffsArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x17001614 RID: 5652
		// (get) Token: 0x06007BE0 RID: 31712 RVA: 0x0024E338 File Offset: 0x0024C538
		public int Prop
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007BE1 RID: 31713 RVA: 0x0024E378 File Offset: 0x0024C578
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用InitBuffsIter()或GetInitBuffsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] InitBuffs()
		{
			GPURole gpurole = this;
			return gpurole.GetInitBuffsArray() ?? Array.Empty<int>();
		}

		// Token: 0x06007BE2 RID: 31714 RVA: 0x0024E39C File Offset: 0x0024C59C
		[NullableContext(1)]
		public readonly IEnumerable<int> InitBuffsIter()
		{
			GPURole.<InitBuffsIter>d__24 <InitBuffsIter>d__ = new GPURole.<InitBuffsIter>d__24(-2);
			<InitBuffsIter>d__.<>3__<>4__this = this;
			return <InitBuffsIter>d__;
		}

		// Token: 0x04004D84 RID: 19844
		private Table __p;
	}
}
