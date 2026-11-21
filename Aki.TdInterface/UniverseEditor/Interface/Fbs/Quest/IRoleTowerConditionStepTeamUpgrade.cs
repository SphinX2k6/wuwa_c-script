using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004520 RID: 17696
	public struct IRoleTowerConditionStepTeamUpgrade : IFlatbufferObject
	{
		// Token: 0x17007B19 RID: 31513
		// (get) Token: 0x060199C3 RID: 104899 RVA: 0x003A6049 File Offset: 0x003A4249
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060199C4 RID: 104900 RVA: 0x003A6056 File Offset: 0x003A4256
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060199C5 RID: 104901 RVA: 0x003A6060 File Offset: 0x003A4260
		public static IRoleTowerConditionStepTeamUpgrade GetRootAsIRoleTowerConditionStepTeamUpgrade(ByteBuffer _bb)
		{
			return IRoleTowerConditionStepTeamUpgrade.GetRootAsIRoleTowerConditionStepTeamUpgrade(_bb, default(IRoleTowerConditionStepTeamUpgrade));
		}

		// Token: 0x060199C6 RID: 104902 RVA: 0x003A607C File Offset: 0x003A427C
		public static IRoleTowerConditionStepTeamUpgrade GetRootAsIRoleTowerConditionStepTeamUpgrade(ByteBuffer _bb, IRoleTowerConditionStepTeamUpgrade obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060199C7 RID: 104903 RVA: 0x003A6099 File Offset: 0x003A4299
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060199C8 RID: 104904 RVA: 0x003A60A8 File Offset: 0x003A42A8
		public IRoleTowerConditionStepTeamUpgrade __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007B1A RID: 31514
		// (get) Token: 0x060199C9 RID: 104905 RVA: 0x003A60B8 File Offset: 0x003A42B8
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

		// Token: 0x060199CA RID: 104906 RVA: 0x003A60F4 File Offset: 0x003A42F4
		public static Offset<IRoleTowerConditionStepTeamUpgrade> CreateIRoleTowerConditionStepTeamUpgrade(FlatBufferBuilder builder, ERoleTowerConditionStep Type = ERoleTowerConditionStep.Prepare)
		{
			builder.StartTable(1);
			IRoleTowerConditionStepTeamUpgrade.AddType(builder, Type);
			return IRoleTowerConditionStepTeamUpgrade.EndIRoleTowerConditionStepTeamUpgrade(builder);
		}

		// Token: 0x060199CB RID: 104907 RVA: 0x003A610A File Offset: 0x003A430A
		public static void StartIRoleTowerConditionStepTeamUpgrade(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060199CC RID: 104908 RVA: 0x003A6113 File Offset: 0x003A4313
		public static void AddType(FlatBufferBuilder builder, ERoleTowerConditionStep type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060199CD RID: 104909 RVA: 0x003A611E File Offset: 0x003A431E
		public static Offset<IRoleTowerConditionStepTeamUpgrade> EndIRoleTowerConditionStepTeamUpgrade(FlatBufferBuilder builder)
		{
			return new Offset<IRoleTowerConditionStepTeamUpgrade>(builder.EndTable());
		}

		// Token: 0x060199CE RID: 104910 RVA: 0x003A612C File Offset: 0x003A432C
		public IRoleTowerConditionStepTeamUpgradeT UnPack()
		{
			IRoleTowerConditionStepTeamUpgradeT roleTowerConditionStepTeamUpgradeT = new IRoleTowerConditionStepTeamUpgradeT();
			this.UnPackTo(roleTowerConditionStepTeamUpgradeT);
			return roleTowerConditionStepTeamUpgradeT;
		}

		// Token: 0x060199CF RID: 104911 RVA: 0x003A6147 File Offset: 0x003A4347
		public void UnPackTo(IRoleTowerConditionStepTeamUpgradeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060199D0 RID: 104912 RVA: 0x003A6158 File Offset: 0x003A4358
		public static Offset<IRoleTowerConditionStepTeamUpgrade> Pack(FlatBufferBuilder builder, IRoleTowerConditionStepTeamUpgradeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRoleTowerConditionStepTeamUpgrade>);
			}
			return IRoleTowerConditionStepTeamUpgrade.CreateIRoleTowerConditionStepTeamUpgrade(builder, _o.Type);
		}

		// Token: 0x0400C661 RID: 50785
		private Table __p;
	}
}
