using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Level
{
	// Token: 0x02004412 RID: 17426
	public struct IMainWpPartitionData : IFlatbufferObject
	{
		// Token: 0x17007AF1 RID: 31473
		// (get) Token: 0x06019F32 RID: 106290 RVA: 0x003B617B File Offset: 0x003B437B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019F33 RID: 106291 RVA: 0x003B6188 File Offset: 0x003B4388
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019F34 RID: 106292 RVA: 0x003B6190 File Offset: 0x003B4390
		public static IMainWpPartitionData GetRootAsIMainWpPartitionData(ByteBuffer _bb)
		{
			return IMainWpPartitionData.GetRootAsIMainWpPartitionData(_bb, default(IMainWpPartitionData));
		}

		// Token: 0x06019F35 RID: 106293 RVA: 0x003B61AC File Offset: 0x003B43AC
		public static IMainWpPartitionData GetRootAsIMainWpPartitionData(ByteBuffer _bb, IMainWpPartitionData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019F36 RID: 106294 RVA: 0x003B61C9 File Offset: 0x003B43C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019F37 RID: 106295 RVA: 0x003B61D8 File Offset: 0x003B43D8
		public IMainWpPartitionData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06019F38 RID: 106296 RVA: 0x003B61E8 File Offset: 0x003B43E8
		public ISubWpData? SubWpData(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new ISubWpData?(default(ISubWpData).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007AF2 RID: 31474
		// (get) Token: 0x06019F39 RID: 106297 RVA: 0x003B6248 File Offset: 0x003B4448
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

		// Token: 0x06019F3A RID: 106298 RVA: 0x003B6273 File Offset: 0x003B4473
		public static Offset<IMainWpPartitionData> CreateIMainWpPartitionData(FlatBufferBuilder builder, VectorOffset SubWpDataOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IMainWpPartitionData.AddSubWpData(builder, SubWpDataOffset);
			return IMainWpPartitionData.EndIMainWpPartitionData(builder);
		}

		// Token: 0x06019F3B RID: 106299 RVA: 0x003B6289 File Offset: 0x003B4489
		public static void StartIMainWpPartitionData(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06019F3C RID: 106300 RVA: 0x003B6292 File Offset: 0x003B4492
		public static void AddSubWpData(FlatBufferBuilder builder, VectorOffset subWpDataOffset)
		{
			builder.AddOffset(0, subWpDataOffset.Value, 0);
		}

		// Token: 0x06019F3D RID: 106301 RVA: 0x003B62A4 File Offset: 0x003B44A4
		public static VectorOffset CreateSubWpDataVector(FlatBufferBuilder builder, Offset<ISubWpData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06019F3E RID: 106302 RVA: 0x003B62E4 File Offset: 0x003B44E4
		public static VectorOffset CreateSubWpDataVectorBlock(FlatBufferBuilder builder, Offset<ISubWpData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISubWpData>>(data);
			return builder.EndVector();
		}

		// Token: 0x06019F3F RID: 106303 RVA: 0x003B62FE File Offset: 0x003B44FE
		public static VectorOffset CreateSubWpDataVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISubWpData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISubWpData>>(data);
			return builder.EndVector();
		}

		// Token: 0x06019F40 RID: 106304 RVA: 0x003B631C File Offset: 0x003B451C
		public static VectorOffset CreateSubWpDataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISubWpData>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06019F41 RID: 106305 RVA: 0x003B6335 File Offset: 0x003B4535
		public static void StartSubWpDataVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06019F42 RID: 106306 RVA: 0x003B6340 File Offset: 0x003B4540
		public static Offset<IMainWpPartitionData> EndIMainWpPartitionData(FlatBufferBuilder builder)
		{
			return new Offset<IMainWpPartitionData>(builder.EndTable());
		}

		// Token: 0x06019F43 RID: 106307 RVA: 0x003B6350 File Offset: 0x003B4550
		public IMainWpPartitionDataT UnPack()
		{
			IMainWpPartitionDataT mainWpPartitionDataT = new IMainWpPartitionDataT();
			this.UnPackTo(mainWpPartitionDataT);
			return mainWpPartitionDataT;
		}

		// Token: 0x06019F44 RID: 106308 RVA: 0x003B636C File Offset: 0x003B456C
		public void UnPackTo(IMainWpPartitionDataT _o)
		{
			_o.SubWpData = new List<ISubWpDataT>();
			for (int i = 0; i < this.SubWpDataLength; i++)
			{
				_o.SubWpData.Add((this.SubWpData(i) != null) ? this.SubWpData(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06019F45 RID: 106309 RVA: 0x003B63CC File Offset: 0x003B45CC
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

		// Token: 0x0400C36F RID: 50031
		private Table __p;
	}
}
