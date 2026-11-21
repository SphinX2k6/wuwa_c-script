using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000058 RID: 88
	public class DropComponent : IComponentBase
	{
		// Token: 0x060002F6 RID: 758 RVA: 0x0001B604 File Offset: 0x00019804
		private DropComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("DropComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			DropComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new DropComponent_SetValue());
			}
			return result;
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x0001B63C File Offset: 0x0001983C
		public static DropComponent Create([Nullable(2)] DropComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new DropComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x0001B64F File Offset: 0x0001984F
		public static DropComponent CreateFromSetValue([Nullable(2)] DropComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new DropComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x0001B662 File Offset: 0x00019862
		public new DropComponent_SetValue ToSetValue()
		{
			return new DropComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked
			};
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x060002FA RID: 762 RVA: 0x0001B684 File Offset: 0x00019884
		// (set) Token: 0x060002FB RID: 763 RVA: 0x0001B6BE File Offset: 0x000198BE
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				DropComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060002FC RID: 764 RVA: 0x0001B6CC File Offset: 0x000198CC
		// (set) Token: 0x060002FD RID: 765 RVA: 0x0001B6F6 File Offset: 0x000198F6
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

		// Token: 0x040001E9 RID: 489
		[Nullable(2)]
		protected new DropComponent FbInstance;

		// Token: 0x040001EA RID: 490
		[Nullable(2)]
		protected new DropComponent_SetValue PocoInterface;
	}
}
