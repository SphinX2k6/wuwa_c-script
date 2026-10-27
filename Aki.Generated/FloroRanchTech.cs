using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CB9 RID: 3257
	public struct FloroRanchTech : IFlatbufferObject
	{
		// Token: 0x17001358 RID: 4952
		// (get) Token: 0x060074AE RID: 29870 RVA: 0x0023E430 File Offset: 0x0023C630
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060074AF RID: 29871 RVA: 0x0023E43D File Offset: 0x0023C63D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060074B0 RID: 29872 RVA: 0x0023E444 File Offset: 0x0023C644
		public static FloroRanchTech GetRootAsFloroRanchTech(ByteBuffer _bb)
		{
			return FloroRanchTech.GetRootAsFloroRanchTech(_bb, default(FloroRanchTech));
		}

		// Token: 0x060074B1 RID: 29873 RVA: 0x0023E460 File Offset: 0x0023C660
		public static FloroRanchTech GetRootAsFloroRanchTech(ByteBuffer _bb, FloroRanchTech obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060074B2 RID: 29874 RVA: 0x0023E47D File Offset: 0x0023C67D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060074B3 RID: 29875 RVA: 0x0023E48C File Offset: 0x0023C68C
		public FloroRanchTech __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001359 RID: 4953
		// (get) Token: 0x060074B4 RID: 29876 RVA: 0x0023E49C File Offset: 0x0023C69C
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

		// Token: 0x1700135A RID: 4954
		// (get) Token: 0x060074B5 RID: 29877 RVA: 0x0023E4D8 File Offset: 0x0023C6D8
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

		// Token: 0x060074B6 RID: 29878 RVA: 0x0023E514 File Offset: 0x0023C714
		public int PreNode(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700135B RID: 4955
		// (get) Token: 0x060074B7 RID: 29879 RVA: 0x0023E554 File Offset: 0x0023C754
		public int PreNodeLength
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

		// Token: 0x060074B8 RID: 29880 RVA: 0x0023E57F File Offset: 0x0023C77F
		public Span<int> GetPreNodeBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x060074B9 RID: 29881 RVA: 0x0023E58E File Offset: 0x0023C78E
		public int[] GetPreNodeArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x1700135C RID: 4956
		// (get) Token: 0x060074BA RID: 29882 RVA: 0x0023E5A8 File Offset: 0x0023C7A8
		public string Name
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

		// Token: 0x060074BB RID: 29883 RVA: 0x0023E5E0 File Offset: 0x0023C7E0
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060074BC RID: 29884 RVA: 0x0023E5F0 File Offset: 0x0023C7F0
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700135D RID: 4957
		// (get) Token: 0x060074BD RID: 29885 RVA: 0x0023E608 File Offset: 0x0023C808
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060074BE RID: 29886 RVA: 0x0023E640 File Offset: 0x0023C840
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060074BF RID: 29887 RVA: 0x0023E650 File Offset: 0x0023C850
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700135E RID: 4958
		// (get) Token: 0x060074C0 RID: 29888 RVA: 0x0023E668 File Offset: 0x0023C868
		public int Effect
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

		// Token: 0x1700135F RID: 4959
		// (get) Token: 0x060074C1 RID: 29889 RVA: 0x0023E6A8 File Offset: 0x0023C8A8
		public int Cost
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

		// Token: 0x17001360 RID: 4960
		// (get) Token: 0x060074C2 RID: 29890 RVA: 0x0023E6E8 File Offset: 0x0023C8E8
		public int Column
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001361 RID: 4961
		// (get) Token: 0x060074C3 RID: 29891 RVA: 0x0023E728 File Offset: 0x0023C928
		public int Row
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001362 RID: 4962
		// (get) Token: 0x060074C4 RID: 29892 RVA: 0x0023E768 File Offset: 0x0023C968
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060074C5 RID: 29893 RVA: 0x0023E7A0 File Offset: 0x0023C9A0
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x060074C6 RID: 29894 RVA: 0x0023E7B0 File Offset: 0x0023C9B0
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x060074C7 RID: 29895 RVA: 0x0023E7C8 File Offset: 0x0023C9C8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PreNodeIter()或GetPreNodeBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] PreNode()
		{
			FloroRanchTech floroRanchTech = this;
			return floroRanchTech.GetPreNodeArray() ?? Array.Empty<int>();
		}

		// Token: 0x060074C8 RID: 29896 RVA: 0x0023E7EC File Offset: 0x0023C9EC
		[NullableContext(1)]
		public readonly IEnumerable<int> PreNodeIter()
		{
			FloroRanchTech.<PreNodeIter>d__38 <PreNodeIter>d__ = new FloroRanchTech.<PreNodeIter>d__38(-2);
			<PreNodeIter>d__.<>3__<>4__this = this;
			return <PreNodeIter>d__;
		}

		// Token: 0x04004D26 RID: 19750
		private Table __p;
	}
}
