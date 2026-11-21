using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004352 RID: 17234
	public struct ILogicProgramSpecialProcess : IFlatbufferObject
	{
		// Token: 0x17007641 RID: 30273
		// (get) Token: 0x0601851A RID: 99610 RVA: 0x00378155 File Offset: 0x00376355
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601851B RID: 99611 RVA: 0x00378162 File Offset: 0x00376362
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601851C RID: 99612 RVA: 0x0037816C File Offset: 0x0037636C
		public static ILogicProgramSpecialProcess GetRootAsILogicProgramSpecialProcess(ByteBuffer _bb)
		{
			return ILogicProgramSpecialProcess.GetRootAsILogicProgramSpecialProcess(_bb, default(ILogicProgramSpecialProcess));
		}

		// Token: 0x0601851D RID: 99613 RVA: 0x00378188 File Offset: 0x00376388
		public static ILogicProgramSpecialProcess GetRootAsILogicProgramSpecialProcess(ByteBuffer _bb, ILogicProgramSpecialProcess obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601851E RID: 99614 RVA: 0x003781A5 File Offset: 0x003763A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601851F RID: 99615 RVA: 0x003781B4 File Offset: 0x003763B4
		public ILogicProgramSpecialProcess __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06018520 RID: 99616 RVA: 0x003781C4 File Offset: 0x003763C4
		public IDisableUro? SpecialProcessList(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IDisableUro?(default(IDisableUro).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007642 RID: 30274
		// (get) Token: 0x06018521 RID: 99617 RVA: 0x00378224 File Offset: 0x00376424
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

		// Token: 0x06018522 RID: 99618 RVA: 0x0037824F File Offset: 0x0037644F
		public static Offset<ILogicProgramSpecialProcess> CreateILogicProgramSpecialProcess(FlatBufferBuilder builder, VectorOffset SpecialProcessListOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			ILogicProgramSpecialProcess.AddSpecialProcessList(builder, SpecialProcessListOffset);
			return ILogicProgramSpecialProcess.EndILogicProgramSpecialProcess(builder);
		}

		// Token: 0x06018523 RID: 99619 RVA: 0x00378265 File Offset: 0x00376465
		public static void StartILogicProgramSpecialProcess(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06018524 RID: 99620 RVA: 0x0037826E File Offset: 0x0037646E
		public static void AddSpecialProcessList(FlatBufferBuilder builder, VectorOffset specialProcessListOffset)
		{
			builder.AddOffset(0, specialProcessListOffset.Value, 0);
		}

		// Token: 0x06018525 RID: 99621 RVA: 0x00378280 File Offset: 0x00376480
		public static VectorOffset CreateSpecialProcessListVector(FlatBufferBuilder builder, Offset<IDisableUro>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06018526 RID: 99622 RVA: 0x003782C0 File Offset: 0x003764C0
		public static VectorOffset CreateSpecialProcessListVectorBlock(FlatBufferBuilder builder, Offset<IDisableUro>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IDisableUro>>(data);
			return builder.EndVector();
		}

		// Token: 0x06018527 RID: 99623 RVA: 0x003782DA File Offset: 0x003764DA
		public static VectorOffset CreateSpecialProcessListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IDisableUro>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IDisableUro>>(data);
			return builder.EndVector();
		}

		// Token: 0x06018528 RID: 99624 RVA: 0x003782F8 File Offset: 0x003764F8
		public static VectorOffset CreateSpecialProcessListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IDisableUro>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06018529 RID: 99625 RVA: 0x00378311 File Offset: 0x00376511
		public static void StartSpecialProcessListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601852A RID: 99626 RVA: 0x0037831C File Offset: 0x0037651C
		public static Offset<ILogicProgramSpecialProcess> EndILogicProgramSpecialProcess(FlatBufferBuilder builder)
		{
			return new Offset<ILogicProgramSpecialProcess>(builder.EndTable());
		}

		// Token: 0x0601852B RID: 99627 RVA: 0x0037832C File Offset: 0x0037652C
		public ILogicProgramSpecialProcessT UnPack()
		{
			ILogicProgramSpecialProcessT logicProgramSpecialProcessT = new ILogicProgramSpecialProcessT();
			this.UnPackTo(logicProgramSpecialProcessT);
			return logicProgramSpecialProcessT;
		}

		// Token: 0x0601852C RID: 99628 RVA: 0x00378348 File Offset: 0x00376548
		public void UnPackTo(ILogicProgramSpecialProcessT _o)
		{
			_o.SpecialProcessList = new List<IDisableUroT>();
			for (int i = 0; i < this.SpecialProcessListLength; i++)
			{
				_o.SpecialProcessList.Add((this.SpecialProcessList(i) != null) ? this.SpecialProcessList(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601852D RID: 99629 RVA: 0x003783A8 File Offset: 0x003765A8
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

		// Token: 0x0400C2F7 RID: 49911
		private Table __p;
	}
}
