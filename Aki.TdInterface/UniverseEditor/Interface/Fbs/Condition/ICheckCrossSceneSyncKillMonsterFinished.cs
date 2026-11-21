using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E69 RID: 20073
	public struct ICheckCrossSceneSyncKillMonsterFinished : IFlatbufferObject
	{
		// Token: 0x17008F23 RID: 36643
		// (get) Token: 0x0601F151 RID: 127313 RVA: 0x004566F0 File Offset: 0x004548F0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F152 RID: 127314 RVA: 0x004566FD File Offset: 0x004548FD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F153 RID: 127315 RVA: 0x00456704 File Offset: 0x00454904
		public static ICheckCrossSceneSyncKillMonsterFinished GetRootAsICheckCrossSceneSyncKillMonsterFinished(ByteBuffer _bb)
		{
			return ICheckCrossSceneSyncKillMonsterFinished.GetRootAsICheckCrossSceneSyncKillMonsterFinished(_bb, default(ICheckCrossSceneSyncKillMonsterFinished));
		}

		// Token: 0x0601F154 RID: 127316 RVA: 0x00456720 File Offset: 0x00454920
		public static ICheckCrossSceneSyncKillMonsterFinished GetRootAsICheckCrossSceneSyncKillMonsterFinished(ByteBuffer _bb, ICheckCrossSceneSyncKillMonsterFinished obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F155 RID: 127317 RVA: 0x0045673D File Offset: 0x0045493D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F156 RID: 127318 RVA: 0x0045674C File Offset: 0x0045494C
		public ICheckCrossSceneSyncKillMonsterFinished __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008F24 RID: 36644
		// (get) Token: 0x0601F157 RID: 127319 RVA: 0x0045675C File Offset: 0x0045495C
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

		// Token: 0x17008F25 RID: 36645
		// (get) Token: 0x0601F158 RID: 127320 RVA: 0x00456798 File Offset: 0x00454998
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

		// Token: 0x17008F26 RID: 36646
		// (get) Token: 0x0601F159 RID: 127321 RVA: 0x004567D4 File Offset: 0x004549D4
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

		// Token: 0x17008F27 RID: 36647
		// (get) Token: 0x0601F15A RID: 127322 RVA: 0x00456810 File Offset: 0x00454A10
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

		// Token: 0x0601F15B RID: 127323 RVA: 0x0045684D File Offset: 0x00454A4D
		public static Offset<ICheckCrossSceneSyncKillMonsterFinished> CreateICheckCrossSceneSyncKillMonsterFinished(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int SyncId = 0, int EntityBundleId = 0, ECompare Compare = ECompare.Eq)
		{
			builder.StartTable(4);
			ICheckCrossSceneSyncKillMonsterFinished.AddEntityBundleId(builder, EntityBundleId);
			ICheckCrossSceneSyncKillMonsterFinished.AddSyncId(builder, SyncId);
			ICheckCrossSceneSyncKillMonsterFinished.AddCompare(builder, Compare);
			ICheckCrossSceneSyncKillMonsterFinished.AddType(builder, Type);
			return ICheckCrossSceneSyncKillMonsterFinished.EndICheckCrossSceneSyncKillMonsterFinished(builder);
		}

		// Token: 0x0601F15C RID: 127324 RVA: 0x00456879 File Offset: 0x00454A79
		public static void StartICheckCrossSceneSyncKillMonsterFinished(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601F15D RID: 127325 RVA: 0x00456882 File Offset: 0x00454A82
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F15E RID: 127326 RVA: 0x0045688D File Offset: 0x00454A8D
		public static void AddSyncId(FlatBufferBuilder builder, int syncId)
		{
			builder.AddInt(1, syncId, 0);
		}

		// Token: 0x0601F15F RID: 127327 RVA: 0x00456898 File Offset: 0x00454A98
		public static void AddEntityBundleId(FlatBufferBuilder builder, int entityBundleId)
		{
			builder.AddInt(2, entityBundleId, 0);
		}

		// Token: 0x0601F160 RID: 127328 RVA: 0x004568A3 File Offset: 0x00454AA3
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(3, (byte)compare, 0);
		}

		// Token: 0x0601F161 RID: 127329 RVA: 0x004568AE File Offset: 0x00454AAE
		public static Offset<ICheckCrossSceneSyncKillMonsterFinished> EndICheckCrossSceneSyncKillMonsterFinished(FlatBufferBuilder builder)
		{
			return new Offset<ICheckCrossSceneSyncKillMonsterFinished>(builder.EndTable());
		}

		// Token: 0x0601F162 RID: 127330 RVA: 0x004568BC File Offset: 0x00454ABC
		public ICheckCrossSceneSyncKillMonsterFinishedT UnPack()
		{
			ICheckCrossSceneSyncKillMonsterFinishedT checkCrossSceneSyncKillMonsterFinishedT = new ICheckCrossSceneSyncKillMonsterFinishedT();
			this.UnPackTo(checkCrossSceneSyncKillMonsterFinishedT);
			return checkCrossSceneSyncKillMonsterFinishedT;
		}

		// Token: 0x0601F163 RID: 127331 RVA: 0x004568D7 File Offset: 0x00454AD7
		public void UnPackTo(ICheckCrossSceneSyncKillMonsterFinishedT _o)
		{
			_o.Type = this.Type;
			_o.SyncId = this.SyncId;
			_o.EntityBundleId = this.EntityBundleId;
			_o.Compare = this.Compare;
		}

		// Token: 0x0601F164 RID: 127332 RVA: 0x0045690C File Offset: 0x00454B0C
		public static Offset<ICheckCrossSceneSyncKillMonsterFinished> Pack(FlatBufferBuilder builder, ICheckCrossSceneSyncKillMonsterFinishedT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckCrossSceneSyncKillMonsterFinished>);
			}
			return ICheckCrossSceneSyncKillMonsterFinished.CreateICheckCrossSceneSyncKillMonsterFinished(builder, _o.Type, _o.SyncId, _o.EntityBundleId, _o.Compare);
		}

		// Token: 0x0400DC9D RID: 56477
		private Table __p;
	}
}
