using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004C5 RID: 1221
	public class IInitStateMagneticStorm : IInitState
	{
		// Token: 0x0600186B RID: 6251 RVA: 0x00049B14 File Offset: 0x00047D14
		private IInitStateMagneticStorm_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IInitStateMagneticStorm 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IInitStateMagneticStorm_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IInitStateMagneticStorm_SetValue());
			}
			return result;
		}

		// Token: 0x0600186C RID: 6252 RVA: 0x00049B4C File Offset: 0x00047D4C
		public static IInitStateMagneticStorm Create([Nullable(2)] IInitStateMagneticStorm instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInitStateMagneticStorm
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600186D RID: 6253 RVA: 0x00049B5F File Offset: 0x00047D5F
		public static IInitStateMagneticStorm CreateFromSetValue([Nullable(2)] IInitStateMagneticStorm_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IInitStateMagneticStorm
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600186E RID: 6254 RVA: 0x00049B72 File Offset: 0x00047D72
		public new IInitStateMagneticStorm_SetValue ToSetValue()
		{
			return new IInitStateMagneticStorm_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x0600186F RID: 6255 RVA: 0x00049B85 File Offset: 0x00047D85
		// (set) Token: 0x06001870 RID: 6256 RVA: 0x00049BB0 File Offset: 0x00047DB0
		public override EInitStateType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EInitStateType.Birth;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001269 RID: 4713
		[Nullable(2)]
		protected new IInitStateMagneticStorm FbInstance;

		// Token: 0x0400126A RID: 4714
		[Nullable(2)]
		protected new IInitStateMagneticStorm_SetValue PocoInterface;
	}
}
