using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200181A RID: 6170
	[NullableContext(1)]
	[Nullable(0)]
	public class IBubbleCylinderConfig
	{
		// Token: 0x0600846B RID: 33899 RVA: 0x0013B76C File Offset: 0x0013996C
		private IBubbleCylinderConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IBubbleCylinderConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IBubbleCylinderConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IBubbleCylinderConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600846C RID: 33900 RVA: 0x0013B7A4 File Offset: 0x001399A4
		public static IBubbleCylinderConfig Create([Nullable(2)] IBubbleCylinderConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBubbleCylinderConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600846D RID: 33901 RVA: 0x0013B7B7 File Offset: 0x001399B7
		public static IBubbleCylinderConfig CreateFromSetValue([Nullable(2)] IBubbleCylinderConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IBubbleCylinderConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600846E RID: 33902 RVA: 0x0013B7CA File Offset: 0x001399CA
		public IBubbleCylinderConfig_SetValue ToSetValue()
		{
			return new IBubbleCylinderConfig_SetValue
			{
				Radius = this.Radius,
				Height = this.Height
			};
		}

		// Token: 0x17002B63 RID: 11107
		// (get) Token: 0x0600846F RID: 33903 RVA: 0x0013B7E9 File Offset: 0x001399E9
		// (set) Token: 0x06008470 RID: 33904 RVA: 0x0013B818 File Offset: 0x00139A18
		public virtual float Radius
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Radius;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Radius;
			}
			set
			{
				this.GetOrCreatePoco().Radius = value;
			}
		}

		// Token: 0x17002B64 RID: 11108
		// (get) Token: 0x06008471 RID: 33905 RVA: 0x0013B826 File Offset: 0x00139A26
		// (set) Token: 0x06008472 RID: 33906 RVA: 0x0013B855 File Offset: 0x00139A55
		public virtual float Height
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Height;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Height;
			}
			set
			{
				this.GetOrCreatePoco().Height = value;
			}
		}

		// Token: 0x040053CE RID: 21454
		[Nullable(2)]
		protected IBubbleCylinderConfig FbInstance;

		// Token: 0x040053CF RID: 21455
		[Nullable(2)]
		protected IBubbleCylinderConfig_SetValue PocoInterface;
	}
}
