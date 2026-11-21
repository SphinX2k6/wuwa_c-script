using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A3D RID: 6717
	public class IClientEventUi
	{
		// Token: 0x06008ED7 RID: 36567 RVA: 0x00151004 File Offset: 0x0014F204
		private IClientEventUi_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IClientEventUi 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IClientEventUi_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IClientEventUi_SetValue());
			}
			return result;
		}

		// Token: 0x06008ED8 RID: 36568 RVA: 0x0015103C File Offset: 0x0014F23C
		public static IClientEventUi Create([Nullable(2)] IClientEventUi instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IClientEventUi
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008ED9 RID: 36569 RVA: 0x0015104F File Offset: 0x0014F24F
		public static IClientEventUi CreateFromSetValue([Nullable(2)] IClientEventUi_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IClientEventUi
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008EDA RID: 36570 RVA: 0x00151062 File Offset: 0x0014F262
		public IClientEventUi_SetValue ToSetValue()
		{
			return new IClientEventUi_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002E1C RID: 11804
		// (get) Token: 0x06008EDB RID: 36571 RVA: 0x00151075 File Offset: 0x0014F275
		// (set) Token: 0x06008EDC RID: 36572 RVA: 0x001510A0 File Offset: 0x0014F2A0
		public virtual EClientEventUiType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EClientEventUiType.PlayPiano;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040059A7 RID: 22951
		[Nullable(2)]
		protected IClientEventUi FbInstance;

		// Token: 0x040059A8 RID: 22952
		[Nullable(2)]
		protected IClientEventUi_SetValue PocoInterface;
	}
}
