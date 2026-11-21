using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B0F RID: 6927
	public class IDeliverItemProbeCollectibleViewStyle
	{
		// Token: 0x06009315 RID: 37653 RVA: 0x00158338 File Offset: 0x00156538
		private IDeliverItemProbeCollectibleViewStyle_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDeliverItemProbeCollectibleViewStyle 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDeliverItemProbeCollectibleViewStyle_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDeliverItemProbeCollectibleViewStyle_SetValue());
			}
			return result;
		}

		// Token: 0x06009316 RID: 37654 RVA: 0x00158370 File Offset: 0x00156570
		public static IDeliverItemProbeCollectibleViewStyle Create([Nullable(2)] IDeliverItemProbeCollectibleViewStyle instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDeliverItemProbeCollectibleViewStyle
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009317 RID: 37655 RVA: 0x00158383 File Offset: 0x00156583
		public static IDeliverItemProbeCollectibleViewStyle CreateFromSetValue([Nullable(2)] IDeliverItemProbeCollectibleViewStyle_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDeliverItemProbeCollectibleViewStyle
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009318 RID: 37656 RVA: 0x00158396 File Offset: 0x00156596
		public IDeliverItemProbeCollectibleViewStyle_SetValue ToSetValue()
		{
			return new IDeliverItemProbeCollectibleViewStyle_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002F00 RID: 12032
		// (get) Token: 0x06009319 RID: 37657 RVA: 0x001583A9 File Offset: 0x001565A9
		// (set) Token: 0x0600931A RID: 37658 RVA: 0x001583D4 File Offset: 0x001565D4
		public virtual EDeliverItemProbeCollectibleViewStyle Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EDeliverItemProbeCollectibleViewStyle.HandInItemStyle;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005B7F RID: 23423
		[Nullable(2)]
		protected IDeliverItemProbeCollectibleViewStyle FbInstance;

		// Token: 0x04005B80 RID: 23424
		[Nullable(2)]
		protected IDeliverItemProbeCollectibleViewStyle_SetValue PocoInterface;
	}
}
