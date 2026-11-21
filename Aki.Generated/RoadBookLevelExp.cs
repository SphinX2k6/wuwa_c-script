using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010BA RID: 4282
	public struct RoadBookLevelExp : IFlatbufferObject
	{
		// Token: 0x17002F37 RID: 12087
		// (get) Token: 0x0600C40E RID: 50190 RVA: 0x002FE744 File Offset: 0x002FC944
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C40F RID: 50191 RVA: 0x002FE751 File Offset: 0x002FC951
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C410 RID: 50192 RVA: 0x002FE758 File Offset: 0x002FC958
		public static RoadBookLevelExp GetRootAsRoadBookLevelExp(ByteBuffer _bb)
		{
			return RoadBookLevelExp.GetRootAsRoadBookLevelExp(_bb, default(RoadBookLevelExp));
		}

		// Token: 0x0600C411 RID: 50193 RVA: 0x002FE774 File Offset: 0x002FC974
		public static RoadBookLevelExp GetRootAsRoadBookLevelExp(ByteBuffer _bb, RoadBookLevelExp obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C412 RID: 50194 RVA: 0x002FE791 File Offset: 0x002FC991
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C413 RID: 50195 RVA: 0x002FE7A0 File Offset: 0x002FC9A0
		public RoadBookLevelExp __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002F38 RID: 12088
		// (get) Token: 0x0600C414 RID: 50196 RVA: 0x002FE7B0 File Offset: 0x002FC9B0
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

		// Token: 0x17002F39 RID: 12089
		// (get) Token: 0x0600C415 RID: 50197 RVA: 0x002FE7EC File Offset: 0x002FC9EC
		public int ActivityId
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

		// Token: 0x17002F3A RID: 12090
		// (get) Token: 0x0600C416 RID: 50198 RVA: 0x002FE828 File Offset: 0x002FCA28
		public int Level
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

		// Token: 0x17002F3B RID: 12091
		// (get) Token: 0x0600C417 RID: 50199 RVA: 0x002FE864 File Offset: 0x002FCA64
		public int NeedExp
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

		// Token: 0x17002F3C RID: 12092
		// (get) Token: 0x0600C418 RID: 50200 RVA: 0x002FE8A4 File Offset: 0x002FCAA4
		public int RewardDropId
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

		// Token: 0x17002F3D RID: 12093
		// (get) Token: 0x0600C419 RID: 50201 RVA: 0x002FE8E4 File Offset: 0x002FCAE4
		public string TipsLock
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

		// Token: 0x0600C41A RID: 50202 RVA: 0x002FE91C File Offset: 0x002FCB1C
		public Span<byte> GetTipsLockBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600C41B RID: 50203 RVA: 0x002FE92C File Offset: 0x002FCB2C
		public byte[] GetTipsLockArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002F3E RID: 12094
		// (get) Token: 0x0600C41C RID: 50204 RVA: 0x002FE944 File Offset: 0x002FCB44
		public string TipsDone
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

		// Token: 0x0600C41D RID: 50205 RVA: 0x002FE97C File Offset: 0x002FCB7C
		public Span<byte> GetTipsDoneBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600C41E RID: 50206 RVA: 0x002FE98C File Offset: 0x002FCB8C
		public byte[] GetTipsDoneArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x04005696 RID: 22166
		private Table __p;
	}
}
