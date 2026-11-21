using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021EB RID: 8683
	public class ITeleportTransitionWithCenterText : ITeleportTransitionType
	{
		// Token: 0x0600BD3A RID: 48442 RVA: 0x001B59E8 File Offset: 0x001B3BE8
		private ITeleportTransitionWithCenterText_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITeleportTransitionWithCenterText 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITeleportTransitionWithCenterText_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITeleportTransitionWithCenterText_SetValue());
			}
			return result;
		}

		// Token: 0x0600BD3B RID: 48443 RVA: 0x001B5A20 File Offset: 0x001B3C20
		public static ITeleportTransitionWithCenterText Create([Nullable(2)] ITeleportTransitionWithCenterText instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITeleportTransitionWithCenterText
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BD3C RID: 48444 RVA: 0x001B5A33 File Offset: 0x001B3C33
		public static ITeleportTransitionWithCenterText CreateFromSetValue([Nullable(2)] ITeleportTransitionWithCenterText_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITeleportTransitionWithCenterText
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BD3D RID: 48445 RVA: 0x001B5A46 File Offset: 0x001B3C46
		public new ITeleportTransitionWithCenterText_SetValue ToSetValue()
		{
			return new ITeleportTransitionWithCenterText_SetValue
			{
				Type = this.Type,
				CenterTextFlow = this.CenterTextFlow
			};
		}

		// Token: 0x170039CC RID: 14796
		// (get) Token: 0x0600BD3E RID: 48446 RVA: 0x001B5A65 File Offset: 0x001B3C65
		// (set) Token: 0x0600BD3F RID: 48447 RVA: 0x001B5A90 File Offset: 0x001B3C90
		public override ETeleportTransitionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETeleportTransitionType.PlayMp4;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170039CD RID: 14797
		// (get) Token: 0x0600BD40 RID: 48448 RVA: 0x001B5AA0 File Offset: 0x001B3CA0
		// (set) Token: 0x0600BD41 RID: 48449 RVA: 0x001B5B01 File Offset: 0x001B3D01
		public virtual PlayFlow CenterTextFlow
		{
			get
			{
				if (this._CenterTextFlowInited)
				{
					return this._CenterTextFlowCache;
				}
				this._CenterTextFlowInited = true;
				if (this.FbInstance != null)
				{
					this._CenterTextFlowCache = PlayFlow.Create(this.FbInstance.CenterTextFlow);
				}
				else
				{
					ITeleportTransitionWithCenterText_SetValue pocoInterface = this.PocoInterface;
					this._CenterTextFlowCache = ((pocoInterface != null) ? pocoInterface.CenterTextFlow : null);
				}
				return this._CenterTextFlowCache;
			}
			set
			{
				this.GetOrCreatePoco().CenterTextFlow = value;
				this._CenterTextFlowInited = false;
			}
		}

		// Token: 0x0400719D RID: 29085
		[Nullable(2)]
		protected new ITeleportTransitionWithCenterText FbInstance;

		// Token: 0x0400719E RID: 29086
		[Nullable(2)]
		protected new ITeleportTransitionWithCenterText_SetValue PocoInterface;

		// Token: 0x0400719F RID: 29087
		private PlayFlow _CenterTextFlowCache;

		// Token: 0x040071A0 RID: 29088
		private bool _CenterTextFlowInited;
	}
}
