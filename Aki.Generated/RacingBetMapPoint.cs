using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F85 RID: 3973
	public struct RacingBetMapPoint : IFlatbufferObject
	{
		// Token: 0x17002C83 RID: 11395
		// (get) Token: 0x0600B7CF RID: 47055 RVA: 0x002D49F9 File Offset: 0x002D2BF9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B7D0 RID: 47056 RVA: 0x002D4A06 File Offset: 0x002D2C06
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B7D1 RID: 47057 RVA: 0x002D4A10 File Offset: 0x002D2C10
		public static RacingBetMapPoint GetRootAsRacingBetMapPoint(ByteBuffer _bb)
		{
			return RacingBetMapPoint.GetRootAsRacingBetMapPoint(_bb, default(RacingBetMapPoint));
		}

		// Token: 0x0600B7D2 RID: 47058 RVA: 0x002D4A2C File Offset: 0x002D2C2C
		public static RacingBetMapPoint GetRootAsRacingBetMapPoint(ByteBuffer _bb, RacingBetMapPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B7D3 RID: 47059 RVA: 0x002D4A49 File Offset: 0x002D2C49
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B7D4 RID: 47060 RVA: 0x002D4A58 File Offset: 0x002D2C58
		public RacingBetMapPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002C84 RID: 11396
		// (get) Token: 0x0600B7D5 RID: 47061 RVA: 0x002D4A68 File Offset: 0x002D2C68
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

		// Token: 0x17002C85 RID: 11397
		// (get) Token: 0x0600B7D6 RID: 47062 RVA: 0x002D4AA4 File Offset: 0x002D2CA4
		public int SeasonId
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

		// Token: 0x17002C86 RID: 11398
		// (get) Token: 0x0600B7D7 RID: 47063 RVA: 0x002D4AE0 File Offset: 0x002D2CE0
		public int SortId
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

		// Token: 0x17002C87 RID: 11399
		// (get) Token: 0x0600B7D8 RID: 47064 RVA: 0x002D4B1C File Offset: 0x002D2D1C
		public int EntityId
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

		// Token: 0x17002C88 RID: 11400
		// (get) Token: 0x0600B7D9 RID: 47065 RVA: 0x002D4B5C File Offset: 0x002D2D5C
		public int BackwardEntityId
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

		// Token: 0x04005053 RID: 20563
		private Table __p;
	}
}
