using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004FF5 RID: 20469
	public struct ICheckRogueAbilitySelectCondition : IFlatbufferObject
	{
		// Token: 0x17009272 RID: 37490
		// (get) Token: 0x0601FF07 RID: 130823 RVA: 0x0046F240 File Offset: 0x0046D440
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FF08 RID: 130824 RVA: 0x0046F24D File Offset: 0x0046D44D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FF09 RID: 130825 RVA: 0x0046F254 File Offset: 0x0046D454
		public static ICheckRogueAbilitySelectCondition GetRootAsICheckRogueAbilitySelectCondition(ByteBuffer _bb)
		{
			return ICheckRogueAbilitySelectCondition.GetRootAsICheckRogueAbilitySelectCondition(_bb, default(ICheckRogueAbilitySelectCondition));
		}

		// Token: 0x0601FF0A RID: 130826 RVA: 0x0046F270 File Offset: 0x0046D470
		public static ICheckRogueAbilitySelectCondition GetRootAsICheckRogueAbilitySelectCondition(ByteBuffer _bb, ICheckRogueAbilitySelectCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FF0B RID: 130827 RVA: 0x0046F28D File Offset: 0x0046D48D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FF0C RID: 130828 RVA: 0x0046F29C File Offset: 0x0046D49C
		public ICheckRogueAbilitySelectCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009273 RID: 37491
		// (get) Token: 0x0601FF0D RID: 130829 RVA: 0x0046F2AC File Offset: 0x0046D4AC
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

		// Token: 0x17009274 RID: 37492
		// (get) Token: 0x0601FF0E RID: 130830 RVA: 0x0046F2E8 File Offset: 0x0046D4E8
		public int BoardId
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

		// Token: 0x17009275 RID: 37493
		// (get) Token: 0x0601FF0F RID: 130831 RVA: 0x0046F324 File Offset: 0x0046D524
		public bool IsReceived
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601FF10 RID: 130832 RVA: 0x0046F363 File Offset: 0x0046D563
		public static Offset<ICheckRogueAbilitySelectCondition> CreateICheckRogueAbilitySelectCondition(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int BoardId = 0, bool IsReceived = false)
		{
			builder.StartTable(3);
			ICheckRogueAbilitySelectCondition.AddBoardId(builder, BoardId);
			ICheckRogueAbilitySelectCondition.AddIsReceived(builder, IsReceived);
			ICheckRogueAbilitySelectCondition.AddType(builder, Type);
			return ICheckRogueAbilitySelectCondition.EndICheckRogueAbilitySelectCondition(builder);
		}

		// Token: 0x0601FF11 RID: 130833 RVA: 0x0046F387 File Offset: 0x0046D587
		public static void StartICheckRogueAbilitySelectCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601FF12 RID: 130834 RVA: 0x0046F390 File Offset: 0x0046D590
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601FF13 RID: 130835 RVA: 0x0046F39B File Offset: 0x0046D59B
		public static void AddBoardId(FlatBufferBuilder builder, int boardId)
		{
			builder.AddInt(1, boardId, 0);
		}

		// Token: 0x0601FF14 RID: 130836 RVA: 0x0046F3A6 File Offset: 0x0046D5A6
		public static void AddIsReceived(FlatBufferBuilder builder, bool isReceived)
		{
			builder.AddBool(2, isReceived, false);
		}

		// Token: 0x0601FF15 RID: 130837 RVA: 0x0046F3B1 File Offset: 0x0046D5B1
		public static Offset<ICheckRogueAbilitySelectCondition> EndICheckRogueAbilitySelectCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICheckRogueAbilitySelectCondition>(builder.EndTable());
		}

		// Token: 0x0601FF16 RID: 130838 RVA: 0x0046F3C0 File Offset: 0x0046D5C0
		public ICheckRogueAbilitySelectConditionT UnPack()
		{
			ICheckRogueAbilitySelectConditionT checkRogueAbilitySelectConditionT = new ICheckRogueAbilitySelectConditionT();
			this.UnPackTo(checkRogueAbilitySelectConditionT);
			return checkRogueAbilitySelectConditionT;
		}

		// Token: 0x0601FF17 RID: 130839 RVA: 0x0046F3DB File Offset: 0x0046D5DB
		public void UnPackTo(ICheckRogueAbilitySelectConditionT _o)
		{
			_o.Type = this.Type;
			_o.BoardId = this.BoardId;
			_o.IsReceived = this.IsReceived;
		}

		// Token: 0x0601FF18 RID: 130840 RVA: 0x0046F404 File Offset: 0x0046D604
		public static Offset<ICheckRogueAbilitySelectCondition> Pack(FlatBufferBuilder builder, ICheckRogueAbilitySelectConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckRogueAbilitySelectCondition>);
			}
			return ICheckRogueAbilitySelectCondition.CreateICheckRogueAbilitySelectCondition(builder, _o.Type, _o.BoardId, _o.IsReceived);
		}

		// Token: 0x0400DEA9 RID: 57001
		private Table __p;
	}
}
