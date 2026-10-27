using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A57 RID: 19031
	public struct ICheckHonamiStoryEquipItem : IFlatbufferObject
	{
		// Token: 0x170089C5 RID: 35269
		// (get) Token: 0x0601DCE0 RID: 122080 RVA: 0x00430700 File Offset: 0x0042E900
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DCE1 RID: 122081 RVA: 0x0043070D File Offset: 0x0042E90D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DCE2 RID: 122082 RVA: 0x00430714 File Offset: 0x0042E914
		public static ICheckHonamiStoryEquipItem GetRootAsICheckHonamiStoryEquipItem(ByteBuffer _bb)
		{
			return ICheckHonamiStoryEquipItem.GetRootAsICheckHonamiStoryEquipItem(_bb, default(ICheckHonamiStoryEquipItem));
		}

		// Token: 0x0601DCE3 RID: 122083 RVA: 0x00430730 File Offset: 0x0042E930
		public static ICheckHonamiStoryEquipItem GetRootAsICheckHonamiStoryEquipItem(ByteBuffer _bb, ICheckHonamiStoryEquipItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DCE4 RID: 122084 RVA: 0x0043074D File Offset: 0x0042E94D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DCE5 RID: 122085 RVA: 0x0043075C File Offset: 0x0042E95C
		public ICheckHonamiStoryEquipItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170089C6 RID: 35270
		// (get) Token: 0x0601DCE6 RID: 122086 RVA: 0x0043076C File Offset: 0x0042E96C
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

		// Token: 0x170089C7 RID: 35271
		// (get) Token: 0x0601DCE7 RID: 122087 RVA: 0x004307A8 File Offset: 0x0042E9A8
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

		// Token: 0x170089C8 RID: 35272
		// (get) Token: 0x0601DCE8 RID: 122088 RVA: 0x004307E4 File Offset: 0x0042E9E4
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

		// Token: 0x0601DCE9 RID: 122089 RVA: 0x00430820 File Offset: 0x0042EA20
		public static Offset<ICheckHonamiStoryEquipItem> CreateICheckHonamiStoryEquipItem(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int ItemId = 0, int Count = 0)
		{
			builder.StartTable(3);
			ICheckHonamiStoryEquipItem.AddCount(builder, Count);
			ICheckHonamiStoryEquipItem.AddItemId(builder, ItemId);
			ICheckHonamiStoryEquipItem.AddType(builder, Type);
			return ICheckHonamiStoryEquipItem.EndICheckHonamiStoryEquipItem(builder);
		}

		// Token: 0x0601DCEA RID: 122090 RVA: 0x00430844 File Offset: 0x0042EA44
		public static void StartICheckHonamiStoryEquipItem(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601DCEB RID: 122091 RVA: 0x0043084D File Offset: 0x0042EA4D
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601DCEC RID: 122092 RVA: 0x00430858 File Offset: 0x0042EA58
		public static void AddItemId(FlatBufferBuilder builder, int itemId)
		{
			builder.AddInt(1, itemId, 0);
		}

		// Token: 0x0601DCED RID: 122093 RVA: 0x00430863 File Offset: 0x0042EA63
		public static void AddCount(FlatBufferBuilder builder, int count)
		{
			builder.AddInt(2, count, 0);
		}

		// Token: 0x0601DCEE RID: 122094 RVA: 0x0043086E File Offset: 0x0042EA6E
		public static Offset<ICheckHonamiStoryEquipItem> EndICheckHonamiStoryEquipItem(FlatBufferBuilder builder)
		{
			return new Offset<ICheckHonamiStoryEquipItem>(builder.EndTable());
		}

		// Token: 0x0601DCEF RID: 122095 RVA: 0x0043087C File Offset: 0x0042EA7C
		public ICheckHonamiStoryEquipItemT UnPack()
		{
			ICheckHonamiStoryEquipItemT checkHonamiStoryEquipItemT = new ICheckHonamiStoryEquipItemT();
			this.UnPackTo(checkHonamiStoryEquipItemT);
			return checkHonamiStoryEquipItemT;
		}

		// Token: 0x0601DCF0 RID: 122096 RVA: 0x00430897 File Offset: 0x0042EA97
		public void UnPackTo(ICheckHonamiStoryEquipItemT _o)
		{
			_o.Type = this.Type;
			_o.ItemId = this.ItemId;
			_o.Count = this.Count;
		}

		// Token: 0x0601DCF1 RID: 122097 RVA: 0x004308C0 File Offset: 0x0042EAC0
		public static Offset<ICheckHonamiStoryEquipItem> Pack(FlatBufferBuilder builder, ICheckHonamiStoryEquipItemT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckHonamiStoryEquipItem>);
			}
			return ICheckHonamiStoryEquipItem.CreateICheckHonamiStoryEquipItem(builder, _o.Type, _o.ItemId, _o.Count);
		}

		// Token: 0x0400D2B4 RID: 53940
		private Table __p;
	}
}
