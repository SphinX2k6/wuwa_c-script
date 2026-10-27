using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200156C RID: 5484
	[NullableContext(1)]
	[Nullable(0)]
	public class DisableEntityLookAt : ActionParams
	{
		// Token: 0x06007BCD RID: 31693 RVA: 0x0012A0E8 File Offset: 0x001282E8
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

		// Token: 0x06007BCE RID: 31694 RVA: 0x0012A120 File Offset: 0x00128320
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

		// Token: 0x06007BCF RID: 31695 RVA: 0x0012A133 File Offset: 0x00128333
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

		// Token: 0x06007BD0 RID: 31696 RVA: 0x0012A146 File Offset: 0x00128346
		public DisableEntityLookAt_SetValue ToSetValue()
		{
			return new DisableEntityLookAt_SetValue
			{
				Key = this.Key
			};
		}

		// Token: 0x17002900 RID: 10496
		// (get) Token: 0x06007BD1 RID: 31697 RVA: 0x0012A159 File Offset: 0x00128359
		// (set) Token: 0x06007BD2 RID: 31698 RVA: 0x0012A184 File Offset: 0x00128384
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

		// Token: 0x04004744 RID: 18244
		[Nullable(2)]
		protected new DisableEntityLookAt FbInstance;

		// Token: 0x04004745 RID: 18245
		[Nullable(2)]
		protected DisableEntityLookAt_SetValue PocoInterface;
	}
}
