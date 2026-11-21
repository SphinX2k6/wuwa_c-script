using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004B07 RID: 19207
	public struct ISkipToInstanceDungeonNode : IFlatbufferObject
	{
		// Token: 0x170086A1 RID: 34465
		// (get) Token: 0x0601CF2A RID: 118570 RVA: 0x00412676 File Offset: 0x00410876
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601CF2B RID: 118571 RVA: 0x00412683 File Offset: 0x00410883
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601CF2C RID: 118572 RVA: 0x0041268C File Offset: 0x0041088C
		public static ISkipToInstanceDungeonNode GetRootAsISkipToInstanceDungeonNode(ByteBuffer _bb)
		{
			return ISkipToInstanceDungeonNode.GetRootAsISkipToInstanceDungeonNode(_bb, default(ISkipToInstanceDungeonNode));
		}

		// Token: 0x0601CF2D RID: 118573 RVA: 0x004126A8 File Offset: 0x004108A8
		public static ISkipToInstanceDungeonNode GetRootAsISkipToInstanceDungeonNode(ByteBuffer _bb, ISkipToInstanceDungeonNode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601CF2E RID: 118574 RVA: 0x004126C5 File Offset: 0x004108C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601CF2F RID: 118575 RVA: 0x004126D4 File Offset: 0x004108D4
		public ISkipToInstanceDungeonNode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170086A2 RID: 34466
		// (get) Token: 0x0601CF30 RID: 118576 RVA: 0x004126E4 File Offset: 0x004108E4
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

		// Token: 0x170086A3 RID: 34467
		// (get) Token: 0x0601CF31 RID: 118577 RVA: 0x00412720 File Offset: 0x00410920
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

		// Token: 0x170086A4 RID: 34468
		// (get) Token: 0x0601CF32 RID: 118578 RVA: 0x0041275C File Offset: 0x0041095C
		public bool IsTeleport
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170086A5 RID: 34469
		// (get) Token: 0x0601CF33 RID: 118579 RVA: 0x0041279C File Offset: 0x0041099C
		public bool IsFastMode
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601CF34 RID: 118580 RVA: 0x004127DC File Offset: 0x004109DC
		public static Offset<ISkipToInstanceDungeonNode> CreateISkipToInstanceDungeonNode(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode, int ChildQuestId = 0, bool IsTeleport = false, bool IsFastMode = false)
		{
			builder.StartTable(4);
			ISkipToInstanceDungeonNode.AddChildQuestId(builder, ChildQuestId);
			ISkipToInstanceDungeonNode.AddIsFastMode(builder, IsFastMode);
			ISkipToInstanceDungeonNode.AddIsTeleport(builder, IsTeleport);
			ISkipToInstanceDungeonNode.AddType(builder, Type);
			return ISkipToInstanceDungeonNode.EndISkipToInstanceDungeonNode(builder);
		}

		// Token: 0x0601CF35 RID: 118581 RVA: 0x00412808 File Offset: 0x00410A08
		public static void StartISkipToInstanceDungeonNode(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601CF36 RID: 118582 RVA: 0x00412811 File Offset: 0x00410A11
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601CF37 RID: 118583 RVA: 0x0041281C File Offset: 0x00410A1C
		public static void AddChildQuestId(FlatBufferBuilder builder, int childQuestId)
		{
			builder.AddInt(1, childQuestId, 0);
		}

		// Token: 0x0601CF38 RID: 118584 RVA: 0x00412827 File Offset: 0x00410A27
		public static void AddIsTeleport(FlatBufferBuilder builder, bool isTeleport)
		{
			builder.AddBool(2, isTeleport, false);
		}

		// Token: 0x0601CF39 RID: 118585 RVA: 0x00412832 File Offset: 0x00410A32
		public static void AddIsFastMode(FlatBufferBuilder builder, bool isFastMode)
		{
			builder.AddBool(3, isFastMode, false);
		}

		// Token: 0x0601CF3A RID: 118586 RVA: 0x0041283D File Offset: 0x00410A3D
		public static Offset<ISkipToInstanceDungeonNode> EndISkipToInstanceDungeonNode(FlatBufferBuilder builder)
		{
			return new Offset<ISkipToInstanceDungeonNode>(builder.EndTable());
		}

		// Token: 0x0601CF3B RID: 118587 RVA: 0x0041284C File Offset: 0x00410A4C
		public ISkipToInstanceDungeonNodeT UnPack()
		{
			ISkipToInstanceDungeonNodeT skipToInstanceDungeonNodeT = new ISkipToInstanceDungeonNodeT();
			this.UnPackTo(skipToInstanceDungeonNodeT);
			return skipToInstanceDungeonNodeT;
		}

		// Token: 0x0601CF3C RID: 118588 RVA: 0x00412867 File Offset: 0x00410A67
		public void UnPackTo(ISkipToInstanceDungeonNodeT _o)
		{
			_o.Type = this.Type;
			_o.ChildQuestId = this.ChildQuestId;
			_o.IsTeleport = this.IsTeleport;
			_o.IsFastMode = this.IsFastMode;
		}

		// Token: 0x0601CF3D RID: 118589 RVA: 0x0041289C File Offset: 0x00410A9C
		public static Offset<ISkipToInstanceDungeonNode> Pack(FlatBufferBuilder builder, ISkipToInstanceDungeonNodeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISkipToInstanceDungeonNode>);
			}
			return ISkipToInstanceDungeonNode.CreateISkipToInstanceDungeonNode(builder, _o.Type, _o.ChildQuestId, _o.IsTeleport, _o.IsFastMode);
		}

		// Token: 0x0400D293 RID: 53907
		private Table __p;
	}
}
