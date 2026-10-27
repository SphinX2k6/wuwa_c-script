using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200005A RID: 90
	[NullableContext(1)]
	[Nullable(0)]
	public class DungeonEntryComponent : IComponentBase
	{
		// Token: 0x060002FC RID: 764 RVA: 0x0001ADA0 File Offset: 0x00018FA0
		private DungeonEntryComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("DungeonEntryComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			DungeonEntryComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new DungeonEntryComponent_SetValue());
			}
			return result;
		}

		// Token: 0x060002FD RID: 765 RVA: 0x0001ADD8 File Offset: 0x00018FD8
		public static DungeonEntryComponent Create([Nullable(2)] DungeonEntryComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new DungeonEntryComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x060002FE RID: 766 RVA: 0x0001ADEB File Offset: 0x00018FEB
		public static DungeonEntryComponent CreateFromSetValue([Nullable(2)] DungeonEntryComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new DungeonEntryComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x060002FF RID: 767 RVA: 0x0001ADFE File Offset: 0x00018FFE
		public new DungeonEntryComponent_SetValue ToSetValue()
		{
			return new DungeonEntryComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked
			};
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000300 RID: 768 RVA: 0x0001AE20 File Offset: 0x00019020
		// (set) Token: 0x06000301 RID: 769 RVA: 0x0001AE5A File Offset: 0x0001905A
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				DungeonEntryComponent_SetValue pocoInterface = this.PocoInterface;
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
		// (get) Token: 0x06000302 RID: 770 RVA: 0x0001AE68 File Offset: 0x00019068
		// (set) Token: 0x06000303 RID: 771 RVA: 0x0001AE92 File Offset: 0x00019092
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

		// Token: 0x040001E8 RID: 488
		[Nullable(2)]
		protected new DungeonEntryComponent FbInstance;

		// Token: 0x040001E9 RID: 489
		[Nullable(2)]
		protected new DungeonEntryComponent_SetValue PocoInterface;
	}
}
