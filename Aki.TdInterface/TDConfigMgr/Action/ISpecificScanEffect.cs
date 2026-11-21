using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020D4 RID: 8404
	public class ISpecificScanEffect
	{
		// Token: 0x0600B26E RID: 45678 RVA: 0x00190BB8 File Offset: 0x0018EDB8
		private ISpecificScanEffect_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISpecificScanEffect 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISpecificScanEffect_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISpecificScanEffect_SetValue());
			}
			return result;
		}

		// Token: 0x0600B26F RID: 45679 RVA: 0x00190BF0 File Offset: 0x0018EDF0
		public static ISpecificScanEffect Create([Nullable(2)] ISpecificScanEffect instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISpecificScanEffect
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B270 RID: 45680 RVA: 0x00190C03 File Offset: 0x0018EE03
		public static ISpecificScanEffect CreateFromSetValue([Nullable(2)] ISpecificScanEffect_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISpecificScanEffect
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B271 RID: 45681 RVA: 0x00190C16 File Offset: 0x0018EE16
		public ISpecificScanEffect_SetValue ToSetValue()
		{
			return new ISpecificScanEffect_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003608 RID: 13832
		// (get) Token: 0x0600B272 RID: 45682 RVA: 0x00190C29 File Offset: 0x0018EE29
		// (set) Token: 0x0600B273 RID: 45683 RVA: 0x00190C54 File Offset: 0x0018EE54
		public virtual ESpecificScanType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return (ESpecificScanType)0;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040069E3 RID: 27107
		[Nullable(2)]
		protected ISpecificScanEffect FbInstance;

		// Token: 0x040069E4 RID: 27108
		[Nullable(2)]
		protected ISpecificScanEffect_SetValue PocoInterface;
	}
}
