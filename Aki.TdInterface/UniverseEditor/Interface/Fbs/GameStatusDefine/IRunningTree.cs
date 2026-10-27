using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x0200470C RID: 18188
	public struct IRunningTree : IFlatbufferObject
	{
		// Token: 0x17008234 RID: 33332
		// (get) Token: 0x0601BE59 RID: 114265 RVA: 0x003F437E File Offset: 0x003F257E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601BE5A RID: 114266 RVA: 0x003F438B File Offset: 0x003F258B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601BE5B RID: 114267 RVA: 0x003F4394 File Offset: 0x003F2594
		public static IRunningTree GetRootAsIRunningTree(ByteBuffer _bb)
		{
			return IRunningTree.GetRootAsIRunningTree(_bb, default(IRunningTree));
		}

		// Token: 0x0601BE5C RID: 114268 RVA: 0x003F43B0 File Offset: 0x003F25B0
		public static IRunningTree GetRootAsIRunningTree(ByteBuffer _bb, IRunningTree obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601BE5D RID: 114269 RVA: 0x003F43CD File Offset: 0x003F25CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601BE5E RID: 114270 RVA: 0x003F43DC File Offset: 0x003F25DC
		public IRunningTree __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008235 RID: 33333
		// (get) Token: 0x0601BE5F RID: 114271 RVA: 0x003F43EC File Offset: 0x003F25EC
		public int Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008236 RID: 33334
		// (get) Token: 0x0601BE60 RID: 114272 RVA: 0x003F4428 File Offset: 0x003F2628
		public bool IsOccupy
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008237 RID: 33335
		// (get) Token: 0x0601BE61 RID: 114273 RVA: 0x003F4468 File Offset: 0x003F2668
		public bool IsHide
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008238 RID: 33336
		// (get) Token: 0x0601BE62 RID: 114274 RVA: 0x003F44A8 File Offset: 0x003F26A8
		public bool IsSuspend
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008239 RID: 33337
		// (get) Token: 0x0601BE63 RID: 114275 RVA: 0x003F44E8 File Offset: 0x003F26E8
		public EQuestStatus QuestStatus
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return EQuestStatus.None;
				}
				return (EQuestStatus)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700823A RID: 33338
		// (get) Token: 0x0601BE64 RID: 114276 RVA: 0x003F4528 File Offset: 0x003F2728
		public IRunningTreeConfig? Tree
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return new IRunningTreeConfig?(default(IRunningTreeConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700823B RID: 33339
		// (get) Token: 0x0601BE65 RID: 114277 RVA: 0x003F4588 File Offset: 0x003F2788
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

		// Token: 0x0601BE66 RID: 114278 RVA: 0x003F45C8 File Offset: 0x003F27C8
		public static Offset<IRunningTree> CreateIRunningTree(FlatBufferBuilder builder, int Id = 0, bool IsOccupy = false, bool IsHide = false, bool IsSuspend = false, EQuestStatus QuestStatus = EQuestStatus.None, Offset<IRunningTreeConfig> TreeOffset = default(Offset<IRunningTreeConfig>), byte NullMask = 0)
		{
			builder.StartTable(7);
			IRunningTree.AddTree(builder, TreeOffset);
			IRunningTree.AddId(builder, Id);
			IRunningTree.AddNullMask(builder, NullMask);
			IRunningTree.AddQuestStatus(builder, QuestStatus);
			IRunningTree.AddIsSuspend(builder, IsSuspend);
			IRunningTree.AddIsHide(builder, IsHide);
			IRunningTree.AddIsOccupy(builder, IsOccupy);
			return IRunningTree.EndIRunningTree(builder);
		}

		// Token: 0x0601BE67 RID: 114279 RVA: 0x003F4617 File Offset: 0x003F2817
		public static void StartIRunningTree(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0601BE68 RID: 114280 RVA: 0x003F4620 File Offset: 0x003F2820
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0601BE69 RID: 114281 RVA: 0x003F462B File Offset: 0x003F282B
		public static void AddIsOccupy(FlatBufferBuilder builder, bool isOccupy)
		{
			builder.AddBool(1, isOccupy, false);
		}

		// Token: 0x0601BE6A RID: 114282 RVA: 0x003F4636 File Offset: 0x003F2836
		public static void AddIsHide(FlatBufferBuilder builder, bool isHide)
		{
			builder.AddBool(2, isHide, false);
		}

		// Token: 0x0601BE6B RID: 114283 RVA: 0x003F4641 File Offset: 0x003F2841
		public static void AddIsSuspend(FlatBufferBuilder builder, bool isSuspend)
		{
			builder.AddBool(3, isSuspend, false);
		}

		// Token: 0x0601BE6C RID: 114284 RVA: 0x003F464C File Offset: 0x003F284C
		public static void AddQuestStatus(FlatBufferBuilder builder, EQuestStatus questStatus)
		{
			builder.AddByte(4, (byte)questStatus, 0);
		}

		// Token: 0x0601BE6D RID: 114285 RVA: 0x003F4657 File Offset: 0x003F2857
		public static void AddTree(FlatBufferBuilder builder, Offset<IRunningTreeConfig> treeOffset)
		{
			builder.AddOffset(5, treeOffset.Value, 0);
		}

		// Token: 0x0601BE6E RID: 114286 RVA: 0x003F4667 File Offset: 0x003F2867
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x0601BE6F RID: 114287 RVA: 0x003F4672 File Offset: 0x003F2872
		public static Offset<IRunningTree> EndIRunningTree(FlatBufferBuilder builder)
		{
			return new Offset<IRunningTree>(builder.EndTable());
		}

		// Token: 0x0601BE70 RID: 114288 RVA: 0x003F4680 File Offset: 0x003F2880
		public IRunningTreeT UnPack()
		{
			IRunningTreeT runningTreeT = new IRunningTreeT();
			this.UnPackTo(runningTreeT);
			return runningTreeT;
		}

		// Token: 0x0601BE71 RID: 114289 RVA: 0x003F469C File Offset: 0x003F289C
		public void UnPackTo(IRunningTreeT _o)
		{
			_o.Id = this.Id;
			_o.IsOccupy = this.IsOccupy;
			_o.IsHide = this.IsHide;
			_o.IsSuspend = this.IsSuspend;
			_o.QuestStatus = this.QuestStatus;
			_o.Tree = ((this.Tree != null) ? this.Tree.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601BE72 RID: 114290 RVA: 0x003F4720 File Offset: 0x003F2920
		public static Offset<IRunningTree> Pack(FlatBufferBuilder builder, IRunningTreeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRunningTree>);
			}
			Offset<IRunningTreeConfig> treeOffset = (_o.Tree == null) ? default(Offset<IRunningTreeConfig>) : IRunningTreeConfig.Pack(builder, _o.Tree);
			return IRunningTree.CreateIRunningTree(builder, _o.Id, _o.IsOccupy, _o.IsHide, _o.IsSuspend, _o.QuestStatus, treeOffset, _o.NullMask);
		}

		// Token: 0x0400C9CF RID: 51663
		private Table __p;
	}
}
