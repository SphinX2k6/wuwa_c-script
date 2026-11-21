using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C55 RID: 19541
	public struct IRunningResetReviveInfo : IFlatbufferObject
	{
		// Token: 0x17008A9F RID: 35487
		// (get) Token: 0x0601DF91 RID: 122769 RVA: 0x00433C30 File Offset: 0x00431E30
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DF92 RID: 122770 RVA: 0x00433C3D File Offset: 0x00431E3D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DF93 RID: 122771 RVA: 0x00433C44 File Offset: 0x00431E44
		public static IRunningResetReviveInfo GetRootAsIRunningResetReviveInfo(ByteBuffer _bb)
		{
			return IRunningResetReviveInfo.GetRootAsIRunningResetReviveInfo(_bb, default(IRunningResetReviveInfo));
		}

		// Token: 0x0601DF94 RID: 122772 RVA: 0x00433C60 File Offset: 0x00431E60
		public static IRunningResetReviveInfo GetRootAsIRunningResetReviveInfo(ByteBuffer _bb, IRunningResetReviveInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DF95 RID: 122773 RVA: 0x00433C7D File Offset: 0x00431E7D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DF96 RID: 122774 RVA: 0x00433C8C File Offset: 0x00431E8C
		public IRunningResetReviveInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0601DF97 RID: 122775 RVA: 0x00433C9C File Offset: 0x00431E9C
		public IInstEntityData? ResetDatas(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IInstEntityData?(default(IInstEntityData).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008AA0 RID: 35488
		// (get) Token: 0x0601DF98 RID: 122776 RVA: 0x00433CFC File Offset: 0x00431EFC
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

		// Token: 0x0601DF99 RID: 122777 RVA: 0x00433D28 File Offset: 0x00431F28
		public IInstEntityData? ReviveDatas(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IInstEntityData?(default(IInstEntityData).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008AA1 RID: 35489
		// (get) Token: 0x0601DF9A RID: 122778 RVA: 0x00433D88 File Offset: 0x00431F88
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

		// Token: 0x17008AA2 RID: 35490
		// (get) Token: 0x0601DF9B RID: 122779 RVA: 0x00433DB4 File Offset: 0x00431FB4
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

		// Token: 0x0601DF9C RID: 122780 RVA: 0x00433DF0 File Offset: 0x00431FF0
		public static Offset<IRunningResetReviveInfo> CreateIRunningResetReviveInfo(FlatBufferBuilder builder, VectorOffset ResetDatasOffset = default(VectorOffset), VectorOffset ReviveDatasOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			IRunningResetReviveInfo.AddReviveDatas(builder, ReviveDatasOffset);
			IRunningResetReviveInfo.AddResetDatas(builder, ResetDatasOffset);
			IRunningResetReviveInfo.AddNullMask(builder, NullMask);
			return IRunningResetReviveInfo.EndIRunningResetReviveInfo(builder);
		}

		// Token: 0x0601DF9D RID: 122781 RVA: 0x00433E14 File Offset: 0x00432014
		public static void StartIRunningResetReviveInfo(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601DF9E RID: 122782 RVA: 0x00433E1D File Offset: 0x0043201D
		public static void AddResetDatas(FlatBufferBuilder builder, VectorOffset resetDatasOffset)
		{
			builder.AddOffset(0, resetDatasOffset.Value, 0);
		}

		// Token: 0x0601DF9F RID: 122783 RVA: 0x00433E30 File Offset: 0x00432030
		public static VectorOffset CreateResetDatasVector(FlatBufferBuilder builder, Offset<IInstEntityData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601DFA0 RID: 122784 RVA: 0x00433E70 File Offset: 0x00432070
		public static VectorOffset CreateResetDatasVectorBlock(FlatBufferBuilder builder, Offset<IInstEntityData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IInstEntityData>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601DFA1 RID: 122785 RVA: 0x00433E8A File Offset: 0x0043208A
		public static VectorOffset CreateResetDatasVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IInstEntityData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IInstEntityData>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601DFA2 RID: 122786 RVA: 0x00433EA8 File Offset: 0x004320A8
		public static VectorOffset CreateResetDatasVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IInstEntityData>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601DFA3 RID: 122787 RVA: 0x00433EC1 File Offset: 0x004320C1
		public static void StartResetDatasVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601DFA4 RID: 122788 RVA: 0x00433ECC File Offset: 0x004320CC
		public static void AddReviveDatas(FlatBufferBuilder builder, VectorOffset reviveDatasOffset)
		{
			builder.AddOffset(1, reviveDatasOffset.Value, 0);
		}

		// Token: 0x0601DFA5 RID: 122789 RVA: 0x00433EDC File Offset: 0x004320DC
		public static VectorOffset CreateReviveDatasVector(FlatBufferBuilder builder, Offset<IInstEntityData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601DFA6 RID: 122790 RVA: 0x00433F1C File Offset: 0x0043211C
		public static VectorOffset CreateReviveDatasVectorBlock(FlatBufferBuilder builder, Offset<IInstEntityData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IInstEntityData>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601DFA7 RID: 122791 RVA: 0x00433F36 File Offset: 0x00432136
		public static VectorOffset CreateReviveDatasVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IInstEntityData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IInstEntityData>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601DFA8 RID: 122792 RVA: 0x00433F54 File Offset: 0x00432154
		public static VectorOffset CreateReviveDatasVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IInstEntityData>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601DFA9 RID: 122793 RVA: 0x00433F6D File Offset: 0x0043216D
		public static void StartReviveDatasVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601DFAA RID: 122794 RVA: 0x00433F78 File Offset: 0x00432178
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0601DFAB RID: 122795 RVA: 0x00433F83 File Offset: 0x00432183
		public static Offset<IRunningResetReviveInfo> EndIRunningResetReviveInfo(FlatBufferBuilder builder)
		{
			return new Offset<IRunningResetReviveInfo>(builder.EndTable());
		}

		// Token: 0x0601DFAC RID: 122796 RVA: 0x00433F90 File Offset: 0x00432190
		public IRunningResetReviveInfoT UnPack()
		{
			IRunningResetReviveInfoT runningResetReviveInfoT = new IRunningResetReviveInfoT();
			this.UnPackTo(runningResetReviveInfoT);
			return runningResetReviveInfoT;
		}

		// Token: 0x0601DFAD RID: 122797 RVA: 0x00433FAC File Offset: 0x004321AC
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

		// Token: 0x0601DFAE RID: 122798 RVA: 0x0043406C File Offset: 0x0043226C
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

		// Token: 0x0400D6BF RID: 54975
		private Table __p;
	}
}
