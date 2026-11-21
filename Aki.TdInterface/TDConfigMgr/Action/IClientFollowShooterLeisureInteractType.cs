using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A45 RID: 6725
	public class IClientFollowShooterLeisureInteractType
	{
		// Token: 0x06008EFB RID: 36603 RVA: 0x001513B8 File Offset: 0x0014F5B8
		private IClientFollowShooterLeisureInteractType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IClientFollowShooterLeisureInteractType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IClientFollowShooterLeisureInteractType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IClientFollowShooterLeisureInteractType_SetValue());
			}
			return result;
		}

		// Token: 0x06008EFC RID: 36604 RVA: 0x001513F0 File Offset: 0x0014F5F0
		public static IClientFollowShooterLeisureInteractType Create([Nullable(2)] IClientFollowShooterLeisureInteractType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IClientFollowShooterLeisureInteractType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008EFD RID: 36605 RVA: 0x00151403 File Offset: 0x0014F603
		public static IClientFollowShooterLeisureInteractType CreateFromSetValue([Nullable(2)] IClientFollowShooterLeisureInteractType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IClientFollowShooterLeisureInteractType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008EFE RID: 36606 RVA: 0x00151416 File Offset: 0x0014F616
		public IClientFollowShooterLeisureInteractType_SetValue ToSetValue()
		{
			return new IClientFollowShooterLeisureInteractType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002E22 RID: 11810
		// (get) Token: 0x06008EFF RID: 36607 RVA: 0x00151429 File Offset: 0x0014F629
		// (set) Token: 0x06008F00 RID: 36608 RVA: 0x00151454 File Offset: 0x0014F654
		public virtual EClientFollowShooterLeisureInteractType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EClientFollowShooterLeisureInteractType.PlayAnimation;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040059B7 RID: 22967
		[Nullable(2)]
		protected IClientFollowShooterLeisureInteractType FbInstance;

		// Token: 0x040059B8 RID: 22968
		[Nullable(2)]
		protected IClientFollowShooterLeisureInteractType_SetValue PocoInterface;
	}
}
