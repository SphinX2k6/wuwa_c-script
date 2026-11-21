using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000920 RID: 2336
	public class RollBlockComponent : IComponentBase
	{
		// Token: 0x06003389 RID: 13193 RVA: 0x00083A18 File Offset: 0x00081C18
		private RollBlockComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("RollBlockComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			RollBlockComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new RollBlockComponent_SetValue());
			}
			return result;
		}

		// Token: 0x0600338A RID: 13194 RVA: 0x00083A50 File Offset: 0x00081C50
		public static RollBlockComponent Create([Nullable(2)] RollBlockComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RollBlockComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600338B RID: 13195 RVA: 0x00083A63 File Offset: 0x00081C63
		public static RollBlockComponent CreateFromSetValue([Nullable(2)] RollBlockComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new RollBlockComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600338C RID: 13196 RVA: 0x00083A76 File Offset: 0x00081C76
		public new RollBlockComponent_SetValue ToSetValue()
		{
			return new RollBlockComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked
			};
		}

		// Token: 0x17000D97 RID: 3479
		// (get) Token: 0x0600338D RID: 13197 RVA: 0x00083A98 File Offset: 0x00081C98
		// (set) Token: 0x0600338E RID: 13198 RVA: 0x00083AD2 File Offset: 0x00081CD2
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				RollBlockComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000D98 RID: 3480
		// (get) Token: 0x0600338F RID: 13199 RVA: 0x00083AE0 File Offset: 0x00081CE0
		// (set) Token: 0x06003390 RID: 13200 RVA: 0x00083B0A File Offset: 0x00081D0A
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

		// Token: 0x040021DA RID: 8666
		[Nullable(2)]
		protected new RollBlockComponent FbInstance;

		// Token: 0x040021DB RID: 8667
		[Nullable(2)]
		protected new RollBlockComponent_SetValue PocoInterface;
	}
}
