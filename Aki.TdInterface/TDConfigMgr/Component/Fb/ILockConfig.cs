using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000AD2 RID: 2770
	public class ILockConfig
	{
		// Token: 0x06003FD1 RID: 16337 RVA: 0x000A32E6 File Offset: 0x000A14E6
		[NullableContext(1)]
		public static ILockConfig Create(ILockConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILockConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000FEA RID: 4074
		// (get) Token: 0x06003FD2 RID: 16338 RVA: 0x000A3305 File Offset: 0x000A1505
		public virtual bool IsInitLock
		{
			get
			{
				return this.Instance.IsInitLock;
			}
		}

		// Token: 0x17000FEB RID: 4075
		// (get) Token: 0x06003FD3 RID: 16339 RVA: 0x000A3314 File Offset: 0x000A1514
		public virtual ELockType? LockType
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new ELockType?((ELockType)this.Instance.LockType);
			}
		}

		// Token: 0x04002389 RID: 9097
		private ILockConfig Instance;
	}
}
