using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007FF RID: 2047
	[NullableContext(1)]
	[Nullable(0)]
	public class IWuWaGoGridLinkData
	{
		// Token: 0x06002C75 RID: 11381 RVA: 0x00073760 File Offset: 0x00071960
		private IWuWaGoGridLinkData_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IWuWaGoGridLinkData 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IWuWaGoGridLinkData_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IWuWaGoGridLinkData_SetValue());
			}
			return result;
		}

		// Token: 0x06002C76 RID: 11382 RVA: 0x00073798 File Offset: 0x00071998
		public static IWuWaGoGridLinkData Create([Nullable(2)] IWuWaGoGridLinkData instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWuWaGoGridLinkData
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002C77 RID: 11383 RVA: 0x000737AB File Offset: 0x000719AB
		public static IWuWaGoGridLinkData CreateFromSetValue([Nullable(2)] IWuWaGoGridLinkData_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IWuWaGoGridLinkData
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002C78 RID: 11384 RVA: 0x000737BE File Offset: 0x000719BE
		public IWuWaGoGridLinkData_SetValue ToSetValue()
		{
			return new IWuWaGoGridLinkData_SetValue
			{
				GridLinkType = this.GridLinkType,
				RotationType = this.RotationType
			};
		}

		// Token: 0x17000B9F RID: 2975
		// (get) Token: 0x06002C79 RID: 11385 RVA: 0x000737DD File Offset: 0x000719DD
		// (set) Token: 0x06002C7A RID: 11386 RVA: 0x00073808 File Offset: 0x00071A08
		public virtual EWuWaGoGridLinkType GridLinkType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.GridLinkType;
				}
				if (this.PocoInterface == null)
				{
					return EWuWaGoGridLinkType.EmptyGrid;
				}
				return this.PocoInterface.GridLinkType;
			}
			set
			{
				this.GetOrCreatePoco().GridLinkType = value;
			}
		}

		// Token: 0x17000BA0 RID: 2976
		// (get) Token: 0x06002C7B RID: 11387 RVA: 0x00073816 File Offset: 0x00071A16
		// (set) Token: 0x06002C7C RID: 11388 RVA: 0x00073841 File Offset: 0x00071A41
		public virtual EWuWaGoGridRotationType RotationType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RotationType;
				}
				if (this.PocoInterface == null)
				{
					return EWuWaGoGridRotationType.Front;
				}
				return this.PocoInterface.RotationType;
			}
			set
			{
				this.GetOrCreatePoco().RotationType = value;
			}
		}

		// Token: 0x04001D73 RID: 7539
		[Nullable(2)]
		protected IWuWaGoGridLinkData FbInstance;

		// Token: 0x04001D74 RID: 7540
		[Nullable(2)]
		protected IWuWaGoGridLinkData_SetValue PocoInterface;
	}
}
