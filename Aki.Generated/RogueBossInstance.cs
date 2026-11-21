using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010C1 RID: 4289
	public struct RogueBossInstance : IFlatbufferObject
	{
		// Token: 0x17002F60 RID: 12128
		// (get) Token: 0x0600C478 RID: 50296 RVA: 0x002FF504 File Offset: 0x002FD704
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C479 RID: 50297 RVA: 0x002FF511 File Offset: 0x002FD711
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C47A RID: 50298 RVA: 0x002FF518 File Offset: 0x002FD718
		public static RogueBossInstance GetRootAsRogueBossInstance(ByteBuffer _bb)
		{
			return RogueBossInstance.GetRootAsRogueBossInstance(_bb, default(RogueBossInstance));
		}

		// Token: 0x0600C47B RID: 50299 RVA: 0x002FF534 File Offset: 0x002FD734
		public static RogueBossInstance GetRootAsRogueBossInstance(ByteBuffer _bb, RogueBossInstance obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C47C RID: 50300 RVA: 0x002FF551 File Offset: 0x002FD751
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C47D RID: 50301 RVA: 0x002FF560 File Offset: 0x002FD760
		public RogueBossInstance __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002F61 RID: 12129
		// (get) Token: 0x0600C47E RID: 50302 RVA: 0x002FF570 File Offset: 0x002FD770
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

		// Token: 0x17002F62 RID: 12130
		// (get) Token: 0x0600C47F RID: 50303 RVA: 0x002FF5AC File Offset: 0x002FD7AC
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

		// Token: 0x17002F63 RID: 12131
		// (get) Token: 0x0600C480 RID: 50304 RVA: 0x002FF5E8 File Offset: 0x002FD7E8
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

		// Token: 0x0600C481 RID: 50305 RVA: 0x002FF61F File Offset: 0x002FD81F
		public Span<byte> GetInstNumberBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600C482 RID: 50306 RVA: 0x002FF62E File Offset: 0x002FD82E
		public byte[] GetInstNumberArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002F64 RID: 12132
		// (get) Token: 0x0600C483 RID: 50307 RVA: 0x002FF648 File Offset: 0x002FD848
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

		// Token: 0x0600C484 RID: 50308 RVA: 0x002FF680 File Offset: 0x002FD880
		public Span<byte> GetInstTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600C485 RID: 50309 RVA: 0x002FF690 File Offset: 0x002FD890
		public byte[] GetInstTitleArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002F65 RID: 12133
		// (get) Token: 0x0600C486 RID: 50310 RVA: 0x002FF6A8 File Offset: 0x002FD8A8
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

		// Token: 0x17002F66 RID: 12134
		// (get) Token: 0x0600C487 RID: 50311 RVA: 0x002FF6E8 File Offset: 0x002FD8E8
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

		// Token: 0x0600C488 RID: 50312 RVA: 0x002FF720 File Offset: 0x002FD920
		public Span<byte> GetRewardTypeTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600C489 RID: 50313 RVA: 0x002FF730 File Offset: 0x002FD930
		public byte[] GetRewardTypeTitleArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x0400569D RID: 22173
		private Table __p;
	}
}
