using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004415 RID: 17429
	public struct IQuestFailedBtNode : IFlatbufferObject
	{
		// Token: 0x17007873 RID: 30835
		// (get) Token: 0x06018E2A RID: 101930 RVA: 0x0038C570 File Offset: 0x0038A770
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018E2B RID: 101931 RVA: 0x0038C57D File Offset: 0x0038A77D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018E2C RID: 101932 RVA: 0x0038C584 File Offset: 0x0038A784
		public static IQuestFailedBtNode GetRootAsIQuestFailedBtNode(ByteBuffer _bb)
		{
			return IQuestFailedBtNode.GetRootAsIQuestFailedBtNode(_bb, default(IQuestFailedBtNode));
		}

		// Token: 0x06018E2D RID: 101933 RVA: 0x0038C5A0 File Offset: 0x0038A7A0
		public static IQuestFailedBtNode GetRootAsIQuestFailedBtNode(ByteBuffer _bb, IQuestFailedBtNode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018E2E RID: 101934 RVA: 0x0038C5BD File Offset: 0x0038A7BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018E2F RID: 101935 RVA: 0x0038C5CC File Offset: 0x0038A7CC
		public IQuestFailedBtNode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007874 RID: 30836
		// (get) Token: 0x06018E30 RID: 101936 RVA: 0x0038C5DC File Offset: 0x0038A7DC
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

		// Token: 0x17007875 RID: 30837
		// (get) Token: 0x06018E31 RID: 101937 RVA: 0x0038C618 File Offset: 0x0038A818
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

		// Token: 0x17007876 RID: 30838
		// (get) Token: 0x06018E32 RID: 101938 RVA: 0x0038C654 File Offset: 0x0038A854
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

		// Token: 0x06018E33 RID: 101939 RVA: 0x0038C68B File Offset: 0x0038A88B
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06018E34 RID: 101940 RVA: 0x0038C69A File Offset: 0x0038A89A
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x17007877 RID: 30839
		// (get) Token: 0x06018E35 RID: 101941 RVA: 0x0038C6A8 File Offset: 0x0038A8A8
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

		// Token: 0x17007878 RID: 30840
		// (get) Token: 0x06018E36 RID: 101942 RVA: 0x0038C708 File Offset: 0x0038A908
		public bool _FoldedForTree
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007879 RID: 30841
		// (get) Token: 0x06018E37 RID: 101943 RVA: 0x0038C748 File Offset: 0x0038A948
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700787A RID: 30842
		// (get) Token: 0x06018E38 RID: 101944 RVA: 0x0038C788 File Offset: 0x0038A988
		public bool ReturnTempSavePointFirst
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700787B RID: 30843
		// (get) Token: 0x06018E39 RID: 101945 RVA: 0x0038C7C8 File Offset: 0x0038A9C8
		public bool AutoFailed
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700787C RID: 30844
		// (get) Token: 0x06018E3A RID: 101946 RVA: 0x0038C808 File Offset: 0x0038AA08
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

		// Token: 0x06018E3B RID: 101947 RVA: 0x0038C868 File Offset: 0x0038AA68
		public IActionInfo? FinishActions(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700787D RID: 30845
		// (get) Token: 0x06018E3C RID: 101948 RVA: 0x0038C8CC File Offset: 0x0038AACC
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

		// Token: 0x1700787E RID: 30846
		// (get) Token: 0x06018E3D RID: 101949 RVA: 0x0038C8F8 File Offset: 0x0038AAF8
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

		// Token: 0x06018E3E RID: 101950 RVA: 0x0038C938 File Offset: 0x0038AB38
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

		// Token: 0x06018E3F RID: 101951 RVA: 0x0038C9A8 File Offset: 0x0038ABA8
		public static void StartIQuestFailedBtNode(FlatBufferBuilder builder)
		{
			builder.StartTable(11);
		}

		// Token: 0x06018E40 RID: 101952 RVA: 0x0038C9B2 File Offset: 0x0038ABB2
		public static void AddType(FlatBufferBuilder builder, EBtNode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06018E41 RID: 101953 RVA: 0x0038C9BD File Offset: 0x0038ABBD
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x06018E42 RID: 101954 RVA: 0x0038C9C8 File Offset: 0x0038ABC8
		public static void AddDesc(FlatBufferBuilder builder, StringOffset descOffset)
		{
			builder.AddOffset(2, descOffset.Value, 0);
		}

		// Token: 0x06018E43 RID: 101955 RVA: 0x0038C9D8 File Offset: 0x0038ABD8
		public static void AddFixProcessor(FlatBufferBuilder builder, Offset<IFixProcessor> fixProcessorOffset)
		{
			builder.AddOffset(3, fixProcessorOffset.Value, 0);
		}

		// Token: 0x06018E44 RID: 101956 RVA: 0x0038C9E8 File Offset: 0x0038ABE8
		public static void Add_FoldedForTree(FlatBufferBuilder builder, bool _FoldedForTree)
		{
			builder.AddBool(4, _FoldedForTree, false);
		}

		// Token: 0x06018E45 RID: 101957 RVA: 0x0038C9F3 File Offset: 0x0038ABF3
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(5, disabled, false);
		}

		// Token: 0x06018E46 RID: 101958 RVA: 0x0038C9FE File Offset: 0x0038ABFE
		public static void AddReturnTempSavePointFirst(FlatBufferBuilder builder, bool returnTempSavePointFirst)
		{
			builder.AddBool(6, returnTempSavePointFirst, false);
		}

		// Token: 0x06018E47 RID: 101959 RVA: 0x0038CA09 File Offset: 0x0038AC09
		public static void AddAutoFailed(FlatBufferBuilder builder, bool autoFailed)
		{
			builder.AddBool(7, autoFailed, false);
		}

		// Token: 0x06018E48 RID: 101960 RVA: 0x0038CA14 File Offset: 0x0038AC14
		public static void AddFailedCondition(FlatBufferBuilder builder, Offset<IQuestFailedCondition> failedConditionOffset)
		{
			builder.AddOffset(8, failedConditionOffset.Value, 0);
		}

		// Token: 0x06018E49 RID: 101961 RVA: 0x0038CA24 File Offset: 0x0038AC24
		public static void AddFinishActions(FlatBufferBuilder builder, VectorOffset finishActionsOffset)
		{
			builder.AddOffset(9, finishActionsOffset.Value, 0);
		}

		// Token: 0x06018E4A RID: 101962 RVA: 0x0038CA38 File Offset: 0x0038AC38
		public static VectorOffset CreateFinishActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06018E4B RID: 101963 RVA: 0x0038CA78 File Offset: 0x0038AC78
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06018E4C RID: 101964 RVA: 0x0038CA92 File Offset: 0x0038AC92
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06018E4D RID: 101965 RVA: 0x0038CAB0 File Offset: 0x0038ACB0
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06018E4E RID: 101966 RVA: 0x0038CAC9 File Offset: 0x0038ACC9
		public static void StartFinishActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06018E4F RID: 101967 RVA: 0x0038CAD4 File Offset: 0x0038ACD4
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(10, nullMask, 0);
		}

		// Token: 0x06018E50 RID: 101968 RVA: 0x0038CAE0 File Offset: 0x0038ACE0
		public static Offset<IQuestFailedBtNode> EndIQuestFailedBtNode(FlatBufferBuilder builder)
		{
			return new Offset<IQuestFailedBtNode>(builder.EndTable());
		}

		// Token: 0x06018E51 RID: 101969 RVA: 0x0038CAF0 File Offset: 0x0038ACF0
		public IQuestFailedBtNodeT UnPack()
		{
			IQuestFailedBtNodeT questFailedBtNodeT = new IQuestFailedBtNodeT();
			this.UnPackTo(questFailedBtNodeT);
			return questFailedBtNodeT;
		}

		// Token: 0x06018E52 RID: 101970 RVA: 0x0038CB0C File Offset: 0x0038AD0C
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

		// Token: 0x06018E53 RID: 101971 RVA: 0x0038CC34 File Offset: 0x0038AE34
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

		// Token: 0x0400C49D RID: 50333
		private Table __p;
	}
}
