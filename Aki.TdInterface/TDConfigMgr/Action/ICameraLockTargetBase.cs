using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019CF RID: 6607
	public class ICameraLockTargetBase
	{
		// Token: 0x06008C91 RID: 35985 RVA: 0x0014CDAC File Offset: 0x0014AFAC
		private ICameraLockTargetBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICameraLockTargetBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICameraLockTargetBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICameraLockTargetBase_SetValue());
			}
			return result;
		}

		// Token: 0x06008C92 RID: 35986 RVA: 0x0014CDE4 File Offset: 0x0014AFE4
		public static ICameraLockTargetBase Create([Nullable(2)] ICameraLockTargetBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICameraLockTargetBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008C93 RID: 35987 RVA: 0x0014CDF7 File Offset: 0x0014AFF7
		public static ICameraLockTargetBase CreateFromSetValue([Nullable(2)] ICameraLockTargetBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICameraLockTargetBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008C94 RID: 35988 RVA: 0x0014CE0A File Offset: 0x0014B00A
		public ICameraLockTargetBase_SetValue ToSetValue()
		{
			return new ICameraLockTargetBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002D9E RID: 11678
		// (get) Token: 0x06008C95 RID: 35989 RVA: 0x0014CE1D File Offset: 0x0014B01D
		// (set) Token: 0x06008C96 RID: 35990 RVA: 0x0014CE48 File Offset: 0x0014B048
		public virtual ECameraLockTargetType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECameraLockTargetType.TargetPosition;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005893 RID: 22675
		[Nullable(2)]
		protected ICameraLockTargetBase FbInstance;

		// Token: 0x04005894 RID: 22676
		[Nullable(2)]
		protected ICameraLockTargetBase_SetValue PocoInterface;
	}
}
