using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B58 RID: 2904
	public struct Building : IFlatbufferObject
	{
		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x0600512F RID: 20783 RVA: 0x001EC608 File Offset: 0x001EA808
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005130 RID: 20784 RVA: 0x001EC615 File Offset: 0x001EA815
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005131 RID: 20785 RVA: 0x001EC61C File Offset: 0x001EA81C
		public static Building GetRootAsBuilding(ByteBuffer _bb)
		{
			return Building.GetRootAsBuilding(_bb, default(Building));
		}

		// Token: 0x06005132 RID: 20786 RVA: 0x001EC638 File Offset: 0x001EA838
		public static Building GetRootAsBuilding(ByteBuffer _bb, Building obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005133 RID: 20787 RVA: 0x001EC655 File Offset: 0x001EA855
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005134 RID: 20788 RVA: 0x001EC664 File Offset: 0x001EA864
		public Building __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x06005135 RID: 20789 RVA: 0x001EC674 File Offset: 0x001EA874
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

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x06005136 RID: 20790 RVA: 0x001EC6B0 File Offset: 0x001EA8B0
		public string Name
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005137 RID: 20791 RVA: 0x001EC6E7 File Offset: 0x001EA8E7
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06005138 RID: 20792 RVA: 0x001EC6F6 File Offset: 0x001EA8F6
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x06005139 RID: 20793 RVA: 0x001EC710 File Offset: 0x001EA910
		public int Sort
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

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x0600513A RID: 20794 RVA: 0x001EC74C File Offset: 0x001EA94C
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600513B RID: 20795 RVA: 0x001EC784 File Offset: 0x001EA984
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600513C RID: 20796 RVA: 0x001EC794 File Offset: 0x001EA994
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x0600513D RID: 20797 RVA: 0x001EC7AC File Offset: 0x001EA9AC
		public int AssociateRole
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

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x0600513E RID: 20798 RVA: 0x001EC7EC File Offset: 0x001EA9EC
		public string RoleTips
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

		// Token: 0x0600513F RID: 20799 RVA: 0x001EC824 File Offset: 0x001EAA24
		public Span<byte> GetRoleTipsBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06005140 RID: 20800 RVA: 0x001EC834 File Offset: 0x001EAA34
		public byte[] GetRoleTipsArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x06005141 RID: 20801 RVA: 0x001EC84C File Offset: 0x001EAA4C
		public string BuildingTexture
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

		// Token: 0x06005142 RID: 20802 RVA: 0x001EC884 File Offset: 0x001EAA84
		public Span<byte> GetBuildingTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06005143 RID: 20803 RVA: 0x001EC894 File Offset: 0x001EAA94
		public byte[] GetBuildingTextureArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x06005144 RID: 20804 RVA: 0x001EC8AC File Offset: 0x001EAAAC
		public string TipsSprite
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

		// Token: 0x06005145 RID: 20805 RVA: 0x001EC8E4 File Offset: 0x001EAAE4
		public Span<byte> GetTipsSpriteBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06005146 RID: 20806 RVA: 0x001EC8F4 File Offset: 0x001EAAF4
		public byte[] GetTipsSpriteArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x06005147 RID: 20807 RVA: 0x001EC90C File Offset: 0x001EAB0C
		public int MapMarkId
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

		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x06005148 RID: 20808 RVA: 0x001EC94C File Offset: 0x001EAB4C
		public int UnLockPrice
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

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x06005149 RID: 20809 RVA: 0x001EC98C File Offset: 0x001EAB8C
		public int UnlockCondition
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

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x0600514A RID: 20810 RVA: 0x001EC9CC File Offset: 0x001EABCC
		public int JumpType
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

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x0600514B RID: 20811 RVA: 0x001ECA0C File Offset: 0x001EAC0C
		public int JumpParam
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

		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x0600514C RID: 20812 RVA: 0x001ECA4C File Offset: 0x001EAC4C
		public int UpGradeCurve
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

		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x0600514D RID: 20813 RVA: 0x001ECA8C File Offset: 0x001EAC8C
		public string FlowListName
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

		// Token: 0x0600514E RID: 20814 RVA: 0x001ECAC4 File Offset: 0x001EACC4
		public Span<byte> GetFlowListNameBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x0600514F RID: 20815 RVA: 0x001ECAD4 File Offset: 0x001EACD4
		public byte[] GetFlowListNameArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x06005150 RID: 20816 RVA: 0x001ECAEC File Offset: 0x001EACEC
		public int FlowId
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

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x06005151 RID: 20817 RVA: 0x001ECB2C File Offset: 0x001EAD2C
		public int StateId
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

		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x06005152 RID: 20818 RVA: 0x001ECB6C File Offset: 0x001EAD6C
		public int TriggerEntityId
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

		// Token: 0x04004B55 RID: 19285
		private Table __p;
	}
}
