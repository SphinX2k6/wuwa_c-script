using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200118B RID: 4491
	public struct VehicleRidingRoles : IFlatbufferObject
	{
		// Token: 0x17003D80 RID: 15744
		// (get) Token: 0x0600E6F1 RID: 59121 RVA: 0x0034038A File Offset: 0x0033E58A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E6F2 RID: 59122 RVA: 0x00340397 File Offset: 0x0033E597
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E6F3 RID: 59123 RVA: 0x003403A0 File Offset: 0x0033E5A0
		public static VehicleRidingRoles GetRootAsVehicleRidingRoles(ByteBuffer _bb)
		{
			return VehicleRidingRoles.GetRootAsVehicleRidingRoles(_bb, default(VehicleRidingRoles));
		}

		// Token: 0x0600E6F4 RID: 59124 RVA: 0x003403BC File Offset: 0x0033E5BC
		public static VehicleRidingRoles GetRootAsVehicleRidingRoles(ByteBuffer _bb, VehicleRidingRoles obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E6F5 RID: 59125 RVA: 0x003403D9 File Offset: 0x0033E5D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E6F6 RID: 59126 RVA: 0x003403E8 File Offset: 0x0033E5E8
		public VehicleRidingRoles __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003D81 RID: 15745
		// (get) Token: 0x0600E6F7 RID: 59127 RVA: 0x003403F8 File Offset: 0x0033E5F8
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

		// Token: 0x17003D82 RID: 15746
		// (get) Token: 0x0600E6F8 RID: 59128 RVA: 0x00340434 File Offset: 0x0033E634
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

		// Token: 0x0600E6F9 RID: 59129 RVA: 0x0034046B File Offset: 0x0033E66B
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600E6FA RID: 59130 RVA: 0x0034047A File Offset: 0x0033E67A
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003D83 RID: 15747
		// (get) Token: 0x0600E6FB RID: 59131 RVA: 0x00340494 File Offset: 0x0033E694
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

		// Token: 0x17003D84 RID: 15748
		// (get) Token: 0x0600E6FC RID: 59132 RVA: 0x003404D0 File Offset: 0x0033E6D0
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

		// Token: 0x0600E6FD RID: 59133 RVA: 0x00340510 File Offset: 0x0033E710
		public DicIntInt? SkinTemplates(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003D85 RID: 15749
		// (get) Token: 0x0600E6FE RID: 59134 RVA: 0x00340574 File Offset: 0x0033E774
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

		// Token: 0x17003D86 RID: 15750
		// (get) Token: 0x0600E6FF RID: 59135 RVA: 0x003405A0 File Offset: 0x0033E7A0
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

		// Token: 0x0600E700 RID: 59136 RVA: 0x003405E0 File Offset: 0x0033E7E0
		[NullableContext(1)]
		[Obsolete("已废弃，请使用SkinTemplatesFrozenDict()缓存字典，遍历请使用SkinTemplatesIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> SkinTemplates()
		{
			return this.SkinTemplatesIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600E701 RID: 59137 RVA: 0x00340636 File Offset: 0x0033E836
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> SkinTemplatesIter()
		{
			VehicleRidingRoles.<SkinTemplatesIter>d__24 <SkinTemplatesIter>d__ = new VehicleRidingRoles.<SkinTemplatesIter>d__24(-2);
			<SkinTemplatesIter>d__.<>3__<>4__this = this;
			return <SkinTemplatesIter>d__;
		}

		// Token: 0x0600E702 RID: 59138 RVA: 0x0034064C File Offset: 0x0033E84C
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

		// Token: 0x0600E703 RID: 59139 RVA: 0x00340680 File Offset: 0x0033E880
		private void EnsureSkinTemplatesCacheIfNeeded()
		{
			if (this.SkinTemplatesCache != null)
			{
				return;
			}
			this.SkinTemplatesCache = this.SkinTemplatesIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600E704 RID: 59140 RVA: 0x003406E6 File Offset: 0x0033E8E6
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetSkinTemplatesFrozenDict(int key)
		{
			this.EnsureSkinTemplatesCacheIfNeeded();
			return this.SkinTemplatesCache;
		}

		// Token: 0x040052D4 RID: 21204
		private Table __p;

		// Token: 0x040052D5 RID: 21205
		[Nullable(2)]
		private FrozenDictionary<int, int> SkinTemplatesCache;
	}
}
