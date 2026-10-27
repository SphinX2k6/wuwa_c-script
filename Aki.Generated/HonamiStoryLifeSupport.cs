using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D3B RID: 3387
	public struct HonamiStoryLifeSupport : IFlatbufferObject
	{
		// Token: 0x170017C2 RID: 6082
		// (get) Token: 0x0600801C RID: 32796 RVA: 0x00257C68 File Offset: 0x00255E68
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600801D RID: 32797 RVA: 0x00257C75 File Offset: 0x00255E75
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600801E RID: 32798 RVA: 0x00257C7C File Offset: 0x00255E7C
		public static HonamiStoryLifeSupport GetRootAsHonamiStoryLifeSupport(ByteBuffer _bb)
		{
			return HonamiStoryLifeSupport.GetRootAsHonamiStoryLifeSupport(_bb, default(HonamiStoryLifeSupport));
		}

		// Token: 0x0600801F RID: 32799 RVA: 0x00257C98 File Offset: 0x00255E98
		public static HonamiStoryLifeSupport GetRootAsHonamiStoryLifeSupport(ByteBuffer _bb, HonamiStoryLifeSupport obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008020 RID: 32800 RVA: 0x00257CB5 File Offset: 0x00255EB5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008021 RID: 32801 RVA: 0x00257CC4 File Offset: 0x00255EC4
		public HonamiStoryLifeSupport __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170017C3 RID: 6083
		// (get) Token: 0x06008022 RID: 32802 RVA: 0x00257CD4 File Offset: 0x00255ED4
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

		// Token: 0x170017C4 RID: 6084
		// (get) Token: 0x06008023 RID: 32803 RVA: 0x00257D10 File Offset: 0x00255F10
		public int ActivityId
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

		// Token: 0x170017C5 RID: 6085
		// (get) Token: 0x06008024 RID: 32804 RVA: 0x00257D4C File Offset: 0x00255F4C
		public int Level
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

		// Token: 0x170017C6 RID: 6086
		// (get) Token: 0x06008025 RID: 32805 RVA: 0x00257D88 File Offset: 0x00255F88
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008026 RID: 32806 RVA: 0x00257DC0 File Offset: 0x00255FC0
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06008027 RID: 32807 RVA: 0x00257DD0 File Offset: 0x00255FD0
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170017C7 RID: 6087
		// (get) Token: 0x06008028 RID: 32808 RVA: 0x00257DE8 File Offset: 0x00255FE8
		public int SteadyValue
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

		// Token: 0x06008029 RID: 32809 RVA: 0x00257E28 File Offset: 0x00256028
		public DicIntInt? ConsumeItems(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170017C8 RID: 6088
		// (get) Token: 0x0600802A RID: 32810 RVA: 0x00257E8C File Offset: 0x0025608C
		public int ConsumeItemsLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600802B RID: 32811 RVA: 0x00257EB8 File Offset: 0x002560B8
		[NullableContext(1)]
		[Obsolete("已废弃，请使用ConsumeItemsFrozenDict()缓存字典，遍历请使用ConsumeItemsIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> ConsumeItems()
		{
			return this.ConsumeItemsIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600802C RID: 32812 RVA: 0x00257F0E File Offset: 0x0025610E
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> ConsumeItemsIter()
		{
			HonamiStoryLifeSupport.<ConsumeItemsIter>d__24 <ConsumeItemsIter>d__ = new HonamiStoryLifeSupport.<ConsumeItemsIter>d__24(-2);
			<ConsumeItemsIter>d__.<>3__<>4__this = this;
			return <ConsumeItemsIter>d__;
		}

		// Token: 0x0600802D RID: 32813 RVA: 0x00257F24 File Offset: 0x00256124
		public int? GetConsumeItems(int key)
		{
			this.EnsureConsumeItemsCacheIfNeeded();
			int value;
			if (!this.ConsumeItemsCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600802E RID: 32814 RVA: 0x00257F58 File Offset: 0x00256158
		private void EnsureConsumeItemsCacheIfNeeded()
		{
			if (this.ConsumeItemsCache != null)
			{
				return;
			}
			this.ConsumeItemsCache = this.ConsumeItemsIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600802F RID: 32815 RVA: 0x00257FBE File Offset: 0x002561BE
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetConsumeItemsFrozenDict(int key)
		{
			this.EnsureConsumeItemsCacheIfNeeded();
			return this.ConsumeItemsCache;
		}

		// Token: 0x04004DB5 RID: 19893
		private Table __p;

		// Token: 0x04004DB6 RID: 19894
		[Nullable(2)]
		private FrozenDictionary<int, int> ConsumeItemsCache;
	}
}
