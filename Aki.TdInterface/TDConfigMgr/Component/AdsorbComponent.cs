using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000013 RID: 19
	public class AdsorbComponent : IComponentBase
	{
		// Token: 0x06000040 RID: 64 RVA: 0x00014BA4 File Offset: 0x00012DA4
		private AdsorbComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("AdsorbComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			AdsorbComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new AdsorbComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00014BDC File Offset: 0x00012DDC
		public static AdsorbComponent Create([Nullable(2)] AdsorbComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new AdsorbComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00014BEF File Offset: 0x00012DEF
		public static AdsorbComponent CreateFromSetValue([Nullable(2)] AdsorbComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new AdsorbComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00014C04 File Offset: 0x00012E04
		public new AdsorbComponent_SetValue ToSetValue()
		{
			return new AdsorbComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				Range = this.Range,
				StartVelocity = this.StartVelocity,
				Acceleration = this.Acceleration,
				ActiveStateCondition = this.ActiveStateCondition,
				AdsorbLimitedTime = this.AdsorbLimitedTime
			};
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000044 RID: 68 RVA: 0x00014C6C File Offset: 0x00012E6C
		// (set) Token: 0x06000045 RID: 69 RVA: 0x00014CA6 File Offset: 0x00012EA6
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				AdsorbComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Disabled;
			}
			set
			{
				this.GetOrCreatePoco().Disabled = value;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000046 RID: 70 RVA: 0x00014CB4 File Offset: 0x00012EB4
		// (set) Token: 0x06000047 RID: 71 RVA: 0x00014CDE File Offset: 0x00012EDE
		public override bool? EdIsLocked
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdIsLocked;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdIsLocked = value;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000048 RID: 72 RVA: 0x00014CEC File Offset: 0x00012EEC
		// (set) Token: 0x06000049 RID: 73 RVA: 0x00014D1B File Offset: 0x00012F1B
		public virtual float Range
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Range;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Range;
			}
			set
			{
				this.GetOrCreatePoco().Range = value;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600004A RID: 74 RVA: 0x00014D29 File Offset: 0x00012F29
		// (set) Token: 0x0600004B RID: 75 RVA: 0x00014D58 File Offset: 0x00012F58
		public virtual float StartVelocity
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.StartVelocity;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.StartVelocity;
			}
			set
			{
				this.GetOrCreatePoco().StartVelocity = value;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600004C RID: 76 RVA: 0x00014D66 File Offset: 0x00012F66
		// (set) Token: 0x0600004D RID: 77 RVA: 0x00014D95 File Offset: 0x00012F95
		public virtual float Acceleration
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Acceleration;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Acceleration;
			}
			set
			{
				this.GetOrCreatePoco().Acceleration = value;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600004E RID: 78 RVA: 0x00014DA4 File Offset: 0x00012FA4
		// (set) Token: 0x0600004F RID: 79 RVA: 0x00014E05 File Offset: 0x00013005
		[Nullable(2)]
		public virtual IEntityState ActiveStateCondition
		{
			[NullableContext(2)]
			get
			{
				if (this._ActiveStateConditionInited)
				{
					return this._ActiveStateConditionCache;
				}
				this._ActiveStateConditionInited = true;
				if (this.FbInstance != null)
				{
					this._ActiveStateConditionCache = IEntityState.Create(this.FbInstance.ActiveStateCondition);
				}
				else
				{
					AdsorbComponent_SetValue pocoInterface = this.PocoInterface;
					this._ActiveStateConditionCache = ((pocoInterface != null) ? pocoInterface.ActiveStateCondition : null);
				}
				return this._ActiveStateConditionCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().ActiveStateCondition = value;
				this._ActiveStateConditionInited = false;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000050 RID: 80 RVA: 0x00014E1A File Offset: 0x0001301A
		// (set) Token: 0x06000051 RID: 81 RVA: 0x00014E45 File Offset: 0x00013045
		public virtual int AdsorbLimitedTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AdsorbLimitedTime;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.AdsorbLimitedTime;
			}
			set
			{
				this.GetOrCreatePoco().AdsorbLimitedTime = value;
			}
		}

		// Token: 0x04000034 RID: 52
		[Nullable(2)]
		protected new AdsorbComponent FbInstance;

		// Token: 0x04000035 RID: 53
		[Nullable(2)]
		protected new AdsorbComponent_SetValue PocoInterface;

		// Token: 0x04000036 RID: 54
		private IEntityState _ActiveStateConditionCache;

		// Token: 0x04000037 RID: 55
		private bool _ActiveStateConditionInited;
	}
}
