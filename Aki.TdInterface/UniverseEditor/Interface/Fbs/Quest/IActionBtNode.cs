using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003CEC RID: 15596
	public struct IActionBtNode : IFlatbufferObject
	{
		// Token: 0x17006ACC RID: 27340
		// (get) Token: 0x0601575F RID: 87903 RVA: 0x00319B32 File Offset: 0x00317D32
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015760 RID: 87904 RVA: 0x00319B3F File Offset: 0x00317D3F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015761 RID: 87905 RVA: 0x00319B48 File Offset: 0x00317D48
		public static IActionBtNode GetRootAsIActionBtNode(ByteBuffer _bb)
		{
			return IActionBtNode.GetRootAsIActionBtNode(_bb, default(IActionBtNode));
		}

		// Token: 0x06015762 RID: 87906 RVA: 0x00319B64 File Offset: 0x00317D64
		public static IActionBtNode GetRootAsIActionBtNode(ByteBuffer _bb, IActionBtNode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015763 RID: 87907 RVA: 0x00319B81 File Offset: 0x00317D81
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015764 RID: 87908 RVA: 0x00319B90 File Offset: 0x00317D90
		public IActionBtNode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006ACD RID: 27341
		// (get) Token: 0x06015765 RID: 87909 RVA: 0x00319BA0 File Offset: 0x00317DA0
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

		// Token: 0x17006ACE RID: 27342
		// (get) Token: 0x06015766 RID: 87910 RVA: 0x00319BDC File Offset: 0x00317DDC
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

		// Token: 0x17006ACF RID: 27343
		// (get) Token: 0x06015767 RID: 87911 RVA: 0x00319C18 File Offset: 0x00317E18
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

		// Token: 0x06015768 RID: 87912 RVA: 0x00319C4F File Offset: 0x00317E4F
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06015769 RID: 87913 RVA: 0x00319C5E File Offset: 0x00317E5E
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x17006AD0 RID: 27344
		// (get) Token: 0x0601576A RID: 87914 RVA: 0x00319C6C File Offset: 0x00317E6C
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

		// Token: 0x17006AD1 RID: 27345
		// (get) Token: 0x0601576B RID: 87915 RVA: 0x00319CCC File Offset: 0x00317ECC
		public bool _FoldedForTree
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17006AD2 RID: 27346
		// (get) Token: 0x0601576C RID: 87916 RVA: 0x00319D0C File Offset: 0x00317F0C
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601576D RID: 87917 RVA: 0x00319D4C File Offset: 0x00317F4C
		public IActionInfo? Actions(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17006AD3 RID: 27347
		// (get) Token: 0x0601576E RID: 87918 RVA: 0x00319DB0 File Offset: 0x00317FB0
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

		// Token: 0x17006AD4 RID: 27348
		// (get) Token: 0x0601576F RID: 87919 RVA: 0x00319DDC File Offset: 0x00317FDC
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

		// Token: 0x06015770 RID: 87920 RVA: 0x00319E1C File Offset: 0x0031801C
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

		// Token: 0x06015771 RID: 87921 RVA: 0x00319E73 File Offset: 0x00318073
		public static void StartIActionBtNode(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x06015772 RID: 87922 RVA: 0x00319E7C File Offset: 0x0031807C
		public static void AddType(FlatBufferBuilder builder, EBtNode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015773 RID: 87923 RVA: 0x00319E87 File Offset: 0x00318087
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x06015774 RID: 87924 RVA: 0x00319E92 File Offset: 0x00318092
		public static void AddDesc(FlatBufferBuilder builder, StringOffset descOffset)
		{
			builder.AddOffset(2, descOffset.Value, 0);
		}

		// Token: 0x06015775 RID: 87925 RVA: 0x00319EA2 File Offset: 0x003180A2
		public static void AddFixProcessor(FlatBufferBuilder builder, Offset<IFixProcessor> fixProcessorOffset)
		{
			builder.AddOffset(3, fixProcessorOffset.Value, 0);
		}

		// Token: 0x06015776 RID: 87926 RVA: 0x00319EB2 File Offset: 0x003180B2
		public static void Add_FoldedForTree(FlatBufferBuilder builder, bool _FoldedForTree)
		{
			builder.AddBool(4, _FoldedForTree, false);
		}

		// Token: 0x06015777 RID: 87927 RVA: 0x00319EBD File Offset: 0x003180BD
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(5, disabled, false);
		}

		// Token: 0x06015778 RID: 87928 RVA: 0x00319EC8 File Offset: 0x003180C8
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(6, actionsOffset.Value, 0);
		}

		// Token: 0x06015779 RID: 87929 RVA: 0x00319ED8 File Offset: 0x003180D8
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601577A RID: 87930 RVA: 0x00319F18 File Offset: 0x00318118
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601577B RID: 87931 RVA: 0x00319F32 File Offset: 0x00318132
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601577C RID: 87932 RVA: 0x00319F50 File Offset: 0x00318150
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601577D RID: 87933 RVA: 0x00319F69 File Offset: 0x00318169
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601577E RID: 87934 RVA: 0x00319F74 File Offset: 0x00318174
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x0601577F RID: 87935 RVA: 0x00319F7F File Offset: 0x0031817F
		public static Offset<IActionBtNode> EndIActionBtNode(FlatBufferBuilder builder)
		{
			return new Offset<IActionBtNode>(builder.EndTable());
		}

		// Token: 0x06015780 RID: 87936 RVA: 0x00319F8C File Offset: 0x0031818C
		public IActionBtNodeT UnPack()
		{
			IActionBtNodeT actionBtNodeT = new IActionBtNodeT();
			this.UnPackTo(actionBtNodeT);
			return actionBtNodeT;
		}

		// Token: 0x06015781 RID: 87937 RVA: 0x00319FA8 File Offset: 0x003181A8
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

		// Token: 0x06015782 RID: 87938 RVA: 0x0031A080 File Offset: 0x00318280
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

		// Token: 0x0400B580 RID: 46464
		private Table __p;
	}
}
