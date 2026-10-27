using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BF7 RID: 23543
	public struct TComponentsData : IFlatbufferObject
	{
		// Token: 0x1700B1D2 RID: 45522
		// (get) Token: 0x0602863D RID: 165437 RVA: 0x0058F6BC File Offset: 0x0058D8BC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602863E RID: 165438 RVA: 0x0058F6C9 File Offset: 0x0058D8C9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602863F RID: 165439 RVA: 0x0058F6D0 File Offset: 0x0058D8D0
		public static TComponentsData GetRootAsTComponentsData(ByteBuffer _bb)
		{
			return TComponentsData.GetRootAsTComponentsData(_bb, default(TComponentsData));
		}

		// Token: 0x06028640 RID: 165440 RVA: 0x0058F6EC File Offset: 0x0058D8EC
		public static TComponentsData GetRootAsTComponentsData(ByteBuffer _bb, TComponentsData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028641 RID: 165441 RVA: 0x0058F709 File Offset: 0x0058D909
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028642 RID: 165442 RVA: 0x0058F718 File Offset: 0x0058D918
		public TComponentsData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06028643 RID: 165443 RVA: 0x0058F728 File Offset: 0x0058D928
		public TComponentData? Items(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new TComponentData?(default(TComponentData).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B1D3 RID: 45523
		// (get) Token: 0x06028644 RID: 165444 RVA: 0x0058F788 File Offset: 0x0058D988
		public int ItemsLength
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06028645 RID: 165445 RVA: 0x0058F7B3 File Offset: 0x0058D9B3
		public static Offset<TComponentsData> CreateTComponentsData(FlatBufferBuilder builder, VectorOffset itemsOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			TComponentsData.AddItems(builder, itemsOffset);
			return TComponentsData.EndTComponentsData(builder);
		}

		// Token: 0x06028646 RID: 165446 RVA: 0x0058F7C9 File Offset: 0x0058D9C9
		public static void StartTComponentsData(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06028647 RID: 165447 RVA: 0x0058F7D2 File Offset: 0x0058D9D2
		public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset)
		{
			builder.AddOffset(0, itemsOffset.Value, 0);
		}

		// Token: 0x06028648 RID: 165448 RVA: 0x0058F7E4 File Offset: 0x0058D9E4
		public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<TComponentData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06028649 RID: 165449 RVA: 0x0058F824 File Offset: 0x0058DA24
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, Offset<TComponentData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<TComponentData>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602864A RID: 165450 RVA: 0x0058F83E File Offset: 0x0058DA3E
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<TComponentData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<TComponentData>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602864B RID: 165451 RVA: 0x0058F85C File Offset: 0x0058DA5C
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<TComponentData>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602864C RID: 165452 RVA: 0x0058F875 File Offset: 0x0058DA75
		public static void StartItemsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602864D RID: 165453 RVA: 0x0058F880 File Offset: 0x0058DA80
		public static Offset<TComponentsData> EndTComponentsData(FlatBufferBuilder builder)
		{
			return new Offset<TComponentsData>(builder.EndTable());
		}

		// Token: 0x0602864E RID: 165454 RVA: 0x0058F890 File Offset: 0x0058DA90
		public TComponentsDataT UnPack()
		{
			TComponentsDataT tcomponentsDataT = new TComponentsDataT();
			this.UnPackTo(tcomponentsDataT);
			return tcomponentsDataT;
		}

		// Token: 0x0602864F RID: 165455 RVA: 0x0058F8AC File Offset: 0x0058DAAC
		public void UnPackTo(TComponentsDataT _o)
		{
			_o.Items = new List<TComponentDataT>();
			for (int i = 0; i < this.ItemsLength; i++)
			{
				_o.Items.Add((this.Items(i) != null) ? this.Items(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06028650 RID: 165456 RVA: 0x0058F90C File Offset: 0x0058DB0C
		public static Offset<TComponentsData> Pack(FlatBufferBuilder builder, TComponentsDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<TComponentsData>);
			}
			VectorOffset itemsOffset = default(VectorOffset);
			if (_o.Items != null)
			{
				Offset<TComponentData>[] array = new Offset<TComponentData>[_o.Items.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = TComponentData.Pack(builder, _o.Items[i]);
				}
				itemsOffset = TComponentsData.CreateItemsVector(builder, array);
			}
			return TComponentsData.CreateTComponentsData(builder, itemsOffset);
		}

		// Token: 0x0400F397 RID: 62359
		private Table __p;
	}
}
