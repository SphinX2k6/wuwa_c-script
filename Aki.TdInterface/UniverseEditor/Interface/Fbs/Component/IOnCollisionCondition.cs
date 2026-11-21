using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C36 RID: 23606
	public struct IOnCollisionCondition : IFlatbufferObject
	{
		// Token: 0x1700AD5F RID: 44383
		// (get) Token: 0x060271FD RID: 160253 RVA: 0x0055C7AB File Offset: 0x0055A9AB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060271FE RID: 160254 RVA: 0x0055C7B8 File Offset: 0x0055A9B8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060271FF RID: 160255 RVA: 0x0055C7C0 File Offset: 0x0055A9C0
		public static IOnCollisionCondition GetRootAsIOnCollisionCondition(ByteBuffer _bb)
		{
			return IOnCollisionCondition.GetRootAsIOnCollisionCondition(_bb, default(IOnCollisionCondition));
		}

		// Token: 0x06027200 RID: 160256 RVA: 0x0055C7DC File Offset: 0x0055A9DC
		public static IOnCollisionCondition GetRootAsIOnCollisionCondition(ByteBuffer _bb, IOnCollisionCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027201 RID: 160257 RVA: 0x0055C7F9 File Offset: 0x0055A9F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027202 RID: 160258 RVA: 0x0055C808 File Offset: 0x0055AA08
		public IOnCollisionCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AD60 RID: 44384
		// (get) Token: 0x06027203 RID: 160259 RVA: 0x0055C818 File Offset: 0x0055AA18
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

		// Token: 0x1700AD61 RID: 44385
		// (get) Token: 0x06027204 RID: 160260 RVA: 0x0055C854 File Offset: 0x0055AA54
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

		// Token: 0x1700AD62 RID: 44386
		// (get) Token: 0x06027205 RID: 160261 RVA: 0x0055C894 File Offset: 0x0055AA94
		public ITriggerCountConfig? TriggerCount
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new ITriggerCountConfig?(default(ITriggerCountConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06027206 RID: 160262 RVA: 0x0055C8F1 File Offset: 0x0055AAF1
		public static Offset<IOnCollisionCondition> CreateIOnCollisionCondition(FlatBufferBuilder builder, EBulletCreateCondition Type = EBulletCreateCondition.OnHit, long BulletId = 0L, Offset<ITriggerCountConfig> TriggerCountOffset = default(Offset<ITriggerCountConfig>))
		{
			builder.StartTable(3);
			IOnCollisionCondition.AddBulletId(builder, BulletId);
			IOnCollisionCondition.AddTriggerCount(builder, TriggerCountOffset);
			IOnCollisionCondition.AddType(builder, Type);
			return IOnCollisionCondition.EndIOnCollisionCondition(builder);
		}

		// Token: 0x06027207 RID: 160263 RVA: 0x0055C915 File Offset: 0x0055AB15
		public static void StartIOnCollisionCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06027208 RID: 160264 RVA: 0x0055C91E File Offset: 0x0055AB1E
		public static void AddType(FlatBufferBuilder builder, EBulletCreateCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06027209 RID: 160265 RVA: 0x0055C929 File Offset: 0x0055AB29
		public static void AddBulletId(FlatBufferBuilder builder, long bulletId)
		{
			builder.AddLong(1, bulletId, 0L);
		}

		// Token: 0x0602720A RID: 160266 RVA: 0x0055C935 File Offset: 0x0055AB35
		public static void AddTriggerCount(FlatBufferBuilder builder, Offset<ITriggerCountConfig> triggerCountOffset)
		{
			builder.AddOffset(2, triggerCountOffset.Value, 0);
		}

		// Token: 0x0602720B RID: 160267 RVA: 0x0055C945 File Offset: 0x0055AB45
		public static Offset<IOnCollisionCondition> EndIOnCollisionCondition(FlatBufferBuilder builder)
		{
			return new Offset<IOnCollisionCondition>(builder.EndTable());
		}

		// Token: 0x0602720C RID: 160268 RVA: 0x0055C954 File Offset: 0x0055AB54
		public IOnCollisionConditionT UnPack()
		{
			IOnCollisionConditionT onCollisionConditionT = new IOnCollisionConditionT();
			this.UnPackTo(onCollisionConditionT);
			return onCollisionConditionT;
		}

		// Token: 0x0602720D RID: 160269 RVA: 0x0055C970 File Offset: 0x0055AB70
		public void UnPackTo(IOnCollisionConditionT _o)
		{
			_o.Type = this.Type;
			_o.BulletId = this.BulletId;
			_o.TriggerCount = ((this.TriggerCount != null) ? this.TriggerCount.Value.UnPack() : null);
		}

		// Token: 0x0602720E RID: 160270 RVA: 0x0055C9C4 File Offset: 0x0055ABC4
		public static Offset<IOnCollisionCondition> Pack(FlatBufferBuilder builder, IOnCollisionConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOnCollisionCondition>);
			}
			Offset<ITriggerCountConfig> triggerCountOffset = (_o.TriggerCount == null) ? default(Offset<ITriggerCountConfig>) : ITriggerCountConfig.Pack(builder, _o.TriggerCount);
			return IOnCollisionCondition.CreateIOnCollisionCondition(builder, _o.Type, _o.BulletId, triggerCountOffset);
		}

		// Token: 0x0400F71E RID: 63262
		private Table __p;
	}
}
