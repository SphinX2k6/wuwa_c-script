using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008D0 RID: 2256
	public class LifePointCenterComponent : IComponentBase
	{
		// Token: 0x060030C5 RID: 12485 RVA: 0x0007D434 File Offset: 0x0007B634
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

		// Token: 0x060030C6 RID: 12486 RVA: 0x0007D46C File Offset: 0x0007B66C
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

		// Token: 0x060030C7 RID: 12487 RVA: 0x0007D47F File Offset: 0x0007B67F
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

		// Token: 0x060030C8 RID: 12488 RVA: 0x0007D492 File Offset: 0x0007B692
		public new LifePointCenterComponent_SetValue ToSetValue()
		{
			return new LifePointCenterComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked
			};
		}

		// Token: 0x17000CAD RID: 3245
		// (get) Token: 0x060030C9 RID: 12489 RVA: 0x0007D4B4 File Offset: 0x0007B6B4
		// (set) Token: 0x060030CA RID: 12490 RVA: 0x0007D4EE File Offset: 0x0007B6EE
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

		// Token: 0x17000CAE RID: 3246
		// (get) Token: 0x060030CB RID: 12491 RVA: 0x0007D4FC File Offset: 0x0007B6FC
		// (set) Token: 0x060030CC RID: 12492 RVA: 0x0007D526 File Offset: 0x0007B726
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

		// Token: 0x04002034 RID: 8244
		[Nullable(2)]
		protected new LifePointCenterComponent FbInstance;

		// Token: 0x04002035 RID: 8245
		[Nullable(2)]
		protected new LifePointCenterComponent_SetValue PocoInterface;
	}
}
