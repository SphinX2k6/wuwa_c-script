using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001061 RID: 4193
	[NullableContext(1)]
	[Nullable(0)]
	public class IProgressBar
	{
		// Token: 0x06005DF2 RID: 24050 RVA: 0x000E3454 File Offset: 0x000E1654
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

		// Token: 0x06005DF3 RID: 24051 RVA: 0x000E348C File Offset: 0x000E168C
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

		// Token: 0x06005DF4 RID: 24052 RVA: 0x000E349F File Offset: 0x000E169F
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

		// Token: 0x06005DF5 RID: 24053 RVA: 0x000E34B2 File Offset: 0x000E16B2
		public IProgressBar_SetValue ToSetValue()
		{
			return new IProgressBar_SetValue
			{
				ProgressStyle = this.ProgressStyle,
				ProgressCalculate = this.ProgressCalculate
			};
		}

		// Token: 0x17001EE9 RID: 7913
		// (get) Token: 0x06005DF6 RID: 24054 RVA: 0x000E34D1 File Offset: 0x000E16D1
		// (set) Token: 0x06005DF7 RID: 24055 RVA: 0x000E34FC File Offset: 0x000E16FC
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

		// Token: 0x17001EEA RID: 7914
		// (get) Token: 0x06005DF8 RID: 24056 RVA: 0x000E350C File Offset: 0x000E170C
		// (set) Token: 0x06005DF9 RID: 24057 RVA: 0x000E356D File Offset: 0x000E176D
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

		// Token: 0x04003890 RID: 14480
		[Nullable(2)]
		protected IProgressBar FbInstance;

		// Token: 0x04003891 RID: 14481
		[Nullable(2)]
		protected IProgressBar_SetValue PocoInterface;

		// Token: 0x04003892 RID: 14482
		private IProgressCalculate _ProgressCalculateCache;

		// Token: 0x04003893 RID: 14483
		private bool _ProgressCalculateInited;
	}
}
