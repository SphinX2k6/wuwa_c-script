using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000717 RID: 1815
	public class IRenderFlag
	{
		// Token: 0x0600267C RID: 9852 RVA: 0x000679F4 File Offset: 0x00065BF4
		private IRenderFlag_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRenderFlag 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRenderFlag_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRenderFlag_SetValue());
			}
			return result;
		}

		// Token: 0x0600267D RID: 9853 RVA: 0x00067A2C File Offset: 0x00065C2C
		public static IRenderFlag Create([Nullable(2)] IRenderFlag instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRenderFlag
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600267E RID: 9854 RVA: 0x00067A3F File Offset: 0x00065C3F
		public static IRenderFlag CreateFromSetValue([Nullable(2)] IRenderFlag_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRenderFlag
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600267F RID: 9855 RVA: 0x00067A52 File Offset: 0x00065C52
		public IRenderFlag_SetValue ToSetValue()
		{
			return new IRenderFlag_SetValue
			{
				Type = this.Type,
				Enable = this.Enable
			};
		}

		// Token: 0x17000A1A RID: 2586
		// (get) Token: 0x06002680 RID: 9856 RVA: 0x00067A71 File Offset: 0x00065C71
		// (set) Token: 0x06002681 RID: 9857 RVA: 0x00067A9C File Offset: 0x00065C9C
		public virtual ERenderFlagType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ERenderFlagType.Fog;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000A1B RID: 2587
		// (get) Token: 0x06002682 RID: 9858 RVA: 0x00067AAA File Offset: 0x00065CAA
		// (set) Token: 0x06002683 RID: 9859 RVA: 0x00067AD5 File Offset: 0x00065CD5
		public virtual bool Enable
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Enable;
				}
				return this.PocoInterface != null && this.PocoInterface.Enable;
			}
			set
			{
				this.GetOrCreatePoco().Enable = value;
			}
		}

		// Token: 0x04001A6F RID: 6767
		[Nullable(2)]
		protected IRenderFlag FbInstance;

		// Token: 0x04001A70 RID: 6768
		[Nullable(2)]
		protected IRenderFlag_SetValue PocoInterface;
	}
}
