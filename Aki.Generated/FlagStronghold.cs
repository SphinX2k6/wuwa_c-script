using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C9A RID: 3226
	public struct FlagStronghold : IFlatbufferObject
	{
		// Token: 0x17001245 RID: 4677
		// (get) Token: 0x060071A3 RID: 29091 RVA: 0x0023698C File Offset: 0x00234B8C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060071A4 RID: 29092 RVA: 0x00236999 File Offset: 0x00234B99
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060071A5 RID: 29093 RVA: 0x002369A0 File Offset: 0x00234BA0
		public static FlagStronghold GetRootAsFlagStronghold(ByteBuffer _bb)
		{
			return FlagStronghold.GetRootAsFlagStronghold(_bb, default(FlagStronghold));
		}

		// Token: 0x060071A6 RID: 29094 RVA: 0x002369BC File Offset: 0x00234BBC
		public static FlagStronghold GetRootAsFlagStronghold(ByteBuffer _bb, FlagStronghold obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060071A7 RID: 29095 RVA: 0x002369D9 File Offset: 0x00234BD9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060071A8 RID: 29096 RVA: 0x002369E8 File Offset: 0x00234BE8
		public FlagStronghold __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001246 RID: 4678
		// (get) Token: 0x060071A9 RID: 29097 RVA: 0x002369F8 File Offset: 0x00234BF8
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

		// Token: 0x17001247 RID: 4679
		// (get) Token: 0x060071AA RID: 29098 RVA: 0x00236A34 File Offset: 0x00234C34
		public int MarkId
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

		// Token: 0x17001248 RID: 4680
		// (get) Token: 0x060071AB RID: 29099 RVA: 0x00236A70 File Offset: 0x00234C70
		public int ChallengeLevelId
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

		// Token: 0x17001249 RID: 4681
		// (get) Token: 0x060071AC RID: 29100 RVA: 0x00236AAC File Offset: 0x00234CAC
		public int AreaId
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

		// Token: 0x1700124A RID: 4682
		// (get) Token: 0x060071AD RID: 29101 RVA: 0x00236AEC File Offset: 0x00234CEC
		public int Type
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

		// Token: 0x1700124B RID: 4683
		// (get) Token: 0x060071AE RID: 29102 RVA: 0x00236B2C File Offset: 0x00234D2C
		public int DropId
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

		// Token: 0x1700124C RID: 4684
		// (get) Token: 0x060071AF RID: 29103 RVA: 0x00236B6C File Offset: 0x00234D6C
		public int EntityConfigId
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

		// Token: 0x1700124D RID: 4685
		// (get) Token: 0x060071B0 RID: 29104 RVA: 0x00236BAC File Offset: 0x00234DAC
		public string Name
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

		// Token: 0x060071B1 RID: 29105 RVA: 0x00236BE4 File Offset: 0x00234DE4
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x060071B2 RID: 29106 RVA: 0x00236BF4 File Offset: 0x00234DF4
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x1700124E RID: 4686
		// (get) Token: 0x060071B3 RID: 29107 RVA: 0x00236C0C File Offset: 0x00234E0C
		public int MonsterLevel
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

		// Token: 0x1700124F RID: 4687
		// (get) Token: 0x060071B4 RID: 29108 RVA: 0x00236C4C File Offset: 0x00234E4C
		public string MonsterIconPath
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

		// Token: 0x060071B5 RID: 29109 RVA: 0x00236C84 File Offset: 0x00234E84
		public Span<byte> GetMonsterIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x060071B6 RID: 29110 RVA: 0x00236C94 File Offset: 0x00234E94
		public byte[] GetMonsterIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17001250 RID: 4688
		// (get) Token: 0x060071B7 RID: 29111 RVA: 0x00236CAC File Offset: 0x00234EAC
		public string MonsterDesc
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

		// Token: 0x060071B8 RID: 29112 RVA: 0x00236CE4 File Offset: 0x00234EE4
		public Span<byte> GetMonsterDescBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x060071B9 RID: 29113 RVA: 0x00236CF4 File Offset: 0x00234EF4
		public byte[] GetMonsterDescArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x060071BA RID: 29114 RVA: 0x00236D0C File Offset: 0x00234F0C
		public int UiRelativePos(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001251 RID: 4689
		// (get) Token: 0x060071BB RID: 29115 RVA: 0x00236D4C File Offset: 0x00234F4C
		public int UiRelativePosLength
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060071BC RID: 29116 RVA: 0x00236D78 File Offset: 0x00234F78
		public Span<int> GetUiRelativePosBytes()
		{
			return this.__p.__vector_as_span<int>(26, 4);
		}

		// Token: 0x060071BD RID: 29117 RVA: 0x00236D88 File Offset: 0x00234F88
		public int[] GetUiRelativePosArray()
		{
			return this.__p.__vector_as_array<int>(26) ?? Array.Empty<int>();
		}

		// Token: 0x17001252 RID: 4690
		// (get) Token: 0x060071BE RID: 29118 RVA: 0x00236DA0 File Offset: 0x00234FA0
		public int Index
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

		// Token: 0x17001253 RID: 4691
		// (get) Token: 0x060071BF RID: 29119 RVA: 0x00236DE0 File Offset: 0x00234FE0
		public int RecommendLevel
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

		// Token: 0x060071C0 RID: 29120 RVA: 0x00236E20 File Offset: 0x00235020
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用UiRelativePosIter()或GetUiRelativePosBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] UiRelativePos()
		{
			FlagStronghold flagStronghold = this;
			return flagStronghold.GetUiRelativePosArray() ?? Array.Empty<int>();
		}

		// Token: 0x060071C1 RID: 29121 RVA: 0x00236E44 File Offset: 0x00235044
		[NullableContext(1)]
		public readonly IEnumerable<int> UiRelativePosIter()
		{
			FlagStronghold.<UiRelativePosIter>d__46 <UiRelativePosIter>d__ = new FlagStronghold.<UiRelativePosIter>d__46(-2);
			<UiRelativePosIter>d__.<>3__<>4__this = this;
			return <UiRelativePosIter>d__;
		}

		// Token: 0x04004CF1 RID: 19697
		private Table __p;
	}
}
