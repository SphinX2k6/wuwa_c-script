using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FA8 RID: 8104
	[NullableContext(1)]
	[Nullable(0)]
	public class ITeleportTransitionWithCenterText : ITeleportTransitionType
	{
		// Token: 0x0600B236 RID: 45622 RVA: 0x0019F638 File Offset: 0x0019D838
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

		// Token: 0x0600B237 RID: 45623 RVA: 0x0019F670 File Offset: 0x0019D870
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

		// Token: 0x0600B238 RID: 45624 RVA: 0x0019F683 File Offset: 0x0019D883
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

		// Token: 0x0600B239 RID: 45625 RVA: 0x0019F696 File Offset: 0x0019D896
		public new ITeleportTransitionWithCenterText_SetValue ToSetValue()
		{
			return new ITeleportTransitionWithCenterText_SetValue
			{
				Type = this.Type,
				CenterTextFlow = this.CenterTextFlow
			};
		}

		// Token: 0x170036F7 RID: 14071
		// (get) Token: 0x0600B23A RID: 45626 RVA: 0x0019F6B5 File Offset: 0x0019D8B5
		// (set) Token: 0x0600B23B RID: 45627 RVA: 0x0019F6E0 File Offset: 0x0019D8E0
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

		// Token: 0x170036F8 RID: 14072
		// (get) Token: 0x0600B23C RID: 45628 RVA: 0x0019F6F0 File Offset: 0x0019D8F0
		// (set) Token: 0x0600B23D RID: 45629 RVA: 0x0019F751 File Offset: 0x0019D951
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

		// Token: 0x04006BA2 RID: 27554
		[Nullable(2)]
		protected new ITeleportTransitionWithCenterText FbInstance;

		// Token: 0x04006BA3 RID: 27555
		[Nullable(2)]
		protected new ITeleportTransitionWithCenterText_SetValue PocoInterface;

		// Token: 0x04006BA4 RID: 27556
		private PlayFlow _CenterTextFlowCache;

		// Token: 0x04006BA5 RID: 27557
		private bool _CenterTextFlowInited;
	}
}
