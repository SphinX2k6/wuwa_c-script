using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004B0D RID: 19213
	public struct ISkipToQuestNode : IFlatbufferObject
	{
		// Token: 0x170086B3 RID: 34483
		// (get) Token: 0x0601CF66 RID: 118630 RVA: 0x00412CB4 File Offset: 0x00410EB4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601CF67 RID: 118631 RVA: 0x00412CC1 File Offset: 0x00410EC1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601CF68 RID: 118632 RVA: 0x00412CC8 File Offset: 0x00410EC8
		public static ISkipToQuestNode GetRootAsISkipToQuestNode(ByteBuffer _bb)
		{
			return ISkipToQuestNode.GetRootAsISkipToQuestNode(_bb, default(ISkipToQuestNode));
		}

		// Token: 0x0601CF69 RID: 118633 RVA: 0x00412CE4 File Offset: 0x00410EE4
		public static ISkipToQuestNode GetRootAsISkipToQuestNode(ByteBuffer _bb, ISkipToQuestNode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601CF6A RID: 118634 RVA: 0x00412D01 File Offset: 0x00410F01
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601CF6B RID: 118635 RVA: 0x00412D10 File Offset: 0x00410F10
		public ISkipToQuestNode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170086B4 RID: 34484
		// (get) Token: 0x0601CF6C RID: 118636 RVA: 0x00412D20 File Offset: 0x00410F20
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

		// Token: 0x170086B5 RID: 34485
		// (get) Token: 0x0601CF6D RID: 118637 RVA: 0x00412D5C File Offset: 0x00410F5C
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

		// Token: 0x170086B6 RID: 34486
		// (get) Token: 0x0601CF6E RID: 118638 RVA: 0x00412DBC File Offset: 0x00410FBC
		public bool IsTeleport
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170086B7 RID: 34487
		// (get) Token: 0x0601CF6F RID: 118639 RVA: 0x00412DFC File Offset: 0x00410FFC
		public bool IsFastMode
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601CF70 RID: 118640 RVA: 0x00412E3C File Offset: 0x0041103C
		public static Offset<ISkipToQuestNode> CreateISkipToQuestNode(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode, Offset<IChildQuestCondition> QuestOffset = default(Offset<IChildQuestCondition>), bool IsTeleport = false, bool IsFastMode = false)
		{
			builder.StartTable(4);
			ISkipToQuestNode.AddQuest(builder, QuestOffset);
			ISkipToQuestNode.AddIsFastMode(builder, IsFastMode);
			ISkipToQuestNode.AddIsTeleport(builder, IsTeleport);
			ISkipToQuestNode.AddType(builder, Type);
			return ISkipToQuestNode.EndISkipToQuestNode(builder);
		}

		// Token: 0x0601CF71 RID: 118641 RVA: 0x00412E68 File Offset: 0x00411068
		public static void StartISkipToQuestNode(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601CF72 RID: 118642 RVA: 0x00412E71 File Offset: 0x00411071
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601CF73 RID: 118643 RVA: 0x00412E7C File Offset: 0x0041107C
		public static void AddQuest(FlatBufferBuilder builder, Offset<IChildQuestCondition> questOffset)
		{
			builder.AddOffset(1, questOffset.Value, 0);
		}

		// Token: 0x0601CF74 RID: 118644 RVA: 0x00412E8C File Offset: 0x0041108C
		public static void AddIsTeleport(FlatBufferBuilder builder, bool isTeleport)
		{
			builder.AddBool(2, isTeleport, false);
		}

		// Token: 0x0601CF75 RID: 118645 RVA: 0x00412E97 File Offset: 0x00411097
		public static void AddIsFastMode(FlatBufferBuilder builder, bool isFastMode)
		{
			builder.AddBool(3, isFastMode, false);
		}

		// Token: 0x0601CF76 RID: 118646 RVA: 0x00412EA2 File Offset: 0x004110A2
		public static Offset<ISkipToQuestNode> EndISkipToQuestNode(FlatBufferBuilder builder)
		{
			return new Offset<ISkipToQuestNode>(builder.EndTable());
		}

		// Token: 0x0601CF77 RID: 118647 RVA: 0x00412EB0 File Offset: 0x004110B0
		public ISkipToQuestNodeT UnPack()
		{
			ISkipToQuestNodeT skipToQuestNodeT = new ISkipToQuestNodeT();
			this.UnPackTo(skipToQuestNodeT);
			return skipToQuestNodeT;
		}

		// Token: 0x0601CF78 RID: 118648 RVA: 0x00412ECC File Offset: 0x004110CC
		public void UnPackTo(ISkipToQuestNodeT _o)
		{
			_o.Type = this.Type;
			_o.Quest = ((this.Quest != null) ? this.Quest.Value.UnPack() : null);
			_o.IsTeleport = this.IsTeleport;
			_o.IsFastMode = this.IsFastMode;
		}

		// Token: 0x0601CF79 RID: 118649 RVA: 0x00412F2C File Offset: 0x0041112C
		public static Offset<ISkipToQuestNode> Pack(FlatBufferBuilder builder, ISkipToQuestNodeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISkipToQuestNode>);
			}
			Offset<IChildQuestCondition> questOffset = (_o.Quest == null) ? default(Offset<IChildQuestCondition>) : IChildQuestCondition.Pack(builder, _o.Quest);
			return ISkipToQuestNode.CreateISkipToQuestNode(builder, _o.Type, questOffset, _o.IsTeleport, _o.IsFastMode);
		}

		// Token: 0x0400D29D RID: 53917
		private Table __p;
	}
}
