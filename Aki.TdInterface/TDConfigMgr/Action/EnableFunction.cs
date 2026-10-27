using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200163C RID: 5692
	[NullableContext(1)]
	[Nullable(0)]
	public class EnableFunction : ActionParams
	{
		// Token: 0x06007C4D RID: 31821 RVA: 0x0012AFB8 File Offset: 0x001291B8
		private EnableFunction_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("EnableFunction 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			EnableFunction_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new EnableFunction_SetValue());
			}
			return result;
		}

		// Token: 0x06007C4E RID: 31822 RVA: 0x0012AFF0 File Offset: 0x001291F0
		public static EnableFunction Create([Nullable(2)] EnableFunction instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new EnableFunction
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007C4F RID: 31823 RVA: 0x0012B003 File Offset: 0x00129203
		public static EnableFunction CreateFromSetValue([Nullable(2)] EnableFunction_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new EnableFunction
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007C50 RID: 31824 RVA: 0x0012B016 File Offset: 0x00129216
		public EnableFunction_SetValue ToSetValue()
		{
			return new EnableFunction_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700291F RID: 10527
		// (get) Token: 0x06007C51 RID: 31825 RVA: 0x0012B029 File Offset: 0x00129229
		// (set) Token: 0x06007C52 RID: 31826 RVA: 0x0012B054 File Offset: 0x00129254
		public virtual EEnableFunctionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EEnableFunctionType.TeleportDungeon;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04004C5F RID: 19551
		[Nullable(2)]
		protected new EnableFunction FbInstance;

		// Token: 0x04004C60 RID: 19552
		[Nullable(2)]
		protected EnableFunction_SetValue PocoInterface;
	}
}
