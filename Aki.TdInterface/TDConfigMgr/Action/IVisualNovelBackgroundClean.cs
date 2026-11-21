using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022A4 RID: 8868
	public class IVisualNovelBackgroundClean : IVisualNovelBackgroundBase
	{
		// Token: 0x0600C126 RID: 49446 RVA: 0x001BCAF0 File Offset: 0x001BACF0
		private IVisualNovelBackgroundClean_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVisualNovelBackgroundClean 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVisualNovelBackgroundClean_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVisualNovelBackgroundClean_SetValue());
			}
			return result;
		}

		// Token: 0x0600C127 RID: 49447 RVA: 0x001BCB28 File Offset: 0x001BAD28
		public static IVisualNovelBackgroundClean Create([Nullable(2)] IVisualNovelBackgroundClean instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelBackgroundClean
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C128 RID: 49448 RVA: 0x001BCB3B File Offset: 0x001BAD3B
		public static IVisualNovelBackgroundClean CreateFromSetValue([Nullable(2)] IVisualNovelBackgroundClean_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVisualNovelBackgroundClean
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C129 RID: 49449 RVA: 0x001BCB4E File Offset: 0x001BAD4E
		public new IVisualNovelBackgroundClean_SetValue ToSetValue()
		{
			return new IVisualNovelBackgroundClean_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003AAD RID: 15021
		// (get) Token: 0x0600C12A RID: 49450 RVA: 0x001BCB61 File Offset: 0x001BAD61
		// (set) Token: 0x0600C12B RID: 49451 RVA: 0x001BCB8C File Offset: 0x001BAD8C
		public override EVisualNovelBackgroundType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EVisualNovelBackgroundType.Load;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04007370 RID: 29552
		[Nullable(2)]
		protected new IVisualNovelBackgroundClean FbInstance;

		// Token: 0x04007371 RID: 29553
		[Nullable(2)]
		protected new IVisualNovelBackgroundClean_SetValue PocoInterface;
	}
}
