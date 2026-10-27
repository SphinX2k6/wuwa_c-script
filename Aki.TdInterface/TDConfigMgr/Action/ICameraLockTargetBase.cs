using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001844 RID: 6212
	[NullableContext(1)]
	[Nullable(0)]
	public class ICameraLockTargetBase
	{
		// Token: 0x0600856B RID: 34155 RVA: 0x0013D5B8 File Offset: 0x0013B7B8
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

		// Token: 0x0600856C RID: 34156 RVA: 0x0013D5F0 File Offset: 0x0013B7F0
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

		// Token: 0x0600856D RID: 34157 RVA: 0x0013D603 File Offset: 0x0013B803
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

		// Token: 0x0600856E RID: 34158 RVA: 0x0013D616 File Offset: 0x0013B816
		public ICameraLockTargetBase_SetValue ToSetValue()
		{
			return new ICameraLockTargetBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002BA4 RID: 11172
		// (get) Token: 0x0600856F RID: 34159 RVA: 0x0013D629 File Offset: 0x0013B829
		// (set) Token: 0x06008570 RID: 34160 RVA: 0x0013D654 File Offset: 0x0013B854
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

		// Token: 0x04005447 RID: 21575
		[Nullable(2)]
		protected ICameraLockTargetBase FbInstance;

		// Token: 0x04005448 RID: 21576
		[Nullable(2)]
		protected ICameraLockTargetBase_SetValue PocoInterface;
	}
}
