using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008D4 RID: 2260
	[NullableContext(1)]
	[Nullable(0)]
	public class UndergroundComponent : IComponentBase
	{
		// Token: 0x0600331D RID: 13085 RVA: 0x00083114 File Offset: 0x00081314
		private UndergroundComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("UndergroundComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			UndergroundComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new UndergroundComponent_SetValue());
			}
			return result;
		}

		// Token: 0x0600331E RID: 13086 RVA: 0x0008314C File Offset: 0x0008134C
		public static UndergroundComponent Create([Nullable(2)] UndergroundComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new UndergroundComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600331F RID: 13087 RVA: 0x0008315F File Offset: 0x0008135F
		public static UndergroundComponent CreateFromSetValue([Nullable(2)] UndergroundComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new UndergroundComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06003320 RID: 13088 RVA: 0x00083174 File Offset: 0x00081374
		public new UndergroundComponent_SetValue ToSetValue()
		{
			return new UndergroundComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				TestState = this.TestState,
				IsRestartPlayer = this.IsRestartPlayer,
				DestroyTag = this.DestroyTag,
				StateInfo = this.StateInfo
			};
		}

		// Token: 0x17000DB8 RID: 3512
		// (get) Token: 0x06003321 RID: 13089 RVA: 0x000831D0 File Offset: 0x000813D0
		// (set) Token: 0x06003322 RID: 13090 RVA: 0x0008320A File Offset: 0x0008140A
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				UndergroundComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Disabled;
			}
			set
			{
				this.GetOrCreatePoco().Disabled = value;
			}
		}

		// Token: 0x17000DB9 RID: 3513
		// (get) Token: 0x06003323 RID: 13091 RVA: 0x00083218 File Offset: 0x00081418
		// (set) Token: 0x06003324 RID: 13092 RVA: 0x00083242 File Offset: 0x00081442
		public override bool? EdIsLocked
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdIsLocked;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdIsLocked = value;
			}
		}

		// Token: 0x17000DBA RID: 3514
		// (get) Token: 0x06003325 RID: 13093 RVA: 0x00083250 File Offset: 0x00081450
		// (set) Token: 0x06003326 RID: 13094 RVA: 0x0008327B File Offset: 0x0008147B
		public virtual int TestState
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TestState;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.TestState;
			}
			set
			{
				this.GetOrCreatePoco().TestState = value;
			}
		}

		// Token: 0x17000DBB RID: 3515
		// (get) Token: 0x06003327 RID: 13095 RVA: 0x00083289 File Offset: 0x00081489
		// (set) Token: 0x06003328 RID: 13096 RVA: 0x000832B4 File Offset: 0x000814B4
		public virtual bool IsRestartPlayer
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsRestartPlayer;
				}
				return this.PocoInterface != null && this.PocoInterface.IsRestartPlayer;
			}
			set
			{
				this.GetOrCreatePoco().IsRestartPlayer = value;
			}
		}

		// Token: 0x17000DBC RID: 3516
		// (get) Token: 0x06003329 RID: 13097 RVA: 0x000832C2 File Offset: 0x000814C2
		// (set) Token: 0x0600332A RID: 13098 RVA: 0x000832E9 File Offset: 0x000814E9
		public virtual List<string> DestroyTag
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DestroyTag;
				}
				UndergroundComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DestroyTag;
			}
			set
			{
				this.GetOrCreatePoco().DestroyTag = value;
			}
		}

		// Token: 0x17000DBD RID: 3517
		// (get) Token: 0x0600332B RID: 13099 RVA: 0x000832F8 File Offset: 0x000814F8
		// (set) Token: 0x0600332C RID: 13100 RVA: 0x0008338B File Offset: 0x0008158B
		public virtual List<IUndergroundStateInfo> StateInfo
		{
			get
			{
				if (this._StateInfoInited)
				{
					return this._StateInfoCache;
				}
				this._StateInfoInited = true;
				if (this.FbInstance != null)
				{
					List<IUndergroundStateInfo> stateInfo = this.FbInstance.StateInfo;
					if (stateInfo != null)
					{
						this._StateInfoCache = new List<IUndergroundStateInfo>(stateInfo.Count);
						for (int i = 0; i < stateInfo.Count; i++)
						{
							this._StateInfoCache.Add(IUndergroundStateInfo.Create(stateInfo[i]));
						}
					}
				}
				else
				{
					UndergroundComponent_SetValue pocoInterface = this.PocoInterface;
					this._StateInfoCache = ((pocoInterface != null) ? pocoInterface.StateInfo : null);
				}
				return this._StateInfoCache;
			}
			set
			{
				this.GetOrCreatePoco().StateInfo = value;
				this._StateInfoInited = false;
			}
		}

		// Token: 0x0400218B RID: 8587
		[Nullable(2)]
		protected new UndergroundComponent FbInstance;

		// Token: 0x0400218C RID: 8588
		[Nullable(2)]
		protected new UndergroundComponent_SetValue PocoInterface;

		// Token: 0x0400218D RID: 8589
		private List<IUndergroundStateInfo> _StateInfoCache;

		// Token: 0x0400218E RID: 8590
		private bool _StateInfoInited;
	}
}
