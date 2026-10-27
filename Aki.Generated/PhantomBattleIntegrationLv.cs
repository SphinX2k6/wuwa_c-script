using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000ED4 RID: 3796
	public struct PhantomBattleIntegrationLv : IFlatbufferObject
	{
		// Token: 0x17002654 RID: 9812
		// (get) Token: 0x0600A75E RID: 42846 RVA: 0x002B0738 File Offset: 0x002AE938
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A75F RID: 42847 RVA: 0x002B0745 File Offset: 0x002AE945
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A760 RID: 42848 RVA: 0x002B074C File Offset: 0x002AE94C
		public static PhantomBattleIntegrationLv GetRootAsPhantomBattleIntegrationLv(ByteBuffer _bb)
		{
			return PhantomBattleIntegrationLv.GetRootAsPhantomBattleIntegrationLv(_bb, default(PhantomBattleIntegrationLv));
		}

		// Token: 0x0600A761 RID: 42849 RVA: 0x002B0768 File Offset: 0x002AE968
		public static PhantomBattleIntegrationLv GetRootAsPhantomBattleIntegrationLv(ByteBuffer _bb, PhantomBattleIntegrationLv obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A762 RID: 42850 RVA: 0x002B0785 File Offset: 0x002AE985
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A763 RID: 42851 RVA: 0x002B0794 File Offset: 0x002AE994
		public PhantomBattleIntegrationLv __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002655 RID: 9813
		// (get) Token: 0x0600A764 RID: 42852 RVA: 0x002B07A4 File Offset: 0x002AE9A4
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

		// Token: 0x0600A765 RID: 42853 RVA: 0x002B07E0 File Offset: 0x002AE9E0
		public int Range(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002656 RID: 9814
		// (get) Token: 0x0600A766 RID: 42854 RVA: 0x002B0820 File Offset: 0x002AEA20
		public int RangeLength
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

		// Token: 0x0600A767 RID: 42855 RVA: 0x002B084B File Offset: 0x002AEA4B
		public Span<int> GetRangeBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600A768 RID: 42856 RVA: 0x002B085A File Offset: 0x002AEA5A
		public int[] GetRangeArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x17002657 RID: 9815
		// (get) Token: 0x0600A769 RID: 42857 RVA: 0x002B0874 File Offset: 0x002AEA74
		public string Title
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

		// Token: 0x0600A76A RID: 42858 RVA: 0x002B08AB File Offset: 0x002AEAAB
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600A76B RID: 42859 RVA: 0x002B08BA File Offset: 0x002AEABA
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002658 RID: 9816
		// (get) Token: 0x0600A76C RID: 42860 RVA: 0x002B08D4 File Offset: 0x002AEAD4
		public int Win
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

		// Token: 0x17002659 RID: 9817
		// (get) Token: 0x0600A76D RID: 42861 RVA: 0x002B0914 File Offset: 0x002AEB14
		public int Fail
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

		// Token: 0x1700265A RID: 9818
		// (get) Token: 0x0600A76E RID: 42862 RVA: 0x002B0954 File Offset: 0x002AEB54
		public int WinSecond
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

		// Token: 0x1700265B RID: 9819
		// (get) Token: 0x0600A76F RID: 42863 RVA: 0x002B0994 File Offset: 0x002AEB94
		public int FailSecond
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A770 RID: 42864 RVA: 0x002B09D4 File Offset: 0x002AEBD4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RangeIter()或GetRangeBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Range()
		{
			PhantomBattleIntegrationLv phantomBattleIntegrationLv = this;
			return phantomBattleIntegrationLv.GetRangeArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600A771 RID: 42865 RVA: 0x002B09F8 File Offset: 0x002AEBF8
		[NullableContext(1)]
		public readonly IEnumerable<int> RangeIter()
		{
			PhantomBattleIntegrationLv.<RangeIter>d__28 <RangeIter>d__ = new PhantomBattleIntegrationLv.<RangeIter>d__28(-2);
			<RangeIter>d__.<>3__<>4__this = this;
			return <RangeIter>d__;
		}

		// Token: 0x04004F92 RID: 20370
		private Table __p;
	}
}
