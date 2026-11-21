using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020017A9 RID: 6057
	public class EnableFunction : ActionParams
	{
		// Token: 0x0600832B RID: 33579 RVA: 0x0013A064 File Offset: 0x00138264
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

		// Token: 0x0600832C RID: 33580 RVA: 0x0013A09C File Offset: 0x0013829C
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

		// Token: 0x0600832D RID: 33581 RVA: 0x0013A0AF File Offset: 0x001382AF
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

		// Token: 0x0600832E RID: 33582 RVA: 0x0013A0C2 File Offset: 0x001382C2
		public EnableFunction_SetValue ToSetValue()
		{
			return new EnableFunction_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002B0A RID: 11018
		// (get) Token: 0x0600832F RID: 33583 RVA: 0x0013A0D5 File Offset: 0x001382D5
		// (set) Token: 0x06008330 RID: 33584 RVA: 0x0013A100 File Offset: 0x00138300
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

		// Token: 0x04005053 RID: 20563
		[Nullable(2)]
		protected new EnableFunction FbInstance;

		// Token: 0x04005054 RID: 20564
		[Nullable(2)]
		protected EnableFunction_SetValue PocoInterface;
	}
}
