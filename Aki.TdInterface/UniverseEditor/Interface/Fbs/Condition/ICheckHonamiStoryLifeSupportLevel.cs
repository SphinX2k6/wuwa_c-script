using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A5D RID: 19037
	public struct ICheckHonamiStoryLifeSupportLevel : IFlatbufferObject
	{
		// Token: 0x170089D1 RID: 35281
		// (get) Token: 0x0601DD10 RID: 122128 RVA: 0x00430B8E File Offset: 0x0042ED8E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DD11 RID: 122129 RVA: 0x00430B9B File Offset: 0x0042ED9B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DD12 RID: 122130 RVA: 0x00430BA4 File Offset: 0x0042EDA4
		public static ICheckHonamiStoryLifeSupportLevel GetRootAsICheckHonamiStoryLifeSupportLevel(ByteBuffer _bb)
		{
			return ICheckHonamiStoryLifeSupportLevel.GetRootAsICheckHonamiStoryLifeSupportLevel(_bb, default(ICheckHonamiStoryLifeSupportLevel));
		}

		// Token: 0x0601DD13 RID: 122131 RVA: 0x00430BC0 File Offset: 0x0042EDC0
		public static ICheckHonamiStoryLifeSupportLevel GetRootAsICheckHonamiStoryLifeSupportLevel(ByteBuffer _bb, ICheckHonamiStoryLifeSupportLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DD14 RID: 122132 RVA: 0x00430BDD File Offset: 0x0042EDDD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DD15 RID: 122133 RVA: 0x00430BEC File Offset: 0x0042EDEC
		public ICheckHonamiStoryLifeSupportLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170089D2 RID: 35282
		// (get) Token: 0x0601DD16 RID: 122134 RVA: 0x00430BFC File Offset: 0x0042EDFC
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

		// Token: 0x170089D3 RID: 35283
		// (get) Token: 0x0601DD17 RID: 122135 RVA: 0x00430C38 File Offset: 0x0042EE38
		public int ActivityId
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

		// Token: 0x170089D4 RID: 35284
		// (get) Token: 0x0601DD18 RID: 122136 RVA: 0x00430C74 File Offset: 0x0042EE74
		public ECompare Compare
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170089D5 RID: 35285
		// (get) Token: 0x0601DD19 RID: 122137 RVA: 0x00430CB0 File Offset: 0x0042EEB0
		public int Level
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601DD1A RID: 122138 RVA: 0x00430CED File Offset: 0x0042EEED
		public static Offset<ICheckHonamiStoryLifeSupportLevel> CreateICheckHonamiStoryLifeSupportLevel(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int ActivityId = 0, ECompare Compare = ECompare.Eq, int Level = 0)
		{
			builder.StartTable(4);
			ICheckHonamiStoryLifeSupportLevel.AddLevel(builder, Level);
			ICheckHonamiStoryLifeSupportLevel.AddActivityId(builder, ActivityId);
			ICheckHonamiStoryLifeSupportLevel.AddCompare(builder, Compare);
			ICheckHonamiStoryLifeSupportLevel.AddType(builder, Type);
			return ICheckHonamiStoryLifeSupportLevel.EndICheckHonamiStoryLifeSupportLevel(builder);
		}

		// Token: 0x0601DD1B RID: 122139 RVA: 0x00430D19 File Offset: 0x0042EF19
		public static void StartICheckHonamiStoryLifeSupportLevel(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601DD1C RID: 122140 RVA: 0x00430D22 File Offset: 0x0042EF22
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601DD1D RID: 122141 RVA: 0x00430D2D File Offset: 0x0042EF2D
		public static void AddActivityId(FlatBufferBuilder builder, int activityId)
		{
			builder.AddInt(1, activityId, 0);
		}

		// Token: 0x0601DD1E RID: 122142 RVA: 0x00430D38 File Offset: 0x0042EF38
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(2, (byte)compare, 0);
		}

		// Token: 0x0601DD1F RID: 122143 RVA: 0x00430D43 File Offset: 0x0042EF43
		public static void AddLevel(FlatBufferBuilder builder, int level)
		{
			builder.AddInt(3, level, 0);
		}

		// Token: 0x0601DD20 RID: 122144 RVA: 0x00430D4E File Offset: 0x0042EF4E
		public static Offset<ICheckHonamiStoryLifeSupportLevel> EndICheckHonamiStoryLifeSupportLevel(FlatBufferBuilder builder)
		{
			return new Offset<ICheckHonamiStoryLifeSupportLevel>(builder.EndTable());
		}

		// Token: 0x0601DD21 RID: 122145 RVA: 0x00430D5C File Offset: 0x0042EF5C
		public ICheckHonamiStoryLifeSupportLevelT UnPack()
		{
			ICheckHonamiStoryLifeSupportLevelT checkHonamiStoryLifeSupportLevelT = new ICheckHonamiStoryLifeSupportLevelT();
			this.UnPackTo(checkHonamiStoryLifeSupportLevelT);
			return checkHonamiStoryLifeSupportLevelT;
		}

		// Token: 0x0601DD22 RID: 122146 RVA: 0x00430D77 File Offset: 0x0042EF77
		public void UnPackTo(ICheckHonamiStoryLifeSupportLevelT _o)
		{
			_o.Type = this.Type;
			_o.ActivityId = this.ActivityId;
			_o.Compare = this.Compare;
			_o.Level = this.Level;
		}

		// Token: 0x0601DD23 RID: 122147 RVA: 0x00430DAC File Offset: 0x0042EFAC
		public static Offset<ICheckHonamiStoryLifeSupportLevel> Pack(FlatBufferBuilder builder, ICheckHonamiStoryLifeSupportLevelT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckHonamiStoryLifeSupportLevel>);
			}
			return ICheckHonamiStoryLifeSupportLevel.CreateICheckHonamiStoryLifeSupportLevel(builder, _o.Type, _o.ActivityId, _o.Compare, _o.Level);
		}

		// Token: 0x0400D2BB RID: 53947
		private Table __p;
	}
}
