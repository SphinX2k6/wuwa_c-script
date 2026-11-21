using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BF9 RID: 27641
	public struct IDestroyItemData : IFlatbufferObject
	{
		// Token: 0x1700CAA6 RID: 51878
		// (get) Token: 0x0602F91A RID: 194842 RVA: 0x0067BCAA File Offset: 0x00679EAA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F91B RID: 194843 RVA: 0x0067BCB7 File Offset: 0x00679EB7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F91C RID: 194844 RVA: 0x0067BCC0 File Offset: 0x00679EC0
		public static IDestroyItemData GetRootAsIDestroyItemData(ByteBuffer _bb)
		{
			return IDestroyItemData.GetRootAsIDestroyItemData(_bb, default(IDestroyItemData));
		}

		// Token: 0x0602F91D RID: 194845 RVA: 0x0067BCDC File Offset: 0x00679EDC
		public static IDestroyItemData GetRootAsIDestroyItemData(ByteBuffer _bb, IDestroyItemData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F91E RID: 194846 RVA: 0x0067BCF9 File Offset: 0x00679EF9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F91F RID: 194847 RVA: 0x0067BD08 File Offset: 0x00679F08
		public IDestroyItemData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CAA7 RID: 51879
		// (get) Token: 0x0602F920 RID: 194848 RVA: 0x0067BD18 File Offset: 0x00679F18
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

		// Token: 0x1700CAA8 RID: 51880
		// (get) Token: 0x0602F921 RID: 194849 RVA: 0x0067BD54 File Offset: 0x00679F54
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

		// Token: 0x1700CAA9 RID: 51881
		// (get) Token: 0x0602F922 RID: 194850 RVA: 0x0067BD90 File Offset: 0x00679F90
		public bool IsAll
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0602F923 RID: 194851 RVA: 0x0067BDCF File Offset: 0x00679FCF
		public static Offset<IDestroyItemData> CreateIDestroyItemData(FlatBufferBuilder builder, int ItemId = 0, int Count = 0, bool IsAll = false)
		{
			builder.StartTable(3);
			IDestroyItemData.AddCount(builder, Count);
			IDestroyItemData.AddItemId(builder, ItemId);
			IDestroyItemData.AddIsAll(builder, IsAll);
			return IDestroyItemData.EndIDestroyItemData(builder);
		}

		// Token: 0x0602F924 RID: 194852 RVA: 0x0067BDF3 File Offset: 0x00679FF3
		public static void StartIDestroyItemData(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602F925 RID: 194853 RVA: 0x0067BDFC File Offset: 0x00679FFC
		public static void AddItemId(FlatBufferBuilder builder, int itemId)
		{
			builder.AddInt(0, itemId, 0);
		}

		// Token: 0x0602F926 RID: 194854 RVA: 0x0067BE07 File Offset: 0x0067A007
		public static void AddCount(FlatBufferBuilder builder, int count)
		{
			builder.AddInt(1, count, 0);
		}

		// Token: 0x0602F927 RID: 194855 RVA: 0x0067BE12 File Offset: 0x0067A012
		public static void AddIsAll(FlatBufferBuilder builder, bool isAll)
		{
			builder.AddBool(2, isAll, false);
		}

		// Token: 0x0602F928 RID: 194856 RVA: 0x0067BE1D File Offset: 0x0067A01D
		public static Offset<IDestroyItemData> EndIDestroyItemData(FlatBufferBuilder builder)
		{
			return new Offset<IDestroyItemData>(builder.EndTable());
		}

		// Token: 0x0602F929 RID: 194857 RVA: 0x0067BE2C File Offset: 0x0067A02C
		public IDestroyItemDataT UnPack()
		{
			IDestroyItemDataT destroyItemDataT = new IDestroyItemDataT();
			this.UnPackTo(destroyItemDataT);
			return destroyItemDataT;
		}

		// Token: 0x0602F92A RID: 194858 RVA: 0x0067BE47 File Offset: 0x0067A047
		public void UnPackTo(IDestroyItemDataT _o)
		{
			_o.ItemId = this.ItemId;
			_o.Count = this.Count;
			_o.IsAll = this.IsAll;
		}

		// Token: 0x0602F92B RID: 194859 RVA: 0x0067BE70 File Offset: 0x0067A070
		public static Offset<IDestroyItemData> Pack(FlatBufferBuilder builder, IDestroyItemDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDestroyItemData>);
			}
			return IDestroyItemData.CreateIDestroyItemData(builder, _o.ItemId, _o.Count, _o.IsAll);
		}

		// Token: 0x040119FB RID: 72187
		private Table __p;
	}
}
