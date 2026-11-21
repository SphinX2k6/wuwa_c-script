using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022FC RID: 8956
	public class IVisualNovelTransitionConfigBase
	{
		// Token: 0x0600C334 RID: 49972 RVA: 0x001C09FC File Offset: 0x001BEBFC
		private IVisualNovelTransitionConfigBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVisualNovelTransitionConfigBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVisualNovelTransitionConfigBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVisualNovelTransitionConfigBase_SetValue());
			}
			return result;
		}

		// Token: 0x0600C335 RID: 49973 RVA: 0x001C0A34 File Offset: 0x001BEC34
		public static IVisualNovelTransitionConfigBase Create([Nullable(2)] IVisualNovelTransitionConfigBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelTransitionConfigBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C336 RID: 49974 RVA: 0x001C0A47 File Offset: 0x001BEC47
		public static IVisualNovelTransitionConfigBase CreateFromSetValue([Nullable(2)] IVisualNovelTransitionConfigBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVisualNovelTransitionConfigBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C337 RID: 49975 RVA: 0x001C0A5A File Offset: 0x001BEC5A
		public IVisualNovelTransitionConfigBase_SetValue ToSetValue()
		{
			return new IVisualNovelTransitionConfigBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003B30 RID: 15152
		// (get) Token: 0x0600C338 RID: 49976 RVA: 0x001C0A6D File Offset: 0x001BEC6D
		// (set) Token: 0x0600C339 RID: 49977 RVA: 0x001C0A98 File Offset: 0x001BEC98
		public virtual EVisualNovelTransitionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EVisualNovelTransitionType.Location;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400746D RID: 29805
		[Nullable(2)]
		protected IVisualNovelTransitionConfigBase FbInstance;

		// Token: 0x0400746E RID: 29806
		[Nullable(2)]
		protected IVisualNovelTransitionConfigBase_SetValue PocoInterface;
	}
}
