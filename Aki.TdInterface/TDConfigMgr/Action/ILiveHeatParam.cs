using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D55 RID: 7509
	public class ILiveHeatParam : ILiveParamConfig
	{
		// Token: 0x06009F6F RID: 40815 RVA: 0x0016E20C File Offset: 0x0016C40C
		private ILiveHeatParam_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILiveHeatParam 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILiveHeatParam_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILiveHeatParam_SetValue());
			}
			return result;
		}

		// Token: 0x06009F70 RID: 40816 RVA: 0x0016E244 File Offset: 0x0016C444
		public static ILiveHeatParam Create([Nullable(2)] ILiveHeatParam instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILiveHeatParam
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009F71 RID: 40817 RVA: 0x0016E257 File Offset: 0x0016C457
		public static ILiveHeatParam CreateFromSetValue([Nullable(2)] ILiveHeatParam_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILiveHeatParam
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009F72 RID: 40818 RVA: 0x0016E26A File Offset: 0x0016C46A
		public new ILiveHeatParam_SetValue ToSetValue()
		{
			return new ILiveHeatParam_SetValue
			{
				Type = this.Type,
				MinHeat = this.MinHeat,
				MaxHeat = this.MaxHeat
			};
		}

		// Token: 0x170031C6 RID: 12742
		// (get) Token: 0x06009F73 RID: 40819 RVA: 0x0016E295 File Offset: 0x0016C495
		// (set) Token: 0x06009F74 RID: 40820 RVA: 0x0016E2C0 File Offset: 0x0016C4C0
		public override ELiveParamType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELiveParamType.Heat;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170031C7 RID: 12743
		// (get) Token: 0x06009F75 RID: 40821 RVA: 0x0016E2CE File Offset: 0x0016C4CE
		// (set) Token: 0x06009F76 RID: 40822 RVA: 0x0016E2F9 File Offset: 0x0016C4F9
		public virtual int MinHeat
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MinHeat;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.MinHeat;
			}
			set
			{
				this.GetOrCreatePoco().MinHeat = value;
			}
		}

		// Token: 0x170031C8 RID: 12744
		// (get) Token: 0x06009F77 RID: 40823 RVA: 0x0016E307 File Offset: 0x0016C507
		// (set) Token: 0x06009F78 RID: 40824 RVA: 0x0016E332 File Offset: 0x0016C532
		public virtual int MaxHeat
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MaxHeat;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.MaxHeat;
			}
			set
			{
				this.GetOrCreatePoco().MaxHeat = value;
			}
		}

		// Token: 0x0400610D RID: 24845
		[Nullable(2)]
		protected new ILiveHeatParam FbInstance;

		// Token: 0x0400610E RID: 24846
		[Nullable(2)]
		protected new ILiveHeatParam_SetValue PocoInterface;
	}
}
