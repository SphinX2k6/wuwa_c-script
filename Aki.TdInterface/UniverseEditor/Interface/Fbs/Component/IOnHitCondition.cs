using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200569B RID: 22171
	public struct IOnHitCondition : IFlatbufferObject
	{
		// Token: 0x1700A4E2 RID: 42210
		// (get) Token: 0x06025004 RID: 151556 RVA: 0x0051C3D7 File Offset: 0x0051A5D7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025005 RID: 151557 RVA: 0x0051C3E4 File Offset: 0x0051A5E4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025006 RID: 151558 RVA: 0x0051C3EC File Offset: 0x0051A5EC
		public static IOnHitCondition GetRootAsIOnHitCondition(ByteBuffer _bb)
		{
			return IOnHitCondition.GetRootAsIOnHitCondition(_bb, default(IOnHitCondition));
		}

		// Token: 0x06025007 RID: 151559 RVA: 0x0051C408 File Offset: 0x0051A608
		public static IOnHitCondition GetRootAsIOnHitCondition(ByteBuffer _bb, IOnHitCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025008 RID: 151560 RVA: 0x0051C425 File Offset: 0x0051A625
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025009 RID: 151561 RVA: 0x0051C434 File Offset: 0x0051A634
		public IOnHitCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A4E3 RID: 42211
		// (get) Token: 0x0602500A RID: 151562 RVA: 0x0051C444 File Offset: 0x0051A644
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

		// Token: 0x1700A4E4 RID: 42212
		// (get) Token: 0x0602500B RID: 151563 RVA: 0x0051C480 File Offset: 0x0051A680
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

		// Token: 0x0602500C RID: 151564 RVA: 0x0051C4BD File Offset: 0x0051A6BD
		public static Offset<IOnHitCondition> CreateIOnHitCondition(FlatBufferBuilder builder, EBulletCreateCondition Type = EBulletCreateCondition.OnHit, long BulletId = 0L)
		{
			builder.StartTable(2);
			IOnHitCondition.AddBulletId(builder, BulletId);
			IOnHitCondition.AddType(builder, Type);
			return IOnHitCondition.EndIOnHitCondition(builder);
		}

		// Token: 0x0602500D RID: 151565 RVA: 0x0051C4DA File Offset: 0x0051A6DA
		public static void StartIOnHitCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602500E RID: 151566 RVA: 0x0051C4E3 File Offset: 0x0051A6E3
		public static void AddType(FlatBufferBuilder builder, EBulletCreateCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602500F RID: 151567 RVA: 0x0051C4EE File Offset: 0x0051A6EE
		public static void AddBulletId(FlatBufferBuilder builder, long bulletId)
		{
			builder.AddLong(1, bulletId, 0L);
		}

		// Token: 0x06025010 RID: 151568 RVA: 0x0051C4FA File Offset: 0x0051A6FA
		public static Offset<IOnHitCondition> EndIOnHitCondition(FlatBufferBuilder builder)
		{
			return new Offset<IOnHitCondition>(builder.EndTable());
		}

		// Token: 0x06025011 RID: 151569 RVA: 0x0051C508 File Offset: 0x0051A708
		public IOnHitConditionT UnPack()
		{
			IOnHitConditionT onHitConditionT = new IOnHitConditionT();
			this.UnPackTo(onHitConditionT);
			return onHitConditionT;
		}

		// Token: 0x06025012 RID: 151570 RVA: 0x0051C523 File Offset: 0x0051A723
		public void UnPackTo(IOnHitConditionT _o)
		{
			_o.Type = this.Type;
			_o.BulletId = this.BulletId;
		}

		// Token: 0x06025013 RID: 151571 RVA: 0x0051C540 File Offset: 0x0051A740
		public static Offset<IOnHitCondition> Pack(FlatBufferBuilder builder, IOnHitConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOnHitCondition>);
			}
			return IOnHitCondition.CreateIOnHitCondition(builder, _o.Type, _o.BulletId);
		}

		// Token: 0x0400EABF RID: 60095
		private Table __p;
	}
}
