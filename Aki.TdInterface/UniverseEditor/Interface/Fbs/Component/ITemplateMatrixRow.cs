using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A58 RID: 23128
	public struct ITemplateMatrixRow : IFlatbufferObject
	{
		// Token: 0x1700AE0E RID: 44558
		// (get) Token: 0x06027590 RID: 161168 RVA: 0x0056A38A File Offset: 0x0056858A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027591 RID: 161169 RVA: 0x0056A397 File Offset: 0x00568597
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027592 RID: 161170 RVA: 0x0056A3A0 File Offset: 0x005685A0
		public static ITemplateMatrixRow GetRootAsITemplateMatrixRow(ByteBuffer _bb)
		{
			return ITemplateMatrixRow.GetRootAsITemplateMatrixRow(_bb, default(ITemplateMatrixRow));
		}

		// Token: 0x06027593 RID: 161171 RVA: 0x0056A3BC File Offset: 0x005685BC
		public static ITemplateMatrixRow GetRootAsITemplateMatrixRow(ByteBuffer _bb, ITemplateMatrixRow obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027594 RID: 161172 RVA: 0x0056A3D9 File Offset: 0x005685D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027595 RID: 161173 RVA: 0x0056A3E8 File Offset: 0x005685E8
		public ITemplateMatrixRow __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06027596 RID: 161174 RVA: 0x0056A3F8 File Offset: 0x005685F8
		public ISpawnTemplateEntityConfig? Items(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new ISpawnTemplateEntityConfig?(default(ISpawnTemplateEntityConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AE0F RID: 44559
		// (get) Token: 0x06027597 RID: 161175 RVA: 0x0056A458 File Offset: 0x00568658
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

		// Token: 0x06027598 RID: 161176 RVA: 0x0056A483 File Offset: 0x00568683
		public static Offset<ITemplateMatrixRow> CreateITemplateMatrixRow(FlatBufferBuilder builder, VectorOffset ItemsOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			ITemplateMatrixRow.AddItems(builder, ItemsOffset);
			return ITemplateMatrixRow.EndITemplateMatrixRow(builder);
		}

		// Token: 0x06027599 RID: 161177 RVA: 0x0056A499 File Offset: 0x00568699
		public static void StartITemplateMatrixRow(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602759A RID: 161178 RVA: 0x0056A4A2 File Offset: 0x005686A2
		public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset)
		{
			builder.AddOffset(0, itemsOffset.Value, 0);
		}

		// Token: 0x0602759B RID: 161179 RVA: 0x0056A4B4 File Offset: 0x005686B4
		public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<ISpawnTemplateEntityConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602759C RID: 161180 RVA: 0x0056A4F4 File Offset: 0x005686F4
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, Offset<ISpawnTemplateEntityConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISpawnTemplateEntityConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602759D RID: 161181 RVA: 0x0056A50E File Offset: 0x0056870E
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISpawnTemplateEntityConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISpawnTemplateEntityConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602759E RID: 161182 RVA: 0x0056A52C File Offset: 0x0056872C
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISpawnTemplateEntityConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602759F RID: 161183 RVA: 0x0056A545 File Offset: 0x00568745
		public static void StartItemsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060275A0 RID: 161184 RVA: 0x0056A550 File Offset: 0x00568750
		public static Offset<ITemplateMatrixRow> EndITemplateMatrixRow(FlatBufferBuilder builder)
		{
			return new Offset<ITemplateMatrixRow>(builder.EndTable());
		}

		// Token: 0x060275A1 RID: 161185 RVA: 0x0056A560 File Offset: 0x00568760
		public ITemplateMatrixRowT UnPack()
		{
			ITemplateMatrixRowT templateMatrixRowT = new ITemplateMatrixRowT();
			this.UnPackTo(templateMatrixRowT);
			return templateMatrixRowT;
		}

		// Token: 0x060275A2 RID: 161186 RVA: 0x0056A57C File Offset: 0x0056877C
		public void UnPackTo(ITemplateMatrixRowT _o)
		{
			_o.Items = new List<ISpawnTemplateEntityConfigT>();
			for (int i = 0; i < this.ItemsLength; i++)
			{
				_o.Items.Add((this.Items(i) != null) ? this.Items(i).Value.UnPack() : null);
			}
		}

		// Token: 0x060275A3 RID: 161187 RVA: 0x0056A5DC File Offset: 0x005687DC
		public static Offset<ITemplateMatrixRow> Pack(FlatBufferBuilder builder, ITemplateMatrixRowT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITemplateMatrixRow>);
			}
			VectorOffset itemsOffset = default(VectorOffset);
			if (_o.Items != null)
			{
				Offset<ISpawnTemplateEntityConfig>[] array = new Offset<ISpawnTemplateEntityConfig>[_o.Items.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ISpawnTemplateEntityConfig.Pack(builder, _o.Items[i]);
				}
				itemsOffset = ITemplateMatrixRow.CreateItemsVector(builder, array);
			}
			return ITemplateMatrixRow.CreateITemplateMatrixRow(builder, itemsOffset);
		}

		// Token: 0x0400F0E9 RID: 61673
		private Table __p;
	}
}
