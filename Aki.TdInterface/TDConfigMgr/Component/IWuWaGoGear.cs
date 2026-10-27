using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007FB RID: 2043
	[NullableContext(1)]
	[Nullable(0)]
	public class IWuWaGoGear : IWuWaGoEntityBase
	{
		// Token: 0x06002C5B RID: 11355 RVA: 0x0007338C File Offset: 0x0007158C
		private IWuWaGoGear_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IWuWaGoGear 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IWuWaGoGear_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IWuWaGoGear_SetValue());
			}
			return result;
		}

		// Token: 0x06002C5C RID: 11356 RVA: 0x000733C4 File Offset: 0x000715C4
		public static IWuWaGoGear Create([Nullable(2)] IWuWaGoGear instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWuWaGoGear
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002C5D RID: 11357 RVA: 0x000733D7 File Offset: 0x000715D7
		public static IWuWaGoGear CreateFromSetValue([Nullable(2)] IWuWaGoGear_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IWuWaGoGear
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002C5E RID: 11358 RVA: 0x000733EA File Offset: 0x000715EA
		public new IWuWaGoGear_SetValue ToSetValue()
		{
			return new IWuWaGoGear_SetValue
			{
				Type = this.Type,
				GridEntityIds = this.GridEntityIds
			};
		}

		// Token: 0x17000B98 RID: 2968
		// (get) Token: 0x06002C5F RID: 11359 RVA: 0x00073409 File Offset: 0x00071609
		// (set) Token: 0x06002C60 RID: 11360 RVA: 0x00073434 File Offset: 0x00071634
		public override EWuWaGoEntityType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EWuWaGoEntityType.LevelCenter;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000B99 RID: 2969
		// (get) Token: 0x06002C61 RID: 11361 RVA: 0x00073442 File Offset: 0x00071642
		// (set) Token: 0x06002C62 RID: 11362 RVA: 0x00073469 File Offset: 0x00071669
		public virtual List<int> GridEntityIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.GridEntityIds;
				}
				IWuWaGoGear_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.GridEntityIds;
			}
			set
			{
				this.GetOrCreatePoco().GridEntityIds = value;
			}
		}

		// Token: 0x04001D60 RID: 7520
		[Nullable(2)]
		protected new IWuWaGoGear FbInstance;

		// Token: 0x04001D61 RID: 7521
		[Nullable(2)]
		protected new IWuWaGoGear_SetValue PocoInterface;
	}
}
