using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005BB RID: 1467
	public class INoRenderPortalMode
	{
		// Token: 0x06001DE6 RID: 7654 RVA: 0x000552C4 File Offset: 0x000534C4
		private INoRenderPortalMode_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INoRenderPortalMode 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INoRenderPortalMode_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INoRenderPortalMode_SetValue());
			}
			return result;
		}

		// Token: 0x06001DE7 RID: 7655 RVA: 0x000552FC File Offset: 0x000534FC
		public static INoRenderPortalMode Create([Nullable(2)] INoRenderPortalMode instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INoRenderPortalMode
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001DE8 RID: 7656 RVA: 0x0005530F File Offset: 0x0005350F
		public static INoRenderPortalMode CreateFromSetValue([Nullable(2)] INoRenderPortalMode_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INoRenderPortalMode
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001DE9 RID: 7657 RVA: 0x00055322 File Offset: 0x00053522
		public INoRenderPortalMode_SetValue ToSetValue()
		{
			return new INoRenderPortalMode_SetValue
			{
				Type = this.Type,
				PortalModel = this.PortalModel
			};
		}

		// Token: 0x170007D9 RID: 2009
		// (get) Token: 0x06001DEA RID: 7658 RVA: 0x00055341 File Offset: 0x00053541
		// (set) Token: 0x06001DEB RID: 7659 RVA: 0x0005536C File Offset: 0x0005356C
		public virtual ENoRenderPortalType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ENoRenderPortalType.Static;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170007DA RID: 2010
		// (get) Token: 0x06001DEC RID: 7660 RVA: 0x0005537A File Offset: 0x0005357A
		// (set) Token: 0x06001DED RID: 7661 RVA: 0x000553A5 File Offset: 0x000535A5
		public virtual EPortalModel PortalModel
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PortalModel;
				}
				if (this.PocoInterface == null)
				{
					return EPortalModel.A;
				}
				return this.PocoInterface.PortalModel;
			}
			set
			{
				this.GetOrCreatePoco().PortalModel = value;
			}
		}

		// Token: 0x0400156E RID: 5486
		[Nullable(2)]
		protected INoRenderPortalMode FbInstance;

		// Token: 0x0400156F RID: 5487
		[Nullable(2)]
		protected INoRenderPortalMode_SetValue PocoInterface;
	}
}
