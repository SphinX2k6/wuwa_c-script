using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200111D RID: 4381
	public class ILevelPlayInformationView : IInformationViewType
	{
		// Token: 0x060060AE RID: 24750 RVA: 0x000E92A0 File Offset: 0x000E74A0
		private ILevelPlayInformationView_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILevelPlayInformationView 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILevelPlayInformationView_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILevelPlayInformationView_SetValue());
			}
			return result;
		}

		// Token: 0x060060AF RID: 24751 RVA: 0x000E92D8 File Offset: 0x000E74D8
		public static ILevelPlayInformationView Create([Nullable(2)] ILevelPlayInformationView instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILevelPlayInformationView
			{
				FbInstance = instance
			};
		}

		// Token: 0x060060B0 RID: 24752 RVA: 0x000E92EB File Offset: 0x000E74EB
		public static ILevelPlayInformationView CreateFromSetValue([Nullable(2)] ILevelPlayInformationView_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILevelPlayInformationView
			{
				PocoInterface = value
			};
		}

		// Token: 0x060060B1 RID: 24753 RVA: 0x000E92FE File Offset: 0x000E74FE
		public new ILevelPlayInformationView_SetValue ToSetValue()
		{
			return new ILevelPlayInformationView_SetValue
			{
				Type = this.Type,
				InformationConfig = this.InformationConfig
			};
		}

		// Token: 0x17001FA8 RID: 8104
		// (get) Token: 0x060060B2 RID: 24754 RVA: 0x000E931D File Offset: 0x000E751D
		// (set) Token: 0x060060B3 RID: 24755 RVA: 0x000E9348 File Offset: 0x000E7548
		public override EInformationViewType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EInformationViewType.LevelPlay;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17001FA9 RID: 8105
		// (get) Token: 0x060060B4 RID: 24756 RVA: 0x000E9358 File Offset: 0x000E7558
		// (set) Token: 0x060060B5 RID: 24757 RVA: 0x000E93EB File Offset: 0x000E75EB
		public virtual List<ILevelPlayInformation> InformationConfig
		{
			get
			{
				if (this._InformationConfigInited)
				{
					return this._InformationConfigCache;
				}
				this._InformationConfigInited = true;
				if (this.FbInstance != null)
				{
					List<ILevelPlayInformation> informationConfig = this.FbInstance.InformationConfig;
					if (informationConfig != null)
					{
						this._InformationConfigCache = new List<ILevelPlayInformation>(informationConfig.Count);
						for (int i = 0; i < informationConfig.Count; i++)
						{
							this._InformationConfigCache.Add(ILevelPlayInformation.Create(informationConfig[i]));
						}
					}
				}
				else
				{
					ILevelPlayInformationView_SetValue pocoInterface = this.PocoInterface;
					this._InformationConfigCache = ((pocoInterface != null) ? pocoInterface.InformationConfig : null);
				}
				return this._InformationConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().InformationConfig = value;
				this._InformationConfigInited = false;
			}
		}

		// Token: 0x040039DE RID: 14814
		[Nullable(2)]
		protected new ILevelPlayInformationView FbInstance;

		// Token: 0x040039DF RID: 14815
		[Nullable(2)]
		protected new ILevelPlayInformationView_SetValue PocoInterface;

		// Token: 0x040039E0 RID: 14816
		private List<ILevelPlayInformation> _InformationConfigCache;

		// Token: 0x040039E1 RID: 14817
		private bool _InformationConfigInited;
	}
}
