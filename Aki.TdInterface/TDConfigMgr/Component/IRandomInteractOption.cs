using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000652 RID: 1618
	[NullableContext(1)]
	[Nullable(0)]
	public class IRandomInteractOption
	{
		// Token: 0x0600229E RID: 8862 RVA: 0x0005F24C File Offset: 0x0005D44C
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

		// Token: 0x0600229F RID: 8863 RVA: 0x0005F284 File Offset: 0x0005D484
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

		// Token: 0x060022A0 RID: 8864 RVA: 0x0005F297 File Offset: 0x0005D497
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

		// Token: 0x060022A1 RID: 8865 RVA: 0x0005F2AA File Offset: 0x0005D4AA
		public IRandomInteractOption_SetValue ToSetValue()
		{
			return new IRandomInteractOption_SetValue
			{
				Weight = this.Weight,
				Option = this.Option
			};
		}

		// Token: 0x17000933 RID: 2355
		// (get) Token: 0x060022A2 RID: 8866 RVA: 0x0005F2C9 File Offset: 0x0005D4C9
		// (set) Token: 0x060022A3 RID: 8867 RVA: 0x0005F2F4 File Offset: 0x0005D4F4
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

		// Token: 0x17000934 RID: 2356
		// (get) Token: 0x060022A4 RID: 8868 RVA: 0x0005F304 File Offset: 0x0005D504
		// (set) Token: 0x060022A5 RID: 8869 RVA: 0x0005F365 File Offset: 0x0005D565
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

		// Token: 0x0400180B RID: 6155
		[Nullable(2)]
		protected IRandomInteractOption FbInstance;

		// Token: 0x0400180C RID: 6156
		[Nullable(2)]
		protected IRandomInteractOption_SetValue PocoInterface;

		// Token: 0x0400180D RID: 6157
		private IInteractOption _OptionCache;

		// Token: 0x0400180E RID: 6158
		private bool _OptionInited;
	}
}
