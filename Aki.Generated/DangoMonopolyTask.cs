using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BDD RID: 3037
	public struct DangoMonopolyTask : IFlatbufferObject
	{
		// Token: 0x17000C02 RID: 3074
		// (get) Token: 0x060060AA RID: 24746 RVA: 0x002100B4 File Offset: 0x0020E2B4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060060AB RID: 24747 RVA: 0x002100C1 File Offset: 0x0020E2C1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060060AC RID: 24748 RVA: 0x002100C8 File Offset: 0x0020E2C8
		public static DangoMonopolyTask GetRootAsDangoMonopolyTask(ByteBuffer _bb)
		{
			return DangoMonopolyTask.GetRootAsDangoMonopolyTask(_bb, default(DangoMonopolyTask));
		}

		// Token: 0x060060AD RID: 24749 RVA: 0x002100E4 File Offset: 0x0020E2E4
		public static DangoMonopolyTask GetRootAsDangoMonopolyTask(ByteBuffer _bb, DangoMonopolyTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060060AE RID: 24750 RVA: 0x00210101 File Offset: 0x0020E301
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060060AF RID: 24751 RVA: 0x00210110 File Offset: 0x0020E310
		public DangoMonopolyTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000C03 RID: 3075
		// (get) Token: 0x060060B0 RID: 24752 RVA: 0x00210120 File Offset: 0x0020E320
		public int TaskId
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

		// Token: 0x17000C04 RID: 3076
		// (get) Token: 0x060060B1 RID: 24753 RVA: 0x0021015C File Offset: 0x0020E35C
		public int TaskGroupId
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

		// Token: 0x17000C05 RID: 3077
		// (get) Token: 0x060060B2 RID: 24754 RVA: 0x00210198 File Offset: 0x0020E398
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

		// Token: 0x17000C06 RID: 3078
		// (get) Token: 0x060060B3 RID: 24755 RVA: 0x002101D4 File Offset: 0x0020E3D4
		public int Source
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

		// Token: 0x17000C07 RID: 3079
		// (get) Token: 0x060060B4 RID: 24756 RVA: 0x00210214 File Offset: 0x0020E414
		public int TaskType
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

		// Token: 0x17000C08 RID: 3080
		// (get) Token: 0x060060B5 RID: 24757 RVA: 0x00210254 File Offset: 0x0020E454
		public int ConditionGroupId
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

		// Token: 0x17000C09 RID: 3081
		// (get) Token: 0x060060B6 RID: 24758 RVA: 0x00210294 File Offset: 0x0020E494
		public int ProgressConditionId
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

		// Token: 0x17000C0A RID: 3082
		// (get) Token: 0x060060B7 RID: 24759 RVA: 0x002102D4 File Offset: 0x0020E4D4
		public int ItemId
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

		// Token: 0x17000C0B RID: 3083
		// (get) Token: 0x060060B8 RID: 24760 RVA: 0x00210314 File Offset: 0x0020E514
		public int ItemNum
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

		// Token: 0x17000C0C RID: 3084
		// (get) Token: 0x060060B9 RID: 24761 RVA: 0x00210354 File Offset: 0x0020E554
		public string Desc
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

		// Token: 0x060060BA RID: 24762 RVA: 0x0021038C File Offset: 0x0020E58C
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x060060BB RID: 24763 RVA: 0x0021039C File Offset: 0x0020E59C
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17000C0D RID: 3085
		// (get) Token: 0x060060BC RID: 24764 RVA: 0x002103B4 File Offset: 0x0020E5B4
		public string Title
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

		// Token: 0x060060BD RID: 24765 RVA: 0x002103EC File Offset: 0x0020E5EC
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x060060BE RID: 24766 RVA: 0x002103FC File Offset: 0x0020E5FC
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x04004C0A RID: 19466
		private Table __p;
	}
}
