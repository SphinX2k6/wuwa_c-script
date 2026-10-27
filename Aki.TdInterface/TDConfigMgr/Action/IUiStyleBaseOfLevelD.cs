using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002013 RID: 8211
	[NullableContext(1)]
	[Nullable(0)]
	public class IUiStyleBaseOfLevelD
	{
		// Token: 0x0600B48C RID: 46220 RVA: 0x001A3C9C File Offset: 0x001A1E9C
		private IUiStyleBaseOfLevelD_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IUiStyleBaseOfLevelD 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IUiStyleBaseOfLevelD_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IUiStyleBaseOfLevelD_SetValue());
			}
			return result;
		}

		// Token: 0x0600B48D RID: 46221 RVA: 0x001A3CD4 File Offset: 0x001A1ED4
		public static IUiStyleBaseOfLevelD Create([Nullable(2)] IUiStyleBaseOfLevelD instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IUiStyleBaseOfLevelD
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B48E RID: 46222 RVA: 0x001A3CE7 File Offset: 0x001A1EE7
		public static IUiStyleBaseOfLevelD CreateFromSetValue([Nullable(2)] IUiStyleBaseOfLevelD_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IUiStyleBaseOfLevelD
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B48F RID: 46223 RVA: 0x001A3CFA File Offset: 0x001A1EFA
		public IUiStyleBaseOfLevelD_SetValue ToSetValue()
		{
			return new IUiStyleBaseOfLevelD_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003782 RID: 14210
		// (get) Token: 0x0600B490 RID: 46224 RVA: 0x001A3D0D File Offset: 0x001A1F0D
		// (set) Token: 0x0600B491 RID: 46225 RVA: 0x001A3D38 File Offset: 0x001A1F38
		public virtual EUiStyleTypeOfLevelD Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EUiStyleTypeOfLevelD.GiantSubtitle;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006CC9 RID: 27849
		[Nullable(2)]
		protected IUiStyleBaseOfLevelD FbInstance;

		// Token: 0x04006CCA RID: 27850
		[Nullable(2)]
		protected IUiStyleBaseOfLevelD_SetValue PocoInterface;
	}
}
