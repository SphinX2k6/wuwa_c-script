using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E1A RID: 7706
	[NullableContext(1)]
	[Nullable(0)]
	public class ISetBehaviorPaused
	{
		// Token: 0x0600A4D7 RID: 42199 RVA: 0x00175B14 File Offset: 0x00173D14
		private ISetBehaviorPaused_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISetBehaviorPaused 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISetBehaviorPaused_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISetBehaviorPaused_SetValue());
			}
			return result;
		}

		// Token: 0x0600A4D8 RID: 42200 RVA: 0x00175B4C File Offset: 0x00173D4C
		public static ISetBehaviorPaused Create([Nullable(2)] ISetBehaviorPaused instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetBehaviorPaused
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A4D9 RID: 42201 RVA: 0x00175B5F File Offset: 0x00173D5F
		public static ISetBehaviorPaused CreateFromSetValue([Nullable(2)] ISetBehaviorPaused_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISetBehaviorPaused
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A4DA RID: 42202 RVA: 0x00175B72 File Offset: 0x00173D72
		public ISetBehaviorPaused_SetValue ToSetValue()
		{
			return new ISetBehaviorPaused_SetValue
			{
				IsPaused = this.IsPaused
			};
		}

		// Token: 0x1700329B RID: 12955
		// (get) Token: 0x0600A4DB RID: 42203 RVA: 0x00175B85 File Offset: 0x00173D85
		// (set) Token: 0x0600A4DC RID: 42204 RVA: 0x00175BB0 File Offset: 0x00173DB0
		public virtual bool IsPaused
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsPaused;
				}
				return this.PocoInterface != null && this.PocoInterface.IsPaused;
			}
			set
			{
				this.GetOrCreatePoco().IsPaused = value;
			}
		}

		// Token: 0x040062A8 RID: 25256
		[Nullable(2)]
		protected ISetBehaviorPaused FbInstance;

		// Token: 0x040062A9 RID: 25257
		[Nullable(2)]
		protected ISetBehaviorPaused_SetValue PocoInterface;
	}
}
