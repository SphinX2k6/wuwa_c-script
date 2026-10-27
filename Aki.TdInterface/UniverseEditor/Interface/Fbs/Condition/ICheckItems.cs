using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004AAB RID: 19115
	public struct ICheckItems : IFlatbufferObject
	{
		// Token: 0x17008A8B RID: 35467
		// (get) Token: 0x0601DFF4 RID: 122868 RVA: 0x00435F4C File Offset: 0x0043414C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DFF5 RID: 122869 RVA: 0x00435F59 File Offset: 0x00434159
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DFF6 RID: 122870 RVA: 0x00435F60 File Offset: 0x00434160
		public static ICheckItems GetRootAsICheckItems(ByteBuffer _bb)
		{
			return ICheckItems.GetRootAsICheckItems(_bb, default(ICheckItems));
		}

		// Token: 0x0601DFF7 RID: 122871 RVA: 0x00435F7C File Offset: 0x0043417C
		public static ICheckItems GetRootAsICheckItems(ByteBuffer _bb, ICheckItems obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DFF8 RID: 122872 RVA: 0x00435F99 File Offset: 0x00434199
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DFF9 RID: 122873 RVA: 0x00435FA8 File Offset: 0x004341A8
		public ICheckItems __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008A8C RID: 35468
		// (get) Token: 0x0601DFFA RID: 122874 RVA: 0x00435FB8 File Offset: 0x004341B8
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

		// Token: 0x17008A8D RID: 35469
		// (get) Token: 0x0601DFFB RID: 122875 RVA: 0x00435FF4 File Offset: 0x004341F4
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

		// Token: 0x0601DFFC RID: 122876 RVA: 0x00436030 File Offset: 0x00434230
		public IItemConfig? Items(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IItemConfig?(default(IItemConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008A8E RID: 35470
		// (get) Token: 0x0601DFFD RID: 122877 RVA: 0x00436090 File Offset: 0x00434290
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

		// Token: 0x0601DFFE RID: 122878 RVA: 0x004360BB File Offset: 0x004342BB
		public static Offset<ICheckItems> CreateICheckItems(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, ECompare Compare = ECompare.Eq, VectorOffset ItemsOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			ICheckItems.AddItems(builder, ItemsOffset);
			ICheckItems.AddCompare(builder, Compare);
			ICheckItems.AddType(builder, Type);
			return ICheckItems.EndICheckItems(builder);
		}

		// Token: 0x0601DFFF RID: 122879 RVA: 0x004360DF File Offset: 0x004342DF
		public static void StartICheckItems(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601E000 RID: 122880 RVA: 0x004360E8 File Offset: 0x004342E8
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E001 RID: 122881 RVA: 0x004360F3 File Offset: 0x004342F3
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(1, (byte)compare, 0);
		}

		// Token: 0x0601E002 RID: 122882 RVA: 0x004360FE File Offset: 0x004342FE
		public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset)
		{
			builder.AddOffset(2, itemsOffset.Value, 0);
		}

		// Token: 0x0601E003 RID: 122883 RVA: 0x00436110 File Offset: 0x00434310
		public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<IItemConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601E004 RID: 122884 RVA: 0x00436150 File Offset: 0x00434350
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, Offset<IItemConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IItemConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E005 RID: 122885 RVA: 0x0043616A File Offset: 0x0043436A
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IItemConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IItemConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E006 RID: 122886 RVA: 0x00436188 File Offset: 0x00434388
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IItemConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601E007 RID: 122887 RVA: 0x004361A1 File Offset: 0x004343A1
		public static void StartItemsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601E008 RID: 122888 RVA: 0x004361AC File Offset: 0x004343AC
		public static Offset<ICheckItems> EndICheckItems(FlatBufferBuilder builder)
		{
			return new Offset<ICheckItems>(builder.EndTable());
		}

		// Token: 0x0601E009 RID: 122889 RVA: 0x004361BC File Offset: 0x004343BC
		public ICheckItemsT UnPack()
		{
			ICheckItemsT checkItemsT = new ICheckItemsT();
			this.UnPackTo(checkItemsT);
			return checkItemsT;
		}

		// Token: 0x0601E00A RID: 122890 RVA: 0x004361D8 File Offset: 0x004343D8
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

		// Token: 0x0601E00B RID: 122891 RVA: 0x00436250 File Offset: 0x00434450
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

		// Token: 0x0400D325 RID: 54053
		private Table __p;
	}
}
