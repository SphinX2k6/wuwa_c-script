using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004B0A RID: 19210
	public struct ISkipToLevelPlayNode : IFlatbufferObject
	{
		// Token: 0x170086AA RID: 34474
		// (get) Token: 0x0601CF48 RID: 118600 RVA: 0x00412998 File Offset: 0x00410B98
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601CF49 RID: 118601 RVA: 0x004129A5 File Offset: 0x00410BA5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601CF4A RID: 118602 RVA: 0x004129AC File Offset: 0x00410BAC
		public static ISkipToLevelPlayNode GetRootAsISkipToLevelPlayNode(ByteBuffer _bb)
		{
			return ISkipToLevelPlayNode.GetRootAsISkipToLevelPlayNode(_bb, default(ISkipToLevelPlayNode));
		}

		// Token: 0x0601CF4B RID: 118603 RVA: 0x004129C8 File Offset: 0x00410BC8
		public static ISkipToLevelPlayNode GetRootAsISkipToLevelPlayNode(ByteBuffer _bb, ISkipToLevelPlayNode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601CF4C RID: 118604 RVA: 0x004129E5 File Offset: 0x00410BE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601CF4D RID: 118605 RVA: 0x004129F4 File Offset: 0x00410BF4
		public ISkipToLevelPlayNode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170086AB RID: 34475
		// (get) Token: 0x0601CF4E RID: 118606 RVA: 0x00412A04 File Offset: 0x00410C04
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

		// Token: 0x170086AC RID: 34476
		// (get) Token: 0x0601CF4F RID: 118607 RVA: 0x00412A40 File Offset: 0x00410C40
		public int LevelPlayId
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

		// Token: 0x170086AD RID: 34477
		// (get) Token: 0x0601CF50 RID: 118608 RVA: 0x00412A7C File Offset: 0x00410C7C
		public int ChildQuestId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170086AE RID: 34478
		// (get) Token: 0x0601CF51 RID: 118609 RVA: 0x00412AB8 File Offset: 0x00410CB8
		public bool IsTeleport
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601CF52 RID: 118610 RVA: 0x00412AF8 File Offset: 0x00410CF8
		public static Offset<ISkipToLevelPlayNode> CreateISkipToLevelPlayNode(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode, int LevelPlayId = 0, int ChildQuestId = 0, bool IsTeleport = false)
		{
			builder.StartTable(4);
			ISkipToLevelPlayNode.AddChildQuestId(builder, ChildQuestId);
			ISkipToLevelPlayNode.AddLevelPlayId(builder, LevelPlayId);
			ISkipToLevelPlayNode.AddIsTeleport(builder, IsTeleport);
			ISkipToLevelPlayNode.AddType(builder, Type);
			return ISkipToLevelPlayNode.EndISkipToLevelPlayNode(builder);
		}

		// Token: 0x0601CF53 RID: 118611 RVA: 0x00412B24 File Offset: 0x00410D24
		public static void StartISkipToLevelPlayNode(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601CF54 RID: 118612 RVA: 0x00412B2D File Offset: 0x00410D2D
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601CF55 RID: 118613 RVA: 0x00412B38 File Offset: 0x00410D38
		public static void AddLevelPlayId(FlatBufferBuilder builder, int levelPlayId)
		{
			builder.AddInt(1, levelPlayId, 0);
		}

		// Token: 0x0601CF56 RID: 118614 RVA: 0x00412B43 File Offset: 0x00410D43
		public static void AddChildQuestId(FlatBufferBuilder builder, int childQuestId)
		{
			builder.AddInt(2, childQuestId, 0);
		}

		// Token: 0x0601CF57 RID: 118615 RVA: 0x00412B4E File Offset: 0x00410D4E
		public static void AddIsTeleport(FlatBufferBuilder builder, bool isTeleport)
		{
			builder.AddBool(3, isTeleport, false);
		}

		// Token: 0x0601CF58 RID: 118616 RVA: 0x00412B59 File Offset: 0x00410D59
		public static Offset<ISkipToLevelPlayNode> EndISkipToLevelPlayNode(FlatBufferBuilder builder)
		{
			return new Offset<ISkipToLevelPlayNode>(builder.EndTable());
		}

		// Token: 0x0601CF59 RID: 118617 RVA: 0x00412B68 File Offset: 0x00410D68
		public ISkipToLevelPlayNodeT UnPack()
		{
			ISkipToLevelPlayNodeT skipToLevelPlayNodeT = new ISkipToLevelPlayNodeT();
			this.UnPackTo(skipToLevelPlayNodeT);
			return skipToLevelPlayNodeT;
		}

		// Token: 0x0601CF5A RID: 118618 RVA: 0x00412B83 File Offset: 0x00410D83
		public void UnPackTo(ISkipToLevelPlayNodeT _o)
		{
			_o.Type = this.Type;
			_o.LevelPlayId = this.LevelPlayId;
			_o.ChildQuestId = this.ChildQuestId;
			_o.IsTeleport = this.IsTeleport;
		}

		// Token: 0x0601CF5B RID: 118619 RVA: 0x00412BB8 File Offset: 0x00410DB8
		public static Offset<ISkipToLevelPlayNode> Pack(FlatBufferBuilder builder, ISkipToLevelPlayNodeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISkipToLevelPlayNode>);
			}
			return ISkipToLevelPlayNode.CreateISkipToLevelPlayNode(builder, _o.Type, _o.LevelPlayId, _o.ChildQuestId, _o.IsTeleport);
		}

		// Token: 0x0400D298 RID: 53912
		private Table __p;
	}
}
