using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F16 RID: 7958
	[NullableContext(1)]
	[Nullable(0)]
	public class ITalkBackground
	{
		// Token: 0x0600AA2A RID: 43562 RVA: 0x0017F4CC File Offset: 0x0017D6CC
		private ITalkBackground_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITalkBackground 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITalkBackground_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITalkBackground_SetValue());
			}
			return result;
		}

		// Token: 0x0600AA2B RID: 43563 RVA: 0x0017F504 File Offset: 0x0017D704
		public static ITalkBackground Create([Nullable(2)] ITalkBackground instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkBackground
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AA2C RID: 43564 RVA: 0x0017F517 File Offset: 0x0017D717
		public static ITalkBackground CreateFromSetValue([Nullable(2)] ITalkBackground_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITalkBackground
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AA2D RID: 43565 RVA: 0x0017F52A File Offset: 0x0017D72A
		public ITalkBackground_SetValue ToSetValue()
		{
			return new ITalkBackground_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170033CC RID: 13260
		// (get) Token: 0x0600AA2E RID: 43566 RVA: 0x0017F53D File Offset: 0x0017D73D
		// (set) Token: 0x0600AA2F RID: 43567 RVA: 0x0017F568 File Offset: 0x0017D768
		public virtual ETalkBackgroundType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETalkBackgroundType.Clean;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400651E RID: 25886
		[Nullable(2)]
		protected ITalkBackground FbInstance;

		// Token: 0x0400651F RID: 25887
		[Nullable(2)]
		protected ITalkBackground_SetValue PocoInterface;
	}
}
