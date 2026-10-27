using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D4E RID: 7502
	[NullableContext(1)]
	[Nullable(0)]
	public class IPreloadSubLevels : SwitchSubLevels
	{
		// Token: 0x0600A0F1 RID: 41201 RVA: 0x0016EE6C File Offset: 0x0016D06C
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

		// Token: 0x0600A0F2 RID: 41202 RVA: 0x0016EEA4 File Offset: 0x0016D0A4
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

		// Token: 0x0600A0F3 RID: 41203 RVA: 0x0016EEB7 File Offset: 0x0016D0B7
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

		// Token: 0x0600A0F4 RID: 41204 RVA: 0x0016EECA File Offset: 0x0016D0CA
		public new IPreloadSubLevels_SetValue ToSetValue()
		{
			return new IPreloadSubLevels_SetValue
			{
				Type = this.Type,
				PreloadLevels = this.PreloadLevels
			};
		}

		// Token: 0x170031DA RID: 12762
		// (get) Token: 0x0600A0F5 RID: 41205 RVA: 0x0016EEE9 File Offset: 0x0016D0E9
		// (set) Token: 0x0600A0F6 RID: 41206 RVA: 0x0016EF14 File Offset: 0x0016D114
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

		// Token: 0x170031DB RID: 12763
		// (get) Token: 0x0600A0F7 RID: 41207 RVA: 0x0016EF22 File Offset: 0x0016D122
		// (set) Token: 0x0600A0F8 RID: 41208 RVA: 0x0016EF49 File Offset: 0x0016D149
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

		// Token: 0x040060ED RID: 24813
		[Nullable(2)]
		protected new IPreloadSubLevels FbInstance;

		// Token: 0x040060EE RID: 24814
		[Nullable(2)]
		protected new IPreloadSubLevels_SetValue PocoInterface;
	}
}
