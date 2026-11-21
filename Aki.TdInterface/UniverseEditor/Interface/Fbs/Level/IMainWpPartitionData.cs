using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Level
{
	// Token: 0x0200487A RID: 18554
	public struct IMainWpPartitionData : IFlatbufferObject
	{
		// Token: 0x17008130 RID: 33072
		// (get) Token: 0x0601B703 RID: 112387 RVA: 0x003E2387 File Offset: 0x003E0587
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B704 RID: 112388 RVA: 0x003E2394 File Offset: 0x003E0594
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B705 RID: 112389 RVA: 0x003E239C File Offset: 0x003E059C
		public static IMainWpPartitionData GetRootAsIMainWpPartitionData(ByteBuffer _bb)
		{
			return IMainWpPartitionData.GetRootAsIMainWpPartitionData(_bb, default(IMainWpPartitionData));
		}

		// Token: 0x0601B706 RID: 112390 RVA: 0x003E23B8 File Offset: 0x003E05B8
		public static IMainWpPartitionData GetRootAsIMainWpPartitionData(ByteBuffer _bb, IMainWpPartitionData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B707 RID: 112391 RVA: 0x003E23D5 File Offset: 0x003E05D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B708 RID: 112392 RVA: 0x003E23E4 File Offset: 0x003E05E4
		public IMainWpPartitionData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0601B709 RID: 112393 RVA: 0x003E23F4 File Offset: 0x003E05F4
		public ISubWpData? SubWpData(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new ISubWpData?(default(ISubWpData).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008131 RID: 33073
		// (get) Token: 0x0601B70A RID: 112394 RVA: 0x003E2454 File Offset: 0x003E0654
		public int SubWpDataLength
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

		// Token: 0x0601B70B RID: 112395 RVA: 0x003E247F File Offset: 0x003E067F
		public static Offset<IMainWpPartitionData> CreateIMainWpPartitionData(FlatBufferBuilder builder, VectorOffset SubWpDataOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IMainWpPartitionData.AddSubWpData(builder, SubWpDataOffset);
			return IMainWpPartitionData.EndIMainWpPartitionData(builder);
		}

		// Token: 0x0601B70C RID: 112396 RVA: 0x003E2495 File Offset: 0x003E0695
		public static void StartIMainWpPartitionData(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601B70D RID: 112397 RVA: 0x003E249E File Offset: 0x003E069E
		public static void AddSubWpData(FlatBufferBuilder builder, VectorOffset subWpDataOffset)
		{
			builder.AddOffset(0, subWpDataOffset.Value, 0);
		}

		// Token: 0x0601B70E RID: 112398 RVA: 0x003E24B0 File Offset: 0x003E06B0
		public static VectorOffset CreateSubWpDataVector(FlatBufferBuilder builder, Offset<ISubWpData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601B70F RID: 112399 RVA: 0x003E24F0 File Offset: 0x003E06F0
		public static VectorOffset CreateSubWpDataVectorBlock(FlatBufferBuilder builder, Offset<ISubWpData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISubWpData>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B710 RID: 112400 RVA: 0x003E250A File Offset: 0x003E070A
		public static VectorOffset CreateSubWpDataVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISubWpData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISubWpData>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B711 RID: 112401 RVA: 0x003E2528 File Offset: 0x003E0728
		public static VectorOffset CreateSubWpDataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISubWpData>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601B712 RID: 112402 RVA: 0x003E2541 File Offset: 0x003E0741
		public static void StartSubWpDataVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601B713 RID: 112403 RVA: 0x003E254C File Offset: 0x003E074C
		public static Offset<IMainWpPartitionData> EndIMainWpPartitionData(FlatBufferBuilder builder)
		{
			return new Offset<IMainWpPartitionData>(builder.EndTable());
		}

		// Token: 0x0601B714 RID: 112404 RVA: 0x003E255C File Offset: 0x003E075C
		public IMainWpPartitionDataT UnPack()
		{
			IMainWpPartitionDataT mainWpPartitionDataT = new IMainWpPartitionDataT();
			this.UnPackTo(mainWpPartitionDataT);
			return mainWpPartitionDataT;
		}

		// Token: 0x0601B715 RID: 112405 RVA: 0x003E2578 File Offset: 0x003E0778
		public void UnPackTo(IMainWpPartitionDataT _o)
		{
			_o.SubWpData = new List<ISubWpDataT>();
			for (int i = 0; i < this.SubWpDataLength; i++)
			{
				_o.SubWpData.Add((this.SubWpData(i) != null) ? this.SubWpData(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601B716 RID: 112406 RVA: 0x003E25D8 File Offset: 0x003E07D8
		public static Offset<IMainWpPartitionData> Pack(FlatBufferBuilder builder, IMainWpPartitionDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMainWpPartitionData>);
			}
			VectorOffset subWpDataOffset = default(VectorOffset);
			if (_o.SubWpData != null)
			{
				Offset<ISubWpData>[] array = new Offset<ISubWpData>[_o.SubWpData.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ISubWpData.Pack(builder, _o.SubWpData[i]);
				}
				subWpDataOffset = IMainWpPartitionData.CreateSubWpDataVector(builder, array);
			}
			return IMainWpPartitionData.CreateIMainWpPartitionData(builder, subWpDataOffset);
		}

		// Token: 0x0400CD9C RID: 52636
		private Table __p;
	}
}
