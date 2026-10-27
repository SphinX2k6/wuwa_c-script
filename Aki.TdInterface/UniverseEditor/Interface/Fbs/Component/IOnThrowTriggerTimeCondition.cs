using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056A7 RID: 22183
	public struct IOnThrowTriggerTimeCondition : IFlatbufferObject
	{
		// Token: 0x1700A4F6 RID: 42230
		// (get) Token: 0x0602505C RID: 151644 RVA: 0x0051CBD7 File Offset: 0x0051ADD7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602505D RID: 151645 RVA: 0x0051CBE4 File Offset: 0x0051ADE4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602505E RID: 151646 RVA: 0x0051CBEC File Offset: 0x0051ADEC
		public static IOnThrowTriggerTimeCondition GetRootAsIOnThrowTriggerTimeCondition(ByteBuffer _bb)
		{
			return IOnThrowTriggerTimeCondition.GetRootAsIOnThrowTriggerTimeCondition(_bb, default(IOnThrowTriggerTimeCondition));
		}

		// Token: 0x0602505F RID: 151647 RVA: 0x0051CC08 File Offset: 0x0051AE08
		public static IOnThrowTriggerTimeCondition GetRootAsIOnThrowTriggerTimeCondition(ByteBuffer _bb, IOnThrowTriggerTimeCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025060 RID: 151648 RVA: 0x0051CC25 File Offset: 0x0051AE25
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025061 RID: 151649 RVA: 0x0051CC34 File Offset: 0x0051AE34
		public IOnThrowTriggerTimeCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A4F7 RID: 42231
		// (get) Token: 0x06025062 RID: 151650 RVA: 0x0051CC44 File Offset: 0x0051AE44
		public EBulletCreateCondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBulletCreateCondition.OnHit;
				}
				return (EBulletCreateCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A4F8 RID: 42232
		// (get) Token: 0x06025063 RID: 151651 RVA: 0x0051CC80 File Offset: 0x0051AE80
		public long BulletId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0L;
				}
				return this.__p.bb.GetLong(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A4F9 RID: 42233
		// (get) Token: 0x06025064 RID: 151652 RVA: 0x0051CCC0 File Offset: 0x0051AEC0
		public float TriggerTime
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06025065 RID: 151653 RVA: 0x0051CD00 File Offset: 0x0051AF00
		public static Offset<IOnThrowTriggerTimeCondition> CreateIOnThrowTriggerTimeCondition(FlatBufferBuilder builder, EBulletCreateCondition Type = EBulletCreateCondition.OnHit, long BulletId = 0L, float TriggerTime = 0f)
		{
			builder.StartTable(3);
			IOnThrowTriggerTimeCondition.AddBulletId(builder, BulletId);
			IOnThrowTriggerTimeCondition.AddTriggerTime(builder, TriggerTime);
			IOnThrowTriggerTimeCondition.AddType(builder, Type);
			return IOnThrowTriggerTimeCondition.EndIOnThrowTriggerTimeCondition(builder);
		}

		// Token: 0x06025066 RID: 151654 RVA: 0x0051CD24 File Offset: 0x0051AF24
		public static void StartIOnThrowTriggerTimeCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06025067 RID: 151655 RVA: 0x0051CD2D File Offset: 0x0051AF2D
		public static void AddType(FlatBufferBuilder builder, EBulletCreateCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06025068 RID: 151656 RVA: 0x0051CD38 File Offset: 0x0051AF38
		public static void AddBulletId(FlatBufferBuilder builder, long bulletId)
		{
			builder.AddLong(1, bulletId, 0L);
		}

		// Token: 0x06025069 RID: 151657 RVA: 0x0051CD44 File Offset: 0x0051AF44
		public static void AddTriggerTime(FlatBufferBuilder builder, float triggerTime)
		{
			builder.AddFloat(2, triggerTime, 0.0);
		}

		// Token: 0x0602506A RID: 151658 RVA: 0x0051CD57 File Offset: 0x0051AF57
		public static Offset<IOnThrowTriggerTimeCondition> EndIOnThrowTriggerTimeCondition(FlatBufferBuilder builder)
		{
			return new Offset<IOnThrowTriggerTimeCondition>(builder.EndTable());
		}

		// Token: 0x0602506B RID: 151659 RVA: 0x0051CD64 File Offset: 0x0051AF64
		public IOnThrowTriggerTimeConditionT UnPack()
		{
			IOnThrowTriggerTimeConditionT onThrowTriggerTimeConditionT = new IOnThrowTriggerTimeConditionT();
			this.UnPackTo(onThrowTriggerTimeConditionT);
			return onThrowTriggerTimeConditionT;
		}

		// Token: 0x0602506C RID: 151660 RVA: 0x0051CD7F File Offset: 0x0051AF7F
		public void UnPackTo(IOnThrowTriggerTimeConditionT _o)
		{
			_o.Type = this.Type;
			_o.BulletId = this.BulletId;
			_o.TriggerTime = this.TriggerTime;
		}

		// Token: 0x0602506D RID: 151661 RVA: 0x0051CDA8 File Offset: 0x0051AFA8
		public static Offset<IOnThrowTriggerTimeCondition> Pack(FlatBufferBuilder builder, IOnThrowTriggerTimeConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOnThrowTriggerTimeCondition>);
			}
			return IOnThrowTriggerTimeCondition.CreateIOnThrowTriggerTimeCondition(builder, _o.Type, _o.BulletId, _o.TriggerTime);
		}

		// Token: 0x0400EACB RID: 60107
		private Table __p;
	}
}
