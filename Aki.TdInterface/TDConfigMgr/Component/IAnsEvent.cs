using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020001CB RID: 459
	[NullableContext(1)]
	[Nullable(0)]
	public class IAnsEvent : ISceneItemSeqEventCbType
	{
		// Token: 0x06000756 RID: 1878 RVA: 0x00024C50 File Offset: 0x00022E50
		private IAnsEvent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAnsEvent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAnsEvent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAnsEvent_SetValue());
			}
			return result;
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x00024C88 File Offset: 0x00022E88
		public static IAnsEvent Create([Nullable(2)] IAnsEvent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAnsEvent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000758 RID: 1880 RVA: 0x00024C9B File Offset: 0x00022E9B
		public static IAnsEvent CreateFromSetValue([Nullable(2)] IAnsEvent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAnsEvent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000759 RID: 1881 RVA: 0x00024CAE File Offset: 0x00022EAE
		public new IAnsEvent_SetValue ToSetValue()
		{
			return new IAnsEvent_SetValue
			{
				Type = this.Type,
				EventName = this.EventName,
				Action = this.Action,
				Duration = this.Duration
			};
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x0600075A RID: 1882 RVA: 0x00024CE5 File Offset: 0x00022EE5
		// (set) Token: 0x0600075B RID: 1883 RVA: 0x00024D10 File Offset: 0x00022F10
		public override ESceneItemSeqEventCbType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESceneItemSeqEventCbType.ANS;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x0600075C RID: 1884 RVA: 0x00024D1E File Offset: 0x00022F1E
		// (set) Token: 0x0600075D RID: 1885 RVA: 0x00024D49 File Offset: 0x00022F49
		public override string EventName
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EventName;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.EventName;
			}
			set
			{
				this.GetOrCreatePoco().EventName = value;
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x0600075E RID: 1886 RVA: 0x00024D58 File Offset: 0x00022F58
		// (set) Token: 0x0600075F RID: 1887 RVA: 0x00024DB9 File Offset: 0x00022FB9
		public override ActionInfo Action
		{
			get
			{
				if (this._ActionInited)
				{
					return this._ActionCache;
				}
				this._ActionInited = true;
				if (this.FbInstance != null)
				{
					this._ActionCache = ActionInfo.Create(this.FbInstance.Action);
				}
				else
				{
					IAnsEvent_SetValue pocoInterface = this.PocoInterface;
					this._ActionCache = ((pocoInterface != null) ? pocoInterface.Action : null);
				}
				return this._ActionCache;
			}
			set
			{
				this.GetOrCreatePoco().Action = value;
				this._ActionInited = false;
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06000760 RID: 1888 RVA: 0x00024DCE File Offset: 0x00022FCE
		// (set) Token: 0x06000761 RID: 1889 RVA: 0x00024DFD File Offset: 0x00022FFD
		public virtual float Duration
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Duration;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Duration;
			}
			set
			{
				this.GetOrCreatePoco().Duration = value;
			}
		}

		// Token: 0x04000896 RID: 2198
		[Nullable(2)]
		protected new IAnsEvent FbInstance;

		// Token: 0x04000897 RID: 2199
		[Nullable(2)]
		protected new IAnsEvent_SetValue PocoInterface;

		// Token: 0x04000898 RID: 2200
		private ActionInfo _ActionCache;

		// Token: 0x04000899 RID: 2201
		private bool _ActionInited;
	}
}
