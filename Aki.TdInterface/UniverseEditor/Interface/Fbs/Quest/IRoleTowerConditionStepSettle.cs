using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200451D RID: 17693
	public struct IRoleTowerConditionStepSettle : IFlatbufferObject
	{
		// Token: 0x17007B16 RID: 31510
		// (get) Token: 0x060199B1 RID: 104881 RVA: 0x003A5ED1 File Offset: 0x003A40D1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060199B2 RID: 104882 RVA: 0x003A5EDE File Offset: 0x003A40DE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060199B3 RID: 104883 RVA: 0x003A5EE8 File Offset: 0x003A40E8
		public static IRoleTowerConditionStepSettle GetRootAsIRoleTowerConditionStepSettle(ByteBuffer _bb)
		{
			return IRoleTowerConditionStepSettle.GetRootAsIRoleTowerConditionStepSettle(_bb, default(IRoleTowerConditionStepSettle));
		}

		// Token: 0x060199B4 RID: 104884 RVA: 0x003A5F04 File Offset: 0x003A4104
		public static IRoleTowerConditionStepSettle GetRootAsIRoleTowerConditionStepSettle(ByteBuffer _bb, IRoleTowerConditionStepSettle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060199B5 RID: 104885 RVA: 0x003A5F21 File Offset: 0x003A4121
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060199B6 RID: 104886 RVA: 0x003A5F30 File Offset: 0x003A4130
		public IRoleTowerConditionStepSettle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007B17 RID: 31511
		// (get) Token: 0x060199B7 RID: 104887 RVA: 0x003A5F40 File Offset: 0x003A4140
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

		// Token: 0x060199B8 RID: 104888 RVA: 0x003A5F7C File Offset: 0x003A417C
		public static Offset<IRoleTowerConditionStepSettle> CreateIRoleTowerConditionStepSettle(FlatBufferBuilder builder, ERoleTowerConditionStep Type = ERoleTowerConditionStep.Prepare)
		{
			builder.StartTable(1);
			IRoleTowerConditionStepSettle.AddType(builder, Type);
			return IRoleTowerConditionStepSettle.EndIRoleTowerConditionStepSettle(builder);
		}

		// Token: 0x060199B9 RID: 104889 RVA: 0x003A5F92 File Offset: 0x003A4192
		public static void StartIRoleTowerConditionStepSettle(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060199BA RID: 104890 RVA: 0x003A5F9B File Offset: 0x003A419B
		public static void AddType(FlatBufferBuilder builder, ERoleTowerConditionStep type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060199BB RID: 104891 RVA: 0x003A5FA6 File Offset: 0x003A41A6
		public static Offset<IRoleTowerConditionStepSettle> EndIRoleTowerConditionStepSettle(FlatBufferBuilder builder)
		{
			return new Offset<IRoleTowerConditionStepSettle>(builder.EndTable());
		}

		// Token: 0x060199BC RID: 104892 RVA: 0x003A5FB4 File Offset: 0x003A41B4
		public IRoleTowerConditionStepSettleT UnPack()
		{
			IRoleTowerConditionStepSettleT roleTowerConditionStepSettleT = new IRoleTowerConditionStepSettleT();
			this.UnPackTo(roleTowerConditionStepSettleT);
			return roleTowerConditionStepSettleT;
		}

		// Token: 0x060199BD RID: 104893 RVA: 0x003A5FCF File Offset: 0x003A41CF
		public void UnPackTo(IRoleTowerConditionStepSettleT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060199BE RID: 104894 RVA: 0x003A5FE0 File Offset: 0x003A41E0
		public static Offset<IRoleTowerConditionStepSettle> Pack(FlatBufferBuilder builder, IRoleTowerConditionStepSettleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRoleTowerConditionStepSettle>);
			}
			return IRoleTowerConditionStepSettle.CreateIRoleTowerConditionStepSettle(builder, _o.Type);
		}

		// Token: 0x0400C65F RID: 50783
		private Table __p;
	}
}
