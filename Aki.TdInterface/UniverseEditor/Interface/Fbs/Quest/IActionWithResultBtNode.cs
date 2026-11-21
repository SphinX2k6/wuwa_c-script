using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004106 RID: 16646
	public struct IActionWithResultBtNode : IFlatbufferObject
	{
		// Token: 0x17007097 RID: 28823
		// (get) Token: 0x06016CCD RID: 93389 RVA: 0x00341572 File Offset: 0x0033F772
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016CCE RID: 93390 RVA: 0x0034157F File Offset: 0x0033F77F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016CCF RID: 93391 RVA: 0x00341588 File Offset: 0x0033F788
		public static IActionWithResultBtNode GetRootAsIActionWithResultBtNode(ByteBuffer _bb)
		{
			return IActionWithResultBtNode.GetRootAsIActionWithResultBtNode(_bb, default(IActionWithResultBtNode));
		}

		// Token: 0x06016CD0 RID: 93392 RVA: 0x003415A4 File Offset: 0x0033F7A4
		public static IActionWithResultBtNode GetRootAsIActionWithResultBtNode(ByteBuffer _bb, IActionWithResultBtNode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016CD1 RID: 93393 RVA: 0x003415C1 File Offset: 0x0033F7C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016CD2 RID: 93394 RVA: 0x003415D0 File Offset: 0x0033F7D0
		public IActionWithResultBtNode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007098 RID: 28824
		// (get) Token: 0x06016CD3 RID: 93395 RVA: 0x003415E0 File Offset: 0x0033F7E0
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

		// Token: 0x17007099 RID: 28825
		// (get) Token: 0x06016CD4 RID: 93396 RVA: 0x0034161C File Offset: 0x0033F81C
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

		// Token: 0x1700709A RID: 28826
		// (get) Token: 0x06016CD5 RID: 93397 RVA: 0x00341658 File Offset: 0x0033F858
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

		// Token: 0x06016CD6 RID: 93398 RVA: 0x0034168F File Offset: 0x0033F88F
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06016CD7 RID: 93399 RVA: 0x0034169E File Offset: 0x0033F89E
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700709B RID: 28827
		// (get) Token: 0x06016CD8 RID: 93400 RVA: 0x003416AC File Offset: 0x0033F8AC
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

		// Token: 0x1700709C RID: 28828
		// (get) Token: 0x06016CD9 RID: 93401 RVA: 0x0034170C File Offset: 0x0033F90C
		public bool _FoldedForTree
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700709D RID: 28829
		// (get) Token: 0x06016CDA RID: 93402 RVA: 0x0034174C File Offset: 0x0033F94C
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700709E RID: 28830
		// (get) Token: 0x06016CDB RID: 93403 RVA: 0x0034178C File Offset: 0x0033F98C
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

		// Token: 0x1700709F RID: 28831
		// (get) Token: 0x06016CDC RID: 93404 RVA: 0x003417EC File Offset: 0x0033F9EC
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

		// Token: 0x06016CDD RID: 93405 RVA: 0x0034182C File Offset: 0x0033FA2C
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

		// Token: 0x06016CDE RID: 93406 RVA: 0x00341883 File Offset: 0x0033FA83
		public static void StartIActionWithResultBtNode(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x06016CDF RID: 93407 RVA: 0x0034188C File Offset: 0x0033FA8C
		public static void AddType(FlatBufferBuilder builder, EBtNode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016CE0 RID: 93408 RVA: 0x00341897 File Offset: 0x0033FA97
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x06016CE1 RID: 93409 RVA: 0x003418A2 File Offset: 0x0033FAA2
		public static void AddDesc(FlatBufferBuilder builder, StringOffset descOffset)
		{
			builder.AddOffset(2, descOffset.Value, 0);
		}

		// Token: 0x06016CE2 RID: 93410 RVA: 0x003418B2 File Offset: 0x0033FAB2
		public static void AddFixProcessor(FlatBufferBuilder builder, Offset<IFixProcessor> fixProcessorOffset)
		{
			builder.AddOffset(3, fixProcessorOffset.Value, 0);
		}

		// Token: 0x06016CE3 RID: 93411 RVA: 0x003418C2 File Offset: 0x0033FAC2
		public static void Add_FoldedForTree(FlatBufferBuilder builder, bool _FoldedForTree)
		{
			builder.AddBool(4, _FoldedForTree, false);
		}

		// Token: 0x06016CE4 RID: 93412 RVA: 0x003418CD File Offset: 0x0033FACD
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(5, disabled, false);
		}

		// Token: 0x06016CE5 RID: 93413 RVA: 0x003418D8 File Offset: 0x0033FAD8
		public static void AddAction(FlatBufferBuilder builder, Offset<IActionInfo> actionOffset)
		{
			builder.AddOffset(6, actionOffset.Value, 0);
		}

		// Token: 0x06016CE6 RID: 93414 RVA: 0x003418E8 File Offset: 0x0033FAE8
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x06016CE7 RID: 93415 RVA: 0x003418F3 File Offset: 0x0033FAF3
		public static Offset<IActionWithResultBtNode> EndIActionWithResultBtNode(FlatBufferBuilder builder)
		{
			return new Offset<IActionWithResultBtNode>(builder.EndTable());
		}

		// Token: 0x06016CE8 RID: 93416 RVA: 0x00341900 File Offset: 0x0033FB00
		public IActionWithResultBtNodeT UnPack()
		{
			IActionWithResultBtNodeT actionWithResultBtNodeT = new IActionWithResultBtNodeT();
			this.UnPackTo(actionWithResultBtNodeT);
			return actionWithResultBtNodeT;
		}

		// Token: 0x06016CE9 RID: 93417 RVA: 0x0034191C File Offset: 0x0033FB1C
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

		// Token: 0x06016CEA RID: 93418 RVA: 0x003419D0 File Offset: 0x0033FBD0
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

		// Token: 0x0400BF36 RID: 48950
		private Table __p;
	}
}
