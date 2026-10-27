using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020044CA RID: 17610
	public struct IFirstRoundsCondition : IFlatbufferObject
	{
		// Token: 0x17007C4C RID: 31820
		// (get) Token: 0x0601A516 RID: 107798 RVA: 0x003C1FD3 File Offset: 0x003C01D3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A517 RID: 107799 RVA: 0x003C1FE0 File Offset: 0x003C01E0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A518 RID: 107800 RVA: 0x003C1FE8 File Offset: 0x003C01E8
		public static IFirstRoundsCondition GetRootAsIFirstRoundsCondition(ByteBuffer _bb)
		{
			return IFirstRoundsCondition.GetRootAsIFirstRoundsCondition(_bb, default(IFirstRoundsCondition));
		}

		// Token: 0x0601A519 RID: 107801 RVA: 0x003C2004 File Offset: 0x003C0204
		public static IFirstRoundsCondition GetRootAsIFirstRoundsCondition(ByteBuffer _bb, IFirstRoundsCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A51A RID: 107802 RVA: 0x003C2021 File Offset: 0x003C0221
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A51B RID: 107803 RVA: 0x003C2030 File Offset: 0x003C0230
		public IFirstRoundsCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007C4D RID: 31821
		// (get) Token: 0x0601A51C RID: 107804 RVA: 0x003C2040 File Offset: 0x003C0240
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

		// Token: 0x17007C4E RID: 31822
		// (get) Token: 0x0601A51D RID: 107805 RVA: 0x003C207C File Offset: 0x003C027C
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

		// Token: 0x0601A51E RID: 107806 RVA: 0x003C20B8 File Offset: 0x003C02B8
		public static Offset<IFirstRoundsCondition> CreateIFirstRoundsCondition(FlatBufferBuilder builder, EDartSkillConditionType Type = EDartSkillConditionType.RemainScoreGe, int Round = 0)
		{
			builder.StartTable(2);
			IFirstRoundsCondition.AddRound(builder, Round);
			IFirstRoundsCondition.AddType(builder, Type);
			return IFirstRoundsCondition.EndIFirstRoundsCondition(builder);
		}

		// Token: 0x0601A51F RID: 107807 RVA: 0x003C20D5 File Offset: 0x003C02D5
		public static void StartIFirstRoundsCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601A520 RID: 107808 RVA: 0x003C20DE File Offset: 0x003C02DE
		public static void AddType(FlatBufferBuilder builder, EDartSkillConditionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A521 RID: 107809 RVA: 0x003C20E9 File Offset: 0x003C02E9
		public static void AddRound(FlatBufferBuilder builder, int round)
		{
			builder.AddInt(1, round, 0);
		}

		// Token: 0x0601A522 RID: 107810 RVA: 0x003C20F4 File Offset: 0x003C02F4
		public static Offset<IFirstRoundsCondition> EndIFirstRoundsCondition(FlatBufferBuilder builder)
		{
			return new Offset<IFirstRoundsCondition>(builder.EndTable());
		}

		// Token: 0x0601A523 RID: 107811 RVA: 0x003C2104 File Offset: 0x003C0304
		public IFirstRoundsConditionT UnPack()
		{
			IFirstRoundsConditionT firstRoundsConditionT = new IFirstRoundsConditionT();
			this.UnPackTo(firstRoundsConditionT);
			return firstRoundsConditionT;
		}

		// Token: 0x0601A524 RID: 107812 RVA: 0x003C211F File Offset: 0x003C031F
		public void UnPackTo(IFirstRoundsConditionT _o)
		{
			_o.Type = this.Type;
			_o.Round = this.Round;
		}

		// Token: 0x0601A525 RID: 107813 RVA: 0x003C213C File Offset: 0x003C033C
		public static Offset<IFirstRoundsCondition> Pack(FlatBufferBuilder builder, IFirstRoundsConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFirstRoundsCondition>);
			}
			return IFirstRoundsCondition.CreateIFirstRoundsCondition(builder, _o.Type, _o.Round);
		}

		// Token: 0x0400C4E2 RID: 50402
		private Table __p;
	}
}
