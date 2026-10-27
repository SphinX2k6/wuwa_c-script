using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F14 RID: 16148
	public struct ILogicProgramSpecialProcess : IFlatbufferObject
	{
		// Token: 0x17007052 RID: 28754
		// (get) Token: 0x06016EC2 RID: 93890 RVA: 0x0034EF2D File Offset: 0x0034D12D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016EC3 RID: 93891 RVA: 0x0034EF3A File Offset: 0x0034D13A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016EC4 RID: 93892 RVA: 0x0034EF44 File Offset: 0x0034D144
		public static ILogicProgramSpecialProcess GetRootAsILogicProgramSpecialProcess(ByteBuffer _bb)
		{
			return ILogicProgramSpecialProcess.GetRootAsILogicProgramSpecialProcess(_bb, default(ILogicProgramSpecialProcess));
		}

		// Token: 0x06016EC5 RID: 93893 RVA: 0x0034EF60 File Offset: 0x0034D160
		public static ILogicProgramSpecialProcess GetRootAsILogicProgramSpecialProcess(ByteBuffer _bb, ILogicProgramSpecialProcess obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016EC6 RID: 93894 RVA: 0x0034EF7D File Offset: 0x0034D17D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016EC7 RID: 93895 RVA: 0x0034EF8C File Offset: 0x0034D18C
		public ILogicProgramSpecialProcess __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06016EC8 RID: 93896 RVA: 0x0034EF9C File Offset: 0x0034D19C
		public IDisableUro? SpecialProcessList(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IDisableUro?(default(IDisableUro).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007053 RID: 28755
		// (get) Token: 0x06016EC9 RID: 93897 RVA: 0x0034EFFC File Offset: 0x0034D1FC
		public int SpecialProcessListLength
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

		// Token: 0x06016ECA RID: 93898 RVA: 0x0034F027 File Offset: 0x0034D227
		public static Offset<ILogicProgramSpecialProcess> CreateILogicProgramSpecialProcess(FlatBufferBuilder builder, VectorOffset SpecialProcessListOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			ILogicProgramSpecialProcess.AddSpecialProcessList(builder, SpecialProcessListOffset);
			return ILogicProgramSpecialProcess.EndILogicProgramSpecialProcess(builder);
		}

		// Token: 0x06016ECB RID: 93899 RVA: 0x0034F03D File Offset: 0x0034D23D
		public static void StartILogicProgramSpecialProcess(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06016ECC RID: 93900 RVA: 0x0034F046 File Offset: 0x0034D246
		public static void AddSpecialProcessList(FlatBufferBuilder builder, VectorOffset specialProcessListOffset)
		{
			builder.AddOffset(0, specialProcessListOffset.Value, 0);
		}

		// Token: 0x06016ECD RID: 93901 RVA: 0x0034F058 File Offset: 0x0034D258
		public static VectorOffset CreateSpecialProcessListVector(FlatBufferBuilder builder, Offset<IDisableUro>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06016ECE RID: 93902 RVA: 0x0034F098 File Offset: 0x0034D298
		public static VectorOffset CreateSpecialProcessListVectorBlock(FlatBufferBuilder builder, Offset<IDisableUro>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IDisableUro>>(data);
			return builder.EndVector();
		}

		// Token: 0x06016ECF RID: 93903 RVA: 0x0034F0B2 File Offset: 0x0034D2B2
		public static VectorOffset CreateSpecialProcessListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IDisableUro>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IDisableUro>>(data);
			return builder.EndVector();
		}

		// Token: 0x06016ED0 RID: 93904 RVA: 0x0034F0D0 File Offset: 0x0034D2D0
		public static VectorOffset CreateSpecialProcessListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IDisableUro>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06016ED1 RID: 93905 RVA: 0x0034F0E9 File Offset: 0x0034D2E9
		public static void StartSpecialProcessListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06016ED2 RID: 93906 RVA: 0x0034F0F4 File Offset: 0x0034D2F4
		public static Offset<ILogicProgramSpecialProcess> EndILogicProgramSpecialProcess(FlatBufferBuilder builder)
		{
			return new Offset<ILogicProgramSpecialProcess>(builder.EndTable());
		}

		// Token: 0x06016ED3 RID: 93907 RVA: 0x0034F104 File Offset: 0x0034D304
		public ILogicProgramSpecialProcessT UnPack()
		{
			ILogicProgramSpecialProcessT logicProgramSpecialProcessT = new ILogicProgramSpecialProcessT();
			this.UnPackTo(logicProgramSpecialProcessT);
			return logicProgramSpecialProcessT;
		}

		// Token: 0x06016ED4 RID: 93908 RVA: 0x0034F120 File Offset: 0x0034D320
		public void UnPackTo(ILogicProgramSpecialProcessT _o)
		{
			_o.SpecialProcessList = new List<IDisableUroT>();
			for (int i = 0; i < this.SpecialProcessListLength; i++)
			{
				_o.SpecialProcessList.Add((this.SpecialProcessList(i) != null) ? this.SpecialProcessList(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06016ED5 RID: 93909 RVA: 0x0034F180 File Offset: 0x0034D380
		public static Offset<ILogicProgramSpecialProcess> Pack(FlatBufferBuilder builder, ILogicProgramSpecialProcessT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILogicProgramSpecialProcess>);
			}
			VectorOffset specialProcessListOffset = default(VectorOffset);
			if (_o.SpecialProcessList != null)
			{
				Offset<IDisableUro>[] array = new Offset<IDisableUro>[_o.SpecialProcessList.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IDisableUro.Pack(builder, _o.SpecialProcessList[i]);
				}
				specialProcessListOffset = ILogicProgramSpecialProcess.CreateSpecialProcessListVector(builder, array);
			}
			return ILogicProgramSpecialProcess.CreateILogicProgramSpecialProcess(builder, specialProcessListOffset);
		}

		// Token: 0x0400B91A RID: 47386
		private Table __p;
	}
}
