using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018D2 RID: 6354
	[NullableContext(1)]
	[Nullable(0)]
	public class IClientUiEvent : IClientEventTarget
	{
		// Token: 0x06008847 RID: 34887 RVA: 0x001427B8 File Offset: 0x001409B8
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

		// Token: 0x06008848 RID: 34888 RVA: 0x001427F0 File Offset: 0x001409F0
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

		// Token: 0x06008849 RID: 34889 RVA: 0x00142803 File Offset: 0x00140A03
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

		// Token: 0x0600884A RID: 34890 RVA: 0x00142816 File Offset: 0x00140A16
		public new IClientUiEvent_SetValue ToSetValue()
		{
			return new IClientUiEvent_SetValue
			{
				Type = this.Type,
				Ui = this.Ui
			};
		}

		// Token: 0x17002C3D RID: 11325
		// (get) Token: 0x0600884B RID: 34891 RVA: 0x00142835 File Offset: 0x00140A35
		// (set) Token: 0x0600884C RID: 34892 RVA: 0x00142860 File Offset: 0x00140A60
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

		// Token: 0x17002C3E RID: 11326
		// (get) Token: 0x0600884D RID: 34893 RVA: 0x0014286E File Offset: 0x00140A6E
		// (set) Token: 0x0600884E RID: 34894 RVA: 0x00142895 File Offset: 0x00140A95
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

		// Token: 0x0400559E RID: 21918
		[Nullable(2)]
		protected new IClientUiEvent FbInstance;

		// Token: 0x0400559F RID: 21919
		[Nullable(2)]
		protected new IClientUiEvent_SetValue PocoInterface;
	}
}
