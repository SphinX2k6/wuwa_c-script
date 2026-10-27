using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000692 RID: 1682
	[NullableContext(1)]
	[Nullable(0)]
	public class IRtSize
	{
		// Token: 0x06002408 RID: 9224 RVA: 0x00061EB8 File Offset: 0x000600B8
		private IRtSize_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRtSize 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRtSize_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRtSize_SetValue());
			}
			return result;
		}

		// Token: 0x06002409 RID: 9225 RVA: 0x00061EF0 File Offset: 0x000600F0
		public static IRtSize Create([Nullable(2)] IRtSize instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRtSize
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600240A RID: 9226 RVA: 0x00061F03 File Offset: 0x00060103
		public static IRtSize CreateFromSetValue([Nullable(2)] IRtSize_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRtSize
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600240B RID: 9227 RVA: 0x00061F16 File Offset: 0x00060116
		public IRtSize_SetValue ToSetValue()
		{
			return new IRtSize_SetValue
			{
				Length = this.Length,
				Width = this.Width
			};
		}

		// Token: 0x17000988 RID: 2440
		// (get) Token: 0x0600240C RID: 9228 RVA: 0x00061F35 File Offset: 0x00060135
		// (set) Token: 0x0600240D RID: 9229 RVA: 0x00061F60 File Offset: 0x00060160
		public virtual int Length
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Length;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Length;
			}
			set
			{
				this.GetOrCreatePoco().Length = value;
			}
		}

		// Token: 0x17000989 RID: 2441
		// (get) Token: 0x0600240E RID: 9230 RVA: 0x00061F6E File Offset: 0x0006016E
		// (set) Token: 0x0600240F RID: 9231 RVA: 0x00061F99 File Offset: 0x00060199
		public virtual int Width
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Width;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Width;
			}
			set
			{
				this.GetOrCreatePoco().Width = value;
			}
		}

		// Token: 0x040018CA RID: 6346
		[Nullable(2)]
		protected IRtSize FbInstance;

		// Token: 0x040018CB RID: 6347
		[Nullable(2)]
		protected IRtSize_SetValue PocoInterface;
	}
}
