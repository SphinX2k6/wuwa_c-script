using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x0200469F RID: 18079
	public struct ISkipToInstanceDungeonNode : IFlatbufferObject
	{
		// Token: 0x17008060 RID: 32864
		// (get) Token: 0x0601B755 RID: 112469 RVA: 0x003E63DA File Offset: 0x003E45DA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B756 RID: 112470 RVA: 0x003E63E7 File Offset: 0x003E45E7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B757 RID: 112471 RVA: 0x003E63F0 File Offset: 0x003E45F0
		public static ISkipToInstanceDungeonNode GetRootAsISkipToInstanceDungeonNode(ByteBuffer _bb)
		{
			return ISkipToInstanceDungeonNode.GetRootAsISkipToInstanceDungeonNode(_bb, default(ISkipToInstanceDungeonNode));
		}

		// Token: 0x0601B758 RID: 112472 RVA: 0x003E640C File Offset: 0x003E460C
		public static ISkipToInstanceDungeonNode GetRootAsISkipToInstanceDungeonNode(ByteBuffer _bb, ISkipToInstanceDungeonNode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B759 RID: 112473 RVA: 0x003E6429 File Offset: 0x003E4629
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B75A RID: 112474 RVA: 0x003E6438 File Offset: 0x003E4638
		public ISkipToInstanceDungeonNode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008061 RID: 32865
		// (get) Token: 0x0601B75B RID: 112475 RVA: 0x003E6448 File Offset: 0x003E4648
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

		// Token: 0x17008062 RID: 32866
		// (get) Token: 0x0601B75C RID: 112476 RVA: 0x003E6484 File Offset: 0x003E4684
		public int ChildQuestId
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

		// Token: 0x17008063 RID: 32867
		// (get) Token: 0x0601B75D RID: 112477 RVA: 0x003E64C0 File Offset: 0x003E46C0
		public bool IsTeleport
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008064 RID: 32868
		// (get) Token: 0x0601B75E RID: 112478 RVA: 0x003E6500 File Offset: 0x003E4700
		public bool IsFastMode
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601B75F RID: 112479 RVA: 0x003E6540 File Offset: 0x003E4740
		public static Offset<ISkipToInstanceDungeonNode> CreateISkipToInstanceDungeonNode(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode, int ChildQuestId = 0, bool IsTeleport = false, bool IsFastMode = false)
		{
			builder.StartTable(4);
			ISkipToInstanceDungeonNode.AddChildQuestId(builder, ChildQuestId);
			ISkipToInstanceDungeonNode.AddIsFastMode(builder, IsFastMode);
			ISkipToInstanceDungeonNode.AddIsTeleport(builder, IsTeleport);
			ISkipToInstanceDungeonNode.AddType(builder, Type);
			return ISkipToInstanceDungeonNode.EndISkipToInstanceDungeonNode(builder);
		}

		// Token: 0x0601B760 RID: 112480 RVA: 0x003E656C File Offset: 0x003E476C
		public static void StartISkipToInstanceDungeonNode(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601B761 RID: 112481 RVA: 0x003E6575 File Offset: 0x003E4775
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B762 RID: 112482 RVA: 0x003E6580 File Offset: 0x003E4780
		public static void AddChildQuestId(FlatBufferBuilder builder, int childQuestId)
		{
			builder.AddInt(1, childQuestId, 0);
		}

		// Token: 0x0601B763 RID: 112483 RVA: 0x003E658B File Offset: 0x003E478B
		public static void AddIsTeleport(FlatBufferBuilder builder, bool isTeleport)
		{
			builder.AddBool(2, isTeleport, false);
		}

		// Token: 0x0601B764 RID: 112484 RVA: 0x003E6596 File Offset: 0x003E4796
		public static void AddIsFastMode(FlatBufferBuilder builder, bool isFastMode)
		{
			builder.AddBool(3, isFastMode, false);
		}

		// Token: 0x0601B765 RID: 112485 RVA: 0x003E65A1 File Offset: 0x003E47A1
		public static Offset<ISkipToInstanceDungeonNode> EndISkipToInstanceDungeonNode(FlatBufferBuilder builder)
		{
			return new Offset<ISkipToInstanceDungeonNode>(builder.EndTable());
		}

		// Token: 0x0601B766 RID: 112486 RVA: 0x003E65B0 File Offset: 0x003E47B0
		public ISkipToInstanceDungeonNodeT UnPack()
		{
			ISkipToInstanceDungeonNodeT skipToInstanceDungeonNodeT = new ISkipToInstanceDungeonNodeT();
			this.UnPackTo(skipToInstanceDungeonNodeT);
			return skipToInstanceDungeonNodeT;
		}

		// Token: 0x0601B767 RID: 112487 RVA: 0x003E65CB File Offset: 0x003E47CB
		public void UnPackTo(ISkipToInstanceDungeonNodeT _o)
		{
			_o.Type = this.Type;
			_o.ChildQuestId = this.ChildQuestId;
			_o.IsTeleport = this.IsTeleport;
			_o.IsFastMode = this.IsFastMode;
		}

		// Token: 0x0601B768 RID: 112488 RVA: 0x003E6600 File Offset: 0x003E4800
		public static Offset<ISkipToInstanceDungeonNode> Pack(FlatBufferBuilder builder, ISkipToInstanceDungeonNodeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISkipToInstanceDungeonNode>);
			}
			return ISkipToInstanceDungeonNode.CreateISkipToInstanceDungeonNode(builder, _o.Type, _o.ChildQuestId, _o.IsTeleport, _o.IsFastMode);
		}

		// Token: 0x0400C864 RID: 51300
		private Table __p;
	}
}
