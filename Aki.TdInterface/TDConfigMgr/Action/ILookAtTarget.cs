using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D9B RID: 7579
	public class ILookAtTarget : IDefaultLookAtType
	{
		// Token: 0x0600A0DF RID: 41183 RVA: 0x00170D48 File Offset: 0x0016EF48
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

		// Token: 0x0600A0E0 RID: 41184 RVA: 0x00170D80 File Offset: 0x0016EF80
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

		// Token: 0x0600A0E1 RID: 41185 RVA: 0x00170D93 File Offset: 0x0016EF93
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

		// Token: 0x0600A0E2 RID: 41186 RVA: 0x00170DA6 File Offset: 0x0016EFA6
		public new ILookAtTarget_SetValue ToSetValue()
		{
			return new ILookAtTarget_SetValue
			{
				Type = this.Type,
				LookAtConfigs = this.LookAtConfigs
			};
		}

		// Token: 0x17003215 RID: 12821
		// (get) Token: 0x0600A0E3 RID: 41187 RVA: 0x00170DC5 File Offset: 0x0016EFC5
		// (set) Token: 0x0600A0E4 RID: 41188 RVA: 0x00170DF0 File Offset: 0x0016EFF0
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

		// Token: 0x17003216 RID: 12822
		// (get) Token: 0x0600A0E5 RID: 41189 RVA: 0x00170E00 File Offset: 0x0016F000
		// (set) Token: 0x0600A0E6 RID: 41190 RVA: 0x00170E93 File Offset: 0x0016F093
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

		// Token: 0x040061BE RID: 25022
		[Nullable(2)]
		protected new ILookAtTarget FbInstance;

		// Token: 0x040061BF RID: 25023
		[Nullable(2)]
		protected new ILookAtTarget_SetValue PocoInterface;

		// Token: 0x040061C0 RID: 25024
		private List<INpcLookAtConfig> _LookAtConfigsCache;

		// Token: 0x040061C1 RID: 25025
		private bool _LookAtConfigsInited;
	}
}
