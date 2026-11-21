using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005373 RID: 21363
	public struct IAdsorbComponent : IFlatbufferObject
	{
		// Token: 0x170096D0 RID: 38608
		// (get) Token: 0x06021451 RID: 136273 RVA: 0x0049735A File Offset: 0x0049555A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021452 RID: 136274 RVA: 0x00497367 File Offset: 0x00495567
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021453 RID: 136275 RVA: 0x00497370 File Offset: 0x00495570
		public static IAdsorbComponent GetRootAsIAdsorbComponent(ByteBuffer _bb)
		{
			return IAdsorbComponent.GetRootAsIAdsorbComponent(_bb, default(IAdsorbComponent));
		}

		// Token: 0x06021454 RID: 136276 RVA: 0x0049738C File Offset: 0x0049558C
		public static IAdsorbComponent GetRootAsIAdsorbComponent(ByteBuffer _bb, IAdsorbComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021455 RID: 136277 RVA: 0x004973A9 File Offset: 0x004955A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021456 RID: 136278 RVA: 0x004973B8 File Offset: 0x004955B8
		public IAdsorbComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170096D1 RID: 38609
		// (get) Token: 0x06021457 RID: 136279 RVA: 0x004973C8 File Offset: 0x004955C8
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170096D2 RID: 38610
		// (get) Token: 0x06021458 RID: 136280 RVA: 0x00497408 File Offset: 0x00495608
		public float Range
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

		// Token: 0x170096D3 RID: 38611
		// (get) Token: 0x06021459 RID: 136281 RVA: 0x00497448 File Offset: 0x00495648
		public float StartVelocity
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

		// Token: 0x170096D4 RID: 38612
		// (get) Token: 0x0602145A RID: 136282 RVA: 0x00497488 File Offset: 0x00495688
		public float Acceleration
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170096D5 RID: 38613
		// (get) Token: 0x0602145B RID: 136283 RVA: 0x004974CC File Offset: 0x004956CC
		public IEntityState? ActiveStateCondition
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new IEntityState?(default(IEntityState).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170096D6 RID: 38614
		// (get) Token: 0x0602145C RID: 136284 RVA: 0x0049752C File Offset: 0x0049572C
		public int AdsorbLimitedTime
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170096D7 RID: 38615
		// (get) Token: 0x0602145D RID: 136285 RVA: 0x0049756C File Offset: 0x0049576C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602145E RID: 136286 RVA: 0x004975AC File Offset: 0x004957AC
		public static Offset<IAdsorbComponent> CreateIAdsorbComponent(FlatBufferBuilder builder, bool Disabled = false, float Range = 0f, float StartVelocity = 0f, float Acceleration = 0f, Offset<IEntityState> ActiveStateConditionOffset = default(Offset<IEntityState>), int AdsorbLimitedTime = 0, byte NullMask = 0)
		{
			builder.StartTable(7);
			IAdsorbComponent.AddAdsorbLimitedTime(builder, AdsorbLimitedTime);
			IAdsorbComponent.AddActiveStateCondition(builder, ActiveStateConditionOffset);
			IAdsorbComponent.AddAcceleration(builder, Acceleration);
			IAdsorbComponent.AddStartVelocity(builder, StartVelocity);
			IAdsorbComponent.AddRange(builder, Range);
			IAdsorbComponent.AddNullMask(builder, NullMask);
			IAdsorbComponent.AddDisabled(builder, Disabled);
			return IAdsorbComponent.EndIAdsorbComponent(builder);
		}

		// Token: 0x0602145F RID: 136287 RVA: 0x004975FB File Offset: 0x004957FB
		public static void StartIAdsorbComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06021460 RID: 136288 RVA: 0x00497604 File Offset: 0x00495804
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06021461 RID: 136289 RVA: 0x0049760F File Offset: 0x0049580F
		public static void AddRange(FlatBufferBuilder builder, float range)
		{
			builder.AddFloat(1, range, 0.0);
		}

		// Token: 0x06021462 RID: 136290 RVA: 0x00497622 File Offset: 0x00495822
		public static void AddStartVelocity(FlatBufferBuilder builder, float startVelocity)
		{
			builder.AddFloat(2, startVelocity, 0.0);
		}

		// Token: 0x06021463 RID: 136291 RVA: 0x00497635 File Offset: 0x00495835
		public static void AddAcceleration(FlatBufferBuilder builder, float acceleration)
		{
			builder.AddFloat(3, acceleration, 0.0);
		}

		// Token: 0x06021464 RID: 136292 RVA: 0x00497648 File Offset: 0x00495848
		public static void AddActiveStateCondition(FlatBufferBuilder builder, Offset<IEntityState> activeStateConditionOffset)
		{
			builder.AddOffset(4, activeStateConditionOffset.Value, 0);
		}

		// Token: 0x06021465 RID: 136293 RVA: 0x00497658 File Offset: 0x00495858
		public static void AddAdsorbLimitedTime(FlatBufferBuilder builder, int adsorbLimitedTime)
		{
			builder.AddInt(5, adsorbLimitedTime, 0);
		}

		// Token: 0x06021466 RID: 136294 RVA: 0x00497663 File Offset: 0x00495863
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06021467 RID: 136295 RVA: 0x0049766E File Offset: 0x0049586E
		public static Offset<IAdsorbComponent> EndIAdsorbComponent(FlatBufferBuilder builder)
		{
			return new Offset<IAdsorbComponent>(builder.EndTable());
		}

		// Token: 0x06021468 RID: 136296 RVA: 0x0049767C File Offset: 0x0049587C
		public IAdsorbComponentT UnPack()
		{
			IAdsorbComponentT adsorbComponentT = new IAdsorbComponentT();
			this.UnPackTo(adsorbComponentT);
			return adsorbComponentT;
		}

		// Token: 0x06021469 RID: 136297 RVA: 0x00497698 File Offset: 0x00495898
		public void UnPackTo(IAdsorbComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.Range = this.Range;
			_o.StartVelocity = this.StartVelocity;
			_o.Acceleration = this.Acceleration;
			_o.ActiveStateCondition = ((this.ActiveStateCondition != null) ? this.ActiveStateCondition.Value.UnPack() : null);
			_o.AdsorbLimitedTime = this.AdsorbLimitedTime;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602146A RID: 136298 RVA: 0x0049771C File Offset: 0x0049591C
		public static Offset<IAdsorbComponent> Pack(FlatBufferBuilder builder, IAdsorbComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAdsorbComponent>);
			}
			Offset<IEntityState> activeStateConditionOffset = (_o.ActiveStateCondition == null) ? default(Offset<IEntityState>) : IEntityState.Pack(builder, _o.ActiveStateCondition);
			return IAdsorbComponent.CreateIAdsorbComponent(builder, _o.Disabled, _o.Range, _o.StartVelocity, _o.Acceleration, activeStateConditionOffset, _o.AdsorbLimitedTime, _o.NullMask);
		}

		// Token: 0x0400E77E RID: 59262
		private Table __p;
	}
}
