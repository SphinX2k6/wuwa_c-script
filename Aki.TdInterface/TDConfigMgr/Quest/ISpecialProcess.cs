using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001274 RID: 4724
	public class ISpecialProcess
	{
		// Token: 0x06006A5D RID: 27229 RVA: 0x000FE718 File Offset: 0x000FC918
		private ISpecialProcess_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISpecialProcess 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISpecialProcess_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISpecialProcess_SetValue());
			}
			return result;
		}

		// Token: 0x06006A5E RID: 27230 RVA: 0x000FE750 File Offset: 0x000FC950
		public static ISpecialProcess Create([Nullable(2)] ISpecialProcess instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISpecialProcess
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006A5F RID: 27231 RVA: 0x000FE763 File Offset: 0x000FC963
		public static ISpecialProcess CreateFromSetValue([Nullable(2)] ISpecialProcess_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISpecialProcess
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006A60 RID: 27232 RVA: 0x000FE776 File Offset: 0x000FC976
		public ISpecialProcess_SetValue ToSetValue()
		{
			return new ISpecialProcess_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002280 RID: 8832
		// (get) Token: 0x06006A61 RID: 27233 RVA: 0x000FE789 File Offset: 0x000FC989
		// (set) Token: 0x06006A62 RID: 27234 RVA: 0x000FE7B4 File Offset: 0x000FC9B4
		public virtual ESpecialProcess Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESpecialProcess.LowMemorySceneSwitch;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04003F9E RID: 16286
		[Nullable(2)]
		protected ISpecialProcess FbInstance;

		// Token: 0x04003F9F RID: 16287
		[Nullable(2)]
		protected ISpecialProcess_SetValue PocoInterface;
	}
}
