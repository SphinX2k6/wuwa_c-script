using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005634 RID: 22068
	public struct IDurationCondition : IFlatbufferObject
	{
		// Token: 0x17009E79 RID: 40569
		// (get) Token: 0x060233CB RID: 144331 RVA: 0x004D9514 File Offset: 0x004D7714
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060233CC RID: 144332 RVA: 0x004D9521 File Offset: 0x004D7721
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060233CD RID: 144333 RVA: 0x004D9528 File Offset: 0x004D7728
		public static IDurationCondition GetRootAsIDurationCondition(ByteBuffer _bb)
		{
			return IDurationCondition.GetRootAsIDurationCondition(_bb, default(IDurationCondition));
		}

		// Token: 0x060233CE RID: 144334 RVA: 0x004D9544 File Offset: 0x004D7744
		public static IDurationCondition GetRootAsIDurationCondition(ByteBuffer _bb, IDurationCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060233CF RID: 144335 RVA: 0x004D9561 File Offset: 0x004D7761
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060233D0 RID: 144336 RVA: 0x004D9570 File Offset: 0x004D7770
		public IDurationCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009E7A RID: 40570
		// (get) Token: 0x060233D1 RID: 144337 RVA: 0x004D9580 File Offset: 0x004D7780
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

		// Token: 0x17009E7B RID: 40571
		// (get) Token: 0x060233D2 RID: 144338 RVA: 0x004D95BC File Offset: 0x004D77BC
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

		// Token: 0x17009E7C RID: 40572
		// (get) Token: 0x060233D3 RID: 144339 RVA: 0x004D95FC File Offset: 0x004D77FC
		public bool Refill
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009E7D RID: 40573
		// (get) Token: 0x060233D4 RID: 144340 RVA: 0x004D963C File Offset: 0x004D783C
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

		// Token: 0x060233D5 RID: 144341 RVA: 0x004D9679 File Offset: 0x004D7879
		public static Offset<IDurationCondition> CreateIDurationCondition(FlatBufferBuilder builder, ESpawnMonsterCompleteCondition Type = ESpawnMonsterCompleteCondition.AllKill, float Duration = 0f, bool Refill = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			IDurationCondition.AddDuration(builder, Duration);
			IDurationCondition.AddNullMask(builder, NullMask);
			IDurationCondition.AddRefill(builder, Refill);
			IDurationCondition.AddType(builder, Type);
			return IDurationCondition.EndIDurationCondition(builder);
		}

		// Token: 0x060233D6 RID: 144342 RVA: 0x004D96A5 File Offset: 0x004D78A5
		public static void StartIDurationCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060233D7 RID: 144343 RVA: 0x004D96AE File Offset: 0x004D78AE
		public static void AddType(FlatBufferBuilder builder, ESpawnMonsterCompleteCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060233D8 RID: 144344 RVA: 0x004D96B9 File Offset: 0x004D78B9
		public static void AddDuration(FlatBufferBuilder builder, float duration)
		{
			builder.AddFloat(1, duration, 0.0);
		}

		// Token: 0x060233D9 RID: 144345 RVA: 0x004D96CC File Offset: 0x004D78CC
		public static void AddRefill(FlatBufferBuilder builder, bool refill)
		{
			builder.AddBool(2, refill, false);
		}

		// Token: 0x060233DA RID: 144346 RVA: 0x004D96D7 File Offset: 0x004D78D7
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x060233DB RID: 144347 RVA: 0x004D96E2 File Offset: 0x004D78E2
		public static Offset<IDurationCondition> EndIDurationCondition(FlatBufferBuilder builder)
		{
			return new Offset<IDurationCondition>(builder.EndTable());
		}

		// Token: 0x060233DC RID: 144348 RVA: 0x004D96F0 File Offset: 0x004D78F0
		public IDurationConditionT UnPack()
		{
			IDurationConditionT durationConditionT = new IDurationConditionT();
			this.UnPackTo(durationConditionT);
			return durationConditionT;
		}

		// Token: 0x060233DD RID: 144349 RVA: 0x004D970B File Offset: 0x004D790B
		public void UnPackTo(IDurationConditionT _o)
		{
			_o.Type = this.Type;
			_o.Duration = this.Duration;
			_o.Refill = this.Refill;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060233DE RID: 144350 RVA: 0x004D9740 File Offset: 0x004D7940
		public static Offset<IDurationCondition> Pack(FlatBufferBuilder builder, IDurationConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDurationCondition>);
			}
			return IDurationCondition.CreateIDurationCondition(builder, _o.Type, _o.Duration, _o.Refill, _o.NullMask);
		}

		// Token: 0x0400ED12 RID: 60690
		private Table __p;
	}
}
