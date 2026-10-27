using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FB6 RID: 4022
	public struct Reigns : IFlatbufferObject
	{
		// Token: 0x17002DD9 RID: 11737
		// (get) Token: 0x0600BB5B RID: 47963 RVA: 0x002DCCCD File Offset: 0x002DAECD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BB5C RID: 47964 RVA: 0x002DCCDA File Offset: 0x002DAEDA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BB5D RID: 47965 RVA: 0x002DCCE4 File Offset: 0x002DAEE4
		public static Reigns GetRootAsReigns(ByteBuffer _bb)
		{
			return Reigns.GetRootAsReigns(_bb, default(Reigns));
		}

		// Token: 0x0600BB5E RID: 47966 RVA: 0x002DCD00 File Offset: 0x002DAF00
		public static Reigns GetRootAsReigns(ByteBuffer _bb, Reigns obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BB5F RID: 47967 RVA: 0x002DCD1D File Offset: 0x002DAF1D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BB60 RID: 47968 RVA: 0x002DCD2C File Offset: 0x002DAF2C
		public Reigns __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002DDA RID: 11738
		// (get) Token: 0x0600BB61 RID: 47969 RVA: 0x002DCD3C File Offset: 0x002DAF3C
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

		// Token: 0x17002DDB RID: 11739
		// (get) Token: 0x0600BB62 RID: 47970 RVA: 0x002DCD78 File Offset: 0x002DAF78
		public int NextReignsId
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

		// Token: 0x17002DDC RID: 11740
		// (get) Token: 0x0600BB63 RID: 47971 RVA: 0x002DCDB4 File Offset: 0x002DAFB4
		public int PropertyDownReducePercent
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

		// Token: 0x17002DDD RID: 11741
		// (get) Token: 0x0600BB64 RID: 47972 RVA: 0x002DCDF0 File Offset: 0x002DAFF0
		public string TargetText
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

		// Token: 0x0600BB65 RID: 47973 RVA: 0x002DCE28 File Offset: 0x002DB028
		public Span<byte> GetTargetTextBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600BB66 RID: 47974 RVA: 0x002DCE38 File Offset: 0x002DB038
		public byte[] GetTargetTextArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002DDE RID: 11742
		// (get) Token: 0x0600BB67 RID: 47975 RVA: 0x002DCE50 File Offset: 0x002DB050
		public string TitleText
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

		// Token: 0x0600BB68 RID: 47976 RVA: 0x002DCE88 File Offset: 0x002DB088
		public Span<byte> GetTitleTextBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600BB69 RID: 47977 RVA: 0x002DCE98 File Offset: 0x002DB098
		public byte[] GetTitleTextArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x0600BB6A RID: 47978 RVA: 0x002DCEB0 File Offset: 0x002DB0B0
		public string FlowId(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002DDF RID: 11743
		// (get) Token: 0x0600BB6B RID: 47979 RVA: 0x002DCEEC File Offset: 0x002DB0EC
		public int FlowIdLength
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

		// Token: 0x17002DE0 RID: 11744
		// (get) Token: 0x0600BB6C RID: 47980 RVA: 0x002DCF18 File Offset: 0x002DB118
		public string EndingList
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600BB6D RID: 47981 RVA: 0x002DCF50 File Offset: 0x002DB150
		public Span<byte> GetEndingListBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600BB6E RID: 47982 RVA: 0x002DCF60 File Offset: 0x002DB160
		public byte[] GetEndingListArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002DE1 RID: 11745
		// (get) Token: 0x0600BB6F RID: 47983 RVA: 0x002DCF78 File Offset: 0x002DB178
		public string BaseProperty
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

		// Token: 0x0600BB70 RID: 47984 RVA: 0x002DCFB0 File Offset: 0x002DB1B0
		public Span<byte> GetBasePropertyBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600BB71 RID: 47985 RVA: 0x002DCFC0 File Offset: 0x002DB1C0
		public byte[] GetBasePropertyArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x0600BB72 RID: 47986 RVA: 0x002DCFD8 File Offset: 0x002DB1D8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用FlowIdIter()或GetFlowIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] FlowId()
		{
			return this.FlowIdIter().ToArray<string>();
		}

		// Token: 0x0600BB73 RID: 47987 RVA: 0x002DCFE5 File Offset: 0x002DB1E5
		[NullableContext(1)]
		public readonly IEnumerable<string> FlowIdIter()
		{
			Reigns.<FlowIdIter>d__34 <FlowIdIter>d__ = new Reigns.<FlowIdIter>d__34(-2);
			<FlowIdIter>d__.<>3__<>4__this = this;
			return <FlowIdIter>d__;
		}

		// Token: 0x0400508F RID: 20623
		private Table __p;
	}
}
