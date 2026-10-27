using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E09 RID: 15881
	public struct IEntityDistanceLimitingCondition : IFlatbufferObject
	{
		// Token: 0x17006DC0 RID: 28096
		// (get) Token: 0x06016380 RID: 91008 RVA: 0x003354FC File Offset: 0x003336FC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016381 RID: 91009 RVA: 0x00335509 File Offset: 0x00333709
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016382 RID: 91010 RVA: 0x00335510 File Offset: 0x00333710
		public static IEntityDistanceLimitingCondition GetRootAsIEntityDistanceLimitingCondition(ByteBuffer _bb)
		{
			return IEntityDistanceLimitingCondition.GetRootAsIEntityDistanceLimitingCondition(_bb, default(IEntityDistanceLimitingCondition));
		}

		// Token: 0x06016383 RID: 91011 RVA: 0x0033552C File Offset: 0x0033372C
		public static IEntityDistanceLimitingCondition GetRootAsIEntityDistanceLimitingCondition(ByteBuffer _bb, IEntityDistanceLimitingCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016384 RID: 91012 RVA: 0x00335549 File Offset: 0x00333749
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016385 RID: 91013 RVA: 0x00335558 File Offset: 0x00333758
		public IEntityDistanceLimitingCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006DC1 RID: 28097
		// (get) Token: 0x06016386 RID: 91014 RVA: 0x00335568 File Offset: 0x00333768
		public int EntityId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006DC2 RID: 28098
		// (get) Token: 0x06016387 RID: 91015 RVA: 0x003355A4 File Offset: 0x003337A4
		public float MaxDistance
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

		// Token: 0x17006DC3 RID: 28099
		// (get) Token: 0x06016388 RID: 91016 RVA: 0x003355E4 File Offset: 0x003337E4
		public float OverMaxCountdown
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

		// Token: 0x06016389 RID: 91017 RVA: 0x00335624 File Offset: 0x00333824
		public static Offset<IEntityDistanceLimitingCondition> CreateIEntityDistanceLimitingCondition(FlatBufferBuilder builder, int EntityId = 0, float MaxDistance = 0f, float OverMaxCountdown = 0f)
		{
			builder.StartTable(3);
			IEntityDistanceLimitingCondition.AddOverMaxCountdown(builder, OverMaxCountdown);
			IEntityDistanceLimitingCondition.AddMaxDistance(builder, MaxDistance);
			IEntityDistanceLimitingCondition.AddEntityId(builder, EntityId);
			return IEntityDistanceLimitingCondition.EndIEntityDistanceLimitingCondition(builder);
		}

		// Token: 0x0601638A RID: 91018 RVA: 0x00335648 File Offset: 0x00333848
		public static void StartIEntityDistanceLimitingCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601638B RID: 91019 RVA: 0x00335651 File Offset: 0x00333851
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x0601638C RID: 91020 RVA: 0x0033565C File Offset: 0x0033385C
		public static void AddMaxDistance(FlatBufferBuilder builder, float maxDistance)
		{
			builder.AddFloat(1, maxDistance, 0.0);
		}

		// Token: 0x0601638D RID: 91021 RVA: 0x0033566F File Offset: 0x0033386F
		public static void AddOverMaxCountdown(FlatBufferBuilder builder, float overMaxCountdown)
		{
			builder.AddFloat(2, overMaxCountdown, 0.0);
		}

		// Token: 0x0601638E RID: 91022 RVA: 0x00335682 File Offset: 0x00333882
		public static Offset<IEntityDistanceLimitingCondition> EndIEntityDistanceLimitingCondition(FlatBufferBuilder builder)
		{
			return new Offset<IEntityDistanceLimitingCondition>(builder.EndTable());
		}

		// Token: 0x0601638F RID: 91023 RVA: 0x00335690 File Offset: 0x00333890
		public IEntityDistanceLimitingConditionT UnPack()
		{
			IEntityDistanceLimitingConditionT entityDistanceLimitingConditionT = new IEntityDistanceLimitingConditionT();
			this.UnPackTo(entityDistanceLimitingConditionT);
			return entityDistanceLimitingConditionT;
		}

		// Token: 0x06016390 RID: 91024 RVA: 0x003356AB File Offset: 0x003338AB
		public void UnPackTo(IEntityDistanceLimitingConditionT _o)
		{
			_o.EntityId = this.EntityId;
			_o.MaxDistance = this.MaxDistance;
			_o.OverMaxCountdown = this.OverMaxCountdown;
		}

		// Token: 0x06016391 RID: 91025 RVA: 0x003356D4 File Offset: 0x003338D4
		public static Offset<IEntityDistanceLimitingCondition> Pack(FlatBufferBuilder builder, IEntityDistanceLimitingConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityDistanceLimitingCondition>);
			}
			return IEntityDistanceLimitingCondition.CreateIEntityDistanceLimitingCondition(builder, _o.EntityId, _o.MaxDistance, _o.OverMaxCountdown);
		}

		// Token: 0x0400B77A RID: 46970
		private Table __p;
	}
}
