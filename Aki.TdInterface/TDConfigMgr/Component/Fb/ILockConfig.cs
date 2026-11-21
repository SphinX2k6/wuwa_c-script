using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B9C RID: 2972
	public class ILockConfig
	{
		// Token: 0x060043FB RID: 17403 RVA: 0x000AC8DA File Offset: 0x000AAADA
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

		// Token: 0x170010BE RID: 4286
		// (get) Token: 0x060043FC RID: 17404 RVA: 0x000AC8F9 File Offset: 0x000AAAF9
		public virtual bool IsInitLock
		{
			get
			{
				return this.Instance.IsInitLock;
			}
		}

		// Token: 0x170010BF RID: 4287
		// (get) Token: 0x060043FD RID: 17405 RVA: 0x000AC908 File Offset: 0x000AAB08
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

		// Token: 0x040025A5 RID: 9637
		private ILockConfig Instance;
	}
}
