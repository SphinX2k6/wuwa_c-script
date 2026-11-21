using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020016CA RID: 5834
	public class DisableEntityLookAt : ActionParams
	{
		// Token: 0x060082AB RID: 33451 RVA: 0x00139194 File Offset: 0x00137394
		private DisableEntityLookAt_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("DisableEntityLookAt 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			DisableEntityLookAt_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new DisableEntityLookAt_SetValue());
			}
			return result;
		}

		// Token: 0x060082AC RID: 33452 RVA: 0x001391CC File Offset: 0x001373CC
		public static DisableEntityLookAt Create([Nullable(2)] DisableEntityLookAt instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new DisableEntityLookAt
			{
				FbInstance = instance
			};
		}

		// Token: 0x060082AD RID: 33453 RVA: 0x001391DF File Offset: 0x001373DF
		public static DisableEntityLookAt CreateFromSetValue([Nullable(2)] DisableEntityLookAt_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new DisableEntityLookAt
			{
				PocoInterface = value
			};
		}

		// Token: 0x060082AE RID: 33454 RVA: 0x001391F2 File Offset: 0x001373F2
		public DisableEntityLookAt_SetValue ToSetValue()
		{
			return new DisableEntityLookAt_SetValue
			{
				Key = this.Key
			};
		}

		// Token: 0x17002AEB RID: 10987
		// (get) Token: 0x060082AF RID: 33455 RVA: 0x00139205 File Offset: 0x00137405
		// (set) Token: 0x060082B0 RID: 33456 RVA: 0x00139230 File Offset: 0x00137430
		public virtual string Key
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Key;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Key;
			}
			set
			{
				this.GetOrCreatePoco().Key = value;
			}
		}

		// Token: 0x04004AE4 RID: 19172
		[Nullable(2)]
		protected new DisableEntityLookAt FbInstance;

		// Token: 0x04004AE5 RID: 19173
		[Nullable(2)]
		protected DisableEntityLookAt_SetValue PocoInterface;
	}
}
