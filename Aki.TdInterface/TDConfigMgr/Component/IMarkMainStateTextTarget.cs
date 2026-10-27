using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004D8 RID: 1240
	[NullableContext(2)]
	[Nullable(0)]
	public class IMarkMainStateTextTarget
	{
		// Token: 0x06001926 RID: 6438 RVA: 0x0004A900 File Offset: 0x00048B00
		[NullableContext(1)]
		private IMarkMainStateTextTarget_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMarkMainStateTextTarget 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMarkMainStateTextTarget_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMarkMainStateTextTarget_SetValue());
			}
			return result;
		}

		// Token: 0x06001927 RID: 6439 RVA: 0x0004A938 File Offset: 0x00048B38
		[NullableContext(1)]
		public static IMarkMainStateTextTarget Create([Nullable(2)] IMarkMainStateTextTarget instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMarkMainStateTextTarget
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001928 RID: 6440 RVA: 0x0004A94B File Offset: 0x00048B4B
		[NullableContext(1)]
		public static IMarkMainStateTextTarget CreateFromSetValue([Nullable(2)] IMarkMainStateTextTarget_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMarkMainStateTextTarget
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001929 RID: 6441 RVA: 0x0004A95E File Offset: 0x00048B5E
		[NullableContext(1)]
		public IMarkMainStateTextTarget_SetValue ToSetValue()
		{
			return new IMarkMainStateTextTarget_SetValue
			{
				TidTargetName = this.TidTargetName,
				EdTidTargetName = this.EdTidTargetName
			};
		}

		// Token: 0x170006AE RID: 1710
		// (get) Token: 0x0600192A RID: 6442 RVA: 0x0004A97D File Offset: 0x00048B7D
		// (set) Token: 0x0600192B RID: 6443 RVA: 0x0004A9A4 File Offset: 0x00048BA4
		public virtual string TidTargetName
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TidTargetName;
				}
				IMarkMainStateTextTarget_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TidTargetName;
			}
			set
			{
				this.GetOrCreatePoco().TidTargetName = value;
			}
		}

		// Token: 0x170006AF RID: 1711
		// (get) Token: 0x0600192C RID: 6444 RVA: 0x0004A9B2 File Offset: 0x00048BB2
		// (set) Token: 0x0600192D RID: 6445 RVA: 0x0004A9C9 File Offset: 0x00048BC9
		public virtual string EdTidTargetName
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdTidTargetName;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdTidTargetName = value;
			}
		}

		// Token: 0x04001280 RID: 4736
		protected IMarkMainStateTextTarget FbInstance;

		// Token: 0x04001281 RID: 4737
		protected IMarkMainStateTextTarget_SetValue PocoInterface;
	}
}
