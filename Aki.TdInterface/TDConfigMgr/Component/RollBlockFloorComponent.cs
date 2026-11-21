using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000922 RID: 2338
	public class RollBlockFloorComponent : IComponentBase
	{
		// Token: 0x06003393 RID: 13203 RVA: 0x00083B28 File Offset: 0x00081D28
		private RollBlockFloorComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("RollBlockFloorComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			RollBlockFloorComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new RollBlockFloorComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06003394 RID: 13204 RVA: 0x00083B60 File Offset: 0x00081D60
		public static RollBlockFloorComponent Create([Nullable(2)] RollBlockFloorComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RollBlockFloorComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06003395 RID: 13205 RVA: 0x00083B73 File Offset: 0x00081D73
		public static RollBlockFloorComponent CreateFromSetValue([Nullable(2)] RollBlockFloorComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new RollBlockFloorComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06003396 RID: 13206 RVA: 0x00083B86 File Offset: 0x00081D86
		public new RollBlockFloorComponent_SetValue ToSetValue()
		{
			return new RollBlockFloorComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked
			};
		}

		// Token: 0x17000D99 RID: 3481
		// (get) Token: 0x06003397 RID: 13207 RVA: 0x00083BA8 File Offset: 0x00081DA8
		// (set) Token: 0x06003398 RID: 13208 RVA: 0x00083BE2 File Offset: 0x00081DE2
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				RollBlockFloorComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000D9A RID: 3482
		// (get) Token: 0x06003399 RID: 13209 RVA: 0x00083BF0 File Offset: 0x00081DF0
		// (set) Token: 0x0600339A RID: 13210 RVA: 0x00083C1A File Offset: 0x00081E1A
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

		// Token: 0x040021DE RID: 8670
		[Nullable(2)]
		protected new RollBlockFloorComponent FbInstance;

		// Token: 0x040021DF RID: 8671
		[Nullable(2)]
		protected new RollBlockFloorComponent_SetValue PocoInterface;
	}
}
