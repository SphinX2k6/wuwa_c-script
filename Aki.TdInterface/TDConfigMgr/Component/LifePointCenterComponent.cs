using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200082D RID: 2093
	[NullableContext(1)]
	[Nullable(0)]
	public class LifePointCenterComponent : IComponentBase
	{
		// Token: 0x06002D95 RID: 11669 RVA: 0x000760D0 File Offset: 0x000742D0
		private LifePointCenterComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("LifePointCenterComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			LifePointCenterComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new LifePointCenterComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06002D96 RID: 11670 RVA: 0x00076108 File Offset: 0x00074308
		public static LifePointCenterComponent Create([Nullable(2)] LifePointCenterComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new LifePointCenterComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002D97 RID: 11671 RVA: 0x0007611B File Offset: 0x0007431B
		public static LifePointCenterComponent CreateFromSetValue([Nullable(2)] LifePointCenterComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new LifePointCenterComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002D98 RID: 11672 RVA: 0x0007612E File Offset: 0x0007432E
		public new LifePointCenterComponent_SetValue ToSetValue()
		{
			return new LifePointCenterComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked
			};
		}

		// Token: 0x17000BEA RID: 3050
		// (get) Token: 0x06002D99 RID: 11673 RVA: 0x00076150 File Offset: 0x00074350
		// (set) Token: 0x06002D9A RID: 11674 RVA: 0x0007618A File Offset: 0x0007438A
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				LifePointCenterComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Disabled;
			}
			set
			{
				this.GetOrCreatePoco().Disabled = value;
			}
		}

		// Token: 0x17000BEB RID: 3051
		// (get) Token: 0x06002D9B RID: 11675 RVA: 0x00076198 File Offset: 0x00074398
		// (set) Token: 0x06002D9C RID: 11676 RVA: 0x000761C2 File Offset: 0x000743C2
		public override bool? EdIsLocked
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdIsLocked;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdIsLocked = value;
			}
		}

		// Token: 0x04001E28 RID: 7720
		[Nullable(2)]
		protected new LifePointCenterComponent FbInstance;

		// Token: 0x04001E29 RID: 7721
		[Nullable(2)]
		protected new LifePointCenterComponent_SetValue PocoInterface;
	}
}
