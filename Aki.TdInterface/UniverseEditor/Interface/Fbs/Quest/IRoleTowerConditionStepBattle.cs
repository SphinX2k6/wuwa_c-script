using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004514 RID: 17684
	public struct IRoleTowerConditionStepBattle : IFlatbufferObject
	{
		// Token: 0x17007B0D RID: 31501
		// (get) Token: 0x0601997B RID: 104827 RVA: 0x003A5A6A File Offset: 0x003A3C6A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601997C RID: 104828 RVA: 0x003A5A77 File Offset: 0x003A3C77
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601997D RID: 104829 RVA: 0x003A5A80 File Offset: 0x003A3C80
		public static IRoleTowerConditionStepBattle GetRootAsIRoleTowerConditionStepBattle(ByteBuffer _bb)
		{
			return IRoleTowerConditionStepBattle.GetRootAsIRoleTowerConditionStepBattle(_bb, default(IRoleTowerConditionStepBattle));
		}

		// Token: 0x0601997E RID: 104830 RVA: 0x003A5A9C File Offset: 0x003A3C9C
		public static IRoleTowerConditionStepBattle GetRootAsIRoleTowerConditionStepBattle(ByteBuffer _bb, IRoleTowerConditionStepBattle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601997F RID: 104831 RVA: 0x003A5AB9 File Offset: 0x003A3CB9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019980 RID: 104832 RVA: 0x003A5AC8 File Offset: 0x003A3CC8
		public IRoleTowerConditionStepBattle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007B0E RID: 31502
		// (get) Token: 0x06019981 RID: 104833 RVA: 0x003A5AD8 File Offset: 0x003A3CD8
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

		// Token: 0x06019982 RID: 104834 RVA: 0x003A5B14 File Offset: 0x003A3D14
		public static Offset<IRoleTowerConditionStepBattle> CreateIRoleTowerConditionStepBattle(FlatBufferBuilder builder, ERoleTowerConditionStep Type = ERoleTowerConditionStep.Prepare)
		{
			builder.StartTable(1);
			IRoleTowerConditionStepBattle.AddType(builder, Type);
			return IRoleTowerConditionStepBattle.EndIRoleTowerConditionStepBattle(builder);
		}

		// Token: 0x06019983 RID: 104835 RVA: 0x003A5B2A File Offset: 0x003A3D2A
		public static void StartIRoleTowerConditionStepBattle(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06019984 RID: 104836 RVA: 0x003A5B33 File Offset: 0x003A3D33
		public static void AddType(FlatBufferBuilder builder, ERoleTowerConditionStep type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019985 RID: 104837 RVA: 0x003A5B3E File Offset: 0x003A3D3E
		public static Offset<IRoleTowerConditionStepBattle> EndIRoleTowerConditionStepBattle(FlatBufferBuilder builder)
		{
			return new Offset<IRoleTowerConditionStepBattle>(builder.EndTable());
		}

		// Token: 0x06019986 RID: 104838 RVA: 0x003A5B4C File Offset: 0x003A3D4C
		public IRoleTowerConditionStepBattleT UnPack()
		{
			IRoleTowerConditionStepBattleT roleTowerConditionStepBattleT = new IRoleTowerConditionStepBattleT();
			this.UnPackTo(roleTowerConditionStepBattleT);
			return roleTowerConditionStepBattleT;
		}

		// Token: 0x06019987 RID: 104839 RVA: 0x003A5B67 File Offset: 0x003A3D67
		public void UnPackTo(IRoleTowerConditionStepBattleT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06019988 RID: 104840 RVA: 0x003A5B78 File Offset: 0x003A3D78
		public static Offset<IRoleTowerConditionStepBattle> Pack(FlatBufferBuilder builder, IRoleTowerConditionStepBattleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRoleTowerConditionStepBattle>);
			}
			return IRoleTowerConditionStepBattle.CreateIRoleTowerConditionStepBattle(builder, _o.Type);
		}

		// Token: 0x0400C659 RID: 50777
		private Table __p;
	}
}
