using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B07 RID: 23303
	public struct IMonsterCombatInteractionFrequencyPaint : IFlatbufferObject
	{
		// Token: 0x1700AA0B RID: 43531
		// (get) Token: 0x060264A2 RID: 156834 RVA: 0x0053EDC0 File Offset: 0x0053CFC0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060264A3 RID: 156835 RVA: 0x0053EDCD File Offset: 0x0053CFCD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060264A4 RID: 156836 RVA: 0x0053EDD4 File Offset: 0x0053CFD4
		public static IMonsterCombatInteractionFrequencyPaint GetRootAsIMonsterCombatInteractionFrequencyPaint(ByteBuffer _bb)
		{
			return IMonsterCombatInteractionFrequencyPaint.GetRootAsIMonsterCombatInteractionFrequencyPaint(_bb, default(IMonsterCombatInteractionFrequencyPaint));
		}

		// Token: 0x060264A5 RID: 156837 RVA: 0x0053EDF0 File Offset: 0x0053CFF0
		public static IMonsterCombatInteractionFrequencyPaint GetRootAsIMonsterCombatInteractionFrequencyPaint(ByteBuffer _bb, IMonsterCombatInteractionFrequencyPaint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060264A6 RID: 156838 RVA: 0x0053EE0D File Offset: 0x0053D00D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060264A7 RID: 156839 RVA: 0x0053EE1C File Offset: 0x0053D01C
		public IMonsterCombatInteractionFrequencyPaint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AA0C RID: 43532
		// (get) Token: 0x060264A8 RID: 156840 RVA: 0x0053EE2C File Offset: 0x0053D02C
		public EMonsterCombatInteractionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMonsterCombatInteractionType.WaterBoxStagnation;
				}
				return (EMonsterCombatInteractionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AA0D RID: 43533
		// (get) Token: 0x060264A9 RID: 156841 RVA: 0x0053EE68 File Offset: 0x0053D068
		public int FrequencyPaintTableId
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

		// Token: 0x060264AA RID: 156842 RVA: 0x0053EEA4 File Offset: 0x0053D0A4
		public static Offset<IMonsterCombatInteractionFrequencyPaint> CreateIMonsterCombatInteractionFrequencyPaint(FlatBufferBuilder builder, EMonsterCombatInteractionType Type = EMonsterCombatInteractionType.WaterBoxStagnation, int FrequencyPaintTableId = 0)
		{
			builder.StartTable(2);
			IMonsterCombatInteractionFrequencyPaint.AddFrequencyPaintTableId(builder, FrequencyPaintTableId);
			IMonsterCombatInteractionFrequencyPaint.AddType(builder, Type);
			return IMonsterCombatInteractionFrequencyPaint.EndIMonsterCombatInteractionFrequencyPaint(builder);
		}

		// Token: 0x060264AB RID: 156843 RVA: 0x0053EEC1 File Offset: 0x0053D0C1
		public static void StartIMonsterCombatInteractionFrequencyPaint(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060264AC RID: 156844 RVA: 0x0053EECA File Offset: 0x0053D0CA
		public static void AddType(FlatBufferBuilder builder, EMonsterCombatInteractionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060264AD RID: 156845 RVA: 0x0053EED5 File Offset: 0x0053D0D5
		public static void AddFrequencyPaintTableId(FlatBufferBuilder builder, int frequencyPaintTableId)
		{
			builder.AddInt(1, frequencyPaintTableId, 0);
		}

		// Token: 0x060264AE RID: 156846 RVA: 0x0053EEE0 File Offset: 0x0053D0E0
		public static Offset<IMonsterCombatInteractionFrequencyPaint> EndIMonsterCombatInteractionFrequencyPaint(FlatBufferBuilder builder)
		{
			return new Offset<IMonsterCombatInteractionFrequencyPaint>(builder.EndTable());
		}

		// Token: 0x060264AF RID: 156847 RVA: 0x0053EEF0 File Offset: 0x0053D0F0
		public IMonsterCombatInteractionFrequencyPaintT UnPack()
		{
			IMonsterCombatInteractionFrequencyPaintT monsterCombatInteractionFrequencyPaintT = new IMonsterCombatInteractionFrequencyPaintT();
			this.UnPackTo(monsterCombatInteractionFrequencyPaintT);
			return monsterCombatInteractionFrequencyPaintT;
		}

		// Token: 0x060264B0 RID: 156848 RVA: 0x0053EF0B File Offset: 0x0053D10B
		public void UnPackTo(IMonsterCombatInteractionFrequencyPaintT _o)
		{
			_o.Type = this.Type;
			_o.FrequencyPaintTableId = this.FrequencyPaintTableId;
		}

		// Token: 0x060264B1 RID: 156849 RVA: 0x0053EF28 File Offset: 0x0053D128
		public static Offset<IMonsterCombatInteractionFrequencyPaint> Pack(FlatBufferBuilder builder, IMonsterCombatInteractionFrequencyPaintT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMonsterCombatInteractionFrequencyPaint>);
			}
			return IMonsterCombatInteractionFrequencyPaint.CreateIMonsterCombatInteractionFrequencyPaint(builder, _o.Type, _o.FrequencyPaintTableId);
		}

		// Token: 0x0400F4ED RID: 62701
		private Table __p;
	}
}
