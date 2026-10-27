using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200104D RID: 4173
	public struct RoleGuideActivity : IFlatbufferObject
	{
		// Token: 0x1700326B RID: 12907
		// (get) Token: 0x0600C897 RID: 51351 RVA: 0x002FA670 File Offset: 0x002F8870
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C898 RID: 51352 RVA: 0x002FA67D File Offset: 0x002F887D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C899 RID: 51353 RVA: 0x002FA684 File Offset: 0x002F8884
		public static RoleGuideActivity GetRootAsRoleGuideActivity(ByteBuffer _bb)
		{
			return RoleGuideActivity.GetRootAsRoleGuideActivity(_bb, default(RoleGuideActivity));
		}

		// Token: 0x0600C89A RID: 51354 RVA: 0x002FA6A0 File Offset: 0x002F88A0
		public static RoleGuideActivity GetRootAsRoleGuideActivity(ByteBuffer _bb, RoleGuideActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C89B RID: 51355 RVA: 0x002FA6BD File Offset: 0x002F88BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C89C RID: 51356 RVA: 0x002FA6CC File Offset: 0x002F88CC
		public RoleGuideActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700326C RID: 12908
		// (get) Token: 0x0600C89D RID: 51357 RVA: 0x002FA6DC File Offset: 0x002F88DC
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

		// Token: 0x1700326D RID: 12909
		// (get) Token: 0x0600C89E RID: 51358 RVA: 0x002FA718 File Offset: 0x002F8918
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

		// Token: 0x1700326E RID: 12910
		// (get) Token: 0x0600C89F RID: 51359 RVA: 0x002FA754 File Offset: 0x002F8954
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

		// Token: 0x1700326F RID: 12911
		// (get) Token: 0x0600C8A0 RID: 51360 RVA: 0x002FA790 File Offset: 0x002F8990
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

		// Token: 0x17003270 RID: 12912
		// (get) Token: 0x0600C8A1 RID: 51361 RVA: 0x002FA7D0 File Offset: 0x002F89D0
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

		// Token: 0x17003271 RID: 12913
		// (get) Token: 0x0600C8A2 RID: 51362 RVA: 0x002FA810 File Offset: 0x002F8A10
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

		// Token: 0x0600C8A3 RID: 51363 RVA: 0x002FA848 File Offset: 0x002F8A48
		public Span<byte> GetShowQuestTipsBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600C8A4 RID: 51364 RVA: 0x002FA858 File Offset: 0x002F8A58
		public byte[] GetShowQuestTipsArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17003272 RID: 12914
		// (get) Token: 0x0600C8A5 RID: 51365 RVA: 0x002FA870 File Offset: 0x002F8A70
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

		// Token: 0x0600C8A6 RID: 51366 RVA: 0x002FA8A8 File Offset: 0x002F8AA8
		public Span<byte> GetShowQuestGetWayBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600C8A7 RID: 51367 RVA: 0x002FA8B8 File Offset: 0x002F8AB8
		public byte[] GetShowQuestGetWayArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17003273 RID: 12915
		// (get) Token: 0x0600C8A8 RID: 51368 RVA: 0x002FA8D0 File Offset: 0x002F8AD0
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

		// Token: 0x0600C8A9 RID: 51369 RVA: 0x002FA908 File Offset: 0x002F8B08
		public Span<byte> GetRoleUiBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600C8AA RID: 51370 RVA: 0x002FA918 File Offset: 0x002F8B18
		public byte[] GetRoleUiArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17003274 RID: 12916
		// (get) Token: 0x0600C8AB RID: 51371 RVA: 0x002FA930 File Offset: 0x002F8B30
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

		// Token: 0x0400514B RID: 20811
		private Table __p;
	}
}
