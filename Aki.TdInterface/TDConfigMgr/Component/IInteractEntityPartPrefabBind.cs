using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200047F RID: 1151
	[NullableContext(1)]
	[Nullable(0)]
	public class IInteractEntityPartPrefabBind : IInteractEntityPartBindBase
	{
		// Token: 0x0600172A RID: 5930 RVA: 0x00046868 File Offset: 0x00044A68
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

		// Token: 0x0600172B RID: 5931 RVA: 0x000468A0 File Offset: 0x00044AA0
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

		// Token: 0x0600172C RID: 5932 RVA: 0x000468B3 File Offset: 0x00044AB3
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

		// Token: 0x0600172D RID: 5933 RVA: 0x000468C6 File Offset: 0x00044AC6
		public new IInteractEntityPartPrefabBind_SetValue ToSetValue()
		{
			return new IInteractEntityPartPrefabBind_SetValue
			{
				Type = this.Type,
				OptionPoints = this.OptionPoints
			};
		}

		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x0600172E RID: 5934 RVA: 0x000468E5 File Offset: 0x00044AE5
		// (set) Token: 0x0600172F RID: 5935 RVA: 0x00046910 File Offset: 0x00044B10
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

		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x06001730 RID: 5936 RVA: 0x00046920 File Offset: 0x00044B20
		// (set) Token: 0x06001731 RID: 5937 RVA: 0x000469B3 File Offset: 0x00044BB3
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

		// Token: 0x04001170 RID: 4464
		[Nullable(2)]
		protected new IInteractEntityPartPrefabBind FbInstance;

		// Token: 0x04001171 RID: 4465
		[Nullable(2)]
		protected new IInteractEntityPartPrefabBind_SetValue PocoInterface;

		// Token: 0x04001172 RID: 4466
		private List<IInteractEntityPartPrefabOptionPoint> _OptionPointsCache;

		// Token: 0x04001173 RID: 4467
		private bool _OptionPointsInited;
	}
}
