using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000733 RID: 1843
	public class IRtSize
	{
		// Token: 0x06002724 RID: 10020 RVA: 0x00068E80 File Offset: 0x00067080
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

		// Token: 0x06002725 RID: 10021 RVA: 0x00068EB8 File Offset: 0x000670B8
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

		// Token: 0x06002726 RID: 10022 RVA: 0x00068ECB File Offset: 0x000670CB
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

		// Token: 0x06002727 RID: 10023 RVA: 0x00068EDE File Offset: 0x000670DE
		public IRtSize_SetValue ToSetValue()
		{
			return new IRtSize_SetValue
			{
				Length = this.Length,
				Width = this.Width
			};
		}

		// Token: 0x17000A44 RID: 2628
		// (get) Token: 0x06002728 RID: 10024 RVA: 0x00068EFD File Offset: 0x000670FD
		// (set) Token: 0x06002729 RID: 10025 RVA: 0x00068F28 File Offset: 0x00067128
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

		// Token: 0x17000A45 RID: 2629
		// (get) Token: 0x0600272A RID: 10026 RVA: 0x00068F36 File Offset: 0x00067136
		// (set) Token: 0x0600272B RID: 10027 RVA: 0x00068F61 File Offset: 0x00067161
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

		// Token: 0x04001AC7 RID: 6855
		[Nullable(2)]
		protected IRtSize FbInstance;

		// Token: 0x04001AC8 RID: 6856
		[Nullable(2)]
		protected IRtSize_SetValue PocoInterface;
	}
}
