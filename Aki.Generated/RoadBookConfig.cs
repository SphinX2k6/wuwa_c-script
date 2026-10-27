using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FD1 RID: 4049
	public struct RoadBookConfig : IFlatbufferObject
	{
		// Token: 0x17002EB6 RID: 11958
		// (get) Token: 0x0600BDB3 RID: 48563 RVA: 0x002E1E7D File Offset: 0x002E007D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BDB4 RID: 48564 RVA: 0x002E1E8A File Offset: 0x002E008A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BDB5 RID: 48565 RVA: 0x002E1E94 File Offset: 0x002E0094
		public static RoadBookConfig GetRootAsRoadBookConfig(ByteBuffer _bb)
		{
			return RoadBookConfig.GetRootAsRoadBookConfig(_bb, default(RoadBookConfig));
		}

		// Token: 0x0600BDB6 RID: 48566 RVA: 0x002E1EB0 File Offset: 0x002E00B0
		public static RoadBookConfig GetRootAsRoadBookConfig(ByteBuffer _bb, RoadBookConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BDB7 RID: 48567 RVA: 0x002E1ECD File Offset: 0x002E00CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BDB8 RID: 48568 RVA: 0x002E1EDC File Offset: 0x002E00DC
		public RoadBookConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002EB7 RID: 11959
		// (get) Token: 0x0600BDB9 RID: 48569 RVA: 0x002E1EEC File Offset: 0x002E00EC
		public int ActivityId
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

		// Token: 0x17002EB8 RID: 11960
		// (get) Token: 0x0600BDBA RID: 48570 RVA: 0x002E1F28 File Offset: 0x002E0128
		public int MaxLevel
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

		// Token: 0x17002EB9 RID: 11961
		// (get) Token: 0x0600BDBB RID: 48571 RVA: 0x002E1F64 File Offset: 0x002E0164
		public int ExpItemId
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

		// Token: 0x17002EBA RID: 11962
		// (get) Token: 0x0600BDBC RID: 48572 RVA: 0x002E1FA0 File Offset: 0x002E01A0
		public int FinalRewardId
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

		// Token: 0x0600BDBD RID: 48573 RVA: 0x002E1FE0 File Offset: 0x002E01E0
		public DicIntString? VehicleClassificationName(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002EBB RID: 11963
		// (get) Token: 0x0600BDBE RID: 48574 RVA: 0x002E2044 File Offset: 0x002E0244
		public int VehicleClassificationNameLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600BDBF RID: 48575 RVA: 0x002E2070 File Offset: 0x002E0270
		[NullableContext(1)]
		[Obsolete("已废弃，请使用VehicleClassificationNameFrozenDict()缓存字典，遍历请使用VehicleClassificationNameIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, string> VehicleClassificationName()
		{
			return this.VehicleClassificationNameIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x0600BDC0 RID: 48576 RVA: 0x002E20C6 File Offset: 0x002E02C6
		[NullableContext(1)]
		public readonly IEnumerable<DicIntString> VehicleClassificationNameIter()
		{
			RoadBookConfig.<VehicleClassificationNameIter>d__20 <VehicleClassificationNameIter>d__ = new RoadBookConfig.<VehicleClassificationNameIter>d__20(-2);
			<VehicleClassificationNameIter>d__.<>3__<>4__this = this;
			return <VehicleClassificationNameIter>d__;
		}

		// Token: 0x0600BDC1 RID: 48577 RVA: 0x002E20DC File Offset: 0x002E02DC
		[NullableContext(2)]
		public string GetVehicleClassificationName(int key)
		{
			this.EnsureVehicleClassificationNameCacheIfNeeded();
			string result;
			if (!this.VehicleClassificationNameCache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x0600BDC2 RID: 48578 RVA: 0x002E2104 File Offset: 0x002E0304
		private void EnsureVehicleClassificationNameCacheIfNeeded()
		{
			if (this.VehicleClassificationNameCache != null)
			{
				return;
			}
			this.VehicleClassificationNameCache = this.VehicleClassificationNameIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x0600BDC3 RID: 48579 RVA: 0x002E216A File Offset: 0x002E036A
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public FrozenDictionary<int, string> GetVehicleClassificationNameFrozenDict(int key)
		{
			this.EnsureVehicleClassificationNameCacheIfNeeded();
			return this.VehicleClassificationNameCache;
		}

		// Token: 0x040050AC RID: 20652
		private Table __p;

		// Token: 0x040050AD RID: 20653
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> VehicleClassificationNameCache;
	}
}
