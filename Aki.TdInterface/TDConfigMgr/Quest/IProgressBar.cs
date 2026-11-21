using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200118F RID: 4495
	public class IProgressBar
	{
		// Token: 0x060063E4 RID: 25572 RVA: 0x000F0428 File Offset: 0x000EE628
		private IProgressBar_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IProgressBar 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IProgressBar_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IProgressBar_SetValue());
			}
			return result;
		}

		// Token: 0x060063E5 RID: 25573 RVA: 0x000F0460 File Offset: 0x000EE660
		public static IProgressBar Create([Nullable(2)] IProgressBar instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IProgressBar
			{
				FbInstance = instance
			};
		}

		// Token: 0x060063E6 RID: 25574 RVA: 0x000F0473 File Offset: 0x000EE673
		public static IProgressBar CreateFromSetValue([Nullable(2)] IProgressBar_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IProgressBar
			{
				PocoInterface = value
			};
		}

		// Token: 0x060063E7 RID: 25575 RVA: 0x000F0486 File Offset: 0x000EE686
		public IProgressBar_SetValue ToSetValue()
		{
			return new IProgressBar_SetValue
			{
				ProgressStyle = this.ProgressStyle,
				ProgressCalculate = this.ProgressCalculate
			};
		}

		// Token: 0x17002098 RID: 8344
		// (get) Token: 0x060063E8 RID: 25576 RVA: 0x000F04A5 File Offset: 0x000EE6A5
		// (set) Token: 0x060063E9 RID: 25577 RVA: 0x000F04D0 File Offset: 0x000EE6D0
		public virtual EProgressBarStyle ProgressStyle
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ProgressStyle;
				}
				if (this.PocoInterface == null)
				{
					return EProgressBarStyle.Default;
				}
				return this.PocoInterface.ProgressStyle;
			}
			set
			{
				this.GetOrCreatePoco().ProgressStyle = value;
			}
		}

		// Token: 0x17002099 RID: 8345
		// (get) Token: 0x060063EA RID: 25578 RVA: 0x000F04E0 File Offset: 0x000EE6E0
		// (set) Token: 0x060063EB RID: 25579 RVA: 0x000F0541 File Offset: 0x000EE741
		public virtual IProgressCalculate ProgressCalculate
		{
			get
			{
				if (this._ProgressCalculateInited)
				{
					return this._ProgressCalculateCache;
				}
				this._ProgressCalculateInited = true;
				if (this.FbInstance != null)
				{
					this._ProgressCalculateCache = IProgressCalculate.Create(this.FbInstance.ProgressCalculate);
				}
				else
				{
					IProgressBar_SetValue pocoInterface = this.PocoInterface;
					this._ProgressCalculateCache = ((pocoInterface != null) ? pocoInterface.ProgressCalculate : null);
				}
				return this._ProgressCalculateCache;
			}
			set
			{
				this.GetOrCreatePoco().ProgressCalculate = value;
				this._ProgressCalculateInited = false;
			}
		}

		// Token: 0x04003BD8 RID: 15320
		[Nullable(2)]
		protected IProgressBar FbInstance;

		// Token: 0x04003BD9 RID: 15321
		[Nullable(2)]
		protected IProgressBar_SetValue PocoInterface;

		// Token: 0x04003BDA RID: 15322
		private IProgressCalculate _ProgressCalculateCache;

		// Token: 0x04003BDB RID: 15323
		private bool _ProgressCalculateInited;
	}
}
