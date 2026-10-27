using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FA9 RID: 4009
	public struct RegressBase : IFlatbufferObject
	{
		// Token: 0x17002D7C RID: 11644
		// (get) Token: 0x0600BA9A RID: 47770 RVA: 0x002DB160 File Offset: 0x002D9360
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BA9B RID: 47771 RVA: 0x002DB16D File Offset: 0x002D936D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BA9C RID: 47772 RVA: 0x002DB174 File Offset: 0x002D9374
		public static RegressBase GetRootAsRegressBase(ByteBuffer _bb)
		{
			return RegressBase.GetRootAsRegressBase(_bb, default(RegressBase));
		}

		// Token: 0x0600BA9D RID: 47773 RVA: 0x002DB190 File Offset: 0x002D9390
		public static RegressBase GetRootAsRegressBase(ByteBuffer _bb, RegressBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BA9E RID: 47774 RVA: 0x002DB1AD File Offset: 0x002D93AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BA9F RID: 47775 RVA: 0x002DB1BC File Offset: 0x002D93BC
		public RegressBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002D7D RID: 11645
		// (get) Token: 0x0600BAA0 RID: 47776 RVA: 0x002DB1CC File Offset: 0x002D93CC
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

		// Token: 0x17002D7E RID: 11646
		// (get) Token: 0x0600BAA1 RID: 47777 RVA: 0x002DB208 File Offset: 0x002D9408
		public int EntryType
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

		// Token: 0x0600BAA2 RID: 47778 RVA: 0x002DB244 File Offset: 0x002D9444
		public int ArgId(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002D7F RID: 11647
		// (get) Token: 0x0600BAA3 RID: 47779 RVA: 0x002DB284 File Offset: 0x002D9484
		public int ArgIdLength
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

		// Token: 0x0600BAA4 RID: 47780 RVA: 0x002DB2AF File Offset: 0x002D94AF
		public Span<int> GetArgIdBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600BAA5 RID: 47781 RVA: 0x002DB2BE File Offset: 0x002D94BE
		public int[] GetArgIdArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x17002D80 RID: 11648
		// (get) Token: 0x0600BAA6 RID: 47782 RVA: 0x002DB2D8 File Offset: 0x002D94D8
		public int GachaId
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

		// Token: 0x17002D81 RID: 11649
		// (get) Token: 0x0600BAA7 RID: 47783 RVA: 0x002DB318 File Offset: 0x002D9518
		public string Title
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

		// Token: 0x0600BAA8 RID: 47784 RVA: 0x002DB350 File Offset: 0x002D9550
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600BAA9 RID: 47785 RVA: 0x002DB360 File Offset: 0x002D9560
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002D82 RID: 11650
		// (get) Token: 0x0600BAAA RID: 47786 RVA: 0x002DB378 File Offset: 0x002D9578
		public string SubTitle
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600BAAB RID: 47787 RVA: 0x002DB3B0 File Offset: 0x002D95B0
		public Span<byte> GetSubTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600BAAC RID: 47788 RVA: 0x002DB3C0 File Offset: 0x002D95C0
		public byte[] GetSubTitleArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002D83 RID: 11651
		// (get) Token: 0x0600BAAD RID: 47789 RVA: 0x002DB3D8 File Offset: 0x002D95D8
		public string BgPathF
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

		// Token: 0x0600BAAE RID: 47790 RVA: 0x002DB410 File Offset: 0x002D9610
		public Span<byte> GetBgPathFBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600BAAF RID: 47791 RVA: 0x002DB420 File Offset: 0x002D9620
		public byte[] GetBgPathFArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002D84 RID: 11652
		// (get) Token: 0x0600BAB0 RID: 47792 RVA: 0x002DB438 File Offset: 0x002D9638
		public string BgPath
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

		// Token: 0x0600BAB1 RID: 47793 RVA: 0x002DB470 File Offset: 0x002D9670
		public Span<byte> GetBgPathBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600BAB2 RID: 47794 RVA: 0x002DB480 File Offset: 0x002D9680
		public byte[] GetBgPathArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17002D85 RID: 11653
		// (get) Token: 0x0600BAB3 RID: 47795 RVA: 0x002DB498 File Offset: 0x002D9698
		public string Description
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600BAB4 RID: 47796 RVA: 0x002DB4D0 File Offset: 0x002D96D0
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600BAB5 RID: 47797 RVA: 0x002DB4E0 File Offset: 0x002D96E0
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17002D86 RID: 11654
		// (get) Token: 0x0600BAB6 RID: 47798 RVA: 0x002DB4F8 File Offset: 0x002D96F8
		public int RewardPreview
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002D87 RID: 11655
		// (get) Token: 0x0600BAB7 RID: 47799 RVA: 0x002DB538 File Offset: 0x002D9738
		public int TargetActivityId
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002D88 RID: 11656
		// (get) Token: 0x0600BAB8 RID: 47800 RVA: 0x002DB578 File Offset: 0x002D9778
		public string JumpBtnDes
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600BAB9 RID: 47801 RVA: 0x002DB5B0 File Offset: 0x002D97B0
		public Span<byte> GetJumpBtnDesBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600BABA RID: 47802 RVA: 0x002DB5C0 File Offset: 0x002D97C0
		public byte[] GetJumpBtnDesArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x0600BABB RID: 47803 RVA: 0x002DB5D8 File Offset: 0x002D97D8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ArgIdIter()或GetArgIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ArgId()
		{
			RegressBase regressBase = this;
			return regressBase.GetArgIdArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600BABC RID: 47804 RVA: 0x002DB5FC File Offset: 0x002D97FC
		[NullableContext(1)]
		public readonly IEnumerable<int> ArgIdIter()
		{
			RegressBase.<ArgIdIter>d__48 <ArgIdIter>d__ = new RegressBase.<ArgIdIter>d__48(-2);
			<ArgIdIter>d__.<>3__<>4__this = this;
			return <ArgIdIter>d__;
		}

		// Token: 0x04005082 RID: 20610
		private Table __p;
	}
}
