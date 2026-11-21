using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x02004B74 RID: 19316
	public struct IRunningTree : IFlatbufferObject
	{
		// Token: 0x17008875 RID: 34933
		// (get) Token: 0x0601D62E RID: 120366 RVA: 0x0042061A File Offset: 0x0041E81A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D62F RID: 120367 RVA: 0x00420627 File Offset: 0x0041E827
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D630 RID: 120368 RVA: 0x00420630 File Offset: 0x0041E830
		public static IRunningTree GetRootAsIRunningTree(ByteBuffer _bb)
		{
			return IRunningTree.GetRootAsIRunningTree(_bb, default(IRunningTree));
		}

		// Token: 0x0601D631 RID: 120369 RVA: 0x0042064C File Offset: 0x0041E84C
		public static IRunningTree GetRootAsIRunningTree(ByteBuffer _bb, IRunningTree obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D632 RID: 120370 RVA: 0x00420669 File Offset: 0x0041E869
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D633 RID: 120371 RVA: 0x00420678 File Offset: 0x0041E878
		public IRunningTree __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008876 RID: 34934
		// (get) Token: 0x0601D634 RID: 120372 RVA: 0x00420688 File Offset: 0x0041E888
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

		// Token: 0x17008877 RID: 34935
		// (get) Token: 0x0601D635 RID: 120373 RVA: 0x004206C4 File Offset: 0x0041E8C4
		public bool IsOccupy
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008878 RID: 34936
		// (get) Token: 0x0601D636 RID: 120374 RVA: 0x00420704 File Offset: 0x0041E904
		public bool IsHide
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008879 RID: 34937
		// (get) Token: 0x0601D637 RID: 120375 RVA: 0x00420744 File Offset: 0x0041E944
		public bool IsSuspend
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700887A RID: 34938
		// (get) Token: 0x0601D638 RID: 120376 RVA: 0x00420784 File Offset: 0x0041E984
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

		// Token: 0x1700887B RID: 34939
		// (get) Token: 0x0601D639 RID: 120377 RVA: 0x004207C4 File Offset: 0x0041E9C4
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

		// Token: 0x1700887C RID: 34940
		// (get) Token: 0x0601D63A RID: 120378 RVA: 0x00420824 File Offset: 0x0041EA24
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

		// Token: 0x0601D63B RID: 120379 RVA: 0x00420864 File Offset: 0x0041EA64
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

		// Token: 0x0601D63C RID: 120380 RVA: 0x004208B3 File Offset: 0x0041EAB3
		public static void StartIRunningTree(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0601D63D RID: 120381 RVA: 0x004208BC File Offset: 0x0041EABC
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0601D63E RID: 120382 RVA: 0x004208C7 File Offset: 0x0041EAC7
		public static void AddIsOccupy(FlatBufferBuilder builder, bool isOccupy)
		{
			builder.AddBool(1, isOccupy, false);
		}

		// Token: 0x0601D63F RID: 120383 RVA: 0x004208D2 File Offset: 0x0041EAD2
		public static void AddIsHide(FlatBufferBuilder builder, bool isHide)
		{
			builder.AddBool(2, isHide, false);
		}

		// Token: 0x0601D640 RID: 120384 RVA: 0x004208DD File Offset: 0x0041EADD
		public static void AddIsSuspend(FlatBufferBuilder builder, bool isSuspend)
		{
			builder.AddBool(3, isSuspend, false);
		}

		// Token: 0x0601D641 RID: 120385 RVA: 0x004208E8 File Offset: 0x0041EAE8
		public static void AddQuestStatus(FlatBufferBuilder builder, EQuestStatus questStatus)
		{
			builder.AddByte(4, (byte)questStatus, 0);
		}

		// Token: 0x0601D642 RID: 120386 RVA: 0x004208F3 File Offset: 0x0041EAF3
		public static void AddTree(FlatBufferBuilder builder, Offset<IRunningTreeConfig> treeOffset)
		{
			builder.AddOffset(5, treeOffset.Value, 0);
		}

		// Token: 0x0601D643 RID: 120387 RVA: 0x00420903 File Offset: 0x0041EB03
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x0601D644 RID: 120388 RVA: 0x0042090E File Offset: 0x0041EB0E
		public static Offset<IRunningTree> EndIRunningTree(FlatBufferBuilder builder)
		{
			return new Offset<IRunningTree>(builder.EndTable());
		}

		// Token: 0x0601D645 RID: 120389 RVA: 0x0042091C File Offset: 0x0041EB1C
		public IRunningTreeT UnPack()
		{
			IRunningTreeT runningTreeT = new IRunningTreeT();
			this.UnPackTo(runningTreeT);
			return runningTreeT;
		}

		// Token: 0x0601D646 RID: 120390 RVA: 0x00420938 File Offset: 0x0041EB38
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

		// Token: 0x0601D647 RID: 120391 RVA: 0x004209BC File Offset: 0x0041EBBC
		public static Offset<IRunningTree> Pack(FlatBufferBuilder builder, IRunningTreeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRunningTree>);
			}
			Offset<IRunningTreeConfig> treeOffset = (_o.Tree == null) ? default(Offset<IRunningTreeConfig>) : IRunningTreeConfig.Pack(builder, _o.Tree);
			return IRunningTree.CreateIRunningTree(builder, _o.Id, _o.IsOccupy, _o.IsHide, _o.IsSuspend, _o.QuestStatus, treeOffset, _o.NullMask);
		}

		// Token: 0x0400D3FE RID: 54270
		private Table __p;
	}
}
