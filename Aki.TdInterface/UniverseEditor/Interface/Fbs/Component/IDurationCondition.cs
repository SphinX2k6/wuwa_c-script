using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050CF RID: 20687
	public struct IDurationCondition : IFlatbufferObject
	{
		// Token: 0x1700968C RID: 38540
		// (get) Token: 0x06021477 RID: 136311 RVA: 0x0049F588 File Offset: 0x0049D788
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021478 RID: 136312 RVA: 0x0049F595 File Offset: 0x0049D795
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021479 RID: 136313 RVA: 0x0049F59C File Offset: 0x0049D79C
		public static IDurationCondition GetRootAsIDurationCondition(ByteBuffer _bb)
		{
			return IDurationCondition.GetRootAsIDurationCondition(_bb, default(IDurationCondition));
		}

		// Token: 0x0602147A RID: 136314 RVA: 0x0049F5B8 File Offset: 0x0049D7B8
		public static IDurationCondition GetRootAsIDurationCondition(ByteBuffer _bb, IDurationCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602147B RID: 136315 RVA: 0x0049F5D5 File Offset: 0x0049D7D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602147C RID: 136316 RVA: 0x0049F5E4 File Offset: 0x0049D7E4
		public IDurationCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700968D RID: 38541
		// (get) Token: 0x0602147D RID: 136317 RVA: 0x0049F5F4 File Offset: 0x0049D7F4
		public ESpawnMonsterCompleteCondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESpawnMonsterCompleteCondition.AllKill;
				}
				return (ESpawnMonsterCompleteCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700968E RID: 38542
		// (get) Token: 0x0602147E RID: 136318 RVA: 0x0049F630 File Offset: 0x0049D830
		public float Duration
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700968F RID: 38543
		// (get) Token: 0x0602147F RID: 136319 RVA: 0x0049F670 File Offset: 0x0049D870
		public bool Refill
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009690 RID: 38544
		// (get) Token: 0x06021480 RID: 136320 RVA: 0x0049F6B0 File Offset: 0x0049D8B0
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06021481 RID: 136321 RVA: 0x0049F6ED File Offset: 0x0049D8ED
		public static Offset<IDurationCondition> CreateIDurationCondition(FlatBufferBuilder builder, ESpawnMonsterCompleteCondition Type = ESpawnMonsterCompleteCondition.AllKill, float Duration = 0f, bool Refill = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			IDurationCondition.AddDuration(builder, Duration);
			IDurationCondition.AddNullMask(builder, NullMask);
			IDurationCondition.AddRefill(builder, Refill);
			IDurationCondition.AddType(builder, Type);
			return IDurationCondition.EndIDurationCondition(builder);
		}

		// Token: 0x06021482 RID: 136322 RVA: 0x0049F719 File Offset: 0x0049D919
		public static void StartIDurationCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06021483 RID: 136323 RVA: 0x0049F722 File Offset: 0x0049D922
		public static void AddType(FlatBufferBuilder builder, ESpawnMonsterCompleteCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06021484 RID: 136324 RVA: 0x0049F72D File Offset: 0x0049D92D
		public static void AddDuration(FlatBufferBuilder builder, float duration)
		{
			builder.AddFloat(1, duration, 0.0);
		}

		// Token: 0x06021485 RID: 136325 RVA: 0x0049F740 File Offset: 0x0049D940
		public static void AddRefill(FlatBufferBuilder builder, bool refill)
		{
			builder.AddBool(2, refill, false);
		}

		// Token: 0x06021486 RID: 136326 RVA: 0x0049F74B File Offset: 0x0049D94B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06021487 RID: 136327 RVA: 0x0049F756 File Offset: 0x0049D956
		public static Offset<IDurationCondition> EndIDurationCondition(FlatBufferBuilder builder)
		{
			return new Offset<IDurationCondition>(builder.EndTable());
		}

		// Token: 0x06021488 RID: 136328 RVA: 0x0049F764 File Offset: 0x0049D964
		public IDurationConditionT UnPack()
		{
			IDurationConditionT durationConditionT = new IDurationConditionT();
			this.UnPackTo(durationConditionT);
			return durationConditionT;
		}

		// Token: 0x06021489 RID: 136329 RVA: 0x0049F77F File Offset: 0x0049D97F
		public void UnPackTo(IDurationConditionT _o)
		{
			_o.Type = this.Type;
			_o.Duration = this.Duration;
			_o.Refill = this.Refill;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602148A RID: 136330 RVA: 0x0049F7B4 File Offset: 0x0049D9B4
		public static Offset<IDurationCondition> Pack(FlatBufferBuilder builder, IDurationConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDurationCondition>);
			}
			return IDurationCondition.CreateIDurationCondition(builder, _o.Type, _o.Duration, _o.Refill, _o.NullMask);
		}

		// Token: 0x0400E115 RID: 57621
		private Table __p;
	}
}
