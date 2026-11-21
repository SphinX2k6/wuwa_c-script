using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004244 RID: 16964
	public struct IEntityDistanceLimitingCondition : IFlatbufferObject
	{
		// Token: 0x170073A6 RID: 29606
		// (get) Token: 0x060179AD RID: 96685 RVA: 0x0035E0F4 File Offset: 0x0035C2F4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060179AE RID: 96686 RVA: 0x0035E101 File Offset: 0x0035C301
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060179AF RID: 96687 RVA: 0x0035E108 File Offset: 0x0035C308
		public static IEntityDistanceLimitingCondition GetRootAsIEntityDistanceLimitingCondition(ByteBuffer _bb)
		{
			return IEntityDistanceLimitingCondition.GetRootAsIEntityDistanceLimitingCondition(_bb, default(IEntityDistanceLimitingCondition));
		}

		// Token: 0x060179B0 RID: 96688 RVA: 0x0035E124 File Offset: 0x0035C324
		public static IEntityDistanceLimitingCondition GetRootAsIEntityDistanceLimitingCondition(ByteBuffer _bb, IEntityDistanceLimitingCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060179B1 RID: 96689 RVA: 0x0035E141 File Offset: 0x0035C341
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060179B2 RID: 96690 RVA: 0x0035E150 File Offset: 0x0035C350
		public IEntityDistanceLimitingCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170073A7 RID: 29607
		// (get) Token: 0x060179B3 RID: 96691 RVA: 0x0035E160 File Offset: 0x0035C360
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

		// Token: 0x170073A8 RID: 29608
		// (get) Token: 0x060179B4 RID: 96692 RVA: 0x0035E19C File Offset: 0x0035C39C
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

		// Token: 0x170073A9 RID: 29609
		// (get) Token: 0x060179B5 RID: 96693 RVA: 0x0035E1DC File Offset: 0x0035C3DC
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

		// Token: 0x060179B6 RID: 96694 RVA: 0x0035E21C File Offset: 0x0035C41C
		public static Offset<IEntityDistanceLimitingCondition> CreateIEntityDistanceLimitingCondition(FlatBufferBuilder builder, int EntityId = 0, float MaxDistance = 0f, float OverMaxCountdown = 0f)
		{
			builder.StartTable(3);
			IEntityDistanceLimitingCondition.AddOverMaxCountdown(builder, OverMaxCountdown);
			IEntityDistanceLimitingCondition.AddMaxDistance(builder, MaxDistance);
			IEntityDistanceLimitingCondition.AddEntityId(builder, EntityId);
			return IEntityDistanceLimitingCondition.EndIEntityDistanceLimitingCondition(builder);
		}

		// Token: 0x060179B7 RID: 96695 RVA: 0x0035E240 File Offset: 0x0035C440
		public static void StartIEntityDistanceLimitingCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060179B8 RID: 96696 RVA: 0x0035E249 File Offset: 0x0035C449
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x060179B9 RID: 96697 RVA: 0x0035E254 File Offset: 0x0035C454
		public static void AddMaxDistance(FlatBufferBuilder builder, float maxDistance)
		{
			builder.AddFloat(1, maxDistance, 0.0);
		}

		// Token: 0x060179BA RID: 96698 RVA: 0x0035E267 File Offset: 0x0035C467
		public static void AddOverMaxCountdown(FlatBufferBuilder builder, float overMaxCountdown)
		{
			builder.AddFloat(2, overMaxCountdown, 0.0);
		}

		// Token: 0x060179BB RID: 96699 RVA: 0x0035E27A File Offset: 0x0035C47A
		public static Offset<IEntityDistanceLimitingCondition> EndIEntityDistanceLimitingCondition(FlatBufferBuilder builder)
		{
			return new Offset<IEntityDistanceLimitingCondition>(builder.EndTable());
		}

		// Token: 0x060179BC RID: 96700 RVA: 0x0035E288 File Offset: 0x0035C488
		public IEntityDistanceLimitingConditionT UnPack()
		{
			IEntityDistanceLimitingConditionT entityDistanceLimitingConditionT = new IEntityDistanceLimitingConditionT();
			this.UnPackTo(entityDistanceLimitingConditionT);
			return entityDistanceLimitingConditionT;
		}

		// Token: 0x060179BD RID: 96701 RVA: 0x0035E2A3 File Offset: 0x0035C4A3
		public void UnPackTo(IEntityDistanceLimitingConditionT _o)
		{
			_o.EntityId = this.EntityId;
			_o.MaxDistance = this.MaxDistance;
			_o.OverMaxCountdown = this.OverMaxCountdown;
		}

		// Token: 0x060179BE RID: 96702 RVA: 0x0035E2CC File Offset: 0x0035C4CC
		public static Offset<IEntityDistanceLimitingCondition> Pack(FlatBufferBuilder builder, IEntityDistanceLimitingConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityDistanceLimitingCondition>);
			}
			return IEntityDistanceLimitingCondition.CreateIEntityDistanceLimitingCondition(builder, _o.EntityId, _o.MaxDistance, _o.OverMaxCountdown);
		}

		// Token: 0x0400C152 RID: 49490
		private Table __p;
	}
}
