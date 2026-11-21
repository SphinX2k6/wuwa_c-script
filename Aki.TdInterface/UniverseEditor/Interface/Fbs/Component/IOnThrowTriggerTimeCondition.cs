using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C4B RID: 23627
	public struct IOnThrowTriggerTimeCondition : IFlatbufferObject
	{
		// Token: 0x1700AD8A RID: 44426
		// (get) Token: 0x060272B1 RID: 160433 RVA: 0x0055DB1F File Offset: 0x0055BD1F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060272B2 RID: 160434 RVA: 0x0055DB2C File Offset: 0x0055BD2C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060272B3 RID: 160435 RVA: 0x0055DB34 File Offset: 0x0055BD34
		public static IOnThrowTriggerTimeCondition GetRootAsIOnThrowTriggerTimeCondition(ByteBuffer _bb)
		{
			return IOnThrowTriggerTimeCondition.GetRootAsIOnThrowTriggerTimeCondition(_bb, default(IOnThrowTriggerTimeCondition));
		}

		// Token: 0x060272B4 RID: 160436 RVA: 0x0055DB50 File Offset: 0x0055BD50
		public static IOnThrowTriggerTimeCondition GetRootAsIOnThrowTriggerTimeCondition(ByteBuffer _bb, IOnThrowTriggerTimeCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060272B5 RID: 160437 RVA: 0x0055DB6D File Offset: 0x0055BD6D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060272B6 RID: 160438 RVA: 0x0055DB7C File Offset: 0x0055BD7C
		public IOnThrowTriggerTimeCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AD8B RID: 44427
		// (get) Token: 0x060272B7 RID: 160439 RVA: 0x0055DB8C File Offset: 0x0055BD8C
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

		// Token: 0x1700AD8C RID: 44428
		// (get) Token: 0x060272B8 RID: 160440 RVA: 0x0055DBC8 File Offset: 0x0055BDC8
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

		// Token: 0x1700AD8D RID: 44429
		// (get) Token: 0x060272B9 RID: 160441 RVA: 0x0055DC08 File Offset: 0x0055BE08
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

		// Token: 0x060272BA RID: 160442 RVA: 0x0055DC48 File Offset: 0x0055BE48
		public static Offset<IOnThrowTriggerTimeCondition> CreateIOnThrowTriggerTimeCondition(FlatBufferBuilder builder, EBulletCreateCondition Type = EBulletCreateCondition.OnHit, long BulletId = 0L, float TriggerTime = 0f)
		{
			builder.StartTable(3);
			IOnThrowTriggerTimeCondition.AddBulletId(builder, BulletId);
			IOnThrowTriggerTimeCondition.AddTriggerTime(builder, TriggerTime);
			IOnThrowTriggerTimeCondition.AddType(builder, Type);
			return IOnThrowTriggerTimeCondition.EndIOnThrowTriggerTimeCondition(builder);
		}

		// Token: 0x060272BB RID: 160443 RVA: 0x0055DC6C File Offset: 0x0055BE6C
		public static void StartIOnThrowTriggerTimeCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060272BC RID: 160444 RVA: 0x0055DC75 File Offset: 0x0055BE75
		public static void AddType(FlatBufferBuilder builder, EBulletCreateCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060272BD RID: 160445 RVA: 0x0055DC80 File Offset: 0x0055BE80
		public static void AddBulletId(FlatBufferBuilder builder, long bulletId)
		{
			builder.AddLong(1, bulletId, 0L);
		}

		// Token: 0x060272BE RID: 160446 RVA: 0x0055DC8C File Offset: 0x0055BE8C
		public static void AddTriggerTime(FlatBufferBuilder builder, float triggerTime)
		{
			builder.AddFloat(2, triggerTime, 0.0);
		}

		// Token: 0x060272BF RID: 160447 RVA: 0x0055DC9F File Offset: 0x0055BE9F
		public static Offset<IOnThrowTriggerTimeCondition> EndIOnThrowTriggerTimeCondition(FlatBufferBuilder builder)
		{
			return new Offset<IOnThrowTriggerTimeCondition>(builder.EndTable());
		}

		// Token: 0x060272C0 RID: 160448 RVA: 0x0055DCAC File Offset: 0x0055BEAC
		public IOnThrowTriggerTimeConditionT UnPack()
		{
			IOnThrowTriggerTimeConditionT onThrowTriggerTimeConditionT = new IOnThrowTriggerTimeConditionT();
			this.UnPackTo(onThrowTriggerTimeConditionT);
			return onThrowTriggerTimeConditionT;
		}

		// Token: 0x060272C1 RID: 160449 RVA: 0x0055DCC7 File Offset: 0x0055BEC7
		public void UnPackTo(IOnThrowTriggerTimeConditionT _o)
		{
			_o.Type = this.Type;
			_o.BulletId = this.BulletId;
			_o.TriggerTime = this.TriggerTime;
		}

		// Token: 0x060272C2 RID: 160450 RVA: 0x0055DCF0 File Offset: 0x0055BEF0
		public static Offset<IOnThrowTriggerTimeCondition> Pack(FlatBufferBuilder builder, IOnThrowTriggerTimeConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOnThrowTriggerTimeCondition>);
			}
			return IOnThrowTriggerTimeCondition.CreateIOnThrowTriggerTimeCondition(builder, _o.Type, _o.BulletId, _o.TriggerTime);
		}

		// Token: 0x0400F737 RID: 63287
		private Table __p;
	}
}
