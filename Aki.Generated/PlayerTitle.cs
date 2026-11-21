using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200102D RID: 4141
	public struct PlayerTitle : IFlatbufferObject
	{
		// Token: 0x17002ACA RID: 10954
		// (get) Token: 0x0600B7F1 RID: 47089 RVA: 0x002E4BE0 File Offset: 0x002E2DE0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B7F2 RID: 47090 RVA: 0x002E4BED File Offset: 0x002E2DED
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B7F3 RID: 47091 RVA: 0x002E4BF4 File Offset: 0x002E2DF4
		public static PlayerTitle GetRootAsPlayerTitle(ByteBuffer _bb)
		{
			return PlayerTitle.GetRootAsPlayerTitle(_bb, default(PlayerTitle));
		}

		// Token: 0x0600B7F4 RID: 47092 RVA: 0x002E4C10 File Offset: 0x002E2E10
		public static PlayerTitle GetRootAsPlayerTitle(ByteBuffer _bb, PlayerTitle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B7F5 RID: 47093 RVA: 0x002E4C2D File Offset: 0x002E2E2D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B7F6 RID: 47094 RVA: 0x002E4C3C File Offset: 0x002E2E3C
		public PlayerTitle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002ACB RID: 10955
		// (get) Token: 0x0600B7F7 RID: 47095 RVA: 0x002E4C4C File Offset: 0x002E2E4C
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

		// Token: 0x17002ACC RID: 10956
		// (get) Token: 0x0600B7F8 RID: 47096 RVA: 0x002E4C88 File Offset: 0x002E2E88
		public int TitleType
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

		// Token: 0x17002ACD RID: 10957
		// (get) Token: 0x0600B7F9 RID: 47097 RVA: 0x002E4CC4 File Offset: 0x002E2EC4
		public int LimitTimeId
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

		// Token: 0x17002ACE RID: 10958
		// (get) Token: 0x0600B7FA RID: 47098 RVA: 0x002E4D00 File Offset: 0x002E2F00
		public int TitleStyle
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

		// Token: 0x17002ACF RID: 10959
		// (get) Token: 0x0600B7FB RID: 47099 RVA: 0x002E4D40 File Offset: 0x002E2F40
		public string TitleName
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

		// Token: 0x0600B7FC RID: 47100 RVA: 0x002E4D78 File Offset: 0x002E2F78
		public Span<byte> GetTitleNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600B7FD RID: 47101 RVA: 0x002E4D88 File Offset: 0x002E2F88
		public byte[] GetTitleNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002AD0 RID: 10960
		// (get) Token: 0x0600B7FE RID: 47102 RVA: 0x002E4DA0 File Offset: 0x002E2FA0
		public int TitleQuality
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

		// Token: 0x17002AD1 RID: 10961
		// (get) Token: 0x0600B7FF RID: 47103 RVA: 0x002E4DE0 File Offset: 0x002E2FE0
		public string TitleIcon
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

		// Token: 0x0600B800 RID: 47104 RVA: 0x002E4E18 File Offset: 0x002E3018
		public Span<byte> GetTitleIconBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600B801 RID: 47105 RVA: 0x002E4E28 File Offset: 0x002E3028
		public byte[] GetTitleIconArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002AD2 RID: 10962
		// (get) Token: 0x0600B802 RID: 47106 RVA: 0x002E4E40 File Offset: 0x002E3040
		public string RoleHeadIcon
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

		// Token: 0x0600B803 RID: 47107 RVA: 0x002E4E78 File Offset: 0x002E3078
		public Span<byte> GetRoleHeadIconBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600B804 RID: 47108 RVA: 0x002E4E88 File Offset: 0x002E3088
		public byte[] GetRoleHeadIconArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17002AD3 RID: 10963
		// (get) Token: 0x0600B805 RID: 47109 RVA: 0x002E4EA0 File Offset: 0x002E30A0
		public string FemaleRoleHeadIcon
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

		// Token: 0x0600B806 RID: 47110 RVA: 0x002E4ED8 File Offset: 0x002E30D8
		public Span<byte> GetFemaleRoleHeadIconBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600B807 RID: 47111 RVA: 0x002E4EE8 File Offset: 0x002E30E8
		public byte[] GetFemaleRoleHeadIconArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17002AD4 RID: 10964
		// (get) Token: 0x0600B808 RID: 47112 RVA: 0x002E4F00 File Offset: 0x002E3100
		public string DecorateLeftIcon
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

		// Token: 0x0600B809 RID: 47113 RVA: 0x002E4F38 File Offset: 0x002E3138
		public Span<byte> GetDecorateLeftIconBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600B80A RID: 47114 RVA: 0x002E4F48 File Offset: 0x002E3148
		public byte[] GetDecorateLeftIconArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17002AD5 RID: 10965
		// (get) Token: 0x0600B80B RID: 47115 RVA: 0x002E4F60 File Offset: 0x002E3160
		public string DecorateRightIcon
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

		// Token: 0x0600B80C RID: 47116 RVA: 0x002E4F98 File Offset: 0x002E3198
		public Span<byte> GetDecorateRightIconBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600B80D RID: 47117 RVA: 0x002E4FA8 File Offset: 0x002E31A8
		public byte[] GetDecorateRightIconArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17002AD6 RID: 10966
		// (get) Token: 0x0600B80E RID: 47118 RVA: 0x002E4FC0 File Offset: 0x002E31C0
		public string DecorateLeftNiagara
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

		// Token: 0x0600B80F RID: 47119 RVA: 0x002E4FF8 File Offset: 0x002E31F8
		public Span<byte> GetDecorateLeftNiagaraBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600B810 RID: 47120 RVA: 0x002E5008 File Offset: 0x002E3208
		public byte[] GetDecorateLeftNiagaraArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17002AD7 RID: 10967
		// (get) Token: 0x0600B811 RID: 47121 RVA: 0x002E5020 File Offset: 0x002E3220
		public string DecorateRightNiagara
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

		// Token: 0x0600B812 RID: 47122 RVA: 0x002E5058 File Offset: 0x002E3258
		public Span<byte> GetDecorateRightNiagaraBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600B813 RID: 47123 RVA: 0x002E5068 File Offset: 0x002E3268
		public byte[] GetDecorateRightNiagaraArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17002AD8 RID: 10968
		// (get) Token: 0x0600B814 RID: 47124 RVA: 0x002E5080 File Offset: 0x002E3280
		public string DecorateBgNiagara
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

		// Token: 0x0600B815 RID: 47125 RVA: 0x002E50B8 File Offset: 0x002E32B8
		public Span<byte> GetDecorateBgNiagaraBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600B816 RID: 47126 RVA: 0x002E50C8 File Offset: 0x002E32C8
		public byte[] GetDecorateBgNiagaraArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x17002AD9 RID: 10969
		// (get) Token: 0x0600B817 RID: 47127 RVA: 0x002E50E0 File Offset: 0x002E32E0
		public string TitleBgIcon
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B818 RID: 47128 RVA: 0x002E5118 File Offset: 0x002E3318
		public Span<byte> GetTitleBgIconBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x0600B819 RID: 47129 RVA: 0x002E5128 File Offset: 0x002E3328
		public byte[] GetTitleBgIconArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x17002ADA RID: 10970
		// (get) Token: 0x0600B81A RID: 47130 RVA: 0x002E5140 File Offset: 0x002E3340
		public string StarTitleIcon
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B81B RID: 47131 RVA: 0x002E5178 File Offset: 0x002E3378
		public Span<byte> GetStarTitleIconBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x0600B81C RID: 47132 RVA: 0x002E5188 File Offset: 0x002E3388
		public byte[] GetStarTitleIconArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x17002ADB RID: 10971
		// (get) Token: 0x0600B81D RID: 47133 RVA: 0x002E51A0 File Offset: 0x002E33A0
		public string StarTitleBgIcon
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

		// Token: 0x0600B81E RID: 47134 RVA: 0x002E51D8 File Offset: 0x002E33D8
		public Span<byte> GetStarTitleBgIconBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x0600B81F RID: 47135 RVA: 0x002E51E8 File Offset: 0x002E33E8
		public byte[] GetStarTitleBgIconArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x17002ADC RID: 10972
		// (get) Token: 0x0600B820 RID: 47136 RVA: 0x002E5200 File Offset: 0x002E3400
		public string SelectedIcon
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

		// Token: 0x0600B821 RID: 47137 RVA: 0x002E5238 File Offset: 0x002E3438
		public Span<byte> GetSelectedIconBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x0600B822 RID: 47138 RVA: 0x002E5248 File Offset: 0x002E3448
		public byte[] GetSelectedIconArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x17002ADD RID: 10973
		// (get) Token: 0x0600B823 RID: 47139 RVA: 0x002E5260 File Offset: 0x002E3460
		public string Description
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

		// Token: 0x0600B824 RID: 47140 RVA: 0x002E5298 File Offset: 0x002E3498
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x0600B825 RID: 47141 RVA: 0x002E52A8 File Offset: 0x002E34A8
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x17002ADE RID: 10974
		// (get) Token: 0x0600B826 RID: 47142 RVA: 0x002E52C0 File Offset: 0x002E34C0
		public int ActivityId
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002ADF RID: 10975
		// (get) Token: 0x0600B827 RID: 47143 RVA: 0x002E5300 File Offset: 0x002E3500
		public string HonorDescription
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B828 RID: 47144 RVA: 0x002E5338 File Offset: 0x002E3538
		public Span<byte> GetHonorDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x0600B829 RID: 47145 RVA: 0x002E5348 File Offset: 0x002E3548
		public byte[] GetHonorDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x17002AE0 RID: 10976
		// (get) Token: 0x0600B82A RID: 47146 RVA: 0x002E5360 File Offset: 0x002E3560
		public string SeasonId
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B82B RID: 47147 RVA: 0x002E5398 File Offset: 0x002E3598
		public Span<byte> GetSeasonIdBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x0600B82C RID: 47148 RVA: 0x002E53A8 File Offset: 0x002E35A8
		public byte[] GetSeasonIdArray()
		{
			return this.__p.__vector_as_array<byte>(46) ?? Array.Empty<byte>();
		}

		// Token: 0x17002AE1 RID: 10977
		// (get) Token: 0x0600B82D RID: 47149 RVA: 0x002E53C0 File Offset: 0x002E35C0
		public string SeasonName
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B82E RID: 47150 RVA: 0x002E53F8 File Offset: 0x002E35F8
		public Span<byte> GetSeasonNameBytes()
		{
			return this.__p.__vector_as_span<byte>(48, 1);
		}

		// Token: 0x0600B82F RID: 47151 RVA: 0x002E5408 File Offset: 0x002E3608
		public byte[] GetSeasonNameArray()
		{
			return this.__p.__vector_as_array<byte>(48) ?? Array.Empty<byte>();
		}

		// Token: 0x17002AE2 RID: 10978
		// (get) Token: 0x0600B830 RID: 47152 RVA: 0x002E5420 File Offset: 0x002E3620
		public string ActvityName
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B831 RID: 47153 RVA: 0x002E5458 File Offset: 0x002E3658
		public Span<byte> GetActvityNameBytes()
		{
			return this.__p.__vector_as_span<byte>(50, 1);
		}

		// Token: 0x0600B832 RID: 47154 RVA: 0x002E5468 File Offset: 0x002E3668
		public byte[] GetActvityNameArray()
		{
			return this.__p.__vector_as_array<byte>(50) ?? Array.Empty<byte>();
		}

		// Token: 0x17002AE3 RID: 10979
		// (get) Token: 0x0600B833 RID: 47155 RVA: 0x002E5480 File Offset: 0x002E3680
		public bool IsShowProgress
		{
			get
			{
				int num = this.__p.__offset(52);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002AE4 RID: 10980
		// (get) Token: 0x0600B834 RID: 47156 RVA: 0x002E54C0 File Offset: 0x002E36C0
		public string ItemAccess
		{
			get
			{
				int num = this.__p.__offset(54);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B835 RID: 47157 RVA: 0x002E54F8 File Offset: 0x002E36F8
		public Span<byte> GetItemAccessBytes()
		{
			return this.__p.__vector_as_span<byte>(54, 1);
		}

		// Token: 0x0600B836 RID: 47158 RVA: 0x002E5508 File Offset: 0x002E3708
		public byte[] GetItemAccessArray()
		{
			return this.__p.__vector_as_array<byte>(54) ?? Array.Empty<byte>();
		}

		// Token: 0x17002AE5 RID: 10981
		// (get) Token: 0x0600B837 RID: 47159 RVA: 0x002E5520 File Offset: 0x002E3720
		public int SortIndex
		{
			get
			{
				int num = this.__p.__offset(56);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002AE6 RID: 10982
		// (get) Token: 0x0600B838 RID: 47160 RVA: 0x002E5560 File Offset: 0x002E3760
		public string IconInTitleInfo
		{
			get
			{
				int num = this.__p.__offset(58);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B839 RID: 47161 RVA: 0x002E5598 File Offset: 0x002E3798
		public Span<byte> GetIconInTitleInfoBytes()
		{
			return this.__p.__vector_as_span<byte>(58, 1);
		}

		// Token: 0x0600B83A RID: 47162 RVA: 0x002E55A8 File Offset: 0x002E37A8
		public byte[] GetIconInTitleInfoArray()
		{
			return this.__p.__vector_as_array<byte>(58) ?? Array.Empty<byte>();
		}

		// Token: 0x040055FA RID: 22010
		private Table __p;
	}
}
