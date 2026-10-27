using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FD5 RID: 4053
	public struct RoadZoneConfig : IFlatbufferObject
	{
		// Token: 0x17002ED3 RID: 11987
		// (get) Token: 0x0600BDF4 RID: 48628 RVA: 0x002E2839 File Offset: 0x002E0A39
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BDF5 RID: 48629 RVA: 0x002E2846 File Offset: 0x002E0A46
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BDF6 RID: 48630 RVA: 0x002E2850 File Offset: 0x002E0A50
		public static RoadZoneConfig GetRootAsRoadZoneConfig(ByteBuffer _bb)
		{
			return RoadZoneConfig.GetRootAsRoadZoneConfig(_bb, default(RoadZoneConfig));
		}

		// Token: 0x0600BDF7 RID: 48631 RVA: 0x002E286C File Offset: 0x002E0A6C
		public static RoadZoneConfig GetRootAsRoadZoneConfig(ByteBuffer _bb, RoadZoneConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BDF8 RID: 48632 RVA: 0x002E2889 File Offset: 0x002E0A89
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BDF9 RID: 48633 RVA: 0x002E2898 File Offset: 0x002E0A98
		public RoadZoneConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002ED4 RID: 11988
		// (get) Token: 0x0600BDFA RID: 48634 RVA: 0x002E28A8 File Offset: 0x002E0AA8
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

		// Token: 0x17002ED5 RID: 11989
		// (get) Token: 0x0600BDFB RID: 48635 RVA: 0x002E28E4 File Offset: 0x002E0AE4
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

		// Token: 0x0600BDFC RID: 48636 RVA: 0x002E2920 File Offset: 0x002E0B20
		public string PbDataId(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002ED6 RID: 11990
		// (get) Token: 0x0600BDFD RID: 48637 RVA: 0x002E295C File Offset: 0x002E0B5C
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

		// Token: 0x0600BDFE RID: 48638 RVA: 0x002E2987 File Offset: 0x002E0B87
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PbDataIdIter()或GetPbDataIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] PbDataId()
		{
			return this.PbDataIdIter().ToArray<string>();
		}

		// Token: 0x0600BDFF RID: 48639 RVA: 0x002E2994 File Offset: 0x002E0B94
		[NullableContext(1)]
		public readonly IEnumerable<string> PbDataIdIter()
		{
			RoadZoneConfig.<PbDataIdIter>d__16 <PbDataIdIter>d__ = new RoadZoneConfig.<PbDataIdIter>d__16(-2);
			<PbDataIdIter>d__.<>3__<>4__this = this;
			return <PbDataIdIter>d__;
		}

		// Token: 0x040050B1 RID: 20657
		private Table __p;
	}
}
