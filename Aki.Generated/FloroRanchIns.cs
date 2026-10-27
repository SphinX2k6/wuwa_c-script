using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CAB RID: 3243
	public struct FloroRanchIns : IFlatbufferObject
	{
		// Token: 0x170012F4 RID: 4852
		// (get) Token: 0x0600736A RID: 29546 RVA: 0x0023B405 File Offset: 0x00239605
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600736B RID: 29547 RVA: 0x0023B412 File Offset: 0x00239612
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600736C RID: 29548 RVA: 0x0023B41C File Offset: 0x0023961C
		public static FloroRanchIns GetRootAsFloroRanchIns(ByteBuffer _bb)
		{
			return FloroRanchIns.GetRootAsFloroRanchIns(_bb, default(FloroRanchIns));
		}

		// Token: 0x0600736D RID: 29549 RVA: 0x0023B438 File Offset: 0x00239638
		public static FloroRanchIns GetRootAsFloroRanchIns(ByteBuffer _bb, FloroRanchIns obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600736E RID: 29550 RVA: 0x0023B455 File Offset: 0x00239655
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600736F RID: 29551 RVA: 0x0023B464 File Offset: 0x00239664
		public FloroRanchIns __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170012F5 RID: 4853
		// (get) Token: 0x06007370 RID: 29552 RVA: 0x0023B474 File Offset: 0x00239674
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

		// Token: 0x170012F6 RID: 4854
		// (get) Token: 0x06007371 RID: 29553 RVA: 0x0023B4B0 File Offset: 0x002396B0
		public int ActivityId
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

		// Token: 0x170012F7 RID: 4855
		// (get) Token: 0x06007372 RID: 29554 RVA: 0x0023B4EC File Offset: 0x002396EC
		public string Name
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

		// Token: 0x06007373 RID: 29555 RVA: 0x0023B523 File Offset: 0x00239723
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06007374 RID: 29556 RVA: 0x0023B532 File Offset: 0x00239732
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170012F8 RID: 4856
		// (get) Token: 0x06007375 RID: 29557 RVA: 0x0023B54C File Offset: 0x0023974C
		public int DelayTime
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

		// Token: 0x170012F9 RID: 4857
		// (get) Token: 0x06007376 RID: 29558 RVA: 0x0023B58C File Offset: 0x0023978C
		public int SortId
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

		// Token: 0x06007377 RID: 29559 RVA: 0x0023B5CC File Offset: 0x002397CC
		public int SubInsList(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170012FA RID: 4858
		// (get) Token: 0x06007378 RID: 29560 RVA: 0x0023B60C File Offset: 0x0023980C
		public int SubInsListLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06007379 RID: 29561 RVA: 0x0023B638 File Offset: 0x00239838
		public Span<int> GetSubInsListBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600737A RID: 29562 RVA: 0x0023B648 File Offset: 0x00239848
		public int[] GetSubInsListArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x170012FB RID: 4859
		// (get) Token: 0x0600737B RID: 29563 RVA: 0x0023B660 File Offset: 0x00239860
		public int Difficulty
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

		// Token: 0x170012FC RID: 4860
		// (get) Token: 0x0600737C RID: 29564 RVA: 0x0023B6A0 File Offset: 0x002398A0
		public string RomeIconPath
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600737D RID: 29565 RVA: 0x0023B6D8 File Offset: 0x002398D8
		public Span<byte> GetRomeIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600737E RID: 29566 RVA: 0x0023B6E8 File Offset: 0x002398E8
		public byte[] GetRomeIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x0600737F RID: 29567 RVA: 0x0023B700 File Offset: 0x00239900
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SubInsListIter()或GetSubInsListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] SubInsList()
		{
			FloroRanchIns floroRanchIns = this;
			return floroRanchIns.GetSubInsListArray() ?? Array.Empty<int>();
		}

		// Token: 0x06007380 RID: 29568 RVA: 0x0023B724 File Offset: 0x00239924
		[NullableContext(1)]
		public readonly IEnumerable<int> SubInsListIter()
		{
			FloroRanchIns.<SubInsListIter>d__32 <SubInsListIter>d__ = new FloroRanchIns.<SubInsListIter>d__32(-2);
			<SubInsListIter>d__.<>3__<>4__this = this;
			return <SubInsListIter>d__;
		}

		// Token: 0x04004D0F RID: 19727
		private Table __p;
	}
}
