using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000749 RID: 1865
	public class ISceneItemSeqEventCbType
	{
		// Token: 0x060027A2 RID: 10146 RVA: 0x00069EB8 File Offset: 0x000680B8
		private ISceneItemSeqEventCbType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISceneItemSeqEventCbType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISceneItemSeqEventCbType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISceneItemSeqEventCbType_SetValue());
			}
			return result;
		}

		// Token: 0x060027A3 RID: 10147 RVA: 0x00069EF0 File Offset: 0x000680F0
		public static ISceneItemSeqEventCbType Create([Nullable(2)] ISceneItemSeqEventCbType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneItemSeqEventCbType
			{
				FbInstance = instance
			};
		}

		// Token: 0x060027A4 RID: 10148 RVA: 0x00069F03 File Offset: 0x00068103
		public static ISceneItemSeqEventCbType CreateFromSetValue([Nullable(2)] ISceneItemSeqEventCbType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISceneItemSeqEventCbType
			{
				PocoInterface = value
			};
		}

		// Token: 0x060027A5 RID: 10149 RVA: 0x00069F16 File Offset: 0x00068116
		public ISceneItemSeqEventCbType_SetValue ToSetValue()
		{
			return new ISceneItemSeqEventCbType_SetValue
			{
				Type = this.Type,
				EventName = this.EventName,
				Action = this.Action
			};
		}

		// Token: 0x17000A62 RID: 2658
		// (get) Token: 0x060027A6 RID: 10150 RVA: 0x00069F41 File Offset: 0x00068141
		// (set) Token: 0x060027A7 RID: 10151 RVA: 0x00069F6C File Offset: 0x0006816C
		public virtual ESceneItemSeqEventCbType Type
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

		// Token: 0x17000A63 RID: 2659
		// (get) Token: 0x060027A8 RID: 10152 RVA: 0x00069F7A File Offset: 0x0006817A
		// (set) Token: 0x060027A9 RID: 10153 RVA: 0x00069FA5 File Offset: 0x000681A5
		public virtual string EventName
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

		// Token: 0x17000A64 RID: 2660
		// (get) Token: 0x060027AA RID: 10154 RVA: 0x00069FB4 File Offset: 0x000681B4
		// (set) Token: 0x060027AB RID: 10155 RVA: 0x0006A015 File Offset: 0x00068215
		public virtual ActionInfo Action
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
					ISceneItemSeqEventCbType_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04001B0F RID: 6927
		[Nullable(2)]
		protected ISceneItemSeqEventCbType FbInstance;

		// Token: 0x04001B10 RID: 6928
		[Nullable(2)]
		protected ISceneItemSeqEventCbType_SetValue PocoInterface;

		// Token: 0x04001B11 RID: 6929
		private ActionInfo _ActionCache;

		// Token: 0x04001B12 RID: 6930
		private bool _ActionInited;
	}
}
