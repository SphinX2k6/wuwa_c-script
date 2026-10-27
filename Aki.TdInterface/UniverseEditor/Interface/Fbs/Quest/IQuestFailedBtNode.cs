using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FD4 RID: 16340
	public struct IQuestFailedBtNode : IFlatbufferObject
	{
		// Token: 0x17007273 RID: 29299
		// (get) Token: 0x06017797 RID: 96151 RVA: 0x00362848 File Offset: 0x00360A48
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017798 RID: 96152 RVA: 0x00362855 File Offset: 0x00360A55
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017799 RID: 96153 RVA: 0x0036285C File Offset: 0x00360A5C
		public static IQuestFailedBtNode GetRootAsIQuestFailedBtNode(ByteBuffer _bb)
		{
			return IQuestFailedBtNode.GetRootAsIQuestFailedBtNode(_bb, default(IQuestFailedBtNode));
		}

		// Token: 0x0601779A RID: 96154 RVA: 0x00362878 File Offset: 0x00360A78
		public static IQuestFailedBtNode GetRootAsIQuestFailedBtNode(ByteBuffer _bb, IQuestFailedBtNode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601779B RID: 96155 RVA: 0x00362895 File Offset: 0x00360A95
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601779C RID: 96156 RVA: 0x003628A4 File Offset: 0x00360AA4
		public IQuestFailedBtNode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007274 RID: 29300
		// (get) Token: 0x0601779D RID: 96157 RVA: 0x003628B4 File Offset: 0x00360AB4
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

		// Token: 0x17007275 RID: 29301
		// (get) Token: 0x0601779E RID: 96158 RVA: 0x003628F0 File Offset: 0x00360AF0
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

		// Token: 0x17007276 RID: 29302
		// (get) Token: 0x0601779F RID: 96159 RVA: 0x0036292C File Offset: 0x00360B2C
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

		// Token: 0x060177A0 RID: 96160 RVA: 0x00362963 File Offset: 0x00360B63
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060177A1 RID: 96161 RVA: 0x00362972 File Offset: 0x00360B72
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x17007277 RID: 29303
		// (get) Token: 0x060177A2 RID: 96162 RVA: 0x00362980 File Offset: 0x00360B80
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

		// Token: 0x17007278 RID: 29304
		// (get) Token: 0x060177A3 RID: 96163 RVA: 0x003629E0 File Offset: 0x00360BE0
		public bool _FoldedForTree
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007279 RID: 29305
		// (get) Token: 0x060177A4 RID: 96164 RVA: 0x00362A20 File Offset: 0x00360C20
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700727A RID: 29306
		// (get) Token: 0x060177A5 RID: 96165 RVA: 0x00362A60 File Offset: 0x00360C60
		public bool ReturnTempSavePointFirst
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700727B RID: 29307
		// (get) Token: 0x060177A6 RID: 96166 RVA: 0x00362AA0 File Offset: 0x00360CA0
		public bool AutoFailed
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700727C RID: 29308
		// (get) Token: 0x060177A7 RID: 96167 RVA: 0x00362AE0 File Offset: 0x00360CE0
		public IQuestFailedCondition? FailedCondition
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return new IQuestFailedCondition?(default(IQuestFailedCondition).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060177A8 RID: 96168 RVA: 0x00362B40 File Offset: 0x00360D40
		public IActionInfo? FinishActions(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700727D RID: 29309
		// (get) Token: 0x060177A9 RID: 96169 RVA: 0x00362BA4 File Offset: 0x00360DA4
		public int FinishActionsLength
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700727E RID: 29310
		// (get) Token: 0x060177AA RID: 96170 RVA: 0x00362BD0 File Offset: 0x00360DD0
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060177AB RID: 96171 RVA: 0x00362C10 File Offset: 0x00360E10
		public static Offset<IQuestFailedBtNode> CreateIQuestFailedBtNode(FlatBufferBuilder builder, EBtNode Type = EBtNode.Start, int Id = 0, StringOffset DescOffset = default(StringOffset), Offset<IFixProcessor> FixProcessorOffset = default(Offset<IFixProcessor>), bool _foldedForTree = false, bool Disabled = false, bool ReturnTempSavePointFirst = false, bool AutoFailed = false, Offset<IQuestFailedCondition> FailedConditionOffset = default(Offset<IQuestFailedCondition>), VectorOffset FinishActionsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(11);
			IQuestFailedBtNode.AddFinishActions(builder, FinishActionsOffset);
			IQuestFailedBtNode.AddFailedCondition(builder, FailedConditionOffset);
			IQuestFailedBtNode.AddFixProcessor(builder, FixProcessorOffset);
			IQuestFailedBtNode.AddDesc(builder, DescOffset);
			IQuestFailedBtNode.AddId(builder, Id);
			IQuestFailedBtNode.AddNullMask(builder, NullMask);
			IQuestFailedBtNode.AddAutoFailed(builder, AutoFailed);
			IQuestFailedBtNode.AddReturnTempSavePointFirst(builder, ReturnTempSavePointFirst);
			IQuestFailedBtNode.AddDisabled(builder, Disabled);
			IQuestFailedBtNode.Add_FoldedForTree(builder, _foldedForTree);
			IQuestFailedBtNode.AddType(builder, Type);
			return IQuestFailedBtNode.EndIQuestFailedBtNode(builder);
		}

		// Token: 0x060177AC RID: 96172 RVA: 0x00362C80 File Offset: 0x00360E80
		public static void StartIQuestFailedBtNode(FlatBufferBuilder builder)
		{
			builder.StartTable(11);
		}

		// Token: 0x060177AD RID: 96173 RVA: 0x00362C8A File Offset: 0x00360E8A
		public static void AddType(FlatBufferBuilder builder, EBtNode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060177AE RID: 96174 RVA: 0x00362C95 File Offset: 0x00360E95
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x060177AF RID: 96175 RVA: 0x00362CA0 File Offset: 0x00360EA0
		public static void AddDesc(FlatBufferBuilder builder, StringOffset descOffset)
		{
			builder.AddOffset(2, descOffset.Value, 0);
		}

		// Token: 0x060177B0 RID: 96176 RVA: 0x00362CB0 File Offset: 0x00360EB0
		public static void AddFixProcessor(FlatBufferBuilder builder, Offset<IFixProcessor> fixProcessorOffset)
		{
			builder.AddOffset(3, fixProcessorOffset.Value, 0);
		}

		// Token: 0x060177B1 RID: 96177 RVA: 0x00362CC0 File Offset: 0x00360EC0
		public static void Add_FoldedForTree(FlatBufferBuilder builder, bool _FoldedForTree)
		{
			builder.AddBool(4, _FoldedForTree, false);
		}

		// Token: 0x060177B2 RID: 96178 RVA: 0x00362CCB File Offset: 0x00360ECB
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(5, disabled, false);
		}

		// Token: 0x060177B3 RID: 96179 RVA: 0x00362CD6 File Offset: 0x00360ED6
		public static void AddReturnTempSavePointFirst(FlatBufferBuilder builder, bool returnTempSavePointFirst)
		{
			builder.AddBool(6, returnTempSavePointFirst, false);
		}

		// Token: 0x060177B4 RID: 96180 RVA: 0x00362CE1 File Offset: 0x00360EE1
		public static void AddAutoFailed(FlatBufferBuilder builder, bool autoFailed)
		{
			builder.AddBool(7, autoFailed, false);
		}

		// Token: 0x060177B5 RID: 96181 RVA: 0x00362CEC File Offset: 0x00360EEC
		public static void AddFailedCondition(FlatBufferBuilder builder, Offset<IQuestFailedCondition> failedConditionOffset)
		{
			builder.AddOffset(8, failedConditionOffset.Value, 0);
		}

		// Token: 0x060177B6 RID: 96182 RVA: 0x00362CFC File Offset: 0x00360EFC
		public static void AddFinishActions(FlatBufferBuilder builder, VectorOffset finishActionsOffset)
		{
			builder.AddOffset(9, finishActionsOffset.Value, 0);
		}

		// Token: 0x060177B7 RID: 96183 RVA: 0x00362D10 File Offset: 0x00360F10
		public static VectorOffset CreateFinishActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060177B8 RID: 96184 RVA: 0x00362D50 File Offset: 0x00360F50
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060177B9 RID: 96185 RVA: 0x00362D6A File Offset: 0x00360F6A
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060177BA RID: 96186 RVA: 0x00362D88 File Offset: 0x00360F88
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060177BB RID: 96187 RVA: 0x00362DA1 File Offset: 0x00360FA1
		public static void StartFinishActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060177BC RID: 96188 RVA: 0x00362DAC File Offset: 0x00360FAC
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(10, nullMask, 0);
		}

		// Token: 0x060177BD RID: 96189 RVA: 0x00362DB8 File Offset: 0x00360FB8
		public static Offset<IQuestFailedBtNode> EndIQuestFailedBtNode(FlatBufferBuilder builder)
		{
			return new Offset<IQuestFailedBtNode>(builder.EndTable());
		}

		// Token: 0x060177BE RID: 96190 RVA: 0x00362DC8 File Offset: 0x00360FC8
		public IQuestFailedBtNodeT UnPack()
		{
			IQuestFailedBtNodeT questFailedBtNodeT = new IQuestFailedBtNodeT();
			this.UnPackTo(questFailedBtNodeT);
			return questFailedBtNodeT;
		}

		// Token: 0x060177BF RID: 96191 RVA: 0x00362DE4 File Offset: 0x00360FE4
		public void UnPackTo(IQuestFailedBtNodeT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
			_o.Desc = this.Desc;
			_o.FixProcessor = ((this.FixProcessor != null) ? this.FixProcessor.Value.UnPack() : null);
			_o._FoldedForTree = this._FoldedForTree;
			_o.Disabled = this.Disabled;
			_o.ReturnTempSavePointFirst = this.ReturnTempSavePointFirst;
			_o.AutoFailed = this.AutoFailed;
			_o.FailedCondition = ((this.FailedCondition != null) ? this.FailedCondition.Value.UnPack() : null);
			_o.FinishActions = new List<IActionInfoT>();
			for (int i = 0; i < this.FinishActionsLength; i++)
			{
				_o.FinishActions.Add((this.FinishActions(i) != null) ? this.FinishActions(i).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060177C0 RID: 96192 RVA: 0x00362F0C File Offset: 0x0036110C
		public static Offset<IQuestFailedBtNode> Pack(FlatBufferBuilder builder, IQuestFailedBtNodeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestFailedBtNode>);
			}
			StringOffset descOffset = (_o.Desc == null) ? default(StringOffset) : builder.CreateString(_o.Desc);
			Offset<IFixProcessor> fixProcessorOffset = (_o.FixProcessor == null) ? default(Offset<IFixProcessor>) : IFixProcessor.Pack(builder, _o.FixProcessor);
			Offset<IQuestFailedCondition> failedConditionOffset = (_o.FailedCondition == null) ? default(Offset<IQuestFailedCondition>) : IQuestFailedCondition.Pack(builder, _o.FailedCondition);
			VectorOffset finishActionsOffset = default(VectorOffset);
			if (_o.FinishActions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.FinishActions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.FinishActions[i]);
				}
				finishActionsOffset = IQuestFailedBtNode.CreateFinishActionsVector(builder, array);
			}
			return IQuestFailedBtNode.CreateIQuestFailedBtNode(builder, _o.Type, _o.Id, descOffset, fixProcessorOffset, _o._FoldedForTree, _o.Disabled, _o.ReturnTempSavePointFirst, _o.AutoFailed, failedConditionOffset, finishActionsOffset, _o.NullMask);
		}

		// Token: 0x0400BAB7 RID: 47799
		private Table __p;
	}
}
