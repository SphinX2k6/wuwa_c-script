using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000549 RID: 1353
	public class IMechHookAcceleration
	{
		// Token: 0x06001B58 RID: 7000 RVA: 0x0004FB84 File Offset: 0x0004DD84
		private IMechHookAcceleration_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMechHookAcceleration 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMechHookAcceleration_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMechHookAcceleration_SetValue());
			}
			return result;
		}

		// Token: 0x06001B59 RID: 7001 RVA: 0x0004FBBC File Offset: 0x0004DDBC
		public static IMechHookAcceleration Create([Nullable(2)] IMechHookAcceleration instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMechHookAcceleration
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001B5A RID: 7002 RVA: 0x0004FBCF File Offset: 0x0004DDCF
		public static IMechHookAcceleration CreateFromSetValue([Nullable(2)] IMechHookAcceleration_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMechHookAcceleration
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001B5B RID: 7003 RVA: 0x0004FBE2 File Offset: 0x0004DDE2
		public IMechHookAcceleration_SetValue ToSetValue()
		{
			return new IMechHookAcceleration_SetValue
			{
				MaxSpeed = this.MaxSpeed,
				SpeedSampleCurve = this.SpeedSampleCurve
			};
		}

		// Token: 0x1700073D RID: 1853
		// (get) Token: 0x06001B5C RID: 7004 RVA: 0x0004FC01 File Offset: 0x0004DE01
		// (set) Token: 0x06001B5D RID: 7005 RVA: 0x0004FC2C File Offset: 0x0004DE2C
		public virtual int MaxSpeed
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MaxSpeed;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.MaxSpeed;
			}
			set
			{
				this.GetOrCreatePoco().MaxSpeed = value;
			}
		}

		// Token: 0x1700073E RID: 1854
		// (get) Token: 0x06001B5E RID: 7006 RVA: 0x0004FC3A File Offset: 0x0004DE3A
		// (set) Token: 0x06001B5F RID: 7007 RVA: 0x0004FC65 File Offset: 0x0004DE65
		public virtual string SpeedSampleCurve
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SpeedSampleCurve;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.SpeedSampleCurve;
			}
			set
			{
				this.GetOrCreatePoco().SpeedSampleCurve = value;
			}
		}

		// Token: 0x040013FE RID: 5118
		[Nullable(2)]
		protected IMechHookAcceleration FbInstance;

		// Token: 0x040013FF RID: 5119
		[Nullable(2)]
		protected IMechHookAcceleration_SetValue PocoInterface;
	}
}
