using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x020046A2 RID: 18082
	public struct ISkipToLevelPlayNode : IFlatbufferObject
	{
		// Token: 0x17008069 RID: 32873
		// (get) Token: 0x0601B773 RID: 112499 RVA: 0x003E66FC File Offset: 0x003E48FC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B774 RID: 112500 RVA: 0x003E6709 File Offset: 0x003E4909
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B775 RID: 112501 RVA: 0x003E6710 File Offset: 0x003E4910
		public static ISkipToLevelPlayNode GetRootAsISkipToLevelPlayNode(ByteBuffer _bb)
		{
			return ISkipToLevelPlayNode.GetRootAsISkipToLevelPlayNode(_bb, default(ISkipToLevelPlayNode));
		}

		// Token: 0x0601B776 RID: 112502 RVA: 0x003E672C File Offset: 0x003E492C
		public static ISkipToLevelPlayNode GetRootAsISkipToLevelPlayNode(ByteBuffer _bb, ISkipToLevelPlayNode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B777 RID: 112503 RVA: 0x003E6749 File Offset: 0x003E4949
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B778 RID: 112504 RVA: 0x003E6758 File Offset: 0x003E4958
		public ISkipToLevelPlayNode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700806A RID: 32874
		// (get) Token: 0x0601B779 RID: 112505 RVA: 0x003E6768 File Offset: 0x003E4968
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

		// Token: 0x1700806B RID: 32875
		// (get) Token: 0x0601B77A RID: 112506 RVA: 0x003E67A4 File Offset: 0x003E49A4
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

		// Token: 0x1700806C RID: 32876
		// (get) Token: 0x0601B77B RID: 112507 RVA: 0x003E67E0 File Offset: 0x003E49E0
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

		// Token: 0x1700806D RID: 32877
		// (get) Token: 0x0601B77C RID: 112508 RVA: 0x003E681C File Offset: 0x003E4A1C
		public bool IsTeleport
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601B77D RID: 112509 RVA: 0x003E685C File Offset: 0x003E4A5C
		public static Offset<ISkipToLevelPlayNode> CreateISkipToLevelPlayNode(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode, int LevelPlayId = 0, int ChildQuestId = 0, bool IsTeleport = false)
		{
			builder.StartTable(4);
			ISkipToLevelPlayNode.AddChildQuestId(builder, ChildQuestId);
			ISkipToLevelPlayNode.AddLevelPlayId(builder, LevelPlayId);
			ISkipToLevelPlayNode.AddIsTeleport(builder, IsTeleport);
			ISkipToLevelPlayNode.AddType(builder, Type);
			return ISkipToLevelPlayNode.EndISkipToLevelPlayNode(builder);
		}

		// Token: 0x0601B77E RID: 112510 RVA: 0x003E6888 File Offset: 0x003E4A88
		public static void StartISkipToLevelPlayNode(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601B77F RID: 112511 RVA: 0x003E6891 File Offset: 0x003E4A91
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B780 RID: 112512 RVA: 0x003E689C File Offset: 0x003E4A9C
		public static void AddLevelPlayId(FlatBufferBuilder builder, int levelPlayId)
		{
			builder.AddInt(1, levelPlayId, 0);
		}

		// Token: 0x0601B781 RID: 112513 RVA: 0x003E68A7 File Offset: 0x003E4AA7
		public static void AddChildQuestId(FlatBufferBuilder builder, int childQuestId)
		{
			builder.AddInt(2, childQuestId, 0);
		}

		// Token: 0x0601B782 RID: 112514 RVA: 0x003E68B2 File Offset: 0x003E4AB2
		public static void AddIsTeleport(FlatBufferBuilder builder, bool isTeleport)
		{
			builder.AddBool(3, isTeleport, false);
		}

		// Token: 0x0601B783 RID: 112515 RVA: 0x003E68BD File Offset: 0x003E4ABD
		public static Offset<ISkipToLevelPlayNode> EndISkipToLevelPlayNode(FlatBufferBuilder builder)
		{
			return new Offset<ISkipToLevelPlayNode>(builder.EndTable());
		}

		// Token: 0x0601B784 RID: 112516 RVA: 0x003E68CC File Offset: 0x003E4ACC
		public ISkipToLevelPlayNodeT UnPack()
		{
			ISkipToLevelPlayNodeT skipToLevelPlayNodeT = new ISkipToLevelPlayNodeT();
			this.UnPackTo(skipToLevelPlayNodeT);
			return skipToLevelPlayNodeT;
		}

		// Token: 0x0601B785 RID: 112517 RVA: 0x003E68E7 File Offset: 0x003E4AE7
		public void UnPackTo(ISkipToLevelPlayNodeT _o)
		{
			_o.Type = this.Type;
			_o.LevelPlayId = this.LevelPlayId;
			_o.ChildQuestId = this.ChildQuestId;
			_o.IsTeleport = this.IsTeleport;
		}

		// Token: 0x0601B786 RID: 112518 RVA: 0x003E691C File Offset: 0x003E4B1C
		public static Offset<ISkipToLevelPlayNode> Pack(FlatBufferBuilder builder, ISkipToLevelPlayNodeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISkipToLevelPlayNode>);
			}
			return ISkipToLevelPlayNode.CreateISkipToLevelPlayNode(builder, _o.Type, _o.LevelPlayId, _o.ChildQuestId, _o.IsTeleport);
		}

		// Token: 0x0400C869 RID: 51305
		private Table __p;
	}
}
