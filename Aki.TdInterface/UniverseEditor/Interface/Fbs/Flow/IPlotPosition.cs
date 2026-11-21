using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Flow
{
	// Token: 0x02004BB0 RID: 19376
	public struct IPlotPosition : IFlatbufferObject
	{
		// Token: 0x1700892F RID: 35119
		// (get) Token: 0x0601D924 RID: 121124 RVA: 0x00426BBF File Offset: 0x00424DBF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D925 RID: 121125 RVA: 0x00426BCC File Offset: 0x00424DCC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D926 RID: 121126 RVA: 0x00426BD4 File Offset: 0x00424DD4
		public static IPlotPosition GetRootAsIPlotPosition(ByteBuffer _bb)
		{
			return IPlotPosition.GetRootAsIPlotPosition(_bb, default(IPlotPosition));
		}

		// Token: 0x0601D927 RID: 121127 RVA: 0x00426BF0 File Offset: 0x00424DF0
		public static IPlotPosition GetRootAsIPlotPosition(ByteBuffer _bb, IPlotPosition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D928 RID: 121128 RVA: 0x00426C0D File Offset: 0x00424E0D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D929 RID: 121129 RVA: 0x00426C1C File Offset: 0x00424E1C
		public IPlotPosition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0601D92A RID: 121130 RVA: 0x00426C2C File Offset: 0x00424E2C
		public IPlotPosPlayFlow? PlayFlow(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IPlotPosPlayFlow?(default(IPlotPosPlayFlow).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008930 RID: 35120
		// (get) Token: 0x0601D92B RID: 121131 RVA: 0x00426C8C File Offset: 0x00424E8C
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

		// Token: 0x0601D92C RID: 121132 RVA: 0x00426CB8 File Offset: 0x00424EB8
		public IPlotPosFlowState? FlowState(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IPlotPosFlowState?(default(IPlotPosFlowState).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008931 RID: 35121
		// (get) Token: 0x0601D92D RID: 121133 RVA: 0x00426D18 File Offset: 0x00424F18
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

		// Token: 0x0601D92E RID: 121134 RVA: 0x00426D43 File Offset: 0x00424F43
		public static Offset<IPlotPosition> CreateIPlotPosition(FlatBufferBuilder builder, VectorOffset PlayFlowOffset = default(VectorOffset), VectorOffset FlowStateOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IPlotPosition.AddFlowState(builder, FlowStateOffset);
			IPlotPosition.AddPlayFlow(builder, PlayFlowOffset);
			return IPlotPosition.EndIPlotPosition(builder);
		}

		// Token: 0x0601D92F RID: 121135 RVA: 0x00426D60 File Offset: 0x00424F60
		public static void StartIPlotPosition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601D930 RID: 121136 RVA: 0x00426D69 File Offset: 0x00424F69
		public static void AddPlayFlow(FlatBufferBuilder builder, VectorOffset playFlowOffset)
		{
			builder.AddOffset(0, playFlowOffset.Value, 0);
		}

		// Token: 0x0601D931 RID: 121137 RVA: 0x00426D7C File Offset: 0x00424F7C
		public static VectorOffset CreatePlayFlowVector(FlatBufferBuilder builder, Offset<IPlotPosPlayFlow>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601D932 RID: 121138 RVA: 0x00426DBC File Offset: 0x00424FBC
		public static VectorOffset CreatePlayFlowVectorBlock(FlatBufferBuilder builder, Offset<IPlotPosPlayFlow>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IPlotPosPlayFlow>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D933 RID: 121139 RVA: 0x00426DD6 File Offset: 0x00424FD6
		public static VectorOffset CreatePlayFlowVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IPlotPosPlayFlow>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IPlotPosPlayFlow>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D934 RID: 121140 RVA: 0x00426DF4 File Offset: 0x00424FF4
		public static VectorOffset CreatePlayFlowVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IPlotPosPlayFlow>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601D935 RID: 121141 RVA: 0x00426E0D File Offset: 0x0042500D
		public static void StartPlayFlowVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601D936 RID: 121142 RVA: 0x00426E18 File Offset: 0x00425018
		public static void AddFlowState(FlatBufferBuilder builder, VectorOffset flowStateOffset)
		{
			builder.AddOffset(1, flowStateOffset.Value, 0);
		}

		// Token: 0x0601D937 RID: 121143 RVA: 0x00426E28 File Offset: 0x00425028
		public static VectorOffset CreateFlowStateVector(FlatBufferBuilder builder, Offset<IPlotPosFlowState>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601D938 RID: 121144 RVA: 0x00426E68 File Offset: 0x00425068
		public static VectorOffset CreateFlowStateVectorBlock(FlatBufferBuilder builder, Offset<IPlotPosFlowState>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IPlotPosFlowState>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D939 RID: 121145 RVA: 0x00426E82 File Offset: 0x00425082
		public static VectorOffset CreateFlowStateVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IPlotPosFlowState>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IPlotPosFlowState>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D93A RID: 121146 RVA: 0x00426EA0 File Offset: 0x004250A0
		public static VectorOffset CreateFlowStateVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IPlotPosFlowState>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601D93B RID: 121147 RVA: 0x00426EB9 File Offset: 0x004250B9
		public static void StartFlowStateVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601D93C RID: 121148 RVA: 0x00426EC4 File Offset: 0x004250C4
		public static Offset<IPlotPosition> EndIPlotPosition(FlatBufferBuilder builder)
		{
			return new Offset<IPlotPosition>(builder.EndTable());
		}

		// Token: 0x0601D93D RID: 121149 RVA: 0x00426ED4 File Offset: 0x004250D4
		public IPlotPositionT UnPack()
		{
			IPlotPositionT plotPositionT = new IPlotPositionT();
			this.UnPackTo(plotPositionT);
			return plotPositionT;
		}

		// Token: 0x0601D93E RID: 121150 RVA: 0x00426EF0 File Offset: 0x004250F0
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

		// Token: 0x0601D93F RID: 121151 RVA: 0x00426FA4 File Offset: 0x004251A4
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

		// Token: 0x0400D465 RID: 54373
		private Table __p;
	}
}
