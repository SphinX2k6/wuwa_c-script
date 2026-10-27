using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003DAC RID: 15788
	public struct IConditionBtNode : IFlatbufferObject
	{
		// Token: 0x17006C9E RID: 27806
		// (get) Token: 0x06015F3E RID: 89918 RVA: 0x0032B8B5 File Offset: 0x00329AB5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015F3F RID: 89919 RVA: 0x0032B8C2 File Offset: 0x00329AC2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015F40 RID: 89920 RVA: 0x0032B8CC File Offset: 0x00329ACC
		public static IConditionBtNode GetRootAsIConditionBtNode(ByteBuffer _bb)
		{
			return IConditionBtNode.GetRootAsIConditionBtNode(_bb, default(IConditionBtNode));
		}

		// Token: 0x06015F41 RID: 89921 RVA: 0x0032B8E8 File Offset: 0x00329AE8
		public static IConditionBtNode GetRootAsIConditionBtNode(ByteBuffer _bb, IConditionBtNode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015F42 RID: 89922 RVA: 0x0032B905 File Offset: 0x00329B05
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015F43 RID: 89923 RVA: 0x0032B914 File Offset: 0x00329B14
		public IConditionBtNode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006C9F RID: 27807
		// (get) Token: 0x06015F44 RID: 89924 RVA: 0x0032B924 File Offset: 0x00329B24
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

		// Token: 0x17006CA0 RID: 27808
		// (get) Token: 0x06015F45 RID: 89925 RVA: 0x0032B960 File Offset: 0x00329B60
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

		// Token: 0x17006CA1 RID: 27809
		// (get) Token: 0x06015F46 RID: 89926 RVA: 0x0032B99C File Offset: 0x00329B9C
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

		// Token: 0x06015F47 RID: 89927 RVA: 0x0032B9D3 File Offset: 0x00329BD3
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06015F48 RID: 89928 RVA: 0x0032B9E2 File Offset: 0x00329BE2
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x17006CA2 RID: 27810
		// (get) Token: 0x06015F49 RID: 89929 RVA: 0x0032B9F0 File Offset: 0x00329BF0
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

		// Token: 0x17006CA3 RID: 27811
		// (get) Token: 0x06015F4A RID: 89930 RVA: 0x0032BA50 File Offset: 0x00329C50
		public bool _FoldedForTree
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17006CA4 RID: 27812
		// (get) Token: 0x06015F4B RID: 89931 RVA: 0x0032BA90 File Offset: 0x00329C90
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17006CA5 RID: 27813
		// (get) Token: 0x06015F4C RID: 89932 RVA: 0x0032BAD0 File Offset: 0x00329CD0
		public IConditionGroup? Condition
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17006CA6 RID: 27814
		// (get) Token: 0x06015F4D RID: 89933 RVA: 0x0032BB30 File Offset: 0x00329D30
		public bool WaitUntilTrue
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17006CA7 RID: 27815
		// (get) Token: 0x06015F4E RID: 89934 RVA: 0x0032BB70 File Offset: 0x00329D70
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06015F4F RID: 89935 RVA: 0x0032BBB0 File Offset: 0x00329DB0
		public static Offset<IConditionBtNode> CreateIConditionBtNode(FlatBufferBuilder builder, EBtNode Type = EBtNode.Start, int Id = 0, StringOffset DescOffset = default(StringOffset), Offset<IFixProcessor> FixProcessorOffset = default(Offset<IFixProcessor>), bool _foldedForTree = false, bool Disabled = false, Offset<IConditionGroup> ConditionOffset = default(Offset<IConditionGroup>), bool WaitUntilTrue = false, byte NullMask = 0)
		{
			builder.StartTable(9);
			IConditionBtNode.AddCondition(builder, ConditionOffset);
			IConditionBtNode.AddFixProcessor(builder, FixProcessorOffset);
			IConditionBtNode.AddDesc(builder, DescOffset);
			IConditionBtNode.AddId(builder, Id);
			IConditionBtNode.AddNullMask(builder, NullMask);
			IConditionBtNode.AddWaitUntilTrue(builder, WaitUntilTrue);
			IConditionBtNode.AddDisabled(builder, Disabled);
			IConditionBtNode.Add_FoldedForTree(builder, _foldedForTree);
			IConditionBtNode.AddType(builder, Type);
			return IConditionBtNode.EndIConditionBtNode(builder);
		}

		// Token: 0x06015F50 RID: 89936 RVA: 0x0032BC10 File Offset: 0x00329E10
		public static void StartIConditionBtNode(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x06015F51 RID: 89937 RVA: 0x0032BC1A File Offset: 0x00329E1A
		public static void AddType(FlatBufferBuilder builder, EBtNode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015F52 RID: 89938 RVA: 0x0032BC25 File Offset: 0x00329E25
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x06015F53 RID: 89939 RVA: 0x0032BC30 File Offset: 0x00329E30
		public static void AddDesc(FlatBufferBuilder builder, StringOffset descOffset)
		{
			builder.AddOffset(2, descOffset.Value, 0);
		}

		// Token: 0x06015F54 RID: 89940 RVA: 0x0032BC40 File Offset: 0x00329E40
		public static void AddFixProcessor(FlatBufferBuilder builder, Offset<IFixProcessor> fixProcessorOffset)
		{
			builder.AddOffset(3, fixProcessorOffset.Value, 0);
		}

		// Token: 0x06015F55 RID: 89941 RVA: 0x0032BC50 File Offset: 0x00329E50
		public static void Add_FoldedForTree(FlatBufferBuilder builder, bool _FoldedForTree)
		{
			builder.AddBool(4, _FoldedForTree, false);
		}

		// Token: 0x06015F56 RID: 89942 RVA: 0x0032BC5B File Offset: 0x00329E5B
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(5, disabled, false);
		}

		// Token: 0x06015F57 RID: 89943 RVA: 0x0032BC66 File Offset: 0x00329E66
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(6, conditionOffset.Value, 0);
		}

		// Token: 0x06015F58 RID: 89944 RVA: 0x0032BC76 File Offset: 0x00329E76
		public static void AddWaitUntilTrue(FlatBufferBuilder builder, bool waitUntilTrue)
		{
			builder.AddBool(7, waitUntilTrue, false);
		}

		// Token: 0x06015F59 RID: 89945 RVA: 0x0032BC81 File Offset: 0x00329E81
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x06015F5A RID: 89946 RVA: 0x0032BC8C File Offset: 0x00329E8C
		public static Offset<IConditionBtNode> EndIConditionBtNode(FlatBufferBuilder builder)
		{
			return new Offset<IConditionBtNode>(builder.EndTable());
		}

		// Token: 0x06015F5B RID: 89947 RVA: 0x0032BC9C File Offset: 0x00329E9C
		public IConditionBtNodeT UnPack()
		{
			IConditionBtNodeT conditionBtNodeT = new IConditionBtNodeT();
			this.UnPackTo(conditionBtNodeT);
			return conditionBtNodeT;
		}

		// Token: 0x06015F5C RID: 89948 RVA: 0x0032BCB8 File Offset: 0x00329EB8
		public void UnPackTo(IConditionBtNodeT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
			_o.Desc = this.Desc;
			_o.FixProcessor = ((this.FixProcessor != null) ? this.FixProcessor.Value.UnPack() : null);
			_o._FoldedForTree = this._FoldedForTree;
			_o.Disabled = this.Disabled;
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
			_o.WaitUntilTrue = this.WaitUntilTrue;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06015F5D RID: 89949 RVA: 0x0032BD78 File Offset: 0x00329F78
		public static Offset<IConditionBtNode> Pack(FlatBufferBuilder builder, IConditionBtNodeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IConditionBtNode>);
			}
			StringOffset descOffset = (_o.Desc == null) ? default(StringOffset) : builder.CreateString(_o.Desc);
			Offset<IFixProcessor> fixProcessorOffset = (_o.FixProcessor == null) ? default(Offset<IFixProcessor>) : IFixProcessor.Pack(builder, _o.FixProcessor);
			Offset<IConditionGroup> conditionOffset = (_o.Condition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.Condition);
			return IConditionBtNode.CreateIConditionBtNode(builder, _o.Type, _o.Id, descOffset, fixProcessorOffset, _o._FoldedForTree, _o.Disabled, conditionOffset, _o.WaitUntilTrue, _o.NullMask);
		}

		// Token: 0x0400B6BD RID: 46781
		private Table __p;
	}
}
