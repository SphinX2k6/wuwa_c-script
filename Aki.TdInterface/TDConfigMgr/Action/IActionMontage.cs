using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018DB RID: 6363
	public class IActionMontage
	{
		// Token: 0x0600857F RID: 34175 RVA: 0x0013E2E0 File Offset: 0x0013C4E0
		private IActionMontage_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IActionMontage 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IActionMontage_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IActionMontage_SetValue());
			}
			return result;
		}

		// Token: 0x06008580 RID: 34176 RVA: 0x0013E318 File Offset: 0x0013C518
		public static IActionMontage Create([Nullable(2)] IActionMontage instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActionMontage
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008581 RID: 34177 RVA: 0x0013E32B File Offset: 0x0013C52B
		public static IActionMontage CreateFromSetValue([Nullable(2)] IActionMontage_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IActionMontage
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008582 RID: 34178 RVA: 0x0013E33E File Offset: 0x0013C53E
		public IActionMontage_SetValue ToSetValue()
		{
			return new IActionMontage_SetValue
			{
				MontageType = this.MontageType,
				Path = this.Path
			};
		}

		// Token: 0x17002B83 RID: 11139
		// (get) Token: 0x06008583 RID: 34179 RVA: 0x0013E35D File Offset: 0x0013C55D
		// (set) Token: 0x06008584 RID: 34180 RVA: 0x0013E388 File Offset: 0x0013C588
		public virtual EActionMontageType MontageType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MontageType;
				}
				if (this.PocoInterface == null)
				{
					return EActionMontageType.Normal;
				}
				return this.PocoInterface.MontageType;
			}
			set
			{
				this.GetOrCreatePoco().MontageType = value;
			}
		}

		// Token: 0x17002B84 RID: 11140
		// (get) Token: 0x06008585 RID: 34181 RVA: 0x0013E396 File Offset: 0x0013C596
		// (set) Token: 0x06008586 RID: 34182 RVA: 0x0013E3C1 File Offset: 0x0013C5C1
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

		// Token: 0x040054CC RID: 21708
		[Nullable(2)]
		protected IActionMontage FbInstance;

		// Token: 0x040054CD RID: 21709
		[Nullable(2)]
		protected IActionMontage_SetValue PocoInterface;
	}
}
