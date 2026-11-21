using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001094 RID: 4244
	public struct RegressDoubleDrop : IFlatbufferObject
	{
		// Token: 0x17002E13 RID: 11795
		// (get) Token: 0x0600C120 RID: 49440 RVA: 0x002F81A1 File Offset: 0x002F63A1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C121 RID: 49441 RVA: 0x002F81AE File Offset: 0x002F63AE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C122 RID: 49442 RVA: 0x002F81B8 File Offset: 0x002F63B8
		public static RegressDoubleDrop GetRootAsRegressDoubleDrop(ByteBuffer _bb)
		{
			return RegressDoubleDrop.GetRootAsRegressDoubleDrop(_bb, default(RegressDoubleDrop));
		}

		// Token: 0x0600C123 RID: 49443 RVA: 0x002F81D4 File Offset: 0x002F63D4
		public static RegressDoubleDrop GetRootAsRegressDoubleDrop(ByteBuffer _bb, RegressDoubleDrop obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C124 RID: 49444 RVA: 0x002F81F1 File Offset: 0x002F63F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C125 RID: 49445 RVA: 0x002F8200 File Offset: 0x002F6400
		public RegressDoubleDrop __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002E14 RID: 11796
		// (get) Token: 0x0600C126 RID: 49446 RVA: 0x002F8210 File Offset: 0x002F6410
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

		// Token: 0x17002E15 RID: 11797
		// (get) Token: 0x0600C127 RID: 49447 RVA: 0x002F824C File Offset: 0x002F644C
		public int Grade
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002E16 RID: 11798
		// (get) Token: 0x0600C128 RID: 49448 RVA: 0x002F8288 File Offset: 0x002F6488
		public int BossDoubleTimes
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

		// Token: 0x17002E17 RID: 11799
		// (get) Token: 0x0600C129 RID: 49449 RVA: 0x002F82C4 File Offset: 0x002F64C4
		public int WeekDoubleTimes
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

		// Token: 0x17002E18 RID: 11800
		// (get) Token: 0x0600C12A RID: 49450 RVA: 0x002F8304 File Offset: 0x002F6504
		public int BossUnLock
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

		// Token: 0x17002E19 RID: 11801
		// (get) Token: 0x0600C12B RID: 49451 RVA: 0x002F8344 File Offset: 0x002F6544
		public int WeekUnLock
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

		// Token: 0x17002E1A RID: 11802
		// (get) Token: 0x0600C12C RID: 49452 RVA: 0x002F8384 File Offset: 0x002F6584
		public string Tips
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

		// Token: 0x0600C12D RID: 49453 RVA: 0x002F83BC File Offset: 0x002F65BC
		public Span<byte> GetTipsBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600C12E RID: 49454 RVA: 0x002F83CC File Offset: 0x002F65CC
		public byte[] GetTipsArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002E1B RID: 11803
		// (get) Token: 0x0600C12F RID: 49455 RVA: 0x002F83E4 File Offset: 0x002F65E4
		public int WorldBossAccessPathId
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

		// Token: 0x17002E1C RID: 11804
		// (get) Token: 0x0600C130 RID: 49456 RVA: 0x002F8424 File Offset: 0x002F6624
		public int WeekAccessPathId
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

		// Token: 0x0400566D RID: 22125
		private Table __p;
	}
}
