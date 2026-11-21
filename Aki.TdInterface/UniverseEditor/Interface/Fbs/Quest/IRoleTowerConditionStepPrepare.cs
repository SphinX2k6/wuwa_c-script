using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200451A RID: 17690
	public struct IRoleTowerConditionStepPrepare : IFlatbufferObject
	{
		// Token: 0x17007B13 RID: 31507
		// (get) Token: 0x0601999F RID: 104863 RVA: 0x003A5D59 File Offset: 0x003A3F59
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060199A0 RID: 104864 RVA: 0x003A5D66 File Offset: 0x003A3F66
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060199A1 RID: 104865 RVA: 0x003A5D70 File Offset: 0x003A3F70
		public static IRoleTowerConditionStepPrepare GetRootAsIRoleTowerConditionStepPrepare(ByteBuffer _bb)
		{
			return IRoleTowerConditionStepPrepare.GetRootAsIRoleTowerConditionStepPrepare(_bb, default(IRoleTowerConditionStepPrepare));
		}

		// Token: 0x060199A2 RID: 104866 RVA: 0x003A5D8C File Offset: 0x003A3F8C
		public static IRoleTowerConditionStepPrepare GetRootAsIRoleTowerConditionStepPrepare(ByteBuffer _bb, IRoleTowerConditionStepPrepare obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060199A3 RID: 104867 RVA: 0x003A5DA9 File Offset: 0x003A3FA9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060199A4 RID: 104868 RVA: 0x003A5DB8 File Offset: 0x003A3FB8
		public IRoleTowerConditionStepPrepare __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007B14 RID: 31508
		// (get) Token: 0x060199A5 RID: 104869 RVA: 0x003A5DC8 File Offset: 0x003A3FC8
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

		// Token: 0x060199A6 RID: 104870 RVA: 0x003A5E04 File Offset: 0x003A4004
		public static Offset<IRoleTowerConditionStepPrepare> CreateIRoleTowerConditionStepPrepare(FlatBufferBuilder builder, ERoleTowerConditionStep Type = ERoleTowerConditionStep.Prepare)
		{
			builder.StartTable(1);
			IRoleTowerConditionStepPrepare.AddType(builder, Type);
			return IRoleTowerConditionStepPrepare.EndIRoleTowerConditionStepPrepare(builder);
		}

		// Token: 0x060199A7 RID: 104871 RVA: 0x003A5E1A File Offset: 0x003A401A
		public static void StartIRoleTowerConditionStepPrepare(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060199A8 RID: 104872 RVA: 0x003A5E23 File Offset: 0x003A4023
		public static void AddType(FlatBufferBuilder builder, ERoleTowerConditionStep type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060199A9 RID: 104873 RVA: 0x003A5E2E File Offset: 0x003A402E
		public static Offset<IRoleTowerConditionStepPrepare> EndIRoleTowerConditionStepPrepare(FlatBufferBuilder builder)
		{
			return new Offset<IRoleTowerConditionStepPrepare>(builder.EndTable());
		}

		// Token: 0x060199AA RID: 104874 RVA: 0x003A5E3C File Offset: 0x003A403C
		public IRoleTowerConditionStepPrepareT UnPack()
		{
			IRoleTowerConditionStepPrepareT roleTowerConditionStepPrepareT = new IRoleTowerConditionStepPrepareT();
			this.UnPackTo(roleTowerConditionStepPrepareT);
			return roleTowerConditionStepPrepareT;
		}

		// Token: 0x060199AB RID: 104875 RVA: 0x003A5E57 File Offset: 0x003A4057
		public void UnPackTo(IRoleTowerConditionStepPrepareT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060199AC RID: 104876 RVA: 0x003A5E68 File Offset: 0x003A4068
		public static Offset<IRoleTowerConditionStepPrepare> Pack(FlatBufferBuilder builder, IRoleTowerConditionStepPrepareT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRoleTowerConditionStepPrepare>);
			}
			return IRoleTowerConditionStepPrepare.CreateIRoleTowerConditionStepPrepare(builder, _o.Type);
		}

		// Token: 0x0400C65D RID: 50781
		private Table __p;
	}
}
