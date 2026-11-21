using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A63 RID: 6755
	public class IClientUiEvent : IClientEventTarget
	{
		// Token: 0x06008F8F RID: 36751 RVA: 0x00152330 File Offset: 0x00150530
		private IClientUiEvent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IClientUiEvent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IClientUiEvent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IClientUiEvent_SetValue());
			}
			return result;
		}

		// Token: 0x06008F90 RID: 36752 RVA: 0x00152368 File Offset: 0x00150568
		public static IClientUiEvent Create([Nullable(2)] IClientUiEvent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IClientUiEvent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008F91 RID: 36753 RVA: 0x0015237B File Offset: 0x0015057B
		public static IClientUiEvent CreateFromSetValue([Nullable(2)] IClientUiEvent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IClientUiEvent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008F92 RID: 36754 RVA: 0x0015238E File Offset: 0x0015058E
		public new IClientUiEvent_SetValue ToSetValue()
		{
			return new IClientUiEvent_SetValue
			{
				Type = this.Type,
				Ui = this.Ui
			};
		}

		// Token: 0x17002E3F RID: 11839
		// (get) Token: 0x06008F93 RID: 36755 RVA: 0x001523AD File Offset: 0x001505AD
		// (set) Token: 0x06008F94 RID: 36756 RVA: 0x001523D8 File Offset: 0x001505D8
		public override EClientEventTarget Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EClientEventTarget.Self;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002E40 RID: 11840
		// (get) Token: 0x06008F95 RID: 36757 RVA: 0x001523E6 File Offset: 0x001505E6
		// (set) Token: 0x06008F96 RID: 36758 RVA: 0x0015240D File Offset: 0x0015060D
		public virtual IClientEventUi Ui
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Ui;
				}
				IClientUiEvent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Ui;
			}
			set
			{
				this.GetOrCreatePoco().Ui = value;
			}
		}

		// Token: 0x040059F8 RID: 23032
		[Nullable(2)]
		protected new IClientUiEvent FbInstance;

		// Token: 0x040059F9 RID: 23033
		[Nullable(2)]
		protected new IClientUiEvent_SetValue PocoInterface;
	}
}
