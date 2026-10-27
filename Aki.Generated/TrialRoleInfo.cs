using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001179 RID: 4473
	public struct TrialRoleInfo : IFlatbufferObject
	{
		// Token: 0x17003CDE RID: 15582
		// (get) Token: 0x0600E56B RID: 58731 RVA: 0x0033CB15 File Offset: 0x0033AD15
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E56C RID: 58732 RVA: 0x0033CB22 File Offset: 0x0033AD22
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E56D RID: 58733 RVA: 0x0033CB2C File Offset: 0x0033AD2C
		public static TrialRoleInfo GetRootAsTrialRoleInfo(ByteBuffer _bb)
		{
			return TrialRoleInfo.GetRootAsTrialRoleInfo(_bb, default(TrialRoleInfo));
		}

		// Token: 0x0600E56E RID: 58734 RVA: 0x0033CB48 File Offset: 0x0033AD48
		public static TrialRoleInfo GetRootAsTrialRoleInfo(ByteBuffer _bb, TrialRoleInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E56F RID: 58735 RVA: 0x0033CB65 File Offset: 0x0033AD65
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E570 RID: 58736 RVA: 0x0033CB74 File Offset: 0x0033AD74
		public TrialRoleInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003CDF RID: 15583
		// (get) Token: 0x0600E571 RID: 58737 RVA: 0x0033CB84 File Offset: 0x0033AD84
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

		// Token: 0x17003CE0 RID: 15584
		// (get) Token: 0x0600E572 RID: 58738 RVA: 0x0033CBC0 File Offset: 0x0033ADC0
		public int GroupId
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

		// Token: 0x17003CE1 RID: 15585
		// (get) Token: 0x0600E573 RID: 58739 RVA: 0x0033CBFC File Offset: 0x0033ADFC
		public int Type
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003CE2 RID: 15586
		// (get) Token: 0x0600E574 RID: 58740 RVA: 0x0033CC38 File Offset: 0x0033AE38
		public int WorldLevel
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003CE3 RID: 15587
		// (get) Token: 0x0600E575 RID: 58741 RVA: 0x0033CC78 File Offset: 0x0033AE78
		public int Gender
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return -1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003CE4 RID: 15588
		// (get) Token: 0x0600E576 RID: 58742 RVA: 0x0033CCB8 File Offset: 0x0033AEB8
		public bool OnlyTrial
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003CE5 RID: 15589
		// (get) Token: 0x0600E577 RID: 58743 RVA: 0x0033CCF8 File Offset: 0x0033AEF8
		public bool HideTrialLabel
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003CE6 RID: 15590
		// (get) Token: 0x0600E578 RID: 58744 RVA: 0x0033CD38 File Offset: 0x0033AF38
		public int ParentId
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

		// Token: 0x17003CE7 RID: 15591
		// (get) Token: 0x0600E579 RID: 58745 RVA: 0x0033CD78 File Offset: 0x0033AF78
		public int Level
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

		// Token: 0x17003CE8 RID: 15592
		// (get) Token: 0x0600E57A RID: 58746 RVA: 0x0033CDB8 File Offset: 0x0033AFB8
		public int ResonanceLevel
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

		// Token: 0x17003CE9 RID: 15593
		// (get) Token: 0x0600E57B RID: 58747 RVA: 0x0033CDF8 File Offset: 0x0033AFF8
		public int UnlockSkillLevel
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E57C RID: 58748 RVA: 0x0033CE38 File Offset: 0x0033B038
		public int UnlockSkillNodeList(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003CEA RID: 15594
		// (get) Token: 0x0600E57D RID: 58749 RVA: 0x0033CE78 File Offset: 0x0033B078
		public int UnlockSkillNodeListLength
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

		// Token: 0x0600E57E RID: 58750 RVA: 0x0033CEA4 File Offset: 0x0033B0A4
		public Span<int> GetUnlockSkillNodeListBytes()
		{
			return this.__p.__vector_as_span<int>(26, 4);
		}

		// Token: 0x0600E57F RID: 58751 RVA: 0x0033CEB4 File Offset: 0x0033B0B4
		public int[] GetUnlockSkillNodeListArray()
		{
			return this.__p.__vector_as_array<int>(26) ?? Array.Empty<int>();
		}

		// Token: 0x17003CEB RID: 15595
		// (get) Token: 0x0600E580 RID: 58752 RVA: 0x0033CECC File Offset: 0x0033B0CC
		public int DefaultSkillBranchId
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

		// Token: 0x17003CEC RID: 15596
		// (get) Token: 0x0600E581 RID: 58753 RVA: 0x0033CF0C File Offset: 0x0033B10C
		public int RoleSkin
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

		// Token: 0x17003CED RID: 15597
		// (get) Token: 0x0600E582 RID: 58754 RVA: 0x0033CF4C File Offset: 0x0033B14C
		public int TrailWeapon
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

		// Token: 0x0600E583 RID: 58755 RVA: 0x0033CF8C File Offset: 0x0033B18C
		public IntPair? PhantomEquipList(int j)
		{
			int num = this.__p.__offset(34);
			if (num == 0)
			{
				return null;
			}
			return new IntPair?(default(IntPair).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003CEE RID: 15598
		// (get) Token: 0x0600E584 RID: 58756 RVA: 0x0033CFF0 File Offset: 0x0033B1F0
		public int PhantomEquipListLength
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

		// Token: 0x17003CEF RID: 15599
		// (get) Token: 0x0600E585 RID: 58757 RVA: 0x0033D01C File Offset: 0x0033B21C
		public string SpinePrefabResource
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

		// Token: 0x0600E586 RID: 58758 RVA: 0x0033D054 File Offset: 0x0033B254
		public Span<byte> GetSpinePrefabResourceBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x0600E587 RID: 58759 RVA: 0x0033D064 File Offset: 0x0033B264
		public byte[] GetSpinePrefabResourceArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x17003CF0 RID: 15600
		// (get) Token: 0x0600E588 RID: 58760 RVA: 0x0033D07C File Offset: 0x0033B27C
		public string ContentTexturePath
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E589 RID: 58761 RVA: 0x0033D0B4 File Offset: 0x0033B2B4
		public Span<byte> GetContentTexturePathBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x0600E58A RID: 58762 RVA: 0x0033D0C4 File Offset: 0x0033B2C4
		public byte[] GetContentTexturePathArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x0600E58B RID: 58763 RVA: 0x0033D0DC File Offset: 0x0033B2DC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PhantomEquipListIter()或GetPhantomEquipListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly IntPair[] PhantomEquipList()
		{
			return this.PhantomEquipListIter().ToArray<IntPair>();
		}

		// Token: 0x0600E58C RID: 58764 RVA: 0x0033D0E9 File Offset: 0x0033B2E9
		[NullableContext(1)]
		public readonly IEnumerable<IntPair> PhantomEquipListIter()
		{
			TrialRoleInfo.<PhantomEquipListIter>d__53 <PhantomEquipListIter>d__ = new TrialRoleInfo.<PhantomEquipListIter>d__53(-2);
			<PhantomEquipListIter>d__.<>3__<>4__this = this;
			return <PhantomEquipListIter>d__;
		}

		// Token: 0x0600E58D RID: 58765 RVA: 0x0033D100 File Offset: 0x0033B300
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用UnlockSkillNodeListIter()或GetUnlockSkillNodeListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] UnlockSkillNodeList()
		{
			TrialRoleInfo trialRoleInfo = this;
			return trialRoleInfo.GetUnlockSkillNodeListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600E58E RID: 58766 RVA: 0x0033D124 File Offset: 0x0033B324
		[NullableContext(1)]
		public readonly IEnumerable<int> UnlockSkillNodeListIter()
		{
			TrialRoleInfo.<UnlockSkillNodeListIter>d__55 <UnlockSkillNodeListIter>d__ = new TrialRoleInfo.<UnlockSkillNodeListIter>d__55(-2);
			<UnlockSkillNodeListIter>d__.<>3__<>4__this = this;
			return <UnlockSkillNodeListIter>d__;
		}

		// Token: 0x040052BF RID: 21183
		private Table __p;
	}
}
