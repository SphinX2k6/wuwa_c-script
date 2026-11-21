using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E73 RID: 7795
	public class INpcLookAtConfig
	{
		// Token: 0x0600A5AF RID: 42415 RVA: 0x00179C4C File Offset: 0x00177E4C
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

		// Token: 0x0600A5B0 RID: 42416 RVA: 0x00179C84 File Offset: 0x00177E84
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

		// Token: 0x0600A5B1 RID: 42417 RVA: 0x00179C97 File Offset: 0x00177E97
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

		// Token: 0x0600A5B2 RID: 42418 RVA: 0x00179CAA File Offset: 0x00177EAA
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

		// Token: 0x17003339 RID: 13113
		// (get) Token: 0x0600A5B3 RID: 42419 RVA: 0x00179CE1 File Offset: 0x00177EE1
		// (set) Token: 0x0600A5B4 RID: 42420 RVA: 0x00179D08 File Offset: 0x00177F08
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

		// Token: 0x1700333A RID: 13114
		// (get) Token: 0x0600A5B5 RID: 42421 RVA: 0x00179D18 File Offset: 0x00177F18
		// (set) Token: 0x0600A5B6 RID: 42422 RVA: 0x00179D52 File Offset: 0x00177F52
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

		// Token: 0x1700333B RID: 13115
		// (get) Token: 0x0600A5B7 RID: 42423 RVA: 0x00179D60 File Offset: 0x00177F60
		// (set) Token: 0x0600A5B8 RID: 42424 RVA: 0x00179D8F File Offset: 0x00177F8F
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

		// Token: 0x1700333C RID: 13116
		// (get) Token: 0x0600A5B9 RID: 42425 RVA: 0x00179D9D File Offset: 0x00177F9D
		// (set) Token: 0x0600A5BA RID: 42426 RVA: 0x00179DCC File Offset: 0x00177FCC
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

		// Token: 0x04006406 RID: 25606
		[Nullable(2)]
		protected INpcLookAtConfig FbInstance;

		// Token: 0x04006407 RID: 25607
		[Nullable(2)]
		protected INpcLookAtConfig_SetValue PocoInterface;
	}
}
