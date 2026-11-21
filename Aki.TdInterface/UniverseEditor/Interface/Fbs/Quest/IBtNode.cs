using System;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004151 RID: 16721
	public struct IBtNode : IFlatbufferObject
	{
		// Token: 0x17007138 RID: 28984
		// (get) Token: 0x06016F91 RID: 94097 RVA: 0x00346E99 File Offset: 0x00345099
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016F92 RID: 94098 RVA: 0x00346EA6 File Offset: 0x003450A6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016F93 RID: 94099 RVA: 0x00346EB0 File Offset: 0x003450B0
		public static IBtNode GetRootAsIBtNode(ByteBuffer _bb)
		{
			return IBtNode.GetRootAsIBtNode(_bb, default(IBtNode));
		}

		// Token: 0x06016F94 RID: 94100 RVA: 0x00346ECC File Offset: 0x003450CC
		public static IBtNode GetRootAsIBtNode(ByteBuffer _bb, IBtNode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016F95 RID: 94101 RVA: 0x00346EE9 File Offset: 0x003450E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016F96 RID: 94102 RVA: 0x00346EF8 File Offset: 0x003450F8
		public IBtNode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007139 RID: 28985
		// (get) Token: 0x06016F97 RID: 94103 RVA: 0x00346F08 File Offset: 0x00345108
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

		// Token: 0x1700713A RID: 28986
		// (get) Token: 0x06016F98 RID: 94104 RVA: 0x00346F44 File Offset: 0x00345144
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

		// Token: 0x1700713B RID: 28987
		// (get) Token: 0x06016F99 RID: 94105 RVA: 0x00346F80 File Offset: 0x00345180
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

		// Token: 0x06016F9A RID: 94106 RVA: 0x00346FB7 File Offset: 0x003451B7
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06016F9B RID: 94107 RVA: 0x00346FC6 File Offset: 0x003451C6
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700713C RID: 28988
		// (get) Token: 0x06016F9C RID: 94108 RVA: 0x00346FD4 File Offset: 0x003451D4
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

		// Token: 0x1700713D RID: 28989
		// (get) Token: 0x06016F9D RID: 94109 RVA: 0x00347034 File Offset: 0x00345234
		public bool _FoldedForTree
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700713E RID: 28990
		// (get) Token: 0x06016F9E RID: 94110 RVA: 0x00347074 File Offset: 0x00345274
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700713F RID: 28991
		// (get) Token: 0x06016F9F RID: 94111 RVA: 0x003470B4 File Offset: 0x003452B4
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

		// Token: 0x06016FA0 RID: 94112 RVA: 0x003470F4 File Offset: 0x003452F4
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

		// Token: 0x06016FA1 RID: 94113 RVA: 0x00347143 File Offset: 0x00345343
		public static void StartIBtNode(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06016FA2 RID: 94114 RVA: 0x0034714C File Offset: 0x0034534C
		public static void AddType(FlatBufferBuilder builder, EBtNode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016FA3 RID: 94115 RVA: 0x00347157 File Offset: 0x00345357
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x06016FA4 RID: 94116 RVA: 0x00347162 File Offset: 0x00345362
		public static void AddDesc(FlatBufferBuilder builder, StringOffset descOffset)
		{
			builder.AddOffset(2, descOffset.Value, 0);
		}

		// Token: 0x06016FA5 RID: 94117 RVA: 0x00347172 File Offset: 0x00345372
		public static void AddFixProcessor(FlatBufferBuilder builder, Offset<IFixProcessor> fixProcessorOffset)
		{
			builder.AddOffset(3, fixProcessorOffset.Value, 0);
		}

		// Token: 0x06016FA6 RID: 94118 RVA: 0x00347182 File Offset: 0x00345382
		public static void Add_FoldedForTree(FlatBufferBuilder builder, bool _FoldedForTree)
		{
			builder.AddBool(4, _FoldedForTree, false);
		}

		// Token: 0x06016FA7 RID: 94119 RVA: 0x0034718D File Offset: 0x0034538D
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(5, disabled, false);
		}

		// Token: 0x06016FA8 RID: 94120 RVA: 0x00347198 File Offset: 0x00345398
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06016FA9 RID: 94121 RVA: 0x003471A3 File Offset: 0x003453A3
		public static Offset<IBtNode> EndIBtNode(FlatBufferBuilder builder)
		{
			return new Offset<IBtNode>(builder.EndTable());
		}

		// Token: 0x06016FAA RID: 94122 RVA: 0x003471B0 File Offset: 0x003453B0
		public IBtNodeT UnPack()
		{
			IBtNodeT btNodeT = new IBtNodeT();
			this.UnPackTo(btNodeT);
			return btNodeT;
		}

		// Token: 0x06016FAB RID: 94123 RVA: 0x003471CC File Offset: 0x003453CC
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

		// Token: 0x06016FAC RID: 94124 RVA: 0x00347250 File Offset: 0x00345450
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

		// Token: 0x0400BFA6 RID: 49062
		private Table __p;
	}
}
