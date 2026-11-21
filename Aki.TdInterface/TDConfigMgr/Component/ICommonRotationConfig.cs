using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000294 RID: 660
	public class ICommonRotationConfig
	{
		// Token: 0x06000BCA RID: 3018 RVA: 0x0002EC9C File Offset: 0x0002CE9C
		private ICommonRotationConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICommonRotationConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICommonRotationConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICommonRotationConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06000BCB RID: 3019 RVA: 0x0002ECD4 File Offset: 0x0002CED4
		public static ICommonRotationConfig Create([Nullable(2)] ICommonRotationConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICommonRotationConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000BCC RID: 3020 RVA: 0x0002ECE7 File Offset: 0x0002CEE7
		public static ICommonRotationConfig CreateFromSetValue([Nullable(2)] ICommonRotationConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICommonRotationConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000BCD RID: 3021 RVA: 0x0002ECFA File Offset: 0x0002CEFA
		public ICommonRotationConfig_SetValue ToSetValue()
		{
			return new ICommonRotationConfig_SetValue
			{
				Type = this.Type,
				Time = this.Time,
				Cd = this.Cd,
				Curve = this.Curve
			};
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x06000BCE RID: 3022 RVA: 0x0002ED31 File Offset: 0x0002CF31
		// (set) Token: 0x06000BCF RID: 3023 RVA: 0x0002ED5C File Offset: 0x0002CF5C
		public virtual ERotationType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ERotationType.Relative;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06000BD0 RID: 3024 RVA: 0x0002ED6A File Offset: 0x0002CF6A
		// (set) Token: 0x06000BD1 RID: 3025 RVA: 0x0002ED99 File Offset: 0x0002CF99
		public virtual float Time
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Time;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Time;
			}
			set
			{
				this.GetOrCreatePoco().Time = value;
			}
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x06000BD2 RID: 3026 RVA: 0x0002EDA8 File Offset: 0x0002CFA8
		// (set) Token: 0x06000BD3 RID: 3027 RVA: 0x0002EDE2 File Offset: 0x0002CFE2
		public virtual float? Cd
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Cd;
				}
				ICommonRotationConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Cd;
			}
			set
			{
				this.GetOrCreatePoco().Cd = value;
			}
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06000BD4 RID: 3028 RVA: 0x0002EDF0 File Offset: 0x0002CFF0
		// (set) Token: 0x06000BD5 RID: 3029 RVA: 0x0002EE17 File Offset: 0x0002D017
		[Nullable(2)]
		public virtual string Curve
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Curve;
				}
				ICommonRotationConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Curve;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().Curve = value;
			}
		}

		// Token: 0x04000B6D RID: 2925
		[Nullable(2)]
		protected ICommonRotationConfig FbInstance;

		// Token: 0x04000B6E RID: 2926
		[Nullable(2)]
		protected ICommonRotationConfig_SetValue PocoInterface;
	}
}
