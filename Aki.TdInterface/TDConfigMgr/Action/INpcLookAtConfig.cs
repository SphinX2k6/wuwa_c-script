using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C6E RID: 7278
	[NullableContext(1)]
	[Nullable(0)]
	public class INpcLookAtConfig
	{
		// Token: 0x06009C15 RID: 39957 RVA: 0x00166258 File Offset: 0x00164458
		private INpcLookAtConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INpcLookAtConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INpcLookAtConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INpcLookAtConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06009C16 RID: 39958 RVA: 0x00166290 File Offset: 0x00164490
		public static INpcLookAtConfig Create([Nullable(2)] INpcLookAtConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcLookAtConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009C17 RID: 39959 RVA: 0x001662A3 File Offset: 0x001644A3
		public static INpcLookAtConfig CreateFromSetValue([Nullable(2)] INpcLookAtConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INpcLookAtConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009C18 RID: 39960 RVA: 0x001662B6 File Offset: 0x001644B6
		public INpcLookAtConfig_SetValue ToSetValue()
		{
			return new INpcLookAtConfig_SetValue
			{
				Target = this.Target,
				IsKeepOverAngle = this.IsKeepOverAngle,
				MaxDistance = this.MaxDistance,
				MaxAngle = this.MaxAngle
			};
		}

		// Token: 0x170030BC RID: 12476
		// (get) Token: 0x06009C19 RID: 39961 RVA: 0x001662ED File Offset: 0x001644ED
		// (set) Token: 0x06009C1A RID: 39962 RVA: 0x00166314 File Offset: 0x00164514
		public virtual INpcLookAtTypeBase Target
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Target;
				}
				INpcLookAtConfig_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170030BD RID: 12477
		// (get) Token: 0x06009C1B RID: 39963 RVA: 0x00166324 File Offset: 0x00164524
		// (set) Token: 0x06009C1C RID: 39964 RVA: 0x0016635E File Offset: 0x0016455E
		public virtual bool? IsKeepOverAngle
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsKeepOverAngle;
				}
				INpcLookAtConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsKeepOverAngle;
			}
			set
			{
				this.GetOrCreatePoco().IsKeepOverAngle = value;
			}
		}

		// Token: 0x170030BE RID: 12478
		// (get) Token: 0x06009C1D RID: 39965 RVA: 0x0016636C File Offset: 0x0016456C
		// (set) Token: 0x06009C1E RID: 39966 RVA: 0x0016639B File Offset: 0x0016459B
		public virtual float MaxDistance
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MaxDistance;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.MaxDistance;
			}
			set
			{
				this.GetOrCreatePoco().MaxDistance = value;
			}
		}

		// Token: 0x170030BF RID: 12479
		// (get) Token: 0x06009C1F RID: 39967 RVA: 0x001663A9 File Offset: 0x001645A9
		// (set) Token: 0x06009C20 RID: 39968 RVA: 0x001663D8 File Offset: 0x001645D8
		public virtual float MaxAngle
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MaxAngle;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.MaxAngle;
			}
			set
			{
				this.GetOrCreatePoco().MaxAngle = value;
			}
		}

		// Token: 0x04005EB3 RID: 24243
		[Nullable(2)]
		protected INpcLookAtConfig FbInstance;

		// Token: 0x04005EB4 RID: 24244
		[Nullable(2)]
		protected INpcLookAtConfig_SetValue PocoInterface;
	}
}
