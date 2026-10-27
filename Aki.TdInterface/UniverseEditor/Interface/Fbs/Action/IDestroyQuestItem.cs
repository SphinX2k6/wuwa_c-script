using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200659A RID: 26010
	public struct IDestroyQuestItem : IFlatbufferObject
	{
		// Token: 0x1700C128 RID: 49448
		// (get) Token: 0x0602D1E3 RID: 184803 RVA: 0x00630418 File Offset: 0x0062E618
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D1E4 RID: 184804 RVA: 0x00630425 File Offset: 0x0062E625
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D1E5 RID: 184805 RVA: 0x0063042C File Offset: 0x0062E62C
		public static IDestroyQuestItem GetRootAsIDestroyQuestItem(ByteBuffer _bb)
		{
			return IDestroyQuestItem.GetRootAsIDestroyQuestItem(_bb, default(IDestroyQuestItem));
		}

		// Token: 0x0602D1E6 RID: 184806 RVA: 0x00630448 File Offset: 0x0062E648
		public static IDestroyQuestItem GetRootAsIDestroyQuestItem(ByteBuffer _bb, IDestroyQuestItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D1E7 RID: 184807 RVA: 0x00630465 File Offset: 0x0062E665
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D1E8 RID: 184808 RVA: 0x00630474 File Offset: 0x0062E674
		public IDestroyQuestItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C129 RID: 49449
		// (get) Token: 0x0602D1E9 RID: 184809 RVA: 0x00630484 File Offset: 0x0062E684
		public int ItemId
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

		// Token: 0x1700C12A RID: 49450
		// (get) Token: 0x0602D1EA RID: 184810 RVA: 0x006304C0 File Offset: 0x0062E6C0
		public int Count
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

		// Token: 0x1700C12B RID: 49451
		// (get) Token: 0x0602D1EB RID: 184811 RVA: 0x006304FC File Offset: 0x0062E6FC
		public bool IsAll
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0602D1EC RID: 184812 RVA: 0x0063053B File Offset: 0x0062E73B
		public static Offset<IDestroyQuestItem> CreateIDestroyQuestItem(FlatBufferBuilder builder, int ItemId = 0, int Count = 0, bool IsAll = false)
		{
			builder.StartTable(3);
			IDestroyQuestItem.AddCount(builder, Count);
			IDestroyQuestItem.AddItemId(builder, ItemId);
			IDestroyQuestItem.AddIsAll(builder, IsAll);
			return IDestroyQuestItem.EndIDestroyQuestItem(builder);
		}

		// Token: 0x0602D1ED RID: 184813 RVA: 0x0063055F File Offset: 0x0062E75F
		public static void StartIDestroyQuestItem(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602D1EE RID: 184814 RVA: 0x00630568 File Offset: 0x0062E768
		public static void AddItemId(FlatBufferBuilder builder, int itemId)
		{
			builder.AddInt(0, itemId, 0);
		}

		// Token: 0x0602D1EF RID: 184815 RVA: 0x00630573 File Offset: 0x0062E773
		public static void AddCount(FlatBufferBuilder builder, int count)
		{
			builder.AddInt(1, count, 0);
		}

		// Token: 0x0602D1F0 RID: 184816 RVA: 0x0063057E File Offset: 0x0062E77E
		public static void AddIsAll(FlatBufferBuilder builder, bool isAll)
		{
			builder.AddBool(2, isAll, false);
		}

		// Token: 0x0602D1F1 RID: 184817 RVA: 0x00630589 File Offset: 0x0062E789
		public static Offset<IDestroyQuestItem> EndIDestroyQuestItem(FlatBufferBuilder builder)
		{
			return new Offset<IDestroyQuestItem>(builder.EndTable());
		}

		// Token: 0x0602D1F2 RID: 184818 RVA: 0x00630598 File Offset: 0x0062E798
		public IDestroyQuestItemT UnPack()
		{
			IDestroyQuestItemT destroyQuestItemT = new IDestroyQuestItemT();
			this.UnPackTo(destroyQuestItemT);
			return destroyQuestItemT;
		}

		// Token: 0x0602D1F3 RID: 184819 RVA: 0x006305B3 File Offset: 0x0062E7B3
		public void UnPackTo(IDestroyQuestItemT _o)
		{
			_o.ItemId = this.ItemId;
			_o.Count = this.Count;
			_o.IsAll = this.IsAll;
		}

		// Token: 0x0602D1F4 RID: 184820 RVA: 0x006305DC File Offset: 0x0062E7DC
		public static Offset<IDestroyQuestItem> Pack(FlatBufferBuilder builder, IDestroyQuestItemT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDestroyQuestItem>);
			}
			return IDestroyQuestItem.CreateIDestroyQuestItem(builder, _o.ItemId, _o.Count, _o.IsAll);
		}

		// Token: 0x04010BF3 RID: 68595
		private Table __p;
	}
}
