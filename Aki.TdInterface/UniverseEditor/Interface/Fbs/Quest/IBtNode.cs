using System;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D3A RID: 15674
	public struct IBtNode : IFlatbufferObject
	{
		// Token: 0x17006B7E RID: 27518
		// (get) Token: 0x06015A59 RID: 88665 RVA: 0x0031FC21 File Offset: 0x0031DE21
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015A5A RID: 88666 RVA: 0x0031FC2E File Offset: 0x0031DE2E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015A5B RID: 88667 RVA: 0x0031FC38 File Offset: 0x0031DE38
		public static IBtNode GetRootAsIBtNode(ByteBuffer _bb)
		{
			return IBtNode.GetRootAsIBtNode(_bb, default(IBtNode));
		}

		// Token: 0x06015A5C RID: 88668 RVA: 0x0031FC54 File Offset: 0x0031DE54
		public static IBtNode GetRootAsIBtNode(ByteBuffer _bb, IBtNode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015A5D RID: 88669 RVA: 0x0031FC71 File Offset: 0x0031DE71
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015A5E RID: 88670 RVA: 0x0031FC80 File Offset: 0x0031DE80
		public IBtNode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006B7F RID: 27519
		// (get) Token: 0x06015A5F RID: 88671 RVA: 0x0031FC90 File Offset: 0x0031DE90
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

		// Token: 0x17006B80 RID: 27520
		// (get) Token: 0x06015A60 RID: 88672 RVA: 0x0031FCCC File Offset: 0x0031DECC
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

		// Token: 0x17006B81 RID: 27521
		// (get) Token: 0x06015A61 RID: 88673 RVA: 0x0031FD08 File Offset: 0x0031DF08
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

		// Token: 0x06015A62 RID: 88674 RVA: 0x0031FD3F File Offset: 0x0031DF3F
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06015A63 RID: 88675 RVA: 0x0031FD4E File Offset: 0x0031DF4E
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x17006B82 RID: 27522
		// (get) Token: 0x06015A64 RID: 88676 RVA: 0x0031FD5C File Offset: 0x0031DF5C
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

		// Token: 0x17006B83 RID: 27523
		// (get) Token: 0x06015A65 RID: 88677 RVA: 0x0031FDBC File Offset: 0x0031DFBC
		public bool _FoldedForTree
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17006B84 RID: 27524
		// (get) Token: 0x06015A66 RID: 88678 RVA: 0x0031FDFC File Offset: 0x0031DFFC
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17006B85 RID: 27525
		// (get) Token: 0x06015A67 RID: 88679 RVA: 0x0031FE3C File Offset: 0x0031E03C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06015A68 RID: 88680 RVA: 0x0031FE7C File Offset: 0x0031E07C
		public static Offset<IBtNode> CreateIBtNode(FlatBufferBuilder builder, EBtNode Type = EBtNode.Start, int Id = 0, StringOffset DescOffset = default(StringOffset), Offset<IFixProcessor> FixProcessorOffset = default(Offset<IFixProcessor>), bool _foldedForTree = false, bool Disabled = false, byte NullMask = 0)
		{
			builder.StartTable(7);
			IBtNode.AddFixProcessor(builder, FixProcessorOffset);
			IBtNode.AddDesc(builder, DescOffset);
			IBtNode.AddId(builder, Id);
			IBtNode.AddNullMask(builder, NullMask);
			IBtNode.AddDisabled(builder, Disabled);
			IBtNode.Add_FoldedForTree(builder, _foldedForTree);
			IBtNode.AddType(builder, Type);
			return IBtNode.EndIBtNode(builder);
		}

		// Token: 0x06015A69 RID: 88681 RVA: 0x0031FECB File Offset: 0x0031E0CB
		public static void StartIBtNode(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06015A6A RID: 88682 RVA: 0x0031FED4 File Offset: 0x0031E0D4
		public static void AddType(FlatBufferBuilder builder, EBtNode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015A6B RID: 88683 RVA: 0x0031FEDF File Offset: 0x0031E0DF
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x06015A6C RID: 88684 RVA: 0x0031FEEA File Offset: 0x0031E0EA
		public static void AddDesc(FlatBufferBuilder builder, StringOffset descOffset)
		{
			builder.AddOffset(2, descOffset.Value, 0);
		}

		// Token: 0x06015A6D RID: 88685 RVA: 0x0031FEFA File Offset: 0x0031E0FA
		public static void AddFixProcessor(FlatBufferBuilder builder, Offset<IFixProcessor> fixProcessorOffset)
		{
			builder.AddOffset(3, fixProcessorOffset.Value, 0);
		}

		// Token: 0x06015A6E RID: 88686 RVA: 0x0031FF0A File Offset: 0x0031E10A
		public static void Add_FoldedForTree(FlatBufferBuilder builder, bool _FoldedForTree)
		{
			builder.AddBool(4, _FoldedForTree, false);
		}

		// Token: 0x06015A6F RID: 88687 RVA: 0x0031FF15 File Offset: 0x0031E115
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(5, disabled, false);
		}

		// Token: 0x06015A70 RID: 88688 RVA: 0x0031FF20 File Offset: 0x0031E120
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06015A71 RID: 88689 RVA: 0x0031FF2B File Offset: 0x0031E12B
		public static Offset<IBtNode> EndIBtNode(FlatBufferBuilder builder)
		{
			return new Offset<IBtNode>(builder.EndTable());
		}

		// Token: 0x06015A72 RID: 88690 RVA: 0x0031FF38 File Offset: 0x0031E138
		public IBtNodeT UnPack()
		{
			IBtNodeT btNodeT = new IBtNodeT();
			this.UnPackTo(btNodeT);
			return btNodeT;
		}

		// Token: 0x06015A73 RID: 88691 RVA: 0x0031FF54 File Offset: 0x0031E154
		public void UnPackTo(IBtNodeT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
			_o.Desc = this.Desc;
			_o.FixProcessor = ((this.FixProcessor != null) ? this.FixProcessor.Value.UnPack() : null);
			_o._FoldedForTree = this._FoldedForTree;
			_o.Disabled = this.Disabled;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06015A74 RID: 88692 RVA: 0x0031FFD8 File Offset: 0x0031E1D8
		public static Offset<IBtNode> Pack(FlatBufferBuilder builder, IBtNodeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBtNode>);
			}
			StringOffset descOffset = (_o.Desc == null) ? default(StringOffset) : builder.CreateString(_o.Desc);
			Offset<IFixProcessor> fixProcessorOffset = (_o.FixProcessor == null) ? default(Offset<IFixProcessor>) : IFixProcessor.Pack(builder, _o.FixProcessor);
			return IBtNode.CreateIBtNode(builder, _o.Type, _o.Id, descOffset, fixProcessorOffset, _o._FoldedForTree, _o.Disabled, _o.NullMask);
		}

		// Token: 0x0400B5F9 RID: 46585
		private Table __p;
	}
}
