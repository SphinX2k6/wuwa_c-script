using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006591 RID: 26001
	public struct IDestroyItemData : IFlatbufferObject
	{
		// Token: 0x1700C117 RID: 49431
		// (get) Token: 0x0602D196 RID: 184726 RVA: 0x0062FAE6 File Offset: 0x0062DCE6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D197 RID: 184727 RVA: 0x0062FAF3 File Offset: 0x0062DCF3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D198 RID: 184728 RVA: 0x0062FAFC File Offset: 0x0062DCFC
		public static IDestroyItemData GetRootAsIDestroyItemData(ByteBuffer _bb)
		{
			return IDestroyItemData.GetRootAsIDestroyItemData(_bb, default(IDestroyItemData));
		}

		// Token: 0x0602D199 RID: 184729 RVA: 0x0062FB18 File Offset: 0x0062DD18
		public static IDestroyItemData GetRootAsIDestroyItemData(ByteBuffer _bb, IDestroyItemData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D19A RID: 184730 RVA: 0x0062FB35 File Offset: 0x0062DD35
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D19B RID: 184731 RVA: 0x0062FB44 File Offset: 0x0062DD44
		public IDestroyItemData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C118 RID: 49432
		// (get) Token: 0x0602D19C RID: 184732 RVA: 0x0062FB54 File Offset: 0x0062DD54
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

		// Token: 0x1700C119 RID: 49433
		// (get) Token: 0x0602D19D RID: 184733 RVA: 0x0062FB90 File Offset: 0x0062DD90
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

		// Token: 0x1700C11A RID: 49434
		// (get) Token: 0x0602D19E RID: 184734 RVA: 0x0062FBCC File Offset: 0x0062DDCC
		public bool IsAll
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0602D19F RID: 184735 RVA: 0x0062FC0B File Offset: 0x0062DE0B
		public static Offset<IDestroyItemData> CreateIDestroyItemData(FlatBufferBuilder builder, int ItemId = 0, int Count = 0, bool IsAll = false)
		{
			builder.StartTable(3);
			IDestroyItemData.AddCount(builder, Count);
			IDestroyItemData.AddItemId(builder, ItemId);
			IDestroyItemData.AddIsAll(builder, IsAll);
			return IDestroyItemData.EndIDestroyItemData(builder);
		}

		// Token: 0x0602D1A0 RID: 184736 RVA: 0x0062FC2F File Offset: 0x0062DE2F
		public static void StartIDestroyItemData(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602D1A1 RID: 184737 RVA: 0x0062FC38 File Offset: 0x0062DE38
		public static void AddItemId(FlatBufferBuilder builder, int itemId)
		{
			builder.AddInt(0, itemId, 0);
		}

		// Token: 0x0602D1A2 RID: 184738 RVA: 0x0062FC43 File Offset: 0x0062DE43
		public static void AddCount(FlatBufferBuilder builder, int count)
		{
			builder.AddInt(1, count, 0);
		}

		// Token: 0x0602D1A3 RID: 184739 RVA: 0x0062FC4E File Offset: 0x0062DE4E
		public static void AddIsAll(FlatBufferBuilder builder, bool isAll)
		{
			builder.AddBool(2, isAll, false);
		}

		// Token: 0x0602D1A4 RID: 184740 RVA: 0x0062FC59 File Offset: 0x0062DE59
		public static Offset<IDestroyItemData> EndIDestroyItemData(FlatBufferBuilder builder)
		{
			return new Offset<IDestroyItemData>(builder.EndTable());
		}

		// Token: 0x0602D1A5 RID: 184741 RVA: 0x0062FC68 File Offset: 0x0062DE68
		public IDestroyItemDataT UnPack()
		{
			IDestroyItemDataT destroyItemDataT = new IDestroyItemDataT();
			this.UnPackTo(destroyItemDataT);
			return destroyItemDataT;
		}

		// Token: 0x0602D1A6 RID: 184742 RVA: 0x0062FC83 File Offset: 0x0062DE83
		public void UnPackTo(IDestroyItemDataT _o)
		{
			_o.ItemId = this.ItemId;
			_o.Count = this.Count;
			_o.IsAll = this.IsAll;
		}

		// Token: 0x0602D1A7 RID: 184743 RVA: 0x0062FCAC File Offset: 0x0062DEAC
		public static Offset<IDestroyItemData> Pack(FlatBufferBuilder builder, IDestroyItemDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDestroyItemData>);
			}
			return IDestroyItemData.CreateIDestroyItemData(builder, _o.ItemId, _o.Count, _o.IsAll);
		}

		// Token: 0x04010BE9 RID: 68585
		private Table __p;
	}
}
