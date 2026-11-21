using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004103 RID: 16643
	public struct IActionBtNode : IFlatbufferObject
	{
		// Token: 0x17007086 RID: 28806
		// (get) Token: 0x06016C97 RID: 93335 RVA: 0x00340DAA File Offset: 0x0033EFAA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016C98 RID: 93336 RVA: 0x00340DB7 File Offset: 0x0033EFB7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016C99 RID: 93337 RVA: 0x00340DC0 File Offset: 0x0033EFC0
		public static IActionBtNode GetRootAsIActionBtNode(ByteBuffer _bb)
		{
			return IActionBtNode.GetRootAsIActionBtNode(_bb, default(IActionBtNode));
		}

		// Token: 0x06016C9A RID: 93338 RVA: 0x00340DDC File Offset: 0x0033EFDC
		public static IActionBtNode GetRootAsIActionBtNode(ByteBuffer _bb, IActionBtNode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016C9B RID: 93339 RVA: 0x00340DF9 File Offset: 0x0033EFF9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016C9C RID: 93340 RVA: 0x00340E08 File Offset: 0x0033F008
		public IActionBtNode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007087 RID: 28807
		// (get) Token: 0x06016C9D RID: 93341 RVA: 0x00340E18 File Offset: 0x0033F018
		public EBtNode Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBtNode.Start;
				}
				return (EBtNode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007088 RID: 28808
		// (get) Token: 0x06016C9E RID: 93342 RVA: 0x00340E54 File Offset: 0x0033F054
		public int Id
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007089 RID: 28809
		// (get) Token: 0x06016C9F RID: 93343 RVA: 0x00340E90 File Offset: 0x0033F090
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06016CA0 RID: 93344 RVA: 0x00340EC7 File Offset: 0x0033F0C7
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06016CA1 RID: 93345 RVA: 0x00340ED6 File Offset: 0x0033F0D6
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700708A RID: 28810
		// (get) Token: 0x06016CA2 RID: 93346 RVA: 0x00340EE4 File Offset: 0x0033F0E4
		public IFixProcessor? FixProcessor
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IFixProcessor?(default(IFixProcessor).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700708B RID: 28811
		// (get) Token: 0x06016CA3 RID: 93347 RVA: 0x00340F44 File Offset: 0x0033F144
		public bool _FoldedForTree
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700708C RID: 28812
		// (get) Token: 0x06016CA4 RID: 93348 RVA: 0x00340F84 File Offset: 0x0033F184
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06016CA5 RID: 93349 RVA: 0x00340FC4 File Offset: 0x0033F1C4
		public IActionInfo? Actions(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700708D RID: 28813
		// (get) Token: 0x06016CA6 RID: 93350 RVA: 0x00341028 File Offset: 0x0033F228
		public int ActionsLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700708E RID: 28814
		// (get) Token: 0x06016CA7 RID: 93351 RVA: 0x00341054 File Offset: 0x0033F254
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06016CA8 RID: 93352 RVA: 0x00341094 File Offset: 0x0033F294
		public static Offset<IActionBtNode> CreateIActionBtNode(FlatBufferBuilder builder, EBtNode Type = EBtNode.Start, int Id = 0, StringOffset DescOffset = default(StringOffset), Offset<IFixProcessor> FixProcessorOffset = default(Offset<IFixProcessor>), bool _foldedForTree = false, bool Disabled = false, VectorOffset ActionsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(8);
			IActionBtNode.AddActions(builder, ActionsOffset);
			IActionBtNode.AddFixProcessor(builder, FixProcessorOffset);
			IActionBtNode.AddDesc(builder, DescOffset);
			IActionBtNode.AddId(builder, Id);
			IActionBtNode.AddNullMask(builder, NullMask);
			IActionBtNode.AddDisabled(builder, Disabled);
			IActionBtNode.Add_FoldedForTree(builder, _foldedForTree);
			IActionBtNode.AddType(builder, Type);
			return IActionBtNode.EndIActionBtNode(builder);
		}

		// Token: 0x06016CA9 RID: 93353 RVA: 0x003410EB File Offset: 0x0033F2EB
		public static void StartIActionBtNode(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x06016CAA RID: 93354 RVA: 0x003410F4 File Offset: 0x0033F2F4
		public static void AddType(FlatBufferBuilder builder, EBtNode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016CAB RID: 93355 RVA: 0x003410FF File Offset: 0x0033F2FF
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x06016CAC RID: 93356 RVA: 0x0034110A File Offset: 0x0033F30A
		public static void AddDesc(FlatBufferBuilder builder, StringOffset descOffset)
		{
			builder.AddOffset(2, descOffset.Value, 0);
		}

		// Token: 0x06016CAD RID: 93357 RVA: 0x0034111A File Offset: 0x0033F31A
		public static void AddFixProcessor(FlatBufferBuilder builder, Offset<IFixProcessor> fixProcessorOffset)
		{
			builder.AddOffset(3, fixProcessorOffset.Value, 0);
		}

		// Token: 0x06016CAE RID: 93358 RVA: 0x0034112A File Offset: 0x0033F32A
		public static void Add_FoldedForTree(FlatBufferBuilder builder, bool _FoldedForTree)
		{
			builder.AddBool(4, _FoldedForTree, false);
		}

		// Token: 0x06016CAF RID: 93359 RVA: 0x00341135 File Offset: 0x0033F335
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(5, disabled, false);
		}

		// Token: 0x06016CB0 RID: 93360 RVA: 0x00341140 File Offset: 0x0033F340
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(6, actionsOffset.Value, 0);
		}

		// Token: 0x06016CB1 RID: 93361 RVA: 0x00341150 File Offset: 0x0033F350
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06016CB2 RID: 93362 RVA: 0x00341190 File Offset: 0x0033F390
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06016CB3 RID: 93363 RVA: 0x003411AA File Offset: 0x0033F3AA
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06016CB4 RID: 93364 RVA: 0x003411C8 File Offset: 0x0033F3C8
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06016CB5 RID: 93365 RVA: 0x003411E1 File Offset: 0x0033F3E1
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06016CB6 RID: 93366 RVA: 0x003411EC File Offset: 0x0033F3EC
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x06016CB7 RID: 93367 RVA: 0x003411F7 File Offset: 0x0033F3F7
		public static Offset<IActionBtNode> EndIActionBtNode(FlatBufferBuilder builder)
		{
			return new Offset<IActionBtNode>(builder.EndTable());
		}

		// Token: 0x06016CB8 RID: 93368 RVA: 0x00341204 File Offset: 0x0033F404
		public IActionBtNodeT UnPack()
		{
			IActionBtNodeT actionBtNodeT = new IActionBtNodeT();
			this.UnPackTo(actionBtNodeT);
			return actionBtNodeT;
		}

		// Token: 0x06016CB9 RID: 93369 RVA: 0x00341220 File Offset: 0x0033F420
		public void UnPackTo(IActionBtNodeT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
			_o.Desc = this.Desc;
			_o.FixProcessor = ((this.FixProcessor != null) ? this.FixProcessor.Value.UnPack() : null);
			_o._FoldedForTree = this._FoldedForTree;
			_o.Disabled = this.Disabled;
			_o.Actions = new List<IActionInfoT>();
			for (int i = 0; i < this.ActionsLength; i++)
			{
				_o.Actions.Add((this.Actions(i) != null) ? this.Actions(i).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06016CBA RID: 93370 RVA: 0x003412F8 File Offset: 0x0033F4F8
		public static Offset<IActionBtNode> Pack(FlatBufferBuilder builder, IActionBtNodeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActionBtNode>);
			}
			StringOffset descOffset = (_o.Desc == null) ? default(StringOffset) : builder.CreateString(_o.Desc);
			Offset<IFixProcessor> fixProcessorOffset = (_o.FixProcessor == null) ? default(Offset<IFixProcessor>) : IFixProcessor.Pack(builder, _o.FixProcessor);
			VectorOffset actionsOffset = default(VectorOffset);
			if (_o.Actions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.Actions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.Actions[i]);
				}
				actionsOffset = IActionBtNode.CreateActionsVector(builder, array);
			}
			return IActionBtNode.CreateIActionBtNode(builder, _o.Type, _o.Id, descOffset, fixProcessorOffset, _o._FoldedForTree, _o.Disabled, actionsOffset, _o.NullMask);
		}

		// Token: 0x0400BF2D RID: 48941
		private Table __p;
	}
}
