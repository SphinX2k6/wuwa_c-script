using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008FE RID: 2302
	public class ProceduralVisualComponent : IComponentBase
	{
		// Token: 0x06003273 RID: 12915 RVA: 0x00081328 File Offset: 0x0007F528
		private ProceduralVisualComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ProceduralVisualComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ProceduralVisualComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ProceduralVisualComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06003274 RID: 12916 RVA: 0x00081360 File Offset: 0x0007F560
		public static ProceduralVisualComponent Create([Nullable(2)] ProceduralVisualComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ProceduralVisualComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06003275 RID: 12917 RVA: 0x00081373 File Offset: 0x0007F573
		public static ProceduralVisualComponent CreateFromSetValue([Nullable(2)] ProceduralVisualComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ProceduralVisualComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06003276 RID: 12918 RVA: 0x00081386 File Offset: 0x0007F586
		public new ProceduralVisualComponent_SetValue ToSetValue()
		{
			return new ProceduralVisualComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				Configs = this.Configs
			};
		}

		// Token: 0x17000D3F RID: 3391
		// (get) Token: 0x06003277 RID: 12919 RVA: 0x000813B4 File Offset: 0x0007F5B4
		// (set) Token: 0x06003278 RID: 12920 RVA: 0x000813EE File Offset: 0x0007F5EE
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				ProceduralVisualComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000D40 RID: 3392
		// (get) Token: 0x06003279 RID: 12921 RVA: 0x000813FC File Offset: 0x0007F5FC
		// (set) Token: 0x0600327A RID: 12922 RVA: 0x00081426 File Offset: 0x0007F626
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

		// Token: 0x17000D41 RID: 3393
		// (get) Token: 0x0600327B RID: 12923 RVA: 0x00081434 File Offset: 0x0007F634
		// (set) Token: 0x0600327C RID: 12924 RVA: 0x0008145B File Offset: 0x0007F65B
		public virtual List<IProceduralVisualBase> Configs
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Configs;
				}
				ProceduralVisualComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Configs;
			}
			set
			{
				this.GetOrCreatePoco().Configs = value;
			}
		}

		// Token: 0x0400213C RID: 8508
		[Nullable(2)]
		protected new ProceduralVisualComponent FbInstance;

		// Token: 0x0400213D RID: 8509
		[Nullable(2)]
		protected new ProceduralVisualComponent_SetValue PocoInterface;
	}
}
