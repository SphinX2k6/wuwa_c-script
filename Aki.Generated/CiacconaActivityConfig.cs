using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C55 RID: 3157
	public struct CiacconaActivityConfig : IFlatbufferObject
	{
		// Token: 0x17000820 RID: 2080
		// (get) Token: 0x06005ABC RID: 23228 RVA: 0x00214991 File Offset: 0x00212B91
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005ABD RID: 23229 RVA: 0x0021499E File Offset: 0x00212B9E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005ABE RID: 23230 RVA: 0x002149A8 File Offset: 0x00212BA8
		public static CiacconaActivityConfig GetRootAsCiacconaActivityConfig(ByteBuffer _bb)
		{
			return CiacconaActivityConfig.GetRootAsCiacconaActivityConfig(_bb, default(CiacconaActivityConfig));
		}

		// Token: 0x06005ABF RID: 23231 RVA: 0x002149C4 File Offset: 0x00212BC4
		public static CiacconaActivityConfig GetRootAsCiacconaActivityConfig(ByteBuffer _bb, CiacconaActivityConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005AC0 RID: 23232 RVA: 0x002149E1 File Offset: 0x00212BE1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005AC1 RID: 23233 RVA: 0x002149F0 File Offset: 0x00212BF0
		public CiacconaActivityConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000821 RID: 2081
		// (get) Token: 0x06005AC2 RID: 23234 RVA: 0x00214A00 File Offset: 0x00212C00
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

		// Token: 0x06005AC3 RID: 23235 RVA: 0x00214A3C File Offset: 0x00212C3C
		public int Slots(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000822 RID: 2082
		// (get) Token: 0x06005AC4 RID: 23236 RVA: 0x00214A7C File Offset: 0x00212C7C
		public int SlotsLength
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

		// Token: 0x06005AC5 RID: 23237 RVA: 0x00214AA7 File Offset: 0x00212CA7
		public Span<int> GetSlotsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06005AC6 RID: 23238 RVA: 0x00214AB6 File Offset: 0x00212CB6
		public int[] GetSlotsArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x17000823 RID: 2083
		// (get) Token: 0x06005AC7 RID: 23239 RVA: 0x00214AD0 File Offset: 0x00212CD0
		public int InspirationInitValue
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

		// Token: 0x17000824 RID: 2084
		// (get) Token: 0x06005AC8 RID: 23240 RVA: 0x00214B0C File Offset: 0x00212D0C
		public int InspirationMaxValue
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

		// Token: 0x17000825 RID: 2085
		// (get) Token: 0x06005AC9 RID: 23241 RVA: 0x00214B4C File Offset: 0x00212D4C
		public int InspirationRecoverSec
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000826 RID: 2086
		// (get) Token: 0x06005ACA RID: 23242 RVA: 0x00214B8C File Offset: 0x00212D8C
		public int LimitRewardDuration
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

		// Token: 0x17000827 RID: 2087
		// (get) Token: 0x06005ACB RID: 23243 RVA: 0x00214BCC File Offset: 0x00212DCC
		public int State1UnlockCondition
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

		// Token: 0x17000828 RID: 2088
		// (get) Token: 0x06005ACC RID: 23244 RVA: 0x00214C0C File Offset: 0x00212E0C
		public int State2UnlockCondition
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

		// Token: 0x17000829 RID: 2089
		// (get) Token: 0x06005ACD RID: 23245 RVA: 0x00214C4C File Offset: 0x00212E4C
		public int RecommendQuestId
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

		// Token: 0x1700082A RID: 2090
		// (get) Token: 0x06005ACE RID: 23246 RVA: 0x00214C8C File Offset: 0x00212E8C
		public string RecommendQuestTips
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

		// Token: 0x06005ACF RID: 23247 RVA: 0x00214CC4 File Offset: 0x00212EC4
		public Span<byte> GetRecommendQuestTipsBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06005AD0 RID: 23248 RVA: 0x00214CD4 File Offset: 0x00212ED4
		public byte[] GetRecommendQuestTipsArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x06005AD1 RID: 23249 RVA: 0x00214CEC File Offset: 0x00212EEC
		[NullableContext(1)]
		public int[] Slots()
		{
			return this.GetSlotsArray();
		}

		// Token: 0x06005AD2 RID: 23250 RVA: 0x00214CF4 File Offset: 0x00212EF4
		[NullableContext(1)]
		public IEnumerable<int> SlotsIter()
		{
			CiacconaActivityConfig.<SlotsIter>d__34 <SlotsIter>d__ = new CiacconaActivityConfig.<SlotsIter>d__34(-2);
			<SlotsIter>d__.<>3__<>4__this = this;
			return <SlotsIter>d__;
		}

		// Token: 0x04005159 RID: 20825
		private Table __p;
	}
}
