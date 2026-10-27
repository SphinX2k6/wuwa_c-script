using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004061 RID: 16481
	public struct IQuestSucceedBtNode : IFlatbufferObject
	{
		// Token: 0x17007412 RID: 29714
		// (get) Token: 0x06017E83 RID: 97923 RVA: 0x003734E2 File Offset: 0x003716E2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017E84 RID: 97924 RVA: 0x003734EF File Offset: 0x003716EF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017E85 RID: 97925 RVA: 0x003734F8 File Offset: 0x003716F8
		public static IQuestSucceedBtNode GetRootAsIQuestSucceedBtNode(ByteBuffer _bb)
		{
			return IQuestSucceedBtNode.GetRootAsIQuestSucceedBtNode(_bb, default(IQuestSucceedBtNode));
		}

		// Token: 0x06017E86 RID: 97926 RVA: 0x00373514 File Offset: 0x00371714
		public static IQuestSucceedBtNode GetRootAsIQuestSucceedBtNode(ByteBuffer _bb, IQuestSucceedBtNode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017E87 RID: 97927 RVA: 0x00373531 File Offset: 0x00371731
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017E88 RID: 97928 RVA: 0x00373540 File Offset: 0x00371740
		public IQuestSucceedBtNode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007413 RID: 29715
		// (get) Token: 0x06017E89 RID: 97929 RVA: 0x00373550 File Offset: 0x00371750
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

		// Token: 0x17007414 RID: 29716
		// (get) Token: 0x06017E8A RID: 97930 RVA: 0x0037358C File Offset: 0x0037178C
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

		// Token: 0x17007415 RID: 29717
		// (get) Token: 0x06017E8B RID: 97931 RVA: 0x003735C8 File Offset: 0x003717C8
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

		// Token: 0x06017E8C RID: 97932 RVA: 0x003735FF File Offset: 0x003717FF
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06017E8D RID: 97933 RVA: 0x0037360E File Offset: 0x0037180E
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x17007416 RID: 29718
		// (get) Token: 0x06017E8E RID: 97934 RVA: 0x0037361C File Offset: 0x0037181C
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

		// Token: 0x17007417 RID: 29719
		// (get) Token: 0x06017E8F RID: 97935 RVA: 0x0037367C File Offset: 0x0037187C
		public bool _FoldedForTree
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007418 RID: 29720
		// (get) Token: 0x06017E90 RID: 97936 RVA: 0x003736BC File Offset: 0x003718BC
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06017E91 RID: 97937 RVA: 0x003736FC File Offset: 0x003718FC
		public IActionInfo? FinishActions(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007419 RID: 29721
		// (get) Token: 0x06017E92 RID: 97938 RVA: 0x00373760 File Offset: 0x00371960
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

		// Token: 0x1700741A RID: 29722
		// (get) Token: 0x06017E93 RID: 97939 RVA: 0x0037378C File Offset: 0x0037198C
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

		// Token: 0x06017E94 RID: 97940 RVA: 0x003737CC File Offset: 0x003719CC
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

		// Token: 0x06017E95 RID: 97941 RVA: 0x00373823 File Offset: 0x00371A23
		public static void StartIQuestSucceedBtNode(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x06017E96 RID: 97942 RVA: 0x0037382C File Offset: 0x00371A2C
		public static void AddType(FlatBufferBuilder builder, EBtNode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017E97 RID: 97943 RVA: 0x00373837 File Offset: 0x00371A37
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x06017E98 RID: 97944 RVA: 0x00373842 File Offset: 0x00371A42
		public static void AddDesc(FlatBufferBuilder builder, StringOffset descOffset)
		{
			builder.AddOffset(2, descOffset.Value, 0);
		}

		// Token: 0x06017E99 RID: 97945 RVA: 0x00373852 File Offset: 0x00371A52
		public static void AddFixProcessor(FlatBufferBuilder builder, Offset<IFixProcessor> fixProcessorOffset)
		{
			builder.AddOffset(3, fixProcessorOffset.Value, 0);
		}

		// Token: 0x06017E9A RID: 97946 RVA: 0x00373862 File Offset: 0x00371A62
		public static void Add_FoldedForTree(FlatBufferBuilder builder, bool _FoldedForTree)
		{
			builder.AddBool(4, _FoldedForTree, false);
		}

		// Token: 0x06017E9B RID: 97947 RVA: 0x0037386D File Offset: 0x00371A6D
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(5, disabled, false);
		}

		// Token: 0x06017E9C RID: 97948 RVA: 0x00373878 File Offset: 0x00371A78
		public static void AddFinishActions(FlatBufferBuilder builder, VectorOffset finishActionsOffset)
		{
			builder.AddOffset(6, finishActionsOffset.Value, 0);
		}

		// Token: 0x06017E9D RID: 97949 RVA: 0x00373888 File Offset: 0x00371A88
		public static VectorOffset CreateFinishActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06017E9E RID: 97950 RVA: 0x003738C8 File Offset: 0x00371AC8
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06017E9F RID: 97951 RVA: 0x003738E2 File Offset: 0x00371AE2
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06017EA0 RID: 97952 RVA: 0x00373900 File Offset: 0x00371B00
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06017EA1 RID: 97953 RVA: 0x00373919 File Offset: 0x00371B19
		public static void StartFinishActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06017EA2 RID: 97954 RVA: 0x00373924 File Offset: 0x00371B24
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x06017EA3 RID: 97955 RVA: 0x0037392F File Offset: 0x00371B2F
		public static Offset<IQuestSucceedBtNode> EndIQuestSucceedBtNode(FlatBufferBuilder builder)
		{
			return new Offset<IQuestSucceedBtNode>(builder.EndTable());
		}

		// Token: 0x06017EA4 RID: 97956 RVA: 0x0037393C File Offset: 0x00371B3C
		public IQuestSucceedBtNodeT UnPack()
		{
			IQuestSucceedBtNodeT questSucceedBtNodeT = new IQuestSucceedBtNodeT();
			this.UnPackTo(questSucceedBtNodeT);
			return questSucceedBtNodeT;
		}

		// Token: 0x06017EA5 RID: 97957 RVA: 0x00373958 File Offset: 0x00371B58
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

		// Token: 0x06017EA6 RID: 97958 RVA: 0x00373A30 File Offset: 0x00371C30
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

		// Token: 0x0400BBBF RID: 48063
		private Table __p;
	}
}
