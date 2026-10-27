using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000ED1 RID: 3793
	public struct PhantomBattleFourCTask : IFlatbufferObject
	{
		// Token: 0x17002641 RID: 9793
		// (get) Token: 0x0600A727 RID: 42791 RVA: 0x002B0075 File Offset: 0x002AE275
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A728 RID: 42792 RVA: 0x002B0082 File Offset: 0x002AE282
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A729 RID: 42793 RVA: 0x002B008C File Offset: 0x002AE28C
		public static PhantomBattleFourCTask GetRootAsPhantomBattleFourCTask(ByteBuffer _bb)
		{
			return PhantomBattleFourCTask.GetRootAsPhantomBattleFourCTask(_bb, default(PhantomBattleFourCTask));
		}

		// Token: 0x0600A72A RID: 42794 RVA: 0x002B00A8 File Offset: 0x002AE2A8
		public static PhantomBattleFourCTask GetRootAsPhantomBattleFourCTask(ByteBuffer _bb, PhantomBattleFourCTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A72B RID: 42795 RVA: 0x002B00C5 File Offset: 0x002AE2C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A72C RID: 42796 RVA: 0x002B00D4 File Offset: 0x002AE2D4
		public PhantomBattleFourCTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002642 RID: 9794
		// (get) Token: 0x0600A72D RID: 42797 RVA: 0x002B00E4 File Offset: 0x002AE2E4
		public int CardId
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

		// Token: 0x17002643 RID: 9795
		// (get) Token: 0x0600A72E RID: 42798 RVA: 0x002B0120 File Offset: 0x002AE320
		public string CoreDesc
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A72F RID: 42799 RVA: 0x002B0157 File Offset: 0x002AE357
		public Span<byte> GetCoreDescBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600A730 RID: 42800 RVA: 0x002B0166 File Offset: 0x002AE366
		public byte[] GetCoreDescArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002644 RID: 9796
		// (get) Token: 0x0600A731 RID: 42801 RVA: 0x002B0180 File Offset: 0x002AE380
		public string TaskDesc
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

		// Token: 0x0600A732 RID: 42802 RVA: 0x002B01B7 File Offset: 0x002AE3B7
		public Span<byte> GetTaskDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600A733 RID: 42803 RVA: 0x002B01C6 File Offset: 0x002AE3C6
		public byte[] GetTaskDescArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0600A734 RID: 42804 RVA: 0x002B01E0 File Offset: 0x002AE3E0
		public int ConditionList(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002645 RID: 9797
		// (get) Token: 0x0600A735 RID: 42805 RVA: 0x002B0220 File Offset: 0x002AE420
		public int ConditionListLength
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

		// Token: 0x0600A736 RID: 42806 RVA: 0x002B024C File Offset: 0x002AE44C
		public Span<int> GetConditionListBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600A737 RID: 42807 RVA: 0x002B025C File Offset: 0x002AE45C
		public int[] GetConditionListArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x17002646 RID: 9798
		// (get) Token: 0x0600A738 RID: 42808 RVA: 0x002B0274 File Offset: 0x002AE474
		public int TaskDescConditionId
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

		// Token: 0x0600A739 RID: 42809 RVA: 0x002B02B4 File Offset: 0x002AE4B4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ConditionListIter()或GetConditionListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ConditionList()
		{
			PhantomBattleFourCTask phantomBattleFourCTask = this;
			return phantomBattleFourCTask.GetConditionListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600A73A RID: 42810 RVA: 0x002B02D8 File Offset: 0x002AE4D8
		[NullableContext(1)]
		public readonly IEnumerable<int> ConditionListIter()
		{
			PhantomBattleFourCTask.<ConditionListIter>d__26 <ConditionListIter>d__ = new PhantomBattleFourCTask.<ConditionListIter>d__26(-2);
			<ConditionListIter>d__.<>3__<>4__this = this;
			return <ConditionListIter>d__;
		}

		// Token: 0x04004F8F RID: 20367
		private Table __p;
	}
}
