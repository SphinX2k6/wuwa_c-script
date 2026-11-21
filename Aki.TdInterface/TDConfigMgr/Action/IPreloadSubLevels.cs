using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F5F RID: 8031
	public class IPreloadSubLevels : SwitchSubLevels
	{
		// Token: 0x0600AADD RID: 43741 RVA: 0x00183290 File Offset: 0x00181490
		private IPreloadSubLevels_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPreloadSubLevels 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPreloadSubLevels_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPreloadSubLevels_SetValue());
			}
			return result;
		}

		// Token: 0x0600AADE RID: 43742 RVA: 0x001832C8 File Offset: 0x001814C8
		public static IPreloadSubLevels Create([Nullable(2)] IPreloadSubLevels instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPreloadSubLevels
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AADF RID: 43743 RVA: 0x001832DB File Offset: 0x001814DB
		public static IPreloadSubLevels CreateFromSetValue([Nullable(2)] IPreloadSubLevels_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPreloadSubLevels
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AAE0 RID: 43744 RVA: 0x001832EE File Offset: 0x001814EE
		public new IPreloadSubLevels_SetValue ToSetValue()
		{
			return new IPreloadSubLevels_SetValue
			{
				Type = this.Type,
				PreloadLevels = this.PreloadLevels
			};
		}

		// Token: 0x1700346E RID: 13422
		// (get) Token: 0x0600AAE1 RID: 43745 RVA: 0x0018330D File Offset: 0x0018150D
		// (set) Token: 0x0600AAE2 RID: 43746 RVA: 0x00183338 File Offset: 0x00181538
		public override ESwitchSubLevelsType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESwitchSubLevelsType.Directly;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700346F RID: 13423
		// (get) Token: 0x0600AAE3 RID: 43747 RVA: 0x00183346 File Offset: 0x00181546
		// (set) Token: 0x0600AAE4 RID: 43748 RVA: 0x0018336D File Offset: 0x0018156D
		public virtual List<string> PreloadLevels
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PreloadLevels;
				}
				IPreloadSubLevels_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.PreloadLevels;
			}
			set
			{
				this.GetOrCreatePoco().PreloadLevels = value;
			}
		}

		// Token: 0x04006669 RID: 26217
		[Nullable(2)]
		protected new IPreloadSubLevels FbInstance;

		// Token: 0x0400666A RID: 26218
		[Nullable(2)]
		protected new IPreloadSubLevels_SetValue PocoInterface;
	}
}
