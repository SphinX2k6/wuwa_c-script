using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E29 RID: 3625
	public struct HonamiStoryPluginSlot : IFlatbufferObject
	{
		// Token: 0x17001863 RID: 6243
		// (get) Token: 0x060086CD RID: 34509 RVA: 0x002778D0 File Offset: 0x00275AD0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060086CE RID: 34510 RVA: 0x002778DD File Offset: 0x00275ADD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060086CF RID: 34511 RVA: 0x002778E4 File Offset: 0x00275AE4
		public static HonamiStoryPluginSlot GetRootAsHonamiStoryPluginSlot(ByteBuffer _bb)
		{
			return HonamiStoryPluginSlot.GetRootAsHonamiStoryPluginSlot(_bb, default(HonamiStoryPluginSlot));
		}

		// Token: 0x060086D0 RID: 34512 RVA: 0x00277900 File Offset: 0x00275B00
		public static HonamiStoryPluginSlot GetRootAsHonamiStoryPluginSlot(ByteBuffer _bb, HonamiStoryPluginSlot obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060086D1 RID: 34513 RVA: 0x0027791D File Offset: 0x00275B1D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060086D2 RID: 34514 RVA: 0x0027792C File Offset: 0x00275B2C
		public HonamiStoryPluginSlot __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001864 RID: 6244
		// (get) Token: 0x060086D3 RID: 34515 RVA: 0x0027793C File Offset: 0x00275B3C
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

		// Token: 0x17001865 RID: 6245
		// (get) Token: 0x060086D4 RID: 34516 RVA: 0x00277978 File Offset: 0x00275B78
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

		// Token: 0x17001866 RID: 6246
		// (get) Token: 0x060086D5 RID: 34517 RVA: 0x002779B4 File Offset: 0x00275BB4
		public int SlotPos
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

		// Token: 0x060086D6 RID: 34518 RVA: 0x002779F0 File Offset: 0x00275BF0
		public DicIntInt? ConsumeItems(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001867 RID: 6247
		// (get) Token: 0x060086D7 RID: 34519 RVA: 0x00277A54 File Offset: 0x00275C54
		public int ConsumeItemsLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060086D8 RID: 34520 RVA: 0x00277A80 File Offset: 0x00275C80
		[NullableContext(1)]
		public Dictionary<int, int> ConsumeItems()
		{
			return this.ConsumeItemsIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x060086D9 RID: 34521 RVA: 0x00277AD6 File Offset: 0x00275CD6
		[NullableContext(1)]
		public IEnumerable<DicIntInt> ConsumeItemsIter()
		{
			HonamiStoryPluginSlot.<ConsumeItemsIter>d__18 <ConsumeItemsIter>d__ = new HonamiStoryPluginSlot.<ConsumeItemsIter>d__18(-2);
			<ConsumeItemsIter>d__.<>3__<>4__this = this;
			return <ConsumeItemsIter>d__;
		}

		// Token: 0x060086DA RID: 34522 RVA: 0x00277AEC File Offset: 0x00275CEC
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

		// Token: 0x060086DB RID: 34523 RVA: 0x00277B20 File Offset: 0x00275D20
		private void EnsureConsumeItemsCacheIfNeeded()
		{
			if (this.ConsumeItemsCache != null)
			{
				return;
			}
			this.ConsumeItemsCache = this.ConsumeItemsIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x060086DC RID: 34524 RVA: 0x00277B86 File Offset: 0x00275D86
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetConsumeItemsFrozenDict()
		{
			this.EnsureConsumeItemsCacheIfNeeded();
			return this.ConsumeItemsCache;
		}

		// Token: 0x040053A4 RID: 21412
		private Table __p;

		// Token: 0x040053A5 RID: 21413
		[Nullable(2)]
		private FrozenDictionary<int, int> ConsumeItemsCache;
	}
}
