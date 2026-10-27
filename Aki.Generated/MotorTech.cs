using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E6D RID: 3693
	public struct MotorTech : IFlatbufferObject
	{
		// Token: 0x17002253 RID: 8787
		// (get) Token: 0x06009C87 RID: 40071 RVA: 0x0029830D File Offset: 0x0029650D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009C88 RID: 40072 RVA: 0x0029831A File Offset: 0x0029651A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009C89 RID: 40073 RVA: 0x00298324 File Offset: 0x00296524
		public static MotorTech GetRootAsMotorTech(ByteBuffer _bb)
		{
			return MotorTech.GetRootAsMotorTech(_bb, default(MotorTech));
		}

		// Token: 0x06009C8A RID: 40074 RVA: 0x00298340 File Offset: 0x00296540
		public static MotorTech GetRootAsMotorTech(ByteBuffer _bb, MotorTech obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009C8B RID: 40075 RVA: 0x0029835D File Offset: 0x0029655D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009C8C RID: 40076 RVA: 0x0029836C File Offset: 0x0029656C
		public MotorTech __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002254 RID: 8788
		// (get) Token: 0x06009C8D RID: 40077 RVA: 0x0029837C File Offset: 0x0029657C
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

		// Token: 0x17002255 RID: 8789
		// (get) Token: 0x06009C8E RID: 40078 RVA: 0x002983B8 File Offset: 0x002965B8
		public int TreeType
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

		// Token: 0x17002256 RID: 8790
		// (get) Token: 0x06009C8F RID: 40079 RVA: 0x002983F4 File Offset: 0x002965F4
		public int GeneralNodeSortOrder
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

		// Token: 0x06009C90 RID: 40080 RVA: 0x00298430 File Offset: 0x00296630
		public int ExclusiveNodeSortOrder(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002257 RID: 8791
		// (get) Token: 0x06009C91 RID: 40081 RVA: 0x00298470 File Offset: 0x00296670
		public int ExclusiveNodeSortOrderLength
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

		// Token: 0x06009C92 RID: 40082 RVA: 0x0029849C File Offset: 0x0029669C
		public Span<int> GetExclusiveNodeSortOrderBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06009C93 RID: 40083 RVA: 0x002984AC File Offset: 0x002966AC
		public int[] GetExclusiveNodeSortOrderArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x17002258 RID: 8792
		// (get) Token: 0x06009C94 RID: 40084 RVA: 0x002984C4 File Offset: 0x002966C4
		public int DetailOrder
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

		// Token: 0x17002259 RID: 8793
		// (get) Token: 0x06009C95 RID: 40085 RVA: 0x00298504 File Offset: 0x00296704
		public int ShowStyle
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

		// Token: 0x1700225A RID: 8794
		// (get) Token: 0x06009C96 RID: 40086 RVA: 0x00298544 File Offset: 0x00296744
		public string Icon
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

		// Token: 0x06009C97 RID: 40087 RVA: 0x0029857C File Offset: 0x0029677C
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06009C98 RID: 40088 RVA: 0x0029858C File Offset: 0x0029678C
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x1700225B RID: 8795
		// (get) Token: 0x06009C99 RID: 40089 RVA: 0x002985A4 File Offset: 0x002967A4
		public string VideoName
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

		// Token: 0x06009C9A RID: 40090 RVA: 0x002985DC File Offset: 0x002967DC
		public Span<byte> GetVideoNameBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06009C9B RID: 40091 RVA: 0x002985EC File Offset: 0x002967EC
		public byte[] GetVideoNameArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x1700225C RID: 8796
		// (get) Token: 0x06009C9C RID: 40092 RVA: 0x00298604 File Offset: 0x00296804
		public string Video
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

		// Token: 0x06009C9D RID: 40093 RVA: 0x0029863C File Offset: 0x0029683C
		public Span<byte> GetVideoBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06009C9E RID: 40094 RVA: 0x0029864C File Offset: 0x0029684C
		public byte[] GetVideoArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x1700225D RID: 8797
		// (get) Token: 0x06009C9F RID: 40095 RVA: 0x00298664 File Offset: 0x00296864
		public string VideoFemale
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

		// Token: 0x06009CA0 RID: 40096 RVA: 0x0029869C File Offset: 0x0029689C
		public Span<byte> GetVideoFemaleBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06009CA1 RID: 40097 RVA: 0x002986AC File Offset: 0x002968AC
		public byte[] GetVideoFemaleArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x1700225E RID: 8798
		// (get) Token: 0x06009CA2 RID: 40098 RVA: 0x002986C4 File Offset: 0x002968C4
		public string Title
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009CA3 RID: 40099 RVA: 0x002986FC File Offset: 0x002968FC
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06009CA4 RID: 40100 RVA: 0x0029870C File Offset: 0x0029690C
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x1700225F RID: 8799
		// (get) Token: 0x06009CA5 RID: 40101 RVA: 0x00298724 File Offset: 0x00296924
		public string DescSimple
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

		// Token: 0x06009CA6 RID: 40102 RVA: 0x0029875C File Offset: 0x0029695C
		public Span<byte> GetDescSimpleBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06009CA7 RID: 40103 RVA: 0x0029876C File Offset: 0x0029696C
		public byte[] GetDescSimpleArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17002260 RID: 8800
		// (get) Token: 0x06009CA8 RID: 40104 RVA: 0x00298784 File Offset: 0x00296984
		public int TagId
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002261 RID: 8801
		// (get) Token: 0x06009CA9 RID: 40105 RVA: 0x002987C4 File Offset: 0x002969C4
		public int Type
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009CAA RID: 40106 RVA: 0x00298804 File Offset: 0x00296A04
		public int PreNode(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002262 RID: 8802
		// (get) Token: 0x06009CAB RID: 40107 RVA: 0x00298844 File Offset: 0x00296A44
		public int PreNodeLength
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06009CAC RID: 40108 RVA: 0x00298870 File Offset: 0x00296A70
		public Span<int> GetPreNodeBytes()
		{
			return this.__p.__vector_as_span<int>(32, 4);
		}

		// Token: 0x06009CAD RID: 40109 RVA: 0x00298880 File Offset: 0x00296A80
		public int[] GetPreNodeArray()
		{
			return this.__p.__vector_as_array<int>(32) ?? Array.Empty<int>();
		}

		// Token: 0x06009CAE RID: 40110 RVA: 0x00298898 File Offset: 0x00296A98
		public int TechLv(int j)
		{
			int num = this.__p.__offset(34);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002263 RID: 8803
		// (get) Token: 0x06009CAF RID: 40111 RVA: 0x002988D8 File Offset: 0x00296AD8
		public int TechLvLength
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06009CB0 RID: 40112 RVA: 0x00298904 File Offset: 0x00296B04
		public Span<int> GetTechLvBytes()
		{
			return this.__p.__vector_as_span<int>(34, 4);
		}

		// Token: 0x06009CB1 RID: 40113 RVA: 0x00298914 File Offset: 0x00296B14
		public int[] GetTechLvArray()
		{
			return this.__p.__vector_as_array<int>(34) ?? Array.Empty<int>();
		}

		// Token: 0x17002264 RID: 8804
		// (get) Token: 0x06009CB2 RID: 40114 RVA: 0x0029892C File Offset: 0x00296B2C
		public int InitLevel
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002265 RID: 8805
		// (get) Token: 0x06009CB3 RID: 40115 RVA: 0x0029896C File Offset: 0x00296B6C
		public int UnlockCondition
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002266 RID: 8806
		// (get) Token: 0x06009CB4 RID: 40116 RVA: 0x002989AC File Offset: 0x00296BAC
		public string UnlockConditionDesc
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009CB5 RID: 40117 RVA: 0x002989E4 File Offset: 0x00296BE4
		public Span<byte> GetUnlockConditionDescBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x06009CB6 RID: 40118 RVA: 0x002989F4 File Offset: 0x00296BF4
		public byte[] GetUnlockConditionDescArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x17002267 RID: 8807
		// (get) Token: 0x06009CB7 RID: 40119 RVA: 0x00298A0C File Offset: 0x00296C0C
		public string NotActivatedPreviewDesc
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009CB8 RID: 40120 RVA: 0x00298A44 File Offset: 0x00296C44
		public Span<byte> GetNotActivatedPreviewDescBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x06009CB9 RID: 40121 RVA: 0x00298A54 File Offset: 0x00296C54
		public byte[] GetNotActivatedPreviewDescArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x06009CBA RID: 40122 RVA: 0x00298A6C File Offset: 0x00296C6C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ExclusiveNodeSortOrderIter()或GetExclusiveNodeSortOrderBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ExclusiveNodeSortOrder()
		{
			MotorTech motorTech = this;
			return motorTech.GetExclusiveNodeSortOrderArray() ?? Array.Empty<int>();
		}

		// Token: 0x06009CBB RID: 40123 RVA: 0x00298A90 File Offset: 0x00296C90
		[NullableContext(1)]
		public readonly IEnumerable<int> ExclusiveNodeSortOrderIter()
		{
			MotorTech.<ExclusiveNodeSortOrderIter>d__74 <ExclusiveNodeSortOrderIter>d__ = new MotorTech.<ExclusiveNodeSortOrderIter>d__74(-2);
			<ExclusiveNodeSortOrderIter>d__.<>3__<>4__this = this;
			return <ExclusiveNodeSortOrderIter>d__;
		}

		// Token: 0x06009CBC RID: 40124 RVA: 0x00298AA8 File Offset: 0x00296CA8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PreNodeIter()或GetPreNodeBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] PreNode()
		{
			MotorTech motorTech = this;
			return motorTech.GetPreNodeArray() ?? Array.Empty<int>();
		}

		// Token: 0x06009CBD RID: 40125 RVA: 0x00298ACC File Offset: 0x00296CCC
		[NullableContext(1)]
		public readonly IEnumerable<int> PreNodeIter()
		{
			MotorTech.<PreNodeIter>d__76 <PreNodeIter>d__ = new MotorTech.<PreNodeIter>d__76(-2);
			<PreNodeIter>d__.<>3__<>4__this = this;
			return <PreNodeIter>d__;
		}

		// Token: 0x06009CBE RID: 40126 RVA: 0x00298AE4 File Offset: 0x00296CE4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用TechLvIter()或GetTechLvBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] TechLv()
		{
			MotorTech motorTech = this;
			return motorTech.GetTechLvArray() ?? Array.Empty<int>();
		}

		// Token: 0x06009CBF RID: 40127 RVA: 0x00298B08 File Offset: 0x00296D08
		[NullableContext(1)]
		public readonly IEnumerable<int> TechLvIter()
		{
			MotorTech.<TechLvIter>d__78 <TechLvIter>d__ = new MotorTech.<TechLvIter>d__78(-2);
			<TechLvIter>d__.<>3__<>4__this = this;
			return <TechLvIter>d__;
		}

		// Token: 0x04004F1B RID: 20251
		private Table __p;
	}
}
