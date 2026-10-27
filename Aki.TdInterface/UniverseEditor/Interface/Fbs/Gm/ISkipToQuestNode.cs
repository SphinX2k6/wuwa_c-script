using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x020046A5 RID: 18085
	public struct ISkipToQuestNode : IFlatbufferObject
	{
		// Token: 0x17008072 RID: 32882
		// (get) Token: 0x0601B791 RID: 112529 RVA: 0x003E6A18 File Offset: 0x003E4C18
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B792 RID: 112530 RVA: 0x003E6A25 File Offset: 0x003E4C25
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B793 RID: 112531 RVA: 0x003E6A2C File Offset: 0x003E4C2C
		public static ISkipToQuestNode GetRootAsISkipToQuestNode(ByteBuffer _bb)
		{
			return ISkipToQuestNode.GetRootAsISkipToQuestNode(_bb, default(ISkipToQuestNode));
		}

		// Token: 0x0601B794 RID: 112532 RVA: 0x003E6A48 File Offset: 0x003E4C48
		public static ISkipToQuestNode GetRootAsISkipToQuestNode(ByteBuffer _bb, ISkipToQuestNode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B795 RID: 112533 RVA: 0x003E6A65 File Offset: 0x003E4C65
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B796 RID: 112534 RVA: 0x003E6A74 File Offset: 0x003E4C74
		public ISkipToQuestNode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008073 RID: 32883
		// (get) Token: 0x0601B797 RID: 112535 RVA: 0x003E6A84 File Offset: 0x003E4C84
		public EGmCommand Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGmCommand.SkipToLevelPlayNode;
				}
				return (EGmCommand)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008074 RID: 32884
		// (get) Token: 0x0601B798 RID: 112536 RVA: 0x003E6AC0 File Offset: 0x003E4CC0
		public IChildQuestCondition? Quest
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IChildQuestCondition?(default(IChildQuestCondition).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17008075 RID: 32885
		// (get) Token: 0x0601B799 RID: 112537 RVA: 0x003E6B20 File Offset: 0x003E4D20
		public bool IsTeleport
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008076 RID: 32886
		// (get) Token: 0x0601B79A RID: 112538 RVA: 0x003E6B60 File Offset: 0x003E4D60
		public bool IsFastMode
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601B79B RID: 112539 RVA: 0x003E6BA0 File Offset: 0x003E4DA0
		public static Offset<ISkipToQuestNode> CreateISkipToQuestNode(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode, Offset<IChildQuestCondition> QuestOffset = default(Offset<IChildQuestCondition>), bool IsTeleport = false, bool IsFastMode = false)
		{
			builder.StartTable(4);
			ISkipToQuestNode.AddQuest(builder, QuestOffset);
			ISkipToQuestNode.AddIsFastMode(builder, IsFastMode);
			ISkipToQuestNode.AddIsTeleport(builder, IsTeleport);
			ISkipToQuestNode.AddType(builder, Type);
			return ISkipToQuestNode.EndISkipToQuestNode(builder);
		}

		// Token: 0x0601B79C RID: 112540 RVA: 0x003E6BCC File Offset: 0x003E4DCC
		public static void StartISkipToQuestNode(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601B79D RID: 112541 RVA: 0x003E6BD5 File Offset: 0x003E4DD5
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B79E RID: 112542 RVA: 0x003E6BE0 File Offset: 0x003E4DE0
		public static void AddQuest(FlatBufferBuilder builder, Offset<IChildQuestCondition> questOffset)
		{
			builder.AddOffset(1, questOffset.Value, 0);
		}

		// Token: 0x0601B79F RID: 112543 RVA: 0x003E6BF0 File Offset: 0x003E4DF0
		public static void AddIsTeleport(FlatBufferBuilder builder, bool isTeleport)
		{
			builder.AddBool(2, isTeleport, false);
		}

		// Token: 0x0601B7A0 RID: 112544 RVA: 0x003E6BFB File Offset: 0x003E4DFB
		public static void AddIsFastMode(FlatBufferBuilder builder, bool isFastMode)
		{
			builder.AddBool(3, isFastMode, false);
		}

		// Token: 0x0601B7A1 RID: 112545 RVA: 0x003E6C06 File Offset: 0x003E4E06
		public static Offset<ISkipToQuestNode> EndISkipToQuestNode(FlatBufferBuilder builder)
		{
			return new Offset<ISkipToQuestNode>(builder.EndTable());
		}

		// Token: 0x0601B7A2 RID: 112546 RVA: 0x003E6C14 File Offset: 0x003E4E14
		public ISkipToQuestNodeT UnPack()
		{
			ISkipToQuestNodeT skipToQuestNodeT = new ISkipToQuestNodeT();
			this.UnPackTo(skipToQuestNodeT);
			return skipToQuestNodeT;
		}

		// Token: 0x0601B7A3 RID: 112547 RVA: 0x003E6C30 File Offset: 0x003E4E30
		public void UnPackTo(ISkipToQuestNodeT _o)
		{
			_o.Type = this.Type;
			_o.Quest = ((this.Quest != null) ? this.Quest.Value.UnPack() : null);
			_o.IsTeleport = this.IsTeleport;
			_o.IsFastMode = this.IsFastMode;
		}

		// Token: 0x0601B7A4 RID: 112548 RVA: 0x003E6C90 File Offset: 0x003E4E90
		public static Offset<ISkipToQuestNode> Pack(FlatBufferBuilder builder, ISkipToQuestNodeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISkipToQuestNode>);
			}
			Offset<IChildQuestCondition> questOffset = (_o.Quest == null) ? default(Offset<IChildQuestCondition>) : IChildQuestCondition.Pack(builder, _o.Quest);
			return ISkipToQuestNode.CreateISkipToQuestNode(builder, _o.Type, questOffset, _o.IsTeleport, _o.IsFastMode);
		}

		// Token: 0x0400C86E RID: 51310
		private Table __p;
	}
}
