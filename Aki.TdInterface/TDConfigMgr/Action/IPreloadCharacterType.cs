using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F55 RID: 8021
	public class IPreloadCharacterType
	{
		// Token: 0x0600AAAD RID: 43693 RVA: 0x00182D98 File Offset: 0x00180F98
		private IPreloadCharacterType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPreloadCharacterType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPreloadCharacterType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPreloadCharacterType_SetValue());
			}
			return result;
		}

		// Token: 0x0600AAAE RID: 43694 RVA: 0x00182DD0 File Offset: 0x00180FD0
		public static IPreloadCharacterType Create([Nullable(2)] IPreloadCharacterType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPreloadCharacterType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AAAF RID: 43695 RVA: 0x00182DE3 File Offset: 0x00180FE3
		public static IPreloadCharacterType CreateFromSetValue([Nullable(2)] IPreloadCharacterType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPreloadCharacterType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AAB0 RID: 43696 RVA: 0x00182DF6 File Offset: 0x00180FF6
		public IPreloadCharacterType_SetValue ToSetValue()
		{
			return new IPreloadCharacterType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003465 RID: 13413
		// (get) Token: 0x0600AAB1 RID: 43697 RVA: 0x00182E09 File Offset: 0x00181009
		// (set) Token: 0x0600AAB2 RID: 43698 RVA: 0x00182E34 File Offset: 0x00181034
		public virtual EPreloadObjectType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPreloadObjectType.PreloadTrialCharacterForSkill;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006654 RID: 26196
		[Nullable(2)]
		protected IPreloadCharacterType FbInstance;

		// Token: 0x04006655 RID: 26197
		[Nullable(2)]
		protected IPreloadCharacterType_SetValue PocoInterface;
	}
}
