using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020049AF RID: 18863
	public struct ICheckCrossSceneSyncKillMonsterFinished : IFlatbufferObject
	{
		// Token: 0x17008861 RID: 34913
		// (get) Token: 0x0601D712 RID: 120594 RVA: 0x00425FA8 File Offset: 0x004241A8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D713 RID: 120595 RVA: 0x00425FB5 File Offset: 0x004241B5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D714 RID: 120596 RVA: 0x00425FBC File Offset: 0x004241BC
		public static ICheckCrossSceneSyncKillMonsterFinished GetRootAsICheckCrossSceneSyncKillMonsterFinished(ByteBuffer _bb)
		{
			return ICheckCrossSceneSyncKillMonsterFinished.GetRootAsICheckCrossSceneSyncKillMonsterFinished(_bb, default(ICheckCrossSceneSyncKillMonsterFinished));
		}

		// Token: 0x0601D715 RID: 120597 RVA: 0x00425FD8 File Offset: 0x004241D8
		public static ICheckCrossSceneSyncKillMonsterFinished GetRootAsICheckCrossSceneSyncKillMonsterFinished(ByteBuffer _bb, ICheckCrossSceneSyncKillMonsterFinished obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D716 RID: 120598 RVA: 0x00425FF5 File Offset: 0x004241F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D717 RID: 120599 RVA: 0x00426004 File Offset: 0x00424204
		public ICheckCrossSceneSyncKillMonsterFinished __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008862 RID: 34914
		// (get) Token: 0x0601D718 RID: 120600 RVA: 0x00426014 File Offset: 0x00424214
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008863 RID: 34915
		// (get) Token: 0x0601D719 RID: 120601 RVA: 0x00426050 File Offset: 0x00424250
		public int SyncId
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

		// Token: 0x17008864 RID: 34916
		// (get) Token: 0x0601D71A RID: 120602 RVA: 0x0042608C File Offset: 0x0042428C
		public int EntityBundleId
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

		// Token: 0x17008865 RID: 34917
		// (get) Token: 0x0601D71B RID: 120603 RVA: 0x004260C8 File Offset: 0x004242C8
		public ECompare Compare
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601D71C RID: 120604 RVA: 0x00426105 File Offset: 0x00424305
		public static Offset<ICheckCrossSceneSyncKillMonsterFinished> CreateICheckCrossSceneSyncKillMonsterFinished(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int SyncId = 0, int EntityBundleId = 0, ECompare Compare = ECompare.Eq)
		{
			builder.StartTable(4);
			ICheckCrossSceneSyncKillMonsterFinished.AddEntityBundleId(builder, EntityBundleId);
			ICheckCrossSceneSyncKillMonsterFinished.AddSyncId(builder, SyncId);
			ICheckCrossSceneSyncKillMonsterFinished.AddCompare(builder, Compare);
			ICheckCrossSceneSyncKillMonsterFinished.AddType(builder, Type);
			return ICheckCrossSceneSyncKillMonsterFinished.EndICheckCrossSceneSyncKillMonsterFinished(builder);
		}

		// Token: 0x0601D71D RID: 120605 RVA: 0x00426131 File Offset: 0x00424331
		public static void StartICheckCrossSceneSyncKillMonsterFinished(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601D71E RID: 120606 RVA: 0x0042613A File Offset: 0x0042433A
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601D71F RID: 120607 RVA: 0x00426145 File Offset: 0x00424345
		public static void AddSyncId(FlatBufferBuilder builder, int syncId)
		{
			builder.AddInt(1, syncId, 0);
		}

		// Token: 0x0601D720 RID: 120608 RVA: 0x00426150 File Offset: 0x00424350
		public static void AddEntityBundleId(FlatBufferBuilder builder, int entityBundleId)
		{
			builder.AddInt(2, entityBundleId, 0);
		}

		// Token: 0x0601D721 RID: 120609 RVA: 0x0042615B File Offset: 0x0042435B
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(3, (byte)compare, 0);
		}

		// Token: 0x0601D722 RID: 120610 RVA: 0x00426166 File Offset: 0x00424366
		public static Offset<ICheckCrossSceneSyncKillMonsterFinished> EndICheckCrossSceneSyncKillMonsterFinished(FlatBufferBuilder builder)
		{
			return new Offset<ICheckCrossSceneSyncKillMonsterFinished>(builder.EndTable());
		}

		// Token: 0x0601D723 RID: 120611 RVA: 0x00426174 File Offset: 0x00424374
		public ICheckCrossSceneSyncKillMonsterFinishedT UnPack()
		{
			ICheckCrossSceneSyncKillMonsterFinishedT checkCrossSceneSyncKillMonsterFinishedT = new ICheckCrossSceneSyncKillMonsterFinishedT();
			this.UnPackTo(checkCrossSceneSyncKillMonsterFinishedT);
			return checkCrossSceneSyncKillMonsterFinishedT;
		}

		// Token: 0x0601D724 RID: 120612 RVA: 0x0042618F File Offset: 0x0042438F
		public void UnPackTo(ICheckCrossSceneSyncKillMonsterFinishedT _o)
		{
			_o.Type = this.Type;
			_o.SyncId = this.SyncId;
			_o.EntityBundleId = this.EntityBundleId;
			_o.Compare = this.Compare;
		}

		// Token: 0x0601D725 RID: 120613 RVA: 0x004261C4 File Offset: 0x004243C4
		public static Offset<ICheckCrossSceneSyncKillMonsterFinished> Pack(FlatBufferBuilder builder, ICheckCrossSceneSyncKillMonsterFinishedT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckCrossSceneSyncKillMonsterFinished>);
			}
			return ICheckCrossSceneSyncKillMonsterFinished.CreateICheckCrossSceneSyncKillMonsterFinished(builder, _o.Type, _o.SyncId, _o.EntityBundleId, _o.Compare);
		}

		// Token: 0x0400D1D1 RID: 53713
		private Table __p;
	}
}
