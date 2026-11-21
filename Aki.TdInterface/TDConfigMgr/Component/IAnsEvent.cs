using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020001EE RID: 494
	public class IAnsEvent : ISceneItemSeqEventCbType
	{
		// Token: 0x060007AA RID: 1962 RVA: 0x00025F54 File Offset: 0x00024154
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

		// Token: 0x060007AB RID: 1963 RVA: 0x00025F8C File Offset: 0x0002418C
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

		// Token: 0x060007AC RID: 1964 RVA: 0x00025F9F File Offset: 0x0002419F
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

		// Token: 0x060007AD RID: 1965 RVA: 0x00025FB2 File Offset: 0x000241B2
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

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x060007AE RID: 1966 RVA: 0x00025FE9 File Offset: 0x000241E9
		// (set) Token: 0x060007AF RID: 1967 RVA: 0x00026014 File Offset: 0x00024214
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

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x060007B0 RID: 1968 RVA: 0x00026022 File Offset: 0x00024222
		// (set) Token: 0x060007B1 RID: 1969 RVA: 0x0002604D File Offset: 0x0002424D
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

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x060007B2 RID: 1970 RVA: 0x0002605C File Offset: 0x0002425C
		// (set) Token: 0x060007B3 RID: 1971 RVA: 0x000260BD File Offset: 0x000242BD
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

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x060007B4 RID: 1972 RVA: 0x000260D2 File Offset: 0x000242D2
		// (set) Token: 0x060007B5 RID: 1973 RVA: 0x00026101 File Offset: 0x00024301
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

		// Token: 0x0400090A RID: 2314
		[Nullable(2)]
		protected new IAnsEvent FbInstance;

		// Token: 0x0400090B RID: 2315
		[Nullable(2)]
		protected new IAnsEvent_SetValue PocoInterface;

		// Token: 0x0400090C RID: 2316
		private ActionInfo _ActionCache;

		// Token: 0x0400090D RID: 2317
		private bool _ActionInited;
	}
}
