using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002B8 RID: 696
	public class IConnectorPathAdvanceInitiator
	{
		// Token: 0x06000C97 RID: 3223 RVA: 0x00030D24 File Offset: 0x0002EF24
		private IConnectorPathAdvanceInitiator_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IConnectorPathAdvanceInitiator 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IConnectorPathAdvanceInitiator_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IConnectorPathAdvanceInitiator_SetValue());
			}
			return result;
		}

		// Token: 0x06000C98 RID: 3224 RVA: 0x00030D5C File Offset: 0x0002EF5C
		public static IConnectorPathAdvanceInitiator Create([Nullable(2)] IConnectorPathAdvanceInitiator instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IConnectorPathAdvanceInitiator
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000C99 RID: 3225 RVA: 0x00030D6F File Offset: 0x0002EF6F
		public static IConnectorPathAdvanceInitiator CreateFromSetValue([Nullable(2)] IConnectorPathAdvanceInitiator_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IConnectorPathAdvanceInitiator
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000C9A RID: 3226 RVA: 0x00030D84 File Offset: 0x0002EF84
		public IConnectorPathAdvanceInitiator_SetValue ToSetValue()
		{
			return new IConnectorPathAdvanceInitiator_SetValue
			{
				ActiveState = this.ActiveState,
				Paths = this.Paths,
				TargetEntity = this.TargetEntity,
				AdvanceSpeed = this.AdvanceSpeed,
				VisualType = this.VisualType,
				VisualConfig = this.VisualConfig,
				KeepConditions = this.KeepConditions
			};
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06000C9B RID: 3227 RVA: 0x00030DEA File Offset: 0x0002EFEA
		// (set) Token: 0x06000C9C RID: 3228 RVA: 0x00030E15 File Offset: 0x0002F015
		public virtual string ActiveState
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ActiveState;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.ActiveState;
			}
			set
			{
				this.GetOrCreatePoco().ActiveState = value;
			}
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06000C9D RID: 3229 RVA: 0x00030E23 File Offset: 0x0002F023
		// (set) Token: 0x06000C9E RID: 3230 RVA: 0x00030E4A File Offset: 0x0002F04A
		public virtual List<int> Paths
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Paths;
				}
				IConnectorPathAdvanceInitiator_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Paths;
			}
			set
			{
				this.GetOrCreatePoco().Paths = value;
			}
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06000C9F RID: 3231 RVA: 0x00030E58 File Offset: 0x0002F058
		// (set) Token: 0x06000CA0 RID: 3232 RVA: 0x00030E83 File Offset: 0x0002F083
		public virtual int TargetEntity
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TargetEntity;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.TargetEntity;
			}
			set
			{
				this.GetOrCreatePoco().TargetEntity = value;
			}
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06000CA1 RID: 3233 RVA: 0x00030E91 File Offset: 0x0002F091
		// (set) Token: 0x06000CA2 RID: 3234 RVA: 0x00030EC0 File Offset: 0x0002F0C0
		public virtual float AdvanceSpeed
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AdvanceSpeed;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.AdvanceSpeed;
			}
			set
			{
				this.GetOrCreatePoco().AdvanceSpeed = value;
			}
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06000CA3 RID: 3235 RVA: 0x00030ECE File Offset: 0x0002F0CE
		// (set) Token: 0x06000CA4 RID: 3236 RVA: 0x00030EF9 File Offset: 0x0002F0F9
		public virtual EConnectorPathAdvanceVisualType VisualType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.VisualType;
				}
				if (this.PocoInterface == null)
				{
					return EConnectorPathAdvanceVisualType.VasePlant;
				}
				return this.PocoInterface.VisualType;
			}
			set
			{
				this.GetOrCreatePoco().VisualType = value;
			}
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06000CA5 RID: 3237 RVA: 0x00030F08 File Offset: 0x0002F108
		// (set) Token: 0x06000CA6 RID: 3238 RVA: 0x00030F69 File Offset: 0x0002F169
		[Nullable(2)]
		public virtual IConnectorPathAdvanceVasePlantVisual VisualConfig
		{
			[NullableContext(2)]
			get
			{
				if (this._VisualConfigInited)
				{
					return this._VisualConfigCache;
				}
				this._VisualConfigInited = true;
				if (this.FbInstance != null)
				{
					this._VisualConfigCache = IConnectorPathAdvanceVasePlantVisual.Create(this.FbInstance.VisualConfig);
				}
				else
				{
					IConnectorPathAdvanceInitiator_SetValue pocoInterface = this.PocoInterface;
					this._VisualConfigCache = ((pocoInterface != null) ? pocoInterface.VisualConfig : null);
				}
				return this._VisualConfigCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().VisualConfig = value;
				this._VisualConfigInited = false;
			}
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06000CA7 RID: 3239 RVA: 0x00030F80 File Offset: 0x0002F180
		// (set) Token: 0x06000CA8 RID: 3240 RVA: 0x00031013 File Offset: 0x0002F213
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<IDynamicEntityMatch> KeepConditions
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._KeepConditionsInited)
				{
					return this._KeepConditionsCache;
				}
				this._KeepConditionsInited = true;
				if (this.FbInstance != null)
				{
					List<IDynamicEntityMatch> keepConditions = this.FbInstance.KeepConditions;
					if (keepConditions != null)
					{
						this._KeepConditionsCache = new List<IDynamicEntityMatch>(keepConditions.Count);
						for (int i = 0; i < keepConditions.Count; i++)
						{
							this._KeepConditionsCache.Add(IDynamicEntityMatch.Create(keepConditions[i]));
						}
					}
				}
				else
				{
					IConnectorPathAdvanceInitiator_SetValue pocoInterface = this.PocoInterface;
					this._KeepConditionsCache = ((pocoInterface != null) ? pocoInterface.KeepConditions : null);
				}
				return this._KeepConditionsCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this.GetOrCreatePoco().KeepConditions = value;
				this._KeepConditionsInited = false;
			}
		}

		// Token: 0x04000BF8 RID: 3064
		[Nullable(2)]
		protected IConnectorPathAdvanceInitiator FbInstance;

		// Token: 0x04000BF9 RID: 3065
		[Nullable(2)]
		protected IConnectorPathAdvanceInitiator_SetValue PocoInterface;

		// Token: 0x04000BFA RID: 3066
		private IConnectorPathAdvanceVasePlantVisual _VisualConfigCache;

		// Token: 0x04000BFB RID: 3067
		private bool _VisualConfigInited;

		// Token: 0x04000BFC RID: 3068
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IDynamicEntityMatch> _KeepConditionsCache;

		// Token: 0x04000BFD RID: 3069
		private bool _KeepConditionsInited;
	}
}
