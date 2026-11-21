using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200542D RID: 21549
	public struct IBatchBulletItem : IFlatbufferObject
	{
		// Token: 0x170098FF RID: 39167
		// (get) Token: 0x06021C74 RID: 138356 RVA: 0x004A8358 File Offset: 0x004A6558
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021C75 RID: 138357 RVA: 0x004A8365 File Offset: 0x004A6565
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021C76 RID: 138358 RVA: 0x004A836C File Offset: 0x004A656C
		public static IBatchBulletItem GetRootAsIBatchBulletItem(ByteBuffer _bb)
		{
			return IBatchBulletItem.GetRootAsIBatchBulletItem(_bb, default(IBatchBulletItem));
		}

		// Token: 0x06021C77 RID: 138359 RVA: 0x004A8388 File Offset: 0x004A6588
		public static IBatchBulletItem GetRootAsIBatchBulletItem(ByteBuffer _bb, IBatchBulletItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021C78 RID: 138360 RVA: 0x004A83A5 File Offset: 0x004A65A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021C79 RID: 138361 RVA: 0x004A83B4 File Offset: 0x004A65B4
		public IBatchBulletItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009900 RID: 39168
		// (get) Token: 0x06021C7A RID: 138362 RVA: 0x004A83C4 File Offset: 0x004A65C4
		public int Time
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

		// Token: 0x06021C7B RID: 138363 RVA: 0x004A8400 File Offset: 0x004A6600
		public IBatchBulletCaster? CasterList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IBatchBulletCaster?(default(IBatchBulletCaster).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009901 RID: 39169
		// (get) Token: 0x06021C7C RID: 138364 RVA: 0x004A8460 File Offset: 0x004A6660
		public int CasterListLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06021C7D RID: 138365 RVA: 0x004A848B File Offset: 0x004A668B
		public static Offset<IBatchBulletItem> CreateIBatchBulletItem(FlatBufferBuilder builder, int Time = 0, VectorOffset CasterListOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IBatchBulletItem.AddCasterList(builder, CasterListOffset);
			IBatchBulletItem.AddTime(builder, Time);
			return IBatchBulletItem.EndIBatchBulletItem(builder);
		}

		// Token: 0x06021C7E RID: 138366 RVA: 0x004A84A8 File Offset: 0x004A66A8
		public static void StartIBatchBulletItem(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06021C7F RID: 138367 RVA: 0x004A84B1 File Offset: 0x004A66B1
		public static void AddTime(FlatBufferBuilder builder, int time)
		{
			builder.AddInt(0, time, 0);
		}

		// Token: 0x06021C80 RID: 138368 RVA: 0x004A84BC File Offset: 0x004A66BC
		public static void AddCasterList(FlatBufferBuilder builder, VectorOffset casterListOffset)
		{
			builder.AddOffset(1, casterListOffset.Value, 0);
		}

		// Token: 0x06021C81 RID: 138369 RVA: 0x004A84CC File Offset: 0x004A66CC
		public static VectorOffset CreateCasterListVector(FlatBufferBuilder builder, Offset<IBatchBulletCaster>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06021C82 RID: 138370 RVA: 0x004A850C File Offset: 0x004A670C
		public static VectorOffset CreateCasterListVectorBlock(FlatBufferBuilder builder, Offset<IBatchBulletCaster>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IBatchBulletCaster>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021C83 RID: 138371 RVA: 0x004A8526 File Offset: 0x004A6726
		public static VectorOffset CreateCasterListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IBatchBulletCaster>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IBatchBulletCaster>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021C84 RID: 138372 RVA: 0x004A8544 File Offset: 0x004A6744
		public static VectorOffset CreateCasterListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IBatchBulletCaster>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06021C85 RID: 138373 RVA: 0x004A855D File Offset: 0x004A675D
		public static void StartCasterListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06021C86 RID: 138374 RVA: 0x004A8568 File Offset: 0x004A6768
		public static Offset<IBatchBulletItem> EndIBatchBulletItem(FlatBufferBuilder builder)
		{
			return new Offset<IBatchBulletItem>(builder.EndTable());
		}

		// Token: 0x06021C87 RID: 138375 RVA: 0x004A8578 File Offset: 0x004A6778
		public IBatchBulletItemT UnPack()
		{
			IBatchBulletItemT batchBulletItemT = new IBatchBulletItemT();
			this.UnPackTo(batchBulletItemT);
			return batchBulletItemT;
		}

		// Token: 0x06021C88 RID: 138376 RVA: 0x004A8594 File Offset: 0x004A6794
		public void UnPackTo(IBatchBulletItemT _o)
		{
			_o.Time = this.Time;
			_o.CasterList = new List<IBatchBulletCasterT>();
			for (int i = 0; i < this.CasterListLength; i++)
			{
				_o.CasterList.Add((this.CasterList(i) != null) ? this.CasterList(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06021C89 RID: 138377 RVA: 0x004A8600 File Offset: 0x004A6800
		public static Offset<IBatchBulletItem> Pack(FlatBufferBuilder builder, IBatchBulletItemT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBatchBulletItem>);
			}
			VectorOffset casterListOffset = default(VectorOffset);
			if (_o.CasterList != null)
			{
				Offset<IBatchBulletCaster>[] array = new Offset<IBatchBulletCaster>[_o.CasterList.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IBatchBulletCaster.Pack(builder, _o.CasterList[i]);
				}
				casterListOffset = IBatchBulletItem.CreateCasterListVector(builder, array);
			}
			return IBatchBulletItem.CreateIBatchBulletItem(builder, _o.Time, casterListOffset);
		}

		// Token: 0x0400E8E3 RID: 59619
		private Table __p;
	}
}
