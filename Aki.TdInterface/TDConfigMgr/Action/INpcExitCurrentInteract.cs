using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C66 RID: 7270
	[NullableContext(1)]
	[Nullable(0)]
	public class INpcExitCurrentInteract : INpcLeisureInteractType
	{
		// Token: 0x06009BEF RID: 39919 RVA: 0x00165DFC File Offset: 0x00163FFC
		private INpcExitCurrentInteract_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INpcExitCurrentInteract 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INpcExitCurrentInteract_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INpcExitCurrentInteract_SetValue());
			}
			return result;
		}

		// Token: 0x06009BF0 RID: 39920 RVA: 0x00165E34 File Offset: 0x00164034
		public static INpcExitCurrentInteract Create([Nullable(2)] INpcExitCurrentInteract instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcExitCurrentInteract
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009BF1 RID: 39921 RVA: 0x00165E47 File Offset: 0x00164047
		public static INpcExitCurrentInteract CreateFromSetValue([Nullable(2)] INpcExitCurrentInteract_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INpcExitCurrentInteract
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009BF2 RID: 39922 RVA: 0x00165E5A File Offset: 0x0016405A
		public new INpcExitCurrentInteract_SetValue ToSetValue()
		{
			return new INpcExitCurrentInteract_SetValue
			{
				Type = this.Type,
				KeepState = this.KeepState
			};
		}

		// Token: 0x170030B5 RID: 12469
		// (get) Token: 0x06009BF3 RID: 39923 RVA: 0x00165E79 File Offset: 0x00164079
		// (set) Token: 0x06009BF4 RID: 39924 RVA: 0x00165EA4 File Offset: 0x001640A4
		public override ENpcLeisureInteract Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ENpcLeisureInteract.SitDown;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170030B6 RID: 12470
		// (get) Token: 0x06009BF5 RID: 39925 RVA: 0x00165EB4 File Offset: 0x001640B4
		// (set) Token: 0x06009BF6 RID: 39926 RVA: 0x00165EEE File Offset: 0x001640EE
		public override bool? KeepState
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.KeepState;
				}
				INpcExitCurrentInteract_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.KeepState;
			}
			set
			{
				this.GetOrCreatePoco().KeepState = value;
			}
		}

		// Token: 0x04005EA0 RID: 24224
		[Nullable(2)]
		protected new INpcExitCurrentInteract FbInstance;

		// Token: 0x04005EA1 RID: 24225
		[Nullable(2)]
		protected new INpcExitCurrentInteract_SetValue PocoInterface;
	}
}
