using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006EF RID: 1775
	public class IRandomInteractOption
	{
		// Token: 0x060025A4 RID: 9636 RVA: 0x00065F60 File Offset: 0x00064160
		private IRandomInteractOption_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRandomInteractOption 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRandomInteractOption_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRandomInteractOption_SetValue());
			}
			return result;
		}

		// Token: 0x060025A5 RID: 9637 RVA: 0x00065F98 File Offset: 0x00064198
		public static IRandomInteractOption Create([Nullable(2)] IRandomInteractOption instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRandomInteractOption
			{
				FbInstance = instance
			};
		}

		// Token: 0x060025A6 RID: 9638 RVA: 0x00065FAB File Offset: 0x000641AB
		public static IRandomInteractOption CreateFromSetValue([Nullable(2)] IRandomInteractOption_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRandomInteractOption
			{
				PocoInterface = value
			};
		}

		// Token: 0x060025A7 RID: 9639 RVA: 0x00065FBE File Offset: 0x000641BE
		public IRandomInteractOption_SetValue ToSetValue()
		{
			return new IRandomInteractOption_SetValue
			{
				Weight = this.Weight,
				Option = this.Option
			};
		}

		// Token: 0x170009EA RID: 2538
		// (get) Token: 0x060025A8 RID: 9640 RVA: 0x00065FDD File Offset: 0x000641DD
		// (set) Token: 0x060025A9 RID: 9641 RVA: 0x00066008 File Offset: 0x00064208
		public virtual int Weight
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Weight;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Weight;
			}
			set
			{
				this.GetOrCreatePoco().Weight = value;
			}
		}

		// Token: 0x170009EB RID: 2539
		// (get) Token: 0x060025AA RID: 9642 RVA: 0x00066018 File Offset: 0x00064218
		// (set) Token: 0x060025AB RID: 9643 RVA: 0x00066079 File Offset: 0x00064279
		public virtual IInteractOption Option
		{
			get
			{
				if (this._OptionInited)
				{
					return this._OptionCache;
				}
				this._OptionInited = true;
				if (this.FbInstance != null)
				{
					this._OptionCache = IInteractOption.Create(this.FbInstance.Option);
				}
				else
				{
					IRandomInteractOption_SetValue pocoInterface = this.PocoInterface;
					this._OptionCache = ((pocoInterface != null) ? pocoInterface.Option : null);
				}
				return this._OptionCache;
			}
			set
			{
				this.GetOrCreatePoco().Option = value;
				this._OptionInited = false;
			}
		}

		// Token: 0x040019FD RID: 6653
		[Nullable(2)]
		protected IRandomInteractOption FbInstance;

		// Token: 0x040019FE RID: 6654
		[Nullable(2)]
		protected IRandomInteractOption_SetValue PocoInterface;

		// Token: 0x040019FF RID: 6655
		private IInteractOption _OptionCache;

		// Token: 0x04001A00 RID: 6656
		private bool _OptionInited;
	}
}
