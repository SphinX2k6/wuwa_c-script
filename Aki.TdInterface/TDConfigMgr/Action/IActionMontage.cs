using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200175A RID: 5978
	[NullableContext(1)]
	[Nullable(0)]
	public class IActionMontage
	{
		// Token: 0x06007E8F RID: 32399 RVA: 0x0012F080 File Offset: 0x0012D280
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

		// Token: 0x06007E90 RID: 32400 RVA: 0x0012F0B8 File Offset: 0x0012D2B8
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

		// Token: 0x06007E91 RID: 32401 RVA: 0x0012F0CB File Offset: 0x0012D2CB
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

		// Token: 0x06007E92 RID: 32402 RVA: 0x0012F0DE File Offset: 0x0012D2DE
		public IActionMontage_SetValue ToSetValue()
		{
			return new IActionMontage_SetValue
			{
				MontageType = this.MontageType,
				Path = this.Path
			};
		}

		// Token: 0x17002995 RID: 10645
		// (get) Token: 0x06007E93 RID: 32403 RVA: 0x0012F0FD File Offset: 0x0012D2FD
		// (set) Token: 0x06007E94 RID: 32404 RVA: 0x0012F128 File Offset: 0x0012D328
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

		// Token: 0x17002996 RID: 10646
		// (get) Token: 0x06007E95 RID: 32405 RVA: 0x0012F136 File Offset: 0x0012D336
		// (set) Token: 0x06007E96 RID: 32406 RVA: 0x0012F161 File Offset: 0x0012D361
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

		// Token: 0x04005096 RID: 20630
		[Nullable(2)]
		protected IActionMontage FbInstance;

		// Token: 0x04005097 RID: 20631
		[Nullable(2)]
		protected IActionMontage_SetValue PocoInterface;
	}
}
