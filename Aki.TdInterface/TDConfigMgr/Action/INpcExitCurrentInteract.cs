using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E5F RID: 7775
	public class INpcExitCurrentInteract : INpcLeisureInteractType
	{
		// Token: 0x0600A54F RID: 42319 RVA: 0x001791F8 File Offset: 0x001773F8
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

		// Token: 0x0600A550 RID: 42320 RVA: 0x00179230 File Offset: 0x00177430
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

		// Token: 0x0600A551 RID: 42321 RVA: 0x00179243 File Offset: 0x00177443
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

		// Token: 0x0600A552 RID: 42322 RVA: 0x00179256 File Offset: 0x00177456
		public new INpcExitCurrentInteract_SetValue ToSetValue()
		{
			return new INpcExitCurrentInteract_SetValue
			{
				Type = this.Type,
				KeepState = this.KeepState
			};
		}

		// Token: 0x17003327 RID: 13095
		// (get) Token: 0x0600A553 RID: 42323 RVA: 0x00179275 File Offset: 0x00177475
		// (set) Token: 0x0600A554 RID: 42324 RVA: 0x001792A0 File Offset: 0x001774A0
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

		// Token: 0x17003328 RID: 13096
		// (get) Token: 0x0600A555 RID: 42325 RVA: 0x001792B0 File Offset: 0x001774B0
		// (set) Token: 0x0600A556 RID: 42326 RVA: 0x001792EA File Offset: 0x001774EA
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

		// Token: 0x040063DA RID: 25562
		[Nullable(2)]
		protected new INpcExitCurrentInteract FbInstance;

		// Token: 0x040063DB RID: 25563
		[Nullable(2)]
		protected new INpcExitCurrentInteract_SetValue PocoInterface;
	}
}
