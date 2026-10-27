using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040DF RID: 16607
	public struct IRoleTowerConditionStepTeamUpgrade : IFlatbufferObject
	{
		// Token: 0x17007513 RID: 29971
		// (get) Token: 0x06018322 RID: 99106 RVA: 0x0037C0F9 File Offset: 0x0037A2F9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018323 RID: 99107 RVA: 0x0037C106 File Offset: 0x0037A306
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018324 RID: 99108 RVA: 0x0037C110 File Offset: 0x0037A310
		public static IRoleTowerConditionStepTeamUpgrade GetRootAsIRoleTowerConditionStepTeamUpgrade(ByteBuffer _bb)
		{
			return IRoleTowerConditionStepTeamUpgrade.GetRootAsIRoleTowerConditionStepTeamUpgrade(_bb, default(IRoleTowerConditionStepTeamUpgrade));
		}

		// Token: 0x06018325 RID: 99109 RVA: 0x0037C12C File Offset: 0x0037A32C
		public static IRoleTowerConditionStepTeamUpgrade GetRootAsIRoleTowerConditionStepTeamUpgrade(ByteBuffer _bb, IRoleTowerConditionStepTeamUpgrade obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018326 RID: 99110 RVA: 0x0037C149 File Offset: 0x0037A349
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018327 RID: 99111 RVA: 0x0037C158 File Offset: 0x0037A358
		public IRoleTowerConditionStepTeamUpgrade __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007514 RID: 29972
		// (get) Token: 0x06018328 RID: 99112 RVA: 0x0037C168 File Offset: 0x0037A368
		public ERoleTowerConditionStep Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERoleTowerConditionStep.Prepare;
				}
				return (ERoleTowerConditionStep)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06018329 RID: 99113 RVA: 0x0037C1A4 File Offset: 0x0037A3A4
		public static Offset<IRoleTowerConditionStepTeamUpgrade> CreateIRoleTowerConditionStepTeamUpgrade(FlatBufferBuilder builder, ERoleTowerConditionStep Type = ERoleTowerConditionStep.Prepare)
		{
			builder.StartTable(1);
			IRoleTowerConditionStepTeamUpgrade.AddType(builder, Type);
			return IRoleTowerConditionStepTeamUpgrade.EndIRoleTowerConditionStepTeamUpgrade(builder);
		}

		// Token: 0x0601832A RID: 99114 RVA: 0x0037C1BA File Offset: 0x0037A3BA
		public static void StartIRoleTowerConditionStepTeamUpgrade(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601832B RID: 99115 RVA: 0x0037C1C3 File Offset: 0x0037A3C3
		public static void AddType(FlatBufferBuilder builder, ERoleTowerConditionStep type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601832C RID: 99116 RVA: 0x0037C1CE File Offset: 0x0037A3CE
		public static Offset<IRoleTowerConditionStepTeamUpgrade> EndIRoleTowerConditionStepTeamUpgrade(FlatBufferBuilder builder)
		{
			return new Offset<IRoleTowerConditionStepTeamUpgrade>(builder.EndTable());
		}

		// Token: 0x0601832D RID: 99117 RVA: 0x0037C1DC File Offset: 0x0037A3DC
		public IRoleTowerConditionStepTeamUpgradeT UnPack()
		{
			IRoleTowerConditionStepTeamUpgradeT roleTowerConditionStepTeamUpgradeT = new IRoleTowerConditionStepTeamUpgradeT();
			this.UnPackTo(roleTowerConditionStepTeamUpgradeT);
			return roleTowerConditionStepTeamUpgradeT;
		}

		// Token: 0x0601832E RID: 99118 RVA: 0x0037C1F7 File Offset: 0x0037A3F7
		public void UnPackTo(IRoleTowerConditionStepTeamUpgradeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601832F RID: 99119 RVA: 0x0037C208 File Offset: 0x0037A408
		public static Offset<IRoleTowerConditionStepTeamUpgrade> Pack(FlatBufferBuilder builder, IRoleTowerConditionStepTeamUpgradeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRoleTowerConditionStepTeamUpgrade>);
			}
			return IRoleTowerConditionStepTeamUpgrade.CreateIRoleTowerConditionStepTeamUpgrade(builder, _o.Type);
		}

		// Token: 0x0400BC78 RID: 48248
		private Table __p;
	}
}
