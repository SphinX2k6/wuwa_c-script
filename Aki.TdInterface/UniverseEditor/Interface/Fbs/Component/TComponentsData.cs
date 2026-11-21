using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006216 RID: 25110
	public struct TComponentsData : IFlatbufferObject
	{
		// Token: 0x1700BB20 RID: 47904
		// (get) Token: 0x0602AC2D RID: 175149 RVA: 0x005D7604 File Offset: 0x005D5804
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602AC2E RID: 175150 RVA: 0x005D7611 File Offset: 0x005D5811
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602AC2F RID: 175151 RVA: 0x005D7618 File Offset: 0x005D5818
		public static TComponentsData GetRootAsTComponentsData(ByteBuffer _bb)
		{
			return TComponentsData.GetRootAsTComponentsData(_bb, default(TComponentsData));
		}

		// Token: 0x0602AC30 RID: 175152 RVA: 0x005D7634 File Offset: 0x005D5834
		public static TComponentsData GetRootAsTComponentsData(ByteBuffer _bb, TComponentsData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602AC31 RID: 175153 RVA: 0x005D7651 File Offset: 0x005D5851
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602AC32 RID: 175154 RVA: 0x005D7660 File Offset: 0x005D5860
		public TComponentsData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602AC33 RID: 175155 RVA: 0x005D7670 File Offset: 0x005D5870
		public TComponentData? Items(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new TComponentData?(default(TComponentData).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700BB21 RID: 47905
		// (get) Token: 0x0602AC34 RID: 175156 RVA: 0x005D76D0 File Offset: 0x005D58D0
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

		// Token: 0x0602AC35 RID: 175157 RVA: 0x005D76FB File Offset: 0x005D58FB
		public static Offset<TComponentsData> CreateTComponentsData(FlatBufferBuilder builder, VectorOffset itemsOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			TComponentsData.AddItems(builder, itemsOffset);
			return TComponentsData.EndTComponentsData(builder);
		}

		// Token: 0x0602AC36 RID: 175158 RVA: 0x005D7711 File Offset: 0x005D5911
		public static void StartTComponentsData(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602AC37 RID: 175159 RVA: 0x005D771A File Offset: 0x005D591A
		public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset)
		{
			builder.AddOffset(0, itemsOffset.Value, 0);
		}

		// Token: 0x0602AC38 RID: 175160 RVA: 0x005D772C File Offset: 0x005D592C
		public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<TComponentData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602AC39 RID: 175161 RVA: 0x005D776C File Offset: 0x005D596C
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, Offset<TComponentData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<TComponentData>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602AC3A RID: 175162 RVA: 0x005D7786 File Offset: 0x005D5986
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<TComponentData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<TComponentData>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602AC3B RID: 175163 RVA: 0x005D77A4 File Offset: 0x005D59A4
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<TComponentData>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602AC3C RID: 175164 RVA: 0x005D77BD File Offset: 0x005D59BD
		public static void StartItemsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602AC3D RID: 175165 RVA: 0x005D77C8 File Offset: 0x005D59C8
		public static Offset<TComponentsData> EndTComponentsData(FlatBufferBuilder builder)
		{
			return new Offset<TComponentsData>(builder.EndTable());
		}

		// Token: 0x0602AC3E RID: 175166 RVA: 0x005D77D8 File Offset: 0x005D59D8
		public TComponentsDataT UnPack()
		{
			TComponentsDataT tcomponentsDataT = new TComponentsDataT();
			this.UnPackTo(tcomponentsDataT);
			return tcomponentsDataT;
		}

		// Token: 0x0602AC3F RID: 175167 RVA: 0x005D77F4 File Offset: 0x005D59F4
		public void UnPackTo(TComponentsDataT _o)
		{
			_o.Items = new List<TComponentDataT>();
			for (int i = 0; i < this.ItemsLength; i++)
			{
				_o.Items.Add((this.Items(i) != null) ? this.Items(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0602AC40 RID: 175168 RVA: 0x005D7854 File Offset: 0x005D5A54
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

		// Token: 0x040100B2 RID: 65714
		private Table __p;
	}
}
