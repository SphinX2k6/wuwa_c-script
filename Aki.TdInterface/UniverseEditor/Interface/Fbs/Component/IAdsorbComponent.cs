using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004E62 RID: 20066
	public struct IAdsorbComponent : IFlatbufferObject
	{
		// Token: 0x17008F97 RID: 36759
		// (get) Token: 0x0601F806 RID: 129030 RVA: 0x00463342 File Offset: 0x00461542
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F807 RID: 129031 RVA: 0x0046334F File Offset: 0x0046154F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F808 RID: 129032 RVA: 0x00463358 File Offset: 0x00461558
		public static IAdsorbComponent GetRootAsIAdsorbComponent(ByteBuffer _bb)
		{
			return IAdsorbComponent.GetRootAsIAdsorbComponent(_bb, default(IAdsorbComponent));
		}

		// Token: 0x0601F809 RID: 129033 RVA: 0x00463374 File Offset: 0x00461574
		public static IAdsorbComponent GetRootAsIAdsorbComponent(ByteBuffer _bb, IAdsorbComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F80A RID: 129034 RVA: 0x00463391 File Offset: 0x00461591
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F80B RID: 129035 RVA: 0x004633A0 File Offset: 0x004615A0
		public IAdsorbComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008F98 RID: 36760
		// (get) Token: 0x0601F80C RID: 129036 RVA: 0x004633B0 File Offset: 0x004615B0
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008F99 RID: 36761
		// (get) Token: 0x0601F80D RID: 129037 RVA: 0x004633F0 File Offset: 0x004615F0
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

		// Token: 0x17008F9A RID: 36762
		// (get) Token: 0x0601F80E RID: 129038 RVA: 0x00463430 File Offset: 0x00461630
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

		// Token: 0x17008F9B RID: 36763
		// (get) Token: 0x0601F80F RID: 129039 RVA: 0x00463470 File Offset: 0x00461670
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

		// Token: 0x17008F9C RID: 36764
		// (get) Token: 0x0601F810 RID: 129040 RVA: 0x004634B4 File Offset: 0x004616B4
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

		// Token: 0x17008F9D RID: 36765
		// (get) Token: 0x0601F811 RID: 129041 RVA: 0x00463514 File Offset: 0x00461714
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

		// Token: 0x17008F9E RID: 36766
		// (get) Token: 0x0601F812 RID: 129042 RVA: 0x00463554 File Offset: 0x00461754
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

		// Token: 0x0601F813 RID: 129043 RVA: 0x00463594 File Offset: 0x00461794
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

		// Token: 0x0601F814 RID: 129044 RVA: 0x004635E3 File Offset: 0x004617E3
		public static void StartIAdsorbComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0601F815 RID: 129045 RVA: 0x004635EC File Offset: 0x004617EC
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x0601F816 RID: 129046 RVA: 0x004635F7 File Offset: 0x004617F7
		public static void AddRange(FlatBufferBuilder builder, float range)
		{
			builder.AddFloat(1, range, 0.0);
		}

		// Token: 0x0601F817 RID: 129047 RVA: 0x0046360A File Offset: 0x0046180A
		public static void AddStartVelocity(FlatBufferBuilder builder, float startVelocity)
		{
			builder.AddFloat(2, startVelocity, 0.0);
		}

		// Token: 0x0601F818 RID: 129048 RVA: 0x0046361D File Offset: 0x0046181D
		public static void AddAcceleration(FlatBufferBuilder builder, float acceleration)
		{
			builder.AddFloat(3, acceleration, 0.0);
		}

		// Token: 0x0601F819 RID: 129049 RVA: 0x00463630 File Offset: 0x00461830
		public static void AddActiveStateCondition(FlatBufferBuilder builder, Offset<IEntityState> activeStateConditionOffset)
		{
			builder.AddOffset(4, activeStateConditionOffset.Value, 0);
		}

		// Token: 0x0601F81A RID: 129050 RVA: 0x00463640 File Offset: 0x00461840
		public static void AddAdsorbLimitedTime(FlatBufferBuilder builder, int adsorbLimitedTime)
		{
			builder.AddInt(5, adsorbLimitedTime, 0);
		}

		// Token: 0x0601F81B RID: 129051 RVA: 0x0046364B File Offset: 0x0046184B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x0601F81C RID: 129052 RVA: 0x00463656 File Offset: 0x00461856
		public static Offset<IAdsorbComponent> EndIAdsorbComponent(FlatBufferBuilder builder)
		{
			return new Offset<IAdsorbComponent>(builder.EndTable());
		}

		// Token: 0x0601F81D RID: 129053 RVA: 0x00463664 File Offset: 0x00461864
		public IAdsorbComponentT UnPack()
		{
			IAdsorbComponentT adsorbComponentT = new IAdsorbComponentT();
			this.UnPackTo(adsorbComponentT);
			return adsorbComponentT;
		}

		// Token: 0x0601F81E RID: 129054 RVA: 0x00463680 File Offset: 0x00461880
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

		// Token: 0x0601F81F RID: 129055 RVA: 0x00463704 File Offset: 0x00461904
		public static Offset<IAdsorbComponent> Pack(FlatBufferBuilder builder, IAdsorbComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAdsorbComponent>);
			}
			Offset<IEntityState> activeStateConditionOffset = (_o.ActiveStateCondition == null) ? default(Offset<IEntityState>) : IEntityState.Pack(builder, _o.ActiveStateCondition);
			return IAdsorbComponent.CreateIAdsorbComponent(builder, _o.Disabled, _o.Range, _o.StartVelocity, _o.Acceleration, activeStateConditionOffset, _o.AdsorbLimitedTime, _o.NullMask);
		}

		// Token: 0x0400DC04 RID: 56324
		private Table __p;
	}
}
