using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F1D RID: 20253
	public struct ICheckHonamiStoryEquipItem : IFlatbufferObject
	{
		// Token: 0x170090A1 RID: 37025
		// (get) Token: 0x0601F783 RID: 128899 RVA: 0x0046188C File Offset: 0x0045FA8C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F784 RID: 128900 RVA: 0x00461899 File Offset: 0x0045FA99
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F785 RID: 128901 RVA: 0x004618A0 File Offset: 0x0045FAA0
		public static ICheckHonamiStoryEquipItem GetRootAsICheckHonamiStoryEquipItem(ByteBuffer _bb)
		{
			return ICheckHonamiStoryEquipItem.GetRootAsICheckHonamiStoryEquipItem(_bb, default(ICheckHonamiStoryEquipItem));
		}

		// Token: 0x0601F786 RID: 128902 RVA: 0x004618BC File Offset: 0x0045FABC
		public static ICheckHonamiStoryEquipItem GetRootAsICheckHonamiStoryEquipItem(ByteBuffer _bb, ICheckHonamiStoryEquipItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F787 RID: 128903 RVA: 0x004618D9 File Offset: 0x0045FAD9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F788 RID: 128904 RVA: 0x004618E8 File Offset: 0x0045FAE8
		public ICheckHonamiStoryEquipItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170090A2 RID: 37026
		// (get) Token: 0x0601F789 RID: 128905 RVA: 0x004618F8 File Offset: 0x0045FAF8
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170090A3 RID: 37027
		// (get) Token: 0x0601F78A RID: 128906 RVA: 0x00461934 File Offset: 0x0045FB34
		public int ItemId
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

		// Token: 0x170090A4 RID: 37028
		// (get) Token: 0x0601F78B RID: 128907 RVA: 0x00461970 File Offset: 0x0045FB70
		public int Count
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

		// Token: 0x0601F78C RID: 128908 RVA: 0x004619AC File Offset: 0x0045FBAC
		public static Offset<ICheckHonamiStoryEquipItem> CreateICheckHonamiStoryEquipItem(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int ItemId = 0, int Count = 0)
		{
			builder.StartTable(3);
			ICheckHonamiStoryEquipItem.AddCount(builder, Count);
			ICheckHonamiStoryEquipItem.AddItemId(builder, ItemId);
			ICheckHonamiStoryEquipItem.AddType(builder, Type);
			return ICheckHonamiStoryEquipItem.EndICheckHonamiStoryEquipItem(builder);
		}

		// Token: 0x0601F78D RID: 128909 RVA: 0x004619D0 File Offset: 0x0045FBD0
		public static void StartICheckHonamiStoryEquipItem(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601F78E RID: 128910 RVA: 0x004619D9 File Offset: 0x0045FBD9
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F78F RID: 128911 RVA: 0x004619E4 File Offset: 0x0045FBE4
		public static void AddItemId(FlatBufferBuilder builder, int itemId)
		{
			builder.AddInt(1, itemId, 0);
		}

		// Token: 0x0601F790 RID: 128912 RVA: 0x004619EF File Offset: 0x0045FBEF
		public static void AddCount(FlatBufferBuilder builder, int count)
		{
			builder.AddInt(2, count, 0);
		}

		// Token: 0x0601F791 RID: 128913 RVA: 0x004619FA File Offset: 0x0045FBFA
		public static Offset<ICheckHonamiStoryEquipItem> EndICheckHonamiStoryEquipItem(FlatBufferBuilder builder)
		{
			return new Offset<ICheckHonamiStoryEquipItem>(builder.EndTable());
		}

		// Token: 0x0601F792 RID: 128914 RVA: 0x00461A08 File Offset: 0x0045FC08
		public ICheckHonamiStoryEquipItemT UnPack()
		{
			ICheckHonamiStoryEquipItemT checkHonamiStoryEquipItemT = new ICheckHonamiStoryEquipItemT();
			this.UnPackTo(checkHonamiStoryEquipItemT);
			return checkHonamiStoryEquipItemT;
		}

		// Token: 0x0601F793 RID: 128915 RVA: 0x00461A23 File Offset: 0x0045FC23
		public void UnPackTo(ICheckHonamiStoryEquipItemT _o)
		{
			_o.Type = this.Type;
			_o.ItemId = this.ItemId;
			_o.Count = this.Count;
		}

		// Token: 0x0601F794 RID: 128916 RVA: 0x00461A4C File Offset: 0x0045FC4C
		public static Offset<ICheckHonamiStoryEquipItem> Pack(FlatBufferBuilder builder, ICheckHonamiStoryEquipItemT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckHonamiStoryEquipItem>);
			}
			return ICheckHonamiStoryEquipItem.CreateICheckHonamiStoryEquipItem(builder, _o.Type, _o.ItemId, _o.Count);
		}

		// Token: 0x0400DD8F RID: 56719
		private Table __p;
	}
}
