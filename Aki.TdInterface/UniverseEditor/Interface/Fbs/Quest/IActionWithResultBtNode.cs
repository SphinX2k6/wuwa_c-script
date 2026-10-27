using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003CEF RID: 15599
	public struct IActionWithResultBtNode : IFlatbufferObject
	{
		// Token: 0x17006ADD RID: 27357
		// (get) Token: 0x06015795 RID: 87957 RVA: 0x0031A2FA File Offset: 0x003184FA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015796 RID: 87958 RVA: 0x0031A307 File Offset: 0x00318507
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015797 RID: 87959 RVA: 0x0031A310 File Offset: 0x00318510
		public static IActionWithResultBtNode GetRootAsIActionWithResultBtNode(ByteBuffer _bb)
		{
			return IActionWithResultBtNode.GetRootAsIActionWithResultBtNode(_bb, default(IActionWithResultBtNode));
		}

		// Token: 0x06015798 RID: 87960 RVA: 0x0031A32C File Offset: 0x0031852C
		public static IActionWithResultBtNode GetRootAsIActionWithResultBtNode(ByteBuffer _bb, IActionWithResultBtNode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015799 RID: 87961 RVA: 0x0031A349 File Offset: 0x00318549
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601579A RID: 87962 RVA: 0x0031A358 File Offset: 0x00318558
		public IActionWithResultBtNode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006ADE RID: 27358
		// (get) Token: 0x0601579B RID: 87963 RVA: 0x0031A368 File Offset: 0x00318568
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

		// Token: 0x17006ADF RID: 27359
		// (get) Token: 0x0601579C RID: 87964 RVA: 0x0031A3A4 File Offset: 0x003185A4
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

		// Token: 0x17006AE0 RID: 27360
		// (get) Token: 0x0601579D RID: 87965 RVA: 0x0031A3E0 File Offset: 0x003185E0
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

		// Token: 0x0601579E RID: 87966 RVA: 0x0031A417 File Offset: 0x00318617
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0601579F RID: 87967 RVA: 0x0031A426 File Offset: 0x00318626
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x17006AE1 RID: 27361
		// (get) Token: 0x060157A0 RID: 87968 RVA: 0x0031A434 File Offset: 0x00318634
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

		// Token: 0x17006AE2 RID: 27362
		// (get) Token: 0x060157A1 RID: 87969 RVA: 0x0031A494 File Offset: 0x00318694
		public bool _FoldedForTree
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17006AE3 RID: 27363
		// (get) Token: 0x060157A2 RID: 87970 RVA: 0x0031A4D4 File Offset: 0x003186D4
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17006AE4 RID: 27364
		// (get) Token: 0x060157A3 RID: 87971 RVA: 0x0031A514 File Offset: 0x00318714
		public IActionInfo? Action
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17006AE5 RID: 27365
		// (get) Token: 0x060157A4 RID: 87972 RVA: 0x0031A574 File Offset: 0x00318774
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

		// Token: 0x060157A5 RID: 87973 RVA: 0x0031A5B4 File Offset: 0x003187B4
		public static Offset<IActionWithResultBtNode> CreateIActionWithResultBtNode(FlatBufferBuilder builder, EBtNode Type = EBtNode.Start, int Id = 0, StringOffset DescOffset = default(StringOffset), Offset<IFixProcessor> FixProcessorOffset = default(Offset<IFixProcessor>), bool _foldedForTree = false, bool Disabled = false, Offset<IActionInfo> ActionOffset = default(Offset<IActionInfo>), byte NullMask = 0)
		{
			builder.StartTable(8);
			IActionWithResultBtNode.AddAction(builder, ActionOffset);
			IActionWithResultBtNode.AddFixProcessor(builder, FixProcessorOffset);
			IActionWithResultBtNode.AddDesc(builder, DescOffset);
			IActionWithResultBtNode.AddId(builder, Id);
			IActionWithResultBtNode.AddNullMask(builder, NullMask);
			IActionWithResultBtNode.AddDisabled(builder, Disabled);
			IActionWithResultBtNode.Add_FoldedForTree(builder, _foldedForTree);
			IActionWithResultBtNode.AddType(builder, Type);
			return IActionWithResultBtNode.EndIActionWithResultBtNode(builder);
		}

		// Token: 0x060157A6 RID: 87974 RVA: 0x0031A60B File Offset: 0x0031880B
		public static void StartIActionWithResultBtNode(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x060157A7 RID: 87975 RVA: 0x0031A614 File Offset: 0x00318814
		public static void AddType(FlatBufferBuilder builder, EBtNode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060157A8 RID: 87976 RVA: 0x0031A61F File Offset: 0x0031881F
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x060157A9 RID: 87977 RVA: 0x0031A62A File Offset: 0x0031882A
		public static void AddDesc(FlatBufferBuilder builder, StringOffset descOffset)
		{
			builder.AddOffset(2, descOffset.Value, 0);
		}

		// Token: 0x060157AA RID: 87978 RVA: 0x0031A63A File Offset: 0x0031883A
		public static void AddFixProcessor(FlatBufferBuilder builder, Offset<IFixProcessor> fixProcessorOffset)
		{
			builder.AddOffset(3, fixProcessorOffset.Value, 0);
		}

		// Token: 0x060157AB RID: 87979 RVA: 0x0031A64A File Offset: 0x0031884A
		public static void Add_FoldedForTree(FlatBufferBuilder builder, bool _FoldedForTree)
		{
			builder.AddBool(4, _FoldedForTree, false);
		}

		// Token: 0x060157AC RID: 87980 RVA: 0x0031A655 File Offset: 0x00318855
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(5, disabled, false);
		}

		// Token: 0x060157AD RID: 87981 RVA: 0x0031A660 File Offset: 0x00318860
		public static void AddAction(FlatBufferBuilder builder, Offset<IActionInfo> actionOffset)
		{
			builder.AddOffset(6, actionOffset.Value, 0);
		}

		// Token: 0x060157AE RID: 87982 RVA: 0x0031A670 File Offset: 0x00318870
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x060157AF RID: 87983 RVA: 0x0031A67B File Offset: 0x0031887B
		public static Offset<IActionWithResultBtNode> EndIActionWithResultBtNode(FlatBufferBuilder builder)
		{
			return new Offset<IActionWithResultBtNode>(builder.EndTable());
		}

		// Token: 0x060157B0 RID: 87984 RVA: 0x0031A688 File Offset: 0x00318888
		public IActionWithResultBtNodeT UnPack()
		{
			IActionWithResultBtNodeT actionWithResultBtNodeT = new IActionWithResultBtNodeT();
			this.UnPackTo(actionWithResultBtNodeT);
			return actionWithResultBtNodeT;
		}

		// Token: 0x060157B1 RID: 87985 RVA: 0x0031A6A4 File Offset: 0x003188A4
		public void UnPackTo(IActionWithResultBtNodeT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
			_o.Desc = this.Desc;
			_o.FixProcessor = ((this.FixProcessor != null) ? this.FixProcessor.Value.UnPack() : null);
			_o._FoldedForTree = this._FoldedForTree;
			_o.Disabled = this.Disabled;
			_o.Action = ((this.Action != null) ? this.Action.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060157B2 RID: 87986 RVA: 0x0031A758 File Offset: 0x00318958
		public static Offset<IActionWithResultBtNode> Pack(FlatBufferBuilder builder, IActionWithResultBtNodeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActionWithResultBtNode>);
			}
			StringOffset descOffset = (_o.Desc == null) ? default(StringOffset) : builder.CreateString(_o.Desc);
			Offset<IFixProcessor> fixProcessorOffset = (_o.FixProcessor == null) ? default(Offset<IFixProcessor>) : IFixProcessor.Pack(builder, _o.FixProcessor);
			Offset<IActionInfo> actionOffset = (_o.Action == null) ? default(Offset<IActionInfo>) : IActionInfo.Pack(builder, _o.Action);
			return IActionWithResultBtNode.CreateIActionWithResultBtNode(builder, _o.Type, _o.Id, descOffset, fixProcessorOffset, _o._FoldedForTree, _o.Disabled, actionOffset, _o.NullMask);
		}

		// Token: 0x0400B589 RID: 46473
		private Table __p;
	}
}
