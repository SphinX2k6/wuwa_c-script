using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004EFB RID: 20219
	public struct IBatchBulletItem : IFlatbufferObject
	{
		// Token: 0x1700917D RID: 37245
		// (get) Token: 0x0601FF04 RID: 130820 RVA: 0x00471FC4 File Offset: 0x004701C4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FF05 RID: 130821 RVA: 0x00471FD1 File Offset: 0x004701D1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FF06 RID: 130822 RVA: 0x00471FD8 File Offset: 0x004701D8
		public static IBatchBulletItem GetRootAsIBatchBulletItem(ByteBuffer _bb)
		{
			return IBatchBulletItem.GetRootAsIBatchBulletItem(_bb, default(IBatchBulletItem));
		}

		// Token: 0x0601FF07 RID: 130823 RVA: 0x00471FF4 File Offset: 0x004701F4
		public static IBatchBulletItem GetRootAsIBatchBulletItem(ByteBuffer _bb, IBatchBulletItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FF08 RID: 130824 RVA: 0x00472011 File Offset: 0x00470211
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FF09 RID: 130825 RVA: 0x00472020 File Offset: 0x00470220
		public IBatchBulletItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700917E RID: 37246
		// (get) Token: 0x0601FF0A RID: 130826 RVA: 0x00472030 File Offset: 0x00470230
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

		// Token: 0x0601FF0B RID: 130827 RVA: 0x0047206C File Offset: 0x0047026C
		public IBatchBulletCaster? CasterList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IBatchBulletCaster?(default(IBatchBulletCaster).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700917F RID: 37247
		// (get) Token: 0x0601FF0C RID: 130828 RVA: 0x004720CC File Offset: 0x004702CC
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

		// Token: 0x0601FF0D RID: 130829 RVA: 0x004720F7 File Offset: 0x004702F7
		public static Offset<IBatchBulletItem> CreateIBatchBulletItem(FlatBufferBuilder builder, int Time = 0, VectorOffset CasterListOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IBatchBulletItem.AddCasterList(builder, CasterListOffset);
			IBatchBulletItem.AddTime(builder, Time);
			return IBatchBulletItem.EndIBatchBulletItem(builder);
		}

		// Token: 0x0601FF0E RID: 130830 RVA: 0x00472114 File Offset: 0x00470314
		public static void StartIBatchBulletItem(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601FF0F RID: 130831 RVA: 0x0047211D File Offset: 0x0047031D
		public static void AddTime(FlatBufferBuilder builder, int time)
		{
			builder.AddInt(0, time, 0);
		}

		// Token: 0x0601FF10 RID: 130832 RVA: 0x00472128 File Offset: 0x00470328
		public static void AddCasterList(FlatBufferBuilder builder, VectorOffset casterListOffset)
		{
			builder.AddOffset(1, casterListOffset.Value, 0);
		}

		// Token: 0x0601FF11 RID: 130833 RVA: 0x00472138 File Offset: 0x00470338
		public static VectorOffset CreateCasterListVector(FlatBufferBuilder builder, Offset<IBatchBulletCaster>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601FF12 RID: 130834 RVA: 0x00472178 File Offset: 0x00470378
		public static VectorOffset CreateCasterListVectorBlock(FlatBufferBuilder builder, Offset<IBatchBulletCaster>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IBatchBulletCaster>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601FF13 RID: 130835 RVA: 0x00472192 File Offset: 0x00470392
		public static VectorOffset CreateCasterListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IBatchBulletCaster>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IBatchBulletCaster>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601FF14 RID: 130836 RVA: 0x004721B0 File Offset: 0x004703B0
		public static VectorOffset CreateCasterListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IBatchBulletCaster>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601FF15 RID: 130837 RVA: 0x004721C9 File Offset: 0x004703C9
		public static void StartCasterListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601FF16 RID: 130838 RVA: 0x004721D4 File Offset: 0x004703D4
		public static Offset<IBatchBulletItem> EndIBatchBulletItem(FlatBufferBuilder builder)
		{
			return new Offset<IBatchBulletItem>(builder.EndTable());
		}

		// Token: 0x0601FF17 RID: 130839 RVA: 0x004721E4 File Offset: 0x004703E4
		public IBatchBulletItemT UnPack()
		{
			IBatchBulletItemT batchBulletItemT = new IBatchBulletItemT();
			this.UnPackTo(batchBulletItemT);
			return batchBulletItemT;
		}

		// Token: 0x0601FF18 RID: 130840 RVA: 0x00472200 File Offset: 0x00470400
		public void UnPackTo(IBatchBulletItemT _o)
		{
			_o.Time = this.Time;
			_o.CasterList = new List<IBatchBulletCasterT>();
			for (int i = 0; i < this.CasterListLength; i++)
			{
				_o.CasterList.Add((this.CasterList(i) != null) ? this.CasterList(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601FF19 RID: 130841 RVA: 0x0047226C File Offset: 0x0047046C
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

		// Token: 0x0400DD34 RID: 56628
		private Table __p;
	}
}
