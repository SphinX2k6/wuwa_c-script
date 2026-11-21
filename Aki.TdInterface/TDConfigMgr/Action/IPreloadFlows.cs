using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F57 RID: 8023
	public class IPreloadFlows : IPreloadCharacterType
	{
		// Token: 0x0600AAB5 RID: 43701 RVA: 0x00182E54 File Offset: 0x00181054
		private IPreloadFlows_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPreloadFlows 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPreloadFlows_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPreloadFlows_SetValue());
			}
			return result;
		}

		// Token: 0x0600AAB6 RID: 43702 RVA: 0x00182E8C File Offset: 0x0018108C
		public static IPreloadFlows Create([Nullable(2)] IPreloadFlows instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPreloadFlows
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AAB7 RID: 43703 RVA: 0x00182E9F File Offset: 0x0018109F
		public static IPreloadFlows CreateFromSetValue([Nullable(2)] IPreloadFlows_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPreloadFlows
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AAB8 RID: 43704 RVA: 0x00182EB2 File Offset: 0x001810B2
		public new IPreloadFlows_SetValue ToSetValue()
		{
			return new IPreloadFlows_SetValue
			{
				Type = this.Type,
				FlowData = this.FlowData
			};
		}

		// Token: 0x17003466 RID: 13414
		// (get) Token: 0x0600AAB9 RID: 43705 RVA: 0x00182ED1 File Offset: 0x001810D1
		// (set) Token: 0x0600AABA RID: 43706 RVA: 0x00182EFC File Offset: 0x001810FC
		public override EPreloadObjectType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPreloadObjectType.PreloadTrialCharacterForSkill;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003467 RID: 13415
		// (get) Token: 0x0600AABB RID: 43707 RVA: 0x00182F0C File Offset: 0x0018110C
		// (set) Token: 0x0600AABC RID: 43708 RVA: 0x00182F6D File Offset: 0x0018116D
		public virtual PlayFlow FlowData
		{
			get
			{
				if (this._FlowDataInited)
				{
					return this._FlowDataCache;
				}
				this._FlowDataInited = true;
				if (this.FbInstance != null)
				{
					this._FlowDataCache = PlayFlow.Create(this.FbInstance.FlowData);
				}
				else
				{
					IPreloadFlows_SetValue pocoInterface = this.PocoInterface;
					this._FlowDataCache = ((pocoInterface != null) ? pocoInterface.FlowData : null);
				}
				return this._FlowDataCache;
			}
			set
			{
				this.GetOrCreatePoco().FlowData = value;
				this._FlowDataInited = false;
			}
		}

		// Token: 0x04006657 RID: 26199
		[Nullable(2)]
		protected new IPreloadFlows FbInstance;

		// Token: 0x04006658 RID: 26200
		[Nullable(2)]
		protected new IPreloadFlows_SetValue PocoInterface;

		// Token: 0x04006659 RID: 26201
		private PlayFlow _FlowDataCache;

		// Token: 0x0400665A RID: 26202
		private bool _FlowDataInited;
	}
}
