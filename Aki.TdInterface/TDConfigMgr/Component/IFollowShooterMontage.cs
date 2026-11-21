using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003F9 RID: 1017
	public class IFollowShooterMontage
	{
		// Token: 0x06001421 RID: 5153 RVA: 0x000410EC File Offset: 0x0003F2EC
		private IFollowShooterMontage_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFollowShooterMontage 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFollowShooterMontage_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFollowShooterMontage_SetValue());
			}
			return result;
		}

		// Token: 0x06001422 RID: 5154 RVA: 0x00041124 File Offset: 0x0003F324
		public static IFollowShooterMontage Create([Nullable(2)] IFollowShooterMontage instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFollowShooterMontage
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001423 RID: 5155 RVA: 0x00041137 File Offset: 0x0003F337
		public static IFollowShooterMontage CreateFromSetValue([Nullable(2)] IFollowShooterMontage_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFollowShooterMontage
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001424 RID: 5156 RVA: 0x0004114A File Offset: 0x0003F34A
		public IFollowShooterMontage_SetValue ToSetValue()
		{
			return new IFollowShooterMontage_SetValue
			{
				Name = this.Name,
				Path = this.Path
			};
		}

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x06001425 RID: 5157 RVA: 0x00041169 File Offset: 0x0003F369
		// (set) Token: 0x06001426 RID: 5158 RVA: 0x00041194 File Offset: 0x0003F394
		public virtual EFollowShooterMontageType Name
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Name;
				}
				if (this.PocoInterface == null)
				{
					return EFollowShooterMontageType.Born;
				}
				return this.PocoInterface.Name;
			}
			set
			{
				this.GetOrCreatePoco().Name = value;
			}
		}

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x06001427 RID: 5159 RVA: 0x000411A2 File Offset: 0x0003F3A2
		// (set) Token: 0x06001428 RID: 5160 RVA: 0x000411CD File Offset: 0x0003F3CD
		public virtual string Path
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Path;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Path;
			}
			set
			{
				this.GetOrCreatePoco().Path = value;
			}
		}

		// Token: 0x04001014 RID: 4116
		[Nullable(2)]
		protected IFollowShooterMontage FbInstance;

		// Token: 0x04001015 RID: 4117
		[Nullable(2)]
		protected IFollowShooterMontage_SetValue PocoInterface;
	}
}
