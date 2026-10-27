using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200047B RID: 1147
	[NullableContext(1)]
	[Nullable(0)]
	public class IInteractEntityPartModelBind : IInteractEntityPartBindBase
	{
		// Token: 0x06001716 RID: 5910 RVA: 0x000465F8 File Offset: 0x000447F8
		private IInteractEntityPartModelBind_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IInteractEntityPartModelBind 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IInteractEntityPartModelBind_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IInteractEntityPartModelBind_SetValue());
			}
			return result;
		}

		// Token: 0x06001717 RID: 5911 RVA: 0x00046630 File Offset: 0x00044830
		public static IInteractEntityPartModelBind Create([Nullable(2)] IInteractEntityPartModelBind instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInteractEntityPartModelBind
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001718 RID: 5912 RVA: 0x00046643 File Offset: 0x00044843
		public static IInteractEntityPartModelBind CreateFromSetValue([Nullable(2)] IInteractEntityPartModelBind_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IInteractEntityPartModelBind
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001719 RID: 5913 RVA: 0x00046656 File Offset: 0x00044856
		public new IInteractEntityPartModelBind_SetValue ToSetValue()
		{
			return new IInteractEntityPartModelBind_SetValue
			{
				Type = this.Type,
				OptionPoints = this.OptionPoints
			};
		}

		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x0600171A RID: 5914 RVA: 0x00046675 File Offset: 0x00044875
		// (set) Token: 0x0600171B RID: 5915 RVA: 0x000466A0 File Offset: 0x000448A0
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

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x0600171C RID: 5916 RVA: 0x000466B0 File Offset: 0x000448B0
		// (set) Token: 0x0600171D RID: 5917 RVA: 0x00046743 File Offset: 0x00044943
		public virtual List<IInteractEntityPartModelOptionPoint> OptionPoints
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
					List<IInteractEntityPartModelOptionPoint> optionPoints = this.FbInstance.OptionPoints;
					if (optionPoints != null)
					{
						this._OptionPointsCache = new List<IInteractEntityPartModelOptionPoint>(optionPoints.Count);
						for (int i = 0; i < optionPoints.Count; i++)
						{
							this._OptionPointsCache.Add(IInteractEntityPartModelOptionPoint.Create(optionPoints[i]));
						}
					}
				}
				else
				{
					IInteractEntityPartModelBind_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04001166 RID: 4454
		[Nullable(2)]
		protected new IInteractEntityPartModelBind FbInstance;

		// Token: 0x04001167 RID: 4455
		[Nullable(2)]
		protected new IInteractEntityPartModelBind_SetValue PocoInterface;

		// Token: 0x04001168 RID: 4456
		private List<IInteractEntityPartModelOptionPoint> _OptionPointsCache;

		// Token: 0x04001169 RID: 4457
		private bool _OptionPointsInited;
	}
}
