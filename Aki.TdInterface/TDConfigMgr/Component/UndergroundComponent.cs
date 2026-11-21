using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000979 RID: 2425
	public class UndergroundComponent : IComponentBase
	{
		// Token: 0x06003665 RID: 13925 RVA: 0x0008A750 File Offset: 0x00088950
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

		// Token: 0x06003666 RID: 13926 RVA: 0x0008A788 File Offset: 0x00088988
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

		// Token: 0x06003667 RID: 13927 RVA: 0x0008A79B File Offset: 0x0008899B
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

		// Token: 0x06003668 RID: 13928 RVA: 0x0008A7B0 File Offset: 0x000889B0
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

		// Token: 0x17000E84 RID: 3716
		// (get) Token: 0x06003669 RID: 13929 RVA: 0x0008A80C File Offset: 0x00088A0C
		// (set) Token: 0x0600366A RID: 13930 RVA: 0x0008A846 File Offset: 0x00088A46
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

		// Token: 0x17000E85 RID: 3717
		// (get) Token: 0x0600366B RID: 13931 RVA: 0x0008A854 File Offset: 0x00088A54
		// (set) Token: 0x0600366C RID: 13932 RVA: 0x0008A87E File Offset: 0x00088A7E
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

		// Token: 0x17000E86 RID: 3718
		// (get) Token: 0x0600366D RID: 13933 RVA: 0x0008A88C File Offset: 0x00088A8C
		// (set) Token: 0x0600366E RID: 13934 RVA: 0x0008A8B7 File Offset: 0x00088AB7
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

		// Token: 0x17000E87 RID: 3719
		// (get) Token: 0x0600366F RID: 13935 RVA: 0x0008A8C5 File Offset: 0x00088AC5
		// (set) Token: 0x06003670 RID: 13936 RVA: 0x0008A8F0 File Offset: 0x00088AF0
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

		// Token: 0x17000E88 RID: 3720
		// (get) Token: 0x06003671 RID: 13937 RVA: 0x0008A8FE File Offset: 0x00088AFE
		// (set) Token: 0x06003672 RID: 13938 RVA: 0x0008A925 File Offset: 0x00088B25
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

		// Token: 0x17000E89 RID: 3721
		// (get) Token: 0x06003673 RID: 13939 RVA: 0x0008A934 File Offset: 0x00088B34
		// (set) Token: 0x06003674 RID: 13940 RVA: 0x0008A9C7 File Offset: 0x00088BC7
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

		// Token: 0x040023A2 RID: 9122
		[Nullable(2)]
		protected new UndergroundComponent FbInstance;

		// Token: 0x040023A3 RID: 9123
		[Nullable(2)]
		protected new UndergroundComponent_SetValue PocoInterface;

		// Token: 0x040023A4 RID: 9124
		private List<IUndergroundStateInfo> _StateInfoCache;

		// Token: 0x040023A5 RID: 9125
		private bool _StateInfoInited;
	}
}
