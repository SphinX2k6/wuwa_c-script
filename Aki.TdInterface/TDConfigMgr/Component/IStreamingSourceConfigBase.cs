using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007CC RID: 1996
	public class IStreamingSourceConfigBase
	{
		// Token: 0x06002AC5 RID: 10949 RVA: 0x000707BC File Offset: 0x0006E9BC
		private IStreamingSourceConfigBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IStreamingSourceConfigBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IStreamingSourceConfigBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IStreamingSourceConfigBase_SetValue());
			}
			return result;
		}

		// Token: 0x06002AC6 RID: 10950 RVA: 0x000707F4 File Offset: 0x0006E9F4
		public static IStreamingSourceConfigBase Create([Nullable(2)] IStreamingSourceConfigBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStreamingSourceConfigBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002AC7 RID: 10951 RVA: 0x00070807 File Offset: 0x0006EA07
		public static IStreamingSourceConfigBase CreateFromSetValue([Nullable(2)] IStreamingSourceConfigBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IStreamingSourceConfigBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002AC8 RID: 10952 RVA: 0x0007081A File Offset: 0x0006EA1A
		public IStreamingSourceConfigBase_SetValue ToSetValue()
		{
			return new IStreamingSourceConfigBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000B30 RID: 2864
		// (get) Token: 0x06002AC9 RID: 10953 RVA: 0x0007082D File Offset: 0x0006EA2D
		// (set) Token: 0x06002ACA RID: 10954 RVA: 0x00070858 File Offset: 0x0006EA58
		public virtual EStreamingSourceMode Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EStreamingSourceMode.Fixed;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001CC1 RID: 7361
		[Nullable(2)]
		protected IStreamingSourceConfigBase FbInstance;

		// Token: 0x04001CC2 RID: 7362
		[Nullable(2)]
		protected IStreamingSourceConfigBase_SetValue PocoInterface;
	}
}
