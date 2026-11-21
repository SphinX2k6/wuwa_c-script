using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010B9 RID: 4281
	public struct RoadBookConfig : IFlatbufferObject
	{
		// Token: 0x17002F31 RID: 12081
		// (get) Token: 0x0600C3FD RID: 50173 RVA: 0x002FE449 File Offset: 0x002FC649
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C3FE RID: 50174 RVA: 0x002FE456 File Offset: 0x002FC656
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C3FF RID: 50175 RVA: 0x002FE460 File Offset: 0x002FC660
		public static RoadBookConfig GetRootAsRoadBookConfig(ByteBuffer _bb)
		{
			return RoadBookConfig.GetRootAsRoadBookConfig(_bb, default(RoadBookConfig));
		}

		// Token: 0x0600C400 RID: 50176 RVA: 0x002FE47C File Offset: 0x002FC67C
		public static RoadBookConfig GetRootAsRoadBookConfig(ByteBuffer _bb, RoadBookConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C401 RID: 50177 RVA: 0x002FE499 File Offset: 0x002FC699
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C402 RID: 50178 RVA: 0x002FE4A8 File Offset: 0x002FC6A8
		public RoadBookConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002F32 RID: 12082
		// (get) Token: 0x0600C403 RID: 50179 RVA: 0x002FE4B8 File Offset: 0x002FC6B8
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

		// Token: 0x17002F33 RID: 12083
		// (get) Token: 0x0600C404 RID: 50180 RVA: 0x002FE4F4 File Offset: 0x002FC6F4
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

		// Token: 0x17002F34 RID: 12084
		// (get) Token: 0x0600C405 RID: 50181 RVA: 0x002FE530 File Offset: 0x002FC730
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

		// Token: 0x17002F35 RID: 12085
		// (get) Token: 0x0600C406 RID: 50182 RVA: 0x002FE56C File Offset: 0x002FC76C
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

		// Token: 0x0600C407 RID: 50183 RVA: 0x002FE5AC File Offset: 0x002FC7AC
		public DicIntString? VehicleClassificationName(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002F36 RID: 12086
		// (get) Token: 0x0600C408 RID: 50184 RVA: 0x002FE610 File Offset: 0x002FC810
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

		// Token: 0x0600C409 RID: 50185 RVA: 0x002FE63C File Offset: 0x002FC83C
		[NullableContext(1)]
		public Dictionary<int, string> VehicleClassificationName()
		{
			return this.VehicleClassificationNameIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x0600C40A RID: 50186 RVA: 0x002FE692 File Offset: 0x002FC892
		[NullableContext(1)]
		public IEnumerable<DicIntString> VehicleClassificationNameIter()
		{
			RoadBookConfig.<VehicleClassificationNameIter>d__20 <VehicleClassificationNameIter>d__ = new RoadBookConfig.<VehicleClassificationNameIter>d__20(-2);
			<VehicleClassificationNameIter>d__.<>3__<>4__this = this;
			return <VehicleClassificationNameIter>d__;
		}

		// Token: 0x0600C40B RID: 50187 RVA: 0x002FE6A8 File Offset: 0x002FC8A8
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

		// Token: 0x0600C40C RID: 50188 RVA: 0x002FE6D0 File Offset: 0x002FC8D0
		private void EnsureVehicleClassificationNameCacheIfNeeded()
		{
			if (this.VehicleClassificationNameCache != null)
			{
				return;
			}
			this.VehicleClassificationNameCache = this.VehicleClassificationNameIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x0600C40D RID: 50189 RVA: 0x002FE736 File Offset: 0x002FC936
		[NullableContext(1)]
		public FrozenDictionary<int, string> GetVehicleClassificationNameFrozenDict()
		{
			this.EnsureVehicleClassificationNameCacheIfNeeded();
			return this.VehicleClassificationNameCache;
		}

		// Token: 0x04005694 RID: 22164
		private Table __p;

		// Token: 0x04005695 RID: 22165
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> VehicleClassificationNameCache;
	}
}
