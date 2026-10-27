using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000013 RID: 19
	[NullableContext(1)]
	[Nullable(0)]
	public class AdsorbComponent : IComponentBase
	{
		// Token: 0x06000040 RID: 64 RVA: 0x000142F8 File Offset: 0x000124F8
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

		// Token: 0x06000041 RID: 65 RVA: 0x00014330 File Offset: 0x00012530
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

		// Token: 0x06000042 RID: 66 RVA: 0x00014343 File Offset: 0x00012543
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

		// Token: 0x06000043 RID: 67 RVA: 0x00014358 File Offset: 0x00012558
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
		// (get) Token: 0x06000044 RID: 68 RVA: 0x000143C0 File Offset: 0x000125C0
		// (set) Token: 0x06000045 RID: 69 RVA: 0x000143FA File Offset: 0x000125FA
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
		// (get) Token: 0x06000046 RID: 70 RVA: 0x00014408 File Offset: 0x00012608
		// (set) Token: 0x06000047 RID: 71 RVA: 0x00014432 File Offset: 0x00012632
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
		// (get) Token: 0x06000048 RID: 72 RVA: 0x00014440 File Offset: 0x00012640
		// (set) Token: 0x06000049 RID: 73 RVA: 0x0001446F File Offset: 0x0001266F
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
		// (get) Token: 0x0600004A RID: 74 RVA: 0x0001447D File Offset: 0x0001267D
		// (set) Token: 0x0600004B RID: 75 RVA: 0x000144AC File Offset: 0x000126AC
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
		// (get) Token: 0x0600004C RID: 76 RVA: 0x000144BA File Offset: 0x000126BA
		// (set) Token: 0x0600004D RID: 77 RVA: 0x000144E9 File Offset: 0x000126E9
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
		// (get) Token: 0x0600004E RID: 78 RVA: 0x000144F8 File Offset: 0x000126F8
		// (set) Token: 0x0600004F RID: 79 RVA: 0x00014559 File Offset: 0x00012759
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
		// (get) Token: 0x06000050 RID: 80 RVA: 0x0001456E File Offset: 0x0001276E
		// (set) Token: 0x06000051 RID: 81 RVA: 0x00014599 File Offset: 0x00012799
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

		// Token: 0x04000033 RID: 51
		[Nullable(2)]
		protected new AdsorbComponent FbInstance;

		// Token: 0x04000034 RID: 52
		[Nullable(2)]
		protected new AdsorbComponent_SetValue PocoInterface;

		// Token: 0x04000035 RID: 53
		private IEntityState _ActiveStateConditionCache;

		// Token: 0x04000036 RID: 54
		private bool _ActiveStateConditionInited;
	}
}
