using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041C3 RID: 16835
	public struct IConditionBtNode : IFlatbufferObject
	{
		// Token: 0x17007258 RID: 29272
		// (get) Token: 0x06017476 RID: 95350 RVA: 0x00352BE1 File Offset: 0x00350DE1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017477 RID: 95351 RVA: 0x00352BEE File Offset: 0x00350DEE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017478 RID: 95352 RVA: 0x00352BF8 File Offset: 0x00350DF8
		public static IConditionBtNode GetRootAsIConditionBtNode(ByteBuffer _bb)
		{
			return IConditionBtNode.GetRootAsIConditionBtNode(_bb, default(IConditionBtNode));
		}

		// Token: 0x06017479 RID: 95353 RVA: 0x00352C14 File Offset: 0x00350E14
		public static IConditionBtNode GetRootAsIConditionBtNode(ByteBuffer _bb, IConditionBtNode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601747A RID: 95354 RVA: 0x00352C31 File Offset: 0x00350E31
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601747B RID: 95355 RVA: 0x00352C40 File Offset: 0x00350E40
		public IConditionBtNode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007259 RID: 29273
		// (get) Token: 0x0601747C RID: 95356 RVA: 0x00352C50 File Offset: 0x00350E50
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

		// Token: 0x1700725A RID: 29274
		// (get) Token: 0x0601747D RID: 95357 RVA: 0x00352C8C File Offset: 0x00350E8C
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

		// Token: 0x1700725B RID: 29275
		// (get) Token: 0x0601747E RID: 95358 RVA: 0x00352CC8 File Offset: 0x00350EC8
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

		// Token: 0x0601747F RID: 95359 RVA: 0x00352CFF File Offset: 0x00350EFF
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06017480 RID: 95360 RVA: 0x00352D0E File Offset: 0x00350F0E
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700725C RID: 29276
		// (get) Token: 0x06017481 RID: 95361 RVA: 0x00352D1C File Offset: 0x00350F1C
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

		// Token: 0x1700725D RID: 29277
		// (get) Token: 0x06017482 RID: 95362 RVA: 0x00352D7C File Offset: 0x00350F7C
		public bool _FoldedForTree
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700725E RID: 29278
		// (get) Token: 0x06017483 RID: 95363 RVA: 0x00352DBC File Offset: 0x00350FBC
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700725F RID: 29279
		// (get) Token: 0x06017484 RID: 95364 RVA: 0x00352DFC File Offset: 0x00350FFC
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

		// Token: 0x17007260 RID: 29280
		// (get) Token: 0x06017485 RID: 95365 RVA: 0x00352E5C File Offset: 0x0035105C
		public bool WaitUntilTrue
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007261 RID: 29281
		// (get) Token: 0x06017486 RID: 95366 RVA: 0x00352E9C File Offset: 0x0035109C
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

		// Token: 0x06017487 RID: 95367 RVA: 0x00352EDC File Offset: 0x003510DC
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

		// Token: 0x06017488 RID: 95368 RVA: 0x00352F3C File Offset: 0x0035113C
		public static void StartIConditionBtNode(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x06017489 RID: 95369 RVA: 0x00352F46 File Offset: 0x00351146
		public static void AddType(FlatBufferBuilder builder, EBtNode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601748A RID: 95370 RVA: 0x00352F51 File Offset: 0x00351151
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x0601748B RID: 95371 RVA: 0x00352F5C File Offset: 0x0035115C
		public static void AddDesc(FlatBufferBuilder builder, StringOffset descOffset)
		{
			builder.AddOffset(2, descOffset.Value, 0);
		}

		// Token: 0x0601748C RID: 95372 RVA: 0x00352F6C File Offset: 0x0035116C
		public static void AddFixProcessor(FlatBufferBuilder builder, Offset<IFixProcessor> fixProcessorOffset)
		{
			builder.AddOffset(3, fixProcessorOffset.Value, 0);
		}

		// Token: 0x0601748D RID: 95373 RVA: 0x00352F7C File Offset: 0x0035117C
		public static void Add_FoldedForTree(FlatBufferBuilder builder, bool _FoldedForTree)
		{
			builder.AddBool(4, _FoldedForTree, false);
		}

		// Token: 0x0601748E RID: 95374 RVA: 0x00352F87 File Offset: 0x00351187
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(5, disabled, false);
		}

		// Token: 0x0601748F RID: 95375 RVA: 0x00352F92 File Offset: 0x00351192
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(6, conditionOffset.Value, 0);
		}

		// Token: 0x06017490 RID: 95376 RVA: 0x00352FA2 File Offset: 0x003511A2
		public static void AddWaitUntilTrue(FlatBufferBuilder builder, bool waitUntilTrue)
		{
			builder.AddBool(7, waitUntilTrue, false);
		}

		// Token: 0x06017491 RID: 95377 RVA: 0x00352FAD File Offset: 0x003511AD
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x06017492 RID: 95378 RVA: 0x00352FB8 File Offset: 0x003511B8
		public static Offset<IConditionBtNode> EndIConditionBtNode(FlatBufferBuilder builder)
		{
			return new Offset<IConditionBtNode>(builder.EndTable());
		}

		// Token: 0x06017493 RID: 95379 RVA: 0x00352FC8 File Offset: 0x003511C8
		public IConditionBtNodeT UnPack()
		{
			IConditionBtNodeT conditionBtNodeT = new IConditionBtNodeT();
			this.UnPackTo(conditionBtNodeT);
			return conditionBtNodeT;
		}

		// Token: 0x06017494 RID: 95380 RVA: 0x00352FE4 File Offset: 0x003511E4
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

		// Token: 0x06017495 RID: 95381 RVA: 0x003530A4 File Offset: 0x003512A4
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

		// Token: 0x0400C06A RID: 49258
		private Table __p;
	}
}
