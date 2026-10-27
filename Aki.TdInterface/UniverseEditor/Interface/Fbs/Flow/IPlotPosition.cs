using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Flow
{
	// Token: 0x02004748 RID: 18248
	public struct IPlotPosition : IFlatbufferObject
	{
		// Token: 0x170082EE RID: 33518
		// (get) Token: 0x0601C14F RID: 115023 RVA: 0x003FA923 File Offset: 0x003F8B23
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C150 RID: 115024 RVA: 0x003FA930 File Offset: 0x003F8B30
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C151 RID: 115025 RVA: 0x003FA938 File Offset: 0x003F8B38
		public static IPlotPosition GetRootAsIPlotPosition(ByteBuffer _bb)
		{
			return IPlotPosition.GetRootAsIPlotPosition(_bb, default(IPlotPosition));
		}

		// Token: 0x0601C152 RID: 115026 RVA: 0x003FA954 File Offset: 0x003F8B54
		public static IPlotPosition GetRootAsIPlotPosition(ByteBuffer _bb, IPlotPosition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C153 RID: 115027 RVA: 0x003FA971 File Offset: 0x003F8B71
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C154 RID: 115028 RVA: 0x003FA980 File Offset: 0x003F8B80
		public IPlotPosition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0601C155 RID: 115029 RVA: 0x003FA990 File Offset: 0x003F8B90
		public IPlotPosPlayFlow? PlayFlow(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IPlotPosPlayFlow?(default(IPlotPosPlayFlow).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170082EF RID: 33519
		// (get) Token: 0x0601C156 RID: 115030 RVA: 0x003FA9F0 File Offset: 0x003F8BF0
		public int PlayFlowLength
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

		// Token: 0x0601C157 RID: 115031 RVA: 0x003FAA1C File Offset: 0x003F8C1C
		public IPlotPosFlowState? FlowState(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IPlotPosFlowState?(default(IPlotPosFlowState).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170082F0 RID: 33520
		// (get) Token: 0x0601C158 RID: 115032 RVA: 0x003FAA7C File Offset: 0x003F8C7C
		public int FlowStateLength
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

		// Token: 0x0601C159 RID: 115033 RVA: 0x003FAAA7 File Offset: 0x003F8CA7
		public static Offset<IPlotPosition> CreateIPlotPosition(FlatBufferBuilder builder, VectorOffset PlayFlowOffset = default(VectorOffset), VectorOffset FlowStateOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IPlotPosition.AddFlowState(builder, FlowStateOffset);
			IPlotPosition.AddPlayFlow(builder, PlayFlowOffset);
			return IPlotPosition.EndIPlotPosition(builder);
		}

		// Token: 0x0601C15A RID: 115034 RVA: 0x003FAAC4 File Offset: 0x003F8CC4
		public static void StartIPlotPosition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601C15B RID: 115035 RVA: 0x003FAACD File Offset: 0x003F8CCD
		public static void AddPlayFlow(FlatBufferBuilder builder, VectorOffset playFlowOffset)
		{
			builder.AddOffset(0, playFlowOffset.Value, 0);
		}

		// Token: 0x0601C15C RID: 115036 RVA: 0x003FAAE0 File Offset: 0x003F8CE0
		public static VectorOffset CreatePlayFlowVector(FlatBufferBuilder builder, Offset<IPlotPosPlayFlow>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C15D RID: 115037 RVA: 0x003FAB20 File Offset: 0x003F8D20
		public static VectorOffset CreatePlayFlowVectorBlock(FlatBufferBuilder builder, Offset<IPlotPosPlayFlow>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IPlotPosPlayFlow>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C15E RID: 115038 RVA: 0x003FAB3A File Offset: 0x003F8D3A
		public static VectorOffset CreatePlayFlowVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IPlotPosPlayFlow>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IPlotPosPlayFlow>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C15F RID: 115039 RVA: 0x003FAB58 File Offset: 0x003F8D58
		public static VectorOffset CreatePlayFlowVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IPlotPosPlayFlow>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C160 RID: 115040 RVA: 0x003FAB71 File Offset: 0x003F8D71
		public static void StartPlayFlowVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601C161 RID: 115041 RVA: 0x003FAB7C File Offset: 0x003F8D7C
		public static void AddFlowState(FlatBufferBuilder builder, VectorOffset flowStateOffset)
		{
			builder.AddOffset(1, flowStateOffset.Value, 0);
		}

		// Token: 0x0601C162 RID: 115042 RVA: 0x003FAB8C File Offset: 0x003F8D8C
		public static VectorOffset CreateFlowStateVector(FlatBufferBuilder builder, Offset<IPlotPosFlowState>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C163 RID: 115043 RVA: 0x003FABCC File Offset: 0x003F8DCC
		public static VectorOffset CreateFlowStateVectorBlock(FlatBufferBuilder builder, Offset<IPlotPosFlowState>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IPlotPosFlowState>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C164 RID: 115044 RVA: 0x003FABE6 File Offset: 0x003F8DE6
		public static VectorOffset CreateFlowStateVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IPlotPosFlowState>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IPlotPosFlowState>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C165 RID: 115045 RVA: 0x003FAC04 File Offset: 0x003F8E04
		public static VectorOffset CreateFlowStateVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IPlotPosFlowState>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C166 RID: 115046 RVA: 0x003FAC1D File Offset: 0x003F8E1D
		public static void StartFlowStateVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601C167 RID: 115047 RVA: 0x003FAC28 File Offset: 0x003F8E28
		public static Offset<IPlotPosition> EndIPlotPosition(FlatBufferBuilder builder)
		{
			return new Offset<IPlotPosition>(builder.EndTable());
		}

		// Token: 0x0601C168 RID: 115048 RVA: 0x003FAC38 File Offset: 0x003F8E38
		public IPlotPositionT UnPack()
		{
			IPlotPositionT plotPositionT = new IPlotPositionT();
			this.UnPackTo(plotPositionT);
			return plotPositionT;
		}

		// Token: 0x0601C169 RID: 115049 RVA: 0x003FAC54 File Offset: 0x003F8E54
		public void UnPackTo(IPlotPositionT _o)
		{
			_o.PlayFlow = new List<IPlotPosPlayFlowT>();
			for (int i = 0; i < this.PlayFlowLength; i++)
			{
				_o.PlayFlow.Add((this.PlayFlow(i) != null) ? this.PlayFlow(i).Value.UnPack() : null);
			}
			_o.FlowState = new List<IPlotPosFlowStateT>();
			for (int j = 0; j < this.FlowStateLength; j++)
			{
				_o.FlowState.Add((this.FlowState(j) != null) ? this.FlowState(j).Value.UnPack() : null);
			}
		}

		// Token: 0x0601C16A RID: 115050 RVA: 0x003FAD08 File Offset: 0x003F8F08
		public static Offset<IPlotPosition> Pack(FlatBufferBuilder builder, IPlotPositionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlotPosition>);
			}
			VectorOffset playFlowOffset = default(VectorOffset);
			if (_o.PlayFlow != null)
			{
				Offset<IPlotPosPlayFlow>[] array = new Offset<IPlotPosPlayFlow>[_o.PlayFlow.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IPlotPosPlayFlow.Pack(builder, _o.PlayFlow[i]);
				}
				playFlowOffset = IPlotPosition.CreatePlayFlowVector(builder, array);
			}
			VectorOffset flowStateOffset = default(VectorOffset);
			if (_o.FlowState != null)
			{
				Offset<IPlotPosFlowState>[] array2 = new Offset<IPlotPosFlowState>[_o.FlowState.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IPlotPosFlowState.Pack(builder, _o.FlowState[j]);
				}
				flowStateOffset = IPlotPosition.CreateFlowStateVector(builder, array2);
			}
			return IPlotPosition.CreateIPlotPosition(builder, playFlowOffset, flowStateOffset);
		}

		// Token: 0x0400CA36 RID: 51766
		private Table __p;
	}
}
