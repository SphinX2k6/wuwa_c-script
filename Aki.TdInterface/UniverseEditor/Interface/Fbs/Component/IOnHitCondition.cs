using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C3F RID: 23615
	public struct IOnHitCondition : IFlatbufferObject
	{
		// Token: 0x1700AD76 RID: 44406
		// (get) Token: 0x06027259 RID: 160345 RVA: 0x0055D320 File Offset: 0x0055B520
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602725A RID: 160346 RVA: 0x0055D32D File Offset: 0x0055B52D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602725B RID: 160347 RVA: 0x0055D334 File Offset: 0x0055B534
		public static IOnHitCondition GetRootAsIOnHitCondition(ByteBuffer _bb)
		{
			return IOnHitCondition.GetRootAsIOnHitCondition(_bb, default(IOnHitCondition));
		}

		// Token: 0x0602725C RID: 160348 RVA: 0x0055D350 File Offset: 0x0055B550
		public static IOnHitCondition GetRootAsIOnHitCondition(ByteBuffer _bb, IOnHitCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602725D RID: 160349 RVA: 0x0055D36D File Offset: 0x0055B56D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602725E RID: 160350 RVA: 0x0055D37C File Offset: 0x0055B57C
		public IOnHitCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AD77 RID: 44407
		// (get) Token: 0x0602725F RID: 160351 RVA: 0x0055D38C File Offset: 0x0055B58C
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

		// Token: 0x1700AD78 RID: 44408
		// (get) Token: 0x06027260 RID: 160352 RVA: 0x0055D3C8 File Offset: 0x0055B5C8
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

		// Token: 0x06027261 RID: 160353 RVA: 0x0055D405 File Offset: 0x0055B605
		public static Offset<IOnHitCondition> CreateIOnHitCondition(FlatBufferBuilder builder, EBulletCreateCondition Type = EBulletCreateCondition.OnHit, long BulletId = 0L)
		{
			builder.StartTable(2);
			IOnHitCondition.AddBulletId(builder, BulletId);
			IOnHitCondition.AddType(builder, Type);
			return IOnHitCondition.EndIOnHitCondition(builder);
		}

		// Token: 0x06027262 RID: 160354 RVA: 0x0055D422 File Offset: 0x0055B622
		public static void StartIOnHitCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06027263 RID: 160355 RVA: 0x0055D42B File Offset: 0x0055B62B
		public static void AddType(FlatBufferBuilder builder, EBulletCreateCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06027264 RID: 160356 RVA: 0x0055D436 File Offset: 0x0055B636
		public static void AddBulletId(FlatBufferBuilder builder, long bulletId)
		{
			builder.AddLong(1, bulletId, 0L);
		}

		// Token: 0x06027265 RID: 160357 RVA: 0x0055D442 File Offset: 0x0055B642
		public static Offset<IOnHitCondition> EndIOnHitCondition(FlatBufferBuilder builder)
		{
			return new Offset<IOnHitCondition>(builder.EndTable());
		}

		// Token: 0x06027266 RID: 160358 RVA: 0x0055D450 File Offset: 0x0055B650
		public IOnHitConditionT UnPack()
		{
			IOnHitConditionT onHitConditionT = new IOnHitConditionT();
			this.UnPackTo(onHitConditionT);
			return onHitConditionT;
		}

		// Token: 0x06027267 RID: 160359 RVA: 0x0055D46B File Offset: 0x0055B66B
		public void UnPackTo(IOnHitConditionT _o)
		{
			_o.Type = this.Type;
			_o.BulletId = this.BulletId;
		}

		// Token: 0x06027268 RID: 160360 RVA: 0x0055D488 File Offset: 0x0055B688
		public static Offset<IOnHitCondition> Pack(FlatBufferBuilder builder, IOnHitConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOnHitCondition>);
			}
			return IOnHitCondition.CreateIOnHitCondition(builder, _o.Type, _o.BulletId);
		}

		// Token: 0x0400F72B RID: 63275
		private Table __p;
	}
}
