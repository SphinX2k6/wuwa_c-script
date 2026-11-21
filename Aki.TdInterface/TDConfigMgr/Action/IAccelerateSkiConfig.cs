using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018D3 RID: 6355
	public class IAccelerateSkiConfig : ISkiConfigType
	{
		// Token: 0x06008547 RID: 34119 RVA: 0x0013DC14 File Offset: 0x0013BE14
		private IAccelerateSkiConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAccelerateSkiConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAccelerateSkiConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAccelerateSkiConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06008548 RID: 34120 RVA: 0x0013DC4C File Offset: 0x0013BE4C
		public static IAccelerateSkiConfig Create([Nullable(2)] IAccelerateSkiConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAccelerateSkiConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008549 RID: 34121 RVA: 0x0013DC5F File Offset: 0x0013BE5F
		public static IAccelerateSkiConfig CreateFromSetValue([Nullable(2)] IAccelerateSkiConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAccelerateSkiConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600854A RID: 34122 RVA: 0x0013DC74 File Offset: 0x0013BE74
		public new IAccelerateSkiConfig_SetValue ToSetValue()
		{
			return new IAccelerateSkiConfig_SetValue
			{
				Type = this.Type,
				Target = this.Target,
				Duration = this.Duration,
				LimitSpeed = this.LimitSpeed,
				Acceleration = this.Acceleration,
				InstantSpeed = this.InstantSpeed
			};
		}

		// Token: 0x17002B73 RID: 11123
		// (get) Token: 0x0600854B RID: 34123 RVA: 0x0013DCCE File Offset: 0x0013BECE
		// (set) Token: 0x0600854C RID: 34124 RVA: 0x0013DCF9 File Offset: 0x0013BEF9
		public override ESkiConfig Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESkiConfig.Open;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002B74 RID: 11124
		// (get) Token: 0x0600854D RID: 34125 RVA: 0x0013DD07 File Offset: 0x0013BF07
		// (set) Token: 0x0600854E RID: 34126 RVA: 0x0013DD2E File Offset: 0x0013BF2E
		public override ITargetEntityType Target
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Target;
				}
				IAccelerateSkiConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Target;
			}
			set
			{
				this.GetOrCreatePoco().Target = value;
			}
		}

		// Token: 0x17002B75 RID: 11125
		// (get) Token: 0x0600854F RID: 34127 RVA: 0x0013DD3C File Offset: 0x0013BF3C
		// (set) Token: 0x06008550 RID: 34128 RVA: 0x0013DD67 File Offset: 0x0013BF67
		public virtual int Duration
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Duration;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Duration;
			}
			set
			{
				this.GetOrCreatePoco().Duration = value;
			}
		}

		// Token: 0x17002B76 RID: 11126
		// (get) Token: 0x06008551 RID: 34129 RVA: 0x0013DD75 File Offset: 0x0013BF75
		// (set) Token: 0x06008552 RID: 34130 RVA: 0x0013DDA0 File Offset: 0x0013BFA0
		public virtual int LimitSpeed
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LimitSpeed;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.LimitSpeed;
			}
			set
			{
				this.GetOrCreatePoco().LimitSpeed = value;
			}
		}

		// Token: 0x17002B77 RID: 11127
		// (get) Token: 0x06008553 RID: 34131 RVA: 0x0013DDAE File Offset: 0x0013BFAE
		// (set) Token: 0x06008554 RID: 34132 RVA: 0x0013DDD9 File Offset: 0x0013BFD9
		public virtual int Acceleration
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Acceleration;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Acceleration;
			}
			set
			{
				this.GetOrCreatePoco().Acceleration = value;
			}
		}

		// Token: 0x17002B78 RID: 11128
		// (get) Token: 0x06008555 RID: 34133 RVA: 0x0013DDE8 File Offset: 0x0013BFE8
		// (set) Token: 0x06008556 RID: 34134 RVA: 0x0013DE22 File Offset: 0x0013C022
		public virtual int? InstantSpeed
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.InstantSpeed;
				}
				IAccelerateSkiConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.InstantSpeed;
			}
			set
			{
				this.GetOrCreatePoco().InstantSpeed = value;
			}
		}

		// Token: 0x040054B4 RID: 21684
		[Nullable(2)]
		protected new IAccelerateSkiConfig FbInstance;

		// Token: 0x040054B5 RID: 21685
		[Nullable(2)]
		protected new IAccelerateSkiConfig_SetValue PocoInterface;
	}
}
