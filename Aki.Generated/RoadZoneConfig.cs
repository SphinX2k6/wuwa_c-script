using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010BD RID: 4285
	public struct RoadZoneConfig : IFlatbufferObject
	{
		// Token: 0x17002F4E RID: 12110
		// (get) Token: 0x0600C43E RID: 50238 RVA: 0x002FEE05 File Offset: 0x002FD005
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C43F RID: 50239 RVA: 0x002FEE12 File Offset: 0x002FD012
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C440 RID: 50240 RVA: 0x002FEE1C File Offset: 0x002FD01C
		public static RoadZoneConfig GetRootAsRoadZoneConfig(ByteBuffer _bb)
		{
			return RoadZoneConfig.GetRootAsRoadZoneConfig(_bb, default(RoadZoneConfig));
		}

		// Token: 0x0600C441 RID: 50241 RVA: 0x002FEE38 File Offset: 0x002FD038
		public static RoadZoneConfig GetRootAsRoadZoneConfig(ByteBuffer _bb, RoadZoneConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C442 RID: 50242 RVA: 0x002FEE55 File Offset: 0x002FD055
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C443 RID: 50243 RVA: 0x002FEE64 File Offset: 0x002FD064
		public RoadZoneConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002F4F RID: 12111
		// (get) Token: 0x0600C444 RID: 50244 RVA: 0x002FEE74 File Offset: 0x002FD074
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

		// Token: 0x17002F50 RID: 12112
		// (get) Token: 0x0600C445 RID: 50245 RVA: 0x002FEEB0 File Offset: 0x002FD0B0
		public int MapId
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

		// Token: 0x0600C446 RID: 50246 RVA: 0x002FEEEC File Offset: 0x002FD0EC
		public string PbDataId(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002F51 RID: 12113
		// (get) Token: 0x0600C447 RID: 50247 RVA: 0x002FEF28 File Offset: 0x002FD128
		public int PbDataIdLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600C448 RID: 50248 RVA: 0x002FEF53 File Offset: 0x002FD153
		[NullableContext(1)]
		public string[] PbDataId()
		{
			return this.PbDataIdIter().ToArray<string>();
		}

		// Token: 0x0600C449 RID: 50249 RVA: 0x002FEF60 File Offset: 0x002FD160
		[NullableContext(1)]
		public IEnumerable<string> PbDataIdIter()
		{
			RoadZoneConfig.<PbDataIdIter>d__16 <PbDataIdIter>d__ = new RoadZoneConfig.<PbDataIdIter>d__16(-2);
			<PbDataIdIter>d__.<>3__<>4__this = this;
			return <PbDataIdIter>d__;
		}

		// Token: 0x04005699 RID: 22169
		private Table __p;
	}
}
