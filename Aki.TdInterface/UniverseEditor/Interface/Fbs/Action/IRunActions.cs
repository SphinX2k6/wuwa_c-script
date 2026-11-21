using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007696 RID: 30358
	public struct IRunActions : IFlatbufferObject
	{
		// Token: 0x1700DEBC RID: 57020
		// (get) Token: 0x06035401 RID: 218113 RVA: 0x007252E6 File Offset: 0x007234E6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035402 RID: 218114 RVA: 0x007252F3 File Offset: 0x007234F3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035403 RID: 218115 RVA: 0x007252FC File Offset: 0x007234FC
		public static IRunActions GetRootAsIRunActions(ByteBuffer _bb)
		{
			return IRunActions.GetRootAsIRunActions(_bb, default(IRunActions));
		}

		// Token: 0x06035404 RID: 218116 RVA: 0x00725318 File Offset: 0x00723518
		public static IRunActions GetRootAsIRunActions(ByteBuffer _bb, IRunActions obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035405 RID: 218117 RVA: 0x00725335 File Offset: 0x00723535
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035406 RID: 218118 RVA: 0x00725344 File Offset: 0x00723544
		public IRunActions __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06035407 RID: 218119 RVA: 0x00725354 File Offset: 0x00723554
		public IActionInfo? ActionList(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700DEBD RID: 57021
		// (get) Token: 0x06035408 RID: 218120 RVA: 0x007253B4 File Offset: 0x007235B4
		public int ActionListLength
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

		// Token: 0x06035409 RID: 218121 RVA: 0x007253DF File Offset: 0x007235DF
		public static Offset<IRunActions> CreateIRunActions(FlatBufferBuilder builder, VectorOffset ActionListOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IRunActions.AddActionList(builder, ActionListOffset);
			return IRunActions.EndIRunActions(builder);
		}

		// Token: 0x0603540A RID: 218122 RVA: 0x007253F5 File Offset: 0x007235F5
		public static void StartIRunActions(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603540B RID: 218123 RVA: 0x007253FE File Offset: 0x007235FE
		public static void AddActionList(FlatBufferBuilder builder, VectorOffset actionListOffset)
		{
			builder.AddOffset(0, actionListOffset.Value, 0);
		}

		// Token: 0x0603540C RID: 218124 RVA: 0x00725410 File Offset: 0x00723610
		public static VectorOffset CreateActionListVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0603540D RID: 218125 RVA: 0x00725450 File Offset: 0x00723650
		public static VectorOffset CreateActionListVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0603540E RID: 218126 RVA: 0x0072546A File Offset: 0x0072366A
		public static VectorOffset CreateActionListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0603540F RID: 218127 RVA: 0x00725488 File Offset: 0x00723688
		public static VectorOffset CreateActionListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06035410 RID: 218128 RVA: 0x007254A1 File Offset: 0x007236A1
		public static void StartActionListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06035411 RID: 218129 RVA: 0x007254AC File Offset: 0x007236AC
		public static Offset<IRunActions> EndIRunActions(FlatBufferBuilder builder)
		{
			return new Offset<IRunActions>(builder.EndTable());
		}

		// Token: 0x06035412 RID: 218130 RVA: 0x007254BC File Offset: 0x007236BC
		public IRunActionsT UnPack()
		{
			IRunActionsT runActionsT = new IRunActionsT();
			this.UnPackTo(runActionsT);
			return runActionsT;
		}

		// Token: 0x06035413 RID: 218131 RVA: 0x007254D8 File Offset: 0x007236D8
		public void UnPackTo(IRunActionsT _o)
		{
			_o.ActionList = new List<IActionInfoT>();
			for (int i = 0; i < this.ActionListLength; i++)
			{
				_o.ActionList.Add((this.ActionList(i) != null) ? this.ActionList(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06035414 RID: 218132 RVA: 0x00725538 File Offset: 0x00723738
		public static Offset<IRunActions> Pack(FlatBufferBuilder builder, IRunActionsT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRunActions>);
			}
			VectorOffset actionListOffset = default(VectorOffset);
			if (_o.ActionList != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.ActionList.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.ActionList[i]);
				}
				actionListOffset = IRunActions.CreateActionListVector(builder, array);
			}
			return IRunActions.CreateIRunActions(builder, actionListOffset);
		}

		// Token: 0x04012882 RID: 75906
		private Table __p;
	}
}
