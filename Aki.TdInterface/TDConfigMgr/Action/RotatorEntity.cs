using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002178 RID: 8568
	[NullableContext(1)]
	[Nullable(0)]
	public class RotatorEntity : ActionParams
	{
		// Token: 0x0600BC5C RID: 48220 RVA: 0x001B2548 File Offset: 0x001B0748
		private RotatorEntity_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("RotatorEntity 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			RotatorEntity_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new RotatorEntity_SetValue());
			}
			return result;
		}

		// Token: 0x0600BC5D RID: 48221 RVA: 0x001B2580 File Offset: 0x001B0780
		public static RotatorEntity Create([Nullable(2)] RotatorEntity instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RotatorEntity
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BC5E RID: 48222 RVA: 0x001B2593 File Offset: 0x001B0793
		public static RotatorEntity CreateFromSetValue([Nullable(2)] RotatorEntity_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new RotatorEntity
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BC5F RID: 48223 RVA: 0x001B25A6 File Offset: 0x001B07A6
		public RotatorEntity_SetValue ToSetValue()
		{
			return new RotatorEntity_SetValue
			{
				Entity = this.Entity
			};
		}

		// Token: 0x1700395A RID: 14682
		// (get) Token: 0x0600BC60 RID: 48224 RVA: 0x001B25B9 File Offset: 0x001B07B9
		// (set) Token: 0x0600BC61 RID: 48225 RVA: 0x001B25E0 File Offset: 0x001B07E0
		public virtual ITargetEntityType Entity
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Entity;
				}
				RotatorEntity_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Entity;
			}
			set
			{
				this.GetOrCreatePoco().Entity = value;
			}
		}

		// Token: 0x04007082 RID: 28802
		[Nullable(2)]
		protected new RotatorEntity FbInstance;

		// Token: 0x04007083 RID: 28803
		[Nullable(2)]
		protected RotatorEntity_SetValue PocoInterface;
	}
}
