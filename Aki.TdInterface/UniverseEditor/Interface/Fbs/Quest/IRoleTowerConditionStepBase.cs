using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040CD RID: 16589
	public struct IRoleTowerConditionStepBase : IFlatbufferObject
	{
		// Token: 0x17007502 RID: 29954
		// (get) Token: 0x060182B4 RID: 98996 RVA: 0x0037B792 File Offset: 0x00379992
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060182B5 RID: 98997 RVA: 0x0037B79F File Offset: 0x0037999F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060182B6 RID: 98998 RVA: 0x0037B7A8 File Offset: 0x003799A8
		public static IRoleTowerConditionStepBase GetRootAsIRoleTowerConditionStepBase(ByteBuffer _bb)
		{
			return IRoleTowerConditionStepBase.GetRootAsIRoleTowerConditionStepBase(_bb, default(IRoleTowerConditionStepBase));
		}

		// Token: 0x060182B7 RID: 98999 RVA: 0x0037B7C4 File Offset: 0x003799C4
		public static IRoleTowerConditionStepBase GetRootAsIRoleTowerConditionStepBase(ByteBuffer _bb, IRoleTowerConditionStepBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060182B8 RID: 99000 RVA: 0x0037B7E1 File Offset: 0x003799E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060182B9 RID: 99001 RVA: 0x0037B7F0 File Offset: 0x003799F0
		public IRoleTowerConditionStepBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007503 RID: 29955
		// (get) Token: 0x060182BA RID: 99002 RVA: 0x0037B800 File Offset: 0x00379A00
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

		// Token: 0x060182BB RID: 99003 RVA: 0x0037B83C File Offset: 0x00379A3C
		public static Offset<IRoleTowerConditionStepBase> CreateIRoleTowerConditionStepBase(FlatBufferBuilder builder, ERoleTowerConditionStep Type = ERoleTowerConditionStep.Prepare)
		{
			builder.StartTable(1);
			IRoleTowerConditionStepBase.AddType(builder, Type);
			return IRoleTowerConditionStepBase.EndIRoleTowerConditionStepBase(builder);
		}

		// Token: 0x060182BC RID: 99004 RVA: 0x0037B852 File Offset: 0x00379A52
		public static void StartIRoleTowerConditionStepBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060182BD RID: 99005 RVA: 0x0037B85B File Offset: 0x00379A5B
		public static void AddType(FlatBufferBuilder builder, ERoleTowerConditionStep type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060182BE RID: 99006 RVA: 0x0037B866 File Offset: 0x00379A66
		public static Offset<IRoleTowerConditionStepBase> EndIRoleTowerConditionStepBase(FlatBufferBuilder builder)
		{
			return new Offset<IRoleTowerConditionStepBase>(builder.EndTable());
		}

		// Token: 0x060182BF RID: 99007 RVA: 0x0037B874 File Offset: 0x00379A74
		public IRoleTowerConditionStepBaseT UnPack()
		{
			IRoleTowerConditionStepBaseT roleTowerConditionStepBaseT = new IRoleTowerConditionStepBaseT();
			this.UnPackTo(roleTowerConditionStepBaseT);
			return roleTowerConditionStepBaseT;
		}

		// Token: 0x060182C0 RID: 99008 RVA: 0x0037B88F File Offset: 0x00379A8F
		public void UnPackTo(IRoleTowerConditionStepBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060182C1 RID: 99009 RVA: 0x0037B8A0 File Offset: 0x00379AA0
		public static Offset<IRoleTowerConditionStepBase> Pack(FlatBufferBuilder builder, IRoleTowerConditionStepBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRoleTowerConditionStepBase>);
			}
			return IRoleTowerConditionStepBase.CreateIRoleTowerConditionStepBase(builder, _o.Type);
		}

		// Token: 0x0400BC64 RID: 48228
		private Table __p;
	}
}
