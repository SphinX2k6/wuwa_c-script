using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020044A2 RID: 17570
	public struct IQuestSucceedBtNode : IFlatbufferObject
	{
		// Token: 0x17007A14 RID: 31252
		// (get) Token: 0x0601951C RID: 103708 RVA: 0x0039D2D6 File Offset: 0x0039B4D6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601951D RID: 103709 RVA: 0x0039D2E3 File Offset: 0x0039B4E3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601951E RID: 103710 RVA: 0x0039D2EC File Offset: 0x0039B4EC
		public static IQuestSucceedBtNode GetRootAsIQuestSucceedBtNode(ByteBuffer _bb)
		{
			return IQuestSucceedBtNode.GetRootAsIQuestSucceedBtNode(_bb, default(IQuestSucceedBtNode));
		}

		// Token: 0x0601951F RID: 103711 RVA: 0x0039D308 File Offset: 0x0039B508
		public static IQuestSucceedBtNode GetRootAsIQuestSucceedBtNode(ByteBuffer _bb, IQuestSucceedBtNode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019520 RID: 103712 RVA: 0x0039D325 File Offset: 0x0039B525
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019521 RID: 103713 RVA: 0x0039D334 File Offset: 0x0039B534
		public IQuestSucceedBtNode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007A15 RID: 31253
		// (get) Token: 0x06019522 RID: 103714 RVA: 0x0039D344 File Offset: 0x0039B544
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

		// Token: 0x17007A16 RID: 31254
		// (get) Token: 0x06019523 RID: 103715 RVA: 0x0039D380 File Offset: 0x0039B580
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

		// Token: 0x17007A17 RID: 31255
		// (get) Token: 0x06019524 RID: 103716 RVA: 0x0039D3BC File Offset: 0x0039B5BC
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

		// Token: 0x06019525 RID: 103717 RVA: 0x0039D3F3 File Offset: 0x0039B5F3
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06019526 RID: 103718 RVA: 0x0039D402 File Offset: 0x0039B602
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x17007A18 RID: 31256
		// (get) Token: 0x06019527 RID: 103719 RVA: 0x0039D410 File Offset: 0x0039B610
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

		// Token: 0x17007A19 RID: 31257
		// (get) Token: 0x06019528 RID: 103720 RVA: 0x0039D470 File Offset: 0x0039B670
		public bool _FoldedForTree
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007A1A RID: 31258
		// (get) Token: 0x06019529 RID: 103721 RVA: 0x0039D4B0 File Offset: 0x0039B6B0
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601952A RID: 103722 RVA: 0x0039D4F0 File Offset: 0x0039B6F0
		public IActionInfo? FinishActions(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007A1B RID: 31259
		// (get) Token: 0x0601952B RID: 103723 RVA: 0x0039D554 File Offset: 0x0039B754
		public int FinishActionsLength
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

		// Token: 0x17007A1C RID: 31260
		// (get) Token: 0x0601952C RID: 103724 RVA: 0x0039D580 File Offset: 0x0039B780
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

		// Token: 0x0601952D RID: 103725 RVA: 0x0039D5C0 File Offset: 0x0039B7C0
		public static Offset<IQuestSucceedBtNode> CreateIQuestSucceedBtNode(FlatBufferBuilder builder, EBtNode Type = EBtNode.Start, int Id = 0, StringOffset DescOffset = default(StringOffset), Offset<IFixProcessor> FixProcessorOffset = default(Offset<IFixProcessor>), bool _foldedForTree = false, bool Disabled = false, VectorOffset FinishActionsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(8);
			IQuestSucceedBtNode.AddFinishActions(builder, FinishActionsOffset);
			IQuestSucceedBtNode.AddFixProcessor(builder, FixProcessorOffset);
			IQuestSucceedBtNode.AddDesc(builder, DescOffset);
			IQuestSucceedBtNode.AddId(builder, Id);
			IQuestSucceedBtNode.AddNullMask(builder, NullMask);
			IQuestSucceedBtNode.AddDisabled(builder, Disabled);
			IQuestSucceedBtNode.Add_FoldedForTree(builder, _foldedForTree);
			IQuestSucceedBtNode.AddType(builder, Type);
			return IQuestSucceedBtNode.EndIQuestSucceedBtNode(builder);
		}

		// Token: 0x0601952E RID: 103726 RVA: 0x0039D617 File Offset: 0x0039B817
		public static void StartIQuestSucceedBtNode(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x0601952F RID: 103727 RVA: 0x0039D620 File Offset: 0x0039B820
		public static void AddType(FlatBufferBuilder builder, EBtNode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019530 RID: 103728 RVA: 0x0039D62B File Offset: 0x0039B82B
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x06019531 RID: 103729 RVA: 0x0039D636 File Offset: 0x0039B836
		public static void AddDesc(FlatBufferBuilder builder, StringOffset descOffset)
		{
			builder.AddOffset(2, descOffset.Value, 0);
		}

		// Token: 0x06019532 RID: 103730 RVA: 0x0039D646 File Offset: 0x0039B846
		public static void AddFixProcessor(FlatBufferBuilder builder, Offset<IFixProcessor> fixProcessorOffset)
		{
			builder.AddOffset(3, fixProcessorOffset.Value, 0);
		}

		// Token: 0x06019533 RID: 103731 RVA: 0x0039D656 File Offset: 0x0039B856
		public static void Add_FoldedForTree(FlatBufferBuilder builder, bool _FoldedForTree)
		{
			builder.AddBool(4, _FoldedForTree, false);
		}

		// Token: 0x06019534 RID: 103732 RVA: 0x0039D661 File Offset: 0x0039B861
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(5, disabled, false);
		}

		// Token: 0x06019535 RID: 103733 RVA: 0x0039D66C File Offset: 0x0039B86C
		public static void AddFinishActions(FlatBufferBuilder builder, VectorOffset finishActionsOffset)
		{
			builder.AddOffset(6, finishActionsOffset.Value, 0);
		}

		// Token: 0x06019536 RID: 103734 RVA: 0x0039D67C File Offset: 0x0039B87C
		public static VectorOffset CreateFinishActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06019537 RID: 103735 RVA: 0x0039D6BC File Offset: 0x0039B8BC
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06019538 RID: 103736 RVA: 0x0039D6D6 File Offset: 0x0039B8D6
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06019539 RID: 103737 RVA: 0x0039D6F4 File Offset: 0x0039B8F4
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601953A RID: 103738 RVA: 0x0039D70D File Offset: 0x0039B90D
		public static void StartFinishActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601953B RID: 103739 RVA: 0x0039D718 File Offset: 0x0039B918
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x0601953C RID: 103740 RVA: 0x0039D723 File Offset: 0x0039B923
		public static Offset<IQuestSucceedBtNode> EndIQuestSucceedBtNode(FlatBufferBuilder builder)
		{
			return new Offset<IQuestSucceedBtNode>(builder.EndTable());
		}

		// Token: 0x0601953D RID: 103741 RVA: 0x0039D730 File Offset: 0x0039B930
		public IQuestSucceedBtNodeT UnPack()
		{
			IQuestSucceedBtNodeT questSucceedBtNodeT = new IQuestSucceedBtNodeT();
			this.UnPackTo(questSucceedBtNodeT);
			return questSucceedBtNodeT;
		}

		// Token: 0x0601953E RID: 103742 RVA: 0x0039D74C File Offset: 0x0039B94C
		public void UnPackTo(IQuestSucceedBtNodeT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
			_o.Desc = this.Desc;
			_o.FixProcessor = ((this.FixProcessor != null) ? this.FixProcessor.Value.UnPack() : null);
			_o._FoldedForTree = this._FoldedForTree;
			_o.Disabled = this.Disabled;
			_o.FinishActions = new List<IActionInfoT>();
			for (int i = 0; i < this.FinishActionsLength; i++)
			{
				_o.FinishActions.Add((this.FinishActions(i) != null) ? this.FinishActions(i).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601953F RID: 103743 RVA: 0x0039D824 File Offset: 0x0039BA24
		public static Offset<IQuestSucceedBtNode> Pack(FlatBufferBuilder builder, IQuestSucceedBtNodeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestSucceedBtNode>);
			}
			StringOffset descOffset = (_o.Desc == null) ? default(StringOffset) : builder.CreateString(_o.Desc);
			Offset<IFixProcessor> fixProcessorOffset = (_o.FixProcessor == null) ? default(Offset<IFixProcessor>) : IFixProcessor.Pack(builder, _o.FixProcessor);
			VectorOffset finishActionsOffset = default(VectorOffset);
			if (_o.FinishActions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.FinishActions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.FinishActions[i]);
				}
				finishActionsOffset = IQuestSucceedBtNode.CreateFinishActionsVector(builder, array);
			}
			return IQuestSucceedBtNode.CreateIQuestSucceedBtNode(builder, _o.Type, _o.Id, descOffset, fixProcessorOffset, _o._FoldedForTree, _o.Disabled, finishActionsOffset, _o.NullMask);
		}

		// Token: 0x0400C5A6 RID: 50598
		private Table __p;
	}
}
