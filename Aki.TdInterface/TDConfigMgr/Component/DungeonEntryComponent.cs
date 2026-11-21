using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200005A RID: 90
	public class DungeonEntryComponent : IComponentBase
	{
		// Token: 0x06000300 RID: 768 RVA: 0x0001B714 File Offset: 0x00019914
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

		// Token: 0x06000301 RID: 769 RVA: 0x0001B74C File Offset: 0x0001994C
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

		// Token: 0x06000302 RID: 770 RVA: 0x0001B75F File Offset: 0x0001995F
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

		// Token: 0x06000303 RID: 771 RVA: 0x0001B772 File Offset: 0x00019972
		public new DungeonEntryComponent_SetValue ToSetValue()
		{
			return new DungeonEntryComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked
			};
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x06000304 RID: 772 RVA: 0x0001B794 File Offset: 0x00019994
		// (set) Token: 0x06000305 RID: 773 RVA: 0x0001B7CE File Offset: 0x000199CE
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

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x06000306 RID: 774 RVA: 0x0001B7DC File Offset: 0x000199DC
		// (set) Token: 0x06000307 RID: 775 RVA: 0x0001B806 File Offset: 0x00019A06
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

		// Token: 0x040001ED RID: 493
		[Nullable(2)]
		protected new DungeonEntryComponent FbInstance;

		// Token: 0x040001EE RID: 494
		[Nullable(2)]
		protected new DungeonEntryComponent_SetValue PocoInterface;
	}
}
