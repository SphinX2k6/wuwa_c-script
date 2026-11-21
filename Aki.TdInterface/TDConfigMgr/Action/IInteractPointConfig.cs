using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D03 RID: 7427
	public class IInteractPointConfig
	{
		// Token: 0x06009DBD RID: 40381 RVA: 0x0016B220 File Offset: 0x00169420
		private IInteractPointConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IInteractPointConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IInteractPointConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IInteractPointConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06009DBE RID: 40382 RVA: 0x0016B258 File Offset: 0x00169458
		public static IInteractPointConfig Create([Nullable(2)] IInteractPointConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInteractPointConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009DBF RID: 40383 RVA: 0x0016B26B File Offset: 0x0016946B
		public static IInteractPointConfig CreateFromSetValue([Nullable(2)] IInteractPointConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IInteractPointConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009DC0 RID: 40384 RVA: 0x0016B27E File Offset: 0x0016947E
		public IInteractPointConfig_SetValue ToSetValue()
		{
			return new IInteractPointConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003168 RID: 12648
		// (get) Token: 0x06009DC1 RID: 40385 RVA: 0x0016B291 File Offset: 0x00169491
		// (set) Token: 0x06009DC2 RID: 40386 RVA: 0x0016B2BC File Offset: 0x001694BC
		public virtual EInteractUnlockType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EInteractUnlockType.Sequence;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400604B RID: 24651
		[Nullable(2)]
		protected IInteractPointConfig FbInstance;

		// Token: 0x0400604C RID: 24652
		[Nullable(2)]
		protected IInteractPointConfig_SetValue PocoInterface;
	}
}
