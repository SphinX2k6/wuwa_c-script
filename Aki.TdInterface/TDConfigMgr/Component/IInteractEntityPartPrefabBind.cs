using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004D8 RID: 1240
	public class IInteractEntityPartPrefabBind : IInteractEntityPartBindBase
	{
		// Token: 0x060018C4 RID: 6340 RVA: 0x0004A5B0 File Offset: 0x000487B0
		private IInteractEntityPartPrefabBind_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IInteractEntityPartPrefabBind 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IInteractEntityPartPrefabBind_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IInteractEntityPartPrefabBind_SetValue());
			}
			return result;
		}

		// Token: 0x060018C5 RID: 6341 RVA: 0x0004A5E8 File Offset: 0x000487E8
		public static IInteractEntityPartPrefabBind Create([Nullable(2)] IInteractEntityPartPrefabBind instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInteractEntityPartPrefabBind
			{
				FbInstance = instance
			};
		}

		// Token: 0x060018C6 RID: 6342 RVA: 0x0004A5FB File Offset: 0x000487FB
		public static IInteractEntityPartPrefabBind CreateFromSetValue([Nullable(2)] IInteractEntityPartPrefabBind_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IInteractEntityPartPrefabBind
			{
				PocoInterface = value
			};
		}

		// Token: 0x060018C7 RID: 6343 RVA: 0x0004A60E File Offset: 0x0004880E
		public new IInteractEntityPartPrefabBind_SetValue ToSetValue()
		{
			return new IInteractEntityPartPrefabBind_SetValue
			{
				Type = this.Type,
				OptionPoints = this.OptionPoints
			};
		}

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x060018C8 RID: 6344 RVA: 0x0004A62D File Offset: 0x0004882D
		// (set) Token: 0x060018C9 RID: 6345 RVA: 0x0004A658 File Offset: 0x00048858
		public override EInteractEntityPartBindType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EInteractEntityPartBindType.Prefab;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x060018CA RID: 6346 RVA: 0x0004A668 File Offset: 0x00048868
		// (set) Token: 0x060018CB RID: 6347 RVA: 0x0004A6FB File Offset: 0x000488FB
		public virtual List<IInteractEntityPartPrefabOptionPoint> OptionPoints
		{
			get
			{
				if (this._OptionPointsInited)
				{
					return this._OptionPointsCache;
				}
				this._OptionPointsInited = true;
				if (this.FbInstance != null)
				{
					List<IInteractEntityPartPrefabOptionPoint> optionPoints = this.FbInstance.OptionPoints;
					if (optionPoints != null)
					{
						this._OptionPointsCache = new List<IInteractEntityPartPrefabOptionPoint>(optionPoints.Count);
						for (int i = 0; i < optionPoints.Count; i++)
						{
							this._OptionPointsCache.Add(IInteractEntityPartPrefabOptionPoint.Create(optionPoints[i]));
						}
					}
				}
				else
				{
					IInteractEntityPartPrefabBind_SetValue pocoInterface = this.PocoInterface;
					this._OptionPointsCache = ((pocoInterface != null) ? pocoInterface.OptionPoints : null);
				}
				return this._OptionPointsCache;
			}
			set
			{
				this.GetOrCreatePoco().OptionPoints = value;
				this._OptionPointsInited = false;
			}
		}

		// Token: 0x04001292 RID: 4754
		[Nullable(2)]
		protected new IInteractEntityPartPrefabBind FbInstance;

		// Token: 0x04001293 RID: 4755
		[Nullable(2)]
		protected new IInteractEntityPartPrefabBind_SetValue PocoInterface;

		// Token: 0x04001294 RID: 4756
		private List<IInteractEntityPartPrefabOptionPoint> _OptionPointsCache;

		// Token: 0x04001295 RID: 4757
		private bool _OptionPointsInited;
	}
}
