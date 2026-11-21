using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004932 RID: 18738
	public struct IFirstRoundsCondition : IFlatbufferObject
	{
		// Token: 0x1700828B RID: 33419
		// (get) Token: 0x0601BCE7 RID: 113895 RVA: 0x003EE1DF File Offset: 0x003EC3DF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601BCE8 RID: 113896 RVA: 0x003EE1EC File Offset: 0x003EC3EC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601BCE9 RID: 113897 RVA: 0x003EE1F4 File Offset: 0x003EC3F4
		public static IFirstRoundsCondition GetRootAsIFirstRoundsCondition(ByteBuffer _bb)
		{
			return IFirstRoundsCondition.GetRootAsIFirstRoundsCondition(_bb, default(IFirstRoundsCondition));
		}

		// Token: 0x0601BCEA RID: 113898 RVA: 0x003EE210 File Offset: 0x003EC410
		public static IFirstRoundsCondition GetRootAsIFirstRoundsCondition(ByteBuffer _bb, IFirstRoundsCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601BCEB RID: 113899 RVA: 0x003EE22D File Offset: 0x003EC42D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601BCEC RID: 113900 RVA: 0x003EE23C File Offset: 0x003EC43C
		public IFirstRoundsCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700828C RID: 33420
		// (get) Token: 0x0601BCED RID: 113901 RVA: 0x003EE24C File Offset: 0x003EC44C
		public EDartSkillConditionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EDartSkillConditionType.RemainScoreGe;
				}
				return (EDartSkillConditionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700828D RID: 33421
		// (get) Token: 0x0601BCEE RID: 113902 RVA: 0x003EE288 File Offset: 0x003EC488
		public int Round
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

		// Token: 0x0601BCEF RID: 113903 RVA: 0x003EE2C4 File Offset: 0x003EC4C4
		public static Offset<IFirstRoundsCondition> CreateIFirstRoundsCondition(FlatBufferBuilder builder, EDartSkillConditionType Type = EDartSkillConditionType.RemainScoreGe, int Round = 0)
		{
			builder.StartTable(2);
			IFirstRoundsCondition.AddRound(builder, Round);
			IFirstRoundsCondition.AddType(builder, Type);
			return IFirstRoundsCondition.EndIFirstRoundsCondition(builder);
		}

		// Token: 0x0601BCF0 RID: 113904 RVA: 0x003EE2E1 File Offset: 0x003EC4E1
		public static void StartIFirstRoundsCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601BCF1 RID: 113905 RVA: 0x003EE2EA File Offset: 0x003EC4EA
		public static void AddType(FlatBufferBuilder builder, EDartSkillConditionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601BCF2 RID: 113906 RVA: 0x003EE2F5 File Offset: 0x003EC4F5
		public static void AddRound(FlatBufferBuilder builder, int round)
		{
			builder.AddInt(1, round, 0);
		}

		// Token: 0x0601BCF3 RID: 113907 RVA: 0x003EE300 File Offset: 0x003EC500
		public static Offset<IFirstRoundsCondition> EndIFirstRoundsCondition(FlatBufferBuilder builder)
		{
			return new Offset<IFirstRoundsCondition>(builder.EndTable());
		}

		// Token: 0x0601BCF4 RID: 113908 RVA: 0x003EE310 File Offset: 0x003EC510
		public IFirstRoundsConditionT UnPack()
		{
			IFirstRoundsConditionT firstRoundsConditionT = new IFirstRoundsConditionT();
			this.UnPackTo(firstRoundsConditionT);
			return firstRoundsConditionT;
		}

		// Token: 0x0601BCF5 RID: 113909 RVA: 0x003EE32B File Offset: 0x003EC52B
		public void UnPackTo(IFirstRoundsConditionT _o)
		{
			_o.Type = this.Type;
			_o.Round = this.Round;
		}

		// Token: 0x0601BCF6 RID: 113910 RVA: 0x003EE348 File Offset: 0x003EC548
		public static Offset<IFirstRoundsCondition> Pack(FlatBufferBuilder builder, IFirstRoundsConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFirstRoundsCondition>);
			}
			return IFirstRoundsCondition.CreateIFirstRoundsCondition(builder, _o.Type, _o.Round);
		}

		// Token: 0x0400CF10 RID: 53008
		private Table __p;
	}
}
