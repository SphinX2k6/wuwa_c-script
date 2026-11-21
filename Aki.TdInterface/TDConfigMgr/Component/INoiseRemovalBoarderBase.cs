using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005B3 RID: 1459
	public class INoiseRemovalBoarderBase
	{
		// Token: 0x06001DBE RID: 7614 RVA: 0x00054E00 File Offset: 0x00053000
		private INoiseRemovalBoarderBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INoiseRemovalBoarderBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INoiseRemovalBoarderBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INoiseRemovalBoarderBase_SetValue());
			}
			return result;
		}

		// Token: 0x06001DBF RID: 7615 RVA: 0x00054E38 File Offset: 0x00053038
		public static INoiseRemovalBoarderBase Create([Nullable(2)] INoiseRemovalBoarderBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INoiseRemovalBoarderBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001DC0 RID: 7616 RVA: 0x00054E4B File Offset: 0x0005304B
		public static INoiseRemovalBoarderBase CreateFromSetValue([Nullable(2)] INoiseRemovalBoarderBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INoiseRemovalBoarderBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001DC1 RID: 7617 RVA: 0x00054E5E File Offset: 0x0005305E
		public INoiseRemovalBoarderBase_SetValue ToSetValue()
		{
			return new INoiseRemovalBoarderBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170007D1 RID: 2001
		// (get) Token: 0x06001DC2 RID: 7618 RVA: 0x00054E71 File Offset: 0x00053071
		// (set) Token: 0x06001DC3 RID: 7619 RVA: 0x00054E9C File Offset: 0x0005309C
		public virtual ENoiseRemovalBoarderShape Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ENoiseRemovalBoarderShape.Box;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001558 RID: 5464
		[Nullable(2)]
		protected INoiseRemovalBoarderBase FbInstance;

		// Token: 0x04001559 RID: 5465
		[Nullable(2)]
		protected INoiseRemovalBoarderBase_SetValue PocoInterface;
	}
}
