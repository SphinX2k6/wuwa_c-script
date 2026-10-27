using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001752 RID: 5970
	[NullableContext(1)]
	[Nullable(0)]
	public class IAccelerateSkiConfig : ISkiConfigType
	{
		// Token: 0x06007E57 RID: 32343 RVA: 0x0012E9B4 File Offset: 0x0012CBB4
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

		// Token: 0x06007E58 RID: 32344 RVA: 0x0012E9EC File Offset: 0x0012CBEC
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

		// Token: 0x06007E59 RID: 32345 RVA: 0x0012E9FF File Offset: 0x0012CBFF
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

		// Token: 0x06007E5A RID: 32346 RVA: 0x0012EA14 File Offset: 0x0012CC14
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

		// Token: 0x17002985 RID: 10629
		// (get) Token: 0x06007E5B RID: 32347 RVA: 0x0012EA6E File Offset: 0x0012CC6E
		// (set) Token: 0x06007E5C RID: 32348 RVA: 0x0012EA99 File Offset: 0x0012CC99
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

		// Token: 0x17002986 RID: 10630
		// (get) Token: 0x06007E5D RID: 32349 RVA: 0x0012EAA7 File Offset: 0x0012CCA7
		// (set) Token: 0x06007E5E RID: 32350 RVA: 0x0012EACE File Offset: 0x0012CCCE
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

		// Token: 0x17002987 RID: 10631
		// (get) Token: 0x06007E5F RID: 32351 RVA: 0x0012EADC File Offset: 0x0012CCDC
		// (set) Token: 0x06007E60 RID: 32352 RVA: 0x0012EB07 File Offset: 0x0012CD07
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

		// Token: 0x17002988 RID: 10632
		// (get) Token: 0x06007E61 RID: 32353 RVA: 0x0012EB15 File Offset: 0x0012CD15
		// (set) Token: 0x06007E62 RID: 32354 RVA: 0x0012EB40 File Offset: 0x0012CD40
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

		// Token: 0x17002989 RID: 10633
		// (get) Token: 0x06007E63 RID: 32355 RVA: 0x0012EB4E File Offset: 0x0012CD4E
		// (set) Token: 0x06007E64 RID: 32356 RVA: 0x0012EB79 File Offset: 0x0012CD79
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

		// Token: 0x1700298A RID: 10634
		// (get) Token: 0x06007E65 RID: 32357 RVA: 0x0012EB88 File Offset: 0x0012CD88
		// (set) Token: 0x06007E66 RID: 32358 RVA: 0x0012EBC2 File Offset: 0x0012CDC2
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

		// Token: 0x0400507E RID: 20606
		[Nullable(2)]
		protected new IAccelerateSkiConfig FbInstance;

		// Token: 0x0400507F RID: 20607
		[Nullable(2)]
		protected new IAccelerateSkiConfig_SetValue PocoInterface;
	}
}
