using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200126E RID: 4718
	public struct TowerDefenceInstance : IFlatbufferObject
	{
		// Token: 0x17003E21 RID: 15905
		// (get) Token: 0x0600ED2A RID: 60714 RVA: 0x0035B249 File Offset: 0x00359449
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600ED2B RID: 60715 RVA: 0x0035B256 File Offset: 0x00359456
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600ED2C RID: 60716 RVA: 0x0035B260 File Offset: 0x00359460
		public static TowerDefenceInstance GetRootAsTowerDefenceInstance(ByteBuffer _bb)
		{
			return TowerDefenceInstance.GetRootAsTowerDefenceInstance(_bb, default(TowerDefenceInstance));
		}

		// Token: 0x0600ED2D RID: 60717 RVA: 0x0035B27C File Offset: 0x0035947C
		public static TowerDefenceInstance GetRootAsTowerDefenceInstance(ByteBuffer _bb, TowerDefenceInstance obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600ED2E RID: 60718 RVA: 0x0035B299 File Offset: 0x00359499
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600ED2F RID: 60719 RVA: 0x0035B2A8 File Offset: 0x003594A8
		public TowerDefenceInstance __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003E22 RID: 15906
		// (get) Token: 0x0600ED30 RID: 60720 RVA: 0x0035B2B8 File Offset: 0x003594B8
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

		// Token: 0x17003E23 RID: 15907
		// (get) Token: 0x0600ED31 RID: 60721 RVA: 0x0035B2F4 File Offset: 0x003594F4
		public int InstanceId
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

		// Token: 0x17003E24 RID: 15908
		// (get) Token: 0x0600ED32 RID: 60722 RVA: 0x0035B330 File Offset: 0x00359530
		public int ActivityId
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

		// Token: 0x17003E25 RID: 15909
		// (get) Token: 0x0600ED33 RID: 60723 RVA: 0x0035B36C File Offset: 0x0035956C
		public int GroupId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 999;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003E26 RID: 15910
		// (get) Token: 0x0600ED34 RID: 60724 RVA: 0x0035B3B0 File Offset: 0x003595B0
		public int Difficulty
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

		// Token: 0x17003E27 RID: 15911
		// (get) Token: 0x0600ED35 RID: 60725 RVA: 0x0035B3F0 File Offset: 0x003595F0
		public bool BossRush
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003E28 RID: 15912
		// (get) Token: 0x0600ED36 RID: 60726 RVA: 0x0035B430 File Offset: 0x00359630
		public int SortId
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

		// Token: 0x0600ED37 RID: 60727 RVA: 0x0035B470 File Offset: 0x00359670
		public int OptionalBuff(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003E29 RID: 15913
		// (get) Token: 0x0600ED38 RID: 60728 RVA: 0x0035B4B0 File Offset: 0x003596B0
		public int OptionalBuffLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600ED39 RID: 60729 RVA: 0x0035B4DC File Offset: 0x003596DC
		public Span<int> GetOptionalBuffBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x0600ED3A RID: 60730 RVA: 0x0035B4EC File Offset: 0x003596EC
		public int[] GetOptionalBuffArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x17003E2A RID: 15914
		// (get) Token: 0x0600ED3B RID: 60731 RVA: 0x0035B504 File Offset: 0x00359704
		public int OpenDay
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

		// Token: 0x17003E2B RID: 15915
		// (get) Token: 0x0600ED3C RID: 60732 RVA: 0x0035B544 File Offset: 0x00359744
		public int Condition
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

		// Token: 0x17003E2C RID: 15916
		// (get) Token: 0x0600ED3D RID: 60733 RVA: 0x0035B584 File Offset: 0x00359784
		public int RewardId
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

		// Token: 0x17003E2D RID: 15917
		// (get) Token: 0x0600ED3E RID: 60734 RVA: 0x0035B5C4 File Offset: 0x003597C4
		public int RewardScore
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003E2E RID: 15918
		// (get) Token: 0x0600ED3F RID: 60735 RVA: 0x0035B604 File Offset: 0x00359804
		public string LevelRewardDesc
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

		// Token: 0x0600ED40 RID: 60736 RVA: 0x0035B63C File Offset: 0x0035983C
		public Span<byte> GetLevelRewardDescBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600ED41 RID: 60737 RVA: 0x0035B64C File Offset: 0x0035984C
		public byte[] GetLevelRewardDescArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17003E2F RID: 15919
		// (get) Token: 0x0600ED42 RID: 60738 RVA: 0x0035B664 File Offset: 0x00359864
		public int BaseEntityId
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

		// Token: 0x17003E30 RID: 15920
		// (get) Token: 0x0600ED43 RID: 60739 RVA: 0x0035B6A4 File Offset: 0x003598A4
		public int UnlockScoreLimit
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003E31 RID: 15921
		// (get) Token: 0x0600ED44 RID: 60740 RVA: 0x0035B6E4 File Offset: 0x003598E4
		public bool IsDifficult
		{
			get
			{
				int num = this.__p.__offset(34);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003E32 RID: 15922
		// (get) Token: 0x0600ED45 RID: 60741 RVA: 0x0035B724 File Offset: 0x00359924
		public string BgPath
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600ED46 RID: 60742 RVA: 0x0035B75C File Offset: 0x0035995C
		public Span<byte> GetBgPathBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x0600ED47 RID: 60743 RVA: 0x0035B76C File Offset: 0x0035996C
		public byte[] GetBgPathArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x0600ED48 RID: 60744 RVA: 0x0035B784 File Offset: 0x00359984
		[NullableContext(1)]
		public int[] OptionalBuff()
		{
			return this.GetOptionalBuffArray();
		}

		// Token: 0x0600ED49 RID: 60745 RVA: 0x0035B78C File Offset: 0x0035998C
		[NullableContext(1)]
		public IEnumerable<int> OptionalBuffIter()
		{
			TowerDefenceInstance.<OptionalBuffIter>d__50 <OptionalBuffIter>d__ = new TowerDefenceInstance.<OptionalBuffIter>d__50(-2);
			<OptionalBuffIter>d__.<>3__<>4__this = this;
			return <OptionalBuffIter>d__;
		}

		// Token: 0x040058BC RID: 22716
		private Table __p;
	}
}
