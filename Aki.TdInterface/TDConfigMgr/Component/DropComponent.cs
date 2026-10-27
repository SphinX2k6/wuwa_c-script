using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000058 RID: 88
	[NullableContext(1)]
	[Nullable(0)]
	public class DropComponent : IComponentBase
	{
		// Token: 0x060002F2 RID: 754 RVA: 0x0001AC90 File Offset: 0x00018E90
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

		// Token: 0x060002F3 RID: 755 RVA: 0x0001ACC8 File Offset: 0x00018EC8
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

		// Token: 0x060002F4 RID: 756 RVA: 0x0001ACDB File Offset: 0x00018EDB
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

		// Token: 0x060002F5 RID: 757 RVA: 0x0001ACEE File Offset: 0x00018EEE
		public new DropComponent_SetValue ToSetValue()
		{
			return new DropComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked
			};
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060002F6 RID: 758 RVA: 0x0001AD10 File Offset: 0x00018F10
		// (set) Token: 0x060002F7 RID: 759 RVA: 0x0001AD4A File Offset: 0x00018F4A
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

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060002F8 RID: 760 RVA: 0x0001AD58 File Offset: 0x00018F58
		// (set) Token: 0x060002F9 RID: 761 RVA: 0x0001AD82 File Offset: 0x00018F82
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

		// Token: 0x040001E4 RID: 484
		[Nullable(2)]
		protected new DropComponent FbInstance;

		// Token: 0x040001E5 RID: 485
		[Nullable(2)]
		protected new DropComponent_SetValue PocoInterface;
	}
}
