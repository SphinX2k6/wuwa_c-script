using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BB4 RID: 7092
	[NullableContext(1)]
	[Nullable(0)]
	public class ILookAtTarget : IDefaultLookAtType
	{
		// Token: 0x060097DB RID: 38875 RVA: 0x0015E288 File Offset: 0x0015C488
		private ILookAtTarget_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILookAtTarget 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILookAtTarget_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILookAtTarget_SetValue());
			}
			return result;
		}

		// Token: 0x060097DC RID: 38876 RVA: 0x0015E2C0 File Offset: 0x0015C4C0
		public static ILookAtTarget Create([Nullable(2)] ILookAtTarget instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILookAtTarget
			{
				FbInstance = instance
			};
		}

		// Token: 0x060097DD RID: 38877 RVA: 0x0015E2D3 File Offset: 0x0015C4D3
		public static ILookAtTarget CreateFromSetValue([Nullable(2)] ILookAtTarget_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILookAtTarget
			{
				PocoInterface = value
			};
		}

		// Token: 0x060097DE RID: 38878 RVA: 0x0015E2E6 File Offset: 0x0015C4E6
		public new ILookAtTarget_SetValue ToSetValue()
		{
			return new ILookAtTarget_SetValue
			{
				Type = this.Type,
				LookAtConfigs = this.LookAtConfigs
			};
		}

		// Token: 0x17002FB6 RID: 12214
		// (get) Token: 0x060097DF RID: 38879 RVA: 0x0015E305 File Offset: 0x0015C505
		// (set) Token: 0x060097E0 RID: 38880 RVA: 0x0015E330 File Offset: 0x0015C530
		public override EDefaultLookAtType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EDefaultLookAtType.LookAtBubbleEntity;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002FB7 RID: 12215
		// (get) Token: 0x060097E1 RID: 38881 RVA: 0x0015E340 File Offset: 0x0015C540
		// (set) Token: 0x060097E2 RID: 38882 RVA: 0x0015E3D3 File Offset: 0x0015C5D3
		public virtual List<INpcLookAtConfig> LookAtConfigs
		{
			get
			{
				if (this._LookAtConfigsInited)
				{
					return this._LookAtConfigsCache;
				}
				this._LookAtConfigsInited = true;
				if (this.FbInstance != null)
				{
					List<INpcLookAtConfig> lookAtConfigs = this.FbInstance.LookAtConfigs;
					if (lookAtConfigs != null)
					{
						this._LookAtConfigsCache = new List<INpcLookAtConfig>(lookAtConfigs.Count);
						for (int i = 0; i < lookAtConfigs.Count; i++)
						{
							this._LookAtConfigsCache.Add(INpcLookAtConfig.Create(lookAtConfigs[i]));
						}
					}
				}
				else
				{
					ILookAtTarget_SetValue pocoInterface = this.PocoInterface;
					this._LookAtConfigsCache = ((pocoInterface != null) ? pocoInterface.LookAtConfigs : null);
				}
				return this._LookAtConfigsCache;
			}
			set
			{
				this.GetOrCreatePoco().LookAtConfigs = value;
				this._LookAtConfigsInited = false;
			}
		}

		// Token: 0x04005CA9 RID: 23721
		[Nullable(2)]
		protected new ILookAtTarget FbInstance;

		// Token: 0x04005CAA RID: 23722
		[Nullable(2)]
		protected new ILookAtTarget_SetValue PocoInterface;

		// Token: 0x04005CAB RID: 23723
		private List<INpcLookAtConfig> _LookAtConfigsCache;

		// Token: 0x04005CAC RID: 23724
		private bool _LookAtConfigsInited;
	}
}
