using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012C1 RID: 4801
	public struct VehicleRidingRoles : IFlatbufferObject
	{
		// Token: 0x170040E4 RID: 16612
		// (get) Token: 0x0600F45F RID: 62559 RVA: 0x0036B162 File Offset: 0x00369362
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F460 RID: 62560 RVA: 0x0036B16F File Offset: 0x0036936F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F461 RID: 62561 RVA: 0x0036B178 File Offset: 0x00369378
		public static VehicleRidingRoles GetRootAsVehicleRidingRoles(ByteBuffer _bb)
		{
			return VehicleRidingRoles.GetRootAsVehicleRidingRoles(_bb, default(VehicleRidingRoles));
		}

		// Token: 0x0600F462 RID: 62562 RVA: 0x0036B194 File Offset: 0x00369394
		public static VehicleRidingRoles GetRootAsVehicleRidingRoles(ByteBuffer _bb, VehicleRidingRoles obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F463 RID: 62563 RVA: 0x0036B1B1 File Offset: 0x003693B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F464 RID: 62564 RVA: 0x0036B1C0 File Offset: 0x003693C0
		public VehicleRidingRoles __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170040E5 RID: 16613
		// (get) Token: 0x0600F465 RID: 62565 RVA: 0x0036B1D0 File Offset: 0x003693D0
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

		// Token: 0x170040E6 RID: 16614
		// (get) Token: 0x0600F466 RID: 62566 RVA: 0x0036B20C File Offset: 0x0036940C
		public string Description
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600F467 RID: 62567 RVA: 0x0036B243 File Offset: 0x00369443
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600F468 RID: 62568 RVA: 0x0036B252 File Offset: 0x00369452
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170040E7 RID: 16615
		// (get) Token: 0x0600F469 RID: 62569 RVA: 0x0036B26C File Offset: 0x0036946C
		public int CreatorId
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

		// Token: 0x170040E8 RID: 16616
		// (get) Token: 0x0600F46A RID: 62570 RVA: 0x0036B2A8 File Offset: 0x003694A8
		public int TemplateId
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

		// Token: 0x0600F46B RID: 62571 RVA: 0x0036B2E8 File Offset: 0x003694E8
		public DicIntInt? SkinTemplates(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170040E9 RID: 16617
		// (get) Token: 0x0600F46C RID: 62572 RVA: 0x0036B34C File Offset: 0x0036954C
		public int SkinTemplatesLength
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

		// Token: 0x170040EA RID: 16618
		// (get) Token: 0x0600F46D RID: 62573 RVA: 0x0036B378 File Offset: 0x00369578
		public int RegionId
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

		// Token: 0x0600F46E RID: 62574 RVA: 0x0036B3B8 File Offset: 0x003695B8
		[NullableContext(1)]
		public Dictionary<int, int> SkinTemplates()
		{
			return this.SkinTemplatesIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600F46F RID: 62575 RVA: 0x0036B40E File Offset: 0x0036960E
		[NullableContext(1)]
		public IEnumerable<DicIntInt> SkinTemplatesIter()
		{
			VehicleRidingRoles.<SkinTemplatesIter>d__24 <SkinTemplatesIter>d__ = new VehicleRidingRoles.<SkinTemplatesIter>d__24(-2);
			<SkinTemplatesIter>d__.<>3__<>4__this = this;
			return <SkinTemplatesIter>d__;
		}

		// Token: 0x0600F470 RID: 62576 RVA: 0x0036B424 File Offset: 0x00369624
		public int? GetSkinTemplates(int key)
		{
			this.EnsureSkinTemplatesCacheIfNeeded();
			int value;
			if (!this.SkinTemplatesCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600F471 RID: 62577 RVA: 0x0036B458 File Offset: 0x00369658
		private void EnsureSkinTemplatesCacheIfNeeded()
		{
			if (this.SkinTemplatesCache != null)
			{
				return;
			}
			this.SkinTemplatesCache = this.SkinTemplatesIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600F472 RID: 62578 RVA: 0x0036B4BE File Offset: 0x003696BE
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetSkinTemplatesFrozenDict()
		{
			this.EnsureSkinTemplatesCacheIfNeeded();
			return this.SkinTemplatesCache;
		}

		// Token: 0x04005917 RID: 22807
		private Table __p;

		// Token: 0x04005918 RID: 22808
		[Nullable(2)]
		private FrozenDictionary<int, int> SkinTemplatesCache;
	}
}
