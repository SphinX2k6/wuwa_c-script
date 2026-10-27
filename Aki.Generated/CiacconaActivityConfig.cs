using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B74 RID: 2932
	public struct CiacconaActivityConfig : IFlatbufferObject
	{
		// Token: 0x170007DD RID: 2013
		// (get) Token: 0x060054EE RID: 21742 RVA: 0x001F4B65 File Offset: 0x001F2D65
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060054EF RID: 21743 RVA: 0x001F4B72 File Offset: 0x001F2D72
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060054F0 RID: 21744 RVA: 0x001F4B7C File Offset: 0x001F2D7C
		public static CiacconaActivityConfig GetRootAsCiacconaActivityConfig(ByteBuffer _bb)
		{
			return CiacconaActivityConfig.GetRootAsCiacconaActivityConfig(_bb, default(CiacconaActivityConfig));
		}

		// Token: 0x060054F1 RID: 21745 RVA: 0x001F4B98 File Offset: 0x001F2D98
		public static CiacconaActivityConfig GetRootAsCiacconaActivityConfig(ByteBuffer _bb, CiacconaActivityConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060054F2 RID: 21746 RVA: 0x001F4BB5 File Offset: 0x001F2DB5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060054F3 RID: 21747 RVA: 0x001F4BC4 File Offset: 0x001F2DC4
		public CiacconaActivityConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170007DE RID: 2014
		// (get) Token: 0x060054F4 RID: 21748 RVA: 0x001F4BD4 File Offset: 0x001F2DD4
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

		// Token: 0x060054F5 RID: 21749 RVA: 0x001F4C10 File Offset: 0x001F2E10
		public int Slots(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170007DF RID: 2015
		// (get) Token: 0x060054F6 RID: 21750 RVA: 0x001F4C50 File Offset: 0x001F2E50
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

		// Token: 0x060054F7 RID: 21751 RVA: 0x001F4C7B File Offset: 0x001F2E7B
		public Span<int> GetSlotsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x060054F8 RID: 21752 RVA: 0x001F4C8A File Offset: 0x001F2E8A
		public int[] GetSlotsArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x170007E0 RID: 2016
		// (get) Token: 0x060054F9 RID: 21753 RVA: 0x001F4CA4 File Offset: 0x001F2EA4
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

		// Token: 0x170007E1 RID: 2017
		// (get) Token: 0x060054FA RID: 21754 RVA: 0x001F4CE0 File Offset: 0x001F2EE0
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

		// Token: 0x170007E2 RID: 2018
		// (get) Token: 0x060054FB RID: 21755 RVA: 0x001F4D20 File Offset: 0x001F2F20
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

		// Token: 0x170007E3 RID: 2019
		// (get) Token: 0x060054FC RID: 21756 RVA: 0x001F4D60 File Offset: 0x001F2F60
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

		// Token: 0x170007E4 RID: 2020
		// (get) Token: 0x060054FD RID: 21757 RVA: 0x001F4DA0 File Offset: 0x001F2FA0
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

		// Token: 0x170007E5 RID: 2021
		// (get) Token: 0x060054FE RID: 21758 RVA: 0x001F4DE0 File Offset: 0x001F2FE0
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

		// Token: 0x170007E6 RID: 2022
		// (get) Token: 0x060054FF RID: 21759 RVA: 0x001F4E20 File Offset: 0x001F3020
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

		// Token: 0x170007E7 RID: 2023
		// (get) Token: 0x06005500 RID: 21760 RVA: 0x001F4E60 File Offset: 0x001F3060
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

		// Token: 0x06005501 RID: 21761 RVA: 0x001F4E98 File Offset: 0x001F3098
		public Span<byte> GetRecommendQuestTipsBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06005502 RID: 21762 RVA: 0x001F4EA8 File Offset: 0x001F30A8
		public byte[] GetRecommendQuestTipsArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x06005503 RID: 21763 RVA: 0x001F4EC0 File Offset: 0x001F30C0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SlotsIter()或GetSlotsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Slots()
		{
			CiacconaActivityConfig ciacconaActivityConfig = this;
			return ciacconaActivityConfig.GetSlotsArray() ?? Array.Empty<int>();
		}

		// Token: 0x06005504 RID: 21764 RVA: 0x001F4EE4 File Offset: 0x001F30E4
		[NullableContext(1)]
		public readonly IEnumerable<int> SlotsIter()
		{
			CiacconaActivityConfig.<SlotsIter>d__34 <SlotsIter>d__ = new CiacconaActivityConfig.<SlotsIter>d__34(-2);
			<SlotsIter>d__.<>3__<>4__this = this;
			return <SlotsIter>d__;
		}

		// Token: 0x04004B78 RID: 19320
		private Table __p;
	}
}
