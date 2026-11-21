using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F43 RID: 3907
	public struct MotorOnlineBuff : IFlatbufferObject
	{
		// Token: 0x1700222F RID: 8751
		// (get) Token: 0x0600A129 RID: 41257 RVA: 0x002B2946 File Offset: 0x002B0B46
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A12A RID: 41258 RVA: 0x002B2953 File Offset: 0x002B0B53
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A12B RID: 41259 RVA: 0x002B295C File Offset: 0x002B0B5C
		public static MotorOnlineBuff GetRootAsMotorOnlineBuff(ByteBuffer _bb)
		{
			return MotorOnlineBuff.GetRootAsMotorOnlineBuff(_bb, default(MotorOnlineBuff));
		}

		// Token: 0x0600A12C RID: 41260 RVA: 0x002B2978 File Offset: 0x002B0B78
		public static MotorOnlineBuff GetRootAsMotorOnlineBuff(ByteBuffer _bb, MotorOnlineBuff obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A12D RID: 41261 RVA: 0x002B2995 File Offset: 0x002B0B95
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A12E RID: 41262 RVA: 0x002B29A4 File Offset: 0x002B0BA4
		public MotorOnlineBuff __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002230 RID: 8752
		// (get) Token: 0x0600A12F RID: 41263 RVA: 0x002B29B4 File Offset: 0x002B0BB4
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

		// Token: 0x17002231 RID: 8753
		// (get) Token: 0x0600A130 RID: 41264 RVA: 0x002B29F0 File Offset: 0x002B0BF0
		public int InstId
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

		// Token: 0x17002232 RID: 8754
		// (get) Token: 0x0600A131 RID: 41265 RVA: 0x002B2A2C File Offset: 0x002B0C2C
		public int TriggerRank
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

		// Token: 0x17002233 RID: 8755
		// (get) Token: 0x0600A132 RID: 41266 RVA: 0x002B2A68 File Offset: 0x002B0C68
		public int BroadcastGroup
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

		// Token: 0x17002234 RID: 8756
		// (get) Token: 0x0600A133 RID: 41267 RVA: 0x002B2AA8 File Offset: 0x002B0CA8
		public int EffectType
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

		// Token: 0x17002235 RID: 8757
		// (get) Token: 0x0600A134 RID: 41268 RVA: 0x002B2AE8 File Offset: 0x002B0CE8
		public int EffectTime
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

		// Token: 0x040054EF RID: 21743
		private Table __p;
	}
}
