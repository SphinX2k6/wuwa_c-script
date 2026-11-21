using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011A1 RID: 4513
	public struct SheriffZone : IFlatbufferObject
	{
		// Token: 0x170036B3 RID: 14003
		// (get) Token: 0x0600D956 RID: 55638 RVA: 0x0032D7C1 File Offset: 0x0032B9C1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D957 RID: 55639 RVA: 0x0032D7CE File Offset: 0x0032B9CE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D958 RID: 55640 RVA: 0x0032D7D8 File Offset: 0x0032B9D8
		public static SheriffZone GetRootAsSheriffZone(ByteBuffer _bb)
		{
			return SheriffZone.GetRootAsSheriffZone(_bb, default(SheriffZone));
		}

		// Token: 0x0600D959 RID: 55641 RVA: 0x0032D7F4 File Offset: 0x0032B9F4
		public static SheriffZone GetRootAsSheriffZone(ByteBuffer _bb, SheriffZone obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D95A RID: 55642 RVA: 0x0032D811 File Offset: 0x0032BA11
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D95B RID: 55643 RVA: 0x0032D820 File Offset: 0x0032BA20
		public SheriffZone __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170036B4 RID: 14004
		// (get) Token: 0x0600D95C RID: 55644 RVA: 0x0032D830 File Offset: 0x0032BA30
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

		// Token: 0x170036B5 RID: 14005
		// (get) Token: 0x0600D95D RID: 55645 RVA: 0x0032D86C File Offset: 0x0032BA6C
		public int AnomalyFuncId
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

		// Token: 0x170036B6 RID: 14006
		// (get) Token: 0x0600D95E RID: 55646 RVA: 0x0032D8A8 File Offset: 0x0032BAA8
		public int QuestFuncId
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

		// Token: 0x170036B7 RID: 14007
		// (get) Token: 0x0600D95F RID: 55647 RVA: 0x0032D8E4 File Offset: 0x0032BAE4
		public int ItemId
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

		// Token: 0x170036B8 RID: 14008
		// (get) Token: 0x0600D960 RID: 55648 RVA: 0x0032D924 File Offset: 0x0032BB24
		public int ActivityId
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

		// Token: 0x170036B9 RID: 14009
		// (get) Token: 0x0600D961 RID: 55649 RVA: 0x0032D964 File Offset: 0x0032BB64
		public int MapId
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

		// Token: 0x040057B4 RID: 22452
		private Table __p;
	}
}
