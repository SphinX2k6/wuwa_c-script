using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FD9 RID: 4057
	public struct RogueBossInstance : IFlatbufferObject
	{
		// Token: 0x17002EE5 RID: 12005
		// (get) Token: 0x0600BE2E RID: 48686 RVA: 0x002E2F58 File Offset: 0x002E1158
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BE2F RID: 48687 RVA: 0x002E2F65 File Offset: 0x002E1165
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BE30 RID: 48688 RVA: 0x002E2F6C File Offset: 0x002E116C
		public static RogueBossInstance GetRootAsRogueBossInstance(ByteBuffer _bb)
		{
			return RogueBossInstance.GetRootAsRogueBossInstance(_bb, default(RogueBossInstance));
		}

		// Token: 0x0600BE31 RID: 48689 RVA: 0x002E2F88 File Offset: 0x002E1188
		public static RogueBossInstance GetRootAsRogueBossInstance(ByteBuffer _bb, RogueBossInstance obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BE32 RID: 48690 RVA: 0x002E2FA5 File Offset: 0x002E11A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BE33 RID: 48691 RVA: 0x002E2FB4 File Offset: 0x002E11B4
		public RogueBossInstance __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002EE6 RID: 12006
		// (get) Token: 0x0600BE34 RID: 48692 RVA: 0x002E2FC4 File Offset: 0x002E11C4
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

		// Token: 0x17002EE7 RID: 12007
		// (get) Token: 0x0600BE35 RID: 48693 RVA: 0x002E3000 File Offset: 0x002E1200
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

		// Token: 0x17002EE8 RID: 12008
		// (get) Token: 0x0600BE36 RID: 48694 RVA: 0x002E303C File Offset: 0x002E123C
		public string InstNumber
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600BE37 RID: 48695 RVA: 0x002E3073 File Offset: 0x002E1273
		public Span<byte> GetInstNumberBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600BE38 RID: 48696 RVA: 0x002E3082 File Offset: 0x002E1282
		public byte[] GetInstNumberArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002EE9 RID: 12009
		// (get) Token: 0x0600BE39 RID: 48697 RVA: 0x002E309C File Offset: 0x002E129C
		public string InstTitle
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

		// Token: 0x0600BE3A RID: 48698 RVA: 0x002E30D4 File Offset: 0x002E12D4
		public Span<byte> GetInstTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600BE3B RID: 48699 RVA: 0x002E30E4 File Offset: 0x002E12E4
		public byte[] GetInstTitleArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002EEA RID: 12010
		// (get) Token: 0x0600BE3C RID: 48700 RVA: 0x002E30FC File Offset: 0x002E12FC
		public int ConditionGroupId
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

		// Token: 0x17002EEB RID: 12011
		// (get) Token: 0x0600BE3D RID: 48701 RVA: 0x002E313C File Offset: 0x002E133C
		public string RewardTypeTitle
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

		// Token: 0x0600BE3E RID: 48702 RVA: 0x002E3174 File Offset: 0x002E1374
		public Span<byte> GetRewardTypeTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600BE3F RID: 48703 RVA: 0x002E3184 File Offset: 0x002E1384
		public byte[] GetRewardTypeTitleArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x040050B5 RID: 20661
		private Table __p;
	}
}
