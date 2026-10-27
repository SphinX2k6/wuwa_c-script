using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047ED RID: 18413
	public struct IRunningResetReviveInfo : IFlatbufferObject
	{
		// Token: 0x17008454 RID: 33876
		// (get) Token: 0x0601C794 RID: 116628 RVA: 0x004072E0 File Offset: 0x004054E0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C795 RID: 116629 RVA: 0x004072ED File Offset: 0x004054ED
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C796 RID: 116630 RVA: 0x004072F4 File Offset: 0x004054F4
		public static IRunningResetReviveInfo GetRootAsIRunningResetReviveInfo(ByteBuffer _bb)
		{
			return IRunningResetReviveInfo.GetRootAsIRunningResetReviveInfo(_bb, default(IRunningResetReviveInfo));
		}

		// Token: 0x0601C797 RID: 116631 RVA: 0x00407310 File Offset: 0x00405510
		public static IRunningResetReviveInfo GetRootAsIRunningResetReviveInfo(ByteBuffer _bb, IRunningResetReviveInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C798 RID: 116632 RVA: 0x0040732D File Offset: 0x0040552D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C799 RID: 116633 RVA: 0x0040733C File Offset: 0x0040553C
		public IRunningResetReviveInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0601C79A RID: 116634 RVA: 0x0040734C File Offset: 0x0040554C
		public IInstEntityData? ResetDatas(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IInstEntityData?(default(IInstEntityData).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008455 RID: 33877
		// (get) Token: 0x0601C79B RID: 116635 RVA: 0x004073AC File Offset: 0x004055AC
		public int ResetDatasLength
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

		// Token: 0x0601C79C RID: 116636 RVA: 0x004073D8 File Offset: 0x004055D8
		public IInstEntityData? ReviveDatas(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IInstEntityData?(default(IInstEntityData).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008456 RID: 33878
		// (get) Token: 0x0601C79D RID: 116637 RVA: 0x00407438 File Offset: 0x00405638
		public int ReviveDatasLength
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

		// Token: 0x17008457 RID: 33879
		// (get) Token: 0x0601C79E RID: 116638 RVA: 0x00407464 File Offset: 0x00405664
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601C79F RID: 116639 RVA: 0x004074A0 File Offset: 0x004056A0
		public static Offset<IRunningResetReviveInfo> CreateIRunningResetReviveInfo(FlatBufferBuilder builder, VectorOffset ResetDatasOffset = default(VectorOffset), VectorOffset ReviveDatasOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			IRunningResetReviveInfo.AddReviveDatas(builder, ReviveDatasOffset);
			IRunningResetReviveInfo.AddResetDatas(builder, ResetDatasOffset);
			IRunningResetReviveInfo.AddNullMask(builder, NullMask);
			return IRunningResetReviveInfo.EndIRunningResetReviveInfo(builder);
		}

		// Token: 0x0601C7A0 RID: 116640 RVA: 0x004074C4 File Offset: 0x004056C4
		public static void StartIRunningResetReviveInfo(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601C7A1 RID: 116641 RVA: 0x004074CD File Offset: 0x004056CD
		public static void AddResetDatas(FlatBufferBuilder builder, VectorOffset resetDatasOffset)
		{
			builder.AddOffset(0, resetDatasOffset.Value, 0);
		}

		// Token: 0x0601C7A2 RID: 116642 RVA: 0x004074E0 File Offset: 0x004056E0
		public static VectorOffset CreateResetDatasVector(FlatBufferBuilder builder, Offset<IInstEntityData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C7A3 RID: 116643 RVA: 0x00407520 File Offset: 0x00405720
		public static VectorOffset CreateResetDatasVectorBlock(FlatBufferBuilder builder, Offset<IInstEntityData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IInstEntityData>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C7A4 RID: 116644 RVA: 0x0040753A File Offset: 0x0040573A
		public static VectorOffset CreateResetDatasVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IInstEntityData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IInstEntityData>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C7A5 RID: 116645 RVA: 0x00407558 File Offset: 0x00405758
		public static VectorOffset CreateResetDatasVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IInstEntityData>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C7A6 RID: 116646 RVA: 0x00407571 File Offset: 0x00405771
		public static void StartResetDatasVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601C7A7 RID: 116647 RVA: 0x0040757C File Offset: 0x0040577C
		public static void AddReviveDatas(FlatBufferBuilder builder, VectorOffset reviveDatasOffset)
		{
			builder.AddOffset(1, reviveDatasOffset.Value, 0);
		}

		// Token: 0x0601C7A8 RID: 116648 RVA: 0x0040758C File Offset: 0x0040578C
		public static VectorOffset CreateReviveDatasVector(FlatBufferBuilder builder, Offset<IInstEntityData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C7A9 RID: 116649 RVA: 0x004075CC File Offset: 0x004057CC
		public static VectorOffset CreateReviveDatasVectorBlock(FlatBufferBuilder builder, Offset<IInstEntityData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IInstEntityData>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C7AA RID: 116650 RVA: 0x004075E6 File Offset: 0x004057E6
		public static VectorOffset CreateReviveDatasVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IInstEntityData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IInstEntityData>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C7AB RID: 116651 RVA: 0x00407604 File Offset: 0x00405804
		public static VectorOffset CreateReviveDatasVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IInstEntityData>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C7AC RID: 116652 RVA: 0x0040761D File Offset: 0x0040581D
		public static void StartReviveDatasVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601C7AD RID: 116653 RVA: 0x00407628 File Offset: 0x00405828
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0601C7AE RID: 116654 RVA: 0x00407633 File Offset: 0x00405833
		public static Offset<IRunningResetReviveInfo> EndIRunningResetReviveInfo(FlatBufferBuilder builder)
		{
			return new Offset<IRunningResetReviveInfo>(builder.EndTable());
		}

		// Token: 0x0601C7AF RID: 116655 RVA: 0x00407640 File Offset: 0x00405840
		public IRunningResetReviveInfoT UnPack()
		{
			IRunningResetReviveInfoT runningResetReviveInfoT = new IRunningResetReviveInfoT();
			this.UnPackTo(runningResetReviveInfoT);
			return runningResetReviveInfoT;
		}

		// Token: 0x0601C7B0 RID: 116656 RVA: 0x0040765C File Offset: 0x0040585C
		public void UnPackTo(IRunningResetReviveInfoT _o)
		{
			_o.ResetDatas = new List<IInstEntityDataT>();
			for (int i = 0; i < this.ResetDatasLength; i++)
			{
				_o.ResetDatas.Add((this.ResetDatas(i) != null) ? this.ResetDatas(i).Value.UnPack() : null);
			}
			_o.ReviveDatas = new List<IInstEntityDataT>();
			for (int j = 0; j < this.ReviveDatasLength; j++)
			{
				_o.ReviveDatas.Add((this.ReviveDatas(j) != null) ? this.ReviveDatas(j).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601C7B1 RID: 116657 RVA: 0x0040771C File Offset: 0x0040591C
		public static Offset<IRunningResetReviveInfo> Pack(FlatBufferBuilder builder, IRunningResetReviveInfoT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRunningResetReviveInfo>);
			}
			VectorOffset resetDatasOffset = default(VectorOffset);
			if (_o.ResetDatas != null)
			{
				Offset<IInstEntityData>[] array = new Offset<IInstEntityData>[_o.ResetDatas.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IInstEntityData.Pack(builder, _o.ResetDatas[i]);
				}
				resetDatasOffset = IRunningResetReviveInfo.CreateResetDatasVector(builder, array);
			}
			VectorOffset reviveDatasOffset = default(VectorOffset);
			if (_o.ReviveDatas != null)
			{
				Offset<IInstEntityData>[] array2 = new Offset<IInstEntityData>[_o.ReviveDatas.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IInstEntityData.Pack(builder, _o.ReviveDatas[j]);
				}
				reviveDatasOffset = IRunningResetReviveInfo.CreateReviveDatasVector(builder, array2);
			}
			return IRunningResetReviveInfo.CreateIRunningResetReviveInfo(builder, resetDatasOffset, reviveDatasOffset, _o.NullMask);
		}

		// Token: 0x0400CC84 RID: 52356
		private Table __p;
	}
}
