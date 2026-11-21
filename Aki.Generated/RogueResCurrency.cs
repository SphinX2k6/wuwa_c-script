using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010E0 RID: 4320
	public struct RogueResCurrency : IFlatbufferObject
	{
		// Token: 0x1700306A RID: 12394
		// (get) Token: 0x0600C7A9 RID: 51113 RVA: 0x003066FE File Offset: 0x003048FE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C7AA RID: 51114 RVA: 0x0030670B File Offset: 0x0030490B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C7AB RID: 51115 RVA: 0x00306714 File Offset: 0x00304914
		public static RogueResCurrency GetRootAsRogueResCurrency(ByteBuffer _bb)
		{
			return RogueResCurrency.GetRootAsRogueResCurrency(_bb, default(RogueResCurrency));
		}

		// Token: 0x0600C7AC RID: 51116 RVA: 0x00306730 File Offset: 0x00304930
		public static RogueResCurrency GetRootAsRogueResCurrency(ByteBuffer _bb, RogueResCurrency obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C7AD RID: 51117 RVA: 0x0030674D File Offset: 0x0030494D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C7AE RID: 51118 RVA: 0x0030675C File Offset: 0x0030495C
		public RogueResCurrency __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700306B RID: 12395
		// (get) Token: 0x0600C7AF RID: 51119 RVA: 0x0030676C File Offset: 0x0030496C
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

		// Token: 0x1700306C RID: 12396
		// (get) Token: 0x0600C7B0 RID: 51120 RVA: 0x003067A8 File Offset: 0x003049A8
		public int QualityId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C7B1 RID: 51121 RVA: 0x003067E4 File Offset: 0x003049E4
		public int ItemAccess(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700306D RID: 12397
		// (get) Token: 0x0600C7B2 RID: 51122 RVA: 0x00306824 File Offset: 0x00304A24
		public int ItemAccessLength
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

		// Token: 0x0600C7B3 RID: 51123 RVA: 0x0030684F File Offset: 0x00304A4F
		public Span<int> GetItemAccessBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600C7B4 RID: 51124 RVA: 0x0030685E File Offset: 0x00304A5E
		public int[] GetItemAccessArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x1700306E RID: 12398
		// (get) Token: 0x0600C7B5 RID: 51125 RVA: 0x00306878 File Offset: 0x00304A78
		public int SortIndex
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

		// Token: 0x1700306F RID: 12399
		// (get) Token: 0x0600C7B6 RID: 51126 RVA: 0x003068B8 File Offset: 0x00304AB8
		public string ImagePath
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

		// Token: 0x0600C7B7 RID: 51127 RVA: 0x003068F0 File Offset: 0x00304AF0
		public Span<byte> GetImagePathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600C7B8 RID: 51128 RVA: 0x00306900 File Offset: 0x00304B00
		public byte[] GetImagePathArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17003070 RID: 12400
		// (get) Token: 0x0600C7B9 RID: 51129 RVA: 0x00306918 File Offset: 0x00304B18
		public string Icon
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

		// Token: 0x0600C7BA RID: 51130 RVA: 0x00306950 File Offset: 0x00304B50
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600C7BB RID: 51131 RVA: 0x00306960 File Offset: 0x00304B60
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17003071 RID: 12401
		// (get) Token: 0x0600C7BC RID: 51132 RVA: 0x00306978 File Offset: 0x00304B78
		public string IconMiddle
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

		// Token: 0x0600C7BD RID: 51133 RVA: 0x003069B0 File Offset: 0x00304BB0
		public Span<byte> GetIconMiddleBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600C7BE RID: 51134 RVA: 0x003069C0 File Offset: 0x00304BC0
		public byte[] GetIconMiddleArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17003072 RID: 12402
		// (get) Token: 0x0600C7BF RID: 51135 RVA: 0x003069D8 File Offset: 0x00304BD8
		public string IconSmall
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

		// Token: 0x0600C7C0 RID: 51136 RVA: 0x00306A10 File Offset: 0x00304C10
		public Span<byte> GetIconSmallBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600C7C1 RID: 51137 RVA: 0x00306A20 File Offset: 0x00304C20
		public byte[] GetIconSmallArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17003073 RID: 12403
		// (get) Token: 0x0600C7C2 RID: 51138 RVA: 0x00306A38 File Offset: 0x00304C38
		public string Title
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

		// Token: 0x0600C7C3 RID: 51139 RVA: 0x00306A70 File Offset: 0x00304C70
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600C7C4 RID: 51140 RVA: 0x00306A80 File Offset: 0x00304C80
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17003074 RID: 12404
		// (get) Token: 0x0600C7C5 RID: 51141 RVA: 0x00306A98 File Offset: 0x00304C98
		public string AttributesDescription
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

		// Token: 0x0600C7C6 RID: 51142 RVA: 0x00306AD0 File Offset: 0x00304CD0
		public Span<byte> GetAttributesDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600C7C7 RID: 51143 RVA: 0x00306AE0 File Offset: 0x00304CE0
		public byte[] GetAttributesDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17003075 RID: 12405
		// (get) Token: 0x0600C7C8 RID: 51144 RVA: 0x00306AF8 File Offset: 0x00304CF8
		public string ObtainedShowDescription
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

		// Token: 0x0600C7C9 RID: 51145 RVA: 0x00306B30 File Offset: 0x00304D30
		public Span<byte> GetObtainedShowDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600C7CA RID: 51146 RVA: 0x00306B40 File Offset: 0x00304D40
		public byte[] GetObtainedShowDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17003076 RID: 12406
		// (get) Token: 0x0600C7CB RID: 51147 RVA: 0x00306B58 File Offset: 0x00304D58
		public string TypeDescription
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

		// Token: 0x0600C7CC RID: 51148 RVA: 0x00306B90 File Offset: 0x00304D90
		public Span<byte> GetTypeDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600C7CD RID: 51149 RVA: 0x00306BA0 File Offset: 0x00304DA0
		public byte[] GetTypeDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17003077 RID: 12407
		// (get) Token: 0x0600C7CE RID: 51150 RVA: 0x00306BB8 File Offset: 0x00304DB8
		public string BgDescription
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C7CF RID: 51151 RVA: 0x00306BF0 File Offset: 0x00304DF0
		public Span<byte> GetBgDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600C7D0 RID: 51152 RVA: 0x00306C00 File Offset: 0x00304E00
		public byte[] GetBgDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17003078 RID: 12408
		// (get) Token: 0x0600C7D1 RID: 51153 RVA: 0x00306C18 File Offset: 0x00304E18
		public string Tips
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C7D2 RID: 51154 RVA: 0x00306C50 File Offset: 0x00304E50
		public Span<byte> GetTipsBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600C7D3 RID: 51155 RVA: 0x00306C60 File Offset: 0x00304E60
		public byte[] GetTipsArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x17003079 RID: 12409
		// (get) Token: 0x0600C7D4 RID: 51156 RVA: 0x00306C78 File Offset: 0x00304E78
		public bool ShowInBag
		{
			get
			{
				int num = this.__p.__offset(32);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700307A RID: 12410
		// (get) Token: 0x0600C7D5 RID: 51157 RVA: 0x00306CB8 File Offset: 0x00304EB8
		public int RedDotDisableRule
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C7D6 RID: 51158 RVA: 0x00306CF5 File Offset: 0x00304EF5
		[NullableContext(1)]
		public int[] ItemAccess()
		{
			return this.GetItemAccessArray();
		}

		// Token: 0x0600C7D7 RID: 51159 RVA: 0x00306CFD File Offset: 0x00304EFD
		[NullableContext(1)]
		public IEnumerable<int> ItemAccessIter()
		{
			RogueResCurrency.<ItemAccessIter>d__64 <ItemAccessIter>d__ = new RogueResCurrency.<ItemAccessIter>d__64(-2);
			<ItemAccessIter>d__.<>3__<>4__this = this;
			return <ItemAccessIter>d__;
		}

		// Token: 0x040056C8 RID: 22216
		private Table __p;
	}
}
