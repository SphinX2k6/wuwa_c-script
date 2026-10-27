using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020001BF RID: 447
	[NullableContext(1)]
	[Nullable(0)]
	public class IAnEvent : ISceneItemSeqEventCbType
	{
		// Token: 0x06000714 RID: 1812 RVA: 0x000243D4 File Offset: 0x000225D4
		private IAnEvent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAnEvent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAnEvent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAnEvent_SetValue());
			}
			return result;
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x0002440C File Offset: 0x0002260C
		public static IAnEvent Create([Nullable(2)] IAnEvent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAnEvent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x0002441F File Offset: 0x0002261F
		public static IAnEvent CreateFromSetValue([Nullable(2)] IAnEvent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAnEvent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x00024432 File Offset: 0x00022632
		public new IAnEvent_SetValue ToSetValue()
		{
			return new IAnEvent_SetValue
			{
				Type = this.Type,
				EventName = this.EventName,
				Action = this.Action
			};
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06000718 RID: 1816 RVA: 0x0002445D File Offset: 0x0002265D
		// (set) Token: 0x06000719 RID: 1817 RVA: 0x00024488 File Offset: 0x00022688
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

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x0600071A RID: 1818 RVA: 0x00024496 File Offset: 0x00022696
		// (set) Token: 0x0600071B RID: 1819 RVA: 0x000244C1 File Offset: 0x000226C1
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

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x0600071C RID: 1820 RVA: 0x000244D0 File Offset: 0x000226D0
		// (set) Token: 0x0600071D RID: 1821 RVA: 0x00024531 File Offset: 0x00022731
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
					IAnEvent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x0400086F RID: 2159
		[Nullable(2)]
		protected new IAnEvent FbInstance;

		// Token: 0x04000870 RID: 2160
		[Nullable(2)]
		protected new IAnEvent_SetValue PocoInterface;

		// Token: 0x04000871 RID: 2161
		private ActionInfo _ActionCache;

		// Token: 0x04000872 RID: 2162
		private bool _ActionInited;
	}
}
