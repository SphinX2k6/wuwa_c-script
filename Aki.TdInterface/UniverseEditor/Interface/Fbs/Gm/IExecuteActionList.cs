using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004645 RID: 17989
	public struct IExecuteActionList : IFlatbufferObject
	{
		// Token: 0x17007FA1 RID: 32673
		// (get) Token: 0x0601B3F3 RID: 111603 RVA: 0x003E0A21 File Offset: 0x003DEC21
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B3F4 RID: 111604 RVA: 0x003E0A2E File Offset: 0x003DEC2E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B3F5 RID: 111605 RVA: 0x003E0A38 File Offset: 0x003DEC38
		public static IExecuteActionList GetRootAsIExecuteActionList(ByteBuffer _bb)
		{
			return IExecuteActionList.GetRootAsIExecuteActionList(_bb, default(IExecuteActionList));
		}

		// Token: 0x0601B3F6 RID: 111606 RVA: 0x003E0A54 File Offset: 0x003DEC54
		public static IExecuteActionList GetRootAsIExecuteActionList(ByteBuffer _bb, IExecuteActionList obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B3F7 RID: 111607 RVA: 0x003E0A71 File Offset: 0x003DEC71
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B3F8 RID: 111608 RVA: 0x003E0A80 File Offset: 0x003DEC80
		public IExecuteActionList __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007FA2 RID: 32674
		// (get) Token: 0x0601B3F9 RID: 111609 RVA: 0x003E0A90 File Offset: 0x003DEC90
		public EGmCommand Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGmCommand.SkipToLevelPlayNode;
				}
				return (EGmCommand)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601B3FA RID: 111610 RVA: 0x003E0ACC File Offset: 0x003DECCC
		public IActionInfo? ActionList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007FA3 RID: 32675
		// (get) Token: 0x0601B3FB RID: 111611 RVA: 0x003E0B2C File Offset: 0x003DED2C
		public int ActionListLength
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

		// Token: 0x0601B3FC RID: 111612 RVA: 0x003E0B57 File Offset: 0x003DED57
		public static Offset<IExecuteActionList> CreateIExecuteActionList(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode, VectorOffset ActionListOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IExecuteActionList.AddActionList(builder, ActionListOffset);
			IExecuteActionList.AddType(builder, Type);
			return IExecuteActionList.EndIExecuteActionList(builder);
		}

		// Token: 0x0601B3FD RID: 111613 RVA: 0x003E0B74 File Offset: 0x003DED74
		public static void StartIExecuteActionList(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601B3FE RID: 111614 RVA: 0x003E0B7D File Offset: 0x003DED7D
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B3FF RID: 111615 RVA: 0x003E0B88 File Offset: 0x003DED88
		public static void AddActionList(FlatBufferBuilder builder, VectorOffset actionListOffset)
		{
			builder.AddOffset(1, actionListOffset.Value, 0);
		}

		// Token: 0x0601B400 RID: 111616 RVA: 0x003E0B98 File Offset: 0x003DED98
		public static VectorOffset CreateActionListVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601B401 RID: 111617 RVA: 0x003E0BD8 File Offset: 0x003DEDD8
		public static VectorOffset CreateActionListVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B402 RID: 111618 RVA: 0x003E0BF2 File Offset: 0x003DEDF2
		public static VectorOffset CreateActionListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B403 RID: 111619 RVA: 0x003E0C10 File Offset: 0x003DEE10
		public static VectorOffset CreateActionListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601B404 RID: 111620 RVA: 0x003E0C29 File Offset: 0x003DEE29
		public static void StartActionListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601B405 RID: 111621 RVA: 0x003E0C34 File Offset: 0x003DEE34
		public static Offset<IExecuteActionList> EndIExecuteActionList(FlatBufferBuilder builder)
		{
			return new Offset<IExecuteActionList>(builder.EndTable());
		}

		// Token: 0x0601B406 RID: 111622 RVA: 0x003E0C44 File Offset: 0x003DEE44
		public IExecuteActionListT UnPack()
		{
			IExecuteActionListT executeActionListT = new IExecuteActionListT();
			this.UnPackTo(executeActionListT);
			return executeActionListT;
		}

		// Token: 0x0601B407 RID: 111623 RVA: 0x003E0C60 File Offset: 0x003DEE60
		public void UnPackTo(IExecuteActionListT _o)
		{
			_o.Type = this.Type;
			_o.ActionList = new List<IActionInfoT>();
			for (int i = 0; i < this.ActionListLength; i++)
			{
				_o.ActionList.Add((this.ActionList(i) != null) ? this.ActionList(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601B408 RID: 111624 RVA: 0x003E0CCC File Offset: 0x003DEECC
		public static Offset<IExecuteActionList> Pack(FlatBufferBuilder builder, IExecuteActionListT _o)
		{
			if (_o == null)
			{
				return default(Offset<IExecuteActionList>);
			}
			VectorOffset actionListOffset = default(VectorOffset);
			if (_o.ActionList != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.ActionList.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.ActionList[i]);
				}
				actionListOffset = IExecuteActionList.CreateActionListVector(builder, array);
			}
			return IExecuteActionList.CreateIExecuteActionList(builder, _o.Type, actionListOffset);
		}

		// Token: 0x0400C7BA RID: 51130
		private Table __p;
	}
}
