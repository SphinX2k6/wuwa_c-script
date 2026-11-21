using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001135 RID: 4405
	public struct RoleGuideActivity : IFlatbufferObject
	{
		// Token: 0x170032E6 RID: 13030
		// (get) Token: 0x0600CEE1 RID: 52961 RVA: 0x0031633C File Offset: 0x0031453C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CEE2 RID: 52962 RVA: 0x00316349 File Offset: 0x00314549
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CEE3 RID: 52963 RVA: 0x00316350 File Offset: 0x00314550
		public static RoleGuideActivity GetRootAsRoleGuideActivity(ByteBuffer _bb)
		{
			return RoleGuideActivity.GetRootAsRoleGuideActivity(_bb, default(RoleGuideActivity));
		}

		// Token: 0x0600CEE4 RID: 52964 RVA: 0x0031636C File Offset: 0x0031456C
		public static RoleGuideActivity GetRootAsRoleGuideActivity(ByteBuffer _bb, RoleGuideActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CEE5 RID: 52965 RVA: 0x00316389 File Offset: 0x00314589
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CEE6 RID: 52966 RVA: 0x00316398 File Offset: 0x00314598
		public RoleGuideActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170032E7 RID: 13031
		// (get) Token: 0x0600CEE7 RID: 52967 RVA: 0x003163A8 File Offset: 0x003145A8
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

		// Token: 0x170032E8 RID: 13032
		// (get) Token: 0x0600CEE8 RID: 52968 RVA: 0x003163E4 File Offset: 0x003145E4
		public int RoleId
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

		// Token: 0x170032E9 RID: 13033
		// (get) Token: 0x0600CEE9 RID: 52969 RVA: 0x00316420 File Offset: 0x00314620
		public int RoleQuestId
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

		// Token: 0x170032EA RID: 13034
		// (get) Token: 0x0600CEEA RID: 52970 RVA: 0x0031645C File Offset: 0x0031465C
		public int RoleTrialId
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

		// Token: 0x170032EB RID: 13035
		// (get) Token: 0x0600CEEB RID: 52971 RVA: 0x0031649C File Offset: 0x0031469C
		public int ShowQuestId
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

		// Token: 0x170032EC RID: 13036
		// (get) Token: 0x0600CEEC RID: 52972 RVA: 0x003164DC File Offset: 0x003146DC
		public string ShowQuestTips
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

		// Token: 0x0600CEED RID: 52973 RVA: 0x00316514 File Offset: 0x00314714
		public Span<byte> GetShowQuestTipsBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600CEEE RID: 52974 RVA: 0x00316524 File Offset: 0x00314724
		public byte[] GetShowQuestTipsArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170032ED RID: 13037
		// (get) Token: 0x0600CEEF RID: 52975 RVA: 0x0031653C File Offset: 0x0031473C
		public string ShowQuestGetWay
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

		// Token: 0x0600CEF0 RID: 52976 RVA: 0x00316574 File Offset: 0x00314774
		public Span<byte> GetShowQuestGetWayBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600CEF1 RID: 52977 RVA: 0x00316584 File Offset: 0x00314784
		public byte[] GetShowQuestGetWayArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170032EE RID: 13038
		// (get) Token: 0x0600CEF2 RID: 52978 RVA: 0x0031659C File Offset: 0x0031479C
		public string RoleUi
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

		// Token: 0x0600CEF3 RID: 52979 RVA: 0x003165D4 File Offset: 0x003147D4
		public Span<byte> GetRoleUiBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600CEF4 RID: 52980 RVA: 0x003165E4 File Offset: 0x003147E4
		public byte[] GetRoleUiArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170032EF RID: 13039
		// (get) Token: 0x0600CEF5 RID: 52981 RVA: 0x003165FC File Offset: 0x003147FC
		public int ClientPrefabType
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

		// Token: 0x04005733 RID: 22323
		private Table __p;
	}
}
