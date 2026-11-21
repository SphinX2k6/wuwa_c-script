using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F7A RID: 20346
	public struct ICheckItems : IFlatbufferObject
	{
		// Token: 0x17009178 RID: 37240
		// (get) Token: 0x0601FADD RID: 129757 RVA: 0x0046776C File Offset: 0x0046596C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FADE RID: 129758 RVA: 0x00467779 File Offset: 0x00465979
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FADF RID: 129759 RVA: 0x00467780 File Offset: 0x00465980
		public static ICheckItems GetRootAsICheckItems(ByteBuffer _bb)
		{
			return ICheckItems.GetRootAsICheckItems(_bb, default(ICheckItems));
		}

		// Token: 0x0601FAE0 RID: 129760 RVA: 0x0046779C File Offset: 0x0046599C
		public static ICheckItems GetRootAsICheckItems(ByteBuffer _bb, ICheckItems obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FAE1 RID: 129761 RVA: 0x004677B9 File Offset: 0x004659B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FAE2 RID: 129762 RVA: 0x004677C8 File Offset: 0x004659C8
		public ICheckItems __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009179 RID: 37241
		// (get) Token: 0x0601FAE3 RID: 129763 RVA: 0x004677D8 File Offset: 0x004659D8
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

		// Token: 0x1700917A RID: 37242
		// (get) Token: 0x0601FAE4 RID: 129764 RVA: 0x00467814 File Offset: 0x00465A14
		public ECompare Compare
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601FAE5 RID: 129765 RVA: 0x00467850 File Offset: 0x00465A50
		public IItemConfig? Items(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IItemConfig?(default(IItemConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700917B RID: 37243
		// (get) Token: 0x0601FAE6 RID: 129766 RVA: 0x004678B0 File Offset: 0x00465AB0
		public int ItemsLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0601FAE7 RID: 129767 RVA: 0x004678DB File Offset: 0x00465ADB
		public static Offset<ICheckItems> CreateICheckItems(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, ECompare Compare = ECompare.Eq, VectorOffset ItemsOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			ICheckItems.AddItems(builder, ItemsOffset);
			ICheckItems.AddCompare(builder, Compare);
			ICheckItems.AddType(builder, Type);
			return ICheckItems.EndICheckItems(builder);
		}

		// Token: 0x0601FAE8 RID: 129768 RVA: 0x004678FF File Offset: 0x00465AFF
		public static void StartICheckItems(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601FAE9 RID: 129769 RVA: 0x00467908 File Offset: 0x00465B08
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601FAEA RID: 129770 RVA: 0x00467913 File Offset: 0x00465B13
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(1, (byte)compare, 0);
		}

		// Token: 0x0601FAEB RID: 129771 RVA: 0x0046791E File Offset: 0x00465B1E
		public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset)
		{
			builder.AddOffset(2, itemsOffset.Value, 0);
		}

		// Token: 0x0601FAEC RID: 129772 RVA: 0x00467930 File Offset: 0x00465B30
		public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<IItemConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601FAED RID: 129773 RVA: 0x00467970 File Offset: 0x00465B70
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, Offset<IItemConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IItemConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601FAEE RID: 129774 RVA: 0x0046798A File Offset: 0x00465B8A
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IItemConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IItemConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601FAEF RID: 129775 RVA: 0x004679A8 File Offset: 0x00465BA8
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IItemConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601FAF0 RID: 129776 RVA: 0x004679C1 File Offset: 0x00465BC1
		public static void StartItemsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601FAF1 RID: 129777 RVA: 0x004679CC File Offset: 0x00465BCC
		public static Offset<ICheckItems> EndICheckItems(FlatBufferBuilder builder)
		{
			return new Offset<ICheckItems>(builder.EndTable());
		}

		// Token: 0x0601FAF2 RID: 129778 RVA: 0x004679DC File Offset: 0x00465BDC
		public ICheckItemsT UnPack()
		{
			ICheckItemsT checkItemsT = new ICheckItemsT();
			this.UnPackTo(checkItemsT);
			return checkItemsT;
		}

		// Token: 0x0601FAF3 RID: 129779 RVA: 0x004679F8 File Offset: 0x00465BF8
		public void UnPackTo(ICheckItemsT _o)
		{
			_o.Type = this.Type;
			_o.Compare = this.Compare;
			_o.Items = new List<IItemConfigT>();
			for (int i = 0; i < this.ItemsLength; i++)
			{
				_o.Items.Add((this.Items(i) != null) ? this.Items(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601FAF4 RID: 129780 RVA: 0x00467A70 File Offset: 0x00465C70
		public static Offset<ICheckItems> Pack(FlatBufferBuilder builder, ICheckItemsT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckItems>);
			}
			VectorOffset itemsOffset = default(VectorOffset);
			if (_o.Items != null)
			{
				Offset<IItemConfig>[] array = new Offset<IItemConfig>[_o.Items.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IItemConfig.Pack(builder, _o.Items[i]);
				}
				itemsOffset = ICheckItems.CreateItemsVector(builder, array);
			}
			return ICheckItems.CreateICheckItems(builder, _o.Type, _o.Compare, itemsOffset);
		}

		// Token: 0x0400DE0A RID: 56842
		private Table __p;
	}
}
